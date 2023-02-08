// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetPlayUidInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GadgetPlayUidInfo.proto</summary>
  public static partial class GadgetPlayUidInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GadgetPlayUidInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GadgetPlayUidInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHYWRnZXRQbGF5VWlkSW5mby5wcm90bxoUUHJvZmlsZVBpY3R1cmUucHJv",
            "dG8ipwEKEUdhZGdldFBsYXlVaWRJbmZvEhEKCW9ubGluZV9pZBgFIAEoCRIN",
            "CgVzY29yZRgBIAEoDRIQCghuaWNrbmFtZRgLIAEoCRIMCgRpY29uGA8gASgN",
            "EhkKEWJhdHRsZV93YXRjaGVyX2lkGAkgASgNEigKD3Byb2ZpbGVfcGljdHVy",
            "ZRgGIAEoCzIPLlByb2ZpbGVQaWN0dXJlEgsKA3VpZBgMIAEoDUIMqgIJTmV3",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GadgetPlayUidInfo), global::NewProtos.GadgetPlayUidInfo.Parser, new[]{ "OnlineId", "Score", "Nickname", "Icon", "BattleWatcherId", "ProfilePicture", "Uid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GadgetPlayUidInfo : pb::IMessage<GadgetPlayUidInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GadgetPlayUidInfo> _parser = new pb::MessageParser<GadgetPlayUidInfo>(() => new GadgetPlayUidInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GadgetPlayUidInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GadgetPlayUidInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetPlayUidInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetPlayUidInfo(GadgetPlayUidInfo other) : this() {
      onlineId_ = other.onlineId_;
      score_ = other.score_;
      nickname_ = other.nickname_;
      icon_ = other.icon_;
      battleWatcherId_ = other.battleWatcherId_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      uid_ = other.uid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetPlayUidInfo Clone() {
      return new GadgetPlayUidInfo(this);
    }

    /// <summary>Field number for the "online_id" field.</summary>
    public const int OnlineIdFieldNumber = 5;
    private string onlineId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OnlineId {
      get { return onlineId_; }
      set {
        onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 1;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 11;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "icon" field.</summary>
    public const int IconFieldNumber = 15;
    private uint icon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Icon {
      get { return icon_; }
      set {
        icon_ = value;
      }
    }

    /// <summary>Field number for the "battle_watcher_id" field.</summary>
    public const int BattleWatcherIdFieldNumber = 9;
    private uint battleWatcherId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleWatcherId {
      get { return battleWatcherId_; }
      set {
        battleWatcherId_ = value;
      }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 6;
    private global::NewProtos.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 12;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GadgetPlayUidInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GadgetPlayUidInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OnlineId != other.OnlineId) return false;
      if (Score != other.Score) return false;
      if (Nickname != other.Nickname) return false;
      if (Icon != other.Icon) return false;
      if (BattleWatcherId != other.BattleWatcherId) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (Uid != other.Uid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (Icon != 0) hash ^= Icon.GetHashCode();
      if (BattleWatcherId != 0) hash ^= BattleWatcherId.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
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
      if (Score != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Score);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OnlineId);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ProfilePicture);
      }
      if (BattleWatcherId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BattleWatcherId);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uid);
      }
      if (Icon != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Icon);
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
      if (Score != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Score);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OnlineId);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ProfilePicture);
      }
      if (BattleWatcherId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(BattleWatcherId);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uid);
      }
      if (Icon != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Icon);
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
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (Icon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Icon);
      }
      if (BattleWatcherId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleWatcherId);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GadgetPlayUidInfo other) {
      if (other == null) {
        return;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.Icon != 0) {
        Icon = other.Icon;
      }
      if (other.BattleWatcherId != 0) {
        BattleWatcherId = other.BattleWatcherId;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::NewProtos.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
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
            Score = input.ReadUInt32();
            break;
          }
          case 42: {
            OnlineId = input.ReadString();
            break;
          }
          case 50: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::NewProtos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 72: {
            BattleWatcherId = input.ReadUInt32();
            break;
          }
          case 90: {
            Nickname = input.ReadString();
            break;
          }
          case 96: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            Icon = input.ReadUInt32();
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
            Score = input.ReadUInt32();
            break;
          }
          case 42: {
            OnlineId = input.ReadString();
            break;
          }
          case 50: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::NewProtos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 72: {
            BattleWatcherId = input.ReadUInt32();
            break;
          }
          case 90: {
            Nickname = input.ReadString();
            break;
          }
          case 96: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            Icon = input.ReadUInt32();
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
