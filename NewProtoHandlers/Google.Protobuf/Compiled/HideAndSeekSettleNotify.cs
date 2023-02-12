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
namespace NewProtos {

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
            "/gIKF0hpZGVBbmRTZWVrU2V0dGxlTm90aWZ5EhIKCnBsYXlfaW5kZXgYBiAB",
            "KA0SKgoKc2NvcmVfbGlzdBgLIAMoCzIWLkV4aGliaXRpb25EaXNwbGF5SW5m",
            "bxI1CgZyZWFzb24YASABKA4yJS5IaWRlQW5kU2Vla1NldHRsZU5vdGlmeS5T",
            "ZXR0bGVSZWFzb24SEwoLd2lubmVyX2xpc3QYAiADKA0SEQoJY29zdF90aW1l",
            "GA8gASgNEhIKCnN0YWdlX3R5cGUYByABKA0SFwoPaXNfcmVjb3JkX3Njb3Jl",
            "GAUgASgIEjAKEHNldHRsZV9pbmZvX2xpc3QYBCADKAsyFi5IaWRlQW5kU2Vl",
            "a1NldHRsZUluZm8iZQoMU2V0dGxlUmVhc29uEhoKFlNFVFRMRV9SRUFTT05f",
            "VElNRV9PVVQQABIaChZTRVRUTEVfUkVBU09OX1BMQVlfRU5EEAESHQoZU0VU",
            "VExFX1JFQVNPTl9QTEFZRVJfUVVJVBACQgyqAglOZXdQcm90b3NiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ExhibitionDisplayInfoReflection.Descriptor, global::NewProtos.HideAndSeekSettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.HideAndSeekSettleNotify), global::NewProtos.HideAndSeekSettleNotify.Parser, new[]{ "PlayIndex", "ScoreList", "Reason", "WinnerList", "CostTime", "StageType", "IsRecordScore", "SettleInfoList" }, null, new[]{ typeof(global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5391;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
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
      get { return global::NewProtos.HideAndSeekSettleNotifyReflection.Descriptor.MessageTypes[0]; }
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
      playIndex_ = other.playIndex_;
      scoreList_ = other.scoreList_.Clone();
      reason_ = other.reason_;
      winnerList_ = other.winnerList_.Clone();
      costTime_ = other.costTime_;
      stageType_ = other.stageType_;
      isRecordScore_ = other.isRecordScore_;
      settleInfoList_ = other.settleInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HideAndSeekSettleNotify Clone() {
      return new HideAndSeekSettleNotify(this);
    }

    /// <summary>Field number for the "play_index" field.</summary>
    public const int PlayIndexFieldNumber = 6;
    private uint playIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayIndex {
      get { return playIndex_; }
      set {
        playIndex_ = value;
      }
    }

