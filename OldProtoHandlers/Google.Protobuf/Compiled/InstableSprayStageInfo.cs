// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InstableSprayStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from InstableSprayStageInfo.proto</summary>
public static partial class InstableSprayStageInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for InstableSprayStageInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InstableSprayStageInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxJbnN0YWJsZVNwcmF5U3RhZ2VJbmZvLnByb3RvGhtJbnN0YWJsZVNwcmF5",
          "VGVhbUluZm8ucHJvdG8iggEKFkluc3RhYmxlU3ByYXlTdGFnZUluZm8SEwoL",
          "aXNfZmluaXNoZWQYCiABKAgSEQoJbWF4X3Njb3JlGAMgASgNEhAKCHN0YWdl",
          "X2lkGAQgASgNEi4KDnRlYW1faW5mb19saXN0GAYgAygLMhYuSW5zdGFibGVT",
          "cHJheVRlYW1JbmZvQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9i",
          "BnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::InstableSprayTeamInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InstableSprayStageInfo), global::InstableSprayStageInfo.Parser, new[]{ "IsFinished", "MaxScore", "StageId", "TeamInfoList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class InstableSprayStageInfo : pb::IMessage<InstableSprayStageInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InstableSprayStageInfo> _parser = new pb::MessageParser<InstableSprayStageInfo>(() => new InstableSprayStageInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InstableSprayStageInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InstableSprayStageInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InstableSprayStageInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InstableSprayStageInfo(InstableSprayStageInfo other) : this() {
    isFinished_ = other.isFinished_;
    maxScore_ = other.maxScore_;
    stageId_ = other.stageId_;
    teamInfoList_ = other.teamInfoList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InstableSprayStageInfo Clone() {
    return new InstableSprayStageInfo(this);
  }

  /// <summary>Field number for the "is_finished" field.</summary>
  public const int IsFinishedFieldNumber = 10;
  private bool isFinished_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFinished {
    get { return isFinished_; }
    set {
      isFinished_ = value;
    }
  }

  /// <summary>Field number for the "max_score" field.</summary>
  public const int MaxScoreFieldNumber = 3;
  private uint maxScore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MaxScore {
    get { return maxScore_; }
    set {
      maxScore_ = value;
    }
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 4;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "team_info_list" field.</summary>
  public const int TeamInfoListFieldNumber = 6;
  private static readonly pb::FieldCodec<global::InstableSprayTeamInfo> _repeated_teamInfoList_codec
      = pb::FieldCodec.ForMessage(50, global::InstableSprayTeamInfo.Parser);
  private readonly pbc::RepeatedField<global::InstableSprayTeamInfo> teamInfoList_ = new pbc::RepeatedField<global::InstableSprayTeamInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::InstableSprayTeamInfo> TeamInfoList {
    get { return teamInfoList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InstableSprayStageInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InstableSprayStageInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsFinished != other.IsFinished) return false;
    if (MaxScore != other.MaxScore) return false;
    if (StageId != other.StageId) return false;
    if(!teamInfoList_.Equals(other.teamInfoList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsFinished != false) hash ^= IsFinished.GetHashCode();
    if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
    if (StageId != 0) hash ^= StageId.GetHashCode();
    hash ^= teamInfoList_.GetHashCode();
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
    if (MaxScore != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(MaxScore);
    }
    if (StageId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StageId);
    }
    teamInfoList_.WriteTo(output, _repeated_teamInfoList_codec);
    if (IsFinished != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsFinished);
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
    if (MaxScore != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(MaxScore);
    }
    if (StageId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StageId);
    }
    teamInfoList_.WriteTo(ref output, _repeated_teamInfoList_codec);
    if (IsFinished != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsFinished);
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
    if (IsFinished != false) {
      size += 1 + 1;
    }
    if (MaxScore != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
    }
    if (StageId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
    }
    size += teamInfoList_.CalculateSize(_repeated_teamInfoList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InstableSprayStageInfo other) {
    if (other == null) {
      return;
    }
    if (other.IsFinished != false) {
      IsFinished = other.IsFinished;
    }
    if (other.MaxScore != 0) {
      MaxScore = other.MaxScore;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    teamInfoList_.Add(other.teamInfoList_);
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
          MaxScore = input.ReadUInt32();
          break;
        }
        case 32: {
          StageId = input.ReadUInt32();
          break;
        }
        case 50: {
          teamInfoList_.AddEntriesFrom(input, _repeated_teamInfoList_codec);
          break;
        }
        case 80: {
          IsFinished = input.ReadBool();
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
          MaxScore = input.ReadUInt32();
          break;
        }
        case 32: {
          StageId = input.ReadUInt32();
          break;
        }
        case 50: {
          teamInfoList_.AddEntriesFrom(ref input, _repeated_teamInfoList_codec);
          break;
        }
        case 80: {
          IsFinished = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
