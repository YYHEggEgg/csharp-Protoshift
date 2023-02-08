// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PBNavMeshPoly.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PBNavMeshPoly.proto</summary>
  public static partial class PBNavMeshPolyReflection {

    #region Descriptor
    /// <summary>File descriptor for PBNavMeshPoly.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PBNavMeshPolyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQQk5hdk1lc2hQb2x5LnByb3RvItoBCg1QQk5hdk1lc2hQb2x5EgwKBGFy",
            "ZWEYDiABKAUSDQoFdmVjdHMYDSADKAUSKwoKZWRnZV90eXBlcxgFIAMoDjIX",
            "LlBCTmF2TWVzaFBvbHkuRWRnZVR5cGUifwoIRWRnZVR5cGUSEwoPRURHRV9U",
            "WVBFX0lOTkVSEAASGAoURURHRV9UWVBFX1RJTEVfQk9VTkQQARIiCh5FREdF",
            "X1RZUEVfVElMRV9CT1VORF9VTkNPTk5FQ1QQAhIgChxFREdFX1RZUEVfVElM",
            "RV9CT1VORF9PVkVSSURFEANCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PBNavMeshPoly), global::NewProtos.PBNavMeshPoly.Parser, new[]{ "Area", "Vects", "EdgeTypes" }, null, new[]{ typeof(global::NewProtos.PBNavMeshPoly.Types.EdgeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PBNavMeshPoly : pb::IMessage<PBNavMeshPoly>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PBNavMeshPoly> _parser = new pb::MessageParser<PBNavMeshPoly>(() => new PBNavMeshPoly());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PBNavMeshPoly> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PBNavMeshPolyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PBNavMeshPoly() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PBNavMeshPoly(PBNavMeshPoly other) : this() {
      area_ = other.area_;
      vects_ = other.vects_.Clone();
      edgeTypes_ = other.edgeTypes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PBNavMeshPoly Clone() {
      return new PBNavMeshPoly(this);
    }

    /// <summary>Field number for the "area" field.</summary>
    public const int AreaFieldNumber = 14;
    private int area_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Area {
      get { return area_; }
      set {
        area_ = value;
      }
    }

    /// <summary>Field number for the "vects" field.</summary>
    public const int VectsFieldNumber = 13;
    private static readonly pb::FieldCodec<int> _repeated_vects_codec
        = pb::FieldCodec.ForInt32(106);
    private readonly pbc::RepeatedField<int> vects_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> Vects {
      get { return vects_; }
    }

    /// <summary>Field number for the "edge_types" field.</summary>
    public const int EdgeTypesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::NewProtos.PBNavMeshPoly.Types.EdgeType> _repeated_edgeTypes_codec
        = pb::FieldCodec.ForEnum(42, x => (int) x, x => (global::NewProtos.PBNavMeshPoly.Types.EdgeType) x);
    private readonly pbc::RepeatedField<global::NewProtos.PBNavMeshPoly.Types.EdgeType> edgeTypes_ = new pbc::RepeatedField<global::NewProtos.PBNavMeshPoly.Types.EdgeType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.PBNavMeshPoly.Types.EdgeType> EdgeTypes {
      get { return edgeTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PBNavMeshPoly);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PBNavMeshPoly other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Area != other.Area) return false;
      if(!vects_.Equals(other.vects_)) return false;
      if(!edgeTypes_.Equals(other.edgeTypes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Area != 0) hash ^= Area.GetHashCode();
      hash ^= vects_.GetHashCode();
      hash ^= edgeTypes_.GetHashCode();
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
      edgeTypes_.WriteTo(output, _repeated_edgeTypes_codec);
      vects_.WriteTo(output, _repeated_vects_codec);
      if (Area != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Area);
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
      edgeTypes_.WriteTo(ref output, _repeated_edgeTypes_codec);
      vects_.WriteTo(ref output, _repeated_vects_codec);
      if (Area != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Area);
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
      size += vects_.CalculateSize(_repeated_vects_codec);
      size += edgeTypes_.CalculateSize(_repeated_edgeTypes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PBNavMeshPoly other) {
      if (other == null) {
        return;
      }
      if (other.Area != 0) {
        Area = other.Area;
      }
      vects_.Add(other.vects_);
      edgeTypes_.Add(other.edgeTypes_);
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
          case 42:
          case 40: {
            edgeTypes_.AddEntriesFrom(input, _repeated_edgeTypes_codec);
            break;
          }
          case 106:
          case 104: {
            vects_.AddEntriesFrom(input, _repeated_vects_codec);
            break;
          }
          case 112: {
            Area = input.ReadInt32();
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
          case 42:
          case 40: {
            edgeTypes_.AddEntriesFrom(ref input, _repeated_edgeTypes_codec);
            break;
          }
          case 106:
          case 104: {
            vects_.AddEntriesFrom(ref input, _repeated_vects_codec);
            break;
          }
          case 112: {
            Area = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PBNavMeshPoly message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum EdgeType {
        [pbr::OriginalName("EDGE_TYPE_INNER")] Inner = 0,
        [pbr::OriginalName("EDGE_TYPE_TILE_BOUND")] TileBound = 1,
        [pbr::OriginalName("EDGE_TYPE_TILE_BOUND_UNCONNECT")] TileBoundUnconnect = 2,
        [pbr::OriginalName("EDGE_TYPE_TILE_BOUND_OVERIDE")] TileBoundOveride = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
