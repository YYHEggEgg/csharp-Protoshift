// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReliquaryPromoteRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ReliquaryPromoteRsp.proto</summary>
public static partial class ReliquaryPromoteRspReflection {

  #region Descriptor
  /// <summary>File descriptor for ReliquaryPromoteRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReliquaryPromoteRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlSZWxpcXVhcnlQcm9tb3RlUnNwLnByb3RvIrcBChNSZWxpcXVhcnlQcm9t",
          "b3RlUnNwEhwKFG9sZF9hcHBlbmRfcHJvcF9saXN0GAggAygNEhkKEW9sZF9w",
          "cm9tb3RlX2xldmVsGAkgASgNEhwKFGN1cl9hcHBlbmRfcHJvcF9saXN0GA0g",
          "AygNEg8KB3JldGNvZGUYCiABKAUSHQoVdGFyZ2V0X3JlbGlxdWFyeV9ndWlk",
          "GAYgASgEEhkKEWN1cl9wcm9tb3RlX2xldmVsGAQgASgNQhYKFG9yZy5zb3Jh",
          "cG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReliquaryPromoteRsp), global::ReliquaryPromoteRsp.Parser, new[]{ "OldAppendPropList", "OldPromoteLevel", "CurAppendPropList", "Retcode", "TargetReliquaryGuid", "CurPromoteLevel" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 605;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class ReliquaryPromoteRsp : pb::IMessage<ReliquaryPromoteRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReliquaryPromoteRsp> _parser = new pb::MessageParser<ReliquaryPromoteRsp>(() => new ReliquaryPromoteRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ReliquaryPromoteRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReliquaryPromoteRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryPromoteRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryPromoteRsp(ReliquaryPromoteRsp other) : this() {
    oldAppendPropList_ = other.oldAppendPropList_.Clone();
    oldPromoteLevel_ = other.oldPromoteLevel_;
    curAppendPropList_ = other.curAppendPropList_.Clone();
    retcode_ = other.retcode_;
    targetReliquaryGuid_ = other.targetReliquaryGuid_;
    curPromoteLevel_ = other.curPromoteLevel_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryPromoteRsp Clone() {
    return new ReliquaryPromoteRsp(this);
  }

  /// <summary>Field number for the "old_append_prop_list" field.</summary>
  public const int OldAppendPropListFieldNumber = 8;
  private static readonly pb::FieldCodec<uint> _repeated_oldAppendPropList_codec
      = pb::FieldCodec.ForUInt32(66);
  private readonly pbc::RepeatedField<uint> oldAppendPropList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> OldAppendPropList {
    get { return oldAppendPropList_; }
  }

  /// <summary>Field number for the "old_promote_level" field.</summary>
  public const int OldPromoteLevelFieldNumber = 9;
  private uint oldPromoteLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OldPromoteLevel {
    get { return oldPromoteLevel_; }
    set {
      oldPromoteLevel_ = value;
    }
  }

