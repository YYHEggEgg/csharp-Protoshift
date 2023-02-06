// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassMission.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BattlePassMission.proto</summary>
public static partial class BattlePassMissionReflection {

  #region Descriptor
  /// <summary>File descriptor for BattlePassMission.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BattlePassMissionReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdCYXR0bGVQYXNzTWlzc2lvbi5wcm90byLRAgoRQmF0dGxlUGFzc01pc3Np",
          "b24SFAoMY3VyX3Byb2dyZXNzGAogASgNEhQKDG1pc3Npb25fdHlwZRgJIAEo",
          "DRIgChhyZXdhcmRfYmF0dGxlX3Bhc3NfcG9pbnQYDiABKA0SFgoOdG90YWxf",
          "cHJvZ3Jlc3MYDCABKA0SEgoKbWlzc2lvbl9pZBgPIAEoDRI4Cg5taXNzaW9u",
          "X3N0YXR1cxgLIAEoDjIgLkJhdHRsZVBhc3NNaXNzaW9uLk1pc3Npb25TdGF0",
          "dXMihwEKDU1pc3Npb25TdGF0dXMSGgoWTUlTU0lPTl9TVEFUVVNfSU5WQUxJ",
          "RBAAEh0KGU1JU1NJT05fU1RBVFVTX1VORklOSVNIRUQQARIbChdNSVNTSU9O",
          "X1NUQVRVU19GSU5JU0hFRBACEh4KGk1JU1NJT05fU1RBVFVTX1BPSU5UX1RB",
          "S0VOEANCFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BattlePassMission), global::BattlePassMission.Parser, new[]{ "CurProgress", "MissionType", "RewardBattlePassPoint", "TotalProgress", "MissionId", "MissionStatus" }, null, new[]{ typeof(global::BattlePassMission.Types.MissionStatus) }, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BattlePassMission : pb::IMessage<BattlePassMission>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BattlePassMission> _parser = new pb::MessageParser<BattlePassMission>(() => new BattlePassMission());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BattlePassMission> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BattlePassMissionReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassMission() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassMission(BattlePassMission other) : this() {
    curProgress_ = other.curProgress_;
    missionType_ = other.missionType_;
    rewardBattlePassPoint_ = other.rewardBattlePassPoint_;
    totalProgress_ = other.totalProgress_;
    missionId_ = other.missionId_;
    missionStatus_ = other.missionStatus_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassMission Clone() {
    return new BattlePassMission(this);
  }

  /// <summary>Field number for the "cur_progress" field.</summary>
  public const int CurProgressFieldNumber = 10;
  private uint curProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurProgress {
    get { return curProgress_; }
    set {
      curProgress_ = value;
    }
  }

  /// <summary>Field number for the "mission_type" field.</summary>
  public const int MissionTypeFieldNumber = 9;
  private uint missionType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MissionType {
    get { return missionType_; }
    set {
      missionType_ = value;
    }
  }

  /// <summary>Field number for the "reward_battle_pass_point" field.</summary>
  public const int RewardBattlePassPointFieldNumber = 14;
  private uint rewardBattlePassPoint_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RewardBattlePassPoint {
    get { return rewardBattlePassPoint_; }
    set {
      rewardBattlePassPoint_ = value;
    }
  }

  /// <summary>Field number for the "total_progress" field.</summary>
  public const int TotalProgressFieldNumber = 12;
  private uint totalProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalProgress {
    get { return totalProgress_; }
    set {
      totalProgress_ = value;
    }
  }

  /// <summary>Field number for the "mission_id" field.</summary>
  public const int MissionIdFieldNumber = 15;
  private uint missionId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MissionId {
    get { return missionId_; }
    set {
      missionId_ = value;
    }
  }

