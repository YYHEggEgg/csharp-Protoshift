// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessEntranceInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ChessEntranceInfo.proto</summary>
public static partial class ChessEntranceInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for ChessEntranceInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ChessEntranceInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdDaGVzc0VudHJhbmNlSW5mby5wcm90bxoWQ2hlc3NNb25zdGVySW5mby5w",
          "cm90byJ0ChFDaGVzc0VudHJhbmNlSW5mbxIsChFtb25zdGVyX2luZm9fbGlz",
          "dBgPIAMoCzIRLkNoZXNzTW9uc3RlckluZm8SFgoOZW50cmFuY2VfaW5kZXgY",
          "CSABKA0SGQoRZW50cmFuY2VfcG9pbnRfaWQYDCABKA1CFgoUb3JnLnNvcmFw",
          "b2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ChessMonsterInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ChessEntranceInfo), global::ChessEntranceInfo.Parser, new[]{ "MonsterInfoList", "EntranceIndex", "EntrancePointId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ChessEntranceInfo : pb::IMessage<ChessEntranceInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ChessEntranceInfo> _parser = new pb::MessageParser<ChessEntranceInfo>(() => new ChessEntranceInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ChessEntranceInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ChessEntranceInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChessEntranceInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChessEntranceInfo(ChessEntranceInfo other) : this() {
    monsterInfoList_ = other.monsterInfoList_.Clone();
    entranceIndex_ = other.entranceIndex_;
    entrancePointId_ = other.entrancePointId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChessEntranceInfo Clone() {
    return new ChessEntranceInfo(this);
  }

  /// <summary>Field number for the "monster_info_list" field.</summary>
  public const int MonsterInfoListFieldNumber = 15;
  private static readonly pb::FieldCodec<global::ChessMonsterInfo> _repeated_monsterInfoList_codec
      = pb::FieldCodec.ForMessage(122, global::ChessMonsterInfo.Parser);
  private readonly pbc::RepeatedField<global::ChessMonsterInfo> monsterInfoList_ = new pbc::RepeatedField<global::ChessMonsterInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ChessMonsterInfo> MonsterInfoList {
    get { return monsterInfoList_; }
  }

  /// <summary>Field number for the "entrance_index" field.</summary>
  public const int EntranceIndexFieldNumber = 9;
  private uint entranceIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntranceIndex {
    get { return entranceIndex_; }
    set {
      entranceIndex_ = value;
    }
  }

  /// <summary>Field number for the "entrance_point_id" field.</summary>
  public const int EntrancePointIdFieldNumber = 12;
  private uint entrancePointId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntrancePointId {
    get { return entrancePointId_; }
    set {
      entrancePointId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ChessEntranceInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ChessEntranceInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!monsterInfoList_.Equals(other.monsterInfoList_)) return false;
    if (EntranceIndex != other.EntranceIndex) return false;
    if (EntrancePointId != other.EntrancePointId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= monsterInfoList_.GetHashCode();
    if (EntranceIndex != 0) hash ^= EntranceIndex.GetHashCode();
    if (EntrancePointId != 0) hash ^= EntrancePointId.GetHashCode();
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
    if (EntranceIndex != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(EntranceIndex);
    }
    if (EntrancePointId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(EntrancePointId);
    }
    monsterInfoList_.WriteTo(output, _repeated_monsterInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (EntranceIndex != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(EntranceIndex);
    }
    if (EntrancePointId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(EntrancePointId);
    }
    monsterInfoList_.WriteTo(ref output, _repeated_monsterInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += monsterInfoList_.CalculateSize(_repeated_monsterInfoList_codec);
    if (EntranceIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntranceIndex);
    }
    if (EntrancePointId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntrancePointId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ChessEntranceInfo other) {
    if (other == null) {
      return;
    }
    monsterInfoList_.Add(other.monsterInfoList_);
    if (other.EntranceIndex != 0) {
      EntranceIndex = other.EntranceIndex;
    }
    if (other.EntrancePointId != 0) {
      EntrancePointId = other.EntrancePointId;
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
        case 72: {
          EntranceIndex = input.ReadUInt32();
          break;
        }
        case 96: {
          EntrancePointId = input.ReadUInt32();
          break;
        }
        case 122: {
          monsterInfoList_.AddEntriesFrom(input, _repeated_monsterInfoList_codec);
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
        case 72: {
          EntranceIndex = input.ReadUInt32();
          break;
        }
        case 96: {
          EntrancePointId = input.ReadUInt32();
          break;
        }
        case 122: {
          monsterInfoList_.AddEntriesFrom(ref input, _repeated_monsterInfoList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
