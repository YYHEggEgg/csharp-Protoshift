// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryFallInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryFallInfo.proto</summary>
public static partial class SceneGalleryFallInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryFallInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryFallInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpTY2VuZUdhbGxlcnlGYWxsSW5mby5wcm90bxoURmFsbFBsYXllckluZm8u",
          "cHJvdG8izwEKFFNjZW5lR2FsbGVyeUZhbGxJbmZvElUKGnNjZW5lX3BsYXll",
          "cl9mYWxsX2luZm9fbWFwGAwgAygLMjEuU2NlbmVHYWxsZXJ5RmFsbEluZm8u",
          "U2NlbmVQbGF5ZXJGYWxsSW5mb01hcEVudHJ5EhAKCGVuZF90aW1lGAIgASgN",
          "Gk4KG1NjZW5lUGxheWVyRmFsbEluZm9NYXBFbnRyeRILCgNrZXkYASABKA0S",
          "HgoFdmFsdWUYAiABKAsyDy5GYWxsUGxheWVySW5mbzoCOAFCHgocZW11Lmdy",
          "YXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::FallPlayerInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryFallInfo), global::SceneGalleryFallInfo.Parser, new[]{ "ScenePlayerFallInfoMap", "EndTime" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SceneGalleryFallInfo : pb::IMessage<SceneGalleryFallInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryFallInfo> _parser = new pb::MessageParser<SceneGalleryFallInfo>(() => new SceneGalleryFallInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryFallInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryFallInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryFallInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryFallInfo(SceneGalleryFallInfo other) : this() {
    scenePlayerFallInfoMap_ = other.scenePlayerFallInfoMap_.Clone();
    endTime_ = other.endTime_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryFallInfo Clone() {
    return new SceneGalleryFallInfo(this);
  }

  /// <summary>Field number for the "scene_player_fall_info_map" field.</summary>
  public const int ScenePlayerFallInfoMapFieldNumber = 12;
  private static readonly pbc::MapField<uint, global::FallPlayerInfo>.Codec _map_scenePlayerFallInfoMap_codec
      = new pbc::MapField<uint, global::FallPlayerInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::FallPlayerInfo.Parser), 98);
  private readonly pbc::MapField<uint, global::FallPlayerInfo> scenePlayerFallInfoMap_ = new pbc::MapField<uint, global::FallPlayerInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::FallPlayerInfo> ScenePlayerFallInfoMap {
    get { return scenePlayerFallInfoMap_; }
  }

  /// <summary>Field number for the "end_time" field.</summary>
  public const int EndTimeFieldNumber = 2;
  private uint endTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EndTime {
    get { return endTime_; }
    set {
      endTime_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneGalleryFallInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryFallInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!ScenePlayerFallInfoMap.Equals(other.ScenePlayerFallInfoMap)) return false;
    if (EndTime != other.EndTime) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= ScenePlayerFallInfoMap.GetHashCode();
    if (EndTime != 0) hash ^= EndTime.GetHashCode();
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
    if (EndTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(EndTime);
    }
    scenePlayerFallInfoMap_.WriteTo(output, _map_scenePlayerFallInfoMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (EndTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(EndTime);
    }
    scenePlayerFallInfoMap_.WriteTo(ref output, _map_scenePlayerFallInfoMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += scenePlayerFallInfoMap_.CalculateSize(_map_scenePlayerFallInfoMap_codec);
    if (EndTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneGalleryFallInfo other) {
    if (other == null) {
      return;
    }
    scenePlayerFallInfoMap_.Add(other.scenePlayerFallInfoMap_);
    if (other.EndTime != 0) {
      EndTime = other.EndTime;
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
          EndTime = input.ReadUInt32();
          break;
        }
        case 98: {
          scenePlayerFallInfoMap_.AddEntriesFrom(input, _map_scenePlayerFallInfoMap_codec);
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
          EndTime = input.ReadUInt32();
          break;
        }
        case 98: {
          scenePlayerFallInfoMap_.AddEntriesFrom(ref input, _map_scenePlayerFallInfoMap_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
