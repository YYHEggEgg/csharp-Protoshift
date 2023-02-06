// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarTeamUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AvatarTeamUpdateNotify.proto</summary>
public static partial class AvatarTeamUpdateNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for AvatarTeamUpdateNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AvatarTeamUpdateNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxBdmF0YXJUZWFtVXBkYXRlTm90aWZ5LnByb3RvGhBBdmF0YXJUZWFtLnBy",
          "b3RvIr8BChZBdmF0YXJUZWFtVXBkYXRlTm90aWZ5EkMKD2F2YXRhcl90ZWFt",
          "X21hcBgPIAMoCzIqLkF2YXRhclRlYW1VcGRhdGVOb3RpZnkuQXZhdGFyVGVh",
          "bU1hcEVudHJ5Eh0KFXRlbXBfYXZhdGFyX2d1aWRfbGlzdBgKIAMoBBpBChJB",
          "dmF0YXJUZWFtTWFwRW50cnkSCwoDa2V5GAEgASgNEhoKBXZhbHVlGAIgASgL",
          "MgsuQXZhdGFyVGVhbToCOAFCFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::AvatarTeamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AvatarTeamUpdateNotify), global::AvatarTeamUpdateNotify.Parser, new[]{ "AvatarTeamMap", "TempAvatarGuidList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 1739;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class AvatarTeamUpdateNotify : pb::IMessage<AvatarTeamUpdateNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AvatarTeamUpdateNotify> _parser = new pb::MessageParser<AvatarTeamUpdateNotify>(() => new AvatarTeamUpdateNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AvatarTeamUpdateNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AvatarTeamUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarTeamUpdateNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarTeamUpdateNotify(AvatarTeamUpdateNotify other) : this() {
    avatarTeamMap_ = other.avatarTeamMap_.Clone();
    tempAvatarGuidList_ = other.tempAvatarGuidList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarTeamUpdateNotify Clone() {
    return new AvatarTeamUpdateNotify(this);
  }

  /// <summary>Field number for the "avatar_team_map" field.</summary>
  public const int AvatarTeamMapFieldNumber = 15;
  private static readonly pbc::MapField<uint, global::AvatarTeam>.Codec _map_avatarTeamMap_codec
      = new pbc::MapField<uint, global::AvatarTeam>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::AvatarTeam.Parser), 122);
  private readonly pbc::MapField<uint, global::AvatarTeam> avatarTeamMap_ = new pbc::MapField<uint, global::AvatarTeam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::AvatarTeam> AvatarTeamMap {
    get { return avatarTeamMap_; }
  }

  /// <summary>Field number for the "temp_avatar_guid_list" field.</summary>
  public const int TempAvatarGuidListFieldNumber = 10;
  private static readonly pb::FieldCodec<ulong> _repeated_tempAvatarGuidList_codec
      = pb::FieldCodec.ForUInt64(82);
  private readonly pbc::RepeatedField<ulong> tempAvatarGuidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> TempAvatarGuidList {
    get { return tempAvatarGuidList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AvatarTeamUpdateNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AvatarTeamUpdateNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!AvatarTeamMap.Equals(other.AvatarTeamMap)) return false;
    if(!tempAvatarGuidList_.Equals(other.tempAvatarGuidList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= AvatarTeamMap.GetHashCode();
    hash ^= tempAvatarGuidList_.GetHashCode();
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
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += avatarTeamMap_.CalculateSize(_map_avatarTeamMap_codec);
    size += tempAvatarGuidList_.CalculateSize(_repeated_tempAvatarGuidList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AvatarTeamUpdateNotify other) {
    if (other == null) {
      return;
    }
    avatarTeamMap_.Add(other.avatarTeamMap_);
    tempAvatarGuidList_.Add(other.tempAvatarGuidList_);
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
        case 82:
        case 80: {
          tempAvatarGuidList_.AddEntriesFrom(input, _repeated_tempAvatarGuidList_codec);
          break;
        }
        case 122: {
          avatarTeamMap_.AddEntriesFrom(input, _map_avatarTeamMap_codec);
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
        case 82:
        case 80: {
          tempAvatarGuidList_.AddEntriesFrom(ref input, _repeated_tempAvatarGuidList_codec);
          break;
        }
        case 122: {
          avatarTeamMap_.AddEntriesFrom(ref input, _map_avatarTeamMap_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code