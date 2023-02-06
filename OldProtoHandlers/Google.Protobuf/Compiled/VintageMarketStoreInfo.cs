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
          "ChxWaW50YWdlTWFya2V0U3RvcmVJbmZvLnByb3RvIogBChZWaW50YWdlTWFy",
          "a2V0U3RvcmVJbmZvEhUKDWN1cl9hdHRyX2xpc3QYBSADKA0SGgoSbmV4dF9h",
          "aW1fYXR0cl9saXN0GA4gAygNEhUKDXN0cmF0ZWd5X2xpc3QYAiADKA0SEgoK",
          "c2xvdF9jb3VudBgDIAEoDRIQCghzdG9yZV9pZBgKIAEoDUIeChxlbXUuZ3Jh",
          "c3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::VintageMarketStoreInfo), global::VintageMarketStoreInfo.Parser, new[]{ "CurAttrList", "NextAimAttrList", "StrategyList", "SlotCount", "StoreId" }, null, null, null, null)
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
    curAttrList_ = other.curAttrList_.Clone();
    nextAimAttrList_ = other.nextAimAttrList_.Clone();
    strategyList_ = other.strategyList_.Clone();
    slotCount_ = other.slotCount_;
    storeId_ = other.storeId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageMarketStoreInfo Clone() {
    return new VintageMarketStoreInfo(this);
  }

  /// <summary>Field number for the "cur_attr_list" field.</summary>
  public const int CurAttrListFieldNumber = 5;
  private static readonly pb::FieldCodec<uint> _repeated_curAttrList_codec
      = pb::FieldCodec.ForUInt32(42);
  private readonly pbc::RepeatedField<uint> curAttrList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> CurAttrList {
    get { return curAttrList_; }
  }

  /// <summary>Field number for the "next_aim_attr_list" field.</summary>
  public const int NextAimAttrListFieldNumber = 14;
  private static readonly pb::FieldCodec<uint> _repeated_nextAimAttrList_codec
      = pb::FieldCodec.ForUInt32(114);
  private readonly pbc::RepeatedField<uint> nextAimAttrList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> NextAimAttrList {
    get { return nextAimAttrList_; }
  }

  /// <summary>Field number for the "strategy_list" field.</summary>
  public const int StrategyListFieldNumber = 2;
  private static readonly pb::FieldCodec<uint> _repeated_strategyList_codec
      = pb::FieldCodec.ForUInt32(18);
  private readonly pbc::RepeatedField<uint> strategyList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> StrategyList {
    get { return strategyList_; }
  }

  /// <summary>Field number for the "slot_count" field.</summary>
  public const int SlotCountFieldNumber = 3;
  private uint slotCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SlotCount {
    get { return slotCount_; }
    set {
      slotCount_ = value;
    }
  }

  /// <summary>Field number for the "store_id" field.</summary>
  public const int StoreIdFieldNumber = 10;
  private uint storeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StoreId {
    get { return storeId_; }
    set {
      storeId_ = value;
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
    if(!curAttrList_.Equals(other.curAttrList_)) return false;
    if(!nextAimAttrList_.Equals(other.nextAimAttrList_)) return false;
    if(!strategyList_.Equals(other.strategyList_)) return false;
    if (SlotCount != other.SlotCount) return false;
    if (StoreId != other.StoreId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= curAttrList_.GetHashCode();
    hash ^= nextAimAttrList_.GetHashCode();
    hash ^= strategyList_.GetHashCode();
    if (SlotCount != 0) hash ^= SlotCount.GetHashCode();
    if (StoreId != 0) hash ^= StoreId.GetHashCode();
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
    strategyList_.WriteTo(output, _repeated_strategyList_codec);
    if (SlotCount != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SlotCount);
    }
    curAttrList_.WriteTo(output, _repeated_curAttrList_codec);
    if (StoreId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StoreId);
    }
    nextAimAttrList_.WriteTo(output, _repeated_nextAimAttrList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    strategyList_.WriteTo(ref output, _repeated_strategyList_codec);
    if (SlotCount != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SlotCount);
    }
    curAttrList_.WriteTo(ref output, _repeated_curAttrList_codec);
    if (StoreId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StoreId);
    }
    nextAimAttrList_.WriteTo(ref output, _repeated_nextAimAttrList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += curAttrList_.CalculateSize(_repeated_curAttrList_codec);
    size += nextAimAttrList_.CalculateSize(_repeated_nextAimAttrList_codec);
    size += strategyList_.CalculateSize(_repeated_strategyList_codec);
    if (SlotCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SlotCount);
    }
    if (StoreId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreId);
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
    curAttrList_.Add(other.curAttrList_);
    nextAimAttrList_.Add(other.nextAimAttrList_);
    strategyList_.Add(other.strategyList_);
    if (other.SlotCount != 0) {
      SlotCount = other.SlotCount;
    }
    if (other.StoreId != 0) {
      StoreId = other.StoreId;
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
        case 18:
        case 16: {
          strategyList_.AddEntriesFrom(input, _repeated_strategyList_codec);
          break;
        }
        case 24: {
          SlotCount = input.ReadUInt32();
          break;
        }
        case 42:
        case 40: {
          curAttrList_.AddEntriesFrom(input, _repeated_curAttrList_codec);
          break;
        }
        case 80: {
          StoreId = input.ReadUInt32();
          break;
        }
        case 114:
        case 112: {
          nextAimAttrList_.AddEntriesFrom(input, _repeated_nextAimAttrList_codec);
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
        case 18:
        case 16: {
          strategyList_.AddEntriesFrom(ref input, _repeated_strategyList_codec);
          break;
        }
        case 24: {
          SlotCount = input.ReadUInt32();
          break;
        }
        case 42:
        case 40: {
          curAttrList_.AddEntriesFrom(ref input, _repeated_curAttrList_codec);
          break;
        }
        case 80: {
          StoreId = input.ReadUInt32();
          break;
        }
        case 114:
        case 112: {
          nextAimAttrList_.AddEntriesFrom(ref input, _repeated_nextAimAttrList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
