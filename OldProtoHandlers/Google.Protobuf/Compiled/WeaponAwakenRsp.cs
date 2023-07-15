// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WeaponAwakenRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from WeaponAwakenRsp.proto</summary>
  public static partial class WeaponAwakenRspReflection {

    #region Descriptor
    /// <summary>File descriptor for WeaponAwakenRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeaponAwakenRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXZWFwb25Bd2FrZW5Sc3AucHJvdG8i8wIKD1dlYXBvbkF3YWtlblJzcBIP",
            "CgdyZXRjb2RlGAkgASgFEhMKC2F2YXRhcl9ndWlkGAogASgEEkMKE29sZF9h",
            "ZmZpeF9sZXZlbF9tYXAYBCADKAsyJi5XZWFwb25Bd2FrZW5Sc3AuT2xkQWZm",
            "aXhMZXZlbE1hcEVudHJ5EiIKGnRhcmdldF93ZWFwb25fYXdha2VuX2xldmVs",
            "GAIgASgNEhoKEnRhcmdldF93ZWFwb25fZ3VpZBgPIAEoBBJDChNjdXJfYWZm",
            "aXhfbGV2ZWxfbWFwGAsgAygLMiYuV2VhcG9uQXdha2VuUnNwLkN1ckFmZml4",
            "TGV2ZWxNYXBFbnRyeRo3ChVPbGRBZmZpeExldmVsTWFwRW50cnkSCwoDa2V5",
            "GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4ARo3ChVDdXJBZmZpeExldmVsTWFw",
            "RW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIMqgIJT2xk",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.WeaponAwakenRsp), global::OldProtos.WeaponAwakenRsp.Parser, new[]{ "Retcode", "AvatarGuid", "OldAffixLevelMap", "TargetWeaponAwakenLevel", "TargetWeaponGuid", "CurAffixLevelMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 606
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class WeaponAwakenRsp : pb::IMessage<WeaponAwakenRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WeaponAwakenRsp> _parser = new pb::MessageParser<WeaponAwakenRsp>(() => new WeaponAwakenRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WeaponAwakenRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.WeaponAwakenRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenRsp(WeaponAwakenRsp other) : this() {
      retcode_ = other.retcode_;
      avatarGuid_ = other.avatarGuid_;
      oldAffixLevelMap_ = other.oldAffixLevelMap_.Clone();
      targetWeaponAwakenLevel_ = other.targetWeaponAwakenLevel_;
      targetWeaponGuid_ = other.targetWeaponGuid_;
      curAffixLevelMap_ = other.curAffixLevelMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenRsp Clone() {
      return new WeaponAwakenRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 10;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "old_affix_level_map" field.</summary>
    public const int OldAffixLevelMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, uint>.Codec _map_oldAffixLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
    private readonly pbc::MapField<uint, uint> oldAffixLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> OldAffixLevelMap {
      get { return oldAffixLevelMap_; }
    }

    /// <summary>Field number for the "target_weapon_awaken_level" field.</summary>
    public const int TargetWeaponAwakenLevelFieldNumber = 2;
    private uint targetWeaponAwakenLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetWeaponAwakenLevel {
      get { return targetWeaponAwakenLevel_; }
      set {
        targetWeaponAwakenLevel_ = value;
      }
    }

    /// <summary>Field number for the "target_weapon_guid" field.</summary>
    public const int TargetWeaponGuidFieldNumber = 15;
    private ulong targetWeaponGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetWeaponGuid {
      get { return targetWeaponGuid_; }
      set {
        targetWeaponGuid_ = value;
      }
    }

    /// <summary>Field number for the "cur_affix_level_map" field.</summary>
    public const int CurAffixLevelMapFieldNumber = 11;
    private static readonly pbc::MapField<uint, uint>.Codec _map_curAffixLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 90);
    private readonly pbc::MapField<uint, uint> curAffixLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> CurAffixLevelMap {
      get { return curAffixLevelMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WeaponAwakenRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WeaponAwakenRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      if (!OldAffixLevelMap.Equals(other.OldAffixLevelMap)) return false;
      if (TargetWeaponAwakenLevel != other.TargetWeaponAwakenLevel) return false;
      if (TargetWeaponGuid != other.TargetWeaponGuid) return false;
      if (!CurAffixLevelMap.Equals(other.CurAffixLevelMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      hash ^= OldAffixLevelMap.GetHashCode();
      if (TargetWeaponAwakenLevel != 0) hash ^= TargetWeaponAwakenLevel.GetHashCode();
      if (TargetWeaponGuid != 0UL) hash ^= TargetWeaponGuid.GetHashCode();
      hash ^= CurAffixLevelMap.GetHashCode();
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
      if (TargetWeaponAwakenLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TargetWeaponAwakenLevel);
      }
      oldAffixLevelMap_.WriteTo(output, _map_oldAffixLevelMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(AvatarGuid);
      }
      curAffixLevelMap_.WriteTo(output, _map_curAffixLevelMap_codec);
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(TargetWeaponGuid);
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
      if (TargetWeaponAwakenLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TargetWeaponAwakenLevel);
      }
      oldAffixLevelMap_.WriteTo(ref output, _map_oldAffixLevelMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(AvatarGuid);
      }
      curAffixLevelMap_.WriteTo(ref output, _map_curAffixLevelMap_codec);
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(TargetWeaponGuid);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      size += oldAffixLevelMap_.CalculateSize(_map_oldAffixLevelMap_codec);
      if (TargetWeaponAwakenLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetWeaponAwakenLevel);
      }
      if (TargetWeaponGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetWeaponGuid);
      }
      size += curAffixLevelMap_.CalculateSize(_map_curAffixLevelMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WeaponAwakenRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      oldAffixLevelMap_.MergeFrom(other.oldAffixLevelMap_);
      if (other.TargetWeaponAwakenLevel != 0) {
        TargetWeaponAwakenLevel = other.TargetWeaponAwakenLevel;
      }
      if (other.TargetWeaponGuid != 0UL) {
        TargetWeaponGuid = other.TargetWeaponGuid;
      }
      curAffixLevelMap_.MergeFrom(other.curAffixLevelMap_);
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
          case 16: {
            TargetWeaponAwakenLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            oldAffixLevelMap_.AddEntriesFrom(input, _map_oldAffixLevelMap_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 90: {
            curAffixLevelMap_.AddEntriesFrom(input, _map_curAffixLevelMap_codec);
            break;
          }
          case 120: {
            TargetWeaponGuid = input.ReadUInt64();
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
          case 16: {
            TargetWeaponAwakenLevel = input.ReadUInt32();
            break;
          }
          case 34: {
            oldAffixLevelMap_.AddEntriesFrom(ref input, _map_oldAffixLevelMap_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 90: {
            curAffixLevelMap_.AddEntriesFrom(ref input, _map_curAffixLevelMap_codec);
            break;
          }
          case 120: {
            TargetWeaponGuid = input.ReadUInt64();
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
