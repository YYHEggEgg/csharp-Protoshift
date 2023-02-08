// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabEnterLoopDungeonRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ChannelerSlabEnterLoopDungeonRsp.proto</summary>
  public static partial class ChannelerSlabEnterLoopDungeonRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChannelerSlabEnterLoopDungeonRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelerSlabEnterLoopDungeonRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZDaGFubmVsZXJTbGFiRW50ZXJMb29wRHVuZ2VvblJzcC5wcm90byKOAQog",
            "Q2hhbm5lbGVyU2xhYkVudGVyTG9vcER1bmdlb25Sc3ASDwoHcmV0Y29kZRgJ",
            "IAEoBRIQCghwb2ludF9pZBgMIAEoDRIZChFjb25kaXRpb25faWRfbGlzdBgG",
            "IAMoDRIVCg1kdW5nZW9uX2luZGV4GA8gASgNEhUKDWRpZmZpY3VsdHlfaWQY",
            "AyABKA1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ChannelerSlabEnterLoopDungeonRsp), global::OldProtos.ChannelerSlabEnterLoopDungeonRsp.Parser, new[]{ "Retcode", "PointId", "ConditionIdList", "DungeonIndex", "DifficultyId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8081
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ChannelerSlabEnterLoopDungeonRsp : pb::IMessage<ChannelerSlabEnterLoopDungeonRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelerSlabEnterLoopDungeonRsp> _parser = new pb::MessageParser<ChannelerSlabEnterLoopDungeonRsp>(() => new ChannelerSlabEnterLoopDungeonRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelerSlabEnterLoopDungeonRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ChannelerSlabEnterLoopDungeonRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabEnterLoopDungeonRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabEnterLoopDungeonRsp(ChannelerSlabEnterLoopDungeonRsp other) : this() {
      retcode_ = other.retcode_;
      pointId_ = other.pointId_;
      conditionIdList_ = other.conditionIdList_.Clone();
      dungeonIndex_ = other.dungeonIndex_;
      difficultyId_ = other.difficultyId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabEnterLoopDungeonRsp Clone() {
      return new ChannelerSlabEnterLoopDungeonRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "point_id" field.</summary>
    public const int PointIdFieldNumber = 12;
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
    public const int ConditionIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_conditionIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> conditionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ConditionIdList {
      get { return conditionIdList_; }
    }

    /// <summary>Field number for the "dungeon_index" field.</summary>
    public const int DungeonIndexFieldNumber = 15;
    private uint dungeonIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonIndex {
      get { return dungeonIndex_; }
      set {
        dungeonIndex_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 3;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelerSlabEnterLoopDungeonRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelerSlabEnterLoopDungeonRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (PointId != other.PointId) return false;
      if(!conditionIdList_.Equals(other.conditionIdList_)) return false;
      if (DungeonIndex != other.DungeonIndex) return false;
      if (DifficultyId != other.DifficultyId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (PointId != 0) hash ^= PointId.GetHashCode();
      hash ^= conditionIdList_.GetHashCode();
      if (DungeonIndex != 0) hash ^= DungeonIndex.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
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
      if (DifficultyId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DifficultyId);
      }
      conditionIdList_.WriteTo(output, _repeated_conditionIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (PointId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PointId);
      }
      if (DungeonIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DungeonIndex);
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
      if (DifficultyId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DifficultyId);
      }
      conditionIdList_.WriteTo(ref output, _repeated_conditionIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (PointId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PointId);
      }
      if (DungeonIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DungeonIndex);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (PointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
      }
      size += conditionIdList_.CalculateSize(_repeated_conditionIdList_codec);
      if (DungeonIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonIndex);
      }
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelerSlabEnterLoopDungeonRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.PointId != 0) {
        PointId = other.PointId;
      }
      conditionIdList_.Add(other.conditionIdList_);
      if (other.DungeonIndex != 0) {
        DungeonIndex = other.DungeonIndex;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
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
          case 24: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            conditionIdList_.AddEntriesFrom(input, _repeated_conditionIdList_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            PointId = input.ReadUInt32();
            break;
          }
          case 120: {
            DungeonIndex = input.ReadUInt32();
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
          case 24: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            conditionIdList_.AddEntriesFrom(ref input, _repeated_conditionIdList_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            PointId = input.ReadUInt32();
            break;
          }
          case 120: {
            DungeonIndex = input.ReadUInt32();
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
