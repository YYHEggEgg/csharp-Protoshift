// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TriggerCreateGadgetToEquipPartNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from TriggerCreateGadgetToEquipPartNotify.proto</summary>
  public static partial class TriggerCreateGadgetToEquipPartNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TriggerCreateGadgetToEquipPartNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TriggerCreateGadgetToEquipPartNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipUcmlnZ2VyQ3JlYXRlR2FkZ2V0VG9FcXVpcFBhcnROb3RpZnkucHJvdG8i",
            "egokVHJpZ2dlckNyZWF0ZUdhZGdldFRvRXF1aXBQYXJ0Tm90aWZ5EhgKEGdh",
            "ZGdldF9lbnRpdHlfaWQYASABKA0SEgoKZXF1aXBfcGFydBgMIAEoCRIRCgll",
            "bnRpdHlfaWQYBiABKA0SEQoJZ2FkZ2V0X2lkGAsgASgNQgyqAglOZXdQcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.TriggerCreateGadgetToEquipPartNotify), global::NewProtos.TriggerCreateGadgetToEquipPartNotify.Parser, new[]{ "GadgetEntityId", "EquipPart", "EntityId", "GadgetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 346;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class TriggerCreateGadgetToEquipPartNotify : pb::IMessage<TriggerCreateGadgetToEquipPartNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TriggerCreateGadgetToEquipPartNotify> _parser = new pb::MessageParser<TriggerCreateGadgetToEquipPartNotify>(() => new TriggerCreateGadgetToEquipPartNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TriggerCreateGadgetToEquipPartNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.TriggerCreateGadgetToEquipPartNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerCreateGadgetToEquipPartNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerCreateGadgetToEquipPartNotify(TriggerCreateGadgetToEquipPartNotify other) : this() {
      gadgetEntityId_ = other.gadgetEntityId_;
      equipPart_ = other.equipPart_;
      entityId_ = other.entityId_;
      gadgetId_ = other.gadgetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerCreateGadgetToEquipPartNotify Clone() {
      return new TriggerCreateGadgetToEquipPartNotify(this);
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

    /// <summary>Field number for the "equip_part" field.</summary>
    public const int EquipPartFieldNumber = 12;
    private string equipPart_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EquipPart {
      get { return equipPart_; }
      set {
        equipPart_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 6;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 11;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TriggerCreateGadgetToEquipPartNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TriggerCreateGadgetToEquipPartNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GadgetEntityId != other.GadgetEntityId) return false;
      if (EquipPart != other.EquipPart) return false;
      if (EntityId != other.EntityId) return false;
      if (GadgetId != other.GadgetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
      if (EquipPart.Length != 0) hash ^= EquipPart.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EntityId);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GadgetId);
      }
      if (EquipPart.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(EquipPart);
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
      if (EntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EntityId);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GadgetId);
      }
      if (EquipPart.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(EquipPart);
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
      if (EquipPart.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EquipPart);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TriggerCreateGadgetToEquipPartNotify other) {
      if (other == null) {
        return;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
      }
      if (other.EquipPart.Length != 0) {
        EquipPart = other.EquipPart;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 98: {
            EquipPart = input.ReadString();
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 98: {
            EquipPart = input.ReadString();
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
