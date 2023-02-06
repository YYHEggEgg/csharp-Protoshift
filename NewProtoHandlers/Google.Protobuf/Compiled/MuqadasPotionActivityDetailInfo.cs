// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuqadasPotionActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MuqadasPotionActivityDetailInfo.proto</summary>
public static partial class MuqadasPotionActivityDetailInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for MuqadasPotionActivityDetailInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MuqadasPotionActivityDetailInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVNdXFhZGFzUG90aW9uQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGhxNdXFh",
          "ZGFzUG90aW9uTGV2ZWxEYXRhLnByb3RvImIKH011cWFkYXNQb3Rpb25BY3Rp",
          "dml0eURldGFpbEluZm8SPwoebXVxYWRhc19wb3Rpb25fbGV2ZWxfZGF0YV9s",
          "aXN0GAUgAygLMhcuTXVxYWRhc1BvdGlvbkxldmVsRGF0YUIWChRvcmcuc29y",
          "YXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MuqadasPotionLevelDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MuqadasPotionActivityDetailInfo), global::MuqadasPotionActivityDetailInfo.Parser, new[]{ "MuqadasPotionLevelDataList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class MuqadasPotionActivityDetailInfo : pb::IMessage<MuqadasPotionActivityDetailInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MuqadasPotionActivityDetailInfo> _parser = new pb::MessageParser<MuqadasPotionActivityDetailInfo>(() => new MuqadasPotionActivityDetailInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MuqadasPotionActivityDetailInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MuqadasPotionActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MuqadasPotionActivityDetailInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MuqadasPotionActivityDetailInfo(MuqadasPotionActivityDetailInfo other) : this() {
    muqadasPotionLevelDataList_ = other.muqadasPotionLevelDataList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MuqadasPotionActivityDetailInfo Clone() {
    return new MuqadasPotionActivityDetailInfo(this);
  }

  /// <summary>Field number for the "muqadas_potion_level_data_list" field.</summary>
  public const int MuqadasPotionLevelDataListFieldNumber = 5;
  private static readonly pb::FieldCodec<global::MuqadasPotionLevelData> _repeated_muqadasPotionLevelDataList_codec
      = pb::FieldCodec.ForMessage(42, global::MuqadasPotionLevelData.Parser);
  private readonly pbc::RepeatedField<global::MuqadasPotionLevelData> muqadasPotionLevelDataList_ = new pbc::RepeatedField<global::MuqadasPotionLevelData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::MuqadasPotionLevelData> MuqadasPotionLevelDataList {
    get { return muqadasPotionLevelDataList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MuqadasPotionActivityDetailInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MuqadasPotionActivityDetailInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!muqadasPotionLevelDataList_.Equals(other.muqadasPotionLevelDataList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= muqadasPotionLevelDataList_.GetHashCode();
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
    muqadasPotionLevelDataList_.WriteTo(output, _repeated_muqadasPotionLevelDataList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    muqadasPotionLevelDataList_.WriteTo(ref output, _repeated_muqadasPotionLevelDataList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += muqadasPotionLevelDataList_.CalculateSize(_repeated_muqadasPotionLevelDataList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MuqadasPotionActivityDetailInfo other) {
    if (other == null) {
      return;
    }
    muqadasPotionLevelDataList_.Add(other.muqadasPotionLevelDataList_);
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
        case 42: {
          muqadasPotionLevelDataList_.AddEntriesFrom(input, _repeated_muqadasPotionLevelDataList_codec);
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
        case 42: {
          muqadasPotionLevelDataList_.AddEntriesFrom(ref input, _repeated_muqadasPotionLevelDataList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
