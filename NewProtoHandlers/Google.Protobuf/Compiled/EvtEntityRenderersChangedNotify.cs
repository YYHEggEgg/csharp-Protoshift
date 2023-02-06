// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtEntityRenderersChangedNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EvtEntityRenderersChangedNotify.proto</summary>
public static partial class EvtEntityRenderersChangedNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for EvtEntityRenderersChangedNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EvtEntityRenderersChangedNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVFdnRFbnRpdHlSZW5kZXJlcnNDaGFuZ2VkTm90aWZ5LnByb3RvGh9FbnRp",
          "dHlSZW5kZXJlckNoYW5nZWRJbmZvLnByb3RvGhFGb3J3YXJkVHlwZS5wcm90",
          "byKsAQofRXZ0RW50aXR5UmVuZGVyZXJzQ2hhbmdlZE5vdGlmeRIiCgxmb3J3",
          "YXJkX3R5cGUYBSABKA4yDC5Gb3J3YXJkVHlwZRIRCgllbnRpdHlfaWQYASAB",
          "KA0SFwoPaXNfc2VydmVyX2NhY2hlGAMgASgIEjkKFXJlbmRlcmVyX2NoYW5n",
          "ZWRfaW5mbxgPIAEoCzIaLkVudGl0eVJlbmRlcmVyQ2hhbmdlZEluZm9CFgoU",
          "b3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::EntityRendererChangedInfoReflection.Descriptor, global::ForwardTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EvtEntityRenderersChangedNotify), global::EvtEntityRenderersChangedNotify.Parser, new[]{ "ForwardType", "EntityId", "IsServerCache", "RendererChangedInfo" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 375;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class EvtEntityRenderersChangedNotify : pb::IMessage<EvtEntityRenderersChangedNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EvtEntityRenderersChangedNotify> _parser = new pb::MessageParser<EvtEntityRenderersChangedNotify>(() => new EvtEntityRenderersChangedNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EvtEntityRenderersChangedNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EvtEntityRenderersChangedNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtEntityRenderersChangedNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtEntityRenderersChangedNotify(EvtEntityRenderersChangedNotify other) : this() {
    forwardType_ = other.forwardType_;
    entityId_ = other.entityId_;
    isServerCache_ = other.isServerCache_;
    rendererChangedInfo_ = other.rendererChangedInfo_ != null ? other.rendererChangedInfo_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtEntityRenderersChangedNotify Clone() {
    return new EvtEntityRenderersChangedNotify(this);
  }

  /// <summary>Field number for the "forward_type" field.</summary>
  public const int ForwardTypeFieldNumber = 5;
  private global::ForwardType forwardType_ = global::ForwardType.Local;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ForwardType ForwardType {
    get { return forwardType_; }
    set {
      forwardType_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 1;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  /// <summary>Field number for the "is_server_cache" field.</summary>
  public const int IsServerCacheFieldNumber = 3;
  private bool isServerCache_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsServerCache {
    get { return isServerCache_; }
    set {
      isServerCache_ = value;
    }
  }

  /// <summary>Field number for the "renderer_changed_info" field.</summary>
  public const int RendererChangedInfoFieldNumber = 15;
  private global::EntityRendererChangedInfo rendererChangedInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::EntityRendererChangedInfo RendererChangedInfo {
    get { return rendererChangedInfo_; }
    set {
      rendererChangedInfo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EvtEntityRenderersChangedNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EvtEntityRenderersChangedNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ForwardType != other.ForwardType) return false;
    if (EntityId != other.EntityId) return false;
    if (IsServerCache != other.IsServerCache) return false;
    if (!object.Equals(RendererChangedInfo, other.RendererChangedInfo)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ForwardType != global::ForwardType.Local) hash ^= ForwardType.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (IsServerCache != false) hash ^= IsServerCache.GetHashCode();
    if (rendererChangedInfo_ != null) hash ^= RendererChangedInfo.GetHashCode();
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
    if (EntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(EntityId);
    }
    if (IsServerCache != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsServerCache);
    }
    if (ForwardType != global::ForwardType.Local) {
      output.WriteRawTag(40);
      output.WriteEnum((int) ForwardType);
    }
    if (rendererChangedInfo_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(RendererChangedInfo);
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
    if (EntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(EntityId);
    }
    if (IsServerCache != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsServerCache);
    }
    if (ForwardType != global::ForwardType.Local) {
      output.WriteRawTag(40);
      output.WriteEnum((int) ForwardType);
    }
    if (rendererChangedInfo_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(RendererChangedInfo);
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
    if (ForwardType != global::ForwardType.Local) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (IsServerCache != false) {
      size += 1 + 1;
    }
    if (rendererChangedInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RendererChangedInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EvtEntityRenderersChangedNotify other) {
    if (other == null) {
      return;
    }
    if (other.ForwardType != global::ForwardType.Local) {
      ForwardType = other.ForwardType;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.IsServerCache != false) {
      IsServerCache = other.IsServerCache;
    }
    if (other.rendererChangedInfo_ != null) {
      if (rendererChangedInfo_ == null) {
        RendererChangedInfo = new global::EntityRendererChangedInfo();
      }
      RendererChangedInfo.MergeFrom(other.RendererChangedInfo);
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
          EntityId = input.ReadUInt32();
          break;
        }
        case 24: {
          IsServerCache = input.ReadBool();
          break;
        }
        case 40: {
          ForwardType = (global::ForwardType) input.ReadEnum();
          break;
        }
        case 122: {
          if (rendererChangedInfo_ == null) {
            RendererChangedInfo = new global::EntityRendererChangedInfo();
          }
          input.ReadMessage(RendererChangedInfo);
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
          EntityId = input.ReadUInt32();
          break;
        }
        case 24: {
          IsServerCache = input.ReadBool();
          break;
        }
        case 40: {
          ForwardType = (global::ForwardType) input.ReadEnum();
          break;
        }
        case 122: {
          if (rendererChangedInfo_ == null) {
            RendererChangedInfo = new global::EntityRendererChangedInfo();
          }
          input.ReadMessage(RendererChangedInfo);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
