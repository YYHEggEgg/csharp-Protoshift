// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SaveCoopDialogReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SaveCoopDialogReq.proto</summary>
  public static partial class SaveCoopDialogReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SaveCoopDialogReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SaveCoopDialogReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTYXZlQ29vcERpYWxvZ1JlcS5wcm90byJNChFTYXZlQ29vcERpYWxvZ1Jl",
            "cRIbChNVbmszMzAwX0FNS0RESkVQQUtNGAogASgNEhsKE1VuazMzMDBfS01C",
            "R05JSUNOQUYYCCABKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SaveCoopDialogReq), global::NewProtos.SaveCoopDialogReq.Parser, new[]{ "Unk3300AMKDDJEPAKM", "Unk3300KMBGNIICNAF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1954;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class SaveCoopDialogReq : pb::IMessage<SaveCoopDialogReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SaveCoopDialogReq> _parser = new pb::MessageParser<SaveCoopDialogReq>(() => new SaveCoopDialogReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SaveCoopDialogReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SaveCoopDialogReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCoopDialogReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCoopDialogReq(SaveCoopDialogReq other) : this() {
      unk3300AMKDDJEPAKM_ = other.unk3300AMKDDJEPAKM_;
      unk3300KMBGNIICNAF_ = other.unk3300KMBGNIICNAF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCoopDialogReq Clone() {
      return new SaveCoopDialogReq(this);
    }

    /// <summary>Field number for the "Unk3300_AMKDDJEPAKM" field.</summary>
    public const int Unk3300AMKDDJEPAKMFieldNumber = 10;
    private uint unk3300AMKDDJEPAKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AMKDDJEPAKM {
      get { return unk3300AMKDDJEPAKM_; }
      set {
        unk3300AMKDDJEPAKM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KMBGNIICNAF" field.</summary>
    public const int Unk3300KMBGNIICNAFFieldNumber = 8;
    private uint unk3300KMBGNIICNAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KMBGNIICNAF {
      get { return unk3300KMBGNIICNAF_; }
      set {
        unk3300KMBGNIICNAF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SaveCoopDialogReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SaveCoopDialogReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300AMKDDJEPAKM != other.Unk3300AMKDDJEPAKM) return false;
      if (Unk3300KMBGNIICNAF != other.Unk3300KMBGNIICNAF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300AMKDDJEPAKM != 0) hash ^= Unk3300AMKDDJEPAKM.GetHashCode();
      if (Unk3300KMBGNIICNAF != 0) hash ^= Unk3300KMBGNIICNAF.GetHashCode();
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
      if (Unk3300KMBGNIICNAF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300KMBGNIICNAF);
      }
      if (Unk3300AMKDDJEPAKM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300AMKDDJEPAKM);
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
      if (Unk3300KMBGNIICNAF != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300KMBGNIICNAF);
      }
      if (Unk3300AMKDDJEPAKM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300AMKDDJEPAKM);
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
      if (Unk3300AMKDDJEPAKM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AMKDDJEPAKM);
      }
      if (Unk3300KMBGNIICNAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KMBGNIICNAF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SaveCoopDialogReq other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300AMKDDJEPAKM != 0) {
        Unk3300AMKDDJEPAKM = other.Unk3300AMKDDJEPAKM;
      }
      if (other.Unk3300KMBGNIICNAF != 0) {
        Unk3300KMBGNIICNAF = other.Unk3300KMBGNIICNAF;
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
          case 64: {
            Unk3300KMBGNIICNAF = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300AMKDDJEPAKM = input.ReadUInt32();
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
          case 64: {
            Unk3300KMBGNIICNAF = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300AMKDDJEPAKM = input.ReadUInt32();
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