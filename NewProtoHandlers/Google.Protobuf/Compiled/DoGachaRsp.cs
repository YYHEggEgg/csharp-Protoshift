// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DoGachaRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from DoGachaRsp.proto</summary>
public static partial class DoGachaRspReflection {

  #region Descriptor
  /// <summary>File descriptor for DoGachaRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DoGachaRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBEb0dhY2hhUnNwLnByb3RvGg9HYWNoYUl0ZW0ucHJvdG8igAQKCkRvR2Fj",
          "aGFSc3ASHAoTVW5rMzMwMF9PSEZNSElISkhQShiUDiABKAgSGAoQbGVmdF9n",
          "YWNoYV90aW1lcxgDIAEoDRIjCg9nYWNoYV9pdGVtX2xpc3QYCSADKAsyCi5H",
          "YWNoYUl0ZW0SHAoTVW5rMzMwMF9IQklMSUFFSUhOSxjfDiABKAgSEgoKZ2Fj",
          "aGFfdHlwZRgKIAEoDRIYChBuZXdfZ2FjaGFfcmFuZG9tGAYgASgNEhUKDXdp",
          "c2hfcHJvZ3Jlc3MYASABKA0SGQoRd2lzaF9tYXhfcHJvZ3Jlc3MYBSABKA0S",
          "EwoLZ2FjaGFfdGltZXMYBCABKA0SGQoRZ2FjaGFfdGltZXNfbGltaXQYDyAB",
          "KA0SFAoMd2lzaF9pdGVtX2lkGAwgASgNEhgKEHRlbl9jb3N0X2l0ZW1faWQY",
          "DSABKA0SFQoNY29zdF9pdGVtX251bRgIIAEoDRIZChF0ZW5fY29zdF9pdGVt",
          "X251bRgCIAEoDRInCh5jdXJfc2NoZWR1bGVfZGFpbHlfZ2FjaGFfdGltZXMY",
          "jgwgASgNEhQKDGNvc3RfaXRlbV9pZBgHIAEoDRIZChFnYWNoYV9zY2hlZHVs",
          "ZV9pZBgOIAEoDRIaChFkYWlseV9nYWNoYV90aW1lcxjTAyABKA0SDwoHcmV0",
          "Y29kZRgLIAEoBUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GachaItemReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DoGachaRsp), global::DoGachaRsp.Parser, new[]{ "Unk3300OHFMHIHJHPJ", "LeftGachaTimes", "GachaItemList", "Unk3300HBILIAEIHNK", "GachaType", "NewGachaRandom", "WishProgress", "WishMaxProgress", "GachaTimes", "GachaTimesLimit", "WishItemId", "TenCostItemId", "CostItemNum", "TenCostItemNum", "CurScheduleDailyGachaTimes", "CostItemId", "GachaScheduleId", "DailyGachaTimes", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 1519;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class DoGachaRsp : pb::IMessage<DoGachaRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<DoGachaRsp> _parser = new pb::MessageParser<DoGachaRsp>(() => new DoGachaRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<DoGachaRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DoGachaRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DoGachaRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DoGachaRsp(DoGachaRsp other) : this() {
    unk3300OHFMHIHJHPJ_ = other.unk3300OHFMHIHJHPJ_;
    leftGachaTimes_ = other.leftGachaTimes_;
    gachaItemList_ = other.gachaItemList_.Clone();
    unk3300HBILIAEIHNK_ = other.unk3300HBILIAEIHNK_;
    gachaType_ = other.gachaType_;
    newGachaRandom_ = other.newGachaRandom_;
    wishProgress_ = other.wishProgress_;
    wishMaxProgress_ = other.wishMaxProgress_;
    gachaTimes_ = other.gachaTimes_;
    gachaTimesLimit_ = other.gachaTimesLimit_;
    wishItemId_ = other.wishItemId_;
    tenCostItemId_ = other.tenCostItemId_;
    costItemNum_ = other.costItemNum_;
    tenCostItemNum_ = other.tenCostItemNum_;
    curScheduleDailyGachaTimes_ = other.curScheduleDailyGachaTimes_;
    costItemId_ = other.costItemId_;
    gachaScheduleId_ = other.gachaScheduleId_;
    dailyGachaTimes_ = other.dailyGachaTimes_;
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DoGachaRsp Clone() {
    return new DoGachaRsp(this);
  }

