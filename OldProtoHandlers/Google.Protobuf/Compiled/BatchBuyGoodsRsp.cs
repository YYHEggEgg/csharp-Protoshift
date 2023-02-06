// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BatchBuyGoodsRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BatchBuyGoodsRsp.proto</summary>
public static partial class BatchBuyGoodsRspReflection {

  #region Descriptor
  /// <summary>File descriptor for BatchBuyGoodsRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BatchBuyGoodsRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZCYXRjaEJ1eUdvb2RzUnNwLnByb3RvGhNCdXlHb29kc1BhcmFtLnByb3Rv",
          "Gg9TaG9wR29vZHMucHJvdG8ifgoQQmF0Y2hCdXlHb29kc1JzcBIeCgpnb29k",
          "c19saXN0GAkgAygLMgouU2hvcEdvb2RzEg8KB3JldGNvZGUYASABKAUSJgoO",
          "YnV5X2dvb2RzX2xpc3QYBSADKAsyDi5CdXlHb29kc1BhcmFtEhEKCXNob3Bf",
          "dHlwZRgOIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZw",
          "cm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BuyGoodsParamReflection.Descriptor, global::ShopGoodsReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BatchBuyGoodsRsp), global::BatchBuyGoodsRsp.Parser, new[]{ "GoodsList", "Retcode", "BuyGoodsList", "ShopType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BatchBuyGoodsRsp : pb::IMessage<BatchBuyGoodsRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BatchBuyGoodsRsp> _parser = new pb::MessageParser<BatchBuyGoodsRsp>(() => new BatchBuyGoodsRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BatchBuyGoodsRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BatchBuyGoodsRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BatchBuyGoodsRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BatchBuyGoodsRsp(BatchBuyGoodsRsp other) : this() {
    goodsList_ = other.goodsList_.Clone();
    retcode_ = other.retcode_;
    buyGoodsList_ = other.buyGoodsList_.Clone();
    shopType_ = other.shopType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BatchBuyGoodsRsp Clone() {
    return new BatchBuyGoodsRsp(this);
  }

  /// <summary>Field number for the "goods_list" field.</summary>
  public const int GoodsListFieldNumber = 9;
  private static readonly pb::FieldCodec<global::ShopGoods> _repeated_goodsList_codec
      = pb::FieldCodec.ForMessage(74, global::ShopGoods.Parser);
  private readonly pbc::RepeatedField<global::ShopGoods> goodsList_ = new pbc::RepeatedField<global::ShopGoods>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ShopGoods> GoodsList {
    get { return goodsList_; }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 1;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "buy_goods_list" field.</summary>
  public const int BuyGoodsListFieldNumber = 5;
  private static readonly pb::FieldCodec<global::BuyGoodsParam> _repeated_buyGoodsList_codec
      = pb::FieldCodec.ForMessage(42, global::BuyGoodsParam.Parser);
  private readonly pbc::RepeatedField<global::BuyGoodsParam> buyGoodsList_ = new pbc::RepeatedField<global::BuyGoodsParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::BuyGoodsParam> BuyGoodsList {
    get { return buyGoodsList_; }
  }

  /// <summary>Field number for the "shop_type" field.</summary>
  public const int ShopTypeFieldNumber = 14;
  private uint shopType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ShopType {
    get { return shopType_; }
    set {
      shopType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BatchBuyGoodsRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BatchBuyGoodsRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!goodsList_.Equals(other.goodsList_)) return false;
    if (Retcode != other.Retcode) return false;
    if(!buyGoodsList_.Equals(other.buyGoodsList_)) return false;
    if (ShopType != other.ShopType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= goodsList_.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    hash ^= buyGoodsList_.GetHashCode();
    if (ShopType != 0) hash ^= ShopType.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Retcode);
    }
    buyGoodsList_.WriteTo(output, _repeated_buyGoodsList_codec);
    goodsList_.WriteTo(output, _repeated_goodsList_codec);
    if (ShopType != 0) {
      output.WriteRawTag(112);
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
    if (Retcode != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Retcode);
    }
    buyGoodsList_.WriteTo(ref output, _repeated_buyGoodsList_codec);
    goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
    if (ShopType != 0) {
      output.WriteRawTag(112);
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
    size += goodsList_.CalculateSize(_repeated_goodsList_codec);
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    size += buyGoodsList_.CalculateSize(_repeated_buyGoodsList_codec);
    if (ShopType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BatchBuyGoodsRsp other) {
    if (other == null) {
      return;
    }
    goodsList_.Add(other.goodsList_);
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    buyGoodsList_.Add(other.buyGoodsList_);
    if (other.ShopType != 0) {
      ShopType = other.ShopType;
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
          Retcode = input.ReadInt32();
          break;
        }
        case 42: {
          buyGoodsList_.AddEntriesFrom(input, _repeated_buyGoodsList_codec);
          break;
        }
        case 74: {
          goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
          break;
        }
        case 112: {
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
        case 8: {
          Retcode = input.ReadInt32();
          break;
        }
        case 42: {
          buyGoodsList_.AddEntriesFrom(ref input, _repeated_buyGoodsList_codec);
          break;
        }
        case 74: {
          goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
          break;
        }
        case 112: {
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
