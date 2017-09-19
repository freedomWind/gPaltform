using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using SimpleFramework.Game;

namespace SimpleFramework
{
    public class ISceneState 
    {
        //状态名称
        private string m_StateName = "ISceneState";
        public string StateName
        {
            get { return m_StateName; }
            set { m_StateName = value; }
        }
        //控制者
        protected SceneStateController m_Controller = null;

        //建造者
        public ISceneState(SceneStateController Controller) : base()
        {
            m_Controller = Controller;
        }

        //开始
        public virtual void StateBegin()
        {
            //通过配置的功能加载
        }

        //结束
        public virtual void StateEnd()
        {
        }

        public virtual void StateUpdate()
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                GameManager.NowRunnigGame.GoBack();
            }
        }

        public override string ToString()
        {
            return string.Format("[I_SceneState: StateName = {0}", StateName);
        }
    }
    public class SceneStateController :IFrameUpdate
    {
        public enum mEvent
        {
            readySwitchNotify,  //开始切换
            switchOverNotify,  //切换完成
        }
        private AsyncOperation m_async;
        private ISceneState m_State;

        private float m_MinLoadingTime = 1f; //切换场景最短时间

        public SceneStateController()
        {
            FrameUpdateManager.Instance.AddFrame(this);
        }

        public void UpdateDo(float deltaTime)
        {
            StateUpdate();
        }

        //设置状态
        public void SetState(ISceneState State, string loadSceneName)
        {
            if (loadSceneName != "")
                LoadScene(loadSceneName);
            if (m_State != null)
            {
                m_State.StateEnd();
            }
            m_State = State;
        }

        private void LoadScene(string loadSceneName)
        {
          //  AppFacade.Ins.Dispath(mEvent.readySwitchNotify, loadSceneName);
            Debug.Log("开始切换场景：" + loadSceneName);
            LoadingView.loadingScene = loadSceneName;
            LoadingView.OnLoadingOver = OnLoadOver;
            SceneManager.LoadScene("loading");
        }
        void OnLoadOver(object param)
        {
            if (m_State != null)
                m_State.StateBegin();
        }
        void StateUpdate()
        {
            if (m_State != null)
                m_State.StateUpdate();
        }
    }
}