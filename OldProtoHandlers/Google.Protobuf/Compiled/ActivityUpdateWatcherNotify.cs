// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityUpdateWatcherNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ActivityUpdateWatcherNotify.proto</summary>
public static partial class ActivityUpdateWatcherNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ActivityUpdateWatcherNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ActivityUpdateWatcherNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFBY3Rpdml0eVVwZGF0ZVdhdGNoZXJOb3RpZnkucHJvdG8aGUFjdGl2aXR5",
          "V2F0Y2hlckluZm8ucHJvdG8iXgobQWN0aXZpdHlVcGRhdGVXYXRjaGVyTm90",
          "aWZ5EioKDHdhdGNoZXJfaW5mbxgCIAEoCzIULkFjdGl2aXR5V2F0Y2hlcklu",
          "Zm8SEwoLYWN0aXZpdHlfaWQYASABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5l",
          "dC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ActivityWatcherInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ActivityUpdateWatcherNotify), global::ActivityUpdateWatcherNotify.Parser, new[]{ "WatcherInfo", "ActivityId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2156
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class ActivityUpdateWatcherNotify : pb::IMessage<ActivityUpdateWatcherNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ActivityUpdateWatcherNotify> _parser = new pb::MessageParser<ActivityUpdateWatcherNotify>(() => new ActivityUpdateWatcherNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ActivityUpdateWatcherNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ActivityUpdateWatcherNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityUpdateWatcherNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityUpdateWatcherNotify(ActivityUpdateWatcherNotify other) : this() {
    watcherInfo_ = other.watcherInfo_ != null ? other.watcherInfo_.Clone() : null;
    activityId_ = other.activityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityUpdateWatcherNotify Clone() {
    return new ActivityUpdateWatcherNotify(this);
  }

  /// <summary>Field number for the "watcher_info" field.</summary>
  public const int WatcherInfoFieldNumber = 2;
  private global::ActivityWatcherInfo watcherInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ActivityWatcherInfo WatcherInfo {
    get { return watcherInfo_; }
    set {
      watcherInfo_ = value;
    }
  }

  /// <summary>Field number for the "activity_id" field.</summary>
  public const int ActivityIdFieldNumber = 1;
  private uint activityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ActivityId {
    get { return activityId_; }
    set {
      activityId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ActivityUpdateWatcherNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ActivityUpdateWatcherNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(WatcherInfo, other.WatcherInfo)) return false;
    if (ActivityId != other.ActivityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (watcherInfo_ != null) hash ^= WatcherInfo.GetHashCode();
    if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
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
      output.WriteRawTag(8);
      output.WriteUInt32(ActivityId);
    }
    if (watcherInfo_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(WatcherInfo);
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
      output.WriteRawTag(8);
      output.WriteUInt32(ActivityId);
    }
    if (watcherInfo_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(WatcherInfo);
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
    if (watcherInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(WatcherInfo);
    }
    if (ActivityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ActivityUpdateWatcherNotify other) {
    if (other == null) {
      return;
    }
    if (other.watcherInfo_ != null) {
      if (watcherInfo_ == null) {
        WatcherInfo = new global::ActivityWatcherInfo();
      }
      WatcherInfo.MergeFrom(other.WatcherInfo);
    }
    if (other.ActivityId != 0) {
      ActivityId = other.ActivityId;
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
          ActivityId = input.ReadUInt32();
          break;
        }
        case 18: {
          if (watcherInfo_ == null) {
            WatcherInfo = new global::ActivityWatcherInfo();
          }
          input.ReadMessage(WatcherInfo);
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
          ActivityId = input.ReadUInt32();
          break;
        }
        case 18: {
          if (watcherInfo_ == null) {
            WatcherInfo = new global::ActivityWatcherInfo();
          }
          input.ReadMessage(WatcherInfo);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code