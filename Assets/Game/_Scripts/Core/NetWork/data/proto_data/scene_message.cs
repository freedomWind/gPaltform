//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: proto/scene_message.proto
namespace proto.scene_message
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLoginReqC2S")]
  public partial class CLoginReqC2S : global::ProtoBuf.IExtensible
  {
    public CLoginReqC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _session;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"session", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string session
    {
      get { return _session; }
      set { _session = value; }
    }
    private int _actorID = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"actorID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int actorID
    {
      get { return _actorID; }
      set { _actorID = value; }
    }
    private string _nickname = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private int _anchor = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"anchor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int anchor
    {
      get { return _anchor; }
      set { _anchor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLoginRespS2C")]
  public partial class CLoginRespS2C : global::ProtoBuf.IExtensible
  {
    public CLoginRespS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _errcode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"errcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errcode
    {
      get { return _errcode; }
      set { _errcode = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSetUsrInfoReqC2S")]
  public partial class CSetUsrInfoReqC2S : global::ProtoBuf.IExtensible
  {
    public CSetUsrInfoReqC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _actorID = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"actorID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int actorID
    {
      get { return _actorID; }
      set { _actorID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSetUsrInfoRespS2C")]
  public partial class CSetUsrInfoRespS2C : global::ProtoBuf.IExtensible
  {
    public CSetUsrInfoRespS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _errcode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"errcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errcode
    {
      get { return _errcode; }
      set { _errcode = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerInfo_T")]
  public partial class PlayerInfo_T : global::ProtoBuf.IExtensible
  {
    public PlayerInfo_T() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _actorID = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"actorID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int actorID
    {
      get { return _actorID; }
      set { _actorID = value; }
    }
    private string _nickname = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private float _x_pos = default(float);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"x_pos", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float x_pos
    {
      get { return _x_pos; }
      set { _x_pos = value; }
    }
    private float _y_pos = default(float);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"y_pos", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float y_pos
    {
      get { return _y_pos; }
      set { _y_pos = value; }
    }
    private float _z_pos = default(float);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"z_pos", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float z_pos
    {
      get { return _z_pos; }
      set { _z_pos = value; }
    }
    private float _x_ang = default(float);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"x_ang", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float x_ang
    {
      get { return _x_ang; }
      set { _x_ang = value; }
    }
    private float _y_ang = default(float);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"y_ang", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float y_ang
    {
      get { return _y_ang; }
      set { _y_ang = value; }
    }
    private float _z_ang = default(float);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"z_ang", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float z_ang
    {
      get { return _z_ang; }
      set { _z_ang = value; }
    }
    private int _origin = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"origin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int origin
    {
      get { return _origin; }
      set { _origin = value; }
    }
    private int _posIdx = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"posIdx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int posIdx
    {
      get { return _posIdx; }
      set { _posIdx = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CEnterRoomReqC2S")]
  public partial class CEnterRoomReqC2S : global::ProtoBuf.IExtensible
  {
    public CEnterRoomReqC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _pwd = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pwd
    {
      get { return _pwd; }
      set { _pwd = value; }
    }
    private int _rflag = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rflag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rflag
    {
      get { return _rflag; }
      set { _rflag = value; }
    }
    private int _rid = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CEnterRoomRespS2C")]
  public partial class CEnterRoomRespS2C : global::ProtoBuf.IExtensible
  {
    public CEnterRoomRespS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _errcode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"errcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errcode
    {
      get { return _errcode; }
      set { _errcode = value; }
    }
    private int _rid = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private string _URL = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"URL", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string URL
    {
      get { return _URL; }
      set { _URL = value; }
    }
    private readonly global::System.Collections.Generic.List<PlayerInfo_T> _stPlayerInfos = new global::System.Collections.Generic.List<PlayerInfo_T>();
    [global::ProtoBuf.ProtoMember(6, Name=@"stPlayerInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PlayerInfo_T> stPlayerInfos
    {
      get { return _stPlayerInfos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNotifyEnterRoomS2C")]
  public partial class CNotifyEnterRoomS2C : global::ProtoBuf.IExtensible
  {
    public CNotifyEnterRoomS2C() {}
    
    private int _rid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private PlayerInfo_T _stPlayerInfo;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"stPlayerInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public PlayerInfo_T stPlayerInfo
    {
      get { return _stPlayerInfo; }
      set { _stPlayerInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCreateRoomReqC2S")]
  public partial class CCreateRoomReqC2S : global::ProtoBuf.IExtensible
  {
    public CCreateRoomReqC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _confid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"confid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int confid
    {
      get { return _confid; }
      set { _confid = value; }
    }
    private int _usrmax = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"usrmax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int usrmax
    {
      get { return _usrmax; }
      set { _usrmax = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _pwd = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"pwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pwd
    {
      get { return _pwd; }
      set { _pwd = value; }
    }
    private string _desc = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private string _url = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCreateRoomRespS2C")]
  public partial class CCreateRoomRespS2C : global::ProtoBuf.IExtensible
  {
    public CCreateRoomRespS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private int _rid = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private string _errcode = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"errcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errcode
    {
      get { return _errcode; }
      set { _errcode = value; }
    }
    private PlayerInfo_T _stPlayerInfo = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"stPlayerInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerInfo_T stPlayerInfo
    {
      get { return _stPlayerInfo; }
      set { _stPlayerInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RoomInfo_T")]
  public partial class RoomInfo_T : global::ProtoBuf.IExtensible
  {
    public RoomInfo_T() {}
    
    private int _rid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private long _owner = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"owner", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long owner
    {
      get { return _owner; }
      set { _owner = value; }
    }
    private int _usrMax;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"usrMax", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int usrMax
    {
      get { return _usrMax; }
      set { _usrMax = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _confid;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"confid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int confid
    {
      get { return _confid; }
      set { _confid = value; }
    }
    private int _usrNum;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"usrNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int usrNum
    {
      get { return _usrNum; }
      set { _usrNum = value; }
    }
    private int _state = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int state
    {
      get { return _state; }
      set { _state = value; }
    }
    private int _pwdlmt = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pwdlmt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int pwdlmt
    {
      get { return _pwdlmt; }
      set { _pwdlmt = value; }
    }
    private string _ownernick = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ownernick", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ownernick
    {
      get { return _ownernick; }
      set { _ownernick = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private string _desc = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private string _image = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"image", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string image
    {
      get { return _image; }
      set { _image = value; }
    }
    private string _url = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetRoomListReqC2S")]
  public partial class CGetRoomListReqC2S : global::ProtoBuf.IExtensible
  {
    public CGetRoomListReqC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetRoomListRespS2C")]
  public partial class CGetRoomListRespS2C : global::ProtoBuf.IExtensible
  {
    public CGetRoomListRespS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _errcode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"errcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errcode
    {
      get { return _errcode; }
      set { _errcode = value; }
    }
    private readonly global::System.Collections.Generic.List<RoomInfo_T> _roomlist = new global::System.Collections.Generic.List<RoomInfo_T>();
    [global::ProtoBuf.ProtoMember(4, Name=@"roomlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RoomInfo_T> roomlist
    {
      get { return _roomlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetRoomInfoByIDReqC2S")]
  public partial class CGetRoomInfoByIDReqC2S : global::ProtoBuf.IExtensible
  {
    public CGetRoomInfoByIDReqC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private long _bid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"bid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long bid
    {
      get { return _bid; }
      set { _bid = value; }
    }
    private int _btype;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"btype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int btype
    {
      get { return _btype; }
      set { _btype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetRoomInfoByIDRespS2C")]
  public partial class CGetRoomInfoByIDRespS2C : global::ProtoBuf.IExtensible
  {
    public CGetRoomInfoByIDRespS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _errcode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"errcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errcode
    {
      get { return _errcode; }
      set { _errcode = value; }
    }
    private RoomInfo_T _roominfo = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"roominfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public RoomInfo_T roominfo
    {
      get { return _roominfo; }
      set { _roominfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLeaveRoomReqC2S")]
  public partial class CLeaveRoomReqC2S : global::ProtoBuf.IExtensible
  {
    public CLeaveRoomReqC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CLeaveRoomRespS2C")]
  public partial class CLeaveRoomRespS2C : global::ProtoBuf.IExtensible
  {
    public CLeaveRoomRespS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _rid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CNotifyLeaveRoomS2C")]
  public partial class CNotifyLeaveRoomS2C : global::ProtoBuf.IExtensible
  {
    public CNotifyLeaveRoomS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _rid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CReleaseRoom")]
  public partial class CReleaseRoom : global::ProtoBuf.IExtensible
  {
    public CReleaseRoom() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _rid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CReleaseRoomResp")]
  public partial class CReleaseRoomResp : global::ProtoBuf.IExtensible
  {
    public CReleaseRoomResp() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private int _rid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"rid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int rid
    {
      get { return _rid; }
      set { _rid = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetAgoraAppidReq")]
  public partial class CGetAgoraAppidReq : global::ProtoBuf.IExtensible
  {
    public CGetAgoraAppidReq() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetAgoraAppidResp")]
  public partial class CGetAgoraAppidResp : global::ProtoBuf.IExtensible
  {
    public CGetAgoraAppidResp() {}
    
    private string _appid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPingC2S")]
  public partial class CPingC2S : global::ProtoBuf.IExtensible
  {
    public CPingC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _data = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPingS2C")]
  public partial class CPingS2C : global::ProtoBuf.IExtensible
  {
    public CPingS2C() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _data = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGet360ImageLstReq")]
  public partial class CGet360ImageLstReq : global::ProtoBuf.IExtensible
  {
    public CGet360ImageLstReq() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGet360ImageLstResp")]
  public partial class CGet360ImageLstResp : global::ProtoBuf.IExtensible
  {
    public CGet360ImageLstResp() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _images = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"images", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> images
    {
      get { return _images; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}