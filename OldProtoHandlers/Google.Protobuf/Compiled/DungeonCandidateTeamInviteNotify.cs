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
namespace OldProtos {

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
            "dW5nZW9uQ2FuZGlkYXRlVGVhbUludml0ZU5vdGlmeRISCgpwbGF5ZXJfdWlk",
            "GAUgASgNEh8KF3ZhaWxkX2RlYWRsaW5lX3RpbWVfc2VjGAkgASgNEhIKCmR1",
            "bmdlb25faWQYBiABKA1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.DungeonCandidateTeamInviteNotify), global::OldProtos.DungeonCandidateTeamInviteNotify.Parser, new[]{ "PlayerUid", "VaildDeadlineTimeSec", "DungeonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 994
  /// EnetChannelId: 0
  /// EnetIsReliable: true
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
      get { return global::OldProtos.DungeonCandidateTeamInviteNotifyReflection.Descriptor.MessageTypes[0]; }
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
      playerUid_ = other.playerUid_;
      vaildDeadlineTimeSec_ = other.vaildDeadlineTimeSec_;
      dungeonId_ = other.dungeonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamInviteNotify Clone() {
      return new DungeonCandidateTeamInviteNotify(this);
    }

    /// <summary>Field number for the "player_uid" field.</summary>
    public const int PlayerUidFieldNumber = 5;
    private uint playerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerUid {
      get { return playerUid_; }
      set {
        playerUid_ = value;
      }
    }

    /// <summary>Field number for the "vaild_deadline_time_sec" field.</summary>
    public const int VaildDeadlineTimeSecFieldNumber = 9;
    private uint vaildDeadlineTimeSec_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint VaildDeadlineTimeSec {
      get { return vaildDeadlineTimeSec_; }
      set {
        vaildDeadlineTimeSec_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 6;
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
      if (PlayerUid != other.PlayerUid) return false;
      if (VaildDeadlineTimeSec != other.VaildDeadlineTimeSec) return false;
      if (DungeonId != other.DungeonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerUid != 0) hash ^= PlayerUid.GetHashCode();
      if (VaildDeadlineTimeSec != 0) hash ^= VaildDeadlineTimeSec.GetHashCode();
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
        output.WriteRawTag(40);
        output.WriteUInt32(PlayerUid);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      if (VaildDeadlineTimeSec != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(VaildDeadlineTimeSec);
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
        output.WriteRawTag(40);
        output.WriteUInt32(PlayerUid);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      if (VaildDeadlineTimeSec != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(VaildDeadlineTimeSec);
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
      if (PlayerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerUid);
      }
      if (VaildDeadlineTimeSec != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(VaildDeadlineTimeSec);
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
      if (other.PlayerUid != 0) {
        PlayerUid = other.PlayerUid;
      }
      if (other.VaildDeadlineTimeSec != 0) {
        VaildDeadlineTimeSec = other.VaildDeadlineTimeSec;
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
          case 40: {
            PlayerUid = input.ReadUInt32();
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 72: {
            VaildDeadlineTimeSec = input.ReadUInt32();
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
          case 40: {
            PlayerUid = input.ReadUInt32();
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 72: {
            VaildDeadlineTimeSec = input.ReadUInt32();
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
