// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GameplayRecommendationElementReliquaryResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GameplayRecommendationElementReliquaryResponse.proto</summary>
public static partial class GameplayRecommendationElementReliquaryResponseReflection {

  #region Descriptor
  /// <summary>File descriptor for GameplayRecommendationElementReliquaryResponse.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GameplayRecommendationElementReliquaryResponseReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CjRHYW1lcGxheVJlY29tbWVuZGF0aW9uRWxlbWVudFJlbGlxdWFyeVJlc3Bv",
          "bnNlLnByb3RvGjFHYW1lcGxheVJlY29tbWVuZGF0aW9uUmVsaXF1YXJ5TWFp",
          "blByb3BEYXRhLnByb3RvIqUBCi5HYW1lcGxheVJlY29tbWVuZGF0aW9uRWxl",
          "bWVudFJlbGlxdWFyeVJlc3BvbnNlEhQKDGVsZW1lbnRfdHlwZRgBIAEoDRIS",
          "CgplcXVpcF90eXBlGAkgASgNEkkKE21haW5fcHJvcF9kYXRhX2xpc3QYBSAD",
          "KAsyLC5HYW1lcGxheVJlY29tbWVuZGF0aW9uUmVsaXF1YXJ5TWFpblByb3BE",
          "YXRhQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GameplayRecommendationReliquaryMainPropDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GameplayRecommendationElementReliquaryResponse), global::GameplayRecommendationElementReliquaryResponse.Parser, new[]{ "ElementType", "EquipType", "MainPropDataList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GameplayRecommendationElementReliquaryResponse : pb::IMessage<GameplayRecommendationElementReliquaryResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GameplayRecommendationElementReliquaryResponse> _parser = new pb::MessageParser<GameplayRecommendationElementReliquaryResponse>(() => new GameplayRecommendationElementReliquaryResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GameplayRecommendationElementReliquaryResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GameplayRecommendationElementReliquaryResponseReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GameplayRecommendationElementReliquaryResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GameplayRecommendationElementReliquaryResponse(GameplayRecommendationElementReliquaryResponse other) : this() {
    elementType_ = other.elementType_;
    equipType_ = other.equipType_;
    mainPropDataList_ = other.mainPropDataList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GameplayRecommendationElementReliquaryResponse Clone() {
    return new GameplayRecommendationElementReliquaryResponse(this);
  }

  /// <summary>Field number for the "element_type" field.</summary>
  public const int ElementTypeFieldNumber = 1;
  private uint elementType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ElementType {
    get { return elementType_; }
    set {
      elementType_ = value;
    }
  }

  /// <summary>Field number for the "equip_type" field.</summary>
  public const int EquipTypeFieldNumber = 9;
  private uint equipType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EquipType {
    get { return equipType_; }
    set {
      equipType_ = value;
    }
  }

  /// <summary>Field number for the "main_prop_data_list" field.</summary>
  public const int MainPropDataListFieldNumber = 5;
  private static readonly pb::FieldCodec<global::GameplayRecommendationReliquaryMainPropData> _repeated_mainPropDataList_codec
      = pb::FieldCodec.ForMessage(42, global::GameplayRecommendationReliquaryMainPropData.Parser);
  private readonly pbc::RepeatedField<global::GameplayRecommendationReliquaryMainPropData> mainPropDataList_ = new pbc::RepeatedField<global::GameplayRecommendationReliquaryMainPropData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GameplayRecommendationReliquaryMainPropData> MainPropDataList {
    get { return mainPropDataList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GameplayRecommendationElementReliquaryResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GameplayRecommendationElementReliquaryResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ElementType != other.ElementType) return false;
    if (EquipType != other.EquipType) return false;
    if(!mainPropDataList_.Equals(other.mainPropDataList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ElementType != 0) hash ^= ElementType.GetHashCode();
    if (EquipType != 0) hash ^= EquipType.GetHashCode();
    hash ^= mainPropDataList_.GetHashCode();
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
    if (ElementType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ElementType);
    }
    mainPropDataList_.WriteTo(output, _repeated_mainPropDataList_codec);
    if (EquipType != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(EquipType);
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
    if (ElementType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ElementType);
    }
    mainPropDataList_.WriteTo(ref output, _repeated_mainPropDataList_codec);
    if (EquipType != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(EquipType);
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
    if (ElementType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementType);
    }
    if (EquipType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EquipType);
    }
    size += mainPropDataList_.CalculateSize(_repeated_mainPropDataList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GameplayRecommendationElementReliquaryResponse other) {
    if (other == null) {
      return;
    }
    if (other.ElementType != 0) {
      ElementType = other.ElementType;
    }
    if (other.EquipType != 0) {
      EquipType = other.EquipType;
    }
    mainPropDataList_.Add(other.mainPropDataList_);
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
          ElementType = input.ReadUInt32();
          break;
        }
        case 42: {
          mainPropDataList_.AddEntriesFrom(input, _repeated_mainPropDataList_codec);
          break;
        }
        case 72: {
          EquipType = input.ReadUInt32();
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
          ElementType = input.ReadUInt32();
          break;
        }
        case 42: {
          mainPropDataList_.AddEntriesFrom(ref input, _repeated_mainPropDataList_codec);
          break;
        }
        case 72: {
          EquipType = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
