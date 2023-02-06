// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityAppliedModifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AbilityAppliedModifier.proto</summary>
public static partial class AbilityAppliedModifierReflection {

  #region Descriptor
  /// <summary>File descriptor for AbilityAppliedModifier.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AbilityAppliedModifierReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxBYmlsaXR5QXBwbGllZE1vZGlmaWVyLnByb3RvGh1BYmlsaXR5QXR0YWNo",
          "ZWRNb2RpZmllci5wcm90bxoTQWJpbGl0eVN0cmluZy5wcm90bxoYTW9kaWZp",
          "ZXJEdXJhYmlsaXR5LnByb3RvIukDChZBYmlsaXR5QXBwbGllZE1vZGlmaWVy",
          "EhkKEW1vZGlmaWVyX2xvY2FsX2lkGAEgASgFEiAKGHBhcmVudF9hYmlsaXR5",
          "X2VudGl0eV9pZBgCIAEoDRIrChNwYXJlbnRfYWJpbGl0eV9uYW1lGAMgASgL",
          "Mg4uQWJpbGl0eVN0cmluZxIvChdwYXJlbnRfYWJpbGl0eV9vdmVycmlkZRgE",
          "IAEoCzIOLkFiaWxpdHlTdHJpbmcSHAoUaW5zdGFuY2VkX2FiaWxpdHlfaWQY",
          "BSABKA0SHQoVaW5zdGFuY2VkX21vZGlmaWVyX2lkGAYgASgNEhYKDmV4aXN0",
          "X2R1cmF0aW9uGAcgASgCEj0KG2F0dGFjaGVkX2luc3RhbmNlZF9tb2RpZmll",
          "chgIIAEoCzIYLkFiaWxpdHlBdHRhY2hlZE1vZGlmaWVyEhcKD2FwcGx5X2Vu",
          "dGl0eV9pZBgJIAEoDRIiChppc19hdHRhY2hlZF9wYXJlbnRfYWJpbGl0eRgK",
          "IAEoCBIwChNtb2RpZmllcl9kdXJhYmlsaXR5GAsgASgLMhMuTW9kaWZpZXJE",
          "dXJhYmlsaXR5EhEKCXNidWZmX3VpZBgMIAEoDRIeChZpc19zZXJ2ZXJidWZm",
          "X21vZGlmaWVyGA0gASgIQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::AbilityAttachedModifierReflection.Descriptor, global::AbilityStringReflection.Descriptor, global::ModifierDurabilityReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AbilityAppliedModifier), global::AbilityAppliedModifier.Parser, new[]{ "ModifierLocalId", "ParentAbilityEntityId", "ParentAbilityName", "ParentAbilityOverride", "InstancedAbilityId", "InstancedModifierId", "ExistDuration", "AttachedInstancedModifier", "ApplyEntityId", "IsAttachedParentAbility", "ModifierDurability", "SbuffUid", "IsServerbuffModifier" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AbilityAppliedModifier : pb::IMessage<AbilityAppliedModifier>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AbilityAppliedModifier> _parser = new pb::MessageParser<AbilityAppliedModifier>(() => new AbilityAppliedModifier());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AbilityAppliedModifier> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AbilityAppliedModifierReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityAppliedModifier() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityAppliedModifier(AbilityAppliedModifier other) : this() {
    modifierLocalId_ = other.modifierLocalId_;
    parentAbilityEntityId_ = other.parentAbilityEntityId_;
    parentAbilityName_ = other.parentAbilityName_ != null ? other.parentAbilityName_.Clone() : null;
    parentAbilityOverride_ = other.parentAbilityOverride_ != null ? other.parentAbilityOverride_.Clone() : null;
    instancedAbilityId_ = other.instancedAbilityId_;
    instancedModifierId_ = other.instancedModifierId_;
    existDuration_ = other.existDuration_;
    attachedInstancedModifier_ = other.attachedInstancedModifier_ != null ? other.attachedInstancedModifier_.Clone() : null;
    applyEntityId_ = other.applyEntityId_;
    isAttachedParentAbility_ = other.isAttachedParentAbility_;
    modifierDurability_ = other.modifierDurability_ != null ? other.modifierDurability_.Clone() : null;
    sbuffUid_ = other.sbuffUid_;
    isServerbuffModifier_ = other.isServerbuffModifier_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityAppliedModifier Clone() {
    return new AbilityAppliedModifier(this);
  }

  /// <summary>Field number for the "modifier_local_id" field.</summary>
  public const int ModifierLocalIdFieldNumber = 1;
  private int modifierLocalId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int ModifierLocalId {
    get { return modifierLocalId_; }
    set {
      modifierLocalId_ = value;
    }
  }

