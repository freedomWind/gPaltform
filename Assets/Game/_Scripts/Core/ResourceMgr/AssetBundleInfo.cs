using UnityEngine;
using System.Collections.Generic;
using SimpleFramework.Game;
using System.IO;

namespace SimpleFramework
{
    public class AssetBundleInfo
    {
        public static string assetPath_server      //服务器资源地址
        {
            get { return "D:\\WORK\\NewProgram\\ARGame\\abRes\\"+curPlatformFloder; }
         //   get { return "http://10.0.0.160/upload/" + curPlatformFloder; }
        }
        public static string assetPath_local       //本地资源地址
        {
            get { return Application.streamingAssetsPath + "/Assetbundles/"+curPlatformFloder; }
        }
        public static string manifest_name         //AssetbundleManifest name
        {
            get
            {
                return curPlatformFloder;
            }
        }
        public static string curPlatformFloder
        {
            get
            {
                if (Application.platform != RuntimePlatform.Android)
                    return "Windows";
                else
                    return Application.platform.ToString();
            }
        }


    }
    /// <summary>
    /// 
    /// </summary>
    public static class AssetBundleHelp
    {
        /// <summary>
        /// 获取AssetVersion的存放路径
        /// </summary>
        /// <returns></returns>
        public static string GetAssetVersionPath(string gamename = "")
        {
            if (gamename == "")   //全局
                return "assetVersionInfo.txt";
            return gamename + "/" + "assetVersionInfo.txt";
        }
        /// <summary>
        /// 获取abconfig的存放路径
        /// </summary>
        /// <param name="gamename"></param>
        /// <returns></returns>
        public static string GetAbConfigPath(string gamename = "")
        {
            if (gamename == "")
                return "abConfig.txt";
            else return gamename + "/" + "abConfig.txt";
        }
        /// <summary>
        /// 获取游戏资源配置路径
        /// </summary>
        /// <param name="gamename"></param>
        /// <returns></returns>
        public static string GetGameassetConfigPath(string gamename = "")
        {
            if (gamename == "")
                return "gameAssetConfig.txt";
            else return gamename + "/" + "gameAssetConfig.txt";
        }
        public static AssetVersion LoadAssetVersion(string gamename = "")
        {
            string fullpath = Path.Combine(AssetBundleInfo.assetPath_local, GetAssetVersionPath(gamename));
            string text = "";
            if (File.Exists(fullpath))
            {
                StreamReader sr = File.OpenText(fullpath);
                text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                fullpath = Path.Combine(AssetBundleInfo.curPlatformFloder, GetAssetVersionPath(gamename));
                Debug.Log("fullpath:" + fullpath);
                TextAsset ta = Resources.Load<TextAsset>(fullpath);
                if (ta == null)
                {
                    Debug.LogError("not find AssetVersionInfo at resource dir");
                    return null;
                }
                text = ta.text;
            }
            return AssetVersion.FromString(text);
        }
        public static AssetbundleConfig LoadABConfig(string gamename = "")
        {
            string fullpath = Path.Combine(AssetBundleInfo.assetPath_local, GetAbConfigPath(gamename));
            fullpath = fullpath.Replace("/", "\\");
            if (File.Exists(fullpath))
            {
                StreamReader sr = File.OpenText(fullpath);
                string text = sr.ReadToEnd();
                sr.Close();
                return AssetbundleConfig.FromStr(text);
            }
            else
            {
                fullpath = Path.Combine(AssetBundleInfo.curPlatformFloder, GetAbConfigPath(gamename));// "/abConfig";
                Debug.Log("fullpath:" + fullpath);
                TextAsset ta = Resources.Load<TextAsset>(fullpath);
                if (ta == null)
                {
                    Debug.LogError("not find abConfig at resource dir");
                    return null;
                }
                return AssetbundleConfig.FromStr(ta.text);
            }
        }
        public static GameAssetConfig LoadGameAssetConfig(string gamename = "")
        {
            string fullpath = GetGameassetConfigPath(gamename);
            fullpath = fullpath.Replace("/", "\\");
            if (File.Exists(fullpath))
            {
                StreamReader sr = File.OpenText(fullpath);
                string text = sr.ReadToEnd();
                sr.Close();
                return GameAssetConfig.FromStr(text);
            }
            else
            {
                GameAssetConfig gac = null;
                TextAsset ta = Resources.Load<TextAsset>(fullpath) as TextAsset;
                if (ta != null)
                {
                    Debug.Log("textasset config is not null:" + ta.text);
                    gac = GameAssetConfig.FromStr(ta.text);
                }
                if (gac == null)
                    Debug.LogError("GameAssetConfig file is not exsit!");
                return gac;
            }
        }

    }
    public class AssetbundleConfig
    {
        public int resourceVersion;
        Dictionary<string, string> bundleAssetsDic = new Dictionary<string, string>(); //资源名 - 包名
        public void AddAssetBundle(string assetname, string bundlename)
        {
            assetname = assetname.ToLower();
            bundlename = bundlename.ToLower();
            if (!bundleAssetsDic.ContainsKey(assetname))
                bundleAssetsDic.Add(assetname, bundlename);
        }
        public void RemoveAssetBundle(string assetname)
        {
            assetname = assetname.ToLower();
            if (bundleAssetsDic.ContainsKey(assetname))
                bundleAssetsDic.Remove(assetname);
        }
        public void ClearAssetbundleDic()
        {
            bundleAssetsDic.Clear();
        }
        public string GetBundlenameByAssetname(string assetname)
        {
            assetname = assetname.ToLower();
            if (bundleAssetsDic.ContainsKey(assetname))
                return bundleAssetsDic[assetname];
            return "";
        }
        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(resourceVersion.ToString() + "|");
            foreach (KeyValuePair<string, string> kp in bundleAssetsDic)
            {
                sb.Append(kp.Key + "&" + kp.Value + ",");
            }
            return sb.ToString();
        }

        public static AssetbundleConfig FromStr(string str)
        {
            AssetbundleConfig abc = new AssetbundleConfig();
            string[] strs = str.Split('|');
            if (strs.Length != 2)
                return null;
            int.TryParse(strs[0], out abc.resourceVersion);
            string[] table = strs[1].Split(',');
            string[] kp;
            for (int i = 0; i < table.Length; i++)
            {
                kp = table[i].Split('&');
                if (kp.Length == 2)
                    abc.AddAssetBundle(kp[0], kp[1]);
            }
            return abc;
        }
    }

}