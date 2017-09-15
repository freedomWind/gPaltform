using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMono : MonoBehaviour {
    /// <summary>
    /// 延迟特定时间执行
    /// </summary>
    /// <param name="time"></param>
    /// <param name="action"></param>
    /// <param name="param"></param>
    public void DelayExcute(float time, System.Action<object> action, object param = null)
    {
        StartCoroutine(DelaySometimeExcute(time, action, param));
    }
    /// <summary>
    /// 延迟一帧执行
    /// </summary>
    /// <param name="action"></param>
    /// <param name="param"></param>
    public void DelayExcute(System.Action<object> action, object param = null)
    {
        StartCoroutine(DelayOneframeExcute(action, param));
    }
    #region 协程封装
    /// <summary>
    /// 延迟执行
    /// </summary>
    /// <param name="time"></param>
    /// <param name="action"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    static IEnumerator DelaySometimeExcute(float time, System.Action<object> action, object param)
    {

        yield return new WaitForSeconds(time);
        action(param);
    }
    static IEnumerator DelayOneframeExcute(System.Action<object> action, object param)
    {
        yield return null;
        action(param);
    }
    #endregion
}
