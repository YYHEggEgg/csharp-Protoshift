// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from VintageActivityDetailInfo.proto</summary>
  public static partial class VintageActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9WaW50YWdlQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGh5WaW50YWdlQm9v",
            "dGhVc2VkSXRlbURhdGEucHJvdG8aI1ZpbnRhZ2VDYW1wQ2hhbGxlbmdlU3Rh",
            "Z2VEYXRhLnByb3RvGh1WaW50YWdlSHVudGluZ1N0YWdlRGF0YS5wcm90bxoX",
            "VmludGFnZU1hcmtldEluZm8ucHJvdG8aHVZpbnRhZ2VQcmVzZW50U3RhZ2VE",
            "YXRhLnByb3RvIuUEChlWaW50YWdlQWN0aXZpdHlEZXRhaWxJbmZvEicKC21h",
            "cmtldF9pbmZvGAIgASgLMhIuVmludGFnZU1hcmtldEluZm8SSgoRaHVudGlu",
            "Z19zdGFnZV9tYXAYByADKAsyLy5WaW50YWdlQWN0aXZpdHlEZXRhaWxJbmZv",
            "Lkh1bnRpbmdTdGFnZU1hcEVudHJ5Ei0KCmJvb3RoX2RhdGEYBSABKAsyGS5W",
            "aW50YWdlQm9vdGhVc2VkSXRlbURhdGESRAoOY2FtcF9zdGFnZV9tYXAYDSAD",
            "KAsyLC5WaW50YWdlQWN0aXZpdHlEZXRhaWxJbmZvLkNhbXBTdGFnZU1hcEVu",
            "dHJ5EkoKEXByZXNlbnRfc3RhZ2VfbWFwGAQgAygLMi8uVmludGFnZUFjdGl2",
            "aXR5RGV0YWlsSW5mby5QcmVzZW50U3RhZ2VNYXBFbnRyeRIZChFpc19jb250",
            "ZW50X2Nsb3NlZBgLIAEoCBpQChRIdW50aW5nU3RhZ2VNYXBFbnRyeRILCgNr",
            "ZXkYASABKA0SJwoFdmFsdWUYAiABKAsyGC5WaW50YWdlSHVudGluZ1N0YWdl",
            "RGF0YToCOAEaUwoRQ2FtcFN0YWdlTWFwRW50cnkSCwoDa2V5GAEgASgNEi0K",
            "BXZhbHVlGAIgASgLMh4uVmludGFnZUNhbXBDaGFsbGVuZ2VTdGFnZURhdGE6",
            "AjgBGlAKFFByZXNlbnRTdGFnZU1hcEVudHJ5EgsKA2tleRgBIAEoDRInCgV2",
            "YWx1ZRgCIAEoCzIYLlZpbnRhZ2VQcmVzZW50U3RhZ2VEYXRhOgI4AUIMqgIJ",
            "T2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VintageBoothUsedItemDataReflection.Descriptor, global::OldProtos.VintageCampChallengeStageDataReflection.Descriptor, global::OldProtos.VintageHuntingStageDataReflection.Descriptor, global::OldProtos.VintageMarketInfoReflection.Descriptor, global::OldProtos.VintagePresentStageDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.VintageActivityDetailInfo), global::OldProtos.VintageActivityDetailInfo.Parser, new[]{ "MarketInfo", "HuntingStageMap", "BoothData", "CampStageMap", "PresentStageMap", "IsContentClosed" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageActivityDetailInfo : pb::IMessage<VintageActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageActivityDetailInfo> _parser = new pb::MessageParser<VintageActivityDetailInfo>(() => new VintageActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.VintageActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageActivityDetailInfo(VintageActivityDetailInfo other) : this() {
      marketInfo_ = other.marketInfo_ != null ? other.marketInfo_.Clone() : null;
      huntingStageMap_ = other.huntingStageMap_.Clone();
      boothData_ = other.boothData_ != null ? other.boothData_.Clone() : null;
      campStageMap_ = other.campStageMap_.Clone();
      presentStageMap_ = other.presentStageMap_.Clone();
      isContentClosed_ = other.isContentClosed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageActivityDetailInfo Clone() {
      return new VintageActivityDetailInfo(this);
    }

    /// <summary>Field number for the "market_info" field.</summary>
    public const int MarketInfoFieldNumber = 2;
    private global::OldProtos.VintageMarketInfo marketInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.VintageMarketInfo MarketInfo {
      get { return marketInfo_; }
      set {
        marketInfo_ = value;
      }
    }

    /// <summary>Field number for the "hunting_stage_map" field.</summary>
    public const int HuntingStageMapFieldNumber = 7;
    private static readonly pbc::MapField<uint, global::OldProtos.VintageHuntingStageData>.Codec _map_huntingStageMap_codec
        = new pbc::MapField<uint, global::OldProtos.VintageHuntingStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.VintageHuntingStageData.Parser), 58);
    private readonly pbc::MapField<uint, global::OldProtos.VintageHuntingStageData> huntingStageMap_ = new pbc::MapField<uint, global::OldProtos.VintageHuntingStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.VintageHuntingStageData> HuntingStageMap {
      get { return huntingStageMap_; }
    }

    /// <summary>Field number for the "booth_data" field.</summary>
    public const int BoothDataFieldNumber = 5;
    private global::OldProtos.VintageBoothUsedItemData boothData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.VintageBoothUsedItemData BoothData {
      get { return boothData_; }
      set {
        boothData_ = value;
      }
    }

    /// <summary>Field number for the "camp_stage_map" field.</summary>
    public const int CampStageMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, global::OldProtos.VintageCampChallengeStageData>.Codec _map_campStageMap_codec
        = new pbc::MapField<uint, global::OldProtos.VintageCampChallengeStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.VintageCampChallengeStageData.Parser), 106);
    private readonly pbc::MapField<uint, global::OldProtos.VintageCampChallengeStageData> campStageMap_ = new pbc::MapField<uint, global::OldProtos.VintageCampChallengeStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.VintageCampChallengeStageData> CampStageMap {
      get { return campStageMap_; }
    }

    /// <summary>Field number for the "present_stage_map" field.</summary>
    public const int PresentStageMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, global::OldProtos.VintagePresentStageData>.Codec _map_presentStageMap_codec
        = new pbc::MapField<uint, global::OldProtos.VintagePresentStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.VintagePresentStageData.Parser), 34);
    private readonly pbc::MapField<uint, global::OldProtos.VintagePresentStageData> presentStageMap_ = new pbc::MapField<uint, global::OldProtos.VintagePresentStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.VintagePresentStageData> PresentStageMap {
      get { return presentStageMap_; }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 11;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MarketInfo, other.MarketInfo)) return false;
      if (!HuntingStageMap.Equals(other.HuntingStageMap)) return false;
      if (!object.Equals(BoothData, other.BoothData)) return false;
      if (!CampStageMap.Equals(other.CampStageMap)) return false;
      if (!PresentStageMap.Equals(other.PresentStageMap)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (marketInfo_ != null) hash ^= MarketInfo.GetHashCode();
      hash ^= HuntingStageMap.GetHashCode();
      if (boothData_ != null) hash ^= BoothData.GetHashCode();
      hash ^= CampStageMap.GetHashCode();
      hash ^= PresentStageMap.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
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
      if (marketInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MarketInfo);
      }
      presentStageMap_.WriteTo(output, _map_presentStageMap_codec);
      if (boothData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BoothData);
      }
      huntingStageMap_.WriteTo(output, _map_huntingStageMap_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsContentClosed);
      }
      campStageMap_.WriteTo(output, _map_campStageMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (marketInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MarketInfo);
      }
      presentStageMap_.WriteTo(ref output, _map_presentStageMap_codec);
      if (boothData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BoothData);
      }
      huntingStageMap_.WriteTo(ref output, _map_huntingStageMap_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsContentClosed);
      }
      campStageMap_.WriteTo(ref output, _map_campStageMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (marketInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MarketInfo);
      }
      size += huntingStageMap_.CalculateSize(_map_huntingStageMap_codec);
      if (boothData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoothData);
      }
      size += campStageMap_.CalculateSize(_map_campStageMap_codec);
      size += presentStageMap_.CalculateSize(_map_presentStageMap_codec);
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.marketInfo_ != null) {
        if (marketInfo_ == null) {
          MarketInfo = new global::OldProtos.VintageMarketInfo();
        }
        MarketInfo.MergeFrom(other.MarketInfo);
      }
      huntingStageMap_.Add(other.huntingStageMap_);
      if (other.boothData_ != null) {
        if (boothData_ == null) {
          BoothData = new global::OldProtos.VintageBoothUsedItemData();
        }
        BoothData.MergeFrom(other.BoothData);
      }
      campStageMap_.Add(other.campStageMap_);
      presentStageMap_.Add(other.presentStageMap_);
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
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
          case 18: {
            if (marketInfo_ == null) {
              MarketInfo = new global::OldProtos.VintageMarketInfo();
            }
            input.ReadMessage(MarketInfo);
            break;
          }
          case 34: {
            presentStageMap_.AddEntriesFrom(input, _map_presentStageMap_codec);
            break;
          }
          case 42: {
            if (boothData_ == null) {
              BoothData = new global::OldProtos.VintageBoothUsedItemData();
            }
            input.ReadMessage(BoothData);
            break;
          }
          case 58: {
            huntingStageMap_.AddEntriesFrom(input, _map_huntingStageMap_codec);
            break;
          }
          case 88: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 106: {
            campStageMap_.AddEntriesFrom(input, _map_campStageMap_codec);
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
          case 18: {
            if (marketInfo_ == null) {
              MarketInfo = new global::OldProtos.VintageMarketInfo();
            }
            input.ReadMessage(MarketInfo);
            break;
          }
          case 34: {
            presentStageMap_.AddEntriesFrom(ref input, _map_presentStageMap_codec);
            break;
          }
          case 42: {
            if (boothData_ == null) {
              BoothData = new global::OldProtos.VintageBoothUsedItemData();
            }
            input.ReadMessage(BoothData);
            break;
          }
          case 58: {
            huntingStageMap_.AddEntriesFrom(ref input, _map_huntingStageMap_codec);
            break;
          }
          case 88: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 106: {
            campStageMap_.AddEntriesFrom(ref input, _map_campStageMap_codec);
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