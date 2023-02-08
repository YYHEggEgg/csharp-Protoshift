// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerTimeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from PlayerTimeNotify.proto</summary>
  public static partial class PlayerTimeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerTimeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerTimeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJUaW1lTm90aWZ5LnByb3RvIk8KEFBsYXllclRpbWVOb3RpZnkS",
            "EwoLc2VydmVyX3RpbWUYBSABKAQSEwoLcGxheWVyX3RpbWUYCyABKAQSEQoJ",
            "aXNfcGF1c2VkGA4gASgIQgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.PlayerTimeNotify), global::OldProtos.PlayerTimeNotify.Parser, new[]{ "ServerTime", "PlayerTime", "IsPaused" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 191
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerTimeNotify : pb::IMessage<PlayerTimeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerTimeNotify> _parser = new pb::MessageParser<PlayerTimeNotify>(() => new PlayerTimeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerTimeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.PlayerTimeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerTimeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerTimeNotify(PlayerTimeNotify other) : this() {
      serverTime_ = other.serverTime_;
      playerTime_ = other.playerTime_;
      isPaused_ = other.isPaused_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerTimeNotify Clone() {
      return new PlayerTimeNotify(this);
    }

    /// <summary>Field number for the "server_time" field.</summary>
    public const int ServerTimeFieldNumber = 5;
    private ulong serverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    /// <summary>Field number for the "player_time" field.</summary>
    public const int PlayerTimeFieldNumber = 11;
    private ulong playerTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong PlayerTime {
      get { return playerTime_; }
      set {
        playerTime_ = value;
      }
    }

    /// <summary>Field number for the "is_paused" field.</summary>
    public const int IsPausedFieldNumber = 14;
    private bool isPaused_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPaused {
      get { return isPaused_; }
      set {
        isPaused_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerTimeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerTimeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerTime != other.ServerTime) return false;
      if (PlayerTime != other.PlayerTime) return false;
      if (IsPaused != other.IsPaused) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerTime != 0UL) hash ^= ServerTime.GetHashCode();
      if (PlayerTime != 0UL) hash ^= PlayerTime.GetHashCode();
      if (IsPaused != false) hash ^= IsPaused.GetHashCode();
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
      if (ServerTime != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(ServerTime);
      }
      if (PlayerTime != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(PlayerTime);
      }
      if (IsPaused != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsPaused);
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
      if (ServerTime != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(ServerTime);
      }
      if (PlayerTime != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(PlayerTime);
      }
      if (IsPaused != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsPaused);
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
      if (ServerTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ServerTime);
      }
      if (PlayerTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerTime);
      }
      if (IsPaused != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerTimeNotify other) {
      if (other == null) {
        return;
      }
      if (other.ServerTime != 0UL) {
        ServerTime = other.ServerTime;
      }
      if (other.PlayerTime != 0UL) {
        PlayerTime = other.PlayerTime;
      }
      if (other.IsPaused != false) {
        IsPaused = other.IsPaused;
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
            ServerTime = input.ReadUInt64();
            break;
          }
          case 88: {
            PlayerTime = input.ReadUInt64();
            break;
          }
          case 112: {
            IsPaused = input.ReadBool();
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
            ServerTime = input.ReadUInt64();
            break;
          }
          case 88: {
            PlayerTime = input.ReadUInt64();
            break;
          }
          case 112: {
            IsPaused = input.ReadBool();
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
