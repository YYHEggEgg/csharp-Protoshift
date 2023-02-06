// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeReunionWatcherRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TakeReunionWatcherRewardRsp.proto</summary>
public static partial class TakeReunionWatcherRewardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for TakeReunionWatcherRewardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TakeReunionWatcherRewardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFUYWtlUmV1bmlvbldhdGNoZXJSZXdhcmRSc3AucHJvdG8iVgobVGFrZVJl",
          "dW5pb25XYXRjaGVyUmV3YXJkUnNwEhIKCm1pc3Npb25faWQYDyABKA0SEgoK",
          "d2F0Y2hlcl9pZBgJIAEoDRIPCgdyZXRjb2RlGAogASgFQh4KHGVtdS5ncmFz",
          "c2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TakeReunionWatcherRewardRsp), global::TakeReunionWatcherRewardRsp.Parser, new[]{ "MissionId", "WatcherId", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 5095
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class TakeReunionWatcherRewardRsp : pb::IMessage<TakeReunionWatcherRewardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TakeReunionWatcherRewardRsp> _parser = new pb::MessageParser<TakeReunionWatcherRewardRsp>(() => new TakeReunionWatcherRewardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TakeReunionWatcherRewardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TakeReunionWatcherRewardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeReunionWatcherRewardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeReunionWatcherRewardRsp(TakeReunionWatcherRewardRsp other) : this() {
    missionId_ = other.missionId_;
    watcherId_ = other.watcherId_;
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeReunionWatcherRewardRsp Clone() {
    return new TakeReunionWatcherRewardRsp(this);
  }

  /// <summary>Field number for the "mission_id" field.</summary>
  public const int MissionIdFieldNumber = 15;
  private uint missionId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MissionId {
    get { return missionId_; }
    set {
      missionId_ = value;
    }
  }

  /// <summary>Field number for the "watcher_id" field.</summary>
  public const int WatcherIdFieldNumber = 9;
  private uint watcherId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WatcherId {
    get { return watcherId_; }
    set {
      watcherId_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 10;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TakeReunionWatcherRewardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TakeReunionWatcherRewardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MissionId != other.MissionId) return false;
    if (WatcherId != other.WatcherId) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (MissionId != 0) hash ^= MissionId.GetHashCode();
    if (WatcherId != 0) hash ^= WatcherId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (WatcherId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(WatcherId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
    }
    if (MissionId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(MissionId);
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
    if (WatcherId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(WatcherId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
    }
    if (MissionId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(MissionId);
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
    if (MissionId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MissionId);
    }
    if (WatcherId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WatcherId);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TakeReunionWatcherRewardRsp other) {
    if (other == null) {
      return;
    }
    if (other.MissionId != 0) {
      MissionId = other.MissionId;
    }
    if (other.WatcherId != 0) {
      WatcherId = other.WatcherId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
        case 72: {
          WatcherId = input.ReadUInt32();
          break;
        }
        case 80: {
          Retcode = input.ReadInt32();
          break;
        }
        case 120: {
          MissionId = input.ReadUInt32();
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
        case 72: {
          WatcherId = input.ReadUInt32();
          break;
        }
        case 80: {
          Retcode = input.ReadInt32();
          break;
        }
        case 120: {
          MissionId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
