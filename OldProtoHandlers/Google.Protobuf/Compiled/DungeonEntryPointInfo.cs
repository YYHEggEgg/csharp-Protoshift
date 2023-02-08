// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonEntryPointInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from DungeonEntryPointInfo.proto</summary>
  public static partial class DungeonEntryPointInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonEntryPointInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonEntryPointInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtEdW5nZW9uRW50cnlQb2ludEluZm8ucHJvdG8aFkR1bmdlb25FbnRyeUlu",
            "Zm8ucHJvdG8iiAEKFUR1bmdlb25FbnRyeVBvaW50SW5mbxIQCghzY2VuZV9p",
            "ZBgMIAEoDRIQCghwb2ludF9pZBgGIAEoDRItChJkdW5nZW9uX2VudHJ5X2xp",
            "c3QYASADKAsyES5EdW5nZW9uRW50cnlJbmZvEhwKFHJlY29tbWVuZF9kdW5n",
            "ZW9uX2lkGAggASgNQgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.DungeonEntryInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.DungeonEntryPointInfo), global::OldProtos.DungeonEntryPointInfo.Parser, new[]{ "SceneId", "PointId", "DungeonEntryList", "RecommendDungeonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DungeonEntryPointInfo : pb::IMessage<DungeonEntryPointInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonEntryPointInfo> _parser = new pb::MessageParser<DungeonEntryPointInfo>(() => new DungeonEntryPointInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonEntryPointInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.DungeonEntryPointInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryPointInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryPointInfo(DungeonEntryPointInfo other) : this() {
      sceneId_ = other.sceneId_;
      pointId_ = other.pointId_;
      dungeonEntryList_ = other.dungeonEntryList_.Clone();
      recommendDungeonId_ = other.recommendDungeonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryPointInfo Clone() {
      return new DungeonEntryPointInfo(this);
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 12;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "point_id" field.</summary>
    public const int PointIdFieldNumber = 6;
    private uint pointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointId {
      get { return pointId_; }
      set {
        pointId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_entry_list" field.</summary>
    public const int DungeonEntryListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::OldProtos.DungeonEntryInfo> _repeated_dungeonEntryList_codec
        = pb::FieldCodec.ForMessage(10, global::OldProtos.DungeonEntryInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.DungeonEntryInfo> dungeonEntryList_ = new pbc::RepeatedField<global::OldProtos.DungeonEntryInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.DungeonEntryInfo> DungeonEntryList {
      get { return dungeonEntryList_; }
    }

    /// <summary>Field number for the "recommend_dungeon_id" field.</summary>
    public const int RecommendDungeonIdFieldNumber = 8;
    private uint recommendDungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RecommendDungeonId {
      get { return recommendDungeonId_; }
      set {
        recommendDungeonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonEntryPointInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonEntryPointInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneId != other.SceneId) return false;
      if (PointId != other.PointId) return false;
      if(!dungeonEntryList_.Equals(other.dungeonEntryList_)) return false;
      if (RecommendDungeonId != other.RecommendDungeonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (PointId != 0) hash ^= PointId.GetHashCode();
      hash ^= dungeonEntryList_.GetHashCode();
      if (RecommendDungeonId != 0) hash ^= RecommendDungeonId.GetHashCode();
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
      if (PointId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PointId);
      }
      if (RecommendDungeonId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RecommendDungeonId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
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
      if (PointId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PointId);
      }
      if (RecommendDungeonId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RecommendDungeonId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
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
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (PointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
      }
      size += dungeonEntryList_.CalculateSize(_repeated_dungeonEntryList_codec);
      if (RecommendDungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RecommendDungeonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonEntryPointInfo other) {
      if (other == null) {
        return;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.PointId != 0) {
        PointId = other.PointId;
      }
      dungeonEntryList_.Add(other.dungeonEntryList_);
      if (other.RecommendDungeonId != 0) {
        RecommendDungeonId = other.RecommendDungeonId;
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
          case 10: {
            dungeonEntryList_.AddEntriesFrom(input, _repeated_dungeonEntryList_codec);
            break;
          }
          case 48: {
            PointId = input.ReadUInt32();
            break;
          }
          case 64: {
            RecommendDungeonId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
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
            dungeonEntryList_.AddEntriesFrom(ref input, _repeated_dungeonEntryList_codec);
            break;
          }
          case 48: {
            PointId = input.ReadUInt32();
            break;
          }
          case 64: {
            RecommendDungeonId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
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
