// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SalvagePreventGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SalvagePreventGallerySettleInfo.proto</summary>
public static partial class SalvagePreventGallerySettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SalvagePreventGallerySettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SalvagePreventGallerySettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVTYWx2YWdlUHJldmVudEdhbGxlcnlTZXR0bGVJbmZvLnByb3RvGh5TYWx2",
          "YWdlUHJldmVudFN0b3BSZWFzb24ucHJvdG8ijQEKH1NhbHZhZ2VQcmV2ZW50",
          "R2FsbGVyeVNldHRsZUluZm8SFQoNbW9uc3Rlcl9jb3VudBgCIAEoDRIpCgZy",
          "ZWFzb24YCyABKA4yGS5TYWx2YWdlUHJldmVudFN0b3BSZWFzb24SEwoLZmlu",
          "YWxfc2NvcmUYBCABKA0SEwoLdGltZV9yZW1haW4YCCABKA1CFgoUb3JnLnNv",
          "cmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SalvagePreventStopReasonReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SalvagePreventGallerySettleInfo), global::SalvagePreventGallerySettleInfo.Parser, new[]{ "MonsterCount", "Reason", "FinalScore", "TimeRemain" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SalvagePreventGallerySettleInfo : pb::IMessage<SalvagePreventGallerySettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SalvagePreventGallerySettleInfo> _parser = new pb::MessageParser<SalvagePreventGallerySettleInfo>(() => new SalvagePreventGallerySettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SalvagePreventGallerySettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SalvagePreventGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvagePreventGallerySettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvagePreventGallerySettleInfo(SalvagePreventGallerySettleInfo other) : this() {
    monsterCount_ = other.monsterCount_;
    reason_ = other.reason_;
    finalScore_ = other.finalScore_;
    timeRemain_ = other.timeRemain_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvagePreventGallerySettleInfo Clone() {
    return new SalvagePreventGallerySettleInfo(this);
  }

  /// <summary>Field number for the "monster_count" field.</summary>
  public const int MonsterCountFieldNumber = 2;
  private uint monsterCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MonsterCount {
    get { return monsterCount_; }
    set {
      monsterCount_ = value;
    }
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 11;
  private global::SalvagePreventStopReason reason_ = global::SalvagePreventStopReason.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::SalvagePreventStopReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "final_score" field.</summary>
  public const int FinalScoreFieldNumber = 4;
  private uint finalScore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FinalScore {
    get { return finalScore_; }
    set {
      finalScore_ = value;
    }
  }

  /// <summary>Field number for the "time_remain" field.</summary>
  public const int TimeRemainFieldNumber = 8;
  private uint timeRemain_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TimeRemain {
    get { return timeRemain_; }
    set {
      timeRemain_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SalvagePreventGallerySettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SalvagePreventGallerySettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MonsterCount != other.MonsterCount) return false;
    if (Reason != other.Reason) return false;
    if (FinalScore != other.FinalScore) return false;
    if (TimeRemain != other.TimeRemain) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (MonsterCount != 0) hash ^= MonsterCount.GetHashCode();
    if (Reason != global::SalvagePreventStopReason.None) hash ^= Reason.GetHashCode();
    if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
    if (TimeRemain != 0) hash ^= TimeRemain.GetHashCode();
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
    if (MonsterCount != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(MonsterCount);
    }
    if (FinalScore != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(FinalScore);
    }
    if (TimeRemain != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(TimeRemain);
    }
    if (Reason != global::SalvagePreventStopReason.None) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Reason);
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
    if (MonsterCount != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(MonsterCount);
    }
    if (FinalScore != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(FinalScore);
    }
    if (TimeRemain != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(TimeRemain);
    }
    if (Reason != global::SalvagePreventStopReason.None) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Reason);
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
    if (MonsterCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterCount);
    }
    if (Reason != global::SalvagePreventStopReason.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (FinalScore != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
    }
    if (TimeRemain != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeRemain);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SalvagePreventGallerySettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.MonsterCount != 0) {
      MonsterCount = other.MonsterCount;
    }
    if (other.Reason != global::SalvagePreventStopReason.None) {
      Reason = other.Reason;
    }
    if (other.FinalScore != 0) {
      FinalScore = other.FinalScore;
    }
    if (other.TimeRemain != 0) {
      TimeRemain = other.TimeRemain;
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
          MonsterCount = input.ReadUInt32();
          break;
        }
        case 32: {
          FinalScore = input.ReadUInt32();
          break;
        }
        case 64: {
          TimeRemain = input.ReadUInt32();
          break;
        }
        case 88: {
          Reason = (global::SalvagePreventStopReason) input.ReadEnum();
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
          MonsterCount = input.ReadUInt32();
          break;
        }
        case 32: {
          FinalScore = input.ReadUInt32();
          break;
        }
        case 64: {
          TimeRemain = input.ReadUInt32();
          break;
        }
        case 88: {
          Reason = (global::SalvagePreventStopReason) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
