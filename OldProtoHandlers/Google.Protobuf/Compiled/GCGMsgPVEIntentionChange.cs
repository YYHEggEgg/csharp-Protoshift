// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgPVEIntentionChange.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGMsgPVEIntentionChange.proto</summary>
public static partial class GCGMsgPVEIntentionChangeReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGMsgPVEIntentionChange.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGMsgPVEIntentionChangeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5HQ0dNc2dQVkVJbnRlbnRpb25DaGFuZ2UucHJvdG8aGEdDR01zZ1BWRUlu",
          "dGVudGlvbi5wcm90bxocR0NHSW50ZW50aW9uQ2hhbmdlVHlwZS5wcm90byJ8",
          "ChhHQ0dNc2dQVkVJbnRlbnRpb25DaGFuZ2USMgoVY2hhbmdlX2ludGVudGlv",
          "bl9saXN0GAQgAygLMhMuR0NHTXNnUFZFSW50ZW50aW9uEiwKC2NoYW5nZV90",
          "eXBlGAEgASgOMhcuR0NHSW50ZW50aW9uQ2hhbmdlVHlwZUIeChxlbXUuZ3Jh",
          "c3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGMsgPVEIntentionReflection.Descriptor, global::GCGIntentionChangeTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGMsgPVEIntentionChange), global::GCGMsgPVEIntentionChange.Parser, new[]{ "ChangeIntentionList", "ChangeType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGMsgPVEIntentionChange : pb::IMessage<GCGMsgPVEIntentionChange>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGMsgPVEIntentionChange> _parser = new pb::MessageParser<GCGMsgPVEIntentionChange>(() => new GCGMsgPVEIntentionChange());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGMsgPVEIntentionChange> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGMsgPVEIntentionChangeReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgPVEIntentionChange() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgPVEIntentionChange(GCGMsgPVEIntentionChange other) : this() {
    changeIntentionList_ = other.changeIntentionList_.Clone();
    changeType_ = other.changeType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgPVEIntentionChange Clone() {
    return new GCGMsgPVEIntentionChange(this);
  }

  /// <summary>Field number for the "change_intention_list" field.</summary>
  public const int ChangeIntentionListFieldNumber = 4;
  private static readonly pb::FieldCodec<global::GCGMsgPVEIntention> _repeated_changeIntentionList_codec
      = pb::FieldCodec.ForMessage(34, global::GCGMsgPVEIntention.Parser);
  private readonly pbc::RepeatedField<global::GCGMsgPVEIntention> changeIntentionList_ = new pbc::RepeatedField<global::GCGMsgPVEIntention>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGMsgPVEIntention> ChangeIntentionList {
    get { return changeIntentionList_; }
  }

  /// <summary>Field number for the "change_type" field.</summary>
  public const int ChangeTypeFieldNumber = 1;
  private global::GCGIntentionChangeType changeType_ = global::GCGIntentionChangeType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGIntentionChangeType ChangeType {
    get { return changeType_; }
    set {
      changeType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGMsgPVEIntentionChange);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGMsgPVEIntentionChange other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!changeIntentionList_.Equals(other.changeIntentionList_)) return false;
    if (ChangeType != other.ChangeType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= changeIntentionList_.GetHashCode();
    if (ChangeType != global::GCGIntentionChangeType.None) hash ^= ChangeType.GetHashCode();
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
    if (ChangeType != global::GCGIntentionChangeType.None) {
      output.WriteRawTag(8);
      output.WriteEnum((int) ChangeType);
    }
    changeIntentionList_.WriteTo(output, _repeated_changeIntentionList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (ChangeType != global::GCGIntentionChangeType.None) {
      output.WriteRawTag(8);
      output.WriteEnum((int) ChangeType);
    }
    changeIntentionList_.WriteTo(ref output, _repeated_changeIntentionList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += changeIntentionList_.CalculateSize(_repeated_changeIntentionList_codec);
    if (ChangeType != global::GCGIntentionChangeType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChangeType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGMsgPVEIntentionChange other) {
    if (other == null) {
      return;
    }
    changeIntentionList_.Add(other.changeIntentionList_);
    if (other.ChangeType != global::GCGIntentionChangeType.None) {
      ChangeType = other.ChangeType;
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
          ChangeType = (global::GCGIntentionChangeType) input.ReadEnum();
          break;
        }
        case 34: {
          changeIntentionList_.AddEntriesFrom(input, _repeated_changeIntentionList_codec);
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
          ChangeType = (global::GCGIntentionChangeType) input.ReadEnum();
          break;
        }
        case 34: {
          changeIntentionList_.AddEntriesFrom(ref input, _repeated_changeIntentionList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code