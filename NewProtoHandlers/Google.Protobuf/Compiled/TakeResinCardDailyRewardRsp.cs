// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeResinCardDailyRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TakeResinCardDailyRewardRsp.proto</summary>
public static partial class TakeResinCardDailyRewardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for TakeResinCardDailyRewardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TakeResinCardDailyRewardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFUYWtlUmVzaW5DYXJkRGFpbHlSZXdhcmRSc3AucHJvdG8aD0l0ZW1QYXJh",
          "bS5wcm90byJnChtUYWtlUmVzaW5DYXJkRGFpbHlSZXdhcmRSc3ASDwoHcmV0",
          "Y29kZRgEIAEoBRIcCghpdGVtX3ZlYxgPIAMoCzIKLkl0ZW1QYXJhbRIZChFw",
          "cm9kdWN0X2NvbmZpZ19pZBgNIAEoDUIWChRvcmcuc29yYXBvaW50YS5wcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TakeResinCardDailyRewardRsp), global::TakeResinCardDailyRewardRsp.Parser, new[]{ "Retcode", "ItemVec", "ProductConfigId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4112;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class TakeResinCardDailyRewardRsp : pb::IMessage<TakeResinCardDailyRewardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TakeResinCardDailyRewardRsp> _parser = new pb::MessageParser<TakeResinCardDailyRewardRsp>(() => new TakeResinCardDailyRewardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TakeResinCardDailyRewardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TakeResinCardDailyRewardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeResinCardDailyRewardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeResinCardDailyRewardRsp(TakeResinCardDailyRewardRsp other) : this() {
    retcode_ = other.retcode_;
    itemVec_ = other.itemVec_.Clone();
    productConfigId_ = other.productConfigId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeResinCardDailyRewardRsp Clone() {
    return new TakeResinCardDailyRewardRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 4;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "item_vec" field.</summary>
  public const int ItemVecFieldNumber = 15;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_itemVec_codec
      = pb::FieldCodec.ForMessage(122, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> itemVec_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> ItemVec {
    get { return itemVec_; }
  }

  /// <summary>Field number for the "product_config_id" field.</summary>
  public const int ProductConfigIdFieldNumber = 13;
  private uint productConfigId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ProductConfigId {
    get { return productConfigId_; }
    set {
      productConfigId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TakeResinCardDailyRewardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TakeResinCardDailyRewardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if(!itemVec_.Equals(other.itemVec_)) return false;
    if (ProductConfigId != other.ProductConfigId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    hash ^= itemVec_.GetHashCode();
    if (ProductConfigId != 0) hash ^= ProductConfigId.GetHashCode();
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
      output.WriteRawTag(32);
      output.WriteInt32(Retcode);
    }
    if (ProductConfigId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ProductConfigId);
    }
    itemVec_.WriteTo(output, _repeated_itemVec_codec);
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
      output.WriteRawTag(32);
      output.WriteInt32(Retcode);
    }
    if (ProductConfigId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ProductConfigId);
    }
    itemVec_.WriteTo(ref output, _repeated_itemVec_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    size += itemVec_.CalculateSize(_repeated_itemVec_codec);
    if (ProductConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProductConfigId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TakeResinCardDailyRewardRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    itemVec_.Add(other.itemVec_);
    if (other.ProductConfigId != 0) {
      ProductConfigId = other.ProductConfigId;
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
        case 32: {
          Retcode = input.ReadInt32();
          break;
        }
        case 104: {
          ProductConfigId = input.ReadUInt32();
          break;
        }
        case 122: {
          itemVec_.AddEntriesFrom(input, _repeated_itemVec_codec);
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
        case 32: {
          Retcode = input.ReadInt32();
          break;
        }
        case 104: {
          ProductConfigId = input.ReadUInt32();
          break;
        }
        case 122: {
          itemVec_.AddEntriesFrom(ref input, _repeated_itemVec_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
