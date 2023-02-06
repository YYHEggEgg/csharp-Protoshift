// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgSelectOnStage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGMsgSelectOnStage.proto</summary>
public static partial class GCGMsgSelectOnStageReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGMsgSelectOnStage.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGMsgSelectOnStageReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlHQ0dNc2dTZWxlY3RPblN0YWdlLnByb3RvGg9HQ0dSZWFzb24ucHJvdG8i",
          "WwoTR0NHTXNnU2VsZWN0T25TdGFnZRIaCgZyZWFzb24YCyABKA4yCi5HQ0dS",
          "ZWFzb24SFQoNY29udHJvbGxlcl9pZBgMIAEoDRIRCgljYXJkX2d1aWQYBCAB",
          "KA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGReasonReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGMsgSelectOnStage), global::GCGMsgSelectOnStage.Parser, new[]{ "Reason", "ControllerId", "CardGuid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGMsgSelectOnStage : pb::IMessage<GCGMsgSelectOnStage>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGMsgSelectOnStage> _parser = new pb::MessageParser<GCGMsgSelectOnStage>(() => new GCGMsgSelectOnStage());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGMsgSelectOnStage> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGMsgSelectOnStageReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgSelectOnStage() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgSelectOnStage(GCGMsgSelectOnStage other) : this() {
    reason_ = other.reason_;
    controllerId_ = other.controllerId_;
    cardGuid_ = other.cardGuid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgSelectOnStage Clone() {
    return new GCGMsgSelectOnStage(this);
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 11;
  private global::GCGReason reason_ = global::GCGReason.Default;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "controller_id" field.</summary>
  public const int ControllerIdFieldNumber = 12;
  private uint controllerId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ControllerId {
    get { return controllerId_; }
    set {
      controllerId_ = value;
    }
  }

  /// <summary>Field number for the "card_guid" field.</summary>
  public const int CardGuidFieldNumber = 4;
  private uint cardGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CardGuid {
    get { return cardGuid_; }
    set {
      cardGuid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGMsgSelectOnStage);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGMsgSelectOnStage other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Reason != other.Reason) return false;
    if (ControllerId != other.ControllerId) return false;
    if (CardGuid != other.CardGuid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Reason != global::GCGReason.Default) hash ^= Reason.GetHashCode();
    if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
    if (CardGuid != 0) hash ^= CardGuid.GetHashCode();
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
    if (CardGuid != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CardGuid);
    }
    if (Reason != global::GCGReason.Default) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Reason);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ControllerId);
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
    if (CardGuid != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CardGuid);
    }
    if (Reason != global::GCGReason.Default) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Reason);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ControllerId);
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
    if (Reason != global::GCGReason.Default) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (ControllerId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
    }
    if (CardGuid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardGuid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGMsgSelectOnStage other) {
    if (other == null) {
      return;
    }
    if (other.Reason != global::GCGReason.Default) {
      Reason = other.Reason;
    }
    if (other.ControllerId != 0) {
      ControllerId = other.ControllerId;
    }
    if (other.CardGuid != 0) {
      CardGuid = other.CardGuid;
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
          CardGuid = input.ReadUInt32();
          break;
        }
        case 88: {
          Reason = (global::GCGReason) input.ReadEnum();
          break;
        }
        case 96: {
          ControllerId = input.ReadUInt32();
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
          CardGuid = input.ReadUInt32();
          break;
        }
        case 88: {
          Reason = (global::GCGReason) input.ReadEnum();
          break;
        }
        case 96: {
          ControllerId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
