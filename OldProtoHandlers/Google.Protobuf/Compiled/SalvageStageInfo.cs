// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SalvageStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SalvageStageInfo.proto</summary>
public static partial class SalvageStageInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SalvageStageInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SalvageStageInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZTYWx2YWdlU3RhZ2VJbmZvLnByb3RvGhpTYWx2YWdlQ2hhbGxlbmdlSW5m",
          "by5wcm90byJpChBTYWx2YWdlU3RhZ2VJbmZvEjIKE2NoYWxsZW5nZV9pbmZv",
          "X2xpc3QYCSADKAsyFS5TYWx2YWdlQ2hhbGxlbmdlSW5mbxIPCgdpc19vcGVu",
          "GAogASgIEhAKCHN0YWdlX2lkGAIgASgNQh4KHGVtdS5ncmFzc2N1dHRlci5u",
          "ZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SalvageChallengeInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SalvageStageInfo), global::SalvageStageInfo.Parser, new[]{ "ChallengeInfoList", "IsOpen", "StageId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SalvageStageInfo : pb::IMessage<SalvageStageInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SalvageStageInfo> _parser = new pb::MessageParser<SalvageStageInfo>(() => new SalvageStageInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SalvageStageInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SalvageStageInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvageStageInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvageStageInfo(SalvageStageInfo other) : this() {
    challengeInfoList_ = other.challengeInfoList_.Clone();
    isOpen_ = other.isOpen_;
    stageId_ = other.stageId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvageStageInfo Clone() {
    return new SalvageStageInfo(this);
  }

  /// <summary>Field number for the "challenge_info_list" field.</summary>
  public const int ChallengeInfoListFieldNumber = 9;
  private static readonly pb::FieldCodec<global::SalvageChallengeInfo> _repeated_challengeInfoList_codec
      = pb::FieldCodec.ForMessage(74, global::SalvageChallengeInfo.Parser);
  private readonly pbc::RepeatedField<global::SalvageChallengeInfo> challengeInfoList_ = new pbc::RepeatedField<global::SalvageChallengeInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::SalvageChallengeInfo> ChallengeInfoList {
    get { return challengeInfoList_; }
  }

  /// <summary>Field number for the "is_open" field.</summary>
  public const int IsOpenFieldNumber = 10;
  private bool isOpen_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsOpen {
    get { return isOpen_; }
    set {
      isOpen_ = value;
    }
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 2;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SalvageStageInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SalvageStageInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!challengeInfoList_.Equals(other.challengeInfoList_)) return false;
    if (IsOpen != other.IsOpen) return false;
    if (StageId != other.StageId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= challengeInfoList_.GetHashCode();
    if (IsOpen != false) hash ^= IsOpen.GetHashCode();
    if (StageId != 0) hash ^= StageId.GetHashCode();
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
    if (StageId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(StageId);
    }
    challengeInfoList_.WriteTo(output, _repeated_challengeInfoList_codec);
    if (IsOpen != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsOpen);
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
    if (StageId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(StageId);
    }
    challengeInfoList_.WriteTo(ref output, _repeated_challengeInfoList_codec);
    if (IsOpen != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsOpen);
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
    size += challengeInfoList_.CalculateSize(_repeated_challengeInfoList_codec);
    if (IsOpen != false) {
      size += 1 + 1;
    }
    if (StageId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SalvageStageInfo other) {
    if (other == null) {
      return;
    }
    challengeInfoList_.Add(other.challengeInfoList_);
    if (other.IsOpen != false) {
      IsOpen = other.IsOpen;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
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
        case 16: {
          StageId = input.ReadUInt32();
          break;
        }
        case 74: {
          challengeInfoList_.AddEntriesFrom(input, _repeated_challengeInfoList_codec);
          break;
        }
        case 80: {
          IsOpen = input.ReadBool();
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
        case 16: {
          StageId = input.ReadUInt32();
          break;
        }
        case 74: {
          challengeInfoList_.AddEntriesFrom(ref input, _repeated_challengeInfoList_codec);
          break;
        }
        case 80: {
          IsOpen = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
