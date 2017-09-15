using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using SimpleFramework;
using System;
using SimpleFramework.Game;

public class MainLobby : BaseView
{
    class BtnNames
    {
        public const string BackBtn = "Setting";
        public const string CreateBtn = "CreateBtn";
    }
   // [SerializeField]
    public Button[] Btns;
    public Transform CreatePanel;
    public Transform TempUINode;
    public Transform UIPoolNode;

    protected override void OnClicked(Button sender)
    {
        base.OnClicked(sender);
        string name = sender.name;
        switch (name)
        {
            case BtnNames.BackBtn:
                GameManager.NowRunnigGame.GoBack();
                break;
            case BtnNames.CreateBtn:
                CreatePanel?.SetParent(TempUINode);
                CreatePanel?.gameObject.SetActive(true);
                break;
        }
    }
    protected override void InitBtns()
    {
        mbtns = Btns;
    }

}
