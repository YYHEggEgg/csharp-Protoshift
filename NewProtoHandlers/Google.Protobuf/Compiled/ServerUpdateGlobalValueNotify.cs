// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerUpdateGlobalValueNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ServerUpdateGlobalValueNotify.proto</summary>
public static partial class ServerUpdateGlobalValueNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ServerUpdateGlobalValueNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ServerUpdateGlobalValueNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNTZXJ2ZXJVcGRhdGVHbG9iYWxWYWx1ZU5vdGlmeS5wcm90byLzAQodU2Vy",
          "dmVyVXBkYXRlR2xvYmFsVmFsdWVOb3RpZnkSEAoIa2V5X2hhc2gYCCABKA0S",
          "PgoLdXBkYXRlX3R5cGUYCSABKA4yKS5TZXJ2ZXJVcGRhdGVHbG9iYWxWYWx1",
          "ZU5vdGlmeS5VcGRhdGVUeXBlEg0KBWRlbHRhGAYgASgCEg0KBXZhbHVlGAMg",
          "ASgCEhEKCWVudGl0eV9pZBgPIAEoDSJPCgpVcGRhdGVUeXBlEhcKE1VQREFU",
          "RV9UWVBFX0lOVkFMSUQQABITCg9VUERBVEVfVFlQRV9BREQQARITCg9VUERB",
          "VEVfVFlQRV9TRVQQAkIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ServerUpdateGlobalValueNotify), global::ServerUpdateGlobalValueNotify.Parser, new[]{ "KeyHash", "UpdateType", "Delta", "Value", "EntityId" }, null, new[]{ typeof(global::ServerUpdateGlobalValueNotify.Types.UpdateType) }, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 1148;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class ServerUpdateGlobalValueNotify : pb::IMessage<ServerUpdateGlobalValueNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ServerUpdateGlobalValueNotify> _parser = new pb::MessageParser<ServerUpdateGlobalValueNotify>(() => new ServerUpdateGlobalValueNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ServerUpdateGlobalValueNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ServerUpdateGlobalValueNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerUpdateGlobalValueNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerUpdateGlobalValueNotify(ServerUpdateGlobalValueNotify other) : this() {
    keyHash_ = other.keyHash_;
    updateType_ = other.updateType_;
    delta_ = other.delta_;
    value_ = other.value_;
    entityId_ = other.entityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerUpdateGlobalValueNotify Clone() {
    return new ServerUpdateGlobalValueNotify(this);
  }

  /// <summary>Field number for the "key_hash" field.</summary>
  public const int KeyHashFieldNumber = 8;
  private uint keyHash_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint KeyHash {
    get { return keyHash_; }
    set {
      keyHash_ = value;
    }
  }

  /// <summary>Field number for the "update_type" field.</summary>
  public const int UpdateTypeFieldNumber = 9;
  private global::ServerUpdateGlobalValueNotify.Types.UpdateType updateType_ = global::ServerUpdateGlobalValueNotify.Types.UpdateType.Invalid;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ServerUpdateGlobalValueNotify.Types.UpdateType UpdateType {
    get { return updateType_; }
    set {
      updateType_ = value;
    }
  }

  /// <summary>Field number for the "delta" field.</summary>
  public const int DeltaFieldNumber = 6;
  private float delta_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Delta {
    get { return delta_; }
    set {
      delta_ = value;
    }
  }

  /// <summary>Field number for the "value" field.</summary>
  public const int ValueFieldNumber = 3;
  private float value_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Value {
    get { return value_; }
    set {
      value_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 15;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ServerUpdateGlobalValueNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ServerUpdateGlobalValueNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (KeyHash != other.KeyHash) return false;
    if (UpdateType != other.UpdateType) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Delta, other.Delta)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Value, other.Value)) return false;
    if (EntityId != other.EntityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (KeyHash != 0) hash ^= KeyHash.GetHashCode();
    if (UpdateType != global::ServerUpdateGlobalValueNotify.Types.UpdateType.Invalid) hash ^= UpdateType.GetHashCode();
    if (Delta != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Delta);
    if (Value != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Value);
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
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
    if (Value != 0F) {
      output.WriteRawTag(29);
      output.WriteFloat(Value);
    }
    if (Delta != 0F) {
      output.WriteRawTag(53);
      output.WriteFloat(Delta);
    }
    if (KeyHash != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(KeyHash);
    }
    if (UpdateType != global::ServerUpdateGlobalValueNotify.Types.UpdateType.Invalid) {
      output.WriteRawTag(72);
      output.WriteEnum((int) UpdateType);
    }
    if (EntityId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(EntityId);
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
    if (Value != 0F) {
      output.WriteRawTag(29);
      output.WriteFloat(Value);
    }
    if (Delta != 0F) {
      output.WriteRawTag(53);
      output.WriteFloat(Delta);
    }
    if (KeyHash != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(KeyHash);
    }
    if (UpdateType != global::ServerUpdateGlobalValueNotify.Types.UpdateType.Invalid) {
      output.WriteRawTag(72);
      output.WriteEnum((int) UpdateType);
    }
    if (EntityId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(EntityId);
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
    if (KeyHash != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KeyHash);
    }
    if (UpdateType != global::ServerUpdateGlobalValueNotify.Types.UpdateType.Invalid) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UpdateType);
    }
    if (Delta != 0F) {
      size += 1 + 4;
    }
    if (Value != 0F) {
      size += 1 + 4;
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ServerUpdateGlobalValueNotify other) {
    if (other == null) {
      return;
    }
    if (other.KeyHash != 0) {
      KeyHash = other.KeyHash;
    }
    if (other.UpdateType != global::ServerUpdateGlobalValueNotify.Types.UpdateType.Invalid) {
      UpdateType = other.UpdateType;
    }
    if (other.Delta != 0F) {
      Delta = other.Delta;
    }
    if (other.Value != 0F) {
      Value = other.Value;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
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
        case 29: {
          Value = input.ReadFloat();
          break;
        }
        case 53: {
          Delta = input.ReadFloat();
          break;
        }
        case 64: {
          KeyHash = input.ReadUInt32();
          break;
        }
        case 72: {
          UpdateType = (global::ServerUpdateGlobalValueNotify.Types.UpdateType) input.ReadEnum();
          break;
        }
        case 120: {
          EntityId = input.ReadUInt32();
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
        case 29: {
          Value = input.ReadFloat();
          break;
        }
        case 53: {
          Delta = input.ReadFloat();
          break;
        }
        case 64: {
          KeyHash = input.ReadUInt32();
          break;
        }
        case 72: {
          UpdateType = (global::ServerUpdateGlobalValueNotify.Types.UpdateType) input.ReadEnum();
          break;
        }
        case 120: {
          EntityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the ServerUpdateGlobalValueNotify message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum UpdateType {
      [pbr::OriginalName("UPDATE_TYPE_INVALID")] Invalid = 0,
      [pbr::OriginalName("UPDATE_TYPE_ADD")] Add = 1,
      [pbr::OriginalName("UPDATE_TYPE_SET")] Set = 2,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
