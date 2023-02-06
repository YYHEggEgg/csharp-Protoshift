// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CrystalLinkEnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CrystalLinkEnterDungeonReq.proto</summary>
public static partial class CrystalLinkEnterDungeonReqReflection {

  #region Descriptor
  /// <summary>File descriptor for CrystalLinkEnterDungeonReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CrystalLinkEnterDungeonReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBDcnlzdGFsTGlua0VudGVyRHVuZ2VvblJlcS5wcm90bxoZQ3J5c3RhbExp",
          "bmtUZWFtSW5mby5wcm90byJzChpDcnlzdGFsTGlua0VudGVyRHVuZ2VvblJl",
          "cRIsCg50ZWFtX2luZm9fbGlzdBgNIAMoCzIULkNyeXN0YWxMaW5rVGVhbUlu",
          "Zm8SFQoNZGlmZmljdWx0eV9pZBgFIAEoDRIQCghsZXZlbF9pZBgGIAEoDUIW",
          "ChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CrystalLinkTeamInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CrystalLinkEnterDungeonReq), global::CrystalLinkEnterDungeonReq.Parser, new[]{ "TeamInfoList", "DifficultyId", "LevelId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 8179;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class CrystalLinkEnterDungeonReq : pb::IMessage<CrystalLinkEnterDungeonReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CrystalLinkEnterDungeonReq> _parser = new pb::MessageParser<CrystalLinkEnterDungeonReq>(() => new CrystalLinkEnterDungeonReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CrystalLinkEnterDungeonReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CrystalLinkEnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CrystalLinkEnterDungeonReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CrystalLinkEnterDungeonReq(CrystalLinkEnterDungeonReq other) : this() {
    teamInfoList_ = other.teamInfoList_.Clone();
    difficultyId_ = other.difficultyId_;
    levelId_ = other.levelId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CrystalLinkEnterDungeonReq Clone() {
    return new CrystalLinkEnterDungeonReq(this);
  }

  /// <summary>Field number for the "team_info_list" field.</summary>
  public const int TeamInfoListFieldNumber = 13;
  private static readonly pb::FieldCodec<global::CrystalLinkTeamInfo> _repeated_teamInfoList_codec
      = pb::FieldCodec.ForMessage(106, global::CrystalLinkTeamInfo.Parser);
  private readonly pbc::RepeatedField<global::CrystalLinkTeamInfo> teamInfoList_ = new pbc::RepeatedField<global::CrystalLinkTeamInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::CrystalLinkTeamInfo> TeamInfoList {
    get { return teamInfoList_; }
  }

  /// <summary>Field number for the "difficulty_id" field.</summary>
  public const int DifficultyIdFieldNumber = 5;
  private uint difficultyId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DifficultyId {
    get { return difficultyId_; }
    set {
      difficultyId_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 6;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CrystalLinkEnterDungeonReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CrystalLinkEnterDungeonReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!teamInfoList_.Equals(other.teamInfoList_)) return false;
    if (DifficultyId != other.DifficultyId) return false;
    if (LevelId != other.LevelId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= teamInfoList_.GetHashCode();
    if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
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
    if (DifficultyId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(DifficultyId);
    }
    if (LevelId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(LevelId);
    }
    teamInfoList_.WriteTo(output, _repeated_teamInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (DifficultyId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(DifficultyId);
    }
    if (LevelId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(LevelId);
    }
    teamInfoList_.WriteTo(ref output, _repeated_teamInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += teamInfoList_.CalculateSize(_repeated_teamInfoList_codec);
    if (DifficultyId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CrystalLinkEnterDungeonReq other) {
    if (other == null) {
      return;
    }
    teamInfoList_.Add(other.teamInfoList_);
    if (other.DifficultyId != 0) {
      DifficultyId = other.DifficultyId;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
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
        case 40: {
          DifficultyId = input.ReadUInt32();
          break;
        }
        case 48: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 106: {
          teamInfoList_.AddEntriesFrom(input, _repeated_teamInfoList_codec);
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
        case 40: {
          DifficultyId = input.ReadUInt32();
          break;
        }
        case 48: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 106: {
          teamInfoList_.AddEntriesFrom(ref input, _repeated_teamInfoList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
