// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketStoreInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from VintageMarketStoreInfo.proto</summary>
public static partial class VintageMarketStoreInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for VintageMarketStoreInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static VintageMarketStoreInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxWaW50YWdlTWFya2V0U3RvcmVJbmZvLnByb3RvIo8BChZWaW50YWdlTWFy",
          "a2V0U3RvcmVJbmZvEhAKCHN0b3JlX2lkGA0gASgNEhsKE1VuazMzMDBfSE5C",
          "R0hDQ0VOSUEYASADKA0SFQoNc3RyYXRlZ3lfbGlzdBgKIAMoDRIbChNVbmsz",
          "MzAwX09ETExBTktPRU5EGAcgAygNEhIKCnNsb3RfY291bnQYBSABKA1CFgoU",
          "b3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::VintageMarketStoreInfo), global::VintageMarketStoreInfo.Parser, new[]{ "StoreId", "Unk3300HNBGHCCENIA", "StrategyList", "Unk3300ODLLANKOEND", "SlotCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class VintageMarketStoreInfo : pb::IMessage<VintageMarketStoreInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<VintageMarketStoreInfo> _parser = new pb::MessageParser<VintageMarketStoreInfo>(() => new VintageMarketStoreInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<VintageMarketStoreInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::VintageMarketStoreInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageMarketStoreInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageMarketStoreInfo(VintageMarketStoreInfo other) : this() {
    storeId_ = other.storeId_;
    unk3300HNBGHCCENIA_ = other.unk3300HNBGHCCENIA_.Clone();
    strategyList_ = other.strategyList_.Clone();
    unk3300ODLLANKOEND_ = other.unk3300ODLLANKOEND_.Clone();
    slotCount_ = other.slotCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageMarketStoreInfo Clone() {
    return new VintageMarketStoreInfo(this);
  }

  /// <summary>Field number for the "store_id" field.</summary>
  public const int StoreIdFieldNumber = 13;
  private uint storeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StoreId {
    get { return storeId_; }
    set {
      storeId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_HNBGHCCENIA" field.</summary>
  public const int Unk3300HNBGHCCENIAFieldNumber = 1;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300HNBGHCCENIA_codec
      = pb::FieldCodec.ForUInt32(10);
  private readonly pbc::RepeatedField<uint> unk3300HNBGHCCENIA_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300HNBGHCCENIA {
    get { return unk3300HNBGHCCENIA_; }
  }

  /// <summary>Field number for the "strategy_list" field.</summary>
  public const int StrategyListFieldNumber = 10;
  private static readonly pb::FieldCodec<uint> _repeated_strategyList_codec
      = pb::FieldCodec.ForUInt32(82);
  private readonly pbc::RepeatedField<uint> strategyList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> StrategyList {
    get { return strategyList_; }
  }

  /// <summary>Field number for the "Unk3300_ODLLANKOEND" field.</summary>
  public const int Unk3300ODLLANKOENDFieldNumber = 7;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300ODLLANKOEND_codec
      = pb::FieldCodec.ForUInt32(58);
  private readonly pbc::RepeatedField<uint> unk3300ODLLANKOEND_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300ODLLANKOEND {
    get { return unk3300ODLLANKOEND_; }
  }

  /// <summary>Field number for the "slot_count" field.</summary>
  public const int SlotCountFieldNumber = 5;
  private uint slotCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SlotCount {
    get { return slotCount_; }
    set {
      slotCount_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as VintageMarketStoreInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(VintageMarketStoreInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StoreId != other.StoreId) return false;
    if(!unk3300HNBGHCCENIA_.Equals(other.unk3300HNBGHCCENIA_)) return false;
    if(!strategyList_.Equals(other.strategyList_)) return false;
    if(!unk3300ODLLANKOEND_.Equals(other.unk3300ODLLANKOEND_)) return false;
    if (SlotCount != other.SlotCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StoreId != 0) hash ^= StoreId.GetHashCode();
    hash ^= unk3300HNBGHCCENIA_.GetHashCode();
    hash ^= strategyList_.GetHashCode();
    hash ^= unk3300ODLLANKOEND_.GetHashCode();
    if (SlotCount != 0) hash ^= SlotCount.GetHashCode();
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
    unk3300HNBGHCCENIA_.WriteTo(output, _repeated_unk3300HNBGHCCENIA_codec);
    if (SlotCount != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(SlotCount);
    }
    unk3300ODLLANKOEND_.WriteTo(output, _repeated_unk3300ODLLANKOEND_codec);
    strategyList_.WriteTo(output, _repeated_strategyList_codec);
    if (StoreId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(StoreId);
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
    unk3300HNBGHCCENIA_.WriteTo(ref output, _repeated_unk3300HNBGHCCENIA_codec);
    if (SlotCount != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(SlotCount);
    }
    unk3300ODLLANKOEND_.WriteTo(ref output, _repeated_unk3300ODLLANKOEND_codec);
    strategyList_.WriteTo(ref output, _repeated_strategyList_codec);
    if (StoreId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(StoreId);
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
    if (StoreId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreId);
    }
    size += unk3300HNBGHCCENIA_.CalculateSize(_repeated_unk3300HNBGHCCENIA_codec);
    size += strategyList_.CalculateSize(_repeated_strategyList_codec);
    size += unk3300ODLLANKOEND_.CalculateSize(_repeated_unk3300ODLLANKOEND_codec);
    if (SlotCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SlotCount);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(VintageMarketStoreInfo other) {
    if (other == null) {
      return;
    }
    if (other.StoreId != 0) {
      StoreId = other.StoreId;
    }
    unk3300HNBGHCCENIA_.Add(other.unk3300HNBGHCCENIA_);
    strategyList_.Add(other.strategyList_);
    unk3300ODLLANKOEND_.Add(other.unk3300ODLLANKOEND_);
    if (other.SlotCount != 0) {
      SlotCount = other.SlotCount;
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
        case 10:
        case 8: {
          unk3300HNBGHCCENIA_.AddEntriesFrom(input, _repeated_unk3300HNBGHCCENIA_codec);
          break;
        }
        case 40: {
          SlotCount = input.ReadUInt32();
          break;
        }
        case 58:
        case 56: {
          unk3300ODLLANKOEND_.AddEntriesFrom(input, _repeated_unk3300ODLLANKOEND_codec);
          break;
        }
        case 82:
        case 80: {
          strategyList_.AddEntriesFrom(input, _repeated_strategyList_codec);
          break;
        }
        case 104: {
          StoreId = input.ReadUInt32();
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
        case 10:
        case 8: {
          unk3300HNBGHCCENIA_.AddEntriesFrom(ref input, _repeated_unk3300HNBGHCCENIA_codec);
          break;
        }
        case 40: {
          SlotCount = input.ReadUInt32();
          break;
        }
        case 58:
        case 56: {
          unk3300ODLLANKOEND_.AddEntriesFrom(ref input, _repeated_unk3300ODLLANKOEND_codec);
          break;
        }
        case 82:
        case 80: {
          strategyList_.AddEntriesFrom(ref input, _repeated_strategyList_codec);
          break;
        }
        case 104: {
          StoreId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
