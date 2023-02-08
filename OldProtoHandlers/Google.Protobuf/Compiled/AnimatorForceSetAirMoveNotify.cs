// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AnimatorForceSetAirMoveNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AnimatorForceSetAirMoveNotify.proto</summary>
  public static partial class AnimatorForceSetAirMoveNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AnimatorForceSetAirMoveNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnimatorForceSetAirMoveNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNBbmltYXRvckZvcmNlU2V0QWlyTW92ZU5vdGlmeS5wcm90bxoRRm9yd2Fy",
            "ZFR5cGUucHJvdG8iawodQW5pbWF0b3JGb3JjZVNldEFpck1vdmVOb3RpZnkS",
            "EQoJZW50aXR5X2lkGA4gASgNEhMKC2luX2Fpcl9tb3ZlGA0gASgIEiIKDGZv",
            "cndhcmRfdHlwZRgJIAEoDjIMLkZvcndhcmRUeXBlQgyqAglPbGRQcm90b3Ni",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AnimatorForceSetAirMoveNotify), global::OldProtos.AnimatorForceSetAirMoveNotify.Parser, new[]{ "EntityId", "InAirMove", "ForwardType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 374
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class AnimatorForceSetAirMoveNotify : pb::IMessage<AnimatorForceSetAirMoveNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnimatorForceSetAirMoveNotify> _parser = new pb::MessageParser<AnimatorForceSetAirMoveNotify>(() => new AnimatorForceSetAirMoveNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AnimatorForceSetAirMoveNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.AnimatorForceSetAirMoveNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorForceSetAirMoveNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorForceSetAirMoveNotify(AnimatorForceSetAirMoveNotify other) : this() {
      entityId_ = other.entityId_;
      inAirMove_ = other.inAirMove_;
      forwardType_ = other.forwardType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorForceSetAirMoveNotify Clone() {
      return new AnimatorForceSetAirMoveNotify(this);
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

    /// <summary>Field number for the "in_air_move" field.</summary>
    public const int InAirMoveFieldNumber = 13;
    private bool inAirMove_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool InAirMove {
      get { return inAirMove_; }
      set {
        inAirMove_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 9;
    private global::OldProtos.ForwardType forwardType_ = global::OldProtos.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AnimatorForceSetAirMoveNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AnimatorForceSetAirMoveNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (InAirMove != other.InAirMove) return false;
      if (ForwardType != other.ForwardType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (InAirMove != false) hash ^= InAirMove.GetHashCode();
      if (ForwardType != global::OldProtos.ForwardType.Local) hash ^= ForwardType.GetHashCode();
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
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ForwardType);
      }
      if (InAirMove != false) {
        output.WriteRawTag(104);
        output.WriteBool(InAirMove);
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
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ForwardType);
      }
      if (InAirMove != false) {
        output.WriteRawTag(104);
        output.WriteBool(InAirMove);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (InAirMove != false) {
        size += 1 + 1;
      }
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AnimatorForceSetAirMoveNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.InAirMove != false) {
        InAirMove = other.InAirMove;
      }
      if (other.ForwardType != global::OldProtos.ForwardType.Local) {
        ForwardType = other.ForwardType;
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
            ForwardType = (global::OldProtos.ForwardType) input.ReadEnum();
            break;
          }
          case 104: {
            InAirMove = input.ReadBool();
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
            ForwardType = (global::OldProtos.ForwardType) input.ReadEnum();
            break;
          }
          case 104: {
            InAirMove = input.ReadBool();
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

}

#endregion Designer generated code
