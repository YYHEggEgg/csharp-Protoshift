// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FungusFighterTrainingGallerySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from FungusFighterTrainingGallerySettleNotify.proto</summary>
public static partial class FungusFighterTrainingGallerySettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for FungusFighterTrainingGallerySettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FungusFighterTrainingGallerySettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ci5GdW5ndXNGaWdodGVyVHJhaW5pbmdHYWxsZXJ5U2V0dGxlTm90aWZ5LnBy",
          "b3RvGhdHYWxsZXJ5U3RvcFJlYXNvbi5wcm90byL7AQooRnVuZ3VzRmlnaHRl",
          "clRyYWluaW5nR2FsbGVyeVNldHRsZU5vdGlmeRIVCg1pc19uZXdfcmVjb3Jk",
          "GA4gASgIEhcKD3RvdGFsX3VzZWRfdGltZRgEIAEoDRIiCgZyZWFzb24YBSAB",
          "KA4yEi5HYWxsZXJ5U3RvcFJlYXNvbhIXCg9kZWFkX2Z1bmd1c19udW0YASAB",
          "KA0SFAoMc2V0dGxlX3JvdW5kGA8gASgNEhcKD2lzX2ZpbmFsX3NldHRsZRgK",
          "IAEoCBIeChZnYWRnZXRfbGlmZV9wZXJjZW50YWdlGAsgASgNEhMKC2ZpbmFs",
          "X3Njb3JlGAkgASgNQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9i",
          "BnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GalleryStopReasonReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FungusFighterTrainingGallerySettleNotify), global::FungusFighterTrainingGallerySettleNotify.Parser, new[]{ "IsNewRecord", "TotalUsedTime", "Reason", "DeadFungusNum", "SettleRound", "IsFinalSettle", "GadgetLifePercentage", "FinalScore" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 23931
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class FungusFighterTrainingGallerySettleNotify : pb::IMessage<FungusFighterTrainingGallerySettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<FungusFighterTrainingGallerySettleNotify> _parser = new pb::MessageParser<FungusFighterTrainingGallerySettleNotify>(() => new FungusFighterTrainingGallerySettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<FungusFighterTrainingGallerySettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FungusFighterTrainingGallerySettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FungusFighterTrainingGallerySettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FungusFighterTrainingGallerySettleNotify(FungusFighterTrainingGallerySettleNotify other) : this() {
    isNewRecord_ = other.isNewRecord_;
    totalUsedTime_ = other.totalUsedTime_;
    reason_ = other.reason_;
    deadFungusNum_ = other.deadFungusNum_;
    settleRound_ = other.settleRound_;
    isFinalSettle_ = other.isFinalSettle_;
    gadgetLifePercentage_ = other.gadgetLifePercentage_;
    finalScore_ = other.finalScore_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FungusFighterTrainingGallerySettleNotify Clone() {
    return new FungusFighterTrainingGallerySettleNotify(this);
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 14;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  /// <summary>Field number for the "total_used_time" field.</summary>
  public const int TotalUsedTimeFieldNumber = 4;
  private uint totalUsedTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalUsedTime {
    get { return totalUsedTime_; }
    set {
      totalUsedTime_ = value;
    }
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 5;
  private global::GalleryStopReason reason_ = global::GalleryStopReason.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GalleryStopReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "dead_fungus_num" field.</summary>
  public const int DeadFungusNumFieldNumber = 1;
  private uint deadFungusNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DeadFungusNum {
    get { return deadFungusNum_; }
    set {
      deadFungusNum_ = value;
    }
  }

  /// <summary>Field number for the "settle_round" field.</summary>
  public const int SettleRoundFieldNumber = 15;
  private uint settleRound_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SettleRound {
    get { return settleRound_; }
    set {
      settleRound_ = value;
    }
  }

  /// <summary>Field number for the "is_final_settle" field.</summary>
  public const int IsFinalSettleFieldNumber = 10;
  private bool isFinalSettle_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFinalSettle {
    get { return isFinalSettle_; }
    set {
      isFinalSettle_ = value;
    }
  }

  /// <summary>Field number for the "gadget_life_percentage" field.</summary>
  public const int GadgetLifePercentageFieldNumber = 11;
  private uint gadgetLifePercentage_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GadgetLifePercentage {
    get { return gadgetLifePercentage_; }
    set {
      gadgetLifePercentage_ = value;
    }
  }

  /// <summary>Field number for the "final_score" field.</summary>
  public const int FinalScoreFieldNumber = 9;
  private uint finalScore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FinalScore {
    get { return finalScore_; }
    set {
      finalScore_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as FungusFighterTrainingGallerySettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(FungusFighterTrainingGallerySettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsNewRecord != other.IsNewRecord) return false;
    if (TotalUsedTime != other.TotalUsedTime) return false;
    if (Reason != other.Reason) return false;
    if (DeadFungusNum != other.DeadFungusNum) return false;
    if (SettleRound != other.SettleRound) return false;
    if (IsFinalSettle != other.IsFinalSettle) return false;
    if (GadgetLifePercentage != other.GadgetLifePercentage) return false;
    if (FinalScore != other.FinalScore) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
    if (TotalUsedTime != 0) hash ^= TotalUsedTime.GetHashCode();
    if (Reason != global::GalleryStopReason.None) hash ^= Reason.GetHashCode();
    if (DeadFungusNum != 0) hash ^= DeadFungusNum.GetHashCode();
    if (SettleRound != 0) hash ^= SettleRound.GetHashCode();
    if (IsFinalSettle != false) hash ^= IsFinalSettle.GetHashCode();
    if (GadgetLifePercentage != 0) hash ^= GadgetLifePercentage.GetHashCode();
    if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
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
    if (DeadFungusNum != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(DeadFungusNum);
    }
    if (TotalUsedTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(TotalUsedTime);
    }
    if (Reason != global::GalleryStopReason.None) {
      output.WriteRawTag(40);
      output.WriteEnum((int) Reason);
    }
    if (FinalScore != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(FinalScore);
    }
    if (IsFinalSettle != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsFinalSettle);
    }
    if (GadgetLifePercentage != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(GadgetLifePercentage);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsNewRecord);
    }
    if (SettleRound != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(SettleRound);
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
    if (DeadFungusNum != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(DeadFungusNum);
    }
    if (TotalUsedTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(TotalUsedTime);
    }
    if (Reason != global::GalleryStopReason.None) {
      output.WriteRawTag(40);
      output.WriteEnum((int) Reason);
    }
    if (FinalScore != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(FinalScore);
    }
    if (IsFinalSettle != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsFinalSettle);
    }
    if (GadgetLifePercentage != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(GadgetLifePercentage);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsNewRecord);
    }
    if (SettleRound != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(SettleRound);
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
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (TotalUsedTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalUsedTime);
    }
    if (Reason != global::GalleryStopReason.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (DeadFungusNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DeadFungusNum);
    }
    if (SettleRound != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SettleRound);
    }
    if (IsFinalSettle != false) {
      size += 1 + 1;
    }
    if (GadgetLifePercentage != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetLifePercentage);
    }
    if (FinalScore != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(FungusFighterTrainingGallerySettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
    }
    if (other.TotalUsedTime != 0) {
      TotalUsedTime = other.TotalUsedTime;
    }
    if (other.Reason != global::GalleryStopReason.None) {
      Reason = other.Reason;
    }
    if (other.DeadFungusNum != 0) {
      DeadFungusNum = other.DeadFungusNum;
    }
    if (other.SettleRound != 0) {
      SettleRound = other.SettleRound;
    }
    if (other.IsFinalSettle != false) {
      IsFinalSettle = other.IsFinalSettle;
    }
    if (other.GadgetLifePercentage != 0) {
      GadgetLifePercentage = other.GadgetLifePercentage;
    }
    if (other.FinalScore != 0) {
      FinalScore = other.FinalScore;
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
          DeadFungusNum = input.ReadUInt32();
          break;
        }
        case 32: {
          TotalUsedTime = input.ReadUInt32();
          break;
        }
        case 40: {
          Reason = (global::GalleryStopReason) input.ReadEnum();
          break;
        }
        case 72: {
          FinalScore = input.ReadUInt32();
          break;
        }
        case 80: {
          IsFinalSettle = input.ReadBool();
          break;
        }
        case 88: {
          GadgetLifePercentage = input.ReadUInt32();
          break;
        }
        case 112: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 120: {
          SettleRound = input.ReadUInt32();
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
          DeadFungusNum = input.ReadUInt32();
          break;
        }
        case 32: {
          TotalUsedTime = input.ReadUInt32();
          break;
        }
        case 40: {
          Reason = (global::GalleryStopReason) input.ReadEnum();
          break;
        }
        case 72: {
          FinalScore = input.ReadUInt32();
          break;
        }
        case 80: {
          IsFinalSettle = input.ReadBool();
          break;
        }
        case 88: {
          GadgetLifePercentage = input.ReadUInt32();
          break;
        }
        case 112: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 120: {
          SettleRound = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
