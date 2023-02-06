// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MiracleRingDeliverItemReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MiracleRingDeliverItemReq.proto</summary>
public static partial class MiracleRingDeliverItemReqReflection {

  #region Descriptor
  /// <summary>File descriptor for MiracleRingDeliverItemReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MiracleRingDeliverItemReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9NaXJhY2xlUmluZ0RlbGl2ZXJJdGVtUmVxLnByb3RvGhFJbnRlck9wVHlw",
          "ZS5wcm90bxoPSXRlbVBhcmFtLnByb3RvIqsBChlNaXJhY2xlUmluZ0RlbGl2",
          "ZXJJdGVtUmVxEiMKD2l0ZW1fcGFyYW1fbGlzdBgDIAMoCzIKLkl0ZW1QYXJh",
          "bRIYChBnYWRnZXRfZW50aXR5X2lkGAYgASgNEhEKCWdhZGdldF9pZBgIIAEo",
          "DRIdChVmb29kX3dlYXBvbl9ndWlkX2xpc3QYDSADKAQSHQoHb3BfdHlwZRgP",
          "IAEoDjIMLkludGVyT3BUeXBlQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZw",
          "cm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::InterOpTypeReflection.Descriptor, global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MiracleRingDeliverItemReq), global::MiracleRingDeliverItemReq.Parser, new[]{ "ItemParamList", "GadgetEntityId", "GadgetId", "FoodWeaponGuidList", "OpType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 5244;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class MiracleRingDeliverItemReq : pb::IMessage<MiracleRingDeliverItemReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MiracleRingDeliverItemReq> _parser = new pb::MessageParser<MiracleRingDeliverItemReq>(() => new MiracleRingDeliverItemReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MiracleRingDeliverItemReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MiracleRingDeliverItemReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MiracleRingDeliverItemReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MiracleRingDeliverItemReq(MiracleRingDeliverItemReq other) : this() {
    itemParamList_ = other.itemParamList_.Clone();
    gadgetEntityId_ = other.gadgetEntityId_;
    gadgetId_ = other.gadgetId_;
    foodWeaponGuidList_ = other.foodWeaponGuidList_.Clone();
    opType_ = other.opType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MiracleRingDeliverItemReq Clone() {
    return new MiracleRingDeliverItemReq(this);
  }

  /// <summary>Field number for the "item_param_list" field.</summary>
  public const int ItemParamListFieldNumber = 3;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_itemParamList_codec
      = pb::FieldCodec.ForMessage(26, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> itemParamList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> ItemParamList {
    get { return itemParamList_; }
  }

  /// <summary>Field number for the "gadget_entity_id" field.</summary>
  public const int GadgetEntityIdFieldNumber = 6;
  private uint gadgetEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GadgetEntityId {
    get { return gadgetEntityId_; }
    set {
      gadgetEntityId_ = value;
    }
  }

  /// <summary>Field number for the "gadget_id" field.</summary>
  public const int GadgetIdFieldNumber = 8;
  private uint gadgetId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GadgetId {
    get { return gadgetId_; }
    set {
      gadgetId_ = value;
    }
  }

  /// <summary>Field number for the "food_weapon_guid_list" field.</summary>
  public const int FoodWeaponGuidListFieldNumber = 13;
  private static readonly pb::FieldCodec<ulong> _repeated_foodWeaponGuidList_codec
      = pb::FieldCodec.ForUInt64(106);
  private readonly pbc::RepeatedField<ulong> foodWeaponGuidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> FoodWeaponGuidList {
    get { return foodWeaponGuidList_; }
  }

  /// <summary>Field number for the "op_type" field.</summary>
  public const int OpTypeFieldNumber = 15;
  private global::InterOpType opType_ = global::InterOpType.Finish;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::InterOpType OpType {
    get { return opType_; }
    set {
      opType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MiracleRingDeliverItemReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MiracleRingDeliverItemReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!itemParamList_.Equals(other.itemParamList_)) return false;
    if (GadgetEntityId != other.GadgetEntityId) return false;
    if (GadgetId != other.GadgetId) return false;
    if(!foodWeaponGuidList_.Equals(other.foodWeaponGuidList_)) return false;
    if (OpType != other.OpType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= itemParamList_.GetHashCode();
    if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
    if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
    hash ^= foodWeaponGuidList_.GetHashCode();
    if (OpType != global::InterOpType.Finish) hash ^= OpType.GetHashCode();
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
    itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
    if (GadgetEntityId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GadgetEntityId);
    }
    if (GadgetId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(GadgetId);
    }
    foodWeaponGuidList_.WriteTo(output, _repeated_foodWeaponGuidList_codec);
    if (OpType != global::InterOpType.Finish) {
      output.WriteRawTag(120);
      output.WriteEnum((int) OpType);
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
    itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
    if (GadgetEntityId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GadgetEntityId);
    }
    if (GadgetId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(GadgetId);
    }
    foodWeaponGuidList_.WriteTo(ref output, _repeated_foodWeaponGuidList_codec);
    if (OpType != global::InterOpType.Finish) {
      output.WriteRawTag(120);
      output.WriteEnum((int) OpType);
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
    size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
    if (GadgetEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
    }
    if (GadgetId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
    }
    size += foodWeaponGuidList_.CalculateSize(_repeated_foodWeaponGuidList_codec);
    if (OpType != global::InterOpType.Finish) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MiracleRingDeliverItemReq other) {
    if (other == null) {
      return;
    }
    itemParamList_.Add(other.itemParamList_);
    if (other.GadgetEntityId != 0) {
      GadgetEntityId = other.GadgetEntityId;
    }
    if (other.GadgetId != 0) {
      GadgetId = other.GadgetId;
    }
    foodWeaponGuidList_.Add(other.foodWeaponGuidList_);
    if (other.OpType != global::InterOpType.Finish) {
      OpType = other.OpType;
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
          itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
          break;
        }
        case 48: {
          GadgetEntityId = input.ReadUInt32();
          break;
        }
        case 64: {
          GadgetId = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          foodWeaponGuidList_.AddEntriesFrom(input, _repeated_foodWeaponGuidList_codec);
          break;
        }
        case 120: {
          OpType = (global::InterOpType) input.ReadEnum();
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
          itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
          break;
        }
        case 48: {
          GadgetEntityId = input.ReadUInt32();
          break;
        }
        case 64: {
          GadgetId = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          foodWeaponGuidList_.AddEntriesFrom(ref input, _repeated_foodWeaponGuidList_codec);
          break;
        }
        case 120: {
          OpType = (global::InterOpType) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
