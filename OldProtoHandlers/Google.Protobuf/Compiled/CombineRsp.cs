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
namespace OldProtos {

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
            "bmVSc3ASIgoOY29zdF9pdGVtX2xpc3QYAyADKAsyCi5JdGVtUGFyYW0SDwoH",
            "cmV0Y29kZRgHIAEoBRIpChV0b3RhbF9leHRyYV9pdGVtX2xpc3QYBiADKAsy",
            "Ci5JdGVtUGFyYW0SEgoKY29tYmluZV9pZBgLIAEoDRIqChZ0b3RhbF9yYW5k",
            "b21faXRlbV9saXN0GAkgAygLMgouSXRlbVBhcmFtEiQKEHJlc3VsdF9pdGVt",
            "X2xpc3QYAiADKAsyCi5JdGVtUGFyYW0SFQoNY29tYmluZV9jb3VudBgNIAEo",
            "DRIqChZ0b3RhbF9yZXR1cm5faXRlbV9saXN0GAwgAygLMgouSXRlbVBhcmFt",
            "EhMKC2F2YXRhcl9ndWlkGAogASgEQgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.CombineRsp), global::OldProtos.CombineRsp.Parser, new[]{ "CostItemList", "Retcode", "TotalExtraItemList", "CombineId", "TotalRandomItemList", "ResultItemList", "CombineCount", "TotalReturnItemList", "AvatarGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 674
  /// EnetChannelId: 0
  /// EnetIsReliable: true
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
      get { return global::OldProtos.CombineRspReflection.Descriptor.MessageTypes[0]; }
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
      costItemList_ = other.costItemList_.Clone();
      retcode_ = other.retcode_;
      totalExtraItemList_ = other.totalExtraItemList_.Clone();
      combineId_ = other.combineId_;
      totalRandomItemList_ = other.totalRandomItemList_.Clone();
      resultItemList_ = other.resultItemList_.Clone();
      combineCount_ = other.combineCount_;
      totalReturnItemList_ = other.totalReturnItemList_.Clone();
      avatarGuid_ = other.avatarGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombineRsp Clone() {
      return new CombineRsp(this);
    }

