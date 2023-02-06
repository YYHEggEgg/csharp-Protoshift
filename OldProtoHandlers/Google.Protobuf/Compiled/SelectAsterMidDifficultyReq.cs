// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SelectAsterMidDifficultyReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SelectAsterMidDifficultyReq.proto</summary>
public static partial class SelectAsterMidDifficultyReqReflection {

  #region Descriptor
  /// <summary>File descriptor for SelectAsterMidDifficultyReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SelectAsterMidDifficultyReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFTZWxlY3RBc3Rlck1pZERpZmZpY3VsdHlSZXEucHJvdG8iYwobU2VsZWN0",
          "QXN0ZXJNaWREaWZmaWN1bHR5UmVxEhgKEGdhZGdldF9lbnRpdHlfaWQYDSAB",
          "KA0SEwoLc2NoZWR1bGVfaWQYASABKA0SFQoNZGlmZmljdWx0eV9pZBgFIAEo",
          "DUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SelectAsterMidDifficultyReq), global::SelectAsterMidDifficultyReq.Parser, new[]{ "GadgetEntityId", "ScheduleId", "DifficultyId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2134
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class SelectAsterMidDifficultyReq : pb::IMessage<SelectAsterMidDifficultyReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SelectAsterMidDifficultyReq> _parser = new pb::MessageParser<SelectAsterMidDifficultyReq>(() => new SelectAsterMidDifficultyReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SelectAsterMidDifficultyReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SelectAsterMidDifficultyReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SelectAsterMidDifficultyReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SelectAsterMidDifficultyReq(SelectAsterMidDifficultyReq other) : this() {
    gadgetEntityId_ = other.gadgetEntityId_;
    scheduleId_ = other.scheduleId_;
    difficultyId_ = other.difficultyId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SelectAsterMidDifficultyReq Clone() {
    return new SelectAsterMidDifficultyReq(this);
  }

  /// <summary>Field number for the "gadget_entity_id" field.</summary>
  public const int GadgetEntityIdFieldNumber = 13;
  private uint gadgetEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GadgetEntityId {
    get { return gadgetEntityId_; }
    set {
      gadgetEntityId_ = value;
    }
  }

  /// <summary>Field number for the "schedule_id" field.</summary>
  public const int ScheduleIdFieldNumber = 1;
  private uint scheduleId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ScheduleId {
    get { return scheduleId_; }
    set {
      scheduleId_ = value;
    }
  }

  /// <summary>Field number for the "difficulty_id" field.</summary>
  public const int DifficultyIdFieldNumber = 5;
  private uint difficultyId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DifficultyId {
    get { return difficultyId_; }
    set {
      difficultyId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SelectAsterMidDifficultyReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SelectAsterMidDifficultyReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GadgetEntityId != other.GadgetEntityId) return false;
    if (ScheduleId != other.ScheduleId) return false;
    if (DifficultyId != other.DifficultyId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
    if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
    if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
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
    if (ScheduleId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ScheduleId);
    }
    if (DifficultyId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(DifficultyId);
    }
    if (GadgetEntityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GadgetEntityId);
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
    if (ScheduleId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ScheduleId);
    }
    if (DifficultyId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(DifficultyId);
    }
    if (GadgetEntityId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(GadgetEntityId);
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
    if (GadgetEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
    }
    if (ScheduleId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
    }
    if (DifficultyId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SelectAsterMidDifficultyReq other) {
    if (other == null) {
      return;
    }
    if (other.GadgetEntityId != 0) {
      GadgetEntityId = other.GadgetEntityId;
    }
    if (other.ScheduleId != 0) {
      ScheduleId = other.ScheduleId;
    }
    if (other.DifficultyId != 0) {
      DifficultyId = other.DifficultyId;
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
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 40: {
          DifficultyId = input.ReadUInt32();
          break;
        }
        case 104: {
          GadgetEntityId = input.ReadUInt32();
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
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 40: {
          DifficultyId = input.ReadUInt32();
          break;
        }
        case 104: {
          GadgetEntityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
