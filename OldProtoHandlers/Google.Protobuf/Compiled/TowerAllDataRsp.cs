// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerAllDataRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from TowerAllDataRsp.proto</summary>
  public static partial class TowerAllDataRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerAllDataRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerAllDataRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVUb3dlckFsbERhdGFSc3AucHJvdG8aGVRvd2VyQ3VyTGV2ZWxSZWNvcmQu",
            "cHJvdG8aFlRvd2VyRmxvb3JSZWNvcmQucHJvdG8aF1Rvd2VyTW9udGhseUJy",
            "aWVmLnByb3RvIrwGCg9Ub3dlckFsbERhdGFSc3ASGQoRdG93ZXJfc2NoZWR1",
            "bGVfaWQYCiABKA0SGQoRZGFpbHlfbGV2ZWxfaW5kZXgYCSABKA0SXwoic2tp",
            "cF9mbG9vcl9ncmFudGVkX3Jld2FyZF9pdGVtX21hcBgMIAMoCzIzLlRvd2Vy",
            "QWxsRGF0YVJzcC5Ta2lwRmxvb3JHcmFudGVkUmV3YXJkSXRlbU1hcEVudHJ5",
            "EhkKEWlzX2ZpcnN0X2ludGVyYWN0GAMgASgIEiIKGmlzX2ZpbmlzaGVkX2Vu",
            "dHJhbmNlX2Zsb29yGAEgASgIEjIKF3Rvd2VyX2Zsb29yX3JlY29yZF9saXN0",
            "GAUgAygLMhEuVG93ZXJGbG9vclJlY29yZBIWCg5kYWlseV9mbG9vcl9pZBgL",
            "IAEoDRIfChdjb21tZW1vcmF0aXZlX3Jld2FyZF9pZBgNIAEoDRI4ChtsYXN0",
            "X3NjaGVkdWxlX21vbnRobHlfYnJpZWYYxgkgASgLMhIuVG93ZXJNb250aGx5",
            "QnJpZWYSIQoZbmV4dF9zY2hlZHVsZV9jaGFuZ2VfdGltZRgGIAEoDRIeChZ2",
            "YWxpZF90b3dlcl9yZWNvcmRfbnVtGAcgASgNEhsKE3NraXBfdG9fZmxvb3Jf",
            "aW5kZXgYAiABKA0SQwoTZmxvb3Jfb3Blbl90aW1lX21hcBgEIAMoCzImLlRv",
            "d2VyQWxsRGF0YVJzcC5GbG9vck9wZW5UaW1lTWFwRW50cnkSLgoQY3VyX2xl",
            "dmVsX3JlY29yZBgPIAEoCzIULlRvd2VyQ3VyTGV2ZWxSZWNvcmQSDwoHcmV0",
            "Y29kZRgIIAEoBRIcChNzY2hlZHVsZV9zdGFydF90aW1lGJIHIAEoDRIpCg1t",
            "b250aGx5X2JyaWVmGA4gASgLMhIuVG93ZXJNb250aGx5QnJpZWYaRAoiU2tp",
            "cEZsb29yR3JhbnRlZFJld2FyZEl0ZW1NYXBFbnRyeRILCgNrZXkYASABKA0S",
            "DQoFdmFsdWUYAiABKA06AjgBGjcKFUZsb29yT3BlblRpbWVNYXBFbnRyeRIL",
            "CgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQgyqAglPbGRQcm90b3Ni",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.TowerCurLevelRecordReflection.Descriptor, global::OldProtos.TowerFloorRecordReflection.Descriptor, global::OldProtos.TowerMonthlyBriefReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.TowerAllDataRsp), global::OldProtos.TowerAllDataRsp.Parser, new[]{ "TowerScheduleId", "DailyLevelIndex", "SkipFloorGrantedRewardItemMap", "IsFirstInteract", "IsFinishedEntranceFloor", "TowerFloorRecordList", "DailyFloorId", "CommemorativeRewardId", "LastScheduleMonthlyBrief", "NextScheduleChangeTime", "ValidTowerRecordNum", "SkipToFloorIndex", "FloorOpenTimeMap", "CurLevelRecord", "Retcode", "ScheduleStartTime", "MonthlyBrief" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2473
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class TowerAllDataRsp : pb::IMessage<TowerAllDataRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerAllDataRsp> _parser = new pb::MessageParser<TowerAllDataRsp>(() => new TowerAllDataRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerAllDataRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.TowerAllDataRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp(TowerAllDataRsp other) : this() {
      towerScheduleId_ = other.towerScheduleId_;
      dailyLevelIndex_ = other.dailyLevelIndex_;
      skipFloorGrantedRewardItemMap_ = other.skipFloorGrantedRewardItemMap_.Clone();
      isFirstInteract_ = other.isFirstInteract_;
      isFinishedEntranceFloor_ = other.isFinishedEntranceFloor_;
      towerFloorRecordList_ = other.towerFloorRecordList_.Clone();
      dailyFloorId_ = other.dailyFloorId_;
      commemorativeRewardId_ = other.commemorativeRewardId_;
      lastScheduleMonthlyBrief_ = other.lastScheduleMonthlyBrief_ != null ? other.lastScheduleMonthlyBrief_.Clone() : null;
      nextScheduleChangeTime_ = other.nextScheduleChangeTime_;
      validTowerRecordNum_ = other.validTowerRecordNum_;
      skipToFloorIndex_ = other.skipToFloorIndex_;
      floorOpenTimeMap_ = other.floorOpenTimeMap_.Clone();
      curLevelRecord_ = other.curLevelRecord_ != null ? other.curLevelRecord_.Clone() : null;
      retcode_ = other.retcode_;
      scheduleStartTime_ = other.scheduleStartTime_;
      monthlyBrief_ = other.monthlyBrief_ != null ? other.monthlyBrief_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp Clone() {
      return new TowerAllDataRsp(this);
    }

    /// <summary>Field number for the "tower_schedule_id" field.</summary>
    public const int TowerScheduleIdFieldNumber = 10;
    private uint towerScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TowerScheduleId {
      get { return towerScheduleId_; }
      set {
        towerScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "daily_level_index" field.</summary>
    public const int DailyLevelIndexFieldNumber = 9;
    private uint dailyLevelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DailyLevelIndex {
      get { return dailyLevelIndex_; }
      set {
        dailyLevelIndex_ = value;
      }
    }

    /// <summary>Field number for the "skip_floor_granted_reward_item_map" field.</summary>
    public const int SkipFloorGrantedRewardItemMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_skipFloorGrantedRewardItemMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> skipFloorGrantedRewardItemMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SkipFloorGrantedRewardItemMap {
      get { return skipFloorGrantedRewardItemMap_; }
    }

    /// <summary>Field number for the "is_first_interact" field.</summary>
    public const int IsFirstInteractFieldNumber = 3;
    private bool isFirstInteract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstInteract {
      get { return isFirstInteract_; }
      set {
        isFirstInteract_ = value;
      }
    }

    /// <summary>Field number for the "is_finished_entrance_floor" field.</summary>
    public const int IsFinishedEntranceFloorFieldNumber = 1;
    private bool isFinishedEntranceFloor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishedEntranceFloor {
      get { return isFinishedEntranceFloor_; }
      set {
        isFinishedEntranceFloor_ = value;
      }
    }

    /// <summary>Field number for the "tower_floor_record_list" field.</summary>
    public const int TowerFloorRecordListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::OldProtos.TowerFloorRecord> _repeated_towerFloorRecordList_codec
        = pb::FieldCodec.ForMessage(42, global::OldProtos.TowerFloorRecord.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.TowerFloorRecord> towerFloorRecordList_ = new pbc::RepeatedField<global::OldProtos.TowerFloorRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.TowerFloorRecord> TowerFloorRecordList {
      get { return towerFloorRecordList_; }
    }

    /// <summary>Field number for the "daily_floor_id" field.</summary>
    public const int DailyFloorIdFieldNumber = 11;
    private uint dailyFloorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DailyFloorId {
      get { return dailyFloorId_; }
      set {
        dailyFloorId_ = value;
      }
    }

    /// <summary>Field number for the "commemorative_reward_id" field.</summary>
    public const int CommemorativeRewardIdFieldNumber = 13;
    private uint commemorativeRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CommemorativeRewardId {
      get { return commemorativeRewardId_; }
      set {
        commemorativeRewardId_ = value;
      }
    }

    /// <summary>Field number for the "last_schedule_monthly_brief" field.</summary>
    public const int LastScheduleMonthlyBriefFieldNumber = 1222;
    private global::OldProtos.TowerMonthlyBrief lastScheduleMonthlyBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.TowerMonthlyBrief LastScheduleMonthlyBrief {
      get { return lastScheduleMonthlyBrief_; }
      set {
        lastScheduleMonthlyBrief_ = value;
      }
    }

    /// <summary>Field number for the "next_schedule_change_time" field.</summary>
    public const int NextScheduleChangeTimeFieldNumber = 6;
    private uint nextScheduleChangeTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextScheduleChangeTime {
      get { return nextScheduleChangeTime_; }
      set {
        nextScheduleChangeTime_ = value;
      }
    }

    /// <summary>Field number for the "valid_tower_record_num" field.</summary>
    public const int ValidTowerRecordNumFieldNumber = 7;
    private uint validTowerRecordNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ValidTowerRecordNum {
      get { return validTowerRecordNum_; }
      set {
        validTowerRecordNum_ = value;
      }
    }

    /// <summary>Field number for the "skip_to_floor_index" field.</summary>
    public const int SkipToFloorIndexFieldNumber = 2;
    private uint skipToFloorIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkipToFloorIndex {
      get { return skipToFloorIndex_; }
      set {
        skipToFloorIndex_ = value;
      }
    }

    /// <summary>Field number for the "floor_open_time_map" field.</summary>
    public const int FloorOpenTimeMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, uint>.Codec _map_floorOpenTimeMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
    private readonly pbc::MapField<uint, uint> floorOpenTimeMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FloorOpenTimeMap {
      get { return floorOpenTimeMap_; }
    }

    /// <summary>Field number for the "cur_level_record" field.</summary>
    public const int CurLevelRecordFieldNumber = 15;
    private global::OldProtos.TowerCurLevelRecord curLevelRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.TowerCurLevelRecord CurLevelRecord {
      get { return curLevelRecord_; }
      set {
        curLevelRecord_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "schedule_start_time" field.</summary>
    public const int ScheduleStartTimeFieldNumber = 914;
    private uint scheduleStartTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleStartTime {
      get { return scheduleStartTime_; }
      set {
        scheduleStartTime_ = value;
      }
    }

    /// <summary>Field number for the "monthly_brief" field.</summary>
    public const int MonthlyBriefFieldNumber = 14;
    private global::OldProtos.TowerMonthlyBrief monthlyBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.TowerMonthlyBrief MonthlyBrief {
      get { return monthlyBrief_; }
      set {
        monthlyBrief_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerAllDataRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerAllDataRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TowerScheduleId != other.TowerScheduleId) return false;
      if (DailyLevelIndex != other.DailyLevelIndex) return false;
      if (!SkipFloorGrantedRewardItemMap.Equals(other.SkipFloorGrantedRewardItemMap)) return false;
      if (IsFirstInteract != other.IsFirstInteract) return false;
      if (IsFinishedEntranceFloor != other.IsFinishedEntranceFloor) return false;
      if(!towerFloorRecordList_.Equals(other.towerFloorRecordList_)) return false;
      if (DailyFloorId != other.DailyFloorId) return false;
      if (CommemorativeRewardId != other.CommemorativeRewardId) return false;
      if (!object.Equals(LastScheduleMonthlyBrief, other.LastScheduleMonthlyBrief)) return false;
      if (NextScheduleChangeTime != other.NextScheduleChangeTime) return false;
      if (ValidTowerRecordNum != other.ValidTowerRecordNum) return false;
      if (SkipToFloorIndex != other.SkipToFloorIndex) return false;
      if (!FloorOpenTimeMap.Equals(other.FloorOpenTimeMap)) return false;
      if (!object.Equals(CurLevelRecord, other.CurLevelRecord)) return false;
      if (Retcode != other.Retcode) return false;
      if (ScheduleStartTime != other.ScheduleStartTime) return false;
      if (!object.Equals(MonthlyBrief, other.MonthlyBrief)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TowerScheduleId != 0) hash ^= TowerScheduleId.GetHashCode();
      if (DailyLevelIndex != 0) hash ^= DailyLevelIndex.GetHashCode();
      hash ^= SkipFloorGrantedRewardItemMap.GetHashCode();
      if (IsFirstInteract != false) hash ^= IsFirstInteract.GetHashCode();
      if (IsFinishedEntranceFloor != false) hash ^= IsFinishedEntranceFloor.GetHashCode();
      hash ^= towerFloorRecordList_.GetHashCode();
      if (DailyFloorId != 0) hash ^= DailyFloorId.GetHashCode();
      if (CommemorativeRewardId != 0) hash ^= CommemorativeRewardId.GetHashCode();
      if (lastScheduleMonthlyBrief_ != null) hash ^= LastScheduleMonthlyBrief.GetHashCode();
      if (NextScheduleChangeTime != 0) hash ^= NextScheduleChangeTime.GetHashCode();
      if (ValidTowerRecordNum != 0) hash ^= ValidTowerRecordNum.GetHashCode();
      if (SkipToFloorIndex != 0) hash ^= SkipToFloorIndex.GetHashCode();
      hash ^= FloorOpenTimeMap.GetHashCode();
      if (curLevelRecord_ != null) hash ^= CurLevelRecord.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ScheduleStartTime != 0) hash ^= ScheduleStartTime.GetHashCode();
      if (monthlyBrief_ != null) hash ^= MonthlyBrief.GetHashCode();
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
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (SkipToFloorIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkipToFloorIndex);
      }
      if (IsFirstInteract != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFirstInteract);
      }
      floorOpenTimeMap_.WriteTo(output, _map_floorOpenTimeMap_codec);
      towerFloorRecordList_.WriteTo(output, _repeated_towerFloorRecordList_codec);
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      if (ValidTowerRecordNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ValidTowerRecordNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (DailyLevelIndex != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DailyLevelIndex);
      }
      if (TowerScheduleId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TowerScheduleId);
      }
      if (DailyFloorId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DailyFloorId);
      }
      skipFloorGrantedRewardItemMap_.WriteTo(output, _map_skipFloorGrantedRewardItemMap_codec);
      if (CommemorativeRewardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CommemorativeRewardId);
      }
      if (monthlyBrief_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(MonthlyBrief);
      }
      if (curLevelRecord_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(CurLevelRecord);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(144, 57);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        output.WriteRawTag(178, 76);
        output.WriteMessage(LastScheduleMonthlyBrief);
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
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (SkipToFloorIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkipToFloorIndex);
      }
      if (IsFirstInteract != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFirstInteract);
      }
      floorOpenTimeMap_.WriteTo(ref output, _map_floorOpenTimeMap_codec);
      towerFloorRecordList_.WriteTo(ref output, _repeated_towerFloorRecordList_codec);
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      if (ValidTowerRecordNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ValidTowerRecordNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (DailyLevelIndex != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DailyLevelIndex);
      }
      if (TowerScheduleId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TowerScheduleId);
      }
      if (DailyFloorId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DailyFloorId);
      }
      skipFloorGrantedRewardItemMap_.WriteTo(ref output, _map_skipFloorGrantedRewardItemMap_codec);
      if (CommemorativeRewardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CommemorativeRewardId);
      }
      if (monthlyBrief_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(MonthlyBrief);
      }
      if (curLevelRecord_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(CurLevelRecord);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(144, 57);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        output.WriteRawTag(178, 76);
        output.WriteMessage(LastScheduleMonthlyBrief);
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
      if (TowerScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TowerScheduleId);
      }
      if (DailyLevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DailyLevelIndex);
      }
      size += skipFloorGrantedRewardItemMap_.CalculateSize(_map_skipFloorGrantedRewardItemMap_codec);
      if (IsFirstInteract != false) {
        size += 1 + 1;
      }
      if (IsFinishedEntranceFloor != false) {
        size += 1 + 1;
      }
      size += towerFloorRecordList_.CalculateSize(_repeated_towerFloorRecordList_codec);
      if (DailyFloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DailyFloorId);
      }
      if (CommemorativeRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CommemorativeRewardId);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LastScheduleMonthlyBrief);
      }
      if (NextScheduleChangeTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextScheduleChangeTime);
      }
      if (ValidTowerRecordNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ValidTowerRecordNum);
      }
      if (SkipToFloorIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkipToFloorIndex);
      }
      size += floorOpenTimeMap_.CalculateSize(_map_floorOpenTimeMap_codec);
      if (curLevelRecord_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurLevelRecord);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (ScheduleStartTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleStartTime);
      }
      if (monthlyBrief_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MonthlyBrief);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerAllDataRsp other) {
      if (other == null) {
        return;
      }
      if (other.TowerScheduleId != 0) {
        TowerScheduleId = other.TowerScheduleId;
      }
      if (other.DailyLevelIndex != 0) {
        DailyLevelIndex = other.DailyLevelIndex;
      }
      skipFloorGrantedRewardItemMap_.MergeFrom(other.skipFloorGrantedRewardItemMap_);
      if (other.IsFirstInteract != false) {
        IsFirstInteract = other.IsFirstInteract;
      }
      if (other.IsFinishedEntranceFloor != false) {
        IsFinishedEntranceFloor = other.IsFinishedEntranceFloor;
      }
      towerFloorRecordList_.Add(other.towerFloorRecordList_);
      if (other.DailyFloorId != 0) {
        DailyFloorId = other.DailyFloorId;
      }
      if (other.CommemorativeRewardId != 0) {
        CommemorativeRewardId = other.CommemorativeRewardId;
      }
      if (other.lastScheduleMonthlyBrief_ != null) {
        if (lastScheduleMonthlyBrief_ == null) {
          LastScheduleMonthlyBrief = new global::OldProtos.TowerMonthlyBrief();
        }
        LastScheduleMonthlyBrief.MergeFrom(other.LastScheduleMonthlyBrief);
      }
      if (other.NextScheduleChangeTime != 0) {
        NextScheduleChangeTime = other.NextScheduleChangeTime;
      }
      if (other.ValidTowerRecordNum != 0) {
        ValidTowerRecordNum = other.ValidTowerRecordNum;
      }
      if (other.SkipToFloorIndex != 0) {
        SkipToFloorIndex = other.SkipToFloorIndex;
      }
      floorOpenTimeMap_.MergeFrom(other.floorOpenTimeMap_);
      if (other.curLevelRecord_ != null) {
        if (curLevelRecord_ == null) {
          CurLevelRecord = new global::OldProtos.TowerCurLevelRecord();
        }
        CurLevelRecord.MergeFrom(other.CurLevelRecord);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ScheduleStartTime != 0) {
        ScheduleStartTime = other.ScheduleStartTime;
      }
      if (other.monthlyBrief_ != null) {
        if (monthlyBrief_ == null) {
          MonthlyBrief = new global::OldProtos.TowerMonthlyBrief();
        }
        MonthlyBrief.MergeFrom(other.MonthlyBrief);
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
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
          case 16: {
            SkipToFloorIndex = input.ReadUInt32();
            break;
          }
          case 24: {
            IsFirstInteract = input.ReadBool();
            break;
          }
          case 34: {
            floorOpenTimeMap_.AddEntriesFrom(input, _map_floorOpenTimeMap_codec);
            break;
          }
          case 42: {
            towerFloorRecordList_.AddEntriesFrom(input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 48: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 56: {
            ValidTowerRecordNum = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            DailyLevelIndex = input.ReadUInt32();
            break;
          }
          case 80: {
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 88: {
            DailyFloorId = input.ReadUInt32();
            break;
          }
          case 98: {
            skipFloorGrantedRewardItemMap_.AddEntriesFrom(input, _map_skipFloorGrantedRewardItemMap_codec);
            break;
          }
          case 104: {
            CommemorativeRewardId = input.ReadUInt32();
            break;
          }
          case 114: {
            if (monthlyBrief_ == null) {
              MonthlyBrief = new global::OldProtos.TowerMonthlyBrief();
            }
            input.ReadMessage(MonthlyBrief);
            break;
          }
          case 122: {
            if (curLevelRecord_ == null) {
              CurLevelRecord = new global::OldProtos.TowerCurLevelRecord();
            }
            input.ReadMessage(CurLevelRecord);
            break;
          }
          case 7312: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 9778: {
            if (lastScheduleMonthlyBrief_ == null) {
              LastScheduleMonthlyBrief = new global::OldProtos.TowerMonthlyBrief();
            }
            input.ReadMessage(LastScheduleMonthlyBrief);
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
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
          case 16: {
            SkipToFloorIndex = input.ReadUInt32();
            break;
          }
          case 24: {
            IsFirstInteract = input.ReadBool();
            break;
          }
          case 34: {
            floorOpenTimeMap_.AddEntriesFrom(ref input, _map_floorOpenTimeMap_codec);
            break;
          }
          case 42: {
            towerFloorRecordList_.AddEntriesFrom(ref input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 48: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 56: {
            ValidTowerRecordNum = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            DailyLevelIndex = input.ReadUInt32();
            break;
          }
          case 80: {
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 88: {
            DailyFloorId = input.ReadUInt32();
            break;
          }
          case 98: {
            skipFloorGrantedRewardItemMap_.AddEntriesFrom(ref input, _map_skipFloorGrantedRewardItemMap_codec);
            break;
          }
          case 104: {
            CommemorativeRewardId = input.ReadUInt32();
            break;
          }
          case 114: {
            if (monthlyBrief_ == null) {
              MonthlyBrief = new global::OldProtos.TowerMonthlyBrief();
            }
            input.ReadMessage(MonthlyBrief);
            break;
          }
          case 122: {
            if (curLevelRecord_ == null) {
              CurLevelRecord = new global::OldProtos.TowerCurLevelRecord();
            }
            input.ReadMessage(CurLevelRecord);
            break;
          }
          case 7312: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 9778: {
            if (lastScheduleMonthlyBrief_ == null) {
              LastScheduleMonthlyBrief = new global::OldProtos.TowerMonthlyBrief();
            }
            input.ReadMessage(LastScheduleMonthlyBrief);
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
