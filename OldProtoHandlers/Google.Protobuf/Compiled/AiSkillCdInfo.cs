// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AiSkillCdInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AiSkillCdInfo.proto</summary>
public static partial class AiSkillCdInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for AiSkillCdInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AiSkillCdInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNBaVNraWxsQ2RJbmZvLnByb3RvIvEBCg1BaVNraWxsQ2RJbmZvEjQKDHNr",
          "aWxsX2NkX21hcBgLIAMoCzIeLkFpU2tpbGxDZEluZm8uU2tpbGxDZE1hcEVu",
          "dHJ5Ej8KEnNraWxsX2dyb3VwX2NkX21hcBgGIAMoCzIjLkFpU2tpbGxDZElu",
          "Zm8uU2tpbGxHcm91cENkTWFwRW50cnkaMQoPU2tpbGxDZE1hcEVudHJ5EgsK",
          "A2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAEaNgoUU2tpbGxHcm91cENk",
          "TWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIeChxl",
          "bXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AiSkillCdInfo), global::AiSkillCdInfo.Parser, new[]{ "SkillCdMap", "SkillGroupCdMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AiSkillCdInfo : pb::IMessage<AiSkillCdInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AiSkillCdInfo> _parser = new pb::MessageParser<AiSkillCdInfo>(() => new AiSkillCdInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AiSkillCdInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AiSkillCdInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AiSkillCdInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AiSkillCdInfo(AiSkillCdInfo other) : this() {
    skillCdMap_ = other.skillCdMap_.Clone();
    skillGroupCdMap_ = other.skillGroupCdMap_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AiSkillCdInfo Clone() {
    return new AiSkillCdInfo(this);
  }

  /// <summary>Field number for the "skill_cd_map" field.</summary>
  public const int SkillCdMapFieldNumber = 11;
  private static readonly pbc::MapField<uint, uint>.Codec _map_skillCdMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 90);
  private readonly pbc::MapField<uint, uint> skillCdMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> SkillCdMap {
    get { return skillCdMap_; }
  }

  /// <summary>Field number for the "skill_group_cd_map" field.</summary>
  public const int SkillGroupCdMapFieldNumber = 6;
  private static readonly pbc::MapField<uint, uint>.Codec _map_skillGroupCdMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 50);
  private readonly pbc::MapField<uint, uint> skillGroupCdMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> SkillGroupCdMap {
    get { return skillGroupCdMap_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AiSkillCdInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AiSkillCdInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!SkillCdMap.Equals(other.SkillCdMap)) return false;
    if (!SkillGroupCdMap.Equals(other.SkillGroupCdMap)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= SkillCdMap.GetHashCode();
    hash ^= SkillGroupCdMap.GetHashCode();
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
    skillGroupCdMap_.WriteTo(output, _map_skillGroupCdMap_codec);
    skillCdMap_.WriteTo(output, _map_skillCdMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    skillGroupCdMap_.WriteTo(ref output, _map_skillGroupCdMap_codec);
    skillCdMap_.WriteTo(ref output, _map_skillCdMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += skillCdMap_.CalculateSize(_map_skillCdMap_codec);
    size += skillGroupCdMap_.CalculateSize(_map_skillGroupCdMap_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AiSkillCdInfo other) {
    if (other == null) {
      return;
    }
    skillCdMap_.Add(other.skillCdMap_);
    skillGroupCdMap_.Add(other.skillGroupCdMap_);
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
        case 50: {
          skillGroupCdMap_.AddEntriesFrom(input, _map_skillGroupCdMap_codec);
          break;
        }
        case 90: {
          skillCdMap_.AddEntriesFrom(input, _map_skillCdMap_codec);
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
        case 50: {
          skillGroupCdMap_.AddEntriesFrom(ref input, _map_skillGroupCdMap_codec);
          break;
        }
        case 90: {
          skillCdMap_.AddEntriesFrom(ref input, _map_skillCdMap_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
