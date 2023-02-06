// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessEntranceInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IrodoriChessEntranceInfo.proto</summary>
public static partial class IrodoriChessEntranceInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for IrodoriChessEntranceInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IrodoriChessEntranceInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5Jcm9kb3JpQ2hlc3NFbnRyYW5jZUluZm8ucHJvdG8aHUlyb2RvcmlDaGVz",
          "c01vbnN0ZXJJbmZvLnByb3RvImoKGElyb2RvcmlDaGVzc0VudHJhbmNlSW5m",
          "bxIzChFtb25zdGVyX2luZm9fbGlzdBgGIAMoCzIYLklyb2RvcmlDaGVzc01v",
          "bnN0ZXJJbmZvEhkKEWVudHJhbmNlX3BvaW50X2lkGAQgASgNQh4KHGVtdS5n",
          "cmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::IrodoriChessMonsterInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IrodoriChessEntranceInfo), global::IrodoriChessEntranceInfo.Parser, new[]{ "MonsterInfoList", "EntrancePointId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class IrodoriChessEntranceInfo : pb::IMessage<IrodoriChessEntranceInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IrodoriChessEntranceInfo> _parser = new pb::MessageParser<IrodoriChessEntranceInfo>(() => new IrodoriChessEntranceInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IrodoriChessEntranceInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IrodoriChessEntranceInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessEntranceInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessEntranceInfo(IrodoriChessEntranceInfo other) : this() {
    monsterInfoList_ = other.monsterInfoList_.Clone();
    entrancePointId_ = other.entrancePointId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessEntranceInfo Clone() {
    return new IrodoriChessEntranceInfo(this);
  }

  /// <summary>Field number for the "monster_info_list" field.</summary>
  public const int MonsterInfoListFieldNumber = 6;
  private static readonly pb::FieldCodec<global::IrodoriChessMonsterInfo> _repeated_monsterInfoList_codec
      = pb::FieldCodec.ForMessage(50, global::IrodoriChessMonsterInfo.Parser);
  private readonly pbc::RepeatedField<global::IrodoriChessMonsterInfo> monsterInfoList_ = new pbc::RepeatedField<global::IrodoriChessMonsterInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::IrodoriChessMonsterInfo> MonsterInfoList {
    get { return monsterInfoList_; }
  }

  /// <summary>Field number for the "entrance_point_id" field.</summary>
  public const int EntrancePointIdFieldNumber = 4;
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
    return Equals(other as IrodoriChessEntranceInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IrodoriChessEntranceInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!monsterInfoList_.Equals(other.monsterInfoList_)) return false;
    if (EntrancePointId != other.EntrancePointId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= monsterInfoList_.GetHashCode();
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
    if (EntrancePointId != 0) {
      output.WriteRawTag(32);
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
    if (EntrancePointId != 0) {
      output.WriteRawTag(32);
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
  public void MergeFrom(IrodoriChessEntranceInfo other) {
    if (other == null) {
      return;
    }
    monsterInfoList_.Add(other.monsterInfoList_);
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
        case 32: {
          EntrancePointId = input.ReadUInt32();
          break;
        }
        case 50: {
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
        case 32: {
          EntrancePointId = input.ReadUInt32();
          break;
        }
        case 50: {
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