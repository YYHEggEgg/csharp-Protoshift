// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GachaActivityDetailInfo.proto</summary>
  public static partial class GachaActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GachaActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GachaActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HYWNoYUFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxoUR2FjaGFTdGFnZURh",
            "dGEucHJvdG8irAMKF0dhY2hhQWN0aXZpdHlEZXRhaWxJbmZvEhsKE1VuazMz",
            "MDBfSkpESEtKR0RFS0oYDCABKA0SQAoNcm9ib3RfbnVtX21hcBgKIAMoCzIp",
            "LkdhY2hhQWN0aXZpdHlEZXRhaWxJbmZvLlJvYm90TnVtTWFwRW50cnkSVgoZ",
            "aGF2ZV9yZXdhcmRfcm9ib3RfbnVtX21hcBgDIAMoCzIzLkdhY2hhQWN0aXZp",
            "dHlEZXRhaWxJbmZvLkhhdmVSZXdhcmRSb2JvdE51bU1hcEVudHJ5EhsKE2hh",
            "dmVfZ2V0X3JvYm90X2xpc3QYDiADKA0SLgoVZ2FjaGFfc3RhZ2VfZGF0YV9s",
            "aXN0GAcgAygLMg8uR2FjaGFTdGFnZURhdGESGwoTVW5rMzMwMF9JR0dQQkVP",
            "Q05HSRgPIAEoDRoyChBSb2JvdE51bU1hcEVudHJ5EgsKA2tleRgBIAEoDRIN",
            "CgV2YWx1ZRgCIAEoDToCOAEaPAoaSGF2ZVJld2FyZFJvYm90TnVtTWFwRW50",
            "cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIMqgIJTmV3UHJv",
            "dG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GachaStageDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GachaActivityDetailInfo), global::NewProtos.GachaActivityDetailInfo.Parser, new[]{ "Unk3300JJDHKJGDEKJ", "RobotNumMap", "HaveRewardRobotNumMap", "HaveGetRobotList", "GachaStageDataList", "Unk3300IGGPBEOCNGI" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GachaActivityDetailInfo : pb::IMessage<GachaActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaActivityDetailInfo> _parser = new pb::MessageParser<GachaActivityDetailInfo>(() => new GachaActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GachaActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityDetailInfo(GachaActivityDetailInfo other) : this() {
      unk3300JJDHKJGDEKJ_ = other.unk3300JJDHKJGDEKJ_;
      robotNumMap_ = other.robotNumMap_.Clone();
      haveRewardRobotNumMap_ = other.haveRewardRobotNumMap_.Clone();
      haveGetRobotList_ = other.haveGetRobotList_.Clone();
      gachaStageDataList_ = other.gachaStageDataList_.Clone();
      unk3300IGGPBEOCNGI_ = other.unk3300IGGPBEOCNGI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityDetailInfo Clone() {
      return new GachaActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk3300_JJDHKJGDEKJ" field.</summary>
    public const int Unk3300JJDHKJGDEKJFieldNumber = 12;
    private uint unk3300JJDHKJGDEKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JJDHKJGDEKJ {
      get { return unk3300JJDHKJGDEKJ_; }
      set {
        unk3300JJDHKJGDEKJ_ = value;
      }
    }

    /// <summary>Field number for the "robot_num_map" field.</summary>
    public const int RobotNumMapFieldNumber = 10;
    private static readonly pbc::MapField<uint, uint>.Codec _map_robotNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 82);
    private readonly pbc::MapField<uint, uint> robotNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> RobotNumMap {
      get { return robotNumMap_; }
    }

    /// <summary>Field number for the "have_reward_robot_num_map" field.</summary>
    public const int HaveRewardRobotNumMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_haveRewardRobotNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> haveRewardRobotNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> HaveRewardRobotNumMap {
      get { return haveRewardRobotNumMap_; }
    }

    /// <summary>Field number for the "have_get_robot_list" field.</summary>
    public const int HaveGetRobotListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_haveGetRobotList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> haveGetRobotList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HaveGetRobotList {
      get { return haveGetRobotList_; }
    }

    /// <summary>Field number for the "gacha_stage_data_list" field.</summary>
    public const int GachaStageDataListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::NewProtos.GachaStageData> _repeated_gachaStageDataList_codec
        = pb::FieldCodec.ForMessage(58, global::NewProtos.GachaStageData.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.GachaStageData> gachaStageDataList_ = new pbc::RepeatedField<global::NewProtos.GachaStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.GachaStageData> GachaStageDataList {
      get { return gachaStageDataList_; }
    }

    /// <summary>Field number for the "Unk3300_IGGPBEOCNGI" field.</summary>
    public const int Unk3300IGGPBEOCNGIFieldNumber = 15;
    private uint unk3300IGGPBEOCNGI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IGGPBEOCNGI {
      get { return unk3300IGGPBEOCNGI_; }
      set {
        unk3300IGGPBEOCNGI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300JJDHKJGDEKJ != other.Unk3300JJDHKJGDEKJ) return false;
      if (!RobotNumMap.Equals(other.RobotNumMap)) return false;
      if (!HaveRewardRobotNumMap.Equals(other.HaveRewardRobotNumMap)) return false;
      if(!haveGetRobotList_.Equals(other.haveGetRobotList_)) return false;
      if(!gachaStageDataList_.Equals(other.gachaStageDataList_)) return false;
      if (Unk3300IGGPBEOCNGI != other.Unk3300IGGPBEOCNGI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300JJDHKJGDEKJ != 0) hash ^= Unk3300JJDHKJGDEKJ.GetHashCode();
      hash ^= RobotNumMap.GetHashCode();
      hash ^= HaveRewardRobotNumMap.GetHashCode();
      hash ^= haveGetRobotList_.GetHashCode();
      hash ^= gachaStageDataList_.GetHashCode();
      if (Unk3300IGGPBEOCNGI != 0) hash ^= Unk3300IGGPBEOCNGI.GetHashCode();
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
      haveRewardRobotNumMap_.WriteTo(output, _map_haveRewardRobotNumMap_codec);
      gachaStageDataList_.WriteTo(output, _repeated_gachaStageDataList_codec);
      robotNumMap_.WriteTo(output, _map_robotNumMap_codec);
      if (Unk3300JJDHKJGDEKJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300JJDHKJGDEKJ);
      }
      haveGetRobotList_.WriteTo(output, _repeated_haveGetRobotList_codec);
      if (Unk3300IGGPBEOCNGI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300IGGPBEOCNGI);
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
      haveRewardRobotNumMap_.WriteTo(ref output, _map_haveRewardRobotNumMap_codec);
      gachaStageDataList_.WriteTo(ref output, _repeated_gachaStageDataList_codec);
      robotNumMap_.WriteTo(ref output, _map_robotNumMap_codec);
      if (Unk3300JJDHKJGDEKJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300JJDHKJGDEKJ);
      }
      haveGetRobotList_.WriteTo(ref output, _repeated_haveGetRobotList_codec);
      if (Unk3300IGGPBEOCNGI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300IGGPBEOCNGI);
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
      if (Unk3300JJDHKJGDEKJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JJDHKJGDEKJ);
      }
      size += robotNumMap_.CalculateSize(_map_robotNumMap_codec);
      size += haveRewardRobotNumMap_.CalculateSize(_map_haveRewardRobotNumMap_codec);
      size += haveGetRobotList_.CalculateSize(_repeated_haveGetRobotList_codec);
      size += gachaStageDataList_.CalculateSize(_repeated_gachaStageDataList_codec);
      if (Unk3300IGGPBEOCNGI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IGGPBEOCNGI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300JJDHKJGDEKJ != 0) {
        Unk3300JJDHKJGDEKJ = other.Unk3300JJDHKJGDEKJ;
      }
      robotNumMap_.MergeFrom(other.robotNumMap_);
      haveRewardRobotNumMap_.MergeFrom(other.haveRewardRobotNumMap_);
      haveGetRobotList_.Add(other.haveGetRobotList_);
      gachaStageDataList_.Add(other.gachaStageDataList_);
      if (other.Unk3300IGGPBEOCNGI != 0) {
        Unk3300IGGPBEOCNGI = other.Unk3300IGGPBEOCNGI;
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
          case 26: {
            haveRewardRobotNumMap_.AddEntriesFrom(input, _map_haveRewardRobotNumMap_codec);
            break;
          }
          case 58: {
            gachaStageDataList_.AddEntriesFrom(input, _repeated_gachaStageDataList_codec);
            break;
          }
          case 82: {
            robotNumMap_.AddEntriesFrom(input, _map_robotNumMap_codec);
            break;
          }
          case 96: {
            Unk3300JJDHKJGDEKJ = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            haveGetRobotList_.AddEntriesFrom(input, _repeated_haveGetRobotList_codec);
            break;
          }
          case 120: {
            Unk3300IGGPBEOCNGI = input.ReadUInt32();
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
          case 26: {
            haveRewardRobotNumMap_.AddEntriesFrom(ref input, _map_haveRewardRobotNumMap_codec);
            break;
          }
          case 58: {
            gachaStageDataList_.AddEntriesFrom(ref input, _repeated_gachaStageDataList_codec);
            break;
          }
          case 82: {
            robotNumMap_.AddEntriesFrom(ref input, _map_robotNumMap_codec);
            break;
          }
          case 96: {
            Unk3300JJDHKJGDEKJ = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            haveGetRobotList_.AddEntriesFrom(ref input, _repeated_haveGetRobotList_codec);
            break;
          }
          case 120: {
            Unk3300IGGPBEOCNGI = input.ReadUInt32();
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
