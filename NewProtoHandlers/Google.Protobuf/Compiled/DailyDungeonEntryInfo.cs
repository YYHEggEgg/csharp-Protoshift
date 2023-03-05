// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DailyDungeonEntryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from DailyDungeonEntryInfo.proto</summary>
  public static partial class DailyDungeonEntryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DailyDungeonEntryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DailyDungeonEntryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtEYWlseUR1bmdlb25FbnRyeUluZm8ucHJvdG8aFkR1bmdlb25FbnRyeUlu",
            "Zm8ucHJvdG8iqQEKFURhaWx5RHVuZ2VvbkVudHJ5SW5mbxI3ChxyZWNvbW1l",
            "bmRfZHVuZ2Vvbl9lbnRyeV9pbmZvGAYgASgLMhEuRHVuZ2VvbkVudHJ5SW5m",
            "bxIfChdkdW5nZW9uX2VudHJ5X2NvbmZpZ19pZBgKIAEoDRIcChRyZWNvbW1l",
            "bmRfZHVuZ2Vvbl9pZBgFIAEoDRIYChBkdW5nZW9uX2VudHJ5X2lkGAwgASgN",
            "QgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.DungeonEntryInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.DailyDungeonEntryInfo), global::NewProtos.DailyDungeonEntryInfo.Parser, new[]{ "RecommendDungeonEntryInfo", "DungeonEntryConfigId", "RecommendDungeonId", "DungeonEntryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DailyDungeonEntryInfo : pb::IMessage<DailyDungeonEntryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DailyDungeonEntryInfo> _parser = new pb::MessageParser<DailyDungeonEntryInfo>(() => new DailyDungeonEntryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DailyDungeonEntryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.DailyDungeonEntryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyDungeonEntryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyDungeonEntryInfo(DailyDungeonEntryInfo other) : this() {
      recommendDungeonEntryInfo_ = other.recommendDungeonEntryInfo_ != null ? other.recommendDungeonEntryInfo_.Clone() : null;
      dungeonEntryConfigId_ = other.dungeonEntryConfigId_;
      recommendDungeonId_ = other.recommendDungeonId_;
      dungeonEntryId_ = other.dungeonEntryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyDungeonEntryInfo Clone() {
      return new DailyDungeonEntryInfo(this);
    }

    /// <summary>Field number for the "recommend_dungeon_entry_info" field.</summary>
    public const int RecommendDungeonEntryInfoFieldNumber = 6;
    private global::NewProtos.DungeonEntryInfo recommendDungeonEntryInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.DungeonEntryInfo RecommendDungeonEntryInfo {
      get { return recommendDungeonEntryInfo_; }
      set {
        recommendDungeonEntryInfo_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_entry_config_id" field.</summary>
    public const int DungeonEntryConfigIdFieldNumber = 10;
    private uint dungeonEntryConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonEntryConfigId {
      get { return dungeonEntryConfigId_; }
      set {
        dungeonEntryConfigId_ = value;
      }
    }

    /// <summary>Field number for the "recommend_dungeon_id" field.</summary>
    public const int RecommendDungeonIdFieldNumber = 5;
    private uint recommendDungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RecommendDungeonId {
      get { return recommendDungeonId_; }
      set {
        recommendDungeonId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_entry_id" field.</summary>
    public const int DungeonEntryIdFieldNumber = 12;
    private uint dungeonEntryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonEntryId {
      get { return dungeonEntryId_; }
      set {
        dungeonEntryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DailyDungeonEntryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DailyDungeonEntryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RecommendDungeonEntryInfo, other.RecommendDungeonEntryInfo)) return false;
      if (DungeonEntryConfigId != other.DungeonEntryConfigId) return false;
      if (RecommendDungeonId != other.RecommendDungeonId) return false;
      if (DungeonEntryId != other.DungeonEntryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (recommendDungeonEntryInfo_ != null) hash ^= RecommendDungeonEntryInfo.GetHashCode();
      if (DungeonEntryConfigId != 0) hash ^= DungeonEntryConfigId.GetHashCode();
      if (RecommendDungeonId != 0) hash ^= RecommendDungeonId.GetHashCode();
      if (DungeonEntryId != 0) hash ^= DungeonEntryId.GetHashCode();
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
      if (RecommendDungeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RecommendDungeonId);
      }
      if (recommendDungeonEntryInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RecommendDungeonEntryInfo);
      }
      if (DungeonEntryConfigId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DungeonEntryConfigId);
      }
      if (DungeonEntryId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DungeonEntryId);
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
      if (RecommendDungeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(RecommendDungeonId);
      }
      if (recommendDungeonEntryInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RecommendDungeonEntryInfo);
      }
      if (DungeonEntryConfigId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DungeonEntryConfigId);
      }
      if (DungeonEntryId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DungeonEntryId);
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
      if (recommendDungeonEntryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecommendDungeonEntryInfo);
      }
      if (DungeonEntryConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonEntryConfigId);
      }
      if (RecommendDungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RecommendDungeonId);
      }
      if (DungeonEntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonEntryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DailyDungeonEntryInfo other) {
      if (other == null) {
        return;
      }
      if (other.recommendDungeonEntryInfo_ != null) {
        if (recommendDungeonEntryInfo_ == null) {
          RecommendDungeonEntryInfo = new global::NewProtos.DungeonEntryInfo();
        }
        RecommendDungeonEntryInfo.MergeFrom(other.RecommendDungeonEntryInfo);
      }
      if (other.DungeonEntryConfigId != 0) {
        DungeonEntryConfigId = other.DungeonEntryConfigId;
      }
      if (other.RecommendDungeonId != 0) {
        RecommendDungeonId = other.RecommendDungeonId;
      }
      if (other.DungeonEntryId != 0) {
        DungeonEntryId = other.DungeonEntryId;
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
          case 40: {
            RecommendDungeonId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (recommendDungeonEntryInfo_ == null) {
              RecommendDungeonEntryInfo = new global::NewProtos.DungeonEntryInfo();
            }
            input.ReadMessage(RecommendDungeonEntryInfo);
            break;
          }
          case 80: {
            DungeonEntryConfigId = input.ReadUInt32();
            break;
          }
          case 96: {
            DungeonEntryId = input.ReadUInt32();
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
          case 40: {
            RecommendDungeonId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (recommendDungeonEntryInfo_ == null) {
              RecommendDungeonEntryInfo = new global::NewProtos.DungeonEntryInfo();
            }
            input.ReadMessage(RecommendDungeonEntryInfo);
            break;
          }
          case 80: {
            DungeonEntryConfigId = input.ReadUInt32();
            break;
          }
          case 96: {
            DungeonEntryId = input.ReadUInt32();
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