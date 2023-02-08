// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PotionLevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from PotionLevelData.proto</summary>
  public static partial class PotionLevelDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PotionLevelData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PotionLevelDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQb3Rpb25MZXZlbERhdGEucHJvdG8iXQoPUG90aW9uTGV2ZWxEYXRhEhAK",
            "CGxldmVsX2lkGAogASgNEg0KBXNjb3JlGAcgASgNEg8KB21vZGVfaWQYBSAB",
            "KA0SGAoQZGlmZmljdWx0eV9sZXZlbBgCIAEoDUIMqgIJT2xkUHJvdG9zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.PotionLevelData), global::OldProtos.PotionLevelData.Parser, new[]{ "LevelId", "Score", "ModeId", "DifficultyLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PotionLevelData : pb::IMessage<PotionLevelData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PotionLevelData> _parser = new pb::MessageParser<PotionLevelData>(() => new PotionLevelData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PotionLevelData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.PotionLevelDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionLevelData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionLevelData(PotionLevelData other) : this() {
      levelId_ = other.levelId_;
      score_ = other.score_;
      modeId_ = other.modeId_;
      difficultyLevel_ = other.difficultyLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionLevelData Clone() {
      return new PotionLevelData(this);
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 10;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 7;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "mode_id" field.</summary>
    public const int ModeIdFieldNumber = 5;
    private uint modeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModeId {
      get { return modeId_; }
      set {
        modeId_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_level" field.</summary>
    public const int DifficultyLevelFieldNumber = 2;
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
      return Equals(other as PotionLevelData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PotionLevelData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LevelId != other.LevelId) return false;
      if (Score != other.Score) return false;
      if (ModeId != other.ModeId) return false;
      if (DifficultyLevel != other.DifficultyLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (ModeId != 0) hash ^= ModeId.GetHashCode();
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
      if (DifficultyLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DifficultyLevel);
      }
      if (ModeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ModeId);
      }
      if (Score != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Score);
      }
      if (LevelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelId);
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
      if (DifficultyLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DifficultyLevel);
      }
      if (ModeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ModeId);
      }
      if (Score != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Score);
      }
      if (LevelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelId);
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
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (ModeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModeId);
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
    public void MergeFrom(PotionLevelData other) {
      if (other == null) {
        return;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.ModeId != 0) {
        ModeId = other.ModeId;
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
          case 16: {
            DifficultyLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            ModeId = input.ReadUInt32();
            break;
          }
          case 56: {
            Score = input.ReadUInt32();
            break;
          }
          case 80: {
            LevelId = input.ReadUInt32();
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
            DifficultyLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            ModeId = input.ReadUInt32();
            break;
          }
          case 56: {
            Score = input.ReadUInt32();
            break;
          }
          case 80: {
            LevelId = input.ReadUInt32();
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