  /// <summary>Field number for the "Unk3300_OHFMHIHJHPJ" field.</summary>
  public const int Unk3300OHFMHIHJHPJFieldNumber = 1812;
  private bool unk3300OHFMHIHJHPJ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300OHFMHIHJHPJ {
    get { return unk3300OHFMHIHJHPJ_; }
    set {
      unk3300OHFMHIHJHPJ_ = value;
    }
  }

  /// <summary>Field number for the "left_gacha_times" field.</summary>
  public const int LeftGachaTimesFieldNumber = 3;
  private uint leftGachaTimes_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LeftGachaTimes {
    get { return leftGachaTimes_; }
    set {
      leftGachaTimes_ = value;
    }
  }

  /// <summary>Field number for the "gacha_item_list" field.</summary>
  public const int GachaItemListFieldNumber = 9;
  private static readonly pb::FieldCodec<global::GachaItem> _repeated_gachaItemList_codec
      = pb::FieldCodec.ForMessage(74, global::GachaItem.Parser);
  private readonly pbc::RepeatedField<global::GachaItem> gachaItemList_ = new pbc::RepeatedField<global::GachaItem>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GachaItem> GachaItemList {
    get { return gachaItemList_; }
  }

  /// <summary>Field number for the "Unk3300_HBILIAEIHNK" field.</summary>
  public const int Unk3300HBILIAEIHNKFieldNumber = 1887;
  private bool unk3300HBILIAEIHNK_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300HBILIAEIHNK {
    get { return unk3300HBILIAEIHNK_; }
    set {
      unk3300HBILIAEIHNK_ = value;
    }
  }

  /// <summary>Field number for the "gacha_type" field.</summary>
  public const int GachaTypeFieldNumber = 10;
  private uint gachaType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GachaType {
    get { return gachaType_; }
    set {
      gachaType_ = value;
    }
  }

  /// <summary>Field number for the "new_gacha_random" field.</summary>
  public const int NewGachaRandomFieldNumber = 6;
  private uint newGachaRandom_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint NewGachaRandom {
    get { return newGachaRandom_; }
    set {
      newGachaRandom_ = value;
    }
  }

  /// <summary>Field number for the "wish_progress" field.</summary>
  public const int WishProgressFieldNumber = 1;
  private uint wishProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WishProgress {
    get { return wishProgress_; }
    set {
      wishProgress_ = value;
    }
  }

  /// <summary>Field number for the "wish_max_progress" field.</summary>
  public const int WishMaxProgressFieldNumber = 5;
  private uint wishMaxProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WishMaxProgress {
    get { return wishMaxProgress_; }
    set {
      wishMaxProgress_ = value;
    }
  }

  /// <summary>Field number for the "gacha_times" field.</summary>
  public const int GachaTimesFieldNumber = 4;
  private uint gachaTimes_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GachaTimes {
    get { return gachaTimes_; }
    set {
      gachaTimes_ = value;
    }
  }

  /// <summary>Field number for the "gacha_times_limit" field.</summary>
  public const int GachaTimesLimitFieldNumber = 15;
  private uint gachaTimesLimit_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GachaTimesLimit {
    get { return gachaTimesLimit_; }
    set {
      gachaTimesLimit_ = value;
    }
  }

  /// <summary>Field number for the "wish_item_id" field.</summary>
  public const int WishItemIdFieldNumber = 12;
  private uint wishItemId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WishItemId {
    get { return wishItemId_; }
    set {
      wishItemId_ = value;
    }
  }

  /// <summary>Field number for the "ten_cost_item_id" field.</summary>
  public const int TenCostItemIdFieldNumber = 13;
  private uint tenCostItemId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TenCostItemId {
    get { return tenCostItemId_; }
    set {
      tenCostItemId_ = value;
    }
  }

  /// <summary>Field number for the "cost_item_num" field.</summary>
  public const int CostItemNumFieldNumber = 8;
  private uint costItemNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CostItemNum {
    get { return costItemNum_; }
    set {
      costItemNum_ = value;
    }
  }

  /// <summary>Field number for the "ten_cost_item_num" field.</summary>
  public const int TenCostItemNumFieldNumber = 2;
  private uint tenCostItemNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TenCostItemNum {
    get { return tenCostItemNum_; }
    set {
      tenCostItemNum_ = value;
    }
  }

  /// <summary>Field number for the "cur_schedule_daily_gacha_times" field.</summary>
  public const int CurScheduleDailyGachaTimesFieldNumber = 1550;
  private uint curScheduleDailyGachaTimes_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurScheduleDailyGachaTimes {
    get { return curScheduleDailyGachaTimes_; }
    set {
      curScheduleDailyGachaTimes_ = value;
    }
  }

