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
namespace OldProtos {

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
            "ZXJ5UHJvZ3Jlc3NJbmZvEhsKE3Byb2dyZXNzX3N0YWdlX2xpc3QYCCADKA0S",
            "CwoDa2V5GAsgASgJEhAKCHByb2dyZXNzGAUgASgNEg8KB3VpX2Zvcm0YDCAB",
            "KA1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.SceneGalleryProgressInfo), global::OldProtos.SceneGalleryProgressInfo.Parser, new[]{ "ProgressStageList", "Key", "Progress", "UiForm" }, null, null, null, null)
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
      get { return global::OldProtos.SceneGalleryProgressInfoReflection.Descriptor.MessageTypes[0]; }
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
      progressStageList_ = other.progressStageList_.Clone();
      key_ = other.key_;
      progress_ = other.progress_;
      uiForm_ = other.uiForm_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryProgressInfo Clone() {
      return new SceneGalleryProgressInfo(this);
    }

    /// <summary>Field number for the "progress_stage_list" field.</summary>
    public const int ProgressStageListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_progressStageList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> progressStageList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ProgressStageList {
      get { return progressStageList_; }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 11;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 5;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
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
      if(!progressStageList_.Equals(other.progressStageList_)) return false;
      if (Key != other.Key) return false;
      if (Progress != other.Progress) return false;
      if (UiForm != other.UiForm) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= progressStageList_.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (UiForm != 0) hash ^= UiForm.GetHashCode();
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
      if (Progress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Progress);
      }
      progressStageList_.WriteTo(output, _repeated_progressStageList_codec);
      if (Key.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Key);
      }
      if (UiForm != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(UiForm);
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
      if (Progress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Progress);
      }
      progressStageList_.WriteTo(ref output, _repeated_progressStageList_codec);
      if (Key.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Key);
      }
      if (UiForm != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(UiForm);
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
      size += progressStageList_.CalculateSize(_repeated_progressStageList_codec);
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (UiForm != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UiForm);
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
      progressStageList_.Add(other.progressStageList_);
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.UiForm != 0) {
        UiForm = other.UiForm;
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
          case 40: {
            Progress = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            progressStageList_.AddEntriesFrom(input, _repeated_progressStageList_codec);
            break;
          }
          case 90: {
            Key = input.ReadString();
            break;
          }
          case 96: {
            UiForm = input.ReadUInt32();
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
          case 40: {
            Progress = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            progressStageList_.AddEntriesFrom(ref input, _repeated_progressStageList_codec);
            break;
          }
          case 90: {
            Key = input.ReadString();
            break;
          }
          case 96: {
            UiForm = input.ReadUInt32();
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
