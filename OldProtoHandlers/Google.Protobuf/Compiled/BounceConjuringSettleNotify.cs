// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BounceConjuringSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from BounceConjuringSettleNotify.proto</summary>
  public static partial class BounceConjuringSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BounceConjuringSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BounceConjuringSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFCb3VuY2VDb25qdXJpbmdTZXR0bGVOb3RpZnkucHJvdG8aJkJvdW5jZUNv",
            "bmp1cmluZ0dhbGxlcnlTZXR0bGVJbmZvLnByb3RvIoACChtCb3VuY2VDb25q",
            "dXJpbmdTZXR0bGVOb3RpZnkSFQoNaXNfbmV3X3JlY29yZBgOIAEoCBJICg9z",
            "ZXR0bGVfaW5mb19tYXAYBCADKAsyLy5Cb3VuY2VDb25qdXJpbmdTZXR0bGVO",
            "b3RpZnkuU2V0dGxlSW5mb01hcEVudHJ5EhMKC3RvdGFsX3Njb3JlGAIgASgN",
            "EhIKCmNoYXB0ZXJfaWQYDSABKA0aVwoSU2V0dGxlSW5mb01hcEVudHJ5EgsK",
            "A2tleRgBIAEoDRIwCgV2YWx1ZRgCIAEoCzIhLkJvdW5jZUNvbmp1cmluZ0dh",
            "bGxlcnlTZXR0bGVJbmZvOgI4AUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.BounceConjuringGallerySettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.BounceConjuringSettleNotify), global::OldProtos.BounceConjuringSettleNotify.Parser, new[]{ "IsNewRecord", "SettleInfoMap", "TotalScore", "ChapterId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8084
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class BounceConjuringSettleNotify : pb::IMessage<BounceConjuringSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BounceConjuringSettleNotify> _parser = new pb::MessageParser<BounceConjuringSettleNotify>(() => new BounceConjuringSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BounceConjuringSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.BounceConjuringSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringSettleNotify(BounceConjuringSettleNotify other) : this() {
      isNewRecord_ = other.isNewRecord_;
      settleInfoMap_ = other.settleInfoMap_.Clone();
      totalScore_ = other.totalScore_;
      chapterId_ = other.chapterId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringSettleNotify Clone() {
      return new BounceConjuringSettleNotify(this);
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 14;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "settle_info_map" field.</summary>
    public const int SettleInfoMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, global::OldProtos.BounceConjuringGallerySettleInfo>.Codec _map_settleInfoMap_codec
        = new pbc::MapField<uint, global::OldProtos.BounceConjuringGallerySettleInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.BounceConjuringGallerySettleInfo.Parser), 34);
    private readonly pbc::MapField<uint, global::OldProtos.BounceConjuringGallerySettleInfo> settleInfoMap_ = new pbc::MapField<uint, global::OldProtos.BounceConjuringGallerySettleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.BounceConjuringGallerySettleInfo> SettleInfoMap {
      get { return settleInfoMap_; }
    }

    /// <summary>Field number for the "total_score" field.</summary>
    public const int TotalScoreFieldNumber = 2;
    private uint totalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalScore {
      get { return totalScore_; }
      set {
        totalScore_ = value;
      }
    }

    /// <summary>Field number for the "chapter_id" field.</summary>
    public const int ChapterIdFieldNumber = 13;
    private uint chapterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChapterId {
      get { return chapterId_; }
      set {
        chapterId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BounceConjuringSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BounceConjuringSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsNewRecord != other.IsNewRecord) return false;
      if (!SettleInfoMap.Equals(other.SettleInfoMap)) return false;
      if (TotalScore != other.TotalScore) return false;
      if (ChapterId != other.ChapterId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      hash ^= SettleInfoMap.GetHashCode();
      if (TotalScore != 0) hash ^= TotalScore.GetHashCode();
      if (ChapterId != 0) hash ^= ChapterId.GetHashCode();
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
      if (TotalScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TotalScore);
      }
      settleInfoMap_.WriteTo(output, _map_settleInfoMap_codec);
      if (ChapterId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChapterId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsNewRecord);
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
      if (TotalScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TotalScore);
      }
      settleInfoMap_.WriteTo(ref output, _map_settleInfoMap_codec);
      if (ChapterId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChapterId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsNewRecord);
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
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      size += settleInfoMap_.CalculateSize(_map_settleInfoMap_codec);
      if (TotalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalScore);
      }
      if (ChapterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChapterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BounceConjuringSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      settleInfoMap_.MergeFrom(other.settleInfoMap_);
      if (other.TotalScore != 0) {
        TotalScore = other.TotalScore;
      }
      if (other.ChapterId != 0) {
        ChapterId = other.ChapterId;
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
          case 16: {
            TotalScore = input.ReadUInt32();
            break;
          }
          case 34: {
            settleInfoMap_.AddEntriesFrom(input, _map_settleInfoMap_codec);
            break;
          }
          case 104: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsNewRecord = input.ReadBool();
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
          case 16: {
            TotalScore = input.ReadUInt32();
            break;
          }
          case 34: {
            settleInfoMap_.AddEntriesFrom(ref input, _map_settleInfoMap_codec);
            break;
          }
          case 104: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsNewRecord = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
