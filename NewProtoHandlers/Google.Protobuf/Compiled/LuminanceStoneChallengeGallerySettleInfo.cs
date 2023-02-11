// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LuminanceStoneChallengeGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from LuminanceStoneChallengeGallerySettleInfo.proto</summary>
  public static partial class LuminanceStoneChallengeGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LuminanceStoneChallengeGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LuminanceStoneChallengeGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5MdW1pbmFuY2VTdG9uZUNoYWxsZW5nZUdhbGxlcnlTZXR0bGVJbmZvLnBy",
            "b3RvGhdHYWxsZXJ5U3RvcFJlYXNvbi5wcm90byLQAQooTHVtaW5hbmNlU3Rv",
            "bmVDaGFsbGVuZ2VHYWxsZXJ5U2V0dGxlSW5mbxITCgtmaW5hbF9zY29yZRgM",
            "IAEoDRIXCg9jbGVhbl9tdWRfY291bnQYCCABKA0SIgoGcmVhc29uGA8gASgO",
            "MhIuR2FsbGVyeVN0b3BSZWFzb24SEgoKZ2FsbGVyeV9pZBgLIAEoDRIiChpr",
            "aWxsX3NwZWNpYWxfbW9uc3Rlcl9jb3VudBgEIAEoDRIaChJraWxsX21vbnN0",
            "ZXJfY291bnQYASABKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GalleryStopReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.LuminanceStoneChallengeGallerySettleInfo), global::NewProtos.LuminanceStoneChallengeGallerySettleInfo.Parser, new[]{ "FinalScore", "CleanMudCount", "Reason", "GalleryId", "KillSpecialMonsterCount", "KillMonsterCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LuminanceStoneChallengeGallerySettleInfo : pb::IMessage<LuminanceStoneChallengeGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LuminanceStoneChallengeGallerySettleInfo> _parser = new pb::MessageParser<LuminanceStoneChallengeGallerySettleInfo>(() => new LuminanceStoneChallengeGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LuminanceStoneChallengeGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.LuminanceStoneChallengeGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuminanceStoneChallengeGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuminanceStoneChallengeGallerySettleInfo(LuminanceStoneChallengeGallerySettleInfo other) : this() {
      finalScore_ = other.finalScore_;
      cleanMudCount_ = other.cleanMudCount_;
      reason_ = other.reason_;
      galleryId_ = other.galleryId_;
      killSpecialMonsterCount_ = other.killSpecialMonsterCount_;
      killMonsterCount_ = other.killMonsterCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuminanceStoneChallengeGallerySettleInfo Clone() {
      return new LuminanceStoneChallengeGallerySettleInfo(this);
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 12;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "clean_mud_count" field.</summary>
    public const int CleanMudCountFieldNumber = 8;
    private uint cleanMudCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CleanMudCount {
      get { return cleanMudCount_; }
      set {
        cleanMudCount_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 15;
    private global::NewProtos.GalleryStopReason reason_ = global::NewProtos.GalleryStopReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GalleryStopReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 11;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "kill_special_monster_count" field.</summary>
    public const int KillSpecialMonsterCountFieldNumber = 4;
    private uint killSpecialMonsterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillSpecialMonsterCount {
      get { return killSpecialMonsterCount_; }
      set {
        killSpecialMonsterCount_ = value;
      }
    }

    /// <summary>Field number for the "kill_monster_count" field.</summary>
    public const int KillMonsterCountFieldNumber = 1;
    private uint killMonsterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillMonsterCount {
      get { return killMonsterCount_; }
      set {
        killMonsterCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LuminanceStoneChallengeGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LuminanceStoneChallengeGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FinalScore != other.FinalScore) return false;
      if (CleanMudCount != other.CleanMudCount) return false;
      if (Reason != other.Reason) return false;
      if (GalleryId != other.GalleryId) return false;
      if (KillSpecialMonsterCount != other.KillSpecialMonsterCount) return false;
      if (KillMonsterCount != other.KillMonsterCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (CleanMudCount != 0) hash ^= CleanMudCount.GetHashCode();
      if (Reason != global::NewProtos.GalleryStopReason.None) hash ^= Reason.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (KillSpecialMonsterCount != 0) hash ^= KillSpecialMonsterCount.GetHashCode();
      if (KillMonsterCount != 0) hash ^= KillMonsterCount.GetHashCode();
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
      if (KillMonsterCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KillMonsterCount);
      }
      if (KillSpecialMonsterCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KillSpecialMonsterCount);
      }
      if (CleanMudCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CleanMudCount);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FinalScore);
      }
      if (Reason != global::NewProtos.GalleryStopReason.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Reason);
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
      if (KillMonsterCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(KillMonsterCount);
      }
      if (KillSpecialMonsterCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KillSpecialMonsterCount);
      }
      if (CleanMudCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CleanMudCount);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FinalScore);
      }
      if (Reason != global::NewProtos.GalleryStopReason.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Reason);
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
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (CleanMudCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CleanMudCount);
      }
      if (Reason != global::NewProtos.GalleryStopReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (KillSpecialMonsterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillSpecialMonsterCount);
      }
      if (KillMonsterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillMonsterCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LuminanceStoneChallengeGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.CleanMudCount != 0) {
        CleanMudCount = other.CleanMudCount;
      }
      if (other.Reason != global::NewProtos.GalleryStopReason.None) {
        Reason = other.Reason;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.KillSpecialMonsterCount != 0) {
        KillSpecialMonsterCount = other.KillSpecialMonsterCount;
      }
      if (other.KillMonsterCount != 0) {
        KillMonsterCount = other.KillMonsterCount;
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
            KillMonsterCount = input.ReadUInt32();
            break;
          }
          case 32: {
            KillSpecialMonsterCount = input.ReadUInt32();
            break;
          }
          case 64: {
            CleanMudCount = input.ReadUInt32();
            break;
          }
          case 88: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 96: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            Reason = (global::NewProtos.GalleryStopReason) input.ReadEnum();
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
            KillMonsterCount = input.ReadUInt32();
            break;
          }
          case 32: {
            KillSpecialMonsterCount = input.ReadUInt32();
            break;
          }
          case 64: {
            CleanMudCount = input.ReadUInt32();
            break;
          }
          case 88: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 96: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            Reason = (global::NewProtos.GalleryStopReason) input.ReadEnum();
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