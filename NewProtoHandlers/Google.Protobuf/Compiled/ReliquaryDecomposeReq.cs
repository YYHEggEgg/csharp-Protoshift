// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReliquaryDecomposeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ReliquaryDecomposeReq.proto</summary>
public static partial class ReliquaryDecomposeReqReflection {

  #region Descriptor
  /// <summary>File descriptor for ReliquaryDecomposeReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReliquaryDecomposeReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtSZWxpcXVhcnlEZWNvbXBvc2VSZXEucHJvdG8iUwoVUmVsaXF1YXJ5RGVj",
          "b21wb3NlUmVxEhEKCWNvbmZpZ19pZBgEIAEoDRIUCgx0YXJnZXRfY291bnQY",
          "DyABKA0SEQoJZ3VpZF9saXN0GA0gAygEQhYKFG9yZy5zb3JhcG9pbnRhLnBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ReliquaryDecomposeReq), global::ReliquaryDecomposeReq.Parser, new[]{ "ConfigId", "TargetCount", "GuidList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 631;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class ReliquaryDecomposeReq : pb::IMessage<ReliquaryDecomposeReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ReliquaryDecomposeReq> _parser = new pb::MessageParser<ReliquaryDecomposeReq>(() => new ReliquaryDecomposeReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ReliquaryDecomposeReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReliquaryDecomposeReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryDecomposeReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryDecomposeReq(ReliquaryDecomposeReq other) : this() {
    configId_ = other.configId_;
    targetCount_ = other.targetCount_;
    guidList_ = other.guidList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ReliquaryDecomposeReq Clone() {
    return new ReliquaryDecomposeReq(this);
  }

  /// <summary>Field number for the "config_id" field.</summary>
  public const int ConfigIdFieldNumber = 4;
  private uint configId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConfigId {
    get { return configId_; }
    set {
      configId_ = value;
    }
  }

  /// <summary>Field number for the "target_count" field.</summary>
  public const int TargetCountFieldNumber = 15;
  private uint targetCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TargetCount {
    get { return targetCount_; }
    set {
      targetCount_ = value;
    }
  }

  /// <summary>Field number for the "guid_list" field.</summary>
  public const int GuidListFieldNumber = 13;
  private static readonly pb::FieldCodec<ulong> _repeated_guidList_codec
      = pb::FieldCodec.ForUInt64(106);
  private readonly pbc::RepeatedField<ulong> guidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> GuidList {
    get { return guidList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ReliquaryDecomposeReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ReliquaryDecomposeReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ConfigId != other.ConfigId) return false;
    if (TargetCount != other.TargetCount) return false;
    if(!guidList_.Equals(other.guidList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
    if (TargetCount != 0) hash ^= TargetCount.GetHashCode();
    hash ^= guidList_.GetHashCode();
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
    if (ConfigId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(ConfigId);
    }
    guidList_.WriteTo(output, _repeated_guidList_codec);
    if (TargetCount != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(TargetCount);
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
    if (ConfigId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(ConfigId);
    }
    guidList_.WriteTo(ref output, _repeated_guidList_codec);
    if (TargetCount != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(TargetCount);
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
    if (ConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
    }
    if (TargetCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetCount);
    }
    size += guidList_.CalculateSize(_repeated_guidList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ReliquaryDecomposeReq other) {
    if (other == null) {
      return;
    }
    if (other.ConfigId != 0) {
      ConfigId = other.ConfigId;
    }
    if (other.TargetCount != 0) {
      TargetCount = other.TargetCount;
    }
    guidList_.Add(other.guidList_);
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
          ConfigId = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          guidList_.AddEntriesFrom(input, _repeated_guidList_codec);
          break;
        }
        case 120: {
          TargetCount = input.ReadUInt32();
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
          ConfigId = input.ReadUInt32();
          break;
        }
        case 106:
        case 104: {
          guidList_.AddEntriesFrom(ref input, _repeated_guidList_codec);
          break;
        }
        case 120: {
          TargetCount = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
