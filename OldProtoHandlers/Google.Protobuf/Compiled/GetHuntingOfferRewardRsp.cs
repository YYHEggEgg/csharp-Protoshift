// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetHuntingOfferRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GetHuntingOfferRewardRsp.proto</summary>
public static partial class GetHuntingOfferRewardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for GetHuntingOfferRewardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GetHuntingOfferRewardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5HZXRIdW50aW5nT2ZmZXJSZXdhcmRSc3AucHJvdG8aEUh1bnRpbmdQYWly",
          "LnByb3RvImAKGEdldEh1bnRpbmdPZmZlclJld2FyZFJzcBIiCgxodW50aW5n",
          "X3BhaXIYDiABKAsyDC5IdW50aW5nUGFpchIPCgdjaXR5X2lkGAMgASgNEg8K",
          "B3JldGNvZGUYDCABKAVCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HuntingPairReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GetHuntingOfferRewardRsp), global::GetHuntingOfferRewardRsp.Parser, new[]{ "HuntingPair", "CityId", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4331
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class GetHuntingOfferRewardRsp : pb::IMessage<GetHuntingOfferRewardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GetHuntingOfferRewardRsp> _parser = new pb::MessageParser<GetHuntingOfferRewardRsp>(() => new GetHuntingOfferRewardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GetHuntingOfferRewardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GetHuntingOfferRewardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetHuntingOfferRewardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetHuntingOfferRewardRsp(GetHuntingOfferRewardRsp other) : this() {
    huntingPair_ = other.huntingPair_ != null ? other.huntingPair_.Clone() : null;
    cityId_ = other.cityId_;
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetHuntingOfferRewardRsp Clone() {
    return new GetHuntingOfferRewardRsp(this);
  }

  /// <summary>Field number for the "hunting_pair" field.</summary>
  public const int HuntingPairFieldNumber = 14;
  private global::HuntingPair huntingPair_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::HuntingPair HuntingPair {
    get { return huntingPair_; }
    set {
      huntingPair_ = value;
    }
  }

  /// <summary>Field number for the "city_id" field.</summary>
  public const int CityIdFieldNumber = 3;
  private uint cityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CityId {
    get { return cityId_; }
    set {
      cityId_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 12;
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
    return Equals(other as GetHuntingOfferRewardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GetHuntingOfferRewardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(HuntingPair, other.HuntingPair)) return false;
    if (CityId != other.CityId) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (huntingPair_ != null) hash ^= HuntingPair.GetHashCode();
    if (CityId != 0) hash ^= CityId.GetHashCode();
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
    if (CityId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(CityId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(96);
      output.WriteInt32(Retcode);
    }
    if (huntingPair_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(HuntingPair);
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
    if (CityId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(CityId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(96);
      output.WriteInt32(Retcode);
    }
    if (huntingPair_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(HuntingPair);
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
    if (huntingPair_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HuntingPair);
    }
    if (CityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
    }
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
  public void MergeFrom(GetHuntingOfferRewardRsp other) {
    if (other == null) {
      return;
    }
    if (other.huntingPair_ != null) {
      if (huntingPair_ == null) {
        HuntingPair = new global::HuntingPair();
      }
      HuntingPair.MergeFrom(other.HuntingPair);
    }
    if (other.CityId != 0) {
      CityId = other.CityId;
    }
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
        case 24: {
          CityId = input.ReadUInt32();
          break;
        }
        case 96: {
          Retcode = input.ReadInt32();
          break;
        }
        case 114: {
          if (huntingPair_ == null) {
            HuntingPair = new global::HuntingPair();
          }
          input.ReadMessage(HuntingPair);
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
          CityId = input.ReadUInt32();
          break;
        }
        case 96: {
          Retcode = input.ReadInt32();
          break;
        }
        case 114: {
          if (huntingPair_ == null) {
            HuntingPair = new global::HuntingPair();
          }
          input.ReadMessage(HuntingPair);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code