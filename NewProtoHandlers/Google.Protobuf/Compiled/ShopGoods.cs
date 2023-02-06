// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ShopGoods.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ShopGoods.proto</summary>
public static partial class ShopGoodsReflection {

  #region Descriptor
  /// <summary>File descriptor for ShopGoods.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ShopGoodsReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9TaG9wR29vZHMucHJvdG8aD0l0ZW1QYXJhbS5wcm90byLbAwoJU2hvcEdv",
          "b2RzEhsKEnNlY29uZGFyeV9zaGVldF9pZBjrByABKA0SHgoKZ29vZHNfaXRl",
          "bRgPIAEoCzIKLkl0ZW1QYXJhbRIiCg5jb3N0X2l0ZW1fbGlzdBgHIAMoCzIK",
          "Lkl0ZW1QYXJhbRISCgpib3VnaHRfbnVtGA4gASgNEhkKEXByZV9nb29kc19p",
          "ZF9saXN0GAkgAygNEhEKCW1pbl9sZXZlbBgFIAEoDRINCgVtY29pbhgLIAEo",
          "DRINCgVoY29pbhgGIAEoDRIQCghlbmRfdGltZRgDIAEoDRIZChFuZXh0X3Jl",
          "ZnJlc2hfdGltZRgKIAEoDRIQCghnb29kc19pZBgNIAEoDRIcChNVbmszMzAw",
          "X09NS0lGSU1ER0ROGI0IIAEoDRIRCglidXlfbGltaXQYCCABKA0SHAoTVW5r",
          "MzMwMF9NQkdPTUhOQkhNRxiJBiABKA0SDQoFc2NvaW4YAiABKA0SEQoJbWF4",
          "X2xldmVsGAEgASgNEhUKDHNpbmdsZV9saW1pdBjqDSABKA0SHAoTVW5rMzMw",
          "MF9OSkNQQUpCQ0VQSBj5AyABKA0SEgoKYmVnaW5fdGltZRgMIAEoDRIUCgxk",
          "aXNhYmxlX3R5cGUYBCABKA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ShopGoods), global::ShopGoods.Parser, new[]{ "SecondarySheetId", "GoodsItem", "CostItemList", "BoughtNum", "PreGoodsIdList", "MinLevel", "Mcoin", "Hcoin", "EndTime", "NextRefreshTime", "GoodsId", "Unk3300OMKIFIMDGDN", "BuyLimit", "Unk3300MBGOMHNBHMG", "Scoin", "MaxLevel", "SingleLimit", "Unk3300NJCPAJBCEPH", "BeginTime", "DisableType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ShopGoods : pb::IMessage<ShopGoods>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ShopGoods> _parser = new pb::MessageParser<ShopGoods>(() => new ShopGoods());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ShopGoods> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ShopGoodsReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ShopGoods() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ShopGoods(ShopGoods other) : this() {
    secondarySheetId_ = other.secondarySheetId_;
    goodsItem_ = other.goodsItem_ != null ? other.goodsItem_.Clone() : null;
    costItemList_ = other.costItemList_.Clone();
    boughtNum_ = other.boughtNum_;
    preGoodsIdList_ = other.preGoodsIdList_.Clone();
    minLevel_ = other.minLevel_;
    mcoin_ = other.mcoin_;
    hcoin_ = other.hcoin_;
    endTime_ = other.endTime_;
    nextRefreshTime_ = other.nextRefreshTime_;
    goodsId_ = other.goodsId_;
    unk3300OMKIFIMDGDN_ = other.unk3300OMKIFIMDGDN_;
    buyLimit_ = other.buyLimit_;
    unk3300MBGOMHNBHMG_ = other.unk3300MBGOMHNBHMG_;
    scoin_ = other.scoin_;
    maxLevel_ = other.maxLevel_;
    singleLimit_ = other.singleLimit_;
    unk3300NJCPAJBCEPH_ = other.unk3300NJCPAJBCEPH_;
    beginTime_ = other.beginTime_;
    disableType_ = other.disableType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ShopGoods Clone() {
    return new ShopGoods(this);
  }

  /// <summary>Field number for the "secondary_sheet_id" field.</summary>
  public const int SecondarySheetIdFieldNumber = 1003;
  private uint secondarySheetId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SecondarySheetId {
    get { return secondarySheetId_; }
    set {
      secondarySheetId_ = value;
    }
  }

  /// <summary>Field number for the "goods_item" field.</summary>
  public const int GoodsItemFieldNumber = 15;
  private global::ItemParam goodsItem_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ItemParam GoodsItem {
    get { return goodsItem_; }
    set {
      goodsItem_ = value;
    }
  }

  /// <summary>Field number for the "cost_item_list" field.</summary>
  public const int CostItemListFieldNumber = 7;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_costItemList_codec
      = pb::FieldCodec.ForMessage(58, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> costItemList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> CostItemList {
    get { return costItemList_; }
  }

  /// <summary>Field number for the "bought_num" field.</summary>
  public const int BoughtNumFieldNumber = 14;
  private uint boughtNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BoughtNum {
    get { return boughtNum_; }
    set {
      boughtNum_ = value;
    }
  }

  /// <summary>Field number for the "pre_goods_id_list" field.</summary>
  public const int PreGoodsIdListFieldNumber = 9;
  private static readonly pb::FieldCodec<uint> _repeated_preGoodsIdList_codec
      = pb::FieldCodec.ForUInt32(74);
  private readonly pbc::RepeatedField<uint> preGoodsIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> PreGoodsIdList {
    get { return preGoodsIdList_; }
  }

  /// <summary>Field number for the "min_level" field.</summary>
  public const int MinLevelFieldNumber = 5;
  private uint minLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MinLevel {
    get { return minLevel_; }
    set {
      minLevel_ = value;
    }
  }

  /// <summary>Field number for the "mcoin" field.</summary>
  public const int McoinFieldNumber = 11;
  private uint mcoin_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Mcoin {
    get { return mcoin_; }
    set {
      mcoin_ = value;
    }
  }

  /// <summary>Field number for the "hcoin" field.</summary>
  public const int HcoinFieldNumber = 6;
  private uint hcoin_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Hcoin {
    get { return hcoin_; }
    set {
      hcoin_ = value;
    }
  }

  /// <summary>Field number for the "end_time" field.</summary>
  public const int EndTimeFieldNumber = 3;
  private uint endTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EndTime {
    get { return endTime_; }
    set {
      endTime_ = value;
    }
  }

  /// <summary>Field number for the "next_refresh_time" field.</summary>
  public const int NextRefreshTimeFieldNumber = 10;
  private uint nextRefreshTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint NextRefreshTime {
    get { return nextRefreshTime_; }
    set {
      nextRefreshTime_ = value;
    }
  }

  /// <summary>Field number for the "goods_id" field.</summary>
  public const int GoodsIdFieldNumber = 13;
  private uint goodsId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GoodsId {
    get { return goodsId_; }
    set {
      goodsId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_OMKIFIMDGDN" field.</summary>
  public const int Unk3300OMKIFIMDGDNFieldNumber = 1037;
  private uint unk3300OMKIFIMDGDN_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300OMKIFIMDGDN {
    get { return unk3300OMKIFIMDGDN_; }
    set {
      unk3300OMKIFIMDGDN_ = value;
    }
  }

  /// <summary>Field number for the "buy_limit" field.</summary>
  public const int BuyLimitFieldNumber = 8;
  private uint buyLimit_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BuyLimit {
    get { return buyLimit_; }
    set {
      buyLimit_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_MBGOMHNBHMG" field.</summary>
  public const int Unk3300MBGOMHNBHMGFieldNumber = 777;
  private uint unk3300MBGOMHNBHMG_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300MBGOMHNBHMG {
    get { return unk3300MBGOMHNBHMG_; }
    set {
      unk3300MBGOMHNBHMG_ = value;
    }
  }

  /// <summary>Field number for the "scoin" field.</summary>
  public const int ScoinFieldNumber = 2;
  private uint scoin_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Scoin {
    get { return scoin_; }
    set {
      scoin_ = value;
    }
  }

  /// <summary>Field number for the "max_level" field.</summary>
  public const int MaxLevelFieldNumber = 1;
  private uint maxLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MaxLevel {
    get { return maxLevel_; }
    set {
      maxLevel_ = value;
    }
  }

  /// <summary>Field number for the "single_limit" field.</summary>
  public const int SingleLimitFieldNumber = 1770;
  private uint singleLimit_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SingleLimit {
    get { return singleLimit_; }
    set {
      singleLimit_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_NJCPAJBCEPH" field.</summary>
  public const int Unk3300NJCPAJBCEPHFieldNumber = 505;
  private uint unk3300NJCPAJBCEPH_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300NJCPAJBCEPH {
    get { return unk3300NJCPAJBCEPH_; }
    set {
      unk3300NJCPAJBCEPH_ = value;
    }
  }

  /// <summary>Field number for the "begin_time" field.</summary>
  public const int BeginTimeFieldNumber = 12;
  private uint beginTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BeginTime {
    get { return beginTime_; }
    set {
      beginTime_ = value;
    }
  }

  /// <summary>Field number for the "disable_type" field.</summary>
  public const int DisableTypeFieldNumber = 4;
  private uint disableType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DisableType {
    get { return disableType_; }
    set {
      disableType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ShopGoods);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ShopGoods other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (SecondarySheetId != other.SecondarySheetId) return false;
    if (!object.Equals(GoodsItem, other.GoodsItem)) return false;
    if(!costItemList_.Equals(other.costItemList_)) return false;
    if (BoughtNum != other.BoughtNum) return false;
    if(!preGoodsIdList_.Equals(other.preGoodsIdList_)) return false;
    if (MinLevel != other.MinLevel) return false;
    if (Mcoin != other.Mcoin) return false;
    if (Hcoin != other.Hcoin) return false;
    if (EndTime != other.EndTime) return false;
    if (NextRefreshTime != other.NextRefreshTime) return false;
    if (GoodsId != other.GoodsId) return false;
    if (Unk3300OMKIFIMDGDN != other.Unk3300OMKIFIMDGDN) return false;
    if (BuyLimit != other.BuyLimit) return false;
    if (Unk3300MBGOMHNBHMG != other.Unk3300MBGOMHNBHMG) return false;
    if (Scoin != other.Scoin) return false;
    if (MaxLevel != other.MaxLevel) return false;
    if (SingleLimit != other.SingleLimit) return false;
    if (Unk3300NJCPAJBCEPH != other.Unk3300NJCPAJBCEPH) return false;
    if (BeginTime != other.BeginTime) return false;
    if (DisableType != other.DisableType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (SecondarySheetId != 0) hash ^= SecondarySheetId.GetHashCode();
    if (goodsItem_ != null) hash ^= GoodsItem.GetHashCode();
    hash ^= costItemList_.GetHashCode();
    if (BoughtNum != 0) hash ^= BoughtNum.GetHashCode();
    hash ^= preGoodsIdList_.GetHashCode();
    if (MinLevel != 0) hash ^= MinLevel.GetHashCode();
    if (Mcoin != 0) hash ^= Mcoin.GetHashCode();
    if (Hcoin != 0) hash ^= Hcoin.GetHashCode();
    if (EndTime != 0) hash ^= EndTime.GetHashCode();
    if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
    if (GoodsId != 0) hash ^= GoodsId.GetHashCode();
    if (Unk3300OMKIFIMDGDN != 0) hash ^= Unk3300OMKIFIMDGDN.GetHashCode();
    if (BuyLimit != 0) hash ^= BuyLimit.GetHashCode();
    if (Unk3300MBGOMHNBHMG != 0) hash ^= Unk3300MBGOMHNBHMG.GetHashCode();
    if (Scoin != 0) hash ^= Scoin.GetHashCode();
    if (MaxLevel != 0) hash ^= MaxLevel.GetHashCode();
    if (SingleLimit != 0) hash ^= SingleLimit.GetHashCode();
    if (Unk3300NJCPAJBCEPH != 0) hash ^= Unk3300NJCPAJBCEPH.GetHashCode();
    if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
    if (DisableType != 0) hash ^= DisableType.GetHashCode();
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
    if (MaxLevel != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(MaxLevel);
    }
    if (Scoin != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Scoin);
    }
    if (EndTime != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(EndTime);
    }
    if (DisableType != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(DisableType);
    }
    if (MinLevel != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MinLevel);
    }
    if (Hcoin != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Hcoin);
    }
    costItemList_.WriteTo(output, _repeated_costItemList_codec);
    if (BuyLimit != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(BuyLimit);
    }
    preGoodsIdList_.WriteTo(output, _repeated_preGoodsIdList_codec);
    if (NextRefreshTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(NextRefreshTime);
    }
    if (Mcoin != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Mcoin);
    }
    if (BeginTime != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(BeginTime);
    }
    if (GoodsId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GoodsId);
    }
    if (BoughtNum != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(BoughtNum);
    }
    if (goodsItem_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(GoodsItem);
    }
    if (Unk3300NJCPAJBCEPH != 0) {
      output.WriteRawTag(200, 31);
      output.WriteUInt32(Unk3300NJCPAJBCEPH);
    }
    if (Unk3300MBGOMHNBHMG != 0) {
      output.WriteRawTag(200, 48);
      output.WriteUInt32(Unk3300MBGOMHNBHMG);
    }
    if (SecondarySheetId != 0) {
      output.WriteRawTag(216, 62);
      output.WriteUInt32(SecondarySheetId);
    }
    if (Unk3300OMKIFIMDGDN != 0) {
      output.WriteRawTag(232, 64);
      output.WriteUInt32(Unk3300OMKIFIMDGDN);
    }
    if (SingleLimit != 0) {
      output.WriteRawTag(208, 110);
      output.WriteUInt32(SingleLimit);
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
    if (MaxLevel != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(MaxLevel);
    }
    if (Scoin != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Scoin);
    }
    if (EndTime != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(EndTime);
    }
    if (DisableType != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(DisableType);
    }
    if (MinLevel != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MinLevel);
    }
    if (Hcoin != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Hcoin);
    }
    costItemList_.WriteTo(ref output, _repeated_costItemList_codec);
    if (BuyLimit != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(BuyLimit);
    }
    preGoodsIdList_.WriteTo(ref output, _repeated_preGoodsIdList_codec);
    if (NextRefreshTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(NextRefreshTime);
    }
    if (Mcoin != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Mcoin);
    }
    if (BeginTime != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(BeginTime);
    }
    if (GoodsId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GoodsId);
    }
    if (BoughtNum != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(BoughtNum);
    }
    if (goodsItem_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(GoodsItem);
    }
    if (Unk3300NJCPAJBCEPH != 0) {
      output.WriteRawTag(200, 31);
      output.WriteUInt32(Unk3300NJCPAJBCEPH);
    }
    if (Unk3300MBGOMHNBHMG != 0) {
      output.WriteRawTag(200, 48);
      output.WriteUInt32(Unk3300MBGOMHNBHMG);
    }
    if (SecondarySheetId != 0) {
      output.WriteRawTag(216, 62);
      output.WriteUInt32(SecondarySheetId);
    }
    if (Unk3300OMKIFIMDGDN != 0) {
      output.WriteRawTag(232, 64);
      output.WriteUInt32(Unk3300OMKIFIMDGDN);
    }
    if (SingleLimit != 0) {
      output.WriteRawTag(208, 110);
      output.WriteUInt32(SingleLimit);
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
    if (SecondarySheetId != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SecondarySheetId);
    }
    if (goodsItem_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(GoodsItem);
    }
    size += costItemList_.CalculateSize(_repeated_costItemList_codec);
    if (BoughtNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BoughtNum);
    }
    size += preGoodsIdList_.CalculateSize(_repeated_preGoodsIdList_codec);
    if (MinLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinLevel);
    }
    if (Mcoin != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Mcoin);
    }
    if (Hcoin != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hcoin);
    }
    if (EndTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
    }
    if (NextRefreshTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
    }
    if (GoodsId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoodsId);
    }
    if (Unk3300OMKIFIMDGDN != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OMKIFIMDGDN);
    }
    if (BuyLimit != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuyLimit);
    }
    if (Unk3300MBGOMHNBHMG != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MBGOMHNBHMG);
    }
    if (Scoin != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Scoin);
    }
    if (MaxLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxLevel);
    }
    if (SingleLimit != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SingleLimit);
    }
    if (Unk3300NJCPAJBCEPH != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NJCPAJBCEPH);
    }
    if (BeginTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
    }
    if (DisableType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DisableType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ShopGoods other) {
    if (other == null) {
      return;
    }
    if (other.SecondarySheetId != 0) {
      SecondarySheetId = other.SecondarySheetId;
    }
    if (other.goodsItem_ != null) {
      if (goodsItem_ == null) {
        GoodsItem = new global::ItemParam();
      }
      GoodsItem.MergeFrom(other.GoodsItem);
    }
    costItemList_.Add(other.costItemList_);
    if (other.BoughtNum != 0) {
      BoughtNum = other.BoughtNum;
    }
    preGoodsIdList_.Add(other.preGoodsIdList_);
    if (other.MinLevel != 0) {
      MinLevel = other.MinLevel;
    }
    if (other.Mcoin != 0) {
      Mcoin = other.Mcoin;
    }
    if (other.Hcoin != 0) {
      Hcoin = other.Hcoin;
    }
    if (other.EndTime != 0) {
      EndTime = other.EndTime;
    }
    if (other.NextRefreshTime != 0) {
      NextRefreshTime = other.NextRefreshTime;
    }
    if (other.GoodsId != 0) {
      GoodsId = other.GoodsId;
    }
    if (other.Unk3300OMKIFIMDGDN != 0) {
      Unk3300OMKIFIMDGDN = other.Unk3300OMKIFIMDGDN;
    }
    if (other.BuyLimit != 0) {
      BuyLimit = other.BuyLimit;
    }
    if (other.Unk3300MBGOMHNBHMG != 0) {
      Unk3300MBGOMHNBHMG = other.Unk3300MBGOMHNBHMG;
    }
    if (other.Scoin != 0) {
      Scoin = other.Scoin;
    }
    if (other.MaxLevel != 0) {
      MaxLevel = other.MaxLevel;
    }
    if (other.SingleLimit != 0) {
      SingleLimit = other.SingleLimit;
    }
    if (other.Unk3300NJCPAJBCEPH != 0) {
      Unk3300NJCPAJBCEPH = other.Unk3300NJCPAJBCEPH;
    }
    if (other.BeginTime != 0) {
      BeginTime = other.BeginTime;
    }
    if (other.DisableType != 0) {
      DisableType = other.DisableType;
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
          MaxLevel = input.ReadUInt32();
          break;
        }
        case 16: {
          Scoin = input.ReadUInt32();
          break;
        }
        case 24: {
          EndTime = input.ReadUInt32();
          break;
        }
        case 32: {
          DisableType = input.ReadUInt32();
          break;
        }
        case 40: {
          MinLevel = input.ReadUInt32();
          break;
        }
        case 48: {
          Hcoin = input.ReadUInt32();
          break;
        }
        case 58: {
          costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
          break;
        }
        case 64: {
          BuyLimit = input.ReadUInt32();
          break;
        }
        case 74:
        case 72: {
          preGoodsIdList_.AddEntriesFrom(input, _repeated_preGoodsIdList_codec);
          break;
        }
        case 80: {
          NextRefreshTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Mcoin = input.ReadUInt32();
          break;
        }
        case 96: {
          BeginTime = input.ReadUInt32();
          break;
        }
        case 104: {
          GoodsId = input.ReadUInt32();
          break;
        }
        case 112: {
          BoughtNum = input.ReadUInt32();
          break;
        }
        case 122: {
          if (goodsItem_ == null) {
            GoodsItem = new global::ItemParam();
          }
          input.ReadMessage(GoodsItem);
          break;
        }
        case 4040: {
          Unk3300NJCPAJBCEPH = input.ReadUInt32();
          break;
        }
        case 6216: {
          Unk3300MBGOMHNBHMG = input.ReadUInt32();
          break;
        }
        case 8024: {
          SecondarySheetId = input.ReadUInt32();
          break;
        }
        case 8296: {
          Unk3300OMKIFIMDGDN = input.ReadUInt32();
          break;
        }
        case 14160: {
          SingleLimit = input.ReadUInt32();
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
          MaxLevel = input.ReadUInt32();
          break;
        }
        case 16: {
          Scoin = input.ReadUInt32();
          break;
        }
        case 24: {
          EndTime = input.ReadUInt32();
          break;
        }
        case 32: {
          DisableType = input.ReadUInt32();
          break;
        }
        case 40: {
          MinLevel = input.ReadUInt32();
          break;
        }
        case 48: {
          Hcoin = input.ReadUInt32();
          break;
        }
        case 58: {
          costItemList_.AddEntriesFrom(ref input, _repeated_costItemList_codec);
          break;
        }
        case 64: {
          BuyLimit = input.ReadUInt32();
          break;
        }
        case 74:
        case 72: {
          preGoodsIdList_.AddEntriesFrom(ref input, _repeated_preGoodsIdList_codec);
          break;
        }
        case 80: {
          NextRefreshTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Mcoin = input.ReadUInt32();
          break;
        }
        case 96: {
          BeginTime = input.ReadUInt32();
          break;
        }
        case 104: {
          GoodsId = input.ReadUInt32();
          break;
        }
        case 112: {
          BoughtNum = input.ReadUInt32();
          break;
        }
        case 122: {
          if (goodsItem_ == null) {
            GoodsItem = new global::ItemParam();
          }
          input.ReadMessage(GoodsItem);
          break;
        }
        case 4040: {
          Unk3300NJCPAJBCEPH = input.ReadUInt32();
          break;
        }
        case 6216: {
          Unk3300MBGOMHNBHMG = input.ReadUInt32();
          break;
        }
        case 8024: {
          SecondarySheetId = input.ReadUInt32();
          break;
        }
        case 8296: {
          Unk3300OMKIFIMDGDN = input.ReadUInt32();
          break;
        }
        case 14160: {
          SingleLimit = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
