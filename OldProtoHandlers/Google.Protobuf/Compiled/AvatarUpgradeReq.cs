// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarUpgradeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AvatarUpgradeReq.proto</summary>
public static partial class AvatarUpgradeReqReflection {

  #region Descriptor
  /// <summary>File descriptor for AvatarUpgradeReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AvatarUpgradeReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZBdmF0YXJVcGdyYWRlUmVxLnByb3RvIkcKEEF2YXRhclVwZ3JhZGVSZXES",
          "EwoLYXZhdGFyX2d1aWQYBiABKAQSDQoFY291bnQYAiABKA0SDwoHaXRlbV9p",
          "ZBgFIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AvatarUpgradeReq), global::AvatarUpgradeReq.Parser, new[]{ "AvatarGuid", "Count", "ItemId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 1770
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class AvatarUpgradeReq : pb::IMessage<AvatarUpgradeReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AvatarUpgradeReq> _parser = new pb::MessageParser<AvatarUpgradeReq>(() => new AvatarUpgradeReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AvatarUpgradeReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AvatarUpgradeReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarUpgradeReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarUpgradeReq(AvatarUpgradeReq other) : this() {
    avatarGuid_ = other.avatarGuid_;
    count_ = other.count_;
    itemId_ = other.itemId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarUpgradeReq Clone() {
    return new AvatarUpgradeReq(this);
  }

  /// <summary>Field number for the "avatar_guid" field.</summary>
  public const int AvatarGuidFieldNumber = 6;
  private ulong avatarGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong AvatarGuid {
    get { return avatarGuid_; }
    set {
      avatarGuid_ = value;
    }
  }

  /// <summary>Field number for the "count" field.</summary>
  public const int CountFieldNumber = 2;
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
  public const int ItemIdFieldNumber = 5;
  private uint itemId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ItemId {
    get { return itemId_; }
    set {
      itemId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AvatarUpgradeReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AvatarUpgradeReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (AvatarGuid != other.AvatarGuid) return false;
    if (Count != other.Count) return false;
    if (ItemId != other.ItemId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
    if (Count != 0) hash ^= Count.GetHashCode();
    if (ItemId != 0) hash ^= ItemId.GetHashCode();
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
    if (Count != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Count);
    }
    if (ItemId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ItemId);
    }
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(AvatarGuid);
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
    if (Count != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Count);
    }
    if (ItemId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ItemId);
    }
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(48);
      output.WriteUInt64(AvatarGuid);
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
    if (AvatarGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
    }
    if (Count != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
    }
    if (ItemId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AvatarUpgradeReq other) {
    if (other == null) {
      return;
    }
    if (other.AvatarGuid != 0UL) {
      AvatarGuid = other.AvatarGuid;
    }
    if (other.Count != 0) {
      Count = other.Count;
    }
    if (other.ItemId != 0) {
      ItemId = other.ItemId;
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
          Count = input.ReadUInt32();
          break;
        }
        case 40: {
          ItemId = input.ReadUInt32();
          break;
        }
        case 48: {
          AvatarGuid = input.ReadUInt64();
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
          Count = input.ReadUInt32();
          break;
        }
        case 40: {
          ItemId = input.ReadUInt32();
          break;
        }
        case 48: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
