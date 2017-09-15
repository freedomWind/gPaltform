using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Bulletting : MonoBehaviour {

    [SerializeField]
    private Text _messageTxt;
    const float _duration = 16f;
    // Use this for initialization
    void Start () {
        BullettingAnimation();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        _messageTxt.rectTransform.DOKill();
    }

    //todo 距离稍后改成从UI获取应该Rect.width + text.width
    public void BullettingAnimation()
    {
        _messageTxt.rectTransform.DOLocalMoveX(-570f, _duration).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}
