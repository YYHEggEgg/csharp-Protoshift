// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WinterCampActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from WinterCampActivityDetailInfo.proto</summary>
  public static partial class WinterCampActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WinterCampActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WinterCampActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJXaW50ZXJDYW1wQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGg9JdGVtUGFy",
            "YW0ucHJvdG8aHVdpbnRlckNhbXBSYWNlU3RhZ2VJbmZvLnByb3RvGhlXaW50",
            "ZXJDYW1wU3RhZ2VJbmZvLnByb3RvIr0CChxXaW50ZXJDYW1wQWN0aXZpdHlE",
            "ZXRhaWxJbmZvEioKDGV4cGxvcmVfaW5mbxgDIAEoCzIULldpbnRlckNhbXBT",
            "dGFnZUluZm8SGwoTVW5rMzMwMF9LQ0dLTkpGR0NGQxgEIAMoDRIZChFpc19j",
            "b250ZW50X2Nsb3NlZBgMIAEoCBIbChNVbmszMzAwX0NNTklCUE1PRUNPGAUg",
            "AygNEhsKE1VuazMzMDBfRkhOTkpKREdMT08YBiADKA0SIgoOdXNlZF9pdGVt",
            "X2xpc3QYDiADKAsyCi5JdGVtUGFyYW0SKQoLYmF0dGxlX2luZm8YCSABKAsy",
            "FC5XaW50ZXJDYW1wU3RhZ2VJbmZvEjAKDnJhY2VfaW5mb19saXN0GA0gAygL",
            "MhguV2ludGVyQ2FtcFJhY2VTdGFnZUluZm9CDKoCCU5ld1Byb3Rvc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ItemParamReflection.Descriptor, global::NewProtos.WinterCampRaceStageInfoReflection.Descriptor, global::NewProtos.WinterCampStageInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.WinterCampActivityDetailInfo), global::NewProtos.WinterCampActivityDetailInfo.Parser, new[]{ "ExploreInfo", "Unk3300KCGKNJFGCFC", "IsContentClosed", "Unk3300CMNIBPMOECO", "Unk3300FHNNJJDGLOO", "UsedItemList", "BattleInfo", "RaceInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WinterCampActivityDetailInfo : pb::IMessage<WinterCampActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WinterCampActivityDetailInfo> _parser = new pb::MessageParser<WinterCampActivityDetailInfo>(() => new WinterCampActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WinterCampActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.WinterCampActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampActivityDetailInfo(WinterCampActivityDetailInfo other) : this() {
      exploreInfo_ = other.exploreInfo_ != null ? other.exploreInfo_.Clone() : null;
      unk3300KCGKNJFGCFC_ = other.unk3300KCGKNJFGCFC_.Clone();
      isContentClosed_ = other.isContentClosed_;
      unk3300CMNIBPMOECO_ = other.unk3300CMNIBPMOECO_.Clone();
      unk3300FHNNJJDGLOO_ = other.unk3300FHNNJJDGLOO_.Clone();
      usedItemList_ = other.usedItemList_.Clone();
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      raceInfoList_ = other.raceInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampActivityDetailInfo Clone() {
      return new WinterCampActivityDetailInfo(this);
    }

    /// <summary>Field number for the "explore_info" field.</summary>
    public const int ExploreInfoFieldNumber = 3;
    private global::NewProtos.WinterCampStageInfo exploreInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.WinterCampStageInfo ExploreInfo {
      get { return exploreInfo_; }
      set {
        exploreInfo_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KCGKNJFGCFC" field.</summary>
    public const int Unk3300KCGKNJFGCFCFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300KCGKNJFGCFC_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> unk3300KCGKNJFGCFC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300KCGKNJFGCFC {
      get { return unk3300KCGKNJFGCFC_; }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 12;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_CMNIBPMOECO" field.</summary>
    public const int Unk3300CMNIBPMOECOFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300CMNIBPMOECO_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> unk3300CMNIBPMOECO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300CMNIBPMOECO {
      get { return unk3300CMNIBPMOECO_; }
    }

    /// <summary>Field number for the "Unk3300_FHNNJJDGLOO" field.</summary>
    public const int Unk3300FHNNJJDGLOOFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300FHNNJJDGLOO_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> unk3300FHNNJJDGLOO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300FHNNJJDGLOO {
      get { return unk3300FHNNJJDGLOO_; }
    }

    /// <summary>Field number for the "used_item_list" field.</summary>
    public const int UsedItemListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_usedItemList_codec
        = pb::FieldCodec.ForMessage(114, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> usedItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> UsedItemList {
      get { return usedItemList_; }
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 9;
    private global::NewProtos.WinterCampStageInfo battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.WinterCampStageInfo BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    /// <summary>Field number for the "race_info_list" field.</summary>
    public const int RaceInfoListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::NewProtos.WinterCampRaceStageInfo> _repeated_raceInfoList_codec
        = pb::FieldCodec.ForMessage(106, global::NewProtos.WinterCampRaceStageInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.WinterCampRaceStageInfo> raceInfoList_ = new pbc::RepeatedField<global::NewProtos.WinterCampRaceStageInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.WinterCampRaceStageInfo> RaceInfoList {
      get { return raceInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WinterCampActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WinterCampActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ExploreInfo, other.ExploreInfo)) return false;
      if(!unk3300KCGKNJFGCFC_.Equals(other.unk3300KCGKNJFGCFC_)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if(!unk3300CMNIBPMOECO_.Equals(other.unk3300CMNIBPMOECO_)) return false;
      if(!unk3300FHNNJJDGLOO_.Equals(other.unk3300FHNNJJDGLOO_)) return false;
      if(!usedItemList_.Equals(other.usedItemList_)) return false;
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      if(!raceInfoList_.Equals(other.raceInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (exploreInfo_ != null) hash ^= ExploreInfo.GetHashCode();
      hash ^= unk3300KCGKNJFGCFC_.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      hash ^= unk3300CMNIBPMOECO_.GetHashCode();
      hash ^= unk3300FHNNJJDGLOO_.GetHashCode();
      hash ^= usedItemList_.GetHashCode();
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
      hash ^= raceInfoList_.GetHashCode();
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
      if (exploreInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ExploreInfo);
      }
      unk3300KCGKNJFGCFC_.WriteTo(output, _repeated_unk3300KCGKNJFGCFC_codec);
      unk3300CMNIBPMOECO_.WriteTo(output, _repeated_unk3300CMNIBPMOECO_codec);
      unk3300FHNNJJDGLOO_.WriteTo(output, _repeated_unk3300FHNNJJDGLOO_codec);
      if (battleInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BattleInfo);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
      }
      raceInfoList_.WriteTo(output, _repeated_raceInfoList_codec);
      usedItemList_.WriteTo(output, _repeated_usedItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (exploreInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ExploreInfo);
      }
      unk3300KCGKNJFGCFC_.WriteTo(ref output, _repeated_unk3300KCGKNJFGCFC_codec);
      unk3300CMNIBPMOECO_.WriteTo(ref output, _repeated_unk3300CMNIBPMOECO_codec);
      unk3300FHNNJJDGLOO_.WriteTo(ref output, _repeated_unk3300FHNNJJDGLOO_codec);
      if (battleInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BattleInfo);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
      }
      raceInfoList_.WriteTo(ref output, _repeated_raceInfoList_codec);
      usedItemList_.WriteTo(ref output, _repeated_usedItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (exploreInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExploreInfo);
      }
      size += unk3300KCGKNJFGCFC_.CalculateSize(_repeated_unk3300KCGKNJFGCFC_codec);
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      size += unk3300CMNIBPMOECO_.CalculateSize(_repeated_unk3300CMNIBPMOECO_codec);
      size += unk3300FHNNJJDGLOO_.CalculateSize(_repeated_unk3300FHNNJJDGLOO_codec);
      size += usedItemList_.CalculateSize(_repeated_usedItemList_codec);
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      size += raceInfoList_.CalculateSize(_repeated_raceInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WinterCampActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.exploreInfo_ != null) {
        if (exploreInfo_ == null) {
          ExploreInfo = new global::NewProtos.WinterCampStageInfo();
        }
        ExploreInfo.MergeFrom(other.ExploreInfo);
      }
      unk3300KCGKNJFGCFC_.Add(other.unk3300KCGKNJFGCFC_);
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      unk3300CMNIBPMOECO_.Add(other.unk3300CMNIBPMOECO_);
      unk3300FHNNJJDGLOO_.Add(other.unk3300FHNNJJDGLOO_);
      usedItemList_.Add(other.usedItemList_);
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::NewProtos.WinterCampStageInfo();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
      }
      raceInfoList_.Add(other.raceInfoList_);
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
          case 26: {
            if (exploreInfo_ == null) {
              ExploreInfo = new global::NewProtos.WinterCampStageInfo();
            }
            input.ReadMessage(ExploreInfo);
            break;
          }
          case 34:
          case 32: {
            unk3300KCGKNJFGCFC_.AddEntriesFrom(input, _repeated_unk3300KCGKNJFGCFC_codec);
            break;
          }
          case 42:
          case 40: {
            unk3300CMNIBPMOECO_.AddEntriesFrom(input, _repeated_unk3300CMNIBPMOECO_codec);
            break;
          }
          case 50:
          case 48: {
            unk3300FHNNJJDGLOO_.AddEntriesFrom(input, _repeated_unk3300FHNNJJDGLOO_codec);
            break;
          }
          case 74: {
            if (battleInfo_ == null) {
              BattleInfo = new global::NewProtos.WinterCampStageInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 106: {
            raceInfoList_.AddEntriesFrom(input, _repeated_raceInfoList_codec);
            break;
          }
          case 114: {
            usedItemList_.AddEntriesFrom(input, _repeated_usedItemList_codec);
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
          case 26: {
            if (exploreInfo_ == null) {
              ExploreInfo = new global::NewProtos.WinterCampStageInfo();
            }
            input.ReadMessage(ExploreInfo);
            break;
          }
          case 34:
          case 32: {
            unk3300KCGKNJFGCFC_.AddEntriesFrom(ref input, _repeated_unk3300KCGKNJFGCFC_codec);
            break;
          }
          case 42:
          case 40: {
            unk3300CMNIBPMOECO_.AddEntriesFrom(ref input, _repeated_unk3300CMNIBPMOECO_codec);
            break;
          }
          case 50:
          case 48: {
            unk3300FHNNJJDGLOO_.AddEntriesFrom(ref input, _repeated_unk3300FHNNJJDGLOO_codec);
            break;
          }
          case 74: {
            if (battleInfo_ == null) {
              BattleInfo = new global::NewProtos.WinterCampStageInfo();
            }
            input.ReadMessage(BattleInfo);
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 106: {
            raceInfoList_.AddEntriesFrom(ref input, _repeated_raceInfoList_codec);
            break;
          }
          case 114: {
            usedItemList_.AddEntriesFrom(ref input, _repeated_usedItemList_codec);
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