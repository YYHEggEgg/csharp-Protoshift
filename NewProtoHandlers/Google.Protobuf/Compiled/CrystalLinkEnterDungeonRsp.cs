// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CrystalLinkEnterDungeonRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CrystalLinkEnterDungeonRsp.proto</summary>
public static partial class CrystalLinkEnterDungeonRspReflection {

  #region Descriptor
  /// <summary>File descriptor for CrystalLinkEnterDungeonRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CrystalLinkEnterDungeonRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBDcnlzdGFsTGlua0VudGVyRHVuZ2VvblJzcC5wcm90bxoZQ3J5c3RhbExp",
          "bmtUZWFtSW5mby5wcm90byKEAQoaQ3J5c3RhbExpbmtFbnRlckR1bmdlb25S",
          "c3ASDwoHcmV0Y29kZRgFIAEoBRIVCg1kaWZmaWN1bHR5X2lkGA8gASgNEhAK",
          "CGxldmVsX2lkGAcgASgNEiwKDnRlYW1faW5mb19saXN0GAwgAygLMhQuQ3J5",
          "c3RhbExpbmtUZWFtSW5mb0IWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CrystalLinkTeamInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CrystalLinkEnterDungeonRsp), global::CrystalLinkEnterDungeonRsp.Parser, new[]{ "Retcode", "DifficultyId", "LevelId", "TeamInfoList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 8628;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class CrystalLinkEnterDungeonRsp : pb::IMessage<CrystalLinkEnterDungeonRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CrystalLinkEnterDungeonRsp> _parser = new pb::MessageParser<CrystalLinkEnterDungeonRsp>(() => new CrystalLinkEnterDungeonRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CrystalLinkEnterDungeonRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CrystalLinkEnterDungeonRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CrystalLinkEnterDungeonRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CrystalLinkEnterDungeonRsp(CrystalLinkEnterDungeonRsp other) : this() {
    retcode_ = other.retcode_;
    difficultyId_ = other.difficultyId_;
    levelId_ = other.levelId_;
    teamInfoList_ = other.teamInfoList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CrystalLinkEnterDungeonRsp Clone() {
    return new CrystalLinkEnterDungeonRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 5;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "difficulty_id" field.</summary>
  public const int DifficultyIdFieldNumber = 15;
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
  public const int LevelIdFieldNumber = 7;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "team_info_list" field.</summary>
  public const int TeamInfoListFieldNumber = 12;
  private static readonly pb::FieldCodec<global::CrystalLinkTeamInfo> _repeated_teamInfoList_codec
      = pb::FieldCodec.ForMessage(98, global::CrystalLinkTeamInfo.Parser);
  private readonly pbc::RepeatedField<global::CrystalLinkTeamInfo> teamInfoList_ = new pbc::RepeatedField<global::CrystalLinkTeamInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::CrystalLinkTeamInfo> TeamInfoList {
    get { return teamInfoList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CrystalLinkEnterDungeonRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CrystalLinkEnterDungeonRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if (DifficultyId != other.DifficultyId) return false;
    if (LevelId != other.LevelId) return false;
    if(!teamInfoList_.Equals(other.teamInfoList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    hash ^= teamInfoList_.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(40);
      output.WriteInt32(Retcode);
    }
    if (LevelId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(LevelId);
    }
    teamInfoList_.WriteTo(output, _repeated_teamInfoList_codec);
    if (DifficultyId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(DifficultyId);
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
    if (Retcode != 0) {
      output.WriteRawTag(40);
      output.WriteInt32(Retcode);
    }
    if (LevelId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(LevelId);
    }
    teamInfoList_.WriteTo(ref output, _repeated_teamInfoList_codec);
    if (DifficultyId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(DifficultyId);
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
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (DifficultyId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    size += teamInfoList_.CalculateSize(_repeated_teamInfoList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CrystalLinkEnterDungeonRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.DifficultyId != 0) {
      DifficultyId = other.DifficultyId;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    teamInfoList_.Add(other.teamInfoList_);
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
          Retcode = input.ReadInt32();
          break;
        }
        case 56: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 98: {
          teamInfoList_.AddEntriesFrom(input, _repeated_teamInfoList_codec);
          break;
        }
        case 120: {
          DifficultyId = input.ReadUInt32();
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
          Retcode = input.ReadInt32();
          break;
        }
        case 56: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 98: {
          teamInfoList_.AddEntriesFrom(ref input, _repeated_teamInfoList_codec);
          break;
        }
        case 120: {
          DifficultyId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
