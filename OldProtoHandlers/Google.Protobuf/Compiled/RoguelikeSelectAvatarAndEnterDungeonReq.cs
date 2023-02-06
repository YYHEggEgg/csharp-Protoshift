// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoguelikeSelectAvatarAndEnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RoguelikeSelectAvatarAndEnterDungeonReq.proto</summary>
public static partial class RoguelikeSelectAvatarAndEnterDungeonReqReflection {

  #region Descriptor
  /// <summary>File descriptor for RoguelikeSelectAvatarAndEnterDungeonReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RoguelikeSelectAvatarAndEnterDungeonReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ci1Sb2d1ZWxpa2VTZWxlY3RBdmF0YXJBbmRFbnRlckR1bmdlb25SZXEucHJv",
          "dG8igQEKJ1JvZ3VlbGlrZVNlbGVjdEF2YXRhckFuZEVudGVyRHVuZ2VvblJl",
          "cRIgChhvbnN0YWdlX2F2YXRhcl9ndWlkX2xpc3QYDiADKAQSEAoIc3RhZ2Vf",
          "aWQYBCABKA0SIgoaYmFja3N0YWdlX2F2YXRhcl9ndWlkX2xpc3QYCyADKARC",
          "HgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RoguelikeSelectAvatarAndEnterDungeonReq), global::RoguelikeSelectAvatarAndEnterDungeonReq.Parser, new[]{ "OnstageAvatarGuidList", "StageId", "BackstageAvatarGuidList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8457
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class RoguelikeSelectAvatarAndEnterDungeonReq : pb::IMessage<RoguelikeSelectAvatarAndEnterDungeonReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RoguelikeSelectAvatarAndEnterDungeonReq> _parser = new pb::MessageParser<RoguelikeSelectAvatarAndEnterDungeonReq>(() => new RoguelikeSelectAvatarAndEnterDungeonReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RoguelikeSelectAvatarAndEnterDungeonReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RoguelikeSelectAvatarAndEnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeSelectAvatarAndEnterDungeonReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeSelectAvatarAndEnterDungeonReq(RoguelikeSelectAvatarAndEnterDungeonReq other) : this() {
    onstageAvatarGuidList_ = other.onstageAvatarGuidList_.Clone();
    stageId_ = other.stageId_;
    backstageAvatarGuidList_ = other.backstageAvatarGuidList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeSelectAvatarAndEnterDungeonReq Clone() {
    return new RoguelikeSelectAvatarAndEnterDungeonReq(this);
  }

  /// <summary>Field number for the "onstage_avatar_guid_list" field.</summary>
  public const int OnstageAvatarGuidListFieldNumber = 14;
  private static readonly pb::FieldCodec<ulong> _repeated_onstageAvatarGuidList_codec
      = pb::FieldCodec.ForUInt64(114);
  private readonly pbc::RepeatedField<ulong> onstageAvatarGuidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> OnstageAvatarGuidList {
    get { return onstageAvatarGuidList_; }
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 4;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "backstage_avatar_guid_list" field.</summary>
  public const int BackstageAvatarGuidListFieldNumber = 11;
  private static readonly pb::FieldCodec<ulong> _repeated_backstageAvatarGuidList_codec
      = pb::FieldCodec.ForUInt64(90);
  private readonly pbc::RepeatedField<ulong> backstageAvatarGuidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> BackstageAvatarGuidList {
    get { return backstageAvatarGuidList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RoguelikeSelectAvatarAndEnterDungeonReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RoguelikeSelectAvatarAndEnterDungeonReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!onstageAvatarGuidList_.Equals(other.onstageAvatarGuidList_)) return false;
    if (StageId != other.StageId) return false;
    if(!backstageAvatarGuidList_.Equals(other.backstageAvatarGuidList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= onstageAvatarGuidList_.GetHashCode();
    if (StageId != 0) hash ^= StageId.GetHashCode();
    hash ^= backstageAvatarGuidList_.GetHashCode();
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
    if (StageId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StageId);
    }
    backstageAvatarGuidList_.WriteTo(output, _repeated_backstageAvatarGuidList_codec);
    onstageAvatarGuidList_.WriteTo(output, _repeated_onstageAvatarGuidList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (StageId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StageId);
    }
    backstageAvatarGuidList_.WriteTo(ref output, _repeated_backstageAvatarGuidList_codec);
    onstageAvatarGuidList_.WriteTo(ref output, _repeated_onstageAvatarGuidList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += onstageAvatarGuidList_.CalculateSize(_repeated_onstageAvatarGuidList_codec);
    if (StageId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
    }
    size += backstageAvatarGuidList_.CalculateSize(_repeated_backstageAvatarGuidList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RoguelikeSelectAvatarAndEnterDungeonReq other) {
    if (other == null) {
      return;
    }
    onstageAvatarGuidList_.Add(other.onstageAvatarGuidList_);
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    backstageAvatarGuidList_.Add(other.backstageAvatarGuidList_);
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
        case 32: {
          StageId = input.ReadUInt32();
          break;
        }
        case 90:
        case 88: {
          backstageAvatarGuidList_.AddEntriesFrom(input, _repeated_backstageAvatarGuidList_codec);
          break;
        }
        case 114:
        case 112: {
          onstageAvatarGuidList_.AddEntriesFrom(input, _repeated_onstageAvatarGuidList_codec);
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
        case 32: {
          StageId = input.ReadUInt32();
          break;
        }
        case 90:
        case 88: {
          backstageAvatarGuidList_.AddEntriesFrom(ref input, _repeated_backstageAvatarGuidList_codec);
          break;
        }
        case 114:
        case 112: {
          onstageAvatarGuidList_.AddEntriesFrom(ref input, _repeated_onstageAvatarGuidList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
