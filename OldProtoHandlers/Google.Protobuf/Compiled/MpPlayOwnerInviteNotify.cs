// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MpPlayOwnerInviteNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MpPlayOwnerInviteNotify.proto</summary>
public static partial class MpPlayOwnerInviteNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for MpPlayOwnerInviteNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MpPlayOwnerInviteNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1NcFBsYXlPd25lckludml0ZU5vdGlmeS5wcm90byJTChdNcFBsYXlPd25l",
          "ckludml0ZU5vdGlmeRIKCgJjZBgMIAEoDRISCgptcF9wbGF5X2lkGA0gASgN",
          "EhgKEGlzX3JlbWFpbl9yZXdhcmQYCiABKAhCHgocZW11LmdyYXNzY3V0dGVy",
          "Lm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MpPlayOwnerInviteNotify), global::MpPlayOwnerInviteNotify.Parser, new[]{ "Cd", "MpPlayId", "IsRemainReward" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 1835
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class MpPlayOwnerInviteNotify : pb::IMessage<MpPlayOwnerInviteNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MpPlayOwnerInviteNotify> _parser = new pb::MessageParser<MpPlayOwnerInviteNotify>(() => new MpPlayOwnerInviteNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MpPlayOwnerInviteNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MpPlayOwnerInviteNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MpPlayOwnerInviteNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MpPlayOwnerInviteNotify(MpPlayOwnerInviteNotify other) : this() {
    cd_ = other.cd_;
    mpPlayId_ = other.mpPlayId_;
    isRemainReward_ = other.isRemainReward_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MpPlayOwnerInviteNotify Clone() {
    return new MpPlayOwnerInviteNotify(this);
  }

  /// <summary>Field number for the "cd" field.</summary>
  public const int CdFieldNumber = 12;
  private uint cd_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Cd {
    get { return cd_; }
    set {
      cd_ = value;
    }
  }

  /// <summary>Field number for the "mp_play_id" field.</summary>
  public const int MpPlayIdFieldNumber = 13;
  private uint mpPlayId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MpPlayId {
    get { return mpPlayId_; }
    set {
      mpPlayId_ = value;
    }
  }

  /// <summary>Field number for the "is_remain_reward" field.</summary>
  public const int IsRemainRewardFieldNumber = 10;
  private bool isRemainReward_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsRemainReward {
    get { return isRemainReward_; }
    set {
      isRemainReward_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MpPlayOwnerInviteNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MpPlayOwnerInviteNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Cd != other.Cd) return false;
    if (MpPlayId != other.MpPlayId) return false;
    if (IsRemainReward != other.IsRemainReward) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Cd != 0) hash ^= Cd.GetHashCode();
    if (MpPlayId != 0) hash ^= MpPlayId.GetHashCode();
    if (IsRemainReward != false) hash ^= IsRemainReward.GetHashCode();
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
    if (IsRemainReward != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsRemainReward);
    }
    if (Cd != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(Cd);
    }
    if (MpPlayId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(MpPlayId);
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
    if (IsRemainReward != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsRemainReward);
    }
    if (Cd != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(Cd);
    }
    if (MpPlayId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(MpPlayId);
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
    if (Cd != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Cd);
    }
    if (MpPlayId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayId);
    }
    if (IsRemainReward != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MpPlayOwnerInviteNotify other) {
    if (other == null) {
      return;
    }
    if (other.Cd != 0) {
      Cd = other.Cd;
    }
    if (other.MpPlayId != 0) {
      MpPlayId = other.MpPlayId;
    }
    if (other.IsRemainReward != false) {
      IsRemainReward = other.IsRemainReward;
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
        case 80: {
          IsRemainReward = input.ReadBool();
          break;
        }
        case 96: {
          Cd = input.ReadUInt32();
          break;
        }
        case 104: {
          MpPlayId = input.ReadUInt32();
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
        case 80: {
          IsRemainReward = input.ReadBool();
          break;
        }
        case 96: {
          Cd = input.ReadUInt32();
          break;
        }
        case 104: {
          MpPlayId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
