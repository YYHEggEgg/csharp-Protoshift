// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoSetNoSwitchPunishTimeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SumoSetNoSwitchPunishTimeNotify.proto</summary>
public static partial class SumoSetNoSwitchPunishTimeNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for SumoSetNoSwitchPunishTimeNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SumoSetNoSwitchPunishTimeNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVTdW1vU2V0Tm9Td2l0Y2hQdW5pc2hUaW1lTm90aWZ5LnByb3RvGhVTdW1v",
          "RHVuZ2VvblRlYW0ucHJvdG8izAEKH1N1bW9TZXROb1N3aXRjaFB1bmlzaFRp",
          "bWVOb3RpZnkSEAoIc3RhZ2VfaWQYDyABKA0SGwoTVW5rMzMwMF9DQkFNTEhE",
          "TUtKRhgKIAEoDRITCgthY3Rpdml0eV9pZBgFIAEoDRIbChNVbmszMzAwX0JO",
          "SkJJR0hJSk9DGAMgASgNEhsKE1VuazMzMDBfREpCSkFDR0hHRE0YCSABKA0S",
          "KwoRZHVuZ2Vvbl90ZWFtX2xpc3QYAiADKAsyEC5TdW1vRHVuZ2VvblRlYW1C",
          "FgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SumoDungeonTeamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SumoSetNoSwitchPunishTimeNotify), global::SumoSetNoSwitchPunishTimeNotify.Parser, new[]{ "StageId", "Unk3300CBAMLHDMKJF", "ActivityId", "Unk3300BNJBIGHIJOC", "Unk3300DJBJACGHGDM", "DungeonTeamList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 8610;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class SumoSetNoSwitchPunishTimeNotify : pb::IMessage<SumoSetNoSwitchPunishTimeNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SumoSetNoSwitchPunishTimeNotify> _parser = new pb::MessageParser<SumoSetNoSwitchPunishTimeNotify>(() => new SumoSetNoSwitchPunishTimeNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SumoSetNoSwitchPunishTimeNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SumoSetNoSwitchPunishTimeNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SumoSetNoSwitchPunishTimeNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SumoSetNoSwitchPunishTimeNotify(SumoSetNoSwitchPunishTimeNotify other) : this() {
    stageId_ = other.stageId_;
    unk3300CBAMLHDMKJF_ = other.unk3300CBAMLHDMKJF_;
    activityId_ = other.activityId_;
    unk3300BNJBIGHIJOC_ = other.unk3300BNJBIGHIJOC_;
    unk3300DJBJACGHGDM_ = other.unk3300DJBJACGHGDM_;
    dungeonTeamList_ = other.dungeonTeamList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SumoSetNoSwitchPunishTimeNotify Clone() {
    return new SumoSetNoSwitchPunishTimeNotify(this);
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 15;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_CBAMLHDMKJF" field.</summary>
  public const int Unk3300CBAMLHDMKJFFieldNumber = 10;
  private uint unk3300CBAMLHDMKJF_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300CBAMLHDMKJF {
    get { return unk3300CBAMLHDMKJF_; }
    set {
      unk3300CBAMLHDMKJF_ = value;
    }
  }

  /// <summary>Field number for the "activity_id" field.</summary>
  public const int ActivityIdFieldNumber = 5;
  private uint activityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ActivityId {
    get { return activityId_; }
    set {
      activityId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_BNJBIGHIJOC" field.</summary>
  public const int Unk3300BNJBIGHIJOCFieldNumber = 3;
  private uint unk3300BNJBIGHIJOC_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300BNJBIGHIJOC {
    get { return unk3300BNJBIGHIJOC_; }
    set {
      unk3300BNJBIGHIJOC_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_DJBJACGHGDM" field.</summary>
  public const int Unk3300DJBJACGHGDMFieldNumber = 9;
  private uint unk3300DJBJACGHGDM_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300DJBJACGHGDM {
    get { return unk3300DJBJACGHGDM_; }
    set {
      unk3300DJBJACGHGDM_ = value;
    }
  }

  /// <summary>Field number for the "dungeon_team_list" field.</summary>
  public const int DungeonTeamListFieldNumber = 2;
  private static readonly pb::FieldCodec<global::SumoDungeonTeam> _repeated_dungeonTeamList_codec
      = pb::FieldCodec.ForMessage(18, global::SumoDungeonTeam.Parser);
  private readonly pbc::RepeatedField<global::SumoDungeonTeam> dungeonTeamList_ = new pbc::RepeatedField<global::SumoDungeonTeam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::SumoDungeonTeam> DungeonTeamList {
    get { return dungeonTeamList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SumoSetNoSwitchPunishTimeNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SumoSetNoSwitchPunishTimeNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StageId != other.StageId) return false;
    if (Unk3300CBAMLHDMKJF != other.Unk3300CBAMLHDMKJF) return false;
    if (ActivityId != other.ActivityId) return false;
    if (Unk3300BNJBIGHIJOC != other.Unk3300BNJBIGHIJOC) return false;
    if (Unk3300DJBJACGHGDM != other.Unk3300DJBJACGHGDM) return false;
    if(!dungeonTeamList_.Equals(other.dungeonTeamList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StageId != 0) hash ^= StageId.GetHashCode();
    if (Unk3300CBAMLHDMKJF != 0) hash ^= Unk3300CBAMLHDMKJF.GetHashCode();
    if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
    if (Unk3300BNJBIGHIJOC != 0) hash ^= Unk3300BNJBIGHIJOC.GetHashCode();
    if (Unk3300DJBJACGHGDM != 0) hash ^= Unk3300DJBJACGHGDM.GetHashCode();
    hash ^= dungeonTeamList_.GetHashCode();
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
    dungeonTeamList_.WriteTo(output, _repeated_dungeonTeamList_codec);
    if (Unk3300BNJBIGHIJOC != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Unk3300BNJBIGHIJOC);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ActivityId);
    }
    if (Unk3300DJBJACGHGDM != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Unk3300DJBJACGHGDM);
    }
    if (Unk3300CBAMLHDMKJF != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Unk3300CBAMLHDMKJF);
    }
    if (StageId != 0) {
      output.WriteRawTag(120);
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
    dungeonTeamList_.WriteTo(ref output, _repeated_dungeonTeamList_codec);
    if (Unk3300BNJBIGHIJOC != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Unk3300BNJBIGHIJOC);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ActivityId);
    }
    if (Unk3300DJBJACGHGDM != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Unk3300DJBJACGHGDM);
    }
    if (Unk3300CBAMLHDMKJF != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Unk3300CBAMLHDMKJF);
    }
    if (StageId != 0) {
      output.WriteRawTag(120);
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
    if (Unk3300CBAMLHDMKJF != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300CBAMLHDMKJF);
    }
    if (ActivityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
    }
    if (Unk3300BNJBIGHIJOC != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BNJBIGHIJOC);
    }
    if (Unk3300DJBJACGHGDM != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DJBJACGHGDM);
    }
    size += dungeonTeamList_.CalculateSize(_repeated_dungeonTeamList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SumoSetNoSwitchPunishTimeNotify other) {
    if (other == null) {
      return;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    if (other.Unk3300CBAMLHDMKJF != 0) {
      Unk3300CBAMLHDMKJF = other.Unk3300CBAMLHDMKJF;
    }
    if (other.ActivityId != 0) {
      ActivityId = other.ActivityId;
    }
    if (other.Unk3300BNJBIGHIJOC != 0) {
      Unk3300BNJBIGHIJOC = other.Unk3300BNJBIGHIJOC;
    }
    if (other.Unk3300DJBJACGHGDM != 0) {
      Unk3300DJBJACGHGDM = other.Unk3300DJBJACGHGDM;
    }
    dungeonTeamList_.Add(other.dungeonTeamList_);
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
        case 18: {
          dungeonTeamList_.AddEntriesFrom(input, _repeated_dungeonTeamList_codec);
          break;
        }
        case 24: {
          Unk3300BNJBIGHIJOC = input.ReadUInt32();
          break;
        }
        case 40: {
          ActivityId = input.ReadUInt32();
          break;
        }
        case 72: {
          Unk3300DJBJACGHGDM = input.ReadUInt32();
          break;
        }
        case 80: {
          Unk3300CBAMLHDMKJF = input.ReadUInt32();
          break;
        }
        case 120: {
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
        case 18: {
          dungeonTeamList_.AddEntriesFrom(ref input, _repeated_dungeonTeamList_codec);
          break;
        }
        case 24: {
          Unk3300BNJBIGHIJOC = input.ReadUInt32();
          break;
        }
        case 40: {
          ActivityId = input.ReadUInt32();
          break;
        }
        case 72: {
          Unk3300DJBJACGHGDM = input.ReadUInt32();
          break;
        }
        case 80: {
          Unk3300CBAMLHDMKJF = input.ReadUInt32();
          break;
        }
        case 120: {
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