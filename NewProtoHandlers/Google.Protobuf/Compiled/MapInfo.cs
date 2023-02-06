// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MapInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MapInfo.proto</summary>
public static partial class MapInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for MapInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MapInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1NYXBJbmZvLnByb3RvGg5DZWxsSW5mby5wcm90byJbCgdNYXBJbmZvEgwK",
          "BG1pbngYASABKAUSDAoEbWF4eBgCIAEoBRIMCgRtaW56GAMgASgFEgwKBG1h",
          "eHoYBCABKAUSGAoFY2VsbHMYBSADKAsyCS5DZWxsSW5mb0IWChRvcmcuc29y",
          "YXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CellInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MapInfo), global::MapInfo.Parser, new[]{ "Minx", "Maxx", "Minz", "Maxz", "Cells" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class MapInfo : pb::IMessage<MapInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MapInfo> _parser = new pb::MessageParser<MapInfo>(() => new MapInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MapInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MapInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MapInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MapInfo(MapInfo other) : this() {
    minx_ = other.minx_;
    maxx_ = other.maxx_;
    minz_ = other.minz_;
    maxz_ = other.maxz_;
    cells_ = other.cells_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MapInfo Clone() {
    return new MapInfo(this);
  }

  /// <summary>Field number for the "minx" field.</summary>
  public const int MinxFieldNumber = 1;
  private int minx_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Minx {
    get { return minx_; }
    set {
      minx_ = value;
    }
  }

  /// <summary>Field number for the "maxx" field.</summary>
  public const int MaxxFieldNumber = 2;
  private int maxx_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Maxx {
    get { return maxx_; }
    set {
      maxx_ = value;
    }
  }

  /// <summary>Field number for the "minz" field.</summary>
  public const int MinzFieldNumber = 3;
  private int minz_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Minz {
    get { return minz_; }
    set {
      minz_ = value;
    }
  }

  /// <summary>Field number for the "maxz" field.</summary>
  public const int MaxzFieldNumber = 4;
  private int maxz_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Maxz {
    get { return maxz_; }
    set {
      maxz_ = value;
    }
  }

  /// <summary>Field number for the "cells" field.</summary>
  public const int CellsFieldNumber = 5;
  private static readonly pb::FieldCodec<global::CellInfo> _repeated_cells_codec
      = pb::FieldCodec.ForMessage(42, global::CellInfo.Parser);
  private readonly pbc::RepeatedField<global::CellInfo> cells_ = new pbc::RepeatedField<global::CellInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::CellInfo> Cells {
    get { return cells_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MapInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MapInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Minx != other.Minx) return false;
    if (Maxx != other.Maxx) return false;
    if (Minz != other.Minz) return false;
    if (Maxz != other.Maxz) return false;
    if(!cells_.Equals(other.cells_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Minx != 0) hash ^= Minx.GetHashCode();
    if (Maxx != 0) hash ^= Maxx.GetHashCode();
    if (Minz != 0) hash ^= Minz.GetHashCode();
    if (Maxz != 0) hash ^= Maxz.GetHashCode();
    hash ^= cells_.GetHashCode();
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
    if (Minx != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Minx);
    }
    if (Maxx != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Maxx);
    }
    if (Minz != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Minz);
    }
    if (Maxz != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(Maxz);
    }
    cells_.WriteTo(output, _repeated_cells_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Minx != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Minx);
    }
    if (Maxx != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Maxx);
    }
    if (Minz != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Minz);
    }
    if (Maxz != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(Maxz);
    }
    cells_.WriteTo(ref output, _repeated_cells_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Minx != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Minx);
    }
    if (Maxx != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Maxx);
    }
    if (Minz != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Minz);
    }
    if (Maxz != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Maxz);
    }
    size += cells_.CalculateSize(_repeated_cells_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MapInfo other) {
    if (other == null) {
      return;
    }
    if (other.Minx != 0) {
      Minx = other.Minx;
    }
    if (other.Maxx != 0) {
      Maxx = other.Maxx;
    }
    if (other.Minz != 0) {
      Minz = other.Minz;
    }
    if (other.Maxz != 0) {
      Maxz = other.Maxz;
    }
    cells_.Add(other.cells_);
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
          Minx = input.ReadInt32();
          break;
        }
        case 16: {
          Maxx = input.ReadInt32();
          break;
        }
        case 24: {
          Minz = input.ReadInt32();
          break;
        }
        case 32: {
          Maxz = input.ReadInt32();
          break;
        }
        case 42: {
          cells_.AddEntriesFrom(input, _repeated_cells_codec);
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
          Minx = input.ReadInt32();
          break;
        }
        case 16: {
          Maxx = input.ReadInt32();
          break;
        }
        case 24: {
          Minz = input.ReadInt32();
          break;
        }
        case 32: {
          Maxz = input.ReadInt32();
          break;
        }
        case 42: {
          cells_.AddEntriesFrom(ref input, _repeated_cells_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
