﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFramework;
namespace SimpleFramework.Game
{
    /// <summary>
    /// 游戏管理器 
    /// 负责游戏之间的切换
    /// </summary>
    internal class GameManager
    {
        #region  // private
        Dictionary<string, IGameBase> gameDic;
        public GameManager()
        {
            gameDic = new Dictionary<string, IGameBase>();
            gameDic.Add(GameEnum.mainLobby, new Game_MainLobby(GameType.none, GameEnum.mainLobby));
            gameDic.Add(GameEnum.SeaFish, new Game_SeaFish(GameType.none, GameEnum.SeaFish));  //每新增加一个游戏 需在此声明一次
            gameDic.Add(GameEnum.DYZP, new Game_Card(GameType.none, GameEnum.DYZP));
            //gameDic.Add(GameEnum.b, new Game_b(GameType.NonAR, GameEnum.b));
            //gameDic.Add(GameEnum.c, new Game_c(GameType.NonAR, GameEnum.c));
            //gameDic.Add(GameEnum.d, new Game_d(GameType.NonAR, GameEnum.d));
            //gameDic.Add(GameEnum.e, new Game_e(GameType.NonAR, GameEnum.e));
            Debug.Log("游戏管理器初始化");
          //  AppFacade.Ins.Log(BugType.log, "游戏管理器初始化");
        }
        #endregion
        //当前正在运行的游戏
        public static IGameBase NowRunnigGame
        {
            get
            {
                return IGameBase.NowActiveGame;
            }
        }
        public IGameBase GetGame(string gname)
        {
            IGameBase gbase = null;
            gameDic.TryGetValue(gname, out gbase);
            return gbase;
        }
    }
}
