// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGInviteGuestBattleRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGInviteGuestBattleRsp.proto</summary>
public static partial class GCGInviteGuestBattleRspReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGInviteGuestBattleRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGInviteGuestBattleRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1HQ0dJbnZpdGVHdWVzdEJhdHRsZVJzcC5wcm90byJqChdHQ0dJbnZpdGVH",
          "dWVzdEJhdHRsZVJzcBIPCgdyZXRjb2RlGAMgASgFEhgKEGNvbmZpcm1fZW5k",
          "X3RpbWUYAiABKA0SFwoPcHVuaXNoX2VuZF90aW1lGAkgASgNEgsKA3VpZBgL",
          "IAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGInviteGuestBattleRsp), global::GCGInviteGuestBattleRsp.Parser, new[]{ "Retcode", "ConfirmEndTime", "PunishEndTime", "Uid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGInviteGuestBattleRsp : pb::IMessage<GCGInviteGuestBattleRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGInviteGuestBattleRsp> _parser = new pb::MessageParser<GCGInviteGuestBattleRsp>(() => new GCGInviteGuestBattleRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGInviteGuestBattleRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGInviteGuestBattleRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGInviteGuestBattleRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGInviteGuestBattleRsp(GCGInviteGuestBattleRsp other) : this() {
    retcode_ = other.retcode_;
    confirmEndTime_ = other.confirmEndTime_;
    punishEndTime_ = other.punishEndTime_;
    uid_ = other.uid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGInviteGuestBattleRsp Clone() {
    return new GCGInviteGuestBattleRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 3;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "confirm_end_time" field.</summary>
  public const int ConfirmEndTimeFieldNumber = 2;
  private uint confirmEndTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConfirmEndTime {
    get { return confirmEndTime_; }
    set {
      confirmEndTime_ = value;
    }
  }

  /// <summary>Field number for the "punish_end_time" field.</summary>
  public const int PunishEndTimeFieldNumber = 9;
  private uint punishEndTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PunishEndTime {
    get { return punishEndTime_; }
    set {
      punishEndTime_ = value;
    }
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 11;
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
    return Equals(other as GCGInviteGuestBattleRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGInviteGuestBattleRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if (ConfirmEndTime != other.ConfirmEndTime) return false;
    if (PunishEndTime != other.PunishEndTime) return false;
    if (Uid != other.Uid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (ConfirmEndTime != 0) hash ^= ConfirmEndTime.GetHashCode();
    if (PunishEndTime != 0) hash ^= PunishEndTime.GetHashCode();
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
    if (ConfirmEndTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ConfirmEndTime);
    }
    if (Retcode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (PunishEndTime != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(PunishEndTime);
    }
    if (Uid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Uid);
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
    if (ConfirmEndTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ConfirmEndTime);
    }
    if (Retcode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (PunishEndTime != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(PunishEndTime);
    }
    if (Uid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Uid);
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
    if (ConfirmEndTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfirmEndTime);
    }
    if (PunishEndTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PunishEndTime);
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
  public void MergeFrom(GCGInviteGuestBattleRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.ConfirmEndTime != 0) {
      ConfirmEndTime = other.ConfirmEndTime;
    }
    if (other.PunishEndTime != 0) {
      PunishEndTime = other.PunishEndTime;
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
        case 16: {
          ConfirmEndTime = input.ReadUInt32();
          break;
        }
        case 24: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          PunishEndTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Uid = input.ReadUInt32();
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
          ConfirmEndTime = input.ReadUInt32();
          break;
        }
        case 24: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          PunishEndTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Uid = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code