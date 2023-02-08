// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtSyncEntityPositionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from EvtSyncEntityPositionInfo.proto</summary>
  public static partial class EvtSyncEntityPositionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtSyncEntityPositionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtSyncEntityPositionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9FdnRTeW5jRW50aXR5UG9zaXRpb25JbmZvLnByb3RvGgxWZWN0b3IucHJv",
            "dG8ilQEKGUV2dFN5bmNFbnRpdHlQb3NpdGlvbkluZm8SEgoKc3RhdGVfaGFz",
            "aBgKIAEoDRIaChJmYWNlX2FuZ2xlX2NvbXBhY3QYBCABKAUSFAoDcG9zGA4g",
            "ASgLMgcuVmVjdG9yEhEKCWVudGl0eV9pZBgBIAEoDRIfChdub3JtYWxpemVk",
            "X3RpbWVfY29tcGFjdBgNIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.EvtSyncEntityPositionInfo), global::NewProtos.EvtSyncEntityPositionInfo.Parser, new[]{ "StateHash", "FaceAngleCompact", "Pos", "EntityId", "NormalizedTimeCompact" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtSyncEntityPositionInfo : pb::IMessage<EvtSyncEntityPositionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtSyncEntityPositionInfo> _parser = new pb::MessageParser<EvtSyncEntityPositionInfo>(() => new EvtSyncEntityPositionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtSyncEntityPositionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.EvtSyncEntityPositionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSyncEntityPositionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSyncEntityPositionInfo(EvtSyncEntityPositionInfo other) : this() {
      stateHash_ = other.stateHash_;
      faceAngleCompact_ = other.faceAngleCompact_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      entityId_ = other.entityId_;
      normalizedTimeCompact_ = other.normalizedTimeCompact_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSyncEntityPositionInfo Clone() {
      return new EvtSyncEntityPositionInfo(this);
    }

    /// <summary>Field number for the "state_hash" field.</summary>
    public const int StateHashFieldNumber = 10;
    private uint stateHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StateHash {
      get { return stateHash_; }
      set {
        stateHash_ = value;
      }
    }

    /// <summary>Field number for the "face_angle_compact" field.</summary>
    public const int FaceAngleCompactFieldNumber = 4;
    private int faceAngleCompact_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FaceAngleCompact {
      get { return faceAngleCompact_; }
      set {
        faceAngleCompact_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 14;
    private global::NewProtos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "normalized_time_compact" field.</summary>
    public const int NormalizedTimeCompactFieldNumber = 13;
    private uint normalizedTimeCompact_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NormalizedTimeCompact {
      get { return normalizedTimeCompact_; }
      set {
        normalizedTimeCompact_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtSyncEntityPositionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtSyncEntityPositionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StateHash != other.StateHash) return false;
      if (FaceAngleCompact != other.FaceAngleCompact) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (EntityId != other.EntityId) return false;
      if (NormalizedTimeCompact != other.NormalizedTimeCompact) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StateHash != 0) hash ^= StateHash.GetHashCode();
      if (FaceAngleCompact != 0) hash ^= FaceAngleCompact.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (NormalizedTimeCompact != 0) hash ^= NormalizedTimeCompact.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(FaceAngleCompact);
      }
      if (StateHash != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StateHash);
      }
      if (NormalizedTimeCompact != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NormalizedTimeCompact);
      }
      if (pos_ != null) {
        output.WriteRawTag(114);
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(FaceAngleCompact);
      }
      if (StateHash != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StateHash);
      }
      if (NormalizedTimeCompact != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NormalizedTimeCompact);
      }
      if (pos_ != null) {
        output.WriteRawTag(114);
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
      if (StateHash != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StateHash);
      }
      if (FaceAngleCompact != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FaceAngleCompact);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (NormalizedTimeCompact != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NormalizedTimeCompact);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtSyncEntityPositionInfo other) {
      if (other == null) {
        return;
      }
      if (other.StateHash != 0) {
        StateHash = other.StateHash;
      }
      if (other.FaceAngleCompact != 0) {
        FaceAngleCompact = other.FaceAngleCompact;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::NewProtos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.NormalizedTimeCompact != 0) {
        NormalizedTimeCompact = other.NormalizedTimeCompact;
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 32: {
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 80: {
            StateHash = input.ReadUInt32();
            break;
          }
          case 104: {
            NormalizedTimeCompact = input.ReadUInt32();
            break;
          }
          case 114: {
            if (pos_ == null) {
              Pos = new global::NewProtos.Vector();
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
          case 8: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 32: {
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 80: {
            StateHash = input.ReadUInt32();
            break;
          }
          case 104: {
            NormalizedTimeCompact = input.ReadUInt32();
            break;
          }
          case 114: {
            if (pos_ == null) {
              Pos = new global::NewProtos.Vector();
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
