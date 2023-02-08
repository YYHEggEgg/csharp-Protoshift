// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyChallengeDungeonResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from EffigyChallengeDungeonResultInfo.proto</summary>
  public static partial class EffigyChallengeDungeonResultInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyChallengeDungeonResultInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyChallengeDungeonResultInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZFZmZpZ3lDaGFsbGVuZ2VEdW5nZW9uUmVzdWx0SW5mby5wcm90byKcAQog",
            "RWZmaWd5Q2hhbGxlbmdlRHVuZ2VvblJlc3VsdEluZm8SFwoPY2hhbGxlbmdl",
            "X3Njb3JlGAwgASgNEhsKE2NoYWxsZW5nZV9tYXhfc2NvcmUYCCABKA0SEgoK",
            "aXNfc3VjY2VzcxgCIAEoCBIYChBpc19pbl90aW1lX2xpbWl0GAEgASgIEhQK",
            "DGNoYWxsZW5nZV9pZBgPIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.EffigyChallengeDungeonResultInfo), global::NewProtos.EffigyChallengeDungeonResultInfo.Parser, new[]{ "ChallengeScore", "ChallengeMaxScore", "IsSuccess", "IsInTimeLimit", "ChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EffigyChallengeDungeonResultInfo : pb::IMessage<EffigyChallengeDungeonResultInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyChallengeDungeonResultInfo> _parser = new pb::MessageParser<EffigyChallengeDungeonResultInfo>(() => new EffigyChallengeDungeonResultInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyChallengeDungeonResultInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.EffigyChallengeDungeonResultInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeDungeonResultInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeDungeonResultInfo(EffigyChallengeDungeonResultInfo other) : this() {
      challengeScore_ = other.challengeScore_;
      challengeMaxScore_ = other.challengeMaxScore_;
      isSuccess_ = other.isSuccess_;
      isInTimeLimit_ = other.isInTimeLimit_;
      challengeId_ = other.challengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeDungeonResultInfo Clone() {
      return new EffigyChallengeDungeonResultInfo(this);
    }

    /// <summary>Field number for the "challenge_score" field.</summary>
    public const int ChallengeScoreFieldNumber = 12;
    private uint challengeScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeScore {
      get { return challengeScore_; }
      set {
        challengeScore_ = value;
      }
    }

    /// <summary>Field number for the "challenge_max_score" field.</summary>
    public const int ChallengeMaxScoreFieldNumber = 8;
    private uint challengeMaxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeMaxScore {
      get { return challengeMaxScore_; }
      set {
        challengeMaxScore_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 2;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "is_in_time_limit" field.</summary>
    public const int IsInTimeLimitFieldNumber = 1;
    private bool isInTimeLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInTimeLimit {
      get { return isInTimeLimit_; }
      set {
        isInTimeLimit_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 15;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EffigyChallengeDungeonResultInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyChallengeDungeonResultInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeScore != other.ChallengeScore) return false;
      if (ChallengeMaxScore != other.ChallengeMaxScore) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (IsInTimeLimit != other.IsInTimeLimit) return false;
      if (ChallengeId != other.ChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeScore != 0) hash ^= ChallengeScore.GetHashCode();
      if (ChallengeMaxScore != 0) hash ^= ChallengeMaxScore.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (IsInTimeLimit != false) hash ^= IsInTimeLimit.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
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
      if (IsInTimeLimit != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsInTimeLimit);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsSuccess);
      }
      if (ChallengeMaxScore != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ChallengeMaxScore);
      }
      if (ChallengeScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeScore);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ChallengeId);
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
      if (IsInTimeLimit != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsInTimeLimit);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsSuccess);
      }
      if (ChallengeMaxScore != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ChallengeMaxScore);
      }
      if (ChallengeScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeScore);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ChallengeId);
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
      if (ChallengeScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeScore);
      }
      if (ChallengeMaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeMaxScore);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (IsInTimeLimit != false) {
        size += 1 + 1;
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EffigyChallengeDungeonResultInfo other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeScore != 0) {
        ChallengeScore = other.ChallengeScore;
      }
      if (other.ChallengeMaxScore != 0) {
        ChallengeMaxScore = other.ChallengeMaxScore;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.IsInTimeLimit != false) {
        IsInTimeLimit = other.IsInTimeLimit;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
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
          case 8: {
            IsInTimeLimit = input.ReadBool();
            break;
          }
          case 16: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            ChallengeMaxScore = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeScore = input.ReadUInt32();
            break;
          }
          case 120: {
            ChallengeId = input.ReadUInt32();
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
          case 8: {
            IsInTimeLimit = input.ReadBool();
            break;
          }
          case 16: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            ChallengeMaxScore = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeScore = input.ReadUInt32();
            break;
          }
          case 120: {
            ChallengeId = input.ReadUInt32();
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
