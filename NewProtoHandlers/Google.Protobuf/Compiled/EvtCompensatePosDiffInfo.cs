// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtCompensatePosDiffInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EvtCompensatePosDiffInfo.proto</summary>
public static partial class EvtCompensatePosDiffInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for EvtCompensatePosDiffInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EvtCompensatePosDiffInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5FdnRDb21wZW5zYXRlUG9zRGlmZkluZm8ucHJvdG8aDFZlY3Rvci5wcm90",
          "byKWAQoYRXZ0Q29tcGVuc2F0ZVBvc0RpZmZJbmZvEhEKCWVudGl0eV9pZBgM",
          "IAEoDRIfChdub3JtYWxpemVkX3RpbWVfY29tcGFjdBgFIAEoDRIQCghjdXJf",
          "aGFzaBgHIAEoDRIaChJmYWNlX2FuZ2xlX2NvbXBhY3QYCyABKAUSGAoHY3Vy",
          "X3BvcxgGIAEoCzIHLlZlY3RvckIWChRvcmcuc29yYXBvaW50YS5wcm90b2IG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EvtCompensatePosDiffInfo), global::EvtCompensatePosDiffInfo.Parser, new[]{ "EntityId", "NormalizedTimeCompact", "CurHash", "FaceAngleCompact", "CurPos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class EvtCompensatePosDiffInfo : pb::IMessage<EvtCompensatePosDiffInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EvtCompensatePosDiffInfo> _parser = new pb::MessageParser<EvtCompensatePosDiffInfo>(() => new EvtCompensatePosDiffInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EvtCompensatePosDiffInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EvtCompensatePosDiffInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtCompensatePosDiffInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtCompensatePosDiffInfo(EvtCompensatePosDiffInfo other) : this() {
    entityId_ = other.entityId_;
    normalizedTimeCompact_ = other.normalizedTimeCompact_;
    curHash_ = other.curHash_;
    faceAngleCompact_ = other.faceAngleCompact_;
    curPos_ = other.curPos_ != null ? other.curPos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtCompensatePosDiffInfo Clone() {
    return new EvtCompensatePosDiffInfo(this);
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

  /// <summary>Field number for the "normalized_time_compact" field.</summary>
  public const int NormalizedTimeCompactFieldNumber = 5;
  private uint normalizedTimeCompact_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint NormalizedTimeCompact {
    get { return normalizedTimeCompact_; }
    set {
      normalizedTimeCompact_ = value;
    }
  }

  /// <summary>Field number for the "cur_hash" field.</summary>
  public const int CurHashFieldNumber = 7;
  private uint curHash_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurHash {
    get { return curHash_; }
    set {
      curHash_ = value;
    }
  }

  /// <summary>Field number for the "face_angle_compact" field.</summary>
  public const int FaceAngleCompactFieldNumber = 11;
  private int faceAngleCompact_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int FaceAngleCompact {
    get { return faceAngleCompact_; }
    set {
      faceAngleCompact_ = value;
    }
  }

  /// <summary>Field number for the "cur_pos" field.</summary>
  public const int CurPosFieldNumber = 6;
  private global::Vector curPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector CurPos {
    get { return curPos_; }
    set {
      curPos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EvtCompensatePosDiffInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EvtCompensatePosDiffInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EntityId != other.EntityId) return false;
    if (NormalizedTimeCompact != other.NormalizedTimeCompact) return false;
    if (CurHash != other.CurHash) return false;
    if (FaceAngleCompact != other.FaceAngleCompact) return false;
    if (!object.Equals(CurPos, other.CurPos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (NormalizedTimeCompact != 0) hash ^= NormalizedTimeCompact.GetHashCode();
    if (CurHash != 0) hash ^= CurHash.GetHashCode();
    if (FaceAngleCompact != 0) hash ^= FaceAngleCompact.GetHashCode();
    if (curPos_ != null) hash ^= CurPos.GetHashCode();
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
    if (NormalizedTimeCompact != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(NormalizedTimeCompact);
    }
    if (curPos_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(CurPos);
    }
    if (CurHash != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CurHash);
    }
    if (FaceAngleCompact != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(FaceAngleCompact);
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
    if (NormalizedTimeCompact != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(NormalizedTimeCompact);
    }
    if (curPos_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(CurPos);
    }
    if (CurHash != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CurHash);
    }
    if (FaceAngleCompact != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(FaceAngleCompact);
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
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (NormalizedTimeCompact != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NormalizedTimeCompact);
    }
    if (CurHash != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurHash);
    }
    if (FaceAngleCompact != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(FaceAngleCompact);
    }
    if (curPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurPos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EvtCompensatePosDiffInfo other) {
    if (other == null) {
      return;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.NormalizedTimeCompact != 0) {
      NormalizedTimeCompact = other.NormalizedTimeCompact;
    }
    if (other.CurHash != 0) {
      CurHash = other.CurHash;
    }
    if (other.FaceAngleCompact != 0) {
      FaceAngleCompact = other.FaceAngleCompact;
    }
    if (other.curPos_ != null) {
      if (curPos_ == null) {
        CurPos = new global::Vector();
      }
      CurPos.MergeFrom(other.CurPos);
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
        case 40: {
          NormalizedTimeCompact = input.ReadUInt32();
          break;
        }
        case 50: {
          if (curPos_ == null) {
            CurPos = new global::Vector();
          }
          input.ReadMessage(CurPos);
          break;
        }
        case 56: {
          CurHash = input.ReadUInt32();
          break;
        }
        case 88: {
          FaceAngleCompact = input.ReadInt32();
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
        case 40: {
          NormalizedTimeCompact = input.ReadUInt32();
          break;
        }
        case 50: {
          if (curPos_ == null) {
            CurPos = new global::Vector();
          }
          input.ReadMessage(CurPos);
          break;
        }
        case 56: {
          CurHash = input.ReadUInt32();
          break;
        }
        case 88: {
          FaceAngleCompact = input.ReadInt32();
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

}

#endregion


#endregion Designer generated code
