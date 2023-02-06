// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomCommonNodeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CustomCommonNodeInfo.proto</summary>
public static partial class CustomCommonNodeInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for CustomCommonNodeInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CustomCommonNodeInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpDdXN0b21Db21tb25Ob2RlSW5mby5wcm90byJYChRDdXN0b21Db21tb25O",
          "b2RlSW5mbxIUCgxwYXJlbnRfaW5kZXgYASABKAUSEQoJY29uZmlnX2lkGAIg",
          "ASgNEhcKD3Nsb3RfaWRlbnRpZmllchgDIAEoCUIWChRvcmcuc29yYXBvaW50",
          "YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CustomCommonNodeInfo), global::CustomCommonNodeInfo.Parser, new[]{ "ParentIndex", "ConfigId", "SlotIdentifier" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CustomCommonNodeInfo : pb::IMessage<CustomCommonNodeInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CustomCommonNodeInfo> _parser = new pb::MessageParser<CustomCommonNodeInfo>(() => new CustomCommonNodeInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CustomCommonNodeInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CustomCommonNodeInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomCommonNodeInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomCommonNodeInfo(CustomCommonNodeInfo other) : this() {
    parentIndex_ = other.parentIndex_;
    configId_ = other.configId_;
    slotIdentifier_ = other.slotIdentifier_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomCommonNodeInfo Clone() {
    return new CustomCommonNodeInfo(this);
  }

  /// <summary>Field number for the "parent_index" field.</summary>
  public const int ParentIndexFieldNumber = 1;
  private int parentIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int ParentIndex {
    get { return parentIndex_; }
    set {
      parentIndex_ = value;
    }
  }

  /// <summary>Field number for the "config_id" field.</summary>
  public const int ConfigIdFieldNumber = 2;
  private uint configId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConfigId {
    get { return configId_; }
    set {
      configId_ = value;
    }
  }

  /// <summary>Field number for the "slot_identifier" field.</summary>
  public const int SlotIdentifierFieldNumber = 3;
  private string slotIdentifier_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string SlotIdentifier {
    get { return slotIdentifier_; }
    set {
      slotIdentifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CustomCommonNodeInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CustomCommonNodeInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ParentIndex != other.ParentIndex) return false;
    if (ConfigId != other.ConfigId) return false;
    if (SlotIdentifier != other.SlotIdentifier) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ParentIndex != 0) hash ^= ParentIndex.GetHashCode();
    if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
    if (SlotIdentifier.Length != 0) hash ^= SlotIdentifier.GetHashCode();
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
    if (ParentIndex != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(ParentIndex);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ConfigId);
    }
    if (SlotIdentifier.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(SlotIdentifier);
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
    if (ParentIndex != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(ParentIndex);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ConfigId);
    }
    if (SlotIdentifier.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(SlotIdentifier);
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
    if (ParentIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(ParentIndex);
    }
    if (ConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
    }
    if (SlotIdentifier.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(SlotIdentifier);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CustomCommonNodeInfo other) {
    if (other == null) {
      return;
    }
    if (other.ParentIndex != 0) {
      ParentIndex = other.ParentIndex;
    }
    if (other.ConfigId != 0) {
      ConfigId = other.ConfigId;
    }
    if (other.SlotIdentifier.Length != 0) {
      SlotIdentifier = other.SlotIdentifier;
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
          ParentIndex = input.ReadInt32();
          break;
        }
        case 16: {
          ConfigId = input.ReadUInt32();
          break;
        }
        case 26: {
          SlotIdentifier = input.ReadString();
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
          ParentIndex = input.ReadInt32();
          break;
        }
        case 16: {
          ConfigId = input.ReadUInt32();
          break;
        }
        case 26: {
          SlotIdentifier = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
