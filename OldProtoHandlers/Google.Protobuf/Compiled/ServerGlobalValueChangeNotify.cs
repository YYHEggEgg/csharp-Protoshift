// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerGlobalValueChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ServerGlobalValueChangeNotify.proto</summary>
public static partial class ServerGlobalValueChangeNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ServerGlobalValueChangeNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ServerGlobalValueChangeNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNTZXJ2ZXJHbG9iYWxWYWx1ZUNoYW5nZU5vdGlmeS5wcm90byJTCh1TZXJ2",
          "ZXJHbG9iYWxWYWx1ZUNoYW5nZU5vdGlmeRIRCgllbnRpdHlfaWQYBiABKA0S",
          "DQoFdmFsdWUYDCABKAISEAoIa2V5X2hhc2gYDSABKA1CHgocZW11LmdyYXNz",
          "Y3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ServerGlobalValueChangeNotify), global::ServerGlobalValueChangeNotify.Parser, new[]{ "EntityId", "Value", "KeyHash" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 1197
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ServerGlobalValueChangeNotify : pb::IMessage<ServerGlobalValueChangeNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ServerGlobalValueChangeNotify> _parser = new pb::MessageParser<ServerGlobalValueChangeNotify>(() => new ServerGlobalValueChangeNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ServerGlobalValueChangeNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ServerGlobalValueChangeNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerGlobalValueChangeNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerGlobalValueChangeNotify(ServerGlobalValueChangeNotify other) : this() {
    entityId_ = other.entityId_;
    value_ = other.value_;
    keyHash_ = other.keyHash_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerGlobalValueChangeNotify Clone() {
    return new ServerGlobalValueChangeNotify(this);
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 6;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  /// <summary>Field number for the "value" field.</summary>
  public const int ValueFieldNumber = 12;
  private float value_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Value {
    get { return value_; }
    set {
      value_ = value;
    }
  }

  /// <summary>Field number for the "key_hash" field.</summary>
  public const int KeyHashFieldNumber = 13;
  private uint keyHash_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint KeyHash {
    get { return keyHash_; }
    set {
      keyHash_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ServerGlobalValueChangeNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ServerGlobalValueChangeNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EntityId != other.EntityId) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Value, other.Value)) return false;
    if (KeyHash != other.KeyHash) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    if (Value != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Value);
    if (KeyHash != 0) hash ^= KeyHash.GetHashCode();
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
      output.WriteRawTag(48);
      output.WriteUInt32(EntityId);
    }
    if (Value != 0F) {
      output.WriteRawTag(101);
      output.WriteFloat(Value);
    }
    if (KeyHash != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(KeyHash);
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
      output.WriteRawTag(48);
      output.WriteUInt32(EntityId);
    }
    if (Value != 0F) {
      output.WriteRawTag(101);
      output.WriteFloat(Value);
    }
    if (KeyHash != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(KeyHash);
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
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    if (Value != 0F) {
      size += 1 + 4;
    }
    if (KeyHash != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KeyHash);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ServerGlobalValueChangeNotify other) {
    if (other == null) {
      return;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    if (other.Value != 0F) {
      Value = other.Value;
    }
    if (other.KeyHash != 0) {
      KeyHash = other.KeyHash;
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
        case 48: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 101: {
          Value = input.ReadFloat();
          break;
        }
        case 104: {
          KeyHash = input.ReadUInt32();
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
        case 48: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 101: {
          Value = input.ReadFloat();
          break;
        }
        case 104: {
          KeyHash = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
