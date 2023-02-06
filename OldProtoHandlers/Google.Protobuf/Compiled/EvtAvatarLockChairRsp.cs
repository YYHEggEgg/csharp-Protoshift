// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAvatarLockChairRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EvtAvatarLockChairRsp.proto</summary>
public static partial class EvtAvatarLockChairRspReflection {

  #region Descriptor
  /// <summary>File descriptor for EvtAvatarLockChairRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EvtAvatarLockChairRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtFdnRBdmF0YXJMb2NrQ2hhaXJSc3AucHJvdG8aDFZlY3Rvci5wcm90byJo",
          "ChVFdnRBdmF0YXJMb2NrQ2hhaXJSc3ASEAoIY2hhaXJfaWQYDiABKAQSEQoJ",
          "ZW50aXR5X2lkGA8gASgNEhkKCHBvc2l0aW9uGAQgASgLMgcuVmVjdG9yEg8K",
          "B3JldGNvZGUYDCABKAVCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EvtAvatarLockChairRsp), global::EvtAvatarLockChairRsp.Parser, new[]{ "ChairId", "EntityId", "Position", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 366
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class EvtAvatarLockChairRsp : pb::IMessage<EvtAvatarLockChairRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EvtAvatarLockChairRsp> _parser = new pb::MessageParser<EvtAvatarLockChairRsp>(() => new EvtAvatarLockChairRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EvtAvatarLockChairRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EvtAvatarLockChairRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAvatarLockChairRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAvatarLockChairRsp(EvtAvatarLockChairRsp other) : this() {
    chairId_ = other.chairId_;
    entityId_ = other.entityId_;
    position_ = other.position_ != null ? other.position_.Clone() : null;
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAvatarLockChairRsp Clone() {
    return new EvtAvatarLockChairRsp(this);
  }

  /// <summary>Field number for the "chair_id" field.</summary>
  public const int ChairIdFieldNumber = 14;
  private ulong chairId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong ChairId {
    get { return chairId_; }
    set {
      chairId_ = value;
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

  /// <summary>Field number for the "position" field.</summary>
  public const int PositionFieldNumber = 4;
  private global::Vector position_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Position {
    get { return position_; }
    set {
      position_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 12;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EvtAvatarLockChairRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EvtAvatarLockChairRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ChairId != other.ChairId) return false;
    if (EntityId != other.EntityId) return false;
    if (!object.Equals(Position, other.Position)) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ChairId != 0UL) hash ^= ChairId.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (position_ != null) hash ^= Position.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (position_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(Position);
    }
    if (Retcode != 0) {
      output.WriteRawTag(96);
      output.WriteInt32(Retcode);
    }
    if (ChairId != 0UL) {
      output.WriteRawTag(112);
      output.WriteUInt64(ChairId);
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
    if (position_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(Position);
    }
    if (Retcode != 0) {
      output.WriteRawTag(96);
      output.WriteInt32(Retcode);
    }
    if (ChairId != 0UL) {
      output.WriteRawTag(112);
      output.WriteUInt64(ChairId);
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
    if (ChairId != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ChairId);
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (position_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EvtAvatarLockChairRsp other) {
    if (other == null) {
      return;
    }
    if (other.ChairId != 0UL) {
      ChairId = other.ChairId;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.position_ != null) {
      if (position_ == null) {
        Position = new global::Vector();
      }
      Position.MergeFrom(other.Position);
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
          if (position_ == null) {
            Position = new global::Vector();
          }
          input.ReadMessage(Position);
          break;
        }
        case 96: {
          Retcode = input.ReadInt32();
          break;
        }
        case 112: {
          ChairId = input.ReadUInt64();
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
        case 34: {
          if (position_ == null) {
            Position = new global::Vector();
          }
          input.ReadMessage(Position);
          break;
        }
        case 96: {
          Retcode = input.ReadInt32();
          break;
        }
        case 112: {
          ChairId = input.ReadUInt64();
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


#endregion Designer generated code
