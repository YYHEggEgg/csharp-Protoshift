// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetCityReputationMapInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GetCityReputationMapInfoRsp.proto</summary>
public static partial class GetCityReputationMapInfoRspReflection {

  #region Descriptor
  /// <summary>File descriptor for GetCityReputationMapInfoRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GetCityReputationMapInfoRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFHZXRDaXR5UmVwdXRhdGlvbk1hcEluZm9Sc3AucHJvdG8ipAEKG0dldENp",
          "dHlSZXB1dGF0aW9uTWFwSW5mb1JzcBIPCgdyZXRjb2RlGA0gASgFEiAKGHVu",
          "bG9ja19odW50aW5nX2NpdHlfbGlzdBgEIAMoDRIbChNVbmszMzAwX0dKRk5P",
          "UE5NRk5HGAwgASgIEhsKE1VuazMzMDBfTkNNSE1PRElJS00YBSABKAgSGAoQ",
          "cmV3YXJkX2NpdHlfbGlzdBgPIAMoDUIWChRvcmcuc29yYXBvaW50YS5wcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GetCityReputationMapInfoRsp), global::GetCityReputationMapInfoRsp.Parser, new[]{ "Retcode", "UnlockHuntingCityList", "Unk3300GJFNOPNMFNG", "Unk3300NCMHMODIIKM", "RewardCityList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 2848;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GetCityReputationMapInfoRsp : pb::IMessage<GetCityReputationMapInfoRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GetCityReputationMapInfoRsp> _parser = new pb::MessageParser<GetCityReputationMapInfoRsp>(() => new GetCityReputationMapInfoRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GetCityReputationMapInfoRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GetCityReputationMapInfoRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetCityReputationMapInfoRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetCityReputationMapInfoRsp(GetCityReputationMapInfoRsp other) : this() {
    retcode_ = other.retcode_;
    unlockHuntingCityList_ = other.unlockHuntingCityList_.Clone();
    unk3300GJFNOPNMFNG_ = other.unk3300GJFNOPNMFNG_;
    unk3300NCMHMODIIKM_ = other.unk3300NCMHMODIIKM_;
    rewardCityList_ = other.rewardCityList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetCityReputationMapInfoRsp Clone() {
    return new GetCityReputationMapInfoRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 13;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "unlock_hunting_city_list" field.</summary>
  public const int UnlockHuntingCityListFieldNumber = 4;
  private static readonly pb::FieldCodec<uint> _repeated_unlockHuntingCityList_codec
      = pb::FieldCodec.ForUInt32(34);
  private readonly pbc::RepeatedField<uint> unlockHuntingCityList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> UnlockHuntingCityList {
    get { return unlockHuntingCityList_; }
  }

  /// <summary>Field number for the "Unk3300_GJFNOPNMFNG" field.</summary>
  public const int Unk3300GJFNOPNMFNGFieldNumber = 12;
  private bool unk3300GJFNOPNMFNG_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300GJFNOPNMFNG {
    get { return unk3300GJFNOPNMFNG_; }
    set {
      unk3300GJFNOPNMFNG_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_NCMHMODIIKM" field.</summary>
  public const int Unk3300NCMHMODIIKMFieldNumber = 5;
  private bool unk3300NCMHMODIIKM_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Unk3300NCMHMODIIKM {
    get { return unk3300NCMHMODIIKM_; }
    set {
      unk3300NCMHMODIIKM_ = value;
    }
  }

  /// <summary>Field number for the "reward_city_list" field.</summary>
  public const int RewardCityListFieldNumber = 15;
  private static readonly pb::FieldCodec<uint> _repeated_rewardCityList_codec
      = pb::FieldCodec.ForUInt32(122);
  private readonly pbc::RepeatedField<uint> rewardCityList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> RewardCityList {
    get { return rewardCityList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GetCityReputationMapInfoRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GetCityReputationMapInfoRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if(!unlockHuntingCityList_.Equals(other.unlockHuntingCityList_)) return false;
    if (Unk3300GJFNOPNMFNG != other.Unk3300GJFNOPNMFNG) return false;
    if (Unk3300NCMHMODIIKM != other.Unk3300NCMHMODIIKM) return false;
    if(!rewardCityList_.Equals(other.rewardCityList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    hash ^= unlockHuntingCityList_.GetHashCode();
    if (Unk3300GJFNOPNMFNG != false) hash ^= Unk3300GJFNOPNMFNG.GetHashCode();
    if (Unk3300NCMHMODIIKM != false) hash ^= Unk3300NCMHMODIIKM.GetHashCode();
    hash ^= rewardCityList_.GetHashCode();
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
    unlockHuntingCityList_.WriteTo(output, _repeated_unlockHuntingCityList_codec);
    if (Unk3300NCMHMODIIKM != false) {
      output.WriteRawTag(40);
      output.WriteBool(Unk3300NCMHMODIIKM);
    }
    if (Unk3300GJFNOPNMFNG != false) {
      output.WriteRawTag(96);
      output.WriteBool(Unk3300GJFNOPNMFNG);
    }
    if (Retcode != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
    }
    rewardCityList_.WriteTo(output, _repeated_rewardCityList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    unlockHuntingCityList_.WriteTo(ref output, _repeated_unlockHuntingCityList_codec);
    if (Unk3300NCMHMODIIKM != false) {
      output.WriteRawTag(40);
      output.WriteBool(Unk3300NCMHMODIIKM);
    }
    if (Unk3300GJFNOPNMFNG != false) {
      output.WriteRawTag(96);
      output.WriteBool(Unk3300GJFNOPNMFNG);
    }
    if (Retcode != 0) {
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
    }
    rewardCityList_.WriteTo(ref output, _repeated_rewardCityList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    size += unlockHuntingCityList_.CalculateSize(_repeated_unlockHuntingCityList_codec);
    if (Unk3300GJFNOPNMFNG != false) {
      size += 1 + 1;
    }
    if (Unk3300NCMHMODIIKM != false) {
      size += 1 + 1;
    }
    size += rewardCityList_.CalculateSize(_repeated_rewardCityList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GetCityReputationMapInfoRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    unlockHuntingCityList_.Add(other.unlockHuntingCityList_);
    if (other.Unk3300GJFNOPNMFNG != false) {
      Unk3300GJFNOPNMFNG = other.Unk3300GJFNOPNMFNG;
    }
    if (other.Unk3300NCMHMODIIKM != false) {
      Unk3300NCMHMODIIKM = other.Unk3300NCMHMODIIKM;
    }
    rewardCityList_.Add(other.rewardCityList_);
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
        case 34:
        case 32: {
          unlockHuntingCityList_.AddEntriesFrom(input, _repeated_unlockHuntingCityList_codec);
          break;
        }
        case 40: {
          Unk3300NCMHMODIIKM = input.ReadBool();
          break;
        }
        case 96: {
          Unk3300GJFNOPNMFNG = input.ReadBool();
          break;
        }
        case 104: {
          Retcode = input.ReadInt32();
          break;
        }
        case 122:
        case 120: {
          rewardCityList_.AddEntriesFrom(input, _repeated_rewardCityList_codec);
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
        case 34:
        case 32: {
          unlockHuntingCityList_.AddEntriesFrom(ref input, _repeated_unlockHuntingCityList_codec);
          break;
        }
        case 40: {
          Unk3300NCMHMODIIKM = input.ReadBool();
          break;
        }
        case 96: {
          Unk3300GJFNOPNMFNG = input.ReadBool();
          break;
        }
        case 104: {
          Retcode = input.ReadInt32();
          break;
        }
        case 122:
        case 120: {
          rewardCityList_.AddEntriesFrom(ref input, _repeated_rewardCityList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
