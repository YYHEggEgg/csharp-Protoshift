// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BounceConjuringChapterInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from BounceConjuringChapterInfo.proto</summary>
  public static partial class BounceConjuringChapterInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BounceConjuringChapterInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BounceConjuringChapterInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBCb3VuY2VDb25qdXJpbmdDaGFwdGVySW5mby5wcm90byJXChpCb3VuY2VD",
            "b25qdXJpbmdDaGFwdGVySW5mbxISCgpiZXN0X3Njb3JlGAwgASgNEhEKCW9w",
            "ZW5fdGltZRgJIAEoDRISCgpjaGFwdGVyX2lkGA0gASgNQgyqAglPbGRQcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.BounceConjuringChapterInfo), global::OldProtos.BounceConjuringChapterInfo.Parser, new[]{ "BestScore", "OpenTime", "ChapterId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BounceConjuringChapterInfo : pb::IMessage<BounceConjuringChapterInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BounceConjuringChapterInfo> _parser = new pb::MessageParser<BounceConjuringChapterInfo>(() => new BounceConjuringChapterInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BounceConjuringChapterInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.BounceConjuringChapterInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringChapterInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringChapterInfo(BounceConjuringChapterInfo other) : this() {
      bestScore_ = other.bestScore_;
      openTime_ = other.openTime_;
      chapterId_ = other.chapterId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringChapterInfo Clone() {
      return new BounceConjuringChapterInfo(this);
    }

    /// <summary>Field number for the "best_score" field.</summary>
    public const int BestScoreFieldNumber = 12;
    private uint bestScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestScore {
      get { return bestScore_; }
      set {
        bestScore_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 9;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "chapter_id" field.</summary>
    public const int ChapterIdFieldNumber = 13;
    private uint chapterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChapterId {
      get { return chapterId_; }
      set {
        chapterId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BounceConjuringChapterInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BounceConjuringChapterInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BestScore != other.BestScore) return false;
      if (OpenTime != other.OpenTime) return false;
      if (ChapterId != other.ChapterId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BestScore != 0) hash ^= BestScore.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (ChapterId != 0) hash ^= ChapterId.GetHashCode();
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
      if (OpenTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OpenTime);
      }
      if (BestScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BestScore);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChapterId);
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
      if (OpenTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OpenTime);
      }
      if (BestScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BestScore);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChapterId);
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
      if (BestScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestScore);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (ChapterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChapterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BounceConjuringChapterInfo other) {
      if (other == null) {
        return;
      }
      if (other.BestScore != 0) {
        BestScore = other.BestScore;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      if (other.ChapterId != 0) {
        ChapterId = other.ChapterId;
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
          case 72: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 96: {
            BestScore = input.ReadUInt32();
            break;
          }
          case 104: {
            ChapterId = input.ReadUInt32();
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
          case 72: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 96: {
            BestScore = input.ReadUInt32();
            break;
          }
          case 104: {
            ChapterId = input.ReadUInt32();
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