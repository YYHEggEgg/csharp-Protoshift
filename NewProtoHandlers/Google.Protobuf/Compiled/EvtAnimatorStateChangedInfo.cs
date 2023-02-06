// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAnimatorStateChangedInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EvtAnimatorStateChangedInfo.proto</summary>
public static partial class EvtAnimatorStateChangedInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for EvtAnimatorStateChangedInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EvtAnimatorStateChangedInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFFdnRBbmltYXRvclN0YXRlQ2hhbmdlZEluZm8ucHJvdG8aDFZlY3Rvci5w",
          "cm90byL6AQobRXZ0QW5pbWF0b3JTdGF0ZUNoYW5nZWRJbmZvEhUKDWZhZGVf",
          "ZHVyYXRpb24YBCABKAISFQoNdG9fc3RhdGVfaGFzaBgLIAEoDRINCgVsYXll",
          "chgBIAEoDRIUCgNwb3MYBSABKAsyBy5WZWN0b3ISGwoTVW5rMzMwMF9LTE1F",
          "S01HRkdQRBgDIAEoCBIfChdub3JtYWxpemVkX3RpbWVfY29tcGFjdBgGIAEo",
          "DRIbChNVbmszMzAwX01FT1BLRURKQ0lOGAcgASgIEhoKEmZhY2VfYW5nbGVf",
          "Y29tcGFjdBgPIAEoBRIRCgllbnRpdHlfaWQYAiABKA1CFgoUb3JnLnNvcmFw",
          "b2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EvtAnimatorStateChangedInfo), global::EvtAnimatorStateChangedInfo.Parser, new[]{ "FadeDuration", "ToStateHash", "Layer", "Pos", "Unk3300KLMEKMGFGPD", "NormalizedTimeCompact", "Unk3300MEOPKEDJCIN", "FaceAngleCompact", "EntityId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class EvtAnimatorStateChangedInfo : pb::IMessage<EvtAnimatorStateChangedInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EvtAnimatorStateChangedInfo> _parser = new pb::MessageParser<EvtAnimatorStateChangedInfo>(() => new EvtAnimatorStateChangedInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EvtAnimatorStateChangedInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EvtAnimatorStateChangedInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAnimatorStateChangedInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAnimatorStateChangedInfo(EvtAnimatorStateChangedInfo other) : this() {
    fadeDuration_ = other.fadeDuration_;
    toStateHash_ = other.toStateHash_;
    layer_ = other.layer_;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    unk3300KLMEKMGFGPD_ = other.unk3300KLMEKMGFGPD_;
    normalizedTimeCompact_ = other.normalizedTimeCompact_;
    unk3300MEOPKEDJCIN_ = other.unk3300MEOPKEDJCIN_;
    faceAngleCompact_ = other.faceAngleCompact_;
    entityId_ = other.entityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtAnimatorStateChangedInfo Clone() {
    return new EvtAnimatorStateChangedInfo(this);
  }

  /// <summary>Field number for the "fade_duration" field.</summary>
  public const int FadeDurationFieldNumber = 4;
  private float fadeDuration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float FadeDuration {
    get { return fadeDuration_; }
    set {
      fadeDuration_ = value;
    }
  }

  /// <summary>Field number for the "to_state_hash" field.</summary>
  public const int ToStateHashFieldNumber = 11;
  private uint toStateHash_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ToStateHash {
    get { return toStateHash_; }
    set {
      toStateHash_ = value;
    }
  }

  /// <summary>Field number for the "layer" field.</summary>
  public const int LayerFieldNumber = 1;
  private uint layer_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Layer {
    get { return layer_; }
    set {
      layer_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 5;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_KLMEKMGFGPD" field.</summary>
  public const int Unk3300KLMEKMGFGPDFieldNumber = 3;
  private bool unk3300KLMEKMGFGPD_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300KLMEKMGFGPD {
    get { return unk3300KLMEKMGFGPD_; }
    set {
      unk3300KLMEKMGFGPD_ = value;
    }
  }

  /// <summary>Field number for the "normalized_time_compact" field.</summary>
  public const int NormalizedTimeCompactFieldNumber = 6;
  private uint normalizedTimeCompact_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint NormalizedTimeCompact {
    get { return normalizedTimeCompact_; }
    set {
      normalizedTimeCompact_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_MEOPKEDJCIN" field.</summary>
  public const int Unk3300MEOPKEDJCINFieldNumber = 7;
  private bool unk3300MEOPKEDJCIN_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300MEOPKEDJCIN {
    get { return unk3300MEOPKEDJCIN_; }
    set {
      unk3300MEOPKEDJCIN_ = value;
    }
  }

  /// <summary>Field number for the "face_angle_compact" field.</summary>
  public const int FaceAngleCompactFieldNumber = 15;
  private int faceAngleCompact_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int FaceAngleCompact {
    get { return faceAngleCompact_; }
    set {
      faceAngleCompact_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 2;
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
    return Equals(other as EvtAnimatorStateChangedInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EvtAnimatorStateChangedInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FadeDuration, other.FadeDuration)) return false;
    if (ToStateHash != other.ToStateHash) return false;
    if (Layer != other.Layer) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    if (Unk3300KLMEKMGFGPD != other.Unk3300KLMEKMGFGPD) return false;
    if (NormalizedTimeCompact != other.NormalizedTimeCompact) return false;
    if (Unk3300MEOPKEDJCIN != other.Unk3300MEOPKEDJCIN) return false;
    if (FaceAngleCompact != other.FaceAngleCompact) return false;
    if (EntityId != other.EntityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (FadeDuration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FadeDuration);
    if (ToStateHash != 0) hash ^= ToStateHash.GetHashCode();
    if (Layer != 0) hash ^= Layer.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
    if (Unk3300KLMEKMGFGPD != false) hash ^= Unk3300KLMEKMGFGPD.GetHashCode();
    if (NormalizedTimeCompact != 0) hash ^= NormalizedTimeCompact.GetHashCode();
    if (Unk3300MEOPKEDJCIN != false) hash ^= Unk3300MEOPKEDJCIN.GetHashCode();
    if (FaceAngleCompact != 0) hash ^= FaceAngleCompact.GetHashCode();
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
    if (Layer != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Layer);
    }
    if (EntityId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(EntityId);
    }
    if (Unk3300KLMEKMGFGPD != false) {
      output.WriteRawTag(24);
      output.WriteBool(Unk3300KLMEKMGFGPD);
    }
    if (FadeDuration != 0F) {
      output.WriteRawTag(37);
      output.WriteFloat(FadeDuration);
    }
    if (pos_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(Pos);
    }
    if (NormalizedTimeCompact != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(NormalizedTimeCompact);
    }
    if (Unk3300MEOPKEDJCIN != false) {
      output.WriteRawTag(56);
      output.WriteBool(Unk3300MEOPKEDJCIN);
    }
    if (ToStateHash != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ToStateHash);
    }
    if (FaceAngleCompact != 0) {
      output.WriteRawTag(120);
      output.WriteInt32(FaceAngleCompact);
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
    if (Layer != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Layer);
    }
    if (EntityId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(EntityId);
    }
    if (Unk3300KLMEKMGFGPD != false) {
      output.WriteRawTag(24);
      output.WriteBool(Unk3300KLMEKMGFGPD);
    }
    if (FadeDuration != 0F) {
      output.WriteRawTag(37);
      output.WriteFloat(FadeDuration);
    }
    if (pos_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(Pos);
    }
    if (NormalizedTimeCompact != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(NormalizedTimeCompact);
    }
    if (Unk3300MEOPKEDJCIN != false) {
      output.WriteRawTag(56);
      output.WriteBool(Unk3300MEOPKEDJCIN);
    }
    if (ToStateHash != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ToStateHash);
    }
    if (FaceAngleCompact != 0) {
      output.WriteRawTag(120);
      output.WriteInt32(FaceAngleCompact);
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
    if (FadeDuration != 0F) {
      size += 1 + 4;
    }
    if (ToStateHash != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ToStateHash);
    }
    if (Layer != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Layer);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (Unk3300KLMEKMGFGPD != false) {
      size += 1 + 1;
    }
    if (NormalizedTimeCompact != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NormalizedTimeCompact);
    }
    if (Unk3300MEOPKEDJCIN != false) {
      size += 1 + 1;
    }
    if (FaceAngleCompact != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(FaceAngleCompact);
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
  public void MergeFrom(EvtAnimatorStateChangedInfo other) {
    if (other == null) {
      return;
    }
    if (other.FadeDuration != 0F) {
      FadeDuration = other.FadeDuration;
    }
    if (other.ToStateHash != 0) {
      ToStateHash = other.ToStateHash;
    }
    if (other.Layer != 0) {
      Layer = other.Layer;
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
    }
    if (other.Unk3300KLMEKMGFGPD != false) {
      Unk3300KLMEKMGFGPD = other.Unk3300KLMEKMGFGPD;
    }
    if (other.NormalizedTimeCompact != 0) {
      NormalizedTimeCompact = other.NormalizedTimeCompact;
    }
    if (other.Unk3300MEOPKEDJCIN != false) {
      Unk3300MEOPKEDJCIN = other.Unk3300MEOPKEDJCIN;
    }
    if (other.FaceAngleCompact != 0) {
      FaceAngleCompact = other.FaceAngleCompact;
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
          Layer = input.ReadUInt32();
          break;
        }
        case 16: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 24: {
          Unk3300KLMEKMGFGPD = input.ReadBool();
          break;
        }
        case 37: {
          FadeDuration = input.ReadFloat();
          break;
        }
        case 42: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 48: {
          NormalizedTimeCompact = input.ReadUInt32();
          break;
        }
        case 56: {
          Unk3300MEOPKEDJCIN = input.ReadBool();
          break;
        }
        case 88: {
          ToStateHash = input.ReadUInt32();
          break;
        }
        case 120: {
          FaceAngleCompact = input.ReadInt32();
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
          Layer = input.ReadUInt32();
          break;
        }
        case 16: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 24: {
          Unk3300KLMEKMGFGPD = input.ReadBool();
          break;
        }
        case 37: {
          FadeDuration = input.ReadFloat();
          break;
        }
        case 42: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 48: {
          NormalizedTimeCompact = input.ReadUInt32();
          break;
        }
        case 56: {
          Unk3300MEOPKEDJCIN = input.ReadBool();
          break;
        }
        case 88: {
          ToStateHash = input.ReadUInt32();
          break;
        }
        case 120: {
          FaceAngleCompact = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
