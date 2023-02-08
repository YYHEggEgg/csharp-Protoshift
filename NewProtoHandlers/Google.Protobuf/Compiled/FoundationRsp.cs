// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from FoundationRsp.proto</summary>
  public static partial class FoundationRspReflection {

    #region Descriptor
    /// <summary>File descriptor for FoundationRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoundationRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNGb3VuZGF0aW9uUnNwLnByb3RvGhZGb3VuZGF0aW9uT3BUeXBlLnByb3Rv",
            "IowBCg1Gb3VuZGF0aW9uUnNwEg8KB3JldGNvZGUYDyABKAUSEwoLYnVpbGRp",
            "bmdfaWQYCiABKA0SIgoHb3BfdHlwZRgOIAEoDjIRLkZvdW5kYXRpb25PcFR5",
            "cGUSGAoQZ2FkZ2V0X2VudGl0eV9pZBgCIAEoDRIXCg9wb2ludF9jb25maWdf",
            "aWQYBiABKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.FoundationOpTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.FoundationRsp), global::NewProtos.FoundationRsp.Parser, new[]{ "Retcode", "BuildingId", "OpType", "GadgetEntityId", "PointConfigId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 890;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class FoundationRsp : pb::IMessage<FoundationRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FoundationRsp> _parser = new pb::MessageParser<FoundationRsp>(() => new FoundationRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FoundationRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.FoundationRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationRsp(FoundationRsp other) : this() {
      retcode_ = other.retcode_;
      buildingId_ = other.buildingId_;
      opType_ = other.opType_;
      gadgetEntityId_ = other.gadgetEntityId_;
      pointConfigId_ = other.pointConfigId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationRsp Clone() {
      return new FoundationRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "building_id" field.</summary>
    public const int BuildingIdFieldNumber = 10;
    private uint buildingId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuildingId {
      get { return buildingId_; }
      set {
        buildingId_ = value;
      }
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 14;
    private global::NewProtos.FoundationOpType opType_ = global::NewProtos.FoundationOpType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.FoundationOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 2;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "point_config_id" field.</summary>
    public const int PointConfigIdFieldNumber = 6;
    private uint pointConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointConfigId {
      get { return pointConfigId_; }
      set {
        pointConfigId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FoundationRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FoundationRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (BuildingId != other.BuildingId) return false;
      if (OpType != other.OpType) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      if (PointConfigId != other.PointConfigId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (BuildingId != 0) hash ^= BuildingId.GetHashCode();
      if (OpType != global::NewProtos.FoundationOpType.None) hash ^= OpType.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
      if (PointConfigId != 0) hash ^= PointConfigId.GetHashCode();
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
        output.WriteRawTag(16);
        output.WriteUInt32(GadgetEntityId);
      }
      if (PointConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PointConfigId);
      }
      if (BuildingId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BuildingId);
      }
      if (OpType != global::NewProtos.FoundationOpType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) OpType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      if (GadgetEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GadgetEntityId);
      }
      if (PointConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PointConfigId);
      }
      if (BuildingId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BuildingId);
      }
      if (OpType != global::NewProtos.FoundationOpType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) OpType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (BuildingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingId);
      }
      if (OpType != global::NewProtos.FoundationOpType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (PointConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointConfigId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FoundationRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.BuildingId != 0) {
        BuildingId = other.BuildingId;
      }
      if (other.OpType != global::NewProtos.FoundationOpType.None) {
        OpType = other.OpType;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
      }
      if (other.PointConfigId != 0) {
        PointConfigId = other.PointConfigId;
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
          case 16: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            PointConfigId = input.ReadUInt32();
            break;
          }
          case 80: {
            BuildingId = input.ReadUInt32();
            break;
          }
          case 112: {
            OpType = (global::NewProtos.FoundationOpType) input.ReadEnum();
            break;
          }
          case 120: {
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
          case 16: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            PointConfigId = input.ReadUInt32();
            break;
          }
          case 80: {
            BuildingId = input.ReadUInt32();
            break;
          }
          case 112: {
            OpType = (global::NewProtos.FoundationOpType) input.ReadEnum();
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
