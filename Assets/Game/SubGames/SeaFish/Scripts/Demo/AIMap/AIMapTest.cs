using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AIMap;

public enum vBoatEvent
{
    vBoatState,
}
public class AIMapTest : MonoBehaviour {

    #region  test
    /*
    VWorld<Vector3> _myWorld;
    public GameObject cube;
    internal Queue<Node<Vector3>> que;
	// Use this for initialization
	void Start () {
        que = new Queue<Node<Vector3>>();
        Node<Vector3> root = new Node<Vector3>("11");
        _myWorld = VWorld<Vector3>.CreateVWorld(root, 6,5);
        Debug.Log("over!");
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.T))
        {
            string index = "11";
            Node<Vector3> V = _myWorld.FindByIndex(index);
            Debug.Log(string.Format("index = {0}, value = {1} ",index,V.point));
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            int count = 0;
            _myWorld.SearthTheWorld(_ => {

                que.Enqueue(_);
                count++;
            });


        }
        if (curTime + duration < Time.time)
        {
            if (que.Count != 0)
            {
                temp = que.Dequeue();
                if (temp != null)
                {
                    GameObject oo = GameObject.Instantiate(cube);
                    oo.transform.SetParent(_myWorld.RootTrans);
                    oo.transform.localScale = Vector3.one;
                    oo.transform.localPosition = temp.point;
                    oo.name = temp.buildIndex;

                }
                curTime = Time.time;
            }
        }
        //while(que.Count != 0)
    }
    Node<Vector3> temp = null;
    private float curTime = 0;
    float duration = 0.02f;
    */
    #endregion

    public int worldPower;
    public int mindis;
    public int renderingWorldRadius;
    public int renderingWorldBoard;

    public GameObject cube;
    RenderingWorld renderingWorld;

    public Transform trans;

    public static AIMapTest Instance;

    void Start()
    {
        Instance = this;
     //   AppFacade.Ins.AddListener(AppEvent.checkNeedRendering,)
        TheWorld.Instance.CreateWorld(worldPower, mindis);
        renderingWorld = TheWorld.Instance.CreateRenderingWorld(Vector3.zero, renderingWorldRadius, renderingWorldBoard
            ,RenderNode,DestroyNode);
        trans = renderingWorld.worldRootTrans;
    }

    void RenderNode(Node<NodeCell> n)
    {
        GameObject oo = GameObject.Instantiate(cube);
        oo.transform.SetParent(trans);
        oo.transform.localScale = Vector3.one;
        oo.transform.localPosition = n.point;
        oo.name = n.buildIndex;
        AIMap.Object obj = new AIMap.Object();
        obj.obj = oo;
        n.data.objList.Add(obj);
    }
    void DestroyNode(Node<NodeCell> n)
    {

        if (n.data.objList != null)
            foreach (var v in n.data.objList)
            {
                GameObject.DestroyImmediate(v.obj);
            }
    }
    public void CheckRenderingState(Vector3 point,out string wIndex)
    {
        wIndex = "";
        if (renderingWorld == null) return;
        if (renderingWorld.IsOutOfBoard(point))
        {
            TheWorld.Instance.CaculateRenderingWorld(renderingWorld, point, renderingWorldRadius, renderingWorldBoard,out wIndex);
            renderingWorld.Rebuild();
        }

    }
}
