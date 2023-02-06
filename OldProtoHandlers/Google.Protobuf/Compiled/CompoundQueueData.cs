// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CompoundQueueData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CompoundQueueData.proto</summary>
public static partial class CompoundQueueDataReflection {

  #region Descriptor
  /// <summary>File descriptor for CompoundQueueData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CompoundQueueDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdDb21wb3VuZFF1ZXVlRGF0YS5wcm90byJnChFDb21wb3VuZFF1ZXVlRGF0",
          "YRIUCgxvdXRwdXRfY291bnQYASABKA0SEwoLY29tcG91bmRfaWQYBCABKA0S",
          "EwoLb3V0cHV0X3RpbWUYDiABKA0SEgoKd2FpdF9jb3VudBgIIAEoDUIeChxl",
          "bXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CompoundQueueData), global::CompoundQueueData.Parser, new[]{ "OutputCount", "CompoundId", "OutputTime", "WaitCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CompoundQueueData : pb::IMessage<CompoundQueueData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CompoundQueueData> _parser = new pb::MessageParser<CompoundQueueData>(() => new CompoundQueueData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CompoundQueueData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CompoundQueueDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CompoundQueueData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CompoundQueueData(CompoundQueueData other) : this() {
    outputCount_ = other.outputCount_;
    compoundId_ = other.compoundId_;
    outputTime_ = other.outputTime_;
    waitCount_ = other.waitCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CompoundQueueData Clone() {
    return new CompoundQueueData(this);
  }

  /// <summary>Field number for the "output_count" field.</summary>
  public const int OutputCountFieldNumber = 1;
  private uint outputCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OutputCount {
    get { return outputCount_; }
    set {
      outputCount_ = value;
    }
  }

  /// <summary>Field number for the "compound_id" field.</summary>
  public const int CompoundIdFieldNumber = 4;
  private uint compoundId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CompoundId {
    get { return compoundId_; }
    set {
      compoundId_ = value;
    }
  }

  /// <summary>Field number for the "output_time" field.</summary>
  public const int OutputTimeFieldNumber = 14;
  private uint outputTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OutputTime {
    get { return outputTime_; }
    set {
      outputTime_ = value;
    }
  }

  /// <summary>Field number for the "wait_count" field.</summary>
  public const int WaitCountFieldNumber = 8;
  private uint waitCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WaitCount {
    get { return waitCount_; }
    set {
      waitCount_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CompoundQueueData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CompoundQueueData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (OutputCount != other.OutputCount) return false;
    if (CompoundId != other.CompoundId) return false;
    if (OutputTime != other.OutputTime) return false;
    if (WaitCount != other.WaitCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (OutputCount != 0) hash ^= OutputCount.GetHashCode();
    if (CompoundId != 0) hash ^= CompoundId.GetHashCode();
    if (OutputTime != 0) hash ^= OutputTime.GetHashCode();
    if (WaitCount != 0) hash ^= WaitCount.GetHashCode();
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
    if (OutputCount != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(OutputCount);
    }
    if (CompoundId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CompoundId);
    }
    if (WaitCount != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(WaitCount);
    }
    if (OutputTime != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(OutputTime);
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
    if (OutputCount != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(OutputCount);
    }
    if (CompoundId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CompoundId);
    }
    if (WaitCount != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(WaitCount);
    }
    if (OutputTime != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(OutputTime);
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
    if (OutputCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OutputCount);
    }
    if (CompoundId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CompoundId);
    }
    if (OutputTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OutputTime);
    }
    if (WaitCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaitCount);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CompoundQueueData other) {
    if (other == null) {
      return;
    }
    if (other.OutputCount != 0) {
      OutputCount = other.OutputCount;
    }
    if (other.CompoundId != 0) {
      CompoundId = other.CompoundId;
    }
    if (other.OutputTime != 0) {
      OutputTime = other.OutputTime;
    }
    if (other.WaitCount != 0) {
      WaitCount = other.WaitCount;
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
          OutputCount = input.ReadUInt32();
          break;
        }
        case 32: {
          CompoundId = input.ReadUInt32();
          break;
        }
        case 64: {
          WaitCount = input.ReadUInt32();
          break;
        }
        case 112: {
          OutputTime = input.ReadUInt32();
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
          OutputCount = input.ReadUInt32();
          break;
        }
        case 32: {
          CompoundId = input.ReadUInt32();
          break;
        }
        case 64: {
          WaitCount = input.ReadUInt32();
          break;
        }
        case 112: {
          OutputTime = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code