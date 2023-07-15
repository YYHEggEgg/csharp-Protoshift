// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from FleurFairGallerySettleInfo.proto</summary>
  public static partial class FleurFairGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBGbGV1ckZhaXJHYWxsZXJ5U2V0dGxlSW5mby5wcm90byL5AQoaRmxldXJG",
            "YWlyR2FsbGVyeVNldHRsZUluZm8SEgoKaXNfc3VjY2VzcxgIIAEoCBJHCg9l",
            "bmVyZ3lfc3RhdF9tYXAYAiADKAsyLi5GbGV1ckZhaXJHYWxsZXJ5U2V0dGxl",
            "SW5mby5FbmVyZ3lTdGF0TWFwRW50cnkSDgoGZW5lcmd5GAMgASgNEhsKE2dh",
            "bGxlcnlfc3RhZ2VfaW5kZXgYBiABKA0SGwoTZ2FsbGVyeV9zdGFnZV9jb3Vu",
            "dBgPIAEoDRo0ChJFbmVyZ3lTdGF0TWFwRW50cnkSCwoDa2V5GAEgASgNEg0K",
            "BXZhbHVlGAIgASgFOgI4AUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.FleurFairGallerySettleInfo), global::NewProtos.FleurFairGallerySettleInfo.Parser, new[]{ "IsSuccess", "EnergyStatMap", "Energy", "GalleryStageIndex", "GalleryStageCount" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FleurFairGallerySettleInfo : pb::IMessage<FleurFairGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairGallerySettleInfo> _parser = new pb::MessageParser<FleurFairGallerySettleInfo>(() => new FleurFairGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.FleurFairGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairGallerySettleInfo(FleurFairGallerySettleInfo other) : this() {
      isSuccess_ = other.isSuccess_;
      energyStatMap_ = other.energyStatMap_.Clone();
      energy_ = other.energy_;
      galleryStageIndex_ = other.galleryStageIndex_;
      galleryStageCount_ = other.galleryStageCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairGallerySettleInfo Clone() {
      return new FleurFairGallerySettleInfo(this);
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 8;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "energy_stat_map" field.</summary>
    public const int EnergyStatMapFieldNumber = 2;
    private static readonly pbc::MapField<uint, int>.Codec _map_energyStatMap_codec
        = new pbc::MapField<uint, int>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 18);
    private readonly pbc::MapField<uint, int> energyStatMap_ = new pbc::MapField<uint, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, int> EnergyStatMap {
      get { return energyStatMap_; }
    }

    /// <summary>Field number for the "energy" field.</summary>
    public const int EnergyFieldNumber = 3;
    private uint energy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Energy {
      get { return energy_; }
      set {
        energy_ = value;
      }
    }

    /// <summary>Field number for the "gallery_stage_index" field.</summary>
    public const int GalleryStageIndexFieldNumber = 6;
    private uint galleryStageIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryStageIndex {
      get { return galleryStageIndex_; }
      set {
        galleryStageIndex_ = value;
      }
    }

    /// <summary>Field number for the "gallery_stage_count" field.</summary>
    public const int GalleryStageCountFieldNumber = 15;
    private uint galleryStageCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryStageCount {
      get { return galleryStageCount_; }
      set {
        galleryStageCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FleurFairGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (!EnergyStatMap.Equals(other.EnergyStatMap)) return false;
      if (Energy != other.Energy) return false;
      if (GalleryStageIndex != other.GalleryStageIndex) return false;
      if (GalleryStageCount != other.GalleryStageCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      hash ^= EnergyStatMap.GetHashCode();
      if (Energy != 0) hash ^= Energy.GetHashCode();
      if (GalleryStageIndex != 0) hash ^= GalleryStageIndex.GetHashCode();
      if (GalleryStageCount != 0) hash ^= GalleryStageCount.GetHashCode();
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
      energyStatMap_.WriteTo(output, _map_energyStatMap_codec);
      if (Energy != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Energy);
      }
      if (GalleryStageIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GalleryStageIndex);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsSuccess);
      }
      if (GalleryStageCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GalleryStageCount);
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
      energyStatMap_.WriteTo(ref output, _map_energyStatMap_codec);
      if (Energy != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Energy);
      }
      if (GalleryStageIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GalleryStageIndex);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsSuccess);
      }
      if (GalleryStageCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GalleryStageCount);
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
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      size += energyStatMap_.CalculateSize(_map_energyStatMap_codec);
      if (Energy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Energy);
      }
      if (GalleryStageIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryStageIndex);
      }
      if (GalleryStageCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryStageCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      energyStatMap_.MergeFrom(other.energyStatMap_);
      if (other.Energy != 0) {
        Energy = other.Energy;
      }
      if (other.GalleryStageIndex != 0) {
        GalleryStageIndex = other.GalleryStageIndex;
      }
      if (other.GalleryStageCount != 0) {
        GalleryStageCount = other.GalleryStageCount;
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
            energyStatMap_.AddEntriesFrom(input, _map_energyStatMap_codec);
            break;
          }
          case 24: {
            Energy = input.ReadUInt32();
            break;
          }
          case 48: {
            GalleryStageIndex = input.ReadUInt32();
            break;
          }
          case 64: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 120: {
            GalleryStageCount = input.ReadUInt32();
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
            energyStatMap_.AddEntriesFrom(ref input, _map_energyStatMap_codec);
            break;
          }
          case 24: {
            Energy = input.ReadUInt32();
            break;
          }
          case 48: {
            GalleryStageIndex = input.ReadUInt32();
            break;
          }
          case 64: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 120: {
            GalleryStageCount = input.ReadUInt32();
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
