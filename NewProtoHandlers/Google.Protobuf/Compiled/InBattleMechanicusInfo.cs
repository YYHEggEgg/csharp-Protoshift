// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from InBattleMechanicusInfo.proto</summary>
public static partial class InBattleMechanicusInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for InBattleMechanicusInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InBattleMechanicusInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxJbkJhdHRsZU1lY2hhbmljdXNJbmZvLnByb3RvGiBJbkJhdHRsZU1lY2hh",
          "bmljdXNDYXJkSW5mby5wcm90bxojSW5CYXR0bGVNZWNoYW5pY3VzTW9uc3Rl",
          "ckluZm8ucHJvdG8aIkluQmF0dGxlTWVjaGFuaWN1c1BsYXllckluZm8ucHJv",
          "dG8aIUluQmF0dGxlTWVjaGFuaWN1c1N0YWdlVHlwZS5wcm90byLZBAoWSW5C",
          "YXR0bGVNZWNoYW5pY3VzSW5mbxIcChNVbmszMzAwX01OTkRFTEtJQkxHGJAF",
          "IAMoDRIcChNVbmszMzAwX0dIQkVIUEdCQklIGKsFIAMoDRIrCgVzdGFnZRgH",
          "IAEoDjIcLkluQmF0dGxlTWVjaGFuaWN1c1N0YWdlVHlwZRIbChNVbmszMzAw",
          "X0VCT0lHRk1PS0hLGAQgASgNEhQKDHdhaXRfc2Vjb25kcxgNIAEoDRIYChBs",
          "ZWZ0X21vbnN0ZXJfbnVtGA8gASgNEhsKE1VuazMzMDBfSUZJUEtMT0dFT0YY",
          "BiABKAQSMgoLcGxheWVyX2xpc3QYDCADKAsyHS5JbkJhdHRsZU1lY2hhbmlj",
          "dXNQbGF5ZXJJbmZvEhMKC3RvdGFsX3JvdW5kGAEgASgNEhsKE1VuazMzMDBf",
          "SUFQSU5PTElBTEYYDiABKAQSNAoMbW9uc3Rlcl9saXN0GAkgAygLMh4uSW5C",
          "YXR0bGVNZWNoYW5pY3VzTW9uc3RlckluZm8SGwoTVW5rMzMwMF9DSUpBTENB",
          "TUhDRBgDIAEoDRIaChJ3YWl0X2JlZ2luX3RpbWVfdXMYAiABKAQSNgoRaGlz",
          "dG9yeV9jYXJkX2xpc3QYBSADKAsyGy5JbkJhdHRsZU1lY2hhbmljdXNDYXJk",
          "SW5mbxIzCg5waWNrX2NhcmRfbGlzdBgIIAMoCzIbLkluQmF0dGxlTWVjaGFu",
          "aWN1c0NhcmRJbmZvEhsKE2VzY2FwZWRfbW9uc3Rlcl9udW0YCiABKA0SDQoF",
          "cm91bmQYCyABKA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::InBattleMechanicusCardInfoReflection.Descriptor, global::InBattleMechanicusMonsterInfoReflection.Descriptor, global::InBattleMechanicusPlayerInfoReflection.Descriptor, global::InBattleMechanicusStageTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InBattleMechanicusInfo), global::InBattleMechanicusInfo.Parser, new[]{ "Unk3300MNNDELKIBLG", "Unk3300GHBEHPGBBIH", "Stage", "Unk3300EBOIGFMOKHK", "WaitSeconds", "LeftMonsterNum", "Unk3300IFIPKLOGEOF", "PlayerList", "TotalRound", "Unk3300IAPINOLIALF", "MonsterList", "Unk3300CIJALCAMHCD", "WaitBeginTimeUs", "HistoryCardList", "PickCardList", "EscapedMonsterNum", "Round" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class InBattleMechanicusInfo : pb::IMessage<InBattleMechanicusInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InBattleMechanicusInfo> _parser = new pb::MessageParser<InBattleMechanicusInfo>(() => new InBattleMechanicusInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InBattleMechanicusInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InBattleMechanicusInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusInfo(InBattleMechanicusInfo other) : this() {
    unk3300MNNDELKIBLG_ = other.unk3300MNNDELKIBLG_.Clone();
    unk3300GHBEHPGBBIH_ = other.unk3300GHBEHPGBBIH_.Clone();
    stage_ = other.stage_;
    unk3300EBOIGFMOKHK_ = other.unk3300EBOIGFMOKHK_;
    waitSeconds_ = other.waitSeconds_;
    leftMonsterNum_ = other.leftMonsterNum_;
    unk3300IFIPKLOGEOF_ = other.unk3300IFIPKLOGEOF_;
    playerList_ = other.playerList_.Clone();
    totalRound_ = other.totalRound_;
    unk3300IAPINOLIALF_ = other.unk3300IAPINOLIALF_;
    monsterList_ = other.monsterList_.Clone();
    unk3300CIJALCAMHCD_ = other.unk3300CIJALCAMHCD_;
    waitBeginTimeUs_ = other.waitBeginTimeUs_;
    historyCardList_ = other.historyCardList_.Clone();
    pickCardList_ = other.pickCardList_.Clone();
    escapedMonsterNum_ = other.escapedMonsterNum_;
    round_ = other.round_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusInfo Clone() {
    return new InBattleMechanicusInfo(this);
  }

  /// <summary>Field number for the "Unk3300_MNNDELKIBLG" field.</summary>
  public const int Unk3300MNNDELKIBLGFieldNumber = 656;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300MNNDELKIBLG_codec
      = pb::FieldCodec.ForUInt32(5250);
  private readonly pbc::RepeatedField<uint> unk3300MNNDELKIBLG_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300MNNDELKIBLG {
    get { return unk3300MNNDELKIBLG_; }
  }

  /// <summary>Field number for the "Unk3300_GHBEHPGBBIH" field.</summary>
  public const int Unk3300GHBEHPGBBIHFieldNumber = 683;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300GHBEHPGBBIH_codec
      = pb::FieldCodec.ForUInt32(5466);
  private readonly pbc::RepeatedField<uint> unk3300GHBEHPGBBIH_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300GHBEHPGBBIH {
    get { return unk3300GHBEHPGBBIH_; }
  }

  /// <summary>Field number for the "stage" field.</summary>
  public const int StageFieldNumber = 7;
  private global::InBattleMechanicusStageType stage_ = global::InBattleMechanicusStageType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::InBattleMechanicusStageType Stage {
    get { return stage_; }
    set {
      stage_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_EBOIGFMOKHK" field.</summary>
  public const int Unk3300EBOIGFMOKHKFieldNumber = 4;
  private uint unk3300EBOIGFMOKHK_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300EBOIGFMOKHK {
    get { return unk3300EBOIGFMOKHK_; }
    set {
      unk3300EBOIGFMOKHK_ = value;
    }
  }

  /// <summary>Field number for the "wait_seconds" field.</summary>
  public const int WaitSecondsFieldNumber = 13;
  private uint waitSeconds_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WaitSeconds {
    get { return waitSeconds_; }
    set {
      waitSeconds_ = value;
    }
  }

  /// <summary>Field number for the "left_monster_num" field.</summary>
  public const int LeftMonsterNumFieldNumber = 15;
  private uint leftMonsterNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LeftMonsterNum {
    get { return leftMonsterNum_; }
    set {
      leftMonsterNum_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_IFIPKLOGEOF" field.</summary>
  public const int Unk3300IFIPKLOGEOFFieldNumber = 6;
  private ulong unk3300IFIPKLOGEOF_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong Unk3300IFIPKLOGEOF {
    get { return unk3300IFIPKLOGEOF_; }
    set {
      unk3300IFIPKLOGEOF_ = value;
    }
  }

  /// <summary>Field number for the "player_list" field.</summary>
  public const int PlayerListFieldNumber = 12;
  private static readonly pb::FieldCodec<global::InBattleMechanicusPlayerInfo> _repeated_playerList_codec
      = pb::FieldCodec.ForMessage(98, global::InBattleMechanicusPlayerInfo.Parser);
  private readonly pbc::RepeatedField<global::InBattleMechanicusPlayerInfo> playerList_ = new pbc::RepeatedField<global::InBattleMechanicusPlayerInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InBattleMechanicusPlayerInfo> PlayerList {
    get { return playerList_; }
  }

  /// <summary>Field number for the "total_round" field.</summary>
  public const int TotalRoundFieldNumber = 1;
  private uint totalRound_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalRound {
    get { return totalRound_; }
    set {
      totalRound_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_IAPINOLIALF" field.</summary>
  public const int Unk3300IAPINOLIALFFieldNumber = 14;
  private ulong unk3300IAPINOLIALF_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong Unk3300IAPINOLIALF {
    get { return unk3300IAPINOLIALF_; }
    set {
      unk3300IAPINOLIALF_ = value;
    }
  }

  /// <summary>Field number for the "monster_list" field.</summary>
  public const int MonsterListFieldNumber = 9;
  private static readonly pb::FieldCodec<global::InBattleMechanicusMonsterInfo> _repeated_monsterList_codec
      = pb::FieldCodec.ForMessage(74, global::InBattleMechanicusMonsterInfo.Parser);
  private readonly pbc::RepeatedField<global::InBattleMechanicusMonsterInfo> monsterList_ = new pbc::RepeatedField<global::InBattleMechanicusMonsterInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InBattleMechanicusMonsterInfo> MonsterList {
    get { return monsterList_; }
  }

  /// <summary>Field number for the "Unk3300_CIJALCAMHCD" field.</summary>
  public const int Unk3300CIJALCAMHCDFieldNumber = 3;
  private uint unk3300CIJALCAMHCD_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300CIJALCAMHCD {
    get { return unk3300CIJALCAMHCD_; }
    set {
      unk3300CIJALCAMHCD_ = value;
    }
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

  /// <summary>Field number for the "history_card_list" field.</summary>
  public const int HistoryCardListFieldNumber = 5;
  private static readonly pb::FieldCodec<global::InBattleMechanicusCardInfo> _repeated_historyCardList_codec
      = pb::FieldCodec.ForMessage(42, global::InBattleMechanicusCardInfo.Parser);
  private readonly pbc::RepeatedField<global::InBattleMechanicusCardInfo> historyCardList_ = new pbc::RepeatedField<global::InBattleMechanicusCardInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InBattleMechanicusCardInfo> HistoryCardList {
    get { return historyCardList_; }
  }

  /// <summary>Field number for the "pick_card_list" field.</summary>
  public const int PickCardListFieldNumber = 8;
  private static readonly pb::FieldCodec<global::InBattleMechanicusCardInfo> _repeated_pickCardList_codec
      = pb::FieldCodec.ForMessage(66, global::InBattleMechanicusCardInfo.Parser);
  private readonly pbc::RepeatedField<global::InBattleMechanicusCardInfo> pickCardList_ = new pbc::RepeatedField<global::InBattleMechanicusCardInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InBattleMechanicusCardInfo> PickCardList {
    get { return pickCardList_; }
  }

  /// <summary>Field number for the "escaped_monster_num" field.</summary>
  public const int EscapedMonsterNumFieldNumber = 10;
  private uint escapedMonsterNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EscapedMonsterNum {
    get { return escapedMonsterNum_; }
    set {
      escapedMonsterNum_ = value;
    }
  }

  /// <summary>Field number for the "round" field.</summary>
  public const int RoundFieldNumber = 11;
  private uint round_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Round {
    get { return round_; }
    set {
      round_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InBattleMechanicusInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InBattleMechanicusInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!unk3300MNNDELKIBLG_.Equals(other.unk3300MNNDELKIBLG_)) return false;
    if(!unk3300GHBEHPGBBIH_.Equals(other.unk3300GHBEHPGBBIH_)) return false;
    if (Stage != other.Stage) return false;
    if (Unk3300EBOIGFMOKHK != other.Unk3300EBOIGFMOKHK) return false;
    if (WaitSeconds != other.WaitSeconds) return false;
    if (LeftMonsterNum != other.LeftMonsterNum) return false;
    if (Unk3300IFIPKLOGEOF != other.Unk3300IFIPKLOGEOF) return false;
    if(!playerList_.Equals(other.playerList_)) return false;
    if (TotalRound != other.TotalRound) return false;
    if (Unk3300IAPINOLIALF != other.Unk3300IAPINOLIALF) return false;
    if(!monsterList_.Equals(other.monsterList_)) return false;
    if (Unk3300CIJALCAMHCD != other.Unk3300CIJALCAMHCD) return false;
    if (WaitBeginTimeUs != other.WaitBeginTimeUs) return false;
    if(!historyCardList_.Equals(other.historyCardList_)) return false;
    if(!pickCardList_.Equals(other.pickCardList_)) return false;
    if (EscapedMonsterNum != other.EscapedMonsterNum) return false;
    if (Round != other.Round) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= unk3300MNNDELKIBLG_.GetHashCode();
    hash ^= unk3300GHBEHPGBBIH_.GetHashCode();
    if (Stage != global::InBattleMechanicusStageType.None) hash ^= Stage.GetHashCode();
    if (Unk3300EBOIGFMOKHK != 0) hash ^= Unk3300EBOIGFMOKHK.GetHashCode();
    if (WaitSeconds != 0) hash ^= WaitSeconds.GetHashCode();
    if (LeftMonsterNum != 0) hash ^= LeftMonsterNum.GetHashCode();
    if (Unk3300IFIPKLOGEOF != 0UL) hash ^= Unk3300IFIPKLOGEOF.GetHashCode();
    hash ^= playerList_.GetHashCode();
    if (TotalRound != 0) hash ^= TotalRound.GetHashCode();
    if (Unk3300IAPINOLIALF != 0UL) hash ^= Unk3300IAPINOLIALF.GetHashCode();
    hash ^= monsterList_.GetHashCode();
    if (Unk3300CIJALCAMHCD != 0) hash ^= Unk3300CIJALCAMHCD.GetHashCode();
    if (WaitBeginTimeUs != 0UL) hash ^= WaitBeginTimeUs.GetHashCode();
    hash ^= historyCardList_.GetHashCode();
    hash ^= pickCardList_.GetHashCode();
    if (EscapedMonsterNum != 0) hash ^= EscapedMonsterNum.GetHashCode();
    if (Round != 0) hash ^= Round.GetHashCode();
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
    if (TotalRound != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(TotalRound);
    }
    if (WaitBeginTimeUs != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(WaitBeginTimeUs);
    }
    if (Unk3300CIJALCAMHCD != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Unk3300CIJALCAMHCD);
    }
    if (Unk3300EBOIGFMOKHK != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Unk3300EBOIGFMOKHK);
    }
    historyCardList_.WriteTo(output, _repeated_historyCardList_codec);
    if (Unk3300IFIPKLOGEOF != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(Unk3300IFIPKLOGEOF);
    }
    if (Stage != global::InBattleMechanicusStageType.None) {
      output.WriteRawTag(56);
      output.WriteEnum((int) Stage);
    }
    pickCardList_.WriteTo(output, _repeated_pickCardList_codec);
    monsterList_.WriteTo(output, _repeated_monsterList_codec);
    if (EscapedMonsterNum != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(EscapedMonsterNum);
    }
    if (Round != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Round);
    }
    playerList_.WriteTo(output, _repeated_playerList_codec);
    if (WaitSeconds != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(WaitSeconds);
    }
    if (Unk3300IAPINOLIALF != 0UL) {
      output.WriteRawTag(112);
      output.WriteUInt64(Unk3300IAPINOLIALF);
    }
    if (LeftMonsterNum != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(LeftMonsterNum);
    }
    unk3300MNNDELKIBLG_.WriteTo(output, _repeated_unk3300MNNDELKIBLG_codec);
    unk3300GHBEHPGBBIH_.WriteTo(output, _repeated_unk3300GHBEHPGBBIH_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (TotalRound != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(TotalRound);
    }
    if (WaitBeginTimeUs != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(WaitBeginTimeUs);
    }
    if (Unk3300CIJALCAMHCD != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Unk3300CIJALCAMHCD);
    }
    if (Unk3300EBOIGFMOKHK != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Unk3300EBOIGFMOKHK);
    }
    historyCardList_.WriteTo(ref output, _repeated_historyCardList_codec);
    if (Unk3300IFIPKLOGEOF != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(Unk3300IFIPKLOGEOF);
    }
    if (Stage != global::InBattleMechanicusStageType.None) {
      output.WriteRawTag(56);
      output.WriteEnum((int) Stage);
    }
    pickCardList_.WriteTo(ref output, _repeated_pickCardList_codec);
    monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
    if (EscapedMonsterNum != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(EscapedMonsterNum);
    }
    if (Round != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Round);
    }
    playerList_.WriteTo(ref output, _repeated_playerList_codec);
    if (WaitSeconds != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(WaitSeconds);
    }
    if (Unk3300IAPINOLIALF != 0UL) {
      output.WriteRawTag(112);
      output.WriteUInt64(Unk3300IAPINOLIALF);
    }
    if (LeftMonsterNum != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(LeftMonsterNum);
    }
    unk3300MNNDELKIBLG_.WriteTo(ref output, _repeated_unk3300MNNDELKIBLG_codec);
    unk3300GHBEHPGBBIH_.WriteTo(ref output, _repeated_unk3300GHBEHPGBBIH_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += unk3300MNNDELKIBLG_.CalculateSize(_repeated_unk3300MNNDELKIBLG_codec);
    size += unk3300GHBEHPGBBIH_.CalculateSize(_repeated_unk3300GHBEHPGBBIH_codec);
    if (Stage != global::InBattleMechanicusStageType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Stage);
    }
    if (Unk3300EBOIGFMOKHK != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EBOIGFMOKHK);
    }
    if (WaitSeconds != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaitSeconds);
    }
    if (LeftMonsterNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftMonsterNum);
    }
    if (Unk3300IFIPKLOGEOF != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk3300IFIPKLOGEOF);
    }
    size += playerList_.CalculateSize(_repeated_playerList_codec);
    if (TotalRound != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalRound);
    }
    if (Unk3300IAPINOLIALF != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk3300IAPINOLIALF);
    }
    size += monsterList_.CalculateSize(_repeated_monsterList_codec);
    if (Unk3300CIJALCAMHCD != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300CIJALCAMHCD);
    }
    if (WaitBeginTimeUs != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(WaitBeginTimeUs);
    }
    size += historyCardList_.CalculateSize(_repeated_historyCardList_codec);
    size += pickCardList_.CalculateSize(_repeated_pickCardList_codec);
    if (EscapedMonsterNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EscapedMonsterNum);
    }
    if (Round != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InBattleMechanicusInfo other) {
    if (other == null) {
      return;
    }
    unk3300MNNDELKIBLG_.Add(other.unk3300MNNDELKIBLG_);
    unk3300GHBEHPGBBIH_.Add(other.unk3300GHBEHPGBBIH_);
    if (other.Stage != global::InBattleMechanicusStageType.None) {
      Stage = other.Stage;
    }
    if (other.Unk3300EBOIGFMOKHK != 0) {
      Unk3300EBOIGFMOKHK = other.Unk3300EBOIGFMOKHK;
    }
    if (other.WaitSeconds != 0) {
      WaitSeconds = other.WaitSeconds;
    }
    if (other.LeftMonsterNum != 0) {
      LeftMonsterNum = other.LeftMonsterNum;
    }
    if (other.Unk3300IFIPKLOGEOF != 0UL) {
      Unk3300IFIPKLOGEOF = other.Unk3300IFIPKLOGEOF;
    }
    playerList_.Add(other.playerList_);
    if (other.TotalRound != 0) {
      TotalRound = other.TotalRound;
    }
    if (other.Unk3300IAPINOLIALF != 0UL) {
      Unk3300IAPINOLIALF = other.Unk3300IAPINOLIALF;
    }
    monsterList_.Add(other.monsterList_);
    if (other.Unk3300CIJALCAMHCD != 0) {
      Unk3300CIJALCAMHCD = other.Unk3300CIJALCAMHCD;
    }
    if (other.WaitBeginTimeUs != 0UL) {
      WaitBeginTimeUs = other.WaitBeginTimeUs;
    }
    historyCardList_.Add(other.historyCardList_);
    pickCardList_.Add(other.pickCardList_);
    if (other.EscapedMonsterNum != 0) {
      EscapedMonsterNum = other.EscapedMonsterNum;
    }
    if (other.Round != 0) {
      Round = other.Round;
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
          TotalRound = input.ReadUInt32();
          break;
        }
        case 16: {
          WaitBeginTimeUs = input.ReadUInt64();
          break;
        }
        case 24: {
          Unk3300CIJALCAMHCD = input.ReadUInt32();
          break;
        }
        case 32: {
          Unk3300EBOIGFMOKHK = input.ReadUInt32();
          break;
        }
        case 42: {
          historyCardList_.AddEntriesFrom(input, _repeated_historyCardList_codec);
          break;
        }
        case 48: {
          Unk3300IFIPKLOGEOF = input.ReadUInt64();
          break;
        }
        case 56: {
          Stage = (global::InBattleMechanicusStageType) input.ReadEnum();
          break;
        }
        case 66: {
          pickCardList_.AddEntriesFrom(input, _repeated_pickCardList_codec);
          break;
        }
        case 74: {
          monsterList_.AddEntriesFrom(input, _repeated_monsterList_codec);
          break;
        }
        case 80: {
          EscapedMonsterNum = input.ReadUInt32();
          break;
        }
        case 88: {
          Round = input.ReadUInt32();
          break;
        }
        case 98: {
          playerList_.AddEntriesFrom(input, _repeated_playerList_codec);
          break;
        }
        case 104: {
          WaitSeconds = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300IAPINOLIALF = input.ReadUInt64();
          break;
        }
        case 120: {
          LeftMonsterNum = input.ReadUInt32();
          break;
        }
        case 5250:
        case 5248: {
          unk3300MNNDELKIBLG_.AddEntriesFrom(input, _repeated_unk3300MNNDELKIBLG_codec);
          break;
        }
        case 5466:
        case 5464: {
          unk3300GHBEHPGBBIH_.AddEntriesFrom(input, _repeated_unk3300GHBEHPGBBIH_codec);
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
          TotalRound = input.ReadUInt32();
          break;
        }
        case 16: {
          WaitBeginTimeUs = input.ReadUInt64();
          break;
        }
        case 24: {
          Unk3300CIJALCAMHCD = input.ReadUInt32();
          break;
        }
        case 32: {
          Unk3300EBOIGFMOKHK = input.ReadUInt32();
          break;
        }
        case 42: {
          historyCardList_.AddEntriesFrom(ref input, _repeated_historyCardList_codec);
          break;
        }
        case 48: {
          Unk3300IFIPKLOGEOF = input.ReadUInt64();
          break;
        }
        case 56: {
          Stage = (global::InBattleMechanicusStageType) input.ReadEnum();
          break;
        }
        case 66: {
          pickCardList_.AddEntriesFrom(ref input, _repeated_pickCardList_codec);
          break;
        }
        case 74: {
          monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
          break;
        }
        case 80: {
          EscapedMonsterNum = input.ReadUInt32();
          break;
        }
        case 88: {
          Round = input.ReadUInt32();
          break;
        }
        case 98: {
          playerList_.AddEntriesFrom(ref input, _repeated_playerList_codec);
          break;
        }
        case 104: {
          WaitSeconds = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300IAPINOLIALF = input.ReadUInt64();
          break;
        }
        case 120: {
          LeftMonsterNum = input.ReadUInt32();
          break;
        }
        case 5250:
        case 5248: {
          unk3300MNNDELKIBLG_.AddEntriesFrom(ref input, _repeated_unk3300MNNDELKIBLG_codec);
          break;
        }
        case 5466:
        case 5464: {
          unk3300GHBEHPGBBIH_.AddEntriesFrom(ref input, _repeated_unk3300GHBEHPGBBIH_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
