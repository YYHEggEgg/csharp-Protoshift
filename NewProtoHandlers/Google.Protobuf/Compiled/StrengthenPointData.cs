// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StrengthenPointData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from StrengthenPointData.proto</summary>
  public static partial class StrengthenPointDataReflection {

    #region Descriptor
    /// <summary>File descriptor for StrengthenPointData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StrengthenPointDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTdHJlbmd0aGVuUG9pbnREYXRhLnByb3RvIk8KE1N0cmVuZ3RoZW5Qb2lu",
            "dERhdGESGwoTVW5rMzMwMF9ISUtERUtJUENQQhgBIAEoDRIbChNVbmszMzAw",
            "X05OS1BPTExCTERPGAogASgNQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.StrengthenPointData), global::NewProtos.StrengthenPointData.Parser, new[]{ "Unk3300HIKDEKIPCPB", "Unk3300NNKPOLLBLDO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StrengthenPointData : pb::IMessage<StrengthenPointData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StrengthenPointData> _parser = new pb::MessageParser<StrengthenPointData>(() => new StrengthenPointData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StrengthenPointData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.StrengthenPointDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrengthenPointData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrengthenPointData(StrengthenPointData other) : this() {
      unk3300HIKDEKIPCPB_ = other.unk3300HIKDEKIPCPB_;
      unk3300NNKPOLLBLDO_ = other.unk3300NNKPOLLBLDO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StrengthenPointData Clone() {
      return new StrengthenPointData(this);
    }

    /// <summary>Field number for the "Unk3300_HIKDEKIPCPB" field.</summary>
    public const int Unk3300HIKDEKIPCPBFieldNumber = 1;
    private uint unk3300HIKDEKIPCPB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300HIKDEKIPCPB {
      get { return unk3300HIKDEKIPCPB_; }
      set {
        unk3300HIKDEKIPCPB_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NNKPOLLBLDO" field.</summary>
    public const int Unk3300NNKPOLLBLDOFieldNumber = 10;
    private uint unk3300NNKPOLLBLDO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NNKPOLLBLDO {
      get { return unk3300NNKPOLLBLDO_; }
      set {
        unk3300NNKPOLLBLDO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StrengthenPointData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StrengthenPointData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300HIKDEKIPCPB != other.Unk3300HIKDEKIPCPB) return false;
      if (Unk3300NNKPOLLBLDO != other.Unk3300NNKPOLLBLDO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300HIKDEKIPCPB != 0) hash ^= Unk3300HIKDEKIPCPB.GetHashCode();
      if (Unk3300NNKPOLLBLDO != 0) hash ^= Unk3300NNKPOLLBLDO.GetHashCode();
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
      if (Unk3300HIKDEKIPCPB != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300HIKDEKIPCPB);
      }
      if (Unk3300NNKPOLLBLDO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300NNKPOLLBLDO);
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
      if (Unk3300HIKDEKIPCPB != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300HIKDEKIPCPB);
      }
      if (Unk3300NNKPOLLBLDO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300NNKPOLLBLDO);
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
      if (Unk3300HIKDEKIPCPB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HIKDEKIPCPB);
      }
      if (Unk3300NNKPOLLBLDO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NNKPOLLBLDO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StrengthenPointData other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300HIKDEKIPCPB != 0) {
        Unk3300HIKDEKIPCPB = other.Unk3300HIKDEKIPCPB;
      }
      if (other.Unk3300NNKPOLLBLDO != 0) {
        Unk3300NNKPOLLBLDO = other.Unk3300NNKPOLLBLDO;
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
            Unk3300HIKDEKIPCPB = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300NNKPOLLBLDO = input.ReadUInt32();
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
            Unk3300HIKDEKIPCPB = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300NNKPOLLBLDO = input.ReadUInt32();
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