  /// <summary>Field number for the "parent_ability_entity_id" field.</summary>
  public const int ParentAbilityEntityIdFieldNumber = 2;
  private uint parentAbilityEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ParentAbilityEntityId {
    get { return parentAbilityEntityId_; }
    set {
      parentAbilityEntityId_ = value;
    }
  }

  /// <summary>Field number for the "parent_ability_name" field.</summary>
  public const int ParentAbilityNameFieldNumber = 3;
  private global::AbilityString parentAbilityName_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AbilityString ParentAbilityName {
    get { return parentAbilityName_; }
    set {
      parentAbilityName_ = value;
    }
  }

  /// <summary>Field number for the "parent_ability_override" field.</summary>
  public const int ParentAbilityOverrideFieldNumber = 4;
  private global::AbilityString parentAbilityOverride_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AbilityString ParentAbilityOverride {
    get { return parentAbilityOverride_; }
    set {
      parentAbilityOverride_ = value;
    }
  }

  /// <summary>Field number for the "instanced_ability_id" field.</summary>
  public const int InstancedAbilityIdFieldNumber = 5;
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
  public const int InstancedModifierIdFieldNumber = 6;
  private uint instancedModifierId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint InstancedModifierId {
    get { return instancedModifierId_; }
    set {
      instancedModifierId_ = value;
    }
  }

  /// <summary>Field number for the "exist_duration" field.</summary>
  public const int ExistDurationFieldNumber = 7;
  private float existDuration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float ExistDuration {
    get { return existDuration_; }
    set {
      existDuration_ = value;
    }
  }

  /// <summary>Field number for the "attached_instanced_modifier" field.</summary>
  public const int AttachedInstancedModifierFieldNumber = 8;
  private global::AbilityAttachedModifier attachedInstancedModifier_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AbilityAttachedModifier AttachedInstancedModifier {
    get { return attachedInstancedModifier_; }
    set {
      attachedInstancedModifier_ = value;
    }
  }

  /// <summary>Field number for the "apply_entity_id" field.</summary>
  public const int ApplyEntityIdFieldNumber = 9;
  private uint applyEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ApplyEntityId {
    get { return applyEntityId_; }
    set {
      applyEntityId_ = value;
    }
  }

  /// <summary>Field number for the "is_attached_parent_ability" field.</summary>
  public const int IsAttachedParentAbilityFieldNumber = 10;
  private bool isAttachedParentAbility_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsAttachedParentAbility {
    get { return isAttachedParentAbility_; }
    set {
      isAttachedParentAbility_ = value;
    }
  }

  /// <summary>Field number for the "modifier_durability" field.</summary>
  public const int ModifierDurabilityFieldNumber = 11;
  private global::ModifierDurability modifierDurability_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ModifierDurability ModifierDurability {
    get { return modifierDurability_; }
    set {
      modifierDurability_ = value;
    }
  }

  /// <summary>Field number for the "sbuff_uid" field.</summary>
  public const int SbuffUidFieldNumber = 12;
  private uint sbuffUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SbuffUid {
    get { return sbuffUid_; }
    set {
      sbuffUid_ = value;
    }
  }

