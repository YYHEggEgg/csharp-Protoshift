// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeLimitedShopBuyGoodsRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HomeLimitedShopBuyGoodsRsp.proto</summary>
public static partial class HomeLimitedShopBuyGoodsRspReflection {

  #region Descriptor
  /// <summary>File descriptor for HomeLimitedShopBuyGoodsRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HomeLimitedShopBuyGoodsRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBIb21lTGltaXRlZFNob3BCdXlHb29kc1JzcC5wcm90bxoaSG9tZUxpbWl0",
          "ZWRTaG9wR29vZHMucHJvdG8ikQEKGkhvbWVMaW1pdGVkU2hvcEJ1eUdvb2Rz",
          "UnNwEikKCmdvb2RzX2xpc3QYAyADKAsyFS5Ib21lTGltaXRlZFNob3BHb29k",
          "cxIRCglidXlfY291bnQYCiABKA0SDwoHcmV0Y29kZRgNIAEoBRIkCgVnb29k",
          "cxgJIAEoCzIVLkhvbWVMaW1pdGVkU2hvcEdvb2RzQhYKFG9yZy5zb3JhcG9p",
          "bnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HomeLimitedShopGoodsReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HomeLimitedShopBuyGoodsRsp), global::HomeLimitedShopBuyGoodsRsp.Parser, new[]{ "GoodsList", "BuyCount", "Retcode", "Goods" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4630;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class HomeLimitedShopBuyGoodsRsp : pb::IMessage<HomeLimitedShopBuyGoodsRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HomeLimitedShopBuyGoodsRsp> _parser = new pb::MessageParser<HomeLimitedShopBuyGoodsRsp>(() => new HomeLimitedShopBuyGoodsRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HomeLimitedShopBuyGoodsRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HomeLimitedShopBuyGoodsRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeLimitedShopBuyGoodsRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeLimitedShopBuyGoodsRsp(HomeLimitedShopBuyGoodsRsp other) : this() {
    goodsList_ = other.goodsList_.Clone();
    buyCount_ = other.buyCount_;
    retcode_ = other.retcode_;
    goods_ = other.goods_ != null ? other.goods_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeLimitedShopBuyGoodsRsp Clone() {
    return new HomeLimitedShopBuyGoodsRsp(this);
  }

  /// <summary>Field number for the "goods_list" field.</summary>
  public const int GoodsListFieldNumber = 3;
  private static readonly pb::FieldCodec<global::HomeLimitedShopGoods> _repeated_goodsList_codec
      = pb::FieldCodec.ForMessage(26, global::HomeLimitedShopGoods.Parser);
  private readonly pbc::RepeatedField<global::HomeLimitedShopGoods> goodsList_ = new pbc::RepeatedField<global::HomeLimitedShopGoods>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::HomeLimitedShopGoods> GoodsList {
    get { return goodsList_; }
  }

  /// <summary>Field number for the "buy_count" field.</summary>
  public const int BuyCountFieldNumber = 10;
  private uint buyCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BuyCount {
    get { return buyCount_; }
    set {
      buyCount_ = value;
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

  /// <summary>Field number for the "goods" field.</summary>
  public const int GoodsFieldNumber = 9;
  private global::HomeLimitedShopGoods goods_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::HomeLimitedShopGoods Goods {
    get { return goods_; }
    set {
      goods_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HomeLimitedShopBuyGoodsRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HomeLimitedShopBuyGoodsRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!goodsList_.Equals(other.goodsList_)) return false;
    if (BuyCount != other.BuyCount) return false;
    if (Retcode != other.Retcode) return false;
    if (!object.Equals(Goods, other.Goods)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= goodsList_.GetHashCode();
    if (BuyCount != 0) hash ^= BuyCount.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (goods_ != null) hash ^= Goods.GetHashCode();
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
    goodsList_.WriteTo(output, _repeated_goodsList_codec);
    if (goods_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(Goods);
    }
    if (BuyCount != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(BuyCount);
    }
    if (Retcode != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
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
    goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
    if (goods_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(Goods);
    }
    if (BuyCount != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(BuyCount);
    }
    if (Retcode != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
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
    if (BuyCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuyCount);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (goods_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Goods);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HomeLimitedShopBuyGoodsRsp other) {
    if (other == null) {
      return;
    }
    goodsList_.Add(other.goodsList_);
    if (other.BuyCount != 0) {
      BuyCount = other.BuyCount;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.goods_ != null) {
      if (goods_ == null) {
        Goods = new global::HomeLimitedShopGoods();
      }
      Goods.MergeFrom(other.Goods);
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
        case 26: {
          goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
          break;
        }
        case 74: {
          if (goods_ == null) {
            Goods = new global::HomeLimitedShopGoods();
          }
          input.ReadMessage(Goods);
          break;
        }
        case 80: {
          BuyCount = input.ReadUInt32();
          break;
        }
        case 104: {
          Retcode = input.ReadInt32();
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
        case 26: {
          goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
          break;
        }
        case 74: {
          if (goods_ == null) {
            Goods = new global::HomeLimitedShopGoods();
          }
          input.ReadMessage(Goods);
          break;
        }
        case 80: {
          BuyCount = input.ReadUInt32();
          break;
        }
        case 104: {
          Retcode = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
