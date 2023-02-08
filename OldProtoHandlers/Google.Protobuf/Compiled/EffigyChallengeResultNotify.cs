// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyChallengeResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from EffigyChallengeResultNotify.proto</summary>
  public static partial class EffigyChallengeResultNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyChallengeResultNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyChallengeResultNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFZmZpZ3lDaGFsbGVuZ2VSZXN1bHROb3RpZnkucHJvdG8ifQobRWZmaWd5",
            "Q2hhbGxlbmdlUmVzdWx0Tm90aWZ5EhIKCmlzX3N1Y2Nlc3MYBSABKAgSGwoT",
            "Y2hhbGxlbmdlX21heF9zY29yZRgMIAEoDRIXCg9jaGFsbGVuZ2Vfc2NvcmUY",
            "AyABKA0SFAoMY2hhbGxlbmdlX2lkGAcgASgNQgyqAglPbGRQcm90b3NiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.EffigyChallengeResultNotify), global::OldProtos.EffigyChallengeResultNotify.Parser, new[]{ "IsSuccess", "ChallengeMaxScore", "ChallengeScore", "ChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2046
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class EffigyChallengeResultNotify : pb::IMessage<EffigyChallengeResultNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyChallengeResultNotify> _parser = new pb::MessageParser<EffigyChallengeResultNotify>(() => new EffigyChallengeResultNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyChallengeResultNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.EffigyChallengeResultNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeResultNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeResultNotify(EffigyChallengeResultNotify other) : this() {
      isSuccess_ = other.isSuccess_;
      challengeMaxScore_ = other.challengeMaxScore_;
      challengeScore_ = other.challengeScore_;
      challengeId_ = other.challengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeResultNotify Clone() {
      return new EffigyChallengeResultNotify(this);
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 5;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "challenge_max_score" field.</summary>
    public const int ChallengeMaxScoreFieldNumber = 12;
    private uint challengeMaxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeMaxScore {
      get { return challengeMaxScore_; }
      set {
        challengeMaxScore_ = value;
      }
    }

    /// <summary>Field number for the "challenge_score" field.</summary>
    public const int ChallengeScoreFieldNumber = 3;
    private uint challengeScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeScore {
      get { return challengeScore_; }
      set {
        challengeScore_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 7;
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
      return Equals(other as EffigyChallengeResultNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyChallengeResultNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (ChallengeMaxScore != other.ChallengeMaxScore) return false;
      if (ChallengeScore != other.ChallengeScore) return false;
      if (ChallengeId != other.ChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (ChallengeMaxScore != 0) hash ^= ChallengeMaxScore.GetHashCode();
      if (ChallengeScore != 0) hash ^= ChallengeScore.GetHashCode();
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
      if (ChallengeScore != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeScore);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSuccess);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeId);
      }
      if (ChallengeMaxScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeMaxScore);
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
      if (ChallengeScore != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeScore);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSuccess);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeId);
      }
      if (ChallengeMaxScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeMaxScore);
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
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (ChallengeMaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeMaxScore);
      }
      if (ChallengeScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeScore);
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
    public void MergeFrom(EffigyChallengeResultNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.ChallengeMaxScore != 0) {
        ChallengeMaxScore = other.ChallengeMaxScore;
      }
      if (other.ChallengeScore != 0) {
        ChallengeScore = other.ChallengeScore;
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
          case 24: {
            ChallengeScore = input.ReadUInt32();
            break;
          }
          case 40: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 56: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeMaxScore = input.ReadUInt32();
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
          case 24: {
            ChallengeScore = input.ReadUInt32();
            break;
          }
          case 40: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 56: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeMaxScore = input.ReadUInt32();
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
