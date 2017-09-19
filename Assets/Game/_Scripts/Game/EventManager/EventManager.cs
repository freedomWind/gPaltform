using SimpleFramework;
namespace SimpleFramework.Event
{
    /// <summary>
    /// 事件管理器 
    /// 维护整个事件系统
    /// </summary>
    internal class EventManager
    {
        GlobalEntity globalEntity;
        GlobalEntity nowGameEntity;
        public EventManager()
        {
            globalEntity = new GlobalEntity();
            nowGameEntity = new GlobalEntity();
            AddEvent(eApp.eOverUnLoadGame, onGameUnload, true);
        }
        internal void Dispath(EventArg arg,bool isGlobal = false)
        {
            if (isGlobal)
                globalEntity.Dispath(arg);
            else
                nowGameEntity?.Dispath(arg);
        }
        internal void AddEvent(System.Enum eID, EventDel del,bool isGlobal = false)
        {
            if (isGlobal)
                globalEntity.AddListener(eID, del);
            else
                nowGameEntity?.AddListener(eID, del);
        }
        internal void RemoveEvent(System.Enum eID, EventDel del, bool isGlobal = false)
        {
            if (isGlobal)
                globalEntity.RemoveListener(eID, del);
            else
                nowGameEntity.RemoveListener(eID, del);
        }
        void onGameUnload(EventArg arg)
        {
            nowGameEntity.Clear();
        }
    }
    public enum eApp
    {
        eReadyLoadGame,  //准备切换游戏
        eOverLoadGame,  //游戏切换完毕
        eOverUnLoadGame, //游戏卸载完毕
    }
        
}
