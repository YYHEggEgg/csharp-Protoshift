// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionStartReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ExpeditionStartReq.proto</summary>
public static partial class ExpeditionStartReqReflection {

  #region Descriptor
  /// <summary>File descriptor for ExpeditionStartReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ExpeditionStartReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhFeHBlZGl0aW9uU3RhcnRSZXEucHJvdG8iawoSRXhwZWRpdGlvblN0YXJ0",
          "UmVxEhYKDmF2YXRhcl9pZF9saXN0GAEgAygNEhIKCmFzc2lzdF91aWQYBSAB",
          "KA0SGAoQYXNzaXN0X2F2YXRhcl9pZBgIIAEoDRIPCgdwYXRoX2lkGAcgASgN",
          "Qh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ExpeditionStartReq), global::ExpeditionStartReq.Parser, new[]{ "AvatarIdList", "AssistUid", "AssistAvatarId", "PathId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2087
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class ExpeditionStartReq : pb::IMessage<ExpeditionStartReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ExpeditionStartReq> _parser = new pb::MessageParser<ExpeditionStartReq>(() => new ExpeditionStartReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ExpeditionStartReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ExpeditionStartReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExpeditionStartReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExpeditionStartReq(ExpeditionStartReq other) : this() {
    avatarIdList_ = other.avatarIdList_.Clone();
    assistUid_ = other.assistUid_;
    assistAvatarId_ = other.assistAvatarId_;
    pathId_ = other.pathId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExpeditionStartReq Clone() {
    return new ExpeditionStartReq(this);
  }

  /// <summary>Field number for the "avatar_id_list" field.</summary>
  public const int AvatarIdListFieldNumber = 1;
  private static readonly pb::FieldCodec<uint> _repeated_avatarIdList_codec
      = pb::FieldCodec.ForUInt32(10);
  private readonly pbc::RepeatedField<uint> avatarIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> AvatarIdList {
    get { return avatarIdList_; }
  }

  /// <summary>Field number for the "assist_uid" field.</summary>
  public const int AssistUidFieldNumber = 5;
  private uint assistUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AssistUid {
    get { return assistUid_; }
    set {
      assistUid_ = value;
    }
  }

  /// <summary>Field number for the "assist_avatar_id" field.</summary>
  public const int AssistAvatarIdFieldNumber = 8;
  private uint assistAvatarId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AssistAvatarId {
    get { return assistAvatarId_; }
    set {
      assistAvatarId_ = value;
    }
  }

  /// <summary>Field number for the "path_id" field.</summary>
  public const int PathIdFieldNumber = 7;
  private uint pathId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PathId {
    get { return pathId_; }
    set {
      pathId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ExpeditionStartReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ExpeditionStartReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!avatarIdList_.Equals(other.avatarIdList_)) return false;
    if (AssistUid != other.AssistUid) return false;
    if (AssistAvatarId != other.AssistAvatarId) return false;
    if (PathId != other.PathId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= avatarIdList_.GetHashCode();
    if (AssistUid != 0) hash ^= AssistUid.GetHashCode();
    if (AssistAvatarId != 0) hash ^= AssistAvatarId.GetHashCode();
    if (PathId != 0) hash ^= PathId.GetHashCode();
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
    avatarIdList_.WriteTo(output, _repeated_avatarIdList_codec);
    if (AssistUid != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(AssistUid);
    }
    if (PathId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(PathId);
    }
    if (AssistAvatarId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(AssistAvatarId);
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
    avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
    if (AssistUid != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(AssistUid);
    }
    if (PathId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(PathId);
    }
    if (AssistAvatarId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(AssistAvatarId);
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
    size += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
    if (AssistUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistUid);
    }
    if (AssistAvatarId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistAvatarId);
    }
    if (PathId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PathId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ExpeditionStartReq other) {
    if (other == null) {
      return;
    }
    avatarIdList_.Add(other.avatarIdList_);
    if (other.AssistUid != 0) {
      AssistUid = other.AssistUid;
    }
    if (other.AssistAvatarId != 0) {
      AssistAvatarId = other.AssistAvatarId;
    }
    if (other.PathId != 0) {
      PathId = other.PathId;
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
        case 10:
        case 8: {
          avatarIdList_.AddEntriesFrom(input, _repeated_avatarIdList_codec);
          break;
        }
        case 40: {
          AssistUid = input.ReadUInt32();
          break;
        }
        case 56: {
          PathId = input.ReadUInt32();
          break;
        }
        case 64: {
          AssistAvatarId = input.ReadUInt32();
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
        case 10:
        case 8: {
          avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
          break;
        }
        case 40: {
          AssistUid = input.ReadUInt32();
          break;
        }
        case 56: {
          PathId = input.ReadUInt32();
          break;
        }
        case 64: {
          AssistAvatarId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
