// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerAcceptGiveFlowerRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from PlantFlowerAcceptGiveFlowerRsp.proto</summary>
  public static partial class PlantFlowerAcceptGiveFlowerRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlantFlowerAcceptGiveFlowerRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlantFlowerAcceptGiveFlowerRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQbGFudEZsb3dlckFjY2VwdEdpdmVGbG93ZXJSc3AucHJvdG8aJ1BsYW50",
            "Rmxvd2VyQWNjZXB0Rmxvd2VyUmVzdWx0SW5mby5wcm90byKNAQoeUGxhbnRG",
            "bG93ZXJBY2NlcHRHaXZlRmxvd2VyUnNwEhMKC3NjaGVkdWxlX2lkGAEgASgN",
            "EkUKGWFjY2VwdF9mbG93ZXJfcmVzdWx0X2luZm8YDyABKAsyIi5QbGFudEZs",
            "b3dlckFjY2VwdEZsb3dlclJlc3VsdEluZm8SDwoHcmV0Y29kZRgMIAEoBUIM",
            "qgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.PlantFlowerAcceptFlowerResultInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.PlantFlowerAcceptGiveFlowerRsp), global::OldProtos.PlantFlowerAcceptGiveFlowerRsp.Parser, new[]{ "ScheduleId", "AcceptFlowerResultInfo", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8567
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlantFlowerAcceptGiveFlowerRsp : pb::IMessage<PlantFlowerAcceptGiveFlowerRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlantFlowerAcceptGiveFlowerRsp> _parser = new pb::MessageParser<PlantFlowerAcceptGiveFlowerRsp>(() => new PlantFlowerAcceptGiveFlowerRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlantFlowerAcceptGiveFlowerRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.PlantFlowerAcceptGiveFlowerRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptGiveFlowerRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptGiveFlowerRsp(PlantFlowerAcceptGiveFlowerRsp other) : this() {
      scheduleId_ = other.scheduleId_;
      acceptFlowerResultInfo_ = other.acceptFlowerResultInfo_ != null ? other.acceptFlowerResultInfo_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptGiveFlowerRsp Clone() {
      return new PlantFlowerAcceptGiveFlowerRsp(this);
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 1;
    private uint scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    /// <summary>Field number for the "accept_flower_result_info" field.</summary>
    public const int AcceptFlowerResultInfoFieldNumber = 15;
    private global::OldProtos.PlantFlowerAcceptFlowerResultInfo acceptFlowerResultInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.PlantFlowerAcceptFlowerResultInfo AcceptFlowerResultInfo {
      get { return acceptFlowerResultInfo_; }
      set {
        acceptFlowerResultInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlantFlowerAcceptGiveFlowerRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlantFlowerAcceptGiveFlowerRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScheduleId != other.ScheduleId) return false;
      if (!object.Equals(AcceptFlowerResultInfo, other.AcceptFlowerResultInfo)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      if (acceptFlowerResultInfo_ != null) hash ^= AcceptFlowerResultInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (ScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ScheduleId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (acceptFlowerResultInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(AcceptFlowerResultInfo);
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
      if (ScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ScheduleId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (acceptFlowerResultInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(AcceptFlowerResultInfo);
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
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
      }
      if (acceptFlowerResultInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AcceptFlowerResultInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlantFlowerAcceptGiveFlowerRsp other) {
      if (other == null) {
        return;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.acceptFlowerResultInfo_ != null) {
        if (acceptFlowerResultInfo_ == null) {
          AcceptFlowerResultInfo = new global::OldProtos.PlantFlowerAcceptFlowerResultInfo();
        }
        AcceptFlowerResultInfo.MergeFrom(other.AcceptFlowerResultInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122: {
            if (acceptFlowerResultInfo_ == null) {
              AcceptFlowerResultInfo = new global::OldProtos.PlantFlowerAcceptFlowerResultInfo();
            }
            input.ReadMessage(AcceptFlowerResultInfo);
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
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122: {
            if (acceptFlowerResultInfo_ == null) {
              AcceptFlowerResultInfo = new global::OldProtos.PlantFlowerAcceptFlowerResultInfo();
            }
            input.ReadMessage(AcceptFlowerResultInfo);
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
