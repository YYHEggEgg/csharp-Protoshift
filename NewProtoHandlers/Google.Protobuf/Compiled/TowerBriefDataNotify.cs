// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerBriefDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from TowerBriefDataNotify.proto</summary>
  public static partial class TowerBriefDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerBriefDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerBriefDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpUb3dlckJyaWVmRGF0YU5vdGlmeS5wcm90byLhAQoUVG93ZXJCcmllZkRh",
            "dGFOb3RpZnkSGAoQbGFzdF9sZXZlbF9pbmRleBgGIAEoDRIhChluZXh0X3Nj",
            "aGVkdWxlX2NoYW5nZV90aW1lGAkgASgNEiIKGmlzX2ZpbmlzaGVkX2VudHJh",
            "bmNlX2Zsb29yGA4gASgIEhgKEGxhc3RfZmxvb3JfaW5kZXgYASABKA0SGQoR",
            "dG93ZXJfc2NoZWR1bGVfaWQYCyABKA0SGwoTc2NoZWR1bGVfc3RhcnRfdGlt",
            "ZRgIIAEoDRIWCg50b3RhbF9zdGFyX251bRgHIAEoDUIMqgIJTmV3UHJvdG9z",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.TowerBriefDataNotify), global::NewProtos.TowerBriefDataNotify.Parser, new[]{ "LastLevelIndex", "NextScheduleChangeTime", "IsFinishedEntranceFloor", "LastFloorIndex", "TowerScheduleId", "ScheduleStartTime", "TotalStarNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2479;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class TowerBriefDataNotify : pb::IMessage<TowerBriefDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerBriefDataNotify> _parser = new pb::MessageParser<TowerBriefDataNotify>(() => new TowerBriefDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerBriefDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.TowerBriefDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerBriefDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerBriefDataNotify(TowerBriefDataNotify other) : this() {
      lastLevelIndex_ = other.lastLevelIndex_;
      nextScheduleChangeTime_ = other.nextScheduleChangeTime_;
      isFinishedEntranceFloor_ = other.isFinishedEntranceFloor_;
      lastFloorIndex_ = other.lastFloorIndex_;
      towerScheduleId_ = other.towerScheduleId_;
      scheduleStartTime_ = other.scheduleStartTime_;
      totalStarNum_ = other.totalStarNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerBriefDataNotify Clone() {
      return new TowerBriefDataNotify(this);
    }

    /// <summary>Field number for the "last_level_index" field.</summary>
    public const int LastLevelIndexFieldNumber = 6;
    private uint lastLevelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastLevelIndex {
      get { return lastLevelIndex_; }
      set {
        lastLevelIndex_ = value;
      }
    }

    /// <summary>Field number for the "next_schedule_change_time" field.</summary>
    public const int NextScheduleChangeTimeFieldNumber = 9;
    private uint nextScheduleChangeTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextScheduleChangeTime {
      get { return nextScheduleChangeTime_; }
      set {
        nextScheduleChangeTime_ = value;
      }
    }

    /// <summary>Field number for the "is_finished_entrance_floor" field.</summary>
    public const int IsFinishedEntranceFloorFieldNumber = 14;
    private bool isFinishedEntranceFloor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishedEntranceFloor {
      get { return isFinishedEntranceFloor_; }
      set {
        isFinishedEntranceFloor_ = value;
      }
    }

    /// <summary>Field number for the "last_floor_index" field.</summary>
    public const int LastFloorIndexFieldNumber = 1;
    private uint lastFloorIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastFloorIndex {
      get { return lastFloorIndex_; }
      set {
        lastFloorIndex_ = value;
      }
    }

    /// <summary>Field number for the "tower_schedule_id" field.</summary>
    public const int TowerScheduleIdFieldNumber = 11;
    private uint towerScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TowerScheduleId {
      get { return towerScheduleId_; }
      set {
        towerScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "schedule_start_time" field.</summary>
    public const int ScheduleStartTimeFieldNumber = 8;
    private uint scheduleStartTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleStartTime {
      get { return scheduleStartTime_; }
      set {
        scheduleStartTime_ = value;
      }
    }

    /// <summary>Field number for the "total_star_num" field.</summary>
    public const int TotalStarNumFieldNumber = 7;
    private uint totalStarNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalStarNum {
      get { return totalStarNum_; }
      set {
        totalStarNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerBriefDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerBriefDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LastLevelIndex != other.LastLevelIndex) return false;
      if (NextScheduleChangeTime != other.NextScheduleChangeTime) return false;
      if (IsFinishedEntranceFloor != other.IsFinishedEntranceFloor) return false;
      if (LastFloorIndex != other.LastFloorIndex) return false;
      if (TowerScheduleId != other.TowerScheduleId) return false;
      if (ScheduleStartTime != other.ScheduleStartTime) return false;
      if (TotalStarNum != other.TotalStarNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LastLevelIndex != 0) hash ^= LastLevelIndex.GetHashCode();
      if (NextScheduleChangeTime != 0) hash ^= NextScheduleChangeTime.GetHashCode();
      if (IsFinishedEntranceFloor != false) hash ^= IsFinishedEntranceFloor.GetHashCode();
      if (LastFloorIndex != 0) hash ^= LastFloorIndex.GetHashCode();
      if (TowerScheduleId != 0) hash ^= TowerScheduleId.GetHashCode();
      if (ScheduleStartTime != 0) hash ^= ScheduleStartTime.GetHashCode();
      if (TotalStarNum != 0) hash ^= TotalStarNum.GetHashCode();
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
      if (LastFloorIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LastFloorIndex);
      }
      if (LastLevelIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LastLevelIndex);
      }
      if (TotalStarNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TotalStarNum);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      if (TowerScheduleId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TowerScheduleId);
      }
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinishedEntranceFloor);
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
      if (LastFloorIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LastFloorIndex);
      }
      if (LastLevelIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LastLevelIndex);
      }
      if (TotalStarNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TotalStarNum);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      if (TowerScheduleId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TowerScheduleId);
      }
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinishedEntranceFloor);
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
      if (LastLevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastLevelIndex);
      }
      if (NextScheduleChangeTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextScheduleChangeTime);
      }
      if (IsFinishedEntranceFloor != false) {
        size += 1 + 1;
      }
      if (LastFloorIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastFloorIndex);
      }
      if (TowerScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TowerScheduleId);
      }
      if (ScheduleStartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleStartTime);
      }
      if (TotalStarNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalStarNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerBriefDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.LastLevelIndex != 0) {
        LastLevelIndex = other.LastLevelIndex;
      }
      if (other.NextScheduleChangeTime != 0) {
        NextScheduleChangeTime = other.NextScheduleChangeTime;
      }
      if (other.IsFinishedEntranceFloor != false) {
        IsFinishedEntranceFloor = other.IsFinishedEntranceFloor;
      }
      if (other.LastFloorIndex != 0) {
        LastFloorIndex = other.LastFloorIndex;
      }
      if (other.TowerScheduleId != 0) {
        TowerScheduleId = other.TowerScheduleId;
      }
      if (other.ScheduleStartTime != 0) {
        ScheduleStartTime = other.ScheduleStartTime;
      }
      if (other.TotalStarNum != 0) {
        TotalStarNum = other.TotalStarNum;
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
            LastFloorIndex = input.ReadUInt32();
            break;
          }
          case 48: {
            LastLevelIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            TotalStarNum = input.ReadUInt32();
            break;
          }
          case 64: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 72: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 88: {
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinishedEntranceFloor = input.ReadBool();
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
            LastFloorIndex = input.ReadUInt32();
            break;
          }
          case 48: {
            LastLevelIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            TotalStarNum = input.ReadUInt32();
            break;
          }
          case 64: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 72: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 88: {
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinishedEntranceFloor = input.ReadBool();
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
