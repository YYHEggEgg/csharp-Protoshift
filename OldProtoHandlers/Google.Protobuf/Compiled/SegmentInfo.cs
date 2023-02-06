// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SegmentInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SegmentInfo.proto</summary>
public static partial class SegmentInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SegmentInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SegmentInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFTZWdtZW50SW5mby5wcm90byI7CgtTZWdtZW50SW5mbxIOCgZvZmZzZXQY",
          "AyABKA0SDgoGbW9kdWxlGAcgASgNEgwKBHNpemUYCCABKA1CHgocZW11Lmdy",
          "YXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SegmentInfo), global::SegmentInfo.Parser, new[]{ "Offset", "Module", "Size" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SegmentInfo : pb::IMessage<SegmentInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SegmentInfo> _parser = new pb::MessageParser<SegmentInfo>(() => new SegmentInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SegmentInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SegmentInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SegmentInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SegmentInfo(SegmentInfo other) : this() {
    offset_ = other.offset_;
    module_ = other.module_;
    size_ = other.size_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SegmentInfo Clone() {
    return new SegmentInfo(this);
  }

  /// <summary>Field number for the "offset" field.</summary>
  public const int OffsetFieldNumber = 3;
  private uint offset_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Offset {
    get { return offset_; }
    set {
      offset_ = value;
    }
  }

  /// <summary>Field number for the "module" field.</summary>
  public const int ModuleFieldNumber = 7;
  private uint module_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Module {
    get { return module_; }
    set {
      module_ = value;
    }
  }

  /// <summary>Field number for the "size" field.</summary>
  public const int SizeFieldNumber = 8;
  private uint size_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Size {
    get { return size_; }
    set {
      size_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SegmentInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SegmentInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Offset != other.Offset) return false;
    if (Module != other.Module) return false;
    if (Size != other.Size) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Offset != 0) hash ^= Offset.GetHashCode();
    if (Module != 0) hash ^= Module.GetHashCode();
    if (Size != 0) hash ^= Size.GetHashCode();
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
    if (Offset != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Offset);
    }
    if (Module != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Module);
    }
    if (Size != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Size);
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
    if (Offset != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Offset);
    }
    if (Module != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Module);
    }
    if (Size != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Size);
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
    if (Offset != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Offset);
    }
    if (Module != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Module);
    }
    if (Size != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Size);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SegmentInfo other) {
    if (other == null) {
      return;
    }
    if (other.Offset != 0) {
      Offset = other.Offset;
    }
    if (other.Module != 0) {
      Module = other.Module;
    }
    if (other.Size != 0) {
      Size = other.Size;
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
          Offset = input.ReadUInt32();
          break;
        }
        case 56: {
          Module = input.ReadUInt32();
          break;
        }
        case 64: {
          Size = input.ReadUInt32();
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
          Offset = input.ReadUInt32();
          break;
        }
        case 56: {
          Module = input.ReadUInt32();
          break;
        }
        case 64: {
          Size = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
