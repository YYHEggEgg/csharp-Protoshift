// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SummerTimeFloatSignalUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SummerTimeFloatSignalUpdateNotify.proto</summary>
public static partial class SummerTimeFloatSignalUpdateNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for SummerTimeFloatSignalUpdateNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SummerTimeFloatSignalUpdateNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CidTdW1tZXJUaW1lRmxvYXRTaWduYWxVcGRhdGVOb3RpZnkucHJvdG8aDFZl",
          "Y3Rvci5wcm90byJzCiFTdW1tZXJUaW1lRmxvYXRTaWduYWxVcGRhdGVOb3Rp",
          "ZnkSGgoSaXNfdHJhbnNmZXJfYW5jaG9yGAEgASgIEhkKCHBvc2l0aW9uGAcg",
          "ASgLMgcuVmVjdG9yEhcKD2Zsb2F0X3NpZ25hbF9pZBgMIAEoDUIWChRvcmcu",
          "c29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SummerTimeFloatSignalUpdateNotify), global::SummerTimeFloatSignalUpdateNotify.Parser, new[]{ "IsTransferAnchor", "Position", "FloatSignalId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 8508;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class SummerTimeFloatSignalUpdateNotify : pb::IMessage<SummerTimeFloatSignalUpdateNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SummerTimeFloatSignalUpdateNotify> _parser = new pb::MessageParser<SummerTimeFloatSignalUpdateNotify>(() => new SummerTimeFloatSignalUpdateNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SummerTimeFloatSignalUpdateNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SummerTimeFloatSignalUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SummerTimeFloatSignalUpdateNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SummerTimeFloatSignalUpdateNotify(SummerTimeFloatSignalUpdateNotify other) : this() {
    isTransferAnchor_ = other.isTransferAnchor_;
    position_ = other.position_ != null ? other.position_.Clone() : null;
    floatSignalId_ = other.floatSignalId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SummerTimeFloatSignalUpdateNotify Clone() {
    return new SummerTimeFloatSignalUpdateNotify(this);
  }

  /// <summary>Field number for the "is_transfer_anchor" field.</summary>
  public const int IsTransferAnchorFieldNumber = 1;
  private bool isTransferAnchor_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsTransferAnchor {
    get { return isTransferAnchor_; }
    set {
      isTransferAnchor_ = value;
    }
  }

  /// <summary>Field number for the "position" field.</summary>
  public const int PositionFieldNumber = 7;
  private global::Vector position_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Position {
    get { return position_; }
    set {
      position_ = value;
    }
  }

  /// <summary>Field number for the "float_signal_id" field.</summary>
  public const int FloatSignalIdFieldNumber = 12;
  private uint floatSignalId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FloatSignalId {
    get { return floatSignalId_; }
    set {
      floatSignalId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SummerTimeFloatSignalUpdateNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SummerTimeFloatSignalUpdateNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsTransferAnchor != other.IsTransferAnchor) return false;
    if (!object.Equals(Position, other.Position)) return false;
    if (FloatSignalId != other.FloatSignalId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsTransferAnchor != false) hash ^= IsTransferAnchor.GetHashCode();
    if (position_ != null) hash ^= Position.GetHashCode();
    if (FloatSignalId != 0) hash ^= FloatSignalId.GetHashCode();
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
    if (IsTransferAnchor != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsTransferAnchor);
    }
    if (position_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Position);
    }
    if (FloatSignalId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(FloatSignalId);
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
    if (IsTransferAnchor != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsTransferAnchor);
    }
    if (position_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Position);
    }
    if (FloatSignalId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(FloatSignalId);
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
    if (IsTransferAnchor != false) {
      size += 1 + 1;
    }
    if (position_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
    }
    if (FloatSignalId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloatSignalId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SummerTimeFloatSignalUpdateNotify other) {
    if (other == null) {
      return;
    }
    if (other.IsTransferAnchor != false) {
      IsTransferAnchor = other.IsTransferAnchor;
    }
    if (other.position_ != null) {
      if (position_ == null) {
        Position = new global::Vector();
      }
      Position.MergeFrom(other.Position);
    }
    if (other.FloatSignalId != 0) {
      FloatSignalId = other.FloatSignalId;
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
          IsTransferAnchor = input.ReadBool();
          break;
        }
        case 58: {
          if (position_ == null) {
            Position = new global::Vector();
          }
          input.ReadMessage(Position);
          break;
        }
        case 96: {
          FloatSignalId = input.ReadUInt32();
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
          IsTransferAnchor = input.ReadBool();
          break;
        }
        case 58: {
          if (position_ == null) {
            Position = new global::Vector();
          }
          input.ReadMessage(Position);
          break;
        }
        case 96: {
          FloatSignalId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code