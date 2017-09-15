using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFramework;


public class MainController :Controller
{
    protected override void AddViewListenner()
    {
        base.AddViewListenner();
        AddListener(MainControllView.vEvent.vDoSkill, OnSkillFire);
    }

    void OnSkillFire(params object[] objs)
    {
        string sname = (string)objs[0];
        Debug.Log("skill fire = "+sname);
        switch (sname)
        {
          //  case 
        }
    }
}
