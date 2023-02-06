// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeAvatarSummonAllEventNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HomeAvatarSummonAllEventNotify.proto</summary>
public static partial class HomeAvatarSummonAllEventNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for HomeAvatarSummonAllEventNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HomeAvatarSummonAllEventNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiRIb21lQXZhdGFyU3VtbW9uQWxsRXZlbnROb3RpZnkucHJvdG8aH0hvbWVB",
          "dmF0YXJTdW1tb25FdmVudEluZm8ucHJvdG8iVwoeSG9tZUF2YXRhclN1bW1v",
          "bkFsbEV2ZW50Tm90aWZ5EjUKEXN1bW1vbl9ldmVudF9saXN0GA4gAygLMhou",
          "SG9tZUF2YXRhclN1bW1vbkV2ZW50SW5mb0IWChRvcmcuc29yYXBvaW50YS5w",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HomeAvatarSummonEventInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HomeAvatarSummonAllEventNotify), global::HomeAvatarSummonAllEventNotify.Parser, new[]{ "SummonEventList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4670;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class HomeAvatarSummonAllEventNotify : pb::IMessage<HomeAvatarSummonAllEventNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HomeAvatarSummonAllEventNotify> _parser = new pb::MessageParser<HomeAvatarSummonAllEventNotify>(() => new HomeAvatarSummonAllEventNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HomeAvatarSummonAllEventNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HomeAvatarSummonAllEventNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeAvatarSummonAllEventNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeAvatarSummonAllEventNotify(HomeAvatarSummonAllEventNotify other) : this() {
    summonEventList_ = other.summonEventList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeAvatarSummonAllEventNotify Clone() {
    return new HomeAvatarSummonAllEventNotify(this);
  }

  /// <summary>Field number for the "summon_event_list" field.</summary>
  public const int SummonEventListFieldNumber = 14;
  private static readonly pb::FieldCodec<global::HomeAvatarSummonEventInfo> _repeated_summonEventList_codec
      = pb::FieldCodec.ForMessage(114, global::HomeAvatarSummonEventInfo.Parser);
  private readonly pbc::RepeatedField<global::HomeAvatarSummonEventInfo> summonEventList_ = new pbc::RepeatedField<global::HomeAvatarSummonEventInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::HomeAvatarSummonEventInfo> SummonEventList {
    get { return summonEventList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HomeAvatarSummonAllEventNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HomeAvatarSummonAllEventNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!summonEventList_.Equals(other.summonEventList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= summonEventList_.GetHashCode();
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
    summonEventList_.WriteTo(output, _repeated_summonEventList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    summonEventList_.WriteTo(ref output, _repeated_summonEventList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += summonEventList_.CalculateSize(_repeated_summonEventList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HomeAvatarSummonAllEventNotify other) {
    if (other == null) {
      return;
    }
    summonEventList_.Add(other.summonEventList_);
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
        case 114: {
          summonEventList_.AddEntriesFrom(input, _repeated_summonEventList_codec);
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
        case 114: {
          summonEventList_.AddEntriesFrom(ref input, _repeated_summonEventList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
