// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PBNavMeshTile.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PBNavMeshTile.proto</summary>
public static partial class PBNavMeshTileReflection {

  #region Descriptor
  /// <summary>File descriptor for PBNavMeshTile.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PBNavMeshTileReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNQQk5hdk1lc2hUaWxlLnByb3RvGhNQQk5hdk1lc2hQb2x5LnByb3RvGgxW",
          "ZWN0b3IucHJvdG8iRQoNUEJOYXZNZXNoVGlsZRIVCgR2ZWNzGAwgAygLMgcu",
          "VmVjdG9yEh0KBXBvbHlzGA0gAygLMg4uUEJOYXZNZXNoUG9seUIWChRvcmcu",
          "c29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::PBNavMeshPolyReflection.Descriptor, global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PBNavMeshTile), global::PBNavMeshTile.Parser, new[]{ "Vecs", "Polys" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class PBNavMeshTile : pb::IMessage<PBNavMeshTile>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PBNavMeshTile> _parser = new pb::MessageParser<PBNavMeshTile>(() => new PBNavMeshTile());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PBNavMeshTile> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PBNavMeshTileReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PBNavMeshTile() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PBNavMeshTile(PBNavMeshTile other) : this() {
    vecs_ = other.vecs_.Clone();
    polys_ = other.polys_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PBNavMeshTile Clone() {
    return new PBNavMeshTile(this);
  }

  /// <summary>Field number for the "vecs" field.</summary>
  public const int VecsFieldNumber = 12;
  private static readonly pb::FieldCodec<global::Vector> _repeated_vecs_codec
      = pb::FieldCodec.ForMessage(98, global::Vector.Parser);
  private readonly pbc::RepeatedField<global::Vector> vecs_ = new pbc::RepeatedField<global::Vector>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::Vector> Vecs {
    get { return vecs_; }
  }

  /// <summary>Field number for the "polys" field.</summary>
  public const int PolysFieldNumber = 13;
  private static readonly pb::FieldCodec<global::PBNavMeshPoly> _repeated_polys_codec
      = pb::FieldCodec.ForMessage(106, global::PBNavMeshPoly.Parser);
  private readonly pbc::RepeatedField<global::PBNavMeshPoly> polys_ = new pbc::RepeatedField<global::PBNavMeshPoly>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::PBNavMeshPoly> Polys {
    get { return polys_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PBNavMeshTile);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PBNavMeshTile other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!vecs_.Equals(other.vecs_)) return false;
    if(!polys_.Equals(other.polys_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= vecs_.GetHashCode();
    hash ^= polys_.GetHashCode();
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
    vecs_.WriteTo(output, _repeated_vecs_codec);
    polys_.WriteTo(output, _repeated_polys_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    vecs_.WriteTo(ref output, _repeated_vecs_codec);
    polys_.WriteTo(ref output, _repeated_polys_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += vecs_.CalculateSize(_repeated_vecs_codec);
    size += polys_.CalculateSize(_repeated_polys_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PBNavMeshTile other) {
    if (other == null) {
      return;
    }
    vecs_.Add(other.vecs_);
    polys_.Add(other.polys_);
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
        case 98: {
          vecs_.AddEntriesFrom(input, _repeated_vecs_codec);
          break;
        }
        case 106: {
          polys_.AddEntriesFrom(input, _repeated_polys_codec);
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
        case 98: {
          vecs_.AddEntriesFrom(ref input, _repeated_vecs_codec);
          break;
        }
        case 106: {
          polys_.AddEntriesFrom(ref input, _repeated_polys_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
