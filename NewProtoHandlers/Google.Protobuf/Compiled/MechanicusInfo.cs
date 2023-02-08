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
namespace NewProtos {

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
            "ChRNZWNoYW5pY3VzSW5mby5wcm90bxoQVWludDMyUGFpci5wcm90byLVAQoO",
            "TWVjaGFuaWN1c0luZm8SFQoNbWVjaGFuaWN1c19pZBgBIAEoDRIYChBwdW5p",
            "c2hfb3Zlcl90aW1lGAsgASgNEh8KF2lzX2ZpbmlzaF90ZWFjaF9kdW5nZW9u",
            "GAcgASgIEhsKE1VuazMzMDBfS0pMR0ZFUElFTkcYBiADKA0SGwoTVW5rMzMw",
            "MF9FRUJFT0NNQUlLThgJIAMoDRIMCgRjb2luGAogASgNEikKFGdlYXJfbGV2",
            "ZWxfcGFpcl9saXN0GA0gAygLMgsuVWludDMyUGFpckIMqgIJTmV3UHJvdG9z",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.Uint32PairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.MechanicusInfo), global::NewProtos.MechanicusInfo.Parser, new[]{ "MechanicusId", "PunishOverTime", "IsFinishTeachDungeon", "Unk3300KJLGFEPIENG", "Unk3300EEBEOCMAIKN", "Coin", "GearLevelPairList" }, null, null, null, null)
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
      get { return global::NewProtos.MechanicusInfoReflection.Descriptor.MessageTypes[0]; }
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
      mechanicusId_ = other.mechanicusId_;
      punishOverTime_ = other.punishOverTime_;
      isFinishTeachDungeon_ = other.isFinishTeachDungeon_;
      unk3300KJLGFEPIENG_ = other.unk3300KJLGFEPIENG_.Clone();
      unk3300EEBEOCMAIKN_ = other.unk3300EEBEOCMAIKN_.Clone();
      coin_ = other.coin_;
      gearLevelPairList_ = other.gearLevelPairList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusInfo Clone() {
      return new MechanicusInfo(this);
    }

    /// <summary>Field number for the "mechanicus_id" field.</summary>
    public const int MechanicusIdFieldNumber = 1;
    private uint mechanicusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusId {
      get { return mechanicusId_; }
      set {
        mechanicusId_ = value;
      }
    }

    /// <summary>Field number for the "punish_over_time" field.</summary>
    public const int PunishOverTimeFieldNumber = 11;
    private uint punishOverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PunishOverTime {
      get { return punishOverTime_; }
      set {
        punishOverTime_ = value;
      }
    }

    /// <summary>Field number for the "is_finish_teach_dungeon" field.</summary>
    public const int IsFinishTeachDungeonFieldNumber = 7;
    private bool isFinishTeachDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishTeachDungeon {
      get { return isFinishTeachDungeon_; }
      set {
        isFinishTeachDungeon_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KJLGFEPIENG" field.</summary>
    public const int Unk3300KJLGFEPIENGFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300KJLGFEPIENG_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> unk3300KJLGFEPIENG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300KJLGFEPIENG {
      get { return unk3300KJLGFEPIENG_; }
    }

    /// <summary>Field number for the "Unk3300_EEBEOCMAIKN" field.</summary>
    public const int Unk3300EEBEOCMAIKNFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300EEBEOCMAIKN_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> unk3300EEBEOCMAIKN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300EEBEOCMAIKN {
      get { return unk3300EEBEOCMAIKN_; }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 10;
    private uint coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "gear_level_pair_list" field.</summary>
    public const int GearLevelPairListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::NewProtos.Uint32Pair> _repeated_gearLevelPairList_codec
        = pb::FieldCodec.ForMessage(106, global::NewProtos.Uint32Pair.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.Uint32Pair> gearLevelPairList_ = new pbc::RepeatedField<global::NewProtos.Uint32Pair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.Uint32Pair> GearLevelPairList {
      get { return gearLevelPairList_; }
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
      if (MechanicusId != other.MechanicusId) return false;
      if (PunishOverTime != other.PunishOverTime) return false;
      if (IsFinishTeachDungeon != other.IsFinishTeachDungeon) return false;
      if(!unk3300KJLGFEPIENG_.Equals(other.unk3300KJLGFEPIENG_)) return false;
      if(!unk3300EEBEOCMAIKN_.Equals(other.unk3300EEBEOCMAIKN_)) return false;
      if (Coin != other.Coin) return false;
      if(!gearLevelPairList_.Equals(other.gearLevelPairList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MechanicusId != 0) hash ^= MechanicusId.GetHashCode();
      if (PunishOverTime != 0) hash ^= PunishOverTime.GetHashCode();
      if (IsFinishTeachDungeon != false) hash ^= IsFinishTeachDungeon.GetHashCode();
      hash ^= unk3300KJLGFEPIENG_.GetHashCode();
      hash ^= unk3300EEBEOCMAIKN_.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
      hash ^= gearLevelPairList_.GetHashCode();
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
      if (MechanicusId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MechanicusId);
      }
      unk3300KJLGFEPIENG_.WriteTo(output, _repeated_unk3300KJLGFEPIENG_codec);
      if (IsFinishTeachDungeon != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinishTeachDungeon);
      }
      unk3300EEBEOCMAIKN_.WriteTo(output, _repeated_unk3300EEBEOCMAIKN_codec);
      if (Coin != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Coin);
      }
      if (PunishOverTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PunishOverTime);
      }
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
      if (MechanicusId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MechanicusId);
      }
      unk3300KJLGFEPIENG_.WriteTo(ref output, _repeated_unk3300KJLGFEPIENG_codec);
      if (IsFinishTeachDungeon != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinishTeachDungeon);
      }
      unk3300EEBEOCMAIKN_.WriteTo(ref output, _repeated_unk3300EEBEOCMAIKN_codec);
      if (Coin != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Coin);
      }
      if (PunishOverTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PunishOverTime);
      }
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
      if (MechanicusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusId);
      }
      if (PunishOverTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PunishOverTime);
      }
      if (IsFinishTeachDungeon != false) {
        size += 1 + 1;
      }
      size += unk3300KJLGFEPIENG_.CalculateSize(_repeated_unk3300KJLGFEPIENG_codec);
      size += unk3300EEBEOCMAIKN_.CalculateSize(_repeated_unk3300EEBEOCMAIKN_codec);
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
      }
      size += gearLevelPairList_.CalculateSize(_repeated_gearLevelPairList_codec);
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
      if (other.MechanicusId != 0) {
        MechanicusId = other.MechanicusId;
      }
      if (other.PunishOverTime != 0) {
        PunishOverTime = other.PunishOverTime;
      }
      if (other.IsFinishTeachDungeon != false) {
        IsFinishTeachDungeon = other.IsFinishTeachDungeon;
      }
      unk3300KJLGFEPIENG_.Add(other.unk3300KJLGFEPIENG_);
      unk3300EEBEOCMAIKN_.Add(other.unk3300EEBEOCMAIKN_);
      if (other.Coin != 0) {
        Coin = other.Coin;
      }
      gearLevelPairList_.Add(other.gearLevelPairList_);
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
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            unk3300KJLGFEPIENG_.AddEntriesFrom(input, _repeated_unk3300KJLGFEPIENG_codec);
            break;
          }
          case 56: {
            IsFinishTeachDungeon = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            unk3300EEBEOCMAIKN_.AddEntriesFrom(input, _repeated_unk3300EEBEOCMAIKN_codec);
            break;
          }
          case 80: {
            Coin = input.ReadUInt32();
            break;
          }
          case 88: {
            PunishOverTime = input.ReadUInt32();
            break;
          }
          case 106: {
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
          case 8: {
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            unk3300KJLGFEPIENG_.AddEntriesFrom(ref input, _repeated_unk3300KJLGFEPIENG_codec);
            break;
          }
          case 56: {
            IsFinishTeachDungeon = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            unk3300EEBEOCMAIKN_.AddEntriesFrom(ref input, _repeated_unk3300EEBEOCMAIKN_codec);
            break;
          }
          case 80: {
            Coin = input.ReadUInt32();
            break;
          }
          case 88: {
            PunishOverTime = input.ReadUInt32();
            break;
          }
          case 106: {
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
