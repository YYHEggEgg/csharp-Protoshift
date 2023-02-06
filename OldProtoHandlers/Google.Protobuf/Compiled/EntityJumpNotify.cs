// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityJumpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EntityJumpNotify.proto</summary>
public static partial class EntityJumpNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for EntityJumpNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EntityJumpNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZFbnRpdHlKdW1wTm90aWZ5LnByb3RvGgxWZWN0b3IucHJvdG8itgEKEEVu",
          "dGl0eUp1bXBOb3RpZnkSKQoJanVtcF90eXBlGAkgASgOMhYuRW50aXR5SnVt",
          "cE5vdGlmeS5UeXBlEhQKA3JvdBgIIAEoCzIHLlZlY3RvchIUCgNwb3MYCiAB",
          "KAsyBy5WZWN0b3ISEQoJZW50aXR5X2lkGAwgASgNIjgKBFR5cGUSDQoJVFlQ",
          "RV9OVUxMEAASDwoLVFlQRV9BQ1RJVkUQARIQCgxUWVBFX1BBU1NJVkUQAkIe",
          "ChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EntityJumpNotify), global::EntityJumpNotify.Parser, new[]{ "JumpType", "Rot", "Pos", "EntityId" }, null, new[]{ typeof(global::EntityJumpNotify.Types.Type) }, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 222
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class EntityJumpNotify : pb::IMessage<EntityJumpNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EntityJumpNotify> _parser = new pb::MessageParser<EntityJumpNotify>(() => new EntityJumpNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EntityJumpNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EntityJumpNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EntityJumpNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EntityJumpNotify(EntityJumpNotify other) : this() {
    jumpType_ = other.jumpType_;
    rot_ = other.rot_ != null ? other.rot_.Clone() : null;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    entityId_ = other.entityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EntityJumpNotify Clone() {
    return new EntityJumpNotify(this);
  }

  /// <summary>Field number for the "jump_type" field.</summary>
  public const int JumpTypeFieldNumber = 9;
  private global::EntityJumpNotify.Types.Type jumpType_ = global::EntityJumpNotify.Types.Type.Null;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::EntityJumpNotify.Types.Type JumpType {
    get { return jumpType_; }
    set {
      jumpType_ = value;
    }
  }

  /// <summary>Field number for the "rot" field.</summary>
  public const int RotFieldNumber = 8;
  private global::Vector rot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Rot {
    get { return rot_; }
    set {
      rot_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 10;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 12;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EntityJumpNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EntityJumpNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (JumpType != other.JumpType) return false;
    if (!object.Equals(Rot, other.Rot)) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    if (EntityId != other.EntityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (JumpType != global::EntityJumpNotify.Types.Type.Null) hash ^= JumpType.GetHashCode();
    if (rot_ != null) hash ^= Rot.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
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
    if (rot_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(Rot);
    }
    if (JumpType != global::EntityJumpNotify.Types.Type.Null) {
      output.WriteRawTag(72);
      output.WriteEnum((int) JumpType);
    }
    if (pos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(Pos);
    }
    if (EntityId != 0) {
      output.WriteRawTag(96);
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
    if (rot_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(Rot);
    }
    if (JumpType != global::EntityJumpNotify.Types.Type.Null) {
      output.WriteRawTag(72);
      output.WriteEnum((int) JumpType);
    }
    if (pos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(Pos);
    }
    if (EntityId != 0) {
      output.WriteRawTag(96);
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
    if (JumpType != global::EntityJumpNotify.Types.Type.Null) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) JumpType);
    }
    if (rot_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EntityJumpNotify other) {
    if (other == null) {
      return;
    }
    if (other.JumpType != global::EntityJumpNotify.Types.Type.Null) {
      JumpType = other.JumpType;
    }
    if (other.rot_ != null) {
      if (rot_ == null) {
        Rot = new global::Vector();
      }
      Rot.MergeFrom(other.Rot);
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
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
        case 66: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
          break;
        }
        case 72: {
          JumpType = (global::EntityJumpNotify.Types.Type) input.ReadEnum();
          break;
        }
        case 82: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 96: {
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
        case 66: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
          break;
        }
        case 72: {
          JumpType = (global::EntityJumpNotify.Types.Type) input.ReadEnum();
          break;
        }
        case 82: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 96: {
          EntityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the EntityJumpNotify message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum Type {
      [pbr::OriginalName("TYPE_NULL")] Null = 0,
      [pbr::OriginalName("TYPE_ACTIVE")] Active = 1,
      [pbr::OriginalName("TYPE_PASSIVE")] Passive = 2,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
