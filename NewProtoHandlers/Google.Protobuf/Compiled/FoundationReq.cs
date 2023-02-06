// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from FoundationReq.proto</summary>
public static partial class FoundationReqReflection {

  #region Descriptor
  /// <summary>File descriptor for FoundationReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FoundationReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNGb3VuZGF0aW9uUmVxLnByb3RvGhZGb3VuZGF0aW9uT3BUeXBlLnByb3Rv",
          "InsKDUZvdW5kYXRpb25SZXESGAoQZ2FkZ2V0X2VudGl0eV9pZBgBIAEoDRIT",
          "CgtidWlsZGluZ19pZBgLIAEoDRIXCg9wb2ludF9jb25maWdfaWQYCiABKA0S",
          "IgoHb3BfdHlwZRgGIAEoDjIRLkZvdW5kYXRpb25PcFR5cGVCFgoUb3JnLnNv",
          "cmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::FoundationOpTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FoundationReq), global::FoundationReq.Parser, new[]{ "GadgetEntityId", "BuildingId", "PointConfigId", "OpType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 842;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class FoundationReq : pb::IMessage<FoundationReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<FoundationReq> _parser = new pb::MessageParser<FoundationReq>(() => new FoundationReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<FoundationReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FoundationReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FoundationReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FoundationReq(FoundationReq other) : this() {
    gadgetEntityId_ = other.gadgetEntityId_;
    buildingId_ = other.buildingId_;
    pointConfigId_ = other.pointConfigId_;
    opType_ = other.opType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FoundationReq Clone() {
    return new FoundationReq(this);
  }

  /// <summary>Field number for the "gadget_entity_id" field.</summary>
  public const int GadgetEntityIdFieldNumber = 1;
  private uint gadgetEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GadgetEntityId {
    get { return gadgetEntityId_; }
    set {
      gadgetEntityId_ = value;
    }
  }

  /// <summary>Field number for the "building_id" field.</summary>
  public const int BuildingIdFieldNumber = 11;
  private uint buildingId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BuildingId {
    get { return buildingId_; }
    set {
      buildingId_ = value;
    }
  }

  /// <summary>Field number for the "point_config_id" field.</summary>
  public const int PointConfigIdFieldNumber = 10;
  private uint pointConfigId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PointConfigId {
    get { return pointConfigId_; }
    set {
      pointConfigId_ = value;
    }
  }

  /// <summary>Field number for the "op_type" field.</summary>
  public const int OpTypeFieldNumber = 6;
  private global::FoundationOpType opType_ = global::FoundationOpType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::FoundationOpType OpType {
    get { return opType_; }
    set {
      opType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as FoundationReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(FoundationReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GadgetEntityId != other.GadgetEntityId) return false;
    if (BuildingId != other.BuildingId) return false;
    if (PointConfigId != other.PointConfigId) return false;
    if (OpType != other.OpType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
    if (BuildingId != 0) hash ^= BuildingId.GetHashCode();
    if (PointConfigId != 0) hash ^= PointConfigId.GetHashCode();
    if (OpType != global::FoundationOpType.None) hash ^= OpType.GetHashCode();
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
    if (GadgetEntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(GadgetEntityId);
    }
    if (OpType != global::FoundationOpType.None) {
      output.WriteRawTag(48);
      output.WriteEnum((int) OpType);
    }
    if (PointConfigId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(PointConfigId);
    }
    if (BuildingId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(BuildingId);
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
    if (GadgetEntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(GadgetEntityId);
    }
    if (OpType != global::FoundationOpType.None) {
      output.WriteRawTag(48);
      output.WriteEnum((int) OpType);
    }
    if (PointConfigId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(PointConfigId);
    }
    if (BuildingId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(BuildingId);
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
    if (GadgetEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
    }
    if (BuildingId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingId);
    }
    if (PointConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointConfigId);
    }
    if (OpType != global::FoundationOpType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(FoundationReq other) {
    if (other == null) {
      return;
    }
    if (other.GadgetEntityId != 0) {
      GadgetEntityId = other.GadgetEntityId;
    }
    if (other.BuildingId != 0) {
      BuildingId = other.BuildingId;
    }
    if (other.PointConfigId != 0) {
      PointConfigId = other.PointConfigId;
    }
    if (other.OpType != global::FoundationOpType.None) {
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
        case 8: {
          GadgetEntityId = input.ReadUInt32();
          break;
        }
        case 48: {
          OpType = (global::FoundationOpType) input.ReadEnum();
          break;
        }
        case 80: {
          PointConfigId = input.ReadUInt32();
          break;
        }
        case 88: {
          BuildingId = input.ReadUInt32();
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
          GadgetEntityId = input.ReadUInt32();
          break;
        }
        case 48: {
          OpType = (global::FoundationOpType) input.ReadEnum();
          break;
        }
        case 80: {
          PointConfigId = input.ReadUInt32();
          break;
        }
        case 88: {
          BuildingId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
