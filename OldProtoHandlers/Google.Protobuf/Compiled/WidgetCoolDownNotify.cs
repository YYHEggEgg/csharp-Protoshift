// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetCoolDownNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WidgetCoolDownNotify.proto</summary>
public static partial class WidgetCoolDownNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for WidgetCoolDownNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WidgetCoolDownNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpXaWRnZXRDb29sRG93bk5vdGlmeS5wcm90bxoYV2lkZ2V0Q29vbERvd25E",
          "YXRhLnByb3RvIocBChRXaWRnZXRDb29sRG93bk5vdGlmeRI3Chpub3JtYWxf",
          "Y29vbF9kb3duX2RhdGFfbGlzdBgBIAMoCzITLldpZGdldENvb2xEb3duRGF0",
          "YRI2Chlncm91cF9jb29sX2Rvd25fZGF0YV9saXN0GAwgAygLMhMuV2lkZ2V0",
          "Q29vbERvd25EYXRhQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9i",
          "BnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::WidgetCoolDownDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WidgetCoolDownNotify), global::WidgetCoolDownNotify.Parser, new[]{ "NormalCoolDownDataList", "GroupCoolDownDataList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4295
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class WidgetCoolDownNotify : pb::IMessage<WidgetCoolDownNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WidgetCoolDownNotify> _parser = new pb::MessageParser<WidgetCoolDownNotify>(() => new WidgetCoolDownNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WidgetCoolDownNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WidgetCoolDownNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WidgetCoolDownNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WidgetCoolDownNotify(WidgetCoolDownNotify other) : this() {
    normalCoolDownDataList_ = other.normalCoolDownDataList_.Clone();
    groupCoolDownDataList_ = other.groupCoolDownDataList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WidgetCoolDownNotify Clone() {
    return new WidgetCoolDownNotify(this);
  }

  /// <summary>Field number for the "normal_cool_down_data_list" field.</summary>
  public const int NormalCoolDownDataListFieldNumber = 1;
  private static readonly pb::FieldCodec<global::WidgetCoolDownData> _repeated_normalCoolDownDataList_codec
      = pb::FieldCodec.ForMessage(10, global::WidgetCoolDownData.Parser);
  private readonly pbc::RepeatedField<global::WidgetCoolDownData> normalCoolDownDataList_ = new pbc::RepeatedField<global::WidgetCoolDownData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::WidgetCoolDownData> NormalCoolDownDataList {
    get { return normalCoolDownDataList_; }
  }

  /// <summary>Field number for the "group_cool_down_data_list" field.</summary>
  public const int GroupCoolDownDataListFieldNumber = 12;
  private static readonly pb::FieldCodec<global::WidgetCoolDownData> _repeated_groupCoolDownDataList_codec
      = pb::FieldCodec.ForMessage(98, global::WidgetCoolDownData.Parser);
  private readonly pbc::RepeatedField<global::WidgetCoolDownData> groupCoolDownDataList_ = new pbc::RepeatedField<global::WidgetCoolDownData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::WidgetCoolDownData> GroupCoolDownDataList {
    get { return groupCoolDownDataList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WidgetCoolDownNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WidgetCoolDownNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!normalCoolDownDataList_.Equals(other.normalCoolDownDataList_)) return false;
    if(!groupCoolDownDataList_.Equals(other.groupCoolDownDataList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= normalCoolDownDataList_.GetHashCode();
    hash ^= groupCoolDownDataList_.GetHashCode();
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
    normalCoolDownDataList_.WriteTo(output, _repeated_normalCoolDownDataList_codec);
    groupCoolDownDataList_.WriteTo(output, _repeated_groupCoolDownDataList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    normalCoolDownDataList_.WriteTo(ref output, _repeated_normalCoolDownDataList_codec);
    groupCoolDownDataList_.WriteTo(ref output, _repeated_groupCoolDownDataList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += normalCoolDownDataList_.CalculateSize(_repeated_normalCoolDownDataList_codec);
    size += groupCoolDownDataList_.CalculateSize(_repeated_groupCoolDownDataList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WidgetCoolDownNotify other) {
    if (other == null) {
      return;
    }
    normalCoolDownDataList_.Add(other.normalCoolDownDataList_);
    groupCoolDownDataList_.Add(other.groupCoolDownDataList_);
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
        case 10: {
          normalCoolDownDataList_.AddEntriesFrom(input, _repeated_normalCoolDownDataList_codec);
          break;
        }
        case 98: {
          groupCoolDownDataList_.AddEntriesFrom(input, _repeated_groupCoolDownDataList_codec);
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
        case 10: {
          normalCoolDownDataList_.AddEntriesFrom(ref input, _repeated_normalCoolDownDataList_codec);
          break;
        }
        case 98: {
          groupCoolDownDataList_.AddEntriesFrom(ref input, _repeated_groupCoolDownDataList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