  /// <summary>Field number for the "mission_status" field.</summary>
  public const int MissionStatusFieldNumber = 11;
  private global::BattlePassMission.Types.MissionStatus missionStatus_ = global::BattlePassMission.Types.MissionStatus.Invalid;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::BattlePassMission.Types.MissionStatus MissionStatus {
    get { return missionStatus_; }
    set {
      missionStatus_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BattlePassMission);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BattlePassMission other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CurProgress != other.CurProgress) return false;
    if (MissionType != other.MissionType) return false;
    if (RewardBattlePassPoint != other.RewardBattlePassPoint) return false;
    if (TotalProgress != other.TotalProgress) return false;
    if (MissionId != other.MissionId) return false;
    if (MissionStatus != other.MissionStatus) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (CurProgress != 0) hash ^= CurProgress.GetHashCode();
    if (MissionType != 0) hash ^= MissionType.GetHashCode();
    if (RewardBattlePassPoint != 0) hash ^= RewardBattlePassPoint.GetHashCode();
    if (TotalProgress != 0) hash ^= TotalProgress.GetHashCode();
    if (MissionId != 0) hash ^= MissionId.GetHashCode();
    if (MissionStatus != global::BattlePassMission.Types.MissionStatus.Invalid) hash ^= MissionStatus.GetHashCode();
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
    if (MissionType != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(MissionType);
    }
    if (CurProgress != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(CurProgress);
    }
    if (MissionStatus != global::BattlePassMission.Types.MissionStatus.Invalid) {
      output.WriteRawTag(88);
      output.WriteEnum((int) MissionStatus);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(TotalProgress);
    }
    if (RewardBattlePassPoint != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(RewardBattlePassPoint);
    }
    if (MissionId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(MissionId);
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
    if (MissionType != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(MissionType);
    }
    if (CurProgress != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(CurProgress);
    }
    if (MissionStatus != global::BattlePassMission.Types.MissionStatus.Invalid) {
      output.WriteRawTag(88);
      output.WriteEnum((int) MissionStatus);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(TotalProgress);
    }
    if (RewardBattlePassPoint != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(RewardBattlePassPoint);
    }
    if (MissionId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(MissionId);
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
    if (CurProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurProgress);
    }
    if (MissionType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MissionType);
    }
    if (RewardBattlePassPoint != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardBattlePassPoint);
    }
    if (TotalProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalProgress);
    }
    if (MissionId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MissionId);
    }
    if (MissionStatus != global::BattlePassMission.Types.MissionStatus.Invalid) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MissionStatus);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BattlePassMission other) {
    if (other == null) {
      return;
    }
    if (other.CurProgress != 0) {
      CurProgress = other.CurProgress;
    }
    if (other.MissionType != 0) {
      MissionType = other.MissionType;
    }
    if (other.RewardBattlePassPoint != 0) {
      RewardBattlePassPoint = other.RewardBattlePassPoint;
    }
    if (other.TotalProgress != 0) {
      TotalProgress = other.TotalProgress;
    }
    if (other.MissionId != 0) {
      MissionId = other.MissionId;
    }
    if (other.MissionStatus != global::BattlePassMission.Types.MissionStatus.Invalid) {
      MissionStatus = other.MissionStatus;
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
        case 72: {
          MissionType = input.ReadUInt32();
          break;
        }
        case 80: {
          CurProgress = input.ReadUInt32();
          break;
        }
        case 88: {
          MissionStatus = (global::BattlePassMission.Types.MissionStatus) input.ReadEnum();
          break;
        }
        case 96: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 112: {
          RewardBattlePassPoint = input.ReadUInt32();
          break;
        }
        case 120: {
          MissionId = input.ReadUInt32();
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
        case 72: {
          MissionType = input.ReadUInt32();
          break;
        }
        case 80: {
          CurProgress = input.ReadUInt32();
          break;
        }
        case 88: {
          MissionStatus = (global::BattlePassMission.Types.MissionStatus) input.ReadEnum();
          break;
        }
        case 96: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 112: {
          RewardBattlePassPoint = input.ReadUInt32();
          break;
        }
        case 120: {
          MissionId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the BattlePassMission message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum MissionStatus {
      [pbr::OriginalName("MISSION_STATUS_INVALID")] Invalid = 0,
      [pbr::OriginalName("MISSION_STATUS_UNFINISHED")] Unfinished = 1,
      [pbr::OriginalName("MISSION_STATUS_FINISHED")] Finished = 2,
      [pbr::OriginalName("MISSION_STATUS_POINT_TAKEN")] PointTaken = 3,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
