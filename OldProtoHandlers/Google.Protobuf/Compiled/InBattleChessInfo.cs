// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleChessInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from InBattleChessInfo.proto</summary>
  public static partial class InBattleChessInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleChessInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleChessInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdJbkJhdHRsZUNoZXNzSW5mby5wcm90bxoTQ2hlc3NDYXJkSW5mby5wcm90",
            "bxoWQ2hlc3NNeXN0ZXJ5SW5mby5wcm90bxoVQ2hlc3NQbGF5ZXJJbmZvLnBy",
            "b3RvIoUDChFJbkJhdHRsZUNoZXNzSW5mbxIZChFiYW5fY2FyZF90YWdfbGlz",
            "dBgCIAMoDRINCgVyb3VuZBgEIAEoDRIvChdzZWxlY3RlZF9jYXJkX2luZm9f",
            "bGlzdBgJIAMoCzIOLkNoZXNzQ2FyZEluZm8SJwoMbXlzdGVyeV9pbmZvGAEg",
            "ASgLMhEuQ2hlc3NNeXN0ZXJ5SW5mbxI+Cg9wbGF5ZXJfaW5mb19tYXAYCCAD",
            "KAsyJS5JbkJhdHRsZUNoZXNzSW5mby5QbGF5ZXJJbmZvTWFwRW50cnkSHgoW",
            "bWF4X2VzY2FwYWJsZV9tb25zdGVycxgGIAEoDRIYChBlc2NhcGVkX21vbnN0",
            "ZXJzGAwgASgNEhMKC3RvdGFsX3JvdW5kGA4gASgNEhUKDWxlZnRfbW9uc3Rl",
            "cnMYDyABKA0aRgoSUGxheWVySW5mb01hcEVudHJ5EgsKA2tleRgBIAEoDRIf",
            "CgV2YWx1ZRgCIAEoCzIQLkNoZXNzUGxheWVySW5mbzoCOAFCDKoCCU9sZFBy",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ChessCardInfoReflection.Descriptor, global::OldProtos.ChessMysteryInfoReflection.Descriptor, global::OldProtos.ChessPlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.InBattleChessInfo), global::OldProtos.InBattleChessInfo.Parser, new[]{ "BanCardTagList", "Round", "SelectedCardInfoList", "MysteryInfo", "PlayerInfoMap", "MaxEscapableMonsters", "EscapedMonsters", "TotalRound", "LeftMonsters" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InBattleChessInfo : pb::IMessage<InBattleChessInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleChessInfo> _parser = new pb::MessageParser<InBattleChessInfo>(() => new InBattleChessInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleChessInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.InBattleChessInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleChessInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleChessInfo(InBattleChessInfo other) : this() {
      banCardTagList_ = other.banCardTagList_.Clone();
      round_ = other.round_;
      selectedCardInfoList_ = other.selectedCardInfoList_.Clone();
      mysteryInfo_ = other.mysteryInfo_ != null ? other.mysteryInfo_.Clone() : null;
      playerInfoMap_ = other.playerInfoMap_.Clone();
      maxEscapableMonsters_ = other.maxEscapableMonsters_;
      escapedMonsters_ = other.escapedMonsters_;
      totalRound_ = other.totalRound_;
      leftMonsters_ = other.leftMonsters_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleChessInfo Clone() {
      return new InBattleChessInfo(this);
    }

    /// <summary>Field number for the "ban_card_tag_list" field.</summary>
    public const int BanCardTagListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_banCardTagList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> banCardTagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BanCardTagList {
      get { return banCardTagList_; }
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 4;
    private uint round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    /// <summary>Field number for the "selected_card_info_list" field.</summary>
    public const int SelectedCardInfoListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::OldProtos.ChessCardInfo> _repeated_selectedCardInfoList_codec
        = pb::FieldCodec.ForMessage(74, global::OldProtos.ChessCardInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ChessCardInfo> selectedCardInfoList_ = new pbc::RepeatedField<global::OldProtos.ChessCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ChessCardInfo> SelectedCardInfoList {
      get { return selectedCardInfoList_; }
    }

    /// <summary>Field number for the "mystery_info" field.</summary>
    public const int MysteryInfoFieldNumber = 1;
    private global::OldProtos.ChessMysteryInfo mysteryInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ChessMysteryInfo MysteryInfo {
      get { return mysteryInfo_; }
      set {
        mysteryInfo_ = value;
      }
    }

    /// <summary>Field number for the "player_info_map" field.</summary>
    public const int PlayerInfoMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, global::OldProtos.ChessPlayerInfo>.Codec _map_playerInfoMap_codec
        = new pbc::MapField<uint, global::OldProtos.ChessPlayerInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.ChessPlayerInfo.Parser), 66);
    private readonly pbc::MapField<uint, global::OldProtos.ChessPlayerInfo> playerInfoMap_ = new pbc::MapField<uint, global::OldProtos.ChessPlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.ChessPlayerInfo> PlayerInfoMap {
      get { return playerInfoMap_; }
    }

    /// <summary>Field number for the "max_escapable_monsters" field.</summary>
    public const int MaxEscapableMonstersFieldNumber = 6;
    private uint maxEscapableMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxEscapableMonsters {
      get { return maxEscapableMonsters_; }
      set {
        maxEscapableMonsters_ = value;
      }
    }

    /// <summary>Field number for the "escaped_monsters" field.</summary>
    public const int EscapedMonstersFieldNumber = 12;
    private uint escapedMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EscapedMonsters {
      get { return escapedMonsters_; }
      set {
        escapedMonsters_ = value;
      }
    }

    /// <summary>Field number for the "total_round" field.</summary>
    public const int TotalRoundFieldNumber = 14;
    private uint totalRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalRound {
      get { return totalRound_; }
      set {
        totalRound_ = value;
      }
    }

    /// <summary>Field number for the "left_monsters" field.</summary>
    public const int LeftMonstersFieldNumber = 15;
    private uint leftMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftMonsters {
      get { return leftMonsters_; }
      set {
        leftMonsters_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InBattleChessInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleChessInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!banCardTagList_.Equals(other.banCardTagList_)) return false;
      if (Round != other.Round) return false;
      if(!selectedCardInfoList_.Equals(other.selectedCardInfoList_)) return false;
      if (!object.Equals(MysteryInfo, other.MysteryInfo)) return false;
      if (!PlayerInfoMap.Equals(other.PlayerInfoMap)) return false;
      if (MaxEscapableMonsters != other.MaxEscapableMonsters) return false;
      if (EscapedMonsters != other.EscapedMonsters) return false;
      if (TotalRound != other.TotalRound) return false;
      if (LeftMonsters != other.LeftMonsters) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= banCardTagList_.GetHashCode();
      if (Round != 0) hash ^= Round.GetHashCode();
      hash ^= selectedCardInfoList_.GetHashCode();
      if (mysteryInfo_ != null) hash ^= MysteryInfo.GetHashCode();
      hash ^= PlayerInfoMap.GetHashCode();
      if (MaxEscapableMonsters != 0) hash ^= MaxEscapableMonsters.GetHashCode();
      if (EscapedMonsters != 0) hash ^= EscapedMonsters.GetHashCode();
      if (TotalRound != 0) hash ^= TotalRound.GetHashCode();
      if (LeftMonsters != 0) hash ^= LeftMonsters.GetHashCode();
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
      if (mysteryInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MysteryInfo);
      }
      banCardTagList_.WriteTo(output, _repeated_banCardTagList_codec);
      if (Round != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Round);
      }
      if (MaxEscapableMonsters != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxEscapableMonsters);
      }
      playerInfoMap_.WriteTo(output, _map_playerInfoMap_codec);
      selectedCardInfoList_.WriteTo(output, _repeated_selectedCardInfoList_codec);
      if (EscapedMonsters != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EscapedMonsters);
      }
      if (TotalRound != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalRound);
      }
      if (LeftMonsters != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LeftMonsters);
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
      if (mysteryInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MysteryInfo);
      }
      banCardTagList_.WriteTo(ref output, _repeated_banCardTagList_codec);
      if (Round != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Round);
      }
      if (MaxEscapableMonsters != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaxEscapableMonsters);
      }
      playerInfoMap_.WriteTo(ref output, _map_playerInfoMap_codec);
      selectedCardInfoList_.WriteTo(ref output, _repeated_selectedCardInfoList_codec);
      if (EscapedMonsters != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EscapedMonsters);
      }
      if (TotalRound != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalRound);
      }
      if (LeftMonsters != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LeftMonsters);
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
      size += banCardTagList_.CalculateSize(_repeated_banCardTagList_codec);
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
      }
      size += selectedCardInfoList_.CalculateSize(_repeated_selectedCardInfoList_codec);
      if (mysteryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MysteryInfo);
      }
      size += playerInfoMap_.CalculateSize(_map_playerInfoMap_codec);
      if (MaxEscapableMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxEscapableMonsters);
      }
      if (EscapedMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EscapedMonsters);
      }
      if (TotalRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalRound);
      }
      if (LeftMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftMonsters);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InBattleChessInfo other) {
      if (other == null) {
        return;
      }
      banCardTagList_.Add(other.banCardTagList_);
      if (other.Round != 0) {
        Round = other.Round;
      }
      selectedCardInfoList_.Add(other.selectedCardInfoList_);
      if (other.mysteryInfo_ != null) {
        if (mysteryInfo_ == null) {
          MysteryInfo = new global::OldProtos.ChessMysteryInfo();
        }
        MysteryInfo.MergeFrom(other.MysteryInfo);
      }
      playerInfoMap_.Add(other.playerInfoMap_);
      if (other.MaxEscapableMonsters != 0) {
        MaxEscapableMonsters = other.MaxEscapableMonsters;
      }
      if (other.EscapedMonsters != 0) {
        EscapedMonsters = other.EscapedMonsters;
      }
      if (other.TotalRound != 0) {
        TotalRound = other.TotalRound;
      }
      if (other.LeftMonsters != 0) {
        LeftMonsters = other.LeftMonsters;
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
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::OldProtos.ChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 18:
          case 16: {
            banCardTagList_.AddEntriesFrom(input, _repeated_banCardTagList_codec);
            break;
          }
          case 32: {
            Round = input.ReadUInt32();
            break;
          }
          case 48: {
            MaxEscapableMonsters = input.ReadUInt32();
            break;
          }
          case 66: {
            playerInfoMap_.AddEntriesFrom(input, _map_playerInfoMap_codec);
            break;
          }
          case 74: {
            selectedCardInfoList_.AddEntriesFrom(input, _repeated_selectedCardInfoList_codec);
            break;
          }
          case 96: {
            EscapedMonsters = input.ReadUInt32();
            break;
          }
          case 112: {
            TotalRound = input.ReadUInt32();
            break;
          }
          case 120: {
            LeftMonsters = input.ReadUInt32();
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
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::OldProtos.ChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 18:
          case 16: {
            banCardTagList_.AddEntriesFrom(ref input, _repeated_banCardTagList_codec);
            break;
          }
          case 32: {
            Round = input.ReadUInt32();
            break;
          }
          case 48: {
            MaxEscapableMonsters = input.ReadUInt32();
            break;
          }
          case 66: {
            playerInfoMap_.AddEntriesFrom(ref input, _map_playerInfoMap_codec);
            break;
          }
          case 74: {
            selectedCardInfoList_.AddEntriesFrom(ref input, _repeated_selectedCardInfoList_codec);
            break;
          }
          case 96: {
            EscapedMonsters = input.ReadUInt32();
            break;
          }
          case 112: {
            TotalRound = input.ReadUInt32();
            break;
          }
          case 120: {
            LeftMonsters = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
