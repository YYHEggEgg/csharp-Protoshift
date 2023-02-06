// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAvatarStandUpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EvtAvatarStandUpNotify.proto</summary>
public static partial class EvtAvatarStandUpNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for EvtAvatarStandUpNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EvtAvatarStandUpNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxFdnRBdmF0YXJTdGFuZFVwTm90aWZ5LnByb3RvImQKFkV2dEF2YXRhclN0",
          "YW5kVXBOb3RpZnkSEQoJZGlyZWN0aW9uGA0gASgFEhAKCGNoYWlyX2lkGAMg",
          "ASgEEhEKCWVudGl0eV9pZBgFIAEoDRISCgpwZXJmb3JtX2lkGAsgASgFQhYK",
          "FG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EvtAvatarStandUpNotify), global::EvtAvatarStandUpNotify.Parser, new[]{ "Direction", "ChairId", "EntityId", "PerformId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 382;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class EvtAvatarStandUpNotify : pb::IMessage<EvtAvatarStandUpNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EvtAvatarStandUpNotify> _parser = new pb::MessageParser<EvtAvatarStandUpNotify>(() => new EvtAvatarStandUpNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EvtAvatarStandUpNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EvtAvatarStandUpNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAvatarStandUpNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAvatarStandUpNotify(EvtAvatarStandUpNotify other) : this() {
    direction_ = other.direction_;
    chairId_ = other.chairId_;
    entityId_ = other.entityId_;
    performId_ = other.performId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAvatarStandUpNotify Clone() {
    return new EvtAvatarStandUpNotify(this);
  }

  /// <summary>Field number for the "direction" field.</summary>
  public const int DirectionFieldNumber = 13;
  private int direction_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Direction {
    get { return direction_; }
    set {
      direction_ = value;
    }
  }

  /// <summary>Field number for the "chair_id" field.</summary>
  public const int ChairIdFieldNumber = 3;
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
  public const int EntityIdFieldNumber = 5;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  /// <summary>Field number for the "perform_id" field.</summary>
  public const int PerformIdFieldNumber = 11;
  private int performId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int PerformId {
    get { return performId_; }
    set {
      performId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EvtAvatarStandUpNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EvtAvatarStandUpNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Direction != other.Direction) return false;
    if (ChairId != other.ChairId) return false;
    if (EntityId != other.EntityId) return false;
    if (PerformId != other.PerformId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Direction != 0) hash ^= Direction.GetHashCode();
    if (ChairId != 0UL) hash ^= ChairId.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (PerformId != 0) hash ^= PerformId.GetHashCode();
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
    if (ChairId != 0UL) {
      output.WriteRawTag(24);
      output.WriteUInt64(ChairId);
    }
    if (EntityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(EntityId);
    }
    if (PerformId != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(PerformId);
    }
    if (Direction != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Direction);
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
    if (ChairId != 0UL) {
      output.WriteRawTag(24);
      output.WriteUInt64(ChairId);
    }
    if (EntityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(EntityId);
    }
    if (PerformId != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(PerformId);
    }
    if (Direction != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Direction);
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
    if (Direction != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Direction);
    }
    if (ChairId != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ChairId);
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (PerformId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PerformId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EvtAvatarStandUpNotify other) {
    if (other == null) {
      return;
    }
    if (other.Direction != 0) {
      Direction = other.Direction;
    }
    if (other.ChairId != 0UL) {
      ChairId = other.ChairId;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.PerformId != 0) {
      PerformId = other.PerformId;
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
        case 24: {
          ChairId = input.ReadUInt64();
          break;
        }
        case 40: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 88: {
          PerformId = input.ReadInt32();
          break;
        }
        case 104: {
          Direction = input.ReadInt32();
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
        case 24: {
          ChairId = input.ReadUInt64();
          break;
        }
        case 40: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 88: {
          PerformId = input.ReadInt32();
          break;
        }
        case 104: {
          Direction = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code