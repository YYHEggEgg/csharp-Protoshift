// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetActivityInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GetActivityInfoRsp.proto</summary>
  public static partial class GetActivityInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetActivityInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetActivityInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHZXRBY3Rpdml0eUluZm9Sc3AucHJvdG8aEkFjdGl2aXR5SW5mby5wcm90",
            "bxoQVWludDMyUGFpci5wcm90byKuAQoSR2V0QWN0aXZpdHlJbmZvUnNwEg8K",
            "B3JldGNvZGUYDSABKAUSKQoSYWN0aXZpdHlfaW5mb19saXN0GAUgAygLMg0u",
            "QWN0aXZpdHlJbmZvEh4KFmFjdGl2YXRlZF9zYWxlX2lkX2xpc3QYCyADKA0S",
            "PAonZGlzYWJsZV90cmFuc2Zlcl9wb2ludF9pbnRlcmFjdGlvbl9saXN0GAog",
            "AygLMgsuVWludDMyUGFpckIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ActivityInfoReflection.Descriptor, global::OldProtos.Uint32PairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GetActivityInfoRsp), global::OldProtos.GetActivityInfoRsp.Parser, new[]{ "Retcode", "ActivityInfoList", "ActivatedSaleIdList", "DisableTransferPointInteractionList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2041
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GetActivityInfoRsp : pb::IMessage<GetActivityInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetActivityInfoRsp> _parser = new pb::MessageParser<GetActivityInfoRsp>(() => new GetActivityInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetActivityInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GetActivityInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetActivityInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetActivityInfoRsp(GetActivityInfoRsp other) : this() {
      retcode_ = other.retcode_;
      activityInfoList_ = other.activityInfoList_.Clone();
      activatedSaleIdList_ = other.activatedSaleIdList_.Clone();
      disableTransferPointInteractionList_ = other.disableTransferPointInteractionList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetActivityInfoRsp Clone() {
      return new GetActivityInfoRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "activity_info_list" field.</summary>
    public const int ActivityInfoListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::OldProtos.ActivityInfo> _repeated_activityInfoList_codec
        = pb::FieldCodec.ForMessage(42, global::OldProtos.ActivityInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ActivityInfo> activityInfoList_ = new pbc::RepeatedField<global::OldProtos.ActivityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ActivityInfo> ActivityInfoList {
      get { return activityInfoList_; }
    }

    /// <summary>Field number for the "activated_sale_id_list" field.</summary>
    public const int ActivatedSaleIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_activatedSaleIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> activatedSaleIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ActivatedSaleIdList {
      get { return activatedSaleIdList_; }
    }

    /// <summary>Field number for the "disable_transfer_point_interaction_list" field.</summary>
    public const int DisableTransferPointInteractionListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::OldProtos.Uint32Pair> _repeated_disableTransferPointInteractionList_codec
        = pb::FieldCodec.ForMessage(82, global::OldProtos.Uint32Pair.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.Uint32Pair> disableTransferPointInteractionList_ = new pbc::RepeatedField<global::OldProtos.Uint32Pair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.Uint32Pair> DisableTransferPointInteractionList {
      get { return disableTransferPointInteractionList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetActivityInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetActivityInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!activityInfoList_.Equals(other.activityInfoList_)) return false;
      if(!activatedSaleIdList_.Equals(other.activatedSaleIdList_)) return false;
      if(!disableTransferPointInteractionList_.Equals(other.disableTransferPointInteractionList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= activityInfoList_.GetHashCode();
      hash ^= activatedSaleIdList_.GetHashCode();
      hash ^= disableTransferPointInteractionList_.GetHashCode();
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
      activityInfoList_.WriteTo(output, _repeated_activityInfoList_codec);
      disableTransferPointInteractionList_.WriteTo(output, _repeated_disableTransferPointInteractionList_codec);
      activatedSaleIdList_.WriteTo(output, _repeated_activatedSaleIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
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
      activityInfoList_.WriteTo(ref output, _repeated_activityInfoList_codec);
      disableTransferPointInteractionList_.WriteTo(ref output, _repeated_disableTransferPointInteractionList_codec);
      activatedSaleIdList_.WriteTo(ref output, _repeated_activatedSaleIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += activityInfoList_.CalculateSize(_repeated_activityInfoList_codec);
      size += activatedSaleIdList_.CalculateSize(_repeated_activatedSaleIdList_codec);
      size += disableTransferPointInteractionList_.CalculateSize(_repeated_disableTransferPointInteractionList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetActivityInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      activityInfoList_.Add(other.activityInfoList_);
      activatedSaleIdList_.Add(other.activatedSaleIdList_);
      disableTransferPointInteractionList_.Add(other.disableTransferPointInteractionList_);
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
            activityInfoList_.AddEntriesFrom(input, _repeated_activityInfoList_codec);
            break;
          }
          case 82: {
            disableTransferPointInteractionList_.AddEntriesFrom(input, _repeated_disableTransferPointInteractionList_codec);
            break;
          }
          case 90:
          case 88: {
            activatedSaleIdList_.AddEntriesFrom(input, _repeated_activatedSaleIdList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
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
            activityInfoList_.AddEntriesFrom(ref input, _repeated_activityInfoList_codec);
            break;
          }
          case 82: {
            disableTransferPointInteractionList_.AddEntriesFrom(ref input, _repeated_disableTransferPointInteractionList_codec);
            break;
          }
          case 90:
          case 88: {
            activatedSaleIdList_.AddEntriesFrom(ref input, _repeated_activatedSaleIdList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
