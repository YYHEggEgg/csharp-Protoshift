// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabLoopDungeonResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ChannelerSlabLoopDungeonResultInfo.proto</summary>
public static partial class ChannelerSlabLoopDungeonResultInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for ChannelerSlabLoopDungeonResultInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ChannelerSlabLoopDungeonResultInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CihDaGFubmVsZXJTbGFiTG9vcER1bmdlb25SZXN1bHRJbmZvLnByb3RvIp8B",
          "CiJDaGFubmVsZXJTbGFiTG9vcER1bmdlb25SZXN1bHRJbmZvEhUKDWR1bmdl",
          "b25faW5kZXgYByABKA0SFwoPY2hhbGxlbmdlX3Njb3JlGAUgASgNEhgKEGlz",
          "X2luX3RpbWVfbGltaXQYCCABKAgSEgoKaXNfc3VjY2VzcxgMIAEoCBIbChNj",
          "aGFsbGVuZ2VfbWF4X3Njb3JlGA0gASgNQhYKFG9yZy5zb3JhcG9pbnRhLnBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ChannelerSlabLoopDungeonResultInfo), global::ChannelerSlabLoopDungeonResultInfo.Parser, new[]{ "DungeonIndex", "ChallengeScore", "IsInTimeLimit", "IsSuccess", "ChallengeMaxScore" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ChannelerSlabLoopDungeonResultInfo : pb::IMessage<ChannelerSlabLoopDungeonResultInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ChannelerSlabLoopDungeonResultInfo> _parser = new pb::MessageParser<ChannelerSlabLoopDungeonResultInfo>(() => new ChannelerSlabLoopDungeonResultInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ChannelerSlabLoopDungeonResultInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ChannelerSlabLoopDungeonResultInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChannelerSlabLoopDungeonResultInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChannelerSlabLoopDungeonResultInfo(ChannelerSlabLoopDungeonResultInfo other) : this() {
    dungeonIndex_ = other.dungeonIndex_;
    challengeScore_ = other.challengeScore_;
    isInTimeLimit_ = other.isInTimeLimit_;
    isSuccess_ = other.isSuccess_;
    challengeMaxScore_ = other.challengeMaxScore_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChannelerSlabLoopDungeonResultInfo Clone() {
    return new ChannelerSlabLoopDungeonResultInfo(this);
  }

  /// <summary>Field number for the "dungeon_index" field.</summary>
  public const int DungeonIndexFieldNumber = 7;
  private uint dungeonIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DungeonIndex {
    get { return dungeonIndex_; }
    set {
      dungeonIndex_ = value;
    }
  }

  /// <summary>Field number for the "challenge_score" field.</summary>
  public const int ChallengeScoreFieldNumber = 5;
  private uint challengeScore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChallengeScore {
    get { return challengeScore_; }
    set {
      challengeScore_ = value;
    }
  }

  /// <summary>Field number for the "is_in_time_limit" field.</summary>
  public const int IsInTimeLimitFieldNumber = 8;
  private bool isInTimeLimit_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsInTimeLimit {
    get { return isInTimeLimit_; }
    set {
      isInTimeLimit_ = value;
    }
  }

  /// <summary>Field number for the "is_success" field.</summary>
  public const int IsSuccessFieldNumber = 12;
  private bool isSuccess_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSuccess {
    get { return isSuccess_; }
    set {
      isSuccess_ = value;
    }
  }

  /// <summary>Field number for the "challenge_max_score" field.</summary>
  public const int ChallengeMaxScoreFieldNumber = 13;
  private uint challengeMaxScore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChallengeMaxScore {
    get { return challengeMaxScore_; }
    set {
      challengeMaxScore_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ChannelerSlabLoopDungeonResultInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ChannelerSlabLoopDungeonResultInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (DungeonIndex != other.DungeonIndex) return false;
    if (ChallengeScore != other.ChallengeScore) return false;
    if (IsInTimeLimit != other.IsInTimeLimit) return false;
    if (IsSuccess != other.IsSuccess) return false;
    if (ChallengeMaxScore != other.ChallengeMaxScore) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (DungeonIndex != 0) hash ^= DungeonIndex.GetHashCode();
    if (ChallengeScore != 0) hash ^= ChallengeScore.GetHashCode();
    if (IsInTimeLimit != false) hash ^= IsInTimeLimit.GetHashCode();
    if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
    if (ChallengeMaxScore != 0) hash ^= ChallengeMaxScore.GetHashCode();
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
    if (ChallengeScore != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ChallengeScore);
    }
    if (DungeonIndex != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(DungeonIndex);
    }
    if (IsInTimeLimit != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsInTimeLimit);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsSuccess);
    }
    if (ChallengeMaxScore != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ChallengeMaxScore);
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
    if (ChallengeScore != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ChallengeScore);
    }
    if (DungeonIndex != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(DungeonIndex);
    }
    if (IsInTimeLimit != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsInTimeLimit);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsSuccess);
    }
    if (ChallengeMaxScore != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ChallengeMaxScore);
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
    if (DungeonIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonIndex);
    }
    if (ChallengeScore != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeScore);
    }
    if (IsInTimeLimit != false) {
      size += 1 + 1;
    }
    if (IsSuccess != false) {
      size += 1 + 1;
    }
    if (ChallengeMaxScore != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeMaxScore);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ChannelerSlabLoopDungeonResultInfo other) {
    if (other == null) {
      return;
    }
    if (other.DungeonIndex != 0) {
      DungeonIndex = other.DungeonIndex;
    }
    if (other.ChallengeScore != 0) {
      ChallengeScore = other.ChallengeScore;
    }
    if (other.IsInTimeLimit != false) {
      IsInTimeLimit = other.IsInTimeLimit;
    }
    if (other.IsSuccess != false) {
      IsSuccess = other.IsSuccess;
    }
    if (other.ChallengeMaxScore != 0) {
      ChallengeMaxScore = other.ChallengeMaxScore;
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
          ChallengeScore = input.ReadUInt32();
          break;
        }
        case 56: {
          DungeonIndex = input.ReadUInt32();
          break;
        }
        case 64: {
          IsInTimeLimit = input.ReadBool();
          break;
        }
        case 96: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 104: {
          ChallengeMaxScore = input.ReadUInt32();
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
          ChallengeScore = input.ReadUInt32();
          break;
        }
        case 56: {
          DungeonIndex = input.ReadUInt32();
          break;
        }
        case 64: {
          IsInTimeLimit = input.ReadBool();
          break;
        }
        case 96: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 104: {
          ChallengeMaxScore = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
