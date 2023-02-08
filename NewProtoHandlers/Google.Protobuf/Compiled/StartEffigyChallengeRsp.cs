// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartEffigyChallengeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from StartEffigyChallengeRsp.proto</summary>
  public static partial class StartEffigyChallengeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartEffigyChallengeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartEffigyChallengeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TdGFydEVmZmlneUNoYWxsZW5nZVJzcC5wcm90byKEAQoXU3RhcnRFZmZp",
            "Z3lDaGFsbGVuZ2VSc3ASEAoIcG9pbnRfaWQYBCABKA0SGQoRY29uZGl0aW9u",
            "X2lkX2xpc3QYCSADKA0SFQoNZGlmZmljdWx0eV9pZBgMIAEoDRIPCgdyZXRj",
            "b2RlGAUgASgFEhQKDGNoYWxsZW5nZV9pZBgKIAEoDUIMqgIJTmV3UHJvdG9z",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.StartEffigyChallengeRsp), global::NewProtos.StartEffigyChallengeRsp.Parser, new[]{ "PointId", "ConditionIdList", "DifficultyId", "Retcode", "ChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2169;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class StartEffigyChallengeRsp : pb::IMessage<StartEffigyChallengeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartEffigyChallengeRsp> _parser = new pb::MessageParser<StartEffigyChallengeRsp>(() => new StartEffigyChallengeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartEffigyChallengeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.StartEffigyChallengeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartEffigyChallengeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartEffigyChallengeRsp(StartEffigyChallengeRsp other) : this() {
      pointId_ = other.pointId_;
      conditionIdList_ = other.conditionIdList_.Clone();
      difficultyId_ = other.difficultyId_;
      retcode_ = other.retcode_;
      challengeId_ = other.challengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartEffigyChallengeRsp Clone() {
      return new StartEffigyChallengeRsp(this);
    }

    /// <summary>Field number for the "point_id" field.</summary>
    public const int PointIdFieldNumber = 4;
    private uint pointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointId {
      get { return pointId_; }
      set {
        pointId_ = value;
      }
    }

    /// <summary>Field number for the "condition_id_list" field.</summary>
    public const int ConditionIdListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_conditionIdList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> conditionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ConditionIdList {
      get { return conditionIdList_; }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 12;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 10;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartEffigyChallengeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartEffigyChallengeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PointId != other.PointId) return false;
      if(!conditionIdList_.Equals(other.conditionIdList_)) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if (Retcode != other.Retcode) return false;
      if (ChallengeId != other.ChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PointId != 0) hash ^= PointId.GetHashCode();
      hash ^= conditionIdList_.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
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
      if (PointId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PointId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      conditionIdList_.WriteTo(output, _repeated_conditionIdList_codec);
      if (ChallengeId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeId);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DifficultyId);
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
      if (PointId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PointId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      conditionIdList_.WriteTo(ref output, _repeated_conditionIdList_codec);
      if (ChallengeId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeId);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DifficultyId);
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
      if (PointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
      }
      size += conditionIdList_.CalculateSize(_repeated_conditionIdList_codec);
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartEffigyChallengeRsp other) {
      if (other == null) {
        return;
      }
      if (other.PointId != 0) {
        PointId = other.PointId;
      }
      conditionIdList_.Add(other.conditionIdList_);
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
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
          case 32: {
            PointId = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74:
          case 72: {
            conditionIdList_.AddEntriesFrom(input, _repeated_conditionIdList_codec);
            break;
          }
          case 80: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            DifficultyId = input.ReadUInt32();
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
          case 32: {
            PointId = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74:
          case 72: {
            conditionIdList_.AddEntriesFrom(ref input, _repeated_conditionIdList_codec);
            break;
          }
          case 80: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            DifficultyId = input.ReadUInt32();
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
