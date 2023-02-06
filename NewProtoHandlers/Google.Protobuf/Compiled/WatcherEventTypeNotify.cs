// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WatcherEventTypeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WatcherEventTypeNotify.proto</summary>
public static partial class WatcherEventTypeNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for WatcherEventTypeNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WatcherEventTypeNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxXYXRjaGVyRXZlbnRUeXBlTm90aWZ5LnByb3RvImAKFldhdGNoZXJFdmVu",
          "dFR5cGVOb3RpZnkSEgoKcGFyYW1fbGlzdBgEIAMoDRIUCgxhZGRfcHJvZ3Jl",
          "c3MYDSABKA0SHAoUd2F0Y2hlcl90cmlnZ2VyX3R5cGUYAiABKA1CFgoUb3Jn",
          "LnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WatcherEventTypeNotify), global::WatcherEventTypeNotify.Parser, new[]{ "ParamList", "AddProgress", "WatcherTriggerType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 2219;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class WatcherEventTypeNotify : pb::IMessage<WatcherEventTypeNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WatcherEventTypeNotify> _parser = new pb::MessageParser<WatcherEventTypeNotify>(() => new WatcherEventTypeNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WatcherEventTypeNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WatcherEventTypeNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WatcherEventTypeNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WatcherEventTypeNotify(WatcherEventTypeNotify other) : this() {
    paramList_ = other.paramList_.Clone();
    addProgress_ = other.addProgress_;
    watcherTriggerType_ = other.watcherTriggerType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WatcherEventTypeNotify Clone() {
    return new WatcherEventTypeNotify(this);
  }

  /// <summary>Field number for the "param_list" field.</summary>
  public const int ParamListFieldNumber = 4;
  private static readonly pb::FieldCodec<uint> _repeated_paramList_codec
      = pb::FieldCodec.ForUInt32(34);
  private readonly pbc::RepeatedField<uint> paramList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ParamList {
    get { return paramList_; }
  }

  /// <summary>Field number for the "add_progress" field.</summary>
  public const int AddProgressFieldNumber = 13;
  private uint addProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AddProgress {
    get { return addProgress_; }
    set {
      addProgress_ = value;
    }
  }

  /// <summary>Field number for the "watcher_trigger_type" field.</summary>
  public const int WatcherTriggerTypeFieldNumber = 2;
  private uint watcherTriggerType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WatcherTriggerType {
    get { return watcherTriggerType_; }
    set {
      watcherTriggerType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WatcherEventTypeNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WatcherEventTypeNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!paramList_.Equals(other.paramList_)) return false;
    if (AddProgress != other.AddProgress) return false;
    if (WatcherTriggerType != other.WatcherTriggerType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= paramList_.GetHashCode();
    if (AddProgress != 0) hash ^= AddProgress.GetHashCode();
    if (WatcherTriggerType != 0) hash ^= WatcherTriggerType.GetHashCode();
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
    if (WatcherTriggerType != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(WatcherTriggerType);
    }
    paramList_.WriteTo(output, _repeated_paramList_codec);
    if (AddProgress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(AddProgress);
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
    if (WatcherTriggerType != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(WatcherTriggerType);
    }
    paramList_.WriteTo(ref output, _repeated_paramList_codec);
    if (AddProgress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(AddProgress);
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
    size += paramList_.CalculateSize(_repeated_paramList_codec);
    if (AddProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddProgress);
    }
    if (WatcherTriggerType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WatcherTriggerType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WatcherEventTypeNotify other) {
    if (other == null) {
      return;
    }
    paramList_.Add(other.paramList_);
    if (other.AddProgress != 0) {
      AddProgress = other.AddProgress;
    }
    if (other.WatcherTriggerType != 0) {
      WatcherTriggerType = other.WatcherTriggerType;
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
          WatcherTriggerType = input.ReadUInt32();
          break;
        }
        case 34:
        case 32: {
          paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
          break;
        }
        case 104: {
          AddProgress = input.ReadUInt32();
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
          WatcherTriggerType = input.ReadUInt32();
          break;
        }
        case 34:
        case 32: {
          paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
          break;
        }
        case 104: {
          AddProgress = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code