// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityAiSyncNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from EntityAiSyncNotify.proto</summary>
  public static partial class EntityAiSyncNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EntityAiSyncNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityAiSyncNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhFbnRpdHlBaVN5bmNOb3RpZnkucHJvdG8aEEFpU3luY0luZm8ucHJvdG8i",
            "XwoSRW50aXR5QWlTeW5jTm90aWZ5Eh4KCWluZm9fbGlzdBgOIAMoCzILLkFp",
            "U3luY0luZm8SKQohbG9jYWxfYXZhdGFyX2FsZXJ0ZWRfbW9uc3Rlcl9saXN0",
            "GA0gAygNQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.AiSyncInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.EntityAiSyncNotify), global::NewProtos.EntityAiSyncNotify.Parser, new[]{ "InfoList", "LocalAvatarAlertedMonsterList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 304;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class EntityAiSyncNotify : pb::IMessage<EntityAiSyncNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityAiSyncNotify> _parser = new pb::MessageParser<EntityAiSyncNotify>(() => new EntityAiSyncNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityAiSyncNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.EntityAiSyncNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAiSyncNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAiSyncNotify(EntityAiSyncNotify other) : this() {
      infoList_ = other.infoList_.Clone();
      localAvatarAlertedMonsterList_ = other.localAvatarAlertedMonsterList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityAiSyncNotify Clone() {
      return new EntityAiSyncNotify(this);
    }

    /// <summary>Field number for the "info_list" field.</summary>
    public const int InfoListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::NewProtos.AiSyncInfo> _repeated_infoList_codec
        = pb::FieldCodec.ForMessage(114, global::NewProtos.AiSyncInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.AiSyncInfo> infoList_ = new pbc::RepeatedField<global::NewProtos.AiSyncInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.AiSyncInfo> InfoList {
      get { return infoList_; }
    }

    /// <summary>Field number for the "local_avatar_alerted_monster_list" field.</summary>
    public const int LocalAvatarAlertedMonsterListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_localAvatarAlertedMonsterList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> localAvatarAlertedMonsterList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LocalAvatarAlertedMonsterList {
      get { return localAvatarAlertedMonsterList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityAiSyncNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityAiSyncNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!infoList_.Equals(other.infoList_)) return false;
      if(!localAvatarAlertedMonsterList_.Equals(other.localAvatarAlertedMonsterList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= infoList_.GetHashCode();
      hash ^= localAvatarAlertedMonsterList_.GetHashCode();
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
      localAvatarAlertedMonsterList_.WriteTo(output, _repeated_localAvatarAlertedMonsterList_codec);
      infoList_.WriteTo(output, _repeated_infoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      localAvatarAlertedMonsterList_.WriteTo(ref output, _repeated_localAvatarAlertedMonsterList_codec);
      infoList_.WriteTo(ref output, _repeated_infoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += infoList_.CalculateSize(_repeated_infoList_codec);
      size += localAvatarAlertedMonsterList_.CalculateSize(_repeated_localAvatarAlertedMonsterList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityAiSyncNotify other) {
      if (other == null) {
        return;
      }
      infoList_.Add(other.infoList_);
      localAvatarAlertedMonsterList_.Add(other.localAvatarAlertedMonsterList_);
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
          case 106:
          case 104: {
            localAvatarAlertedMonsterList_.AddEntriesFrom(input, _repeated_localAvatarAlertedMonsterList_codec);
            break;
          }
          case 114: {
            infoList_.AddEntriesFrom(input, _repeated_infoList_codec);
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
          case 106:
          case 104: {
            localAvatarAlertedMonsterList_.AddEntriesFrom(ref input, _repeated_localAvatarAlertedMonsterList_codec);
            break;
          }
          case 114: {
            infoList_.AddEntriesFrom(ref input, _repeated_infoList_codec);
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