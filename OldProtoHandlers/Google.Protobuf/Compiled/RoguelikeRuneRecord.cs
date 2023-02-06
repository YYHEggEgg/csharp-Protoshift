// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoguelikeRuneRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RoguelikeRuneRecord.proto</summary>
public static partial class RoguelikeRuneRecordReflection {

  #region Descriptor
  /// <summary>File descriptor for RoguelikeRuneRecord.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RoguelikeRuneRecordReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlSb2d1ZWxpa2VSdW5lUmVjb3JkLnByb3RvIk0KE1JvZ3VlbGlrZVJ1bmVS",
          "ZWNvcmQSEgoKbGVmdF9jb3VudBgOIAEoDRIPCgdydW5lX2lkGAYgASgNEhEK",
          "CW1heF9jb3VudBgEIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RoguelikeRuneRecord), global::RoguelikeRuneRecord.Parser, new[]{ "LeftCount", "RuneId", "MaxCount" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RoguelikeRuneRecord : pb::IMessage<RoguelikeRuneRecord>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RoguelikeRuneRecord> _parser = new pb::MessageParser<RoguelikeRuneRecord>(() => new RoguelikeRuneRecord());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RoguelikeRuneRecord> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RoguelikeRuneRecordReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeRuneRecord() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeRuneRecord(RoguelikeRuneRecord other) : this() {
    leftCount_ = other.leftCount_;
    runeId_ = other.runeId_;
    maxCount_ = other.maxCount_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RoguelikeRuneRecord Clone() {
    return new RoguelikeRuneRecord(this);
  }

  /// <summary>Field number for the "left_count" field.</summary>
  public const int LeftCountFieldNumber = 14;
  private uint leftCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LeftCount {
    get { return leftCount_; }
    set {
      leftCount_ = value;
    }
  }

  /// <summary>Field number for the "rune_id" field.</summary>
  public const int RuneIdFieldNumber = 6;
  private uint runeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RuneId {
    get { return runeId_; }
    set {
      runeId_ = value;
    }
  }

  /// <summary>Field number for the "max_count" field.</summary>
  public const int MaxCountFieldNumber = 4;
  private uint maxCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MaxCount {
    get { return maxCount_; }
    set {
      maxCount_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RoguelikeRuneRecord);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RoguelikeRuneRecord other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (LeftCount != other.LeftCount) return false;
    if (RuneId != other.RuneId) return false;
    if (MaxCount != other.MaxCount) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (LeftCount != 0) hash ^= LeftCount.GetHashCode();
    if (RuneId != 0) hash ^= RuneId.GetHashCode();
    if (MaxCount != 0) hash ^= MaxCount.GetHashCode();
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
    if (MaxCount != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(MaxCount);
    }
    if (RuneId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(RuneId);
    }
    if (LeftCount != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(LeftCount);
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
    if (MaxCount != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(MaxCount);
    }
    if (RuneId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(RuneId);
    }
    if (LeftCount != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(LeftCount);
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
    if (LeftCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftCount);
    }
    if (RuneId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RuneId);
    }
    if (MaxCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxCount);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RoguelikeRuneRecord other) {
    if (other == null) {
      return;
    }
    if (other.LeftCount != 0) {
      LeftCount = other.LeftCount;
    }
    if (other.RuneId != 0) {
      RuneId = other.RuneId;
    }
    if (other.MaxCount != 0) {
      MaxCount = other.MaxCount;
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
        case 32: {
          MaxCount = input.ReadUInt32();
          break;
        }
        case 48: {
          RuneId = input.ReadUInt32();
          break;
        }
        case 112: {
          LeftCount = input.ReadUInt32();
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
        case 32: {
          MaxCount = input.ReadUInt32();
          break;
        }
        case 48: {
          RuneId = input.ReadUInt32();
          break;
        }
        case 112: {
          LeftCount = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
