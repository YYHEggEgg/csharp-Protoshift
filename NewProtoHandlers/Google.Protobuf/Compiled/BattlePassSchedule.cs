// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassSchedule.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from BattlePassSchedule.proto</summary>
  public static partial class BattlePassScheduleReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassSchedule.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassScheduleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhCYXR0bGVQYXNzU2NoZWR1bGUucHJvdG8aFUJhdHRsZVBhc3NDeWNsZS5w",
            "cm90bxoXQmF0dGxlUGFzc1Byb2R1Y3QucHJvdG8aGUJhdHRsZVBhc3NSZXdh",
            "cmRUYWcucHJvdG8aHEJhdHRsZVBhc3NVbmxvY2tTdGF0dXMucHJvdG8iiwMK",
            "EkJhdHRsZVBhc3NTY2hlZHVsZRITCgtzY2hlZHVsZV9pZBgFIAEoDRINCgVw",
            "b2ludBgCIAEoDRINCgVsZXZlbBgHIAEoDRIiChppc19leHRyYV9wYWlkX3Jl",
            "d2FyZF90YWtlbhgIIAEoCBIYChBjdXJfY3ljbGVfcG9pbnRzGA4gASgNEhEK",
            "CWlzX3ZpZXdlZBgMIAEoCBIbChNwYWlkX3BsYXRmb3JtX2ZsYWdzGAQgASgN",
            "EiMKCWN1cl9jeWNsZRgLIAEoCzIQLkJhdHRsZVBhc3NDeWNsZRISCgpiZWdp",
            "bl90aW1lGAEgASgNEi4KDXVubG9ja19zdGF0dXMYDyABKA4yFy5CYXR0bGVQ",
            "YXNzVW5sb2NrU3RhdHVzEigKDHByb2R1Y3RfaW5mbxgKIAEoCzISLkJhdHRs",
            "ZVBhc3NQcm9kdWN0EhAKCGVuZF90aW1lGA0gASgNEi8KEXJld2FyZF90YWtl",
            "bl9saXN0GAMgAygLMhQuQmF0dGxlUGFzc1Jld2FyZFRhZ0IMqgIJTmV3UHJv",
            "dG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.BattlePassCycleReflection.Descriptor, global::NewProtos.BattlePassProductReflection.Descriptor, global::NewProtos.BattlePassRewardTagReflection.Descriptor, global::NewProtos.BattlePassUnlockStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.BattlePassSchedule), global::NewProtos.BattlePassSchedule.Parser, new[]{ "ScheduleId", "Point", "Level", "IsExtraPaidRewardTaken", "CurCyclePoints", "IsViewed", "PaidPlatformFlags", "CurCycle", "BeginTime", "UnlockStatus", "ProductInfo", "EndTime", "RewardTakenList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattlePassSchedule : pb::IMessage<BattlePassSchedule>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassSchedule> _parser = new pb::MessageParser<BattlePassSchedule>(() => new BattlePassSchedule());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassSchedule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.BattlePassScheduleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassSchedule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassSchedule(BattlePassSchedule other) : this() {
      scheduleId_ = other.scheduleId_;
      point_ = other.point_;
      level_ = other.level_;
      isExtraPaidRewardTaken_ = other.isExtraPaidRewardTaken_;
      curCyclePoints_ = other.curCyclePoints_;
      isViewed_ = other.isViewed_;
      paidPlatformFlags_ = other.paidPlatformFlags_;
      curCycle_ = other.curCycle_ != null ? other.curCycle_.Clone() : null;
      beginTime_ = other.beginTime_;
      unlockStatus_ = other.unlockStatus_;
      productInfo_ = other.productInfo_ != null ? other.productInfo_.Clone() : null;
      endTime_ = other.endTime_;
      rewardTakenList_ = other.rewardTakenList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassSchedule Clone() {
      return new BattlePassSchedule(this);
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 5;
    private uint scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    /// <summary>Field number for the "point" field.</summary>
    public const int PointFieldNumber = 2;
    private uint point_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Point {
      get { return point_; }
      set {
        point_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 7;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "is_extra_paid_reward_taken" field.</summary>
    public const int IsExtraPaidRewardTakenFieldNumber = 8;
    private bool isExtraPaidRewardTaken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsExtraPaidRewardTaken {
      get { return isExtraPaidRewardTaken_; }
      set {
        isExtraPaidRewardTaken_ = value;
      }
    }

    /// <summary>Field number for the "cur_cycle_points" field.</summary>
    public const int CurCyclePointsFieldNumber = 14;
    private uint curCyclePoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurCyclePoints {
      get { return curCyclePoints_; }
      set {
        curCyclePoints_ = value;
      }
    }

    /// <summary>Field number for the "is_viewed" field.</summary>
    public const int IsViewedFieldNumber = 12;
    private bool isViewed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsViewed {
      get { return isViewed_; }
      set {
        isViewed_ = value;
      }
    }

    /// <summary>Field number for the "paid_platform_flags" field.</summary>
    public const int PaidPlatformFlagsFieldNumber = 4;
    private uint paidPlatformFlags_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PaidPlatformFlags {
      get { return paidPlatformFlags_; }
      set {
        paidPlatformFlags_ = value;
      }
    }

    /// <summary>Field number for the "cur_cycle" field.</summary>
    public const int CurCycleFieldNumber = 11;
    private global::NewProtos.BattlePassCycle curCycle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.BattlePassCycle CurCycle {
      get { return curCycle_; }
      set {
        curCycle_ = value;
      }
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 1;
    private uint beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "unlock_status" field.</summary>
    public const int UnlockStatusFieldNumber = 15;
    private global::NewProtos.BattlePassUnlockStatus unlockStatus_ = global::NewProtos.BattlePassUnlockStatus.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.BattlePassUnlockStatus UnlockStatus {
      get { return unlockStatus_; }
      set {
        unlockStatus_ = value;
      }
    }

    /// <summary>Field number for the "product_info" field.</summary>
    public const int ProductInfoFieldNumber = 10;
    private global::NewProtos.BattlePassProduct productInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.BattlePassProduct ProductInfo {
      get { return productInfo_; }
      set {
        productInfo_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 13;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "reward_taken_list" field.</summary>
    public const int RewardTakenListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::NewProtos.BattlePassRewardTag> _repeated_rewardTakenList_codec
        = pb::FieldCodec.ForMessage(26, global::NewProtos.BattlePassRewardTag.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.BattlePassRewardTag> rewardTakenList_ = new pbc::RepeatedField<global::NewProtos.BattlePassRewardTag>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.BattlePassRewardTag> RewardTakenList {
      get { return rewardTakenList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassSchedule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassSchedule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScheduleId != other.ScheduleId) return false;
      if (Point != other.Point) return false;
      if (Level != other.Level) return false;
      if (IsExtraPaidRewardTaken != other.IsExtraPaidRewardTaken) return false;
      if (CurCyclePoints != other.CurCyclePoints) return false;
      if (IsViewed != other.IsViewed) return false;
      if (PaidPlatformFlags != other.PaidPlatformFlags) return false;
      if (!object.Equals(CurCycle, other.CurCycle)) return false;
      if (BeginTime != other.BeginTime) return false;
      if (UnlockStatus != other.UnlockStatus) return false;
      if (!object.Equals(ProductInfo, other.ProductInfo)) return false;
      if (EndTime != other.EndTime) return false;
      if(!rewardTakenList_.Equals(other.rewardTakenList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      if (Point != 0) hash ^= Point.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (IsExtraPaidRewardTaken != false) hash ^= IsExtraPaidRewardTaken.GetHashCode();
      if (CurCyclePoints != 0) hash ^= CurCyclePoints.GetHashCode();
      if (IsViewed != false) hash ^= IsViewed.GetHashCode();
      if (PaidPlatformFlags != 0) hash ^= PaidPlatformFlags.GetHashCode();
      if (curCycle_ != null) hash ^= CurCycle.GetHashCode();
      if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
      if (UnlockStatus != global::NewProtos.BattlePassUnlockStatus.Invalid) hash ^= UnlockStatus.GetHashCode();
      if (productInfo_ != null) hash ^= ProductInfo.GetHashCode();
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      hash ^= rewardTakenList_.GetHashCode();
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
      if (BeginTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BeginTime);
      }
      if (Point != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Point);
      }
      rewardTakenList_.WriteTo(output, _repeated_rewardTakenList_codec);
      if (PaidPlatformFlags != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PaidPlatformFlags);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ScheduleId);
      }
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Level);
      }
      if (IsExtraPaidRewardTaken != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsExtraPaidRewardTaken);
      }
      if (productInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ProductInfo);
      }
      if (curCycle_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CurCycle);
      }
      if (IsViewed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsViewed);
      }
      if (EndTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EndTime);
      }
      if (CurCyclePoints != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurCyclePoints);
      }
      if (UnlockStatus != global::NewProtos.BattlePassUnlockStatus.Invalid) {
        output.WriteRawTag(120);
        output.WriteEnum((int) UnlockStatus);
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
      if (BeginTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BeginTime);
      }
      if (Point != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Point);
      }
      rewardTakenList_.WriteTo(ref output, _repeated_rewardTakenList_codec);
      if (PaidPlatformFlags != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PaidPlatformFlags);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ScheduleId);
      }
      if (Level != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Level);
      }
      if (IsExtraPaidRewardTaken != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsExtraPaidRewardTaken);
      }
      if (productInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ProductInfo);
      }
      if (curCycle_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CurCycle);
      }
      if (IsViewed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsViewed);
      }
      if (EndTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EndTime);
      }
      if (CurCyclePoints != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurCyclePoints);
      }
      if (UnlockStatus != global::NewProtos.BattlePassUnlockStatus.Invalid) {
        output.WriteRawTag(120);
        output.WriteEnum((int) UnlockStatus);
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
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
      }
      if (Point != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Point);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (IsExtraPaidRewardTaken != false) {
        size += 1 + 1;
      }
      if (CurCyclePoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurCyclePoints);
      }
      if (IsViewed != false) {
        size += 1 + 1;
      }
      if (PaidPlatformFlags != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PaidPlatformFlags);
      }
      if (curCycle_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurCycle);
      }
      if (BeginTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
      }
      if (UnlockStatus != global::NewProtos.BattlePassUnlockStatus.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnlockStatus);
      }
      if (productInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProductInfo);
      }
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      size += rewardTakenList_.CalculateSize(_repeated_rewardTakenList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassSchedule other) {
      if (other == null) {
        return;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.Point != 0) {
        Point = other.Point;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.IsExtraPaidRewardTaken != false) {
        IsExtraPaidRewardTaken = other.IsExtraPaidRewardTaken;
      }
      if (other.CurCyclePoints != 0) {
        CurCyclePoints = other.CurCyclePoints;
      }
      if (other.IsViewed != false) {
        IsViewed = other.IsViewed;
      }
      if (other.PaidPlatformFlags != 0) {
        PaidPlatformFlags = other.PaidPlatformFlags;
      }
      if (other.curCycle_ != null) {
        if (curCycle_ == null) {
          CurCycle = new global::NewProtos.BattlePassCycle();
        }
        CurCycle.MergeFrom(other.CurCycle);
      }
      if (other.BeginTime != 0) {
        BeginTime = other.BeginTime;
      }
      if (other.UnlockStatus != global::NewProtos.BattlePassUnlockStatus.Invalid) {
        UnlockStatus = other.UnlockStatus;
      }
      if (other.productInfo_ != null) {
        if (productInfo_ == null) {
          ProductInfo = new global::NewProtos.BattlePassProduct();
        }
        ProductInfo.MergeFrom(other.ProductInfo);
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      rewardTakenList_.Add(other.rewardTakenList_);
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
            BeginTime = input.ReadUInt32();
            break;
          }
          case 16: {
            Point = input.ReadUInt32();
            break;
          }
          case 26: {
            rewardTakenList_.AddEntriesFrom(input, _repeated_rewardTakenList_codec);
            break;
          }
          case 32: {
            PaidPlatformFlags = input.ReadUInt32();
            break;
          }
          case 40: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 56: {
            Level = input.ReadUInt32();
            break;
          }
          case 64: {
            IsExtraPaidRewardTaken = input.ReadBool();
            break;
          }
          case 82: {
            if (productInfo_ == null) {
              ProductInfo = new global::NewProtos.BattlePassProduct();
            }
            input.ReadMessage(ProductInfo);
            break;
          }
          case 90: {
            if (curCycle_ == null) {
              CurCycle = new global::NewProtos.BattlePassCycle();
            }
            input.ReadMessage(CurCycle);
            break;
          }
          case 96: {
            IsViewed = input.ReadBool();
            break;
          }
          case 104: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 112: {
            CurCyclePoints = input.ReadUInt32();
            break;
          }
          case 120: {
            UnlockStatus = (global::NewProtos.BattlePassUnlockStatus) input.ReadEnum();
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
            BeginTime = input.ReadUInt32();
            break;
          }
          case 16: {
            Point = input.ReadUInt32();
            break;
          }
          case 26: {
            rewardTakenList_.AddEntriesFrom(ref input, _repeated_rewardTakenList_codec);
            break;
          }
          case 32: {
            PaidPlatformFlags = input.ReadUInt32();
            break;
          }
          case 40: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 56: {
            Level = input.ReadUInt32();
            break;
          }
          case 64: {
            IsExtraPaidRewardTaken = input.ReadBool();
            break;
          }
          case 82: {
            if (productInfo_ == null) {
              ProductInfo = new global::NewProtos.BattlePassProduct();
            }
            input.ReadMessage(ProductInfo);
            break;
          }
          case 90: {
            if (curCycle_ == null) {
              CurCycle = new global::NewProtos.BattlePassCycle();
            }
            input.ReadMessage(CurCycle);
            break;
          }
          case 96: {
            IsViewed = input.ReadBool();
            break;
          }
          case 104: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 112: {
            CurCyclePoints = input.ReadUInt32();
            break;
          }
          case 120: {
            UnlockStatus = (global::NewProtos.BattlePassUnlockStatus) input.ReadEnum();
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
