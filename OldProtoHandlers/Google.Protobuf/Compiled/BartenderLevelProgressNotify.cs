// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BartenderLevelProgressNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BartenderLevelProgressNotify.proto</summary>
public static partial class BartenderLevelProgressNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for BartenderLevelProgressNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BartenderLevelProgressNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiJCYXJ0ZW5kZXJMZXZlbFByb2dyZXNzTm90aWZ5LnByb3RvImkKHEJhcnRl",
          "bmRlckxldmVsUHJvZ3Jlc3NOb3RpZnkSFQoNaXNfbmV3X3JlY29yZBgJIAEo",
          "CBIRCglpc19maW5pc2gYAyABKAgSEAoIbGV2ZWxfaWQYDyABKA0SDQoFc2Nv",
          "cmUYCCABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BartenderLevelProgressNotify), global::BartenderLevelProgressNotify.Parser, new[]{ "IsNewRecord", "IsFinish", "LevelId", "Score" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8756
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class BartenderLevelProgressNotify : pb::IMessage<BartenderLevelProgressNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BartenderLevelProgressNotify> _parser = new pb::MessageParser<BartenderLevelProgressNotify>(() => new BartenderLevelProgressNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BartenderLevelProgressNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BartenderLevelProgressNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BartenderLevelProgressNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BartenderLevelProgressNotify(BartenderLevelProgressNotify other) : this() {
    isNewRecord_ = other.isNewRecord_;
    isFinish_ = other.isFinish_;
    levelId_ = other.levelId_;
    score_ = other.score_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BartenderLevelProgressNotify Clone() {
    return new BartenderLevelProgressNotify(this);
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 9;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  /// <summary>Field number for the "is_finish" field.</summary>
  public const int IsFinishFieldNumber = 3;
  private bool isFinish_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFinish {
    get { return isFinish_; }
    set {
      isFinish_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 15;
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
  public const int ScoreFieldNumber = 8;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BartenderLevelProgressNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BartenderLevelProgressNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsNewRecord != other.IsNewRecord) return false;
    if (IsFinish != other.IsFinish) return false;
    if (LevelId != other.LevelId) return false;
    if (Score != other.Score) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
    if (IsFinish != false) hash ^= IsFinish.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (Score != 0) hash ^= Score.GetHashCode();
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
    if (IsFinish != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsFinish);
    }
    if (Score != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Score);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsNewRecord);
    }
    if (LevelId != 0) {
      output.WriteRawTag(120);
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
    if (IsFinish != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsFinish);
    }
    if (Score != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Score);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsNewRecord);
    }
    if (LevelId != 0) {
      output.WriteRawTag(120);
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
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (IsFinish != false) {
      size += 1 + 1;
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (Score != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BartenderLevelProgressNotify other) {
    if (other == null) {
      return;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
    }
    if (other.IsFinish != false) {
      IsFinish = other.IsFinish;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.Score != 0) {
      Score = other.Score;
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
        case 24: {
          IsFinish = input.ReadBool();
          break;
        }
        case 64: {
          Score = input.ReadUInt32();
          break;
        }
        case 72: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 120: {
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
        case 24: {
          IsFinish = input.ReadBool();
          break;
        }
        case 64: {
          Score = input.ReadUInt32();
          break;
        }
        case 72: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 120: {
          LevelId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
