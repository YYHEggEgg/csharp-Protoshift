// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReliquaryUpgradeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ReliquaryUpgradeReq.proto</summary>
public static partial class ReliquaryUpgradeReqReflection {

  #region Descriptor
  /// <summary>File descriptor for ReliquaryUpgradeReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReliquaryUpgradeReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlSZWxpcXVhcnlVcGdyYWRlUmVxLnByb3RvGg9JdGVtUGFyYW0ucHJvdG8i",
          "ewoTUmVsaXF1YXJ5VXBncmFkZVJlcRIjCg9pdGVtX3BhcmFtX2xpc3QYCyAD",
          "KAsyCi5JdGVtUGFyYW0SHQoVdGFyZ2V0X3JlbGlxdWFyeV9ndWlkGAYgASgE",
          "EiAKGGZvb2RfcmVsaXF1YXJ5X2d1aWRfbGlzdBgMIAMoBEIeChxlbXUuZ3Jh",
          "c3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReliquaryUpgradeReq), global::ReliquaryUpgradeReq.Parser, new[]{ "ItemParamList", "TargetReliquaryGuid", "FoodReliquaryGuidList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 604
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class ReliquaryUpgradeReq : pb::IMessage<ReliquaryUpgradeReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReliquaryUpgradeReq> _parser = new pb::MessageParser<ReliquaryUpgradeReq>(() => new ReliquaryUpgradeReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ReliquaryUpgradeReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReliquaryUpgradeReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryUpgradeReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryUpgradeReq(ReliquaryUpgradeReq other) : this() {
    itemParamList_ = other.itemParamList_.Clone();
    targetReliquaryGuid_ = other.targetReliquaryGuid_;
    foodReliquaryGuidList_ = other.foodReliquaryGuidList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryUpgradeReq Clone() {
    return new ReliquaryUpgradeReq(this);
  }

  /// <summary>Field number for the "item_param_list" field.</summary>
  public const int ItemParamListFieldNumber = 11;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_itemParamList_codec
      = pb::FieldCodec.ForMessage(90, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> itemParamList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> ItemParamList {
    get { return itemParamList_; }
  }

  /// <summary>Field number for the "target_reliquary_guid" field.</summary>
  public const int TargetReliquaryGuidFieldNumber = 6;
  private ulong targetReliquaryGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong TargetReliquaryGuid {
    get { return targetReliquaryGuid_; }
    set {
      targetReliquaryGuid_ = value;
    }
  }

  /// <summary>Field number for the "food_reliquary_guid_list" field.</summary>
  public const int FoodReliquaryGuidListFieldNumber = 12;
  private static readonly pb::FieldCodec<ulong> _repeated_foodReliquaryGuidList_codec
      = pb::FieldCodec.ForUInt64(98);
  private readonly pbc::RepeatedField<ulong> foodReliquaryGuidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> FoodReliquaryGuidList {
    get { return foodReliquaryGuidList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ReliquaryUpgradeReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ReliquaryUpgradeReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!itemParamList_.Equals(other.itemParamList_)) return false;
    if (TargetReliquaryGuid != other.TargetReliquaryGuid) return false;
    if(!foodReliquaryGuidList_.Equals(other.foodReliquaryGuidList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= itemParamList_.GetHashCode();
    if (TargetReliquaryGuid != 0UL) hash ^= TargetReliquaryGuid.GetHashCode();
    hash ^= foodReliquaryGuidList_.GetHashCode();
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
    if (TargetReliquaryGuid != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(TargetReliquaryGuid);
    }
    itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
    foodReliquaryGuidList_.WriteTo(output, _repeated_foodReliquaryGuidList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (TargetReliquaryGuid != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(TargetReliquaryGuid);
    }
    itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
    foodReliquaryGuidList_.WriteTo(ref output, _repeated_foodReliquaryGuidList_codec);
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
    if (TargetReliquaryGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetReliquaryGuid);
    }
    size += foodReliquaryGuidList_.CalculateSize(_repeated_foodReliquaryGuidList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ReliquaryUpgradeReq other) {
    if (other == null) {
      return;
    }
    itemParamList_.Add(other.itemParamList_);
    if (other.TargetReliquaryGuid != 0UL) {
      TargetReliquaryGuid = other.TargetReliquaryGuid;
    }
    foodReliquaryGuidList_.Add(other.foodReliquaryGuidList_);
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
          TargetReliquaryGuid = input.ReadUInt64();
          break;
        }
        case 90: {
          itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
          break;
        }
        case 98:
        case 96: {
          foodReliquaryGuidList_.AddEntriesFrom(input, _repeated_foodReliquaryGuidList_codec);
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
          TargetReliquaryGuid = input.ReadUInt64();
          break;
        }
        case 90: {
          itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
          break;
        }
        case 98:
        case 96: {
          foodReliquaryGuidList_.AddEntriesFrom(ref input, _repeated_foodReliquaryGuidList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
