// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMetaElementReactionVisual.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AbilityMetaElementReactionVisual.proto</summary>
public static partial class AbilityMetaElementReactionVisualReflection {

  #region Descriptor
  /// <summary>File descriptor for AbilityMetaElementReactionVisual.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AbilityMetaElementReactionVisualReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiZBYmlsaXR5TWV0YUVsZW1lbnRSZWFjdGlvblZpc3VhbC5wcm90byKPAQog",
          "QWJpbGl0eU1ldGFFbGVtZW50UmVhY3Rpb25WaXN1YWwSGwoTZWxlbWVudF9z",
          "b3VyY2VfdHlwZRgGIAEoDRIcChRlbGVtZW50X3JlYWN0b3JfdHlwZRgBIAEo",
          "DRIRCgloaXRfaW5kZXgYDiABKAUSHQoVZWxlbWVudF9yZWFjdGlvbl90eXBl",
          "GAIgASgNQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AbilityMetaElementReactionVisual), global::AbilityMetaElementReactionVisual.Parser, new[]{ "ElementSourceType", "ElementReactorType", "HitIndex", "ElementReactionType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AbilityMetaElementReactionVisual : pb::IMessage<AbilityMetaElementReactionVisual>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AbilityMetaElementReactionVisual> _parser = new pb::MessageParser<AbilityMetaElementReactionVisual>(() => new AbilityMetaElementReactionVisual());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AbilityMetaElementReactionVisual> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AbilityMetaElementReactionVisualReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMetaElementReactionVisual() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMetaElementReactionVisual(AbilityMetaElementReactionVisual other) : this() {
    elementSourceType_ = other.elementSourceType_;
    elementReactorType_ = other.elementReactorType_;
    hitIndex_ = other.hitIndex_;
    elementReactionType_ = other.elementReactionType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMetaElementReactionVisual Clone() {
    return new AbilityMetaElementReactionVisual(this);
  }

  /// <summary>Field number for the "element_source_type" field.</summary>
  public const int ElementSourceTypeFieldNumber = 6;
  private uint elementSourceType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ElementSourceType {
    get { return elementSourceType_; }
    set {
      elementSourceType_ = value;
    }
  }

  /// <summary>Field number for the "element_reactor_type" field.</summary>
  public const int ElementReactorTypeFieldNumber = 1;
  private uint elementReactorType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ElementReactorType {
    get { return elementReactorType_; }
    set {
      elementReactorType_ = value;
    }
  }

  /// <summary>Field number for the "hit_index" field.</summary>
  public const int HitIndexFieldNumber = 14;
  private int hitIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int HitIndex {
    get { return hitIndex_; }
    set {
      hitIndex_ = value;
    }
  }

  /// <summary>Field number for the "element_reaction_type" field.</summary>
  public const int ElementReactionTypeFieldNumber = 2;
  private uint elementReactionType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ElementReactionType {
    get { return elementReactionType_; }
    set {
      elementReactionType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AbilityMetaElementReactionVisual);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AbilityMetaElementReactionVisual other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ElementSourceType != other.ElementSourceType) return false;
    if (ElementReactorType != other.ElementReactorType) return false;
    if (HitIndex != other.HitIndex) return false;
    if (ElementReactionType != other.ElementReactionType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ElementSourceType != 0) hash ^= ElementSourceType.GetHashCode();
    if (ElementReactorType != 0) hash ^= ElementReactorType.GetHashCode();
    if (HitIndex != 0) hash ^= HitIndex.GetHashCode();
    if (ElementReactionType != 0) hash ^= ElementReactionType.GetHashCode();
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
    if (ElementReactorType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ElementReactorType);
    }
    if (ElementReactionType != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ElementReactionType);
    }
    if (ElementSourceType != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ElementSourceType);
    }
    if (HitIndex != 0) {
      output.WriteRawTag(112);
      output.WriteInt32(HitIndex);
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
    if (ElementReactorType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ElementReactorType);
    }
    if (ElementReactionType != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ElementReactionType);
    }
    if (ElementSourceType != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ElementSourceType);
    }
    if (HitIndex != 0) {
      output.WriteRawTag(112);
      output.WriteInt32(HitIndex);
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
    if (ElementSourceType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementSourceType);
    }
    if (ElementReactorType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementReactorType);
    }
    if (HitIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(HitIndex);
    }
    if (ElementReactionType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementReactionType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AbilityMetaElementReactionVisual other) {
    if (other == null) {
      return;
    }
    if (other.ElementSourceType != 0) {
      ElementSourceType = other.ElementSourceType;
    }
    if (other.ElementReactorType != 0) {
      ElementReactorType = other.ElementReactorType;
    }
    if (other.HitIndex != 0) {
      HitIndex = other.HitIndex;
    }
    if (other.ElementReactionType != 0) {
      ElementReactionType = other.ElementReactionType;
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
          ElementReactorType = input.ReadUInt32();
          break;
        }
        case 16: {
          ElementReactionType = input.ReadUInt32();
          break;
        }
        case 48: {
          ElementSourceType = input.ReadUInt32();
          break;
        }
        case 112: {
          HitIndex = input.ReadInt32();
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
          ElementReactorType = input.ReadUInt32();
          break;
        }
        case 16: {
          ElementReactionType = input.ReadUInt32();
          break;
        }
        case 48: {
          ElementSourceType = input.ReadUInt32();
          break;
        }
        case 112: {
          HitIndex = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code