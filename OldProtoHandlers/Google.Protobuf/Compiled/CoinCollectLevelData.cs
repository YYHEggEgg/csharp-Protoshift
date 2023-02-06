// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoinCollectLevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CoinCollectLevelData.proto</summary>
public static partial class CoinCollectLevelDataReflection {

  #region Descriptor
  /// <summary>File descriptor for CoinCollectLevelData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CoinCollectLevelDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpDb2luQ29sbGVjdExldmVsRGF0YS5wcm90bxodQ29pbkNvbGxlY3RUZWFt",
          "SW5mb0RhdGEucHJvdG8iwgMKFENvaW5Db2xsZWN0TGV2ZWxEYXRhEhAKCGxl",
          "dmVsX2lkGAMgASgNEjwKGmRvdWJsZV9iZXN0X3RlYW1faW5mb19saXN0GAwg",
          "AygLMhguQ29pbkNvbGxlY3RUZWFtSW5mb0RhdGESHAoUbGFzdF9jaG9vc2Vf",
          "c2tpbGxfbm8YCSABKA0SHwoXc2luZ2xlX2Jlc3RfY29sbGVjdF9udW0YDyAB",
          "KA0SIAoYaXNfaGF2ZV93YXRjaGVkX2N1dHNjZW5lGAEgASgIEiAKGHNpbmds",
          "ZV9iZXN0X3Bhc3NfdGltZV9tcxgCIAEoDRIhChlpc19oYXZlX3BsYXlfc2lu",
          "Z2xlX2xldmVsGAsgASgIEhUKDWlzX2xldmVsX29wZW4YCCABKAgSIQoZaXNf",
          "aGF2ZV9wbGF5X2RvdWJsZV9sZXZlbBgGIAEoCBI3ChVzaW5nbGVfYmVzdF90",
          "ZWFtX2luZm8YDSABKAsyGC5Db2luQ29sbGVjdFRlYW1JbmZvRGF0YRIfChdk",
          "b3VibGVfYmVzdF9jb2xsZWN0X251bRgOIAEoDRIgChhkb3VibGVfYmVzdF9w",
          "YXNzX3RpbWVfbXMYCiABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRw",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CoinCollectTeamInfoDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CoinCollectLevelData), global::CoinCollectLevelData.Parser, new[]{ "LevelId", "DoubleBestTeamInfoList", "LastChooseSkillNo", "SingleBestCollectNum", "IsHaveWatchedCutscene", "SingleBestPassTimeMs", "IsHavePlaySingleLevel", "IsLevelOpen", "IsHavePlayDoubleLevel", "SingleBestTeamInfo", "DoubleBestCollectNum", "DoubleBestPassTimeMs" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CoinCollectLevelData : pb::IMessage<CoinCollectLevelData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CoinCollectLevelData> _parser = new pb::MessageParser<CoinCollectLevelData>(() => new CoinCollectLevelData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CoinCollectLevelData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CoinCollectLevelDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CoinCollectLevelData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CoinCollectLevelData(CoinCollectLevelData other) : this() {
    levelId_ = other.levelId_;
    doubleBestTeamInfoList_ = other.doubleBestTeamInfoList_.Clone();
    lastChooseSkillNo_ = other.lastChooseSkillNo_;
    singleBestCollectNum_ = other.singleBestCollectNum_;
    isHaveWatchedCutscene_ = other.isHaveWatchedCutscene_;
    singleBestPassTimeMs_ = other.singleBestPassTimeMs_;
    isHavePlaySingleLevel_ = other.isHavePlaySingleLevel_;
    isLevelOpen_ = other.isLevelOpen_;
    isHavePlayDoubleLevel_ = other.isHavePlayDoubleLevel_;
    singleBestTeamInfo_ = other.singleBestTeamInfo_ != null ? other.singleBestTeamInfo_.Clone() : null;
    doubleBestCollectNum_ = other.doubleBestCollectNum_;
    doubleBestPassTimeMs_ = other.doubleBestPassTimeMs_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CoinCollectLevelData Clone() {
    return new CoinCollectLevelData(this);
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 3;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "double_best_team_info_list" field.</summary>
  public const int DoubleBestTeamInfoListFieldNumber = 12;
  private static readonly pb::FieldCodec<global::CoinCollectTeamInfoData> _repeated_doubleBestTeamInfoList_codec
      = pb::FieldCodec.ForMessage(98, global::CoinCollectTeamInfoData.Parser);
  private readonly pbc::RepeatedField<global::CoinCollectTeamInfoData> doubleBestTeamInfoList_ = new pbc::RepeatedField<global::CoinCollectTeamInfoData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::CoinCollectTeamInfoData> DoubleBestTeamInfoList {
    get { return doubleBestTeamInfoList_; }
  }

  /// <summary>Field number for the "last_choose_skill_no" field.</summary>
  public const int LastChooseSkillNoFieldNumber = 9;
  private uint lastChooseSkillNo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LastChooseSkillNo {
    get { return lastChooseSkillNo_; }
    set {
      lastChooseSkillNo_ = value;
    }
  }

  /// <summary>Field number for the "single_best_collect_num" field.</summary>
  public const int SingleBestCollectNumFieldNumber = 15;
  private uint singleBestCollectNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SingleBestCollectNum {
    get { return singleBestCollectNum_; }
    set {
      singleBestCollectNum_ = value;
    }
  }

  /// <summary>Field number for the "is_have_watched_cutscene" field.</summary>
  public const int IsHaveWatchedCutsceneFieldNumber = 1;
  private bool isHaveWatchedCutscene_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsHaveWatchedCutscene {
    get { return isHaveWatchedCutscene_; }
    set {
      isHaveWatchedCutscene_ = value;
    }
  }

  /// <summary>Field number for the "single_best_pass_time_ms" field.</summary>
  public const int SingleBestPassTimeMsFieldNumber = 2;
  private uint singleBestPassTimeMs_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SingleBestPassTimeMs {
    get { return singleBestPassTimeMs_; }
    set {
      singleBestPassTimeMs_ = value;
    }
  }

  /// <summary>Field number for the "is_have_play_single_level" field.</summary>
  public const int IsHavePlaySingleLevelFieldNumber = 11;
  private bool isHavePlaySingleLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsHavePlaySingleLevel {
    get { return isHavePlaySingleLevel_; }
    set {
      isHavePlaySingleLevel_ = value;
    }
  }

  /// <summary>Field number for the "is_level_open" field.</summary>
  public const int IsLevelOpenFieldNumber = 8;
  private bool isLevelOpen_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsLevelOpen {
    get { return isLevelOpen_; }
    set {
      isLevelOpen_ = value;
    }
  }

  /// <summary>Field number for the "is_have_play_double_level" field.</summary>
  public const int IsHavePlayDoubleLevelFieldNumber = 6;
  private bool isHavePlayDoubleLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsHavePlayDoubleLevel {
    get { return isHavePlayDoubleLevel_; }
    set {
      isHavePlayDoubleLevel_ = value;
    }
  }

  /// <summary>Field number for the "single_best_team_info" field.</summary>
  public const int SingleBestTeamInfoFieldNumber = 13;
  private global::CoinCollectTeamInfoData singleBestTeamInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CoinCollectTeamInfoData SingleBestTeamInfo {
    get { return singleBestTeamInfo_; }
    set {
      singleBestTeamInfo_ = value;
    }
  }

  /// <summary>Field number for the "double_best_collect_num" field.</summary>
  public const int DoubleBestCollectNumFieldNumber = 14;
  private uint doubleBestCollectNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DoubleBestCollectNum {
    get { return doubleBestCollectNum_; }
    set {
      doubleBestCollectNum_ = value;
    }
  }

  /// <summary>Field number for the "double_best_pass_time_ms" field.</summary>
  public const int DoubleBestPassTimeMsFieldNumber = 10;
  private uint doubleBestPassTimeMs_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DoubleBestPassTimeMs {
    get { return doubleBestPassTimeMs_; }
    set {
      doubleBestPassTimeMs_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CoinCollectLevelData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CoinCollectLevelData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (LevelId != other.LevelId) return false;
    if(!doubleBestTeamInfoList_.Equals(other.doubleBestTeamInfoList_)) return false;
    if (LastChooseSkillNo != other.LastChooseSkillNo) return false;
    if (SingleBestCollectNum != other.SingleBestCollectNum) return false;
    if (IsHaveWatchedCutscene != other.IsHaveWatchedCutscene) return false;
    if (SingleBestPassTimeMs != other.SingleBestPassTimeMs) return false;
    if (IsHavePlaySingleLevel != other.IsHavePlaySingleLevel) return false;
    if (IsLevelOpen != other.IsLevelOpen) return false;
    if (IsHavePlayDoubleLevel != other.IsHavePlayDoubleLevel) return false;
    if (!object.Equals(SingleBestTeamInfo, other.SingleBestTeamInfo)) return false;
    if (DoubleBestCollectNum != other.DoubleBestCollectNum) return false;
    if (DoubleBestPassTimeMs != other.DoubleBestPassTimeMs) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    hash ^= doubleBestTeamInfoList_.GetHashCode();
    if (LastChooseSkillNo != 0) hash ^= LastChooseSkillNo.GetHashCode();
    if (SingleBestCollectNum != 0) hash ^= SingleBestCollectNum.GetHashCode();
    if (IsHaveWatchedCutscene != false) hash ^= IsHaveWatchedCutscene.GetHashCode();
    if (SingleBestPassTimeMs != 0) hash ^= SingleBestPassTimeMs.GetHashCode();
    if (IsHavePlaySingleLevel != false) hash ^= IsHavePlaySingleLevel.GetHashCode();
    if (IsLevelOpen != false) hash ^= IsLevelOpen.GetHashCode();
    if (IsHavePlayDoubleLevel != false) hash ^= IsHavePlayDoubleLevel.GetHashCode();
    if (singleBestTeamInfo_ != null) hash ^= SingleBestTeamInfo.GetHashCode();
    if (DoubleBestCollectNum != 0) hash ^= DoubleBestCollectNum.GetHashCode();
    if (DoubleBestPassTimeMs != 0) hash ^= DoubleBestPassTimeMs.GetHashCode();
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
    if (IsHaveWatchedCutscene != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsHaveWatchedCutscene);
    }
    if (SingleBestPassTimeMs != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(SingleBestPassTimeMs);
    }
    if (LevelId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(LevelId);
    }
    if (IsHavePlayDoubleLevel != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsHavePlayDoubleLevel);
    }
    if (IsLevelOpen != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsLevelOpen);
    }
    if (LastChooseSkillNo != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(LastChooseSkillNo);
    }
    if (DoubleBestPassTimeMs != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DoubleBestPassTimeMs);
    }
    if (IsHavePlaySingleLevel != false) {
      output.WriteRawTag(88);
      output.WriteBool(IsHavePlaySingleLevel);
    }
    doubleBestTeamInfoList_.WriteTo(output, _repeated_doubleBestTeamInfoList_codec);
    if (singleBestTeamInfo_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(SingleBestTeamInfo);
    }
    if (DoubleBestCollectNum != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(DoubleBestCollectNum);
    }
    if (SingleBestCollectNum != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(SingleBestCollectNum);
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
    if (IsHaveWatchedCutscene != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsHaveWatchedCutscene);
    }
    if (SingleBestPassTimeMs != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(SingleBestPassTimeMs);
    }
    if (LevelId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(LevelId);
    }
    if (IsHavePlayDoubleLevel != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsHavePlayDoubleLevel);
    }
    if (IsLevelOpen != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsLevelOpen);
    }
    if (LastChooseSkillNo != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(LastChooseSkillNo);
    }
    if (DoubleBestPassTimeMs != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DoubleBestPassTimeMs);
    }
    if (IsHavePlaySingleLevel != false) {
      output.WriteRawTag(88);
      output.WriteBool(IsHavePlaySingleLevel);
    }
    doubleBestTeamInfoList_.WriteTo(ref output, _repeated_doubleBestTeamInfoList_codec);
    if (singleBestTeamInfo_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(SingleBestTeamInfo);
    }
    if (DoubleBestCollectNum != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(DoubleBestCollectNum);
    }
    if (SingleBestCollectNum != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(SingleBestCollectNum);
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
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    size += doubleBestTeamInfoList_.CalculateSize(_repeated_doubleBestTeamInfoList_codec);
    if (LastChooseSkillNo != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastChooseSkillNo);
    }
    if (SingleBestCollectNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SingleBestCollectNum);
    }
    if (IsHaveWatchedCutscene != false) {
      size += 1 + 1;
    }
    if (SingleBestPassTimeMs != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SingleBestPassTimeMs);
    }
    if (IsHavePlaySingleLevel != false) {
      size += 1 + 1;
    }
    if (IsLevelOpen != false) {
      size += 1 + 1;
    }
    if (IsHavePlayDoubleLevel != false) {
      size += 1 + 1;
    }
    if (singleBestTeamInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SingleBestTeamInfo);
    }
    if (DoubleBestCollectNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DoubleBestCollectNum);
    }
    if (DoubleBestPassTimeMs != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DoubleBestPassTimeMs);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CoinCollectLevelData other) {
    if (other == null) {
      return;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    doubleBestTeamInfoList_.Add(other.doubleBestTeamInfoList_);
    if (other.LastChooseSkillNo != 0) {
      LastChooseSkillNo = other.LastChooseSkillNo;
    }
    if (other.SingleBestCollectNum != 0) {
      SingleBestCollectNum = other.SingleBestCollectNum;
    }
    if (other.IsHaveWatchedCutscene != false) {
      IsHaveWatchedCutscene = other.IsHaveWatchedCutscene;
    }
    if (other.SingleBestPassTimeMs != 0) {
      SingleBestPassTimeMs = other.SingleBestPassTimeMs;
    }
    if (other.IsHavePlaySingleLevel != false) {
      IsHavePlaySingleLevel = other.IsHavePlaySingleLevel;
    }
    if (other.IsLevelOpen != false) {
      IsLevelOpen = other.IsLevelOpen;
    }
    if (other.IsHavePlayDoubleLevel != false) {
      IsHavePlayDoubleLevel = other.IsHavePlayDoubleLevel;
    }
    if (other.singleBestTeamInfo_ != null) {
      if (singleBestTeamInfo_ == null) {
        SingleBestTeamInfo = new global::CoinCollectTeamInfoData();
      }
      SingleBestTeamInfo.MergeFrom(other.SingleBestTeamInfo);
    }
    if (other.DoubleBestCollectNum != 0) {
      DoubleBestCollectNum = other.DoubleBestCollectNum;
    }
    if (other.DoubleBestPassTimeMs != 0) {
      DoubleBestPassTimeMs = other.DoubleBestPassTimeMs;
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
          IsHaveWatchedCutscene = input.ReadBool();
          break;
        }
        case 16: {
          SingleBestPassTimeMs = input.ReadUInt32();
          break;
        }
        case 24: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 48: {
          IsHavePlayDoubleLevel = input.ReadBool();
          break;
        }
        case 64: {
          IsLevelOpen = input.ReadBool();
          break;
        }
        case 72: {
          LastChooseSkillNo = input.ReadUInt32();
          break;
        }
        case 80: {
          DoubleBestPassTimeMs = input.ReadUInt32();
          break;
        }
        case 88: {
          IsHavePlaySingleLevel = input.ReadBool();
          break;
        }
        case 98: {
          doubleBestTeamInfoList_.AddEntriesFrom(input, _repeated_doubleBestTeamInfoList_codec);
          break;
        }
        case 106: {
          if (singleBestTeamInfo_ == null) {
            SingleBestTeamInfo = new global::CoinCollectTeamInfoData();
          }
          input.ReadMessage(SingleBestTeamInfo);
          break;
        }
        case 112: {
          DoubleBestCollectNum = input.ReadUInt32();
          break;
        }
        case 120: {
          SingleBestCollectNum = input.ReadUInt32();
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
          IsHaveWatchedCutscene = input.ReadBool();
          break;
        }
        case 16: {
          SingleBestPassTimeMs = input.ReadUInt32();
          break;
        }
        case 24: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 48: {
          IsHavePlayDoubleLevel = input.ReadBool();
          break;
        }
        case 64: {
          IsLevelOpen = input.ReadBool();
          break;
        }
        case 72: {
          LastChooseSkillNo = input.ReadUInt32();
          break;
        }
        case 80: {
          DoubleBestPassTimeMs = input.ReadUInt32();
          break;
        }
        case 88: {
          IsHavePlaySingleLevel = input.ReadBool();
          break;
        }
        case 98: {
          doubleBestTeamInfoList_.AddEntriesFrom(ref input, _repeated_doubleBestTeamInfoList_codec);
          break;
        }
        case 106: {
          if (singleBestTeamInfo_ == null) {
            SingleBestTeamInfo = new global::CoinCollectTeamInfoData();
          }
          input.ReadMessage(SingleBestTeamInfo);
          break;
        }
        case 112: {
          DoubleBestCollectNum = input.ReadUInt32();
          break;
        }
        case 120: {
          SingleBestCollectNum = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
