using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleFramework.Game;
using SimpleFramework;
using UnityEngine.UI;
using DG.DemiLib;
using Joystick = UnityStandardAssets.CrossPlatformInput.Joystick;
using System;

partial class MainControllView
{
    public int BoatMoveSpeed = 6;
    public int BoatTurnSpeed = 30;
    public enum vEvent
    {
        vDoSkill,
    }
    class SkillBtns
    {
        public const string skill1 = "skill1Btn";
        public const string skill2 = "skill2Btn";
        public const string skill3 = "skill3Btn";
        public const string skill4 = "skill4Btn";
    }
    /// <summary>
    /// 船只移动
    /// </summary>
    class BoatMove
    {
        Transform boatTrans;
        public int raduis = 100;
        public int MaxSpeed = 4;    //最大速度  米/秒
        public int MaxTurnRate = 30; //最大转速  角度/秒
        public BoatMove(Transform trans)
        {
            this.boatTrans = trans;
        }

        float moveOffset;
        float turnOffset;
        /// <summary>
        /// 每0.02s执行一次
        /// </summary>
        public void FixedUpdate(Vector2 offset)
        {
            moveOffset = MaxSpeed * 0.02f * offset.y / raduis;
            turnOffset = MaxTurnRate * 0.02f * offset.x / raduis;
            boatTrans.Translate(new Vector3(0, 0, moveOffset), Space.Self);
            boatTrans.Rotate(Vector3.up, turnOffset);
        }
    }
}
public partial class MainControllView:BaseView
{
    Transform _boat;
    Transform _skill;
    BoatMove boatMove;
    protected override void InitBtns()
    {
        mbtns = new Button[5];
        for (int i = 0; i < _skill.childCount; i++)
        {
            mbtns[i] = _skill.GetChild(i).GetComponent<Button>();
        }
        mbtns[4] = GameObject.Find("BackBtn").GetComponent<Button>();
    }
    protected override void Awake()
    {
        SetEntity(ControllerManager.GetController<MainController>());
        _boat = GameObject.Find("Boat").transform;
        _skill = GameObject.Find("SkillTrans").transform;

        _skill.GetChild(0).gameObject.name = SkillBtns.skill1;
        _skill.GetChild(1).gameObject.name = SkillBtns.skill2;
        _skill.GetChild(2).gameObject.name = SkillBtns.skill3;
        _skill.GetChild(3).gameObject.name = SkillBtns.skill4;
        Joystick js = GameObject.Find("Joystick").GetComponentInChildren<Joystick>();
        js.joystickMoveDel = Move;
        Transform boat = GameObject.Find("Boat").transform;
        boatMove = new BoatMove(boat);
        boatMove.MaxSpeed = this.BoatMoveSpeed;
        boatMove.MaxTurnRate = this.BoatTurnSpeed;
        base.Awake();       
    }
    /// <summary>
    /// 船只移动
    /// </summary>
    /// <param name="offset"></param>
    void Move(bool isMove, Vector2 offset)
    {
        isMoving = isMove;
        this.offset = offset;
    }
    bool isMoving = false;
    Vector2 offset;

    protected override void OnClicked(Button sender)
    {
        base.OnClicked(sender);
        string name = sender.name;
        if (name.Contains("skill"))
        {
            mEntity.Dispath(vEvent.vDoSkill, name);
        }
        else if (name.Contains("BackBtn"))
        {
            GameManager.NowRunnigGame.GoBack();
        }
    }
    void FixedUpdate()
    {
        if (isMoving)
            boatMove.FixedUpdate(offset);
    }


}
