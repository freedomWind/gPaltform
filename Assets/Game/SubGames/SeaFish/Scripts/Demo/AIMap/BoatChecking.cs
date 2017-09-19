using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using SimpleFramework.Event;

public class BoatChecking : MonoBehaviour {

    public float checkDuration = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
    float curTime = 0;
	// Update is called once per frame
	void Update () {
        if (curTime + checkDuration < Time.time)
        {
            curTime = Time.time;
            string wIndex = "";
            AIMapTest.Instance?.CheckRenderingState(transform.localPosition,out wIndex);
            //AppFacade.Ins.Dispath(vBoatEvent.vBoatState, new object[] { transform.localPosition, transform.localEulerAngles, wIndex });   //往外更新信息
            AppFacade.Ins.GetMgr<EventManager>().Dispath(new EventArg(vBoatEvent.vBoatState, new vBoatState(transform.localPosition, transform.localEulerAngles, wIndex)));
        }
	}
}

