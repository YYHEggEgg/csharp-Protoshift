// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlessingAcceptGivePicRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BlessingAcceptGivePicRsp.proto</summary>
public static partial class BlessingAcceptGivePicRspReflection {

  #region Descriptor
  /// <summary>File descriptor for BlessingAcceptGivePicRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BlessingAcceptGivePicRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5CbGVzc2luZ0FjY2VwdEdpdmVQaWNSc3AucHJvdG8iVwoYQmxlc3NpbmdB",
          "Y2NlcHRHaXZlUGljUnNwEg0KBWluZGV4GA8gASgNEg4KBnBpY19pZBgMIAEo",
          "DRILCgN1aWQYBCABKA0SDwoHcmV0Y29kZRgIIAEoBUIWChRvcmcuc29yYXBv",
          "aW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BlessingAcceptGivePicRsp), global::BlessingAcceptGivePicRsp.Parser, new[]{ "Index", "PicId", "Uid", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 2010;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class BlessingAcceptGivePicRsp : pb::IMessage<BlessingAcceptGivePicRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BlessingAcceptGivePicRsp> _parser = new pb::MessageParser<BlessingAcceptGivePicRsp>(() => new BlessingAcceptGivePicRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BlessingAcceptGivePicRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlessingAcceptGivePicRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingAcceptGivePicRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingAcceptGivePicRsp(BlessingAcceptGivePicRsp other) : this() {
    index_ = other.index_;
    picId_ = other.picId_;
    uid_ = other.uid_;
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingAcceptGivePicRsp Clone() {
    return new BlessingAcceptGivePicRsp(this);
  }

  /// <summary>Field number for the "index" field.</summary>
  public const int IndexFieldNumber = 15;
  private uint index_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Index {
    get { return index_; }
    set {
      index_ = value;
    }
  }

  /// <summary>Field number for the "pic_id" field.</summary>
  public const int PicIdFieldNumber = 12;
  private uint picId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PicId {
    get { return picId_; }
    set {
      picId_ = value;
    }
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 4;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 8;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BlessingAcceptGivePicRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BlessingAcceptGivePicRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Index != other.Index) return false;
    if (PicId != other.PicId) return false;
    if (Uid != other.Uid) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Index != 0) hash ^= Index.GetHashCode();
    if (PicId != 0) hash ^= PicId.GetHashCode();
    if (Uid != 0) hash ^= Uid.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (Uid != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Uid);
    }
    if (Retcode != 0) {
      output.WriteRawTag(64);
      output.WriteInt32(Retcode);
    }
    if (PicId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(PicId);
    }
    if (Index != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Index);
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
    if (Uid != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Uid);
    }
    if (Retcode != 0) {
      output.WriteRawTag(64);
      output.WriteInt32(Retcode);
    }
    if (PicId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(PicId);
    }
    if (Index != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Index);
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
    if (Index != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
    }
    if (PicId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PicId);
    }
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BlessingAcceptGivePicRsp other) {
    if (other == null) {
      return;
    }
    if (other.Index != 0) {
      Index = other.Index;
    }
    if (other.PicId != 0) {
      PicId = other.PicId;
    }
    if (other.Uid != 0) {
      Uid = other.Uid;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
          Uid = input.ReadUInt32();
          break;
        }
        case 64: {
          Retcode = input.ReadInt32();
          break;
        }
        case 96: {
          PicId = input.ReadUInt32();
          break;
        }
        case 120: {
          Index = input.ReadUInt32();
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
          Uid = input.ReadUInt32();
          break;
        }
        case 64: {
          Retcode = input.ReadInt32();
          break;
        }
        case 96: {
          PicId = input.ReadUInt32();
          break;
        }
        case 120: {
          Index = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
