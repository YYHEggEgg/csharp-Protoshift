// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassRewardTakeOption.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BattlePassRewardTakeOption.proto</summary>
public static partial class BattlePassRewardTakeOptionReflection {

  #region Descriptor
  /// <summary>File descriptor for BattlePassRewardTakeOption.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BattlePassRewardTakeOptionReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBCYXR0bGVQYXNzUmV3YXJkVGFrZU9wdGlvbi5wcm90bxoZQmF0dGxlUGFz",
          "c1Jld2FyZFRhZy5wcm90byJTChpCYXR0bGVQYXNzUmV3YXJkVGFrZU9wdGlv",
          "bhISCgpvcHRpb25faWR4GAUgASgNEiEKA3RhZxgPIAEoCzIULkJhdHRsZVBh",
          "c3NSZXdhcmRUYWdCFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BattlePassRewardTagReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BattlePassRewardTakeOption), global::BattlePassRewardTakeOption.Parser, new[]{ "OptionIdx", "Tag" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BattlePassRewardTakeOption : pb::IMessage<BattlePassRewardTakeOption>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BattlePassRewardTakeOption> _parser = new pb::MessageParser<BattlePassRewardTakeOption>(() => new BattlePassRewardTakeOption());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BattlePassRewardTakeOption> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BattlePassRewardTakeOptionReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassRewardTakeOption() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassRewardTakeOption(BattlePassRewardTakeOption other) : this() {
    optionIdx_ = other.optionIdx_;
    tag_ = other.tag_ != null ? other.tag_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassRewardTakeOption Clone() {
    return new BattlePassRewardTakeOption(this);
  }

  /// <summary>Field number for the "option_idx" field.</summary>
  public const int OptionIdxFieldNumber = 5;
  private uint optionIdx_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OptionIdx {
    get { return optionIdx_; }
    set {
      optionIdx_ = value;
    }
  }

  /// <summary>Field number for the "tag" field.</summary>
  public const int TagFieldNumber = 15;
  private global::BattlePassRewardTag tag_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::BattlePassRewardTag Tag {
    get { return tag_; }
    set {
      tag_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BattlePassRewardTakeOption);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BattlePassRewardTakeOption other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (OptionIdx != other.OptionIdx) return false;
    if (!object.Equals(Tag, other.Tag)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (OptionIdx != 0) hash ^= OptionIdx.GetHashCode();
    if (tag_ != null) hash ^= Tag.GetHashCode();
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
    if (OptionIdx != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(OptionIdx);
    }
    if (tag_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(Tag);
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
    if (OptionIdx != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(OptionIdx);
    }
    if (tag_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(Tag);
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
    if (OptionIdx != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionIdx);
    }
    if (tag_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Tag);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BattlePassRewardTakeOption other) {
    if (other == null) {
      return;
    }
    if (other.OptionIdx != 0) {
      OptionIdx = other.OptionIdx;
    }
    if (other.tag_ != null) {
      if (tag_ == null) {
        Tag = new global::BattlePassRewardTag();
      }
      Tag.MergeFrom(other.Tag);
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
        case 40: {
          OptionIdx = input.ReadUInt32();
          break;
        }
        case 122: {
          if (tag_ == null) {
            Tag = new global::BattlePassRewardTag();
          }
          input.ReadMessage(Tag);
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
        case 40: {
          OptionIdx = input.ReadUInt32();
          break;
        }
        case 122: {
          if (tag_ == null) {
            Tag = new global::BattlePassRewardTag();
          }
          input.ReadMessage(Tag);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
