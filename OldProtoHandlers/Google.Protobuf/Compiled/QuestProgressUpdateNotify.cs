// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestProgressUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from QuestProgressUpdateNotify.proto</summary>
public static partial class QuestProgressUpdateNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for QuestProgressUpdateNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static QuestProgressUpdateNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9RdWVzdFByb2dyZXNzVXBkYXRlTm90aWZ5LnByb3RvImcKGVF1ZXN0UHJv",
          "Z3Jlc3NVcGRhdGVOb3RpZnkSEAoIcXVlc3RfaWQYDCABKA0SGgoSZmFpbF9w",
          "cm9ncmVzc19saXN0GAYgAygNEhwKFGZpbmlzaF9wcm9ncmVzc19saXN0GA0g",
          "AygNQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::QuestProgressUpdateNotify), global::QuestProgressUpdateNotify.Parser, new[]{ "QuestId", "FailProgressList", "FinishProgressList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 482
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class QuestProgressUpdateNotify : pb::IMessage<QuestProgressUpdateNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<QuestProgressUpdateNotify> _parser = new pb::MessageParser<QuestProgressUpdateNotify>(() => new QuestProgressUpdateNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<QuestProgressUpdateNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::QuestProgressUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public QuestProgressUpdateNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public QuestProgressUpdateNotify(QuestProgressUpdateNotify other) : this() {
    questId_ = other.questId_;
    failProgressList_ = other.failProgressList_.Clone();
    finishProgressList_ = other.finishProgressList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public QuestProgressUpdateNotify Clone() {
    return new QuestProgressUpdateNotify(this);
  }

  /// <summary>Field number for the "quest_id" field.</summary>
  public const int QuestIdFieldNumber = 12;
  private uint questId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint QuestId {
    get { return questId_; }
    set {
      questId_ = value;
    }
  }

  /// <summary>Field number for the "fail_progress_list" field.</summary>
  public const int FailProgressListFieldNumber = 6;
  private static readonly pb::FieldCodec<uint> _repeated_failProgressList_codec
      = pb::FieldCodec.ForUInt32(50);
  private readonly pbc::RepeatedField<uint> failProgressList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> FailProgressList {
    get { return failProgressList_; }
  }

  /// <summary>Field number for the "finish_progress_list" field.</summary>
  public const int FinishProgressListFieldNumber = 13;
  private static readonly pb::FieldCodec<uint> _repeated_finishProgressList_codec
      = pb::FieldCodec.ForUInt32(106);
  private readonly pbc::RepeatedField<uint> finishProgressList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> FinishProgressList {
    get { return finishProgressList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as QuestProgressUpdateNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(QuestProgressUpdateNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (QuestId != other.QuestId) return false;
    if(!failProgressList_.Equals(other.failProgressList_)) return false;
    if(!finishProgressList_.Equals(other.finishProgressList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (QuestId != 0) hash ^= QuestId.GetHashCode();
    hash ^= failProgressList_.GetHashCode();
    hash ^= finishProgressList_.GetHashCode();
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
    failProgressList_.WriteTo(output, _repeated_failProgressList_codec);
    if (QuestId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(QuestId);
    }
    finishProgressList_.WriteTo(output, _repeated_finishProgressList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    failProgressList_.WriteTo(ref output, _repeated_failProgressList_codec);
    if (QuestId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(QuestId);
    }
    finishProgressList_.WriteTo(ref output, _repeated_finishProgressList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (QuestId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
    }
    size += failProgressList_.CalculateSize(_repeated_failProgressList_codec);
    size += finishProgressList_.CalculateSize(_repeated_finishProgressList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(QuestProgressUpdateNotify other) {
    if (other == null) {
      return;
    }
    if (other.QuestId != 0) {
      QuestId = other.QuestId;
    }
    failProgressList_.Add(other.failProgressList_);
    finishProgressList_.Add(other.finishProgressList_);
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
        case 50:
        case 48: {
          failProgressList_.AddEntriesFrom(input, _repeated_failProgressList_codec);
          break;
        }
        case 96: {
          QuestId = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          finishProgressList_.AddEntriesFrom(input, _repeated_finishProgressList_codec);
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
        case 50:
        case 48: {
          failProgressList_.AddEntriesFrom(ref input, _repeated_failProgressList_codec);
          break;
        }
        case 96: {
          QuestId = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          finishProgressList_.AddEntriesFrom(ref input, _repeated_finishProgressList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
