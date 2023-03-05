// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoSelectTeamAndEnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SumoSelectTeamAndEnterDungeonReq.proto</summary>
  public static partial class SumoSelectTeamAndEnterDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SumoSelectTeamAndEnterDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SumoSelectTeamAndEnterDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZTdW1vU2VsZWN0VGVhbUFuZEVudGVyRHVuZ2VvblJlcS5wcm90bxoSU3Vt",
            "b1RlYW1EYXRhLnByb3RvIoIBCiBTdW1vU2VsZWN0VGVhbUFuZEVudGVyRHVu",
            "Z2VvblJlcRIgCgl0ZWFtX2xpc3QYDyADKAsyDS5TdW1vVGVhbURhdGESEwoL",
            "YWN0aXZpdHlfaWQYASABKA0SFQoNZGlmZmljdWx0eV9pZBgFIAEoDRIQCghz",
            "dGFnZV9pZBgHIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.SumoTeamDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SumoSelectTeamAndEnterDungeonReq), global::NewProtos.SumoSelectTeamAndEnterDungeonReq.Parser, new[]{ "TeamList", "ActivityId", "DifficultyId", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8978;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class SumoSelectTeamAndEnterDungeonReq : pb::IMessage<SumoSelectTeamAndEnterDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SumoSelectTeamAndEnterDungeonReq> _parser = new pb::MessageParser<SumoSelectTeamAndEnterDungeonReq>(() => new SumoSelectTeamAndEnterDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SumoSelectTeamAndEnterDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SumoSelectTeamAndEnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSelectTeamAndEnterDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSelectTeamAndEnterDungeonReq(SumoSelectTeamAndEnterDungeonReq other) : this() {
      teamList_ = other.teamList_.Clone();
      activityId_ = other.activityId_;
      difficultyId_ = other.difficultyId_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoSelectTeamAndEnterDungeonReq Clone() {
      return new SumoSelectTeamAndEnterDungeonReq(this);
    }

    /// <summary>Field number for the "team_list" field.</summary>
    public const int TeamListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::NewProtos.SumoTeamData> _repeated_teamList_codec
        = pb::FieldCodec.ForMessage(122, global::NewProtos.SumoTeamData.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.SumoTeamData> teamList_ = new pbc::RepeatedField<global::NewProtos.SumoTeamData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.SumoTeamData> TeamList {
      get { return teamList_; }
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 1;
    private uint activityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityId {
      get { return activityId_; }
      set {
        activityId_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 5;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 7;
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
      return Equals(other as SumoSelectTeamAndEnterDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SumoSelectTeamAndEnterDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!teamList_.Equals(other.teamList_)) return false;
      if (ActivityId != other.ActivityId) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= teamList_.GetHashCode();
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
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
      if (ActivityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ActivityId);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DifficultyId);
      }
      if (StageId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageId);
      }
      teamList_.WriteTo(output, _repeated_teamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ActivityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ActivityId);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DifficultyId);
      }
      if (StageId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageId);
      }
      teamList_.WriteTo(ref output, _repeated_teamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += teamList_.CalculateSize(_repeated_teamList_codec);
      if (ActivityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
      }
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
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
    public void MergeFrom(SumoSelectTeamAndEnterDungeonReq other) {
      if (other == null) {
        return;
      }
      teamList_.Add(other.teamList_);
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
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
          case 8: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 40: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 56: {
            StageId = input.ReadUInt32();
            break;
          }
          case 122: {
            teamList_.AddEntriesFrom(input, _repeated_teamList_codec);
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
            ActivityId = input.ReadUInt32();
            break;
          }
          case 40: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 56: {
            StageId = input.ReadUInt32();
            break;
          }
          case 122: {
            teamList_.AddEntriesFrom(ref input, _repeated_teamList_codec);
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