// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExecuteGadgetLuaReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ExecuteGadgetLuaReq.proto</summary>
public static partial class ExecuteGadgetLuaReqReflection {

  #region Descriptor
  /// <summary>File descriptor for ExecuteGadgetLuaReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ExecuteGadgetLuaReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlFeGVjdXRlR2FkZ2V0THVhUmVxLnByb3RvIl8KE0V4ZWN1dGVHYWRnZXRM",
          "dWFSZXESDgoGcGFyYW0zGAEgASgFEg4KBnBhcmFtMhgOIAEoBRIYChBzb3Vy",
          "Y2VfZW50aXR5X2lkGA8gASgNEg4KBnBhcmFtMRgNIAEoBUIWChRvcmcuc29y",
          "YXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ExecuteGadgetLuaReq), global::ExecuteGadgetLuaReq.Parser, new[]{ "Param3", "Param2", "SourceEntityId", "Param1" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 235;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class ExecuteGadgetLuaReq : pb::IMessage<ExecuteGadgetLuaReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ExecuteGadgetLuaReq> _parser = new pb::MessageParser<ExecuteGadgetLuaReq>(() => new ExecuteGadgetLuaReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ExecuteGadgetLuaReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ExecuteGadgetLuaReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExecuteGadgetLuaReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExecuteGadgetLuaReq(ExecuteGadgetLuaReq other) : this() {
    param3_ = other.param3_;
    param2_ = other.param2_;
    sourceEntityId_ = other.sourceEntityId_;
    param1_ = other.param1_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ExecuteGadgetLuaReq Clone() {
    return new ExecuteGadgetLuaReq(this);
  }

  /// <summary>Field number for the "param3" field.</summary>
  public const int Param3FieldNumber = 1;
  private int param3_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Param3 {
    get { return param3_; }
    set {
      param3_ = value;
    }
  }

  /// <summary>Field number for the "param2" field.</summary>
  public const int Param2FieldNumber = 14;
  private int param2_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Param2 {
    get { return param2_; }
    set {
      param2_ = value;
    }
  }

  /// <summary>Field number for the "source_entity_id" field.</summary>
  public const int SourceEntityIdFieldNumber = 15;
  private uint sourceEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SourceEntityId {
    get { return sourceEntityId_; }
    set {
      sourceEntityId_ = value;
    }
  }

  /// <summary>Field number for the "param1" field.</summary>
  public const int Param1FieldNumber = 13;
  private int param1_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Param1 {
    get { return param1_; }
    set {
      param1_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ExecuteGadgetLuaReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ExecuteGadgetLuaReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Param3 != other.Param3) return false;
    if (Param2 != other.Param2) return false;
    if (SourceEntityId != other.SourceEntityId) return false;
    if (Param1 != other.Param1) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Param3 != 0) hash ^= Param3.GetHashCode();
    if (Param2 != 0) hash ^= Param2.GetHashCode();
    if (SourceEntityId != 0) hash ^= SourceEntityId.GetHashCode();
    if (Param1 != 0) hash ^= Param1.GetHashCode();
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
    if (Param3 != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Param3);
    }
    if (Param1 != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Param1);
    }
    if (Param2 != 0) {
      output.WriteRawTag(112);
      output.WriteInt32(Param2);
    }
    if (SourceEntityId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(SourceEntityId);
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
    if (Param3 != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Param3);
    }
    if (Param1 != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Param1);
    }
    if (Param2 != 0) {
      output.WriteRawTag(112);
      output.WriteInt32(Param2);
    }
    if (SourceEntityId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(SourceEntityId);
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
    if (Param3 != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param3);
    }
    if (Param2 != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param2);
    }
    if (SourceEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceEntityId);
    }
    if (Param1 != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param1);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ExecuteGadgetLuaReq other) {
    if (other == null) {
      return;
    }
    if (other.Param3 != 0) {
      Param3 = other.Param3;
    }
    if (other.Param2 != 0) {
      Param2 = other.Param2;
    }
    if (other.SourceEntityId != 0) {
      SourceEntityId = other.SourceEntityId;
    }
    if (other.Param1 != 0) {
      Param1 = other.Param1;
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
          Param3 = input.ReadInt32();
          break;
        }
        case 104: {
          Param1 = input.ReadInt32();
          break;
        }
        case 112: {
          Param2 = input.ReadInt32();
          break;
        }
        case 120: {
          SourceEntityId = input.ReadUInt32();
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
          Param3 = input.ReadInt32();
          break;
        }
        case 104: {
          Param1 = input.ReadInt32();
          break;
        }
        case 112: {
          Param2 = input.ReadInt32();
          break;
        }
        case 120: {
          SourceEntityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code