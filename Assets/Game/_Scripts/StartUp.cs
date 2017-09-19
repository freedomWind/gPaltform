using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleFramework;
using SimpleFramework.Game;

public class StartUp : MonoBehaviour {

    public string serAddr;
    public string serPort;
    public Text tipArea;
    public float startMovieTime;  //启动视频的时长
    private AppMovie startMovie;
    void Awake()
    {
        AppConst.serPort = serAddr;
        AppConst.serPort = serPort;
    }

	// Use this for initialization
	void Start () {
        startMovie = new AppMovie(startMovieTime);   //播放开始动画
        startMovie.Play(_ =>
        {
            isMovieOver = true;
            OnLoadOver();
        });
        AppFacade.Ins.StartUp();   //启动框架    
        AppFacade.Ins.GetMgr<ResourceManager>().UpdateAssets(OnResLoadOver);     
    }

    void UpdateTips(params object[] objs)
    {
        if (objs.Length == 2)
        {
            BugType bt = (BugType)objs[0];
            string msg = (string)objs[1];
            if (tipArea != null)
                tipArea.text += msg+"\n";
        }
    }

    bool isMovieOver = false;
    bool isResLoadOver = false;
    void OnLoadOver()
    {
        if (isMovieOver && isResLoadOver)
            AppFacade.Ins.StartGame(GameEnum.mainLobby);
    }
    void OnResLoadOver(bool result)
    {
        isResLoadOver = result;
        if (!isResLoadOver) Debug.LogError("res down load error");
        OnLoadOver();
    }
}

/// <summary>
/// 启动movie
/// 资源必须放在streamAssets下面
/// </summary>
public class AppMovie
{
  //  private MovieTexture _mTex;
    private float movieTime;
    private bool _init;
    public AppMovie(float time)
    {
        movieTime = time;
        //AppFacade.Ins.GetMgr<ResourceManager>().LoadAsset("startMovie", (Object obj) =>
        //{
        //    if (AppConst.IsPcPlat)
        //    {
        //        if (obj != null)
        //        {
        //            _mTex = obj as MovieTexture;
        //        }
        //    }
        //});
    }

    public void Play(System.Action<object> theEnd)
    {
        AppFacade.Ins.gMono.DelayExcute(movieTime, theEnd);
        if (AppConst.IsPcPlat)
        {
            //if (_mTex != null)
            //{
            //    _mTex.Play();
            //    _mTex.loop = true;
            //}
        }
    }
}