// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMessagePack.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GCGMessagePack.proto</summary>
  public static partial class GCGMessagePackReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMessagePack.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMessagePackReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRHQ0dNZXNzYWdlUGFjay5wcm90bxoTR0NHQWN0aW9uVHlwZS5wcm90bxoQ",
            "R0NHTWVzc2FnZS5wcm90byJrCg5HQ0dNZXNzYWdlUGFjaxIjCgthY3Rpb25f",
            "dHlwZRgJIAEoDjIOLkdDR0FjdGlvblR5cGUSHQoIbXNnX2xpc3QYBSADKAsy",
            "Cy5HQ0dNZXNzYWdlEhUKDWNvbnRyb2xsZXJfaWQYByABKA1CDKoCCU5ld1By",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GCGActionTypeReflection.Descriptor, global::NewProtos.GCGMessageReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GCGMessagePack), global::NewProtos.GCGMessagePack.Parser, new[]{ "ActionType", "MsgList", "ControllerId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMessagePack : pb::IMessage<GCGMessagePack>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMessagePack> _parser = new pb::MessageParser<GCGMessagePack>(() => new GCGMessagePack());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMessagePack> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GCGMessagePackReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMessagePack() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMessagePack(GCGMessagePack other) : this() {
      actionType_ = other.actionType_;
      msgList_ = other.msgList_.Clone();
      controllerId_ = other.controllerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMessagePack Clone() {
      return new GCGMessagePack(this);
    }

    /// <summary>Field number for the "action_type" field.</summary>
    public const int ActionTypeFieldNumber = 9;
    private global::NewProtos.GCGActionType actionType_ = global::NewProtos.GCGActionType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GCGActionType ActionType {
      get { return actionType_; }
      set {
        actionType_ = value;
      }
    }

    /// <summary>Field number for the "msg_list" field.</summary>
    public const int MsgListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::NewProtos.GCGMessage> _repeated_msgList_codec
        = pb::FieldCodec.ForMessage(42, global::NewProtos.GCGMessage.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.GCGMessage> msgList_ = new pbc::RepeatedField<global::NewProtos.GCGMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.GCGMessage> MsgList {
      get { return msgList_; }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 7;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMessagePack);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMessagePack other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActionType != other.ActionType) return false;
      if(!msgList_.Equals(other.msgList_)) return false;
      if (ControllerId != other.ControllerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActionType != global::NewProtos.GCGActionType.None) hash ^= ActionType.GetHashCode();
      hash ^= msgList_.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
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
      msgList_.WriteTo(output, _repeated_msgList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ControllerId);
      }
      if (ActionType != global::NewProtos.GCGActionType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ActionType);
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
      msgList_.WriteTo(ref output, _repeated_msgList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ControllerId);
      }
      if (ActionType != global::NewProtos.GCGActionType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ActionType);
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
      if (ActionType != global::NewProtos.GCGActionType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActionType);
      }
      size += msgList_.CalculateSize(_repeated_msgList_codec);
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMessagePack other) {
      if (other == null) {
        return;
      }
      if (other.ActionType != global::NewProtos.GCGActionType.None) {
        ActionType = other.ActionType;
      }
      msgList_.Add(other.msgList_);
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
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
          case 42: {
            msgList_.AddEntriesFrom(input, _repeated_msgList_codec);
            break;
          }
          case 56: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 72: {
            ActionType = (global::NewProtos.GCGActionType) input.ReadEnum();
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
          case 42: {
            msgList_.AddEntriesFrom(ref input, _repeated_msgList_codec);
            break;
          }
          case 56: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 72: {
            ActionType = (global::NewProtos.GCGActionType) input.ReadEnum();
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
