// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerAcceptAllGiveFlowerRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PlantFlowerAcceptAllGiveFlowerRsp.proto</summary>
  public static partial class PlantFlowerAcceptAllGiveFlowerRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlantFlowerAcceptAllGiveFlowerRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlantFlowerAcceptAllGiveFlowerRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQbGFudEZsb3dlckFjY2VwdEFsbEdpdmVGbG93ZXJSc3AucHJvdG8aJ1Bs",
            "YW50Rmxvd2VyQWNjZXB0Rmxvd2VyUmVzdWx0SW5mby5wcm90byKVAQohUGxh",
            "bnRGbG93ZXJBY2NlcHRBbGxHaXZlRmxvd2VyUnNwEhMKC3NjaGVkdWxlX2lk",
            "GAwgASgNEg8KB3JldGNvZGUYBiABKAUSSgoeYWNjZXB0X2Zsb3dlcl9yZXN1",
            "bHRfaW5mb19saXN0GA0gAygLMiIuUGxhbnRGbG93ZXJBY2NlcHRGbG93ZXJS",
            "ZXN1bHRJbmZvQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.PlantFlowerAcceptFlowerResultInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PlantFlowerAcceptAllGiveFlowerRsp), global::NewProtos.PlantFlowerAcceptAllGiveFlowerRsp.Parser, new[]{ "ScheduleId", "Retcode", "AcceptFlowerResultInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8313;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlantFlowerAcceptAllGiveFlowerRsp : pb::IMessage<PlantFlowerAcceptAllGiveFlowerRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlantFlowerAcceptAllGiveFlowerRsp> _parser = new pb::MessageParser<PlantFlowerAcceptAllGiveFlowerRsp>(() => new PlantFlowerAcceptAllGiveFlowerRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlantFlowerAcceptAllGiveFlowerRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PlantFlowerAcceptAllGiveFlowerRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptAllGiveFlowerRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptAllGiveFlowerRsp(PlantFlowerAcceptAllGiveFlowerRsp other) : this() {
      scheduleId_ = other.scheduleId_;
      retcode_ = other.retcode_;
      acceptFlowerResultInfoList_ = other.acceptFlowerResultInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptAllGiveFlowerRsp Clone() {
      return new PlantFlowerAcceptAllGiveFlowerRsp(this);
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 12;
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
    public const int RetcodeFieldNumber = 6;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "accept_flower_result_info_list" field.</summary>
    public const int AcceptFlowerResultInfoListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::NewProtos.PlantFlowerAcceptFlowerResultInfo> _repeated_acceptFlowerResultInfoList_codec
        = pb::FieldCodec.ForMessage(106, global::NewProtos.PlantFlowerAcceptFlowerResultInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.PlantFlowerAcceptFlowerResultInfo> acceptFlowerResultInfoList_ = new pbc::RepeatedField<global::NewProtos.PlantFlowerAcceptFlowerResultInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.PlantFlowerAcceptFlowerResultInfo> AcceptFlowerResultInfoList {
      get { return acceptFlowerResultInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlantFlowerAcceptAllGiveFlowerRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlantFlowerAcceptAllGiveFlowerRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScheduleId != other.ScheduleId) return false;
      if (Retcode != other.Retcode) return false;
      if(!acceptFlowerResultInfoList_.Equals(other.acceptFlowerResultInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= acceptFlowerResultInfoList_.GetHashCode();
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
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScheduleId);
      }
      acceptFlowerResultInfoList_.WriteTo(output, _repeated_acceptFlowerResultInfoList_codec);
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
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScheduleId);
      }
      acceptFlowerResultInfoList_.WriteTo(ref output, _repeated_acceptFlowerResultInfoList_codec);
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
      size += acceptFlowerResultInfoList_.CalculateSize(_repeated_acceptFlowerResultInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlantFlowerAcceptAllGiveFlowerRsp other) {
      if (other == null) {
        return;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      acceptFlowerResultInfoList_.Add(other.acceptFlowerResultInfoList_);
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
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 106: {
            acceptFlowerResultInfoList_.AddEntriesFrom(input, _repeated_acceptFlowerResultInfoList_codec);
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
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 106: {
            acceptFlowerResultInfoList_.AddEntriesFrom(ref input, _repeated_acceptFlowerResultInfoList_codec);
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