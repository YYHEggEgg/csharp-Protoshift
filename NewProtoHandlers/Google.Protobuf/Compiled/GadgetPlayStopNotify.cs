// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetPlayStopNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GadgetPlayStopNotify.proto</summary>
public static partial class GadgetPlayStopNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for GadgetPlayStopNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GadgetPlayStopNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpHYWRnZXRQbGF5U3RvcE5vdGlmeS5wcm90bxoXR2FkZ2V0UGxheVVpZElu",
          "Zm8ucHJvdG8imQEKFEdhZGdldFBsYXlTdG9wTm90aWZ5EikKDXVpZF9pbmZv",
          "X2xpc3QYASADKAsyEi5HYWRnZXRQbGF5VWlkSW5mbxIRCglwbGF5X3R5cGUY",
          "AyABKA0SDgoGaXNfd2luGAggASgIEhEKCWVudGl0eV9pZBgPIAEoDRINCgVz",
          "Y29yZRgFIAEoDRIRCgljb3N0X3RpbWUYDiABKA1CFgoUb3JnLnNvcmFwb2lu",
          "dGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GadgetPlayUidInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GadgetPlayStopNotify), global::GadgetPlayStopNotify.Parser, new[]{ "UidInfoList", "PlayType", "IsWin", "EntityId", "Score", "CostTime" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 857;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GadgetPlayStopNotify : pb::IMessage<GadgetPlayStopNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GadgetPlayStopNotify> _parser = new pb::MessageParser<GadgetPlayStopNotify>(() => new GadgetPlayStopNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GadgetPlayStopNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GadgetPlayStopNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayStopNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayStopNotify(GadgetPlayStopNotify other) : this() {
    uidInfoList_ = other.uidInfoList_.Clone();
    playType_ = other.playType_;
    isWin_ = other.isWin_;
    entityId_ = other.entityId_;
    score_ = other.score_;
    costTime_ = other.costTime_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayStopNotify Clone() {
    return new GadgetPlayStopNotify(this);
  }

  /// <summary>Field number for the "uid_info_list" field.</summary>
  public const int UidInfoListFieldNumber = 1;
  private static readonly pb::FieldCodec<global::GadgetPlayUidInfo> _repeated_uidInfoList_codec
      = pb::FieldCodec.ForMessage(10, global::GadgetPlayUidInfo.Parser);
  private readonly pbc::RepeatedField<global::GadgetPlayUidInfo> uidInfoList_ = new pbc::RepeatedField<global::GadgetPlayUidInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GadgetPlayUidInfo> UidInfoList {
    get { return uidInfoList_; }
  }

  /// <summary>Field number for the "play_type" field.</summary>
  public const int PlayTypeFieldNumber = 3;
  private uint playType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayType {
    get { return playType_; }
    set {
      playType_ = value;
    }
  }

  /// <summary>Field number for the "is_win" field.</summary>
  public const int IsWinFieldNumber = 8;
  private bool isWin_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsWin {
    get { return isWin_; }
    set {
      isWin_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 15;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  /// <summary>Field number for the "score" field.</summary>
  public const int ScoreFieldNumber = 5;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  /// <summary>Field number for the "cost_time" field.</summary>
  public const int CostTimeFieldNumber = 14;
  private uint costTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CostTime {
    get { return costTime_; }
    set {
      costTime_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GadgetPlayStopNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GadgetPlayStopNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!uidInfoList_.Equals(other.uidInfoList_)) return false;
    if (PlayType != other.PlayType) return false;
    if (IsWin != other.IsWin) return false;
    if (EntityId != other.EntityId) return false;
    if (Score != other.Score) return false;
    if (CostTime != other.CostTime) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= uidInfoList_.GetHashCode();
    if (PlayType != 0) hash ^= PlayType.GetHashCode();
    if (IsWin != false) hash ^= IsWin.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (Score != 0) hash ^= Score.GetHashCode();
    if (CostTime != 0) hash ^= CostTime.GetHashCode();
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
    uidInfoList_.WriteTo(output, _repeated_uidInfoList_codec);
    if (PlayType != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(PlayType);
    }
    if (Score != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Score);
    }
    if (IsWin != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsWin);
    }
    if (CostTime != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CostTime);
    }
    if (EntityId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(EntityId);
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
    uidInfoList_.WriteTo(ref output, _repeated_uidInfoList_codec);
    if (PlayType != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(PlayType);
    }
    if (Score != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Score);
    }
    if (IsWin != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsWin);
    }
    if (CostTime != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CostTime);
    }
    if (EntityId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(EntityId);
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
    size += uidInfoList_.CalculateSize(_repeated_uidInfoList_codec);
    if (PlayType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
    }
    if (IsWin != false) {
      size += 1 + 1;
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (Score != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
    }
    if (CostTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostTime);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GadgetPlayStopNotify other) {
    if (other == null) {
      return;
    }
    uidInfoList_.Add(other.uidInfoList_);
    if (other.PlayType != 0) {
      PlayType = other.PlayType;
    }
    if (other.IsWin != false) {
      IsWin = other.IsWin;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.Score != 0) {
      Score = other.Score;
    }
    if (other.CostTime != 0) {
      CostTime = other.CostTime;
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
        case 10: {
          uidInfoList_.AddEntriesFrom(input, _repeated_uidInfoList_codec);
          break;
        }
        case 24: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 40: {
          Score = input.ReadUInt32();
          break;
        }
        case 64: {
          IsWin = input.ReadBool();
          break;
        }
        case 112: {
          CostTime = input.ReadUInt32();
          break;
        }
        case 120: {
          EntityId = input.ReadUInt32();
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
        case 10: {
          uidInfoList_.AddEntriesFrom(ref input, _repeated_uidInfoList_codec);
          break;
        }
        case 24: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 40: {
          Score = input.ReadUInt32();
          break;
        }
        case 64: {
          IsWin = input.ReadBool();
          break;
        }
        case 112: {
          CostTime = input.ReadUInt32();
          break;
        }
        case 120: {
          EntityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code