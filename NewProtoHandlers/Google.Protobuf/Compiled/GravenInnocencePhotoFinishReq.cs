// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GravenInnocencePhotoFinishReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GravenInnocencePhotoFinishReq.proto</summary>
public static partial class GravenInnocencePhotoFinishReqReflection {

  #region Descriptor
  /// <summary>File descriptor for GravenInnocencePhotoFinishReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GravenInnocencePhotoFinishReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNHcmF2ZW5Jbm5vY2VuY2VQaG90b0ZpbmlzaFJlcS5wcm90byJBCh1HcmF2",
          "ZW5Jbm5vY2VuY2VQaG90b0ZpbmlzaFJlcRINCgVwYXJhbRgGIAEoDRIRCglv",
          "YmplY3RfaWQYDCABKA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3Rv",
          "Mw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GravenInnocencePhotoFinishReq), global::GravenInnocencePhotoFinishReq.Parser, new[]{ "Param", "ObjectId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 22391;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class GravenInnocencePhotoFinishReq : pb::IMessage<GravenInnocencePhotoFinishReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GravenInnocencePhotoFinishReq> _parser = new pb::MessageParser<GravenInnocencePhotoFinishReq>(() => new GravenInnocencePhotoFinishReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GravenInnocencePhotoFinishReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GravenInnocencePhotoFinishReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GravenInnocencePhotoFinishReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GravenInnocencePhotoFinishReq(GravenInnocencePhotoFinishReq other) : this() {
    param_ = other.param_;
    objectId_ = other.objectId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GravenInnocencePhotoFinishReq Clone() {
    return new GravenInnocencePhotoFinishReq(this);
  }

  /// <summary>Field number for the "param" field.</summary>
  public const int ParamFieldNumber = 6;
  private uint param_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Param {
    get { return param_; }
    set {
      param_ = value;
    }
  }

  /// <summary>Field number for the "object_id" field.</summary>
  public const int ObjectIdFieldNumber = 12;
  private uint objectId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ObjectId {
    get { return objectId_; }
    set {
      objectId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GravenInnocencePhotoFinishReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GravenInnocencePhotoFinishReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Param != other.Param) return false;
    if (ObjectId != other.ObjectId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Param != 0) hash ^= Param.GetHashCode();
    if (ObjectId != 0) hash ^= ObjectId.GetHashCode();
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
    if (Param != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Param);
    }
    if (ObjectId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ObjectId);
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
    if (Param != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Param);
    }
    if (ObjectId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ObjectId);
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
    if (Param != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param);
    }
    if (ObjectId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ObjectId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GravenInnocencePhotoFinishReq other) {
    if (other == null) {
      return;
    }
    if (other.Param != 0) {
      Param = other.Param;
    }
    if (other.ObjectId != 0) {
      ObjectId = other.ObjectId;
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
        case 48: {
          Param = input.ReadUInt32();
          break;
        }
        case 96: {
          ObjectId = input.ReadUInt32();
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
        case 48: {
          Param = input.ReadUInt32();
          break;
        }
        case 96: {
          ObjectId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
