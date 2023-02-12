// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FallPlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from FallPlayerInfo.proto</summary>
  public static partial class FallPlayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FallPlayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FallPlayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGYWxsUGxheWVySW5mby5wcm90byLWAQoORmFsbFBsYXllckluZm8SEQoJ",
            "Y3VyX3Njb3JlGAMgASgNEhEKCWlzX2dyb3VuZBgLIAEoCBJEChRiYWxsX2Nh",
            "dGNoX2NvdW50X21hcBgBIAMoCzImLkZhbGxQbGF5ZXJJbmZvLkJhbGxDYXRj",
            "aENvdW50TWFwRW50cnkSCwoDdWlkGAUgASgNEhEKCXRpbWVfY29zdBgIIAEo",
            "DRo4ChZCYWxsQ2F0Y2hDb3VudE1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2",
            "YWx1ZRgCIAEoDToCOAFCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.FallPlayerInfo), global::NewProtos.FallPlayerInfo.Parser, new[]{ "CurScore", "IsGround", "BallCatchCountMap", "Uid", "TimeCost" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FallPlayerInfo : pb::IMessage<FallPlayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FallPlayerInfo> _parser = new pb::MessageParser<FallPlayerInfo>(() => new FallPlayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FallPlayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.FallPlayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallPlayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallPlayerInfo(FallPlayerInfo other) : this() {
      curScore_ = other.curScore_;
      isGround_ = other.isGround_;
      ballCatchCountMap_ = other.ballCatchCountMap_.Clone();
      uid_ = other.uid_;
      timeCost_ = other.timeCost_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallPlayerInfo Clone() {
      return new FallPlayerInfo(this);
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 3;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    /// <summary>Field number for the "is_ground" field.</summary>
    public const int IsGroundFieldNumber = 11;
    private bool isGround_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGround {
      get { return isGround_; }
      set {
        isGround_ = value;
      }
    }

    /// <summary>Field number for the "ball_catch_count_map" field.</summary>
    public const int BallCatchCountMapFieldNumber = 1;
    private static readonly pbc::MapField<uint, uint>.Codec _map_ballCatchCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 10);
    private readonly pbc::MapField<uint, uint> ballCatchCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> BallCatchCountMap {
      get { return ballCatchCountMap_; }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 5;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "time_cost" field.</summary>
    public const int TimeCostFieldNumber = 8;
    private uint timeCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeCost {
      get { return timeCost_; }
      set {
        timeCost_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FallPlayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FallPlayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurScore != other.CurScore) return false;
      if (IsGround != other.IsGround) return false;
      if (!BallCatchCountMap.Equals(other.BallCatchCountMap)) return false;
      if (Uid != other.Uid) return false;
      if (TimeCost != other.TimeCost) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
      if (IsGround != false) hash ^= IsGround.GetHashCode();
      hash ^= BallCatchCountMap.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (TimeCost != 0) hash ^= TimeCost.GetHashCode();
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
      ballCatchCountMap_.WriteTo(output, _map_ballCatchCountMap_codec);
      if (CurScore != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurScore);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (TimeCost != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TimeCost);
      }
      if (IsGround != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsGround);
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
      ballCatchCountMap_.WriteTo(ref output, _map_ballCatchCountMap_codec);
      if (CurScore != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurScore);
      }
      if (Uid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uid);
      }
      if (TimeCost != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TimeCost);
      }
      if (IsGround != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsGround);
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
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      if (IsGround != false) {
        size += 1 + 1;
      }
      size += ballCatchCountMap_.CalculateSize(_map_ballCatchCountMap_codec);
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (TimeCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeCost);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FallPlayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
      }
      if (other.IsGround != false) {
        IsGround = other.IsGround;
      }
      ballCatchCountMap_.Add(other.ballCatchCountMap_);
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.TimeCost != 0) {
        TimeCost = other.TimeCost;
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
          case 10: {
            ballCatchCountMap_.AddEntriesFrom(input, _map_ballCatchCountMap_codec);
            break;
          }
          case 24: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 64: {
            TimeCost = input.ReadUInt32();
            break;
          }
          case 88: {
            IsGround = input.ReadBool();
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
          case 10: {
            ballCatchCountMap_.AddEntriesFrom(ref input, _map_ballCatchCountMap_codec);
            break;
          }
          case 24: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 40: {
            Uid = input.ReadUInt32();
            break;
          }
          case 64: {
            TimeCost = input.ReadUInt32();
            break;
          }
          case 88: {
            IsGround = input.ReadBool();
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