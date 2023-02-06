// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityGetCanGiveFriendGiftRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ActivityGetCanGiveFriendGiftRsp.proto</summary>
public static partial class ActivityGetCanGiveFriendGiftRspReflection {

  #region Descriptor
  /// <summary>File descriptor for ActivityGetCanGiveFriendGiftRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ActivityGetCanGiveFriendGiftRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVBY3Rpdml0eUdldENhbkdpdmVGcmllbmRHaWZ0UnNwLnByb3RvIsIBCh9B",
          "Y3Rpdml0eUdldENhbkdpdmVGcmllbmRHaWZ0UnNwEhMKC3NjaGVkdWxlX2lk",
          "GAcgASgNEg8KB3JldGNvZGUYAyABKAUSRgoMZ2lmdF9udW1fbWFwGA4gAygL",
          "MjAuQWN0aXZpdHlHZXRDYW5HaXZlRnJpZW5kR2lmdFJzcC5HaWZ0TnVtTWFw",
          "RW50cnkaMQoPR2lmdE51bU1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1",
          "ZRgCIAEoDToCOAFCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ActivityGetCanGiveFriendGiftRsp), global::ActivityGetCanGiveFriendGiftRsp.Parser, new[]{ "ScheduleId", "Retcode", "GiftNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8848
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ActivityGetCanGiveFriendGiftRsp : pb::IMessage<ActivityGetCanGiveFriendGiftRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ActivityGetCanGiveFriendGiftRsp> _parser = new pb::MessageParser<ActivityGetCanGiveFriendGiftRsp>(() => new ActivityGetCanGiveFriendGiftRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ActivityGetCanGiveFriendGiftRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ActivityGetCanGiveFriendGiftRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityGetCanGiveFriendGiftRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityGetCanGiveFriendGiftRsp(ActivityGetCanGiveFriendGiftRsp other) : this() {
    scheduleId_ = other.scheduleId_;
    retcode_ = other.retcode_;
    giftNumMap_ = other.giftNumMap_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityGetCanGiveFriendGiftRsp Clone() {
    return new ActivityGetCanGiveFriendGiftRsp(this);
  }

  /// <summary>Field number for the "schedule_id" field.</summary>
  public const int ScheduleIdFieldNumber = 7;
  private uint scheduleId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ScheduleId {
    get { return scheduleId_; }
    set {
      scheduleId_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 3;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "gift_num_map" field.</summary>
  public const int GiftNumMapFieldNumber = 14;
  private static readonly pbc::MapField<uint, uint>.Codec _map_giftNumMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 114);
  private readonly pbc::MapField<uint, uint> giftNumMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> GiftNumMap {
    get { return giftNumMap_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ActivityGetCanGiveFriendGiftRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ActivityGetCanGiveFriendGiftRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ScheduleId != other.ScheduleId) return false;
    if (Retcode != other.Retcode) return false;
    if (!GiftNumMap.Equals(other.GiftNumMap)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    hash ^= GiftNumMap.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (ScheduleId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ScheduleId);
    }
    giftNumMap_.WriteTo(output, _map_giftNumMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Retcode != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Retcode);
    }
    if (ScheduleId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ScheduleId);
    }
    giftNumMap_.WriteTo(ref output, _map_giftNumMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (ScheduleId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    size += giftNumMap_.CalculateSize(_map_giftNumMap_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ActivityGetCanGiveFriendGiftRsp other) {
    if (other == null) {
      return;
    }
    if (other.ScheduleId != 0) {
      ScheduleId = other.ScheduleId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    giftNumMap_.Add(other.giftNumMap_);
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
          Retcode = input.ReadInt32();
          break;
        }
        case 56: {
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 114: {
          giftNumMap_.AddEntriesFrom(input, _map_giftNumMap_codec);
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
          Retcode = input.ReadInt32();
          break;
        }
        case 56: {
          ScheduleId = input.ReadUInt32();
          break;
        }
        case 114: {
          giftNumMap_.AddEntriesFrom(ref input, _map_giftNumMap_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
