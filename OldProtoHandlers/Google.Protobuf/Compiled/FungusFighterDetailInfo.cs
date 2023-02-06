// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FungusFighterDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from FungusFighterDetailInfo.proto</summary>
public static partial class FungusFighterDetailInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for FungusFighterDetailInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FungusFighterDetailInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1GdW5ndXNGaWdodGVyRGV0YWlsSW5mby5wcm90bxoSRnVuZ3VzRGV0YWls",
          "LnByb3RvGhtGdW5ndXNQbG90U3RhZ2VEZXRhaWwucHJvdG8aIUZ1bmd1c1Ry",
          "YWluaW5nRHVuZ2VvbkRldGFpbC5wcm90bxoiRnVuZ3VzVHJhaW5pbmdQcm9n",
          "cmVzc0RldGFpbC5wcm90byLqAgoXRnVuZ3VzRmlnaHRlckRldGFpbEluZm8S",
          "NgoWcGxvdF9zdGFnZV9kZXRhaWxfbGlzdBgGIAMoCzIWLkZ1bmd1c1Bsb3RT",
          "dGFnZURldGFpbBIpChJmdW5ndXNfZGV0YWlsX2xpc3QYBCADKAsyDS5GdW5n",
          "dXNEZXRhaWwSGwoTdW5sb2NrX2NhbXBfaWRfbGlzdBgMIAMoDRJMCiV0cmFp",
          "bmluZ19kdW5nZW9uX3Byb2dyZXNzX2RldGFpbF9saXN0GAMgAygLMh0uRnVu",
          "Z3VzVHJhaW5pbmdQcm9ncmVzc0RldGFpbBJCChx0cmFpbmluZ19kdW5nZW9u",
          "X2RldGFpbF9saXN0GA8gAygLMhwuRnVuZ3VzVHJhaW5pbmdEdW5nZW9uRGV0",
          "YWlsEhsKE2ZpbmlzaF9jYW1wX2lkX2xpc3QYASADKA0SIAoYdW5sb2NrX2N1",
          "bHRpdmF0ZV9pZF9saXN0GAggAygNQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQu",
          "b2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::FungusDetailReflection.Descriptor, global::FungusPlotStageDetailReflection.Descriptor, global::FungusTrainingDungeonDetailReflection.Descriptor, global::FungusTrainingProgressDetailReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FungusFighterDetailInfo), global::FungusFighterDetailInfo.Parser, new[]{ "PlotStageDetailList", "FungusDetailList", "UnlockCampIdList", "TrainingDungeonProgressDetailList", "TrainingDungeonDetailList", "FinishCampIdList", "UnlockCultivateIdList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class FungusFighterDetailInfo : pb::IMessage<FungusFighterDetailInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<FungusFighterDetailInfo> _parser = new pb::MessageParser<FungusFighterDetailInfo>(() => new FungusFighterDetailInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<FungusFighterDetailInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FungusFighterDetailInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FungusFighterDetailInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FungusFighterDetailInfo(FungusFighterDetailInfo other) : this() {
    plotStageDetailList_ = other.plotStageDetailList_.Clone();
    fungusDetailList_ = other.fungusDetailList_.Clone();
    unlockCampIdList_ = other.unlockCampIdList_.Clone();
    trainingDungeonProgressDetailList_ = other.trainingDungeonProgressDetailList_.Clone();
    trainingDungeonDetailList_ = other.trainingDungeonDetailList_.Clone();
    finishCampIdList_ = other.finishCampIdList_.Clone();
    unlockCultivateIdList_ = other.unlockCultivateIdList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FungusFighterDetailInfo Clone() {
    return new FungusFighterDetailInfo(this);
  }

  /// <summary>Field number for the "plot_stage_detail_list" field.</summary>
  public const int PlotStageDetailListFieldNumber = 6;
  private static readonly pb::FieldCodec<global::FungusPlotStageDetail> _repeated_plotStageDetailList_codec
      = pb::FieldCodec.ForMessage(50, global::FungusPlotStageDetail.Parser);
  private readonly pbc::RepeatedField<global::FungusPlotStageDetail> plotStageDetailList_ = new pbc::RepeatedField<global::FungusPlotStageDetail>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::FungusPlotStageDetail> PlotStageDetailList {
    get { return plotStageDetailList_; }
  }

  /// <summary>Field number for the "fungus_detail_list" field.</summary>
  public const int FungusDetailListFieldNumber = 4;
  private static readonly pb::FieldCodec<global::FungusDetail> _repeated_fungusDetailList_codec
      = pb::FieldCodec.ForMessage(34, global::FungusDetail.Parser);
  private readonly pbc::RepeatedField<global::FungusDetail> fungusDetailList_ = new pbc::RepeatedField<global::FungusDetail>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::FungusDetail> FungusDetailList {
    get { return fungusDetailList_; }
  }

  /// <summary>Field number for the "unlock_camp_id_list" field.</summary>
  public const int UnlockCampIdListFieldNumber = 12;
  private static readonly pb::FieldCodec<uint> _repeated_unlockCampIdList_codec
      = pb::FieldCodec.ForUInt32(98);
  private readonly pbc::RepeatedField<uint> unlockCampIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> UnlockCampIdList {
    get { return unlockCampIdList_; }
  }

  /// <summary>Field number for the "training_dungeon_progress_detail_list" field.</summary>
  public const int TrainingDungeonProgressDetailListFieldNumber = 3;
  private static readonly pb::FieldCodec<global::FungusTrainingProgressDetail> _repeated_trainingDungeonProgressDetailList_codec
      = pb::FieldCodec.ForMessage(26, global::FungusTrainingProgressDetail.Parser);
  private readonly pbc::RepeatedField<global::FungusTrainingProgressDetail> trainingDungeonProgressDetailList_ = new pbc::RepeatedField<global::FungusTrainingProgressDetail>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::FungusTrainingProgressDetail> TrainingDungeonProgressDetailList {
    get { return trainingDungeonProgressDetailList_; }
  }

  /// <summary>Field number for the "training_dungeon_detail_list" field.</summary>
  public const int TrainingDungeonDetailListFieldNumber = 15;
  private static readonly pb::FieldCodec<global::FungusTrainingDungeonDetail> _repeated_trainingDungeonDetailList_codec
      = pb::FieldCodec.ForMessage(122, global::FungusTrainingDungeonDetail.Parser);
  private readonly pbc::RepeatedField<global::FungusTrainingDungeonDetail> trainingDungeonDetailList_ = new pbc::RepeatedField<global::FungusTrainingDungeonDetail>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::FungusTrainingDungeonDetail> TrainingDungeonDetailList {
    get { return trainingDungeonDetailList_; }
  }

  /// <summary>Field number for the "finish_camp_id_list" field.</summary>
  public const int FinishCampIdListFieldNumber = 1;
  private static readonly pb::FieldCodec<uint> _repeated_finishCampIdList_codec
      = pb::FieldCodec.ForUInt32(10);
  private readonly pbc::RepeatedField<uint> finishCampIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> FinishCampIdList {
    get { return finishCampIdList_; }
  }

  /// <summary>Field number for the "unlock_cultivate_id_list" field.</summary>
  public const int UnlockCultivateIdListFieldNumber = 8;
  private static readonly pb::FieldCodec<uint> _repeated_unlockCultivateIdList_codec
      = pb::FieldCodec.ForUInt32(66);
  private readonly pbc::RepeatedField<uint> unlockCultivateIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> UnlockCultivateIdList {
    get { return unlockCultivateIdList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as FungusFighterDetailInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(FungusFighterDetailInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!plotStageDetailList_.Equals(other.plotStageDetailList_)) return false;
    if(!fungusDetailList_.Equals(other.fungusDetailList_)) return false;
    if(!unlockCampIdList_.Equals(other.unlockCampIdList_)) return false;
    if(!trainingDungeonProgressDetailList_.Equals(other.trainingDungeonProgressDetailList_)) return false;
    if(!trainingDungeonDetailList_.Equals(other.trainingDungeonDetailList_)) return false;
    if(!finishCampIdList_.Equals(other.finishCampIdList_)) return false;
    if(!unlockCultivateIdList_.Equals(other.unlockCultivateIdList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= plotStageDetailList_.GetHashCode();
    hash ^= fungusDetailList_.GetHashCode();
    hash ^= unlockCampIdList_.GetHashCode();
    hash ^= trainingDungeonProgressDetailList_.GetHashCode();
    hash ^= trainingDungeonDetailList_.GetHashCode();
    hash ^= finishCampIdList_.GetHashCode();
    hash ^= unlockCultivateIdList_.GetHashCode();
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
    finishCampIdList_.WriteTo(output, _repeated_finishCampIdList_codec);
    trainingDungeonProgressDetailList_.WriteTo(output, _repeated_trainingDungeonProgressDetailList_codec);
    fungusDetailList_.WriteTo(output, _repeated_fungusDetailList_codec);
    plotStageDetailList_.WriteTo(output, _repeated_plotStageDetailList_codec);
    unlockCultivateIdList_.WriteTo(output, _repeated_unlockCultivateIdList_codec);
    unlockCampIdList_.WriteTo(output, _repeated_unlockCampIdList_codec);
    trainingDungeonDetailList_.WriteTo(output, _repeated_trainingDungeonDetailList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    finishCampIdList_.WriteTo(ref output, _repeated_finishCampIdList_codec);
    trainingDungeonProgressDetailList_.WriteTo(ref output, _repeated_trainingDungeonProgressDetailList_codec);
    fungusDetailList_.WriteTo(ref output, _repeated_fungusDetailList_codec);
    plotStageDetailList_.WriteTo(ref output, _repeated_plotStageDetailList_codec);
    unlockCultivateIdList_.WriteTo(ref output, _repeated_unlockCultivateIdList_codec);
    unlockCampIdList_.WriteTo(ref output, _repeated_unlockCampIdList_codec);
    trainingDungeonDetailList_.WriteTo(ref output, _repeated_trainingDungeonDetailList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += plotStageDetailList_.CalculateSize(_repeated_plotStageDetailList_codec);
    size += fungusDetailList_.CalculateSize(_repeated_fungusDetailList_codec);
    size += unlockCampIdList_.CalculateSize(_repeated_unlockCampIdList_codec);
    size += trainingDungeonProgressDetailList_.CalculateSize(_repeated_trainingDungeonProgressDetailList_codec);
    size += trainingDungeonDetailList_.CalculateSize(_repeated_trainingDungeonDetailList_codec);
    size += finishCampIdList_.CalculateSize(_repeated_finishCampIdList_codec);
    size += unlockCultivateIdList_.CalculateSize(_repeated_unlockCultivateIdList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(FungusFighterDetailInfo other) {
    if (other == null) {
      return;
    }
    plotStageDetailList_.Add(other.plotStageDetailList_);
    fungusDetailList_.Add(other.fungusDetailList_);
    unlockCampIdList_.Add(other.unlockCampIdList_);
    trainingDungeonProgressDetailList_.Add(other.trainingDungeonProgressDetailList_);
    trainingDungeonDetailList_.Add(other.trainingDungeonDetailList_);
    finishCampIdList_.Add(other.finishCampIdList_);
    unlockCultivateIdList_.Add(other.unlockCultivateIdList_);
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
        case 10:
        case 8: {
          finishCampIdList_.AddEntriesFrom(input, _repeated_finishCampIdList_codec);
          break;
        }
        case 26: {
          trainingDungeonProgressDetailList_.AddEntriesFrom(input, _repeated_trainingDungeonProgressDetailList_codec);
          break;
        }
        case 34: {
          fungusDetailList_.AddEntriesFrom(input, _repeated_fungusDetailList_codec);
          break;
        }
        case 50: {
          plotStageDetailList_.AddEntriesFrom(input, _repeated_plotStageDetailList_codec);
          break;
        }
        case 66:
        case 64: {
          unlockCultivateIdList_.AddEntriesFrom(input, _repeated_unlockCultivateIdList_codec);
          break;
        }
        case 98:
        case 96: {
          unlockCampIdList_.AddEntriesFrom(input, _repeated_unlockCampIdList_codec);
          break;
        }
        case 122: {
          trainingDungeonDetailList_.AddEntriesFrom(input, _repeated_trainingDungeonDetailList_codec);
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
        case 10:
        case 8: {
          finishCampIdList_.AddEntriesFrom(ref input, _repeated_finishCampIdList_codec);
          break;
        }
        case 26: {
          trainingDungeonProgressDetailList_.AddEntriesFrom(ref input, _repeated_trainingDungeonProgressDetailList_codec);
          break;
        }
        case 34: {
          fungusDetailList_.AddEntriesFrom(ref input, _repeated_fungusDetailList_codec);
          break;
        }
        case 50: {
          plotStageDetailList_.AddEntriesFrom(ref input, _repeated_plotStageDetailList_codec);
          break;
        }
        case 66:
        case 64: {
          unlockCultivateIdList_.AddEntriesFrom(ref input, _repeated_unlockCultivateIdList_codec);
          break;
        }
        case 98:
        case 96: {
          unlockCampIdList_.AddEntriesFrom(ref input, _repeated_unlockCampIdList_codec);
          break;
        }
        case 122: {
          trainingDungeonDetailList_.AddEntriesFrom(ref input, _repeated_trainingDungeonDetailList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
