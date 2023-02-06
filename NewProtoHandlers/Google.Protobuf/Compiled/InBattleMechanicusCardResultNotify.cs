// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusCardResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from InBattleMechanicusCardResultNotify.proto</summary>
public static partial class InBattleMechanicusCardResultNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for InBattleMechanicusCardResultNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InBattleMechanicusCardResultNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CihJbkJhdHRsZU1lY2hhbmljdXNDYXJkUmVzdWx0Tm90aWZ5LnByb3RvGiBJ",
          "bkJhdHRsZU1lY2hhbmljdXNDYXJkSW5mby5wcm90byLPAgoiSW5CYXR0bGVN",
          "ZWNoYW5pY3VzQ2FyZFJlc3VsdE5vdGlmeRIQCghncm91cF9pZBgKIAEoDRIu",
          "CgljYXJkX2xpc3QYCCADKAsyGy5JbkJhdHRsZU1lY2hhbmljdXNDYXJkSW5m",
          "bxISCgpwbGF5X2luZGV4GA4gASgNEmIKGXBsYXllcl9jb25maXJtZWRfY2Fy",
          "ZF9tYXAYCSADKAsyPy5JbkJhdHRsZU1lY2hhbmljdXNDYXJkUmVzdWx0Tm90",
          "aWZ5LlBsYXllckNvbmZpcm1lZENhcmRNYXBFbnRyeRIaChJ3YWl0X2JlZ2lu",
          "X3RpbWVfdXMYAiABKAQSFAoMd2FpdF9zZWNvbmRzGAUgASgNGj0KG1BsYXll",
          "ckNvbmZpcm1lZENhcmRNYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUY",
          "AiABKA06AjgBQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::InBattleMechanicusCardInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InBattleMechanicusCardResultNotify), global::InBattleMechanicusCardResultNotify.Parser, new[]{ "GroupId", "CardList", "PlayIndex", "PlayerConfirmedCardMap", "WaitBeginTimeUs", "WaitSeconds" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 5399;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class InBattleMechanicusCardResultNotify : pb::IMessage<InBattleMechanicusCardResultNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InBattleMechanicusCardResultNotify> _parser = new pb::MessageParser<InBattleMechanicusCardResultNotify>(() => new InBattleMechanicusCardResultNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InBattleMechanicusCardResultNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InBattleMechanicusCardResultNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusCardResultNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusCardResultNotify(InBattleMechanicusCardResultNotify other) : this() {
    groupId_ = other.groupId_;
    cardList_ = other.cardList_.Clone();
    playIndex_ = other.playIndex_;
    playerConfirmedCardMap_ = other.playerConfirmedCardMap_.Clone();
    waitBeginTimeUs_ = other.waitBeginTimeUs_;
    waitSeconds_ = other.waitSeconds_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusCardResultNotify Clone() {
    return new InBattleMechanicusCardResultNotify(this);
  }

  /// <summary>Field number for the "group_id" field.</summary>
  public const int GroupIdFieldNumber = 10;
  private uint groupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GroupId {
    get { return groupId_; }
    set {
      groupId_ = value;
    }
  }

  /// <summary>Field number for the "card_list" field.</summary>
  public const int CardListFieldNumber = 8;
  private static readonly pb::FieldCodec<global::InBattleMechanicusCardInfo> _repeated_cardList_codec
      = pb::FieldCodec.ForMessage(66, global::InBattleMechanicusCardInfo.Parser);
  private readonly pbc::RepeatedField<global::InBattleMechanicusCardInfo> cardList_ = new pbc::RepeatedField<global::InBattleMechanicusCardInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InBattleMechanicusCardInfo> CardList {
    get { return cardList_; }
  }

  /// <summary>Field number for the "play_index" field.</summary>
  public const int PlayIndexFieldNumber = 14;
  private uint playIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayIndex {
    get { return playIndex_; }
    set {
      playIndex_ = value;
    }
  }

  /// <summary>Field number for the "player_confirmed_card_map" field.</summary>
  public const int PlayerConfirmedCardMapFieldNumber = 9;
  private static readonly pbc::MapField<uint, uint>.Codec _map_playerConfirmedCardMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 74);
  private readonly pbc::MapField<uint, uint> playerConfirmedCardMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> PlayerConfirmedCardMap {
    get { return playerConfirmedCardMap_; }
  }

  /// <summary>Field number for the "wait_begin_time_us" field.</summary>
  public const int WaitBeginTimeUsFieldNumber = 2;
  private ulong waitBeginTimeUs_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong WaitBeginTimeUs {
    get { return waitBeginTimeUs_; }
    set {
      waitBeginTimeUs_ = value;
    }
  }

  /// <summary>Field number for the "wait_seconds" field.</summary>
  public const int WaitSecondsFieldNumber = 5;
  private uint waitSeconds_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WaitSeconds {
    get { return waitSeconds_; }
    set {
      waitSeconds_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InBattleMechanicusCardResultNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InBattleMechanicusCardResultNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GroupId != other.GroupId) return false;
    if(!cardList_.Equals(other.cardList_)) return false;
    if (PlayIndex != other.PlayIndex) return false;
    if (!PlayerConfirmedCardMap.Equals(other.PlayerConfirmedCardMap)) return false;
    if (WaitBeginTimeUs != other.WaitBeginTimeUs) return false;
    if (WaitSeconds != other.WaitSeconds) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (GroupId != 0) hash ^= GroupId.GetHashCode();
    hash ^= cardList_.GetHashCode();
    if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
    hash ^= PlayerConfirmedCardMap.GetHashCode();
    if (WaitBeginTimeUs != 0UL) hash ^= WaitBeginTimeUs.GetHashCode();
    if (WaitSeconds != 0) hash ^= WaitSeconds.GetHashCode();
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
    if (WaitBeginTimeUs != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(WaitBeginTimeUs);
    }
    if (WaitSeconds != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(WaitSeconds);
    }
    cardList_.WriteTo(output, _repeated_cardList_codec);
    playerConfirmedCardMap_.WriteTo(output, _map_playerConfirmedCardMap_codec);
    if (GroupId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(GroupId);
    }
    if (PlayIndex != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(PlayIndex);
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
    if (WaitBeginTimeUs != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(WaitBeginTimeUs);
    }
    if (WaitSeconds != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(WaitSeconds);
    }
    cardList_.WriteTo(ref output, _repeated_cardList_codec);
    playerConfirmedCardMap_.WriteTo(ref output, _map_playerConfirmedCardMap_codec);
    if (GroupId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(GroupId);
    }
    if (PlayIndex != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(PlayIndex);
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
    if (GroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
    }
    size += cardList_.CalculateSize(_repeated_cardList_codec);
    if (PlayIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
    }
    size += playerConfirmedCardMap_.CalculateSize(_map_playerConfirmedCardMap_codec);
    if (WaitBeginTimeUs != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(WaitBeginTimeUs);
    }
    if (WaitSeconds != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaitSeconds);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InBattleMechanicusCardResultNotify other) {
    if (other == null) {
      return;
    }
    if (other.GroupId != 0) {
      GroupId = other.GroupId;
    }
    cardList_.Add(other.cardList_);
    if (other.PlayIndex != 0) {
      PlayIndex = other.PlayIndex;
    }
    playerConfirmedCardMap_.Add(other.playerConfirmedCardMap_);
    if (other.WaitBeginTimeUs != 0UL) {
      WaitBeginTimeUs = other.WaitBeginTimeUs;
    }
    if (other.WaitSeconds != 0) {
      WaitSeconds = other.WaitSeconds;
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
          WaitBeginTimeUs = input.ReadUInt64();
          break;
        }
        case 40: {
          WaitSeconds = input.ReadUInt32();
          break;
        }
        case 66: {
          cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
          break;
        }
        case 74: {
          playerConfirmedCardMap_.AddEntriesFrom(input, _map_playerConfirmedCardMap_codec);
          break;
        }
        case 80: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 112: {
          PlayIndex = input.ReadUInt32();
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
          WaitBeginTimeUs = input.ReadUInt64();
          break;
        }
        case 40: {
          WaitSeconds = input.ReadUInt32();
          break;
        }
        case 66: {
          cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
          break;
        }
        case 74: {
          playerConfirmedCardMap_.AddEntriesFrom(ref input, _map_playerConfirmedCardMap_codec);
          break;
        }
        case 80: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 112: {
          PlayIndex = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
