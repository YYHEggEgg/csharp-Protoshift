// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarTeamAllDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AvatarTeamAllDataNotify.proto</summary>
public static partial class AvatarTeamAllDataNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for AvatarTeamAllDataNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AvatarTeamAllDataNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1BdmF0YXJUZWFtQWxsRGF0YU5vdGlmeS5wcm90bxoQQXZhdGFyVGVhbS5w",
          "cm90byLoAQoXQXZhdGFyVGVhbUFsbERhdGFOb3RpZnkSHQoVdGVtcF9hdmF0",
          "YXJfZ3VpZF9saXN0GAIgAygEEiUKHWJhY2t1cF9hdmF0YXJfdGVhbV9vcmRl",
          "cl9saXN0GAogAygNEkQKD2F2YXRhcl90ZWFtX21hcBgFIAMoCzIrLkF2YXRh",
          "clRlYW1BbGxEYXRhTm90aWZ5LkF2YXRhclRlYW1NYXBFbnRyeRpBChJBdmF0",
          "YXJUZWFtTWFwRW50cnkSCwoDa2V5GAEgASgNEhoKBXZhbHVlGAIgASgLMgsu",
          "QXZhdGFyVGVhbToCOAFCFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3Rv",
          "Mw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::AvatarTeamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AvatarTeamAllDataNotify), global::AvatarTeamAllDataNotify.Parser, new[]{ "TempAvatarGuidList", "BackupAvatarTeamOrderList", "AvatarTeamMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 1615;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class AvatarTeamAllDataNotify : pb::IMessage<AvatarTeamAllDataNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AvatarTeamAllDataNotify> _parser = new pb::MessageParser<AvatarTeamAllDataNotify>(() => new AvatarTeamAllDataNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AvatarTeamAllDataNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AvatarTeamAllDataNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarTeamAllDataNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarTeamAllDataNotify(AvatarTeamAllDataNotify other) : this() {
    tempAvatarGuidList_ = other.tempAvatarGuidList_.Clone();
    backupAvatarTeamOrderList_ = other.backupAvatarTeamOrderList_.Clone();
    avatarTeamMap_ = other.avatarTeamMap_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarTeamAllDataNotify Clone() {
    return new AvatarTeamAllDataNotify(this);
  }

  /// <summary>Field number for the "temp_avatar_guid_list" field.</summary>
  public const int TempAvatarGuidListFieldNumber = 2;
  private static readonly pb::FieldCodec<ulong> _repeated_tempAvatarGuidList_codec
      = pb::FieldCodec.ForUInt64(18);
  private readonly pbc::RepeatedField<ulong> tempAvatarGuidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> TempAvatarGuidList {
    get { return tempAvatarGuidList_; }
  }

  /// <summary>Field number for the "backup_avatar_team_order_list" field.</summary>
  public const int BackupAvatarTeamOrderListFieldNumber = 10;
  private static readonly pb::FieldCodec<uint> _repeated_backupAvatarTeamOrderList_codec
      = pb::FieldCodec.ForUInt32(82);
  private readonly pbc::RepeatedField<uint> backupAvatarTeamOrderList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> BackupAvatarTeamOrderList {
    get { return backupAvatarTeamOrderList_; }
  }

  /// <summary>Field number for the "avatar_team_map" field.</summary>
  public const int AvatarTeamMapFieldNumber = 5;
  private static readonly pbc::MapField<uint, global::AvatarTeam>.Codec _map_avatarTeamMap_codec
      = new pbc::MapField<uint, global::AvatarTeam>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::AvatarTeam.Parser), 42);
  private readonly pbc::MapField<uint, global::AvatarTeam> avatarTeamMap_ = new pbc::MapField<uint, global::AvatarTeam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::AvatarTeam> AvatarTeamMap {
    get { return avatarTeamMap_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AvatarTeamAllDataNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AvatarTeamAllDataNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!tempAvatarGuidList_.Equals(other.tempAvatarGuidList_)) return false;
    if(!backupAvatarTeamOrderList_.Equals(other.backupAvatarTeamOrderList_)) return false;
    if (!AvatarTeamMap.Equals(other.AvatarTeamMap)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= tempAvatarGuidList_.GetHashCode();
    hash ^= backupAvatarTeamOrderList_.GetHashCode();
    hash ^= AvatarTeamMap.GetHashCode();
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
    tempAvatarGuidList_.WriteTo(output, _repeated_tempAvatarGuidList_codec);
    avatarTeamMap_.WriteTo(output, _map_avatarTeamMap_codec);
    backupAvatarTeamOrderList_.WriteTo(output, _repeated_backupAvatarTeamOrderList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    tempAvatarGuidList_.WriteTo(ref output, _repeated_tempAvatarGuidList_codec);
    avatarTeamMap_.WriteTo(ref output, _map_avatarTeamMap_codec);
    backupAvatarTeamOrderList_.WriteTo(ref output, _repeated_backupAvatarTeamOrderList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += tempAvatarGuidList_.CalculateSize(_repeated_tempAvatarGuidList_codec);
    size += backupAvatarTeamOrderList_.CalculateSize(_repeated_backupAvatarTeamOrderList_codec);
    size += avatarTeamMap_.CalculateSize(_map_avatarTeamMap_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AvatarTeamAllDataNotify other) {
    if (other == null) {
      return;
    }
    tempAvatarGuidList_.Add(other.tempAvatarGuidList_);
    backupAvatarTeamOrderList_.Add(other.backupAvatarTeamOrderList_);
    avatarTeamMap_.Add(other.avatarTeamMap_);
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
        case 18:
        case 16: {
          tempAvatarGuidList_.AddEntriesFrom(input, _repeated_tempAvatarGuidList_codec);
          break;
        }
        case 42: {
          avatarTeamMap_.AddEntriesFrom(input, _map_avatarTeamMap_codec);
          break;
        }
        case 82:
        case 80: {
          backupAvatarTeamOrderList_.AddEntriesFrom(input, _repeated_backupAvatarTeamOrderList_codec);
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
        case 18:
        case 16: {
          tempAvatarGuidList_.AddEntriesFrom(ref input, _repeated_tempAvatarGuidList_codec);
          break;
        }
        case 42: {
          avatarTeamMap_.AddEntriesFrom(ref input, _map_avatarTeamMap_codec);
          break;
        }
        case 82:
        case 80: {
          backupAvatarTeamOrderList_.AddEntriesFrom(ref input, _repeated_backupAvatarTeamOrderList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