    /// <summary>Field number for the "score_list" field.</summary>
    public const int ScoreListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::NewProtos.ExhibitionDisplayInfo> _repeated_scoreList_codec
        = pb::FieldCodec.ForMessage(90, global::NewProtos.ExhibitionDisplayInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ExhibitionDisplayInfo> scoreList_ = new pbc::RepeatedField<global::NewProtos.ExhibitionDisplayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ExhibitionDisplayInfo> ScoreList {
      get { return scoreList_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 1;
    private global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason reason_ = global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason.TimeOut;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "winner_list" field.</summary>
    public const int WinnerListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_winnerList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> winnerList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> WinnerList {
      get { return winnerList_; }
    }

    /// <summary>Field number for the "cost_time" field.</summary>
    public const int CostTimeFieldNumber = 15;
    private uint costTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostTime {
      get { return costTime_; }
      set {
        costTime_ = value;
      }
    }

    /// <summary>Field number for the "stage_type" field.</summary>
    public const int StageTypeFieldNumber = 7;
    private uint stageType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageType {
      get { return stageType_; }
      set {
        stageType_ = value;
      }
    }

    /// <summary>Field number for the "is_record_score" field.</summary>
    public const int IsRecordScoreFieldNumber = 5;
    private bool isRecordScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRecordScore {
      get { return isRecordScore_; }
      set {
        isRecordScore_ = value;
      }
    }

    /// <summary>Field number for the "settle_info_list" field.</summary>
    public const int SettleInfoListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::NewProtos.HideAndSeekSettleInfo> _repeated_settleInfoList_codec
        = pb::FieldCodec.ForMessage(34, global::NewProtos.HideAndSeekSettleInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.HideAndSeekSettleInfo> settleInfoList_ = new pbc::RepeatedField<global::NewProtos.HideAndSeekSettleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.HideAndSeekSettleInfo> SettleInfoList {
      get { return settleInfoList_; }
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
      if (PlayIndex != other.PlayIndex) return false;
      if(!scoreList_.Equals(other.scoreList_)) return false;
      if (Reason != other.Reason) return false;
      if(!winnerList_.Equals(other.winnerList_)) return false;
      if (CostTime != other.CostTime) return false;
      if (StageType != other.StageType) return false;
      if (IsRecordScore != other.IsRecordScore) return false;
      if(!settleInfoList_.Equals(other.settleInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
      hash ^= scoreList_.GetHashCode();
      if (Reason != global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason.TimeOut) hash ^= Reason.GetHashCode();
      hash ^= winnerList_.GetHashCode();
      if (CostTime != 0) hash ^= CostTime.GetHashCode();
      if (StageType != 0) hash ^= StageType.GetHashCode();
      if (IsRecordScore != false) hash ^= IsRecordScore.GetHashCode();
      hash ^= settleInfoList_.GetHashCode();
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
      if (Reason != global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      winnerList_.WriteTo(output, _repeated_winnerList_codec);
      settleInfoList_.WriteTo(output, _repeated_settleInfoList_codec);
      if (IsRecordScore != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsRecordScore);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PlayIndex);
      }
      if (StageType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageType);
      }
      scoreList_.WriteTo(output, _repeated_scoreList_codec);
      if (CostTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CostTime);
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
      if (Reason != global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      winnerList_.WriteTo(ref output, _repeated_winnerList_codec);
      settleInfoList_.WriteTo(ref output, _repeated_settleInfoList_codec);
      if (IsRecordScore != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsRecordScore);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PlayIndex);
      }
      if (StageType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageType);
      }
      scoreList_.WriteTo(ref output, _repeated_scoreList_codec);
      if (CostTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CostTime);
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
      if (PlayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
      }
      size += scoreList_.CalculateSize(_repeated_scoreList_codec);
      if (Reason != global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      size += winnerList_.CalculateSize(_repeated_winnerList_codec);
      if (CostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostTime);
      }
      if (StageType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageType);
      }
      if (IsRecordScore != false) {
        size += 1 + 1;
      }
      size += settleInfoList_.CalculateSize(_repeated_settleInfoList_codec);
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
      if (other.PlayIndex != 0) {
        PlayIndex = other.PlayIndex;
      }
      scoreList_.Add(other.scoreList_);
      if (other.Reason != global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason.TimeOut) {
        Reason = other.Reason;
      }
      winnerList_.Add(other.winnerList_);
      if (other.CostTime != 0) {
        CostTime = other.CostTime;
      }
      if (other.StageType != 0) {
        StageType = other.StageType;
      }
      if (other.IsRecordScore != false) {
        IsRecordScore = other.IsRecordScore;
      }
      settleInfoList_.Add(other.settleInfoList_);
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
            Reason = (global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            winnerList_.AddEntriesFrom(input, _repeated_winnerList_codec);
            break;
          }
          case 34: {
            settleInfoList_.AddEntriesFrom(input, _repeated_settleInfoList_codec);
            break;
          }
          case 40: {
            IsRecordScore = input.ReadBool();
            break;
          }
          case 48: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            StageType = input.ReadUInt32();
            break;
          }
          case 90: {
            scoreList_.AddEntriesFrom(input, _repeated_scoreList_codec);
            break;
          }
          case 120: {
            CostTime = input.ReadUInt32();
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
            Reason = (global::NewProtos.HideAndSeekSettleNotify.Types.SettleReason) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            winnerList_.AddEntriesFrom(ref input, _repeated_winnerList_codec);
            break;
          }
          case 34: {
            settleInfoList_.AddEntriesFrom(ref input, _repeated_settleInfoList_codec);
            break;
          }
          case 40: {
            IsRecordScore = input.ReadBool();
            break;
          }
          case 48: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            StageType = input.ReadUInt32();
            break;
          }
          case 90: {
            scoreList_.AddEntriesFrom(ref input, _repeated_scoreList_codec);
            break;
          }
          case 120: {
            CostTime = input.ReadUInt32();
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

}

#endregion Designer generated code