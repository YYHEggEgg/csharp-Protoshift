// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryHomeSeekFurnitureInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryHomeSeekFurnitureInfo.proto</summary>
public static partial class SceneGalleryHomeSeekFurnitureInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryHomeSeekFurnitureInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryHomeSeekFurnitureInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CidTY2VuZUdhbGxlcnlIb21lU2Vla0Z1cm5pdHVyZUluZm8ucHJvdG8igwIK",
          "IVNjZW5lR2FsbGVyeUhvbWVTZWVrRnVybml0dXJlSW5mbxIZChFjdXJfdGlk",
          "ZV9sZWZ0X251bRgGIAEoDRJQChBwbGF5ZXJfc2NvcmVfbWFwGAggAygLMjYu",
          "U2NlbmVHYWxsZXJ5SG9tZVNlZWtGdXJuaXR1cmVJbmZvLlBsYXllclNjb3Jl",
          "TWFwRW50cnkSHgoWY3VyX3RpZGVfZHVyYXRpb25fdGltZRgMIAEoDRIaChJj",
          "dXJfdGlkZV90b3RhbF9udW0YCSABKA0aNQoTUGxheWVyU2NvcmVNYXBFbnRy",
          "eRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh4KHGVtdS5ncmFz",
          "c2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryHomeSeekFurnitureInfo), global::SceneGalleryHomeSeekFurnitureInfo.Parser, new[]{ "CurTideLeftNum", "PlayerScoreMap", "CurTideDurationTime", "CurTideTotalNum" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SceneGalleryHomeSeekFurnitureInfo : pb::IMessage<SceneGalleryHomeSeekFurnitureInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryHomeSeekFurnitureInfo> _parser = new pb::MessageParser<SceneGalleryHomeSeekFurnitureInfo>(() => new SceneGalleryHomeSeekFurnitureInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryHomeSeekFurnitureInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryHomeSeekFurnitureInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryHomeSeekFurnitureInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryHomeSeekFurnitureInfo(SceneGalleryHomeSeekFurnitureInfo other) : this() {
    curTideLeftNum_ = other.curTideLeftNum_;
    playerScoreMap_ = other.playerScoreMap_.Clone();
    curTideDurationTime_ = other.curTideDurationTime_;
    curTideTotalNum_ = other.curTideTotalNum_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryHomeSeekFurnitureInfo Clone() {
    return new SceneGalleryHomeSeekFurnitureInfo(this);
  }

  /// <summary>Field number for the "cur_tide_left_num" field.</summary>
  public const int CurTideLeftNumFieldNumber = 6;
  private uint curTideLeftNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurTideLeftNum {
    get { return curTideLeftNum_; }
    set {
      curTideLeftNum_ = value;
    }
  }

  /// <summary>Field number for the "player_score_map" field.</summary>
  public const int PlayerScoreMapFieldNumber = 8;
  private static readonly pbc::MapField<uint, uint>.Codec _map_playerScoreMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 66);
  private readonly pbc::MapField<uint, uint> playerScoreMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> PlayerScoreMap {
    get { return playerScoreMap_; }
  }

  /// <summary>Field number for the "cur_tide_duration_time" field.</summary>
  public const int CurTideDurationTimeFieldNumber = 12;
  private uint curTideDurationTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurTideDurationTime {
    get { return curTideDurationTime_; }
    set {
      curTideDurationTime_ = value;
    }
  }

  /// <summary>Field number for the "cur_tide_total_num" field.</summary>
  public const int CurTideTotalNumFieldNumber = 9;
  private uint curTideTotalNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurTideTotalNum {
    get { return curTideTotalNum_; }
    set {
      curTideTotalNum_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneGalleryHomeSeekFurnitureInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryHomeSeekFurnitureInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CurTideLeftNum != other.CurTideLeftNum) return false;
    if (!PlayerScoreMap.Equals(other.PlayerScoreMap)) return false;
    if (CurTideDurationTime != other.CurTideDurationTime) return false;
    if (CurTideTotalNum != other.CurTideTotalNum) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (CurTideLeftNum != 0) hash ^= CurTideLeftNum.GetHashCode();
    hash ^= PlayerScoreMap.GetHashCode();
    if (CurTideDurationTime != 0) hash ^= CurTideDurationTime.GetHashCode();
    if (CurTideTotalNum != 0) hash ^= CurTideTotalNum.GetHashCode();
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
    if (CurTideLeftNum != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(CurTideLeftNum);
    }
    playerScoreMap_.WriteTo(output, _map_playerScoreMap_codec);
    if (CurTideTotalNum != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(CurTideTotalNum);
    }
    if (CurTideDurationTime != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CurTideDurationTime);
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
    if (CurTideLeftNum != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(CurTideLeftNum);
    }
    playerScoreMap_.WriteTo(ref output, _map_playerScoreMap_codec);
    if (CurTideTotalNum != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(CurTideTotalNum);
    }
    if (CurTideDurationTime != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CurTideDurationTime);
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
    if (CurTideLeftNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurTideLeftNum);
    }
    size += playerScoreMap_.CalculateSize(_map_playerScoreMap_codec);
    if (CurTideDurationTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurTideDurationTime);
    }
    if (CurTideTotalNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurTideTotalNum);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneGalleryHomeSeekFurnitureInfo other) {
    if (other == null) {
      return;
    }
    if (other.CurTideLeftNum != 0) {
      CurTideLeftNum = other.CurTideLeftNum;
    }
    playerScoreMap_.Add(other.playerScoreMap_);
    if (other.CurTideDurationTime != 0) {
      CurTideDurationTime = other.CurTideDurationTime;
    }
    if (other.CurTideTotalNum != 0) {
      CurTideTotalNum = other.CurTideTotalNum;
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
        case 48: {
          CurTideLeftNum = input.ReadUInt32();
          break;
        }
        case 66: {
          playerScoreMap_.AddEntriesFrom(input, _map_playerScoreMap_codec);
          break;
        }
        case 72: {
          CurTideTotalNum = input.ReadUInt32();
          break;
        }
        case 96: {
          CurTideDurationTime = input.ReadUInt32();
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
        case 48: {
          CurTideLeftNum = input.ReadUInt32();
          break;
        }
        case 66: {
          playerScoreMap_.AddEntriesFrom(ref input, _map_playerScoreMap_codec);
          break;
        }
        case 72: {
          CurTideTotalNum = input.ReadUInt32();
          break;
        }
        case 96: {
          CurTideDurationTime = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