  /// <summary>Field number for the "cost_item_id" field.</summary>
  public const int CostItemIdFieldNumber = 7;
  private uint costItemId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CostItemId {
    get { return costItemId_; }
    set {
      costItemId_ = value;
    }
  }

  /// <summary>Field number for the "gacha_schedule_id" field.</summary>
  public const int GachaScheduleIdFieldNumber = 14;
  private uint gachaScheduleId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GachaScheduleId {
    get { return gachaScheduleId_; }
    set {
      gachaScheduleId_ = value;
    }
  }

  /// <summary>Field number for the "daily_gacha_times" field.</summary>
  public const int DailyGachaTimesFieldNumber = 467;
  private uint dailyGachaTimes_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DailyGachaTimes {
    get { return dailyGachaTimes_; }
    set {
      dailyGachaTimes_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 11;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as DoGachaRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(DoGachaRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Unk3300OHFMHIHJHPJ != other.Unk3300OHFMHIHJHPJ) return false;
    if (LeftGachaTimes != other.LeftGachaTimes) return false;
    if(!gachaItemList_.Equals(other.gachaItemList_)) return false;
    if (Unk3300HBILIAEIHNK != other.Unk3300HBILIAEIHNK) return false;
    if (GachaType != other.GachaType) return false;
    if (NewGachaRandom != other.NewGachaRandom) return false;
    if (WishProgress != other.WishProgress) return false;
    if (WishMaxProgress != other.WishMaxProgress) return false;
    if (GachaTimes != other.GachaTimes) return false;
    if (GachaTimesLimit != other.GachaTimesLimit) return false;
    if (WishItemId != other.WishItemId) return false;
    if (TenCostItemId != other.TenCostItemId) return false;
    if (CostItemNum != other.CostItemNum) return false;
    if (TenCostItemNum != other.TenCostItemNum) return false;
    if (CurScheduleDailyGachaTimes != other.CurScheduleDailyGachaTimes) return false;
    if (CostItemId != other.CostItemId) return false;
    if (GachaScheduleId != other.GachaScheduleId) return false;
    if (DailyGachaTimes != other.DailyGachaTimes) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Unk3300OHFMHIHJHPJ != false) hash ^= Unk3300OHFMHIHJHPJ.GetHashCode();
    if (LeftGachaTimes != 0) hash ^= LeftGachaTimes.GetHashCode();
    hash ^= gachaItemList_.GetHashCode();
    if (Unk3300HBILIAEIHNK != false) hash ^= Unk3300HBILIAEIHNK.GetHashCode();
    if (GachaType != 0) hash ^= GachaType.GetHashCode();
    if (NewGachaRandom != 0) hash ^= NewGachaRandom.GetHashCode();
    if (WishProgress != 0) hash ^= WishProgress.GetHashCode();
    if (WishMaxProgress != 0) hash ^= WishMaxProgress.GetHashCode();
    if (GachaTimes != 0) hash ^= GachaTimes.GetHashCode();
    if (GachaTimesLimit != 0) hash ^= GachaTimesLimit.GetHashCode();
    if (WishItemId != 0) hash ^= WishItemId.GetHashCode();
    if (TenCostItemId != 0) hash ^= TenCostItemId.GetHashCode();
    if (CostItemNum != 0) hash ^= CostItemNum.GetHashCode();
    if (TenCostItemNum != 0) hash ^= TenCostItemNum.GetHashCode();
    if (CurScheduleDailyGachaTimes != 0) hash ^= CurScheduleDailyGachaTimes.GetHashCode();
    if (CostItemId != 0) hash ^= CostItemId.GetHashCode();
    if (GachaScheduleId != 0) hash ^= GachaScheduleId.GetHashCode();
    if (DailyGachaTimes != 0) hash ^= DailyGachaTimes.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (WishProgress != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(WishProgress);
    }
    if (TenCostItemNum != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(TenCostItemNum);
    }
    if (LeftGachaTimes != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(LeftGachaTimes);
    }
    if (GachaTimes != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(GachaTimes);
    }
    if (WishMaxProgress != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(WishMaxProgress);
    }
    if (NewGachaRandom != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(NewGachaRandom);
    }
    if (CostItemId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CostItemId);
    }
    if (CostItemNum != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CostItemNum);
    }
    gachaItemList_.WriteTo(output, _repeated_gachaItemList_codec);
    if (GachaType != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(GachaType);
    }
    if (Retcode != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(Retcode);
    }
    if (WishItemId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(WishItemId);
    }
    if (TenCostItemId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(TenCostItemId);
    }
    if (GachaScheduleId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(GachaScheduleId);
    }
    if (GachaTimesLimit != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(GachaTimesLimit);
    }
    if (DailyGachaTimes != 0) {
      output.WriteRawTag(152, 29);
      output.WriteUInt32(DailyGachaTimes);
    }
    if (CurScheduleDailyGachaTimes != 0) {
      output.WriteRawTag(240, 96);
      output.WriteUInt32(CurScheduleDailyGachaTimes);
    }
    if (Unk3300OHFMHIHJHPJ != false) {
      output.WriteRawTag(160, 113);
      output.WriteBool(Unk3300OHFMHIHJHPJ);
    }
    if (Unk3300HBILIAEIHNK != false) {
      output.WriteRawTag(248, 117);
      output.WriteBool(Unk3300HBILIAEIHNK);
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
    if (WishProgress != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(WishProgress);
    }
    if (TenCostItemNum != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(TenCostItemNum);
    }
    if (LeftGachaTimes != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(LeftGachaTimes);
    }
    if (GachaTimes != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(GachaTimes);
    }
    if (WishMaxProgress != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(WishMaxProgress);
    }
    if (NewGachaRandom != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(NewGachaRandom);
    }
    if (CostItemId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CostItemId);
    }
    if (CostItemNum != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CostItemNum);
    }
    gachaItemList_.WriteTo(ref output, _repeated_gachaItemList_codec);
    if (GachaType != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(GachaType);
    }
    if (Retcode != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(Retcode);
    }
    if (WishItemId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(WishItemId);
    }
    if (TenCostItemId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(TenCostItemId);
    }
    if (GachaScheduleId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(GachaScheduleId);
    }
    if (GachaTimesLimit != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(GachaTimesLimit);
    }
    if (DailyGachaTimes != 0) {
      output.WriteRawTag(152, 29);
      output.WriteUInt32(DailyGachaTimes);
    }
    if (CurScheduleDailyGachaTimes != 0) {
      output.WriteRawTag(240, 96);
      output.WriteUInt32(CurScheduleDailyGachaTimes);
    }
    if (Unk3300OHFMHIHJHPJ != false) {
      output.WriteRawTag(160, 113);
      output.WriteBool(Unk3300OHFMHIHJHPJ);
    }
    if (Unk3300HBILIAEIHNK != false) {
      output.WriteRawTag(248, 117);
      output.WriteBool(Unk3300HBILIAEIHNK);
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
    if (Unk3300OHFMHIHJHPJ != false) {
      size += 2 + 1;
    }
    if (LeftGachaTimes != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftGachaTimes);
    }
    size += gachaItemList_.CalculateSize(_repeated_gachaItemList_codec);
    if (Unk3300HBILIAEIHNK != false) {
      size += 2 + 1;
    }
    if (GachaType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaType);
    }
    if (NewGachaRandom != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NewGachaRandom);
    }
    if (WishProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WishProgress);
    }
    if (WishMaxProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WishMaxProgress);
    }
    if (GachaTimes != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaTimes);
    }
    if (GachaTimesLimit != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaTimesLimit);
    }
    if (WishItemId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WishItemId);
    }
    if (TenCostItemId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TenCostItemId);
    }
    if (CostItemNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostItemNum);
    }
    if (TenCostItemNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TenCostItemNum);
    }
    if (CurScheduleDailyGachaTimes != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(CurScheduleDailyGachaTimes);
    }
    if (CostItemId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostItemId);
    }
    if (GachaScheduleId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaScheduleId);
    }
    if (DailyGachaTimes != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(DailyGachaTimes);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(DoGachaRsp other) {
    if (other == null) {
      return;
    }
    if (other.Unk3300OHFMHIHJHPJ != false) {
      Unk3300OHFMHIHJHPJ = other.Unk3300OHFMHIHJHPJ;
    }
    if (other.LeftGachaTimes != 0) {
      LeftGachaTimes = other.LeftGachaTimes;
    }
    gachaItemList_.Add(other.gachaItemList_);
    if (other.Unk3300HBILIAEIHNK != false) {
      Unk3300HBILIAEIHNK = other.Unk3300HBILIAEIHNK;
    }
    if (other.GachaType != 0) {
      GachaType = other.GachaType;
    }
    if (other.NewGachaRandom != 0) {
      NewGachaRandom = other.NewGachaRandom;
    }
    if (other.WishProgress != 0) {
      WishProgress = other.WishProgress;
    }
    if (other.WishMaxProgress != 0) {
      WishMaxProgress = other.WishMaxProgress;
    }
    if (other.GachaTimes != 0) {
      GachaTimes = other.GachaTimes;
    }
    if (other.GachaTimesLimit != 0) {
      GachaTimesLimit = other.GachaTimesLimit;
    }
    if (other.WishItemId != 0) {
      WishItemId = other.WishItemId;
    }
    if (other.TenCostItemId != 0) {
      TenCostItemId = other.TenCostItemId;
    }
    if (other.CostItemNum != 0) {
      CostItemNum = other.CostItemNum;
    }
    if (other.TenCostItemNum != 0) {
      TenCostItemNum = other.TenCostItemNum;
    }
    if (other.CurScheduleDailyGachaTimes != 0) {
      CurScheduleDailyGachaTimes = other.CurScheduleDailyGachaTimes;
    }
    if (other.CostItemId != 0) {
      CostItemId = other.CostItemId;
    }
    if (other.GachaScheduleId != 0) {
      GachaScheduleId = other.GachaScheduleId;
    }
    if (other.DailyGachaTimes != 0) {
      DailyGachaTimes = other.DailyGachaTimes;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
          WishProgress = input.ReadUInt32();
          break;
        }
        case 16: {
          TenCostItemNum = input.ReadUInt32();
          break;
        }
        case 24: {
          LeftGachaTimes = input.ReadUInt32();
          break;
        }
        case 32: {
          GachaTimes = input.ReadUInt32();
          break;
        }
        case 40: {
          WishMaxProgress = input.ReadUInt32();
          break;
        }
        case 48: {
          NewGachaRandom = input.ReadUInt32();
          break;
        }
        case 56: {
          CostItemId = input.ReadUInt32();
          break;
        }
        case 64: {
          CostItemNum = input.ReadUInt32();
          break;
        }
        case 74: {
          gachaItemList_.AddEntriesFrom(input, _repeated_gachaItemList_codec);
          break;
        }
        case 80: {
          GachaType = input.ReadUInt32();
          break;
        }
        case 88: {
          Retcode = input.ReadInt32();
          break;
        }
        case 96: {
          WishItemId = input.ReadUInt32();
          break;
        }
        case 104: {
          TenCostItemId = input.ReadUInt32();
          break;
        }
        case 112: {
          GachaScheduleId = input.ReadUInt32();
          break;
        }
        case 120: {
          GachaTimesLimit = input.ReadUInt32();
          break;
        }
        case 3736: {
          DailyGachaTimes = input.ReadUInt32();
          break;
        }
        case 12400: {
          CurScheduleDailyGachaTimes = input.ReadUInt32();
          break;
        }
        case 14496: {
          Unk3300OHFMHIHJHPJ = input.ReadBool();
          break;
        }
        case 15096: {
          Unk3300HBILIAEIHNK = input.ReadBool();
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
          WishProgress = input.ReadUInt32();
          break;
        }
        case 16: {
          TenCostItemNum = input.ReadUInt32();
          break;
        }
        case 24: {
          LeftGachaTimes = input.ReadUInt32();
          break;
        }
        case 32: {
          GachaTimes = input.ReadUInt32();
          break;
        }
        case 40: {
          WishMaxProgress = input.ReadUInt32();
          break;
        }
        case 48: {
          NewGachaRandom = input.ReadUInt32();
          break;
        }
        case 56: {
          CostItemId = input.ReadUInt32();
          break;
        }
        case 64: {
          CostItemNum = input.ReadUInt32();
          break;
        }
        case 74: {
          gachaItemList_.AddEntriesFrom(ref input, _repeated_gachaItemList_codec);
          break;
        }
        case 80: {
          GachaType = input.ReadUInt32();
          break;
        }
        case 88: {
          Retcode = input.ReadInt32();
          break;
        }
        case 96: {
          WishItemId = input.ReadUInt32();
          break;
        }
        case 104: {
          TenCostItemId = input.ReadUInt32();
          break;
        }
        case 112: {
          GachaScheduleId = input.ReadUInt32();
          break;
        }
        case 120: {
          GachaTimesLimit = input.ReadUInt32();
          break;
        }
        case 3736: {
          DailyGachaTimes = input.ReadUInt32();
          break;
        }
        case 12400: {
          CurScheduleDailyGachaTimes = input.ReadUInt32();
          break;
        }
        case 14496: {
          Unk3300OHFMHIHJHPJ = input.ReadBool();
          break;
        }
        case 15096: {
          Unk3300HBILIAEIHNK = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
