// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BounceConjuringActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from BounceConjuringActivityDetailInfo.proto</summary>
  public static partial class BounceConjuringActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BounceConjuringActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BounceConjuringActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidCb3VuY2VDb25qdXJpbmdBY3Rpdml0eURldGFpbEluZm8ucHJvdG8aIEJv",
            "dW5jZUNvbmp1cmluZ0NoYXB0ZXJJbmZvLnByb3RvIpIBCiFCb3VuY2VDb25q",
            "dXJpbmdBY3Rpdml0eURldGFpbEluZm8SNgoRY2hhcHRlcl9pbmZvX2xpc3QY",
            "CCADKAsyGy5Cb3VuY2VDb25qdXJpbmdDaGFwdGVySW5mbxIZChFpc19jb250",
            "ZW50X2Nsb3NlZBgMIAEoCBIaChJjb250ZW50X2Nsb3NlX3RpbWUYByABKA1C",
            "DKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.BounceConjuringChapterInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.BounceConjuringActivityDetailInfo), global::OldProtos.BounceConjuringActivityDetailInfo.Parser, new[]{ "ChapterInfoList", "IsContentClosed", "ContentCloseTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BounceConjuringActivityDetailInfo : pb::IMessage<BounceConjuringActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BounceConjuringActivityDetailInfo> _parser = new pb::MessageParser<BounceConjuringActivityDetailInfo>(() => new BounceConjuringActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BounceConjuringActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.BounceConjuringActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringActivityDetailInfo(BounceConjuringActivityDetailInfo other) : this() {
      chapterInfoList_ = other.chapterInfoList_.Clone();
      isContentClosed_ = other.isContentClosed_;
      contentCloseTime_ = other.contentCloseTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringActivityDetailInfo Clone() {
      return new BounceConjuringActivityDetailInfo(this);
    }

    /// <summary>Field number for the "chapter_info_list" field.</summary>
    public const int ChapterInfoListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::OldProtos.BounceConjuringChapterInfo> _repeated_chapterInfoList_codec
        = pb::FieldCodec.ForMessage(66, global::OldProtos.BounceConjuringChapterInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.BounceConjuringChapterInfo> chapterInfoList_ = new pbc::RepeatedField<global::OldProtos.BounceConjuringChapterInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.BounceConjuringChapterInfo> ChapterInfoList {
      get { return chapterInfoList_; }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 12;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 7;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BounceConjuringActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BounceConjuringActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chapterInfoList_.Equals(other.chapterInfoList_)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (ContentCloseTime != other.ContentCloseTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chapterInfoList_.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
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
      if (ContentCloseTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ContentCloseTime);
      }
      chapterInfoList_.WriteTo(output, _repeated_chapterInfoList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
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
      if (ContentCloseTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ContentCloseTime);
      }
      chapterInfoList_.WriteTo(ref output, _repeated_chapterInfoList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
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
      size += chapterInfoList_.CalculateSize(_repeated_chapterInfoList_codec);
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BounceConjuringActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      chapterInfoList_.Add(other.chapterInfoList_);
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
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
          case 56: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 66: {
            chapterInfoList_.AddEntriesFrom(input, _repeated_chapterInfoList_codec);
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
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
          case 56: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 66: {
            chapterInfoList_.AddEntriesFrom(ref input, _repeated_chapterInfoList_codec);
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
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
