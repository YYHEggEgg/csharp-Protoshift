// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HideAndSeekMapInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HideAndSeekMapInfo.proto</summary>
public static partial class HideAndSeekMapInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for HideAndSeekMapInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HideAndSeekMapInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhIaWRlQW5kU2Vla01hcEluZm8ucHJvdG8iQAoSSGlkZUFuZFNlZWtNYXBJ",
          "bmZvEh4KFm1hdGNoX2xvY2tfcmVhc29uX2xpc3QYBiADKA0SCgoCaWQYDCAB",
          "KA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HideAndSeekMapInfo), global::HideAndSeekMapInfo.Parser, new[]{ "MatchLockReasonList", "Id" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class HideAndSeekMapInfo : pb::IMessage<HideAndSeekMapInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HideAndSeekMapInfo> _parser = new pb::MessageParser<HideAndSeekMapInfo>(() => new HideAndSeekMapInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HideAndSeekMapInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HideAndSeekMapInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekMapInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekMapInfo(HideAndSeekMapInfo other) : this() {
    matchLockReasonList_ = other.matchLockReasonList_.Clone();
    id_ = other.id_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekMapInfo Clone() {
    return new HideAndSeekMapInfo(this);
  }

  /// <summary>Field number for the "match_lock_reason_list" field.</summary>
  public const int MatchLockReasonListFieldNumber = 6;
  private static readonly pb::FieldCodec<uint> _repeated_matchLockReasonList_codec
      = pb::FieldCodec.ForUInt32(50);
  private readonly pbc::RepeatedField<uint> matchLockReasonList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> MatchLockReasonList {
    get { return matchLockReasonList_; }
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 12;
  private uint id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HideAndSeekMapInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HideAndSeekMapInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!matchLockReasonList_.Equals(other.matchLockReasonList_)) return false;
    if (Id != other.Id) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= matchLockReasonList_.GetHashCode();
    if (Id != 0) hash ^= Id.GetHashCode();
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
    matchLockReasonList_.WriteTo(output, _repeated_matchLockReasonList_codec);
    if (Id != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(Id);
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
    matchLockReasonList_.WriteTo(ref output, _repeated_matchLockReasonList_codec);
    if (Id != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(Id);
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
    size += matchLockReasonList_.CalculateSize(_repeated_matchLockReasonList_codec);
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HideAndSeekMapInfo other) {
    if (other == null) {
      return;
    }
    matchLockReasonList_.Add(other.matchLockReasonList_);
    if (other.Id != 0) {
      Id = other.Id;
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
        case 50:
        case 48: {
          matchLockReasonList_.AddEntriesFrom(input, _repeated_matchLockReasonList_codec);
          break;
        }
        case 96: {
          Id = input.ReadUInt32();
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
        case 50:
        case 48: {
          matchLockReasonList_.AddEntriesFrom(ref input, _repeated_matchLockReasonList_codec);
          break;
        }
        case 96: {
          Id = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code