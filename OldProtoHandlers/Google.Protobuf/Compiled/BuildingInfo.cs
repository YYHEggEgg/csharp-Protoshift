// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BuildingInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BuildingInfo.proto</summary>
public static partial class BuildingInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for BuildingInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BuildingInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChJCdWlsZGluZ0luZm8ucHJvdG8ikwEKDEJ1aWxkaW5nSW5mbxITCgtidWls",
          "ZGluZ19pZBgBIAEoDRIXCg9wb2ludF9jb25maWdfaWQYAiABKA0SDAoEY29z",
          "dBgDIAEoDRIOCgZyZWZ1bmQYBSABKA0SEQoJb3duZXJfdWlkGAYgASgNEhMK",
          "C2N1cnJlbnRfbnVtGAcgASgNEg8KB21heF9udW0YCCABKA1CHgocZW11Lmdy",
          "YXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BuildingInfo), global::BuildingInfo.Parser, new[]{ "BuildingId", "PointConfigId", "Cost", "Refund", "OwnerUid", "CurrentNum", "MaxNum" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BuildingInfo : pb::IMessage<BuildingInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BuildingInfo> _parser = new pb::MessageParser<BuildingInfo>(() => new BuildingInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BuildingInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BuildingInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuildingInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuildingInfo(BuildingInfo other) : this() {
    buildingId_ = other.buildingId_;
    pointConfigId_ = other.pointConfigId_;
    cost_ = other.cost_;
    refund_ = other.refund_;
    ownerUid_ = other.ownerUid_;
    currentNum_ = other.currentNum_;
    maxNum_ = other.maxNum_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuildingInfo Clone() {
    return new BuildingInfo(this);
  }

  /// <summary>Field number for the "building_id" field.</summary>
  public const int BuildingIdFieldNumber = 1;
  private uint buildingId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BuildingId {
    get { return buildingId_; }
    set {
      buildingId_ = value;
    }
  }

  /// <summary>Field number for the "point_config_id" field.</summary>
  public const int PointConfigIdFieldNumber = 2;
  private uint pointConfigId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PointConfigId {
    get { return pointConfigId_; }
    set {
      pointConfigId_ = value;
    }
  }

  /// <summary>Field number for the "cost" field.</summary>
  public const int CostFieldNumber = 3;
  private uint cost_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Cost {
    get { return cost_; }
    set {
      cost_ = value;
    }
  }

  /// <summary>Field number for the "refund" field.</summary>
  public const int RefundFieldNumber = 5;
  private uint refund_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Refund {
    get { return refund_; }
    set {
      refund_ = value;
    }
  }

  /// <summary>Field number for the "owner_uid" field.</summary>
  public const int OwnerUidFieldNumber = 6;
  private uint ownerUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OwnerUid {
    get { return ownerUid_; }
    set {
      ownerUid_ = value;
    }
  }

  /// <summary>Field number for the "current_num" field.</summary>
  public const int CurrentNumFieldNumber = 7;
  private uint currentNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurrentNum {
    get { return currentNum_; }
    set {
      currentNum_ = value;
    }
  }

  /// <summary>Field number for the "max_num" field.</summary>
  public const int MaxNumFieldNumber = 8;
  private uint maxNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MaxNum {
    get { return maxNum_; }
    set {
      maxNum_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BuildingInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BuildingInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (BuildingId != other.BuildingId) return false;
    if (PointConfigId != other.PointConfigId) return false;
    if (Cost != other.Cost) return false;
    if (Refund != other.Refund) return false;
    if (OwnerUid != other.OwnerUid) return false;
    if (CurrentNum != other.CurrentNum) return false;
    if (MaxNum != other.MaxNum) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (BuildingId != 0) hash ^= BuildingId.GetHashCode();
    if (PointConfigId != 0) hash ^= PointConfigId.GetHashCode();
    if (Cost != 0) hash ^= Cost.GetHashCode();
    if (Refund != 0) hash ^= Refund.GetHashCode();
    if (OwnerUid != 0) hash ^= OwnerUid.GetHashCode();
    if (CurrentNum != 0) hash ^= CurrentNum.GetHashCode();
    if (MaxNum != 0) hash ^= MaxNum.GetHashCode();
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
    if (BuildingId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(BuildingId);
    }
    if (PointConfigId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(PointConfigId);
    }
    if (Cost != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Cost);
    }
    if (Refund != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Refund);
    }
    if (OwnerUid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(OwnerUid);
    }
    if (CurrentNum != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CurrentNum);
    }
    if (MaxNum != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(MaxNum);
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
    if (BuildingId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(BuildingId);
    }
    if (PointConfigId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(PointConfigId);
    }
    if (Cost != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Cost);
    }
    if (Refund != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Refund);
    }
    if (OwnerUid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(OwnerUid);
    }
    if (CurrentNum != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CurrentNum);
    }
    if (MaxNum != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(MaxNum);
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
    if (BuildingId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingId);
    }
    if (PointConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointConfigId);
    }
    if (Cost != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Cost);
    }
    if (Refund != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Refund);
    }
    if (OwnerUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerUid);
    }
    if (CurrentNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrentNum);
    }
    if (MaxNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxNum);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BuildingInfo other) {
    if (other == null) {
      return;
    }
    if (other.BuildingId != 0) {
      BuildingId = other.BuildingId;
    }
    if (other.PointConfigId != 0) {
      PointConfigId = other.PointConfigId;
    }
    if (other.Cost != 0) {
      Cost = other.Cost;
    }
    if (other.Refund != 0) {
      Refund = other.Refund;
    }
    if (other.OwnerUid != 0) {
      OwnerUid = other.OwnerUid;
    }
    if (other.CurrentNum != 0) {
      CurrentNum = other.CurrentNum;
    }
    if (other.MaxNum != 0) {
      MaxNum = other.MaxNum;
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
          BuildingId = input.ReadUInt32();
          break;
        }
        case 16: {
          PointConfigId = input.ReadUInt32();
          break;
        }
        case 24: {
          Cost = input.ReadUInt32();
          break;
        }
        case 40: {
          Refund = input.ReadUInt32();
          break;
        }
        case 48: {
          OwnerUid = input.ReadUInt32();
          break;
        }
        case 56: {
          CurrentNum = input.ReadUInt32();
          break;
        }
        case 64: {
          MaxNum = input.ReadUInt32();
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
          BuildingId = input.ReadUInt32();
          break;
        }
        case 16: {
          PointConfigId = input.ReadUInt32();
          break;
        }
        case 24: {
          Cost = input.ReadUInt32();
          break;
        }
        case 40: {
          Refund = input.ReadUInt32();
          break;
        }
        case 48: {
          OwnerUid = input.ReadUInt32();
          break;
        }
        case 56: {
          CurrentNum = input.ReadUInt32();
          break;
        }
        case 64: {
          MaxNum = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
