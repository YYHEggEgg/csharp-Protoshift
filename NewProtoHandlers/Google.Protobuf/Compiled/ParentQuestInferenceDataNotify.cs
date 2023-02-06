// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ParentQuestInferenceDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ParentQuestInferenceDataNotify.proto</summary>
public static partial class ParentQuestInferenceDataNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ParentQuestInferenceDataNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ParentQuestInferenceDataNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiRQYXJlbnRRdWVzdEluZmVyZW5jZURhdGFOb3RpZnkucHJvdG8aF0luZmVy",
          "ZW5jZVBhZ2VJbmZvLnByb3RvImoKHlBhcmVudFF1ZXN0SW5mZXJlbmNlRGF0",
          "YU5vdGlmeRIXCg9wYXJlbnRfcXVlc3RfaWQYCCABKA0SLwoTaW5mZXJlbmNl",
          "X3BhZ2VfbGlzdBgOIAMoCzISLkluZmVyZW5jZVBhZ2VJbmZvQhYKFG9yZy5z",
          "b3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::InferencePageInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ParentQuestInferenceDataNotify), global::ParentQuestInferenceDataNotify.Parser, new[]{ "ParentQuestId", "InferencePageList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 493;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class ParentQuestInferenceDataNotify : pb::IMessage<ParentQuestInferenceDataNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ParentQuestInferenceDataNotify> _parser = new pb::MessageParser<ParentQuestInferenceDataNotify>(() => new ParentQuestInferenceDataNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ParentQuestInferenceDataNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ParentQuestInferenceDataNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ParentQuestInferenceDataNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ParentQuestInferenceDataNotify(ParentQuestInferenceDataNotify other) : this() {
    parentQuestId_ = other.parentQuestId_;
    inferencePageList_ = other.inferencePageList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ParentQuestInferenceDataNotify Clone() {
    return new ParentQuestInferenceDataNotify(this);
  }

  /// <summary>Field number for the "parent_quest_id" field.</summary>
  public const int ParentQuestIdFieldNumber = 8;
  private uint parentQuestId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ParentQuestId {
    get { return parentQuestId_; }
    set {
      parentQuestId_ = value;
    }
  }

  /// <summary>Field number for the "inference_page_list" field.</summary>
  public const int InferencePageListFieldNumber = 14;
  private static readonly pb::FieldCodec<global::InferencePageInfo> _repeated_inferencePageList_codec
      = pb::FieldCodec.ForMessage(114, global::InferencePageInfo.Parser);
  private readonly pbc::RepeatedField<global::InferencePageInfo> inferencePageList_ = new pbc::RepeatedField<global::InferencePageInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InferencePageInfo> InferencePageList {
    get { return inferencePageList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ParentQuestInferenceDataNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ParentQuestInferenceDataNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ParentQuestId != other.ParentQuestId) return false;
    if(!inferencePageList_.Equals(other.inferencePageList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
    hash ^= inferencePageList_.GetHashCode();
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
    if (ParentQuestId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(ParentQuestId);
    }
    inferencePageList_.WriteTo(output, _repeated_inferencePageList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (ParentQuestId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(ParentQuestId);
    }
    inferencePageList_.WriteTo(ref output, _repeated_inferencePageList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (ParentQuestId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
    }
    size += inferencePageList_.CalculateSize(_repeated_inferencePageList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ParentQuestInferenceDataNotify other) {
    if (other == null) {
      return;
    }
    if (other.ParentQuestId != 0) {
      ParentQuestId = other.ParentQuestId;
    }
    inferencePageList_.Add(other.inferencePageList_);
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
        case 64: {
          ParentQuestId = input.ReadUInt32();
          break;
        }
        case 114: {
          inferencePageList_.AddEntriesFrom(input, _repeated_inferencePageList_codec);
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
        case 64: {
          ParentQuestId = input.ReadUInt32();
          break;
        }
        case 114: {
          inferencePageList_.AddEntriesFrom(ref input, _repeated_inferencePageList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
