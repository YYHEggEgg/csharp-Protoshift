// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OtherCustomDungeonBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from OtherCustomDungeonBrief.proto</summary>
  public static partial class OtherCustomDungeonBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for OtherCustomDungeonBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OtherCustomDungeonBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1PdGhlckN1c3RvbUR1bmdlb25CcmllZi5wcm90bxobQ3VzdG9tRHVuZ2Vv",
            "bkFic3RyYWN0LnByb3RvGhpDdXN0b21EdW5nZW9uU2V0dGluZy5wcm90bxoZ",
            "Q3VzdG9tRHVuZ2VvblNvY2lhbC5wcm90bxoSU29jaWFsRGV0YWlsLnByb3Rv",
            "ItwCChdPdGhlckN1c3RvbUR1bmdlb25CcmllZhIcChRpc19hZHZlbnR1cmVf",
            "ZHVuZ2VvbhgMIAEoCBIcChRiYXR0bGVfbWluX2Nvc3RfdGltZRgKIAEoDRIQ",
            "Cgh0YWdfbGlzdBgNIAMoDRIRCglpc19zdG9yZWQYCCABKAgSEgoKZHVuZ2Vv",
            "bl9pZBgPIAEoDRIXCg9pc19wc25fcGxhdGZvcm0YASABKAgSFAoMZHVuZ2Vv",
            "bl9ndWlkGAcgASgEEiYKB3NldHRpbmcYAiABKAsyFS5DdXN0b21EdW5nZW9u",
            "U2V0dGluZxIkCgZzb2NpYWwYDiABKAsyFC5DdXN0b21EdW5nZW9uU29jaWFs",
            "EigKCGFic3RyYWN0GAQgASgLMhYuQ3VzdG9tRHVuZ2VvbkFic3RyYWN0EiUK",
            "DmNyZWF0b3JfZGV0YWlsGAsgASgLMg0uU29jaWFsRGV0YWlsQgyqAglOZXdQ",
            "cm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.CustomDungeonAbstractReflection.Descriptor, global::NewProtos.CustomDungeonSettingReflection.Descriptor, global::NewProtos.CustomDungeonSocialReflection.Descriptor, global::NewProtos.SocialDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.OtherCustomDungeonBrief), global::NewProtos.OtherCustomDungeonBrief.Parser, new[]{ "IsAdventureDungeon", "BattleMinCostTime", "TagList", "IsStored", "DungeonId", "IsPsnPlatform", "DungeonGuid", "Setting", "Social", "Abstract", "CreatorDetail" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OtherCustomDungeonBrief : pb::IMessage<OtherCustomDungeonBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OtherCustomDungeonBrief> _parser = new pb::MessageParser<OtherCustomDungeonBrief>(() => new OtherCustomDungeonBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OtherCustomDungeonBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.OtherCustomDungeonBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief(OtherCustomDungeonBrief other) : this() {
      isAdventureDungeon_ = other.isAdventureDungeon_;
      battleMinCostTime_ = other.battleMinCostTime_;
      tagList_ = other.tagList_.Clone();
      isStored_ = other.isStored_;
      dungeonId_ = other.dungeonId_;
      isPsnPlatform_ = other.isPsnPlatform_;
      dungeonGuid_ = other.dungeonGuid_;
      setting_ = other.setting_ != null ? other.setting_.Clone() : null;
      social_ = other.social_ != null ? other.social_.Clone() : null;
      abstract_ = other.abstract_ != null ? other.abstract_.Clone() : null;
      creatorDetail_ = other.creatorDetail_ != null ? other.creatorDetail_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief Clone() {
      return new OtherCustomDungeonBrief(this);
    }

    /// <summary>Field number for the "is_adventure_dungeon" field.</summary>
    public const int IsAdventureDungeonFieldNumber = 12;
    private bool isAdventureDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAdventureDungeon {
      get { return isAdventureDungeon_; }
      set {
        isAdventureDungeon_ = value;
      }
    }

    /// <summary>Field number for the "battle_min_cost_time" field.</summary>
    public const int BattleMinCostTimeFieldNumber = 10;
    private uint battleMinCostTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleMinCostTime {
      get { return battleMinCostTime_; }
      set {
        battleMinCostTime_ = value;
      }
    }

    /// <summary>Field number for the "tag_list" field.</summary>
    public const int TagListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_tagList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> tagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TagList {
      get { return tagList_; }
    }

    /// <summary>Field number for the "is_stored" field.</summary>
    public const int IsStoredFieldNumber = 8;
    private bool isStored_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStored {
      get { return isStored_; }
      set {
        isStored_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 15;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "is_psn_platform" field.</summary>
    public const int IsPsnPlatformFieldNumber = 1;
    private bool isPsnPlatform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPsnPlatform {
      get { return isPsnPlatform_; }
      set {
        isPsnPlatform_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_guid" field.</summary>
    public const int DungeonGuidFieldNumber = 7;
    private ulong dungeonGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DungeonGuid {
      get { return dungeonGuid_; }
      set {
        dungeonGuid_ = value;
      }
    }

    /// <summary>Field number for the "setting" field.</summary>
    public const int SettingFieldNumber = 2;
    private global::NewProtos.CustomDungeonSetting setting_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.CustomDungeonSetting Setting {
      get { return setting_; }
      set {
        setting_ = value;
      }
    }

    /// <summary>Field number for the "social" field.</summary>
    public const int SocialFieldNumber = 14;
    private global::NewProtos.CustomDungeonSocial social_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.CustomDungeonSocial Social {
      get { return social_; }
      set {
        social_ = value;
      }
    }

    /// <summary>Field number for the "abstract" field.</summary>
    public const int AbstractFieldNumber = 4;
    private global::NewProtos.CustomDungeonAbstract abstract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.CustomDungeonAbstract Abstract {
      get { return abstract_; }
      set {
        abstract_ = value;
      }
    }

    /// <summary>Field number for the "creator_detail" field.</summary>
    public const int CreatorDetailFieldNumber = 11;
    private global::NewProtos.SocialDetail creatorDetail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.SocialDetail CreatorDetail {
      get { return creatorDetail_; }
      set {
        creatorDetail_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OtherCustomDungeonBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OtherCustomDungeonBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAdventureDungeon != other.IsAdventureDungeon) return false;
      if (BattleMinCostTime != other.BattleMinCostTime) return false;
      if(!tagList_.Equals(other.tagList_)) return false;
      if (IsStored != other.IsStored) return false;
      if (DungeonId != other.DungeonId) return false;
      if (IsPsnPlatform != other.IsPsnPlatform) return false;
      if (DungeonGuid != other.DungeonGuid) return false;
      if (!object.Equals(Setting, other.Setting)) return false;
      if (!object.Equals(Social, other.Social)) return false;
      if (!object.Equals(Abstract, other.Abstract)) return false;
      if (!object.Equals(CreatorDetail, other.CreatorDetail)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAdventureDungeon != false) hash ^= IsAdventureDungeon.GetHashCode();
      if (BattleMinCostTime != 0) hash ^= BattleMinCostTime.GetHashCode();
      hash ^= tagList_.GetHashCode();
      if (IsStored != false) hash ^= IsStored.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (IsPsnPlatform != false) hash ^= IsPsnPlatform.GetHashCode();
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
      if (setting_ != null) hash ^= Setting.GetHashCode();
      if (social_ != null) hash ^= Social.GetHashCode();
      if (abstract_ != null) hash ^= Abstract.GetHashCode();
      if (creatorDetail_ != null) hash ^= CreatorDetail.GetHashCode();
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
      if (IsPsnPlatform != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsPsnPlatform);
      }
      if (setting_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Setting);
      }
      if (abstract_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Abstract);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(DungeonGuid);
      }
      if (IsStored != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsStored);
      }
      if (BattleMinCostTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BattleMinCostTime);
      }
      if (creatorDetail_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreatorDetail);
      }
      if (IsAdventureDungeon != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsAdventureDungeon);
      }
      tagList_.WriteTo(output, _repeated_tagList_codec);
      if (social_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Social);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DungeonId);
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
      if (IsPsnPlatform != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsPsnPlatform);
      }
      if (setting_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Setting);
      }
      if (abstract_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Abstract);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(DungeonGuid);
      }
      if (IsStored != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsStored);
      }
      if (BattleMinCostTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BattleMinCostTime);
      }
      if (creatorDetail_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CreatorDetail);
      }
      if (IsAdventureDungeon != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsAdventureDungeon);
      }
      tagList_.WriteTo(ref output, _repeated_tagList_codec);
      if (social_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Social);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DungeonId);
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
      if (IsAdventureDungeon != false) {
        size += 1 + 1;
      }
      if (BattleMinCostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleMinCostTime);
      }
      size += tagList_.CalculateSize(_repeated_tagList_codec);
      if (IsStored != false) {
        size += 1 + 1;
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (IsPsnPlatform != false) {
        size += 1 + 1;
      }
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (setting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Setting);
      }
      if (social_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Social);
      }
      if (abstract_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Abstract);
      }
      if (creatorDetail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatorDetail);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OtherCustomDungeonBrief other) {
      if (other == null) {
        return;
      }
      if (other.IsAdventureDungeon != false) {
        IsAdventureDungeon = other.IsAdventureDungeon;
      }
      if (other.BattleMinCostTime != 0) {
        BattleMinCostTime = other.BattleMinCostTime;
      }
      tagList_.Add(other.tagList_);
      if (other.IsStored != false) {
        IsStored = other.IsStored;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.IsPsnPlatform != false) {
        IsPsnPlatform = other.IsPsnPlatform;
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
      }
      if (other.setting_ != null) {
        if (setting_ == null) {
          Setting = new global::NewProtos.CustomDungeonSetting();
        }
        Setting.MergeFrom(other.Setting);
      }
      if (other.social_ != null) {
        if (social_ == null) {
          Social = new global::NewProtos.CustomDungeonSocial();
        }
        Social.MergeFrom(other.Social);
      }
      if (other.abstract_ != null) {
        if (abstract_ == null) {
          Abstract = new global::NewProtos.CustomDungeonAbstract();
        }
        Abstract.MergeFrom(other.Abstract);
      }
      if (other.creatorDetail_ != null) {
        if (creatorDetail_ == null) {
          CreatorDetail = new global::NewProtos.SocialDetail();
        }
        CreatorDetail.MergeFrom(other.CreatorDetail);
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
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 18: {
            if (setting_ == null) {
              Setting = new global::NewProtos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 34: {
            if (abstract_ == null) {
              Abstract = new global::NewProtos.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 56: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 64: {
            IsStored = input.ReadBool();
            break;
          }
          case 80: {
            BattleMinCostTime = input.ReadUInt32();
            break;
          }
          case 90: {
            if (creatorDetail_ == null) {
              CreatorDetail = new global::NewProtos.SocialDetail();
            }
            input.ReadMessage(CreatorDetail);
            break;
          }
          case 96: {
            IsAdventureDungeon = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
            break;
          }
          case 114: {
            if (social_ == null) {
              Social = new global::NewProtos.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
            break;
          }
          case 120: {
            DungeonId = input.ReadUInt32();
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
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 18: {
            if (setting_ == null) {
              Setting = new global::NewProtos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 34: {
            if (abstract_ == null) {
              Abstract = new global::NewProtos.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 56: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 64: {
            IsStored = input.ReadBool();
            break;
          }
          case 80: {
            BattleMinCostTime = input.ReadUInt32();
            break;
          }
          case 90: {
            if (creatorDetail_ == null) {
              CreatorDetail = new global::NewProtos.SocialDetail();
            }
            input.ReadMessage(CreatorDetail);
            break;
          }
          case 96: {
            IsAdventureDungeon = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
            break;
          }
          case 114: {
            if (social_ == null) {
              Social = new global::NewProtos.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
            break;
          }
          case 120: {
            DungeonId = input.ReadUInt32();
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
