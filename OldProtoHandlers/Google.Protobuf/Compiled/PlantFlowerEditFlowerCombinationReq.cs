// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerEditFlowerCombinationReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PlantFlowerEditFlowerCombinationReq.proto</summary>
public static partial class PlantFlowerEditFlowerCombinationReqReflection {

  #region Descriptor
  /// <summary>File descriptor for PlantFlowerEditFlowerCombinationReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlantFlowerEditFlowerCombinationReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CilQbGFudEZsb3dlckVkaXRGbG93ZXJDb21iaW5hdGlvblJlcS5wcm90bxoa",
          "Q3VzdG9tR2FkZ2V0VHJlZUluZm8ucHJvdG8ihQEKI1BsYW50Rmxvd2VyRWRp",
          "dEZsb3dlckNvbWJpbmF0aW9uUmVxEjYKF2Zsb3dlcl9jb21iaW5hdGlvbl9p",
          "bmZvGAogASgLMhUuQ3VzdG9tR2FkZ2V0VHJlZUluZm8SEQoJZW50aXR5X2lk",
          "GA4gASgNEhMKC3NjaGVkdWxlX2lkGAkgASgNQh4KHGVtdS5ncmFzc2N1dHRl",
          "ci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CustomGadgetTreeInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PlantFlowerEditFlowerCombinationReq), global::PlantFlowerEditFlowerCombinationReq.Parser, new[]{ "FlowerCombinationInfo", "EntityId", "ScheduleId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8843
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class PlantFlowerEditFlowerCombinationReq : pb::IMessage<PlantFlowerEditFlowerCombinationReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlantFlowerEditFlowerCombinationReq> _parser = new pb::MessageParser<PlantFlowerEditFlowerCombinationReq>(() => new PlantFlowerEditFlowerCombinationReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlantFlowerEditFlowerCombinationReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlantFlowerEditFlowerCombinationReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlantFlowerEditFlowerCombinationReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlantFlowerEditFlowerCombinationReq(PlantFlowerEditFlowerCombinationReq other) : this() {
    flowerCombinationInfo_ = other.flowerCombinationInfo_ != null ? other.flowerCombinationInfo_.Clone() : null;
    entityId_ = other.entityId_;
    scheduleId_ = other.scheduleId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlantFlowerEditFlowerCombinationReq Clone() {
    return new PlantFlowerEditFlowerCombinationReq(this);
  }

  /// <summary>Field number for the "flower_combination_info" field.</summary>
  public const int FlowerCombinationInfoFieldNumber = 10;
  private global::CustomGadgetTreeInfo flowerCombinationInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CustomGadgetTreeInfo FlowerCombinationInfo {
    get { return flowerCombinationInfo_; }
    set {
      flowerCombinationInfo_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 14;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  /// <summary>Field number for the "schedule_id" field.</summary>
  public const int ScheduleIdFieldNumber = 9;
  private uint scheduleId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ScheduleId {
    get { return scheduleId_; }
    set {
      scheduleId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlantFlowerEditFlowerCombinationReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlantFlowerEditFlowerCombinationReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(FlowerCombinationInfo, other.FlowerCombinationInfo)) return false;
    if (EntityId != other.EntityId) return false;
    if (ScheduleId != other.ScheduleId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (flowerCombinationInfo_ != null) hash ^= FlowerCombinationInfo.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
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
    if (ScheduleId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ScheduleId);
    }
    if (flowerCombinationInfo_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(FlowerCombinationInfo);
    }
    if (EntityId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(EntityId);
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
    if (ScheduleId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ScheduleId);
    }
    if (flowerCombinationInfo_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(FlowerCombinationInfo);
    }
    if (EntityId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(EntityId);
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
    if (flowerCombinationInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(FlowerCombinationInfo);
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (ScheduleId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlantFlowerEditFlowerCombinationReq other) {
    if (other == null) {
      return;
    }
    if (other.flowerCombinationInfo_ != null) {
      if (flowerCombinationInfo_ == null) {
        FlowerCombinationInfo = new global::CustomGadgetTreeInfo();
      }
      FlowerCombinationInfo.MergeFrom(other.FlowerCombinationInfo);
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.ScheduleId != 0) {
      ScheduleId = other.ScheduleId;
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
        case 72: {
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 82: {
          if (flowerCombinationInfo_ == null) {
            FlowerCombinationInfo = new global::CustomGadgetTreeInfo();
          }
          input.ReadMessage(FlowerCombinationInfo);
          break;
        }
        case 112: {
          EntityId = input.ReadUInt32();
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
        case 72: {
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 82: {
          if (flowerCombinationInfo_ == null) {
            FlowerCombinationInfo = new global::CustomGadgetTreeInfo();
          }
          input.ReadMessage(FlowerCombinationInfo);
          break;
        }
        case 112: {
          EntityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
