// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetCaptureAnimalReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from WidgetCaptureAnimalReq.proto</summary>
  public static partial class WidgetCaptureAnimalReqReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetCaptureAnimalReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetCaptureAnimalReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxXaWRnZXRDYXB0dXJlQW5pbWFsUmVxLnByb3RvGgxWZWN0b3IucHJvdG8i",
            "VgoWV2lkZ2V0Q2FwdHVyZUFuaW1hbFJlcRIUCgNwb3MYCiABKAsyBy5WZWN0",
            "b3ISEQoJZW50aXR5X2lkGA8gASgNEhMKC21hdGVyaWFsX2lkGAYgASgNQgyq",
            "AglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.WidgetCaptureAnimalReq), global::OldProtos.WidgetCaptureAnimalReq.Parser, new[]{ "Pos", "EntityId", "MaterialId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4256
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class WidgetCaptureAnimalReq : pb::IMessage<WidgetCaptureAnimalReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetCaptureAnimalReq> _parser = new pb::MessageParser<WidgetCaptureAnimalReq>(() => new WidgetCaptureAnimalReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetCaptureAnimalReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.WidgetCaptureAnimalReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCaptureAnimalReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCaptureAnimalReq(WidgetCaptureAnimalReq other) : this() {
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      entityId_ = other.entityId_;
      materialId_ = other.materialId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCaptureAnimalReq Clone() {
      return new WidgetCaptureAnimalReq(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 10;
    private global::OldProtos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 15;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 6;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetCaptureAnimalReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetCaptureAnimalReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pos, other.Pos)) return false;
      if (EntityId != other.EntityId) return false;
      if (MaterialId != other.MaterialId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
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
      if (MaterialId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaterialId);
      }
      if (pos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Pos);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
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
      if (MaterialId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MaterialId);
      }
      if (pos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Pos);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
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
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetCaptureAnimalReq other) {
      if (other == null) {
        return;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::OldProtos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
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
            MaterialId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (pos_ == null) {
              Pos = new global::OldProtos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 120: {
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
          case 48: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (pos_ == null) {
              Pos = new global::OldProtos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 120: {
            EntityId = input.ReadUInt32();
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
