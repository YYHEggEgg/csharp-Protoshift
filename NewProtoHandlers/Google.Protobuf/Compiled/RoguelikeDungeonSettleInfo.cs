// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoguelikeDungeonSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RoguelikeDungeonSettleInfo.proto</summary>
public static partial class RoguelikeDungeonSettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for RoguelikeDungeonSettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RoguelikeDungeonSettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBSb2d1ZWxpa2VEdW5nZW9uU2V0dGxlSW5mby5wcm90bxodUm9ndWVsaWtl",
          "U2V0dGxlQ29pbkluZm8ucHJvdG8i+gIKGlJvZ3VlbGlrZUR1bmdlb25TZXR0",
          "bGVJbmZvEhAKCHN0YWdlX2lkGAkgASgNEhsKE1VuazMzMDBfR01NRUNNUERK",
          "TUkYCCABKA0SGwoTVW5rMzMwMF9QQkVMTU9KS0tIUBgEIAEoDRIRCgljdXJf",
          "bGV2ZWwYDiABKA0SGwoTVW5rMzMwMF9BSElFRU5HS1BGQRgKIAEoCBIbChNV",
          "bmszMzAwX0JQTEtKTUlPS0hNGA8gASgIEmUKH2ZpbmlzaGVkX2NoYWxsZW5n",
          "ZV9jZWxsX251bV9tYXAYBiADKAsyPC5Sb2d1ZWxpa2VEdW5nZW9uU2V0dGxl",
          "SW5mby5GaW5pc2hlZENoYWxsZW5nZUNlbGxOdW1NYXBFbnRyeRpcCiBGaW5p",
          "c2hlZENoYWxsZW5nZUNlbGxOdW1NYXBFbnRyeRILCgNrZXkYASABKA0SJwoF",
          "dmFsdWUYAiABKAsyGC5Sb2d1ZWxpa2VTZXR0bGVDb2luSW5mbzoCOAFCFgoU",
          "b3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::RoguelikeSettleCoinInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RoguelikeDungeonSettleInfo), global::RoguelikeDungeonSettleInfo.Parser, new[]{ "StageId", "Unk3300GMMECMPDJMI", "Unk3300PBELMOJKKHP", "CurLevel", "Unk3300AHIEENGKPFA", "Unk3300BPLKJMIOKHM", "FinishedChallengeCellNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RoguelikeDungeonSettleInfo : pb::IMessage<RoguelikeDungeonSettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RoguelikeDungeonSettleInfo> _parser = new pb::MessageParser<RoguelikeDungeonSettleInfo>(() => new RoguelikeDungeonSettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RoguelikeDungeonSettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RoguelikeDungeonSettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeDungeonSettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeDungeonSettleInfo(RoguelikeDungeonSettleInfo other) : this() {
    stageId_ = other.stageId_;
    unk3300GMMECMPDJMI_ = other.unk3300GMMECMPDJMI_;
    unk3300PBELMOJKKHP_ = other.unk3300PBELMOJKKHP_;
    curLevel_ = other.curLevel_;
    unk3300AHIEENGKPFA_ = other.unk3300AHIEENGKPFA_;
    unk3300BPLKJMIOKHM_ = other.unk3300BPLKJMIOKHM_;
    finishedChallengeCellNumMap_ = other.finishedChallengeCellNumMap_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeDungeonSettleInfo Clone() {
    return new RoguelikeDungeonSettleInfo(this);
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 9;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_GMMECMPDJMI" field.</summary>
  public const int Unk3300GMMECMPDJMIFieldNumber = 8;
  private uint unk3300GMMECMPDJMI_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300GMMECMPDJMI {
    get { return unk3300GMMECMPDJMI_; }
    set {
      unk3300GMMECMPDJMI_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_PBELMOJKKHP" field.</summary>
  public const int Unk3300PBELMOJKKHPFieldNumber = 4;
  private uint unk3300PBELMOJKKHP_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300PBELMOJKKHP {
    get { return unk3300PBELMOJKKHP_; }
    set {
      unk3300PBELMOJKKHP_ = value;
    }
  }

  /// <summary>Field number for the "cur_level" field.</summary>
  public const int CurLevelFieldNumber = 14;
  private uint curLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurLevel {
    get { return curLevel_; }
    set {
      curLevel_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_AHIEENGKPFA" field.</summary>
  public const int Unk3300AHIEENGKPFAFieldNumber = 10;
  private bool unk3300AHIEENGKPFA_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300AHIEENGKPFA {
    get { return unk3300AHIEENGKPFA_; }
    set {
      unk3300AHIEENGKPFA_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_BPLKJMIOKHM" field.</summary>
  public const int Unk3300BPLKJMIOKHMFieldNumber = 15;
  private bool unk3300BPLKJMIOKHM_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300BPLKJMIOKHM {
    get { return unk3300BPLKJMIOKHM_; }
    set {
      unk3300BPLKJMIOKHM_ = value;
    }
  }

  /// <summary>Field number for the "finished_challenge_cell_num_map" field.</summary>
  public const int FinishedChallengeCellNumMapFieldNumber = 6;
  private static readonly pbc::MapField<uint, global::RoguelikeSettleCoinInfo>.Codec _map_finishedChallengeCellNumMap_codec
      = new pbc::MapField<uint, global::RoguelikeSettleCoinInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::RoguelikeSettleCoinInfo.Parser), 50);
  private readonly pbc::MapField<uint, global::RoguelikeSettleCoinInfo> finishedChallengeCellNumMap_ = new pbc::MapField<uint, global::RoguelikeSettleCoinInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::RoguelikeSettleCoinInfo> FinishedChallengeCellNumMap {
    get { return finishedChallengeCellNumMap_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RoguelikeDungeonSettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RoguelikeDungeonSettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StageId != other.StageId) return false;
    if (Unk3300GMMECMPDJMI != other.Unk3300GMMECMPDJMI) return false;
    if (Unk3300PBELMOJKKHP != other.Unk3300PBELMOJKKHP) return false;
    if (CurLevel != other.CurLevel) return false;
    if (Unk3300AHIEENGKPFA != other.Unk3300AHIEENGKPFA) return false;
    if (Unk3300BPLKJMIOKHM != other.Unk3300BPLKJMIOKHM) return false;
    if (!FinishedChallengeCellNumMap.Equals(other.FinishedChallengeCellNumMap)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StageId != 0) hash ^= StageId.GetHashCode();
    if (Unk3300GMMECMPDJMI != 0) hash ^= Unk3300GMMECMPDJMI.GetHashCode();
    if (Unk3300PBELMOJKKHP != 0) hash ^= Unk3300PBELMOJKKHP.GetHashCode();
    if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
    if (Unk3300AHIEENGKPFA != false) hash ^= Unk3300AHIEENGKPFA.GetHashCode();
    if (Unk3300BPLKJMIOKHM != false) hash ^= Unk3300BPLKJMIOKHM.GetHashCode();
    hash ^= FinishedChallengeCellNumMap.GetHashCode();
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
    if (Unk3300PBELMOJKKHP != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Unk3300PBELMOJKKHP);
    }
    finishedChallengeCellNumMap_.WriteTo(output, _map_finishedChallengeCellNumMap_codec);
    if (Unk3300GMMECMPDJMI != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Unk3300GMMECMPDJMI);
    }
    if (StageId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(StageId);
    }
    if (Unk3300AHIEENGKPFA != false) {
      output.WriteRawTag(80);
      output.WriteBool(Unk3300AHIEENGKPFA);
    }
    if (CurLevel != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CurLevel);
    }
    if (Unk3300BPLKJMIOKHM != false) {
      output.WriteRawTag(120);
      output.WriteBool(Unk3300BPLKJMIOKHM);
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
    if (Unk3300PBELMOJKKHP != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Unk3300PBELMOJKKHP);
    }
    finishedChallengeCellNumMap_.WriteTo(ref output, _map_finishedChallengeCellNumMap_codec);
    if (Unk3300GMMECMPDJMI != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Unk3300GMMECMPDJMI);
    }
    if (StageId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(StageId);
    }
    if (Unk3300AHIEENGKPFA != false) {
      output.WriteRawTag(80);
      output.WriteBool(Unk3300AHIEENGKPFA);
    }
    if (CurLevel != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CurLevel);
    }
    if (Unk3300BPLKJMIOKHM != false) {
      output.WriteRawTag(120);
      output.WriteBool(Unk3300BPLKJMIOKHM);
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
    if (StageId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
    }
    if (Unk3300GMMECMPDJMI != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GMMECMPDJMI);
    }
    if (Unk3300PBELMOJKKHP != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PBELMOJKKHP);
    }
    if (CurLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
    }
    if (Unk3300AHIEENGKPFA != false) {
      size += 1 + 1;
    }
    if (Unk3300BPLKJMIOKHM != false) {
      size += 1 + 1;
    }
    size += finishedChallengeCellNumMap_.CalculateSize(_map_finishedChallengeCellNumMap_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RoguelikeDungeonSettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    if (other.Unk3300GMMECMPDJMI != 0) {
      Unk3300GMMECMPDJMI = other.Unk3300GMMECMPDJMI;
    }
    if (other.Unk3300PBELMOJKKHP != 0) {
      Unk3300PBELMOJKKHP = other.Unk3300PBELMOJKKHP;
    }
    if (other.CurLevel != 0) {
      CurLevel = other.CurLevel;
    }
    if (other.Unk3300AHIEENGKPFA != false) {
      Unk3300AHIEENGKPFA = other.Unk3300AHIEENGKPFA;
    }
    if (other.Unk3300BPLKJMIOKHM != false) {
      Unk3300BPLKJMIOKHM = other.Unk3300BPLKJMIOKHM;
    }
    finishedChallengeCellNumMap_.Add(other.finishedChallengeCellNumMap_);
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
          Unk3300PBELMOJKKHP = input.ReadUInt32();
          break;
        }
        case 50: {
          finishedChallengeCellNumMap_.AddEntriesFrom(input, _map_finishedChallengeCellNumMap_codec);
          break;
        }
        case 64: {
          Unk3300GMMECMPDJMI = input.ReadUInt32();
          break;
        }
        case 72: {
          StageId = input.ReadUInt32();
          break;
        }
        case 80: {
          Unk3300AHIEENGKPFA = input.ReadBool();
          break;
        }
        case 112: {
          CurLevel = input.ReadUInt32();
          break;
        }
        case 120: {
          Unk3300BPLKJMIOKHM = input.ReadBool();
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
          Unk3300PBELMOJKKHP = input.ReadUInt32();
          break;
        }
        case 50: {
          finishedChallengeCellNumMap_.AddEntriesFrom(ref input, _map_finishedChallengeCellNumMap_codec);
          break;
        }
        case 64: {
          Unk3300GMMECMPDJMI = input.ReadUInt32();
          break;
        }
        case 72: {
          StageId = input.ReadUInt32();
          break;
        }
        case 80: {
          Unk3300AHIEENGKPFA = input.ReadBool();
          break;
        }
        case 112: {
          CurLevel = input.ReadUInt32();
          break;
        }
        case 120: {
          Unk3300BPLKJMIOKHM = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
