// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReceivedTrialAvatarActivityRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ReceivedTrialAvatarActivityRewardRsp.proto</summary>
public static partial class ReceivedTrialAvatarActivityRewardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for ReceivedTrialAvatarActivityRewardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReceivedTrialAvatarActivityRewardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CipSZWNlaXZlZFRyaWFsQXZhdGFyQWN0aXZpdHlSZXdhcmRSc3AucHJvdG8i",
          "awokUmVjZWl2ZWRUcmlhbEF2YXRhckFjdGl2aXR5UmV3YXJkUnNwEhMKC2Fj",
          "dGl2aXR5X2lkGA0gASgNEg8KB3JldGNvZGUYAyABKAUSHQoVdHJpYWxfYXZh",
          "dGFyX2luZGV4X2lkGAkgASgNQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xk",
          "cHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReceivedTrialAvatarActivityRewardRsp), global::ReceivedTrialAvatarActivityRewardRsp.Parser, new[]{ "ActivityId", "Retcode", "TrialAvatarIndexId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2076
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ReceivedTrialAvatarActivityRewardRsp : pb::IMessage<ReceivedTrialAvatarActivityRewardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReceivedTrialAvatarActivityRewardRsp> _parser = new pb::MessageParser<ReceivedTrialAvatarActivityRewardRsp>(() => new ReceivedTrialAvatarActivityRewardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ReceivedTrialAvatarActivityRewardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReceivedTrialAvatarActivityRewardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReceivedTrialAvatarActivityRewardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReceivedTrialAvatarActivityRewardRsp(ReceivedTrialAvatarActivityRewardRsp other) : this() {
    activityId_ = other.activityId_;
    retcode_ = other.retcode_;
    trialAvatarIndexId_ = other.trialAvatarIndexId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReceivedTrialAvatarActivityRewardRsp Clone() {
    return new ReceivedTrialAvatarActivityRewardRsp(this);
  }

  /// <summary>Field number for the "activity_id" field.</summary>
  public const int ActivityIdFieldNumber = 13;
  private uint activityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ActivityId {
    get { return activityId_; }
    set {
      activityId_ = value;
    }
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

  /// <summary>Field number for the "trial_avatar_index_id" field.</summary>
  public const int TrialAvatarIndexIdFieldNumber = 9;
  private uint trialAvatarIndexId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TrialAvatarIndexId {
    get { return trialAvatarIndexId_; }
    set {
      trialAvatarIndexId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ReceivedTrialAvatarActivityRewardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ReceivedTrialAvatarActivityRewardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ActivityId != other.ActivityId) return false;
    if (Retcode != other.Retcode) return false;
    if (TrialAvatarIndexId != other.TrialAvatarIndexId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (TrialAvatarIndexId != 0) hash ^= TrialAvatarIndexId.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (TrialAvatarIndexId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(TrialAvatarIndexId);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ActivityId);
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
    if (Retcode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (TrialAvatarIndexId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(TrialAvatarIndexId);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ActivityId);
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
    if (ActivityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (TrialAvatarIndexId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialAvatarIndexId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ReceivedTrialAvatarActivityRewardRsp other) {
    if (other == null) {
      return;
    }
    if (other.ActivityId != 0) {
      ActivityId = other.ActivityId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.TrialAvatarIndexId != 0) {
      TrialAvatarIndexId = other.TrialAvatarIndexId;
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
        case 24: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          TrialAvatarIndexId = input.ReadUInt32();
          break;
        }
        case 104: {
          ActivityId = input.ReadUInt32();
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
        case 24: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          TrialAvatarIndexId = input.ReadUInt32();
          break;
        }
        case 104: {
          ActivityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code