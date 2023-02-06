// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryProgressInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryProgressInfo.proto</summary>
public static partial class SceneGalleryProgressInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryProgressInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryProgressInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5TY2VuZUdhbGxlcnlQcm9ncmVzc0luZm8ucHJvdG8iZwoYU2NlbmVHYWxs",
          "ZXJ5UHJvZ3Jlc3NJbmZvEgsKA2tleRgDIAEoCRIPCgd1aV9mb3JtGAwgASgN",
          "EhsKE3Byb2dyZXNzX3N0YWdlX2xpc3QYByADKA0SEAoIcHJvZ3Jlc3MYDSAB",
          "KA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryProgressInfo), global::SceneGalleryProgressInfo.Parser, new[]{ "Key", "UiForm", "ProgressStageList", "Progress" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SceneGalleryProgressInfo : pb::IMessage<SceneGalleryProgressInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryProgressInfo> _parser = new pb::MessageParser<SceneGalleryProgressInfo>(() => new SceneGalleryProgressInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryProgressInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryProgressInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryProgressInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryProgressInfo(SceneGalleryProgressInfo other) : this() {
    key_ = other.key_;
    uiForm_ = other.uiForm_;
    progressStageList_ = other.progressStageList_.Clone();
    progress_ = other.progress_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryProgressInfo Clone() {
    return new SceneGalleryProgressInfo(this);
  }

  /// <summary>Field number for the "key" field.</summary>
  public const int KeyFieldNumber = 3;
  private string key_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Key {
    get { return key_; }
    set {
      key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ui_form" field.</summary>
  public const int UiFormFieldNumber = 12;
  private uint uiForm_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint UiForm {
    get { return uiForm_; }
    set {
      uiForm_ = value;
    }
  }

  /// <summary>Field number for the "progress_stage_list" field.</summary>
  public const int ProgressStageListFieldNumber = 7;
  private static readonly pb::FieldCodec<uint> _repeated_progressStageList_codec
      = pb::FieldCodec.ForUInt32(58);
  private readonly pbc::RepeatedField<uint> progressStageList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ProgressStageList {
    get { return progressStageList_; }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 13;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneGalleryProgressInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryProgressInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Key != other.Key) return false;
    if (UiForm != other.UiForm) return false;
    if(!progressStageList_.Equals(other.progressStageList_)) return false;
    if (Progress != other.Progress) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Key.Length != 0) hash ^= Key.GetHashCode();
    if (UiForm != 0) hash ^= UiForm.GetHashCode();
    hash ^= progressStageList_.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
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
    if (Key.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Key);
    }
    progressStageList_.WriteTo(output, _repeated_progressStageList_codec);
    if (UiForm != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(UiForm);
    }
    if (Progress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(Progress);
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
    if (Key.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Key);
    }
    progressStageList_.WriteTo(ref output, _repeated_progressStageList_codec);
    if (UiForm != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(UiForm);
    }
    if (Progress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(Progress);
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
    if (Key.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
    }
    if (UiForm != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UiForm);
    }
    size += progressStageList_.CalculateSize(_repeated_progressStageList_codec);
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneGalleryProgressInfo other) {
    if (other == null) {
      return;
    }
    if (other.Key.Length != 0) {
      Key = other.Key;
    }
    if (other.UiForm != 0) {
      UiForm = other.UiForm;
    }
    progressStageList_.Add(other.progressStageList_);
    if (other.Progress != 0) {
      Progress = other.Progress;
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
        case 26: {
          Key = input.ReadString();
          break;
        }
        case 58:
        case 56: {
          progressStageList_.AddEntriesFrom(input, _repeated_progressStageList_codec);
          break;
        }
        case 96: {
          UiForm = input.ReadUInt32();
          break;
        }
        case 104: {
          Progress = input.ReadUInt32();
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
        case 26: {
          Key = input.ReadString();
          break;
        }
        case 58:
        case 56: {
          progressStageList_.AddEntriesFrom(ref input, _repeated_progressStageList_codec);
          break;
        }
        case 96: {
          UiForm = input.ReadUInt32();
          break;
        }
        case 104: {
          Progress = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code