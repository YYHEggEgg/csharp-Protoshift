// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerEnterSceneInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PlayerEnterSceneInfoNotify.proto</summary>
  public static partial class PlayerEnterSceneInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerEnterSceneInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerEnterSceneInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQbGF5ZXJFbnRlclNjZW5lSW5mb05vdGlmeS5wcm90bxoaQXZhdGFyRW50",
            "ZXJTY2VuZUluZm8ucHJvdG8aF01QTGV2ZWxFbnRpdHlJbmZvLnByb3RvGhhU",
            "ZWFtRW50ZXJTY2VuZUluZm8ucHJvdG8i5wEKGlBsYXllckVudGVyU2NlbmVJ",
            "bmZvTm90aWZ5EiwKD3RlYW1fZW50ZXJfaW5mbxgGIAEoCzITLlRlYW1FbnRl",
            "clNjZW5lSW5mbxIwChFhdmF0YXJfZW50ZXJfaW5mbxgKIAMoCzIVLkF2YXRh",
            "ckVudGVyU2NlbmVJbmZvEhwKFGN1cl9hdmF0YXJfZW50aXR5X2lkGAQgASgN",
            "EjAKFG1wX2xldmVsX2VudGl0eV9pbmZvGA8gASgLMhIuTVBMZXZlbEVudGl0",
            "eUluZm8SGQoRZW50ZXJfc2NlbmVfdG9rZW4YASABKA1CDKoCCU5ld1Byb3Rv",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.AvatarEnterSceneInfoReflection.Descriptor, global::NewProtos.MPLevelEntityInfoReflection.Descriptor, global::NewProtos.TeamEnterSceneInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PlayerEnterSceneInfoNotify), global::NewProtos.PlayerEnterSceneInfoNotify.Parser, new[]{ "TeamEnterInfo", "AvatarEnterInfo", "CurAvatarEntityId", "MpLevelEntityInfo", "EnterSceneToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 241;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerEnterSceneInfoNotify : pb::IMessage<PlayerEnterSceneInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerEnterSceneInfoNotify> _parser = new pb::MessageParser<PlayerEnterSceneInfoNotify>(() => new PlayerEnterSceneInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerEnterSceneInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PlayerEnterSceneInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneInfoNotify(PlayerEnterSceneInfoNotify other) : this() {
      teamEnterInfo_ = other.teamEnterInfo_ != null ? other.teamEnterInfo_.Clone() : null;
      avatarEnterInfo_ = other.avatarEnterInfo_.Clone();
      curAvatarEntityId_ = other.curAvatarEntityId_;
      mpLevelEntityInfo_ = other.mpLevelEntityInfo_ != null ? other.mpLevelEntityInfo_.Clone() : null;
      enterSceneToken_ = other.enterSceneToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneInfoNotify Clone() {
      return new PlayerEnterSceneInfoNotify(this);
    }

    /// <summary>Field number for the "team_enter_info" field.</summary>
    public const int TeamEnterInfoFieldNumber = 6;
    private global::NewProtos.TeamEnterSceneInfo teamEnterInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.TeamEnterSceneInfo TeamEnterInfo {
      get { return teamEnterInfo_; }
      set {
        teamEnterInfo_ = value;
      }
    }

    /// <summary>Field number for the "avatar_enter_info" field.</summary>
    public const int AvatarEnterInfoFieldNumber = 10;
    private static readonly pb::FieldCodec<global::NewProtos.AvatarEnterSceneInfo> _repeated_avatarEnterInfo_codec
        = pb::FieldCodec.ForMessage(82, global::NewProtos.AvatarEnterSceneInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.AvatarEnterSceneInfo> avatarEnterInfo_ = new pbc::RepeatedField<global::NewProtos.AvatarEnterSceneInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.AvatarEnterSceneInfo> AvatarEnterInfo {
      get { return avatarEnterInfo_; }
    }

    /// <summary>Field number for the "cur_avatar_entity_id" field.</summary>
    public const int CurAvatarEntityIdFieldNumber = 4;
    private uint curAvatarEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurAvatarEntityId {
      get { return curAvatarEntityId_; }
      set {
        curAvatarEntityId_ = value;
      }
    }

    /// <summary>Field number for the "mp_level_entity_info" field.</summary>
    public const int MpLevelEntityInfoFieldNumber = 15;
    private global::NewProtos.MPLevelEntityInfo mpLevelEntityInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.MPLevelEntityInfo MpLevelEntityInfo {
      get { return mpLevelEntityInfo_; }
      set {
        mpLevelEntityInfo_ = value;
      }
    }

    /// <summary>Field number for the "enter_scene_token" field.</summary>
    public const int EnterSceneTokenFieldNumber = 1;
    private uint enterSceneToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterSceneToken {
      get { return enterSceneToken_; }
      set {
        enterSceneToken_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerEnterSceneInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerEnterSceneInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TeamEnterInfo, other.TeamEnterInfo)) return false;
      if(!avatarEnterInfo_.Equals(other.avatarEnterInfo_)) return false;
      if (CurAvatarEntityId != other.CurAvatarEntityId) return false;
      if (!object.Equals(MpLevelEntityInfo, other.MpLevelEntityInfo)) return false;
      if (EnterSceneToken != other.EnterSceneToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (teamEnterInfo_ != null) hash ^= TeamEnterInfo.GetHashCode();
      hash ^= avatarEnterInfo_.GetHashCode();
      if (CurAvatarEntityId != 0) hash ^= CurAvatarEntityId.GetHashCode();
      if (mpLevelEntityInfo_ != null) hash ^= MpLevelEntityInfo.GetHashCode();
      if (EnterSceneToken != 0) hash ^= EnterSceneToken.GetHashCode();
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
      if (EnterSceneToken != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EnterSceneToken);
      }
      if (CurAvatarEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CurAvatarEntityId);
      }
      if (teamEnterInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(TeamEnterInfo);
      }
      avatarEnterInfo_.WriteTo(output, _repeated_avatarEnterInfo_codec);
      if (mpLevelEntityInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MpLevelEntityInfo);
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
      if (EnterSceneToken != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EnterSceneToken);
      }
      if (CurAvatarEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CurAvatarEntityId);
      }
      if (teamEnterInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(TeamEnterInfo);
      }
      avatarEnterInfo_.WriteTo(ref output, _repeated_avatarEnterInfo_codec);
      if (mpLevelEntityInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MpLevelEntityInfo);
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
      if (teamEnterInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeamEnterInfo);
      }
      size += avatarEnterInfo_.CalculateSize(_repeated_avatarEnterInfo_codec);
      if (CurAvatarEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurAvatarEntityId);
      }
      if (mpLevelEntityInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MpLevelEntityInfo);
      }
      if (EnterSceneToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterSceneToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerEnterSceneInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.teamEnterInfo_ != null) {
        if (teamEnterInfo_ == null) {
          TeamEnterInfo = new global::NewProtos.TeamEnterSceneInfo();
        }
        TeamEnterInfo.MergeFrom(other.TeamEnterInfo);
      }
      avatarEnterInfo_.Add(other.avatarEnterInfo_);
      if (other.CurAvatarEntityId != 0) {
        CurAvatarEntityId = other.CurAvatarEntityId;
      }
      if (other.mpLevelEntityInfo_ != null) {
        if (mpLevelEntityInfo_ == null) {
          MpLevelEntityInfo = new global::NewProtos.MPLevelEntityInfo();
        }
        MpLevelEntityInfo.MergeFrom(other.MpLevelEntityInfo);
      }
      if (other.EnterSceneToken != 0) {
        EnterSceneToken = other.EnterSceneToken;
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
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 32: {
            CurAvatarEntityId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (teamEnterInfo_ == null) {
              TeamEnterInfo = new global::NewProtos.TeamEnterSceneInfo();
            }
            input.ReadMessage(TeamEnterInfo);
            break;
          }
          case 82: {
            avatarEnterInfo_.AddEntriesFrom(input, _repeated_avatarEnterInfo_codec);
            break;
          }
          case 122: {
            if (mpLevelEntityInfo_ == null) {
              MpLevelEntityInfo = new global::NewProtos.MPLevelEntityInfo();
            }
            input.ReadMessage(MpLevelEntityInfo);
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
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 32: {
            CurAvatarEntityId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (teamEnterInfo_ == null) {
              TeamEnterInfo = new global::NewProtos.TeamEnterSceneInfo();
            }
            input.ReadMessage(TeamEnterInfo);
            break;
          }
          case 82: {
            avatarEnterInfo_.AddEntriesFrom(ref input, _repeated_avatarEnterInfo_codec);
            break;
          }
          case 122: {
            if (mpLevelEntityInfo_ == null) {
              MpLevelEntityInfo = new global::NewProtos.MPLevelEntityInfo();
            }
            input.ReadMessage(MpLevelEntityInfo);
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
