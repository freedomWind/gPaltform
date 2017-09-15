#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
/// <summary>
/// Unity自带了一个EditorOnly的Tag。意思就是标记过这个游戏对象，
/// 只在Editor下生效不会被最终打进包里。
/// 这一类东西，就非常适合标记成EditorOnly，但是这个Tag有个致命的缺陷-“无法预览”  
/// 因为场景的东西非常多，我们必须要很清楚的看到，那些是标记了EditorOnly的游戏对象，
/// 总不能手动的一个个找吧。
///所以有了下面的这个脚本。（挂在某个对象上即可）
/// </summary>
public class EditorOnly : MonoBehaviour
{

    [HideInInspector]
    public string tag = "Untagged";
    void OnDrawGizmos()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag(tag))
        {
            UnityEditor.Handles.Label(go.transform.position, tag);
        }
    }
}

[CustomEditor(typeof(EditorOnly))]
public class EditorOnlyEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorOnly gizmos = target as EditorOnly;
        EditorGUI.BeginChangeCheck();
        gizmos.tag = EditorGUILayout.TagField("Tag for Objects:", gizmos.tag);
        if (EditorGUI.EndChangeCheck())
        {
            EditorUtility.SetDirty(gizmos);
        }
    }
}
#endif


