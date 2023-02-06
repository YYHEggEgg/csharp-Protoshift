// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CityReputationInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CityReputationInfo.proto</summary>
public static partial class CityReputationInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for CityReputationInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CityReputationInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhDaXR5UmVwdXRhdGlvbkluZm8ucHJvdG8aH0NpdHlSZXB1dGF0aW9uRXhw",
          "bG9yZUluZm8ucHJvdG8aHENpdHlSZXB1dGF0aW9uSHVudEluZm8ucHJvdG8a",
          "HUNpdHlSZXB1dGF0aW9uUXVlc3RJbmZvLnByb3RvGh9DaXR5UmVwdXRhdGlv",
          "blJlcXVlc3RJbmZvLnByb3RvIswCChJDaXR5UmVwdXRhdGlvbkluZm8SCwoD",
          "ZXhwGAggASgNEiwKCnF1ZXN0X2luZm8YCSABKAsyGC5DaXR5UmVwdXRhdGlv",
          "blF1ZXN0SW5mbxIfChd0YWtlbl9sZXZlbF9yZXdhcmRfbGlzdBgKIAMoDRIw",
          "CgxyZXF1ZXN0X2luZm8YBSABKAsyGi5DaXR5UmVwdXRhdGlvblJlcXVlc3RJ",
          "bmZvEhkKEW5leHRfcmVmcmVzaF90aW1lGAsgASgNEiAKGHRvdGFsX2FjY2Vw",
          "dF9yZXF1ZXN0X251bRgMIAEoDRIqCglodW50X2luZm8YDyABKAsyFy5DaXR5",
          "UmVwdXRhdGlvbkh1bnRJbmZvEjAKDGV4cGxvcmVfaW5mbxgDIAEoCzIaLkNp",
          "dHlSZXB1dGF0aW9uRXhwbG9yZUluZm8SDQoFbGV2ZWwYAiABKA1CFgoUb3Jn",
          "LnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CityReputationExploreInfoReflection.Descriptor, global::CityReputationHuntInfoReflection.Descriptor, global::CityReputationQuestInfoReflection.Descriptor, global::CityReputationRequestInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CityReputationInfo), global::CityReputationInfo.Parser, new[]{ "Exp", "QuestInfo", "TakenLevelRewardList", "RequestInfo", "NextRefreshTime", "TotalAcceptRequestNum", "HuntInfo", "ExploreInfo", "Level" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CityReputationInfo : pb::IMessage<CityReputationInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CityReputationInfo> _parser = new pb::MessageParser<CityReputationInfo>(() => new CityReputationInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CityReputationInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CityReputationInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CityReputationInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CityReputationInfo(CityReputationInfo other) : this() {
    exp_ = other.exp_;
    questInfo_ = other.questInfo_ != null ? other.questInfo_.Clone() : null;
    takenLevelRewardList_ = other.takenLevelRewardList_.Clone();
    requestInfo_ = other.requestInfo_ != null ? other.requestInfo_.Clone() : null;
    nextRefreshTime_ = other.nextRefreshTime_;
    totalAcceptRequestNum_ = other.totalAcceptRequestNum_;
    huntInfo_ = other.huntInfo_ != null ? other.huntInfo_.Clone() : null;
    exploreInfo_ = other.exploreInfo_ != null ? other.exploreInfo_.Clone() : null;
    level_ = other.level_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CityReputationInfo Clone() {
    return new CityReputationInfo(this);
  }

  /// <summary>Field number for the "exp" field.</summary>
  public const int ExpFieldNumber = 8;
  private uint exp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Exp {
    get { return exp_; }
    set {
      exp_ = value;
    }
  }

  /// <summary>Field number for the "quest_info" field.</summary>
  public const int QuestInfoFieldNumber = 9;
  private global::CityReputationQuestInfo questInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CityReputationQuestInfo QuestInfo {
    get { return questInfo_; }
    set {
      questInfo_ = value;
    }
  }

  /// <summary>Field number for the "taken_level_reward_list" field.</summary>
  public const int TakenLevelRewardListFieldNumber = 10;
  private static readonly pb::FieldCodec<uint> _repeated_takenLevelRewardList_codec
      = pb::FieldCodec.ForUInt32(82);
  private readonly pbc::RepeatedField<uint> takenLevelRewardList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> TakenLevelRewardList {
    get { return takenLevelRewardList_; }
  }

  /// <summary>Field number for the "request_info" field.</summary>
  public const int RequestInfoFieldNumber = 5;
  private global::CityReputationRequestInfo requestInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CityReputationRequestInfo RequestInfo {
    get { return requestInfo_; }
    set {
      requestInfo_ = value;
    }
  }

  /// <summary>Field number for the "next_refresh_time" field.</summary>
  public const int NextRefreshTimeFieldNumber = 11;
  private uint nextRefreshTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint NextRefreshTime {
    get { return nextRefreshTime_; }
    set {
      nextRefreshTime_ = value;
    }
  }

  /// <summary>Field number for the "total_accept_request_num" field.</summary>
  public const int TotalAcceptRequestNumFieldNumber = 12;
  private uint totalAcceptRequestNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalAcceptRequestNum {
    get { return totalAcceptRequestNum_; }
    set {
      totalAcceptRequestNum_ = value;
    }
  }

  /// <summary>Field number for the "hunt_info" field.</summary>
  public const int HuntInfoFieldNumber = 15;
  private global::CityReputationHuntInfo huntInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CityReputationHuntInfo HuntInfo {
    get { return huntInfo_; }
    set {
      huntInfo_ = value;
    }
  }

  /// <summary>Field number for the "explore_info" field.</summary>
  public const int ExploreInfoFieldNumber = 3;
  private global::CityReputationExploreInfo exploreInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CityReputationExploreInfo ExploreInfo {
    get { return exploreInfo_; }
    set {
      exploreInfo_ = value;
    }
  }

  /// <summary>Field number for the "level" field.</summary>
  public const int LevelFieldNumber = 2;
  private uint level_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Level {
    get { return level_; }
    set {
      level_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CityReputationInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CityReputationInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Exp != other.Exp) return false;
    if (!object.Equals(QuestInfo, other.QuestInfo)) return false;
    if(!takenLevelRewardList_.Equals(other.takenLevelRewardList_)) return false;
    if (!object.Equals(RequestInfo, other.RequestInfo)) return false;
    if (NextRefreshTime != other.NextRefreshTime) return false;
    if (TotalAcceptRequestNum != other.TotalAcceptRequestNum) return false;
    if (!object.Equals(HuntInfo, other.HuntInfo)) return false;
    if (!object.Equals(ExploreInfo, other.ExploreInfo)) return false;
    if (Level != other.Level) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Exp != 0) hash ^= Exp.GetHashCode();
    if (questInfo_ != null) hash ^= QuestInfo.GetHashCode();
    hash ^= takenLevelRewardList_.GetHashCode();
    if (requestInfo_ != null) hash ^= RequestInfo.GetHashCode();
    if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
    if (TotalAcceptRequestNum != 0) hash ^= TotalAcceptRequestNum.GetHashCode();
    if (huntInfo_ != null) hash ^= HuntInfo.GetHashCode();
    if (exploreInfo_ != null) hash ^= ExploreInfo.GetHashCode();
    if (Level != 0) hash ^= Level.GetHashCode();
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
    if (Level != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Level);
    }
    if (exploreInfo_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(ExploreInfo);
    }
    if (requestInfo_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(RequestInfo);
    }
    if (Exp != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Exp);
    }
    if (questInfo_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(QuestInfo);
    }
    takenLevelRewardList_.WriteTo(output, _repeated_takenLevelRewardList_codec);
    if (NextRefreshTime != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(NextRefreshTime);
    }
    if (TotalAcceptRequestNum != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(TotalAcceptRequestNum);
    }
    if (huntInfo_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(HuntInfo);
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
    if (Level != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Level);
    }
    if (exploreInfo_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(ExploreInfo);
    }
    if (requestInfo_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(RequestInfo);
    }
    if (Exp != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Exp);
    }
    if (questInfo_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(QuestInfo);
    }
    takenLevelRewardList_.WriteTo(ref output, _repeated_takenLevelRewardList_codec);
    if (NextRefreshTime != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(NextRefreshTime);
    }
    if (TotalAcceptRequestNum != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(TotalAcceptRequestNum);
    }
    if (huntInfo_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(HuntInfo);
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
    if (Exp != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
    }
    if (questInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(QuestInfo);
    }
    size += takenLevelRewardList_.CalculateSize(_repeated_takenLevelRewardList_codec);
    if (requestInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RequestInfo);
    }
    if (NextRefreshTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
    }
    if (TotalAcceptRequestNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalAcceptRequestNum);
    }
    if (huntInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HuntInfo);
    }
    if (exploreInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExploreInfo);
    }
    if (Level != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CityReputationInfo other) {
    if (other == null) {
      return;
    }
    if (other.Exp != 0) {
      Exp = other.Exp;
    }
    if (other.questInfo_ != null) {
      if (questInfo_ == null) {
        QuestInfo = new global::CityReputationQuestInfo();
      }
      QuestInfo.MergeFrom(other.QuestInfo);
    }
    takenLevelRewardList_.Add(other.takenLevelRewardList_);
    if (other.requestInfo_ != null) {
      if (requestInfo_ == null) {
        RequestInfo = new global::CityReputationRequestInfo();
      }
      RequestInfo.MergeFrom(other.RequestInfo);
    }
    if (other.NextRefreshTime != 0) {
      NextRefreshTime = other.NextRefreshTime;
    }
    if (other.TotalAcceptRequestNum != 0) {
      TotalAcceptRequestNum = other.TotalAcceptRequestNum;
    }
    if (other.huntInfo_ != null) {
      if (huntInfo_ == null) {
        HuntInfo = new global::CityReputationHuntInfo();
      }
      HuntInfo.MergeFrom(other.HuntInfo);
    }
    if (other.exploreInfo_ != null) {
      if (exploreInfo_ == null) {
        ExploreInfo = new global::CityReputationExploreInfo();
      }
      ExploreInfo.MergeFrom(other.ExploreInfo);
    }
    if (other.Level != 0) {
      Level = other.Level;
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
          Level = input.ReadUInt32();
          break;
        }
        case 26: {
          if (exploreInfo_ == null) {
            ExploreInfo = new global::CityReputationExploreInfo();
          }
          input.ReadMessage(ExploreInfo);
          break;
        }
        case 42: {
          if (requestInfo_ == null) {
            RequestInfo = new global::CityReputationRequestInfo();
          }
          input.ReadMessage(RequestInfo);
          break;
        }
        case 64: {
          Exp = input.ReadUInt32();
          break;
        }
        case 74: {
          if (questInfo_ == null) {
            QuestInfo = new global::CityReputationQuestInfo();
          }
          input.ReadMessage(QuestInfo);
          break;
        }
        case 82:
        case 80: {
          takenLevelRewardList_.AddEntriesFrom(input, _repeated_takenLevelRewardList_codec);
          break;
        }
        case 88: {
          NextRefreshTime = input.ReadUInt32();
          break;
        }
        case 96: {
          TotalAcceptRequestNum = input.ReadUInt32();
          break;
        }
        case 122: {
          if (huntInfo_ == null) {
            HuntInfo = new global::CityReputationHuntInfo();
          }
          input.ReadMessage(HuntInfo);
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
          Level = input.ReadUInt32();
          break;
        }
        case 26: {
          if (exploreInfo_ == null) {
            ExploreInfo = new global::CityReputationExploreInfo();
          }
          input.ReadMessage(ExploreInfo);
          break;
        }
        case 42: {
          if (requestInfo_ == null) {
            RequestInfo = new global::CityReputationRequestInfo();
          }
          input.ReadMessage(RequestInfo);
          break;
        }
        case 64: {
          Exp = input.ReadUInt32();
          break;
        }
        case 74: {
          if (questInfo_ == null) {
            QuestInfo = new global::CityReputationQuestInfo();
          }
          input.ReadMessage(QuestInfo);
          break;
        }
        case 82:
        case 80: {
          takenLevelRewardList_.AddEntriesFrom(ref input, _repeated_takenLevelRewardList_codec);
          break;
        }
        case 88: {
          NextRefreshTime = input.ReadUInt32();
          break;
        }
        case 96: {
          TotalAcceptRequestNum = input.ReadUInt32();
          break;
        }
        case 122: {
          if (huntInfo_ == null) {
            HuntInfo = new global::CityReputationHuntInfo();
          }
          input.ReadMessage(HuntInfo);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
