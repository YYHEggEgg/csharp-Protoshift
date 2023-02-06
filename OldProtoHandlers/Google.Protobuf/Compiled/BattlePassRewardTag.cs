// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassRewardTag.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BattlePassRewardTag.proto</summary>
public static partial class BattlePassRewardTagReflection {

  #region Descriptor
  /// <summary>File descriptor for BattlePassRewardTag.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BattlePassRewardTagReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlCYXR0bGVQYXNzUmV3YXJkVGFnLnByb3RvGhxCYXR0bGVQYXNzVW5sb2Nr",
          "U3RhdHVzLnByb3RvImcKE0JhdHRsZVBhc3NSZXdhcmRUYWcSDQoFbGV2ZWwY",
          "BCABKA0SLgoNdW5sb2NrX3N0YXR1cxgCIAEoDjIXLkJhdHRsZVBhc3NVbmxv",
          "Y2tTdGF0dXMSEQoJcmV3YXJkX2lkGAcgASgNQh4KHGVtdS5ncmFzc2N1dHRl",
          "ci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BattlePassUnlockStatusReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BattlePassRewardTag), global::BattlePassRewardTag.Parser, new[]{ "Level", "UnlockStatus", "RewardId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BattlePassRewardTag : pb::IMessage<BattlePassRewardTag>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BattlePassRewardTag> _parser = new pb::MessageParser<BattlePassRewardTag>(() => new BattlePassRewardTag());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BattlePassRewardTag> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BattlePassRewardTagReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassRewardTag() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassRewardTag(BattlePassRewardTag other) : this() {
    level_ = other.level_;
    unlockStatus_ = other.unlockStatus_;
    rewardId_ = other.rewardId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassRewardTag Clone() {
    return new BattlePassRewardTag(this);
  }

  /// <summary>Field number for the "level" field.</summary>
  public const int LevelFieldNumber = 4;
  private uint level_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Level {
    get { return level_; }
    set {
      level_ = value;
    }
  }

  /// <summary>Field number for the "unlock_status" field.</summary>
  public const int UnlockStatusFieldNumber = 2;
  private global::BattlePassUnlockStatus unlockStatus_ = global::BattlePassUnlockStatus.Invalid;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::BattlePassUnlockStatus UnlockStatus {
    get { return unlockStatus_; }
    set {
      unlockStatus_ = value;
    }
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

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BattlePassRewardTag);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BattlePassRewardTag other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Level != other.Level) return false;
    if (UnlockStatus != other.UnlockStatus) return false;
    if (RewardId != other.RewardId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Level != 0) hash ^= Level.GetHashCode();
    if (UnlockStatus != global::BattlePassUnlockStatus.Invalid) hash ^= UnlockStatus.GetHashCode();
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
    if (UnlockStatus != global::BattlePassUnlockStatus.Invalid) {
      output.WriteRawTag(16);
      output.WriteEnum((int) UnlockStatus);
    }
    if (Level != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Level);
    }
    if (RewardId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(RewardId);
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
    if (UnlockStatus != global::BattlePassUnlockStatus.Invalid) {
      output.WriteRawTag(16);
      output.WriteEnum((int) UnlockStatus);
    }
    if (Level != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Level);
    }
    if (RewardId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(RewardId);
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
    if (Level != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
    }
    if (UnlockStatus != global::BattlePassUnlockStatus.Invalid) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnlockStatus);
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
  public void MergeFrom(BattlePassRewardTag other) {
    if (other == null) {
      return;
    }
    if (other.Level != 0) {
      Level = other.Level;
    }
    if (other.UnlockStatus != global::BattlePassUnlockStatus.Invalid) {
      UnlockStatus = other.UnlockStatus;
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
        case 16: {
          UnlockStatus = (global::BattlePassUnlockStatus) input.ReadEnum();
          break;
        }
        case 32: {
          Level = input.ReadUInt32();
          break;
        }
        case 56: {
          RewardId = input.ReadUInt32();
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
          UnlockStatus = (global::BattlePassUnlockStatus) input.ReadEnum();
          break;
        }
        case 32: {
          Level = input.ReadUInt32();
          break;
        }
        case 56: {
          RewardId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
