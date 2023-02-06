// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaActivityTakeRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GachaActivityTakeRewardRsp.proto</summary>
public static partial class GachaActivityTakeRewardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for GachaActivityTakeRewardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GachaActivityTakeRewardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBHYWNoYUFjdGl2aXR5VGFrZVJld2FyZFJzcC5wcm90byKmAQoaR2FjaGFB",
          "Y3Rpdml0eVRha2VSZXdhcmRSc3ASQwoNcm9ib3RfbnVtX21hcBgKIAMoCzIs",
          "LkdhY2hhQWN0aXZpdHlUYWtlUmV3YXJkUnNwLlJvYm90TnVtTWFwRW50cnkS",
          "DwoHcmV0Y29kZRgIIAEoBRoyChBSb2JvdE51bU1hcEVudHJ5EgsKA2tleRgB",
          "IAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCFgoUb3JnLnNvcmFwb2ludGEucHJv",
          "dG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GachaActivityTakeRewardRsp), global::GachaActivityTakeRewardRsp.Parser, new[]{ "RobotNumMap", "Retcode" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 8354;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GachaActivityTakeRewardRsp : pb::IMessage<GachaActivityTakeRewardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GachaActivityTakeRewardRsp> _parser = new pb::MessageParser<GachaActivityTakeRewardRsp>(() => new GachaActivityTakeRewardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GachaActivityTakeRewardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GachaActivityTakeRewardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GachaActivityTakeRewardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GachaActivityTakeRewardRsp(GachaActivityTakeRewardRsp other) : this() {
    robotNumMap_ = other.robotNumMap_.Clone();
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GachaActivityTakeRewardRsp Clone() {
    return new GachaActivityTakeRewardRsp(this);
  }

  /// <summary>Field number for the "robot_num_map" field.</summary>
  public const int RobotNumMapFieldNumber = 10;
  private static readonly pbc::MapField<uint, uint>.Codec _map_robotNumMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 82);
  private readonly pbc::MapField<uint, uint> robotNumMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> RobotNumMap {
    get { return robotNumMap_; }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 8;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GachaActivityTakeRewardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GachaActivityTakeRewardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!RobotNumMap.Equals(other.RobotNumMap)) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= RobotNumMap.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(64);
      output.WriteInt32(Retcode);
    }
    robotNumMap_.WriteTo(output, _map_robotNumMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Retcode != 0) {
      output.WriteRawTag(64);
      output.WriteInt32(Retcode);
    }
    robotNumMap_.WriteTo(ref output, _map_robotNumMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += robotNumMap_.CalculateSize(_map_robotNumMap_codec);
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GachaActivityTakeRewardRsp other) {
    if (other == null) {
      return;
    }
    robotNumMap_.Add(other.robotNumMap_);
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
        case 64: {
          Retcode = input.ReadInt32();
          break;
        }
        case 82: {
          robotNumMap_.AddEntriesFrom(input, _map_robotNumMap_codec);
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
        case 64: {
          Retcode = input.ReadInt32();
          break;
        }
        case 82: {
          robotNumMap_.AddEntriesFrom(ref input, _map_robotNumMap_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
