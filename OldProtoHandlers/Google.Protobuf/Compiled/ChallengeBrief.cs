// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChallengeBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ChallengeBrief.proto</summary>
  public static partial class ChallengeBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for ChallengeBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDaGFsbGVuZ2VCcmllZi5wcm90byJpCg5DaGFsbGVuZ2VCcmllZhIUCgxj",
            "dXJfcHJvZ3Jlc3MYCSABKA0SFwoPY2hhbGxlbmdlX2luZGV4GAogASgNEhIK",
            "CmlzX3N1Y2Nlc3MYBCABKAgSFAoMY2hhbGxlbmdlX2lkGAggASgNQgyqAglP",
            "bGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ChallengeBrief), global::OldProtos.ChallengeBrief.Parser, new[]{ "CurProgress", "ChallengeIndex", "IsSuccess", "ChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChallengeBrief : pb::IMessage<ChallengeBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChallengeBrief> _parser = new pb::MessageParser<ChallengeBrief>(() => new ChallengeBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChallengeBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ChallengeBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeBrief(ChallengeBrief other) : this() {
      curProgress_ = other.curProgress_;
      challengeIndex_ = other.challengeIndex_;
      isSuccess_ = other.isSuccess_;
      challengeId_ = other.challengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeBrief Clone() {
      return new ChallengeBrief(this);
    }

    /// <summary>Field number for the "cur_progress" field.</summary>
    public const int CurProgressFieldNumber = 9;
    private uint curProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurProgress {
      get { return curProgress_; }
      set {
        curProgress_ = value;
      }
    }

    /// <summary>Field number for the "challenge_index" field.</summary>
    public const int ChallengeIndexFieldNumber = 10;
    private uint challengeIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeIndex {
      get { return challengeIndex_; }
      set {
        challengeIndex_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 4;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 8;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChallengeBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChallengeBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurProgress != other.CurProgress) return false;
      if (ChallengeIndex != other.ChallengeIndex) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (ChallengeId != other.ChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurProgress != 0) hash ^= CurProgress.GetHashCode();
      if (ChallengeIndex != 0) hash ^= ChallengeIndex.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
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
      if (IsSuccess != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsSuccess);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ChallengeId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurProgress);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeIndex);
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
      if (IsSuccess != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsSuccess);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ChallengeId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurProgress);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeIndex);
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
      if (CurProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurProgress);
      }
      if (ChallengeIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeIndex);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChallengeBrief other) {
      if (other == null) {
        return;
      }
      if (other.CurProgress != 0) {
        CurProgress = other.CurProgress;
      }
      if (other.ChallengeIndex != 0) {
        ChallengeIndex = other.ChallengeIndex;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
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
          case 32: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 72: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 80: {
            ChallengeIndex = input.ReadUInt32();
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
          case 32: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 72: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 80: {
            ChallengeIndex = input.ReadUInt32();
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
