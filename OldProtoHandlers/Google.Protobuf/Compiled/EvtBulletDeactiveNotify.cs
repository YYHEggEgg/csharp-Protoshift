// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtBulletDeactiveNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EvtBulletDeactiveNotify.proto</summary>
public static partial class EvtBulletDeactiveNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for EvtBulletDeactiveNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EvtBulletDeactiveNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1FdnRCdWxsZXREZWFjdGl2ZU5vdGlmeS5wcm90bxoRRm9yd2FyZFR5cGUu",
          "cHJvdG8aDFZlY3Rvci5wcm90byJwChdFdnRCdWxsZXREZWFjdGl2ZU5vdGlm",
          "eRIiCgxmb3J3YXJkX3R5cGUYBiABKA4yDC5Gb3J3YXJkVHlwZRIRCgllbnRp",
          "dHlfaWQYCSABKA0SHgoNZGlzYXBwZWFyX3BvcxgEIAEoCzIHLlZlY3RvckIe",
          "ChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ForwardTypeReflection.Descriptor, global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EvtBulletDeactiveNotify), global::EvtBulletDeactiveNotify.Parser, new[]{ "ForwardType", "EntityId", "DisappearPos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 397
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class EvtBulletDeactiveNotify : pb::IMessage<EvtBulletDeactiveNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EvtBulletDeactiveNotify> _parser = new pb::MessageParser<EvtBulletDeactiveNotify>(() => new EvtBulletDeactiveNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EvtBulletDeactiveNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EvtBulletDeactiveNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtBulletDeactiveNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtBulletDeactiveNotify(EvtBulletDeactiveNotify other) : this() {
    forwardType_ = other.forwardType_;
    entityId_ = other.entityId_;
    disappearPos_ = other.disappearPos_ != null ? other.disappearPos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtBulletDeactiveNotify Clone() {
    return new EvtBulletDeactiveNotify(this);
  }

  /// <summary>Field number for the "forward_type" field.</summary>
  public const int ForwardTypeFieldNumber = 6;
  private global::ForwardType forwardType_ = global::ForwardType.Local;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ForwardType ForwardType {
    get { return forwardType_; }
    set {
      forwardType_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 9;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  /// <summary>Field number for the "disappear_pos" field.</summary>
  public const int DisappearPosFieldNumber = 4;
  private global::Vector disappearPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector DisappearPos {
    get { return disappearPos_; }
    set {
      disappearPos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EvtBulletDeactiveNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EvtBulletDeactiveNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ForwardType != other.ForwardType) return false;
    if (EntityId != other.EntityId) return false;
    if (!object.Equals(DisappearPos, other.DisappearPos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ForwardType != global::ForwardType.Local) hash ^= ForwardType.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (disappearPos_ != null) hash ^= DisappearPos.GetHashCode();
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
    if (disappearPos_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(DisappearPos);
    }
    if (ForwardType != global::ForwardType.Local) {
      output.WriteRawTag(48);
      output.WriteEnum((int) ForwardType);
    }
    if (EntityId != 0) {
      output.WriteRawTag(72);
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
    if (disappearPos_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(DisappearPos);
    }
    if (ForwardType != global::ForwardType.Local) {
      output.WriteRawTag(48);
      output.WriteEnum((int) ForwardType);
    }
    if (EntityId != 0) {
      output.WriteRawTag(72);
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
    if (ForwardType != global::ForwardType.Local) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (disappearPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(DisappearPos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EvtBulletDeactiveNotify other) {
    if (other == null) {
      return;
    }
    if (other.ForwardType != global::ForwardType.Local) {
      ForwardType = other.ForwardType;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.disappearPos_ != null) {
      if (disappearPos_ == null) {
        DisappearPos = new global::Vector();
      }
      DisappearPos.MergeFrom(other.DisappearPos);
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
        case 34: {
          if (disappearPos_ == null) {
            DisappearPos = new global::Vector();
          }
          input.ReadMessage(DisappearPos);
          break;
        }
        case 48: {
          ForwardType = (global::ForwardType) input.ReadEnum();
          break;
        }
        case 72: {
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
        case 34: {
          if (disappearPos_ == null) {
            DisappearPos = new global::Vector();
          }
          input.ReadMessage(DisappearPos);
          break;
        }
        case 48: {
          ForwardType = (global::ForwardType) input.ReadEnum();
          break;
        }
        case 72: {
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