  /// <summary>Field number for the "cur_append_prop_list" field.</summary>
  public const int CurAppendPropListFieldNumber = 13;
  private static readonly pb::FieldCodec<uint> _repeated_curAppendPropList_codec
      = pb::FieldCodec.ForUInt32(106);
  private readonly pbc::RepeatedField<uint> curAppendPropList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> CurAppendPropList {
    get { return curAppendPropList_; }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 10;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "target_reliquary_guid" field.</summary>
  public const int TargetReliquaryGuidFieldNumber = 6;
  private ulong targetReliquaryGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong TargetReliquaryGuid {
    get { return targetReliquaryGuid_; }
    set {
      targetReliquaryGuid_ = value;
    }
  }

  /// <summary>Field number for the "cur_promote_level" field.</summary>
  public const int CurPromoteLevelFieldNumber = 4;
  private uint curPromoteLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurPromoteLevel {
    get { return curPromoteLevel_; }
    set {
      curPromoteLevel_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ReliquaryPromoteRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ReliquaryPromoteRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!oldAppendPropList_.Equals(other.oldAppendPropList_)) return false;
    if (OldPromoteLevel != other.OldPromoteLevel) return false;
    if(!curAppendPropList_.Equals(other.curAppendPropList_)) return false;
    if (Retcode != other.Retcode) return false;
    if (TargetReliquaryGuid != other.TargetReliquaryGuid) return false;
    if (CurPromoteLevel != other.CurPromoteLevel) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= oldAppendPropList_.GetHashCode();
    if (OldPromoteLevel != 0) hash ^= OldPromoteLevel.GetHashCode();
    hash ^= curAppendPropList_.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (TargetReliquaryGuid != 0UL) hash ^= TargetReliquaryGuid.GetHashCode();
    if (CurPromoteLevel != 0) hash ^= CurPromoteLevel.GetHashCode();
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
    if (CurPromoteLevel != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CurPromoteLevel);
    }
    if (TargetReliquaryGuid != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(TargetReliquaryGuid);
    }
    oldAppendPropList_.WriteTo(output, _repeated_oldAppendPropList_codec);
    if (OldPromoteLevel != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(OldPromoteLevel);
    }
    if (Retcode != 0) {
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
    }
    curAppendPropList_.WriteTo(output, _repeated_curAppendPropList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (CurPromoteLevel != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CurPromoteLevel);
    }
    if (TargetReliquaryGuid != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(TargetReliquaryGuid);
    }
    oldAppendPropList_.WriteTo(ref output, _repeated_oldAppendPropList_codec);
    if (OldPromoteLevel != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(OldPromoteLevel);
    }
    if (Retcode != 0) {
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
    }
    curAppendPropList_.WriteTo(ref output, _repeated_curAppendPropList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += oldAppendPropList_.CalculateSize(_repeated_oldAppendPropList_codec);
    if (OldPromoteLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldPromoteLevel);
    }
    size += curAppendPropList_.CalculateSize(_repeated_curAppendPropList_codec);
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (TargetReliquaryGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetReliquaryGuid);
    }
    if (CurPromoteLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurPromoteLevel);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ReliquaryPromoteRsp other) {
    if (other == null) {
      return;
    }
    oldAppendPropList_.Add(other.oldAppendPropList_);
    if (other.OldPromoteLevel != 0) {
      OldPromoteLevel = other.OldPromoteLevel;
    }
    curAppendPropList_.Add(other.curAppendPropList_);
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.TargetReliquaryGuid != 0UL) {
      TargetReliquaryGuid = other.TargetReliquaryGuid;
    }
    if (other.CurPromoteLevel != 0) {
      CurPromoteLevel = other.CurPromoteLevel;
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
          CurPromoteLevel = input.ReadUInt32();
          break;
        }
        case 48: {
          TargetReliquaryGuid = input.ReadUInt64();
          break;
        }
        case 66:
        case 64: {
          oldAppendPropList_.AddEntriesFrom(input, _repeated_oldAppendPropList_codec);
          break;
        }
        case 72: {
          OldPromoteLevel = input.ReadUInt32();
          break;
        }
        case 80: {
          Retcode = input.ReadInt32();
          break;
        }
        case 106:
        case 104: {
          curAppendPropList_.AddEntriesFrom(input, _repeated_curAppendPropList_codec);
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
          CurPromoteLevel = input.ReadUInt32();
          break;
        }
        case 48: {
          TargetReliquaryGuid = input.ReadUInt64();
          break;
        }
        case 66:
        case 64: {
          oldAppendPropList_.AddEntriesFrom(ref input, _repeated_oldAppendPropList_codec);
          break;
        }
        case 72: {
          OldPromoteLevel = input.ReadUInt32();
          break;
        }
        case 80: {
          Retcode = input.ReadInt32();
          break;
        }
        case 106:
        case 104: {
          curAppendPropList_.AddEntriesFrom(ref input, _repeated_curAppendPropList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
