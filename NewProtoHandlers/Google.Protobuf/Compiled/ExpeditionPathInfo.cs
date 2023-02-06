// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionPathInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ExpeditionPathInfo.proto</summary>
public static partial class ExpeditionPathInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for ExpeditionPathInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ExpeditionPathInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhFeHBlZGl0aW9uUGF0aEluZm8ucHJvdG8aFUV4cGVkaXRpb25TdGF0ZS5w",
          "cm90byKXAgoSRXhwZWRpdGlvblBhdGhJbmZvEhIKCnN0YXJ0X3RpbWUYCiAB",
          "KA0SGQoRYm9udXNfcHJvYmFiaWxpdHkYDCABKAISFgoOYXZhdGFyX2lkX2xp",
          "c3QYCCADKA0SDwoHcGF0aF9pZBgLIAEoDRIbChNVbmszMzAwX0FJRUpLQURG",
          "TEtHGAYgASgNEhsKE1VuazMzMDBfTEtBSE9FQk5CQkkYDiABKA0SGwoTVW5r",
          "MzMwMF9BRkdQR0lJR0FLQRgHIAEoDRIbChNVbmszMzAwX0xGSUZER0FHRkRD",
          "GAUgASgNEh8KBXN0YXRlGA0gASgOMhAuRXhwZWRpdGlvblN0YXRlEhQKDGNo",
          "YWxsZW5nZV9pZBgJIAEoDUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ExpeditionStateReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ExpeditionPathInfo), global::ExpeditionPathInfo.Parser, new[]{ "StartTime", "BonusProbability", "AvatarIdList", "PathId", "Unk3300AIEJKADFLKG", "Unk3300LKAHOEBNBBI", "Unk3300AFGPGIIGAKA", "Unk3300LFIFDGAGFDC", "State", "ChallengeId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ExpeditionPathInfo : pb::IMessage<ExpeditionPathInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ExpeditionPathInfo> _parser = new pb::MessageParser<ExpeditionPathInfo>(() => new ExpeditionPathInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ExpeditionPathInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ExpeditionPathInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExpeditionPathInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExpeditionPathInfo(ExpeditionPathInfo other) : this() {
    startTime_ = other.startTime_;
    bonusProbability_ = other.bonusProbability_;
    avatarIdList_ = other.avatarIdList_.Clone();
    pathId_ = other.pathId_;
    unk3300AIEJKADFLKG_ = other.unk3300AIEJKADFLKG_;
    unk3300LKAHOEBNBBI_ = other.unk3300LKAHOEBNBBI_;
    unk3300AFGPGIIGAKA_ = other.unk3300AFGPGIIGAKA_;
    unk3300LFIFDGAGFDC_ = other.unk3300LFIFDGAGFDC_;
    state_ = other.state_;
    challengeId_ = other.challengeId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExpeditionPathInfo Clone() {
    return new ExpeditionPathInfo(this);
  }

  /// <summary>Field number for the "start_time" field.</summary>
  public const int StartTimeFieldNumber = 10;
  private uint startTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StartTime {
    get { return startTime_; }
    set {
      startTime_ = value;
    }
  }

  /// <summary>Field number for the "bonus_probability" field.</summary>
  public const int BonusProbabilityFieldNumber = 12;
  private float bonusProbability_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float BonusProbability {
    get { return bonusProbability_; }
    set {
      bonusProbability_ = value;
    }
  }

  /// <summary>Field number for the "avatar_id_list" field.</summary>
  public const int AvatarIdListFieldNumber = 8;
  private static readonly pb::FieldCodec<uint> _repeated_avatarIdList_codec
      = pb::FieldCodec.ForUInt32(66);
  private readonly pbc::RepeatedField<uint> avatarIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> AvatarIdList {
    get { return avatarIdList_; }
  }

  /// <summary>Field number for the "path_id" field.</summary>
  public const int PathIdFieldNumber = 11;
  private uint pathId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PathId {
    get { return pathId_; }
    set {
      pathId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_AIEJKADFLKG" field.</summary>
  public const int Unk3300AIEJKADFLKGFieldNumber = 6;
  private uint unk3300AIEJKADFLKG_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300AIEJKADFLKG {
    get { return unk3300AIEJKADFLKG_; }
    set {
      unk3300AIEJKADFLKG_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_LKAHOEBNBBI" field.</summary>
  public const int Unk3300LKAHOEBNBBIFieldNumber = 14;
  private uint unk3300LKAHOEBNBBI_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300LKAHOEBNBBI {
    get { return unk3300LKAHOEBNBBI_; }
    set {
      unk3300LKAHOEBNBBI_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_AFGPGIIGAKA" field.</summary>
  public const int Unk3300AFGPGIIGAKAFieldNumber = 7;
  private uint unk3300AFGPGIIGAKA_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300AFGPGIIGAKA {
    get { return unk3300AFGPGIIGAKA_; }
    set {
      unk3300AFGPGIIGAKA_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_LFIFDGAGFDC" field.</summary>
  public const int Unk3300LFIFDGAGFDCFieldNumber = 5;
  private uint unk3300LFIFDGAGFDC_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300LFIFDGAGFDC {
    get { return unk3300LFIFDGAGFDC_; }
    set {
      unk3300LFIFDGAGFDC_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 13;
  private global::ExpeditionState state_ = global::ExpeditionState.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ExpeditionState State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  /// <summary>Field number for the "challenge_id" field.</summary>
  public const int ChallengeIdFieldNumber = 9;
  private uint challengeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChallengeId {
    get { return challengeId_; }
    set {
      challengeId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ExpeditionPathInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ExpeditionPathInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StartTime != other.StartTime) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BonusProbability, other.BonusProbability)) return false;
    if(!avatarIdList_.Equals(other.avatarIdList_)) return false;
    if (PathId != other.PathId) return false;
    if (Unk3300AIEJKADFLKG != other.Unk3300AIEJKADFLKG) return false;
    if (Unk3300LKAHOEBNBBI != other.Unk3300LKAHOEBNBBI) return false;
    if (Unk3300AFGPGIIGAKA != other.Unk3300AFGPGIIGAKA) return false;
    if (Unk3300LFIFDGAGFDC != other.Unk3300LFIFDGAGFDC) return false;
    if (State != other.State) return false;
    if (ChallengeId != other.ChallengeId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StartTime != 0) hash ^= StartTime.GetHashCode();
    if (BonusProbability != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BonusProbability);
    hash ^= avatarIdList_.GetHashCode();
    if (PathId != 0) hash ^= PathId.GetHashCode();
    if (Unk3300AIEJKADFLKG != 0) hash ^= Unk3300AIEJKADFLKG.GetHashCode();
    if (Unk3300LKAHOEBNBBI != 0) hash ^= Unk3300LKAHOEBNBBI.GetHashCode();
    if (Unk3300AFGPGIIGAKA != 0) hash ^= Unk3300AFGPGIIGAKA.GetHashCode();
    if (Unk3300LFIFDGAGFDC != 0) hash ^= Unk3300LFIFDGAGFDC.GetHashCode();
    if (State != global::ExpeditionState.None) hash ^= State.GetHashCode();
    if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
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
    if (Unk3300LFIFDGAGFDC != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Unk3300LFIFDGAGFDC);
    }
    if (Unk3300AIEJKADFLKG != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300AIEJKADFLKG);
    }
    if (Unk3300AFGPGIIGAKA != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Unk3300AFGPGIIGAKA);
    }
    avatarIdList_.WriteTo(output, _repeated_avatarIdList_codec);
    if (ChallengeId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ChallengeId);
    }
    if (StartTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StartTime);
    }
    if (PathId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(PathId);
    }
    if (BonusProbability != 0F) {
      output.WriteRawTag(101);
      output.WriteFloat(BonusProbability);
    }
    if (State != global::ExpeditionState.None) {
      output.WriteRawTag(104);
      output.WriteEnum((int) State);
    }
    if (Unk3300LKAHOEBNBBI != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300LKAHOEBNBBI);
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
    if (Unk3300LFIFDGAGFDC != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Unk3300LFIFDGAGFDC);
    }
    if (Unk3300AIEJKADFLKG != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300AIEJKADFLKG);
    }
    if (Unk3300AFGPGIIGAKA != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Unk3300AFGPGIIGAKA);
    }
    avatarIdList_.WriteTo(ref output, _repeated_avatarIdList_codec);
    if (ChallengeId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ChallengeId);
    }
    if (StartTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StartTime);
    }
    if (PathId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(PathId);
    }
    if (BonusProbability != 0F) {
      output.WriteRawTag(101);
      output.WriteFloat(BonusProbability);
    }
    if (State != global::ExpeditionState.None) {
      output.WriteRawTag(104);
      output.WriteEnum((int) State);
    }
    if (Unk3300LKAHOEBNBBI != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300LKAHOEBNBBI);
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
    if (StartTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
    }
    if (BonusProbability != 0F) {
      size += 1 + 4;
    }
    size += avatarIdList_.CalculateSize(_repeated_avatarIdList_codec);
    if (PathId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PathId);
    }
    if (Unk3300AIEJKADFLKG != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AIEJKADFLKG);
    }
    if (Unk3300LKAHOEBNBBI != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LKAHOEBNBBI);
    }
    if (Unk3300AFGPGIIGAKA != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AFGPGIIGAKA);
    }
    if (Unk3300LFIFDGAGFDC != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LFIFDGAGFDC);
    }
    if (State != global::ExpeditionState.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (ChallengeId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ExpeditionPathInfo other) {
    if (other == null) {
      return;
    }
    if (other.StartTime != 0) {
      StartTime = other.StartTime;
    }
    if (other.BonusProbability != 0F) {
      BonusProbability = other.BonusProbability;
    }
    avatarIdList_.Add(other.avatarIdList_);
    if (other.PathId != 0) {
      PathId = other.PathId;
    }
    if (other.Unk3300AIEJKADFLKG != 0) {
      Unk3300AIEJKADFLKG = other.Unk3300AIEJKADFLKG;
    }
    if (other.Unk3300LKAHOEBNBBI != 0) {
      Unk3300LKAHOEBNBBI = other.Unk3300LKAHOEBNBBI;
    }
    if (other.Unk3300AFGPGIIGAKA != 0) {
      Unk3300AFGPGIIGAKA = other.Unk3300AFGPGIIGAKA;
    }
    if (other.Unk3300LFIFDGAGFDC != 0) {
      Unk3300LFIFDGAGFDC = other.Unk3300LFIFDGAGFDC;
    }
    if (other.State != global::ExpeditionState.None) {
      State = other.State;
    }
    if (other.ChallengeId != 0) {
      ChallengeId = other.ChallengeId;
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
          Unk3300LFIFDGAGFDC = input.ReadUInt32();
          break;
        }
        case 48: {
          Unk3300AIEJKADFLKG = input.ReadUInt32();
          break;
        }
        case 56: {
          Unk3300AFGPGIIGAKA = input.ReadUInt32();
          break;
        }
        case 66:
        case 64: {
          avatarIdList_.AddEntriesFrom(input, _repeated_avatarIdList_codec);
          break;
        }
        case 72: {
          ChallengeId = input.ReadUInt32();
          break;
        }
        case 80: {
          StartTime = input.ReadUInt32();
          break;
        }
        case 88: {
          PathId = input.ReadUInt32();
          break;
        }
        case 101: {
          BonusProbability = input.ReadFloat();
          break;
        }
        case 104: {
          State = (global::ExpeditionState) input.ReadEnum();
          break;
        }
        case 112: {
          Unk3300LKAHOEBNBBI = input.ReadUInt32();
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
          Unk3300LFIFDGAGFDC = input.ReadUInt32();
          break;
        }
        case 48: {
          Unk3300AIEJKADFLKG = input.ReadUInt32();
          break;
        }
        case 56: {
          Unk3300AFGPGIIGAKA = input.ReadUInt32();
          break;
        }
        case 66:
        case 64: {
          avatarIdList_.AddEntriesFrom(ref input, _repeated_avatarIdList_codec);
          break;
        }
        case 72: {
          ChallengeId = input.ReadUInt32();
          break;
        }
        case 80: {
          StartTime = input.ReadUInt32();
          break;
        }
        case 88: {
          PathId = input.ReadUInt32();
          break;
        }
        case 101: {
          BonusProbability = input.ReadFloat();
          break;
        }
        case 104: {
          State = (global::ExpeditionState) input.ReadEnum();
          break;
        }
        case 112: {
          Unk3300LKAHOEBNBBI = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
