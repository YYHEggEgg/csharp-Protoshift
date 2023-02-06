// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseMiracleRingReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from UseMiracleRingReq.proto</summary>
public static partial class UseMiracleRingReqReflection {

  #region Descriptor
  /// <summary>File descriptor for UseMiracleRingReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static UseMiracleRingReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdVc2VNaXJhY2xlUmluZ1JlcS5wcm90bxoMVmVjdG9yLnByb3RvItMBChFV",
          "c2VNaXJhY2xlUmluZ1JlcRIUCgNyb3QYDiABKAsyBy5WZWN0b3ISFAoDcG9z",
          "GA0gASgLMgcuVmVjdG9yEhwKFG1pcmFjbGVfcmluZ19vcF90eXBlGAUgASgN",
          "InQKEU1pcmFjbGVSaW5nT3BUeXBlEh0KGU1JUkFDTEVfUklOR19PUF9UWVBF",
          "X05PTkUQABIeChpNSVJBQ0xFX1JJTkdfT1BfVFlQRV9QTEFDRRABEiAKHE1J",
          "UkFDTEVfUklOR19PUF9UWVBFX1JFVFJBQ1QQAkIWChRvcmcuc29yYXBvaW50",
          "YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::UseMiracleRingReq), global::UseMiracleRingReq.Parser, new[]{ "Rot", "Pos", "MiracleRingOpType" }, null, new[]{ typeof(global::UseMiracleRingReq.Types.MiracleRingOpType) }, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 5242;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class UseMiracleRingReq : pb::IMessage<UseMiracleRingReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<UseMiracleRingReq> _parser = new pb::MessageParser<UseMiracleRingReq>(() => new UseMiracleRingReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<UseMiracleRingReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::UseMiracleRingReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public UseMiracleRingReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public UseMiracleRingReq(UseMiracleRingReq other) : this() {
    rot_ = other.rot_ != null ? other.rot_.Clone() : null;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    miracleRingOpType_ = other.miracleRingOpType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public UseMiracleRingReq Clone() {
    return new UseMiracleRingReq(this);
  }

  /// <summary>Field number for the "rot" field.</summary>
  public const int RotFieldNumber = 14;
  private global::Vector rot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Rot {
    get { return rot_; }
    set {
      rot_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 13;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  /// <summary>Field number for the "miracle_ring_op_type" field.</summary>
  public const int MiracleRingOpTypeFieldNumber = 5;
  private uint miracleRingOpType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MiracleRingOpType {
    get { return miracleRingOpType_; }
    set {
      miracleRingOpType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as UseMiracleRingReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(UseMiracleRingReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Rot, other.Rot)) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    if (MiracleRingOpType != other.MiracleRingOpType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (rot_ != null) hash ^= Rot.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
    if (MiracleRingOpType != 0) hash ^= MiracleRingOpType.GetHashCode();
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
    if (MiracleRingOpType != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MiracleRingOpType);
    }
    if (pos_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(Pos);
    }
    if (rot_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(Rot);
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
    if (MiracleRingOpType != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MiracleRingOpType);
    }
    if (pos_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(Pos);
    }
    if (rot_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(Rot);
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
    if (rot_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (MiracleRingOpType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MiracleRingOpType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(UseMiracleRingReq other) {
    if (other == null) {
      return;
    }
    if (other.rot_ != null) {
      if (rot_ == null) {
        Rot = new global::Vector();
      }
      Rot.MergeFrom(other.Rot);
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
    }
    if (other.MiracleRingOpType != 0) {
      MiracleRingOpType = other.MiracleRingOpType;
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
        case 40: {
          MiracleRingOpType = input.ReadUInt32();
          break;
        }
        case 106: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 114: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
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
        case 40: {
          MiracleRingOpType = input.ReadUInt32();
          break;
        }
        case 106: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 114: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the UseMiracleRingReq message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum MiracleRingOpType {
      [pbr::OriginalName("MIRACLE_RING_OP_TYPE_NONE")] None = 0,
      [pbr::OriginalName("MIRACLE_RING_OP_TYPE_PLACE")] Place = 1,
      [pbr::OriginalName("MIRACLE_RING_OP_TYPE_RETRACT")] Retract = 2,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
