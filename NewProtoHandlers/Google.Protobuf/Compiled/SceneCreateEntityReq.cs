// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneCreateEntityReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneCreateEntityReq.proto</summary>
public static partial class SceneCreateEntityReqReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneCreateEntityReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneCreateEntityReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpTY2VuZUNyZWF0ZUVudGl0eVJlcS5wcm90bxoWQ3JlYXRlRW50aXR5SW5m",
          "by5wcm90bxoSQ3JlYXRlUmVhc29uLnByb3RvInwKFFNjZW5lQ3JlYXRlRW50",
          "aXR5UmVxEh0KBnJlYXNvbhgEIAEoDjINLkNyZWF0ZVJlYXNvbhIhCgZlbnRp",
          "dHkYCCABKAsyES5DcmVhdGVFbnRpdHlJbmZvEiIKGmlzX2Rlc3Ryb3lfd2hl",
          "bl9kaXNjb25uZWN0GA8gASgIQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZw",
          "cm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CreateEntityInfoReflection.Descriptor, global::CreateReasonReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneCreateEntityReq), global::SceneCreateEntityReq.Parser, new[]{ "Reason", "Entity", "IsDestroyWhenDisconnect" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 294;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class SceneCreateEntityReq : pb::IMessage<SceneCreateEntityReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneCreateEntityReq> _parser = new pb::MessageParser<SceneCreateEntityReq>(() => new SceneCreateEntityReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneCreateEntityReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneCreateEntityReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneCreateEntityReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneCreateEntityReq(SceneCreateEntityReq other) : this() {
    reason_ = other.reason_;
    entity_ = other.entity_ != null ? other.entity_.Clone() : null;
    isDestroyWhenDisconnect_ = other.isDestroyWhenDisconnect_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneCreateEntityReq Clone() {
    return new SceneCreateEntityReq(this);
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 4;
  private global::CreateReason reason_ = global::CreateReason.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CreateReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "entity" field.</summary>
  public const int EntityFieldNumber = 8;
  private global::CreateEntityInfo entity_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CreateEntityInfo Entity {
    get { return entity_; }
    set {
      entity_ = value;
    }
  }

  /// <summary>Field number for the "is_destroy_when_disconnect" field.</summary>
  public const int IsDestroyWhenDisconnectFieldNumber = 15;
  private bool isDestroyWhenDisconnect_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsDestroyWhenDisconnect {
    get { return isDestroyWhenDisconnect_; }
    set {
      isDestroyWhenDisconnect_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneCreateEntityReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneCreateEntityReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Reason != other.Reason) return false;
    if (!object.Equals(Entity, other.Entity)) return false;
    if (IsDestroyWhenDisconnect != other.IsDestroyWhenDisconnect) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Reason != global::CreateReason.None) hash ^= Reason.GetHashCode();
    if (entity_ != null) hash ^= Entity.GetHashCode();
    if (IsDestroyWhenDisconnect != false) hash ^= IsDestroyWhenDisconnect.GetHashCode();
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
    if (Reason != global::CreateReason.None) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Reason);
    }
    if (entity_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(Entity);
    }
    if (IsDestroyWhenDisconnect != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsDestroyWhenDisconnect);
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
    if (Reason != global::CreateReason.None) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Reason);
    }
    if (entity_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(Entity);
    }
    if (IsDestroyWhenDisconnect != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsDestroyWhenDisconnect);
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
    if (Reason != global::CreateReason.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (entity_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Entity);
    }
    if (IsDestroyWhenDisconnect != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneCreateEntityReq other) {
    if (other == null) {
      return;
    }
    if (other.Reason != global::CreateReason.None) {
      Reason = other.Reason;
    }
    if (other.entity_ != null) {
      if (entity_ == null) {
        Entity = new global::CreateEntityInfo();
      }
      Entity.MergeFrom(other.Entity);
    }
    if (other.IsDestroyWhenDisconnect != false) {
      IsDestroyWhenDisconnect = other.IsDestroyWhenDisconnect;
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
          Reason = (global::CreateReason) input.ReadEnum();
          break;
        }
        case 66: {
          if (entity_ == null) {
            Entity = new global::CreateEntityInfo();
          }
          input.ReadMessage(Entity);
          break;
        }
        case 120: {
          IsDestroyWhenDisconnect = input.ReadBool();
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
          Reason = (global::CreateReason) input.ReadEnum();
          break;
        }
        case 66: {
          if (entity_ == null) {
            Entity = new global::CreateEntityInfo();
          }
          input.ReadMessage(Entity);
          break;
        }
        case 120: {
          IsDestroyWhenDisconnect = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
