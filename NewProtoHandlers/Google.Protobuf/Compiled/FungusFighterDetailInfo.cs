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
namespace NewProtos {

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
            "cmVzc0RldGFpbC5wcm90byLlAgoXRnVuZ3VzRmlnaHRlckRldGFpbEluZm8S",
            "KQoSZnVuZ3VzX2RldGFpbF9saXN0GAYgAygLMg0uRnVuZ3VzRGV0YWlsEhsK",
            "E1VuazMzMDBfR0lIQUtLQUpIREgYASADKA0SGwoTVW5rMzMwMF9LR0tGSkpI",
            "RkhBQhgIIAMoDRJMCiV0cmFpbmluZ19kdW5nZW9uX3Byb2dyZXNzX2RldGFp",
            "bF9saXN0GAMgAygLMh0uRnVuZ3VzVHJhaW5pbmdQcm9ncmVzc0RldGFpbBIb",
            "ChNVbmszMzAwX0hQRE9KT0JQRk1KGAkgAygNEjYKFnBsb3Rfc3RhZ2VfZGV0",
            "YWlsX2xpc3QYCyADKAsyFi5GdW5ndXNQbG90U3RhZ2VEZXRhaWwSQgocdHJh",
            "aW5pbmdfZHVuZ2Vvbl9kZXRhaWxfbGlzdBgCIAMoCzIcLkZ1bmd1c1RyYWlu",
            "aW5nRHVuZ2VvbkRldGFpbEIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.FungusDetailReflection.Descriptor, global::NewProtos.FungusPlotStageDetailReflection.Descriptor, global::NewProtos.FungusTrainingDungeonDetailReflection.Descriptor, global::NewProtos.FungusTrainingProgressDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.FungusFighterDetailInfo), global::NewProtos.FungusFighterDetailInfo.Parser, new[]{ "FungusDetailList", "Unk3300GIHAKKAJHDH", "Unk3300KGKFJJHFHAB", "TrainingDungeonProgressDetailList", "Unk3300HPDOJOBPFMJ", "PlotStageDetailList", "TrainingDungeonDetailList" }, null, null, null, null)
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
      get { return global::NewProtos.FungusFighterDetailInfoReflection.Descriptor.MessageTypes[0]; }
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
      fungusDetailList_ = other.fungusDetailList_.Clone();
      unk3300GIHAKKAJHDH_ = other.unk3300GIHAKKAJHDH_.Clone();
      unk3300KGKFJJHFHAB_ = other.unk3300KGKFJJHFHAB_.Clone();
      trainingDungeonProgressDetailList_ = other.trainingDungeonProgressDetailList_.Clone();
      unk3300HPDOJOBPFMJ_ = other.unk3300HPDOJOBPFMJ_.Clone();
      plotStageDetailList_ = other.plotStageDetailList_.Clone();
      trainingDungeonDetailList_ = other.trainingDungeonDetailList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterDetailInfo Clone() {
      return new FungusFighterDetailInfo(this);
    }

