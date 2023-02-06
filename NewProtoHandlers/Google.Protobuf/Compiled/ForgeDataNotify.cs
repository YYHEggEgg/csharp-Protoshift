// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForgeDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ForgeDataNotify.proto</summary>
public static partial class ForgeDataNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ForgeDataNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ForgeDataNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVGb3JnZURhdGFOb3RpZnkucHJvdG8aFEZvcmdlUXVldWVEYXRhLnByb3Rv",
          "IsQBCg9Gb3JnZURhdGFOb3RpZnkSFQoNZm9yZ2VfaWRfbGlzdBgNIAMoDRI8",
          "Cg9mb3JnZV9xdWV1ZV9tYXAYCCADKAsyIy5Gb3JnZURhdGFOb3RpZnkuRm9y",
          "Z2VRdWV1ZU1hcEVudHJ5EhUKDW1heF9xdWV1ZV9udW0YCyABKA0aRQoSRm9y",
          "Z2VRdWV1ZU1hcEVudHJ5EgsKA2tleRgBIAEoDRIeCgV2YWx1ZRgCIAEoCzIP",
          "LkZvcmdlUXVldWVEYXRhOgI4AUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ForgeQueueDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ForgeDataNotify), global::ForgeDataNotify.Parser, new[]{ "ForgeIdList", "ForgeQueueMap", "MaxQueueNum" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 674;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class ForgeDataNotify : pb::IMessage<ForgeDataNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ForgeDataNotify> _parser = new pb::MessageParser<ForgeDataNotify>(() => new ForgeDataNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ForgeDataNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ForgeDataNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ForgeDataNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ForgeDataNotify(ForgeDataNotify other) : this() {
    forgeIdList_ = other.forgeIdList_.Clone();
    forgeQueueMap_ = other.forgeQueueMap_.Clone();
    maxQueueNum_ = other.maxQueueNum_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ForgeDataNotify Clone() {
    return new ForgeDataNotify(this);
  }

  /// <summary>Field number for the "forge_id_list" field.</summary>
  public const int ForgeIdListFieldNumber = 13;
  private static readonly pb::FieldCodec<uint> _repeated_forgeIdList_codec
      = pb::FieldCodec.ForUInt32(106);
  private readonly pbc::RepeatedField<uint> forgeIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ForgeIdList {
    get { return forgeIdList_; }
  }

  /// <summary>Field number for the "forge_queue_map" field.</summary>
  public const int ForgeQueueMapFieldNumber = 8;
  private static readonly pbc::MapField<uint, global::ForgeQueueData>.Codec _map_forgeQueueMap_codec
      = new pbc::MapField<uint, global::ForgeQueueData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::ForgeQueueData.Parser), 66);
  private readonly pbc::MapField<uint, global::ForgeQueueData> forgeQueueMap_ = new pbc::MapField<uint, global::ForgeQueueData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::ForgeQueueData> ForgeQueueMap {
    get { return forgeQueueMap_; }
  }

  /// <summary>Field number for the "max_queue_num" field.</summary>
  public const int MaxQueueNumFieldNumber = 11;
  private uint maxQueueNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MaxQueueNum {
    get { return maxQueueNum_; }
    set {
      maxQueueNum_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ForgeDataNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ForgeDataNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!forgeIdList_.Equals(other.forgeIdList_)) return false;
    if (!ForgeQueueMap.Equals(other.ForgeQueueMap)) return false;
    if (MaxQueueNum != other.MaxQueueNum) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= forgeIdList_.GetHashCode();
    hash ^= ForgeQueueMap.GetHashCode();
    if (MaxQueueNum != 0) hash ^= MaxQueueNum.GetHashCode();
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
    forgeQueueMap_.WriteTo(output, _map_forgeQueueMap_codec);
    if (MaxQueueNum != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(MaxQueueNum);
    }
    forgeIdList_.WriteTo(output, _repeated_forgeIdList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    forgeQueueMap_.WriteTo(ref output, _map_forgeQueueMap_codec);
    if (MaxQueueNum != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(MaxQueueNum);
    }
    forgeIdList_.WriteTo(ref output, _repeated_forgeIdList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += forgeIdList_.CalculateSize(_repeated_forgeIdList_codec);
    size += forgeQueueMap_.CalculateSize(_map_forgeQueueMap_codec);
    if (MaxQueueNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxQueueNum);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ForgeDataNotify other) {
    if (other == null) {
      return;
    }
    forgeIdList_.Add(other.forgeIdList_);
    forgeQueueMap_.Add(other.forgeQueueMap_);
    if (other.MaxQueueNum != 0) {
      MaxQueueNum = other.MaxQueueNum;
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
        case 66: {
          forgeQueueMap_.AddEntriesFrom(input, _map_forgeQueueMap_codec);
          break;
        }
        case 88: {
          MaxQueueNum = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          forgeIdList_.AddEntriesFrom(input, _repeated_forgeIdList_codec);
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
        case 66: {
          forgeQueueMap_.AddEntriesFrom(ref input, _map_forgeQueueMap_codec);
          break;
        }
        case 88: {
          MaxQueueNum = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          forgeIdList_.AddEntriesFrom(ref input, _repeated_forgeIdList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
