// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassAllDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from BattlePassAllDataNotify.proto</summary>
  public static partial class BattlePassAllDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassAllDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassAllDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1CYXR0bGVQYXNzQWxsRGF0YU5vdGlmeS5wcm90bxoXQmF0dGxlUGFzc01p",
            "c3Npb24ucHJvdG8aGEJhdHRsZVBhc3NTY2hlZHVsZS5wcm90byKJAQoXQmF0",
            "dGxlUGFzc0FsbERhdGFOb3RpZnkSGQoRaGF2ZV9jdXJfc2NoZWR1bGUYAiAB",
            "KAgSKAoMbWlzc2lvbl9saXN0GAQgAygLMhIuQmF0dGxlUGFzc01pc3Npb24S",
            "KQoMY3VyX3NjaGVkdWxlGAEgASgLMhMuQmF0dGxlUGFzc1NjaGVkdWxlQgyq",
            "AglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.BattlePassMissionReflection.Descriptor, global::OldProtos.BattlePassScheduleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.BattlePassAllDataNotify), global::OldProtos.BattlePassAllDataNotify.Parser, new[]{ "HaveCurSchedule", "MissionList", "CurSchedule" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2626
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class BattlePassAllDataNotify : pb::IMessage<BattlePassAllDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassAllDataNotify> _parser = new pb::MessageParser<BattlePassAllDataNotify>(() => new BattlePassAllDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassAllDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.BattlePassAllDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassAllDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassAllDataNotify(BattlePassAllDataNotify other) : this() {
      haveCurSchedule_ = other.haveCurSchedule_;
      missionList_ = other.missionList_.Clone();
      curSchedule_ = other.curSchedule_ != null ? other.curSchedule_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassAllDataNotify Clone() {
      return new BattlePassAllDataNotify(this);
    }

    /// <summary>Field number for the "have_cur_schedule" field.</summary>
    public const int HaveCurScheduleFieldNumber = 2;
    private bool haveCurSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HaveCurSchedule {
      get { return haveCurSchedule_; }
      set {
        haveCurSchedule_ = value;
      }
    }

    /// <summary>Field number for the "mission_list" field.</summary>
    public const int MissionListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::OldProtos.BattlePassMission> _repeated_missionList_codec
        = pb::FieldCodec.ForMessage(34, global::OldProtos.BattlePassMission.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.BattlePassMission> missionList_ = new pbc::RepeatedField<global::OldProtos.BattlePassMission>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.BattlePassMission> MissionList {
      get { return missionList_; }
    }

    /// <summary>Field number for the "cur_schedule" field.</summary>
    public const int CurScheduleFieldNumber = 1;
    private global::OldProtos.BattlePassSchedule curSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.BattlePassSchedule CurSchedule {
      get { return curSchedule_; }
      set {
        curSchedule_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassAllDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassAllDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HaveCurSchedule != other.HaveCurSchedule) return false;
      if(!missionList_.Equals(other.missionList_)) return false;
      if (!object.Equals(CurSchedule, other.CurSchedule)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HaveCurSchedule != false) hash ^= HaveCurSchedule.GetHashCode();
      hash ^= missionList_.GetHashCode();
      if (curSchedule_ != null) hash ^= CurSchedule.GetHashCode();
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
      if (curSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CurSchedule);
      }
      if (HaveCurSchedule != false) {
        output.WriteRawTag(16);
        output.WriteBool(HaveCurSchedule);
      }
      missionList_.WriteTo(output, _repeated_missionList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (curSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CurSchedule);
      }
      if (HaveCurSchedule != false) {
        output.WriteRawTag(16);
        output.WriteBool(HaveCurSchedule);
      }
      missionList_.WriteTo(ref output, _repeated_missionList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HaveCurSchedule != false) {
        size += 1 + 1;
      }
      size += missionList_.CalculateSize(_repeated_missionList_codec);
      if (curSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurSchedule);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassAllDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.HaveCurSchedule != false) {
        HaveCurSchedule = other.HaveCurSchedule;
      }
      missionList_.Add(other.missionList_);
      if (other.curSchedule_ != null) {
        if (curSchedule_ == null) {
          CurSchedule = new global::OldProtos.BattlePassSchedule();
        }
        CurSchedule.MergeFrom(other.CurSchedule);
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
          case 10: {
            if (curSchedule_ == null) {
              CurSchedule = new global::OldProtos.BattlePassSchedule();
            }
            input.ReadMessage(CurSchedule);
            break;
          }
          case 16: {
            HaveCurSchedule = input.ReadBool();
            break;
          }
          case 34: {
            missionList_.AddEntriesFrom(input, _repeated_missionList_codec);
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
          case 10: {
            if (curSchedule_ == null) {
              CurSchedule = new global::OldProtos.BattlePassSchedule();
            }
            input.ReadMessage(CurSchedule);
            break;
          }
          case 16: {
            HaveCurSchedule = input.ReadBool();
            break;
          }
          case 34: {
            missionList_.AddEntriesFrom(ref input, _repeated_missionList_codec);
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
