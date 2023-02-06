// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HideAndSeekSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HideAndSeekSettleNotify.proto</summary>
public static partial class HideAndSeekSettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for HideAndSeekSettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HideAndSeekSettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1IaWRlQW5kU2Vla1NldHRsZU5vdGlmeS5wcm90bxobRXhoaWJpdGlvbkRp",
          "c3BsYXlJbmZvLnByb3RvGhtIaWRlQW5kU2Vla1NldHRsZUluZm8ucHJvdG8i",
          "/gIKF0hpZGVBbmRTZWVrU2V0dGxlTm90aWZ5EhEKCWNvc3RfdGltZRgCIAEo",
          "DRIwChBzZXR0bGVfaW5mb19saXN0GAggAygLMhYuSGlkZUFuZFNlZWtTZXR0",
          "bGVJbmZvEhMKC3dpbm5lcl9saXN0GA8gAygNEjUKBnJlYXNvbhgEIAEoDjIl",
          "LkhpZGVBbmRTZWVrU2V0dGxlTm90aWZ5LlNldHRsZVJlYXNvbhISCgpwbGF5",
          "X2luZGV4GA0gASgNEhcKD2lzX3JlY29yZF9zY29yZRgGIAEoCBIqCgpzY29y",
          "ZV9saXN0GAkgAygLMhYuRXhoaWJpdGlvbkRpc3BsYXlJbmZvEhIKCnN0YWdl",
          "X3R5cGUYDiABKA0iZQoMU2V0dGxlUmVhc29uEhoKFlNFVFRMRV9SRUFTT05f",
          "VElNRV9PVVQQABIaChZTRVRUTEVfUkVBU09OX1BMQVlfRU5EEAESHQoZU0VU",
          "VExFX1JFQVNPTl9QTEFZRVJfUVVJVBACQh4KHGVtdS5ncmFzc2N1dHRlci5u",
          "ZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ExhibitionDisplayInfoReflection.Descriptor, global::HideAndSeekSettleInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HideAndSeekSettleNotify), global::HideAndSeekSettleNotify.Parser, new[]{ "CostTime", "SettleInfoList", "WinnerList", "Reason", "PlayIndex", "IsRecordScore", "ScoreList", "StageType" }, null, new[]{ typeof(global::HideAndSeekSettleNotify.Types.SettleReason) }, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 5317
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class HideAndSeekSettleNotify : pb::IMessage<HideAndSeekSettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HideAndSeekSettleNotify> _parser = new pb::MessageParser<HideAndSeekSettleNotify>(() => new HideAndSeekSettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HideAndSeekSettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HideAndSeekSettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekSettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekSettleNotify(HideAndSeekSettleNotify other) : this() {
    costTime_ = other.costTime_;
    settleInfoList_ = other.settleInfoList_.Clone();
    winnerList_ = other.winnerList_.Clone();
    reason_ = other.reason_;
    playIndex_ = other.playIndex_;
    isRecordScore_ = other.isRecordScore_;
    scoreList_ = other.scoreList_.Clone();
    stageType_ = other.stageType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekSettleNotify Clone() {
    return new HideAndSeekSettleNotify(this);
  }

  /// <summary>Field number for the "cost_time" field.</summary>
  public const int CostTimeFieldNumber = 2;
  private uint costTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CostTime {
    get { return costTime_; }
    set {
      costTime_ = value;
    }
  }

  /// <summary>Field number for the "settle_info_list" field.</summary>
  public const int SettleInfoListFieldNumber = 8;
  private static readonly pb::FieldCodec<global::HideAndSeekSettleInfo> _repeated_settleInfoList_codec
      = pb::FieldCodec.ForMessage(66, global::HideAndSeekSettleInfo.Parser);
  private readonly pbc::RepeatedField<global::HideAndSeekSettleInfo> settleInfoList_ = new pbc::RepeatedField<global::HideAndSeekSettleInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::HideAndSeekSettleInfo> SettleInfoList {
    get { return settleInfoList_; }
  }

  /// <summary>Field number for the "winner_list" field.</summary>
  public const int WinnerListFieldNumber = 15;
  private static readonly pb::FieldCodec<uint> _repeated_winnerList_codec
      = pb::FieldCodec.ForUInt32(122);
  private readonly pbc::RepeatedField<uint> winnerList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> WinnerList {
    get { return winnerList_; }
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 4;
  private global::HideAndSeekSettleNotify.Types.SettleReason reason_ = global::HideAndSeekSettleNotify.Types.SettleReason.TimeOut;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::HideAndSeekSettleNotify.Types.SettleReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "play_index" field.</summary>
  public const int PlayIndexFieldNumber = 13;
  private uint playIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayIndex {
    get { return playIndex_; }
    set {
      playIndex_ = value;
    }
  }

  /// <summary>Field number for the "is_record_score" field.</summary>
  public const int IsRecordScoreFieldNumber = 6;
  private bool isRecordScore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsRecordScore {
    get { return isRecordScore_; }
    set {
      isRecordScore_ = value;
    }
  }

  /// <summary>Field number for the "score_list" field.</summary>
  public const int ScoreListFieldNumber = 9;
  private static readonly pb::FieldCodec<global::ExhibitionDisplayInfo> _repeated_scoreList_codec
      = pb::FieldCodec.ForMessage(74, global::ExhibitionDisplayInfo.Parser);
  private readonly pbc::RepeatedField<global::ExhibitionDisplayInfo> scoreList_ = new pbc::RepeatedField<global::ExhibitionDisplayInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ExhibitionDisplayInfo> ScoreList {
    get { return scoreList_; }
  }

  /// <summary>Field number for the "stage_type" field.</summary>
  public const int StageTypeFieldNumber = 14;
  private uint stageType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageType {
    get { return stageType_; }
    set {
      stageType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HideAndSeekSettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HideAndSeekSettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CostTime != other.CostTime) return false;
    if(!settleInfoList_.Equals(other.settleInfoList_)) return false;
    if(!winnerList_.Equals(other.winnerList_)) return false;
    if (Reason != other.Reason) return false;
    if (PlayIndex != other.PlayIndex) return false;
    if (IsRecordScore != other.IsRecordScore) return false;
    if(!scoreList_.Equals(other.scoreList_)) return false;
    if (StageType != other.StageType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (CostTime != 0) hash ^= CostTime.GetHashCode();
    hash ^= settleInfoList_.GetHashCode();
    hash ^= winnerList_.GetHashCode();
    if (Reason != global::HideAndSeekSettleNotify.Types.SettleReason.TimeOut) hash ^= Reason.GetHashCode();
    if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
    if (IsRecordScore != false) hash ^= IsRecordScore.GetHashCode();
    hash ^= scoreList_.GetHashCode();
    if (StageType != 0) hash ^= StageType.GetHashCode();
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
    if (CostTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(CostTime);
    }
    if (Reason != global::HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Reason);
    }
    if (IsRecordScore != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsRecordScore);
    }
    settleInfoList_.WriteTo(output, _repeated_settleInfoList_codec);
    scoreList_.WriteTo(output, _repeated_scoreList_codec);
    if (PlayIndex != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(PlayIndex);
    }
    if (StageType != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(StageType);
    }
    winnerList_.WriteTo(output, _repeated_winnerList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (CostTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(CostTime);
    }
    if (Reason != global::HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Reason);
    }
    if (IsRecordScore != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsRecordScore);
    }
    settleInfoList_.WriteTo(ref output, _repeated_settleInfoList_codec);
    scoreList_.WriteTo(ref output, _repeated_scoreList_codec);
    if (PlayIndex != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(PlayIndex);
    }
    if (StageType != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(StageType);
    }
    winnerList_.WriteTo(ref output, _repeated_winnerList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (CostTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostTime);
    }
    size += settleInfoList_.CalculateSize(_repeated_settleInfoList_codec);
    size += winnerList_.CalculateSize(_repeated_winnerList_codec);
    if (Reason != global::HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (PlayIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
    }
    if (IsRecordScore != false) {
      size += 1 + 1;
    }
    size += scoreList_.CalculateSize(_repeated_scoreList_codec);
    if (StageType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HideAndSeekSettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.CostTime != 0) {
      CostTime = other.CostTime;
    }
    settleInfoList_.Add(other.settleInfoList_);
    winnerList_.Add(other.winnerList_);
    if (other.Reason != global::HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
      Reason = other.Reason;
    }
    if (other.PlayIndex != 0) {
      PlayIndex = other.PlayIndex;
    }
    if (other.IsRecordScore != false) {
      IsRecordScore = other.IsRecordScore;
    }
    scoreList_.Add(other.scoreList_);
    if (other.StageType != 0) {
      StageType = other.StageType;
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
          CostTime = input.ReadUInt32();
          break;
        }
        case 32: {
          Reason = (global::HideAndSeekSettleNotify.Types.SettleReason) input.ReadEnum();
          break;
        }
        case 48: {
          IsRecordScore = input.ReadBool();
          break;
        }
        case 66: {
          settleInfoList_.AddEntriesFrom(input, _repeated_settleInfoList_codec);
          break;
        }
        case 74: {
          scoreList_.AddEntriesFrom(input, _repeated_scoreList_codec);
          break;
        }
        case 104: {
          PlayIndex = input.ReadUInt32();
          break;
        }
        case 112: {
          StageType = input.ReadUInt32();
          break;
        }
        case 122:
        case 120: {
          winnerList_.AddEntriesFrom(input, _repeated_winnerList_codec);
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
          CostTime = input.ReadUInt32();
          break;
        }
        case 32: {
          Reason = (global::HideAndSeekSettleNotify.Types.SettleReason) input.ReadEnum();
          break;
        }
        case 48: {
          IsRecordScore = input.ReadBool();
          break;
        }
        case 66: {
          settleInfoList_.AddEntriesFrom(ref input, _repeated_settleInfoList_codec);
          break;
        }
        case 74: {
          scoreList_.AddEntriesFrom(ref input, _repeated_scoreList_codec);
          break;
        }
        case 104: {
          PlayIndex = input.ReadUInt32();
          break;
        }
        case 112: {
          StageType = input.ReadUInt32();
          break;
        }
        case 122:
        case 120: {
          winnerList_.AddEntriesFrom(ref input, _repeated_winnerList_codec);
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the HideAndSeekSettleNotify message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum SettleReason {
      [pbr::OriginalName("SETTLE_REASON_TIME_OUT")] TimeOut = 0,
      [pbr::OriginalName("SETTLE_REASON_PLAY_END")] PlayEnd = 1,
      [pbr::OriginalName("SETTLE_REASON_PLAYER_QUIT")] PlayerQuit = 2,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
