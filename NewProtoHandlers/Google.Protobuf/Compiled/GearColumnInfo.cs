// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GearColumnInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GearColumnInfo.proto</summary>
  public static partial class GearColumnInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GearColumnInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GearColumnInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRHZWFyQ29sdW1uSW5mby5wcm90byKVAQoOR2VhckNvbHVtbkluZm8SGwoT",
            "VW5rMzMwMF9HSElCUE9JQUlHRhgGIAEoDRIbChNVbmszMzAwX0tFRUdMSE1C",
            "QUtNGAggASgIEhsKE1VuazMzMDBfRURMTE1CR05ERUgYAiABKA0SDwoHZ2Vh",
            "cl9pZBgHIAEoDRIbChNVbmszMzAwX0hHSUtLRE9CQU5LGA8gASgIQgyqAglO",
            "ZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GearColumnInfo), global::NewProtos.GearColumnInfo.Parser, new[]{ "Unk3300GHIBPOIAIGF", "Unk3300KEEGLHMBAKM", "Unk3300EDLLMBGNDEH", "GearId", "Unk3300HGIKKDOBANK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GearColumnInfo : pb::IMessage<GearColumnInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GearColumnInfo> _parser = new pb::MessageParser<GearColumnInfo>(() => new GearColumnInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GearColumnInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GearColumnInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearColumnInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearColumnInfo(GearColumnInfo other) : this() {
      unk3300GHIBPOIAIGF_ = other.unk3300GHIBPOIAIGF_;
      unk3300KEEGLHMBAKM_ = other.unk3300KEEGLHMBAKM_;
      unk3300EDLLMBGNDEH_ = other.unk3300EDLLMBGNDEH_;
      gearId_ = other.gearId_;
      unk3300HGIKKDOBANK_ = other.unk3300HGIKKDOBANK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearColumnInfo Clone() {
      return new GearColumnInfo(this);
    }

    /// <summary>Field number for the "Unk3300_GHIBPOIAIGF" field.</summary>
    public const int Unk3300GHIBPOIAIGFFieldNumber = 6;
    private uint unk3300GHIBPOIAIGF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GHIBPOIAIGF {
      get { return unk3300GHIBPOIAIGF_; }
      set {
        unk3300GHIBPOIAIGF_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KEEGLHMBAKM" field.</summary>
    public const int Unk3300KEEGLHMBAKMFieldNumber = 8;
    private bool unk3300KEEGLHMBAKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300KEEGLHMBAKM {
      get { return unk3300KEEGLHMBAKM_; }
      set {
        unk3300KEEGLHMBAKM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EDLLMBGNDEH" field.</summary>
    public const int Unk3300EDLLMBGNDEHFieldNumber = 2;
    private uint unk3300EDLLMBGNDEH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EDLLMBGNDEH {
      get { return unk3300EDLLMBGNDEH_; }
      set {
        unk3300EDLLMBGNDEH_ = value;
      }
    }

    /// <summary>Field number for the "gear_id" field.</summary>
    public const int GearIdFieldNumber = 7;
    private uint gearId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GearId {
      get { return gearId_; }
      set {
        gearId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HGIKKDOBANK" field.</summary>
    public const int Unk3300HGIKKDOBANKFieldNumber = 15;
    private bool unk3300HGIKKDOBANK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300HGIKKDOBANK {
      get { return unk3300HGIKKDOBANK_; }
      set {
        unk3300HGIKKDOBANK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GearColumnInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GearColumnInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300GHIBPOIAIGF != other.Unk3300GHIBPOIAIGF) return false;
      if (Unk3300KEEGLHMBAKM != other.Unk3300KEEGLHMBAKM) return false;
      if (Unk3300EDLLMBGNDEH != other.Unk3300EDLLMBGNDEH) return false;
      if (GearId != other.GearId) return false;
      if (Unk3300HGIKKDOBANK != other.Unk3300HGIKKDOBANK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300GHIBPOIAIGF != 0) hash ^= Unk3300GHIBPOIAIGF.GetHashCode();
      if (Unk3300KEEGLHMBAKM != false) hash ^= Unk3300KEEGLHMBAKM.GetHashCode();
      if (Unk3300EDLLMBGNDEH != 0) hash ^= Unk3300EDLLMBGNDEH.GetHashCode();
      if (GearId != 0) hash ^= GearId.GetHashCode();
      if (Unk3300HGIKKDOBANK != false) hash ^= Unk3300HGIKKDOBANK.GetHashCode();
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
      if (Unk3300EDLLMBGNDEH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300EDLLMBGNDEH);
      }
      if (Unk3300GHIBPOIAIGF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300GHIBPOIAIGF);
      }
      if (GearId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GearId);
      }
      if (Unk3300KEEGLHMBAKM != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300KEEGLHMBAKM);
      }
      if (Unk3300HGIKKDOBANK != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300HGIKKDOBANK);
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
      if (Unk3300EDLLMBGNDEH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300EDLLMBGNDEH);
      }
      if (Unk3300GHIBPOIAIGF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300GHIBPOIAIGF);
      }
      if (GearId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GearId);
      }
      if (Unk3300KEEGLHMBAKM != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300KEEGLHMBAKM);
      }
      if (Unk3300HGIKKDOBANK != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300HGIKKDOBANK);
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
      if (Unk3300GHIBPOIAIGF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GHIBPOIAIGF);
      }
      if (Unk3300KEEGLHMBAKM != false) {
        size += 1 + 1;
      }
      if (Unk3300EDLLMBGNDEH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EDLLMBGNDEH);
      }
      if (GearId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GearId);
      }
      if (Unk3300HGIKKDOBANK != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GearColumnInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300GHIBPOIAIGF != 0) {
        Unk3300GHIBPOIAIGF = other.Unk3300GHIBPOIAIGF;
      }
      if (other.Unk3300KEEGLHMBAKM != false) {
        Unk3300KEEGLHMBAKM = other.Unk3300KEEGLHMBAKM;
      }
      if (other.Unk3300EDLLMBGNDEH != 0) {
        Unk3300EDLLMBGNDEH = other.Unk3300EDLLMBGNDEH;
      }
      if (other.GearId != 0) {
        GearId = other.GearId;
      }
      if (other.Unk3300HGIKKDOBANK != false) {
        Unk3300HGIKKDOBANK = other.Unk3300HGIKKDOBANK;
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
            Unk3300EDLLMBGNDEH = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300GHIBPOIAIGF = input.ReadUInt32();
            break;
          }
          case 56: {
            GearId = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300KEEGLHMBAKM = input.ReadBool();
            break;
          }
          case 120: {
            Unk3300HGIKKDOBANK = input.ReadBool();
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
            Unk3300EDLLMBGNDEH = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300GHIBPOIAIGF = input.ReadUInt32();
            break;
          }
          case 56: {
            GearId = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300KEEGLHMBAKM = input.ReadBool();
            break;
          }
          case 120: {
            Unk3300HGIKKDOBANK = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
