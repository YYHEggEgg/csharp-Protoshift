// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityTakeWatcherRewardReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ActivityTakeWatcherRewardReq.proto</summary>
  public static partial class ActivityTakeWatcherRewardReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityTakeWatcherRewardReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityTakeWatcherRewardReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBY3Rpdml0eVRha2VXYXRjaGVyUmV3YXJkUmVxLnByb3RvIkcKHEFjdGl2",
            "aXR5VGFrZVdhdGNoZXJSZXdhcmRSZXESEwoLYWN0aXZpdHlfaWQYBCABKA0S",
            "EgoKd2F0Y2hlcl9pZBgOIAEoDUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ActivityTakeWatcherRewardReq), global::OldProtos.ActivityTakeWatcherRewardReq.Parser, new[]{ "ActivityId", "WatcherId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2038
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class ActivityTakeWatcherRewardReq : pb::IMessage<ActivityTakeWatcherRewardReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityTakeWatcherRewardReq> _parser = new pb::MessageParser<ActivityTakeWatcherRewardReq>(() => new ActivityTakeWatcherRewardReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityTakeWatcherRewardReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ActivityTakeWatcherRewardReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityTakeWatcherRewardReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityTakeWatcherRewardReq(ActivityTakeWatcherRewardReq other) : this() {
      activityId_ = other.activityId_;
      watcherId_ = other.watcherId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityTakeWatcherRewardReq Clone() {
      return new ActivityTakeWatcherRewardReq(this);
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

    /// <summary>Field number for the "watcher_id" field.</summary>
    public const int WatcherIdFieldNumber = 14;
    private uint watcherId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WatcherId {
      get { return watcherId_; }
      set {
        watcherId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityTakeWatcherRewardReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityTakeWatcherRewardReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActivityId != other.ActivityId) return false;
      if (WatcherId != other.WatcherId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
      if (WatcherId != 0) hash ^= WatcherId.GetHashCode();
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
      if (WatcherId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(WatcherId);
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
      if (WatcherId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(WatcherId);
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
      if (WatcherId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WatcherId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityTakeWatcherRewardReq other) {
      if (other == null) {
        return;
      }
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
      }
      if (other.WatcherId != 0) {
        WatcherId = other.WatcherId;
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
          case 112: {
            WatcherId = input.ReadUInt32();
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
          case 112: {
            WatcherId = input.ReadUInt32();
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