    /// <summary>Field number for the "cost_item_list" field.</summary>
    public const int CostItemListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::OldProtos.ItemParam> _repeated_costItemList_codec
        = pb::FieldCodec.ForMessage(26, global::OldProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ItemParam> costItemList_ = new pbc::RepeatedField<global::OldProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ItemParam> CostItemList {
      get { return costItemList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "total_extra_item_list" field.</summary>
    public const int TotalExtraItemListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::OldProtos.ItemParam> _repeated_totalExtraItemList_codec
        = pb::FieldCodec.ForMessage(50, global::OldProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ItemParam> totalExtraItemList_ = new pbc::RepeatedField<global::OldProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ItemParam> TotalExtraItemList {
      get { return totalExtraItemList_; }
    }

    /// <summary>Field number for the "combine_id" field.</summary>
    public const int CombineIdFieldNumber = 11;
    private uint combineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CombineId {
      get { return combineId_; }
      set {
        combineId_ = value;
      }
    }

    /// <summary>Field number for the "total_random_item_list" field.</summary>
    public const int TotalRandomItemListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::OldProtos.ItemParam> _repeated_totalRandomItemList_codec
        = pb::FieldCodec.ForMessage(74, global::OldProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ItemParam> totalRandomItemList_ = new pbc::RepeatedField<global::OldProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ItemParam> TotalRandomItemList {
      get { return totalRandomItemList_; }
    }

    /// <summary>Field number for the "result_item_list" field.</summary>
    public const int ResultItemListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::OldProtos.ItemParam> _repeated_resultItemList_codec
        = pb::FieldCodec.ForMessage(18, global::OldProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ItemParam> resultItemList_ = new pbc::RepeatedField<global::OldProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ItemParam> ResultItemList {
      get { return resultItemList_; }
    }

    /// <summary>Field number for the "combine_count" field.</summary>
    public const int CombineCountFieldNumber = 13;
    private uint combineCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CombineCount {
      get { return combineCount_; }
      set {
        combineCount_ = value;
      }
    }

    /// <summary>Field number for the "total_return_item_list" field.</summary>
    public const int TotalReturnItemListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::OldProtos.ItemParam> _repeated_totalReturnItemList_codec
        = pb::FieldCodec.ForMessage(98, global::OldProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.ItemParam> totalReturnItemList_ = new pbc::RepeatedField<global::OldProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.ItemParam> TotalReturnItemList {
      get { return totalReturnItemList_; }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 10;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
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
      if(!costItemList_.Equals(other.costItemList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!totalExtraItemList_.Equals(other.totalExtraItemList_)) return false;
      if (CombineId != other.CombineId) return false;
      if(!totalRandomItemList_.Equals(other.totalRandomItemList_)) return false;
      if(!resultItemList_.Equals(other.resultItemList_)) return false;
      if (CombineCount != other.CombineCount) return false;
      if(!totalReturnItemList_.Equals(other.totalReturnItemList_)) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= costItemList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= totalExtraItemList_.GetHashCode();
      if (CombineId != 0) hash ^= CombineId.GetHashCode();
      hash ^= totalRandomItemList_.GetHashCode();
      hash ^= resultItemList_.GetHashCode();
      if (CombineCount != 0) hash ^= CombineCount.GetHashCode();
      hash ^= totalReturnItemList_.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
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
      resultItemList_.WriteTo(output, _repeated_resultItemList_codec);
      costItemList_.WriteTo(output, _repeated_costItemList_codec);
      totalExtraItemList_.WriteTo(output, _repeated_totalExtraItemList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      totalRandomItemList_.WriteTo(output, _repeated_totalRandomItemList_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(AvatarGuid);
      }
      if (CombineId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CombineId);
      }
      totalReturnItemList_.WriteTo(output, _repeated_totalReturnItemList_codec);
      if (CombineCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CombineCount);
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
      resultItemList_.WriteTo(ref output, _repeated_resultItemList_codec);
      costItemList_.WriteTo(ref output, _repeated_costItemList_codec);
      totalExtraItemList_.WriteTo(ref output, _repeated_totalExtraItemList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      totalRandomItemList_.WriteTo(ref output, _repeated_totalRandomItemList_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(80);
        output.WriteUInt64(AvatarGuid);
      }
      if (CombineId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CombineId);
      }
      totalReturnItemList_.WriteTo(ref output, _repeated_totalReturnItemList_codec);
      if (CombineCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CombineCount);
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
      size += costItemList_.CalculateSize(_repeated_costItemList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += totalExtraItemList_.CalculateSize(_repeated_totalExtraItemList_codec);
      if (CombineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CombineId);
      }
      size += totalRandomItemList_.CalculateSize(_repeated_totalRandomItemList_codec);
      size += resultItemList_.CalculateSize(_repeated_resultItemList_codec);
      if (CombineCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CombineCount);
      }
      size += totalReturnItemList_.CalculateSize(_repeated_totalReturnItemList_codec);
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
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
      costItemList_.Add(other.costItemList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      totalExtraItemList_.Add(other.totalExtraItemList_);
      if (other.CombineId != 0) {
        CombineId = other.CombineId;
      }
      totalRandomItemList_.Add(other.totalRandomItemList_);
      resultItemList_.Add(other.resultItemList_);
      if (other.CombineCount != 0) {
        CombineCount = other.CombineCount;
      }
      totalReturnItemList_.Add(other.totalReturnItemList_);
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
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
          case 18: {
            resultItemList_.AddEntriesFrom(input, _repeated_resultItemList_codec);
            break;
          }
          case 26: {
            costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
            break;
          }
          case 50: {
            totalExtraItemList_.AddEntriesFrom(input, _repeated_totalExtraItemList_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74: {
            totalRandomItemList_.AddEntriesFrom(input, _repeated_totalRandomItemList_codec);
            break;
          }
          case 80: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 88: {
            CombineId = input.ReadUInt32();
            break;
          }
          case 98: {
            totalReturnItemList_.AddEntriesFrom(input, _repeated_totalReturnItemList_codec);
            break;
          }
          case 104: {
            CombineCount = input.ReadUInt32();
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
          case 18: {
            resultItemList_.AddEntriesFrom(ref input, _repeated_resultItemList_codec);
            break;
          }
          case 26: {
            costItemList_.AddEntriesFrom(ref input, _repeated_costItemList_codec);
            break;
          }
          case 50: {
            totalExtraItemList_.AddEntriesFrom(ref input, _repeated_totalExtraItemList_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74: {
            totalRandomItemList_.AddEntriesFrom(ref input, _repeated_totalRandomItemList_codec);
            break;
          }
          case 80: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 88: {
            CombineId = input.ReadUInt32();
            break;
          }
          case 98: {
            totalReturnItemList_.AddEntriesFrom(ref input, _repeated_totalReturnItemList_codec);
            break;
          }
          case 104: {
            CombineCount = input.ReadUInt32();
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