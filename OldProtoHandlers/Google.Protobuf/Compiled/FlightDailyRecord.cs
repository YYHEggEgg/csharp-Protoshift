// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FlightDailyRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from FlightDailyRecord.proto</summary>
  public static partial class FlightDailyRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for FlightDailyRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FlightDailyRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdGbGlnaHREYWlseVJlY29yZC5wcm90byJ6ChFGbGlnaHREYWlseVJlY29y",
            "ZBIQCghncm91cF9pZBgEIAEoDRISCgppc190b3VjaGVkGAEgASgIEhcKD3dh",
            "dGNoZXJfaWRfbGlzdBgLIAMoDRISCgpiZXN0X3Njb3JlGAcgASgNEhIKCnN0",
            "YXJ0X3RpbWUYAyABKA1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.FlightDailyRecord), global::OldProtos.FlightDailyRecord.Parser, new[]{ "GroupId", "IsTouched", "WatcherIdList", "BestScore", "StartTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FlightDailyRecord : pb::IMessage<FlightDailyRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FlightDailyRecord> _parser = new pb::MessageParser<FlightDailyRecord>(() => new FlightDailyRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FlightDailyRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.FlightDailyRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlightDailyRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlightDailyRecord(FlightDailyRecord other) : this() {
      groupId_ = other.groupId_;
      isTouched_ = other.isTouched_;
      watcherIdList_ = other.watcherIdList_.Clone();
      bestScore_ = other.bestScore_;
      startTime_ = other.startTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlightDailyRecord Clone() {
      return new FlightDailyRecord(this);
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 4;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "is_touched" field.</summary>
    public const int IsTouchedFieldNumber = 1;
    private bool isTouched_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTouched {
      get { return isTouched_; }
      set {
        isTouched_ = value;
      }
    }

    /// <summary>Field number for the "watcher_id_list" field.</summary>
    public const int WatcherIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_watcherIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> watcherIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> WatcherIdList {
      get { return watcherIdList_; }
    }

    /// <summary>Field number for the "best_score" field.</summary>
    public const int BestScoreFieldNumber = 7;
    private uint bestScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestScore {
      get { return bestScore_; }
      set {
        bestScore_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 3;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FlightDailyRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FlightDailyRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (IsTouched != other.IsTouched) return false;
      if(!watcherIdList_.Equals(other.watcherIdList_)) return false;
      if (BestScore != other.BestScore) return false;
      if (StartTime != other.StartTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (IsTouched != false) hash ^= IsTouched.GetHashCode();
      hash ^= watcherIdList_.GetHashCode();
      if (BestScore != 0) hash ^= BestScore.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
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
      if (IsTouched != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsTouched);
      }
      if (StartTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StartTime);
      }
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (BestScore != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BestScore);
      }
      watcherIdList_.WriteTo(output, _repeated_watcherIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsTouched != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsTouched);
      }
      if (StartTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StartTime);
      }
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (BestScore != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BestScore);
      }
      watcherIdList_.WriteTo(ref output, _repeated_watcherIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (IsTouched != false) {
        size += 1 + 1;
      }
      size += watcherIdList_.CalculateSize(_repeated_watcherIdList_codec);
      if (BestScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestScore);
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FlightDailyRecord other) {
      if (other == null) {
        return;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.IsTouched != false) {
        IsTouched = other.IsTouched;
      }
      watcherIdList_.Add(other.watcherIdList_);
      if (other.BestScore != 0) {
        BestScore = other.BestScore;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
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
            IsTouched = input.ReadBool();
            break;
          }
          case 24: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 56: {
            BestScore = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            watcherIdList_.AddEntriesFrom(input, _repeated_watcherIdList_codec);
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
            IsTouched = input.ReadBool();
            break;
          }
          case 24: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 56: {
            BestScore = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            watcherIdList_.AddEntriesFrom(ref input, _repeated_watcherIdList_codec);
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
