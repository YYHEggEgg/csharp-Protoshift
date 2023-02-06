// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerCookRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PlayerCookRsp.proto</summary>
public static partial class PlayerCookRspReflection {

  #region Descriptor
  /// <summary>File descriptor for PlayerCookRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlayerCookRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNQbGF5ZXJDb29rUnNwLnByb3RvGhRDb29rUmVjaXBlRGF0YS5wcm90bxoP",
          "SXRlbVBhcmFtLnByb3RvIrMBCg1QbGF5ZXJDb29rUnNwEiMKD2V4dHJhX2l0",
          "ZW1fbGlzdBgPIAMoCzIKLkl0ZW1QYXJhbRISCgpjb29rX2NvdW50GAwgASgN",
          "Eh0KCWl0ZW1fbGlzdBgLIAMoCzIKLkl0ZW1QYXJhbRIPCgdyZXRjb2RlGAMg",
          "ASgFEhMKC3F0ZV9xdWFsaXR5GAUgASgNEiQKC3JlY2lwZV9kYXRhGAcgASgL",
          "Mg8uQ29va1JlY2lwZURhdGFCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRw",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CookRecipeDataReflection.Descriptor, global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PlayerCookRsp), global::PlayerCookRsp.Parser, new[]{ "ExtraItemList", "CookCount", "ItemList", "Retcode", "QteQuality", "RecipeData" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 188
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class PlayerCookRsp : pb::IMessage<PlayerCookRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlayerCookRsp> _parser = new pb::MessageParser<PlayerCookRsp>(() => new PlayerCookRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlayerCookRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlayerCookRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerCookRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerCookRsp(PlayerCookRsp other) : this() {
    extraItemList_ = other.extraItemList_.Clone();
    cookCount_ = other.cookCount_;
    itemList_ = other.itemList_.Clone();
    retcode_ = other.retcode_;
    qteQuality_ = other.qteQuality_;
    recipeData_ = other.recipeData_ != null ? other.recipeData_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerCookRsp Clone() {
    return new PlayerCookRsp(this);
  }

  /// <summary>Field number for the "extra_item_list" field.</summary>
  public const int ExtraItemListFieldNumber = 15;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_extraItemList_codec
      = pb::FieldCodec.ForMessage(122, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> extraItemList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> ExtraItemList {
    get { return extraItemList_; }
  }

  /// <summary>Field number for the "cook_count" field.</summary>
  public const int CookCountFieldNumber = 12;
  private uint cookCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CookCount {
    get { return cookCount_; }
    set {
      cookCount_ = value;
    }
  }

  /// <summary>Field number for the "item_list" field.</summary>
  public const int ItemListFieldNumber = 11;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_itemList_codec
      = pb::FieldCodec.ForMessage(90, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> itemList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> ItemList {
    get { return itemList_; }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 3;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "qte_quality" field.</summary>
  public const int QteQualityFieldNumber = 5;
  private uint qteQuality_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint QteQuality {
    get { return qteQuality_; }
    set {
      qteQuality_ = value;
    }
  }

  /// <summary>Field number for the "recipe_data" field.</summary>
  public const int RecipeDataFieldNumber = 7;
  private global::CookRecipeData recipeData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CookRecipeData RecipeData {
    get { return recipeData_; }
    set {
      recipeData_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlayerCookRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlayerCookRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!extraItemList_.Equals(other.extraItemList_)) return false;
    if (CookCount != other.CookCount) return false;
    if(!itemList_.Equals(other.itemList_)) return false;
    if (Retcode != other.Retcode) return false;
    if (QteQuality != other.QteQuality) return false;
    if (!object.Equals(RecipeData, other.RecipeData)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= extraItemList_.GetHashCode();
    if (CookCount != 0) hash ^= CookCount.GetHashCode();
    hash ^= itemList_.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (QteQuality != 0) hash ^= QteQuality.GetHashCode();
    if (recipeData_ != null) hash ^= RecipeData.GetHashCode();
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
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (QteQuality != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(QteQuality);
    }
    if (recipeData_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(RecipeData);
    }
    itemList_.WriteTo(output, _repeated_itemList_codec);
    if (CookCount != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CookCount);
    }
    extraItemList_.WriteTo(output, _repeated_extraItemList_codec);
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
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (QteQuality != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(QteQuality);
    }
    if (recipeData_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(RecipeData);
    }
    itemList_.WriteTo(ref output, _repeated_itemList_codec);
    if (CookCount != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CookCount);
    }
    extraItemList_.WriteTo(ref output, _repeated_extraItemList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += extraItemList_.CalculateSize(_repeated_extraItemList_codec);
    if (CookCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CookCount);
    }
    size += itemList_.CalculateSize(_repeated_itemList_codec);
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (QteQuality != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QteQuality);
    }
    if (recipeData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecipeData);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlayerCookRsp other) {
    if (other == null) {
      return;
    }
    extraItemList_.Add(other.extraItemList_);
    if (other.CookCount != 0) {
      CookCount = other.CookCount;
    }
    itemList_.Add(other.itemList_);
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.QteQuality != 0) {
      QteQuality = other.QteQuality;
    }
    if (other.recipeData_ != null) {
      if (recipeData_ == null) {
        RecipeData = new global::CookRecipeData();
      }
      RecipeData.MergeFrom(other.RecipeData);
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
        case 24: {
          Retcode = input.ReadInt32();
          break;
        }
        case 40: {
          QteQuality = input.ReadUInt32();
          break;
        }
        case 58: {
          if (recipeData_ == null) {
            RecipeData = new global::CookRecipeData();
          }
          input.ReadMessage(RecipeData);
          break;
        }
        case 90: {
          itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
          break;
        }
        case 96: {
          CookCount = input.ReadUInt32();
          break;
        }
        case 122: {
          extraItemList_.AddEntriesFrom(input, _repeated_extraItemList_codec);
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
        case 24: {
          Retcode = input.ReadInt32();
          break;
        }
        case 40: {
          QteQuality = input.ReadUInt32();
          break;
        }
        case 58: {
          if (recipeData_ == null) {
            RecipeData = new global::CookRecipeData();
          }
          input.ReadMessage(RecipeData);
          break;
        }
        case 90: {
          itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
          break;
        }
        case 96: {
          CookCount = input.ReadUInt32();
          break;
        }
        case 122: {
          extraItemList_.AddEntriesFrom(ref input, _repeated_extraItemList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code