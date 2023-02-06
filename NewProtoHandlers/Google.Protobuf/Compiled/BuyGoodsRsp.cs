// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BuyGoodsRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BuyGoodsRsp.proto</summary>
public static partial class BuyGoodsRspReflection {

  #region Descriptor
  /// <summary>File descriptor for BuyGoodsRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BuyGoodsRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFCdXlHb29kc1JzcC5wcm90bxoPU2hvcEdvb2RzLnByb3RvIn8KC0J1eUdv",
          "b2RzUnNwEhEKCXNob3BfdHlwZRgPIAEoDRIPCgdyZXRjb2RlGA0gASgFEh4K",
          "Cmdvb2RzX2xpc3QYCiADKAsyCi5TaG9wR29vZHMSGQoFZ29vZHMYByABKAsy",
          "Ci5TaG9wR29vZHMSEQoJYnV5X2NvdW50GAkgASgNQhYKFG9yZy5zb3JhcG9p",
          "bnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ShopGoodsReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BuyGoodsRsp), global::BuyGoodsRsp.Parser, new[]{ "ShopType", "Retcode", "GoodsList", "Goods", "BuyCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 719;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class BuyGoodsRsp : pb::IMessage<BuyGoodsRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BuyGoodsRsp> _parser = new pb::MessageParser<BuyGoodsRsp>(() => new BuyGoodsRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BuyGoodsRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BuyGoodsRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuyGoodsRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuyGoodsRsp(BuyGoodsRsp other) : this() {
    shopType_ = other.shopType_;
    retcode_ = other.retcode_;
    goodsList_ = other.goodsList_.Clone();
    goods_ = other.goods_ != null ? other.goods_.Clone() : null;
    buyCount_ = other.buyCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuyGoodsRsp Clone() {
    return new BuyGoodsRsp(this);
  }

  /// <summary>Field number for the "shop_type" field.</summary>
  public const int ShopTypeFieldNumber = 15;
  private uint shopType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ShopType {
    get { return shopType_; }
    set {
      shopType_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 13;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "goods_list" field.</summary>
  public const int GoodsListFieldNumber = 10;
  private static readonly pb::FieldCodec<global::ShopGoods> _repeated_goodsList_codec
      = pb::FieldCodec.ForMessage(82, global::ShopGoods.Parser);
  private readonly pbc::RepeatedField<global::ShopGoods> goodsList_ = new pbc::RepeatedField<global::ShopGoods>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ShopGoods> GoodsList {
    get { return goodsList_; }
  }

  /// <summary>Field number for the "goods" field.</summary>
  public const int GoodsFieldNumber = 7;
  private global::ShopGoods goods_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ShopGoods Goods {
    get { return goods_; }
    set {
      goods_ = value;
    }
  }

  /// <summary>Field number for the "buy_count" field.</summary>
  public const int BuyCountFieldNumber = 9;
  private uint buyCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BuyCount {
    get { return buyCount_; }
    set {
      buyCount_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BuyGoodsRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BuyGoodsRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ShopType != other.ShopType) return false;
    if (Retcode != other.Retcode) return false;
    if(!goodsList_.Equals(other.goodsList_)) return false;
    if (!object.Equals(Goods, other.Goods)) return false;
    if (BuyCount != other.BuyCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ShopType != 0) hash ^= ShopType.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    hash ^= goodsList_.GetHashCode();
    if (goods_ != null) hash ^= Goods.GetHashCode();
    if (BuyCount != 0) hash ^= BuyCount.GetHashCode();
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
    if (goods_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Goods);
    }
    if (BuyCount != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(BuyCount);
    }
    goodsList_.WriteTo(output, _repeated_goodsList_codec);
    if (Retcode != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
    }
    if (ShopType != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(ShopType);
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
    if (goods_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Goods);
    }
    if (BuyCount != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(BuyCount);
    }
    goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
    if (Retcode != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
    }
    if (ShopType != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(ShopType);
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
    if (ShopType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopType);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    size += goodsList_.CalculateSize(_repeated_goodsList_codec);
    if (goods_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Goods);
    }
    if (BuyCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuyCount);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BuyGoodsRsp other) {
    if (other == null) {
      return;
    }
    if (other.ShopType != 0) {
      ShopType = other.ShopType;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    goodsList_.Add(other.goodsList_);
    if (other.goods_ != null) {
      if (goods_ == null) {
        Goods = new global::ShopGoods();
      }
      Goods.MergeFrom(other.Goods);
    }
    if (other.BuyCount != 0) {
      BuyCount = other.BuyCount;
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
        case 58: {
          if (goods_ == null) {
            Goods = new global::ShopGoods();
          }
          input.ReadMessage(Goods);
          break;
        }
        case 72: {
          BuyCount = input.ReadUInt32();
          break;
        }
        case 82: {
          goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
          break;
        }
        case 104: {
          Retcode = input.ReadInt32();
          break;
        }
        case 120: {
          ShopType = input.ReadUInt32();
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
        case 58: {
          if (goods_ == null) {
            Goods = new global::ShopGoods();
          }
          input.ReadMessage(Goods);
          break;
        }
        case 72: {
          BuyCount = input.ReadUInt32();
          break;
        }
        case 82: {
          goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
          break;
        }
        case 104: {
          Retcode = input.ReadInt32();
          break;
        }
        case 120: {
          ShopType = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
