// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarFetterInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AvatarFetterInfo.proto</summary>
public static partial class AvatarFetterInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for AvatarFetterInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AvatarFetterInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZBdmF0YXJGZXR0ZXJJbmZvLnByb3RvGhBGZXR0ZXJEYXRhLnByb3RvIq0B",
          "ChBBdmF0YXJGZXR0ZXJJbmZvEhIKCmV4cF9udW1iZXIYASABKA0SEQoJZXhw",
          "X2xldmVsGAIgASgNEhQKDG9wZW5faWRfbGlzdBgDIAMoDRIWCg5maW5pc2hf",
          "aWRfbGlzdBgEIAMoDRIiChpyZXdhcmRlZF9mZXR0ZXJfbGV2ZWxfbGlzdBgF",
          "IAMoDRIgCgtmZXR0ZXJfbGlzdBgGIAMoCzILLkZldHRlckRhdGFCHgocZW11",
          "LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::FetterDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AvatarFetterInfo), global::AvatarFetterInfo.Parser, new[]{ "ExpNumber", "ExpLevel", "OpenIdList", "FinishIdList", "RewardedFetterLevelList", "FetterList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AvatarFetterInfo : pb::IMessage<AvatarFetterInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AvatarFetterInfo> _parser = new pb::MessageParser<AvatarFetterInfo>(() => new AvatarFetterInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AvatarFetterInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AvatarFetterInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarFetterInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarFetterInfo(AvatarFetterInfo other) : this() {
    expNumber_ = other.expNumber_;
    expLevel_ = other.expLevel_;
    openIdList_ = other.openIdList_.Clone();
    finishIdList_ = other.finishIdList_.Clone();
    rewardedFetterLevelList_ = other.rewardedFetterLevelList_.Clone();
    fetterList_ = other.fetterList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarFetterInfo Clone() {
    return new AvatarFetterInfo(this);
  }

  /// <summary>Field number for the "exp_number" field.</summary>
  public const int ExpNumberFieldNumber = 1;
  private uint expNumber_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ExpNumber {
    get { return expNumber_; }
    set {
      expNumber_ = value;
    }
  }

  /// <summary>Field number for the "exp_level" field.</summary>
  public const int ExpLevelFieldNumber = 2;
  private uint expLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ExpLevel {
    get { return expLevel_; }
    set {
      expLevel_ = value;
    }
  }

  /// <summary>Field number for the "open_id_list" field.</summary>
  public const int OpenIdListFieldNumber = 3;
  private static readonly pb::FieldCodec<uint> _repeated_openIdList_codec
      = pb::FieldCodec.ForUInt32(26);
  private readonly pbc::RepeatedField<uint> openIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> OpenIdList {
    get { return openIdList_; }
  }

  /// <summary>Field number for the "finish_id_list" field.</summary>
  public const int FinishIdListFieldNumber = 4;
  private static readonly pb::FieldCodec<uint> _repeated_finishIdList_codec
      = pb::FieldCodec.ForUInt32(34);
  private readonly pbc::RepeatedField<uint> finishIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> FinishIdList {
    get { return finishIdList_; }
  }

  /// <summary>Field number for the "rewarded_fetter_level_list" field.</summary>
  public const int RewardedFetterLevelListFieldNumber = 5;
  private static readonly pb::FieldCodec<uint> _repeated_rewardedFetterLevelList_codec
      = pb::FieldCodec.ForUInt32(42);
  private readonly pbc::RepeatedField<uint> rewardedFetterLevelList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> RewardedFetterLevelList {
    get { return rewardedFetterLevelList_; }
  }

  /// <summary>Field number for the "fetter_list" field.</summary>
  public const int FetterListFieldNumber = 6;
  private static readonly pb::FieldCodec<global::FetterData> _repeated_fetterList_codec
      = pb::FieldCodec.ForMessage(50, global::FetterData.Parser);
  private readonly pbc::RepeatedField<global::FetterData> fetterList_ = new pbc::RepeatedField<global::FetterData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::FetterData> FetterList {
    get { return fetterList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AvatarFetterInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AvatarFetterInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ExpNumber != other.ExpNumber) return false;
    if (ExpLevel != other.ExpLevel) return false;
    if(!openIdList_.Equals(other.openIdList_)) return false;
    if(!finishIdList_.Equals(other.finishIdList_)) return false;
    if(!rewardedFetterLevelList_.Equals(other.rewardedFetterLevelList_)) return false;
    if(!fetterList_.Equals(other.fetterList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ExpNumber != 0) hash ^= ExpNumber.GetHashCode();
    if (ExpLevel != 0) hash ^= ExpLevel.GetHashCode();
    hash ^= openIdList_.GetHashCode();
    hash ^= finishIdList_.GetHashCode();
    hash ^= rewardedFetterLevelList_.GetHashCode();
    hash ^= fetterList_.GetHashCode();
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
    if (ExpNumber != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ExpNumber);
    }
    if (ExpLevel != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ExpLevel);
    }
    openIdList_.WriteTo(output, _repeated_openIdList_codec);
    finishIdList_.WriteTo(output, _repeated_finishIdList_codec);
    rewardedFetterLevelList_.WriteTo(output, _repeated_rewardedFetterLevelList_codec);
    fetterList_.WriteTo(output, _repeated_fetterList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (ExpNumber != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(ExpNumber);
    }
    if (ExpLevel != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(ExpLevel);
    }
    openIdList_.WriteTo(ref output, _repeated_openIdList_codec);
    finishIdList_.WriteTo(ref output, _repeated_finishIdList_codec);
    rewardedFetterLevelList_.WriteTo(ref output, _repeated_rewardedFetterLevelList_codec);
    fetterList_.WriteTo(ref output, _repeated_fetterList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (ExpNumber != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExpNumber);
    }
    if (ExpLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExpLevel);
    }
    size += openIdList_.CalculateSize(_repeated_openIdList_codec);
    size += finishIdList_.CalculateSize(_repeated_finishIdList_codec);
    size += rewardedFetterLevelList_.CalculateSize(_repeated_rewardedFetterLevelList_codec);
    size += fetterList_.CalculateSize(_repeated_fetterList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AvatarFetterInfo other) {
    if (other == null) {
      return;
    }
    if (other.ExpNumber != 0) {
      ExpNumber = other.ExpNumber;
    }
    if (other.ExpLevel != 0) {
      ExpLevel = other.ExpLevel;
    }
    openIdList_.Add(other.openIdList_);
    finishIdList_.Add(other.finishIdList_);
    rewardedFetterLevelList_.Add(other.rewardedFetterLevelList_);
    fetterList_.Add(other.fetterList_);
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
          ExpNumber = input.ReadUInt32();
          break;
        }
        case 16: {
          ExpLevel = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          openIdList_.AddEntriesFrom(input, _repeated_openIdList_codec);
          break;
        }
        case 34:
        case 32: {
          finishIdList_.AddEntriesFrom(input, _repeated_finishIdList_codec);
          break;
        }
        case 42:
        case 40: {
          rewardedFetterLevelList_.AddEntriesFrom(input, _repeated_rewardedFetterLevelList_codec);
          break;
        }
        case 50: {
          fetterList_.AddEntriesFrom(input, _repeated_fetterList_codec);
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
          ExpNumber = input.ReadUInt32();
          break;
        }
        case 16: {
          ExpLevel = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          openIdList_.AddEntriesFrom(ref input, _repeated_openIdList_codec);
          break;
        }
        case 34:
        case 32: {
          finishIdList_.AddEntriesFrom(ref input, _repeated_finishIdList_codec);
          break;
        }
        case 42:
        case 40: {
          rewardedFetterLevelList_.AddEntriesFrom(ref input, _repeated_rewardedFetterLevelList_codec);
          break;
        }
        case 50: {
          fetterList_.AddEntriesFrom(ref input, _repeated_fetterList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code