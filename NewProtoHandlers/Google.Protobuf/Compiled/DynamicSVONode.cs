// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DynamicSVONode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from DynamicSVONode.proto</summary>
public static partial class DynamicSVONodeReflection {

  #region Descriptor
  /// <summary>File descriptor for DynamicSVONode.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DynamicSVONodeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChREeW5hbWljU1ZPTm9kZS5wcm90bxoMVmVjdG9yLnByb3RvIkkKDkR5bmFt",
          "aWNTVk9Ob2RlEgwKBGFyZWEYAyABKAUSGgoJcmVmZXJfcG9zGA8gASgLMgcu",
          "VmVjdG9yEg0KBWluZGV4GAIgASgDQhYKFG9yZy5zb3JhcG9pbnRhLnByb3Rv",
          "YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DynamicSVONode), global::DynamicSVONode.Parser, new[]{ "Area", "ReferPos", "Index" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class DynamicSVONode : pb::IMessage<DynamicSVONode>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<DynamicSVONode> _parser = new pb::MessageParser<DynamicSVONode>(() => new DynamicSVONode());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<DynamicSVONode> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DynamicSVONodeReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DynamicSVONode() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DynamicSVONode(DynamicSVONode other) : this() {
    area_ = other.area_;
    referPos_ = other.referPos_ != null ? other.referPos_.Clone() : null;
    index_ = other.index_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DynamicSVONode Clone() {
    return new DynamicSVONode(this);
  }

  /// <summary>Field number for the "area" field.</summary>
  public const int AreaFieldNumber = 3;
  private int area_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Area {
    get { return area_; }
    set {
      area_ = value;
    }
  }

  /// <summary>Field number for the "refer_pos" field.</summary>
  public const int ReferPosFieldNumber = 15;
  private global::Vector referPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector ReferPos {
    get { return referPos_; }
    set {
      referPos_ = value;
    }
  }

  /// <summary>Field number for the "index" field.</summary>
  public const int IndexFieldNumber = 2;
  private long index_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public long Index {
    get { return index_; }
    set {
      index_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as DynamicSVONode);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(DynamicSVONode other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Area != other.Area) return false;
    if (!object.Equals(ReferPos, other.ReferPos)) return false;
    if (Index != other.Index) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Area != 0) hash ^= Area.GetHashCode();
    if (referPos_ != null) hash ^= ReferPos.GetHashCode();
    if (Index != 0L) hash ^= Index.GetHashCode();
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
    if (Index != 0L) {
      output.WriteRawTag(16);
      output.WriteInt64(Index);
    }
    if (Area != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Area);
    }
    if (referPos_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(ReferPos);
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
    if (Index != 0L) {
      output.WriteRawTag(16);
      output.WriteInt64(Index);
    }
    if (Area != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Area);
    }
    if (referPos_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(ReferPos);
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
    if (Area != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Area);
    }
    if (referPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReferPos);
    }
    if (Index != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Index);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(DynamicSVONode other) {
    if (other == null) {
      return;
    }
    if (other.Area != 0) {
      Area = other.Area;
    }
    if (other.referPos_ != null) {
      if (referPos_ == null) {
        ReferPos = new global::Vector();
      }
      ReferPos.MergeFrom(other.ReferPos);
    }
    if (other.Index != 0L) {
      Index = other.Index;
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
          Index = input.ReadInt64();
          break;
        }
        case 24: {
          Area = input.ReadInt32();
          break;
        }
        case 122: {
          if (referPos_ == null) {
            ReferPos = new global::Vector();
          }
          input.ReadMessage(ReferPos);
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
          Index = input.ReadInt64();
          break;
        }
        case 24: {
          Area = input.ReadInt32();
          break;
        }
        case 122: {
          if (referPos_ == null) {
            ReferPos = new global::Vector();
          }
          input.ReadMessage(ReferPos);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
