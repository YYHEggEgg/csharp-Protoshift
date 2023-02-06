// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AnchorPointOpRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AnchorPointOpRsp.proto</summary>
public static partial class AnchorPointOpRspReflection {

  #region Descriptor
  /// <summary>File descriptor for AnchorPointOpRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AnchorPointOpRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZBbmNob3JQb2ludE9wUnNwLnByb3RvIloKEEFuY2hvclBvaW50T3BSc3AS",
          "FwoPYW5jaG9yX3BvaW50X2lkGAkgASgNEg8KB3JldGNvZGUYBCABKAUSHAoU",
          "YW5jaG9yX3BvaW50X29wX3R5cGUYDCABKA1CFgoUb3JnLnNvcmFwb2ludGEu",
          "cHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AnchorPointOpRsp), global::AnchorPointOpRsp.Parser, new[]{ "AnchorPointId", "Retcode", "AnchorPointOpType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4277;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class AnchorPointOpRsp : pb::IMessage<AnchorPointOpRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AnchorPointOpRsp> _parser = new pb::MessageParser<AnchorPointOpRsp>(() => new AnchorPointOpRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AnchorPointOpRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AnchorPointOpRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AnchorPointOpRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AnchorPointOpRsp(AnchorPointOpRsp other) : this() {
    anchorPointId_ = other.anchorPointId_;
    retcode_ = other.retcode_;
    anchorPointOpType_ = other.anchorPointOpType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AnchorPointOpRsp Clone() {
    return new AnchorPointOpRsp(this);
  }

  /// <summary>Field number for the "anchor_point_id" field.</summary>
  public const int AnchorPointIdFieldNumber = 9;
  private uint anchorPointId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AnchorPointId {
    get { return anchorPointId_; }
    set {
      anchorPointId_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 4;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "anchor_point_op_type" field.</summary>
  public const int AnchorPointOpTypeFieldNumber = 12;
  private uint anchorPointOpType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AnchorPointOpType {
    get { return anchorPointOpType_; }
    set {
      anchorPointOpType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AnchorPointOpRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AnchorPointOpRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (AnchorPointId != other.AnchorPointId) return false;
    if (Retcode != other.Retcode) return false;
    if (AnchorPointOpType != other.AnchorPointOpType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (AnchorPointId != 0) hash ^= AnchorPointId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (AnchorPointOpType != 0) hash ^= AnchorPointOpType.GetHashCode();
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
      output.WriteRawTag(32);
      output.WriteInt32(Retcode);
    }
    if (AnchorPointId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(AnchorPointId);
    }
    if (AnchorPointOpType != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(AnchorPointOpType);
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
      output.WriteRawTag(32);
      output.WriteInt32(Retcode);
    }
    if (AnchorPointId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(AnchorPointId);
    }
    if (AnchorPointOpType != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(AnchorPointOpType);
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
    if (AnchorPointId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AnchorPointId);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (AnchorPointOpType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AnchorPointOpType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AnchorPointOpRsp other) {
    if (other == null) {
      return;
    }
    if (other.AnchorPointId != 0) {
      AnchorPointId = other.AnchorPointId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.AnchorPointOpType != 0) {
      AnchorPointOpType = other.AnchorPointOpType;
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
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          AnchorPointId = input.ReadUInt32();
          break;
        }
        case 96: {
          AnchorPointOpType = input.ReadUInt32();
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
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          AnchorPointId = input.ReadUInt32();
          break;
        }
        case 96: {
          AnchorPointOpType = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
