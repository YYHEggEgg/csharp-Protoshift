// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneAvatarInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from SceneAvatarInfo.proto</summary>
  public static partial class SceneAvatarInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneAvatarInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneAvatarInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZUF2YXRhckluZm8ucHJvdG8aFUF2YXRhckV4Y2VsSW5mby5wcm90",
            "bxoUQ3VyVmVoaWNsZUluZm8ucHJvdG8aGFNjZW5lUmVsaXF1YXJ5SW5mby5w",
            "cm90bxoVU2NlbmVXZWFwb25JbmZvLnByb3RvGhBTZXJ2ZXJCdWZmLnByb3Rv",
            "Ip0GCg9TY2VuZUF2YXRhckluZm8SCwoDdWlkGAEgASgNEhEKCWF2YXRhcl9p",
            "ZBgCIAEoDRIMCgRndWlkGAMgASgEEg8KB3BlZXJfaWQYBCABKA0SFQoNZXF1",
            "aXBfaWRfbGlzdBgFIAMoDRIWCg5za2lsbF9kZXBvdF9pZBgGIAEoDRIWCg50",
            "YWxlbnRfaWRfbGlzdBgHIAMoDRIgCgZ3ZWFwb24YCCABKAsyEC5TY2VuZVdl",
            "YXBvbkluZm8SKwoOcmVsaXF1YXJ5X2xpc3QYCSADKAsyEy5TY2VuZVJlbGlx",
            "dWFyeUluZm8SHgoWY29yZV9wcm91ZF9za2lsbF9sZXZlbBgLIAEoDRIhChlp",
            "bmhlcmVudF9wcm91ZF9za2lsbF9saXN0GAwgAygNEjwKD3NraWxsX2xldmVs",
            "X21hcBgNIAMoCzIjLlNjZW5lQXZhdGFySW5mby5Ta2lsbExldmVsTWFwRW50",
            "cnkSUgobcHJvdWRfc2tpbGxfZXh0cmFfbGV2ZWxfbWFwGA4gAygLMi0uU2Nl",
            "bmVBdmF0YXJJbmZvLlByb3VkU2tpbGxFeHRyYUxldmVsTWFwRW50cnkSJQoQ",
            "c2VydmVyX2J1ZmZfbGlzdBgPIAMoCzILLlNlcnZlckJ1ZmYSGwoTdGVhbV9y",
            "ZXNvbmFuY2VfbGlzdBgQIAMoDRIbChN3ZWFyaW5nX2ZseWNsb2FrX2lkGBEg",
            "ASgNEhEKCWJvcm5fdGltZRgSIAEoDRISCgpjb3N0dW1lX2lkGBMgASgNEikK",
            "EGN1cl92ZWhpY2xlX2luZm8YFCABKAsyDy5DdXJWZWhpY2xlSW5mbxIkCgpl",
            "eGNlbF9pbmZvGBUgASgLMhAuQXZhdGFyRXhjZWxJbmZvEhEKCWFuaW1faGFz",
            "aBgWIAEoDRo0ChJTa2lsbExldmVsTWFwRW50cnkSCwoDa2V5GAEgASgNEg0K",
            "BXZhbHVlGAIgASgNOgI4ARo+ChxQcm91ZFNraWxsRXh0cmFMZXZlbE1hcEVu",
            "dHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCDKoCCU9sZFBy",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.AvatarExcelInfoReflection.Descriptor, global::OldProtos.CurVehicleInfoReflection.Descriptor, global::OldProtos.SceneReliquaryInfoReflection.Descriptor, global::OldProtos.SceneWeaponInfoReflection.Descriptor, global::OldProtos.ServerBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.SceneAvatarInfo), global::OldProtos.SceneAvatarInfo.Parser, new[]{ "Uid", "AvatarId", "Guid", "PeerId", "EquipIdList", "SkillDepotId", "TalentIdList", "Weapon", "ReliquaryList", "CoreProudSkillLevel", "InherentProudSkillList", "SkillLevelMap", "ProudSkillExtraLevelMap", "ServerBuffList", "TeamResonanceList", "WearingFlycloakId", "BornTime", "CostumeId", "CurVehicleInfo", "ExcelInfo", "AnimHash" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneAvatarInfo : pb::IMessage<SceneAvatarInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneAvatarInfo> _parser = new pb::MessageParser<SceneAvatarInfo>(() => new SceneAvatarInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneAvatarInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.SceneAvatarInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAvatarInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAvatarInfo(SceneAvatarInfo other) : this() {
      uid_ = other.uid_;
      avatarId_ = other.avatarId_;
      guid_ = other.guid_;
      peerId_ = other.peerId_;
      equipIdList_ = other.equipIdList_.Clone();
      skillDepotId_ = other.skillDepotId_;
      talentIdList_ = other.talentIdList_.Clone();
      weapon_ = other.weapon_ != null ? other.weapon_.Clone() : null;
      reliquaryList_ = other.reliquaryList_.Clone();
      coreProudSkillLevel_ = other.coreProudSkillLevel_;
      inherentProudSkillList_ = other.inherentProudSkillList_.Clone();
      skillLevelMap_ = other.skillLevelMap_.Clone();
      proudSkillExtraLevelMap_ = other.proudSkillExtraLevelMap_.Clone();
      serverBuffList_ = other.serverBuffList_.Clone();
      teamResonanceList_ = other.teamResonanceList_.Clone();
      wearingFlycloakId_ = other.wearingFlycloakId_;
      bornTime_ = other.bornTime_;
      costumeId_ = other.costumeId_;
      curVehicleInfo_ = other.curVehicleInfo_ != null ? other.curVehicleInfo_.Clone() : null;
      excelInfo_ = other.excelInfo_ != null ? other.excelInfo_.Clone() : null;
      animHash_ = other.animHash_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAvatarInfo Clone() {
      return new SceneAvatarInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 2;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 3;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "peer_id" field.</summary>
    public const int PeerIdFieldNumber = 4;
    private uint peerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PeerId {
      get { return peerId_; }
      set {
        peerId_ = value;
      }
    }

    /// <summary>Field number for the "equip_id_list" field.</summary>
    public const int EquipIdListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_equipIdList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> equipIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EquipIdList {
      get { return equipIdList_; }
    }

    /// <summary>Field number for the "skill_depot_id" field.</summary>
    public const int SkillDepotIdFieldNumber = 6;
    private uint skillDepotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillDepotId {
      get { return skillDepotId_; }
      set {
        skillDepotId_ = value;
      }
    }

    /// <summary>Field number for the "talent_id_list" field.</summary>
    public const int TalentIdListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_talentIdList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> talentIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TalentIdList {
      get { return talentIdList_; }
    }

    /// <summary>Field number for the "weapon" field.</summary>
    public const int WeaponFieldNumber = 8;
    private global::OldProtos.SceneWeaponInfo weapon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.SceneWeaponInfo Weapon {
      get { return weapon_; }
      set {
        weapon_ = value;
      }
    }

    /// <summary>Field number for the "reliquary_list" field.</summary>
    public const int ReliquaryListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::OldProtos.SceneReliquaryInfo> _repeated_reliquaryList_codec
        = pb::FieldCodec.ForMessage(74, global::OldProtos.SceneReliquaryInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.SceneReliquaryInfo> reliquaryList_ = new pbc::RepeatedField<global::OldProtos.SceneReliquaryInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.SceneReliquaryInfo> ReliquaryList {
      get { return reliquaryList_; }
    }

    /// <summary>Field number for the "core_proud_skill_level" field.</summary>
    public const int CoreProudSkillLevelFieldNumber = 11;
    private uint coreProudSkillLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoreProudSkillLevel {
      get { return coreProudSkillLevel_; }
      set {
        coreProudSkillLevel_ = value;
      }
    }

    /// <summary>Field number for the "inherent_proud_skill_list" field.</summary>
    public const int InherentProudSkillListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_inherentProudSkillList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> inherentProudSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> InherentProudSkillList {
      get { return inherentProudSkillList_; }
    }

    /// <summary>Field number for the "skill_level_map" field.</summary>
    public const int SkillLevelMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_skillLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> skillLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SkillLevelMap {
      get { return skillLevelMap_; }
    }

    /// <summary>Field number for the "proud_skill_extra_level_map" field.</summary>
    public const int ProudSkillExtraLevelMapFieldNumber = 14;
    private static readonly pbc::MapField<uint, uint>.Codec _map_proudSkillExtraLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 114);
    private readonly pbc::MapField<uint, uint> proudSkillExtraLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> ProudSkillExtraLevelMap {
      get { return proudSkillExtraLevelMap_; }
    }

    /// <summary>Field number for the "server_buff_list" field.</summary>
    public const int ServerBuffListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::OldProtos.ServerBuff> _repeated_serverBuffList_codec
        = pb::FieldCodec.ForMessage(122, global::OldProtos.ServerBuff.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ServerBuff> serverBuffList_ = new pbc::RepeatedField<global::OldProtos.ServerBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ServerBuff> ServerBuffList {
      get { return serverBuffList_; }
    }

    /// <summary>Field number for the "team_resonance_list" field.</summary>
    public const int TeamResonanceListFieldNumber = 16;
    private static readonly pb::FieldCodec<uint> _repeated_teamResonanceList_codec
        = pb::FieldCodec.ForUInt32(130);
    private readonly pbc::RepeatedField<uint> teamResonanceList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TeamResonanceList {
      get { return teamResonanceList_; }
    }

    /// <summary>Field number for the "wearing_flycloak_id" field.</summary>
    public const int WearingFlycloakIdFieldNumber = 17;
    private uint wearingFlycloakId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WearingFlycloakId {
      get { return wearingFlycloakId_; }
      set {
        wearingFlycloakId_ = value;
      }
    }

    /// <summary>Field number for the "born_time" field.</summary>
    public const int BornTimeFieldNumber = 18;
    private uint bornTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BornTime {
      get { return bornTime_; }
      set {
        bornTime_ = value;
      }
    }

    /// <summary>Field number for the "costume_id" field.</summary>
    public const int CostumeIdFieldNumber = 19;
    private uint costumeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostumeId {
      get { return costumeId_; }
      set {
        costumeId_ = value;
      }
    }

    /// <summary>Field number for the "cur_vehicle_info" field.</summary>
    public const int CurVehicleInfoFieldNumber = 20;
    private global::OldProtos.CurVehicleInfo curVehicleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.CurVehicleInfo CurVehicleInfo {
      get { return curVehicleInfo_; }
      set {
        curVehicleInfo_ = value;
      }
    }

    /// <summary>Field number for the "excel_info" field.</summary>
    public const int ExcelInfoFieldNumber = 21;
    private global::OldProtos.AvatarExcelInfo excelInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AvatarExcelInfo ExcelInfo {
      get { return excelInfo_; }
      set {
        excelInfo_ = value;
      }
    }

    /// <summary>Field number for the "anim_hash" field.</summary>
    public const int AnimHashFieldNumber = 22;
    private uint animHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AnimHash {
      get { return animHash_; }
      set {
        animHash_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneAvatarInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneAvatarInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (AvatarId != other.AvatarId) return false;
      if (Guid != other.Guid) return false;
      if (PeerId != other.PeerId) return false;
      if(!equipIdList_.Equals(other.equipIdList_)) return false;
      if (SkillDepotId != other.SkillDepotId) return false;
      if(!talentIdList_.Equals(other.talentIdList_)) return false;
      if (!object.Equals(Weapon, other.Weapon)) return false;
      if(!reliquaryList_.Equals(other.reliquaryList_)) return false;
      if (CoreProudSkillLevel != other.CoreProudSkillLevel) return false;
      if(!inherentProudSkillList_.Equals(other.inherentProudSkillList_)) return false;
      if (!SkillLevelMap.Equals(other.SkillLevelMap)) return false;
      if (!ProudSkillExtraLevelMap.Equals(other.ProudSkillExtraLevelMap)) return false;
      if(!serverBuffList_.Equals(other.serverBuffList_)) return false;
      if(!teamResonanceList_.Equals(other.teamResonanceList_)) return false;
      if (WearingFlycloakId != other.WearingFlycloakId) return false;
      if (BornTime != other.BornTime) return false;
      if (CostumeId != other.CostumeId) return false;
      if (!object.Equals(CurVehicleInfo, other.CurVehicleInfo)) return false;
      if (!object.Equals(ExcelInfo, other.ExcelInfo)) return false;
      if (AnimHash != other.AnimHash) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (PeerId != 0) hash ^= PeerId.GetHashCode();
      hash ^= equipIdList_.GetHashCode();
      if (SkillDepotId != 0) hash ^= SkillDepotId.GetHashCode();
      hash ^= talentIdList_.GetHashCode();
      if (weapon_ != null) hash ^= Weapon.GetHashCode();
      hash ^= reliquaryList_.GetHashCode();
      if (CoreProudSkillLevel != 0) hash ^= CoreProudSkillLevel.GetHashCode();
      hash ^= inherentProudSkillList_.GetHashCode();
      hash ^= SkillLevelMap.GetHashCode();
      hash ^= ProudSkillExtraLevelMap.GetHashCode();
      hash ^= serverBuffList_.GetHashCode();
      hash ^= teamResonanceList_.GetHashCode();
      if (WearingFlycloakId != 0) hash ^= WearingFlycloakId.GetHashCode();
      if (BornTime != 0) hash ^= BornTime.GetHashCode();
      if (CostumeId != 0) hash ^= CostumeId.GetHashCode();
      if (curVehicleInfo_ != null) hash ^= CurVehicleInfo.GetHashCode();
      if (excelInfo_ != null) hash ^= ExcelInfo.GetHashCode();
      if (AnimHash != 0) hash ^= AnimHash.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AvatarId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Guid);
      }
      if (PeerId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PeerId);
      }
      equipIdList_.WriteTo(output, _repeated_equipIdList_codec);
      if (SkillDepotId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SkillDepotId);
      }
      talentIdList_.WriteTo(output, _repeated_talentIdList_codec);
      if (weapon_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Weapon);
      }
      reliquaryList_.WriteTo(output, _repeated_reliquaryList_codec);
      if (CoreProudSkillLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CoreProudSkillLevel);
      }
      inherentProudSkillList_.WriteTo(output, _repeated_inherentProudSkillList_codec);
      skillLevelMap_.WriteTo(output, _map_skillLevelMap_codec);
      proudSkillExtraLevelMap_.WriteTo(output, _map_proudSkillExtraLevelMap_codec);
      serverBuffList_.WriteTo(output, _repeated_serverBuffList_codec);
      teamResonanceList_.WriteTo(output, _repeated_teamResonanceList_codec);
      if (WearingFlycloakId != 0) {
        output.WriteRawTag(136, 1);
        output.WriteUInt32(WearingFlycloakId);
      }
      if (BornTime != 0) {
        output.WriteRawTag(144, 1);
        output.WriteUInt32(BornTime);
      }
      if (CostumeId != 0) {
        output.WriteRawTag(152, 1);
        output.WriteUInt32(CostumeId);
      }
      if (curVehicleInfo_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(CurVehicleInfo);
      }
      if (excelInfo_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(ExcelInfo);
      }
      if (AnimHash != 0) {
        output.WriteRawTag(176, 1);
        output.WriteUInt32(AnimHash);
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AvatarId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Guid);
      }
      if (PeerId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PeerId);
      }
      equipIdList_.WriteTo(ref output, _repeated_equipIdList_codec);
      if (SkillDepotId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SkillDepotId);
      }
      talentIdList_.WriteTo(ref output, _repeated_talentIdList_codec);
      if (weapon_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Weapon);
      }
      reliquaryList_.WriteTo(ref output, _repeated_reliquaryList_codec);
      if (CoreProudSkillLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CoreProudSkillLevel);
      }
      inherentProudSkillList_.WriteTo(ref output, _repeated_inherentProudSkillList_codec);
      skillLevelMap_.WriteTo(ref output, _map_skillLevelMap_codec);
      proudSkillExtraLevelMap_.WriteTo(ref output, _map_proudSkillExtraLevelMap_codec);
      serverBuffList_.WriteTo(ref output, _repeated_serverBuffList_codec);
      teamResonanceList_.WriteTo(ref output, _repeated_teamResonanceList_codec);
      if (WearingFlycloakId != 0) {
        output.WriteRawTag(136, 1);
        output.WriteUInt32(WearingFlycloakId);
      }
      if (BornTime != 0) {
        output.WriteRawTag(144, 1);
        output.WriteUInt32(BornTime);
      }
      if (CostumeId != 0) {
        output.WriteRawTag(152, 1);
        output.WriteUInt32(CostumeId);
      }
      if (curVehicleInfo_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(CurVehicleInfo);
      }
      if (excelInfo_ != null) {
        output.WriteRawTag(170, 1);
        output.WriteMessage(ExcelInfo);
      }
      if (AnimHash != 0) {
        output.WriteRawTag(176, 1);
        output.WriteUInt32(AnimHash);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (PeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PeerId);
      }
      size += equipIdList_.CalculateSize(_repeated_equipIdList_codec);
      if (SkillDepotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillDepotId);
      }
      size += talentIdList_.CalculateSize(_repeated_talentIdList_codec);
      if (weapon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Weapon);
      }
      size += reliquaryList_.CalculateSize(_repeated_reliquaryList_codec);
      if (CoreProudSkillLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoreProudSkillLevel);
      }
      size += inherentProudSkillList_.CalculateSize(_repeated_inherentProudSkillList_codec);
      size += skillLevelMap_.CalculateSize(_map_skillLevelMap_codec);
      size += proudSkillExtraLevelMap_.CalculateSize(_map_proudSkillExtraLevelMap_codec);
      size += serverBuffList_.CalculateSize(_repeated_serverBuffList_codec);
      size += teamResonanceList_.CalculateSize(_repeated_teamResonanceList_codec);
      if (WearingFlycloakId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(WearingFlycloakId);
      }
      if (BornTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(BornTime);
      }
      if (CostumeId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(CostumeId);
      }
      if (curVehicleInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CurVehicleInfo);
      }
      if (excelInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ExcelInfo);
      }
      if (AnimHash != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(AnimHash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneAvatarInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.PeerId != 0) {
        PeerId = other.PeerId;
      }
      equipIdList_.Add(other.equipIdList_);
      if (other.SkillDepotId != 0) {
        SkillDepotId = other.SkillDepotId;
      }
      talentIdList_.Add(other.talentIdList_);
      if (other.weapon_ != null) {
        if (weapon_ == null) {
          Weapon = new global::OldProtos.SceneWeaponInfo();
        }
        Weapon.MergeFrom(other.Weapon);
      }
      reliquaryList_.Add(other.reliquaryList_);
      if (other.CoreProudSkillLevel != 0) {
        CoreProudSkillLevel = other.CoreProudSkillLevel;
      }
      inherentProudSkillList_.Add(other.inherentProudSkillList_);
      skillLevelMap_.Add(other.skillLevelMap_);
      proudSkillExtraLevelMap_.Add(other.proudSkillExtraLevelMap_);
      serverBuffList_.Add(other.serverBuffList_);
      teamResonanceList_.Add(other.teamResonanceList_);
      if (other.WearingFlycloakId != 0) {
        WearingFlycloakId = other.WearingFlycloakId;
      }
      if (other.BornTime != 0) {
        BornTime = other.BornTime;
      }
      if (other.CostumeId != 0) {
        CostumeId = other.CostumeId;
      }
      if (other.curVehicleInfo_ != null) {
        if (curVehicleInfo_ == null) {
          CurVehicleInfo = new global::OldProtos.CurVehicleInfo();
        }
        CurVehicleInfo.MergeFrom(other.CurVehicleInfo);
      }
      if (other.excelInfo_ != null) {
        if (excelInfo_ == null) {
          ExcelInfo = new global::OldProtos.AvatarExcelInfo();
        }
        ExcelInfo.MergeFrom(other.ExcelInfo);
      }
      if (other.AnimHash != 0) {
        AnimHash = other.AnimHash;
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 24: {
            Guid = input.ReadUInt64();
            break;
          }
          case 32: {
            PeerId = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            equipIdList_.AddEntriesFrom(input, _repeated_equipIdList_codec);
            break;
          }
          case 48: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            talentIdList_.AddEntriesFrom(input, _repeated_talentIdList_codec);
            break;
          }
          case 66: {
            if (weapon_ == null) {
              Weapon = new global::OldProtos.SceneWeaponInfo();
            }
            input.ReadMessage(Weapon);
            break;
          }
          case 74: {
            reliquaryList_.AddEntriesFrom(input, _repeated_reliquaryList_codec);
            break;
          }
          case 88: {
            CoreProudSkillLevel = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            inherentProudSkillList_.AddEntriesFrom(input, _repeated_inherentProudSkillList_codec);
            break;
          }
          case 106: {
            skillLevelMap_.AddEntriesFrom(input, _map_skillLevelMap_codec);
            break;
          }
          case 114: {
            proudSkillExtraLevelMap_.AddEntriesFrom(input, _map_proudSkillExtraLevelMap_codec);
            break;
          }
          case 122: {
            serverBuffList_.AddEntriesFrom(input, _repeated_serverBuffList_codec);
            break;
          }
          case 130:
          case 128: {
            teamResonanceList_.AddEntriesFrom(input, _repeated_teamResonanceList_codec);
            break;
          }
          case 136: {
            WearingFlycloakId = input.ReadUInt32();
            break;
          }
          case 144: {
            BornTime = input.ReadUInt32();
            break;
          }
          case 152: {
            CostumeId = input.ReadUInt32();
            break;
          }
          case 162: {
            if (curVehicleInfo_ == null) {
              CurVehicleInfo = new global::OldProtos.CurVehicleInfo();
            }
            input.ReadMessage(CurVehicleInfo);
            break;
          }
          case 170: {
            if (excelInfo_ == null) {
              ExcelInfo = new global::OldProtos.AvatarExcelInfo();
            }
            input.ReadMessage(ExcelInfo);
            break;
          }
          case 176: {
            AnimHash = input.ReadUInt32();
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 24: {
            Guid = input.ReadUInt64();
            break;
          }
          case 32: {
            PeerId = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            equipIdList_.AddEntriesFrom(ref input, _repeated_equipIdList_codec);
            break;
          }
          case 48: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            talentIdList_.AddEntriesFrom(ref input, _repeated_talentIdList_codec);
            break;
          }
          case 66: {
            if (weapon_ == null) {
              Weapon = new global::OldProtos.SceneWeaponInfo();
            }
            input.ReadMessage(Weapon);
            break;
          }
          case 74: {
            reliquaryList_.AddEntriesFrom(ref input, _repeated_reliquaryList_codec);
            break;
          }
          case 88: {
            CoreProudSkillLevel = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            inherentProudSkillList_.AddEntriesFrom(ref input, _repeated_inherentProudSkillList_codec);
            break;
          }
          case 106: {
            skillLevelMap_.AddEntriesFrom(ref input, _map_skillLevelMap_codec);
            break;
          }
          case 114: {
            proudSkillExtraLevelMap_.AddEntriesFrom(ref input, _map_proudSkillExtraLevelMap_codec);
            break;
          }
          case 122: {
            serverBuffList_.AddEntriesFrom(ref input, _repeated_serverBuffList_codec);
            break;
          }
          case 130:
          case 128: {
            teamResonanceList_.AddEntriesFrom(ref input, _repeated_teamResonanceList_codec);
            break;
          }
          case 136: {
            WearingFlycloakId = input.ReadUInt32();
            break;
          }
          case 144: {
            BornTime = input.ReadUInt32();
            break;
          }
          case 152: {
            CostumeId = input.ReadUInt32();
            break;
          }
          case 162: {
            if (curVehicleInfo_ == null) {
              CurVehicleInfo = new global::OldProtos.CurVehicleInfo();
            }
            input.ReadMessage(CurVehicleInfo);
            break;
          }
          case 170: {
            if (excelInfo_ == null) {
              ExcelInfo = new global::OldProtos.AvatarExcelInfo();
            }
            input.ReadMessage(ExcelInfo);
            break;
          }
          case 176: {
            AnimHash = input.ReadUInt32();
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
