// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OneoffGatherPointDetectorData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from OneoffGatherPointDetectorData.proto</summary>
public static partial class OneoffGatherPointDetectorDataReflection {

  #region Descriptor
  /// <summary>File descriptor for OneoffGatherPointDetectorData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static OneoffGatherPointDetectorDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNPbmVvZmZHYXRoZXJQb2ludERldGVjdG9yRGF0YS5wcm90bxoMVmVjdG9y",
          "LnByb3RvIsEBCh1PbmVvZmZHYXRoZXJQb2ludERldGVjdG9yRGF0YRIgCg9o",
          "aW50X2NlbnRlcl9wb3MYByABKAsyBy5WZWN0b3ISEwoLaGludF9yYWRpdXMY",
          "DiABKA0SEwoLbWF0ZXJpYWxfaWQYCiABKA0SEQoJY29uZmlnX2lkGAYgASgN",
          "EhAKCGdyb3VwX2lkGA0gASgNEhgKEGlzX2FsbF9jb2xsZWN0ZWQYBCABKAgS",
          "FQoNaXNfaGludF92YWxpZBgPIAEoCEIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0",
          "Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::OneoffGatherPointDetectorData), global::OneoffGatherPointDetectorData.Parser, new[]{ "HintCenterPos", "HintRadius", "MaterialId", "ConfigId", "GroupId", "IsAllCollected", "IsHintValid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class OneoffGatherPointDetectorData : pb::IMessage<OneoffGatherPointDetectorData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<OneoffGatherPointDetectorData> _parser = new pb::MessageParser<OneoffGatherPointDetectorData>(() => new OneoffGatherPointDetectorData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<OneoffGatherPointDetectorData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::OneoffGatherPointDetectorDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public OneoffGatherPointDetectorData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public OneoffGatherPointDetectorData(OneoffGatherPointDetectorData other) : this() {
    hintCenterPos_ = other.hintCenterPos_ != null ? other.hintCenterPos_.Clone() : null;
    hintRadius_ = other.hintRadius_;
    materialId_ = other.materialId_;
    configId_ = other.configId_;
    groupId_ = other.groupId_;
    isAllCollected_ = other.isAllCollected_;
    isHintValid_ = other.isHintValid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public OneoffGatherPointDetectorData Clone() {
    return new OneoffGatherPointDetectorData(this);
  }

  /// <summary>Field number for the "hint_center_pos" field.</summary>
  public const int HintCenterPosFieldNumber = 7;
  private global::Vector hintCenterPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector HintCenterPos {
    get { return hintCenterPos_; }
    set {
      hintCenterPos_ = value;
    }
  }

  /// <summary>Field number for the "hint_radius" field.</summary>
  public const int HintRadiusFieldNumber = 14;
  private uint hintRadius_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint HintRadius {
    get { return hintRadius_; }
    set {
      hintRadius_ = value;
    }
  }

  /// <summary>Field number for the "material_id" field.</summary>
  public const int MaterialIdFieldNumber = 10;
  private uint materialId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MaterialId {
    get { return materialId_; }
    set {
      materialId_ = value;
    }
  }

  /// <summary>Field number for the "config_id" field.</summary>
  public const int ConfigIdFieldNumber = 6;
  private uint configId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConfigId {
    get { return configId_; }
    set {
      configId_ = value;
    }
  }

  /// <summary>Field number for the "group_id" field.</summary>
  public const int GroupIdFieldNumber = 13;
  private uint groupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GroupId {
    get { return groupId_; }
    set {
      groupId_ = value;
    }
  }

  /// <summary>Field number for the "is_all_collected" field.</summary>
  public const int IsAllCollectedFieldNumber = 4;
  private bool isAllCollected_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsAllCollected {
    get { return isAllCollected_; }
    set {
      isAllCollected_ = value;
    }
  }

  /// <summary>Field number for the "is_hint_valid" field.</summary>
  public const int IsHintValidFieldNumber = 15;
  private bool isHintValid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsHintValid {
    get { return isHintValid_; }
    set {
      isHintValid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as OneoffGatherPointDetectorData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(OneoffGatherPointDetectorData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(HintCenterPos, other.HintCenterPos)) return false;
    if (HintRadius != other.HintRadius) return false;
    if (MaterialId != other.MaterialId) return false;
    if (ConfigId != other.ConfigId) return false;
    if (GroupId != other.GroupId) return false;
    if (IsAllCollected != other.IsAllCollected) return false;
    if (IsHintValid != other.IsHintValid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (hintCenterPos_ != null) hash ^= HintCenterPos.GetHashCode();
    if (HintRadius != 0) hash ^= HintRadius.GetHashCode();
    if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
    if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
    if (GroupId != 0) hash ^= GroupId.GetHashCode();
    if (IsAllCollected != false) hash ^= IsAllCollected.GetHashCode();
    if (IsHintValid != false) hash ^= IsHintValid.GetHashCode();
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
    if (IsAllCollected != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsAllCollected);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ConfigId);
    }
    if (hintCenterPos_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(HintCenterPos);
    }
    if (MaterialId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(MaterialId);
    }
    if (GroupId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GroupId);
    }
    if (HintRadius != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(HintRadius);
    }
    if (IsHintValid != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsHintValid);
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
    if (IsAllCollected != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsAllCollected);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ConfigId);
    }
    if (hintCenterPos_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(HintCenterPos);
    }
    if (MaterialId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(MaterialId);
    }
    if (GroupId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GroupId);
    }
    if (HintRadius != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(HintRadius);
    }
    if (IsHintValid != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsHintValid);
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
    if (hintCenterPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HintCenterPos);
    }
    if (HintRadius != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HintRadius);
    }
    if (MaterialId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
    }
    if (ConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
    }
    if (GroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
    }
    if (IsAllCollected != false) {
      size += 1 + 1;
    }
    if (IsHintValid != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(OneoffGatherPointDetectorData other) {
    if (other == null) {
      return;
    }
    if (other.hintCenterPos_ != null) {
      if (hintCenterPos_ == null) {
        HintCenterPos = new global::Vector();
      }
      HintCenterPos.MergeFrom(other.HintCenterPos);
    }
    if (other.HintRadius != 0) {
      HintRadius = other.HintRadius;
    }
    if (other.MaterialId != 0) {
      MaterialId = other.MaterialId;
    }
    if (other.ConfigId != 0) {
      ConfigId = other.ConfigId;
    }
    if (other.GroupId != 0) {
      GroupId = other.GroupId;
    }
    if (other.IsAllCollected != false) {
      IsAllCollected = other.IsAllCollected;
    }
    if (other.IsHintValid != false) {
      IsHintValid = other.IsHintValid;
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
        case 32: {
          IsAllCollected = input.ReadBool();
          break;
        }
        case 48: {
          ConfigId = input.ReadUInt32();
          break;
        }
        case 58: {
          if (hintCenterPos_ == null) {
            HintCenterPos = new global::Vector();
          }
          input.ReadMessage(HintCenterPos);
          break;
        }
        case 80: {
          MaterialId = input.ReadUInt32();
          break;
        }
        case 104: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 112: {
          HintRadius = input.ReadUInt32();
          break;
        }
        case 120: {
          IsHintValid = input.ReadBool();
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
        case 32: {
          IsAllCollected = input.ReadBool();
          break;
        }
        case 48: {
          ConfigId = input.ReadUInt32();
          break;
        }
        case 58: {
          if (hintCenterPos_ == null) {
            HintCenterPos = new global::Vector();
          }
          input.ReadMessage(HintCenterPos);
          break;
        }
        case 80: {
          MaterialId = input.ReadUInt32();
          break;
        }
        case 104: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 112: {
          HintRadius = input.ReadUInt32();
          break;
        }
        case 120: {
          IsHintValid = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
