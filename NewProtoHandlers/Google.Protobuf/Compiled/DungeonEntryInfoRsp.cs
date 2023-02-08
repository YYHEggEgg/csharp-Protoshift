// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonEntryInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from DungeonEntryInfoRsp.proto</summary>
  public static partial class DungeonEntryInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonEntryInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonEntryInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlEdW5nZW9uRW50cnlJbmZvUnNwLnByb3RvGhZEdW5nZW9uRW50cnlJbmZv",
            "LnByb3RvGhtEdW5nZW9uRW50cnlQb2ludEluZm8ucHJvdG8ivwEKE0R1bmdl",
            "b25FbnRyeUluZm9Sc3ASLQoSZHVuZ2Vvbl9lbnRyeV9saXN0GAggAygLMhEu",
            "RHVuZ2VvbkVudHJ5SW5mbxIcChRyZWNvbW1lbmRfZHVuZ2Vvbl9pZBgPIAEo",
            "DRI4ChhkdW5nZW9uX2VudHJ5X3BvaW50X2xpc3QYCiADKAsyFi5EdW5nZW9u",
            "RW50cnlQb2ludEluZm8SDwoHcmV0Y29kZRgOIAEoBRIQCghwb2ludF9pZBgM",
            "IAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.DungeonEntryInfoReflection.Descriptor, global::NewProtos.DungeonEntryPointInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.DungeonEntryInfoRsp), global::NewProtos.DungeonEntryInfoRsp.Parser, new[]{ "DungeonEntryList", "RecommendDungeonId", "DungeonEntryPointList", "Retcode", "PointId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 930;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class DungeonEntryInfoRsp : pb::IMessage<DungeonEntryInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonEntryInfoRsp> _parser = new pb::MessageParser<DungeonEntryInfoRsp>(() => new DungeonEntryInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonEntryInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.DungeonEntryInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryInfoRsp(DungeonEntryInfoRsp other) : this() {
      dungeonEntryList_ = other.dungeonEntryList_.Clone();
      recommendDungeonId_ = other.recommendDungeonId_;
      dungeonEntryPointList_ = other.dungeonEntryPointList_.Clone();
      retcode_ = other.retcode_;
      pointId_ = other.pointId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryInfoRsp Clone() {
      return new DungeonEntryInfoRsp(this);
    }

    /// <summary>Field number for the "dungeon_entry_list" field.</summary>
    public const int DungeonEntryListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::NewProtos.DungeonEntryInfo> _repeated_dungeonEntryList_codec
        = pb::FieldCodec.ForMessage(66, global::NewProtos.DungeonEntryInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.DungeonEntryInfo> dungeonEntryList_ = new pbc::RepeatedField<global::NewProtos.DungeonEntryInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.DungeonEntryInfo> DungeonEntryList {
      get { return dungeonEntryList_; }
    }

    /// <summary>Field number for the "recommend_dungeon_id" field.</summary>
    public const int RecommendDungeonIdFieldNumber = 15;
    private uint recommendDungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RecommendDungeonId {
      get { return recommendDungeonId_; }
      set {
        recommendDungeonId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_entry_point_list" field.</summary>
    public const int DungeonEntryPointListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::NewProtos.DungeonEntryPointInfo> _repeated_dungeonEntryPointList_codec
        = pb::FieldCodec.ForMessage(82, global::NewProtos.DungeonEntryPointInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.DungeonEntryPointInfo> dungeonEntryPointList_ = new pbc::RepeatedField<global::NewProtos.DungeonEntryPointInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.DungeonEntryPointInfo> DungeonEntryPointList {
      get { return dungeonEntryPointList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "point_id" field.</summary>
    public const int PointIdFieldNumber = 12;
    private uint pointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointId {
      get { return pointId_; }
      set {
        pointId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonEntryInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonEntryInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!dungeonEntryList_.Equals(other.dungeonEntryList_)) return false;
      if (RecommendDungeonId != other.RecommendDungeonId) return false;
      if(!dungeonEntryPointList_.Equals(other.dungeonEntryPointList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (PointId != other.PointId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= dungeonEntryList_.GetHashCode();
      if (RecommendDungeonId != 0) hash ^= RecommendDungeonId.GetHashCode();
      hash ^= dungeonEntryPointList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (PointId != 0) hash ^= PointId.GetHashCode();
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
      dungeonEntryList_.WriteTo(output, _repeated_dungeonEntryList_codec);
      dungeonEntryPointList_.WriteTo(output, _repeated_dungeonEntryPointList_codec);
      if (PointId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PointId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
      }
      if (RecommendDungeonId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RecommendDungeonId);
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
      dungeonEntryList_.WriteTo(ref output, _repeated_dungeonEntryList_codec);
      dungeonEntryPointList_.WriteTo(ref output, _repeated_dungeonEntryPointList_codec);
      if (PointId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PointId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
      }
      if (RecommendDungeonId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RecommendDungeonId);
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
      size += dungeonEntryList_.CalculateSize(_repeated_dungeonEntryList_codec);
      if (RecommendDungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RecommendDungeonId);
      }
      size += dungeonEntryPointList_.CalculateSize(_repeated_dungeonEntryPointList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (PointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonEntryInfoRsp other) {
      if (other == null) {
        return;
      }
      dungeonEntryList_.Add(other.dungeonEntryList_);
      if (other.RecommendDungeonId != 0) {
        RecommendDungeonId = other.RecommendDungeonId;
      }
      dungeonEntryPointList_.Add(other.dungeonEntryPointList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.PointId != 0) {
        PointId = other.PointId;
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
          case 66: {
            dungeonEntryList_.AddEntriesFrom(input, _repeated_dungeonEntryList_codec);
            break;
          }
          case 82: {
            dungeonEntryPointList_.AddEntriesFrom(input, _repeated_dungeonEntryPointList_codec);
            break;
          }
          case 96: {
            PointId = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            RecommendDungeonId = input.ReadUInt32();
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
            dungeonEntryList_.AddEntriesFrom(ref input, _repeated_dungeonEntryList_codec);
            break;
          }
          case 82: {
            dungeonEntryPointList_.AddEntriesFrom(ref input, _repeated_dungeonEntryPointList_codec);
            break;
          }
          case 96: {
            PointId = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            RecommendDungeonId = input.ReadUInt32();
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
