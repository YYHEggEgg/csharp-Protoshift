// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyChallengeV2EnterDungeonRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EffigyChallengeV2EnterDungeonRsp.proto</summary>
public static partial class EffigyChallengeV2EnterDungeonRspReflection {

  #region Descriptor
  /// <summary>File descriptor for EffigyChallengeV2EnterDungeonRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EffigyChallengeV2EnterDungeonRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiZFZmZpZ3lDaGFsbGVuZ2VWMkVudGVyRHVuZ2VvblJzcC5wcm90byKJAQog",
          "RWZmaWd5Q2hhbGxlbmdlVjJFbnRlckR1bmdlb25Sc3ASHwoXY2hhbGxlbmdl",
          "X21vZGVfc2tpbGxfbm8YCyABKA0SDwoHcmV0Y29kZRgKIAEoBRIhChljaGFs",
          "bGVuZ2VfbW9kZV9kaWZmaWN1bHR5GA4gASgNEhAKCGxldmVsX2lkGA0gASgN",
          "Qh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EffigyChallengeV2EnterDungeonRsp), global::EffigyChallengeV2EnterDungeonRsp.Parser, new[]{ "ChallengeModeSkillNo", "Retcode", "ChallengeModeDifficulty", "LevelId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 24917
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class EffigyChallengeV2EnterDungeonRsp : pb::IMessage<EffigyChallengeV2EnterDungeonRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EffigyChallengeV2EnterDungeonRsp> _parser = new pb::MessageParser<EffigyChallengeV2EnterDungeonRsp>(() => new EffigyChallengeV2EnterDungeonRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EffigyChallengeV2EnterDungeonRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EffigyChallengeV2EnterDungeonRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EffigyChallengeV2EnterDungeonRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EffigyChallengeV2EnterDungeonRsp(EffigyChallengeV2EnterDungeonRsp other) : this() {
    challengeModeSkillNo_ = other.challengeModeSkillNo_;
    retcode_ = other.retcode_;
    challengeModeDifficulty_ = other.challengeModeDifficulty_;
    levelId_ = other.levelId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EffigyChallengeV2EnterDungeonRsp Clone() {
    return new EffigyChallengeV2EnterDungeonRsp(this);
  }

  /// <summary>Field number for the "challenge_mode_skill_no" field.</summary>
  public const int ChallengeModeSkillNoFieldNumber = 11;
  private uint challengeModeSkillNo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChallengeModeSkillNo {
    get { return challengeModeSkillNo_; }
    set {
      challengeModeSkillNo_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 10;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "challenge_mode_difficulty" field.</summary>
  public const int ChallengeModeDifficultyFieldNumber = 14;
  private uint challengeModeDifficulty_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChallengeModeDifficulty {
    get { return challengeModeDifficulty_; }
    set {
      challengeModeDifficulty_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 13;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EffigyChallengeV2EnterDungeonRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EffigyChallengeV2EnterDungeonRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ChallengeModeSkillNo != other.ChallengeModeSkillNo) return false;
    if (Retcode != other.Retcode) return false;
    if (ChallengeModeDifficulty != other.ChallengeModeDifficulty) return false;
    if (LevelId != other.LevelId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ChallengeModeSkillNo != 0) hash ^= ChallengeModeSkillNo.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (ChallengeModeDifficulty != 0) hash ^= ChallengeModeDifficulty.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
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
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
    }
    if (ChallengeModeSkillNo != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ChallengeModeSkillNo);
    }
    if (LevelId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(LevelId);
    }
    if (ChallengeModeDifficulty != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(ChallengeModeDifficulty);
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
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
    }
    if (ChallengeModeSkillNo != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ChallengeModeSkillNo);
    }
    if (LevelId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(LevelId);
    }
    if (ChallengeModeDifficulty != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(ChallengeModeDifficulty);
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
    if (ChallengeModeSkillNo != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeSkillNo);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (ChallengeModeDifficulty != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeDifficulty);
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EffigyChallengeV2EnterDungeonRsp other) {
    if (other == null) {
      return;
    }
    if (other.ChallengeModeSkillNo != 0) {
      ChallengeModeSkillNo = other.ChallengeModeSkillNo;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.ChallengeModeDifficulty != 0) {
      ChallengeModeDifficulty = other.ChallengeModeDifficulty;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
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
        case 80: {
          Retcode = input.ReadInt32();
          break;
        }
        case 88: {
          ChallengeModeSkillNo = input.ReadUInt32();
          break;
        }
        case 104: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 112: {
          ChallengeModeDifficulty = input.ReadUInt32();
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
        case 80: {
          Retcode = input.ReadInt32();
          break;
        }
        case 88: {
          ChallengeModeSkillNo = input.ReadUInt32();
          break;
        }
        case 104: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 112: {
          ChallengeModeDifficulty = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
