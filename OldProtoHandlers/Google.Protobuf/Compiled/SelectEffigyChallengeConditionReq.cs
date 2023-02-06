// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SelectEffigyChallengeConditionReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SelectEffigyChallengeConditionReq.proto</summary>
public static partial class SelectEffigyChallengeConditionReqReflection {

  #region Descriptor
  /// <summary>File descriptor for SelectEffigyChallengeConditionReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SelectEffigyChallengeConditionReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CidTZWxlY3RFZmZpZ3lDaGFsbGVuZ2VDb25kaXRpb25SZXEucHJvdG8iawoh",
          "U2VsZWN0RWZmaWd5Q2hhbGxlbmdlQ29uZGl0aW9uUmVxEhUKDWRpZmZpY3Vs",
          "dHlfaWQYDyABKA0SFAoMY2hhbGxlbmdlX2lkGAcgASgNEhkKEWNvbmRpdGlv",
          "bl9pZF9saXN0GAkgAygNQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJv",
          "dG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SelectEffigyChallengeConditionReq), global::SelectEffigyChallengeConditionReq.Parser, new[]{ "DifficultyId", "ChallengeId", "ConditionIdList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2064
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class SelectEffigyChallengeConditionReq : pb::IMessage<SelectEffigyChallengeConditionReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SelectEffigyChallengeConditionReq> _parser = new pb::MessageParser<SelectEffigyChallengeConditionReq>(() => new SelectEffigyChallengeConditionReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SelectEffigyChallengeConditionReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SelectEffigyChallengeConditionReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SelectEffigyChallengeConditionReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SelectEffigyChallengeConditionReq(SelectEffigyChallengeConditionReq other) : this() {
    difficultyId_ = other.difficultyId_;
    challengeId_ = other.challengeId_;
    conditionIdList_ = other.conditionIdList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SelectEffigyChallengeConditionReq Clone() {
    return new SelectEffigyChallengeConditionReq(this);
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

  /// <summary>Field number for the "challenge_id" field.</summary>
  public const int ChallengeIdFieldNumber = 7;
  private uint challengeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChallengeId {
    get { return challengeId_; }
    set {
      challengeId_ = value;
    }
  }

  /// <summary>Field number for the "condition_id_list" field.</summary>
  public const int ConditionIdListFieldNumber = 9;
  private static readonly pb::FieldCodec<uint> _repeated_conditionIdList_codec
      = pb::FieldCodec.ForUInt32(74);
  private readonly pbc::RepeatedField<uint> conditionIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ConditionIdList {
    get { return conditionIdList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SelectEffigyChallengeConditionReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SelectEffigyChallengeConditionReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (DifficultyId != other.DifficultyId) return false;
    if (ChallengeId != other.ChallengeId) return false;
    if(!conditionIdList_.Equals(other.conditionIdList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
    if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
    hash ^= conditionIdList_.GetHashCode();
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
    if (ChallengeId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ChallengeId);
    }
    conditionIdList_.WriteTo(output, _repeated_conditionIdList_codec);
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
    if (ChallengeId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ChallengeId);
    }
    conditionIdList_.WriteTo(ref output, _repeated_conditionIdList_codec);
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
    if (DifficultyId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
    }
    if (ChallengeId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
    }
    size += conditionIdList_.CalculateSize(_repeated_conditionIdList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SelectEffigyChallengeConditionReq other) {
    if (other == null) {
      return;
    }
    if (other.DifficultyId != 0) {
      DifficultyId = other.DifficultyId;
    }
    if (other.ChallengeId != 0) {
      ChallengeId = other.ChallengeId;
    }
    conditionIdList_.Add(other.conditionIdList_);
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
        case 56: {
          ChallengeId = input.ReadUInt32();
          break;
        }
        case 74:
        case 72: {
          conditionIdList_.AddEntriesFrom(input, _repeated_conditionIdList_codec);
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
        case 56: {
          ChallengeId = input.ReadUInt32();
          break;
        }
        case 74:
        case 72: {
          conditionIdList_.AddEntriesFrom(ref input, _repeated_conditionIdList_codec);
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
