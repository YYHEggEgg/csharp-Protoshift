// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonChallengeFinishNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from DungeonChallengeFinishNotify.proto</summary>
  public static partial class DungeonChallengeFinishNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonChallengeFinishNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonChallengeFinishNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJEdW5nZW9uQ2hhbGxlbmdlRmluaXNoTm90aWZ5LnByb3RvGhlDaGFsbGVu",
            "Z2VGaW5pc2hUeXBlLnByb3RvGihDaGFubmVsZXJTbGFiTG9vcER1bmdlb25S",
            "ZXN1bHRJbmZvLnByb3RvGh1DdXN0b21EdW5nZW9uUmVzdWx0SW5mby5wcm90",
            "bxomRWZmaWd5Q2hhbGxlbmdlRHVuZ2VvblJlc3VsdEluZm8ucHJvdG8aHVBv",
            "dGlvbkR1bmdlb25SZXN1bHRJbmZvLnByb3RvGhlTdHJlbmd0aGVuUG9pbnRE",
            "YXRhLnByb3RvIsIFChxEdW5nZW9uQ2hhbGxlbmdlRmluaXNoTm90aWZ5ElwK",
            "GXN0cmVuZ3RoZW5fcG9pbnRfZGF0YV9tYXAYDSADKAsyOS5EdW5nZW9uQ2hh",
            "bGxlbmdlRmluaXNoTm90aWZ5LlN0cmVuZ3RoZW5Qb2ludERhdGFNYXBFbnRy",
            "eRIpCgtmaW5pc2hfdHlwZRgJIAEoDjIULkNoYWxsZW5nZUZpbmlzaFR5cGUS",
            "FQoNaXNfbmV3X3JlY29yZBgKIAEoCBIdChVjaGFsbGVuZ2VfcmVjb3JkX3R5",
            "cGUYByABKA0SEQoJdGltZV9jb3N0GAQgASgNEhUKDWN1cnJlbnRfdmFsdWUY",
            "DyABKA0SEgoKaXNfc3VjY2VzcxgDIAEoCBIXCg9jaGFsbGVuZ2VfaW5kZXgY",
            "BSABKA0SVwonY2hhbm5lbGVyX3NsYWJfbG9vcF9kdW5nZW9uX3Jlc3VsdF9p",
            "bmZvGPELIAEoCzIjLkNoYW5uZWxlclNsYWJMb29wRHVuZ2VvblJlc3VsdElu",
            "Zm9IABJSCiRlZmZpZ3lfY2hhbGxlbmdlX2R1bmdlb25fcmVzdWx0X2luZm8Y",
            "2wwgASgLMiEuRWZmaWd5Q2hhbGxlbmdlRHVuZ2VvblJlc3VsdEluZm9IABI/",
            "Chpwb3Rpb25fZHVuZ2Vvbl9yZXN1bHRfaW5mbxigDiABKAsyGC5Qb3Rpb25E",
            "dW5nZW9uUmVzdWx0SW5mb0gAEj8KGmN1c3RvbV9kdW5nZW9uX3Jlc3VsdF9p",
            "bmZvGIANIAEoCzIYLkN1c3RvbUR1bmdlb25SZXN1bHRJbmZvSAAaUwobU3Ry",
            "ZW5ndGhlblBvaW50RGF0YU1hcEVudHJ5EgsKA2tleRgBIAEoDRIjCgV2YWx1",
            "ZRgCIAEoCzIULlN0cmVuZ3RoZW5Qb2ludERhdGE6AjgBQggKBmRldGFpbEIM",
            "qgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ChallengeFinishTypeReflection.Descriptor, global::OldProtos.ChannelerSlabLoopDungeonResultInfoReflection.Descriptor, global::OldProtos.CustomDungeonResultInfoReflection.Descriptor, global::OldProtos.EffigyChallengeDungeonResultInfoReflection.Descriptor, global::OldProtos.PotionDungeonResultInfoReflection.Descriptor, global::OldProtos.StrengthenPointDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.DungeonChallengeFinishNotify), global::OldProtos.DungeonChallengeFinishNotify.Parser, new[]{ "StrengthenPointDataMap", "FinishType", "IsNewRecord", "ChallengeRecordType", "TimeCost", "CurrentValue", "IsSuccess", "ChallengeIndex", "ChannelerSlabLoopDungeonResultInfo", "EffigyChallengeDungeonResultInfo", "PotionDungeonResultInfo", "CustomDungeonResultInfo" }, new[]{ "Detail" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 939
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class DungeonChallengeFinishNotify : pb::IMessage<DungeonChallengeFinishNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonChallengeFinishNotify> _parser = new pb::MessageParser<DungeonChallengeFinishNotify>(() => new DungeonChallengeFinishNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonChallengeFinishNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.DungeonChallengeFinishNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeFinishNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeFinishNotify(DungeonChallengeFinishNotify other) : this() {
      strengthenPointDataMap_ = other.strengthenPointDataMap_.Clone();
      finishType_ = other.finishType_;
      isNewRecord_ = other.isNewRecord_;
      challengeRecordType_ = other.challengeRecordType_;
      timeCost_ = other.timeCost_;
      currentValue_ = other.currentValue_;
      isSuccess_ = other.isSuccess_;
      challengeIndex_ = other.challengeIndex_;
      switch (other.DetailCase) {
        case DetailOneofCase.ChannelerSlabLoopDungeonResultInfo:
          ChannelerSlabLoopDungeonResultInfo = other.ChannelerSlabLoopDungeonResultInfo.Clone();
          break;
        case DetailOneofCase.EffigyChallengeDungeonResultInfo:
          EffigyChallengeDungeonResultInfo = other.EffigyChallengeDungeonResultInfo.Clone();
          break;
        case DetailOneofCase.PotionDungeonResultInfo:
          PotionDungeonResultInfo = other.PotionDungeonResultInfo.Clone();
          break;
        case DetailOneofCase.CustomDungeonResultInfo:
          CustomDungeonResultInfo = other.CustomDungeonResultInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeFinishNotify Clone() {
      return new DungeonChallengeFinishNotify(this);
    }

    /// <summary>Field number for the "strengthen_point_data_map" field.</summary>
    public const int StrengthenPointDataMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, global::OldProtos.StrengthenPointData>.Codec _map_strengthenPointDataMap_codec
        = new pbc::MapField<uint, global::OldProtos.StrengthenPointData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.StrengthenPointData.Parser), 106);
    private readonly pbc::MapField<uint, global::OldProtos.StrengthenPointData> strengthenPointDataMap_ = new pbc::MapField<uint, global::OldProtos.StrengthenPointData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.StrengthenPointData> StrengthenPointDataMap {
      get { return strengthenPointDataMap_; }
    }

    /// <summary>Field number for the "finish_type" field.</summary>
    public const int FinishTypeFieldNumber = 9;
    private global::OldProtos.ChallengeFinishType finishType_ = global::OldProtos.ChallengeFinishType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ChallengeFinishType FinishType {
      get { return finishType_; }
      set {
        finishType_ = value;
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

    /// <summary>Field number for the "challenge_record_type" field.</summary>
    public const int ChallengeRecordTypeFieldNumber = 7;
    private uint challengeRecordType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeRecordType {
      get { return challengeRecordType_; }
      set {
        challengeRecordType_ = value;
      }
    }

    /// <summary>Field number for the "time_cost" field.</summary>
    public const int TimeCostFieldNumber = 4;
    private uint timeCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeCost {
      get { return timeCost_; }
      set {
        timeCost_ = value;
      }
    }

    /// <summary>Field number for the "current_value" field.</summary>
    public const int CurrentValueFieldNumber = 15;
    private uint currentValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurrentValue {
      get { return currentValue_; }
      set {
        currentValue_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 3;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "challenge_index" field.</summary>
    public const int ChallengeIndexFieldNumber = 5;
    private uint challengeIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeIndex {
      get { return challengeIndex_; }
      set {
        challengeIndex_ = value;
      }
    }

    /// <summary>Field number for the "channeler_slab_loop_dungeon_result_info" field.</summary>
    public const int ChannelerSlabLoopDungeonResultInfoFieldNumber = 1521;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ChannelerSlabLoopDungeonResultInfo ChannelerSlabLoopDungeonResultInfo {
      get { return detailCase_ == DetailOneofCase.ChannelerSlabLoopDungeonResultInfo ? (global::OldProtos.ChannelerSlabLoopDungeonResultInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.ChannelerSlabLoopDungeonResultInfo;
      }
    }

    /// <summary>Field number for the "effigy_challenge_dungeon_result_info" field.</summary>
    public const int EffigyChallengeDungeonResultInfoFieldNumber = 1627;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.EffigyChallengeDungeonResultInfo EffigyChallengeDungeonResultInfo {
      get { return detailCase_ == DetailOneofCase.EffigyChallengeDungeonResultInfo ? (global::OldProtos.EffigyChallengeDungeonResultInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.EffigyChallengeDungeonResultInfo;
      }
    }

    /// <summary>Field number for the "potion_dungeon_result_info" field.</summary>
    public const int PotionDungeonResultInfoFieldNumber = 1824;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.PotionDungeonResultInfo PotionDungeonResultInfo {
      get { return detailCase_ == DetailOneofCase.PotionDungeonResultInfo ? (global::OldProtos.PotionDungeonResultInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.PotionDungeonResultInfo;
      }
    }

    /// <summary>Field number for the "custom_dungeon_result_info" field.</summary>
    public const int CustomDungeonResultInfoFieldNumber = 1664;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.CustomDungeonResultInfo CustomDungeonResultInfo {
      get { return detailCase_ == DetailOneofCase.CustomDungeonResultInfo ? (global::OldProtos.CustomDungeonResultInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.CustomDungeonResultInfo;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      ChannelerSlabLoopDungeonResultInfo = 1521,
      EffigyChallengeDungeonResultInfo = 1627,
      PotionDungeonResultInfo = 1824,
      CustomDungeonResultInfo = 1664,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonChallengeFinishNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonChallengeFinishNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!StrengthenPointDataMap.Equals(other.StrengthenPointDataMap)) return false;
      if (FinishType != other.FinishType) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (ChallengeRecordType != other.ChallengeRecordType) return false;
      if (TimeCost != other.TimeCost) return false;
      if (CurrentValue != other.CurrentValue) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (ChallengeIndex != other.ChallengeIndex) return false;
      if (!object.Equals(ChannelerSlabLoopDungeonResultInfo, other.ChannelerSlabLoopDungeonResultInfo)) return false;
      if (!object.Equals(EffigyChallengeDungeonResultInfo, other.EffigyChallengeDungeonResultInfo)) return false;
      if (!object.Equals(PotionDungeonResultInfo, other.PotionDungeonResultInfo)) return false;
      if (!object.Equals(CustomDungeonResultInfo, other.CustomDungeonResultInfo)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= StrengthenPointDataMap.GetHashCode();
      if (FinishType != global::OldProtos.ChallengeFinishType.None) hash ^= FinishType.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (ChallengeRecordType != 0) hash ^= ChallengeRecordType.GetHashCode();
      if (TimeCost != 0) hash ^= TimeCost.GetHashCode();
      if (CurrentValue != 0) hash ^= CurrentValue.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (ChallengeIndex != 0) hash ^= ChallengeIndex.GetHashCode();
      if (detailCase_ == DetailOneofCase.ChannelerSlabLoopDungeonResultInfo) hash ^= ChannelerSlabLoopDungeonResultInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.EffigyChallengeDungeonResultInfo) hash ^= EffigyChallengeDungeonResultInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.PotionDungeonResultInfo) hash ^= PotionDungeonResultInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.CustomDungeonResultInfo) hash ^= CustomDungeonResultInfo.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (IsSuccess != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSuccess);
      }
      if (TimeCost != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TimeCost);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ChallengeIndex);
      }
      if (ChallengeRecordType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeRecordType);
      }
      if (FinishType != global::OldProtos.ChallengeFinishType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) FinishType);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNewRecord);
      }
      strengthenPointDataMap_.WriteTo(output, _map_strengthenPointDataMap_codec);
      if (CurrentValue != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurrentValue);
      }
      if (detailCase_ == DetailOneofCase.ChannelerSlabLoopDungeonResultInfo) {
        output.WriteRawTag(138, 95);
        output.WriteMessage(ChannelerSlabLoopDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.EffigyChallengeDungeonResultInfo) {
        output.WriteRawTag(218, 101);
        output.WriteMessage(EffigyChallengeDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.CustomDungeonResultInfo) {
        output.WriteRawTag(130, 104);
        output.WriteMessage(CustomDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.PotionDungeonResultInfo) {
        output.WriteRawTag(130, 114);
        output.WriteMessage(PotionDungeonResultInfo);
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
      if (IsSuccess != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSuccess);
      }
      if (TimeCost != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TimeCost);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ChallengeIndex);
      }
      if (ChallengeRecordType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeRecordType);
      }
      if (FinishType != global::OldProtos.ChallengeFinishType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) FinishType);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNewRecord);
      }
      strengthenPointDataMap_.WriteTo(ref output, _map_strengthenPointDataMap_codec);
      if (CurrentValue != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurrentValue);
      }
      if (detailCase_ == DetailOneofCase.ChannelerSlabLoopDungeonResultInfo) {
        output.WriteRawTag(138, 95);
        output.WriteMessage(ChannelerSlabLoopDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.EffigyChallengeDungeonResultInfo) {
        output.WriteRawTag(218, 101);
        output.WriteMessage(EffigyChallengeDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.CustomDungeonResultInfo) {
        output.WriteRawTag(130, 104);
        output.WriteMessage(CustomDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.PotionDungeonResultInfo) {
        output.WriteRawTag(130, 114);
        output.WriteMessage(PotionDungeonResultInfo);
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
      size += strengthenPointDataMap_.CalculateSize(_map_strengthenPointDataMap_codec);
      if (FinishType != global::OldProtos.ChallengeFinishType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FinishType);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (ChallengeRecordType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeRecordType);
      }
      if (TimeCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeCost);
      }
      if (CurrentValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrentValue);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (ChallengeIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeIndex);
      }
      if (detailCase_ == DetailOneofCase.ChannelerSlabLoopDungeonResultInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ChannelerSlabLoopDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.EffigyChallengeDungeonResultInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EffigyChallengeDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.PotionDungeonResultInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(PotionDungeonResultInfo);
      }
      if (detailCase_ == DetailOneofCase.CustomDungeonResultInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CustomDungeonResultInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonChallengeFinishNotify other) {
      if (other == null) {
        return;
      }
      strengthenPointDataMap_.Add(other.strengthenPointDataMap_);
      if (other.FinishType != global::OldProtos.ChallengeFinishType.None) {
        FinishType = other.FinishType;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.ChallengeRecordType != 0) {
        ChallengeRecordType = other.ChallengeRecordType;
      }
      if (other.TimeCost != 0) {
        TimeCost = other.TimeCost;
      }
      if (other.CurrentValue != 0) {
        CurrentValue = other.CurrentValue;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.ChallengeIndex != 0) {
        ChallengeIndex = other.ChallengeIndex;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.ChannelerSlabLoopDungeonResultInfo:
          if (ChannelerSlabLoopDungeonResultInfo == null) {
            ChannelerSlabLoopDungeonResultInfo = new global::OldProtos.ChannelerSlabLoopDungeonResultInfo();
          }
          ChannelerSlabLoopDungeonResultInfo.MergeFrom(other.ChannelerSlabLoopDungeonResultInfo);
          break;
        case DetailOneofCase.EffigyChallengeDungeonResultInfo:
          if (EffigyChallengeDungeonResultInfo == null) {
            EffigyChallengeDungeonResultInfo = new global::OldProtos.EffigyChallengeDungeonResultInfo();
          }
          EffigyChallengeDungeonResultInfo.MergeFrom(other.EffigyChallengeDungeonResultInfo);
          break;
        case DetailOneofCase.PotionDungeonResultInfo:
          if (PotionDungeonResultInfo == null) {
            PotionDungeonResultInfo = new global::OldProtos.PotionDungeonResultInfo();
          }
          PotionDungeonResultInfo.MergeFrom(other.PotionDungeonResultInfo);
          break;
        case DetailOneofCase.CustomDungeonResultInfo:
          if (CustomDungeonResultInfo == null) {
            CustomDungeonResultInfo = new global::OldProtos.CustomDungeonResultInfo();
          }
          CustomDungeonResultInfo.MergeFrom(other.CustomDungeonResultInfo);
          break;
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 32: {
            TimeCost = input.ReadUInt32();
            break;
          }
          case 40: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            ChallengeRecordType = input.ReadUInt32();
            break;
          }
          case 72: {
            FinishType = (global::OldProtos.ChallengeFinishType) input.ReadEnum();
            break;
          }
          case 80: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 106: {
            strengthenPointDataMap_.AddEntriesFrom(input, _map_strengthenPointDataMap_codec);
            break;
          }
          case 120: {
            CurrentValue = input.ReadUInt32();
            break;
          }
          case 12170: {
            global::OldProtos.ChannelerSlabLoopDungeonResultInfo subBuilder = new global::OldProtos.ChannelerSlabLoopDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.ChannelerSlabLoopDungeonResultInfo) {
              subBuilder.MergeFrom(ChannelerSlabLoopDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            ChannelerSlabLoopDungeonResultInfo = subBuilder;
            break;
          }
          case 13018: {
            global::OldProtos.EffigyChallengeDungeonResultInfo subBuilder = new global::OldProtos.EffigyChallengeDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.EffigyChallengeDungeonResultInfo) {
              subBuilder.MergeFrom(EffigyChallengeDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            EffigyChallengeDungeonResultInfo = subBuilder;
            break;
          }
          case 13314: {
            global::OldProtos.CustomDungeonResultInfo subBuilder = new global::OldProtos.CustomDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.CustomDungeonResultInfo) {
              subBuilder.MergeFrom(CustomDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            CustomDungeonResultInfo = subBuilder;
            break;
          }
          case 14594: {
            global::OldProtos.PotionDungeonResultInfo subBuilder = new global::OldProtos.PotionDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.PotionDungeonResultInfo) {
              subBuilder.MergeFrom(PotionDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            PotionDungeonResultInfo = subBuilder;
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 32: {
            TimeCost = input.ReadUInt32();
            break;
          }
          case 40: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            ChallengeRecordType = input.ReadUInt32();
            break;
          }
          case 72: {
            FinishType = (global::OldProtos.ChallengeFinishType) input.ReadEnum();
            break;
          }
          case 80: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 106: {
            strengthenPointDataMap_.AddEntriesFrom(ref input, _map_strengthenPointDataMap_codec);
            break;
          }
          case 120: {
            CurrentValue = input.ReadUInt32();
            break;
          }
          case 12170: {
            global::OldProtos.ChannelerSlabLoopDungeonResultInfo subBuilder = new global::OldProtos.ChannelerSlabLoopDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.ChannelerSlabLoopDungeonResultInfo) {
              subBuilder.MergeFrom(ChannelerSlabLoopDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            ChannelerSlabLoopDungeonResultInfo = subBuilder;
            break;
          }
          case 13018: {
            global::OldProtos.EffigyChallengeDungeonResultInfo subBuilder = new global::OldProtos.EffigyChallengeDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.EffigyChallengeDungeonResultInfo) {
              subBuilder.MergeFrom(EffigyChallengeDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            EffigyChallengeDungeonResultInfo = subBuilder;
            break;
          }
          case 13314: {
            global::OldProtos.CustomDungeonResultInfo subBuilder = new global::OldProtos.CustomDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.CustomDungeonResultInfo) {
              subBuilder.MergeFrom(CustomDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            CustomDungeonResultInfo = subBuilder;
            break;
          }
          case 14594: {
            global::OldProtos.PotionDungeonResultInfo subBuilder = new global::OldProtos.PotionDungeonResultInfo();
            if (detailCase_ == DetailOneofCase.PotionDungeonResultInfo) {
              subBuilder.MergeFrom(PotionDungeonResultInfo);
            }
            input.ReadMessage(subBuilder);
            PotionDungeonResultInfo = subBuilder;
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
