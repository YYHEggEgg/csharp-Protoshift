// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ArenaChallengeActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ArenaChallengeActivityDetailInfo.proto</summary>
  public static partial class ArenaChallengeActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ArenaChallengeActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArenaChallengeActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZBcmVuYUNoYWxsZW5nZUFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxogQXJl",
            "bmFDaGFsbGVuZ2VNb25zdGVyTGV2ZWwucHJvdG8ilAIKIEFyZW5hQ2hhbGxl",
            "bmdlQWN0aXZpdHlEZXRhaWxJbmZvEhsKE2lzX2ZpbmlzaF9hbnlfbGV2ZWwY",
            "DiABKAgSVAoTbGV2ZWxfb3Blbl90aW1lX21hcBgDIAMoCzI3LkFyZW5hQ2hh",
            "bGxlbmdlQWN0aXZpdHlEZXRhaWxJbmZvLkxldmVsT3BlblRpbWVNYXBFbnRy",
            "eRITCgt3b3JsZF9sZXZlbBgPIAEoDRIvCgpsZXZlbF9saXN0GAkgAygLMhsu",
            "QXJlbmFDaGFsbGVuZ2VNb25zdGVyTGV2ZWwaNwoVTGV2ZWxPcGVuVGltZU1h",
            "cEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCDKoCCU9s",
            "ZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ArenaChallengeMonsterLevelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ArenaChallengeActivityDetailInfo), global::OldProtos.ArenaChallengeActivityDetailInfo.Parser, new[]{ "IsFinishAnyLevel", "LevelOpenTimeMap", "WorldLevel", "LevelList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ArenaChallengeActivityDetailInfo : pb::IMessage<ArenaChallengeActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ArenaChallengeActivityDetailInfo> _parser = new pb::MessageParser<ArenaChallengeActivityDetailInfo>(() => new ArenaChallengeActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ArenaChallengeActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ArenaChallengeActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeActivityDetailInfo(ArenaChallengeActivityDetailInfo other) : this() {
      isFinishAnyLevel_ = other.isFinishAnyLevel_;
      levelOpenTimeMap_ = other.levelOpenTimeMap_.Clone();
      worldLevel_ = other.worldLevel_;
      levelList_ = other.levelList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeActivityDetailInfo Clone() {
      return new ArenaChallengeActivityDetailInfo(this);
    }

    /// <summary>Field number for the "is_finish_any_level" field.</summary>
    public const int IsFinishAnyLevelFieldNumber = 14;
    private bool isFinishAnyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishAnyLevel {
      get { return isFinishAnyLevel_; }
      set {
        isFinishAnyLevel_ = value;
      }
    }

    /// <summary>Field number for the "level_open_time_map" field.</summary>
    public const int LevelOpenTimeMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_levelOpenTimeMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> levelOpenTimeMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> LevelOpenTimeMap {
      get { return levelOpenTimeMap_; }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 15;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "level_list" field.</summary>
    public const int LevelListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::OldProtos.ArenaChallengeMonsterLevel> _repeated_levelList_codec
        = pb::FieldCodec.ForMessage(74, global::OldProtos.ArenaChallengeMonsterLevel.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ArenaChallengeMonsterLevel> levelList_ = new pbc::RepeatedField<global::OldProtos.ArenaChallengeMonsterLevel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ArenaChallengeMonsterLevel> LevelList {
      get { return levelList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ArenaChallengeActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ArenaChallengeActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinishAnyLevel != other.IsFinishAnyLevel) return false;
      if (!LevelOpenTimeMap.Equals(other.LevelOpenTimeMap)) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if(!levelList_.Equals(other.levelList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinishAnyLevel != false) hash ^= IsFinishAnyLevel.GetHashCode();
      hash ^= LevelOpenTimeMap.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      hash ^= levelList_.GetHashCode();
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
      levelOpenTimeMap_.WriteTo(output, _map_levelOpenTimeMap_codec);
      levelList_.WriteTo(output, _repeated_levelList_codec);
      if (IsFinishAnyLevel != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinishAnyLevel);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(WorldLevel);
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
      levelOpenTimeMap_.WriteTo(ref output, _map_levelOpenTimeMap_codec);
      levelList_.WriteTo(ref output, _repeated_levelList_codec);
      if (IsFinishAnyLevel != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinishAnyLevel);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(WorldLevel);
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
      if (IsFinishAnyLevel != false) {
        size += 1 + 1;
      }
      size += levelOpenTimeMap_.CalculateSize(_map_levelOpenTimeMap_codec);
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      size += levelList_.CalculateSize(_repeated_levelList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ArenaChallengeActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsFinishAnyLevel != false) {
        IsFinishAnyLevel = other.IsFinishAnyLevel;
      }
      levelOpenTimeMap_.MergeFrom(other.levelOpenTimeMap_);
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      levelList_.Add(other.levelList_);
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
            levelOpenTimeMap_.AddEntriesFrom(input, _map_levelOpenTimeMap_codec);
            break;
          }
          case 74: {
            levelList_.AddEntriesFrom(input, _repeated_levelList_codec);
            break;
          }
          case 112: {
            IsFinishAnyLevel = input.ReadBool();
            break;
          }
          case 120: {
            WorldLevel = input.ReadUInt32();
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
            levelOpenTimeMap_.AddEntriesFrom(ref input, _map_levelOpenTimeMap_codec);
            break;
          }
          case 74: {
            levelList_.AddEntriesFrom(ref input, _repeated_levelList_codec);
            break;
          }
          case 112: {
            IsFinishAnyLevel = input.ReadBool();
            break;
          }
          case 120: {
            WorldLevel = input.ReadUInt32();
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
