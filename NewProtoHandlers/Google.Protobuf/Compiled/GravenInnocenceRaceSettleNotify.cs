// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GravenInnocenceRaceSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GravenInnocenceRaceSettleNotify.proto</summary>
public static partial class GravenInnocenceRaceSettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for GravenInnocenceRaceSettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GravenInnocenceRaceSettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVHcmF2ZW5Jbm5vY2VuY2VSYWNlU2V0dGxlTm90aWZ5LnByb3RvGhdHYWxs",
          "ZXJ5U3RvcFJlYXNvbi5wcm90byKRAgofR3JhdmVuSW5ub2NlbmNlUmFjZVNl",
          "dHRsZU5vdGlmeRISCgpnYWxsZXJ5X2lkGAkgASgNEhUKDWlzX25ld19yZWNv",
          "cmQYAyABKAgSEAoIbGV2ZWxfaWQYCyABKA0SGwoTVW5rMzMwMF9CT0lQSE9Q",
          "TUhKTRgIIAEoDRINCgVzY29yZRgEIAEoDRISCgppc19zdWNjZXNzGAogASgI",
          "EiIKBnJlYXNvbhgMIAEoDjISLkdhbGxlcnlTdG9wUmVhc29uEhsKE1VuazMz",
          "MDBfSVBHSktLRkRQSkoYBiABKA0SEwoLcmVtYWluX3RpbWUYAiABKA0SGwoT",
          "VW5rMzMwMF9PSEFISEtOQUpLTBgHIAEoDUIWChRvcmcuc29yYXBvaW50YS5w",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GalleryStopReasonReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GravenInnocenceRaceSettleNotify), global::GravenInnocenceRaceSettleNotify.Parser, new[]{ "GalleryId", "IsNewRecord", "LevelId", "Unk3300BOIPHOPMHJM", "Score", "IsSuccess", "Reason", "Unk3300IPGJKKFDPJJ", "RemainTime", "Unk3300OHAHHKNAJKL" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 24427;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GravenInnocenceRaceSettleNotify : pb::IMessage<GravenInnocenceRaceSettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GravenInnocenceRaceSettleNotify> _parser = new pb::MessageParser<GravenInnocenceRaceSettleNotify>(() => new GravenInnocenceRaceSettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GravenInnocenceRaceSettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GravenInnocenceRaceSettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GravenInnocenceRaceSettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GravenInnocenceRaceSettleNotify(GravenInnocenceRaceSettleNotify other) : this() {
    galleryId_ = other.galleryId_;
    isNewRecord_ = other.isNewRecord_;
    levelId_ = other.levelId_;
    unk3300BOIPHOPMHJM_ = other.unk3300BOIPHOPMHJM_;
    score_ = other.score_;
    isSuccess_ = other.isSuccess_;
    reason_ = other.reason_;
    unk3300IPGJKKFDPJJ_ = other.unk3300IPGJKKFDPJJ_;
    remainTime_ = other.remainTime_;
    unk3300OHAHHKNAJKL_ = other.unk3300OHAHHKNAJKL_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GravenInnocenceRaceSettleNotify Clone() {
    return new GravenInnocenceRaceSettleNotify(this);
  }

  /// <summary>Field number for the "gallery_id" field.</summary>
  public const int GalleryIdFieldNumber = 9;
  private uint galleryId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GalleryId {
    get { return galleryId_; }
    set {
      galleryId_ = value;
    }
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 3;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 11;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_BOIPHOPMHJM" field.</summary>
  public const int Unk3300BOIPHOPMHJMFieldNumber = 8;
  private uint unk3300BOIPHOPMHJM_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300BOIPHOPMHJM {
    get { return unk3300BOIPHOPMHJM_; }
    set {
      unk3300BOIPHOPMHJM_ = value;
    }
  }

  /// <summary>Field number for the "score" field.</summary>
  public const int ScoreFieldNumber = 4;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  /// <summary>Field number for the "is_success" field.</summary>
  public const int IsSuccessFieldNumber = 10;
  private bool isSuccess_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSuccess {
    get { return isSuccess_; }
    set {
      isSuccess_ = value;
    }
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 12;
  private global::GalleryStopReason reason_ = global::GalleryStopReason.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GalleryStopReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_IPGJKKFDPJJ" field.</summary>
  public const int Unk3300IPGJKKFDPJJFieldNumber = 6;
  private uint unk3300IPGJKKFDPJJ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300IPGJKKFDPJJ {
    get { return unk3300IPGJKKFDPJJ_; }
    set {
      unk3300IPGJKKFDPJJ_ = value;
    }
  }

  /// <summary>Field number for the "remain_time" field.</summary>
  public const int RemainTimeFieldNumber = 2;
  private uint remainTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RemainTime {
    get { return remainTime_; }
    set {
      remainTime_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_OHAHHKNAJKL" field.</summary>
  public const int Unk3300OHAHHKNAJKLFieldNumber = 7;
  private uint unk3300OHAHHKNAJKL_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300OHAHHKNAJKL {
    get { return unk3300OHAHHKNAJKL_; }
    set {
      unk3300OHAHHKNAJKL_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GravenInnocenceRaceSettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GravenInnocenceRaceSettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GalleryId != other.GalleryId) return false;
    if (IsNewRecord != other.IsNewRecord) return false;
    if (LevelId != other.LevelId) return false;
    if (Unk3300BOIPHOPMHJM != other.Unk3300BOIPHOPMHJM) return false;
    if (Score != other.Score) return false;
    if (IsSuccess != other.IsSuccess) return false;
    if (Reason != other.Reason) return false;
    if (Unk3300IPGJKKFDPJJ != other.Unk3300IPGJKKFDPJJ) return false;
    if (RemainTime != other.RemainTime) return false;
    if (Unk3300OHAHHKNAJKL != other.Unk3300OHAHHKNAJKL) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (Unk3300BOIPHOPMHJM != 0) hash ^= Unk3300BOIPHOPMHJM.GetHashCode();
    if (Score != 0) hash ^= Score.GetHashCode();
    if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
    if (Reason != global::GalleryStopReason.None) hash ^= Reason.GetHashCode();
    if (Unk3300IPGJKKFDPJJ != 0) hash ^= Unk3300IPGJKKFDPJJ.GetHashCode();
    if (RemainTime != 0) hash ^= RemainTime.GetHashCode();
    if (Unk3300OHAHHKNAJKL != 0) hash ^= Unk3300OHAHHKNAJKL.GetHashCode();
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
    if (RemainTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(RemainTime);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsNewRecord);
    }
    if (Score != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Score);
    }
    if (Unk3300IPGJKKFDPJJ != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300IPGJKKFDPJJ);
    }
    if (Unk3300OHAHHKNAJKL != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Unk3300OHAHHKNAJKL);
    }
    if (Unk3300BOIPHOPMHJM != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Unk3300BOIPHOPMHJM);
    }
    if (GalleryId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(GalleryId);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsSuccess);
    }
    if (LevelId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(LevelId);
    }
    if (Reason != global::GalleryStopReason.None) {
      output.WriteRawTag(96);
      output.WriteEnum((int) Reason);
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
    if (RemainTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(RemainTime);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsNewRecord);
    }
    if (Score != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Score);
    }
    if (Unk3300IPGJKKFDPJJ != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300IPGJKKFDPJJ);
    }
    if (Unk3300OHAHHKNAJKL != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Unk3300OHAHHKNAJKL);
    }
    if (Unk3300BOIPHOPMHJM != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Unk3300BOIPHOPMHJM);
    }
    if (GalleryId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(GalleryId);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsSuccess);
    }
    if (LevelId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(LevelId);
    }
    if (Reason != global::GalleryStopReason.None) {
      output.WriteRawTag(96);
      output.WriteEnum((int) Reason);
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
    if (GalleryId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
    }
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (Unk3300BOIPHOPMHJM != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BOIPHOPMHJM);
    }
    if (Score != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
    }
    if (IsSuccess != false) {
      size += 1 + 1;
    }
    if (Reason != global::GalleryStopReason.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (Unk3300IPGJKKFDPJJ != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IPGJKKFDPJJ);
    }
    if (RemainTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainTime);
    }
    if (Unk3300OHAHHKNAJKL != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OHAHHKNAJKL);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GravenInnocenceRaceSettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.GalleryId != 0) {
      GalleryId = other.GalleryId;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.Unk3300BOIPHOPMHJM != 0) {
      Unk3300BOIPHOPMHJM = other.Unk3300BOIPHOPMHJM;
    }
    if (other.Score != 0) {
      Score = other.Score;
    }
    if (other.IsSuccess != false) {
      IsSuccess = other.IsSuccess;
    }
    if (other.Reason != global::GalleryStopReason.None) {
      Reason = other.Reason;
    }
    if (other.Unk3300IPGJKKFDPJJ != 0) {
      Unk3300IPGJKKFDPJJ = other.Unk3300IPGJKKFDPJJ;
    }
    if (other.RemainTime != 0) {
      RemainTime = other.RemainTime;
    }
    if (other.Unk3300OHAHHKNAJKL != 0) {
      Unk3300OHAHHKNAJKL = other.Unk3300OHAHHKNAJKL;
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
          RemainTime = input.ReadUInt32();
          break;
        }
        case 24: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 32: {
          Score = input.ReadUInt32();
          break;
        }
        case 48: {
          Unk3300IPGJKKFDPJJ = input.ReadUInt32();
          break;
        }
        case 56: {
          Unk3300OHAHHKNAJKL = input.ReadUInt32();
          break;
        }
        case 64: {
          Unk3300BOIPHOPMHJM = input.ReadUInt32();
          break;
        }
        case 72: {
          GalleryId = input.ReadUInt32();
          break;
        }
        case 80: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 88: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 96: {
          Reason = (global::GalleryStopReason) input.ReadEnum();
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
          RemainTime = input.ReadUInt32();
          break;
        }
        case 24: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 32: {
          Score = input.ReadUInt32();
          break;
        }
        case 48: {
          Unk3300IPGJKKFDPJJ = input.ReadUInt32();
          break;
        }
        case 56: {
          Unk3300OHAHHKNAJKL = input.ReadUInt32();
          break;
        }
        case 64: {
          Unk3300BOIPHOPMHJM = input.ReadUInt32();
          break;
        }
        case 72: {
          GalleryId = input.ReadUInt32();
          break;
        }
        case 80: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 88: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 96: {
          Reason = (global::GalleryStopReason) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code