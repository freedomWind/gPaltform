using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;
using System;
using UnityEngine.AI;

namespace SimpleFramework.Game
{
    //游戏类型
    public enum GameType
    {
        none,
        type1,
        type2,
        type3,
    }
    //游戏枚举
    public class GameEnum
    {
        public const string mainLobby = "game_mainLobby";
        public const string SeaFish = "game_SeaFish";
        public const string DYZP = "game_Card";  //大冶字牌
        public const string b = "game_b";
        public const string c = "game_c";
        public const string d = "game_d";
        public const string e = "game_e";
        public const string f = "game_f";
        public const string g = "game_g";
        public const string h = "game_h";
        public const string i = "game_i";

    }
    /// <summary>
    /// 每一个游戏demo对应一个gamebase
    /// </summary>
    public abstract class IGameBase
    {
        static string preGameName = "";
        internal static IGameBase NowActiveGame = null;
        protected GameType gType { get; private set; }             //游戏类型
        protected readonly string gameName;                         //游戏名称
        protected abstract string[] sceneName { get; }             //游戏场景
        public IGameBase(GameType type, string name)
        {
            gType = type;
            this.gameName = name;
            RegiestScene();
        }
        //加载游戏内场景
        void LoadScene(string name)
        {
            AppFacade.Ins.GetMgr<SceneMgr>().LoadScene(name);
        }
        //场景状态注册
        void RegiestScene()
        {
            string typeName = "";
            Assembly assembly = Assembly.GetExecutingAssembly();
            object[] param = new object[1];
            param[0] = SceneMgr.mController;
            for (int i = 0; i < sceneName.Length; i++)
            {
                typeName = "Scene_" + sceneName[i];
                object oo = assembly.CreateInstance(typeName,true,BindingFlags.Default,null,param,null,null);
                if (oo == null)
                    AppFacade.Ins.GetMgr<SceneMgr>().RegiestScene(sceneName[i], new ISceneState(SceneMgr.mController));
                else
                {
                    AppFacade.Ins.GetMgr<SceneMgr>().RegiestScene(sceneName[i], (ISceneState)oo);
                }
            }
        }
        void UnRegiestScene()
        {
            for (int i = 0; i < sceneName.Length; i++)
            {
                AppFacade.Ins.GetMgr<SceneMgr>().UnRegiestScene(sceneName[i]);
            }
        }
        //返回上一个游戏
        public void GoBack()
        {
            if (preGameName != "")
                AppFacade.Ins.GetMgr<GameManager>().GetGame(preGameName).StartUp();
        }
        //加载游戏内场景
        public void LoadScene(int index)
        {
            if (index < 0 || index > sceneName.Length - 1)
            {
                Debug.LogError("load scene is out of arry");
                return;
            }
            LoadScene(sceneName[index]);
        }
        /// <summary>
        /// 启动游戏
        /// 卸载之前的游戏
        /// </summary>
        /// <param name="param"></param>
        internal void StartUp(object param = null)
        {
            if (this == NowActiveGame) return;
            else if (NowActiveGame != null) NowActiveGame.UnLoad();          
            //   else  NowActiveGame?.UnLoad();    //unity版本得支持c#4.0以上
            NowActiveGame = this;
            LoadScene(0);
            OnStartUp(param);
            Debug.Log("启动游戏" + gameName);    
        }
        //启动回调
        protected virtual void OnStartUp(object param = null)
        {

        }
        //卸载
        internal void UnLoad()
        {
            preGameName = gameName;
            Debug.Log("卸载游戏" + gameName);
            UnRegiestScene();
            OnUnLoad();
        }
        //卸载回调
        protected virtual void OnUnLoad()
        {
        }
    }
}
