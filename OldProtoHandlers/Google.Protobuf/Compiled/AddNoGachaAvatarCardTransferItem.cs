// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddNoGachaAvatarCardTransferItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AddNoGachaAvatarCardTransferItem.proto</summary>
  public static partial class AddNoGachaAvatarCardTransferItemReflection {

    #region Descriptor
    /// <summary>File descriptor for AddNoGachaAvatarCardTransferItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddNoGachaAvatarCardTransferItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZBZGROb0dhY2hhQXZhdGFyQ2FyZFRyYW5zZmVySXRlbS5wcm90byJSCiBB",
            "ZGROb0dhY2hhQXZhdGFyQ2FyZFRyYW5zZmVySXRlbRINCgVjb3VudBgJIAEo",
            "DRIPCgdpdGVtX2lkGAYgASgNEg4KBmlzX25ldxgPIAEoCEIMqgIJT2xkUHJv",
            "dG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AddNoGachaAvatarCardTransferItem), global::OldProtos.AddNoGachaAvatarCardTransferItem.Parser, new[]{ "Count", "ItemId", "IsNew" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddNoGachaAvatarCardTransferItem : pb::IMessage<AddNoGachaAvatarCardTransferItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddNoGachaAvatarCardTransferItem> _parser = new pb::MessageParser<AddNoGachaAvatarCardTransferItem>(() => new AddNoGachaAvatarCardTransferItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddNoGachaAvatarCardTransferItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.AddNoGachaAvatarCardTransferItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddNoGachaAvatarCardTransferItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddNoGachaAvatarCardTransferItem(AddNoGachaAvatarCardTransferItem other) : this() {
      count_ = other.count_;
      itemId_ = other.itemId_;
      isNew_ = other.isNew_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddNoGachaAvatarCardTransferItem Clone() {
      return new AddNoGachaAvatarCardTransferItem(this);
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 9;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 6;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "is_new" field.</summary>
    public const int IsNewFieldNumber = 15;
    private bool isNew_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNew {
      get { return isNew_; }
      set {
        isNew_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddNoGachaAvatarCardTransferItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddNoGachaAvatarCardTransferItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Count != other.Count) return false;
      if (ItemId != other.ItemId) return false;
      if (IsNew != other.IsNew) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Count != 0) hash ^= Count.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (IsNew != false) hash ^= IsNew.GetHashCode();
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
      if (ItemId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ItemId);
      }
      if (Count != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Count);
      }
      if (IsNew != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsNew);
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
      if (ItemId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ItemId);
      }
      if (Count != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Count);
      }
      if (IsNew != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsNew);
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
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (IsNew != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddNoGachaAvatarCardTransferItem other) {
      if (other == null) {
        return;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.IsNew != false) {
        IsNew = other.IsNew;
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            Count = input.ReadUInt32();
            break;
          }
          case 120: {
            IsNew = input.ReadBool();
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 72: {
            Count = input.ReadUInt32();
            break;
          }
          case 120: {
            IsNew = input.ReadBool();
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
