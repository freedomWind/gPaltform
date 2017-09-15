using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LauguageTool 
{
    //[MenuItem("Tools/Lauguage/ToJson")]
    //public static void ToJsonFromXml()
    //{
    //    LauguageData.TurnXmlToJson(Application.streamingAssetsPath + "/languageConfig.xml", Application.streamingAssetsPath + "/languageConfig.json");
    //}
    [MenuItem("Tools/Lauguage/ToExcelFromJson")]
    public static void ToExcelFromJson()
    {
        string jpath = Application.streamingAssetsPath + "/languageConfig.json";
        string epath = Application.streamingAssetsPath + "/configExcel.xlsx";
        TextData td = LauguageData.ReadDataFromJsonPath(jpath);
        string[] titles = new string[4] {"索引","简体中文", "繁体中文", "英文" };
        if (td != null)
        {
            ExcelTool.ToExcelFromArrList(titles, td.ToDic(), epath);
            Debug.Log("successed!");
        }
        else
            Debug.LogError("to excel fromJson error");
    }
    [MenuItem("Tools/Lauguage/ToJsonFromExcel")]
    public static void ToJsonFromExcel()
    {
        string epath = Application.streamingAssetsPath + "/configExcel.xlsx";
        string jpath = Application.streamingAssetsPath + "/languageConfig_new.json";
        TextData td = null;
        Dictionary<string,string[]> dic = ExcelTool.ToArrayListFromExcel(epath);
        if (dic != null)
        {
           td = TextData.FromDic(dic);
        }
        if (td != null)
        {
            if (System.IO.File.Exists(jpath))
                System.IO.File.Delete(jpath);
            LauguageData.SerializeToJson(td, jpath);
            Debug.Log("success! Repalce the file Resource/languageConfig.json with file languageConfig_new.json,and renamed languageConfig.json");
            return;
        }
        Debug.LogError("To json from Excel error");
    }
}