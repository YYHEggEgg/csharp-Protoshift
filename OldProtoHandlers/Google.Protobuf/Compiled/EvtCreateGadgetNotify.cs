// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtCreateGadgetNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from EvtCreateGadgetNotify.proto</summary>
  public static partial class EvtCreateGadgetNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtCreateGadgetNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtCreateGadgetNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFdnRDcmVhdGVHYWRnZXROb3RpZnkucHJvdG8aEUZvcndhcmRUeXBlLnBy",
            "b3RvGgxWZWN0b3IucHJvdG8imAQKFUV2dENyZWF0ZUdhZGdldE5vdGlmeRIV",
            "Cg1pc19hc3luY19sb2FkGAggASgIEhEKCWNhbXBfdHlwZRgFIAEoDRIeChZz",
            "aWdodF9ncm91cF93aXRoX293bmVyGAogASgIEh4KFXRhcmdldF9lbnRpdHlf",
            "aWRfbGlzdBj5BiADKA0SIgoMZm9yd2FyZF90eXBlGAwgASgOMgwuRm9yd2Fy",
            "ZFR5cGUSEQoJZW50aXR5X2lkGAIgASgNEhgKEHRhcmdldF9lbnRpdHlfaWQY",
            "AyABKA0SDwoHY2FtcF9pZBgPIAEoDRIMCgRndWlkGAYgASgEEiIKEWluaXRf",
            "ZXVsZXJfYW5nbGVzGA0gASgLMgcuVmVjdG9yEh8KF3RhcmdldF9sb2NrX3Bv",
            "aW50X2luZGV4GAsgASgNEiUKHHRhcmdldF9sb2NrX3BvaW50X2luZGV4X2xp",
            "c3QYgA8gAygNEhkKCGluaXRfcG9zGAQgASgLMgcuVmVjdG9yEhcKD293bmVy",
            "X2VudGl0eV9pZBgJIAEoDRIPCgdyb29tX2lkGAcgASgNEh4KFmlzX3BlZXJf",
            "aWRfZnJvbV9wbGF5ZXIYGSABKAgSHAoUcHJvcF9vd25lcl9lbnRpdHlfaWQY",
            "ASABKA0SIwoaaXNfdHJ1ZV9saWZlX3RpbWVfYnlfb3duZXIY+wIgASgIEhEK",
            "CWNvbmZpZ19pZBgOIAEoDUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ForwardTypeReflection.Descriptor, global::OldProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.EvtCreateGadgetNotify), global::OldProtos.EvtCreateGadgetNotify.Parser, new[]{ "IsAsyncLoad", "CampType", "SightGroupWithOwner", "TargetEntityIdList", "ForwardType", "EntityId", "TargetEntityId", "CampId", "Guid", "InitEulerAngles", "TargetLockPointIndex", "TargetLockPointIndexList", "InitPos", "OwnerEntityId", "RoomId", "IsPeerIdFromPlayer", "PropOwnerEntityId", "IsTrueLifeTimeByOwner", "ConfigId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 307
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class EvtCreateGadgetNotify : pb::IMessage<EvtCreateGadgetNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtCreateGadgetNotify> _parser = new pb::MessageParser<EvtCreateGadgetNotify>(() => new EvtCreateGadgetNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtCreateGadgetNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.EvtCreateGadgetNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify(EvtCreateGadgetNotify other) : this() {
      isAsyncLoad_ = other.isAsyncLoad_;
      campType_ = other.campType_;
      sightGroupWithOwner_ = other.sightGroupWithOwner_;
      targetEntityIdList_ = other.targetEntityIdList_.Clone();
      forwardType_ = other.forwardType_;
      entityId_ = other.entityId_;
      targetEntityId_ = other.targetEntityId_;
      campId_ = other.campId_;
      guid_ = other.guid_;
      initEulerAngles_ = other.initEulerAngles_ != null ? other.initEulerAngles_.Clone() : null;
      targetLockPointIndex_ = other.targetLockPointIndex_;
      targetLockPointIndexList_ = other.targetLockPointIndexList_.Clone();
      initPos_ = other.initPos_ != null ? other.initPos_.Clone() : null;
      ownerEntityId_ = other.ownerEntityId_;
      roomId_ = other.roomId_;
      isPeerIdFromPlayer_ = other.isPeerIdFromPlayer_;
      propOwnerEntityId_ = other.propOwnerEntityId_;
      isTrueLifeTimeByOwner_ = other.isTrueLifeTimeByOwner_;
      configId_ = other.configId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCreateGadgetNotify Clone() {
      return new EvtCreateGadgetNotify(this);
    }

    /// <summary>Field number for the "is_async_load" field.</summary>
    public const int IsAsyncLoadFieldNumber = 8;
    private bool isAsyncLoad_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAsyncLoad {
      get { return isAsyncLoad_; }
      set {
        isAsyncLoad_ = value;
      }
    }

    /// <summary>Field number for the "camp_type" field.</summary>
    public const int CampTypeFieldNumber = 5;
    private uint campType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampType {
      get { return campType_; }
      set {
        campType_ = value;
      }
    }

    /// <summary>Field number for the "sight_group_with_owner" field.</summary>
    public const int SightGroupWithOwnerFieldNumber = 10;
    private bool sightGroupWithOwner_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SightGroupWithOwner {
      get { return sightGroupWithOwner_; }
      set {
        sightGroupWithOwner_ = value;
      }
    }

    /// <summary>Field number for the "target_entity_id_list" field.</summary>
    public const int TargetEntityIdListFieldNumber = 889;
    private static readonly pb::FieldCodec<uint> _repeated_targetEntityIdList_codec
        = pb::FieldCodec.ForUInt32(7114);
    private readonly pbc::RepeatedField<uint> targetEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetEntityIdList {
      get { return targetEntityIdList_; }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 12;
    private global::OldProtos.ForwardType forwardType_ = global::OldProtos.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 2;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "target_entity_id" field.</summary>
    public const int TargetEntityIdFieldNumber = 3;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "camp_id" field.</summary>
    public const int CampIdFieldNumber = 15;
    private uint campId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampId {
      get { return campId_; }
      set {
        campId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 6;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "init_euler_angles" field.</summary>
    public const int InitEulerAnglesFieldNumber = 13;
    private global::OldProtos.Vector initEulerAngles_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector InitEulerAngles {
      get { return initEulerAngles_; }
      set {
        initEulerAngles_ = value;
      }
    }

    /// <summary>Field number for the "target_lock_point_index" field.</summary>
    public const int TargetLockPointIndexFieldNumber = 11;
    private uint targetLockPointIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetLockPointIndex {
      get { return targetLockPointIndex_; }
      set {
        targetLockPointIndex_ = value;
      }
    }

    /// <summary>Field number for the "target_lock_point_index_list" field.</summary>
    public const int TargetLockPointIndexListFieldNumber = 1920;
    private static readonly pb::FieldCodec<uint> _repeated_targetLockPointIndexList_codec
        = pb::FieldCodec.ForUInt32(15362);
    private readonly pbc::RepeatedField<uint> targetLockPointIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetLockPointIndexList {
      get { return targetLockPointIndexList_; }
    }

    /// <summary>Field number for the "init_pos" field.</summary>
    public const int InitPosFieldNumber = 4;
    private global::OldProtos.Vector initPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector InitPos {
      get { return initPos_; }
      set {
        initPos_ = value;
      }
    }

    /// <summary>Field number for the "owner_entity_id" field.</summary>
    public const int OwnerEntityIdFieldNumber = 9;
    private uint ownerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerEntityId {
      get { return ownerEntityId_; }
      set {
        ownerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 7;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "is_peer_id_from_player" field.</summary>
    public const int IsPeerIdFromPlayerFieldNumber = 25;
    private bool isPeerIdFromPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPeerIdFromPlayer {
      get { return isPeerIdFromPlayer_; }
      set {
        isPeerIdFromPlayer_ = value;
      }
    }

    /// <summary>Field number for the "prop_owner_entity_id" field.</summary>
    public const int PropOwnerEntityIdFieldNumber = 1;
    private uint propOwnerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropOwnerEntityId {
      get { return propOwnerEntityId_; }
      set {
        propOwnerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "is_true_life_time_by_owner" field.</summary>
    public const int IsTrueLifeTimeByOwnerFieldNumber = 379;
    private bool isTrueLifeTimeByOwner_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTrueLifeTimeByOwner {
      get { return isTrueLifeTimeByOwner_; }
      set {
        isTrueLifeTimeByOwner_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 14;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtCreateGadgetNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtCreateGadgetNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAsyncLoad != other.IsAsyncLoad) return false;
      if (CampType != other.CampType) return false;
      if (SightGroupWithOwner != other.SightGroupWithOwner) return false;
      if(!targetEntityIdList_.Equals(other.targetEntityIdList_)) return false;
      if (ForwardType != other.ForwardType) return false;
      if (EntityId != other.EntityId) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      if (CampId != other.CampId) return false;
      if (Guid != other.Guid) return false;
      if (!object.Equals(InitEulerAngles, other.InitEulerAngles)) return false;
      if (TargetLockPointIndex != other.TargetLockPointIndex) return false;
      if(!targetLockPointIndexList_.Equals(other.targetLockPointIndexList_)) return false;
      if (!object.Equals(InitPos, other.InitPos)) return false;
      if (OwnerEntityId != other.OwnerEntityId) return false;
      if (RoomId != other.RoomId) return false;
      if (IsPeerIdFromPlayer != other.IsPeerIdFromPlayer) return false;
      if (PropOwnerEntityId != other.PropOwnerEntityId) return false;
      if (IsTrueLifeTimeByOwner != other.IsTrueLifeTimeByOwner) return false;
      if (ConfigId != other.ConfigId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAsyncLoad != false) hash ^= IsAsyncLoad.GetHashCode();
      if (CampType != 0) hash ^= CampType.GetHashCode();
      if (SightGroupWithOwner != false) hash ^= SightGroupWithOwner.GetHashCode();
      hash ^= targetEntityIdList_.GetHashCode();
      if (ForwardType != global::OldProtos.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
      if (CampId != 0) hash ^= CampId.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (initEulerAngles_ != null) hash ^= InitEulerAngles.GetHashCode();
      if (TargetLockPointIndex != 0) hash ^= TargetLockPointIndex.GetHashCode();
      hash ^= targetLockPointIndexList_.GetHashCode();
      if (initPos_ != null) hash ^= InitPos.GetHashCode();
      if (OwnerEntityId != 0) hash ^= OwnerEntityId.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (IsPeerIdFromPlayer != false) hash ^= IsPeerIdFromPlayer.GetHashCode();
      if (PropOwnerEntityId != 0) hash ^= PropOwnerEntityId.GetHashCode();
      if (IsTrueLifeTimeByOwner != false) hash ^= IsTrueLifeTimeByOwner.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
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
      if (PropOwnerEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PropOwnerEntityId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetEntityId);
      }
      if (initPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(InitPos);
      }
      if (CampType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CampType);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Guid);
      }
      if (RoomId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RoomId);
      }
      if (IsAsyncLoad != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsAsyncLoad);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OwnerEntityId);
      }
      if (SightGroupWithOwner != false) {
        output.WriteRawTag(80);
        output.WriteBool(SightGroupWithOwner);
      }
      if (TargetLockPointIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TargetLockPointIndex);
      }
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ForwardType);
      }
      if (initEulerAngles_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(InitEulerAngles);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ConfigId);
      }
      if (CampId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CampId);
      }
      if (IsPeerIdFromPlayer != false) {
        output.WriteRawTag(200, 1);
        output.WriteBool(IsPeerIdFromPlayer);
      }
      if (IsTrueLifeTimeByOwner != false) {
        output.WriteRawTag(216, 23);
        output.WriteBool(IsTrueLifeTimeByOwner);
      }
      targetEntityIdList_.WriteTo(output, _repeated_targetEntityIdList_codec);
      targetLockPointIndexList_.WriteTo(output, _repeated_targetLockPointIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PropOwnerEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PropOwnerEntityId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetEntityId);
      }
      if (initPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(InitPos);
      }
      if (CampType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CampType);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Guid);
      }
      if (RoomId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RoomId);
      }
      if (IsAsyncLoad != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsAsyncLoad);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OwnerEntityId);
      }
      if (SightGroupWithOwner != false) {
        output.WriteRawTag(80);
        output.WriteBool(SightGroupWithOwner);
      }
      if (TargetLockPointIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TargetLockPointIndex);
      }
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ForwardType);
      }
      if (initEulerAngles_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(InitEulerAngles);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ConfigId);
      }
      if (CampId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CampId);
      }
      if (IsPeerIdFromPlayer != false) {
        output.WriteRawTag(200, 1);
        output.WriteBool(IsPeerIdFromPlayer);
      }
      if (IsTrueLifeTimeByOwner != false) {
        output.WriteRawTag(216, 23);
        output.WriteBool(IsTrueLifeTimeByOwner);
      }
      targetEntityIdList_.WriteTo(ref output, _repeated_targetEntityIdList_codec);
      targetLockPointIndexList_.WriteTo(ref output, _repeated_targetLockPointIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsAsyncLoad != false) {
        size += 1 + 1;
      }
      if (CampType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampType);
      }
      if (SightGroupWithOwner != false) {
        size += 1 + 1;
      }
      size += targetEntityIdList_.CalculateSize(_repeated_targetEntityIdList_codec);
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (CampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampId);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (initEulerAngles_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitEulerAngles);
      }
      if (TargetLockPointIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetLockPointIndex);
      }
      size += targetLockPointIndexList_.CalculateSize(_repeated_targetLockPointIndexList_codec);
      if (initPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitPos);
      }
      if (OwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerEntityId);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (IsPeerIdFromPlayer != false) {
        size += 2 + 1;
      }
      if (PropOwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropOwnerEntityId);
      }
      if (IsTrueLifeTimeByOwner != false) {
        size += 2 + 1;
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtCreateGadgetNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsAsyncLoad != false) {
        IsAsyncLoad = other.IsAsyncLoad;
      }
      if (other.CampType != 0) {
        CampType = other.CampType;
      }
      if (other.SightGroupWithOwner != false) {
        SightGroupWithOwner = other.SightGroupWithOwner;
      }
      targetEntityIdList_.Add(other.targetEntityIdList_);
      if (other.ForwardType != global::OldProtos.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
      }
      if (other.CampId != 0) {
        CampId = other.CampId;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.initEulerAngles_ != null) {
        if (initEulerAngles_ == null) {
          InitEulerAngles = new global::OldProtos.Vector();
        }
        InitEulerAngles.MergeFrom(other.InitEulerAngles);
      }
      if (other.TargetLockPointIndex != 0) {
        TargetLockPointIndex = other.TargetLockPointIndex;
      }
      targetLockPointIndexList_.Add(other.targetLockPointIndexList_);
      if (other.initPos_ != null) {
        if (initPos_ == null) {
          InitPos = new global::OldProtos.Vector();
        }
        InitPos.MergeFrom(other.InitPos);
      }
      if (other.OwnerEntityId != 0) {
        OwnerEntityId = other.OwnerEntityId;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.IsPeerIdFromPlayer != false) {
        IsPeerIdFromPlayer = other.IsPeerIdFromPlayer;
      }
      if (other.PropOwnerEntityId != 0) {
        PropOwnerEntityId = other.PropOwnerEntityId;
      }
      if (other.IsTrueLifeTimeByOwner != false) {
        IsTrueLifeTimeByOwner = other.IsTrueLifeTimeByOwner;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
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
            PropOwnerEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (initPos_ == null) {
              InitPos = new global::OldProtos.Vector();
            }
            input.ReadMessage(InitPos);
            break;
          }
          case 40: {
            CampType = input.ReadUInt32();
            break;
          }
          case 48: {
            Guid = input.ReadUInt64();
            break;
          }
          case 56: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 64: {
            IsAsyncLoad = input.ReadBool();
            break;
          }
          case 72: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 80: {
            SightGroupWithOwner = input.ReadBool();
            break;
          }
          case 88: {
            TargetLockPointIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            ForwardType = (global::OldProtos.ForwardType) input.ReadEnum();
            break;
          }
          case 106: {
            if (initEulerAngles_ == null) {
              InitEulerAngles = new global::OldProtos.Vector();
            }
            input.ReadMessage(InitEulerAngles);
            break;
          }
          case 112: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 120: {
            CampId = input.ReadUInt32();
            break;
          }
          case 200: {
            IsPeerIdFromPlayer = input.ReadBool();
            break;
          }
          case 3032: {
            IsTrueLifeTimeByOwner = input.ReadBool();
            break;
          }
          case 7114:
          case 7112: {
            targetEntityIdList_.AddEntriesFrom(input, _repeated_targetEntityIdList_codec);
            break;
          }
          case 15362:
          case 15360: {
            targetLockPointIndexList_.AddEntriesFrom(input, _repeated_targetLockPointIndexList_codec);
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
            PropOwnerEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (initPos_ == null) {
              InitPos = new global::OldProtos.Vector();
            }
            input.ReadMessage(InitPos);
            break;
          }
          case 40: {
            CampType = input.ReadUInt32();
            break;
          }
          case 48: {
            Guid = input.ReadUInt64();
            break;
          }
          case 56: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 64: {
            IsAsyncLoad = input.ReadBool();
            break;
          }
          case 72: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 80: {
            SightGroupWithOwner = input.ReadBool();
            break;
          }
          case 88: {
            TargetLockPointIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            ForwardType = (global::OldProtos.ForwardType) input.ReadEnum();
            break;
          }
          case 106: {
            if (initEulerAngles_ == null) {
              InitEulerAngles = new global::OldProtos.Vector();
            }
            input.ReadMessage(InitEulerAngles);
            break;
          }
          case 112: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 120: {
            CampId = input.ReadUInt32();
            break;
          }
          case 200: {
            IsPeerIdFromPlayer = input.ReadBool();
            break;
          }
          case 3032: {
            IsTrueLifeTimeByOwner = input.ReadBool();
            break;
          }
          case 7114:
          case 7112: {
            targetEntityIdList_.AddEntriesFrom(ref input, _repeated_targetEntityIdList_codec);
            break;
          }
          case 15362:
          case 15360: {
            targetLockPointIndexList_.AddEntriesFrom(ref input, _repeated_targetLockPointIndexList_codec);
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
