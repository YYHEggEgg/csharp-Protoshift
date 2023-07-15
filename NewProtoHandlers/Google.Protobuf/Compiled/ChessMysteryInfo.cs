// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessMysteryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ChessMysteryInfo.proto</summary>
  public static partial class ChessMysteryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessMysteryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessMysteryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDaGVzc015c3RlcnlJbmZvLnByb3RvGh1DaGVzc0VudHJhbmNlRGV0YWls",
            "SW5mby5wcm90byK7AgoQQ2hlc3NNeXN0ZXJ5SW5mbxIaChJleGl0X3BvaW50",
            "X2lkX2xpc3QYDyADKA0SQwoSZW50cmFuY2VfcG9pbnRfbWFwGAogAygLMicu",
            "Q2hlc3NNeXN0ZXJ5SW5mby5FbnRyYW5jZVBvaW50TWFwRW50cnkSPQoPZGV0",
            "YWlsX2luZm9fbWFwGAggAygLMiQuQ2hlc3NNeXN0ZXJ5SW5mby5EZXRhaWxJ",
            "bmZvTWFwRW50cnkaNwoVRW50cmFuY2VQb2ludE1hcEVudHJ5EgsKA2tleRgB",
            "IAEoDRINCgV2YWx1ZRgCIAEoDToCOAEaTgoSRGV0YWlsSW5mb01hcEVudHJ5",
            "EgsKA2tleRgBIAEoDRInCgV2YWx1ZRgCIAEoCzIYLkNoZXNzRW50cmFuY2VE",
            "ZXRhaWxJbmZvOgI4AUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ChessEntranceDetailInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ChessMysteryInfo), global::NewProtos.ChessMysteryInfo.Parser, new[]{ "ExitPointIdList", "EntrancePointMap", "DetailInfoMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChessMysteryInfo : pb::IMessage<ChessMysteryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessMysteryInfo> _parser = new pb::MessageParser<ChessMysteryInfo>(() => new ChessMysteryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessMysteryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ChessMysteryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessMysteryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessMysteryInfo(ChessMysteryInfo other) : this() {
      exitPointIdList_ = other.exitPointIdList_.Clone();
      entrancePointMap_ = other.entrancePointMap_.Clone();
      detailInfoMap_ = other.detailInfoMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessMysteryInfo Clone() {
      return new ChessMysteryInfo(this);
    }

    /// <summary>Field number for the "exit_point_id_list" field.</summary>
    public const int ExitPointIdListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_exitPointIdList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> exitPointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExitPointIdList {
      get { return exitPointIdList_; }
    }

    /// <summary>Field number for the "entrance_point_map" field.</summary>
    public const int EntrancePointMapFieldNumber = 10;
    private static readonly pbc::MapField<uint, uint>.Codec _map_entrancePointMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 82);
    private readonly pbc::MapField<uint, uint> entrancePointMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> EntrancePointMap {
      get { return entrancePointMap_; }
    }

    /// <summary>Field number for the "detail_info_map" field.</summary>
    public const int DetailInfoMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, global::NewProtos.ChessEntranceDetailInfo>.Codec _map_detailInfoMap_codec
        = new pbc::MapField<uint, global::NewProtos.ChessEntranceDetailInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::NewProtos.ChessEntranceDetailInfo.Parser), 66);
    private readonly pbc::MapField<uint, global::NewProtos.ChessEntranceDetailInfo> detailInfoMap_ = new pbc::MapField<uint, global::NewProtos.ChessEntranceDetailInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::NewProtos.ChessEntranceDetailInfo> DetailInfoMap {
      get { return detailInfoMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessMysteryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessMysteryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!exitPointIdList_.Equals(other.exitPointIdList_)) return false;
      if (!EntrancePointMap.Equals(other.EntrancePointMap)) return false;
      if (!DetailInfoMap.Equals(other.DetailInfoMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= exitPointIdList_.GetHashCode();
      hash ^= EntrancePointMap.GetHashCode();
      hash ^= DetailInfoMap.GetHashCode();
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
      detailInfoMap_.WriteTo(output, _map_detailInfoMap_codec);
      entrancePointMap_.WriteTo(output, _map_entrancePointMap_codec);
      exitPointIdList_.WriteTo(output, _repeated_exitPointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      detailInfoMap_.WriteTo(ref output, _map_detailInfoMap_codec);
      entrancePointMap_.WriteTo(ref output, _map_entrancePointMap_codec);
      exitPointIdList_.WriteTo(ref output, _repeated_exitPointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += exitPointIdList_.CalculateSize(_repeated_exitPointIdList_codec);
      size += entrancePointMap_.CalculateSize(_map_entrancePointMap_codec);
      size += detailInfoMap_.CalculateSize(_map_detailInfoMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessMysteryInfo other) {
      if (other == null) {
        return;
      }
      exitPointIdList_.Add(other.exitPointIdList_);
      entrancePointMap_.MergeFrom(other.entrancePointMap_);
      detailInfoMap_.MergeFrom(other.detailInfoMap_);
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
          case 66: {
            detailInfoMap_.AddEntriesFrom(input, _map_detailInfoMap_codec);
            break;
          }
          case 82: {
            entrancePointMap_.AddEntriesFrom(input, _map_entrancePointMap_codec);
            break;
          }
          case 122:
          case 120: {
            exitPointIdList_.AddEntriesFrom(input, _repeated_exitPointIdList_codec);
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
          case 66: {
            detailInfoMap_.AddEntriesFrom(ref input, _map_detailInfoMap_codec);
            break;
          }
          case 82: {
            entrancePointMap_.AddEntriesFrom(ref input, _map_entrancePointMap_codec);
            break;
          }
          case 122:
          case 120: {
            exitPointIdList_.AddEntriesFrom(ref input, _repeated_exitPointIdList_codec);
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
