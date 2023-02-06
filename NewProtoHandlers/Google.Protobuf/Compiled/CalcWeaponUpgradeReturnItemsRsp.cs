// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CalcWeaponUpgradeReturnItemsRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CalcWeaponUpgradeReturnItemsRsp.proto</summary>
public static partial class CalcWeaponUpgradeReturnItemsRspReflection {

  #region Descriptor
  /// <summary>File descriptor for CalcWeaponUpgradeReturnItemsRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CalcWeaponUpgradeReturnItemsRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVDYWxjV2VhcG9uVXBncmFkZVJldHVybkl0ZW1zUnNwLnByb3RvGg9JdGVt",
          "UGFyYW0ucHJvdG8icwofQ2FsY1dlYXBvblVwZ3JhZGVSZXR1cm5JdGVtc1Jz",
          "cBIaChJ0YXJnZXRfd2VhcG9uX2d1aWQYAyABKAQSIwoPaXRlbV9wYXJhbV9s",
          "aXN0GAogAygLMgouSXRlbVBhcmFtEg8KB3JldGNvZGUYBCABKAVCFgoUb3Jn",
          "LnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ItemParamReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CalcWeaponUpgradeReturnItemsRsp), global::CalcWeaponUpgradeReturnItemsRsp.Parser, new[]{ "TargetWeaponGuid", "ItemParamList", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 652;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class CalcWeaponUpgradeReturnItemsRsp : pb::IMessage<CalcWeaponUpgradeReturnItemsRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CalcWeaponUpgradeReturnItemsRsp> _parser = new pb::MessageParser<CalcWeaponUpgradeReturnItemsRsp>(() => new CalcWeaponUpgradeReturnItemsRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CalcWeaponUpgradeReturnItemsRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CalcWeaponUpgradeReturnItemsRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CalcWeaponUpgradeReturnItemsRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CalcWeaponUpgradeReturnItemsRsp(CalcWeaponUpgradeReturnItemsRsp other) : this() {
    targetWeaponGuid_ = other.targetWeaponGuid_;
    itemParamList_ = other.itemParamList_.Clone();
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CalcWeaponUpgradeReturnItemsRsp Clone() {
    return new CalcWeaponUpgradeReturnItemsRsp(this);
  }

  /// <summary>Field number for the "target_weapon_guid" field.</summary>
  public const int TargetWeaponGuidFieldNumber = 3;
  private ulong targetWeaponGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong TargetWeaponGuid {
    get { return targetWeaponGuid_; }
    set {
      targetWeaponGuid_ = value;
    }
  }

  /// <summary>Field number for the "item_param_list" field.</summary>
  public const int ItemParamListFieldNumber = 10;
  private static readonly pb::FieldCodec<global::ItemParam> _repeated_itemParamList_codec
      = pb::FieldCodec.ForMessage(82, global::ItemParam.Parser);
  private readonly pbc::RepeatedField<global::ItemParam> itemParamList_ = new pbc::RepeatedField<global::ItemParam>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ItemParam> ItemParamList {
    get { return itemParamList_; }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 4;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CalcWeaponUpgradeReturnItemsRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CalcWeaponUpgradeReturnItemsRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (TargetWeaponGuid != other.TargetWeaponGuid) return false;
    if(!itemParamList_.Equals(other.itemParamList_)) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (TargetWeaponGuid != 0UL) hash ^= TargetWeaponGuid.GetHashCode();
    hash ^= itemParamList_.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (TargetWeaponGuid != 0UL) {
      output.WriteRawTag(24);
      output.WriteUInt64(TargetWeaponGuid);
    }
    if (Retcode != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(Retcode);
    }
    itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (TargetWeaponGuid != 0UL) {
      output.WriteRawTag(24);
      output.WriteUInt64(TargetWeaponGuid);
    }
    if (Retcode != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(Retcode);
    }
    itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (TargetWeaponGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetWeaponGuid);
    }
    size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CalcWeaponUpgradeReturnItemsRsp other) {
    if (other == null) {
      return;
    }
    if (other.TargetWeaponGuid != 0UL) {
      TargetWeaponGuid = other.TargetWeaponGuid;
    }
    itemParamList_.Add(other.itemParamList_);
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
          TargetWeaponGuid = input.ReadUInt64();
          break;
        }
        case 32: {
          Retcode = input.ReadInt32();
          break;
        }
        case 82: {
          itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
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
          TargetWeaponGuid = input.ReadUInt64();
          break;
        }
        case 32: {
          Retcode = input.ReadInt32();
          break;
        }
        case 82: {
          itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
