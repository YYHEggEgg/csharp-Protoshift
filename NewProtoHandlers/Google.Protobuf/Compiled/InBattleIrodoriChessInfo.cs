// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleIrodoriChessInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from InBattleIrodoriChessInfo.proto</summary>
  public static partial class InBattleIrodoriChessInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleIrodoriChessInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleIrodoriChessInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5JbkJhdHRsZUlyb2RvcmlDaGVzc0luZm8ucHJvdG8aHUlyb2RvcmlDaGVz",
            "c015c3RlcnlJbmZvLnByb3RvIq8BChhJbkJhdHRsZUlyb2RvcmlDaGVzc0lu",
            "Zm8SFAoMc2V0dGxlX3Njb3JlGAEgASgNEi4KDG15c3RlcnlfaW5mbxgCIAEo",
            "CzIYLklyb2RvcmlDaGVzc015c3RlcnlJbmZvEhUKDWxlZnRfbW9uc3RlcnMY",
            "DyABKA0SHQoVc2VsZWN0ZWRfY2FyZF9pZF9saXN0GAogAygNEhcKD2J1aWxk",
            "aW5nX3BvaW50cxgIIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.IrodoriChessMysteryInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.InBattleIrodoriChessInfo), global::NewProtos.InBattleIrodoriChessInfo.Parser, new[]{ "SettleScore", "MysteryInfo", "LeftMonsters", "SelectedCardIdList", "BuildingPoints" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InBattleIrodoriChessInfo : pb::IMessage<InBattleIrodoriChessInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleIrodoriChessInfo> _parser = new pb::MessageParser<InBattleIrodoriChessInfo>(() => new InBattleIrodoriChessInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleIrodoriChessInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.InBattleIrodoriChessInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleIrodoriChessInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleIrodoriChessInfo(InBattleIrodoriChessInfo other) : this() {
      settleScore_ = other.settleScore_;
      mysteryInfo_ = other.mysteryInfo_ != null ? other.mysteryInfo_.Clone() : null;
      leftMonsters_ = other.leftMonsters_;
      selectedCardIdList_ = other.selectedCardIdList_.Clone();
      buildingPoints_ = other.buildingPoints_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleIrodoriChessInfo Clone() {
      return new InBattleIrodoriChessInfo(this);
    }

    /// <summary>Field number for the "settle_score" field.</summary>
    public const int SettleScoreFieldNumber = 1;
    private uint settleScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SettleScore {
      get { return settleScore_; }
      set {
        settleScore_ = value;
      }
    }

    /// <summary>Field number for the "mystery_info" field.</summary>
    public const int MysteryInfoFieldNumber = 2;
    private global::NewProtos.IrodoriChessMysteryInfo mysteryInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.IrodoriChessMysteryInfo MysteryInfo {
      get { return mysteryInfo_; }
      set {
        mysteryInfo_ = value;
      }
    }

    /// <summary>Field number for the "left_monsters" field.</summary>
    public const int LeftMonstersFieldNumber = 15;
    private uint leftMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftMonsters {
      get { return leftMonsters_; }
      set {
        leftMonsters_ = value;
      }
    }

    /// <summary>Field number for the "selected_card_id_list" field.</summary>
    public const int SelectedCardIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_selectedCardIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> selectedCardIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectedCardIdList {
      get { return selectedCardIdList_; }
    }

    /// <summary>Field number for the "building_points" field.</summary>
    public const int BuildingPointsFieldNumber = 8;
    private uint buildingPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuildingPoints {
      get { return buildingPoints_; }
      set {
        buildingPoints_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InBattleIrodoriChessInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleIrodoriChessInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SettleScore != other.SettleScore) return false;
      if (!object.Equals(MysteryInfo, other.MysteryInfo)) return false;
      if (LeftMonsters != other.LeftMonsters) return false;
      if(!selectedCardIdList_.Equals(other.selectedCardIdList_)) return false;
      if (BuildingPoints != other.BuildingPoints) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SettleScore != 0) hash ^= SettleScore.GetHashCode();
      if (mysteryInfo_ != null) hash ^= MysteryInfo.GetHashCode();
      if (LeftMonsters != 0) hash ^= LeftMonsters.GetHashCode();
      hash ^= selectedCardIdList_.GetHashCode();
      if (BuildingPoints != 0) hash ^= BuildingPoints.GetHashCode();
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
      if (SettleScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SettleScore);
      }
      if (mysteryInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MysteryInfo);
      }
      if (BuildingPoints != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BuildingPoints);
      }
      selectedCardIdList_.WriteTo(output, _repeated_selectedCardIdList_codec);
      if (LeftMonsters != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LeftMonsters);
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
      if (SettleScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SettleScore);
      }
      if (mysteryInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MysteryInfo);
      }
      if (BuildingPoints != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BuildingPoints);
      }
      selectedCardIdList_.WriteTo(ref output, _repeated_selectedCardIdList_codec);
      if (LeftMonsters != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LeftMonsters);
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
      if (SettleScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SettleScore);
      }
      if (mysteryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MysteryInfo);
      }
      if (LeftMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftMonsters);
      }
      size += selectedCardIdList_.CalculateSize(_repeated_selectedCardIdList_codec);
      if (BuildingPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingPoints);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InBattleIrodoriChessInfo other) {
      if (other == null) {
        return;
      }
      if (other.SettleScore != 0) {
        SettleScore = other.SettleScore;
      }
      if (other.mysteryInfo_ != null) {
        if (mysteryInfo_ == null) {
          MysteryInfo = new global::NewProtos.IrodoriChessMysteryInfo();
        }
        MysteryInfo.MergeFrom(other.MysteryInfo);
      }
      if (other.LeftMonsters != 0) {
        LeftMonsters = other.LeftMonsters;
      }
      selectedCardIdList_.Add(other.selectedCardIdList_);
      if (other.BuildingPoints != 0) {
        BuildingPoints = other.BuildingPoints;
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
          case 8: {
            SettleScore = input.ReadUInt32();
            break;
          }
          case 18: {
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::NewProtos.IrodoriChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 64: {
            BuildingPoints = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            selectedCardIdList_.AddEntriesFrom(input, _repeated_selectedCardIdList_codec);
            break;
          }
          case 120: {
            LeftMonsters = input.ReadUInt32();
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
            SettleScore = input.ReadUInt32();
            break;
          }
          case 18: {
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::NewProtos.IrodoriChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 64: {
            BuildingPoints = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            selectedCardIdList_.AddEntriesFrom(ref input, _repeated_selectedCardIdList_codec);
            break;
          }
          case 120: {
            LeftMonsters = input.ReadUInt32();
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
