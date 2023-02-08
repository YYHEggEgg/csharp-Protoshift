// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForgeQueueManipulateRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ForgeQueueManipulateRsp.proto</summary>
  public static partial class ForgeQueueManipulateRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ForgeQueueManipulateRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForgeQueueManipulateRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Gb3JnZVF1ZXVlTWFuaXB1bGF0ZVJzcC5wcm90bxoeRm9yZ2VRdWV1ZU1h",
            "bmlwdWxhdGVUeXBlLnByb3RvGg9JdGVtUGFyYW0ucHJvdG8i1gEKF0Zvcmdl",
            "UXVldWVNYW5pcHVsYXRlUnNwEioKFmV4dHJhX291dHB1dF9pdGVtX2xpc3QY",
            "AyADKAsyCi5JdGVtUGFyYW0SMgoPbWFuaXB1bGF0ZV90eXBlGAwgASgOMhku",
            "Rm9yZ2VRdWV1ZU1hbmlwdWxhdGVUeXBlEiQKEHJldHVybl9pdGVtX2xpc3QY",
            "BCADKAsyCi5JdGVtUGFyYW0SJAoQb3V0cHV0X2l0ZW1fbGlzdBgOIAMoCzIK",
            "Lkl0ZW1QYXJhbRIPCgdyZXRjb2RlGAsgASgFQgyqAglOZXdQcm90b3NiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ForgeQueueManipulateTypeReflection.Descriptor, global::NewProtos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ForgeQueueManipulateRsp), global::NewProtos.ForgeQueueManipulateRsp.Parser, new[]{ "ExtraOutputItemList", "ManipulateType", "ReturnItemList", "OutputItemList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 682;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ForgeQueueManipulateRsp : pb::IMessage<ForgeQueueManipulateRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForgeQueueManipulateRsp> _parser = new pb::MessageParser<ForgeQueueManipulateRsp>(() => new ForgeQueueManipulateRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ForgeQueueManipulateRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ForgeQueueManipulateRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueManipulateRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueManipulateRsp(ForgeQueueManipulateRsp other) : this() {
      extraOutputItemList_ = other.extraOutputItemList_.Clone();
      manipulateType_ = other.manipulateType_;
      returnItemList_ = other.returnItemList_.Clone();
      outputItemList_ = other.outputItemList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueManipulateRsp Clone() {
      return new ForgeQueueManipulateRsp(this);
    }

    /// <summary>Field number for the "extra_output_item_list" field.</summary>
    public const int ExtraOutputItemListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_extraOutputItemList_codec
        = pb::FieldCodec.ForMessage(26, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> extraOutputItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> ExtraOutputItemList {
      get { return extraOutputItemList_; }
    }

    /// <summary>Field number for the "manipulate_type" field.</summary>
    public const int ManipulateTypeFieldNumber = 12;
    private global::NewProtos.ForgeQueueManipulateType manipulateType_ = global::NewProtos.ForgeQueueManipulateType.ReceiveOutput;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ForgeQueueManipulateType ManipulateType {
      get { return manipulateType_; }
      set {
        manipulateType_ = value;
      }
    }

    /// <summary>Field number for the "return_item_list" field.</summary>
    public const int ReturnItemListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_returnItemList_codec
        = pb::FieldCodec.ForMessage(34, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> returnItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> ReturnItemList {
      get { return returnItemList_; }
    }

    /// <summary>Field number for the "output_item_list" field.</summary>
    public const int OutputItemListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::NewProtos.ItemParam> _repeated_outputItemList_codec
        = pb::FieldCodec.ForMessage(114, global::NewProtos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ItemParam> outputItemList_ = new pbc::RepeatedField<global::NewProtos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ItemParam> OutputItemList {
      get { return outputItemList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
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
      return Equals(other as ForgeQueueManipulateRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ForgeQueueManipulateRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!extraOutputItemList_.Equals(other.extraOutputItemList_)) return false;
      if (ManipulateType != other.ManipulateType) return false;
      if(!returnItemList_.Equals(other.returnItemList_)) return false;
      if(!outputItemList_.Equals(other.outputItemList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= extraOutputItemList_.GetHashCode();
      if (ManipulateType != global::NewProtos.ForgeQueueManipulateType.ReceiveOutput) hash ^= ManipulateType.GetHashCode();
      hash ^= returnItemList_.GetHashCode();
      hash ^= outputItemList_.GetHashCode();
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
      extraOutputItemList_.WriteTo(output, _repeated_extraOutputItemList_codec);
      returnItemList_.WriteTo(output, _repeated_returnItemList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (ManipulateType != global::NewProtos.ForgeQueueManipulateType.ReceiveOutput) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ManipulateType);
      }
      outputItemList_.WriteTo(output, _repeated_outputItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      extraOutputItemList_.WriteTo(ref output, _repeated_extraOutputItemList_codec);
      returnItemList_.WriteTo(ref output, _repeated_returnItemList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (ManipulateType != global::NewProtos.ForgeQueueManipulateType.ReceiveOutput) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ManipulateType);
      }
      outputItemList_.WriteTo(ref output, _repeated_outputItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += extraOutputItemList_.CalculateSize(_repeated_extraOutputItemList_codec);
      if (ManipulateType != global::NewProtos.ForgeQueueManipulateType.ReceiveOutput) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ManipulateType);
      }
      size += returnItemList_.CalculateSize(_repeated_returnItemList_codec);
      size += outputItemList_.CalculateSize(_repeated_outputItemList_codec);
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
    public void MergeFrom(ForgeQueueManipulateRsp other) {
      if (other == null) {
        return;
      }
      extraOutputItemList_.Add(other.extraOutputItemList_);
      if (other.ManipulateType != global::NewProtos.ForgeQueueManipulateType.ReceiveOutput) {
        ManipulateType = other.ManipulateType;
      }
      returnItemList_.Add(other.returnItemList_);
      outputItemList_.Add(other.outputItemList_);
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
            extraOutputItemList_.AddEntriesFrom(input, _repeated_extraOutputItemList_codec);
            break;
          }
          case 34: {
            returnItemList_.AddEntriesFrom(input, _repeated_returnItemList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            ManipulateType = (global::NewProtos.ForgeQueueManipulateType) input.ReadEnum();
            break;
          }
          case 114: {
            outputItemList_.AddEntriesFrom(input, _repeated_outputItemList_codec);
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
            extraOutputItemList_.AddEntriesFrom(ref input, _repeated_extraOutputItemList_codec);
            break;
          }
          case 34: {
            returnItemList_.AddEntriesFrom(ref input, _repeated_returnItemList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            ManipulateType = (global::NewProtos.ForgeQueueManipulateType) input.ReadEnum();
            break;
          }
          case 114: {
            outputItemList_.AddEntriesFrom(ref input, _repeated_outputItemList_codec);
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
