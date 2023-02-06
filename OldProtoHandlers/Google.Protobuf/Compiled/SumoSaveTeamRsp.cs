// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoSaveTeamRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SumoSaveTeamRsp.proto</summary>
public static partial class SumoSaveTeamRspReflection {

  #region Descriptor
  /// <summary>File descriptor for SumoSaveTeamRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SumoSaveTeamRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVTdW1vU2F2ZVRlYW1Sc3AucHJvdG8aElN1bW9UZWFtRGF0YS5wcm90byKC",
          "AQoPU3Vtb1NhdmVUZWFtUnNwEhAKCHN0YWdlX2lkGAkgASgNEg8KB3JldGNv",
          "ZGUYAiABKAUSEwoLYWN0aXZpdHlfaWQYCyABKA0SIAoJdGVhbV9saXN0GA0g",
          "AygLMg0uU3Vtb1RlYW1EYXRhEhUKDWRpZmZpY3VsdHlfaWQYCiABKA1CHgoc",
          "ZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SumoTeamDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SumoSaveTeamRsp), global::SumoSaveTeamRsp.Parser, new[]{ "StageId", "Retcode", "ActivityId", "TeamList", "DifficultyId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8319
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class SumoSaveTeamRsp : pb::IMessage<SumoSaveTeamRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SumoSaveTeamRsp> _parser = new pb::MessageParser<SumoSaveTeamRsp>(() => new SumoSaveTeamRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SumoSaveTeamRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SumoSaveTeamRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SumoSaveTeamRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SumoSaveTeamRsp(SumoSaveTeamRsp other) : this() {
    stageId_ = other.stageId_;
    retcode_ = other.retcode_;
    activityId_ = other.activityId_;
    teamList_ = other.teamList_.Clone();
    difficultyId_ = other.difficultyId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SumoSaveTeamRsp Clone() {
    return new SumoSaveTeamRsp(this);
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 9;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 2;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "activity_id" field.</summary>
  public const int ActivityIdFieldNumber = 11;
  private uint activityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ActivityId {
    get { return activityId_; }
    set {
      activityId_ = value;
    }
  }

  /// <summary>Field number for the "team_list" field.</summary>
  public const int TeamListFieldNumber = 13;
  private static readonly pb::FieldCodec<global::SumoTeamData> _repeated_teamList_codec
      = pb::FieldCodec.ForMessage(106, global::SumoTeamData.Parser);
  private readonly pbc::RepeatedField<global::SumoTeamData> teamList_ = new pbc::RepeatedField<global::SumoTeamData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::SumoTeamData> TeamList {
    get { return teamList_; }
  }

  /// <summary>Field number for the "difficulty_id" field.</summary>
  public const int DifficultyIdFieldNumber = 10;
  private uint difficultyId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DifficultyId {
    get { return difficultyId_; }
    set {
      difficultyId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SumoSaveTeamRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SumoSaveTeamRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StageId != other.StageId) return false;
    if (Retcode != other.Retcode) return false;
    if (ActivityId != other.ActivityId) return false;
    if(!teamList_.Equals(other.teamList_)) return false;
    if (DifficultyId != other.DifficultyId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StageId != 0) hash ^= StageId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
    hash ^= teamList_.GetHashCode();
    if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
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
      output.WriteRawTag(16);
      output.WriteInt32(Retcode);
    }
    if (StageId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(StageId);
    }
    if (DifficultyId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DifficultyId);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ActivityId);
    }
    teamList_.WriteTo(output, _repeated_teamList_codec);
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
      output.WriteRawTag(16);
      output.WriteInt32(Retcode);
    }
    if (StageId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(StageId);
    }
    if (DifficultyId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DifficultyId);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ActivityId);
    }
    teamList_.WriteTo(ref output, _repeated_teamList_codec);
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
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (ActivityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
    }
    size += teamList_.CalculateSize(_repeated_teamList_codec);
    if (DifficultyId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SumoSaveTeamRsp other) {
    if (other == null) {
      return;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.ActivityId != 0) {
      ActivityId = other.ActivityId;
    }
    teamList_.Add(other.teamList_);
    if (other.DifficultyId != 0) {
      DifficultyId = other.DifficultyId;
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
        case 16: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          StageId = input.ReadUInt32();
          break;
        }
        case 80: {
          DifficultyId = input.ReadUInt32();
          break;
        }
        case 88: {
          ActivityId = input.ReadUInt32();
          break;
        }
        case 106: {
          teamList_.AddEntriesFrom(input, _repeated_teamList_codec);
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
        case 16: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          StageId = input.ReadUInt32();
          break;
        }
        case 80: {
          DifficultyId = input.ReadUInt32();
          break;
        }
        case 88: {
          ActivityId = input.ReadUInt32();
          break;
        }
        case 106: {
          teamList_.AddEntriesFrom(ref input, _repeated_teamList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
