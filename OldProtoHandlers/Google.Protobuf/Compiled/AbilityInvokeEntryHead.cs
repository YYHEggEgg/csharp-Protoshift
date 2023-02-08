// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityInvokeEntryHead.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AbilityInvokeEntryHead.proto</summary>
  public static partial class AbilityInvokeEntryHeadReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityInvokeEntryHead.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityInvokeEntryHeadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxBYmlsaXR5SW52b2tlRW50cnlIZWFkLnByb3RvItUBChZBYmlsaXR5SW52",
            "b2tlRW50cnlIZWFkEiAKGG1vZGlmaWVyX2NvbmZpZ19sb2NhbF9pZBgHIAEo",
            "BRIeChZpc19zZXJ2ZXJidWZmX21vZGlmaWVyGAIgASgIEhwKFGluc3RhbmNl",
            "ZF9hYmlsaXR5X2lkGAEgASgNEh0KFWluc3RhbmNlZF9tb2RpZmllcl9pZBgM",
            "IAEoDRIQCghsb2NhbF9pZBgKIAEoBRIXCg9zZXJ2ZXJfYnVmZl91aWQYDiAB",
            "KA0SEQoJdGFyZ2V0X2lkGAMgASgNQgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AbilityInvokeEntryHead), global::OldProtos.AbilityInvokeEntryHead.Parser, new[]{ "ModifierConfigLocalId", "IsServerbuffModifier", "InstancedAbilityId", "InstancedModifierId", "LocalId", "ServerBuffUid", "TargetId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityInvokeEntryHead : pb::IMessage<AbilityInvokeEntryHead>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityInvokeEntryHead> _parser = new pb::MessageParser<AbilityInvokeEntryHead>(() => new AbilityInvokeEntryHead());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityInvokeEntryHead> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.AbilityInvokeEntryHeadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntryHead() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntryHead(AbilityInvokeEntryHead other) : this() {
      modifierConfigLocalId_ = other.modifierConfigLocalId_;
      isServerbuffModifier_ = other.isServerbuffModifier_;
      instancedAbilityId_ = other.instancedAbilityId_;
      instancedModifierId_ = other.instancedModifierId_;
      localId_ = other.localId_;
      serverBuffUid_ = other.serverBuffUid_;
      targetId_ = other.targetId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntryHead Clone() {
      return new AbilityInvokeEntryHead(this);
    }

    /// <summary>Field number for the "modifier_config_local_id" field.</summary>
    public const int ModifierConfigLocalIdFieldNumber = 7;
    private int modifierConfigLocalId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ModifierConfigLocalId {
      get { return modifierConfigLocalId_; }
      set {
        modifierConfigLocalId_ = value;
      }
    }

    /// <summary>Field number for the "is_serverbuff_modifier" field.</summary>
    public const int IsServerbuffModifierFieldNumber = 2;
    private bool isServerbuffModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsServerbuffModifier {
      get { return isServerbuffModifier_; }
      set {
        isServerbuffModifier_ = value;
      }
    }

    /// <summary>Field number for the "instanced_ability_id" field.</summary>
    public const int InstancedAbilityIdFieldNumber = 1;
    private uint instancedAbilityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedAbilityId {
      get { return instancedAbilityId_; }
      set {
        instancedAbilityId_ = value;
      }
    }

    /// <summary>Field number for the "instanced_modifier_id" field.</summary>
    public const int InstancedModifierIdFieldNumber = 12;
    private uint instancedModifierId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedModifierId {
      get { return instancedModifierId_; }
      set {
        instancedModifierId_ = value;
      }
    }

    /// <summary>Field number for the "local_id" field.</summary>
    public const int LocalIdFieldNumber = 10;
    private int localId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LocalId {
      get { return localId_; }
      set {
        localId_ = value;
      }
    }

    /// <summary>Field number for the "server_buff_uid" field.</summary>
    public const int ServerBuffUidFieldNumber = 14;
    private uint serverBuffUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ServerBuffUid {
      get { return serverBuffUid_; }
      set {
        serverBuffUid_ = value;
      }
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 3;
    private uint targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityInvokeEntryHead);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityInvokeEntryHead other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModifierConfigLocalId != other.ModifierConfigLocalId) return false;
      if (IsServerbuffModifier != other.IsServerbuffModifier) return false;
      if (InstancedAbilityId != other.InstancedAbilityId) return false;
      if (InstancedModifierId != other.InstancedModifierId) return false;
      if (LocalId != other.LocalId) return false;
      if (ServerBuffUid != other.ServerBuffUid) return false;
      if (TargetId != other.TargetId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ModifierConfigLocalId != 0) hash ^= ModifierConfigLocalId.GetHashCode();
      if (IsServerbuffModifier != false) hash ^= IsServerbuffModifier.GetHashCode();
      if (InstancedAbilityId != 0) hash ^= InstancedAbilityId.GetHashCode();
      if (InstancedModifierId != 0) hash ^= InstancedModifierId.GetHashCode();
      if (LocalId != 0) hash ^= LocalId.GetHashCode();
      if (ServerBuffUid != 0) hash ^= ServerBuffUid.GetHashCode();
      if (TargetId != 0) hash ^= TargetId.GetHashCode();
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
      if (InstancedAbilityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(InstancedAbilityId);
      }
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsServerbuffModifier);
      }
      if (TargetId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetId);
      }
      if (ModifierConfigLocalId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ModifierConfigLocalId);
      }
      if (LocalId != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(LocalId);
      }
      if (InstancedModifierId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(InstancedModifierId);
      }
      if (ServerBuffUid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ServerBuffUid);
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
      if (InstancedAbilityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(InstancedAbilityId);
      }
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsServerbuffModifier);
      }
      if (TargetId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetId);
      }
      if (ModifierConfigLocalId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(ModifierConfigLocalId);
      }
      if (LocalId != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(LocalId);
      }
      if (InstancedModifierId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(InstancedModifierId);
      }
      if (ServerBuffUid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ServerBuffUid);
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
      if (ModifierConfigLocalId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ModifierConfigLocalId);
      }
      if (IsServerbuffModifier != false) {
        size += 1 + 1;
      }
      if (InstancedAbilityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedAbilityId);
      }
      if (InstancedModifierId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedModifierId);
      }
      if (LocalId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LocalId);
      }
      if (ServerBuffUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ServerBuffUid);
      }
      if (TargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityInvokeEntryHead other) {
      if (other == null) {
        return;
      }
      if (other.ModifierConfigLocalId != 0) {
        ModifierConfigLocalId = other.ModifierConfigLocalId;
      }
      if (other.IsServerbuffModifier != false) {
        IsServerbuffModifier = other.IsServerbuffModifier;
      }
      if (other.InstancedAbilityId != 0) {
        InstancedAbilityId = other.InstancedAbilityId;
      }
      if (other.InstancedModifierId != 0) {
        InstancedModifierId = other.InstancedModifierId;
      }
      if (other.LocalId != 0) {
        LocalId = other.LocalId;
      }
      if (other.ServerBuffUid != 0) {
        ServerBuffUid = other.ServerBuffUid;
      }
      if (other.TargetId != 0) {
        TargetId = other.TargetId;
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
            InstancedAbilityId = input.ReadUInt32();
            break;
          }
          case 16: {
            IsServerbuffModifier = input.ReadBool();
            break;
          }
          case 24: {
            TargetId = input.ReadUInt32();
            break;
          }
          case 56: {
            ModifierConfigLocalId = input.ReadInt32();
            break;
          }
          case 80: {
            LocalId = input.ReadInt32();
            break;
          }
          case 96: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 112: {
            ServerBuffUid = input.ReadUInt32();
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
            InstancedAbilityId = input.ReadUInt32();
            break;
          }
          case 16: {
            IsServerbuffModifier = input.ReadBool();
            break;
          }
          case 24: {
            TargetId = input.ReadUInt32();
            break;
          }
          case 56: {
            ModifierConfigLocalId = input.ReadInt32();
            break;
          }
          case 80: {
            LocalId = input.ReadInt32();
            break;
          }
          case 96: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 112: {
            ServerBuffUid = input.ReadUInt32();
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
