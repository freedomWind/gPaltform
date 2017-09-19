using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFramework;
using SimpleFramework.Game;

public enum AppEvent
{
    appLog,  //log
    resLoadOver,   //资源更新完毕
    checkNeedRendering,

}
public sealed class AppFacade :Facade 
{

    #region 变量
    private static AppFacade _ins;
    public static AppFacade Ins {
        get { if (_ins == null) _ins = new AppFacade();return _ins; }
    }
    private AppFacade() :base()
    { }
    #endregion
    /// <summary>
    /// app启动
    /// 1，启动框架
    /// 2，更新app配置信息（所有资源配置信息）
    /// </summary>
    public override void StartUp()
    {
        base.StartUp();  
    }
    public void StartGame(string gname)
    {
        GetMgr<GameManager>().GetGame(gname).StartUp();
    }
}
