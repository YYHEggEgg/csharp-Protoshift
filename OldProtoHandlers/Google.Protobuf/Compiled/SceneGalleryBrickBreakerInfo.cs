// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryBrickBreakerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryBrickBreakerInfo.proto</summary>
public static partial class SceneGalleryBrickBreakerInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryBrickBreakerInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryBrickBreakerInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiJTY2VuZUdhbGxlcnlCcmlja0JyZWFrZXJJbmZvLnByb3RvIl8KHFNjZW5l",
          "R2FsbGVyeUJyaWNrQnJlYWtlckluZm8SDQoFc2NvcmUYCiABKA0SEgoKbGlm",
          "ZV9jb3VudBgEIAEoDRINCgVmZXZlchgCIAEoDRINCgVjb21ibxgBIAEoDUIe",
          "ChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryBrickBreakerInfo), global::SceneGalleryBrickBreakerInfo.Parser, new[]{ "Score", "LifeCount", "Fever", "Combo" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SceneGalleryBrickBreakerInfo : pb::IMessage<SceneGalleryBrickBreakerInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryBrickBreakerInfo> _parser = new pb::MessageParser<SceneGalleryBrickBreakerInfo>(() => new SceneGalleryBrickBreakerInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryBrickBreakerInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryBrickBreakerInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryBrickBreakerInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryBrickBreakerInfo(SceneGalleryBrickBreakerInfo other) : this() {
    score_ = other.score_;
    lifeCount_ = other.lifeCount_;
    fever_ = other.fever_;
    combo_ = other.combo_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryBrickBreakerInfo Clone() {
    return new SceneGalleryBrickBreakerInfo(this);
  }

  /// <summary>Field number for the "score" field.</summary>
  public const int ScoreFieldNumber = 10;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  /// <summary>Field number for the "life_count" field.</summary>
  public const int LifeCountFieldNumber = 4;
  private uint lifeCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LifeCount {
    get { return lifeCount_; }
    set {
      lifeCount_ = value;
    }
  }

  /// <summary>Field number for the "fever" field.</summary>
  public const int FeverFieldNumber = 2;
  private uint fever_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Fever {
    get { return fever_; }
    set {
      fever_ = value;
    }
  }

  /// <summary>Field number for the "combo" field.</summary>
  public const int ComboFieldNumber = 1;
  private uint combo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Combo {
    get { return combo_; }
    set {
      combo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneGalleryBrickBreakerInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryBrickBreakerInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Score != other.Score) return false;
    if (LifeCount != other.LifeCount) return false;
    if (Fever != other.Fever) return false;
    if (Combo != other.Combo) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Score != 0) hash ^= Score.GetHashCode();
    if (LifeCount != 0) hash ^= LifeCount.GetHashCode();
    if (Fever != 0) hash ^= Fever.GetHashCode();
    if (Combo != 0) hash ^= Combo.GetHashCode();
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
    if (Combo != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Combo);
    }
    if (Fever != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Fever);
    }
    if (LifeCount != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(LifeCount);
    }
    if (Score != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Score);
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
    if (Combo != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Combo);
    }
    if (Fever != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Fever);
    }
    if (LifeCount != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(LifeCount);
    }
    if (Score != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Score);
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
    if (LifeCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LifeCount);
    }
    if (Fever != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Fever);
    }
    if (Combo != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneGalleryBrickBreakerInfo other) {
    if (other == null) {
      return;
    }
    if (other.Score != 0) {
      Score = other.Score;
    }
    if (other.LifeCount != 0) {
      LifeCount = other.LifeCount;
    }
    if (other.Fever != 0) {
      Fever = other.Fever;
    }
    if (other.Combo != 0) {
      Combo = other.Combo;
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
          Combo = input.ReadUInt32();
          break;
        }
        case 16: {
          Fever = input.ReadUInt32();
          break;
        }
        case 32: {
          LifeCount = input.ReadUInt32();
          break;
        }
        case 80: {
          Score = input.ReadUInt32();
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
          Combo = input.ReadUInt32();
          break;
        }
        case 16: {
          Fever = input.ReadUInt32();
          break;
        }
        case 32: {
          LifeCount = input.ReadUInt32();
          break;
        }
        case 80: {
          Score = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
