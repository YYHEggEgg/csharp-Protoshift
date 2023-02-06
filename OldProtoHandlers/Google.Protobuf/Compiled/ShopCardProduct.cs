// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ShopCardProduct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ShopCardProduct.proto</summary>
public static partial class ShopCardProductReflection {

  #region Descriptor
  /// <summary>File descriptor for ShopCardProduct.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ShopCardProductReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVTaG9wQ2FyZFByb2R1Y3QucHJvdG8aD0l0ZW1QYXJhbS5wcm90byLGAgoP",
          "U2hvcENhcmRQcm9kdWN0EhIKCnByb2R1Y3RfaWQYASABKAkSEgoKcHJpY2Vf",
          "dGllchgCIAEoCRISCgptY29pbl9iYXNlGAMgASgNEhUKDWhjb2luX3Blcl9k",
          "YXkYBCABKA0SDAoEZGF5cxgFIAEoDRIaChJyZW1haW5fcmV3YXJkX2RheXMY",
          "BiABKA0SGQoRY2FyZF9wcm9kdWN0X3R5cGUYByABKA0SMAoKcmVzaW5fY2Fy",
          "ZBhlIAEoCzIaLlNob3BDYXJkUHJvZHVjdC5SZXNpbkNhcmRIABpWCglSZXNp",
          "bkNhcmQSIgoOYmFzZV9pdGVtX2xpc3QYASADKAsyCi5JdGVtUGFyYW0SJQoR",
          "cGVyX2RheV9pdGVtX2xpc3QYAiADKAsyCi5JdGVtUGFyYW1CEQoPZXh0cmFf",
          "Y2FyZF9kYXRhQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ShopCardProduct), global::ShopCardProduct.Parser, new[]{ "ProductId", "PriceTier", "McoinBase", "HcoinPerDay", "Days", "RemainRewardDays", "CardProductType", "ResinCard" }, new[]{ "ExtraCardData" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::ShopCardProduct.Types.ResinCard), global::ShopCardProduct.Types.ResinCard.Parser, new[]{ "BaseItemList", "PerDayItemList" }, null, null, null, null)})
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ShopCardProduct : pb::IMessage<ShopCardProduct>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ShopCardProduct> _parser = new pb::MessageParser<ShopCardProduct>(() => new ShopCardProduct());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ShopCardProduct> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ShopCardProductReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ShopCardProduct() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ShopCardProduct(ShopCardProduct other) : this() {
    productId_ = other.productId_;
    priceTier_ = other.priceTier_;
    mcoinBase_ = other.mcoinBase_;
    hcoinPerDay_ = other.hcoinPerDay_;
    days_ = other.days_;
    remainRewardDays_ = other.remainRewardDays_;
    cardProductType_ = other.cardProductType_;
    switch (other.ExtraCardDataCase) {
      case ExtraCardDataOneofCase.ResinCard:
        ResinCard = other.ResinCard.Clone();
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ShopCardProduct Clone() {
    return new ShopCardProduct(this);
  }

  /// <summary>Field number for the "product_id" field.</summary>
  public const int ProductIdFieldNumber = 1;
  private string productId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ProductId {
    get { return productId_; }
    set {
      productId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "price_tier" field.</summary>
  public const int PriceTierFieldNumber = 2;
  private string priceTier_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string PriceTier {
    get { return priceTier_; }
    set {
      priceTier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "mcoin_base" field.</summary>
  public const int McoinBaseFieldNumber = 3;
  private uint mcoinBase_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint McoinBase {
    get { return mcoinBase_; }
    set {
      mcoinBase_ = value;
    }
  }

  /// <summary>Field number for the "hcoin_per_day" field.</summary>
  public const int HcoinPerDayFieldNumber = 4;
  private uint hcoinPerDay_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint HcoinPerDay {
    get { return hcoinPerDay_; }
    set {
      hcoinPerDay_ = value;
    }
  }

  /// <summary>Field number for the "days" field.</summary>
  public const int DaysFieldNumber = 5;
  private uint days_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Days {
    get { return days_; }
    set {
      days_ = value;
    }
  }

  /// <summary>Field number for the "remain_reward_days" field.</summary>
  public const int RemainRewardDaysFieldNumber = 6;
  private uint remainRewardDays_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RemainRewardDays {
    get { return remainRewardDays_; }
    set {
      remainRewardDays_ = value;
    }
  }

  /// <summary>Field number for the "card_product_type" field.</summary>
  public const int CardProductTypeFieldNumber = 7;
  private uint cardProductType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CardProductType {
    get { return cardProductType_; }
    set {
      cardProductType_ = value;
    }
  }

  /// <summary>Field number for the "resin_card" field.</summary>
  public const int ResinCardFieldNumber = 101;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ShopCardProduct.Types.ResinCard ResinCard {
    get { return extraCardDataCase_ == ExtraCardDataOneofCase.ResinCard ? (global::ShopCardProduct.Types.ResinCard) extraCardData_ : null; }
    set {
      extraCardData_ = value;
      extraCardDataCase_ = value == null ? ExtraCardDataOneofCase.None : ExtraCardDataOneofCase.ResinCard;
    }
  }

  private object extraCardData_;
  /// <summary>Enum of possible cases for the "extra_card_data" oneof.</summary>
  public enum ExtraCardDataOneofCase {
    None = 0,
    ResinCard = 101,
  }
  private ExtraCardDataOneofCase extraCardDataCase_ = ExtraCardDataOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExtraCardDataOneofCase ExtraCardDataCase {
    get { return extraCardDataCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearExtraCardData() {
    extraCardDataCase_ = ExtraCardDataOneofCase.None;
    extraCardData_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ShopCardProduct);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ShopCardProduct other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ProductId != other.ProductId) return false;
    if (PriceTier != other.PriceTier) return false;
    if (McoinBase != other.McoinBase) return false;
    if (HcoinPerDay != other.HcoinPerDay) return false;
    if (Days != other.Days) return false;
    if (RemainRewardDays != other.RemainRewardDays) return false;
    if (CardProductType != other.CardProductType) return false;
    if (!object.Equals(ResinCard, other.ResinCard)) return false;
    if (ExtraCardDataCase != other.ExtraCardDataCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ProductId.Length != 0) hash ^= ProductId.GetHashCode();
    if (PriceTier.Length != 0) hash ^= PriceTier.GetHashCode();
    if (McoinBase != 0) hash ^= McoinBase.GetHashCode();
    if (HcoinPerDay != 0) hash ^= HcoinPerDay.GetHashCode();
    if (Days != 0) hash ^= Days.GetHashCode();
    if (RemainRewardDays != 0) hash ^= RemainRewardDays.GetHashCode();
    if (CardProductType != 0) hash ^= CardProductType.GetHashCode();
    if (extraCardDataCase_ == ExtraCardDataOneofCase.ResinCard) hash ^= ResinCard.GetHashCode();
    hash ^= (int) extraCardDataCase_;
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
    if (ProductId.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(ProductId);
    }
    if (PriceTier.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(PriceTier);
    }
    if (McoinBase != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(McoinBase);
    }
    if (HcoinPerDay != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(HcoinPerDay);
    }
    if (Days != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Days);
    }
    if (RemainRewardDays != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(RemainRewardDays);
    }
    if (CardProductType != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CardProductType);
    }
    if (extraCardDataCase_ == ExtraCardDataOneofCase.ResinCard) {
      output.WriteRawTag(170, 6);
      output.WriteMessage(ResinCard);
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
    if (ProductId.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(ProductId);
    }
    if (PriceTier.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(PriceTier);
    }
    if (McoinBase != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(McoinBase);
    }
    if (HcoinPerDay != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(HcoinPerDay);
    }
    if (Days != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Days);
    }
    if (RemainRewardDays != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(RemainRewardDays);
    }
    if (CardProductType != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CardProductType);
    }
    if (extraCardDataCase_ == ExtraCardDataOneofCase.ResinCard) {
      output.WriteRawTag(170, 6);
      output.WriteMessage(ResinCard);
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
    if (ProductId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductId);
    }
    if (PriceTier.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(PriceTier);
    }
    if (McoinBase != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(McoinBase);
    }
    if (HcoinPerDay != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HcoinPerDay);
    }
    if (Days != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Days);
    }
    if (RemainRewardDays != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainRewardDays);
    }
    if (CardProductType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardProductType);
    }
    if (extraCardDataCase_ == ExtraCardDataOneofCase.ResinCard) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(ResinCard);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ShopCardProduct other) {
    if (other == null) {
      return;
    }
    if (other.ProductId.Length != 0) {
      ProductId = other.ProductId;
    }
    if (other.PriceTier.Length != 0) {
      PriceTier = other.PriceTier;
    }
    if (other.McoinBase != 0) {
      McoinBase = other.McoinBase;
    }
    if (other.HcoinPerDay != 0) {
      HcoinPerDay = other.HcoinPerDay;
    }
    if (other.Days != 0) {
      Days = other.Days;
    }
    if (other.RemainRewardDays != 0) {
      RemainRewardDays = other.RemainRewardDays;
    }
    if (other.CardProductType != 0) {
      CardProductType = other.CardProductType;
    }
    switch (other.ExtraCardDataCase) {
      case ExtraCardDataOneofCase.ResinCard:
        if (ResinCard == null) {
          ResinCard = new global::ShopCardProduct.Types.ResinCard();
        }
        ResinCard.MergeFrom(other.ResinCard);
        break;
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
          ProductId = input.ReadString();
          break;
        }
        case 18: {
          PriceTier = input.ReadString();
          break;
        }
        case 24: {
          McoinBase = input.ReadUInt32();
          break;
        }
        case 32: {
          HcoinPerDay = input.ReadUInt32();
          break;
        }
        case 40: {
          Days = input.ReadUInt32();
          break;
        }
        case 48: {
          RemainRewardDays = input.ReadUInt32();
          break;
        }
        case 56: {
          CardProductType = input.ReadUInt32();
          break;
        }
        case 810: {
          global::ShopCardProduct.Types.ResinCard subBuilder = new global::ShopCardProduct.Types.ResinCard();
          if (extraCardDataCase_ == ExtraCardDataOneofCase.ResinCard) {
            subBuilder.MergeFrom(ResinCard);
          }
          input.ReadMessage(subBuilder);
          ResinCard = subBuilder;
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
          ProductId = input.ReadString();
          break;
        }
        case 18: {
          PriceTier = input.ReadString();
          break;
        }
        case 24: {
          McoinBase = input.ReadUInt32();
          break;
        }
        case 32: {
          HcoinPerDay = input.ReadUInt32();
          break;
        }
        case 40: {
          Days = input.ReadUInt32();
          break;
        }
        case 48: {
          RemainRewardDays = input.ReadUInt32();
          break;
        }
        case 56: {
          CardProductType = input.ReadUInt32();
          break;
        }
        case 810: {
          global::ShopCardProduct.Types.ResinCard subBuilder = new global::ShopCardProduct.Types.ResinCard();
          if (extraCardDataCase_ == ExtraCardDataOneofCase.ResinCard) {
            subBuilder.MergeFrom(ResinCard);
          }
          input.ReadMessage(subBuilder);
          ResinCard = subBuilder;
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the ShopCardProduct message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public sealed partial class ResinCard : pb::IMessage<ResinCard>
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , pb::IBufferMessage
    #endif
    {
      private static readonly pb::MessageParser<ResinCard> _parser = new pb::MessageParser<ResinCard>(() => new ResinCard());
      private pb::UnknownFieldSet _unknownFields;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pb::MessageParser<ResinCard> Parser { get { return _parser; } }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pbr::MessageDescriptor Descriptor {
        get { return global::ShopCardProduct.Descriptor.NestedTypes[0]; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public ResinCard() {
        OnConstruction();
      }

      partial void OnConstruction();

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public ResinCard(ResinCard other) : this() {
        baseItemList_ = other.baseItemList_.Clone();
        perDayItemList_ = other.perDayItemList_.Clone();
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public ResinCard Clone() {
        return new ResinCard(this);
      }

      /// <summary>Field number for the "base_item_list" field.</summary>
      public const int BaseItemListFieldNumber = 1;
      private static readonly pb::FieldCodec<global::ItemParam> _repeated_baseItemList_codec
          = pb::FieldCodec.ForMessage(10, global::ItemParam.Parser);
      private readonly pbc::RepeatedField<global::ItemParam> baseItemList_ = new pbc::RepeatedField<global::ItemParam>();
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public pbc::RepeatedField<global::ItemParam> BaseItemList {
        get { return baseItemList_; }
      }

      /// <summary>Field number for the "per_day_item_list" field.</summary>
      public const int PerDayItemListFieldNumber = 2;
      private static readonly pb::FieldCodec<global::ItemParam> _repeated_perDayItemList_codec
          = pb::FieldCodec.ForMessage(18, global::ItemParam.Parser);
      private readonly pbc::RepeatedField<global::ItemParam> perDayItemList_ = new pbc::RepeatedField<global::ItemParam>();
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public pbc::RepeatedField<global::ItemParam> PerDayItemList {
        get { return perDayItemList_; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override bool Equals(object other) {
        return Equals(other as ResinCard);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public bool Equals(ResinCard other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if(!baseItemList_.Equals(other.baseItemList_)) return false;
        if(!perDayItemList_.Equals(other.perDayItemList_)) return false;
        return Equals(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override int GetHashCode() {
        int hash = 1;
        hash ^= baseItemList_.GetHashCode();
        hash ^= perDayItemList_.GetHashCode();
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
        baseItemList_.WriteTo(output, _repeated_baseItemList_codec);
        perDayItemList_.WriteTo(output, _repeated_perDayItemList_codec);
        if (_unknownFields != null) {
          _unknownFields.WriteTo(output);
        }
      #endif
      }

      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
        baseItemList_.WriteTo(ref output, _repeated_baseItemList_codec);
        perDayItemList_.WriteTo(ref output, _repeated_perDayItemList_codec);
        if (_unknownFields != null) {
          _unknownFields.WriteTo(ref output);
        }
      }
      #endif

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public int CalculateSize() {
        int size = 0;
        size += baseItemList_.CalculateSize(_repeated_baseItemList_codec);
        size += perDayItemList_.CalculateSize(_repeated_perDayItemList_codec);
        if (_unknownFields != null) {
          size += _unknownFields.CalculateSize();
        }
        return size;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public void MergeFrom(ResinCard other) {
        if (other == null) {
          return;
        }
        baseItemList_.Add(other.baseItemList_);
        perDayItemList_.Add(other.perDayItemList_);
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
              baseItemList_.AddEntriesFrom(input, _repeated_baseItemList_codec);
              break;
            }
            case 18: {
              perDayItemList_.AddEntriesFrom(input, _repeated_perDayItemList_codec);
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
              baseItemList_.AddEntriesFrom(ref input, _repeated_baseItemList_codec);
              break;
            }
            case 18: {
              perDayItemList_.AddEntriesFrom(ref input, _repeated_perDayItemList_codec);
              break;
            }
          }
        }
      }
      #endif

    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
