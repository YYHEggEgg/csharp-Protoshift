// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeCityReputationExploreRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TakeCityReputationExploreRewardRsp.proto</summary>
public static partial class TakeCityReputationExploreRewardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for TakeCityReputationExploreRewardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TakeCityReputationExploreRewardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CihUYWtlQ2l0eVJlcHV0YXRpb25FeHBsb3JlUmV3YXJkUnNwLnByb3RvGg9J",
          "dGVtUGFyYW0ucHJvdG8ifgoiVGFrZUNpdHlSZXB1dGF0aW9uRXhwbG9yZVJl",
          "d2FyZFJzcBIXCg9leHBsb3JlX2lkX2xpc3QYCCADKA0SHQoJaXRlbV9saXN0",
          "GAwgAygLMgouSXRlbVBhcmFtEg8KB3JldGNvZGUYBiABKAUSDwoHY2l0eV9p",
          "ZBgNIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TakeCityReputationExploreRewardRsp), global::TakeCityReputationExploreRewardRsp.Parser, new[]{ "ExploreIdList", "ItemList", "Retcode", "CityId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2881
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class TakeCityReputationExploreRewardRsp : pb::IMessage<TakeCityReputationExploreRewardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TakeCityReputationExploreRewardRsp> _parser = new pb::MessageParser<TakeCityReputationExploreRewardRsp>(() => new TakeCityReputationExploreRewardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TakeCityReputationExploreRewardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TakeCityReputationExploreRewardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeCityReputationExploreRewardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeCityReputationExploreRewardRsp(TakeCityReputationExploreRewardRsp other) : this() {
    exploreIdList_ = other.exploreIdList_.Clone();
    itemList_ = other.itemList_.Clone();
    retcode_ = other.retcode_;
    cityId_ = other.cityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TakeCityReputationExploreRewardRsp Clone() {
    return new TakeCityReputationExploreRewardRsp(this);
  }

  /// <summary>Field number for the "explore_id_list" field.</summary>
  public const int ExploreIdListFieldNumber = 8;
  private static readonly pb::FieldCodec<uint> _repeated_exploreIdList_codec
      = pb::FieldCodec.ForUInt32(66);
  private readonly pbc::RepeatedField<uint> exploreIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ExploreIdList {
    get { return exploreIdList_; }
  }

  /// <summary>Field number for the "item_list" field.</summary>
  public const int ItemListFieldNumber = 12;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_itemList_codec
      = pb::FieldCodec.ForMessage(98, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> itemList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> ItemList {
    get { return itemList_; }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 6;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "city_id" field.</summary>
  public const int CityIdFieldNumber = 13;
  private uint cityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CityId {
    get { return cityId_; }
    set {
      cityId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TakeCityReputationExploreRewardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TakeCityReputationExploreRewardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!exploreIdList_.Equals(other.exploreIdList_)) return false;
    if(!itemList_.Equals(other.itemList_)) return false;
    if (Retcode != other.Retcode) return false;
    if (CityId != other.CityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= exploreIdList_.GetHashCode();
    hash ^= itemList_.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (CityId != 0) hash ^= CityId.GetHashCode();
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
      output.WriteRawTag(48);
      output.WriteInt32(Retcode);
    }
    exploreIdList_.WriteTo(output, _repeated_exploreIdList_codec);
    itemList_.WriteTo(output, _repeated_itemList_codec);
    if (CityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(CityId);
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
    if (Retcode != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(Retcode);
    }
    exploreIdList_.WriteTo(ref output, _repeated_exploreIdList_codec);
    itemList_.WriteTo(ref output, _repeated_itemList_codec);
    if (CityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(CityId);
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
    size += exploreIdList_.CalculateSize(_repeated_exploreIdList_codec);
    size += itemList_.CalculateSize(_repeated_itemList_codec);
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (CityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TakeCityReputationExploreRewardRsp other) {
    if (other == null) {
      return;
    }
    exploreIdList_.Add(other.exploreIdList_);
    itemList_.Add(other.itemList_);
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.CityId != 0) {
      CityId = other.CityId;
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
        case 48: {
          Retcode = input.ReadInt32();
          break;
        }
        case 66:
        case 64: {
          exploreIdList_.AddEntriesFrom(input, _repeated_exploreIdList_codec);
          break;
        }
        case 98: {
          itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
          break;
        }
        case 104: {
          CityId = input.ReadUInt32();
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
        case 48: {
          Retcode = input.ReadInt32();
          break;
        }
        case 66:
        case 64: {
          exploreIdList_.AddEntriesFrom(ref input, _repeated_exploreIdList_codec);
          break;
        }
        case 98: {
          itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
          break;
        }
        case 104: {
          CityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
