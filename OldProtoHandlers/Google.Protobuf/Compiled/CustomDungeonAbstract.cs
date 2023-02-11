// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonAbstract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from CustomDungeonAbstract.proto</summary>
  public static partial class CustomDungeonAbstractReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonAbstract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonAbstractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDdXN0b21EdW5nZW9uQWJzdHJhY3QucHJvdG8ihwIKFUN1c3RvbUR1bmdl",
            "b25BYnN0cmFjdBJMChRicmlja19zdGF0aXN0aWNzX21hcBgMIAMoCzIuLkN1",
            "c3RvbUR1bmdlb25BYnN0cmFjdC5Ccmlja1N0YXRpc3RpY3NNYXBFbnRyeRIa",
            "ChJmaXJzdF9wdWJsaXNoX3RpbWUYAyABKA0SFgoOdG90YWxfY29pbl9udW0Y",
            "DyABKA0SGQoRbGFzdF9wdWJsaXNoX3RpbWUYBiABKA0SFgoOZmluaXNoX3Jv",
            "b21faWQYByABKA0aOQoXQnJpY2tTdGF0aXN0aWNzTWFwRW50cnkSCwoDa2V5",
            "GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIMqgIJT2xkUHJvdG9zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.CustomDungeonAbstract), global::OldProtos.CustomDungeonAbstract.Parser, new[]{ "BrickStatisticsMap", "FirstPublishTime", "TotalCoinNum", "LastPublishTime", "FinishRoomId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonAbstract : pb::IMessage<CustomDungeonAbstract>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonAbstract> _parser = new pb::MessageParser<CustomDungeonAbstract>(() => new CustomDungeonAbstract());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonAbstract> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.CustomDungeonAbstractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonAbstract() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonAbstract(CustomDungeonAbstract other) : this() {
      brickStatisticsMap_ = other.brickStatisticsMap_.Clone();
      firstPublishTime_ = other.firstPublishTime_;
      totalCoinNum_ = other.totalCoinNum_;
      lastPublishTime_ = other.lastPublishTime_;
      finishRoomId_ = other.finishRoomId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonAbstract Clone() {
      return new CustomDungeonAbstract(this);
    }

    /// <summary>Field number for the "brick_statistics_map" field.</summary>
    public const int BrickStatisticsMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_brickStatisticsMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> brickStatisticsMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> BrickStatisticsMap {
      get { return brickStatisticsMap_; }
    }

    /// <summary>Field number for the "first_publish_time" field.</summary>
    public const int FirstPublishTimeFieldNumber = 3;
    private uint firstPublishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FirstPublishTime {
      get { return firstPublishTime_; }
      set {
        firstPublishTime_ = value;
      }
    }

    /// <summary>Field number for the "total_coin_num" field.</summary>
    public const int TotalCoinNumFieldNumber = 15;
    private uint totalCoinNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalCoinNum {
      get { return totalCoinNum_; }
      set {
        totalCoinNum_ = value;
      }
    }

    /// <summary>Field number for the "last_publish_time" field.</summary>
    public const int LastPublishTimeFieldNumber = 6;
    private uint lastPublishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastPublishTime {
      get { return lastPublishTime_; }
      set {
        lastPublishTime_ = value;
      }
    }

    /// <summary>Field number for the "finish_room_id" field.</summary>
    public const int FinishRoomIdFieldNumber = 7;
    private uint finishRoomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishRoomId {
      get { return finishRoomId_; }
      set {
        finishRoomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonAbstract);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonAbstract other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!BrickStatisticsMap.Equals(other.BrickStatisticsMap)) return false;
      if (FirstPublishTime != other.FirstPublishTime) return false;
      if (TotalCoinNum != other.TotalCoinNum) return false;
      if (LastPublishTime != other.LastPublishTime) return false;
      if (FinishRoomId != other.FinishRoomId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= BrickStatisticsMap.GetHashCode();
      if (FirstPublishTime != 0) hash ^= FirstPublishTime.GetHashCode();
      if (TotalCoinNum != 0) hash ^= TotalCoinNum.GetHashCode();
      if (LastPublishTime != 0) hash ^= LastPublishTime.GetHashCode();
      if (FinishRoomId != 0) hash ^= FinishRoomId.GetHashCode();
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
      if (FirstPublishTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FirstPublishTime);
      }
      if (LastPublishTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LastPublishTime);
      }
      if (FinishRoomId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FinishRoomId);
      }
      brickStatisticsMap_.WriteTo(output, _map_brickStatisticsMap_codec);
      if (TotalCoinNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TotalCoinNum);
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
      if (FirstPublishTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FirstPublishTime);
      }
      if (LastPublishTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LastPublishTime);
      }
      if (FinishRoomId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(FinishRoomId);
      }
      brickStatisticsMap_.WriteTo(ref output, _map_brickStatisticsMap_codec);
      if (TotalCoinNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TotalCoinNum);
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
      size += brickStatisticsMap_.CalculateSize(_map_brickStatisticsMap_codec);
      if (FirstPublishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FirstPublishTime);
      }
      if (TotalCoinNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalCoinNum);
      }
      if (LastPublishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastPublishTime);
      }
      if (FinishRoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishRoomId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonAbstract other) {
      if (other == null) {
        return;
      }
      brickStatisticsMap_.Add(other.brickStatisticsMap_);
      if (other.FirstPublishTime != 0) {
        FirstPublishTime = other.FirstPublishTime;
      }
      if (other.TotalCoinNum != 0) {
        TotalCoinNum = other.TotalCoinNum;
      }
      if (other.LastPublishTime != 0) {
        LastPublishTime = other.LastPublishTime;
      }
      if (other.FinishRoomId != 0) {
        FinishRoomId = other.FinishRoomId;
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
            FirstPublishTime = input.ReadUInt32();
            break;
          }
          case 48: {
            LastPublishTime = input.ReadUInt32();
            break;
          }
          case 56: {
            FinishRoomId = input.ReadUInt32();
            break;
          }
          case 98: {
            brickStatisticsMap_.AddEntriesFrom(input, _map_brickStatisticsMap_codec);
            break;
          }
          case 120: {
            TotalCoinNum = input.ReadUInt32();
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
            FirstPublishTime = input.ReadUInt32();
            break;
          }
          case 48: {
            LastPublishTime = input.ReadUInt32();
            break;
          }
          case 56: {
            FinishRoomId = input.ReadUInt32();
            break;
          }
          case 98: {
            brickStatisticsMap_.AddEntriesFrom(ref input, _map_brickStatisticsMap_codec);
            break;
          }
          case 120: {
            TotalCoinNum = input.ReadUInt32();
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