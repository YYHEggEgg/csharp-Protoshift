// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerMatchInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PlayerMatchInfoNotify.proto</summary>
public static partial class PlayerMatchInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for PlayerMatchInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlayerMatchInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtQbGF5ZXJNYXRjaEluZm9Ob3RpZnkucHJvdG8aD01hdGNoVHlwZS5wcm90",
          "byL9AQoVUGxheWVyTWF0Y2hJbmZvTm90aWZ5EhAKCG1hdGNoX2lkGAggASgN",
          "EhgKEG1hdGNoX2JlZ2luX3RpbWUYBCABKA0SEgoKZHVuZ2Vvbl9pZBgKIAEo",
          "DRIeCgptYXRjaF90eXBlGAsgASgOMgouTWF0Y2hUeXBlEiIKGm1lY2hhbmlj",
          "dXNfZGlmZmljdWx0X2xldmVsGAwgASgNEhgKEG1hdGNoX3BhcmFtX2xpc3QY",
          "BiADKA0SIAoYZXN0aW1hdGVfbWF0Y2hfY29zdF90aW1lGAMgASgNEhIKCm1w",
          "X3BsYXlfaWQYBSABKA0SEAoIaG9zdF91aWQYDSABKA1CHgocZW11LmdyYXNz",
          "Y3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MatchTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PlayerMatchInfoNotify), global::PlayerMatchInfoNotify.Parser, new[]{ "MatchId", "MatchBeginTime", "DungeonId", "MatchType", "MechanicusDifficultLevel", "MatchParamList", "EstimateMatchCostTime", "MpPlayId", "HostUid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4175
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class PlayerMatchInfoNotify : pb::IMessage<PlayerMatchInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlayerMatchInfoNotify> _parser = new pb::MessageParser<PlayerMatchInfoNotify>(() => new PlayerMatchInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlayerMatchInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlayerMatchInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerMatchInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerMatchInfoNotify(PlayerMatchInfoNotify other) : this() {
    matchId_ = other.matchId_;
    matchBeginTime_ = other.matchBeginTime_;
    dungeonId_ = other.dungeonId_;
    matchType_ = other.matchType_;
    mechanicusDifficultLevel_ = other.mechanicusDifficultLevel_;
    matchParamList_ = other.matchParamList_.Clone();
    estimateMatchCostTime_ = other.estimateMatchCostTime_;
    mpPlayId_ = other.mpPlayId_;
    hostUid_ = other.hostUid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerMatchInfoNotify Clone() {
    return new PlayerMatchInfoNotify(this);
  }

  /// <summary>Field number for the "match_id" field.</summary>
  public const int MatchIdFieldNumber = 8;
  private uint matchId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MatchId {
    get { return matchId_; }
    set {
      matchId_ = value;
    }
  }

  /// <summary>Field number for the "match_begin_time" field.</summary>
  public const int MatchBeginTimeFieldNumber = 4;
  private uint matchBeginTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MatchBeginTime {
    get { return matchBeginTime_; }
    set {
      matchBeginTime_ = value;
    }
  }

  /// <summary>Field number for the "dungeon_id" field.</summary>
  public const int DungeonIdFieldNumber = 10;
  private uint dungeonId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DungeonId {
    get { return dungeonId_; }
    set {
      dungeonId_ = value;
    }
  }

  /// <summary>Field number for the "match_type" field.</summary>
  public const int MatchTypeFieldNumber = 11;
  private global::MatchType matchType_ = global::MatchType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::MatchType MatchType {
    get { return matchType_; }
    set {
      matchType_ = value;
    }
  }

  /// <summary>Field number for the "mechanicus_difficult_level" field.</summary>
  public const int MechanicusDifficultLevelFieldNumber = 12;
  private uint mechanicusDifficultLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MechanicusDifficultLevel {
    get { return mechanicusDifficultLevel_; }
    set {
      mechanicusDifficultLevel_ = value;
    }
  }

  /// <summary>Field number for the "match_param_list" field.</summary>
  public const int MatchParamListFieldNumber = 6;
  private static readonly pb::FieldCodec<uint> _repeated_matchParamList_codec
      = pb::FieldCodec.ForUInt32(50);
  private readonly pbc::RepeatedField<uint> matchParamList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> MatchParamList {
    get { return matchParamList_; }
  }

  /// <summary>Field number for the "estimate_match_cost_time" field.</summary>
  public const int EstimateMatchCostTimeFieldNumber = 3;
  private uint estimateMatchCostTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EstimateMatchCostTime {
    get { return estimateMatchCostTime_; }
    set {
      estimateMatchCostTime_ = value;
    }
  }

  /// <summary>Field number for the "mp_play_id" field.</summary>
  public const int MpPlayIdFieldNumber = 5;
  private uint mpPlayId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MpPlayId {
    get { return mpPlayId_; }
    set {
      mpPlayId_ = value;
    }
  }

  /// <summary>Field number for the "host_uid" field.</summary>
  public const int HostUidFieldNumber = 13;
  private uint hostUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint HostUid {
    get { return hostUid_; }
    set {
      hostUid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlayerMatchInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlayerMatchInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MatchId != other.MatchId) return false;
    if (MatchBeginTime != other.MatchBeginTime) return false;
    if (DungeonId != other.DungeonId) return false;
    if (MatchType != other.MatchType) return false;
    if (MechanicusDifficultLevel != other.MechanicusDifficultLevel) return false;
    if(!matchParamList_.Equals(other.matchParamList_)) return false;
    if (EstimateMatchCostTime != other.EstimateMatchCostTime) return false;
    if (MpPlayId != other.MpPlayId) return false;
    if (HostUid != other.HostUid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (MatchId != 0) hash ^= MatchId.GetHashCode();
    if (MatchBeginTime != 0) hash ^= MatchBeginTime.GetHashCode();
    if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
    if (MatchType != global::MatchType.None) hash ^= MatchType.GetHashCode();
    if (MechanicusDifficultLevel != 0) hash ^= MechanicusDifficultLevel.GetHashCode();
    hash ^= matchParamList_.GetHashCode();
    if (EstimateMatchCostTime != 0) hash ^= EstimateMatchCostTime.GetHashCode();
    if (MpPlayId != 0) hash ^= MpPlayId.GetHashCode();
    if (HostUid != 0) hash ^= HostUid.GetHashCode();
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
    if (EstimateMatchCostTime != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(EstimateMatchCostTime);
    }
    if (MatchBeginTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(MatchBeginTime);
    }
    if (MpPlayId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MpPlayId);
    }
    matchParamList_.WriteTo(output, _repeated_matchParamList_codec);
    if (MatchId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(MatchId);
    }
    if (DungeonId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DungeonId);
    }
    if (MatchType != global::MatchType.None) {
      output.WriteRawTag(88);
      output.WriteEnum((int) MatchType);
    }
    if (MechanicusDifficultLevel != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(MechanicusDifficultLevel);
    }
    if (HostUid != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(HostUid);
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
    if (EstimateMatchCostTime != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(EstimateMatchCostTime);
    }
    if (MatchBeginTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(MatchBeginTime);
    }
    if (MpPlayId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MpPlayId);
    }
    matchParamList_.WriteTo(ref output, _repeated_matchParamList_codec);
    if (MatchId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(MatchId);
    }
    if (DungeonId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DungeonId);
    }
    if (MatchType != global::MatchType.None) {
      output.WriteRawTag(88);
      output.WriteEnum((int) MatchType);
    }
    if (MechanicusDifficultLevel != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(MechanicusDifficultLevel);
    }
    if (HostUid != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(HostUid);
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
    if (MatchId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MatchId);
    }
    if (MatchBeginTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MatchBeginTime);
    }
    if (DungeonId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
    }
    if (MatchType != global::MatchType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
    }
    if (MechanicusDifficultLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusDifficultLevel);
    }
    size += matchParamList_.CalculateSize(_repeated_matchParamList_codec);
    if (EstimateMatchCostTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EstimateMatchCostTime);
    }
    if (MpPlayId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayId);
    }
    if (HostUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HostUid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlayerMatchInfoNotify other) {
    if (other == null) {
      return;
    }
    if (other.MatchId != 0) {
      MatchId = other.MatchId;
    }
    if (other.MatchBeginTime != 0) {
      MatchBeginTime = other.MatchBeginTime;
    }
    if (other.DungeonId != 0) {
      DungeonId = other.DungeonId;
    }
    if (other.MatchType != global::MatchType.None) {
      MatchType = other.MatchType;
    }
    if (other.MechanicusDifficultLevel != 0) {
      MechanicusDifficultLevel = other.MechanicusDifficultLevel;
    }
    matchParamList_.Add(other.matchParamList_);
    if (other.EstimateMatchCostTime != 0) {
      EstimateMatchCostTime = other.EstimateMatchCostTime;
    }
    if (other.MpPlayId != 0) {
      MpPlayId = other.MpPlayId;
    }
    if (other.HostUid != 0) {
      HostUid = other.HostUid;
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
          EstimateMatchCostTime = input.ReadUInt32();
          break;
        }
        case 32: {
          MatchBeginTime = input.ReadUInt32();
          break;
        }
        case 40: {
          MpPlayId = input.ReadUInt32();
          break;
        }
        case 50:
        case 48: {
          matchParamList_.AddEntriesFrom(input, _repeated_matchParamList_codec);
          break;
        }
        case 64: {
          MatchId = input.ReadUInt32();
          break;
        }
        case 80: {
          DungeonId = input.ReadUInt32();
          break;
        }
        case 88: {
          MatchType = (global::MatchType) input.ReadEnum();
          break;
        }
        case 96: {
          MechanicusDifficultLevel = input.ReadUInt32();
          break;
        }
        case 104: {
          HostUid = input.ReadUInt32();
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
          EstimateMatchCostTime = input.ReadUInt32();
          break;
        }
        case 32: {
          MatchBeginTime = input.ReadUInt32();
          break;
        }
        case 40: {
          MpPlayId = input.ReadUInt32();
          break;
        }
        case 50:
        case 48: {
          matchParamList_.AddEntriesFrom(ref input, _repeated_matchParamList_codec);
          break;
        }
        case 64: {
          MatchId = input.ReadUInt32();
          break;
        }
        case 80: {
          DungeonId = input.ReadUInt32();
          break;
        }
        case 88: {
          MatchType = (global::MatchType) input.ReadEnum();
          break;
        }
        case 96: {
          MechanicusDifficultLevel = input.ReadUInt32();
          break;
        }
        case 104: {
          HostUid = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
