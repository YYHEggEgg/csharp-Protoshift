// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FallSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from FallSettleInfo.proto</summary>
  public static partial class FallSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FallSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FallSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGYWxsU2V0dGxlSW5mby5wcm90bxoWT25saW5lUGxheWVySW5mby5wcm90",
            "byKXAgoORmFsbFNldHRsZUluZm8SEwoLY2F0Y2hfY291bnQYDyABKA0SJgoL",
            "cGxheWVyX2luZm8YDSABKAsyES5PbmxpbmVQbGF5ZXJJbmZvEgsKA3VpZBgO",
            "IAEoDRJRChtmbG93ZXJfcmluZ19jYXRjaF9jb3VudF9tYXAYAyADKAsyLC5G",
            "YWxsU2V0dGxlSW5mby5GbG93ZXJSaW5nQ2F0Y2hDb3VudE1hcEVudHJ5EhMK",
            "C3JlbWFpbl90aW1lGAogASgNEhMKC2ZpbmFsX3Njb3JlGAEgASgNGj4KHEZs",
            "b3dlclJpbmdDYXRjaENvdW50TWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZh",
            "bHVlGAIgASgNOgI4AUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.FallSettleInfo), global::OldProtos.FallSettleInfo.Parser, new[]{ "CatchCount", "PlayerInfo", "Uid", "FlowerRingCatchCountMap", "RemainTime", "FinalScore" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FallSettleInfo : pb::IMessage<FallSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FallSettleInfo> _parser = new pb::MessageParser<FallSettleInfo>(() => new FallSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FallSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.FallSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo(FallSettleInfo other) : this() {
      catchCount_ = other.catchCount_;
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      uid_ = other.uid_;
      flowerRingCatchCountMap_ = other.flowerRingCatchCountMap_.Clone();
      remainTime_ = other.remainTime_;
      finalScore_ = other.finalScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo Clone() {
      return new FallSettleInfo(this);
    }

    /// <summary>Field number for the "catch_count" field.</summary>
    public const int CatchCountFieldNumber = 15;
    private uint catchCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CatchCount {
      get { return catchCount_; }
      set {
        catchCount_ = value;
      }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 13;
    private global::OldProtos.OnlinePlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.OnlinePlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 14;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "flower_ring_catch_count_map" field.</summary>
    public const int FlowerRingCatchCountMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_flowerRingCatchCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> flowerRingCatchCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FlowerRingCatchCountMap {
      get { return flowerRingCatchCountMap_; }
    }

    /// <summary>Field number for the "remain_time" field.</summary>
    public const int RemainTimeFieldNumber = 10;
    private uint remainTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainTime {
      get { return remainTime_; }
      set {
        remainTime_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 1;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FallSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FallSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CatchCount != other.CatchCount) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (Uid != other.Uid) return false;
      if (!FlowerRingCatchCountMap.Equals(other.FlowerRingCatchCountMap)) return false;
      if (RemainTime != other.RemainTime) return false;
      if (FinalScore != other.FinalScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CatchCount != 0) hash ^= CatchCount.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= FlowerRingCatchCountMap.GetHashCode();
      if (RemainTime != 0) hash ^= RemainTime.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
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
      if (FinalScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FinalScore);
      }
      flowerRingCatchCountMap_.WriteTo(output, _map_flowerRingCatchCountMap_codec);
      if (RemainTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RemainTime);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PlayerInfo);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
      }
      if (CatchCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CatchCount);
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
      if (FinalScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FinalScore);
      }
      flowerRingCatchCountMap_.WriteTo(ref output, _map_flowerRingCatchCountMap_codec);
      if (RemainTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RemainTime);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PlayerInfo);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
      }
      if (CatchCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CatchCount);
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
      if (CatchCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CatchCount);
      }
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += flowerRingCatchCountMap_.CalculateSize(_map_flowerRingCatchCountMap_codec);
      if (RemainTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainTime);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FallSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.CatchCount != 0) {
        CatchCount = other.CatchCount;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::OldProtos.OnlinePlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      flowerRingCatchCountMap_.Add(other.flowerRingCatchCountMap_);
      if (other.RemainTime != 0) {
        RemainTime = other.RemainTime;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
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
            FinalScore = input.ReadUInt32();
            break;
          }
          case 26: {
            flowerRingCatchCountMap_.AddEntriesFrom(input, _map_flowerRingCatchCountMap_codec);
            break;
          }
          case 80: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 106: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::OldProtos.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            CatchCount = input.ReadUInt32();
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
            FinalScore = input.ReadUInt32();
            break;
          }
          case 26: {
            flowerRingCatchCountMap_.AddEntriesFrom(ref input, _map_flowerRingCatchCountMap_codec);
            break;
          }
          case 80: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 106: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::OldProtos.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            CatchCount = input.ReadUInt32();
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