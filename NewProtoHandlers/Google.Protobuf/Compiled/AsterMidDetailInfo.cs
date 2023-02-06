// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AsterMidDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AsterMidDetailInfo.proto</summary>
public static partial class AsterMidDetailInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for AsterMidDetailInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AsterMidDetailInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhBc3Rlck1pZERldGFpbEluZm8ucHJvdG8aFkFzdGVyTWlkQ2FtcEluZm8u",
          "cHJvdG8idgoSQXN0ZXJNaWREZXRhaWxJbmZvEg8KB2lzX29wZW4YDSABKAgS",
          "JAoJY2FtcF9saXN0GAsgAygLMhEuQXN0ZXJNaWRDYW1wSW5mbxISCgpiZWdp",
          "bl90aW1lGAQgASgNEhUKDWNvbGxlY3RfY291bnQYByABKA1CFgoUb3JnLnNv",
          "cmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::AsterMidCampInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AsterMidDetailInfo), global::AsterMidDetailInfo.Parser, new[]{ "IsOpen", "CampList", "BeginTime", "CollectCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AsterMidDetailInfo : pb::IMessage<AsterMidDetailInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AsterMidDetailInfo> _parser = new pb::MessageParser<AsterMidDetailInfo>(() => new AsterMidDetailInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AsterMidDetailInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AsterMidDetailInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AsterMidDetailInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AsterMidDetailInfo(AsterMidDetailInfo other) : this() {
    isOpen_ = other.isOpen_;
    campList_ = other.campList_.Clone();
    beginTime_ = other.beginTime_;
    collectCount_ = other.collectCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AsterMidDetailInfo Clone() {
    return new AsterMidDetailInfo(this);
  }

  /// <summary>Field number for the "is_open" field.</summary>
  public const int IsOpenFieldNumber = 13;
  private bool isOpen_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsOpen {
    get { return isOpen_; }
    set {
      isOpen_ = value;
    }
  }

  /// <summary>Field number for the "camp_list" field.</summary>
  public const int CampListFieldNumber = 11;
  private static readonly pb::FieldCodec<global::AsterMidCampInfo> _repeated_campList_codec
      = pb::FieldCodec.ForMessage(90, global::AsterMidCampInfo.Parser);
  private readonly pbc::RepeatedField<global::AsterMidCampInfo> campList_ = new pbc::RepeatedField<global::AsterMidCampInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::AsterMidCampInfo> CampList {
    get { return campList_; }
  }

  /// <summary>Field number for the "begin_time" field.</summary>
  public const int BeginTimeFieldNumber = 4;
  private uint beginTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BeginTime {
    get { return beginTime_; }
    set {
      beginTime_ = value;
    }
  }

  /// <summary>Field number for the "collect_count" field.</summary>
  public const int CollectCountFieldNumber = 7;
  private uint collectCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CollectCount {
    get { return collectCount_; }
    set {
      collectCount_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AsterMidDetailInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AsterMidDetailInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsOpen != other.IsOpen) return false;
    if(!campList_.Equals(other.campList_)) return false;
    if (BeginTime != other.BeginTime) return false;
    if (CollectCount != other.CollectCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsOpen != false) hash ^= IsOpen.GetHashCode();
    hash ^= campList_.GetHashCode();
    if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
    if (CollectCount != 0) hash ^= CollectCount.GetHashCode();
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
    if (BeginTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(BeginTime);
    }
    if (CollectCount != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CollectCount);
    }
    campList_.WriteTo(output, _repeated_campList_codec);
    if (IsOpen != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsOpen);
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
    if (BeginTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(BeginTime);
    }
    if (CollectCount != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CollectCount);
    }
    campList_.WriteTo(ref output, _repeated_campList_codec);
    if (IsOpen != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsOpen);
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
    if (IsOpen != false) {
      size += 1 + 1;
    }
    size += campList_.CalculateSize(_repeated_campList_codec);
    if (BeginTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
    }
    if (CollectCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CollectCount);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AsterMidDetailInfo other) {
    if (other == null) {
      return;
    }
    if (other.IsOpen != false) {
      IsOpen = other.IsOpen;
    }
    campList_.Add(other.campList_);
    if (other.BeginTime != 0) {
      BeginTime = other.BeginTime;
    }
    if (other.CollectCount != 0) {
      CollectCount = other.CollectCount;
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
          BeginTime = input.ReadUInt32();
          break;
        }
        case 56: {
          CollectCount = input.ReadUInt32();
          break;
        }
        case 90: {
          campList_.AddEntriesFrom(input, _repeated_campList_codec);
          break;
        }
        case 104: {
          IsOpen = input.ReadBool();
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
          BeginTime = input.ReadUInt32();
          break;
        }
        case 56: {
          CollectCount = input.ReadUInt32();
          break;
        }
        case 90: {
          campList_.AddEntriesFrom(ref input, _repeated_campList_codec);
          break;
        }
        case 104: {
          IsOpen = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
