// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerCurLevelRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TowerCurLevelRecord.proto</summary>
public static partial class TowerCurLevelRecordReflection {

  #region Descriptor
  /// <summary>File descriptor for TowerCurLevelRecord.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TowerCurLevelRecordReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlUb3dlckN1ckxldmVsUmVjb3JkLnByb3RvGg9Ub3dlclRlYW0ucHJvdG8i",
          "qAEKE1Rvd2VyQ3VyTGV2ZWxSZWNvcmQSFAoMYnVmZl9pZF9saXN0GA4gAygN",
          "EhUKDWlzX3VwcGVyX3BhcnQYBCABKAgSFwoPY3VyX2xldmVsX2luZGV4GAYg",
          "ASgNEhAKCGlzX2VtcHR5GAEgASgIEiMKD3Rvd2VyX3RlYW1fbGlzdBgIIAMo",
          "CzIKLlRvd2VyVGVhbRIUCgxjdXJfZmxvb3JfaWQYCSABKA1CFgoUb3JnLnNv",
          "cmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::TowerTeamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TowerCurLevelRecord), global::TowerCurLevelRecord.Parser, new[]{ "BuffIdList", "IsUpperPart", "CurLevelIndex", "IsEmpty", "TowerTeamList", "CurFloorId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TowerCurLevelRecord : pb::IMessage<TowerCurLevelRecord>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TowerCurLevelRecord> _parser = new pb::MessageParser<TowerCurLevelRecord>(() => new TowerCurLevelRecord());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TowerCurLevelRecord> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TowerCurLevelRecordReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TowerCurLevelRecord() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TowerCurLevelRecord(TowerCurLevelRecord other) : this() {
    buffIdList_ = other.buffIdList_.Clone();
    isUpperPart_ = other.isUpperPart_;
    curLevelIndex_ = other.curLevelIndex_;
    isEmpty_ = other.isEmpty_;
    towerTeamList_ = other.towerTeamList_.Clone();
    curFloorId_ = other.curFloorId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TowerCurLevelRecord Clone() {
    return new TowerCurLevelRecord(this);
  }

  /// <summary>Field number for the "buff_id_list" field.</summary>
  public const int BuffIdListFieldNumber = 14;
  private static readonly pb::FieldCodec<uint> _repeated_buffIdList_codec
      = pb::FieldCodec.ForUInt32(114);
  private readonly pbc::RepeatedField<uint> buffIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> BuffIdList {
    get { return buffIdList_; }
  }

  /// <summary>Field number for the "is_upper_part" field.</summary>
  public const int IsUpperPartFieldNumber = 4;
  private bool isUpperPart_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsUpperPart {
    get { return isUpperPart_; }
    set {
      isUpperPart_ = value;
    }
  }

  /// <summary>Field number for the "cur_level_index" field.</summary>
  public const int CurLevelIndexFieldNumber = 6;
  private uint curLevelIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurLevelIndex {
    get { return curLevelIndex_; }
    set {
      curLevelIndex_ = value;
    }
  }

  /// <summary>Field number for the "is_empty" field.</summary>
  public const int IsEmptyFieldNumber = 1;
  private bool isEmpty_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsEmpty {
    get { return isEmpty_; }
    set {
      isEmpty_ = value;
    }
  }

  /// <summary>Field number for the "tower_team_list" field.</summary>
  public const int TowerTeamListFieldNumber = 8;
  private static readonly pb::FieldCodec<global::TowerTeam> _repeated_towerTeamList_codec
      = pb::FieldCodec.ForMessage(66, global::TowerTeam.Parser);
  private readonly pbc::RepeatedField<global::TowerTeam> towerTeamList_ = new pbc::RepeatedField<global::TowerTeam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::TowerTeam> TowerTeamList {
    get { return towerTeamList_; }
  }

  /// <summary>Field number for the "cur_floor_id" field.</summary>
  public const int CurFloorIdFieldNumber = 9;
  private uint curFloorId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurFloorId {
    get { return curFloorId_; }
    set {
      curFloorId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TowerCurLevelRecord);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TowerCurLevelRecord other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!buffIdList_.Equals(other.buffIdList_)) return false;
    if (IsUpperPart != other.IsUpperPart) return false;
    if (CurLevelIndex != other.CurLevelIndex) return false;
    if (IsEmpty != other.IsEmpty) return false;
    if(!towerTeamList_.Equals(other.towerTeamList_)) return false;
    if (CurFloorId != other.CurFloorId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= buffIdList_.GetHashCode();
    if (IsUpperPart != false) hash ^= IsUpperPart.GetHashCode();
    if (CurLevelIndex != 0) hash ^= CurLevelIndex.GetHashCode();
    if (IsEmpty != false) hash ^= IsEmpty.GetHashCode();
    hash ^= towerTeamList_.GetHashCode();
    if (CurFloorId != 0) hash ^= CurFloorId.GetHashCode();
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
    if (IsEmpty != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsEmpty);
    }
    if (IsUpperPart != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsUpperPart);
    }
    if (CurLevelIndex != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(CurLevelIndex);
    }
    towerTeamList_.WriteTo(output, _repeated_towerTeamList_codec);
    if (CurFloorId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(CurFloorId);
    }
    buffIdList_.WriteTo(output, _repeated_buffIdList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (IsEmpty != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsEmpty);
    }
    if (IsUpperPart != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsUpperPart);
    }
    if (CurLevelIndex != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(CurLevelIndex);
    }
    towerTeamList_.WriteTo(ref output, _repeated_towerTeamList_codec);
    if (CurFloorId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(CurFloorId);
    }
    buffIdList_.WriteTo(ref output, _repeated_buffIdList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += buffIdList_.CalculateSize(_repeated_buffIdList_codec);
    if (IsUpperPart != false) {
      size += 1 + 1;
    }
    if (CurLevelIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevelIndex);
    }
    if (IsEmpty != false) {
      size += 1 + 1;
    }
    size += towerTeamList_.CalculateSize(_repeated_towerTeamList_codec);
    if (CurFloorId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurFloorId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TowerCurLevelRecord other) {
    if (other == null) {
      return;
    }
    buffIdList_.Add(other.buffIdList_);
    if (other.IsUpperPart != false) {
      IsUpperPart = other.IsUpperPart;
    }
    if (other.CurLevelIndex != 0) {
      CurLevelIndex = other.CurLevelIndex;
    }
    if (other.IsEmpty != false) {
      IsEmpty = other.IsEmpty;
    }
    towerTeamList_.Add(other.towerTeamList_);
    if (other.CurFloorId != 0) {
      CurFloorId = other.CurFloorId;
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
          IsEmpty = input.ReadBool();
          break;
        }
        case 32: {
          IsUpperPart = input.ReadBool();
          break;
        }
        case 48: {
          CurLevelIndex = input.ReadUInt32();
          break;
        }
        case 66: {
          towerTeamList_.AddEntriesFrom(input, _repeated_towerTeamList_codec);
          break;
        }
        case 72: {
          CurFloorId = input.ReadUInt32();
          break;
        }
        case 114:
        case 112: {
          buffIdList_.AddEntriesFrom(input, _repeated_buffIdList_codec);
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
          IsEmpty = input.ReadBool();
          break;
        }
        case 32: {
          IsUpperPart = input.ReadBool();
          break;
        }
        case 48: {
          CurLevelIndex = input.ReadUInt32();
          break;
        }
        case 66: {
          towerTeamList_.AddEntriesFrom(ref input, _repeated_towerTeamList_codec);
          break;
        }
        case 72: {
          CurFloorId = input.ReadUInt32();
          break;
        }
        case 114:
        case 112: {
          buffIdList_.AddEntriesFrom(ref input, _repeated_buffIdList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code