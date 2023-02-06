// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CutSceneBeginNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CutSceneBeginNotify.proto</summary>
public static partial class CutSceneBeginNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for CutSceneBeginNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CutSceneBeginNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlDdXRTY2VuZUJlZ2luTm90aWZ5LnByb3RvGhhDdXRTY2VuZUV4dHJhUGFy",
          "YW0ucHJvdG8icQoTQ3V0U2NlbmVCZWdpbk5vdGlmeRITCgtjdXRzY2VuZV9p",
          "ZBgOIAEoDRItChBleHRyYV9wYXJhbV9saXN0GA0gAygLMhMuQ3V0U2NlbmVF",
          "eHRyYVBhcmFtEhYKDmlzX3dhaXRfb3RoZXJzGAEgASgIQhYKFG9yZy5zb3Jh",
          "cG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CutSceneExtraParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CutSceneBeginNotify), global::CutSceneBeginNotify.Parser, new[]{ "CutsceneId", "ExtraParamList", "IsWaitOthers" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 283;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class CutSceneBeginNotify : pb::IMessage<CutSceneBeginNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CutSceneBeginNotify> _parser = new pb::MessageParser<CutSceneBeginNotify>(() => new CutSceneBeginNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CutSceneBeginNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CutSceneBeginNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CutSceneBeginNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CutSceneBeginNotify(CutSceneBeginNotify other) : this() {
    cutsceneId_ = other.cutsceneId_;
    extraParamList_ = other.extraParamList_.Clone();
    isWaitOthers_ = other.isWaitOthers_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CutSceneBeginNotify Clone() {
    return new CutSceneBeginNotify(this);
  }

  /// <summary>Field number for the "cutscene_id" field.</summary>
  public const int CutsceneIdFieldNumber = 14;
  private uint cutsceneId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CutsceneId {
    get { return cutsceneId_; }
    set {
      cutsceneId_ = value;
    }
  }

  /// <summary>Field number for the "extra_param_list" field.</summary>
  public const int ExtraParamListFieldNumber = 13;
  private static readonly pb::FieldCodec<global::CutSceneExtraParam> _repeated_extraParamList_codec
      = pb::FieldCodec.ForMessage(106, global::CutSceneExtraParam.Parser);
  private readonly pbc::RepeatedField<global::CutSceneExtraParam> extraParamList_ = new pbc::RepeatedField<global::CutSceneExtraParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::CutSceneExtraParam> ExtraParamList {
    get { return extraParamList_; }
  }

  /// <summary>Field number for the "is_wait_others" field.</summary>
  public const int IsWaitOthersFieldNumber = 1;
  private bool isWaitOthers_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsWaitOthers {
    get { return isWaitOthers_; }
    set {
      isWaitOthers_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CutSceneBeginNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CutSceneBeginNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CutsceneId != other.CutsceneId) return false;
    if(!extraParamList_.Equals(other.extraParamList_)) return false;
    if (IsWaitOthers != other.IsWaitOthers) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (CutsceneId != 0) hash ^= CutsceneId.GetHashCode();
    hash ^= extraParamList_.GetHashCode();
    if (IsWaitOthers != false) hash ^= IsWaitOthers.GetHashCode();
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
    if (IsWaitOthers != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsWaitOthers);
    }
    extraParamList_.WriteTo(output, _repeated_extraParamList_codec);
    if (CutsceneId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CutsceneId);
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
    if (IsWaitOthers != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsWaitOthers);
    }
    extraParamList_.WriteTo(ref output, _repeated_extraParamList_codec);
    if (CutsceneId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CutsceneId);
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
    if (CutsceneId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CutsceneId);
    }
    size += extraParamList_.CalculateSize(_repeated_extraParamList_codec);
    if (IsWaitOthers != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CutSceneBeginNotify other) {
    if (other == null) {
      return;
    }
    if (other.CutsceneId != 0) {
      CutsceneId = other.CutsceneId;
    }
    extraParamList_.Add(other.extraParamList_);
    if (other.IsWaitOthers != false) {
      IsWaitOthers = other.IsWaitOthers;
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
        case 8: {
          IsWaitOthers = input.ReadBool();
          break;
        }
        case 106: {
          extraParamList_.AddEntriesFrom(input, _repeated_extraParamList_codec);
          break;
        }
        case 112: {
          CutsceneId = input.ReadUInt32();
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
        case 8: {
          IsWaitOthers = input.ReadBool();
          break;
        }
        case 106: {
          extraParamList_.AddEntriesFrom(ref input, _repeated_extraParamList_codec);
          break;
        }
        case 112: {
          CutsceneId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
