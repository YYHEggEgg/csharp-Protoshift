// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryBuoyantCombatInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryBuoyantCombatInfo.proto</summary>
public static partial class SceneGalleryBuoyantCombatInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryBuoyantCombatInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryBuoyantCombatInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNTY2VuZUdhbGxlcnlCdW95YW50Q29tYmF0SW5mby5wcm90byJuCh1TY2Vu",
          "ZUdhbGxlcnlCdW95YW50Q29tYmF0SW5mbxINCgVzY29yZRgGIAEoDRIiChpr",
          "aWxsX3NwZWNpYWxfbW9uc3Rlcl9jb3VudBgBIAEoDRIaChJraWxsX21vbnN0",
          "ZXJfY291bnQYDiABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryBuoyantCombatInfo), global::SceneGalleryBuoyantCombatInfo.Parser, new[]{ "Score", "KillSpecialMonsterCount", "KillMonsterCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SceneGalleryBuoyantCombatInfo : pb::IMessage<SceneGalleryBuoyantCombatInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryBuoyantCombatInfo> _parser = new pb::MessageParser<SceneGalleryBuoyantCombatInfo>(() => new SceneGalleryBuoyantCombatInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryBuoyantCombatInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryBuoyantCombatInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryBuoyantCombatInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryBuoyantCombatInfo(SceneGalleryBuoyantCombatInfo other) : this() {
    score_ = other.score_;
    killSpecialMonsterCount_ = other.killSpecialMonsterCount_;
    killMonsterCount_ = other.killMonsterCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryBuoyantCombatInfo Clone() {
    return new SceneGalleryBuoyantCombatInfo(this);
  }

  /// <summary>Field number for the "score" field.</summary>
  public const int ScoreFieldNumber = 6;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  /// <summary>Field number for the "kill_special_monster_count" field.</summary>
  public const int KillSpecialMonsterCountFieldNumber = 1;
  private uint killSpecialMonsterCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint KillSpecialMonsterCount {
    get { return killSpecialMonsterCount_; }
    set {
      killSpecialMonsterCount_ = value;
    }
  }

  /// <summary>Field number for the "kill_monster_count" field.</summary>
  public const int KillMonsterCountFieldNumber = 14;
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
    return Equals(other as SceneGalleryBuoyantCombatInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryBuoyantCombatInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Score != other.Score) return false;
    if (KillSpecialMonsterCount != other.KillSpecialMonsterCount) return false;
    if (KillMonsterCount != other.KillMonsterCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Score != 0) hash ^= Score.GetHashCode();
    if (KillSpecialMonsterCount != 0) hash ^= KillSpecialMonsterCount.GetHashCode();
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
      output.WriteRawTag(8);
      output.WriteUInt32(KillSpecialMonsterCount);
    }
    if (Score != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Score);
    }
    if (KillMonsterCount != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(KillMonsterCount);
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
      output.WriteRawTag(8);
      output.WriteUInt32(KillSpecialMonsterCount);
    }
    if (Score != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Score);
    }
    if (KillMonsterCount != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(KillMonsterCount);
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
    if (Score != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
    }
    if (KillSpecialMonsterCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillSpecialMonsterCount);
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
  public void MergeFrom(SceneGalleryBuoyantCombatInfo other) {
    if (other == null) {
      return;
    }
    if (other.Score != 0) {
      Score = other.Score;
    }
    if (other.KillSpecialMonsterCount != 0) {
      KillSpecialMonsterCount = other.KillSpecialMonsterCount;
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
        case 8: {
          KillSpecialMonsterCount = input.ReadUInt32();
          break;
        }
        case 48: {
          Score = input.ReadUInt32();
          break;
        }
        case 112: {
          KillMonsterCount = input.ReadUInt32();
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
          KillSpecialMonsterCount = input.ReadUInt32();
          break;
        }
        case 48: {
          Score = input.ReadUInt32();
          break;
        }
        case 112: {
          KillMonsterCount = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
