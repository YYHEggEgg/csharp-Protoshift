// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MechanicusInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from MechanicusInfo.proto</summary>
  public static partial class MechanicusInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MechanicusInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MechanicusInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRNZWNoYW5pY3VzSW5mby5wcm90bxoQVWludDMyUGFpci5wcm90byLfAQoO",
            "TWVjaGFuaWN1c0luZm8SKQoUZ2Vhcl9sZXZlbF9wYWlyX2xpc3QYDiADKAsy",
            "Cy5VaW50MzJQYWlyEh0KFW9wZW5fc2VxdWVuY2VfaWRfbGlzdBgHIAMoDRIM",
            "CgRjb2luGAggASgNEhgKEHB1bmlzaF9vdmVyX3RpbWUYDCABKA0SFQoNbWVj",
            "aGFuaWN1c19pZBgKIAEoDRIjChtmaW5pc2hfZGlmZmljdWx0X2xldmVsX2xp",
            "c3QYDSADKA0SHwoXaXNfZmluaXNoX3RlYWNoX2R1bmdlb24YBCABKAhCDKoC",
            "CU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.Uint32PairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.MechanicusInfo), global::OldProtos.MechanicusInfo.Parser, new[]{ "GearLevelPairList", "OpenSequenceIdList", "Coin", "PunishOverTime", "MechanicusId", "FinishDifficultLevelList", "IsFinishTeachDungeon" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MechanicusInfo : pb::IMessage<MechanicusInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MechanicusInfo> _parser = new pb::MessageParser<MechanicusInfo>(() => new MechanicusInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MechanicusInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.MechanicusInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusInfo(MechanicusInfo other) : this() {
      gearLevelPairList_ = other.gearLevelPairList_.Clone();
      openSequenceIdList_ = other.openSequenceIdList_.Clone();
      coin_ = other.coin_;
      punishOverTime_ = other.punishOverTime_;
      mechanicusId_ = other.mechanicusId_;
      finishDifficultLevelList_ = other.finishDifficultLevelList_.Clone();
      isFinishTeachDungeon_ = other.isFinishTeachDungeon_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusInfo Clone() {
      return new MechanicusInfo(this);
    }

    /// <summary>Field number for the "gear_level_pair_list" field.</summary>
    public const int GearLevelPairListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::OldProtos.Uint32Pair> _repeated_gearLevelPairList_codec
        = pb::FieldCodec.ForMessage(114, global::OldProtos.Uint32Pair.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.Uint32Pair> gearLevelPairList_ = new pbc::RepeatedField<global::OldProtos.Uint32Pair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.Uint32Pair> GearLevelPairList {
      get { return gearLevelPairList_; }
    }

    /// <summary>Field number for the "open_sequence_id_list" field.</summary>
    public const int OpenSequenceIdListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_openSequenceIdList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> openSequenceIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OpenSequenceIdList {
      get { return openSequenceIdList_; }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 8;
    private uint coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "punish_over_time" field.</summary>
    public const int PunishOverTimeFieldNumber = 12;
    private uint punishOverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PunishOverTime {
      get { return punishOverTime_; }
      set {
        punishOverTime_ = value;
      }
    }

    /// <summary>Field number for the "mechanicus_id" field.</summary>
    public const int MechanicusIdFieldNumber = 10;
    private uint mechanicusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusId {
      get { return mechanicusId_; }
      set {
        mechanicusId_ = value;
      }
    }

    /// <summary>Field number for the "finish_difficult_level_list" field.</summary>
    public const int FinishDifficultLevelListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_finishDifficultLevelList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> finishDifficultLevelList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishDifficultLevelList {
      get { return finishDifficultLevelList_; }
    }

    /// <summary>Field number for the "is_finish_teach_dungeon" field.</summary>
    public const int IsFinishTeachDungeonFieldNumber = 4;
    private bool isFinishTeachDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishTeachDungeon {
      get { return isFinishTeachDungeon_; }
      set {
        isFinishTeachDungeon_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MechanicusInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MechanicusInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gearLevelPairList_.Equals(other.gearLevelPairList_)) return false;
      if(!openSequenceIdList_.Equals(other.openSequenceIdList_)) return false;
      if (Coin != other.Coin) return false;
      if (PunishOverTime != other.PunishOverTime) return false;
      if (MechanicusId != other.MechanicusId) return false;
      if(!finishDifficultLevelList_.Equals(other.finishDifficultLevelList_)) return false;
      if (IsFinishTeachDungeon != other.IsFinishTeachDungeon) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gearLevelPairList_.GetHashCode();
      hash ^= openSequenceIdList_.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
      if (PunishOverTime != 0) hash ^= PunishOverTime.GetHashCode();
      if (MechanicusId != 0) hash ^= MechanicusId.GetHashCode();
      hash ^= finishDifficultLevelList_.GetHashCode();
      if (IsFinishTeachDungeon != false) hash ^= IsFinishTeachDungeon.GetHashCode();
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
      if (IsFinishTeachDungeon != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsFinishTeachDungeon);
      }
      openSequenceIdList_.WriteTo(output, _repeated_openSequenceIdList_codec);
      if (Coin != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Coin);
      }
      if (MechanicusId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MechanicusId);
      }
      if (PunishOverTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PunishOverTime);
      }
      finishDifficultLevelList_.WriteTo(output, _repeated_finishDifficultLevelList_codec);
      gearLevelPairList_.WriteTo(output, _repeated_gearLevelPairList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsFinishTeachDungeon != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsFinishTeachDungeon);
      }
      openSequenceIdList_.WriteTo(ref output, _repeated_openSequenceIdList_codec);
      if (Coin != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Coin);
      }
      if (MechanicusId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MechanicusId);
      }
      if (PunishOverTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PunishOverTime);
      }
      finishDifficultLevelList_.WriteTo(ref output, _repeated_finishDifficultLevelList_codec);
      gearLevelPairList_.WriteTo(ref output, _repeated_gearLevelPairList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += gearLevelPairList_.CalculateSize(_repeated_gearLevelPairList_codec);
      size += openSequenceIdList_.CalculateSize(_repeated_openSequenceIdList_codec);
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
      }
      if (PunishOverTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PunishOverTime);
      }
      if (MechanicusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusId);
      }
      size += finishDifficultLevelList_.CalculateSize(_repeated_finishDifficultLevelList_codec);
      if (IsFinishTeachDungeon != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MechanicusInfo other) {
      if (other == null) {
        return;
      }
      gearLevelPairList_.Add(other.gearLevelPairList_);
      openSequenceIdList_.Add(other.openSequenceIdList_);
      if (other.Coin != 0) {
        Coin = other.Coin;
      }
      if (other.PunishOverTime != 0) {
        PunishOverTime = other.PunishOverTime;
      }
      if (other.MechanicusId != 0) {
        MechanicusId = other.MechanicusId;
      }
      finishDifficultLevelList_.Add(other.finishDifficultLevelList_);
      if (other.IsFinishTeachDungeon != false) {
        IsFinishTeachDungeon = other.IsFinishTeachDungeon;
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
            IsFinishTeachDungeon = input.ReadBool();
            break;
          }
          case 58:
          case 56: {
            openSequenceIdList_.AddEntriesFrom(input, _repeated_openSequenceIdList_codec);
            break;
          }
          case 64: {
            Coin = input.ReadUInt32();
            break;
          }
          case 80: {
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 96: {
            PunishOverTime = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            finishDifficultLevelList_.AddEntriesFrom(input, _repeated_finishDifficultLevelList_codec);
            break;
          }
          case 114: {
            gearLevelPairList_.AddEntriesFrom(input, _repeated_gearLevelPairList_codec);
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
            IsFinishTeachDungeon = input.ReadBool();
            break;
          }
          case 58:
          case 56: {
            openSequenceIdList_.AddEntriesFrom(ref input, _repeated_openSequenceIdList_codec);
            break;
          }
          case 64: {
            Coin = input.ReadUInt32();
            break;
          }
          case 80: {
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 96: {
            PunishOverTime = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            finishDifficultLevelList_.AddEntriesFrom(ref input, _repeated_finishDifficultLevelList_codec);
            break;
          }
          case 114: {
            gearLevelPairList_.AddEntriesFrom(ref input, _repeated_gearLevelPairList_codec);
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
