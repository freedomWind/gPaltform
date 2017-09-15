using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
namespace AIMap
{
    /// <summary>
    /// vworld由一个四叉树构建
    /// 每个节点都是Node
    /// 由中心点往外递归辐射形成
    /// 实际渲染的世界以船只为中心双倍视距范围
    /// 船只行走过程中，定时向vworld汇报位置点信息，但船只行走快接近视距范围时，渲染的世界进行补充构建，同时销毁范围之外的世界
    /// 
    /// </summary>
    internal class VWorld<T> where T : new()
    {
        public Node<T> Root { get; private set; }
        public int WorldPower { get; private set; }
        public int Mindis { get; private set; }
        public Transform RootTrans { get; private set; }
        private VWorld()
        { }
        /// <summary>
        /// 构建一个根为root,幂级为power,最小单位间距为minDis的世界
        /// </summary>
        /// <param name="root"></param>
        /// <param name="power"></param>
        /// <param name="minDis"></param>
        /// <returns></returns>
        internal static VWorld<T> CreateVWorld(Node<T> root,int power,int minDis)
        {
            VWorld<T> w = new VWorld<T>();
            w.Root = root;
            w.Mindis = minDis;
            w.RootTrans = new GameObject("VWorld").transform;
            w.RootTrans.localPosition = Vector3.zero;
            w.WorldPower = power;
            w.Root.diameter = (int)(minDis * Mathf.Pow(2, power));
            Node<T>.Build(root, power);
            return w;
        }
        internal Node<T> FindByIndex(string index)
        {
            if (WorldPower < index.Length)
            {
                Debug.LogError("索引已经超出世界");
                return null;
            }
            char[] arr = index.ToCharArray();
            int i = 0;
            char ch = arr[0];
            Node<T> temp = Root;
            while (i < arr.Length)
            {
                if (ch == '1')
                    temp = temp.uL;
                else if (ch == '2')
                    temp = temp.uR;
                else if (ch == '3')
                    temp = temp.dR;
                else if (ch == '4')
                    temp = temp.dL;
                else
                {
                    Debug.LogError("FindByIndex输入的参数不正确");
                    return null;
                }
                if (temp == null)
                {
                    Debug.LogError("索引已经超出世界");
                    return null;
                }
                i++;
            }
            return temp;
        }
        internal Node<T> FindByLocation(Vector3 point)
        {
            if (point.x < Root.point.x - Root.diameter / 2 || point.x > Root.point.x + Root.diameter/2)
                return null;
            if (point.z < Root.point.z - Root.diameter / 2 || point.z > Root.point.z + Root.diameter / 2)
                return null;
            return isInNode(Root, point);
        }
        internal void SearthTheWorld(System.Action<Node<T>> action = null)
        {
            Node<T>.Search(Root, action);
        }
        Node<T> isInNode(Node<T> node,Vector3 point)
        {
            //if (point.x < node.point.x - node.diameter / 2||point.x > node.point.x + 2/node.diameter)
            //    return null;
            //if (point.z < node.point.z - node.diameter / 2 || point.z > node.point.z + node.diameter / 2)
            //    return null;
            if (node.uL == null && node.uR == null && node.dL == null && node.dR == null)
                return node;
            else
            {
                if (point.x <= node.point.x)
                {
                    if (point.z <= node.point.z)
                        return isInNode(node.uL, point);
                    else
                        return isInNode(node.dL, point);
                }
                else
                {
                    if (point.z <= node.point.z)
                        return isInNode(node.uR, point);
                    else
                       return isInNode(node.dR, point);
                }
                //Debug.Log("wo bu xin");
                //return null;
            }
        }
    }

    public partial class Node<T> where T:new()
    {
        public int diameter;
        public T data { get; private set; }
        public Vector3 point;      
        public string buildIndex { get; private set; }  //构建而成的索引
        private Node<T> _uL;
        private Node<T> _uR;
        private Node<T> _dL;
        private Node<T> _dR;
        public Node(string buildIndex)
        {
            this.data = new T();
            this.buildIndex = buildIndex;
            _dL = null;
            _uR = null;
            _dL = null;
            _dR = null;
        }
        public Node<T> uL
        {
            get { return _uL; }
            private set
            {
                _uL = value;
                _uL.diameter = diameter / 2;
                _uL.point = new Vector3(point.x - diameter/4, 0, point.z - diameter/4);
            }
        }
        public Node<T> uR
        {
            get { return _uR; }
            private set
            {
                _uR = value;
                _uR.diameter = diameter / 2;
                _uR.point = new Vector3(point.x + diameter/4, 0, point.z - diameter/4);
            }
        }
        public Node<T> dL
        {
            get { return _dL; }
            private set
            {
                _dL = value;
                _dL.diameter = diameter / 2;
                _dL.point = new Vector3(point.x - diameter/4, 0, point.z + diameter/4);
            }
        }
        public Node<T> dR
        {
            get { return _dR; }
            private set
            {
                _dR = value;
                _dR.diameter = diameter / 2;
                _dR.point = new Vector3(point.x + diameter/4, 0, point.z + diameter/4);
            }
        }
        
    }
    /// <summary>
    /// 对应的静态方法
    /// </summary>
    /// <typeparam name="T"></typeparam>
    partial class Node<T>
    {
        public static void Build(Node<T> root, int power)
        {
            if (power <= 0)
            {
                root._uL = root._uR = root._dL = root._dR = null;
                return;
            }
            Node<T> t1 = new Node<T>(root.buildIndex + "1");
            Node<T> t2 = new Node<T>(root.buildIndex + "2");
            Node<T> t3 = new Node<T>(root.buildIndex + "3");
            Node<T> t4 = new Node<T>(root.buildIndex + "4");
            root.uL = t1; root.uR = t2; root.dR = t3; root.dL = t4;
            int p1, p2, p3, p4;
            p1 = p2 = p3 = p4 = power;
            Build(root.uL, --p1);
            Build(root.uR, --p2);
            Build(root.dR, --p3);
            Build(root.dL, --p4);
        }
        public static void Search(Node<T> root, System.Action<Node<T>> action = null)
        {
            searchAction = action;
            Search(root);
        }
        private static System.Action<Node<T>> searchAction = null;
        static void Search(Node<T> root)
        {
            if (root.uL == null && root.uR == null && root.dL == null && root.dR == null)
            {
                if (searchAction != null) searchAction(root);
                return;
            }
            Search(root.uL);
            Search(root.uR);
            Search(root.dL);
            Search(root.dR);
        }
    }
}
