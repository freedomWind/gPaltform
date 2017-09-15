using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace AIMap
{ 
    public class TheWorld 
    {
        static AIMap.VWorld<NodeCell> theWorld;
        private static TheWorld _ins;
        public static TheWorld Instance
        {
            get {
                if (_ins == null) _ins = new TheWorld();
                return _ins;
            }
        }
        private TheWorld()
        {

        }

        public void CreateWorld(int power,int mindis)
        {
            if (theWorld != null)
            {
                Debug.LogError("theWorld has been Created. If you want to Create A new , excute Destroy First");
            }
            Node<NodeCell> root = new Node<NodeCell>("0");
            root.point = Vector3.zero;
            theWorld = VWorld<NodeCell>.CreateVWorld(root,power,mindis);
        }

        public void Destroy()
        {
            if (theWorld == null)
                return;
            else
                theWorld = null;
            System.GC.Collect();
        }

        /// <summary>
        /// 构建一个渲染世界
        /// 视线容错范围为(m - n)*mindis
        /// </summary>
        /// <param name="index">起始索引</param>
        /// <param name="mWorldMindis">最大半径</param>
        /// <param name="nWorldMindis">边界半径，超过边界后触发重新渲染</param>
        /// <returns></returns>
        public RenderingWorld CreateRenderingWorld(Vector3 rootPoint,int mWorldMindis,int nWorldMindis,System.Action<Node<NodeCell>> renderAction, System.Action<Node<NodeCell>> destroyAction)
        {
            Node<NodeCell> nc = theWorld.FindByLocation(rootPoint);
            if (nc == null)
            {
                Debug.LogError("renderingWorld Root is null"); return null;
            }
            else Debug.Log("rendering root = " + nc.buildIndex + " point = " + nc.point);
            List<Node<NodeCell>> nodeArr = GetRenderingNodesByPoint(nc, mWorldMindis);
            if (nodeArr == null) return null;
            RenderingWorld rw = new RenderingWorld(nodeArr, getBoard(nc,nWorldMindis)
                ,renderAction,destroyAction);
            return rw;
        }
        public List<Node<NodeCell>> GetRenderingNodesByPoint(Node<NodeCell> root,int mWorldMindis)
        {
            List<Vector3> pointList = new List<Vector3>();
            Vector3 startPoint = new Vector3(root.point.x - mWorldMindis * theWorld.Mindis, 0, root.point.z - mWorldMindis * theWorld.Mindis);
            for (int i = 0; i < 2 * mWorldMindis; i++)
                for (int j = 0; j < 2 * mWorldMindis; j++)
                {
                    Vector3 p = startPoint + new Vector3(j * theWorld.Mindis, 0, i * theWorld.Mindis);
                    pointList.Add(p);
                }

            List<Node<NodeCell>> nodeArr = new List<Node<NodeCell>>();
            pointList.ForEach(_ =>
            {
                Node<NodeCell> node = theWorld.FindByLocation(_);
                if (node != null)
                {
                    if (node != null)
                    {
                        nodeArr.Add(node);
                    }
                }
            });
            return nodeArr;
        }
        /// <summary>
        /// 通过当前位置找到对应的索引
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public string FindIndexByLocation(Vector3 point)
        {
            return FindNodeByLocation(point)?.buildIndex;
        }
        public Node<NodeCell> FindNodeByLocation(Vector3 point)
        {
            return theWorld.FindByLocation(point);
        }
        /// <summary>
        /// 重新渲染当前世界
        /// </summary>
        /// <param name="theRendering"></param>
        /// <param name="point"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="pointIndex">返回当前的点所在的世界索引</param>
        public void CaculateRenderingWorld(RenderingWorld theRendering, Vector3 point, int m,int n,out string pointIndex)
        {
            pointIndex = "";
            Node<NodeCell> root = FindNodeByLocation(point);
            pointIndex = root.buildIndex;
            List<Node<NodeCell>> tempList = GetRenderingNodesByPoint(root, m);          
            theRendering.ReCaculate(tempList, getBoard(root, n));
        }
        Vector4 getBoard(Node<NodeCell> node,int n)
        {
            return new Vector4(node.point.x - n * theWorld.Mindis, node.point.z - n * theWorld.Mindis, node.point.x + n * theWorld.Mindis, node.point.z + n * theWorld.Mindis);
        }
    }
    public class TestExplain
    {

        void Test(Dictionary<string,Node<NodeCell>> d1, Dictionary<string, Node<NodeCell>> d2)
        {
         //   d1.Union<>
        }
        void Test2(List<string> t1, List<string> t2)
        {
            t1.AddRange(t2);
         //   t1.Union
        }

        //创建并绘制渲染的世界
        //船只行走ing
        //隔断时间检测一下是否超出边界
        //超出 则请求服务器计算
        //服务器根据位置计算出当前索引位置 结合当前渲染世界的边界信息 计算出即将要渲染的世界单元和即将要被销毁的世界单元
        //将结果返回渲染的世界
        //渲染的世界收到结果后进行补充构建
    }
    public class RenderingWorld
    {
        public Transform worldRootTrans { get; private set; }
        #region
        Vector4 _board;
        Dictionary<string,Node<NodeCell>> _renderingNodes;
        Queue<Node<NodeCell>> _willRendering;
        Queue<Node<NodeCell>> _willDestroying;
        System.Action<Node<NodeCell>> _RenderDel;
        System.Action<Node<NodeCell>> _DestroyDel;
        #endregion 

        internal RenderingWorld(ICollection<Node<NodeCell>> RenderingNodes,Vector4 board,System.Action<Node<NodeCell>> renderAction,System.Action<Node<NodeCell>> destroyAction)
        {
            if (worldRootTrans == null)
            {
                worldRootTrans = new GameObject("world_rendering").transform;
            }
            _board = board;
            _renderingNodes = new Dictionary<string, Node<NodeCell>>();
            _willRendering = new Queue<Node<NodeCell>>();
            _willDestroying = new Queue<Node<NodeCell>>();
            _RenderDel = renderAction;
            _DestroyDel = destroyAction;
            StartBuild(RenderingNodes);
        }

        void StartBuild(ICollection<Node<NodeCell>> RenderingNodes)
        {
            foreach (var v in RenderingNodes)
            {
                RenderNode(v);
            }
        }
        public void Rebuild()
        {
            Rendering();
            Destroying();

        }
        public void ReCaculate(List<Node<NodeCell>> newNodes,Vector4 board)
        {
            foreach (var v in newNodes)
            {
                if (!_renderingNodes.ContainsKey(v.buildIndex))
                    _willRendering.Enqueue(v);
            }
            foreach (KeyValuePair<string, Node<NodeCell>> kp in _renderingNodes)
            {
                if (!newNodes.Exists(_ => _.buildIndex == kp.Key))
                {
                    _willDestroying.Enqueue(kp.Value);
                }
            }
            _board = board;
        }
        public bool IsOutOfBoard(Vector3 point)
        {
            if (point.x > _board.x && point.z > _board.y && point.x < _board.z && point.z < _board.w)
                return false;
            return true;
        }  
        #region  private
        void Rendering()
        {            
            Node<NodeCell> node = _willRendering.Dequeue();
            while (_willRendering.Count != 0)
            {
                RenderNode(node);
                node = _willRendering.Dequeue();
            }
        }
        void RenderNode(Node<NodeCell> node)
        {
            _renderingNodes.Add(node.buildIndex, node);
            //how to rendering
            if (_RenderDel != null)
                _RenderDel(node);
        }
        void Destroying()
        {
            Node<NodeCell> node = _willDestroying.Dequeue();
            while (_willDestroying.Count != 0)
            {
                DestroyNode(node);
                node = _willDestroying.Dequeue();
            }
        }
        void DestroyNode(Node<NodeCell> node)
        {
            _renderingNodes.Remove(node.buildIndex);
            //
            //how to destroy
            if (_DestroyDel != null)
                _DestroyDel(node);

        }
        #endregion
    }

    public class NodeCell
    {
        public List<Object> objList;
        public NodeCell()
        {
            objList = new List<Object>();
        }
    }

    public class Object
    {
        public string id { get; }   //物体的唯一标识符
        public string nickName;     //物体昵称
        public UnityEngine.Object obj;
        public Vector3 pos;              
        public Vector3 enguler;
        public Vector3 scale;
    }
}