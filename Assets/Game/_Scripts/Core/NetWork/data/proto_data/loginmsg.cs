//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: proto/loginmsg.proto
namespace proto.loginmsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgAccountLoginRequest")]
  public partial class ST_CMsgAccountLoginRequest : global::ProtoBuf.IExtensible
  {
    public ST_CMsgAccountLoginRequest() {}
    
    private string _account = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _password = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgAccountLoginResponse")]
  public partial class ST_CMsgAccountLoginResponse : global::ProtoBuf.IExtensible
  {
    public ST_CMsgAccountLoginResponse() {}
    
    private int _result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private long _uid = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _sessionkey = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sessionkey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sessionkey
    {
      get { return _sessionkey; }
      set { _sessionkey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgGuestLoginRequest")]
  public partial class ST_CMsgGuestLoginRequest : global::ProtoBuf.IExtensible
  {
    public ST_CMsgGuestLoginRequest() {}
    
    private string _identify = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"identify", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string identify
    {
      get { return _identify; }
      set { _identify = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgGuestLoginResponse")]
  public partial class ST_CMsgGuestLoginResponse : global::ProtoBuf.IExtensible
  {
    public ST_CMsgGuestLoginResponse() {}
    
    private int _result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private long _uid = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _sessionkey = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sessionkey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sessionkey
    {
      get { return _sessionkey; }
      set { _sessionkey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgAccountRegistRequest")]
  public partial class ST_CMsgAccountRegistRequest : global::ProtoBuf.IExtensible
  {
    public ST_CMsgAccountRegistRequest() {}
    
    private string _account = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _password = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgAccountRegistResponse")]
  public partial class ST_CMsgAccountRegistResponse : global::ProtoBuf.IExtensible
  {
    public ST_CMsgAccountRegistResponse() {}
    
    private int _result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private long _uid = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _sessionkey = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sessionkey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sessionkey
    {
      get { return _sessionkey; }
      set { _sessionkey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgGetLogicAddrRequest")]
  public partial class ST_CMsgGetLogicAddrRequest : global::ProtoBuf.IExtensible
  {
    public ST_CMsgGetLogicAddrRequest() {}
    
    private int _svrtype = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"svrtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int svrtype
    {
      get { return _svrtype; }
      set { _svrtype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgGetLogicAddrResponse")]
  public partial class ST_CMsgGetLogicAddrResponse : global::ProtoBuf.IExtensible
  {
    public ST_CMsgGetLogicAddrResponse() {}
    
    private int _svrtype = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"svrtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int svrtype
    {
      get { return _svrtype; }
      set { _svrtype = value; }
    }
    private string _addr = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"addr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string addr
    {
      get { return _addr; }
      set { _addr = value; }
    }
    private int _port = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int port
    {
      get { return _port; }
      set { _port = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgAccountRegistReq")]
  public partial class ST_CMsgAccountRegistReq : global::ProtoBuf.IExtensible
  {
    public ST_CMsgAccountRegistReq() {}
    
    private string _account;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }
    private string _phone;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string phone
    {
      get { return _phone; }
      set { _phone = value; }
    }
    private string _code;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgAccountRegistResp")]
  public partial class ST_CMsgAccountRegistResp : global::ProtoBuf.IExtensible
  {
    public ST_CMsgAccountRegistResp() {}
    
    private string _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string result
    {
      get { return _result; }
      set { _result = value; }
    }
    private long _uid = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _sessionkey = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sessionkey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sessionkey
    {
      get { return _sessionkey; }
      set { _sessionkey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgPhoneAuthCodeReq")]
  public partial class ST_CMsgPhoneAuthCodeReq : global::ProtoBuf.IExtensible
  {
    public ST_CMsgPhoneAuthCodeReq() {}
    
    private string _phone;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string phone
    {
      get { return _phone; }
      set { _phone = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgPhoneAuthCodeResp")]
  public partial class ST_CMsgPhoneAuthCodeResp : global::ProtoBuf.IExtensible
  {
    public ST_CMsgPhoneAuthCodeResp() {}
    
    private string _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgPhoneBindReq")]
  public partial class ST_CMsgPhoneBindReq : global::ProtoBuf.IExtensible
  {
    public ST_CMsgPhoneBindReq() {}
    
    private string _phone;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string phone
    {
      get { return _phone; }
      set { _phone = value; }
    }
    private string _account;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string account
    {
      get { return _account; }
      set { _account = value; }
    }
    private string _code;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ST_CMsgPhoneBindResp")]
  public partial class ST_CMsgPhoneBindResp : global::ProtoBuf.IExtensible
  {
    public ST_CMsgPhoneBindResp() {}
    
    private string _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}