// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryInstableSprayBuffInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SceneGalleryInstableSprayBuffInfo.proto</summary>
  public static partial class SceneGalleryInstableSprayBuffInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryInstableSprayBuffInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryInstableSprayBuffInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTY2VuZUdhbGxlcnlJbnN0YWJsZVNwcmF5QnVmZkluZm8ucHJvdG8ibgoh",
            "U2NlbmVHYWxsZXJ5SW5zdGFibGVTcHJheUJ1ZmZJbmZvEhsKE1VuazMzMDBf",
            "S0tERkxCTUtHRUYYAyABKAQSDwoHYnVmZl9pZBgGIAEoDRIbChNVbmszMzAw",
            "X0VQSEFBQktOTEhDGAIgASgEQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SceneGalleryInstableSprayBuffInfo), global::NewProtos.SceneGalleryInstableSprayBuffInfo.Parser, new[]{ "Unk3300KKDFLBMKGEF", "BuffId", "Unk3300EPHAABKNLHC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryInstableSprayBuffInfo : pb::IMessage<SceneGalleryInstableSprayBuffInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryInstableSprayBuffInfo> _parser = new pb::MessageParser<SceneGalleryInstableSprayBuffInfo>(() => new SceneGalleryInstableSprayBuffInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryInstableSprayBuffInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SceneGalleryInstableSprayBuffInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryInstableSprayBuffInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryInstableSprayBuffInfo(SceneGalleryInstableSprayBuffInfo other) : this() {
      unk3300KKDFLBMKGEF_ = other.unk3300KKDFLBMKGEF_;
      buffId_ = other.buffId_;
      unk3300EPHAABKNLHC_ = other.unk3300EPHAABKNLHC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryInstableSprayBuffInfo Clone() {
      return new SceneGalleryInstableSprayBuffInfo(this);
    }

    /// <summary>Field number for the "Unk3300_KKDFLBMKGEF" field.</summary>
    public const int Unk3300KKDFLBMKGEFFieldNumber = 3;
    private ulong unk3300KKDFLBMKGEF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk3300KKDFLBMKGEF {
      get { return unk3300KKDFLBMKGEF_; }
      set {
        unk3300KKDFLBMKGEF_ = value;
      }
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 6;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EPHAABKNLHC" field.</summary>
    public const int Unk3300EPHAABKNLHCFieldNumber = 2;
    private ulong unk3300EPHAABKNLHC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk3300EPHAABKNLHC {
      get { return unk3300EPHAABKNLHC_; }
      set {
        unk3300EPHAABKNLHC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryInstableSprayBuffInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryInstableSprayBuffInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300KKDFLBMKGEF != other.Unk3300KKDFLBMKGEF) return false;
      if (BuffId != other.BuffId) return false;
      if (Unk3300EPHAABKNLHC != other.Unk3300EPHAABKNLHC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300KKDFLBMKGEF != 0UL) hash ^= Unk3300KKDFLBMKGEF.GetHashCode();
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (Unk3300EPHAABKNLHC != 0UL) hash ^= Unk3300EPHAABKNLHC.GetHashCode();
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
      if (Unk3300EPHAABKNLHC != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Unk3300EPHAABKNLHC);
      }
      if (Unk3300KKDFLBMKGEF != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk3300KKDFLBMKGEF);
      }
      if (BuffId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BuffId);
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
      if (Unk3300EPHAABKNLHC != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Unk3300EPHAABKNLHC);
      }
      if (Unk3300KKDFLBMKGEF != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk3300KKDFLBMKGEF);
      }
      if (BuffId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BuffId);
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
      if (Unk3300KKDFLBMKGEF != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk3300KKDFLBMKGEF);
      }
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (Unk3300EPHAABKNLHC != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk3300EPHAABKNLHC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryInstableSprayBuffInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300KKDFLBMKGEF != 0UL) {
        Unk3300KKDFLBMKGEF = other.Unk3300KKDFLBMKGEF;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.Unk3300EPHAABKNLHC != 0UL) {
        Unk3300EPHAABKNLHC = other.Unk3300EPHAABKNLHC;
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
            Unk3300EPHAABKNLHC = input.ReadUInt64();
            break;
          }
          case 24: {
            Unk3300KKDFLBMKGEF = input.ReadUInt64();
            break;
          }
          case 48: {
            BuffId = input.ReadUInt32();
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
            Unk3300EPHAABKNLHC = input.ReadUInt64();
            break;
          }
          case 24: {
            Unk3300KKDFLBMKGEF = input.ReadUInt64();
            break;
          }
          case 48: {
            BuffId = input.ReadUInt32();
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
