using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

namespace SimpleFramework.Asset
{


    /// <summary>
    /// 游戏资源接口类
    /// 游戏资源加载 卸载 预加载 更新 实现独立和可配置
    /// </summary>
    public class GameAssets
    {

    }
    internal class AssetsLoader
    {
        protected Dictionary<string, Object> gloabalSourceDic;   //全局的 完整生命周期
        protected Dictionary<string, Object> sceneSourceDic;     //跟随场景的
        
        internal void LoadAsset(string assetname, UnityAction<Object> callback)
        { }
        void loadAb(string abname, UnityAction<Object> callback)
        { }
        internal void UpdateAssets(UnityAction<bool> callback)
        {

        }
    }
    internal class AppAssetConfig 
    {
        private AssetConfig appConfig;
        private Dictionary<string, AssetConfig> _totalAssetConfig;
        internal AppAssetConfig()
        {
            _totalAssetConfig = new Dictionary<string, AssetConfig>();
        }
        void LoadConfig()
        {
            //from local
        }
        public AssetConfig GetAssetConfig(string gamename = "")
        {
            if (gamename == "")
                return appConfig;
            AssetConfig config = null;
            _totalAssetConfig.TryGetValue(gamename, out config);
            return config;
        }
    }
    /// <summary>
    /// 资源配置文件
    /// </summary>
    public class AssetConfig
    {
        AssetVersion assetVersion;
        AssetbundleConfig abConfig;
        GameAssetConfig assetConfig;
        AssetBundleInfo abInfo;

        /// <summary>
        /// 通过资源路径名得到ab包名
        /// </summary>
        /// <param name="assetname"></param>
        /// <returns></returns>
        public string GetAbgNameByAssetname(string assetname)
        {
            return "";
        }
        private AssetBundleManifest _manifest = null;
        public AssetBundleManifest Manifest
        {
            get
            {
                if (_manifest == null)
                {
                    AssetBundle ab = AssetBundle.LoadFromFile(assetPath_local + "/" + curPlatformFloder);
                    if (ab != null) _manifest = ab.LoadAsset("AssetBundleManifest") as AssetBundleManifest;
                    if (_manifest == null) Debug.LogError("manifest wei kong");
                    ab.Unload(false);
                }
                return _manifest;
            }
        }
        public void SetManifest(AssetBundleManifest am)
        {
            _manifest = am;
        }
    }
        
}