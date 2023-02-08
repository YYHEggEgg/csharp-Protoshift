// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerRechargeDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PlayerRechargeDataNotify.proto</summary>
  public static partial class PlayerRechargeDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerRechargeDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerRechargeDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5QbGF5ZXJSZWNoYXJnZURhdGFOb3RpZnkucHJvdG8aFlByb2R1Y3RQcmlj",
            "ZVRpZXIucHJvdG8icAoYUGxheWVyUmVjaGFyZ2VEYXRhTm90aWZ5EjIKF3By",
            "b2R1Y3RfcHJpY2VfdGllcl9saXN0GAcgAygLMhEuUHJvZHVjdFByaWNlVGll",
            "chIgChhjYXJkX3Byb2R1Y3RfcmVtYWluX2RheXMYBiABKA1CDKoCCU5ld1By",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ProductPriceTierReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PlayerRechargeDataNotify), global::NewProtos.PlayerRechargeDataNotify.Parser, new[]{ "ProductPriceTierList", "CardProductRemainDays" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4127;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerRechargeDataNotify : pb::IMessage<PlayerRechargeDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerRechargeDataNotify> _parser = new pb::MessageParser<PlayerRechargeDataNotify>(() => new PlayerRechargeDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerRechargeDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PlayerRechargeDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRechargeDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRechargeDataNotify(PlayerRechargeDataNotify other) : this() {
      productPriceTierList_ = other.productPriceTierList_.Clone();
      cardProductRemainDays_ = other.cardProductRemainDays_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerRechargeDataNotify Clone() {
      return new PlayerRechargeDataNotify(this);
    }

    /// <summary>Field number for the "product_price_tier_list" field.</summary>
    public const int ProductPriceTierListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::NewProtos.ProductPriceTier> _repeated_productPriceTierList_codec
        = pb::FieldCodec.ForMessage(58, global::NewProtos.ProductPriceTier.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ProductPriceTier> productPriceTierList_ = new pbc::RepeatedField<global::NewProtos.ProductPriceTier>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ProductPriceTier> ProductPriceTierList {
      get { return productPriceTierList_; }
    }

    /// <summary>Field number for the "card_product_remain_days" field.</summary>
    public const int CardProductRemainDaysFieldNumber = 6;
    private uint cardProductRemainDays_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardProductRemainDays {
      get { return cardProductRemainDays_; }
      set {
        cardProductRemainDays_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerRechargeDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerRechargeDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!productPriceTierList_.Equals(other.productPriceTierList_)) return false;
      if (CardProductRemainDays != other.CardProductRemainDays) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= productPriceTierList_.GetHashCode();
      if (CardProductRemainDays != 0) hash ^= CardProductRemainDays.GetHashCode();
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
      if (CardProductRemainDays != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CardProductRemainDays);
      }
      productPriceTierList_.WriteTo(output, _repeated_productPriceTierList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CardProductRemainDays != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CardProductRemainDays);
      }
      productPriceTierList_.WriteTo(ref output, _repeated_productPriceTierList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += productPriceTierList_.CalculateSize(_repeated_productPriceTierList_codec);
      if (CardProductRemainDays != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardProductRemainDays);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerRechargeDataNotify other) {
      if (other == null) {
        return;
      }
      productPriceTierList_.Add(other.productPriceTierList_);
      if (other.CardProductRemainDays != 0) {
        CardProductRemainDays = other.CardProductRemainDays;
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
          case 48: {
            CardProductRemainDays = input.ReadUInt32();
            break;
          }
          case 58: {
            productPriceTierList_.AddEntriesFrom(input, _repeated_productPriceTierList_codec);
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
          case 48: {
            CardProductRemainDays = input.ReadUInt32();
            break;
          }
          case 58: {
            productPriceTierList_.AddEntriesFrom(ref input, _repeated_productPriceTierList_codec);
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
