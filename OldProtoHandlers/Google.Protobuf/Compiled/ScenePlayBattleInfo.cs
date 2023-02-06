// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayBattleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ScenePlayBattleInfo.proto</summary>
public static partial class ScenePlayBattleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for ScenePlayBattleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ScenePlayBattleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlTY2VuZVBsYXlCYXR0bGVJbmZvLnByb3RvItMBChNTY2VuZVBsYXlCYXR0",
          "bGVJbmZvEgwKBG1vZGUYBCABKA0SGwoTcHJvZ3Jlc3Nfc3RhZ2VfbGlzdBgD",
          "IAMoDRISCgpzdGFydF90aW1lGAogASgNEhAKCGR1cmF0aW9uGA4gASgNEhEK",
          "CXBsYXlfdHlwZRgMIAEoDRIPCgdwbGF5X2lkGAEgASgNEhgKEHByZXBhcmVf",
          "ZW5kX3RpbWUYByABKA0SEAoIcHJvZ3Jlc3MYCyABKA0SDQoFc3RhdGUYCCAB",
          "KA0SDAoEdHlwZRgJIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ScenePlayBattleInfo), global::ScenePlayBattleInfo.Parser, new[]{ "Mode", "ProgressStageList", "StartTime", "Duration", "PlayType", "PlayId", "PrepareEndTime", "Progress", "State", "Type" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ScenePlayBattleInfo : pb::IMessage<ScenePlayBattleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ScenePlayBattleInfo> _parser = new pb::MessageParser<ScenePlayBattleInfo>(() => new ScenePlayBattleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ScenePlayBattleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ScenePlayBattleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleInfo(ScenePlayBattleInfo other) : this() {
    mode_ = other.mode_;
    progressStageList_ = other.progressStageList_.Clone();
    startTime_ = other.startTime_;
    duration_ = other.duration_;
    playType_ = other.playType_;
    playId_ = other.playId_;
    prepareEndTime_ = other.prepareEndTime_;
    progress_ = other.progress_;
    state_ = other.state_;
    type_ = other.type_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleInfo Clone() {
    return new ScenePlayBattleInfo(this);
  }

  /// <summary>Field number for the "mode" field.</summary>
  public const int ModeFieldNumber = 4;
  private uint mode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Mode {
    get { return mode_; }
    set {
      mode_ = value;
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

  /// <summary>Field number for the "start_time" field.</summary>
  public const int StartTimeFieldNumber = 10;
  private uint startTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StartTime {
    get { return startTime_; }
    set {
      startTime_ = value;
    }
  }

  /// <summary>Field number for the "duration" field.</summary>
  public const int DurationFieldNumber = 14;
  private uint duration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Duration {
    get { return duration_; }
    set {
      duration_ = value;
    }
  }

  /// <summary>Field number for the "play_type" field.</summary>
  public const int PlayTypeFieldNumber = 12;
  private uint playType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayType {
    get { return playType_; }
    set {
      playType_ = value;
    }
  }

  /// <summary>Field number for the "play_id" field.</summary>
  public const int PlayIdFieldNumber = 1;
  private uint playId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayId {
    get { return playId_; }
    set {
      playId_ = value;
    }
  }

  /// <summary>Field number for the "prepare_end_time" field.</summary>
  public const int PrepareEndTimeFieldNumber = 7;
  private uint prepareEndTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PrepareEndTime {
    get { return prepareEndTime_; }
    set {
      prepareEndTime_ = value;
    }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 11;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 8;
  private uint state_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 9;
  private uint type_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ScenePlayBattleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ScenePlayBattleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Mode != other.Mode) return false;
    if(!progressStageList_.Equals(other.progressStageList_)) return false;
    if (StartTime != other.StartTime) return false;
    if (Duration != other.Duration) return false;
    if (PlayType != other.PlayType) return false;
    if (PlayId != other.PlayId) return false;
    if (PrepareEndTime != other.PrepareEndTime) return false;
    if (Progress != other.Progress) return false;
    if (State != other.State) return false;
    if (Type != other.Type) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Mode != 0) hash ^= Mode.GetHashCode();
    hash ^= progressStageList_.GetHashCode();
    if (StartTime != 0) hash ^= StartTime.GetHashCode();
    if (Duration != 0) hash ^= Duration.GetHashCode();
    if (PlayType != 0) hash ^= PlayType.GetHashCode();
    if (PlayId != 0) hash ^= PlayId.GetHashCode();
    if (PrepareEndTime != 0) hash ^= PrepareEndTime.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (State != 0) hash ^= State.GetHashCode();
    if (Type != 0) hash ^= Type.GetHashCode();
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
    if (PlayId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(PlayId);
    }
    progressStageList_.WriteTo(output, _repeated_progressStageList_codec);
    if (Mode != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Mode);
    }
    if (PrepareEndTime != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(PrepareEndTime);
    }
    if (State != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(State);
    }
    if (Type != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Type);
    }
    if (StartTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StartTime);
    }
    if (Progress != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Progress);
    }
    if (PlayType != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(PlayType);
    }
    if (Duration != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Duration);
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
    if (PlayId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(PlayId);
    }
    progressStageList_.WriteTo(ref output, _repeated_progressStageList_codec);
    if (Mode != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Mode);
    }
    if (PrepareEndTime != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(PrepareEndTime);
    }
    if (State != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(State);
    }
    if (Type != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Type);
    }
    if (StartTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StartTime);
    }
    if (Progress != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Progress);
    }
    if (PlayType != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(PlayType);
    }
    if (Duration != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Duration);
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
    if (Mode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Mode);
    }
    size += progressStageList_.CalculateSize(_repeated_progressStageList_codec);
    if (StartTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
    }
    if (Duration != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Duration);
    }
    if (PlayType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
    }
    if (PlayId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayId);
    }
    if (PrepareEndTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrepareEndTime);
    }
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (State != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(State);
    }
    if (Type != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ScenePlayBattleInfo other) {
    if (other == null) {
      return;
    }
    if (other.Mode != 0) {
      Mode = other.Mode;
    }
    progressStageList_.Add(other.progressStageList_);
    if (other.StartTime != 0) {
      StartTime = other.StartTime;
    }
    if (other.Duration != 0) {
      Duration = other.Duration;
    }
    if (other.PlayType != 0) {
      PlayType = other.PlayType;
    }
    if (other.PlayId != 0) {
      PlayId = other.PlayId;
    }
    if (other.PrepareEndTime != 0) {
      PrepareEndTime = other.PrepareEndTime;
    }
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    if (other.State != 0) {
      State = other.State;
    }
    if (other.Type != 0) {
      Type = other.Type;
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
          PlayId = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          progressStageList_.AddEntriesFrom(input, _repeated_progressStageList_codec);
          break;
        }
        case 32: {
          Mode = input.ReadUInt32();
          break;
        }
        case 56: {
          PrepareEndTime = input.ReadUInt32();
          break;
        }
        case 64: {
          State = input.ReadUInt32();
          break;
        }
        case 72: {
          Type = input.ReadUInt32();
          break;
        }
        case 80: {
          StartTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Progress = input.ReadUInt32();
          break;
        }
        case 96: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 112: {
          Duration = input.ReadUInt32();
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
          PlayId = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          progressStageList_.AddEntriesFrom(ref input, _repeated_progressStageList_codec);
          break;
        }
        case 32: {
          Mode = input.ReadUInt32();
          break;
        }
        case 56: {
          PrepareEndTime = input.ReadUInt32();
          break;
        }
        case 64: {
          State = input.ReadUInt32();
          break;
        }
        case 72: {
          Type = input.ReadUInt32();
          break;
        }
        case 80: {
          StartTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Progress = input.ReadUInt32();
          break;
        }
        case 96: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 112: {
          Duration = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
