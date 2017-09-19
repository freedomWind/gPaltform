using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleFramework.Event;

public class BoatUI : MonoBehaviour
{
    #region UI界面
    public Text ui_Speed;
    public Text ui_worldIndex;
    public Text ui_PosAndRotate;
    #endregion
    private void Start()
    {
        Debug.LogError("warning");
        AppFacade.Ins.GetMgr<EventManager>().AddEvent(vBoatEvent.vBoatState, UpdateBoatState);
    }
    private void OnDestroy()
    {
        Debug.LogError("whyy");
        AppFacade.Ins.GetMgr<EventManager>().RemoveEvent(vBoatEvent.vBoatState, UpdateBoatState);
    }
    public float Speed
    {
        set { ui_Speed.text = value.ToString(); }
    }
    public string WorldIndex
    {
        set {  ui_worldIndex.text = value; }
    }
    public string PosAndRotate
    {
        set { this.ui_PosAndRotate.text = value; }
    }
    void UpdateBoatState(EventArg arg)
    {
        vBoatState bs = (vBoatState)arg.obj1;
      
        if(bs.worldIndex != "")
            WorldIndex = "世界索引："+ bs.worldIndex;
        PosAndRotate = string.Format("当前位置 -- X:{0},Y:{1},Z:{2}\n当前朝向 -- X:{3},Y:{4},Z:{5}"
            ,bs.pos.x,bs.pos.y,bs.pos.z,bs.rotate.x,bs.rotate.y,bs.rotate.z);

    }
}

