// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarSkillDepotChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from AvatarSkillDepotChangeNotify.proto</summary>
  public static partial class AvatarSkillDepotChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarSkillDepotChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarSkillDepotChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBdmF0YXJTa2lsbERlcG90Q2hhbmdlTm90aWZ5LnByb3RvItIDChxBdmF0",
            "YXJTa2lsbERlcG90Q2hhbmdlTm90aWZ5El8KG3Byb3VkX3NraWxsX2V4dHJh",
            "X2xldmVsX21hcBgJIAMoCzI6LkF2YXRhclNraWxsRGVwb3RDaGFuZ2VOb3Rp",
            "ZnkuUHJvdWRTa2lsbEV4dHJhTGV2ZWxNYXBFbnRyeRIYChBwcm91ZF9za2ls",
            "bF9saXN0GAMgAygNEhEKCWVudGl0eV9pZBgFIAEoDRITCgthdmF0YXJfZ3Vp",
            "ZBgHIAEoBBJJCg9za2lsbF9sZXZlbF9tYXAYASADKAsyMC5BdmF0YXJTa2ls",
            "bERlcG90Q2hhbmdlTm90aWZ5LlNraWxsTGV2ZWxNYXBFbnRyeRIWCg5za2ls",
            "bF9kZXBvdF9pZBgNIAEoDRIWCg50YWxlbnRfaWRfbGlzdBgOIAMoDRIeChZj",
            "b3JlX3Byb3VkX3NraWxsX2xldmVsGA8gASgNGj4KHFByb3VkU2tpbGxFeHRy",
            "YUxldmVsTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4",
            "ARo0ChJTa2lsbExldmVsTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVl",
            "GAIgASgNOgI4AUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.AvatarSkillDepotChangeNotify), global::NewProtos.AvatarSkillDepotChangeNotify.Parser, new[]{ "ProudSkillExtraLevelMap", "ProudSkillList", "EntityId", "AvatarGuid", "SkillLevelMap", "SkillDepotId", "TalentIdList", "CoreProudSkillLevel" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1019;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AvatarSkillDepotChangeNotify : pb::IMessage<AvatarSkillDepotChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarSkillDepotChangeNotify> _parser = new pb::MessageParser<AvatarSkillDepotChangeNotify>(() => new AvatarSkillDepotChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarSkillDepotChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.AvatarSkillDepotChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillDepotChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillDepotChangeNotify(AvatarSkillDepotChangeNotify other) : this() {
      proudSkillExtraLevelMap_ = other.proudSkillExtraLevelMap_.Clone();
      proudSkillList_ = other.proudSkillList_.Clone();
      entityId_ = other.entityId_;
      avatarGuid_ = other.avatarGuid_;
      skillLevelMap_ = other.skillLevelMap_.Clone();
      skillDepotId_ = other.skillDepotId_;
      talentIdList_ = other.talentIdList_.Clone();
      coreProudSkillLevel_ = other.coreProudSkillLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillDepotChangeNotify Clone() {
      return new AvatarSkillDepotChangeNotify(this);
    }

    /// <summary>Field number for the "proud_skill_extra_level_map" field.</summary>
    public const int ProudSkillExtraLevelMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, uint>.Codec _map_proudSkillExtraLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 74);
    private readonly pbc::MapField<uint, uint> proudSkillExtraLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> ProudSkillExtraLevelMap {
      get { return proudSkillExtraLevelMap_; }
    }

    /// <summary>Field number for the "proud_skill_list" field.</summary>
    public const int ProudSkillListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_proudSkillList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> proudSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ProudSkillList {
      get { return proudSkillList_; }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 5;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 7;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "skill_level_map" field.</summary>
    public const int SkillLevelMapFieldNumber = 1;
    private static readonly pbc::MapField<uint, uint>.Codec _map_skillLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 10);
    private readonly pbc::MapField<uint, uint> skillLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SkillLevelMap {
      get { return skillLevelMap_; }
    }

    /// <summary>Field number for the "skill_depot_id" field.</summary>
    public const int SkillDepotIdFieldNumber = 13;
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
    public const int TalentIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_talentIdList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> talentIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TalentIdList {
      get { return talentIdList_; }
    }

    /// <summary>Field number for the "core_proud_skill_level" field.</summary>
    public const int CoreProudSkillLevelFieldNumber = 15;
    private uint coreProudSkillLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoreProudSkillLevel {
      get { return coreProudSkillLevel_; }
      set {
        coreProudSkillLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarSkillDepotChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarSkillDepotChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ProudSkillExtraLevelMap.Equals(other.ProudSkillExtraLevelMap)) return false;
      if(!proudSkillList_.Equals(other.proudSkillList_)) return false;
      if (EntityId != other.EntityId) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      if (!SkillLevelMap.Equals(other.SkillLevelMap)) return false;
      if (SkillDepotId != other.SkillDepotId) return false;
      if(!talentIdList_.Equals(other.talentIdList_)) return false;
      if (CoreProudSkillLevel != other.CoreProudSkillLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ProudSkillExtraLevelMap.GetHashCode();
      hash ^= proudSkillList_.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      hash ^= SkillLevelMap.GetHashCode();
      if (SkillDepotId != 0) hash ^= SkillDepotId.GetHashCode();
      hash ^= talentIdList_.GetHashCode();
      if (CoreProudSkillLevel != 0) hash ^= CoreProudSkillLevel.GetHashCode();
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
      skillLevelMap_.WriteTo(output, _map_skillLevelMap_codec);
      proudSkillList_.WriteTo(output, _repeated_proudSkillList_codec);
      if (EntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EntityId);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(AvatarGuid);
      }
      proudSkillExtraLevelMap_.WriteTo(output, _map_proudSkillExtraLevelMap_codec);
      if (SkillDepotId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SkillDepotId);
      }
      talentIdList_.WriteTo(output, _repeated_talentIdList_codec);
      if (CoreProudSkillLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CoreProudSkillLevel);
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
      skillLevelMap_.WriteTo(ref output, _map_skillLevelMap_codec);
      proudSkillList_.WriteTo(ref output, _repeated_proudSkillList_codec);
      if (EntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EntityId);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(AvatarGuid);
      }
      proudSkillExtraLevelMap_.WriteTo(ref output, _map_proudSkillExtraLevelMap_codec);
      if (SkillDepotId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SkillDepotId);
      }
      talentIdList_.WriteTo(ref output, _repeated_talentIdList_codec);
      if (CoreProudSkillLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CoreProudSkillLevel);
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
      size += proudSkillExtraLevelMap_.CalculateSize(_map_proudSkillExtraLevelMap_codec);
      size += proudSkillList_.CalculateSize(_repeated_proudSkillList_codec);
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      size += skillLevelMap_.CalculateSize(_map_skillLevelMap_codec);
      if (SkillDepotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillDepotId);
      }
      size += talentIdList_.CalculateSize(_repeated_talentIdList_codec);
      if (CoreProudSkillLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoreProudSkillLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarSkillDepotChangeNotify other) {
      if (other == null) {
        return;
      }
      proudSkillExtraLevelMap_.MergeFrom(other.proudSkillExtraLevelMap_);
      proudSkillList_.Add(other.proudSkillList_);
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      skillLevelMap_.MergeFrom(other.skillLevelMap_);
      if (other.SkillDepotId != 0) {
        SkillDepotId = other.SkillDepotId;
      }
      talentIdList_.Add(other.talentIdList_);
      if (other.CoreProudSkillLevel != 0) {
        CoreProudSkillLevel = other.CoreProudSkillLevel;
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
          case 10: {
            skillLevelMap_.AddEntriesFrom(input, _map_skillLevelMap_codec);
            break;
          }
          case 26:
          case 24: {
            proudSkillList_.AddEntriesFrom(input, _repeated_proudSkillList_codec);
            break;
          }
          case 40: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 56: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 74: {
            proudSkillExtraLevelMap_.AddEntriesFrom(input, _map_proudSkillExtraLevelMap_codec);
            break;
          }
          case 104: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            talentIdList_.AddEntriesFrom(input, _repeated_talentIdList_codec);
            break;
          }
          case 120: {
            CoreProudSkillLevel = input.ReadUInt32();
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
            skillLevelMap_.AddEntriesFrom(ref input, _map_skillLevelMap_codec);
            break;
          }
          case 26:
          case 24: {
            proudSkillList_.AddEntriesFrom(ref input, _repeated_proudSkillList_codec);
            break;
          }
          case 40: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 56: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 74: {
            proudSkillExtraLevelMap_.AddEntriesFrom(ref input, _map_proudSkillExtraLevelMap_codec);
            break;
          }
          case 104: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            talentIdList_.AddEntriesFrom(ref input, _repeated_talentIdList_codec);
            break;
          }
          case 120: {
            CoreProudSkillLevel = input.ReadUInt32();
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
