// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetPlayInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GadgetPlayInfo.proto</summary>
public static partial class GadgetPlayInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for GadgetPlayInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GadgetPlayInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChRHYWRnZXRQbGF5SW5mby5wcm90bxoYR2FkZ2V0Q3J1Y2libGVJbmZvLnBy",
          "b3RvIsUBCg5HYWRnZXRQbGF5SW5mbxIRCglwbGF5X3R5cGUYASABKA0SEAoI",
          "ZHVyYXRpb24YAiABKA0SGwoTcHJvZ3Jlc3Nfc3RhZ2VfbGlzdBgDIAMoDRIQ",
          "CghzdGFydF9jZBgEIAEoDRISCgpzdGFydF90aW1lGAUgASgNEhAKCHByb2dy",
          "ZXNzGAYgASgNEiwKDWNydWNpYmxlX2luZm8YFSABKAsyEy5HYWRnZXRDcnVj",
          "aWJsZUluZm9IAEILCglwbGF5X2luZm9CFgoUb3JnLnNvcmFwb2ludGEucHJv",
          "dG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GadgetCrucibleInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GadgetPlayInfo), global::GadgetPlayInfo.Parser, new[]{ "PlayType", "Duration", "ProgressStageList", "StartCd", "StartTime", "Progress", "CrucibleInfo" }, new[]{ "PlayInfo" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GadgetPlayInfo : pb::IMessage<GadgetPlayInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GadgetPlayInfo> _parser = new pb::MessageParser<GadgetPlayInfo>(() => new GadgetPlayInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GadgetPlayInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GadgetPlayInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayInfo(GadgetPlayInfo other) : this() {
    playType_ = other.playType_;
    duration_ = other.duration_;
    progressStageList_ = other.progressStageList_.Clone();
    startCd_ = other.startCd_;
    startTime_ = other.startTime_;
    progress_ = other.progress_;
    switch (other.PlayInfoCase) {
      case PlayInfoOneofCase.CrucibleInfo:
        CrucibleInfo = other.CrucibleInfo.Clone();
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayInfo Clone() {
    return new GadgetPlayInfo(this);
  }

  /// <summary>Field number for the "play_type" field.</summary>
  public const int PlayTypeFieldNumber = 1;
  private uint playType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayType {
    get { return playType_; }
    set {
      playType_ = value;
    }
  }

  /// <summary>Field number for the "duration" field.</summary>
  public const int DurationFieldNumber = 2;
  private uint duration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Duration {
    get { return duration_; }
    set {
      duration_ = value;
    }
  }

  /// <summary>Field number for the "progress_stage_list" field.</summary>
  public const int ProgressStageListFieldNumber = 3;
  private static readonly pb::FieldCodec<uint> _repeated_progressStageList_codec
      = pb::FieldCodec.ForUInt32(26);
  private readonly pbc::RepeatedField<uint> progressStageList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ProgressStageList {
    get { return progressStageList_; }
  }

  /// <summary>Field number for the "start_cd" field.</summary>
  public const int StartCdFieldNumber = 4;
  private uint startCd_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StartCd {
    get { return startCd_; }
    set {
      startCd_ = value;
    }
  }

  /// <summary>Field number for the "start_time" field.</summary>
  public const int StartTimeFieldNumber = 5;
  private uint startTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StartTime {
    get { return startTime_; }
    set {
      startTime_ = value;
    }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 6;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  /// <summary>Field number for the "crucible_info" field.</summary>
  public const int CrucibleInfoFieldNumber = 21;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GadgetCrucibleInfo CrucibleInfo {
    get { return playInfoCase_ == PlayInfoOneofCase.CrucibleInfo ? (global::GadgetCrucibleInfo) playInfo_ : null; }
    set {
      playInfo_ = value;
      playInfoCase_ = value == null ? PlayInfoOneofCase.None : PlayInfoOneofCase.CrucibleInfo;
    }
  }

  private object playInfo_;
  /// <summary>Enum of possible cases for the "play_info" oneof.</summary>
  public enum PlayInfoOneofCase {
    None = 0,
    CrucibleInfo = 21,
  }
  private PlayInfoOneofCase playInfoCase_ = PlayInfoOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayInfoOneofCase PlayInfoCase {
    get { return playInfoCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearPlayInfo() {
    playInfoCase_ = PlayInfoOneofCase.None;
    playInfo_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GadgetPlayInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GadgetPlayInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (PlayType != other.PlayType) return false;
    if (Duration != other.Duration) return false;
    if(!progressStageList_.Equals(other.progressStageList_)) return false;
    if (StartCd != other.StartCd) return false;
    if (StartTime != other.StartTime) return false;
    if (Progress != other.Progress) return false;
    if (!object.Equals(CrucibleInfo, other.CrucibleInfo)) return false;
    if (PlayInfoCase != other.PlayInfoCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (PlayType != 0) hash ^= PlayType.GetHashCode();
    if (Duration != 0) hash ^= Duration.GetHashCode();
    hash ^= progressStageList_.GetHashCode();
    if (StartCd != 0) hash ^= StartCd.GetHashCode();
    if (StartTime != 0) hash ^= StartTime.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (playInfoCase_ == PlayInfoOneofCase.CrucibleInfo) hash ^= CrucibleInfo.GetHashCode();
    hash ^= (int) playInfoCase_;
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
    if (PlayType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(PlayType);
    }
    if (Duration != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Duration);
    }
    progressStageList_.WriteTo(output, _repeated_progressStageList_codec);
    if (StartCd != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StartCd);
    }
    if (StartTime != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(StartTime);
    }
    if (Progress != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Progress);
    }
    if (playInfoCase_ == PlayInfoOneofCase.CrucibleInfo) {
      output.WriteRawTag(170, 1);
      output.WriteMessage(CrucibleInfo);
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
    if (PlayType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(PlayType);
    }
    if (Duration != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Duration);
    }
    progressStageList_.WriteTo(ref output, _repeated_progressStageList_codec);
    if (StartCd != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StartCd);
    }
    if (StartTime != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(StartTime);
    }
    if (Progress != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Progress);
    }
    if (playInfoCase_ == PlayInfoOneofCase.CrucibleInfo) {
      output.WriteRawTag(170, 1);
      output.WriteMessage(CrucibleInfo);
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
    if (PlayType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
    }
    if (Duration != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Duration);
    }
    size += progressStageList_.CalculateSize(_repeated_progressStageList_codec);
    if (StartCd != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartCd);
    }
    if (StartTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
    }
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (playInfoCase_ == PlayInfoOneofCase.CrucibleInfo) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(CrucibleInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GadgetPlayInfo other) {
    if (other == null) {
      return;
    }
    if (other.PlayType != 0) {
      PlayType = other.PlayType;
    }
    if (other.Duration != 0) {
      Duration = other.Duration;
    }
    progressStageList_.Add(other.progressStageList_);
    if (other.StartCd != 0) {
      StartCd = other.StartCd;
    }
    if (other.StartTime != 0) {
      StartTime = other.StartTime;
    }
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    switch (other.PlayInfoCase) {
      case PlayInfoOneofCase.CrucibleInfo:
        if (CrucibleInfo == null) {
          CrucibleInfo = new global::GadgetCrucibleInfo();
        }
        CrucibleInfo.MergeFrom(other.CrucibleInfo);
        break;
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
          PlayType = input.ReadUInt32();
          break;
        }
        case 16: {
          Duration = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          progressStageList_.AddEntriesFrom(input, _repeated_progressStageList_codec);
          break;
        }
        case 32: {
          StartCd = input.ReadUInt32();
          break;
        }
        case 40: {
          StartTime = input.ReadUInt32();
          break;
        }
        case 48: {
          Progress = input.ReadUInt32();
          break;
        }
        case 170: {
          global::GadgetCrucibleInfo subBuilder = new global::GadgetCrucibleInfo();
          if (playInfoCase_ == PlayInfoOneofCase.CrucibleInfo) {
            subBuilder.MergeFrom(CrucibleInfo);
          }
          input.ReadMessage(subBuilder);
          CrucibleInfo = subBuilder;
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
          PlayType = input.ReadUInt32();
          break;
        }
        case 16: {
          Duration = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          progressStageList_.AddEntriesFrom(ref input, _repeated_progressStageList_codec);
          break;
        }
        case 32: {
          StartCd = input.ReadUInt32();
          break;
        }
        case 40: {
          StartTime = input.ReadUInt32();
          break;
        }
        case 48: {
          Progress = input.ReadUInt32();
          break;
        }
        case 170: {
          global::GadgetCrucibleInfo subBuilder = new global::GadgetCrucibleInfo();
          if (playInfoCase_ == PlayInfoOneofCase.CrucibleInfo) {
            subBuilder.MergeFrom(CrucibleInfo);
          }
          input.ReadMessage(subBuilder);
          CrucibleInfo = subBuilder;
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
