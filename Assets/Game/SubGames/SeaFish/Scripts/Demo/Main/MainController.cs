using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFramework;
using SimpleFramework.Event;

public class MainController :Controller
{
    protected override void AddViewListenner()
    {
        base.AddViewListenner();
        AddListener(MainControllView.vEvent.vDoSkill, OnSkillFire);
    }

    void OnSkillFire(EventArg arg)
    {
        string sname = (string)arg.obj1;
        Debug.Log("skill fire = "+sname);
        switch (sname)
        {
          //  case 
        }
    }
}
