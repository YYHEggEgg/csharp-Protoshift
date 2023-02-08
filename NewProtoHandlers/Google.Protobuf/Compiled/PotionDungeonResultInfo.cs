// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PotionDungeonResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PotionDungeonResultInfo.proto</summary>
  public static partial class PotionDungeonResultInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PotionDungeonResultInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PotionDungeonResultInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Qb3Rpb25EdW5nZW9uUmVzdWx0SW5mby5wcm90byKQAQoXUG90aW9uRHVu",
            "Z2VvblJlc3VsdEluZm8SEQoJbGVmdF90aW1lGAcgASgNEg8KB21vZGVfaWQY",
            "DSABKA0SEAoIc3RhZ2VfaWQYASABKA0SEAoIbGV2ZWxfaWQYAiABKA0SEwoL",
            "ZmluYWxfc2NvcmUYDyABKA0SGAoQZGlmZmljdWx0eV9sZXZlbBgIIAEoDUIM",
            "qgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PotionDungeonResultInfo), global::NewProtos.PotionDungeonResultInfo.Parser, new[]{ "LeftTime", "ModeId", "StageId", "LevelId", "FinalScore", "DifficultyLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PotionDungeonResultInfo : pb::IMessage<PotionDungeonResultInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PotionDungeonResultInfo> _parser = new pb::MessageParser<PotionDungeonResultInfo>(() => new PotionDungeonResultInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PotionDungeonResultInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PotionDungeonResultInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionDungeonResultInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionDungeonResultInfo(PotionDungeonResultInfo other) : this() {
      leftTime_ = other.leftTime_;
      modeId_ = other.modeId_;
      stageId_ = other.stageId_;
      levelId_ = other.levelId_;
      finalScore_ = other.finalScore_;
      difficultyLevel_ = other.difficultyLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionDungeonResultInfo Clone() {
      return new PotionDungeonResultInfo(this);
    }

    /// <summary>Field number for the "left_time" field.</summary>
    public const int LeftTimeFieldNumber = 7;
    private uint leftTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftTime {
      get { return leftTime_; }
      set {
        leftTime_ = value;
      }
    }

    /// <summary>Field number for the "mode_id" field.</summary>
    public const int ModeIdFieldNumber = 13;
    private uint modeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModeId {
      get { return modeId_; }
      set {
        modeId_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 1;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 2;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 15;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_level" field.</summary>
    public const int DifficultyLevelFieldNumber = 8;
    private uint difficultyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyLevel {
      get { return difficultyLevel_; }
      set {
        difficultyLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PotionDungeonResultInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PotionDungeonResultInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LeftTime != other.LeftTime) return false;
      if (ModeId != other.ModeId) return false;
      if (StageId != other.StageId) return false;
      if (LevelId != other.LevelId) return false;
      if (FinalScore != other.FinalScore) return false;
      if (DifficultyLevel != other.DifficultyLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LeftTime != 0) hash ^= LeftTime.GetHashCode();
      if (ModeId != 0) hash ^= ModeId.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (DifficultyLevel != 0) hash ^= DifficultyLevel.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(StageId);
      }
      if (LevelId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LevelId);
      }
      if (LeftTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LeftTime);
      }
      if (DifficultyLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DifficultyLevel);
      }
      if (ModeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ModeId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinalScore);
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
      if (StageId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(StageId);
      }
      if (LevelId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LevelId);
      }
      if (LeftTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LeftTime);
      }
      if (DifficultyLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DifficultyLevel);
      }
      if (ModeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ModeId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinalScore);
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
      if (LeftTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftTime);
      }
      if (ModeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModeId);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (DifficultyLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PotionDungeonResultInfo other) {
      if (other == null) {
        return;
      }
      if (other.LeftTime != 0) {
        LeftTime = other.LeftTime;
      }
      if (other.ModeId != 0) {
        ModeId = other.ModeId;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.DifficultyLevel != 0) {
        DifficultyLevel = other.DifficultyLevel;
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
            StageId = input.ReadUInt32();
            break;
          }
          case 16: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 56: {
            LeftTime = input.ReadUInt32();
            break;
          }
          case 64: {
            DifficultyLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            ModeId = input.ReadUInt32();
            break;
          }
          case 120: {
            FinalScore = input.ReadUInt32();
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
            StageId = input.ReadUInt32();
            break;
          }
          case 16: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 56: {
            LeftTime = input.ReadUInt32();
            break;
          }
          case 64: {
            DifficultyLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            ModeId = input.ReadUInt32();
            break;
          }
          case 120: {
            FinalScore = input.ReadUInt32();
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
