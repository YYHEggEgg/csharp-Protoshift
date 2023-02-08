// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrialAvatarActivityRewardDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from TrialAvatarActivityRewardDetailInfo.proto</summary>
  public static partial class TrialAvatarActivityRewardDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TrialAvatarActivityRewardDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrialAvatarActivityRewardDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilUcmlhbEF2YXRhckFjdGl2aXR5UmV3YXJkRGV0YWlsSW5mby5wcm90byKI",
            "AQojVHJpYWxBdmF0YXJBY3Rpdml0eVJld2FyZERldGFpbEluZm8SHQoVdHJp",
            "YWxfYXZhdGFyX2luZGV4X2lkGAQgASgNEhcKD3JlY2VpdmVkX3Jld2FyZBgO",
            "IAEoCBIWCg5wYXNzZWRfZHVuZ2VvbhgFIAEoCBIRCglyZXdhcmRfaWQYCyAB",
            "KA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.TrialAvatarActivityRewardDetailInfo), global::NewProtos.TrialAvatarActivityRewardDetailInfo.Parser, new[]{ "TrialAvatarIndexId", "ReceivedReward", "PassedDungeon", "RewardId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrialAvatarActivityRewardDetailInfo : pb::IMessage<TrialAvatarActivityRewardDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrialAvatarActivityRewardDetailInfo> _parser = new pb::MessageParser<TrialAvatarActivityRewardDetailInfo>(() => new TrialAvatarActivityRewardDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrialAvatarActivityRewardDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.TrialAvatarActivityRewardDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarActivityRewardDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarActivityRewardDetailInfo(TrialAvatarActivityRewardDetailInfo other) : this() {
      trialAvatarIndexId_ = other.trialAvatarIndexId_;
      receivedReward_ = other.receivedReward_;
      passedDungeon_ = other.passedDungeon_;
      rewardId_ = other.rewardId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarActivityRewardDetailInfo Clone() {
      return new TrialAvatarActivityRewardDetailInfo(this);
    }

    /// <summary>Field number for the "trial_avatar_index_id" field.</summary>
    public const int TrialAvatarIndexIdFieldNumber = 4;
    private uint trialAvatarIndexId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TrialAvatarIndexId {
      get { return trialAvatarIndexId_; }
      set {
        trialAvatarIndexId_ = value;
      }
    }

    /// <summary>Field number for the "received_reward" field.</summary>
    public const int ReceivedRewardFieldNumber = 14;
    private bool receivedReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ReceivedReward {
      get { return receivedReward_; }
      set {
        receivedReward_ = value;
      }
    }

    /// <summary>Field number for the "passed_dungeon" field.</summary>
    public const int PassedDungeonFieldNumber = 5;
    private bool passedDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PassedDungeon {
      get { return passedDungeon_; }
      set {
        passedDungeon_ = value;
      }
    }

    /// <summary>Field number for the "reward_id" field.</summary>
    public const int RewardIdFieldNumber = 11;
    private uint rewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrialAvatarActivityRewardDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrialAvatarActivityRewardDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TrialAvatarIndexId != other.TrialAvatarIndexId) return false;
      if (ReceivedReward != other.ReceivedReward) return false;
      if (PassedDungeon != other.PassedDungeon) return false;
      if (RewardId != other.RewardId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TrialAvatarIndexId != 0) hash ^= TrialAvatarIndexId.GetHashCode();
      if (ReceivedReward != false) hash ^= ReceivedReward.GetHashCode();
      if (PassedDungeon != false) hash ^= PassedDungeon.GetHashCode();
      if (RewardId != 0) hash ^= RewardId.GetHashCode();
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
      if (TrialAvatarIndexId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TrialAvatarIndexId);
      }
      if (PassedDungeon != false) {
        output.WriteRawTag(40);
        output.WriteBool(PassedDungeon);
      }
      if (RewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RewardId);
      }
      if (ReceivedReward != false) {
        output.WriteRawTag(112);
        output.WriteBool(ReceivedReward);
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
      if (TrialAvatarIndexId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TrialAvatarIndexId);
      }
      if (PassedDungeon != false) {
        output.WriteRawTag(40);
        output.WriteBool(PassedDungeon);
      }
      if (RewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RewardId);
      }
      if (ReceivedReward != false) {
        output.WriteRawTag(112);
        output.WriteBool(ReceivedReward);
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
      if (TrialAvatarIndexId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialAvatarIndexId);
      }
      if (ReceivedReward != false) {
        size += 1 + 1;
      }
      if (PassedDungeon != false) {
        size += 1 + 1;
      }
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrialAvatarActivityRewardDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.TrialAvatarIndexId != 0) {
        TrialAvatarIndexId = other.TrialAvatarIndexId;
      }
      if (other.ReceivedReward != false) {
        ReceivedReward = other.ReceivedReward;
      }
      if (other.PassedDungeon != false) {
        PassedDungeon = other.PassedDungeon;
      }
      if (other.RewardId != 0) {
        RewardId = other.RewardId;
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
            TrialAvatarIndexId = input.ReadUInt32();
            break;
          }
          case 40: {
            PassedDungeon = input.ReadBool();
            break;
          }
          case 88: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 112: {
            ReceivedReward = input.ReadBool();
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
            TrialAvatarIndexId = input.ReadUInt32();
            break;
          }
          case 40: {
            PassedDungeon = input.ReadBool();
            break;
          }
          case 88: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 112: {
            ReceivedReward = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
