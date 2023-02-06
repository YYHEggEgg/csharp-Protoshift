// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldOwnerBlossomBriefInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WorldOwnerBlossomBriefInfoNotify.proto</summary>
public static partial class WorldOwnerBlossomBriefInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for WorldOwnerBlossomBriefInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WorldOwnerBlossomBriefInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiZXb3JsZE93bmVyQmxvc3NvbUJyaWVmSW5mb05vdGlmeS5wcm90bxoWQmxv",
          "c3NvbUJyaWVmSW5mby5wcm90byJOCiBXb3JsZE93bmVyQmxvc3NvbUJyaWVm",
          "SW5mb05vdGlmeRIqCg9icmllZl9pbmZvX2xpc3QYDSADKAsyES5CbG9zc29t",
          "QnJpZWZJbmZvQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BlossomBriefInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WorldOwnerBlossomBriefInfoNotify), global::WorldOwnerBlossomBriefInfoNotify.Parser, new[]{ "BriefInfoList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2735
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class WorldOwnerBlossomBriefInfoNotify : pb::IMessage<WorldOwnerBlossomBriefInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WorldOwnerBlossomBriefInfoNotify> _parser = new pb::MessageParser<WorldOwnerBlossomBriefInfoNotify>(() => new WorldOwnerBlossomBriefInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WorldOwnerBlossomBriefInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WorldOwnerBlossomBriefInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldOwnerBlossomBriefInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldOwnerBlossomBriefInfoNotify(WorldOwnerBlossomBriefInfoNotify other) : this() {
    briefInfoList_ = other.briefInfoList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldOwnerBlossomBriefInfoNotify Clone() {
    return new WorldOwnerBlossomBriefInfoNotify(this);
  }

  /// <summary>Field number for the "brief_info_list" field.</summary>
  public const int BriefInfoListFieldNumber = 13;
  private static readonly pb::FieldCodec<global::BlossomBriefInfo> _repeated_briefInfoList_codec
      = pb::FieldCodec.ForMessage(106, global::BlossomBriefInfo.Parser);
  private readonly pbc::RepeatedField<global::BlossomBriefInfo> briefInfoList_ = new pbc::RepeatedField<global::BlossomBriefInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::BlossomBriefInfo> BriefInfoList {
    get { return briefInfoList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WorldOwnerBlossomBriefInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WorldOwnerBlossomBriefInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!briefInfoList_.Equals(other.briefInfoList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= briefInfoList_.GetHashCode();
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
    briefInfoList_.WriteTo(output, _repeated_briefInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    briefInfoList_.WriteTo(ref output, _repeated_briefInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += briefInfoList_.CalculateSize(_repeated_briefInfoList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WorldOwnerBlossomBriefInfoNotify other) {
    if (other == null) {
      return;
    }
    briefInfoList_.Add(other.briefInfoList_);
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
        case 106: {
          briefInfoList_.AddEntriesFrom(input, _repeated_briefInfoList_codec);
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
        case 106: {
          briefInfoList_.AddEntriesFrom(ref input, _repeated_briefInfoList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
