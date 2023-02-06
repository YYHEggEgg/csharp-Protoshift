// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGCard.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGCard.proto</summary>
public static partial class GCGCardReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGCard.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGCardReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1HQ0dDYXJkLnByb3RvGhhHQ0dTa2lsbExpbWl0c0luZm8ucHJvdG8aDkdD",
          "R1Rva2VuLnByb3RvItYBCgdHQ0dDYXJkEhAKCHRhZ19saXN0GAcgAygNEgwK",
          "BGd1aWQYCyABKA0SDwoHaXNfc2hvdxgPIAEoCBIdCgp0b2tlbl9saXN0GAgg",
          "AygLMgkuR0NHVG9rZW4SEQoJZmFjZV90eXBlGAIgASgNEhUKDXNraWxsX2lk",
          "X2xpc3QYDSADKA0SLgoRc2tpbGxfbGltaXRzX2xpc3QYAyADKAsyEy5HQ0dT",
          "a2lsbExpbWl0c0luZm8SCgoCaWQYBiABKA0SFQoNY29udHJvbGxlcl9pZBgF",
          "IAEoDUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGSkillLimitsInfoReflection.Descriptor, global::GCGTokenReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGCard), global::GCGCard.Parser, new[]{ "TagList", "Guid", "IsShow", "TokenList", "FaceType", "SkillIdList", "SkillLimitsList", "Id", "ControllerId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGCard : pb::IMessage<GCGCard>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGCard> _parser = new pb::MessageParser<GCGCard>(() => new GCGCard());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGCard> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGCardReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGCard() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGCard(GCGCard other) : this() {
    tagList_ = other.tagList_.Clone();
    guid_ = other.guid_;
    isShow_ = other.isShow_;
    tokenList_ = other.tokenList_.Clone();
    faceType_ = other.faceType_;
    skillIdList_ = other.skillIdList_.Clone();
    skillLimitsList_ = other.skillLimitsList_.Clone();
    id_ = other.id_;
    controllerId_ = other.controllerId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGCard Clone() {
    return new GCGCard(this);
  }

  /// <summary>Field number for the "tag_list" field.</summary>
  public const int TagListFieldNumber = 7;
  private static readonly pb::FieldCodec<uint> _repeated_tagList_codec
      = pb::FieldCodec.ForUInt32(58);
  private readonly pbc::RepeatedField<uint> tagList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> TagList {
    get { return tagList_; }
  }

  /// <summary>Field number for the "guid" field.</summary>
  public const int GuidFieldNumber = 11;
  private uint guid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Guid {
    get { return guid_; }
    set {
      guid_ = value;
    }
  }

  /// <summary>Field number for the "is_show" field.</summary>
  public const int IsShowFieldNumber = 15;
  private bool isShow_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsShow {
    get { return isShow_; }
    set {
      isShow_ = value;
    }
  }

  /// <summary>Field number for the "token_list" field.</summary>
  public const int TokenListFieldNumber = 8;
  private static readonly pb::FieldCodec<global::GCGToken> _repeated_tokenList_codec
      = pb::FieldCodec.ForMessage(66, global::GCGToken.Parser);
  private readonly pbc::RepeatedField<global::GCGToken> tokenList_ = new pbc::RepeatedField<global::GCGToken>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGToken> TokenList {
    get { return tokenList_; }
  }

  /// <summary>Field number for the "face_type" field.</summary>
  public const int FaceTypeFieldNumber = 2;
  private uint faceType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FaceType {
    get { return faceType_; }
    set {
      faceType_ = value;
    }
  }

  /// <summary>Field number for the "skill_id_list" field.</summary>
  public const int SkillIdListFieldNumber = 13;
  private static readonly pb::FieldCodec<uint> _repeated_skillIdList_codec
      = pb::FieldCodec.ForUInt32(106);
  private readonly pbc::RepeatedField<uint> skillIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> SkillIdList {
    get { return skillIdList_; }
  }

  /// <summary>Field number for the "skill_limits_list" field.</summary>
  public const int SkillLimitsListFieldNumber = 3;
  private static readonly pb::FieldCodec<global::GCGSkillLimitsInfo> _repeated_skillLimitsList_codec
      = pb::FieldCodec.ForMessage(26, global::GCGSkillLimitsInfo.Parser);
  private readonly pbc::RepeatedField<global::GCGSkillLimitsInfo> skillLimitsList_ = new pbc::RepeatedField<global::GCGSkillLimitsInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGSkillLimitsInfo> SkillLimitsList {
    get { return skillLimitsList_; }
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 6;
  private uint id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "controller_id" field.</summary>
  public const int ControllerIdFieldNumber = 5;
  private uint controllerId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ControllerId {
    get { return controllerId_; }
    set {
      controllerId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGCard);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGCard other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!tagList_.Equals(other.tagList_)) return false;
    if (Guid != other.Guid) return false;
    if (IsShow != other.IsShow) return false;
    if(!tokenList_.Equals(other.tokenList_)) return false;
    if (FaceType != other.FaceType) return false;
    if(!skillIdList_.Equals(other.skillIdList_)) return false;
    if(!skillLimitsList_.Equals(other.skillLimitsList_)) return false;
    if (Id != other.Id) return false;
    if (ControllerId != other.ControllerId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= tagList_.GetHashCode();
    if (Guid != 0) hash ^= Guid.GetHashCode();
    if (IsShow != false) hash ^= IsShow.GetHashCode();
    hash ^= tokenList_.GetHashCode();
    if (FaceType != 0) hash ^= FaceType.GetHashCode();
    hash ^= skillIdList_.GetHashCode();
    hash ^= skillLimitsList_.GetHashCode();
    if (Id != 0) hash ^= Id.GetHashCode();
    if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
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
    if (FaceType != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(FaceType);
    }
    skillLimitsList_.WriteTo(output, _repeated_skillLimitsList_codec);
    if (ControllerId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ControllerId);
    }
    if (Id != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Id);
    }
    tagList_.WriteTo(output, _repeated_tagList_codec);
    tokenList_.WriteTo(output, _repeated_tokenList_codec);
    if (Guid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Guid);
    }
    skillIdList_.WriteTo(output, _repeated_skillIdList_codec);
    if (IsShow != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsShow);
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
    if (FaceType != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(FaceType);
    }
    skillLimitsList_.WriteTo(ref output, _repeated_skillLimitsList_codec);
    if (ControllerId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ControllerId);
    }
    if (Id != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Id);
    }
    tagList_.WriteTo(ref output, _repeated_tagList_codec);
    tokenList_.WriteTo(ref output, _repeated_tokenList_codec);
    if (Guid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Guid);
    }
    skillIdList_.WriteTo(ref output, _repeated_skillIdList_codec);
    if (IsShow != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsShow);
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
    size += tagList_.CalculateSize(_repeated_tagList_codec);
    if (Guid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
    }
    if (IsShow != false) {
      size += 1 + 1;
    }
    size += tokenList_.CalculateSize(_repeated_tokenList_codec);
    if (FaceType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FaceType);
    }
    size += skillIdList_.CalculateSize(_repeated_skillIdList_codec);
    size += skillLimitsList_.CalculateSize(_repeated_skillLimitsList_codec);
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (ControllerId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGCard other) {
    if (other == null) {
      return;
    }
    tagList_.Add(other.tagList_);
    if (other.Guid != 0) {
      Guid = other.Guid;
    }
    if (other.IsShow != false) {
      IsShow = other.IsShow;
    }
    tokenList_.Add(other.tokenList_);
    if (other.FaceType != 0) {
      FaceType = other.FaceType;
    }
    skillIdList_.Add(other.skillIdList_);
    skillLimitsList_.Add(other.skillLimitsList_);
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.ControllerId != 0) {
      ControllerId = other.ControllerId;
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
        case 16: {
          FaceType = input.ReadUInt32();
          break;
        }
        case 26: {
          skillLimitsList_.AddEntriesFrom(input, _repeated_skillLimitsList_codec);
          break;
        }
        case 40: {
          ControllerId = input.ReadUInt32();
          break;
        }
        case 48: {
          Id = input.ReadUInt32();
          break;
        }
        case 58:
        case 56: {
          tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
          break;
        }
        case 66: {
          tokenList_.AddEntriesFrom(input, _repeated_tokenList_codec);
          break;
        }
        case 88: {
          Guid = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          skillIdList_.AddEntriesFrom(input, _repeated_skillIdList_codec);
          break;
        }
        case 120: {
          IsShow = input.ReadBool();
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
        case 16: {
          FaceType = input.ReadUInt32();
          break;
        }
        case 26: {
          skillLimitsList_.AddEntriesFrom(ref input, _repeated_skillLimitsList_codec);
          break;
        }
        case 40: {
          ControllerId = input.ReadUInt32();
          break;
        }
        case 48: {
          Id = input.ReadUInt32();
          break;
        }
        case 58:
        case 56: {
          tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
          break;
        }
        case 66: {
          tokenList_.AddEntriesFrom(ref input, _repeated_tokenList_codec);
          break;
        }
        case 88: {
          Guid = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          skillIdList_.AddEntriesFrom(ref input, _repeated_skillIdList_codec);
          break;
        }
        case 120: {
          IsShow = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code