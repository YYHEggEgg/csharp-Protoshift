// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoinCollectGallerySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CoinCollectGallerySettleNotify.proto</summary>
public static partial class CoinCollectGallerySettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for CoinCollectGallerySettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CoinCollectGallerySettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiRDb2luQ29sbGVjdEdhbGxlcnlTZXR0bGVOb3RpZnkucHJvdG8itQEKHkNv",
          "aW5Db2xsZWN0R2FsbGVyeVNldHRsZU5vdGlmeRIYChBjb2luX2NvbGxlY3Rf",
          "bnVtGAsgASgNEhYKDmNvaW5fdG90YWxfbnVtGAcgASgNEhAKCGxldmVsX2lk",
          "GAkgASgNEhkKEWNvaW5fY29sbGVjdF90aW1lGAQgASgNEh0KFW11bHRpc3Rh",
          "Z2VfcGxheV9pbmRleBgGIAEoDRIVCg1pc19uZXdfcmVjb3JkGAogASgIQh4K",
          "HGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CoinCollectGallerySettleNotify), global::CoinCollectGallerySettleNotify.Parser, new[]{ "CoinCollectNum", "CoinTotalNum", "LevelId", "CoinCollectTime", "MultistagePlayIndex", "IsNewRecord" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CoinCollectGallerySettleNotify : pb::IMessage<CoinCollectGallerySettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CoinCollectGallerySettleNotify> _parser = new pb::MessageParser<CoinCollectGallerySettleNotify>(() => new CoinCollectGallerySettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CoinCollectGallerySettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CoinCollectGallerySettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CoinCollectGallerySettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CoinCollectGallerySettleNotify(CoinCollectGallerySettleNotify other) : this() {
    coinCollectNum_ = other.coinCollectNum_;
    coinTotalNum_ = other.coinTotalNum_;
    levelId_ = other.levelId_;
    coinCollectTime_ = other.coinCollectTime_;
    multistagePlayIndex_ = other.multistagePlayIndex_;
    isNewRecord_ = other.isNewRecord_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CoinCollectGallerySettleNotify Clone() {
    return new CoinCollectGallerySettleNotify(this);
  }

  /// <summary>Field number for the "coin_collect_num" field.</summary>
  public const int CoinCollectNumFieldNumber = 11;
  private uint coinCollectNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CoinCollectNum {
    get { return coinCollectNum_; }
    set {
      coinCollectNum_ = value;
    }
  }

  /// <summary>Field number for the "coin_total_num" field.</summary>
  public const int CoinTotalNumFieldNumber = 7;
  private uint coinTotalNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CoinTotalNum {
    get { return coinTotalNum_; }
    set {
      coinTotalNum_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 9;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "coin_collect_time" field.</summary>
  public const int CoinCollectTimeFieldNumber = 4;
  private uint coinCollectTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CoinCollectTime {
    get { return coinCollectTime_; }
    set {
      coinCollectTime_ = value;
    }
  }

  /// <summary>Field number for the "multistage_play_index" field.</summary>
  public const int MultistagePlayIndexFieldNumber = 6;
  private uint multistagePlayIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MultistagePlayIndex {
    get { return multistagePlayIndex_; }
    set {
      multistagePlayIndex_ = value;
    }
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 10;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CoinCollectGallerySettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CoinCollectGallerySettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CoinCollectNum != other.CoinCollectNum) return false;
    if (CoinTotalNum != other.CoinTotalNum) return false;
    if (LevelId != other.LevelId) return false;
    if (CoinCollectTime != other.CoinCollectTime) return false;
    if (MultistagePlayIndex != other.MultistagePlayIndex) return false;
    if (IsNewRecord != other.IsNewRecord) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (CoinCollectNum != 0) hash ^= CoinCollectNum.GetHashCode();
    if (CoinTotalNum != 0) hash ^= CoinTotalNum.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (CoinCollectTime != 0) hash ^= CoinCollectTime.GetHashCode();
    if (MultistagePlayIndex != 0) hash ^= MultistagePlayIndex.GetHashCode();
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
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
    if (CoinCollectTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CoinCollectTime);
    }
    if (MultistagePlayIndex != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(MultistagePlayIndex);
    }
    if (CoinTotalNum != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CoinTotalNum);
    }
    if (LevelId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(LevelId);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsNewRecord);
    }
    if (CoinCollectNum != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(CoinCollectNum);
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
    if (CoinCollectTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(CoinCollectTime);
    }
    if (MultistagePlayIndex != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(MultistagePlayIndex);
    }
    if (CoinTotalNum != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(CoinTotalNum);
    }
    if (LevelId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(LevelId);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsNewRecord);
    }
    if (CoinCollectNum != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(CoinCollectNum);
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
    if (CoinCollectNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinCollectNum);
    }
    if (CoinTotalNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinTotalNum);
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (CoinCollectTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinCollectTime);
    }
    if (MultistagePlayIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MultistagePlayIndex);
    }
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CoinCollectGallerySettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.CoinCollectNum != 0) {
      CoinCollectNum = other.CoinCollectNum;
    }
    if (other.CoinTotalNum != 0) {
      CoinTotalNum = other.CoinTotalNum;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.CoinCollectTime != 0) {
      CoinCollectTime = other.CoinCollectTime;
    }
    if (other.MultistagePlayIndex != 0) {
      MultistagePlayIndex = other.MultistagePlayIndex;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
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
        case 32: {
          CoinCollectTime = input.ReadUInt32();
          break;
        }
        case 48: {
          MultistagePlayIndex = input.ReadUInt32();
          break;
        }
        case 56: {
          CoinTotalNum = input.ReadUInt32();
          break;
        }
        case 72: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 80: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 88: {
          CoinCollectNum = input.ReadUInt32();
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
        case 32: {
          CoinCollectTime = input.ReadUInt32();
          break;
        }
        case 48: {
          MultistagePlayIndex = input.ReadUInt32();
          break;
        }
        case 56: {
          CoinTotalNum = input.ReadUInt32();
          break;
        }
        case 72: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 80: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 88: {
          CoinCollectNum = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
