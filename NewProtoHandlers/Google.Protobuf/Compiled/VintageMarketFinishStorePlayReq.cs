// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketFinishStorePlayReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from VintageMarketFinishStorePlayReq.proto</summary>
public static partial class VintageMarketFinishStorePlayReqReflection {

  #region Descriptor
  /// <summary>File descriptor for VintageMarketFinishStorePlayReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static VintageMarketFinishStorePlayReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVWaW50YWdlTWFya2V0RmluaXNoU3RvcmVQbGF5UmVxLnByb3RvGh5WaW50",
          "YWdlTWFya2V0U3RvcmVPcEluZm8ucHJvdG8iaAofVmludGFnZU1hcmtldEZp",
          "bmlzaFN0b3JlUGxheVJlcRITCgtzdG9yZV9yb3VuZBgMIAEoDRIwCg1zdG9y",
          "ZV9vcF9saXN0GAsgAygLMhkuVmludGFnZU1hcmtldFN0b3JlT3BJbmZvQhYK",
          "FG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VintageMarketStoreOpInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::VintageMarketFinishStorePlayReq), global::VintageMarketFinishStorePlayReq.Parser, new[]{ "StoreRound", "StoreOpList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 21911;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class VintageMarketFinishStorePlayReq : pb::IMessage<VintageMarketFinishStorePlayReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<VintageMarketFinishStorePlayReq> _parser = new pb::MessageParser<VintageMarketFinishStorePlayReq>(() => new VintageMarketFinishStorePlayReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<VintageMarketFinishStorePlayReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::VintageMarketFinishStorePlayReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageMarketFinishStorePlayReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageMarketFinishStorePlayReq(VintageMarketFinishStorePlayReq other) : this() {
    storeRound_ = other.storeRound_;
    storeOpList_ = other.storeOpList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageMarketFinishStorePlayReq Clone() {
    return new VintageMarketFinishStorePlayReq(this);
  }

  /// <summary>Field number for the "store_round" field.</summary>
  public const int StoreRoundFieldNumber = 12;
  private uint storeRound_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StoreRound {
    get { return storeRound_; }
    set {
      storeRound_ = value;
    }
  }

  /// <summary>Field number for the "store_op_list" field.</summary>
  public const int StoreOpListFieldNumber = 11;
  private static readonly pb::FieldCodec<global::VintageMarketStoreOpInfo> _repeated_storeOpList_codec
      = pb::FieldCodec.ForMessage(90, global::VintageMarketStoreOpInfo.Parser);
  private readonly pbc::RepeatedField<global::VintageMarketStoreOpInfo> storeOpList_ = new pbc::RepeatedField<global::VintageMarketStoreOpInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::VintageMarketStoreOpInfo> StoreOpList {
    get { return storeOpList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as VintageMarketFinishStorePlayReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(VintageMarketFinishStorePlayReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StoreRound != other.StoreRound) return false;
    if(!storeOpList_.Equals(other.storeOpList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StoreRound != 0) hash ^= StoreRound.GetHashCode();
    hash ^= storeOpList_.GetHashCode();
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
    storeOpList_.WriteTo(output, _repeated_storeOpList_codec);
    if (StoreRound != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(StoreRound);
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
    storeOpList_.WriteTo(ref output, _repeated_storeOpList_codec);
    if (StoreRound != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(StoreRound);
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
    if (StoreRound != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreRound);
    }
    size += storeOpList_.CalculateSize(_repeated_storeOpList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(VintageMarketFinishStorePlayReq other) {
    if (other == null) {
      return;
    }
    if (other.StoreRound != 0) {
      StoreRound = other.StoreRound;
    }
    storeOpList_.Add(other.storeOpList_);
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
        case 90: {
          storeOpList_.AddEntriesFrom(input, _repeated_storeOpList_codec);
          break;
        }
        case 96: {
          StoreRound = input.ReadUInt32();
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
        case 90: {
          storeOpList_.AddEntriesFrom(ref input, _repeated_storeOpList_codec);
          break;
        }
        case 96: {
          StoreRound = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
