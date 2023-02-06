// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Material.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Material.proto</summary>
public static partial class MaterialReflection {

  #region Descriptor
  /// <summary>File descriptor for Material.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MaterialReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg5NYXRlcmlhbC5wcm90bxoYTWF0ZXJpYWxEZWxldGVJbmZvLnByb3RvIkMK",
          "CE1hdGVyaWFsEg0KBWNvdW50GAEgASgNEigKC2RlbGV0ZV9pbmZvGAIgASgL",
          "MhMuTWF0ZXJpYWxEZWxldGVJbmZvQhYKFG9yZy5zb3JhcG9pbnRhLnByb3Rv",
          "YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MaterialDeleteInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Material), global::Material.Parser, new[]{ "Count", "DeleteInfo" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Material : pb::IMessage<Material>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Material> _parser = new pb::MessageParser<Material>(() => new Material());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Material> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MaterialReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Material() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Material(Material other) : this() {
    count_ = other.count_;
    deleteInfo_ = other.deleteInfo_ != null ? other.deleteInfo_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Material Clone() {
    return new Material(this);
  }

  /// <summary>Field number for the "count" field.</summary>
  public const int CountFieldNumber = 1;
  private uint count_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Count {
    get { return count_; }
    set {
      count_ = value;
    }
  }

  /// <summary>Field number for the "delete_info" field.</summary>
  public const int DeleteInfoFieldNumber = 2;
  private global::MaterialDeleteInfo deleteInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::MaterialDeleteInfo DeleteInfo {
    get { return deleteInfo_; }
    set {
      deleteInfo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Material);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Material other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Count != other.Count) return false;
    if (!object.Equals(DeleteInfo, other.DeleteInfo)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Count != 0) hash ^= Count.GetHashCode();
    if (deleteInfo_ != null) hash ^= DeleteInfo.GetHashCode();
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
    if (Count != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Count);
    }
    if (deleteInfo_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(DeleteInfo);
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
    if (Count != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Count);
    }
    if (deleteInfo_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(DeleteInfo);
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
    if (Count != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
    }
    if (deleteInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeleteInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Material other) {
    if (other == null) {
      return;
    }
    if (other.Count != 0) {
      Count = other.Count;
    }
    if (other.deleteInfo_ != null) {
      if (deleteInfo_ == null) {
        DeleteInfo = new global::MaterialDeleteInfo();
      }
      DeleteInfo.MergeFrom(other.DeleteInfo);
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
          Count = input.ReadUInt32();
          break;
        }
        case 18: {
          if (deleteInfo_ == null) {
            DeleteInfo = new global::MaterialDeleteInfo();
          }
          input.ReadMessage(DeleteInfo);
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
          Count = input.ReadUInt32();
          break;
        }
        case 18: {
          if (deleteInfo_ == null) {
            DeleteInfo = new global::MaterialDeleteInfo();
          }
          input.ReadMessage(DeleteInfo);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
