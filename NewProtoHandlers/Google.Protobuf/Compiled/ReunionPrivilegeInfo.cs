// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReunionPrivilegeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ReunionPrivilegeInfo.proto</summary>
public static partial class ReunionPrivilegeInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for ReunionPrivilegeInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReunionPrivilegeInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpSZXVuaW9uUHJpdmlsZWdlSW5mby5wcm90byJmChRSZXVuaW9uUHJpdmls",
          "ZWdlSW5mbxIbChNVbmszMzAwX0dKQkVBRlBNRkFBGA4gASgNEhQKDHByaXZp",
          "bGVnZV9pZBgCIAEoDRIbChNVbmszMzAwX0FMT0xBQ0ZHTUhJGAEgASgNQhYK",
          "FG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReunionPrivilegeInfo), global::ReunionPrivilegeInfo.Parser, new[]{ "Unk3300GJBEAFPMFAA", "PrivilegeId", "Unk3300ALOLACFGMHI" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ReunionPrivilegeInfo : pb::IMessage<ReunionPrivilegeInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReunionPrivilegeInfo> _parser = new pb::MessageParser<ReunionPrivilegeInfo>(() => new ReunionPrivilegeInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ReunionPrivilegeInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReunionPrivilegeInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReunionPrivilegeInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReunionPrivilegeInfo(ReunionPrivilegeInfo other) : this() {
    unk3300GJBEAFPMFAA_ = other.unk3300GJBEAFPMFAA_;
    privilegeId_ = other.privilegeId_;
    unk3300ALOLACFGMHI_ = other.unk3300ALOLACFGMHI_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReunionPrivilegeInfo Clone() {
    return new ReunionPrivilegeInfo(this);
  }

  /// <summary>Field number for the "Unk3300_GJBEAFPMFAA" field.</summary>
  public const int Unk3300GJBEAFPMFAAFieldNumber = 14;
  private uint unk3300GJBEAFPMFAA_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300GJBEAFPMFAA {
    get { return unk3300GJBEAFPMFAA_; }
    set {
      unk3300GJBEAFPMFAA_ = value;
    }
  }

  /// <summary>Field number for the "privilege_id" field.</summary>
  public const int PrivilegeIdFieldNumber = 2;
  private uint privilegeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PrivilegeId {
    get { return privilegeId_; }
    set {
      privilegeId_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_ALOLACFGMHI" field.</summary>
  public const int Unk3300ALOLACFGMHIFieldNumber = 1;
  private uint unk3300ALOLACFGMHI_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300ALOLACFGMHI {
    get { return unk3300ALOLACFGMHI_; }
    set {
      unk3300ALOLACFGMHI_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ReunionPrivilegeInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ReunionPrivilegeInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Unk3300GJBEAFPMFAA != other.Unk3300GJBEAFPMFAA) return false;
    if (PrivilegeId != other.PrivilegeId) return false;
    if (Unk3300ALOLACFGMHI != other.Unk3300ALOLACFGMHI) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Unk3300GJBEAFPMFAA != 0) hash ^= Unk3300GJBEAFPMFAA.GetHashCode();
    if (PrivilegeId != 0) hash ^= PrivilegeId.GetHashCode();
    if (Unk3300ALOLACFGMHI != 0) hash ^= Unk3300ALOLACFGMHI.GetHashCode();
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
    if (Unk3300ALOLACFGMHI != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Unk3300ALOLACFGMHI);
    }
    if (PrivilegeId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(PrivilegeId);
    }
    if (Unk3300GJBEAFPMFAA != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300GJBEAFPMFAA);
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
    if (Unk3300ALOLACFGMHI != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Unk3300ALOLACFGMHI);
    }
    if (PrivilegeId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(PrivilegeId);
    }
    if (Unk3300GJBEAFPMFAA != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300GJBEAFPMFAA);
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
    if (Unk3300GJBEAFPMFAA != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GJBEAFPMFAA);
    }
    if (PrivilegeId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrivilegeId);
    }
    if (Unk3300ALOLACFGMHI != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300ALOLACFGMHI);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ReunionPrivilegeInfo other) {
    if (other == null) {
      return;
    }
    if (other.Unk3300GJBEAFPMFAA != 0) {
      Unk3300GJBEAFPMFAA = other.Unk3300GJBEAFPMFAA;
    }
    if (other.PrivilegeId != 0) {
      PrivilegeId = other.PrivilegeId;
    }
    if (other.Unk3300ALOLACFGMHI != 0) {
      Unk3300ALOLACFGMHI = other.Unk3300ALOLACFGMHI;
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
          Unk3300ALOLACFGMHI = input.ReadUInt32();
          break;
        }
        case 16: {
          PrivilegeId = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300GJBEAFPMFAA = input.ReadUInt32();
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
          Unk3300ALOLACFGMHI = input.ReadUInt32();
          break;
        }
        case 16: {
          PrivilegeId = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300GJBEAFPMFAA = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
