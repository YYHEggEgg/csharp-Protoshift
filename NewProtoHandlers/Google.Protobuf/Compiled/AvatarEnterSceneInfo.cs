// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarEnterSceneInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AvatarEnterSceneInfo.proto</summary>
public static partial class AvatarEnterSceneInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for AvatarEnterSceneInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AvatarEnterSceneInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpBdmF0YXJFbnRlclNjZW5lSW5mby5wcm90bxoaQWJpbGl0eVN5bmNTdGF0",
          "ZUluZm8ucHJvdG8aEFNlcnZlckJ1ZmYucHJvdG8imQIKFEF2YXRhckVudGVy",
          "U2NlbmVJbmZvEhgKEHdlYXBvbl9lbnRpdHlfaWQYBSABKA0SEwoLYXZhdGFy",
          "X2d1aWQYCSABKAQSGAoQYXZhdGFyX2VudGl0eV9pZBgNIAEoDRIlChBzZXJ2",
          "ZXJfYnVmZl9saXN0GAcgAygLMgsuU2VydmVyQnVmZhIyChN3ZWFwb25fYWJp",
          "bGl0eV9pbmZvGAYgASgLMhUuQWJpbGl0eVN5bmNTdGF0ZUluZm8SFAoMYnVm",
          "Zl9pZF9saXN0GAggAygNEjIKE2F2YXRhcl9hYmlsaXR5X2luZm8YASABKAsy",
          "FS5BYmlsaXR5U3luY1N0YXRlSW5mbxITCgt3ZWFwb25fZ3VpZBgPIAEoBEIW",
          "ChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::AbilitySyncStateInfoReflection.Descriptor, global::ServerBuffReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AvatarEnterSceneInfo), global::AvatarEnterSceneInfo.Parser, new[]{ "WeaponEntityId", "AvatarGuid", "AvatarEntityId", "ServerBuffList", "WeaponAbilityInfo", "BuffIdList", "AvatarAbilityInfo", "WeaponGuid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AvatarEnterSceneInfo : pb::IMessage<AvatarEnterSceneInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AvatarEnterSceneInfo> _parser = new pb::MessageParser<AvatarEnterSceneInfo>(() => new AvatarEnterSceneInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AvatarEnterSceneInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AvatarEnterSceneInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarEnterSceneInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarEnterSceneInfo(AvatarEnterSceneInfo other) : this() {
    weaponEntityId_ = other.weaponEntityId_;
    avatarGuid_ = other.avatarGuid_;
    avatarEntityId_ = other.avatarEntityId_;
    serverBuffList_ = other.serverBuffList_.Clone();
    weaponAbilityInfo_ = other.weaponAbilityInfo_ != null ? other.weaponAbilityInfo_.Clone() : null;
    buffIdList_ = other.buffIdList_.Clone();
    avatarAbilityInfo_ = other.avatarAbilityInfo_ != null ? other.avatarAbilityInfo_.Clone() : null;
    weaponGuid_ = other.weaponGuid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarEnterSceneInfo Clone() {
    return new AvatarEnterSceneInfo(this);
  }

  /// <summary>Field number for the "weapon_entity_id" field.</summary>
  public const int WeaponEntityIdFieldNumber = 5;
  private uint weaponEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WeaponEntityId {
    get { return weaponEntityId_; }
    set {
      weaponEntityId_ = value;
    }
  }

  /// <summary>Field number for the "avatar_guid" field.</summary>
  public const int AvatarGuidFieldNumber = 9;
  private ulong avatarGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong AvatarGuid {
    get { return avatarGuid_; }
    set {
      avatarGuid_ = value;
    }
  }

  /// <summary>Field number for the "avatar_entity_id" field.</summary>
  public const int AvatarEntityIdFieldNumber = 13;
  private uint avatarEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AvatarEntityId {
    get { return avatarEntityId_; }
    set {
      avatarEntityId_ = value;
    }
  }

  /// <summary>Field number for the "server_buff_list" field.</summary>
  public const int ServerBuffListFieldNumber = 7;
  private static readonly pb::FieldCodec<global::ServerBuff> _repeated_serverBuffList_codec
      = pb::FieldCodec.ForMessage(58, global::ServerBuff.Parser);
  private readonly pbc::RepeatedField<global::ServerBuff> serverBuffList_ = new pbc::RepeatedField<global::ServerBuff>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ServerBuff> ServerBuffList {
    get { return serverBuffList_; }
  }

  /// <summary>Field number for the "weapon_ability_info" field.</summary>
  public const int WeaponAbilityInfoFieldNumber = 6;
  private global::AbilitySyncStateInfo weaponAbilityInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AbilitySyncStateInfo WeaponAbilityInfo {
    get { return weaponAbilityInfo_; }
    set {
      weaponAbilityInfo_ = value;
    }
  }

  /// <summary>Field number for the "buff_id_list" field.</summary>
  public const int BuffIdListFieldNumber = 8;
  private static readonly pb::FieldCodec<uint> _repeated_buffIdList_codec
      = pb::FieldCodec.ForUInt32(66);
  private readonly pbc::RepeatedField<uint> buffIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> BuffIdList {
    get { return buffIdList_; }
  }

  /// <summary>Field number for the "avatar_ability_info" field.</summary>
  public const int AvatarAbilityInfoFieldNumber = 1;
  private global::AbilitySyncStateInfo avatarAbilityInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AbilitySyncStateInfo AvatarAbilityInfo {
    get { return avatarAbilityInfo_; }
    set {
      avatarAbilityInfo_ = value;
    }
  }

  /// <summary>Field number for the "weapon_guid" field.</summary>
  public const int WeaponGuidFieldNumber = 15;
  private ulong weaponGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong WeaponGuid {
    get { return weaponGuid_; }
    set {
      weaponGuid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AvatarEnterSceneInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AvatarEnterSceneInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (WeaponEntityId != other.WeaponEntityId) return false;
    if (AvatarGuid != other.AvatarGuid) return false;
    if (AvatarEntityId != other.AvatarEntityId) return false;
    if(!serverBuffList_.Equals(other.serverBuffList_)) return false;
    if (!object.Equals(WeaponAbilityInfo, other.WeaponAbilityInfo)) return false;
    if(!buffIdList_.Equals(other.buffIdList_)) return false;
    if (!object.Equals(AvatarAbilityInfo, other.AvatarAbilityInfo)) return false;
    if (WeaponGuid != other.WeaponGuid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (WeaponEntityId != 0) hash ^= WeaponEntityId.GetHashCode();
    if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
    if (AvatarEntityId != 0) hash ^= AvatarEntityId.GetHashCode();
    hash ^= serverBuffList_.GetHashCode();
    if (weaponAbilityInfo_ != null) hash ^= WeaponAbilityInfo.GetHashCode();
    hash ^= buffIdList_.GetHashCode();
    if (avatarAbilityInfo_ != null) hash ^= AvatarAbilityInfo.GetHashCode();
    if (WeaponGuid != 0UL) hash ^= WeaponGuid.GetHashCode();
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
    if (avatarAbilityInfo_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(AvatarAbilityInfo);
    }
    if (WeaponEntityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(WeaponEntityId);
    }
    if (weaponAbilityInfo_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(WeaponAbilityInfo);
    }
    serverBuffList_.WriteTo(output, _repeated_serverBuffList_codec);
    buffIdList_.WriteTo(output, _repeated_buffIdList_codec);
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(72);
      output.WriteUInt64(AvatarGuid);
    }
    if (AvatarEntityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(AvatarEntityId);
    }
    if (WeaponGuid != 0UL) {
      output.WriteRawTag(120);
      output.WriteUInt64(WeaponGuid);
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
    if (avatarAbilityInfo_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(AvatarAbilityInfo);
    }
    if (WeaponEntityId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(WeaponEntityId);
    }
    if (weaponAbilityInfo_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(WeaponAbilityInfo);
    }
    serverBuffList_.WriteTo(ref output, _repeated_serverBuffList_codec);
    buffIdList_.WriteTo(ref output, _repeated_buffIdList_codec);
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(72);
      output.WriteUInt64(AvatarGuid);
    }
    if (AvatarEntityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(AvatarEntityId);
    }
    if (WeaponGuid != 0UL) {
      output.WriteRawTag(120);
      output.WriteUInt64(WeaponGuid);
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
    if (WeaponEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeaponEntityId);
    }
    if (AvatarGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
    }
    if (AvatarEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarEntityId);
    }
    size += serverBuffList_.CalculateSize(_repeated_serverBuffList_codec);
    if (weaponAbilityInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(WeaponAbilityInfo);
    }
    size += buffIdList_.CalculateSize(_repeated_buffIdList_codec);
    if (avatarAbilityInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(AvatarAbilityInfo);
    }
    if (WeaponGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(WeaponGuid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AvatarEnterSceneInfo other) {
    if (other == null) {
      return;
    }
    if (other.WeaponEntityId != 0) {
      WeaponEntityId = other.WeaponEntityId;
    }
    if (other.AvatarGuid != 0UL) {
      AvatarGuid = other.AvatarGuid;
    }
    if (other.AvatarEntityId != 0) {
      AvatarEntityId = other.AvatarEntityId;
    }
    serverBuffList_.Add(other.serverBuffList_);
    if (other.weaponAbilityInfo_ != null) {
      if (weaponAbilityInfo_ == null) {
        WeaponAbilityInfo = new global::AbilitySyncStateInfo();
      }
      WeaponAbilityInfo.MergeFrom(other.WeaponAbilityInfo);
    }
    buffIdList_.Add(other.buffIdList_);
    if (other.avatarAbilityInfo_ != null) {
      if (avatarAbilityInfo_ == null) {
        AvatarAbilityInfo = new global::AbilitySyncStateInfo();
      }
      AvatarAbilityInfo.MergeFrom(other.AvatarAbilityInfo);
    }
    if (other.WeaponGuid != 0UL) {
      WeaponGuid = other.WeaponGuid;
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
          if (avatarAbilityInfo_ == null) {
            AvatarAbilityInfo = new global::AbilitySyncStateInfo();
          }
          input.ReadMessage(AvatarAbilityInfo);
          break;
        }
        case 40: {
          WeaponEntityId = input.ReadUInt32();
          break;
        }
        case 50: {
          if (weaponAbilityInfo_ == null) {
            WeaponAbilityInfo = new global::AbilitySyncStateInfo();
          }
          input.ReadMessage(WeaponAbilityInfo);
          break;
        }
        case 58: {
          serverBuffList_.AddEntriesFrom(input, _repeated_serverBuffList_codec);
          break;
        }
        case 66:
        case 64: {
          buffIdList_.AddEntriesFrom(input, _repeated_buffIdList_codec);
          break;
        }
        case 72: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 104: {
          AvatarEntityId = input.ReadUInt32();
          break;
        }
        case 120: {
          WeaponGuid = input.ReadUInt64();
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
          if (avatarAbilityInfo_ == null) {
            AvatarAbilityInfo = new global::AbilitySyncStateInfo();
          }
          input.ReadMessage(AvatarAbilityInfo);
          break;
        }
        case 40: {
          WeaponEntityId = input.ReadUInt32();
          break;
        }
        case 50: {
          if (weaponAbilityInfo_ == null) {
            WeaponAbilityInfo = new global::AbilitySyncStateInfo();
          }
          input.ReadMessage(WeaponAbilityInfo);
          break;
        }
        case 58: {
          serverBuffList_.AddEntriesFrom(ref input, _repeated_serverBuffList_codec);
          break;
        }
        case 66:
        case 64: {
          buffIdList_.AddEntriesFrom(ref input, _repeated_buffIdList_codec);
          break;
        }
        case 72: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 104: {
          AvatarEntityId = input.ReadUInt32();
          break;
        }
        case 120: {
          WeaponGuid = input.ReadUInt64();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
