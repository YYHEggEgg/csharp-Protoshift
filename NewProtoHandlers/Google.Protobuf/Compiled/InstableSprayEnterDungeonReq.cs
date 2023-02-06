// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InstableSprayEnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from InstableSprayEnterDungeonReq.proto</summary>
public static partial class InstableSprayEnterDungeonReqReflection {

  #region Descriptor
  /// <summary>File descriptor for InstableSprayEnterDungeonReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InstableSprayEnterDungeonReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiJJbnN0YWJsZVNwcmF5RW50ZXJEdW5nZW9uUmVxLnByb3RvGh1JbnN0YWJs",
          "ZVNwcmF5QXZhdGFySW5mby5wcm90byJ4ChxJbnN0YWJsZVNwcmF5RW50ZXJE",
          "dW5nZW9uUmVxEhAKCHN0YWdlX2lkGAUgASgNEjIKEGF2YXRhcl9pbmZvX2xp",
          "c3QYAiADKAsyGC5JbnN0YWJsZVNwcmF5QXZhdGFySW5mbxISCgpkaWZmaWN1",
          "bHR5GAEgASgNQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::InstableSprayAvatarInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InstableSprayEnterDungeonReq), global::InstableSprayEnterDungeonReq.Parser, new[]{ "StageId", "AvatarInfoList", "Difficulty" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 21889;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class InstableSprayEnterDungeonReq : pb::IMessage<InstableSprayEnterDungeonReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InstableSprayEnterDungeonReq> _parser = new pb::MessageParser<InstableSprayEnterDungeonReq>(() => new InstableSprayEnterDungeonReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InstableSprayEnterDungeonReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InstableSprayEnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InstableSprayEnterDungeonReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InstableSprayEnterDungeonReq(InstableSprayEnterDungeonReq other) : this() {
    stageId_ = other.stageId_;
    avatarInfoList_ = other.avatarInfoList_.Clone();
    difficulty_ = other.difficulty_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InstableSprayEnterDungeonReq Clone() {
    return new InstableSprayEnterDungeonReq(this);
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 5;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "avatar_info_list" field.</summary>
  public const int AvatarInfoListFieldNumber = 2;
  private static readonly pb::FieldCodec<global::InstableSprayAvatarInfo> _repeated_avatarInfoList_codec
      = pb::FieldCodec.ForMessage(18, global::InstableSprayAvatarInfo.Parser);
  private readonly pbc::RepeatedField<global::InstableSprayAvatarInfo> avatarInfoList_ = new pbc::RepeatedField<global::InstableSprayAvatarInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InstableSprayAvatarInfo> AvatarInfoList {
    get { return avatarInfoList_; }
  }

  /// <summary>Field number for the "difficulty" field.</summary>
  public const int DifficultyFieldNumber = 1;
  private uint difficulty_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Difficulty {
    get { return difficulty_; }
    set {
      difficulty_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InstableSprayEnterDungeonReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InstableSprayEnterDungeonReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StageId != other.StageId) return false;
    if(!avatarInfoList_.Equals(other.avatarInfoList_)) return false;
    if (Difficulty != other.Difficulty) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StageId != 0) hash ^= StageId.GetHashCode();
    hash ^= avatarInfoList_.GetHashCode();
    if (Difficulty != 0) hash ^= Difficulty.GetHashCode();
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
    if (Difficulty != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Difficulty);
    }
    avatarInfoList_.WriteTo(output, _repeated_avatarInfoList_codec);
    if (StageId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(StageId);
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
    if (Difficulty != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Difficulty);
    }
    avatarInfoList_.WriteTo(ref output, _repeated_avatarInfoList_codec);
    if (StageId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(StageId);
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
    if (StageId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
    }
    size += avatarInfoList_.CalculateSize(_repeated_avatarInfoList_codec);
    if (Difficulty != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficulty);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InstableSprayEnterDungeonReq other) {
    if (other == null) {
      return;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    avatarInfoList_.Add(other.avatarInfoList_);
    if (other.Difficulty != 0) {
      Difficulty = other.Difficulty;
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
          Difficulty = input.ReadUInt32();
          break;
        }
        case 18: {
          avatarInfoList_.AddEntriesFrom(input, _repeated_avatarInfoList_codec);
          break;
        }
        case 40: {
          StageId = input.ReadUInt32();
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
          Difficulty = input.ReadUInt32();
          break;
        }
        case 18: {
          avatarInfoList_.AddEntriesFrom(ref input, _repeated_avatarInfoList_codec);
          break;
        }
        case 40: {
          StageId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
