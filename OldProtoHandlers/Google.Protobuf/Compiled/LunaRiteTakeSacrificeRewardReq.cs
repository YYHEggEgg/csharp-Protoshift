// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LunaRiteTakeSacrificeRewardReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from LunaRiteTakeSacrificeRewardReq.proto</summary>
public static partial class LunaRiteTakeSacrificeRewardReqReflection {

  #region Descriptor
  /// <summary>File descriptor for LunaRiteTakeSacrificeRewardReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static LunaRiteTakeSacrificeRewardReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiRMdW5hUml0ZVRha2VTYWNyaWZpY2VSZXdhcmRSZXEucHJvdG8iQAoeTHVu",
          "YVJpdGVUYWtlU2FjcmlmaWNlUmV3YXJkUmVxEg8KB2FyZWFfaWQYCyABKA0S",
          "DQoFaW5kZXgYAyABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::LunaRiteTakeSacrificeRewardReq), global::LunaRiteTakeSacrificeRewardReq.Parser, new[]{ "AreaId", "Index" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8045
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class LunaRiteTakeSacrificeRewardReq : pb::IMessage<LunaRiteTakeSacrificeRewardReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<LunaRiteTakeSacrificeRewardReq> _parser = new pb::MessageParser<LunaRiteTakeSacrificeRewardReq>(() => new LunaRiteTakeSacrificeRewardReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<LunaRiteTakeSacrificeRewardReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LunaRiteTakeSacrificeRewardReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public LunaRiteTakeSacrificeRewardReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public LunaRiteTakeSacrificeRewardReq(LunaRiteTakeSacrificeRewardReq other) : this() {
    areaId_ = other.areaId_;
    index_ = other.index_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public LunaRiteTakeSacrificeRewardReq Clone() {
    return new LunaRiteTakeSacrificeRewardReq(this);
  }

  /// <summary>Field number for the "area_id" field.</summary>
  public const int AreaIdFieldNumber = 11;
  private uint areaId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AreaId {
    get { return areaId_; }
    set {
      areaId_ = value;
    }
  }

  /// <summary>Field number for the "index" field.</summary>
  public const int IndexFieldNumber = 3;
  private uint index_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Index {
    get { return index_; }
    set {
      index_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as LunaRiteTakeSacrificeRewardReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(LunaRiteTakeSacrificeRewardReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (AreaId != other.AreaId) return false;
    if (Index != other.Index) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (AreaId != 0) hash ^= AreaId.GetHashCode();
    if (Index != 0) hash ^= Index.GetHashCode();
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
    if (Index != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Index);
    }
    if (AreaId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(AreaId);
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
    if (Index != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Index);
    }
    if (AreaId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(AreaId);
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
    if (AreaId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
    }
    if (Index != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(LunaRiteTakeSacrificeRewardReq other) {
    if (other == null) {
      return;
    }
    if (other.AreaId != 0) {
      AreaId = other.AreaId;
    }
    if (other.Index != 0) {
      Index = other.Index;
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
        case 24: {
          Index = input.ReadUInt32();
          break;
        }
        case 88: {
          AreaId = input.ReadUInt32();
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
        case 24: {
          Index = input.ReadUInt32();
          break;
        }
        case 88: {
          AreaId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
