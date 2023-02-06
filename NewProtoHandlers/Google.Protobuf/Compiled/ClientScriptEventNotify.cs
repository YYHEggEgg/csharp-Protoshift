// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClientScriptEventNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ClientScriptEventNotify.proto</summary>
public static partial class ClientScriptEventNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ClientScriptEventNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ClientScriptEventNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1DbGllbnRTY3JpcHRFdmVudE5vdGlmeS5wcm90byJ1ChdDbGllbnRTY3Jp",
          "cHRFdmVudE5vdGlmeRIYChBzb3VyY2VfZW50aXR5X2lkGAEgASgNEhIKCmV2",
          "ZW50X3R5cGUYCCABKA0SGAoQdGFyZ2V0X2VudGl0eV9pZBgEIAEoDRISCgpw",
          "YXJhbV9saXN0GAYgAygFQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ClientScriptEventNotify), global::ClientScriptEventNotify.Parser, new[]{ "SourceEntityId", "EventType", "TargetEntityId", "ParamList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 260;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class ClientScriptEventNotify : pb::IMessage<ClientScriptEventNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ClientScriptEventNotify> _parser = new pb::MessageParser<ClientScriptEventNotify>(() => new ClientScriptEventNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ClientScriptEventNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientScriptEventNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ClientScriptEventNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ClientScriptEventNotify(ClientScriptEventNotify other) : this() {
    sourceEntityId_ = other.sourceEntityId_;
    eventType_ = other.eventType_;
    targetEntityId_ = other.targetEntityId_;
    paramList_ = other.paramList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ClientScriptEventNotify Clone() {
    return new ClientScriptEventNotify(this);
  }

  /// <summary>Field number for the "source_entity_id" field.</summary>
  public const int SourceEntityIdFieldNumber = 1;
  private uint sourceEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SourceEntityId {
    get { return sourceEntityId_; }
    set {
      sourceEntityId_ = value;
    }
  }

  /// <summary>Field number for the "event_type" field.</summary>
  public const int EventTypeFieldNumber = 8;
  private uint eventType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EventType {
    get { return eventType_; }
    set {
      eventType_ = value;
    }
  }

  /// <summary>Field number for the "target_entity_id" field.</summary>
  public const int TargetEntityIdFieldNumber = 4;
  private uint targetEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TargetEntityId {
    get { return targetEntityId_; }
    set {
      targetEntityId_ = value;
    }
  }

  /// <summary>Field number for the "param_list" field.</summary>
  public const int ParamListFieldNumber = 6;
  private static readonly pb::FieldCodec<int> _repeated_paramList_codec
      = pb::FieldCodec.ForInt32(50);
  private readonly pbc::RepeatedField<int> paramList_ = new pbc::RepeatedField<int>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<int> ParamList {
    get { return paramList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ClientScriptEventNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ClientScriptEventNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (SourceEntityId != other.SourceEntityId) return false;
    if (EventType != other.EventType) return false;
    if (TargetEntityId != other.TargetEntityId) return false;
    if(!paramList_.Equals(other.paramList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (SourceEntityId != 0) hash ^= SourceEntityId.GetHashCode();
    if (EventType != 0) hash ^= EventType.GetHashCode();
    if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
    hash ^= paramList_.GetHashCode();
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
    if (SourceEntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(SourceEntityId);
    }
    if (TargetEntityId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(TargetEntityId);
    }
    paramList_.WriteTo(output, _repeated_paramList_codec);
    if (EventType != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(EventType);
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
    if (SourceEntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(SourceEntityId);
    }
    if (TargetEntityId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(TargetEntityId);
    }
    paramList_.WriteTo(ref output, _repeated_paramList_codec);
    if (EventType != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(EventType);
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
    if (SourceEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceEntityId);
    }
    if (EventType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventType);
    }
    if (TargetEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
    }
    size += paramList_.CalculateSize(_repeated_paramList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ClientScriptEventNotify other) {
    if (other == null) {
      return;
    }
    if (other.SourceEntityId != 0) {
      SourceEntityId = other.SourceEntityId;
    }
    if (other.EventType != 0) {
      EventType = other.EventType;
    }
    if (other.TargetEntityId != 0) {
      TargetEntityId = other.TargetEntityId;
    }
    paramList_.Add(other.paramList_);
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
          SourceEntityId = input.ReadUInt32();
          break;
        }
        case 32: {
          TargetEntityId = input.ReadUInt32();
          break;
        }
        case 50:
        case 48: {
          paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
          break;
        }
        case 64: {
          EventType = input.ReadUInt32();
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
          SourceEntityId = input.ReadUInt32();
          break;
        }
        case 32: {
          TargetEntityId = input.ReadUInt32();
          break;
        }
        case 50:
        case 48: {
          paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
          break;
        }
        case 64: {
          EventType = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
