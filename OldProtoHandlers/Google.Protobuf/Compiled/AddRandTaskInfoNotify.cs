// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddRandTaskInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AddRandTaskInfoNotify.proto</summary>
public static partial class AddRandTaskInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for AddRandTaskInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AddRandTaskInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtBZGRSYW5kVGFza0luZm9Ob3RpZnkucHJvdG8aDFZlY3Rvci5wcm90byJD",
          "ChVBZGRSYW5kVGFza0luZm9Ob3RpZnkSFAoMcmFuZF90YXNrX2lkGAUgASgN",
          "EhQKA3BvcxgNIAEoCzIHLlZlY3RvckIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0",
          "Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AddRandTaskInfoNotify), global::AddRandTaskInfoNotify.Parser, new[]{ "RandTaskId", "Pos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 119
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class AddRandTaskInfoNotify : pb::IMessage<AddRandTaskInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AddRandTaskInfoNotify> _parser = new pb::MessageParser<AddRandTaskInfoNotify>(() => new AddRandTaskInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AddRandTaskInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AddRandTaskInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AddRandTaskInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AddRandTaskInfoNotify(AddRandTaskInfoNotify other) : this() {
    randTaskId_ = other.randTaskId_;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AddRandTaskInfoNotify Clone() {
    return new AddRandTaskInfoNotify(this);
  }

  /// <summary>Field number for the "rand_task_id" field.</summary>
  public const int RandTaskIdFieldNumber = 5;
  private uint randTaskId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RandTaskId {
    get { return randTaskId_; }
    set {
      randTaskId_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 13;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AddRandTaskInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AddRandTaskInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RandTaskId != other.RandTaskId) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RandTaskId != 0) hash ^= RandTaskId.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
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
    if (RandTaskId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(RandTaskId);
    }
    if (pos_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(Pos);
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
    if (RandTaskId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(RandTaskId);
    }
    if (pos_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(Pos);
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
    if (RandTaskId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RandTaskId);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AddRandTaskInfoNotify other) {
    if (other == null) {
      return;
    }
    if (other.RandTaskId != 0) {
      RandTaskId = other.RandTaskId;
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
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
          RandTaskId = input.ReadUInt32();
          break;
        }
        case 106: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
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
          RandTaskId = input.ReadUInt32();
          break;
        }
        case 106: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
