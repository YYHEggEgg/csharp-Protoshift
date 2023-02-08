// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerMatchAgreedResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PlayerMatchAgreedResultNotify.proto</summary>
  public static partial class PlayerMatchAgreedResultNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerMatchAgreedResultNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerMatchAgreedResultNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQbGF5ZXJNYXRjaEFncmVlZFJlc3VsdE5vdGlmeS5wcm90bxoPTWF0Y2hU",
            "eXBlLnByb3RvIroCCh1QbGF5ZXJNYXRjaEFncmVlZFJlc3VsdE5vdGlmeRIe",
            "CgptYXRjaF90eXBlGAwgASgOMgouTWF0Y2hUeXBlEhIKCnRhcmdldF91aWQY",
            "BCABKA0SNQoGcmVhc29uGA0gASgOMiUuUGxheWVyTWF0Y2hBZ3JlZWRSZXN1",
            "bHROb3RpZnkuUmVhc29uIq0BCgZSZWFzb24SDwoLUkVBU09OX1NVQ0MQABIk",
            "CiBSRUFTT05fVEFSR0VUX1NDRU5FX0NBTk5PVF9FTlRFUhABEh4KGlJFQVNP",
            "Tl9TRUxGX01QX1VOQVZBSUxBQkxFEAISKAokUkVBU09OX09USEVSX0RBVEFf",
            "VkVSU0lPTl9OT1RfTEFURVNUEAMSIgoeUkVBU09OX0RBVEFfVkVSU0lPTl9O",
            "T1RfTEFURVNUEARCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.MatchTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PlayerMatchAgreedResultNotify), global::NewProtos.PlayerMatchAgreedResultNotify.Parser, new[]{ "MatchType", "TargetUid", "Reason" }, null, new[]{ typeof(global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4165;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerMatchAgreedResultNotify : pb::IMessage<PlayerMatchAgreedResultNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerMatchAgreedResultNotify> _parser = new pb::MessageParser<PlayerMatchAgreedResultNotify>(() => new PlayerMatchAgreedResultNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerMatchAgreedResultNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PlayerMatchAgreedResultNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchAgreedResultNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchAgreedResultNotify(PlayerMatchAgreedResultNotify other) : this() {
      matchType_ = other.matchType_;
      targetUid_ = other.targetUid_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchAgreedResultNotify Clone() {
      return new PlayerMatchAgreedResultNotify(this);
    }

    /// <summary>Field number for the "match_type" field.</summary>
    public const int MatchTypeFieldNumber = 12;
    private global::NewProtos.MatchType matchType_ = global::NewProtos.MatchType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.MatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 4;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 13;
    private global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason reason_ = global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason.Succ;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerMatchAgreedResultNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerMatchAgreedResultNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MatchType != other.MatchType) return false;
      if (TargetUid != other.TargetUid) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MatchType != global::NewProtos.MatchType.None) hash ^= MatchType.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (Reason != global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason.Succ) hash ^= Reason.GetHashCode();
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
      if (TargetUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetUid);
      }
      if (MatchType != global::NewProtos.MatchType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) MatchType);
      }
      if (Reason != global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason.Succ) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Reason);
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
      if (TargetUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetUid);
      }
      if (MatchType != global::NewProtos.MatchType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) MatchType);
      }
      if (Reason != global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason.Succ) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Reason);
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
      if (MatchType != global::NewProtos.MatchType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (Reason != global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason.Succ) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerMatchAgreedResultNotify other) {
      if (other == null) {
        return;
      }
      if (other.MatchType != global::NewProtos.MatchType.None) {
        MatchType = other.MatchType;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.Reason != global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason.Succ) {
        Reason = other.Reason;
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
            TargetUid = input.ReadUInt32();
            break;
          }
          case 96: {
            MatchType = (global::NewProtos.MatchType) input.ReadEnum();
            break;
          }
          case 104: {
            Reason = (global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason) input.ReadEnum();
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
            TargetUid = input.ReadUInt32();
            break;
          }
          case 96: {
            MatchType = (global::NewProtos.MatchType) input.ReadEnum();
            break;
          }
          case 104: {
            Reason = (global::NewProtos.PlayerMatchAgreedResultNotify.Types.Reason) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerMatchAgreedResultNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Reason {
        [pbr::OriginalName("REASON_SUCC")] Succ = 0,
        [pbr::OriginalName("REASON_TARGET_SCENE_CANNOT_ENTER")] TargetSceneCannotEnter = 1,
        [pbr::OriginalName("REASON_SELF_MP_UNAVAILABLE")] SelfMpUnavailable = 2,
        [pbr::OriginalName("REASON_OTHER_DATA_VERSION_NOT_LATEST")] OtherDataVersionNotLatest = 3,
        [pbr::OriginalName("REASON_DATA_VERSION_NOT_LATEST")] DataVersionNotLatest = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
