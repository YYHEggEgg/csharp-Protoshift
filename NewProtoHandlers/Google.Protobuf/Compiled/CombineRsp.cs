// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CombineRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from CombineRsp.proto</summary>
  public static partial class CombineRspReflection {

    #region Descriptor
    /// <summary>File descriptor for CombineRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CombineRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBDb21iaW5lUnNwLnByb3RvGg9JdGVtUGFyYW0ucHJvdG8iqgIKCkNvbWJp",
            "bmVSc3ASKgoWdG90YWxfcmV0dXJuX2l0ZW1fbGlzdBgLIAMoCzIKLkl0ZW1Q",
            "YXJhbRIpChV0b3RhbF9leHRyYV9pdGVtX2xpc3QYDSADKAsyCi5JdGVtUGFy",
            "YW0SKgoWdG90YWxfcmFuZG9tX2l0ZW1fbGlzdBgGIAMoCzIKLkl0ZW1QYXJh",
            "bRITCgthdmF0YXJfZ3VpZBgHIAEoBBIVCg1jb21iaW5lX2NvdW50GAIgASgN",
            "EhIKCmNvbWJpbmVfaWQYCiABKA0SIgoOY29zdF9pdGVtX2xpc3QYDyADKAsy",
            "Ci5JdGVtUGFyYW0SDwoHcmV0Y29kZRgBIAEoBRIkChByZXN1bHRfaXRlbV9s",
            "aXN0GAQgAygLMgouSXRlbVBhcmFtQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.CombineRsp), global::NewProtos.CombineRsp.Parser, new[]{ "TotalReturnItemList", "TotalExtraItemList", "TotalRandomItemList", "AvatarGuid", "CombineCount", "CombineId", "CostItemList", "Retcode", "ResultItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 634;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class CombineRsp : pb::IMessage<CombineRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CombineRsp> _parser = new pb::MessageParser<CombineRsp>(() => new CombineRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CombineRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.CombineRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombineRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombineRsp(CombineRsp other) : this() {
      totalReturnItemList_ = other.totalReturnItemList_.Clone();
      totalExtraItemList_ = other.totalExtraItemList_.Clone();
      totalRandomItemList_ = other.totalRandomItemList_.Clone();
      avatarGuid_ = other.avatarGuid_;
      combineCount_ = other.combineCount_;
      combineId_ = other.combineId_;
      costItemList_ = other.costItemList_.Clone();
      retcode_ = other.retcode_;
      resultItemList_ = other.resultItemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombineRsp Clone() {
      return new CombineRsp(this);
    }

    /// <summary>Field number for the "total_return_item_list" field.</summary>
    public const int TotalReturnItemListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_totalReturnItemList_codec
        = pb::FieldCodec.ForMessage(90, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> totalReturnItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> TotalReturnItemList {
      get { return totalReturnItemList_; }
    }

    /// <summary>Field number for the "total_extra_item_list" field.</summary>
    public const int TotalExtraItemListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_totalExtraItemList_codec
        = pb::FieldCodec.ForMessage(106, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> totalExtraItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> TotalExtraItemList {
      get { return totalExtraItemList_; }
    }

    /// <summary>Field number for the "total_random_item_list" field.</summary>
    public const int TotalRandomItemListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_totalRandomItemList_codec
        = pb::FieldCodec.ForMessage(50, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> totalRandomItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> TotalRandomItemList {
      get { return totalRandomItemList_; }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 7;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "combine_count" field.</summary>
    public const int CombineCountFieldNumber = 2;
    private uint combineCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CombineCount {
      get { return combineCount_; }
      set {
        combineCount_ = value;
      }
    }

    /// <summary>Field number for the "combine_id" field.</summary>
    public const int CombineIdFieldNumber = 10;
    private uint combineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CombineId {
      get { return combineId_; }
      set {
        combineId_ = value;
      }
    }

    /// <summary>Field number for the "cost_item_list" field.</summary>
    public const int CostItemListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_costItemList_codec
        = pb::FieldCodec.ForMessage(122, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> costItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> CostItemList {
      get { return costItemList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "result_item_list" field.</summary>
    public const int ResultItemListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_resultItemList_codec
        = pb::FieldCodec.ForMessage(34, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> resultItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> ResultItemList {
      get { return resultItemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CombineRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CombineRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!totalReturnItemList_.Equals(other.totalReturnItemList_)) return false;
      if(!totalExtraItemList_.Equals(other.totalExtraItemList_)) return false;
      if(!totalRandomItemList_.Equals(other.totalRandomItemList_)) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      if (CombineCount != other.CombineCount) return false;
      if (CombineId != other.CombineId) return false;
      if(!costItemList_.Equals(other.costItemList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!resultItemList_.Equals(other.resultItemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= totalReturnItemList_.GetHashCode();
      hash ^= totalExtraItemList_.GetHashCode();
      hash ^= totalRandomItemList_.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (CombineCount != 0) hash ^= CombineCount.GetHashCode();
      if (CombineId != 0) hash ^= CombineId.GetHashCode();
      hash ^= costItemList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= resultItemList_.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (CombineCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CombineCount);
      }
      resultItemList_.WriteTo(output, _repeated_resultItemList_codec);
      totalRandomItemList_.WriteTo(output, _repeated_totalRandomItemList_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(AvatarGuid);
      }
      if (CombineId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CombineId);
      }
      totalReturnItemList_.WriteTo(output, _repeated_totalReturnItemList_codec);
      totalExtraItemList_.WriteTo(output, _repeated_totalExtraItemList_codec);
      costItemList_.WriteTo(output, _repeated_costItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (CombineCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CombineCount);
      }
      resultItemList_.WriteTo(ref output, _repeated_resultItemList_codec);
      totalRandomItemList_.WriteTo(ref output, _repeated_totalRandomItemList_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(AvatarGuid);
      }
      if (CombineId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CombineId);
      }
      totalReturnItemList_.WriteTo(ref output, _repeated_totalReturnItemList_codec);
      totalExtraItemList_.WriteTo(ref output, _repeated_totalExtraItemList_codec);
      costItemList_.WriteTo(ref output, _repeated_costItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += totalReturnItemList_.CalculateSize(_repeated_totalReturnItemList_codec);
      size += totalExtraItemList_.CalculateSize(_repeated_totalExtraItemList_codec);
      size += totalRandomItemList_.CalculateSize(_repeated_totalRandomItemList_codec);
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (CombineCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CombineCount);
      }
      if (CombineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CombineId);
      }
      size += costItemList_.CalculateSize(_repeated_costItemList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += resultItemList_.CalculateSize(_repeated_resultItemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CombineRsp other) {
      if (other == null) {
        return;
      }
      totalReturnItemList_.Add(other.totalReturnItemList_);
      totalExtraItemList_.Add(other.totalExtraItemList_);
      totalRandomItemList_.Add(other.totalRandomItemList_);
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.CombineCount != 0) {
        CombineCount = other.CombineCount;
      }
      if (other.CombineId != 0) {
        CombineId = other.CombineId;
      }
      costItemList_.Add(other.costItemList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      resultItemList_.Add(other.resultItemList_);
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
          case 8: {
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            CombineCount = input.ReadUInt32();
            break;
          }
          case 34: {
            resultItemList_.AddEntriesFrom(input, _repeated_resultItemList_codec);
            break;
          }
          case 50: {
            totalRandomItemList_.AddEntriesFrom(input, _repeated_totalRandomItemList_codec);
            break;
          }
          case 56: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 80: {
            CombineId = input.ReadUInt32();
            break;
          }
          case 90: {
            totalReturnItemList_.AddEntriesFrom(input, _repeated_totalReturnItemList_codec);
            break;
          }
          case 106: {
            totalExtraItemList_.AddEntriesFrom(input, _repeated_totalExtraItemList_codec);
            break;
          }
          case 122: {
            costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
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
          case 8: {
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            CombineCount = input.ReadUInt32();
            break;
          }
          case 34: {
            resultItemList_.AddEntriesFrom(ref input, _repeated_resultItemList_codec);
            break;
          }
          case 50: {
            totalRandomItemList_.AddEntriesFrom(ref input, _repeated_totalRandomItemList_codec);
            break;
          }
          case 56: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 80: {
            CombineId = input.ReadUInt32();
            break;
          }
          case 90: {
            totalReturnItemList_.AddEntriesFrom(ref input, _repeated_totalReturnItemList_codec);
            break;
          }
          case 106: {
            totalExtraItemList_.AddEntriesFrom(ref input, _repeated_totalExtraItemList_codec);
            break;
          }
          case 122: {
            costItemList_.AddEntriesFrom(ref input, _repeated_costItemList_codec);
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