// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReportTrackingIOInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ReportTrackingIOInfoNotify.proto</summary>
public static partial class ReportTrackingIOInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ReportTrackingIOInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReportTrackingIOInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBSZXBvcnRUcmFja2luZ0lPSW5mb05vdGlmeS5wcm90byJzChpSZXBvcnRU",
          "cmFja2luZ0lPSW5mb05vdGlmeRIUCgxyeWRldmljZXR5cGUYDCABKAkSEAoI",
          "ZGV2aWNlaWQYASABKAkSEQoJY2xpZW50X3R6GA0gASgJEg0KBWFwcGlkGA4g",
          "ASgJEgsKA21hYxgPIAEoCUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReportTrackingIOInfoNotify), global::ReportTrackingIOInfoNotify.Parser, new[]{ "Rydevicetype", "Deviceid", "ClientTz", "Appid", "Mac" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4129
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class ReportTrackingIOInfoNotify : pb::IMessage<ReportTrackingIOInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReportTrackingIOInfoNotify> _parser = new pb::MessageParser<ReportTrackingIOInfoNotify>(() => new ReportTrackingIOInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ReportTrackingIOInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReportTrackingIOInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReportTrackingIOInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReportTrackingIOInfoNotify(ReportTrackingIOInfoNotify other) : this() {
    rydevicetype_ = other.rydevicetype_;
    deviceid_ = other.deviceid_;
    clientTz_ = other.clientTz_;
    appid_ = other.appid_;
    mac_ = other.mac_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReportTrackingIOInfoNotify Clone() {
    return new ReportTrackingIOInfoNotify(this);
  }

  /// <summary>Field number for the "rydevicetype" field.</summary>
  public const int RydevicetypeFieldNumber = 12;
  private string rydevicetype_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Rydevicetype {
    get { return rydevicetype_; }
    set {
      rydevicetype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "deviceid" field.</summary>
  public const int DeviceidFieldNumber = 1;
  private string deviceid_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Deviceid {
    get { return deviceid_; }
    set {
      deviceid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "client_tz" field.</summary>
  public const int ClientTzFieldNumber = 13;
  private string clientTz_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ClientTz {
    get { return clientTz_; }
    set {
      clientTz_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "appid" field.</summary>
  public const int AppidFieldNumber = 14;
  private string appid_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Appid {
    get { return appid_; }
    set {
      appid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "mac" field.</summary>
  public const int MacFieldNumber = 15;
  private string mac_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Mac {
    get { return mac_; }
    set {
      mac_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ReportTrackingIOInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ReportTrackingIOInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Rydevicetype != other.Rydevicetype) return false;
    if (Deviceid != other.Deviceid) return false;
    if (ClientTz != other.ClientTz) return false;
    if (Appid != other.Appid) return false;
    if (Mac != other.Mac) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Rydevicetype.Length != 0) hash ^= Rydevicetype.GetHashCode();
    if (Deviceid.Length != 0) hash ^= Deviceid.GetHashCode();
    if (ClientTz.Length != 0) hash ^= ClientTz.GetHashCode();
    if (Appid.Length != 0) hash ^= Appid.GetHashCode();
    if (Mac.Length != 0) hash ^= Mac.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Deviceid.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Deviceid);
    }
    if (Rydevicetype.Length != 0) {
      output.WriteRawTag(98);
      output.WriteString(Rydevicetype);
    }
    if (ClientTz.Length != 0) {
      output.WriteRawTag(106);
      output.WriteString(ClientTz);
    }
    if (Appid.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(Appid);
    }
    if (Mac.Length != 0) {
      output.WriteRawTag(122);
      output.WriteString(Mac);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Deviceid.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Deviceid);
    }
    if (Rydevicetype.Length != 0) {
      output.WriteRawTag(98);
      output.WriteString(Rydevicetype);
    }
    if (ClientTz.Length != 0) {
      output.WriteRawTag(106);
      output.WriteString(ClientTz);
    }
    if (Appid.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(Appid);
    }
    if (Mac.Length != 0) {
      output.WriteRawTag(122);
      output.WriteString(Mac);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Rydevicetype.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Rydevicetype);
    }
    if (Deviceid.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Deviceid);
    }
    if (ClientTz.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientTz);
    }
    if (Appid.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Appid);
    }
    if (Mac.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Mac);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ReportTrackingIOInfoNotify other) {
    if (other == null) {
      return;
    }
    if (other.Rydevicetype.Length != 0) {
      Rydevicetype = other.Rydevicetype;
    }
    if (other.Deviceid.Length != 0) {
      Deviceid = other.Deviceid;
    }
    if (other.ClientTz.Length != 0) {
      ClientTz = other.ClientTz;
    }
    if (other.Appid.Length != 0) {
      Appid = other.Appid;
    }
    if (other.Mac.Length != 0) {
      Mac = other.Mac;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Deviceid = input.ReadString();
          break;
        }
        case 98: {
          Rydevicetype = input.ReadString();
          break;
        }
        case 106: {
          ClientTz = input.ReadString();
          break;
        }
        case 114: {
          Appid = input.ReadString();
          break;
        }
        case 122: {
          Mac = input.ReadString();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Deviceid = input.ReadString();
          break;
        }
        case 98: {
          Rydevicetype = input.ReadString();
          break;
        }
        case 106: {
          ClientTz = input.ReadString();
          break;
        }
        case 114: {
          Appid = input.ReadString();
          break;
        }
        case 122: {
          Mac = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code