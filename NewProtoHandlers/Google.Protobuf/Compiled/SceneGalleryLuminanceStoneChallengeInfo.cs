// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryLuminanceStoneChallengeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryLuminanceStoneChallengeInfo.proto</summary>
public static partial class SceneGalleryLuminanceStoneChallengeInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryLuminanceStoneChallengeInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryLuminanceStoneChallengeInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ci1TY2VuZUdhbGxlcnlMdW1pbmFuY2VTdG9uZUNoYWxsZW5nZUluZm8ucHJv",
          "dG8ikQEKJ1NjZW5lR2FsbGVyeUx1bWluYW5jZVN0b25lQ2hhbGxlbmdlSW5m",
          "bxIXCg9jbGVhbl9tdWRfY291bnQYDCABKA0SIgoaa2lsbF9zcGVjaWFsX21v",
          "bnN0ZXJfY291bnQYAyABKA0SDQoFc2NvcmUYBCABKA0SGgoSa2lsbF9tb25z",
          "dGVyX2NvdW50GAggASgNQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryLuminanceStoneChallengeInfo), global::SceneGalleryLuminanceStoneChallengeInfo.Parser, new[]{ "CleanMudCount", "KillSpecialMonsterCount", "Score", "KillMonsterCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SceneGalleryLuminanceStoneChallengeInfo : pb::IMessage<SceneGalleryLuminanceStoneChallengeInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryLuminanceStoneChallengeInfo> _parser = new pb::MessageParser<SceneGalleryLuminanceStoneChallengeInfo>(() => new SceneGalleryLuminanceStoneChallengeInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryLuminanceStoneChallengeInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryLuminanceStoneChallengeInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryLuminanceStoneChallengeInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryLuminanceStoneChallengeInfo(SceneGalleryLuminanceStoneChallengeInfo other) : this() {
    cleanMudCount_ = other.cleanMudCount_;
    killSpecialMonsterCount_ = other.killSpecialMonsterCount_;
    score_ = other.score_;
    killMonsterCount_ = other.killMonsterCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryLuminanceStoneChallengeInfo Clone() {
    return new SceneGalleryLuminanceStoneChallengeInfo(this);
  }

  /// <summary>Field number for the "clean_mud_count" field.</summary>
  public const int CleanMudCountFieldNumber = 12;
  private uint cleanMudCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CleanMudCount {
    get { return cleanMudCount_; }
    set {
      cleanMudCount_ = value;
    }
  }

  /// <summary>Field number for the "kill_special_monster_count" field.</summary>
  public const int KillSpecialMonsterCountFieldNumber = 3;
  private uint killSpecialMonsterCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint KillSpecialMonsterCount {
    get { return killSpecialMonsterCount_; }
    set {
      killSpecialMonsterCount_ = value;
    }
  }

  /// <summary>Field number for the "score" field.</summary>
  public const int ScoreFieldNumber = 4;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  /// <summary>Field number for the "kill_monster_count" field.</summary>
  public const int KillMonsterCountFieldNumber = 8;
  private uint killMonsterCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint KillMonsterCount {
    get { return killMonsterCount_; }
    set {
      killMonsterCount_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneGalleryLuminanceStoneChallengeInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryLuminanceStoneChallengeInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CleanMudCount != other.CleanMudCount) return false;
    if (KillSpecialMonsterCount != other.KillSpecialMonsterCount) return false;
    if (Score != other.Score) return false;
    if (KillMonsterCount != other.KillMonsterCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (CleanMudCount != 0) hash ^= CleanMudCount.GetHashCode();
    if (KillSpecialMonsterCount != 0) hash ^= KillSpecialMonsterCount.GetHashCode();
    if (Score != 0) hash ^= Score.GetHashCode();
    if (KillMonsterCount != 0) hash ^= KillMonsterCount.GetHashCode();
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
    if (KillSpecialMonsterCount != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(KillSpecialMonsterCount);
    }
    if (Score != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Score);
    }
    if (KillMonsterCount != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(KillMonsterCount);
    }
    if (CleanMudCount != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CleanMudCount);
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
    if (KillSpecialMonsterCount != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(KillSpecialMonsterCount);
    }
    if (Score != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Score);
    }
    if (KillMonsterCount != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(KillMonsterCount);
    }
    if (CleanMudCount != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CleanMudCount);
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
    if (CleanMudCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CleanMudCount);
    }
    if (KillSpecialMonsterCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillSpecialMonsterCount);
    }
    if (Score != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
    }
    if (KillMonsterCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillMonsterCount);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneGalleryLuminanceStoneChallengeInfo other) {
    if (other == null) {
      return;
    }
    if (other.CleanMudCount != 0) {
      CleanMudCount = other.CleanMudCount;
    }
    if (other.KillSpecialMonsterCount != 0) {
      KillSpecialMonsterCount = other.KillSpecialMonsterCount;
    }
    if (other.Score != 0) {
      Score = other.Score;
    }
    if (other.KillMonsterCount != 0) {
      KillMonsterCount = other.KillMonsterCount;
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
          KillSpecialMonsterCount = input.ReadUInt32();
          break;
        }
        case 32: {
          Score = input.ReadUInt32();
          break;
        }
        case 64: {
          KillMonsterCount = input.ReadUInt32();
          break;
        }
        case 96: {
          CleanMudCount = input.ReadUInt32();
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
          KillSpecialMonsterCount = input.ReadUInt32();
          break;
        }
        case 32: {
          Score = input.ReadUInt32();
          break;
        }
        case 64: {
          KillMonsterCount = input.ReadUInt32();
          break;
        }
        case 96: {
          CleanMudCount = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code