// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayBattleResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ScenePlayBattleResultNotify.proto</summary>
public static partial class ScenePlayBattleResultNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ScenePlayBattleResultNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ScenePlayBattleResultNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFTY2VuZVBsYXlCYXR0bGVSZXN1bHROb3RpZnkucHJvdG8aJVNjZW5lUGxh",
          "eUJhdHRsZVNldHRsZVBsYXllckluZm8ucHJvdG8aJVNjZW5lUGxheUJhdHRs",
          "ZVNldHRsZVJld2FyZEluZm8ucHJvdG8i6gEKG1NjZW5lUGxheUJhdHRsZVJl",
          "c3VsdE5vdGlmeRIOCgZpc193aW4YASABKAgSEQoJY29zdF90aW1lGAcgASgN",
          "EhEKCXBsYXlfdHlwZRgPIAEoDRIPCgdwbGF5X2lkGAsgASgNEkEKF3NldHRs",
          "ZV9wbGF5ZXJfaW5mb19saXN0GAQgAygLMiAuU2NlbmVQbGF5QmF0dGxlU2V0",
          "dGxlUGxheWVySW5mbxJBChdzZXR0bGVfcmV3YXJkX2luZm9fbGlzdBgOIAMo",
          "CzIgLlNjZW5lUGxheUJhdHRsZVNldHRsZVJld2FyZEluZm9CHgocZW11Lmdy",
          "YXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ScenePlayBattleSettlePlayerInfoReflection.Descriptor, global::ScenePlayBattleSettleRewardInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ScenePlayBattleResultNotify), global::ScenePlayBattleResultNotify.Parser, new[]{ "IsWin", "CostTime", "PlayType", "PlayId", "SettlePlayerInfoList", "SettleRewardInfoList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4398
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ScenePlayBattleResultNotify : pb::IMessage<ScenePlayBattleResultNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ScenePlayBattleResultNotify> _parser = new pb::MessageParser<ScenePlayBattleResultNotify>(() => new ScenePlayBattleResultNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ScenePlayBattleResultNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ScenePlayBattleResultNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleResultNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleResultNotify(ScenePlayBattleResultNotify other) : this() {
    isWin_ = other.isWin_;
    costTime_ = other.costTime_;
    playType_ = other.playType_;
    playId_ = other.playId_;
    settlePlayerInfoList_ = other.settlePlayerInfoList_.Clone();
    settleRewardInfoList_ = other.settleRewardInfoList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleResultNotify Clone() {
    return new ScenePlayBattleResultNotify(this);
  }

  /// <summary>Field number for the "is_win" field.</summary>
  public const int IsWinFieldNumber = 1;
  private bool isWin_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsWin {
    get { return isWin_; }
    set {
      isWin_ = value;
    }
  }

  /// <summary>Field number for the "cost_time" field.</summary>
  public const int CostTimeFieldNumber = 7;
  private uint costTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CostTime {
    get { return costTime_; }
    set {
      costTime_ = value;
    }
  }

  /// <summary>Field number for the "play_type" field.</summary>
  public const int PlayTypeFieldNumber = 15;
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
  public const int PlayIdFieldNumber = 11;
  private uint playId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayId {
    get { return playId_; }
    set {
      playId_ = value;
    }
  }

  /// <summary>Field number for the "settle_player_info_list" field.</summary>
  public const int SettlePlayerInfoListFieldNumber = 4;
  private static readonly pb::FieldCodec<global::ScenePlayBattleSettlePlayerInfo> _repeated_settlePlayerInfoList_codec
      = pb::FieldCodec.ForMessage(34, global::ScenePlayBattleSettlePlayerInfo.Parser);
  private readonly pbc::RepeatedField<global::ScenePlayBattleSettlePlayerInfo> settlePlayerInfoList_ = new pbc::RepeatedField<global::ScenePlayBattleSettlePlayerInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ScenePlayBattleSettlePlayerInfo> SettlePlayerInfoList {
    get { return settlePlayerInfoList_; }
  }

  /// <summary>Field number for the "settle_reward_info_list" field.</summary>
  public const int SettleRewardInfoListFieldNumber = 14;
  private static readonly pb::FieldCodec<global::ScenePlayBattleSettleRewardInfo> _repeated_settleRewardInfoList_codec
      = pb::FieldCodec.ForMessage(114, global::ScenePlayBattleSettleRewardInfo.Parser);
  private readonly pbc::RepeatedField<global::ScenePlayBattleSettleRewardInfo> settleRewardInfoList_ = new pbc::RepeatedField<global::ScenePlayBattleSettleRewardInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ScenePlayBattleSettleRewardInfo> SettleRewardInfoList {
    get { return settleRewardInfoList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ScenePlayBattleResultNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ScenePlayBattleResultNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsWin != other.IsWin) return false;
    if (CostTime != other.CostTime) return false;
    if (PlayType != other.PlayType) return false;
    if (PlayId != other.PlayId) return false;
    if(!settlePlayerInfoList_.Equals(other.settlePlayerInfoList_)) return false;
    if(!settleRewardInfoList_.Equals(other.settleRewardInfoList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsWin != false) hash ^= IsWin.GetHashCode();
    if (CostTime != 0) hash ^= CostTime.GetHashCode();
    if (PlayType != 0) hash ^= PlayType.GetHashCode();
    if (PlayId != 0) hash ^= PlayId.GetHashCode();
    hash ^= settlePlayerInfoList_.GetHashCode();
    hash ^= settleRewardInfoList_.GetHashCode();
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
    if (IsWin != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsWin);
    }
    settlePlayerInfoList_.WriteTo(output, _repeated_settlePlayerInfoList_codec);
    if (CostTime != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CostTime);
    }
    if (PlayId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(PlayId);
    }
    settleRewardInfoList_.WriteTo(output, _repeated_settleRewardInfoList_codec);
    if (PlayType != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(PlayType);
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
    if (IsWin != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsWin);
    }
    settlePlayerInfoList_.WriteTo(ref output, _repeated_settlePlayerInfoList_codec);
    if (CostTime != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CostTime);
    }
    if (PlayId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(PlayId);
    }
    settleRewardInfoList_.WriteTo(ref output, _repeated_settleRewardInfoList_codec);
    if (PlayType != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(PlayType);
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
    if (IsWin != false) {
      size += 1 + 1;
    }
    if (CostTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostTime);
    }
    if (PlayType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
    }
    if (PlayId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayId);
    }
    size += settlePlayerInfoList_.CalculateSize(_repeated_settlePlayerInfoList_codec);
    size += settleRewardInfoList_.CalculateSize(_repeated_settleRewardInfoList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ScenePlayBattleResultNotify other) {
    if (other == null) {
      return;
    }
    if (other.IsWin != false) {
      IsWin = other.IsWin;
    }
    if (other.CostTime != 0) {
      CostTime = other.CostTime;
    }
    if (other.PlayType != 0) {
      PlayType = other.PlayType;
    }
    if (other.PlayId != 0) {
      PlayId = other.PlayId;
    }
    settlePlayerInfoList_.Add(other.settlePlayerInfoList_);
    settleRewardInfoList_.Add(other.settleRewardInfoList_);
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
          IsWin = input.ReadBool();
          break;
        }
        case 34: {
          settlePlayerInfoList_.AddEntriesFrom(input, _repeated_settlePlayerInfoList_codec);
          break;
        }
        case 56: {
          CostTime = input.ReadUInt32();
          break;
        }
        case 88: {
          PlayId = input.ReadUInt32();
          break;
        }
        case 114: {
          settleRewardInfoList_.AddEntriesFrom(input, _repeated_settleRewardInfoList_codec);
          break;
        }
        case 120: {
          PlayType = input.ReadUInt32();
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
          IsWin = input.ReadBool();
          break;
        }
        case 34: {
          settlePlayerInfoList_.AddEntriesFrom(ref input, _repeated_settlePlayerInfoList_codec);
          break;
        }
        case 56: {
          CostTime = input.ReadUInt32();
          break;
        }
        case 88: {
          PlayId = input.ReadUInt32();
          break;
        }
        case 114: {
          settleRewardInfoList_.AddEntriesFrom(ref input, _repeated_settleRewardInfoList_codec);
          break;
        }
        case 120: {
          PlayType = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
