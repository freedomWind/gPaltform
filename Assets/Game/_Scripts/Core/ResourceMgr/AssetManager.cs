using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SimpleFramework.Asset
{
    /// <summary>
    /// 资源管理
    /// </summary>
    public class AssetManager
    {
        private AppAssetConfig appassetConfig;
        /// <summary>
        /// 更新资源配置文件
        /// 一次性更新全部配置文件
        /// </summary>
        public void PullAssetsConfig()
        {

        }
        /// <summary>
        /// 向服务器拉取对应游戏资源
        /// </summary>
        /// <param name="gamename">游戏名次，如果为空，则拉取app资源</param>
        /// <param name="overDel">结果回调</param>
        public void PullAssets(string gamename = "",UnityAction<bool> overDel = null)
        {

        }

    }
}
