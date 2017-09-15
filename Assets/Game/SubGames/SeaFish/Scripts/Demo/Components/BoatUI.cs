using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        AppFacade.Ins.AddListener(vBoatEvent.vBoatState, UpdateBoatState);
    }
    private void OnDestroy()
    {
        Debug.LogError("whyy");
        AppFacade.Ins.RemoveListener(vBoatEvent.vBoatState, UpdateBoatState);
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
    void UpdateBoatState(params object[] objs)
    {
        Vector3 pos = (Vector3)objs[0];
        Vector3 engel = (Vector3)objs[1];
        string str = (string)objs[2];
        if(str != "")
            WorldIndex = "世界索引："+ str;
        PosAndRotate = string.Format("当前位置 -- X:{0},Y:{1},Z:{2}\n当前朝向 -- X:{3},Y:{4},Z:{5}"
            ,pos.x,pos.y,pos.z,engel.x,engel.y,engel.z);

    }
}

