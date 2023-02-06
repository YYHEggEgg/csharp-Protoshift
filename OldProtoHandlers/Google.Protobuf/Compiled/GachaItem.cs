// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GachaItem.proto</summary>
public static partial class GachaItemReflection {

  #region Descriptor
  /// <summary>File descriptor for GachaItem.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GachaItemReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9HYWNoYUl0ZW0ucHJvdG8aF0dhY2hhVHJhbnNmZXJJdGVtLnByb3RvGg9J",
          "dGVtUGFyYW0ucHJvdG8irgEKCUdhY2hhSXRlbRIeCgpnYWNoYV9pdGVtGAcg",
          "ASgLMgouSXRlbVBhcmFtEhkKEWlzX2dhY2hhX2l0ZW1fbmV3GAYgASgIEhUK",
          "DWlzX2ZsYXNoX2NhcmQYCCABKAgSIwoPdG9rZW5faXRlbV9saXN0GAkgAygL",
          "MgouSXRlbVBhcmFtEioKDnRyYW5zZmVyX2l0ZW1zGAwgAygLMhIuR2FjaGFU",
          "cmFuc2Zlckl0ZW1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GachaTransferItemReflection.Descriptor, global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GachaItem), global::GachaItem.Parser, new[]{ "GachaItem_", "IsGachaItemNew", "IsFlashCard", "TokenItemList", "TransferItems" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GachaItem : pb::IMessage<GachaItem>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GachaItem> _parser = new pb::MessageParser<GachaItem>(() => new GachaItem());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GachaItem> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GachaItemReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GachaItem() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GachaItem(GachaItem other) : this() {
    gachaItem_ = other.gachaItem_ != null ? other.gachaItem_.Clone() : null;
    isGachaItemNew_ = other.isGachaItemNew_;
    isFlashCard_ = other.isFlashCard_;
    tokenItemList_ = other.tokenItemList_.Clone();
    transferItems_ = other.transferItems_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GachaItem Clone() {
    return new GachaItem(this);
  }

  /// <summary>Field number for the "gacha_item" field.</summary>
  public const int GachaItem_FieldNumber = 7;
  private global::ItemParam gachaItem_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ItemParam GachaItem_ {
    get { return gachaItem_; }
    set {
      gachaItem_ = value;
    }
  }

  /// <summary>Field number for the "is_gacha_item_new" field.</summary>
  public const int IsGachaItemNewFieldNumber = 6;
  private bool isGachaItemNew_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsGachaItemNew {
    get { return isGachaItemNew_; }
    set {
      isGachaItemNew_ = value;
    }
  }

  /// <summary>Field number for the "is_flash_card" field.</summary>
  public const int IsFlashCardFieldNumber = 8;
  private bool isFlashCard_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFlashCard {
    get { return isFlashCard_; }
    set {
      isFlashCard_ = value;
    }
  }

  /// <summary>Field number for the "token_item_list" field.</summary>
  public const int TokenItemListFieldNumber = 9;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_tokenItemList_codec
      = pb::FieldCodec.ForMessage(74, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> tokenItemList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> TokenItemList {
    get { return tokenItemList_; }
  }

  /// <summary>Field number for the "transfer_items" field.</summary>
  public const int TransferItemsFieldNumber = 12;
  private static readonly pb::FieldCodec<global::GachaTransferItem> _repeated_transferItems_codec
      = pb::FieldCodec.ForMessage(98, global::GachaTransferItem.Parser);
  private readonly pbc::RepeatedField<global::GachaTransferItem> transferItems_ = new pbc::RepeatedField<global::GachaTransferItem>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GachaTransferItem> TransferItems {
    get { return transferItems_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GachaItem);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GachaItem other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(GachaItem_, other.GachaItem_)) return false;
    if (IsGachaItemNew != other.IsGachaItemNew) return false;
    if (IsFlashCard != other.IsFlashCard) return false;
    if(!tokenItemList_.Equals(other.tokenItemList_)) return false;
    if(!transferItems_.Equals(other.transferItems_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (gachaItem_ != null) hash ^= GachaItem_.GetHashCode();
    if (IsGachaItemNew != false) hash ^= IsGachaItemNew.GetHashCode();
    if (IsFlashCard != false) hash ^= IsFlashCard.GetHashCode();
    hash ^= tokenItemList_.GetHashCode();
    hash ^= transferItems_.GetHashCode();
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
    if (IsGachaItemNew != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsGachaItemNew);
    }
    if (gachaItem_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(GachaItem_);
    }
    if (IsFlashCard != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsFlashCard);
    }
    tokenItemList_.WriteTo(output, _repeated_tokenItemList_codec);
    transferItems_.WriteTo(output, _repeated_transferItems_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (IsGachaItemNew != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsGachaItemNew);
    }
    if (gachaItem_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(GachaItem_);
    }
    if (IsFlashCard != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsFlashCard);
    }
    tokenItemList_.WriteTo(ref output, _repeated_tokenItemList_codec);
    transferItems_.WriteTo(ref output, _repeated_transferItems_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (gachaItem_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(GachaItem_);
    }
    if (IsGachaItemNew != false) {
      size += 1 + 1;
    }
    if (IsFlashCard != false) {
      size += 1 + 1;
    }
    size += tokenItemList_.CalculateSize(_repeated_tokenItemList_codec);
    size += transferItems_.CalculateSize(_repeated_transferItems_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GachaItem other) {
    if (other == null) {
      return;
    }
    if (other.gachaItem_ != null) {
      if (gachaItem_ == null) {
        GachaItem_ = new global::ItemParam();
      }
      GachaItem_.MergeFrom(other.GachaItem_);
    }
    if (other.IsGachaItemNew != false) {
      IsGachaItemNew = other.IsGachaItemNew;
    }
    if (other.IsFlashCard != false) {
      IsFlashCard = other.IsFlashCard;
    }
    tokenItemList_.Add(other.tokenItemList_);
    transferItems_.Add(other.transferItems_);
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
          IsGachaItemNew = input.ReadBool();
          break;
        }
        case 58: {
          if (gachaItem_ == null) {
            GachaItem_ = new global::ItemParam();
          }
          input.ReadMessage(GachaItem_);
          break;
        }
        case 64: {
          IsFlashCard = input.ReadBool();
          break;
        }
        case 74: {
          tokenItemList_.AddEntriesFrom(input, _repeated_tokenItemList_codec);
          break;
        }
        case 98: {
          transferItems_.AddEntriesFrom(input, _repeated_transferItems_codec);
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
          IsGachaItemNew = input.ReadBool();
          break;
        }
        case 58: {
          if (gachaItem_ == null) {
            GachaItem_ = new global::ItemParam();
          }
          input.ReadMessage(GachaItem_);
          break;
        }
        case 64: {
          IsFlashCard = input.ReadBool();
          break;
        }
        case 74: {
          tokenItemList_.AddEntriesFrom(ref input, _repeated_tokenItemList_codec);
          break;
        }
        case 98: {
          transferItems_.AddEntriesFrom(ref input, _repeated_transferItems_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code