// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneWeaponInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SceneWeaponInfo.proto</summary>
  public static partial class SceneWeaponInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneWeaponInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneWeaponInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZVdlYXBvbkluZm8ucHJvdG8aGkFiaWxpdHlTeW5jU3RhdGVJbmZv",
            "LnByb3RvGh9FbnRpdHlSZW5kZXJlckNoYW5nZWRJbmZvLnByb3RvIsgCCg9T",
            "Y2VuZVdlYXBvbkluZm8SEQoJZW50aXR5X2lkGAEgASgNEhEKCWdhZGdldF9p",
            "ZBgCIAEoDRIPCgdpdGVtX2lkGAMgASgNEgwKBGd1aWQYBCABKAQSDQoFbGV2",
            "ZWwYBSABKA0SFQoNcHJvbW90ZV9sZXZlbBgGIAEoDRIrCgxhYmlsaXR5X2lu",
            "Zm8YByABKAsyFS5BYmlsaXR5U3luY1N0YXRlSW5mbxIxCglhZmZpeF9tYXAY",
            "CCADKAsyHi5TY2VuZVdlYXBvbkluZm8uQWZmaXhNYXBFbnRyeRI5ChVyZW5k",
            "ZXJlcl9jaGFuZ2VkX2luZm8YCSABKAsyGi5FbnRpdHlSZW5kZXJlckNoYW5n",
            "ZWRJbmZvGi8KDUFmZml4TWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVl",
            "GAIgASgNOgI4AUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.AbilitySyncStateInfoReflection.Descriptor, global::NewProtos.EntityRendererChangedInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SceneWeaponInfo), global::NewProtos.SceneWeaponInfo.Parser, new[]{ "EntityId", "GadgetId", "ItemId", "Guid", "Level", "PromoteLevel", "AbilityInfo", "AffixMap", "RendererChangedInfo" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneWeaponInfo : pb::IMessage<SceneWeaponInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneWeaponInfo> _parser = new pb::MessageParser<SceneWeaponInfo>(() => new SceneWeaponInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneWeaponInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SceneWeaponInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneWeaponInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneWeaponInfo(SceneWeaponInfo other) : this() {
      entityId_ = other.entityId_;
      gadgetId_ = other.gadgetId_;
      itemId_ = other.itemId_;
      guid_ = other.guid_;
      level_ = other.level_;
      promoteLevel_ = other.promoteLevel_;
      abilityInfo_ = other.abilityInfo_ != null ? other.abilityInfo_.Clone() : null;
      affixMap_ = other.affixMap_.Clone();
      rendererChangedInfo_ = other.rendererChangedInfo_ != null ? other.rendererChangedInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneWeaponInfo Clone() {
      return new SceneWeaponInfo(this);
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

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 2;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 3;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 4;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 5;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "promote_level" field.</summary>
    public const int PromoteLevelFieldNumber = 6;
    private uint promoteLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PromoteLevel {
      get { return promoteLevel_; }
      set {
        promoteLevel_ = value;
      }
    }

    /// <summary>Field number for the "ability_info" field.</summary>
    public const int AbilityInfoFieldNumber = 7;
    private global::NewProtos.AbilitySyncStateInfo abilityInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.AbilitySyncStateInfo AbilityInfo {
      get { return abilityInfo_; }
      set {
        abilityInfo_ = value;
      }
    }

    /// <summary>Field number for the "affix_map" field.</summary>
    public const int AffixMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, uint>.Codec _map_affixMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 66);
    private readonly pbc::MapField<uint, uint> affixMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> AffixMap {
      get { return affixMap_; }
    }

    /// <summary>Field number for the "renderer_changed_info" field.</summary>
    public const int RendererChangedInfoFieldNumber = 9;
    private global::NewProtos.EntityRendererChangedInfo rendererChangedInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.EntityRendererChangedInfo RendererChangedInfo {
      get { return rendererChangedInfo_; }
      set {
        rendererChangedInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneWeaponInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneWeaponInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (GadgetId != other.GadgetId) return false;
      if (ItemId != other.ItemId) return false;
      if (Guid != other.Guid) return false;
      if (Level != other.Level) return false;
      if (PromoteLevel != other.PromoteLevel) return false;
      if (!object.Equals(AbilityInfo, other.AbilityInfo)) return false;
      if (!AffixMap.Equals(other.AffixMap)) return false;
      if (!object.Equals(RendererChangedInfo, other.RendererChangedInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (PromoteLevel != 0) hash ^= PromoteLevel.GetHashCode();
      if (abilityInfo_ != null) hash ^= AbilityInfo.GetHashCode();
      hash ^= AffixMap.GetHashCode();
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
      if (GadgetId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GadgetId);
      }
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Guid);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Level);
      }
      if (PromoteLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PromoteLevel);
      }
      if (abilityInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AbilityInfo);
      }
      affixMap_.WriteTo(output, _map_affixMap_codec);
      if (rendererChangedInfo_ != null) {
        output.WriteRawTag(74);
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
      if (GadgetId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GadgetId);
      }
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Guid);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Level);
      }
      if (PromoteLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PromoteLevel);
      }
      if (abilityInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AbilityInfo);
      }
      affixMap_.WriteTo(ref output, _map_affixMap_codec);
      if (rendererChangedInfo_ != null) {
        output.WriteRawTag(74);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (PromoteLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PromoteLevel);
      }
      if (abilityInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityInfo);
      }
      size += affixMap_.CalculateSize(_map_affixMap_codec);
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
    public void MergeFrom(SceneWeaponInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.PromoteLevel != 0) {
        PromoteLevel = other.PromoteLevel;
      }
      if (other.abilityInfo_ != null) {
        if (abilityInfo_ == null) {
          AbilityInfo = new global::NewProtos.AbilitySyncStateInfo();
        }
        AbilityInfo.MergeFrom(other.AbilityInfo);
      }
      affixMap_.MergeFrom(other.affixMap_);
      if (other.rendererChangedInfo_ != null) {
        if (rendererChangedInfo_ == null) {
          RendererChangedInfo = new global::NewProtos.EntityRendererChangedInfo();
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
          case 16: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 24: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            Guid = input.ReadUInt64();
            break;
          }
          case 40: {
            Level = input.ReadUInt32();
            break;
          }
          case 48: {
            PromoteLevel = input.ReadUInt32();
            break;
          }
          case 58: {
            if (abilityInfo_ == null) {
              AbilityInfo = new global::NewProtos.AbilitySyncStateInfo();
            }
            input.ReadMessage(AbilityInfo);
            break;
          }
          case 66: {
            affixMap_.AddEntriesFrom(input, _map_affixMap_codec);
            break;
          }
          case 74: {
            if (rendererChangedInfo_ == null) {
              RendererChangedInfo = new global::NewProtos.EntityRendererChangedInfo();
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
          case 16: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 24: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            Guid = input.ReadUInt64();
            break;
          }
          case 40: {
            Level = input.ReadUInt32();
            break;
          }
          case 48: {
            PromoteLevel = input.ReadUInt32();
            break;
          }
          case 58: {
            if (abilityInfo_ == null) {
              AbilityInfo = new global::NewProtos.AbilitySyncStateInfo();
            }
            input.ReadMessage(AbilityInfo);
            break;
          }
          case 66: {
            affixMap_.AddEntriesFrom(ref input, _map_affixMap_codec);
            break;
          }
          case 74: {
            if (rendererChangedInfo_ == null) {
              RendererChangedInfo = new global::NewProtos.EntityRendererChangedInfo();
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

}

#endregion Designer generated code
