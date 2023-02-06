// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WeeklyBossResinDiscountInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WeeklyBossResinDiscountInfo.proto</summary>
public static partial class WeeklyBossResinDiscountInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for WeeklyBossResinDiscountInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WeeklyBossResinDiscountInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFXZWVrbHlCb3NzUmVzaW5EaXNjb3VudEluZm8ucHJvdG8igAEKG1dlZWts",
          "eUJvc3NSZXNpbkRpc2NvdW50SW5mbxIUCgxkaXNjb3VudF9udW0YASABKA0S",
          "GgoSZGlzY291bnRfbnVtX2xpbWl0GAIgASgNEhIKCnJlc2luX2Nvc3QYAyAB",
          "KA0SGwoTb3JpZ2luYWxfcmVzaW5fY29zdBgEIAEoDUIWChRvcmcuc29yYXBv",
          "aW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WeeklyBossResinDiscountInfo), global::WeeklyBossResinDiscountInfo.Parser, new[]{ "DiscountNum", "DiscountNumLimit", "ResinCost", "OriginalResinCost" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class WeeklyBossResinDiscountInfo : pb::IMessage<WeeklyBossResinDiscountInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WeeklyBossResinDiscountInfo> _parser = new pb::MessageParser<WeeklyBossResinDiscountInfo>(() => new WeeklyBossResinDiscountInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WeeklyBossResinDiscountInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WeeklyBossResinDiscountInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WeeklyBossResinDiscountInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WeeklyBossResinDiscountInfo(WeeklyBossResinDiscountInfo other) : this() {
    discountNum_ = other.discountNum_;
    discountNumLimit_ = other.discountNumLimit_;
    resinCost_ = other.resinCost_;
    originalResinCost_ = other.originalResinCost_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WeeklyBossResinDiscountInfo Clone() {
    return new WeeklyBossResinDiscountInfo(this);
  }

  /// <summary>Field number for the "discount_num" field.</summary>
  public const int DiscountNumFieldNumber = 1;
  private uint discountNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DiscountNum {
    get { return discountNum_; }
    set {
      discountNum_ = value;
    }
  }

  /// <summary>Field number for the "discount_num_limit" field.</summary>
  public const int DiscountNumLimitFieldNumber = 2;
  private uint discountNumLimit_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DiscountNumLimit {
    get { return discountNumLimit_; }
    set {
      discountNumLimit_ = value;
    }
  }

  /// <summary>Field number for the "resin_cost" field.</summary>
  public const int ResinCostFieldNumber = 3;
  private uint resinCost_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ResinCost {
    get { return resinCost_; }
    set {
      resinCost_ = value;
    }
  }

  /// <summary>Field number for the "original_resin_cost" field.</summary>
  public const int OriginalResinCostFieldNumber = 4;
  private uint originalResinCost_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OriginalResinCost {
    get { return originalResinCost_; }
    set {
      originalResinCost_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WeeklyBossResinDiscountInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WeeklyBossResinDiscountInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (DiscountNum != other.DiscountNum) return false;
    if (DiscountNumLimit != other.DiscountNumLimit) return false;
    if (ResinCost != other.ResinCost) return false;
    if (OriginalResinCost != other.OriginalResinCost) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (DiscountNum != 0) hash ^= DiscountNum.GetHashCode();
    if (DiscountNumLimit != 0) hash ^= DiscountNumLimit.GetHashCode();
    if (ResinCost != 0) hash ^= ResinCost.GetHashCode();
    if (OriginalResinCost != 0) hash ^= OriginalResinCost.GetHashCode();
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
    if (DiscountNum != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(DiscountNum);
    }
    if (DiscountNumLimit != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(DiscountNumLimit);
    }
    if (ResinCost != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ResinCost);
    }
    if (OriginalResinCost != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(OriginalResinCost);
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
    if (DiscountNum != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(DiscountNum);
    }
    if (DiscountNumLimit != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(DiscountNumLimit);
    }
    if (ResinCost != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ResinCost);
    }
    if (OriginalResinCost != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(OriginalResinCost);
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
    if (DiscountNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiscountNum);
    }
    if (DiscountNumLimit != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiscountNumLimit);
    }
    if (ResinCost != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ResinCost);
    }
    if (OriginalResinCost != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OriginalResinCost);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WeeklyBossResinDiscountInfo other) {
    if (other == null) {
      return;
    }
    if (other.DiscountNum != 0) {
      DiscountNum = other.DiscountNum;
    }
    if (other.DiscountNumLimit != 0) {
      DiscountNumLimit = other.DiscountNumLimit;
    }
    if (other.ResinCost != 0) {
      ResinCost = other.ResinCost;
    }
    if (other.OriginalResinCost != 0) {
      OriginalResinCost = other.OriginalResinCost;
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
          DiscountNum = input.ReadUInt32();
          break;
        }
        case 16: {
          DiscountNumLimit = input.ReadUInt32();
          break;
        }
        case 24: {
          ResinCost = input.ReadUInt32();
          break;
        }
        case 32: {
          OriginalResinCost = input.ReadUInt32();
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
          DiscountNum = input.ReadUInt32();
          break;
        }
        case 16: {
          DiscountNumLimit = input.ReadUInt32();
          break;
        }
        case 24: {
          ResinCost = input.ReadUInt32();
          break;
        }
        case 32: {
          OriginalResinCost = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
