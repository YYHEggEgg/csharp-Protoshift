// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGTCTavernInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGTCTavernInfoNotify.proto</summary>
public static partial class GCGTCTavernInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGTCTavernInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGTCTavernInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtHQ0dUQ1RhdmVybkluZm9Ob3RpZnkucHJvdG8itAEKFUdDR1RDVGF2ZXJu",
          "SW5mb05vdGlmeRIQCghsZXZlbF9pZBgFIAEoDRIbChNVbmszMzAwX0lNRkpC",
          "TkZNQ0hNGAsgASgIEhsKE1VuazMzMDBfTUJHTUhCTkJLQksYCCABKAgSEAoI",
          "cG9pbnRfaWQYBCABKA0SFAoMZWxlbWVudF90eXBlGAYgASgNEhEKCWF2YXRh",
          "cl9pZBgJIAEoDRIUCgxjaGFyYWN0ZXJfaWQYDCABKA1CFgoUb3JnLnNvcmFw",
          "b2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGTCTavernInfoNotify), global::GCGTCTavernInfoNotify.Parser, new[]{ "LevelId", "Unk3300IMFJBNFMCHM", "Unk3300MBGMHBNBKBK", "PointId", "ElementType", "AvatarId", "CharacterId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 7268;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GCGTCTavernInfoNotify : pb::IMessage<GCGTCTavernInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGTCTavernInfoNotify> _parser = new pb::MessageParser<GCGTCTavernInfoNotify>(() => new GCGTCTavernInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGTCTavernInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGTCTavernInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGTCTavernInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGTCTavernInfoNotify(GCGTCTavernInfoNotify other) : this() {
    levelId_ = other.levelId_;
    unk3300IMFJBNFMCHM_ = other.unk3300IMFJBNFMCHM_;
    unk3300MBGMHBNBKBK_ = other.unk3300MBGMHBNBKBK_;
    pointId_ = other.pointId_;
    elementType_ = other.elementType_;
    avatarId_ = other.avatarId_;
    characterId_ = other.characterId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGTCTavernInfoNotify Clone() {
    return new GCGTCTavernInfoNotify(this);
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 5;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_IMFJBNFMCHM" field.</summary>
  public const int Unk3300IMFJBNFMCHMFieldNumber = 11;
  private bool unk3300IMFJBNFMCHM_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300IMFJBNFMCHM {
    get { return unk3300IMFJBNFMCHM_; }
    set {
      unk3300IMFJBNFMCHM_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_MBGMHBNBKBK" field.</summary>
  public const int Unk3300MBGMHBNBKBKFieldNumber = 8;
  private bool unk3300MBGMHBNBKBK_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300MBGMHBNBKBK {
    get { return unk3300MBGMHBNBKBK_; }
    set {
      unk3300MBGMHBNBKBK_ = value;
    }
  }

  /// <summary>Field number for the "point_id" field.</summary>
  public const int PointIdFieldNumber = 4;
  private uint pointId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PointId {
    get { return pointId_; }
    set {
      pointId_ = value;
    }
  }

  /// <summary>Field number for the "element_type" field.</summary>
  public const int ElementTypeFieldNumber = 6;
  private uint elementType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ElementType {
    get { return elementType_; }
    set {
      elementType_ = value;
    }
  }

  /// <summary>Field number for the "avatar_id" field.</summary>
  public const int AvatarIdFieldNumber = 9;
  private uint avatarId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AvatarId {
    get { return avatarId_; }
    set {
      avatarId_ = value;
    }
  }

  /// <summary>Field number for the "character_id" field.</summary>
  public const int CharacterIdFieldNumber = 12;
  private uint characterId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CharacterId {
    get { return characterId_; }
    set {
      characterId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGTCTavernInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGTCTavernInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (LevelId != other.LevelId) return false;
    if (Unk3300IMFJBNFMCHM != other.Unk3300IMFJBNFMCHM) return false;
    if (Unk3300MBGMHBNBKBK != other.Unk3300MBGMHBNBKBK) return false;
    if (PointId != other.PointId) return false;
    if (ElementType != other.ElementType) return false;
    if (AvatarId != other.AvatarId) return false;
    if (CharacterId != other.CharacterId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (Unk3300IMFJBNFMCHM != false) hash ^= Unk3300IMFJBNFMCHM.GetHashCode();
    if (Unk3300MBGMHBNBKBK != false) hash ^= Unk3300MBGMHBNBKBK.GetHashCode();
    if (PointId != 0) hash ^= PointId.GetHashCode();
    if (ElementType != 0) hash ^= ElementType.GetHashCode();
    if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
    if (CharacterId != 0) hash ^= CharacterId.GetHashCode();
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
    if (PointId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(PointId);
    }
    if (LevelId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(LevelId);
    }
    if (ElementType != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ElementType);
    }
    if (Unk3300MBGMHBNBKBK != false) {
      output.WriteRawTag(64);
      output.WriteBool(Unk3300MBGMHBNBKBK);
    }
    if (AvatarId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(AvatarId);
    }
    if (Unk3300IMFJBNFMCHM != false) {
      output.WriteRawTag(88);
      output.WriteBool(Unk3300IMFJBNFMCHM);
    }
    if (CharacterId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CharacterId);
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
    if (PointId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(PointId);
    }
    if (LevelId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(LevelId);
    }
    if (ElementType != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ElementType);
    }
    if (Unk3300MBGMHBNBKBK != false) {
      output.WriteRawTag(64);
      output.WriteBool(Unk3300MBGMHBNBKBK);
    }
    if (AvatarId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(AvatarId);
    }
    if (Unk3300IMFJBNFMCHM != false) {
      output.WriteRawTag(88);
      output.WriteBool(Unk3300IMFJBNFMCHM);
    }
    if (CharacterId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CharacterId);
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
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (Unk3300IMFJBNFMCHM != false) {
      size += 1 + 1;
    }
    if (Unk3300MBGMHBNBKBK != false) {
      size += 1 + 1;
    }
    if (PointId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
    }
    if (ElementType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementType);
    }
    if (AvatarId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
    }
    if (CharacterId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CharacterId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGTCTavernInfoNotify other) {
    if (other == null) {
      return;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.Unk3300IMFJBNFMCHM != false) {
      Unk3300IMFJBNFMCHM = other.Unk3300IMFJBNFMCHM;
    }
    if (other.Unk3300MBGMHBNBKBK != false) {
      Unk3300MBGMHBNBKBK = other.Unk3300MBGMHBNBKBK;
    }
    if (other.PointId != 0) {
      PointId = other.PointId;
    }
    if (other.ElementType != 0) {
      ElementType = other.ElementType;
    }
    if (other.AvatarId != 0) {
      AvatarId = other.AvatarId;
    }
    if (other.CharacterId != 0) {
      CharacterId = other.CharacterId;
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
          PointId = input.ReadUInt32();
          break;
        }
        case 40: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 48: {
          ElementType = input.ReadUInt32();
          break;
        }
        case 64: {
          Unk3300MBGMHBNBKBK = input.ReadBool();
          break;
        }
        case 72: {
          AvatarId = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300IMFJBNFMCHM = input.ReadBool();
          break;
        }
        case 96: {
          CharacterId = input.ReadUInt32();
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
          PointId = input.ReadUInt32();
          break;
        }
        case 40: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 48: {
          ElementType = input.ReadUInt32();
          break;
        }
        case 64: {
          Unk3300MBGMHBNBKBK = input.ReadBool();
          break;
        }
        case 72: {
          AvatarId = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300IMFJBNFMCHM = input.ReadBool();
          break;
        }
        case 96: {
          CharacterId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code