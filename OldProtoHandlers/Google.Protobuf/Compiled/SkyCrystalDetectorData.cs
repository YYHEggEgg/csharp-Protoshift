// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SkyCrystalDetectorData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SkyCrystalDetectorData.proto</summary>
public static partial class SkyCrystalDetectorDataReflection {

  #region Descriptor
  /// <summary>File descriptor for SkyCrystalDetectorData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SkyCrystalDetectorDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxTa3lDcnlzdGFsRGV0ZWN0b3JEYXRhLnByb3RvGgxWZWN0b3IucHJvdG8i",
          "dgoWU2t5Q3J5c3RhbERldGVjdG9yRGF0YRIVCg1pc19oaW50X3ZhbGlkGAMg",
          "ASgIEiAKD2hpbnRfY2VudGVyX3BvcxgIIAEoCzIHLlZlY3RvchIQCghncm91",
          "cF9pZBgGIAEoDRIRCgljb25maWdfaWQYCSABKA1CHgocZW11LmdyYXNzY3V0",
          "dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SkyCrystalDetectorData), global::SkyCrystalDetectorData.Parser, new[]{ "IsHintValid", "HintCenterPos", "GroupId", "ConfigId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SkyCrystalDetectorData : pb::IMessage<SkyCrystalDetectorData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SkyCrystalDetectorData> _parser = new pb::MessageParser<SkyCrystalDetectorData>(() => new SkyCrystalDetectorData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SkyCrystalDetectorData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SkyCrystalDetectorDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SkyCrystalDetectorData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SkyCrystalDetectorData(SkyCrystalDetectorData other) : this() {
    isHintValid_ = other.isHintValid_;
    hintCenterPos_ = other.hintCenterPos_ != null ? other.hintCenterPos_.Clone() : null;
    groupId_ = other.groupId_;
    configId_ = other.configId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SkyCrystalDetectorData Clone() {
    return new SkyCrystalDetectorData(this);
  }

  /// <summary>Field number for the "is_hint_valid" field.</summary>
  public const int IsHintValidFieldNumber = 3;
  private bool isHintValid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsHintValid {
    get { return isHintValid_; }
    set {
      isHintValid_ = value;
    }
  }

  /// <summary>Field number for the "hint_center_pos" field.</summary>
  public const int HintCenterPosFieldNumber = 8;
  private global::Vector hintCenterPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector HintCenterPos {
    get { return hintCenterPos_; }
    set {
      hintCenterPos_ = value;
    }
  }

  /// <summary>Field number for the "group_id" field.</summary>
  public const int GroupIdFieldNumber = 6;
  private uint groupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GroupId {
    get { return groupId_; }
    set {
      groupId_ = value;
    }
  }

  /// <summary>Field number for the "config_id" field.</summary>
  public const int ConfigIdFieldNumber = 9;
  private uint configId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConfigId {
    get { return configId_; }
    set {
      configId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SkyCrystalDetectorData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SkyCrystalDetectorData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsHintValid != other.IsHintValid) return false;
    if (!object.Equals(HintCenterPos, other.HintCenterPos)) return false;
    if (GroupId != other.GroupId) return false;
    if (ConfigId != other.ConfigId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsHintValid != false) hash ^= IsHintValid.GetHashCode();
    if (hintCenterPos_ != null) hash ^= HintCenterPos.GetHashCode();
    if (GroupId != 0) hash ^= GroupId.GetHashCode();
    if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
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
    if (IsHintValid != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsHintValid);
    }
    if (GroupId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GroupId);
    }
    if (hintCenterPos_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(HintCenterPos);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ConfigId);
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
    if (IsHintValid != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsHintValid);
    }
    if (GroupId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GroupId);
    }
    if (hintCenterPos_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(HintCenterPos);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ConfigId);
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
    if (IsHintValid != false) {
      size += 1 + 1;
    }
    if (hintCenterPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HintCenterPos);
    }
    if (GroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
    }
    if (ConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SkyCrystalDetectorData other) {
    if (other == null) {
      return;
    }
    if (other.IsHintValid != false) {
      IsHintValid = other.IsHintValid;
    }
    if (other.hintCenterPos_ != null) {
      if (hintCenterPos_ == null) {
        HintCenterPos = new global::Vector();
      }
      HintCenterPos.MergeFrom(other.HintCenterPos);
    }
    if (other.GroupId != 0) {
      GroupId = other.GroupId;
    }
    if (other.ConfigId != 0) {
      ConfigId = other.ConfigId;
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
        case 24: {
          IsHintValid = input.ReadBool();
          break;
        }
        case 48: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 66: {
          if (hintCenterPos_ == null) {
            HintCenterPos = new global::Vector();
          }
          input.ReadMessage(HintCenterPos);
          break;
        }
        case 72: {
          ConfigId = input.ReadUInt32();
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
        case 24: {
          IsHintValid = input.ReadBool();
          break;
        }
        case 48: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 66: {
          if (hintCenterPos_ == null) {
            HintCenterPos = new global::Vector();
          }
          input.ReadMessage(HintCenterPos);
          break;
        }
        case 72: {
          ConfigId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
