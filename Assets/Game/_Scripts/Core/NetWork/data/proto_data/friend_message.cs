//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: friendserver/friend_message.proto
namespace friendserver.friend_message
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendInfo_T")]
  public partial class FriendInfo_T : global::ProtoBuf.IExtensible
  {
    public FriendInfo_T() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _nickname = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetFriendListC2S")]
  public partial class CGetFriendListC2S : global::ProtoBuf.IExtensible
  {
    public CGetFriendListC2S() {}
    
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
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGetFriendListS2C")]
  public partial class CGetFriendListS2C : global::ProtoBuf.IExtensible
  {
    public CGetFriendListS2C() {}
    
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
    private readonly global::System.Collections.Generic.List<FriendInfo_T> _finfo = new global::System.Collections.Generic.List<FriendInfo_T>();
    [global::ProtoBuf.ProtoMember(3, Name=@"finfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FriendInfo_T> finfo
    {
      get { return _finfo; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CBeFriendC2S")]
  public partial class CBeFriendC2S : global::ProtoBuf.IExtensible
  {
    public CBeFriendC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private long _fuid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"fuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long fuid
    {
      get { return _fuid; }
      set { _fuid = value; }
    }
    private string _session;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"session", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string session
    {
      get { return _session; }
      set { _session = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CBeFriendS2C")]
  public partial class CBeFriendS2C : global::ProtoBuf.IExtensible
  {
    public CBeFriendS2C() {}
    
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
    private long _fuid = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"fuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long fuid
    {
      get { return _fuid; }
      set { _fuid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDelFriendC2S")]
  public partial class CDelFriendC2S : global::ProtoBuf.IExtensible
  {
    public CDelFriendC2S() {}
    
    private long _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private long _fuid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"fuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long fuid
    {
      get { return _fuid; }
      set { _fuid = value; }
    }
    private string _session;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"session", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string session
    {
      get { return _session; }
      set { _session = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CDelFriendS2C")]
  public partial class CDelFriendS2C : global::ProtoBuf.IExtensible
  {
    public CDelFriendS2C() {}
    
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
    private long _fuid = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"fuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long fuid
    {
      get { return _fuid; }
      set { _fuid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}