  /// <summary>Field number for the "is_serverbuff_modifier" field.</summary>
  public const int IsServerbuffModifierFieldNumber = 13;
  private bool isServerbuffModifier_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsServerbuffModifier {
    get { return isServerbuffModifier_; }
    set {
      isServerbuffModifier_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AbilityAppliedModifier);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AbilityAppliedModifier other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ModifierLocalId != other.ModifierLocalId) return false;
    if (ParentAbilityEntityId != other.ParentAbilityEntityId) return false;
    if (!object.Equals(ParentAbilityName, other.ParentAbilityName)) return false;
    if (!object.Equals(ParentAbilityOverride, other.ParentAbilityOverride)) return false;
    if (InstancedAbilityId != other.InstancedAbilityId) return false;
    if (InstancedModifierId != other.InstancedModifierId) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExistDuration, other.ExistDuration)) return false;
    if (!object.Equals(AttachedInstancedModifier, other.AttachedInstancedModifier)) return false;
    if (ApplyEntityId != other.ApplyEntityId) return false;
    if (IsAttachedParentAbility != other.IsAttachedParentAbility) return false;
    if (!object.Equals(ModifierDurability, other.ModifierDurability)) return false;
    if (SbuffUid != other.SbuffUid) return false;
    if (IsServerbuffModifier != other.IsServerbuffModifier) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ModifierLocalId != 0) hash ^= ModifierLocalId.GetHashCode();
    if (ParentAbilityEntityId != 0) hash ^= ParentAbilityEntityId.GetHashCode();
    if (parentAbilityName_ != null) hash ^= ParentAbilityName.GetHashCode();
    if (parentAbilityOverride_ != null) hash ^= ParentAbilityOverride.GetHashCode();
    if (InstancedAbilityId != 0) hash ^= InstancedAbilityId.GetHashCode();
    if (InstancedModifierId != 0) hash ^= InstancedModifierId.GetHashCode();
    if (ExistDuration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExistDuration);
    if (attachedInstancedModifier_ != null) hash ^= AttachedInstancedModifier.GetHashCode();
    if (ApplyEntityId != 0) hash ^= ApplyEntityId.GetHashCode();
    if (IsAttachedParentAbility != false) hash ^= IsAttachedParentAbility.GetHashCode();
    if (modifierDurability_ != null) hash ^= ModifierDurability.GetHashCode();
    if (SbuffUid != 0) hash ^= SbuffUid.GetHashCode();
    if (IsServerbuffModifier != false) hash ^= IsServerbuffModifier.GetHashCode();
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
    if (ModifierLocalId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(ModifierLocalId);
    }
    if (ParentAbilityEntityId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ParentAbilityEntityId);
    }
    if (parentAbilityName_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(ParentAbilityName);
    }
    if (parentAbilityOverride_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(ParentAbilityOverride);
    }
    if (InstancedAbilityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(InstancedAbilityId);
    }
    if (InstancedModifierId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(InstancedModifierId);
    }
    if (ExistDuration != 0F) {
      output.WriteRawTag(61);
      output.WriteFloat(ExistDuration);
    }
    if (attachedInstancedModifier_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(AttachedInstancedModifier);
    }
    if (ApplyEntityId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ApplyEntityId);
    }
    if (IsAttachedParentAbility != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsAttachedParentAbility);
    }
    if (modifierDurability_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(ModifierDurability);
    }
    if (SbuffUid != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(SbuffUid);
    }
    if (IsServerbuffModifier != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsServerbuffModifier);
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
    if (ModifierLocalId != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(ModifierLocalId);
    }
    if (ParentAbilityEntityId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ParentAbilityEntityId);
    }
    if (parentAbilityName_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(ParentAbilityName);
    }
    if (parentAbilityOverride_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(ParentAbilityOverride);
    }
    if (InstancedAbilityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(InstancedAbilityId);
    }
    if (InstancedModifierId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(InstancedModifierId);
    }
    if (ExistDuration != 0F) {
      output.WriteRawTag(61);
      output.WriteFloat(ExistDuration);
    }
    if (attachedInstancedModifier_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(AttachedInstancedModifier);
    }
    if (ApplyEntityId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ApplyEntityId);
    }
    if (IsAttachedParentAbility != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsAttachedParentAbility);
    }
    if (modifierDurability_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(ModifierDurability);
    }
    if (SbuffUid != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(SbuffUid);
    }
    if (IsServerbuffModifier != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsServerbuffModifier);
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
    if (ModifierLocalId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(ModifierLocalId);
    }
    if (ParentAbilityEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentAbilityEntityId);
    }
    if (parentAbilityName_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ParentAbilityName);
    }
    if (parentAbilityOverride_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ParentAbilityOverride);
    }
    if (InstancedAbilityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedAbilityId);
    }
    if (InstancedModifierId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedModifierId);
    }
    if (ExistDuration != 0F) {
      size += 1 + 4;
    }
    if (attachedInstancedModifier_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(AttachedInstancedModifier);
    }
    if (ApplyEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ApplyEntityId);
    }
    if (IsAttachedParentAbility != false) {
      size += 1 + 1;
    }
    if (modifierDurability_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModifierDurability);
    }
    if (SbuffUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SbuffUid);
    }
    if (IsServerbuffModifier != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AbilityAppliedModifier other) {
    if (other == null) {
      return;
    }
    if (other.ModifierLocalId != 0) {
      ModifierLocalId = other.ModifierLocalId;
    }
    if (other.ParentAbilityEntityId != 0) {
      ParentAbilityEntityId = other.ParentAbilityEntityId;
    }
    if (other.parentAbilityName_ != null) {
      if (parentAbilityName_ == null) {
        ParentAbilityName = new global::AbilityString();
      }
      ParentAbilityName.MergeFrom(other.ParentAbilityName);
    }
    if (other.parentAbilityOverride_ != null) {
      if (parentAbilityOverride_ == null) {
        ParentAbilityOverride = new global::AbilityString();
      }
      ParentAbilityOverride.MergeFrom(other.ParentAbilityOverride);
    }
    if (other.InstancedAbilityId != 0) {
      InstancedAbilityId = other.InstancedAbilityId;
    }
    if (other.InstancedModifierId != 0) {
      InstancedModifierId = other.InstancedModifierId;
    }
    if (other.ExistDuration != 0F) {
      ExistDuration = other.ExistDuration;
    }
    if (other.attachedInstancedModifier_ != null) {
      if (attachedInstancedModifier_ == null) {
        AttachedInstancedModifier = new global::AbilityAttachedModifier();
      }
      AttachedInstancedModifier.MergeFrom(other.AttachedInstancedModifier);
    }
    if (other.ApplyEntityId != 0) {
      ApplyEntityId = other.ApplyEntityId;
    }
    if (other.IsAttachedParentAbility != false) {
      IsAttachedParentAbility = other.IsAttachedParentAbility;
    }
    if (other.modifierDurability_ != null) {
      if (modifierDurability_ == null) {
        ModifierDurability = new global::ModifierDurability();
      }
      ModifierDurability.MergeFrom(other.ModifierDurability);
    }
    if (other.SbuffUid != 0) {
      SbuffUid = other.SbuffUid;
    }
    if (other.IsServerbuffModifier != false) {
      IsServerbuffModifier = other.IsServerbuffModifier;
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
          ModifierLocalId = input.ReadInt32();
          break;
        }
        case 16: {
          ParentAbilityEntityId = input.ReadUInt32();
          break;
        }
        case 26: {
          if (parentAbilityName_ == null) {
            ParentAbilityName = new global::AbilityString();
          }
          input.ReadMessage(ParentAbilityName);
          break;
        }
        case 34: {
          if (parentAbilityOverride_ == null) {
            ParentAbilityOverride = new global::AbilityString();
          }
          input.ReadMessage(ParentAbilityOverride);
          break;
        }
        case 40: {
          InstancedAbilityId = input.ReadUInt32();
          break;
        }
        case 48: {
          InstancedModifierId = input.ReadUInt32();
          break;
        }
        case 61: {
          ExistDuration = input.ReadFloat();
          break;
        }
        case 66: {
          if (attachedInstancedModifier_ == null) {
            AttachedInstancedModifier = new global::AbilityAttachedModifier();
          }
          input.ReadMessage(AttachedInstancedModifier);
          break;
        }
        case 72: {
          ApplyEntityId = input.ReadUInt32();
          break;
        }
        case 80: {
          IsAttachedParentAbility = input.ReadBool();
          break;
        }
        case 90: {
          if (modifierDurability_ == null) {
            ModifierDurability = new global::ModifierDurability();
          }
          input.ReadMessage(ModifierDurability);
          break;
        }
        case 96: {
          SbuffUid = input.ReadUInt32();
          break;
        }
        case 104: {
          IsServerbuffModifier = input.ReadBool();
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
          ModifierLocalId = input.ReadInt32();
          break;
        }
        case 16: {
          ParentAbilityEntityId = input.ReadUInt32();
          break;
        }
        case 26: {
          if (parentAbilityName_ == null) {
            ParentAbilityName = new global::AbilityString();
          }
          input.ReadMessage(ParentAbilityName);
          break;
        }
        case 34: {
          if (parentAbilityOverride_ == null) {
            ParentAbilityOverride = new global::AbilityString();
          }
          input.ReadMessage(ParentAbilityOverride);
          break;
        }
        case 40: {
          InstancedAbilityId = input.ReadUInt32();
          break;
        }
        case 48: {
          InstancedModifierId = input.ReadUInt32();
          break;
        }
        case 61: {
          ExistDuration = input.ReadFloat();
          break;
        }
        case 66: {
          if (attachedInstancedModifier_ == null) {
            AttachedInstancedModifier = new global::AbilityAttachedModifier();
          }
          input.ReadMessage(AttachedInstancedModifier);
          break;
        }
        case 72: {
          ApplyEntityId = input.ReadUInt32();
          break;
        }
        case 80: {
          IsAttachedParentAbility = input.ReadBool();
          break;
        }
        case 90: {
          if (modifierDurability_ == null) {
            ModifierDurability = new global::ModifierDurability();
          }
          input.ReadMessage(ModifierDurability);
          break;
        }
        case 96: {
          SbuffUid = input.ReadUInt32();
          break;
        }
        case 104: {
          IsServerbuffModifier = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
