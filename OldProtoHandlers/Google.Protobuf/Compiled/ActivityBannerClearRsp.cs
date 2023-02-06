// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityBannerClearRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ActivityBannerClearRsp.proto</summary>
public static partial class ActivityBannerClearRspReflection {

  #region Descriptor
  /// <summary>File descriptor for ActivityBannerClearRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ActivityBannerClearRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxBY3Rpdml0eUJhbm5lckNsZWFyUnNwLnByb3RvIlMKFkFjdGl2aXR5QmFu",
          "bmVyQ2xlYXJSc3ASEwoLYWN0aXZpdHlfaWQYBCABKA0SDwoHcmV0Y29kZRgG",
          "IAEoBRITCgtzY2hlZHVsZV9pZBgLIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIu",
          "bmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ActivityBannerClearRsp), global::ActivityBannerClearRsp.Parser, new[]{ "ActivityId", "Retcode", "ScheduleId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2163
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ActivityBannerClearRsp : pb::IMessage<ActivityBannerClearRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ActivityBannerClearRsp> _parser = new pb::MessageParser<ActivityBannerClearRsp>(() => new ActivityBannerClearRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ActivityBannerClearRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ActivityBannerClearRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityBannerClearRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityBannerClearRsp(ActivityBannerClearRsp other) : this() {
    activityId_ = other.activityId_;
    retcode_ = other.retcode_;
    scheduleId_ = other.scheduleId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityBannerClearRsp Clone() {
    return new ActivityBannerClearRsp(this);
  }

  /// <summary>Field number for the "activity_id" field.</summary>
  public const int ActivityIdFieldNumber = 4;
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
  public const int RetcodeFieldNumber = 6;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "schedule_id" field.</summary>
  public const int ScheduleIdFieldNumber = 11;
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
    return Equals(other as ActivityBannerClearRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ActivityBannerClearRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ActivityId != other.ActivityId) return false;
    if (Retcode != other.Retcode) return false;
    if (ScheduleId != other.ScheduleId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (ActivityId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(ActivityId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(Retcode);
    }
    if (ScheduleId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ScheduleId);
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
    if (ActivityId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(ActivityId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(Retcode);
    }
    if (ScheduleId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ScheduleId);
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
  public void MergeFrom(ActivityBannerClearRsp other) {
    if (other == null) {
      return;
    }
    if (other.ActivityId != 0) {
      ActivityId = other.ActivityId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
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
        case 32: {
          ActivityId = input.ReadUInt32();
          break;
        }
        case 48: {
          Retcode = input.ReadInt32();
          break;
        }
        case 88: {
          ScheduleId = input.ReadUInt32();
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
          ActivityId = input.ReadUInt32();
          break;
        }
        case 48: {
          Retcode = input.ReadInt32();
          break;
        }
        case 88: {
          ScheduleId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
