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
namespace OldProtos {

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
            "YW5kVXBOb3RpZnkSEAoIY2hhaXJfaWQYCyABKAQSEgoKcGVyZm9ybV9pZBgG",
            "IAEoBRIRCglkaXJlY3Rpb24YASABKAUSEQoJZW50aXR5X2lkGAkgASgNQgyq",
            "AglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.EvtAvatarStandUpNotify), global::OldProtos.EvtAvatarStandUpNotify.Parser, new[]{ "ChairId", "PerformId", "Direction", "EntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 356
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
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
      get { return global::OldProtos.EvtAvatarStandUpNotifyReflection.Descriptor.MessageTypes[0]; }
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
      chairId_ = other.chairId_;
      performId_ = other.performId_;
      direction_ = other.direction_;
      entityId_ = other.entityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarStandUpNotify Clone() {
      return new EvtAvatarStandUpNotify(this);
    }

    /// <summary>Field number for the "chair_id" field.</summary>
    public const int ChairIdFieldNumber = 11;
    private ulong chairId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ChairId {
      get { return chairId_; }
      set {
        chairId_ = value;
      }
    }

    /// <summary>Field number for the "perform_id" field.</summary>
    public const int PerformIdFieldNumber = 6;
    private int performId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PerformId {
      get { return performId_; }
      set {
        performId_ = value;
      }
    }

    /// <summary>Field number for the "direction" field.</summary>
    public const int DirectionFieldNumber = 1;
    private int direction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Direction {
      get { return direction_; }
      set {
        direction_ = value;
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
      if (ChairId != other.ChairId) return false;
      if (PerformId != other.PerformId) return false;
      if (Direction != other.Direction) return false;
      if (EntityId != other.EntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChairId != 0UL) hash ^= ChairId.GetHashCode();
      if (PerformId != 0) hash ^= PerformId.GetHashCode();
      if (Direction != 0) hash ^= Direction.GetHashCode();
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
      if (Direction != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Direction);
      }
      if (PerformId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(PerformId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntityId);
      }
      if (ChairId != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ChairId);
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
      if (Direction != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Direction);
      }
      if (PerformId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(PerformId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntityId);
      }
      if (ChairId != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ChairId);
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
      if (PerformId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PerformId);
      }
      if (Direction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Direction);
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
    public void MergeFrom(EvtAvatarStandUpNotify other) {
      if (other == null) {
        return;
      }
      if (other.ChairId != 0UL) {
        ChairId = other.ChairId;
      }
      if (other.PerformId != 0) {
        PerformId = other.PerformId;
      }
      if (other.Direction != 0) {
        Direction = other.Direction;
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
          case 8: {
            Direction = input.ReadInt32();
            break;
          }
          case 48: {
            PerformId = input.ReadInt32();
            break;
          }
          case 72: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            ChairId = input.ReadUInt64();
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
            Direction = input.ReadInt32();
            break;
          }
          case 48: {
            PerformId = input.ReadInt32();
            break;
          }
          case 72: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            ChairId = input.ReadUInt64();
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
