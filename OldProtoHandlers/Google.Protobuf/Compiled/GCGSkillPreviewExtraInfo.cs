// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewExtraInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewExtraInfo.proto</summary>
  public static partial class GCGSkillPreviewExtraInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewExtraInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewExtraInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HQ0dTa2lsbFByZXZpZXdFeHRyYUluZm8ucHJvdG8aHUdDR1NraWxsUHJl",
            "dmlld0NhcmRJbmZvLnByb3RvIpcBChhHQ0dTa2lsbFByZXZpZXdFeHRyYUlu",
            "Zm8SOwoZZmFpbF9hZGRlZF93aGVuX2Z1bGxfbGlzdBgOIAMoCzIYLkdDR1Nr",
            "aWxsUHJldmlld0NhcmRJbmZvEj4KHHJlZnJlc2hfY2FyZF93aGVuX2V4aXN0",
            "X2xpc3QYBiADKAsyGC5HQ0dTa2lsbFByZXZpZXdDYXJkSW5mb0IMqgIJT2xk",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.GCGSkillPreviewCardInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GCGSkillPreviewExtraInfo), global::OldProtos.GCGSkillPreviewExtraInfo.Parser, new[]{ "FailAddedWhenFullList", "RefreshCardWhenExistList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGSkillPreviewExtraInfo : pb::IMessage<GCGSkillPreviewExtraInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewExtraInfo> _parser = new pb::MessageParser<GCGSkillPreviewExtraInfo>(() => new GCGSkillPreviewExtraInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewExtraInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GCGSkillPreviewExtraInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewExtraInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewExtraInfo(GCGSkillPreviewExtraInfo other) : this() {
      failAddedWhenFullList_ = other.failAddedWhenFullList_.Clone();
      refreshCardWhenExistList_ = other.refreshCardWhenExistList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewExtraInfo Clone() {
      return new GCGSkillPreviewExtraInfo(this);
    }

    /// <summary>Field number for the "fail_added_when_full_list" field.</summary>
    public const int FailAddedWhenFullListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::OldProtos.GCGSkillPreviewCardInfo> _repeated_failAddedWhenFullList_codec
        = pb::FieldCodec.ForMessage(114, global::OldProtos.GCGSkillPreviewCardInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.GCGSkillPreviewCardInfo> failAddedWhenFullList_ = new pbc::RepeatedField<global::OldProtos.GCGSkillPreviewCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.GCGSkillPreviewCardInfo> FailAddedWhenFullList {
      get { return failAddedWhenFullList_; }
    }

    /// <summary>Field number for the "refresh_card_when_exist_list" field.</summary>
    public const int RefreshCardWhenExistListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::OldProtos.GCGSkillPreviewCardInfo> _repeated_refreshCardWhenExistList_codec
        = pb::FieldCodec.ForMessage(50, global::OldProtos.GCGSkillPreviewCardInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.GCGSkillPreviewCardInfo> refreshCardWhenExistList_ = new pbc::RepeatedField<global::OldProtos.GCGSkillPreviewCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.GCGSkillPreviewCardInfo> RefreshCardWhenExistList {
      get { return refreshCardWhenExistList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewExtraInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewExtraInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!failAddedWhenFullList_.Equals(other.failAddedWhenFullList_)) return false;
      if(!refreshCardWhenExistList_.Equals(other.refreshCardWhenExistList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= failAddedWhenFullList_.GetHashCode();
      hash ^= refreshCardWhenExistList_.GetHashCode();
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
      refreshCardWhenExistList_.WriteTo(output, _repeated_refreshCardWhenExistList_codec);
      failAddedWhenFullList_.WriteTo(output, _repeated_failAddedWhenFullList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      refreshCardWhenExistList_.WriteTo(ref output, _repeated_refreshCardWhenExistList_codec);
      failAddedWhenFullList_.WriteTo(ref output, _repeated_failAddedWhenFullList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += failAddedWhenFullList_.CalculateSize(_repeated_failAddedWhenFullList_codec);
      size += refreshCardWhenExistList_.CalculateSize(_repeated_refreshCardWhenExistList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewExtraInfo other) {
      if (other == null) {
        return;
      }
      failAddedWhenFullList_.Add(other.failAddedWhenFullList_);
      refreshCardWhenExistList_.Add(other.refreshCardWhenExistList_);
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
          case 50: {
            refreshCardWhenExistList_.AddEntriesFrom(input, _repeated_refreshCardWhenExistList_codec);
            break;
          }
          case 114: {
            failAddedWhenFullList_.AddEntriesFrom(input, _repeated_failAddedWhenFullList_codec);
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
          case 50: {
            refreshCardWhenExistList_.AddEntriesFrom(ref input, _repeated_refreshCardWhenExistList_codec);
            break;
          }
          case 114: {
            failAddedWhenFullList_.AddEntriesFrom(ref input, _repeated_failAddedWhenFullList_codec);
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