    /// <summary>Field number for the "fungus_detail_list" field.</summary>
    public const int FungusDetailListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::NewProtos.FungusDetail> _repeated_fungusDetailList_codec
        = pb::FieldCodec.ForMessage(50, global::NewProtos.FungusDetail.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.FungusDetail> fungusDetailList_ = new pbc::RepeatedField<global::NewProtos.FungusDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.FungusDetail> FungusDetailList {
      get { return fungusDetailList_; }
    }

    /// <summary>Field number for the "Unk3300_GIHAKKAJHDH" field.</summary>
    public const int Unk3300GIHAKKAJHDHFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300GIHAKKAJHDH_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> unk3300GIHAKKAJHDH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300GIHAKKAJHDH {
      get { return unk3300GIHAKKAJHDH_; }
    }

    /// <summary>Field number for the "Unk3300_KGKFJJHFHAB" field.</summary>
    public const int Unk3300KGKFJJHFHABFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300KGKFJJHFHAB_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> unk3300KGKFJJHFHAB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300KGKFJJHFHAB {
      get { return unk3300KGKFJJHFHAB_; }
    }

    /// <summary>Field number for the "training_dungeon_progress_detail_list" field.</summary>
    public const int TrainingDungeonProgressDetailListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::NewProtos.FungusTrainingProgressDetail> _repeated_trainingDungeonProgressDetailList_codec
        = pb::FieldCodec.ForMessage(26, global::NewProtos.FungusTrainingProgressDetail.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.FungusTrainingProgressDetail> trainingDungeonProgressDetailList_ = new pbc::RepeatedField<global::NewProtos.FungusTrainingProgressDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.FungusTrainingProgressDetail> TrainingDungeonProgressDetailList {
      get { return trainingDungeonProgressDetailList_; }
    }

    /// <summary>Field number for the "Unk3300_HPDOJOBPFMJ" field.</summary>
    public const int Unk3300HPDOJOBPFMJFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300HPDOJOBPFMJ_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> unk3300HPDOJOBPFMJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300HPDOJOBPFMJ {
      get { return unk3300HPDOJOBPFMJ_; }
    }

    /// <summary>Field number for the "plot_stage_detail_list" field.</summary>
    public const int PlotStageDetailListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::NewProtos.FungusPlotStageDetail> _repeated_plotStageDetailList_codec
        = pb::FieldCodec.ForMessage(90, global::NewProtos.FungusPlotStageDetail.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.FungusPlotStageDetail> plotStageDetailList_ = new pbc::RepeatedField<global::NewProtos.FungusPlotStageDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.FungusPlotStageDetail> PlotStageDetailList {
      get { return plotStageDetailList_; }
    }

    /// <summary>Field number for the "training_dungeon_detail_list" field.</summary>
    public const int TrainingDungeonDetailListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::NewProtos.FungusTrainingDungeonDetail> _repeated_trainingDungeonDetailList_codec
        = pb::FieldCodec.ForMessage(18, global::NewProtos.FungusTrainingDungeonDetail.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.FungusTrainingDungeonDetail> trainingDungeonDetailList_ = new pbc::RepeatedField<global::NewProtos.FungusTrainingDungeonDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.FungusTrainingDungeonDetail> TrainingDungeonDetailList {
      get { return trainingDungeonDetailList_; }
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
      if(!fungusDetailList_.Equals(other.fungusDetailList_)) return false;
      if(!unk3300GIHAKKAJHDH_.Equals(other.unk3300GIHAKKAJHDH_)) return false;
      if(!unk3300KGKFJJHFHAB_.Equals(other.unk3300KGKFJJHFHAB_)) return false;
      if(!trainingDungeonProgressDetailList_.Equals(other.trainingDungeonProgressDetailList_)) return false;
      if(!unk3300HPDOJOBPFMJ_.Equals(other.unk3300HPDOJOBPFMJ_)) return false;
      if(!plotStageDetailList_.Equals(other.plotStageDetailList_)) return false;
      if(!trainingDungeonDetailList_.Equals(other.trainingDungeonDetailList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fungusDetailList_.GetHashCode();
      hash ^= unk3300GIHAKKAJHDH_.GetHashCode();
      hash ^= unk3300KGKFJJHFHAB_.GetHashCode();
      hash ^= trainingDungeonProgressDetailList_.GetHashCode();
      hash ^= unk3300HPDOJOBPFMJ_.GetHashCode();
      hash ^= plotStageDetailList_.GetHashCode();
      hash ^= trainingDungeonDetailList_.GetHashCode();
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
      unk3300GIHAKKAJHDH_.WriteTo(output, _repeated_unk3300GIHAKKAJHDH_codec);
      trainingDungeonDetailList_.WriteTo(output, _repeated_trainingDungeonDetailList_codec);
      trainingDungeonProgressDetailList_.WriteTo(output, _repeated_trainingDungeonProgressDetailList_codec);
      fungusDetailList_.WriteTo(output, _repeated_fungusDetailList_codec);
      unk3300KGKFJJHFHAB_.WriteTo(output, _repeated_unk3300KGKFJJHFHAB_codec);
      unk3300HPDOJOBPFMJ_.WriteTo(output, _repeated_unk3300HPDOJOBPFMJ_codec);
      plotStageDetailList_.WriteTo(output, _repeated_plotStageDetailList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk3300GIHAKKAJHDH_.WriteTo(ref output, _repeated_unk3300GIHAKKAJHDH_codec);
      trainingDungeonDetailList_.WriteTo(ref output, _repeated_trainingDungeonDetailList_codec);
      trainingDungeonProgressDetailList_.WriteTo(ref output, _repeated_trainingDungeonProgressDetailList_codec);
      fungusDetailList_.WriteTo(ref output, _repeated_fungusDetailList_codec);
      unk3300KGKFJJHFHAB_.WriteTo(ref output, _repeated_unk3300KGKFJJHFHAB_codec);
      unk3300HPDOJOBPFMJ_.WriteTo(ref output, _repeated_unk3300HPDOJOBPFMJ_codec);
      plotStageDetailList_.WriteTo(ref output, _repeated_plotStageDetailList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += fungusDetailList_.CalculateSize(_repeated_fungusDetailList_codec);
      size += unk3300GIHAKKAJHDH_.CalculateSize(_repeated_unk3300GIHAKKAJHDH_codec);
      size += unk3300KGKFJJHFHAB_.CalculateSize(_repeated_unk3300KGKFJJHFHAB_codec);
      size += trainingDungeonProgressDetailList_.CalculateSize(_repeated_trainingDungeonProgressDetailList_codec);
      size += unk3300HPDOJOBPFMJ_.CalculateSize(_repeated_unk3300HPDOJOBPFMJ_codec);
      size += plotStageDetailList_.CalculateSize(_repeated_plotStageDetailList_codec);
      size += trainingDungeonDetailList_.CalculateSize(_repeated_trainingDungeonDetailList_codec);
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
      fungusDetailList_.Add(other.fungusDetailList_);
      unk3300GIHAKKAJHDH_.Add(other.unk3300GIHAKKAJHDH_);
      unk3300KGKFJJHFHAB_.Add(other.unk3300KGKFJJHFHAB_);
      trainingDungeonProgressDetailList_.Add(other.trainingDungeonProgressDetailList_);
      unk3300HPDOJOBPFMJ_.Add(other.unk3300HPDOJOBPFMJ_);
      plotStageDetailList_.Add(other.plotStageDetailList_);
      trainingDungeonDetailList_.Add(other.trainingDungeonDetailList_);
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
            unk3300GIHAKKAJHDH_.AddEntriesFrom(input, _repeated_unk3300GIHAKKAJHDH_codec);
            break;
          }
          case 18: {
            trainingDungeonDetailList_.AddEntriesFrom(input, _repeated_trainingDungeonDetailList_codec);
            break;
          }
          case 26: {
            trainingDungeonProgressDetailList_.AddEntriesFrom(input, _repeated_trainingDungeonProgressDetailList_codec);
            break;
          }
          case 50: {
            fungusDetailList_.AddEntriesFrom(input, _repeated_fungusDetailList_codec);
            break;
          }
          case 66:
          case 64: {
            unk3300KGKFJJHFHAB_.AddEntriesFrom(input, _repeated_unk3300KGKFJJHFHAB_codec);
            break;
          }
          case 74:
          case 72: {
            unk3300HPDOJOBPFMJ_.AddEntriesFrom(input, _repeated_unk3300HPDOJOBPFMJ_codec);
            break;
          }
          case 90: {
            plotStageDetailList_.AddEntriesFrom(input, _repeated_plotStageDetailList_codec);
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
            unk3300GIHAKKAJHDH_.AddEntriesFrom(ref input, _repeated_unk3300GIHAKKAJHDH_codec);
            break;
          }
          case 18: {
            trainingDungeonDetailList_.AddEntriesFrom(ref input, _repeated_trainingDungeonDetailList_codec);
            break;
          }
          case 26: {
            trainingDungeonProgressDetailList_.AddEntriesFrom(ref input, _repeated_trainingDungeonProgressDetailList_codec);
            break;
          }
          case 50: {
            fungusDetailList_.AddEntriesFrom(ref input, _repeated_fungusDetailList_codec);
            break;
          }
          case 66:
          case 64: {
            unk3300KGKFJJHFHAB_.AddEntriesFrom(ref input, _repeated_unk3300KGKFJJHFHAB_codec);
            break;
          }
          case 74:
          case 72: {
            unk3300HPDOJOBPFMJ_.AddEntriesFrom(ref input, _repeated_unk3300HPDOJOBPFMJ_codec);
            break;
          }
          case 90: {
            plotStageDetailList_.AddEntriesFrom(ref input, _repeated_plotStageDetailList_codec);
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
