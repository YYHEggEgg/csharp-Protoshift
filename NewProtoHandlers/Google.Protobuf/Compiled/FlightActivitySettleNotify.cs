// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FlightActivitySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from FlightActivitySettleNotify.proto</summary>
public static partial class FlightActivitySettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for FlightActivitySettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FlightActivitySettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBGbGlnaHRBY3Rpdml0eVNldHRsZU5vdGlmeS5wcm90byLIAQoaRmxpZ2h0",
          "QWN0aXZpdHlTZXR0bGVOb3RpZnkSEQoJbGVmdF90aW1lGAogASgNEhEKCXRv",
          "dGFsX251bRgGIAEoDRIQCghncm91cF9pZBgNIAEoDRINCgVzY29yZRgPIAEo",
          "DRIbChNVbmszMzAwX01FRUtGSkpJT0tFGAkgASgNEhUKDWlzX25ld19yZWNv",
          "cmQYBCABKAgSEgoKaXNfc3VjY2VzcxgBIAEoCBIbChNVbmszMzAwX1BMRk1K",
          "UE5QUExJGAsgASgNQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FlightActivitySettleNotify), global::FlightActivitySettleNotify.Parser, new[]{ "LeftTime", "TotalNum", "GroupId", "Score", "Unk3300MEEKFJJIOKE", "IsNewRecord", "IsSuccess", "Unk3300PLFMJPNPPLI" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 2143;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class FlightActivitySettleNotify : pb::IMessage<FlightActivitySettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<FlightActivitySettleNotify> _parser = new pb::MessageParser<FlightActivitySettleNotify>(() => new FlightActivitySettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<FlightActivitySettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FlightActivitySettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FlightActivitySettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FlightActivitySettleNotify(FlightActivitySettleNotify other) : this() {
    leftTime_ = other.leftTime_;
    totalNum_ = other.totalNum_;
    groupId_ = other.groupId_;
    score_ = other.score_;
    unk3300MEEKFJJIOKE_ = other.unk3300MEEKFJJIOKE_;
    isNewRecord_ = other.isNewRecord_;
    isSuccess_ = other.isSuccess_;
    unk3300PLFMJPNPPLI_ = other.unk3300PLFMJPNPPLI_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FlightActivitySettleNotify Clone() {
    return new FlightActivitySettleNotify(this);
  }

  /// <summary>Field number for the "left_time" field.</summary>
  public const int LeftTimeFieldNumber = 10;
  private uint leftTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LeftTime {
    get { return leftTime_; }
    set {
      leftTime_ = value;
    }
  }

  /// <summary>Field number for the "total_num" field.</summary>
  public const int TotalNumFieldNumber = 6;
  private uint totalNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalNum {
    get { return totalNum_; }
    set {
      totalNum_ = value;
    }
  }

  /// <summary>Field number for the "group_id" field.</summary>
  public const int GroupIdFieldNumber = 13;
  private uint groupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GroupId {
    get { return groupId_; }
    set {
      groupId_ = value;
    }
  }

  /// <summary>Field number for the "score" field.</summary>
  public const int ScoreFieldNumber = 15;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_MEEKFJJIOKE" field.</summary>
  public const int Unk3300MEEKFJJIOKEFieldNumber = 9;
  private uint unk3300MEEKFJJIOKE_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300MEEKFJJIOKE {
    get { return unk3300MEEKFJJIOKE_; }
    set {
      unk3300MEEKFJJIOKE_ = value;
    }
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 4;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  /// <summary>Field number for the "is_success" field.</summary>
  public const int IsSuccessFieldNumber = 1;
  private bool isSuccess_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSuccess {
    get { return isSuccess_; }
    set {
      isSuccess_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_PLFMJPNPPLI" field.</summary>
  public const int Unk3300PLFMJPNPPLIFieldNumber = 11;
  private uint unk3300PLFMJPNPPLI_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300PLFMJPNPPLI {
    get { return unk3300PLFMJPNPPLI_; }
    set {
      unk3300PLFMJPNPPLI_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as FlightActivitySettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(FlightActivitySettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (LeftTime != other.LeftTime) return false;
    if (TotalNum != other.TotalNum) return false;
    if (GroupId != other.GroupId) return false;
    if (Score != other.Score) return false;
    if (Unk3300MEEKFJJIOKE != other.Unk3300MEEKFJJIOKE) return false;
    if (IsNewRecord != other.IsNewRecord) return false;
    if (IsSuccess != other.IsSuccess) return false;
    if (Unk3300PLFMJPNPPLI != other.Unk3300PLFMJPNPPLI) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (LeftTime != 0) hash ^= LeftTime.GetHashCode();
    if (TotalNum != 0) hash ^= TotalNum.GetHashCode();
    if (GroupId != 0) hash ^= GroupId.GetHashCode();
    if (Score != 0) hash ^= Score.GetHashCode();
    if (Unk3300MEEKFJJIOKE != 0) hash ^= Unk3300MEEKFJJIOKE.GetHashCode();
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
    if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
    if (Unk3300PLFMJPNPPLI != 0) hash ^= Unk3300PLFMJPNPPLI.GetHashCode();
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
      output.WriteRawTag(8);
      output.WriteBool(IsSuccess);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsNewRecord);
    }
    if (TotalNum != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(TotalNum);
    }
    if (Unk3300MEEKFJJIOKE != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Unk3300MEEKFJJIOKE);
    }
    if (LeftTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(LeftTime);
    }
    if (Unk3300PLFMJPNPPLI != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Unk3300PLFMJPNPPLI);
    }
    if (GroupId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GroupId);
    }
    if (Score != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Score);
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
      output.WriteRawTag(8);
      output.WriteBool(IsSuccess);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsNewRecord);
    }
    if (TotalNum != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(TotalNum);
    }
    if (Unk3300MEEKFJJIOKE != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Unk3300MEEKFJJIOKE);
    }
    if (LeftTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(LeftTime);
    }
    if (Unk3300PLFMJPNPPLI != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Unk3300PLFMJPNPPLI);
    }
    if (GroupId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GroupId);
    }
    if (Score != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Score);
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
    if (LeftTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftTime);
    }
    if (TotalNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalNum);
    }
    if (GroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
    }
    if (Score != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
    }
    if (Unk3300MEEKFJJIOKE != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MEEKFJJIOKE);
    }
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (IsSuccess != false) {
      size += 1 + 1;
    }
    if (Unk3300PLFMJPNPPLI != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PLFMJPNPPLI);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(FlightActivitySettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.LeftTime != 0) {
      LeftTime = other.LeftTime;
    }
    if (other.TotalNum != 0) {
      TotalNum = other.TotalNum;
    }
    if (other.GroupId != 0) {
      GroupId = other.GroupId;
    }
    if (other.Score != 0) {
      Score = other.Score;
    }
    if (other.Unk3300MEEKFJJIOKE != 0) {
      Unk3300MEEKFJJIOKE = other.Unk3300MEEKFJJIOKE;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
    }
    if (other.IsSuccess != false) {
      IsSuccess = other.IsSuccess;
    }
    if (other.Unk3300PLFMJPNPPLI != 0) {
      Unk3300PLFMJPNPPLI = other.Unk3300PLFMJPNPPLI;
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
          IsSuccess = input.ReadBool();
          break;
        }
        case 32: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 48: {
          TotalNum = input.ReadUInt32();
          break;
        }
        case 72: {
          Unk3300MEEKFJJIOKE = input.ReadUInt32();
          break;
        }
        case 80: {
          LeftTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300PLFMJPNPPLI = input.ReadUInt32();
          break;
        }
        case 104: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 120: {
          Score = input.ReadUInt32();
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
          IsSuccess = input.ReadBool();
          break;
        }
        case 32: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 48: {
          TotalNum = input.ReadUInt32();
          break;
        }
        case 72: {
          Unk3300MEEKFJJIOKE = input.ReadUInt32();
          break;
        }
        case 80: {
          LeftTime = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300PLFMJPNPPLI = input.ReadUInt32();
          break;
        }
        case 104: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 120: {
          Score = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
