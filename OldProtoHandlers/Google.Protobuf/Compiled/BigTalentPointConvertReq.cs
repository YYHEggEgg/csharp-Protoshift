// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BigTalentPointConvertReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BigTalentPointConvertReq.proto</summary>
public static partial class BigTalentPointConvertReqReflection {

  #region Descriptor
  /// <summary>File descriptor for BigTalentPointConvertReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BigTalentPointConvertReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5CaWdUYWxlbnRQb2ludENvbnZlcnRSZXEucHJvdG8iRwoYQmlnVGFsZW50",
          "UG9pbnRDb252ZXJ0UmVxEhYKDml0ZW1fZ3VpZF9saXN0GAYgAygEEhMKC2F2",
          "YXRhcl9ndWlkGAMgASgEQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJv",
          "dG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BigTalentPointConvertReq), global::BigTalentPointConvertReq.Parser, new[]{ "ItemGuidList", "AvatarGuid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 1007
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class BigTalentPointConvertReq : pb::IMessage<BigTalentPointConvertReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BigTalentPointConvertReq> _parser = new pb::MessageParser<BigTalentPointConvertReq>(() => new BigTalentPointConvertReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BigTalentPointConvertReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BigTalentPointConvertReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BigTalentPointConvertReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BigTalentPointConvertReq(BigTalentPointConvertReq other) : this() {
    itemGuidList_ = other.itemGuidList_.Clone();
    avatarGuid_ = other.avatarGuid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BigTalentPointConvertReq Clone() {
    return new BigTalentPointConvertReq(this);
  }

  /// <summary>Field number for the "item_guid_list" field.</summary>
  public const int ItemGuidListFieldNumber = 6;
  private static readonly pb::FieldCodec<ulong> _repeated_itemGuidList_codec
      = pb::FieldCodec.ForUInt64(50);
  private readonly pbc::RepeatedField<ulong> itemGuidList_ = new pbc::RepeatedField<ulong>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<ulong> ItemGuidList {
    get { return itemGuidList_; }
  }

  /// <summary>Field number for the "avatar_guid" field.</summary>
  public const int AvatarGuidFieldNumber = 3;
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
    return Equals(other as BigTalentPointConvertReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BigTalentPointConvertReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!itemGuidList_.Equals(other.itemGuidList_)) return false;
    if (AvatarGuid != other.AvatarGuid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= itemGuidList_.GetHashCode();
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
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(24);
      output.WriteUInt64(AvatarGuid);
    }
    itemGuidList_.WriteTo(output, _repeated_itemGuidList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(24);
      output.WriteUInt64(AvatarGuid);
    }
    itemGuidList_.WriteTo(ref output, _repeated_itemGuidList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += itemGuidList_.CalculateSize(_repeated_itemGuidList_codec);
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
  public void MergeFrom(BigTalentPointConvertReq other) {
    if (other == null) {
      return;
    }
    itemGuidList_.Add(other.itemGuidList_);
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
        case 24: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 50:
        case 48: {
          itemGuidList_.AddEntriesFrom(input, _repeated_itemGuidList_codec);
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
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 50:
        case 48: {
          itemGuidList_.AddEntriesFrom(ref input, _repeated_itemGuidList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code