// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonCandidateTeamInviteNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from DungeonCandidateTeamInviteNotify.proto</summary>
  public static partial class DungeonCandidateTeamInviteNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonCandidateTeamInviteNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonCandidateTeamInviteNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZEdW5nZW9uQ2FuZGlkYXRlVGVhbUludml0ZU5vdGlmeS5wcm90byJrCiBE",
            "dW5nZW9uQ2FuZGlkYXRlVGVhbUludml0ZU5vdGlmeRIfChd2YWxpZF9kZWFk",
            "bGluZV90aW1lX3NlYxgLIAEoDRISCgpwbGF5ZXJfdWlkGAQgASgNEhIKCmR1",
            "bmdlb25faWQYDSABKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.DungeonCandidateTeamInviteNotify), global::NewProtos.DungeonCandidateTeamInviteNotify.Parser, new[]{ "ValidDeadlineTimeSec", "PlayerUid", "DungeonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 905;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class DungeonCandidateTeamInviteNotify : pb::IMessage<DungeonCandidateTeamInviteNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonCandidateTeamInviteNotify> _parser = new pb::MessageParser<DungeonCandidateTeamInviteNotify>(() => new DungeonCandidateTeamInviteNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonCandidateTeamInviteNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.DungeonCandidateTeamInviteNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamInviteNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamInviteNotify(DungeonCandidateTeamInviteNotify other) : this() {
      validDeadlineTimeSec_ = other.validDeadlineTimeSec_;
      playerUid_ = other.playerUid_;
      dungeonId_ = other.dungeonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamInviteNotify Clone() {
      return new DungeonCandidateTeamInviteNotify(this);
    }

    /// <summary>Field number for the "valid_deadline_time_sec" field.</summary>
    public const int ValidDeadlineTimeSecFieldNumber = 11;
    private uint validDeadlineTimeSec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ValidDeadlineTimeSec {
      get { return validDeadlineTimeSec_; }
      set {
        validDeadlineTimeSec_ = value;
      }
    }

    /// <summary>Field number for the "player_uid" field.</summary>
    public const int PlayerUidFieldNumber = 4;
    private uint playerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerUid {
      get { return playerUid_; }
      set {
        playerUid_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 13;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonCandidateTeamInviteNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonCandidateTeamInviteNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ValidDeadlineTimeSec != other.ValidDeadlineTimeSec) return false;
      if (PlayerUid != other.PlayerUid) return false;
      if (DungeonId != other.DungeonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ValidDeadlineTimeSec != 0) hash ^= ValidDeadlineTimeSec.GetHashCode();
      if (PlayerUid != 0) hash ^= PlayerUid.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
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
      if (PlayerUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PlayerUid);
      }
      if (ValidDeadlineTimeSec != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ValidDeadlineTimeSec);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(104);
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
      if (PlayerUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PlayerUid);
      }
      if (ValidDeadlineTimeSec != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ValidDeadlineTimeSec);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(104);
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
      if (ValidDeadlineTimeSec != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ValidDeadlineTimeSec);
      }
      if (PlayerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerUid);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonCandidateTeamInviteNotify other) {
      if (other == null) {
        return;
      }
      if (other.ValidDeadlineTimeSec != 0) {
        ValidDeadlineTimeSec = other.ValidDeadlineTimeSec;
      }
      if (other.PlayerUid != 0) {
        PlayerUid = other.PlayerUid;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
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
          case 32: {
            PlayerUid = input.ReadUInt32();
            break;
          }
          case 88: {
            ValidDeadlineTimeSec = input.ReadUInt32();
            break;
          }
          case 104: {
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
          case 32: {
            PlayerUid = input.ReadUInt32();
            break;
          }
          case 88: {
            ValidDeadlineTimeSec = input.ReadUInt32();
            break;
          }
          case 104: {
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
