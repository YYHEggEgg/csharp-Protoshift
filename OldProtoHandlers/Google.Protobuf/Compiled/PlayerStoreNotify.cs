// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerStoreNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from PlayerStoreNotify.proto</summary>
  public static partial class PlayerStoreNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerStoreNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerStoreNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQbGF5ZXJTdG9yZU5vdGlmeS5wcm90bxoKSXRlbS5wcm90bxoPU3RvcmVU",
            "eXBlLnByb3RvImMKEVBsYXllclN0b3JlTm90aWZ5EhgKCWl0ZW1fbGlzdBgP",
            "IAMoCzIFLkl0ZW0SFAoMd2VpZ2h0X2xpbWl0GAggASgNEh4KCnN0b3JlX3R5",
            "cGUYAiABKA4yCi5TdG9yZVR5cGVCDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ItemReflection.Descriptor, global::OldProtos.StoreTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.PlayerStoreNotify), global::OldProtos.PlayerStoreNotify.Parser, new[]{ "ItemList", "WeightLimit", "StoreType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 672
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerStoreNotify : pb::IMessage<PlayerStoreNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerStoreNotify> _parser = new pb::MessageParser<PlayerStoreNotify>(() => new PlayerStoreNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerStoreNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.PlayerStoreNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStoreNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStoreNotify(PlayerStoreNotify other) : this() {
      itemList_ = other.itemList_.Clone();
      weightLimit_ = other.weightLimit_;
      storeType_ = other.storeType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStoreNotify Clone() {
      return new PlayerStoreNotify(this);
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::OldProtos.Item> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(122, global::OldProtos.Item.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.Item> itemList_ = new pbc::RepeatedField<global::OldProtos.Item>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.Item> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "weight_limit" field.</summary>
    public const int WeightLimitFieldNumber = 8;
    private uint weightLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeightLimit {
      get { return weightLimit_; }
      set {
        weightLimit_ = value;
      }
    }

    /// <summary>Field number for the "store_type" field.</summary>
    public const int StoreTypeFieldNumber = 2;
    private global::OldProtos.StoreType storeType_ = global::OldProtos.StoreType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.StoreType StoreType {
      get { return storeType_; }
      set {
        storeType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerStoreNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerStoreNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!itemList_.Equals(other.itemList_)) return false;
      if (WeightLimit != other.WeightLimit) return false;
      if (StoreType != other.StoreType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= itemList_.GetHashCode();
      if (WeightLimit != 0) hash ^= WeightLimit.GetHashCode();
      if (StoreType != global::OldProtos.StoreType.None) hash ^= StoreType.GetHashCode();
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
      if (StoreType != global::OldProtos.StoreType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) StoreType);
      }
      if (WeightLimit != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WeightLimit);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StoreType != global::OldProtos.StoreType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) StoreType);
      }
      if (WeightLimit != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WeightLimit);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (WeightLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeightLimit);
      }
      if (StoreType != global::OldProtos.StoreType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StoreType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerStoreNotify other) {
      if (other == null) {
        return;
      }
      itemList_.Add(other.itemList_);
      if (other.WeightLimit != 0) {
        WeightLimit = other.WeightLimit;
      }
      if (other.StoreType != global::OldProtos.StoreType.None) {
        StoreType = other.StoreType;
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
          case 16: {
            StoreType = (global::OldProtos.StoreType) input.ReadEnum();
            break;
          }
          case 64: {
            WeightLimit = input.ReadUInt32();
            break;
          }
          case 122: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
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
          case 16: {
            StoreType = (global::OldProtos.StoreType) input.ReadEnum();
            break;
          }
          case 64: {
            WeightLimit = input.ReadUInt32();
            break;
          }
          case 122: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
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
