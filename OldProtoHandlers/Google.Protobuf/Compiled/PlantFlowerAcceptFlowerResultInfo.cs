// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerAcceptFlowerResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PlantFlowerAcceptFlowerResultInfo.proto</summary>
public static partial class PlantFlowerAcceptFlowerResultInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for PlantFlowerAcceptFlowerResultInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlantFlowerAcceptFlowerResultInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CidQbGFudEZsb3dlckFjY2VwdEZsb3dlclJlc3VsdEluZm8ucHJvdG8i4gIK",
          "IVBsYW50Rmxvd2VyQWNjZXB0Rmxvd2VyUmVzdWx0SW5mbxJdChd1bmFjY2Vw",
          "dF9mbG93ZXJfbnVtX21hcBgEIAMoCzI8LlBsYW50Rmxvd2VyQWNjZXB0Rmxv",
          "d2VyUmVzdWx0SW5mby5VbmFjY2VwdEZsb3dlck51bU1hcEVudHJ5EgsKA3Vp",
          "ZBgHIAEoDRJZChVhY2NlcHRfZmxvd2VyX251bV9tYXAYCiADKAsyOi5QbGFu",
          "dEZsb3dlckFjY2VwdEZsb3dlclJlc3VsdEluZm8uQWNjZXB0Rmxvd2VyTnVt",
          "TWFwRW50cnkaOwoZVW5hY2NlcHRGbG93ZXJOdW1NYXBFbnRyeRILCgNrZXkY",
          "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBGjkKF0FjY2VwdEZsb3dlck51bU1h",
          "cEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCHgocZW11",
          "LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PlantFlowerAcceptFlowerResultInfo), global::PlantFlowerAcceptFlowerResultInfo.Parser, new[]{ "UnacceptFlowerNumMap", "Uid", "AcceptFlowerNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class PlantFlowerAcceptFlowerResultInfo : pb::IMessage<PlantFlowerAcceptFlowerResultInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlantFlowerAcceptFlowerResultInfo> _parser = new pb::MessageParser<PlantFlowerAcceptFlowerResultInfo>(() => new PlantFlowerAcceptFlowerResultInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlantFlowerAcceptFlowerResultInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlantFlowerAcceptFlowerResultInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlantFlowerAcceptFlowerResultInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlantFlowerAcceptFlowerResultInfo(PlantFlowerAcceptFlowerResultInfo other) : this() {
    unacceptFlowerNumMap_ = other.unacceptFlowerNumMap_.Clone();
    uid_ = other.uid_;
    acceptFlowerNumMap_ = other.acceptFlowerNumMap_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlantFlowerAcceptFlowerResultInfo Clone() {
    return new PlantFlowerAcceptFlowerResultInfo(this);
  }

  /// <summary>Field number for the "unaccept_flower_num_map" field.</summary>
  public const int UnacceptFlowerNumMapFieldNumber = 4;
  private static readonly pbc::MapField<uint, uint>.Codec _map_unacceptFlowerNumMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
  private readonly pbc::MapField<uint, uint> unacceptFlowerNumMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> UnacceptFlowerNumMap {
    get { return unacceptFlowerNumMap_; }
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 7;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  /// <summary>Field number for the "accept_flower_num_map" field.</summary>
  public const int AcceptFlowerNumMapFieldNumber = 10;
  private static readonly pbc::MapField<uint, uint>.Codec _map_acceptFlowerNumMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 82);
  private readonly pbc::MapField<uint, uint> acceptFlowerNumMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> AcceptFlowerNumMap {
    get { return acceptFlowerNumMap_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlantFlowerAcceptFlowerResultInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlantFlowerAcceptFlowerResultInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!UnacceptFlowerNumMap.Equals(other.UnacceptFlowerNumMap)) return false;
    if (Uid != other.Uid) return false;
    if (!AcceptFlowerNumMap.Equals(other.AcceptFlowerNumMap)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= UnacceptFlowerNumMap.GetHashCode();
    if (Uid != 0) hash ^= Uid.GetHashCode();
    hash ^= AcceptFlowerNumMap.GetHashCode();
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
    unacceptFlowerNumMap_.WriteTo(output, _map_unacceptFlowerNumMap_codec);
    if (Uid != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Uid);
    }
    acceptFlowerNumMap_.WriteTo(output, _map_acceptFlowerNumMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    unacceptFlowerNumMap_.WriteTo(ref output, _map_unacceptFlowerNumMap_codec);
    if (Uid != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Uid);
    }
    acceptFlowerNumMap_.WriteTo(ref output, _map_acceptFlowerNumMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += unacceptFlowerNumMap_.CalculateSize(_map_unacceptFlowerNumMap_codec);
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    size += acceptFlowerNumMap_.CalculateSize(_map_acceptFlowerNumMap_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlantFlowerAcceptFlowerResultInfo other) {
    if (other == null) {
      return;
    }
    unacceptFlowerNumMap_.Add(other.unacceptFlowerNumMap_);
    if (other.Uid != 0) {
      Uid = other.Uid;
    }
    acceptFlowerNumMap_.Add(other.acceptFlowerNumMap_);
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
        case 34: {
          unacceptFlowerNumMap_.AddEntriesFrom(input, _map_unacceptFlowerNumMap_codec);
          break;
        }
        case 56: {
          Uid = input.ReadUInt32();
          break;
        }
        case 82: {
          acceptFlowerNumMap_.AddEntriesFrom(input, _map_acceptFlowerNumMap_codec);
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
        case 34: {
          unacceptFlowerNumMap_.AddEntriesFrom(ref input, _map_unacceptFlowerNumMap_codec);
          break;
        }
        case 56: {
          Uid = input.ReadUInt32();
          break;
        }
        case 82: {
          acceptFlowerNumMap_.AddEntriesFrom(ref input, _map_acceptFlowerNumMap_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
