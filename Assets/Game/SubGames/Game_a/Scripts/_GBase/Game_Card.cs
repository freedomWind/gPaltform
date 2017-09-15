using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFramework;
using SimpleFramework.Game;
using System;

public class Game_Card :IGameBase
{
    public Game_Card(GameType type, string name) : base(type, name) { }
    protected override string[] sceneName
    {
        get
        {
            return new string[] {"Card"};
        }
    }
}
