// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityGetRecvGiftListRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ActivityGetRecvGiftListRsp.proto</summary>
public static partial class ActivityGetRecvGiftListRspReflection {

  #region Descriptor
  /// <summary>File descriptor for ActivityGetRecvGiftListRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ActivityGetRecvGiftListRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBBY3Rpdml0eUdldFJlY3ZHaWZ0TGlzdFJzcC5wcm90bxoaQWN0aXZpdHlS",
          "ZWN2R2lmdERhdGEucHJvdG8icQoaQWN0aXZpdHlHZXRSZWN2R2lmdExpc3RS",
          "c3ASDwoHcmV0Y29kZRgPIAEoBRItCg5yZWN2X2dpZnRfbGlzdBgLIAMoCzIV",
          "LkFjdGl2aXR5UmVjdkdpZnREYXRhEhMKC3NjaGVkdWxlX2lkGAYgASgNQh4K",
          "HGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ActivityRecvGiftDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ActivityGetRecvGiftListRsp), global::ActivityGetRecvGiftListRsp.Parser, new[]{ "Retcode", "RecvGiftList", "ScheduleId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8120
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ActivityGetRecvGiftListRsp : pb::IMessage<ActivityGetRecvGiftListRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ActivityGetRecvGiftListRsp> _parser = new pb::MessageParser<ActivityGetRecvGiftListRsp>(() => new ActivityGetRecvGiftListRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ActivityGetRecvGiftListRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ActivityGetRecvGiftListRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityGetRecvGiftListRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityGetRecvGiftListRsp(ActivityGetRecvGiftListRsp other) : this() {
    retcode_ = other.retcode_;
    recvGiftList_ = other.recvGiftList_.Clone();
    scheduleId_ = other.scheduleId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityGetRecvGiftListRsp Clone() {
    return new ActivityGetRecvGiftListRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 15;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "recv_gift_list" field.</summary>
  public const int RecvGiftListFieldNumber = 11;
  private static readonly pb::FieldCodec<global::ActivityRecvGiftData> _repeated_recvGiftList_codec
      = pb::FieldCodec.ForMessage(90, global::ActivityRecvGiftData.Parser);
  private readonly pbc::RepeatedField<global::ActivityRecvGiftData> recvGiftList_ = new pbc::RepeatedField<global::ActivityRecvGiftData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ActivityRecvGiftData> RecvGiftList {
    get { return recvGiftList_; }
  }

  /// <summary>Field number for the "schedule_id" field.</summary>
  public const int ScheduleIdFieldNumber = 6;
  private uint scheduleId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ScheduleId {
    get { return scheduleId_; }
    set {
      scheduleId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ActivityGetRecvGiftListRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ActivityGetRecvGiftListRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if(!recvGiftList_.Equals(other.recvGiftList_)) return false;
    if (ScheduleId != other.ScheduleId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    hash ^= recvGiftList_.GetHashCode();
    if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
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
    if (ScheduleId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ScheduleId);
    }
    recvGiftList_.WriteTo(output, _repeated_recvGiftList_codec);
    if (Retcode != 0) {
      output.WriteRawTag(120);
      output.WriteInt32(Retcode);
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
    if (ScheduleId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(ScheduleId);
    }
    recvGiftList_.WriteTo(ref output, _repeated_recvGiftList_codec);
    if (Retcode != 0) {
      output.WriteRawTag(120);
      output.WriteInt32(Retcode);
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
    size += recvGiftList_.CalculateSize(_repeated_recvGiftList_codec);
    if (ScheduleId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ActivityGetRecvGiftListRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    recvGiftList_.Add(other.recvGiftList_);
    if (other.ScheduleId != 0) {
      ScheduleId = other.ScheduleId;
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
        case 48: {
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 90: {
          recvGiftList_.AddEntriesFrom(input, _repeated_recvGiftList_codec);
          break;
        }
        case 120: {
          Retcode = input.ReadInt32();
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
        case 48: {
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 90: {
          recvGiftList_.AddEntriesFrom(ref input, _repeated_recvGiftList_codec);
          break;
        }
        case 120: {
          Retcode = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
