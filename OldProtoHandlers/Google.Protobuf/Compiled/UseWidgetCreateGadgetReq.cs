// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseWidgetCreateGadgetReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from UseWidgetCreateGadgetReq.proto</summary>
  public static partial class UseWidgetCreateGadgetReqReflection {

    #region Descriptor
    /// <summary>File descriptor for UseWidgetCreateGadgetReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseWidgetCreateGadgetReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Vc2VXaWRnZXRDcmVhdGVHYWRnZXRSZXEucHJvdG8aDFZlY3Rvci5wcm90",
            "byJbChhVc2VXaWRnZXRDcmVhdGVHYWRnZXRSZXESFAoDcG9zGA8gASgLMgcu",
            "VmVjdG9yEhQKA3JvdBgMIAEoCzIHLlZlY3RvchITCgttYXRlcmlhbF9pZBgE",
            "IAEoDUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.UseWidgetCreateGadgetReq), global::OldProtos.UseWidgetCreateGadgetReq.Parser, new[]{ "Pos", "Rot", "MaterialId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4293
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class UseWidgetCreateGadgetReq : pb::IMessage<UseWidgetCreateGadgetReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseWidgetCreateGadgetReq> _parser = new pb::MessageParser<UseWidgetCreateGadgetReq>(() => new UseWidgetCreateGadgetReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseWidgetCreateGadgetReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.UseWidgetCreateGadgetReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseWidgetCreateGadgetReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseWidgetCreateGadgetReq(UseWidgetCreateGadgetReq other) : this() {
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      rot_ = other.rot_ != null ? other.rot_.Clone() : null;
      materialId_ = other.materialId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseWidgetCreateGadgetReq Clone() {
      return new UseWidgetCreateGadgetReq(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 15;
    private global::OldProtos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 12;
    private global::OldProtos.Vector rot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 4;
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
      return Equals(other as UseWidgetCreateGadgetReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseWidgetCreateGadgetReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      if (MaterialId != other.MaterialId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (rot_ != null) hash ^= Rot.GetHashCode();
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
        output.WriteRawTag(32);
        output.WriteUInt32(MaterialId);
      }
      if (rot_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Rot);
      }
      if (pos_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Pos);
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
        output.WriteRawTag(32);
        output.WriteUInt32(MaterialId);
      }
      if (rot_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Rot);
      }
      if (pos_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Pos);
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
      if (rot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
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
    public void MergeFrom(UseWidgetCreateGadgetReq other) {
      if (other == null) {
        return;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::OldProtos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          Rot = new global::OldProtos.Vector();
        }
        Rot.MergeFrom(other.Rot);
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
          case 32: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rot_ == null) {
              Rot = new global::OldProtos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 122: {
            if (pos_ == null) {
              Pos = new global::OldProtos.Vector();
            }
            input.ReadMessage(Pos);
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
            MaterialId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rot_ == null) {
              Rot = new global::OldProtos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 122: {
            if (pos_ == null) {
              Pos = new global::OldProtos.Vector();
            }
            input.ReadMessage(Pos);
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
