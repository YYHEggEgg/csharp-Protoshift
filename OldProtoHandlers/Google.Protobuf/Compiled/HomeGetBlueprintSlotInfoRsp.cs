// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeGetBlueprintSlotInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from HomeGetBlueprintSlotInfoRsp.proto</summary>
  public static partial class HomeGetBlueprintSlotInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeGetBlueprintSlotInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeGetBlueprintSlotInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFIb21lR2V0Qmx1ZXByaW50U2xvdEluZm9Sc3AucHJvdG8aG0hvbWVCbHVl",
            "cHJpbnRTbG90SW5mby5wcm90byJ7ChtIb21lR2V0Qmx1ZXByaW50U2xvdElu",
            "Zm9Sc3ASGwoTZGVsZXRlX3Nsb3RfaWRfbGlzdBgGIAMoDRIuCg5zbG90X2lu",
            "Zm9fbGlzdBgDIAMoCzIWLkhvbWVCbHVlcHJpbnRTbG90SW5mbxIPCgdyZXRj",
            "b2RlGA8gASgFQgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.HomeBlueprintSlotInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.HomeGetBlueprintSlotInfoRsp), global::OldProtos.HomeGetBlueprintSlotInfoRsp.Parser, new[]{ "DeleteSlotIdList", "SlotInfoList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4662
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class HomeGetBlueprintSlotInfoRsp : pb::IMessage<HomeGetBlueprintSlotInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeGetBlueprintSlotInfoRsp> _parser = new pb::MessageParser<HomeGetBlueprintSlotInfoRsp>(() => new HomeGetBlueprintSlotInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeGetBlueprintSlotInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.HomeGetBlueprintSlotInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGetBlueprintSlotInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGetBlueprintSlotInfoRsp(HomeGetBlueprintSlotInfoRsp other) : this() {
      deleteSlotIdList_ = other.deleteSlotIdList_.Clone();
      slotInfoList_ = other.slotInfoList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGetBlueprintSlotInfoRsp Clone() {
      return new HomeGetBlueprintSlotInfoRsp(this);
    }

    /// <summary>Field number for the "delete_slot_id_list" field.</summary>
    public const int DeleteSlotIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_deleteSlotIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> deleteSlotIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DeleteSlotIdList {
      get { return deleteSlotIdList_; }
    }

    /// <summary>Field number for the "slot_info_list" field.</summary>
    public const int SlotInfoListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::OldProtos.HomeBlueprintSlotInfo> _repeated_slotInfoList_codec
        = pb::FieldCodec.ForMessage(26, global::OldProtos.HomeBlueprintSlotInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.HomeBlueprintSlotInfo> slotInfoList_ = new pbc::RepeatedField<global::OldProtos.HomeBlueprintSlotInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.HomeBlueprintSlotInfo> SlotInfoList {
      get { return slotInfoList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
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
      return Equals(other as HomeGetBlueprintSlotInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeGetBlueprintSlotInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!deleteSlotIdList_.Equals(other.deleteSlotIdList_)) return false;
      if(!slotInfoList_.Equals(other.slotInfoList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= deleteSlotIdList_.GetHashCode();
      hash ^= slotInfoList_.GetHashCode();
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
      slotInfoList_.WriteTo(output, _repeated_slotInfoList_codec);
      deleteSlotIdList_.WriteTo(output, _repeated_deleteSlotIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      slotInfoList_.WriteTo(ref output, _repeated_slotInfoList_codec);
      deleteSlotIdList_.WriteTo(ref output, _repeated_deleteSlotIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      size += deleteSlotIdList_.CalculateSize(_repeated_deleteSlotIdList_codec);
      size += slotInfoList_.CalculateSize(_repeated_slotInfoList_codec);
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
    public void MergeFrom(HomeGetBlueprintSlotInfoRsp other) {
      if (other == null) {
        return;
      }
      deleteSlotIdList_.Add(other.deleteSlotIdList_);
      slotInfoList_.Add(other.slotInfoList_);
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
          case 26: {
            slotInfoList_.AddEntriesFrom(input, _repeated_slotInfoList_codec);
            break;
          }
          case 50:
          case 48: {
            deleteSlotIdList_.AddEntriesFrom(input, _repeated_deleteSlotIdList_codec);
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
            slotInfoList_.AddEntriesFrom(ref input, _repeated_slotInfoList_codec);
            break;
          }
          case 50:
          case 48: {
            deleteSlotIdList_.AddEntriesFrom(ref input, _repeated_deleteSlotIdList_codec);
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
