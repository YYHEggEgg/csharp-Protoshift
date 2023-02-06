// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerCompoundMaterialBoostReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PlayerCompoundMaterialBoostReq.proto</summary>
public static partial class PlayerCompoundMaterialBoostReqReflection {

  #region Descriptor
  /// <summary>File descriptor for PlayerCompoundMaterialBoostReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlayerCompoundMaterialBoostReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiRQbGF5ZXJDb21wb3VuZE1hdGVyaWFsQm9vc3RSZXEucHJvdG8ilQEKHlBs",
          "YXllckNvbXBvdW5kTWF0ZXJpYWxCb29zdFJlcRIUCgxpc19ib29zdF9hbGwY",
          "CCABKAgSIAoYdGFyZ2V0X2NvbXBvdW5kX2dyb3VwX2lkGA4gASgNEhsKE2Nv",
          "bnN1bWVfbWF0ZXJpYWxfaWQYCSABKA0SHgoWY29uc3VtZV9tYXRlcmlhbF9j",
          "b3VudBgBIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZw",
          "cm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PlayerCompoundMaterialBoostReq), global::PlayerCompoundMaterialBoostReq.Parser, new[]{ "IsBoostAll", "TargetCompoundGroupId", "ConsumeMaterialId", "ConsumeMaterialCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 185
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class PlayerCompoundMaterialBoostReq : pb::IMessage<PlayerCompoundMaterialBoostReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlayerCompoundMaterialBoostReq> _parser = new pb::MessageParser<PlayerCompoundMaterialBoostReq>(() => new PlayerCompoundMaterialBoostReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlayerCompoundMaterialBoostReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlayerCompoundMaterialBoostReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerCompoundMaterialBoostReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerCompoundMaterialBoostReq(PlayerCompoundMaterialBoostReq other) : this() {
    isBoostAll_ = other.isBoostAll_;
    targetCompoundGroupId_ = other.targetCompoundGroupId_;
    consumeMaterialId_ = other.consumeMaterialId_;
    consumeMaterialCount_ = other.consumeMaterialCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlayerCompoundMaterialBoostReq Clone() {
    return new PlayerCompoundMaterialBoostReq(this);
  }

  /// <summary>Field number for the "is_boost_all" field.</summary>
  public const int IsBoostAllFieldNumber = 8;
  private bool isBoostAll_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsBoostAll {
    get { return isBoostAll_; }
    set {
      isBoostAll_ = value;
    }
  }

  /// <summary>Field number for the "target_compound_group_id" field.</summary>
  public const int TargetCompoundGroupIdFieldNumber = 14;
  private uint targetCompoundGroupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TargetCompoundGroupId {
    get { return targetCompoundGroupId_; }
    set {
      targetCompoundGroupId_ = value;
    }
  }

  /// <summary>Field number for the "consume_material_id" field.</summary>
  public const int ConsumeMaterialIdFieldNumber = 9;
  private uint consumeMaterialId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConsumeMaterialId {
    get { return consumeMaterialId_; }
    set {
      consumeMaterialId_ = value;
    }
  }

  /// <summary>Field number for the "consume_material_count" field.</summary>
  public const int ConsumeMaterialCountFieldNumber = 1;
  private uint consumeMaterialCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConsumeMaterialCount {
    get { return consumeMaterialCount_; }
    set {
      consumeMaterialCount_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlayerCompoundMaterialBoostReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlayerCompoundMaterialBoostReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsBoostAll != other.IsBoostAll) return false;
    if (TargetCompoundGroupId != other.TargetCompoundGroupId) return false;
    if (ConsumeMaterialId != other.ConsumeMaterialId) return false;
    if (ConsumeMaterialCount != other.ConsumeMaterialCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsBoostAll != false) hash ^= IsBoostAll.GetHashCode();
    if (TargetCompoundGroupId != 0) hash ^= TargetCompoundGroupId.GetHashCode();
    if (ConsumeMaterialId != 0) hash ^= ConsumeMaterialId.GetHashCode();
    if (ConsumeMaterialCount != 0) hash ^= ConsumeMaterialCount.GetHashCode();
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
    if (ConsumeMaterialCount != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ConsumeMaterialCount);
    }
    if (IsBoostAll != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsBoostAll);
    }
    if (ConsumeMaterialId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ConsumeMaterialId);
    }
    if (TargetCompoundGroupId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(TargetCompoundGroupId);
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
    if (ConsumeMaterialCount != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ConsumeMaterialCount);
    }
    if (IsBoostAll != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsBoostAll);
    }
    if (ConsumeMaterialId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(ConsumeMaterialId);
    }
    if (TargetCompoundGroupId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(TargetCompoundGroupId);
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
    if (IsBoostAll != false) {
      size += 1 + 1;
    }
    if (TargetCompoundGroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetCompoundGroupId);
    }
    if (ConsumeMaterialId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConsumeMaterialId);
    }
    if (ConsumeMaterialCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConsumeMaterialCount);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlayerCompoundMaterialBoostReq other) {
    if (other == null) {
      return;
    }
    if (other.IsBoostAll != false) {
      IsBoostAll = other.IsBoostAll;
    }
    if (other.TargetCompoundGroupId != 0) {
      TargetCompoundGroupId = other.TargetCompoundGroupId;
    }
    if (other.ConsumeMaterialId != 0) {
      ConsumeMaterialId = other.ConsumeMaterialId;
    }
    if (other.ConsumeMaterialCount != 0) {
      ConsumeMaterialCount = other.ConsumeMaterialCount;
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
        case 8: {
          ConsumeMaterialCount = input.ReadUInt32();
          break;
        }
        case 64: {
          IsBoostAll = input.ReadBool();
          break;
        }
        case 72: {
          ConsumeMaterialId = input.ReadUInt32();
          break;
        }
        case 112: {
          TargetCompoundGroupId = input.ReadUInt32();
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
          ConsumeMaterialCount = input.ReadUInt32();
          break;
        }
        case 64: {
          IsBoostAll = input.ReadBool();
          break;
        }
        case 72: {
          ConsumeMaterialId = input.ReadUInt32();
          break;
        }
        case 112: {
          TargetCompoundGroupId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code