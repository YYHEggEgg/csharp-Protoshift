// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MistTrialGetChallengeMissionRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MistTrialGetChallengeMissionRsp.proto</summary>
public static partial class MistTrialGetChallengeMissionRspReflection {

  #region Descriptor
  /// <summary>File descriptor for MistTrialGetChallengeMissionRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MistTrialGetChallengeMissionRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVNaXN0VHJpYWxHZXRDaGFsbGVuZ2VNaXNzaW9uUnNwLnByb3RvGhpNaXN0",
          "VHJpYWxNaXNzaW9uSW5mby5wcm90byJ2Ch9NaXN0VHJpYWxHZXRDaGFsbGVu",
          "Z2VNaXNzaW9uUnNwEhAKCHRyaWFsX2lkGAYgASgNEjAKEW1pc3Npb25faW5m",
          "b19saXN0GAMgAygLMhUuTWlzdFRyaWFsTWlzc2lvbkluZm8SDwoHcmV0Y29k",
          "ZRgHIAEoBUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MistTrialMissionInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MistTrialGetChallengeMissionRsp), global::MistTrialGetChallengeMissionRsp.Parser, new[]{ "TrialId", "MissionInfoList", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 8193;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class MistTrialGetChallengeMissionRsp : pb::IMessage<MistTrialGetChallengeMissionRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MistTrialGetChallengeMissionRsp> _parser = new pb::MessageParser<MistTrialGetChallengeMissionRsp>(() => new MistTrialGetChallengeMissionRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MistTrialGetChallengeMissionRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MistTrialGetChallengeMissionRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MistTrialGetChallengeMissionRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MistTrialGetChallengeMissionRsp(MistTrialGetChallengeMissionRsp other) : this() {
    trialId_ = other.trialId_;
    missionInfoList_ = other.missionInfoList_.Clone();
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MistTrialGetChallengeMissionRsp Clone() {
    return new MistTrialGetChallengeMissionRsp(this);
  }

  /// <summary>Field number for the "trial_id" field.</summary>
  public const int TrialIdFieldNumber = 6;
  private uint trialId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TrialId {
    get { return trialId_; }
    set {
      trialId_ = value;
    }
  }

  /// <summary>Field number for the "mission_info_list" field.</summary>
  public const int MissionInfoListFieldNumber = 3;
  private static readonly pb::FieldCodec<global::MistTrialMissionInfo> _repeated_missionInfoList_codec
      = pb::FieldCodec.ForMessage(26, global::MistTrialMissionInfo.Parser);
  private readonly pbc::RepeatedField<global::MistTrialMissionInfo> missionInfoList_ = new pbc::RepeatedField<global::MistTrialMissionInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::MistTrialMissionInfo> MissionInfoList {
    get { return missionInfoList_; }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 7;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MistTrialGetChallengeMissionRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MistTrialGetChallengeMissionRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (TrialId != other.TrialId) return false;
    if(!missionInfoList_.Equals(other.missionInfoList_)) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (TrialId != 0) hash ^= TrialId.GetHashCode();
    hash ^= missionInfoList_.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    missionInfoList_.WriteTo(output, _repeated_missionInfoList_codec);
    if (TrialId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(TrialId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(56);
      output.WriteInt32(Retcode);
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
    missionInfoList_.WriteTo(ref output, _repeated_missionInfoList_codec);
    if (TrialId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(TrialId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(56);
      output.WriteInt32(Retcode);
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
    if (TrialId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialId);
    }
    size += missionInfoList_.CalculateSize(_repeated_missionInfoList_codec);
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MistTrialGetChallengeMissionRsp other) {
    if (other == null) {
      return;
    }
    if (other.TrialId != 0) {
      TrialId = other.TrialId;
    }
    missionInfoList_.Add(other.missionInfoList_);
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
          missionInfoList_.AddEntriesFrom(input, _repeated_missionInfoList_codec);
          break;
        }
        case 48: {
          TrialId = input.ReadUInt32();
          break;
        }
        case 56: {
          Retcode = input.ReadInt32();
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
          missionInfoList_.AddEntriesFrom(ref input, _repeated_missionInfoList_codec);
          break;
        }
        case 48: {
          TrialId = input.ReadUInt32();
          break;
        }
        case 56: {
          Retcode = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code