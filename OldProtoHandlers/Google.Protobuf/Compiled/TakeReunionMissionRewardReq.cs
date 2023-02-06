// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeReunionMissionRewardReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TakeReunionMissionRewardReq.proto</summary>
public static partial class TakeReunionMissionRewardReqReflection {

  #region Descriptor
  /// <summary>File descriptor for TakeReunionMissionRewardReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TakeReunionMissionRewardReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFUYWtlUmV1bmlvbk1pc3Npb25SZXdhcmRSZXEucHJvdG8iWgobVGFrZVJl",
          "dW5pb25NaXNzaW9uUmV3YXJkUmVxEhEKCXJld2FyZF9pZBgHIAEoDRIUCgxy",
          "ZXdhcmRfaW5kZXgYBCABKA0SEgoKbWlzc2lvbl9pZBgMIAEoDUIeChxlbXUu",
          "Z3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TakeReunionMissionRewardReq), global::TakeReunionMissionRewardReq.Parser, new[]{ "RewardId", "RewardIndex", "MissionId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 5092
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class TakeReunionMissionRewardReq : pb::IMessage<TakeReunionMissionRewardReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TakeReunionMissionRewardReq> _parser = new pb::MessageParser<TakeReunionMissionRewardReq>(() => new TakeReunionMissionRewardReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TakeReunionMissionRewardReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TakeReunionMissionRewardReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeReunionMissionRewardReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeReunionMissionRewardReq(TakeReunionMissionRewardReq other) : this() {
    rewardId_ = other.rewardId_;
    rewardIndex_ = other.rewardIndex_;
    missionId_ = other.missionId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeReunionMissionRewardReq Clone() {
    return new TakeReunionMissionRewardReq(this);
  }

  /// <summary>Field number for the "reward_id" field.</summary>
  public const int RewardIdFieldNumber = 7;
  private uint rewardId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RewardId {
    get { return rewardId_; }
    set {
      rewardId_ = value;
    }
  }

  /// <summary>Field number for the "reward_index" field.</summary>
  public const int RewardIndexFieldNumber = 4;
  private uint rewardIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RewardIndex {
    get { return rewardIndex_; }
    set {
      rewardIndex_ = value;
    }
  }

  /// <summary>Field number for the "mission_id" field.</summary>
  public const int MissionIdFieldNumber = 12;
  private uint missionId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MissionId {
    get { return missionId_; }
    set {
      missionId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TakeReunionMissionRewardReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TakeReunionMissionRewardReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RewardId != other.RewardId) return false;
    if (RewardIndex != other.RewardIndex) return false;
    if (MissionId != other.MissionId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RewardId != 0) hash ^= RewardId.GetHashCode();
    if (RewardIndex != 0) hash ^= RewardIndex.GetHashCode();
    if (MissionId != 0) hash ^= MissionId.GetHashCode();
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
    if (RewardIndex != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(RewardIndex);
    }
    if (RewardId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(RewardId);
    }
    if (MissionId != 0) {
      output.WriteRawTag(96);
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
    if (RewardIndex != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(RewardIndex);
    }
    if (RewardId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(RewardId);
    }
    if (MissionId != 0) {
      output.WriteRawTag(96);
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
    if (RewardId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
    }
    if (RewardIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardIndex);
    }
    if (MissionId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MissionId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TakeReunionMissionRewardReq other) {
    if (other == null) {
      return;
    }
    if (other.RewardId != 0) {
      RewardId = other.RewardId;
    }
    if (other.RewardIndex != 0) {
      RewardIndex = other.RewardIndex;
    }
    if (other.MissionId != 0) {
      MissionId = other.MissionId;
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
        case 32: {
          RewardIndex = input.ReadUInt32();
          break;
        }
        case 56: {
          RewardId = input.ReadUInt32();
          break;
        }
        case 96: {
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
        case 32: {
          RewardIndex = input.ReadUInt32();
          break;
        }
        case 56: {
          RewardId = input.ReadUInt32();
          break;
        }
        case 96: {
          MissionId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
