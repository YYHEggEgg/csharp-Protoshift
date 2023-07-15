// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WaterSpiritActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from WaterSpiritActivityDetailInfo.proto</summary>
  public static partial class WaterSpiritActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WaterSpiritActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WaterSpiritActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNXYXRlclNwaXJpdEFjdGl2aXR5RGV0YWlsSW5mby5wcm90byLPAQodV2F0",
            "ZXJTcGlyaXRBY3Rpdml0eURldGFpbEluZm8SSgoPc2VhcmNoX3RpbWVfbWFw",
            "GAkgAygLMjEuV2F0ZXJTcGlyaXRBY3Rpdml0eURldGFpbEluZm8uU2VhcmNo",
            "VGltZU1hcEVudHJ5EhgKEHJlZ2lvbl9zZWFyY2hfaWQYAiABKA0SEgoKbXBf",
            "cGxheV9pZBgPIAEoDRo0ChJTZWFyY2hUaW1lTWFwRW50cnkSCwoDa2V5GAEg",
            "ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.WaterSpiritActivityDetailInfo), global::OldProtos.WaterSpiritActivityDetailInfo.Parser, new[]{ "SearchTimeMap", "RegionSearchId", "MpPlayId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WaterSpiritActivityDetailInfo : pb::IMessage<WaterSpiritActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WaterSpiritActivityDetailInfo> _parser = new pb::MessageParser<WaterSpiritActivityDetailInfo>(() => new WaterSpiritActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WaterSpiritActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.WaterSpiritActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WaterSpiritActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WaterSpiritActivityDetailInfo(WaterSpiritActivityDetailInfo other) : this() {
      searchTimeMap_ = other.searchTimeMap_.Clone();
      regionSearchId_ = other.regionSearchId_;
      mpPlayId_ = other.mpPlayId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WaterSpiritActivityDetailInfo Clone() {
      return new WaterSpiritActivityDetailInfo(this);
    }

    /// <summary>Field number for the "search_time_map" field.</summary>
    public const int SearchTimeMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, uint>.Codec _map_searchTimeMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 74);
    private readonly pbc::MapField<uint, uint> searchTimeMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SearchTimeMap {
      get { return searchTimeMap_; }
    }

    /// <summary>Field number for the "region_search_id" field.</summary>
    public const int RegionSearchIdFieldNumber = 2;
    private uint regionSearchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RegionSearchId {
      get { return regionSearchId_; }
      set {
        regionSearchId_ = value;
      }
    }

    /// <summary>Field number for the "mp_play_id" field.</summary>
    public const int MpPlayIdFieldNumber = 15;
    private uint mpPlayId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MpPlayId {
      get { return mpPlayId_; }
      set {
        mpPlayId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WaterSpiritActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WaterSpiritActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!SearchTimeMap.Equals(other.SearchTimeMap)) return false;
      if (RegionSearchId != other.RegionSearchId) return false;
      if (MpPlayId != other.MpPlayId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= SearchTimeMap.GetHashCode();
      if (RegionSearchId != 0) hash ^= RegionSearchId.GetHashCode();
      if (MpPlayId != 0) hash ^= MpPlayId.GetHashCode();
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
      if (RegionSearchId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RegionSearchId);
      }
      searchTimeMap_.WriteTo(output, _map_searchTimeMap_codec);
      if (MpPlayId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MpPlayId);
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
      if (RegionSearchId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RegionSearchId);
      }
      searchTimeMap_.WriteTo(ref output, _map_searchTimeMap_codec);
      if (MpPlayId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MpPlayId);
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
      size += searchTimeMap_.CalculateSize(_map_searchTimeMap_codec);
      if (RegionSearchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionSearchId);
      }
      if (MpPlayId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WaterSpiritActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      searchTimeMap_.Add(other.searchTimeMap_);
      if (other.RegionSearchId != 0) {
        RegionSearchId = other.RegionSearchId;
      }
      if (other.MpPlayId != 0) {
        MpPlayId = other.MpPlayId;
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
            RegionSearchId = input.ReadUInt32();
            break;
          }
          case 74: {
            searchTimeMap_.AddEntriesFrom(input, _map_searchTimeMap_codec);
            break;
          }
          case 120: {
            MpPlayId = input.ReadUInt32();
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
            RegionSearchId = input.ReadUInt32();
            break;
          }
          case 74: {
            searchTimeMap_.AddEntriesFrom(ref input, _map_searchTimeMap_codec);
            break;
          }
          case 120: {
            MpPlayId = input.ReadUInt32();
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
