// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomePlantFieldData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HomePlantFieldData.proto</summary>
public static partial class HomePlantFieldDataReflection {

  #region Descriptor
  /// <summary>File descriptor for HomePlantFieldData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HomePlantFieldDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhIb21lUGxhbnRGaWVsZERhdGEucHJvdG8aG0hvbWVQbGFudFN1YkZpZWxk",
          "RGF0YS5wcm90bxoMVmVjdG9yLnByb3RvIpwBChJIb21lUGxhbnRGaWVsZERh",
          "dGESEAoIc2NlbmVfaWQYDyABKA0SEgoKZmllbGRfZ3VpZBgFIAEoDRIuCg5z",
          "dWJfZmllbGRfbGlzdBgDIAMoCzIWLkhvbWVQbGFudFN1YkZpZWxkRGF0YRIU",
          "CgxmdXJuaXR1cmVfaWQYASABKA0SGgoJc3Bhd25fcG9zGAkgASgLMgcuVmVj",
          "dG9yQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HomePlantSubFieldDataReflection.Descriptor, global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HomePlantFieldData), global::HomePlantFieldData.Parser, new[]{ "SceneId", "FieldGuid", "SubFieldList", "FurnitureId", "SpawnPos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class HomePlantFieldData : pb::IMessage<HomePlantFieldData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HomePlantFieldData> _parser = new pb::MessageParser<HomePlantFieldData>(() => new HomePlantFieldData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HomePlantFieldData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HomePlantFieldDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomePlantFieldData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomePlantFieldData(HomePlantFieldData other) : this() {
    sceneId_ = other.sceneId_;
    fieldGuid_ = other.fieldGuid_;
    subFieldList_ = other.subFieldList_.Clone();
    furnitureId_ = other.furnitureId_;
    spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomePlantFieldData Clone() {
    return new HomePlantFieldData(this);
  }

  /// <summary>Field number for the "scene_id" field.</summary>
  public const int SceneIdFieldNumber = 15;
  private uint sceneId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SceneId {
    get { return sceneId_; }
    set {
      sceneId_ = value;
    }
  }

  /// <summary>Field number for the "field_guid" field.</summary>
  public const int FieldGuidFieldNumber = 5;
  private uint fieldGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FieldGuid {
    get { return fieldGuid_; }
    set {
      fieldGuid_ = value;
    }
  }

  /// <summary>Field number for the "sub_field_list" field.</summary>
  public const int SubFieldListFieldNumber = 3;
  private static readonly pb::FieldCodec<global::HomePlantSubFieldData> _repeated_subFieldList_codec
      = pb::FieldCodec.ForMessage(26, global::HomePlantSubFieldData.Parser);
  private readonly pbc::RepeatedField<global::HomePlantSubFieldData> subFieldList_ = new pbc::RepeatedField<global::HomePlantSubFieldData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::HomePlantSubFieldData> SubFieldList {
    get { return subFieldList_; }
  }

  /// <summary>Field number for the "furniture_id" field.</summary>
  public const int FurnitureIdFieldNumber = 1;
  private uint furnitureId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FurnitureId {
    get { return furnitureId_; }
    set {
      furnitureId_ = value;
    }
  }

  /// <summary>Field number for the "spawn_pos" field.</summary>
  public const int SpawnPosFieldNumber = 9;
  private global::Vector spawnPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector SpawnPos {
    get { return spawnPos_; }
    set {
      spawnPos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HomePlantFieldData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HomePlantFieldData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (SceneId != other.SceneId) return false;
    if (FieldGuid != other.FieldGuid) return false;
    if(!subFieldList_.Equals(other.subFieldList_)) return false;
    if (FurnitureId != other.FurnitureId) return false;
    if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (SceneId != 0) hash ^= SceneId.GetHashCode();
    if (FieldGuid != 0) hash ^= FieldGuid.GetHashCode();
    hash ^= subFieldList_.GetHashCode();
    if (FurnitureId != 0) hash ^= FurnitureId.GetHashCode();
    if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
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
    if (FurnitureId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(FurnitureId);
    }
    subFieldList_.WriteTo(output, _repeated_subFieldList_codec);
    if (FieldGuid != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(FieldGuid);
    }
    if (spawnPos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(SpawnPos);
    }
    if (SceneId != 0) {
      output.WriteRawTag(120);
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
    if (FurnitureId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(FurnitureId);
    }
    subFieldList_.WriteTo(ref output, _repeated_subFieldList_codec);
    if (FieldGuid != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(FieldGuid);
    }
    if (spawnPos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(SpawnPos);
    }
    if (SceneId != 0) {
      output.WriteRawTag(120);
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
    if (FieldGuid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FieldGuid);
    }
    size += subFieldList_.CalculateSize(_repeated_subFieldList_codec);
    if (FurnitureId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureId);
    }
    if (spawnPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HomePlantFieldData other) {
    if (other == null) {
      return;
    }
    if (other.SceneId != 0) {
      SceneId = other.SceneId;
    }
    if (other.FieldGuid != 0) {
      FieldGuid = other.FieldGuid;
    }
    subFieldList_.Add(other.subFieldList_);
    if (other.FurnitureId != 0) {
      FurnitureId = other.FurnitureId;
    }
    if (other.spawnPos_ != null) {
      if (spawnPos_ == null) {
        SpawnPos = new global::Vector();
      }
      SpawnPos.MergeFrom(other.SpawnPos);
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
        case 8: {
          FurnitureId = input.ReadUInt32();
          break;
        }
        case 26: {
          subFieldList_.AddEntriesFrom(input, _repeated_subFieldList_codec);
          break;
        }
        case 40: {
          FieldGuid = input.ReadUInt32();
          break;
        }
        case 74: {
          if (spawnPos_ == null) {
            SpawnPos = new global::Vector();
          }
          input.ReadMessage(SpawnPos);
          break;
        }
        case 120: {
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
        case 8: {
          FurnitureId = input.ReadUInt32();
          break;
        }
        case 26: {
          subFieldList_.AddEntriesFrom(ref input, _repeated_subFieldList_codec);
          break;
        }
        case 40: {
          FieldGuid = input.ReadUInt32();
          break;
        }
        case 74: {
          if (spawnPos_ == null) {
            SpawnPos = new global::Vector();
          }
          input.ReadMessage(SpawnPos);
          break;
        }
        case 120: {
          SceneId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code