// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SumoActivityDetailInfo.proto</summary>
  public static partial class SumoActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SumoActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SumoActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTdW1vQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGhNTdW1vU3RhZ2VEYXRh",
            "LnByb3RvIs4BChZTdW1vQWN0aXZpdHlEZXRhaWxJbmZvEhUKDWRpZmZpY3Vs",
            "dHlfaWQYCyABKA0SFQoNbGFzdF9zdGFnZV9pZBgMIAEoDRJBCg5zdW1vX3N0",
            "YWdlX21hcBgBIAMoCzIpLlN1bW9BY3Rpdml0eURldGFpbEluZm8uU3Vtb1N0",
            "YWdlTWFwRW50cnkaQwoRU3Vtb1N0YWdlTWFwRW50cnkSCwoDa2V5GAEgASgN",
            "Eh0KBXZhbHVlGAIgASgLMg4uU3Vtb1N0YWdlRGF0YToCOAFCDKoCCU5ld1By",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.SumoStageDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SumoActivityDetailInfo), global::NewProtos.SumoActivityDetailInfo.Parser, new[]{ "DifficultyId", "LastStageId", "SumoStageMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SumoActivityDetailInfo : pb::IMessage<SumoActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SumoActivityDetailInfo> _parser = new pb::MessageParser<SumoActivityDetailInfo>(() => new SumoActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SumoActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SumoActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoActivityDetailInfo(SumoActivityDetailInfo other) : this() {
      difficultyId_ = other.difficultyId_;
      lastStageId_ = other.lastStageId_;
      sumoStageMap_ = other.sumoStageMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoActivityDetailInfo Clone() {
      return new SumoActivityDetailInfo(this);
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 11;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "last_stage_id" field.</summary>
    public const int LastStageIdFieldNumber = 12;
    private uint lastStageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastStageId {
      get { return lastStageId_; }
      set {
        lastStageId_ = value;
      }
    }

    /// <summary>Field number for the "sumo_stage_map" field.</summary>
    public const int SumoStageMapFieldNumber = 1;
    private static readonly pbc::MapField<uint, global::NewProtos.SumoStageData>.Codec _map_sumoStageMap_codec
        = new pbc::MapField<uint, global::NewProtos.SumoStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::NewProtos.SumoStageData.Parser), 10);
    private readonly pbc::MapField<uint, global::NewProtos.SumoStageData> sumoStageMap_ = new pbc::MapField<uint, global::NewProtos.SumoStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::NewProtos.SumoStageData> SumoStageMap {
      get { return sumoStageMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SumoActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SumoActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DifficultyId != other.DifficultyId) return false;
      if (LastStageId != other.LastStageId) return false;
      if (!SumoStageMap.Equals(other.SumoStageMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      if (LastStageId != 0) hash ^= LastStageId.GetHashCode();
      hash ^= SumoStageMap.GetHashCode();
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
      sumoStageMap_.WriteTo(output, _map_sumoStageMap_codec);
      if (DifficultyId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DifficultyId);
      }
      if (LastStageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LastStageId);
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
      sumoStageMap_.WriteTo(ref output, _map_sumoStageMap_codec);
      if (DifficultyId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DifficultyId);
      }
      if (LastStageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LastStageId);
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
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (LastStageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastStageId);
      }
      size += sumoStageMap_.CalculateSize(_map_sumoStageMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SumoActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      if (other.LastStageId != 0) {
        LastStageId = other.LastStageId;
      }
      sumoStageMap_.MergeFrom(other.sumoStageMap_);
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
          case 10: {
            sumoStageMap_.AddEntriesFrom(input, _map_sumoStageMap_codec);
            break;
          }
          case 88: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 96: {
            LastStageId = input.ReadUInt32();
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
          case 10: {
            sumoStageMap_.AddEntriesFrom(ref input, _map_sumoStageMap_codec);
            break;
          }
          case 88: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 96: {
            LastStageId = input.ReadUInt32();
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
