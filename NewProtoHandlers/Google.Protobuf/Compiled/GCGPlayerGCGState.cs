// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGPlayerGCGState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GCGPlayerGCGState.proto</summary>
  public static partial class GCGPlayerGCGStateReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGPlayerGCGState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGPlayerGCGStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHQ0dQbGF5ZXJHQ0dTdGF0ZS5wcm90byJaChFHQ0dQbGF5ZXJHQ0dTdGF0",
            "ZRILCgN1aWQYDiABKA0SGwoTVW5rMzMwMF9HSUtPTUZOTkFBQRgLIAEoCBIb",
            "ChNVbmszMzAwX0RFS0dNS0NDR0VHGAQgASgIQgyqAglOZXdQcm90b3NiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GCGPlayerGCGState), global::NewProtos.GCGPlayerGCGState.Parser, new[]{ "Uid", "Unk3300GIKOMFNNAAA", "Unk3300DEKGMKCCGEG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGPlayerGCGState : pb::IMessage<GCGPlayerGCGState>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGPlayerGCGState> _parser = new pb::MessageParser<GCGPlayerGCGState>(() => new GCGPlayerGCGState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGPlayerGCGState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GCGPlayerGCGStateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGPlayerGCGState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGPlayerGCGState(GCGPlayerGCGState other) : this() {
      uid_ = other.uid_;
      unk3300GIKOMFNNAAA_ = other.unk3300GIKOMFNNAAA_;
      unk3300DEKGMKCCGEG_ = other.unk3300DEKGMKCCGEG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGPlayerGCGState Clone() {
      return new GCGPlayerGCGState(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 14;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GIKOMFNNAAA" field.</summary>
    public const int Unk3300GIKOMFNNAAAFieldNumber = 11;
    private bool unk3300GIKOMFNNAAA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300GIKOMFNNAAA {
      get { return unk3300GIKOMFNNAAA_; }
      set {
        unk3300GIKOMFNNAAA_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DEKGMKCCGEG" field.</summary>
    public const int Unk3300DEKGMKCCGEGFieldNumber = 4;
    private bool unk3300DEKGMKCCGEG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300DEKGMKCCGEG {
      get { return unk3300DEKGMKCCGEG_; }
      set {
        unk3300DEKGMKCCGEG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGPlayerGCGState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGPlayerGCGState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Unk3300GIKOMFNNAAA != other.Unk3300GIKOMFNNAAA) return false;
      if (Unk3300DEKGMKCCGEG != other.Unk3300DEKGMKCCGEG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Unk3300GIKOMFNNAAA != false) hash ^= Unk3300GIKOMFNNAAA.GetHashCode();
      if (Unk3300DEKGMKCCGEG != false) hash ^= Unk3300DEKGMKCCGEG.GetHashCode();
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
      if (Unk3300DEKGMKCCGEG != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300DEKGMKCCGEG);
      }
      if (Unk3300GIKOMFNNAAA != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk3300GIKOMFNNAAA);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
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
      if (Unk3300DEKGMKCCGEG != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300DEKGMKCCGEG);
      }
      if (Unk3300GIKOMFNNAAA != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk3300GIKOMFNNAAA);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Unk3300GIKOMFNNAAA != false) {
        size += 1 + 1;
      }
      if (Unk3300DEKGMKCCGEG != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGPlayerGCGState other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Unk3300GIKOMFNNAAA != false) {
        Unk3300GIKOMFNNAAA = other.Unk3300GIKOMFNNAAA;
      }
      if (other.Unk3300DEKGMKCCGEG != false) {
        Unk3300DEKGMKCCGEG = other.Unk3300DEKGMKCCGEG;
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
          case 32: {
            Unk3300DEKGMKCCGEG = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300GIKOMFNNAAA = input.ReadBool();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
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
          case 32: {
            Unk3300DEKGMKCCGEG = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300GIKOMFNNAAA = input.ReadBool();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
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
