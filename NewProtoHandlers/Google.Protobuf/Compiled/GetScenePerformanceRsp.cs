// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetScenePerformanceRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GetScenePerformanceRsp.proto</summary>
  public static partial class GetScenePerformanceRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetScenePerformanceRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetScenePerformanceRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRTY2VuZVBlcmZvcm1hbmNlUnNwLnByb3RvGgxWZWN0b3IucHJvdG8i",
            "igIKFkdldFNjZW5lUGVyZm9ybWFuY2VSc3ASDwoHcmV0Y29kZRgBIAEoBRIb",
            "ChNVbmszMzAwX0dMTkZJRlBOSklFGAQgASgNEhsKE1VuazMzMDBfSUhCUENQ",
            "Q0pJQkMYAiABKA0SGwoTVW5rMzMwMF9NTUFMSklGREtKSxgNIAEoDRIbChNV",
            "bmszMzAwX1BEUEpFTUVLSEtEGAogASgNEhsKE1VuazMzMDBfTElPRkdBSEtO",
            "SUEYDiABKA0SGwoTVW5rMzMwMF9NSUpNS0xCR0tNTBgLIAEoDRIbChNVbmsz",
            "MzAwX0pNTEpMTktMSk5QGA8gASgNEhQKA3BvcxgJIAEoCzIHLlZlY3RvckIM",
            "qgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GetScenePerformanceRsp), global::NewProtos.GetScenePerformanceRsp.Parser, new[]{ "Retcode", "Unk3300GLNFIFPNJIE", "Unk3300IHBPCPCJIBC", "Unk3300MMALJIFDKJK", "Unk3300PDPJEMEKHKD", "Unk3300LIOFGAHKNIA", "Unk3300MIJMKLBGKML", "Unk3300JMLJLNKLJNP", "Pos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3010;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetScenePerformanceRsp : pb::IMessage<GetScenePerformanceRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetScenePerformanceRsp> _parser = new pb::MessageParser<GetScenePerformanceRsp>(() => new GetScenePerformanceRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetScenePerformanceRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GetScenePerformanceRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePerformanceRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePerformanceRsp(GetScenePerformanceRsp other) : this() {
      retcode_ = other.retcode_;
      unk3300GLNFIFPNJIE_ = other.unk3300GLNFIFPNJIE_;
      unk3300IHBPCPCJIBC_ = other.unk3300IHBPCPCJIBC_;
      unk3300MMALJIFDKJK_ = other.unk3300MMALJIFDKJK_;
      unk3300PDPJEMEKHKD_ = other.unk3300PDPJEMEKHKD_;
      unk3300LIOFGAHKNIA_ = other.unk3300LIOFGAHKNIA_;
      unk3300MIJMKLBGKML_ = other.unk3300MIJMKLBGKML_;
      unk3300JMLJLNKLJNP_ = other.unk3300JMLJLNKLJNP_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePerformanceRsp Clone() {
      return new GetScenePerformanceRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GLNFIFPNJIE" field.</summary>
    public const int Unk3300GLNFIFPNJIEFieldNumber = 4;
    private uint unk3300GLNFIFPNJIE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GLNFIFPNJIE {
      get { return unk3300GLNFIFPNJIE_; }
      set {
        unk3300GLNFIFPNJIE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IHBPCPCJIBC" field.</summary>
    public const int Unk3300IHBPCPCJIBCFieldNumber = 2;
    private uint unk3300IHBPCPCJIBC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IHBPCPCJIBC {
      get { return unk3300IHBPCPCJIBC_; }
      set {
        unk3300IHBPCPCJIBC_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MMALJIFDKJK" field.</summary>
    public const int Unk3300MMALJIFDKJKFieldNumber = 13;
    private uint unk3300MMALJIFDKJK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MMALJIFDKJK {
      get { return unk3300MMALJIFDKJK_; }
      set {
        unk3300MMALJIFDKJK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PDPJEMEKHKD" field.</summary>
    public const int Unk3300PDPJEMEKHKDFieldNumber = 10;
    private uint unk3300PDPJEMEKHKD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PDPJEMEKHKD {
      get { return unk3300PDPJEMEKHKD_; }
      set {
        unk3300PDPJEMEKHKD_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LIOFGAHKNIA" field.</summary>
    public const int Unk3300LIOFGAHKNIAFieldNumber = 14;
    private uint unk3300LIOFGAHKNIA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LIOFGAHKNIA {
      get { return unk3300LIOFGAHKNIA_; }
      set {
        unk3300LIOFGAHKNIA_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MIJMKLBGKML" field.</summary>
    public const int Unk3300MIJMKLBGKMLFieldNumber = 11;
    private uint unk3300MIJMKLBGKML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MIJMKLBGKML {
      get { return unk3300MIJMKLBGKML_; }
      set {
        unk3300MIJMKLBGKML_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JMLJLNKLJNP" field.</summary>
    public const int Unk3300JMLJLNKLJNPFieldNumber = 15;
    private uint unk3300JMLJLNKLJNP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JMLJLNKLJNP {
      get { return unk3300JMLJLNKLJNP_; }
      set {
        unk3300JMLJLNKLJNP_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 9;
    private global::NewProtos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetScenePerformanceRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetScenePerformanceRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Unk3300GLNFIFPNJIE != other.Unk3300GLNFIFPNJIE) return false;
      if (Unk3300IHBPCPCJIBC != other.Unk3300IHBPCPCJIBC) return false;
      if (Unk3300MMALJIFDKJK != other.Unk3300MMALJIFDKJK) return false;
      if (Unk3300PDPJEMEKHKD != other.Unk3300PDPJEMEKHKD) return false;
      if (Unk3300LIOFGAHKNIA != other.Unk3300LIOFGAHKNIA) return false;
      if (Unk3300MIJMKLBGKML != other.Unk3300MIJMKLBGKML) return false;
      if (Unk3300JMLJLNKLJNP != other.Unk3300JMLJLNKLJNP) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3300GLNFIFPNJIE != 0) hash ^= Unk3300GLNFIFPNJIE.GetHashCode();
      if (Unk3300IHBPCPCJIBC != 0) hash ^= Unk3300IHBPCPCJIBC.GetHashCode();
      if (Unk3300MMALJIFDKJK != 0) hash ^= Unk3300MMALJIFDKJK.GetHashCode();
      if (Unk3300PDPJEMEKHKD != 0) hash ^= Unk3300PDPJEMEKHKD.GetHashCode();
      if (Unk3300LIOFGAHKNIA != 0) hash ^= Unk3300LIOFGAHKNIA.GetHashCode();
      if (Unk3300MIJMKLBGKML != 0) hash ^= Unk3300MIJMKLBGKML.GetHashCode();
      if (Unk3300JMLJLNKLJNP != 0) hash ^= Unk3300JMLJLNKLJNP.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Unk3300IHBPCPCJIBC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300IHBPCPCJIBC);
      }
      if (Unk3300GLNFIFPNJIE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300GLNFIFPNJIE);
      }
      if (pos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Pos);
      }
      if (Unk3300PDPJEMEKHKD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300PDPJEMEKHKD);
      }
      if (Unk3300MIJMKLBGKML != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300MIJMKLBGKML);
      }
      if (Unk3300MMALJIFDKJK != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300MMALJIFDKJK);
      }
      if (Unk3300LIOFGAHKNIA != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300LIOFGAHKNIA);
      }
      if (Unk3300JMLJLNKLJNP != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300JMLJLNKLJNP);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Unk3300IHBPCPCJIBC != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300IHBPCPCJIBC);
      }
      if (Unk3300GLNFIFPNJIE != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300GLNFIFPNJIE);
      }
      if (pos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Pos);
      }
      if (Unk3300PDPJEMEKHKD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300PDPJEMEKHKD);
      }
      if (Unk3300MIJMKLBGKML != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300MIJMKLBGKML);
      }
      if (Unk3300MMALJIFDKJK != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300MMALJIFDKJK);
      }
      if (Unk3300LIOFGAHKNIA != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300LIOFGAHKNIA);
      }
      if (Unk3300JMLJLNKLJNP != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300JMLJLNKLJNP);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3300GLNFIFPNJIE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GLNFIFPNJIE);
      }
      if (Unk3300IHBPCPCJIBC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IHBPCPCJIBC);
      }
      if (Unk3300MMALJIFDKJK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MMALJIFDKJK);
      }
      if (Unk3300PDPJEMEKHKD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PDPJEMEKHKD);
      }
      if (Unk3300LIOFGAHKNIA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LIOFGAHKNIA);
      }
      if (Unk3300MIJMKLBGKML != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MIJMKLBGKML);
      }
      if (Unk3300JMLJLNKLJNP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JMLJLNKLJNP);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetScenePerformanceRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3300GLNFIFPNJIE != 0) {
        Unk3300GLNFIFPNJIE = other.Unk3300GLNFIFPNJIE;
      }
      if (other.Unk3300IHBPCPCJIBC != 0) {
        Unk3300IHBPCPCJIBC = other.Unk3300IHBPCPCJIBC;
      }
      if (other.Unk3300MMALJIFDKJK != 0) {
        Unk3300MMALJIFDKJK = other.Unk3300MMALJIFDKJK;
      }
      if (other.Unk3300PDPJEMEKHKD != 0) {
        Unk3300PDPJEMEKHKD = other.Unk3300PDPJEMEKHKD;
      }
      if (other.Unk3300LIOFGAHKNIA != 0) {
        Unk3300LIOFGAHKNIA = other.Unk3300LIOFGAHKNIA;
      }
      if (other.Unk3300MIJMKLBGKML != 0) {
        Unk3300MIJMKLBGKML = other.Unk3300MIJMKLBGKML;
      }
      if (other.Unk3300JMLJLNKLJNP != 0) {
        Unk3300JMLJLNKLJNP = other.Unk3300JMLJLNKLJNP;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::NewProtos.Vector();
        }
        Pos.MergeFrom(other.Pos);
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
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            Unk3300IHBPCPCJIBC = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300GLNFIFPNJIE = input.ReadUInt32();
            break;
          }
          case 74: {
            if (pos_ == null) {
              Pos = new global::NewProtos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 80: {
            Unk3300PDPJEMEKHKD = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300MIJMKLBGKML = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300MMALJIFDKJK = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300LIOFGAHKNIA = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300JMLJLNKLJNP = input.ReadUInt32();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            Unk3300IHBPCPCJIBC = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300GLNFIFPNJIE = input.ReadUInt32();
            break;
          }
          case 74: {
            if (pos_ == null) {
              Pos = new global::NewProtos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 80: {
            Unk3300PDPJEMEKHKD = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300MIJMKLBGKML = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300MMALJIFDKJK = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300LIOFGAHKNIA = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300JMLJLNKLJNP = input.ReadUInt32();
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
