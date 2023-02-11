// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityConfigHashNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from EntityConfigHashNotify.proto</summary>
  public static partial class EntityConfigHashNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EntityConfigHashNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityConfigHashNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxFbnRpdHlDb25maWdIYXNoTm90aWZ5LnByb3RvGhtFbnRpdHlDb25maWdI",
            "YXNoRW50cnkucHJvdG8isgEKFkVudGl0eUNvbmZpZ0hhc2hOb3RpZnkSMQoR",
            "YXZhdGFyX2VudHJ5X2xpc3QYASADKAsyFi5FbnRpdHlDb25maWdIYXNoRW50",
            "cnkSMQoRY29tYmF0X2VudHJ5X2xpc3QYAiADKAsyFi5FbnRpdHlDb25maWdI",
            "YXNoRW50cnkSMgoSYWJpbGl0eV9lbnRyeV9saXN0GAkgAygLMhYuRW50aXR5",
            "Q29uZmlnSGFzaEVudHJ5QgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.EntityConfigHashEntryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.EntityConfigHashNotify), global::NewProtos.EntityConfigHashNotify.Parser, new[]{ "AvatarEntryList", "CombatEntryList", "AbilityEntryList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3332;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class EntityConfigHashNotify : pb::IMessage<EntityConfigHashNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityConfigHashNotify> _parser = new pb::MessageParser<EntityConfigHashNotify>(() => new EntityConfigHashNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityConfigHashNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.EntityConfigHashNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityConfigHashNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityConfigHashNotify(EntityConfigHashNotify other) : this() {
      avatarEntryList_ = other.avatarEntryList_.Clone();
      combatEntryList_ = other.combatEntryList_.Clone();
      abilityEntryList_ = other.abilityEntryList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityConfigHashNotify Clone() {
      return new EntityConfigHashNotify(this);
    }

    /// <summary>Field number for the "avatar_entry_list" field.</summary>
    public const int AvatarEntryListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::NewProtos.EntityConfigHashEntry> _repeated_avatarEntryList_codec
        = pb::FieldCodec.ForMessage(10, global::NewProtos.EntityConfigHashEntry.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry> avatarEntryList_ = new pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry> AvatarEntryList {
      get { return avatarEntryList_; }
    }

    /// <summary>Field number for the "combat_entry_list" field.</summary>
    public const int CombatEntryListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::NewProtos.EntityConfigHashEntry> _repeated_combatEntryList_codec
        = pb::FieldCodec.ForMessage(18, global::NewProtos.EntityConfigHashEntry.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry> combatEntryList_ = new pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry> CombatEntryList {
      get { return combatEntryList_; }
    }

    /// <summary>Field number for the "ability_entry_list" field.</summary>
    public const int AbilityEntryListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::NewProtos.EntityConfigHashEntry> _repeated_abilityEntryList_codec
        = pb::FieldCodec.ForMessage(74, global::NewProtos.EntityConfigHashEntry.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry> abilityEntryList_ = new pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.EntityConfigHashEntry> AbilityEntryList {
      get { return abilityEntryList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityConfigHashNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityConfigHashNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarEntryList_.Equals(other.avatarEntryList_)) return false;
      if(!combatEntryList_.Equals(other.combatEntryList_)) return false;
      if(!abilityEntryList_.Equals(other.abilityEntryList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarEntryList_.GetHashCode();
      hash ^= combatEntryList_.GetHashCode();
      hash ^= abilityEntryList_.GetHashCode();
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
      avatarEntryList_.WriteTo(output, _repeated_avatarEntryList_codec);
      combatEntryList_.WriteTo(output, _repeated_combatEntryList_codec);
      abilityEntryList_.WriteTo(output, _repeated_abilityEntryList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      avatarEntryList_.WriteTo(ref output, _repeated_avatarEntryList_codec);
      combatEntryList_.WriteTo(ref output, _repeated_combatEntryList_codec);
      abilityEntryList_.WriteTo(ref output, _repeated_abilityEntryList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += avatarEntryList_.CalculateSize(_repeated_avatarEntryList_codec);
      size += combatEntryList_.CalculateSize(_repeated_combatEntryList_codec);
      size += abilityEntryList_.CalculateSize(_repeated_abilityEntryList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityConfigHashNotify other) {
      if (other == null) {
        return;
      }
      avatarEntryList_.Add(other.avatarEntryList_);
      combatEntryList_.Add(other.combatEntryList_);
      abilityEntryList_.Add(other.abilityEntryList_);
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
          case 10: {
            avatarEntryList_.AddEntriesFrom(input, _repeated_avatarEntryList_codec);
            break;
          }
          case 18: {
            combatEntryList_.AddEntriesFrom(input, _repeated_combatEntryList_codec);
            break;
          }
          case 74: {
            abilityEntryList_.AddEntriesFrom(input, _repeated_abilityEntryList_codec);
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
          case 10: {
            avatarEntryList_.AddEntriesFrom(ref input, _repeated_avatarEntryList_codec);
            break;
          }
          case 18: {
            combatEntryList_.AddEntriesFrom(ref input, _repeated_combatEntryList_codec);
            break;
          }
          case 74: {
            abilityEntryList_.AddEntriesFrom(ref input, _repeated_abilityEntryList_codec);
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