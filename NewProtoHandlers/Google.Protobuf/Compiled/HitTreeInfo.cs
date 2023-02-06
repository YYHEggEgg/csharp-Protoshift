// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HitTreeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HitTreeInfo.proto</summary>
public static partial class HitTreeInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for HitTreeInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HitTreeInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFIaXRUcmVlSW5mby5wcm90bxoMVmVjdG9yLnByb3RvIjsKC0hpdFRyZWVJ",
          "bmZvEhkKCHRyZWVfcG9zGAogASgLMgcuVmVjdG9yEhEKCXRyZWVfdHlwZRgH",
          "IAEoDUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HitTreeInfo), global::HitTreeInfo.Parser, new[]{ "TreePos", "TreeType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class HitTreeInfo : pb::IMessage<HitTreeInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HitTreeInfo> _parser = new pb::MessageParser<HitTreeInfo>(() => new HitTreeInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HitTreeInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HitTreeInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HitTreeInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HitTreeInfo(HitTreeInfo other) : this() {
    treePos_ = other.treePos_ != null ? other.treePos_.Clone() : null;
    treeType_ = other.treeType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HitTreeInfo Clone() {
    return new HitTreeInfo(this);
  }

  /// <summary>Field number for the "tree_pos" field.</summary>
  public const int TreePosFieldNumber = 10;
  private global::Vector treePos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector TreePos {
    get { return treePos_; }
    set {
      treePos_ = value;
    }
  }

  /// <summary>Field number for the "tree_type" field.</summary>
  public const int TreeTypeFieldNumber = 7;
  private uint treeType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TreeType {
    get { return treeType_; }
    set {
      treeType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HitTreeInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HitTreeInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(TreePos, other.TreePos)) return false;
    if (TreeType != other.TreeType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (treePos_ != null) hash ^= TreePos.GetHashCode();
    if (TreeType != 0) hash ^= TreeType.GetHashCode();
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
    if (TreeType != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(TreeType);
    }
    if (treePos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(TreePos);
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
    if (TreeType != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(TreeType);
    }
    if (treePos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(TreePos);
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
    if (treePos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(TreePos);
    }
    if (TreeType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TreeType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HitTreeInfo other) {
    if (other == null) {
      return;
    }
    if (other.treePos_ != null) {
      if (treePos_ == null) {
        TreePos = new global::Vector();
      }
      TreePos.MergeFrom(other.TreePos);
    }
    if (other.TreeType != 0) {
      TreeType = other.TreeType;
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
        case 56: {
          TreeType = input.ReadUInt32();
          break;
        }
        case 82: {
          if (treePos_ == null) {
            TreePos = new global::Vector();
          }
          input.ReadMessage(TreePos);
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
        case 56: {
          TreeType = input.ReadUInt32();
          break;
        }
        case 82: {
          if (treePos_ == null) {
            TreePos = new global::Vector();
          }
          input.ReadMessage(TreePos);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
