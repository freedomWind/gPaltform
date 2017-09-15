using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFramework;

public class Scene_SeaFish : ISceneState
{
    public Scene_SeaFish(SceneStateController controller) : base(controller)
    {
        //大冶字牌快速开始 充值特惠 选项 创建房间 玩法简介 选择局数 6局 消耗1个闪钥 AA开房 您当前拥有6个闪钥 躺着赚钱，稳赢不输
    }

    public override void StateBegin()
    {
        base.StateBegin();
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/fangyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //      //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/denglongyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/dianmanyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/dinianyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/haigui", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/hetun", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/jianyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/jinqiangyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        ////AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/shayu", (Object obj) =>
        ////{
        ////    if (obj == null) Debug.LogError("res load error");
        ////    else
        ////    {
        ////        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        ////        //  oo.name = "fangyu";
        ////    }
        ////});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/shiziyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/tianshiyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/xiaochouyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/xiaohuangyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("fishFbx/xiaolvyu", (Object obj) =>
        //{
        //    if (obj == null) Debug.LogError("res load error");
        //    else
        //    {
        //        GameObject oo = GameObject.Instantiate(obj) as GameObject;
        //        //  oo.name = "fangyu";
        //    }
        //});
    }

    public override void StateEnd()
    {
        base.StateEnd();
        Debug.Log("i'm scene_seafish stateEnd");
    }
}
