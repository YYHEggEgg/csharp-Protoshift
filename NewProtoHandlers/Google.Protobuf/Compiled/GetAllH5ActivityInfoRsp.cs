// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAllH5ActivityInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GetAllH5ActivityInfoRsp.proto</summary>
  public static partial class GetAllH5ActivityInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAllH5ActivityInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAllH5ActivityInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRBbGxINUFjdGl2aXR5SW5mb1JzcC5wcm90bxoUSDVBY3Rpdml0eUlu",
            "Zm8ucHJvdG8ifAoXR2V0QWxsSDVBY3Rpdml0eUluZm9Sc3ASIAoYY2xpZW50",
            "X3JlZF9kb3RfdGltZXN0YW1wGAMgASgNEi4KFWg1X2FjdGl2aXR5X2luZm9f",
            "bGlzdBgFIAMoCzIPLkg1QWN0aXZpdHlJbmZvEg8KB3JldGNvZGUYDiABKAVC",
            "DKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.H5ActivityInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GetAllH5ActivityInfoRsp), global::NewProtos.GetAllH5ActivityInfoRsp.Parser, new[]{ "ClientRedDotTimestamp", "H5ActivityInfoList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5692;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetAllH5ActivityInfoRsp : pb::IMessage<GetAllH5ActivityInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllH5ActivityInfoRsp> _parser = new pb::MessageParser<GetAllH5ActivityInfoRsp>(() => new GetAllH5ActivityInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAllH5ActivityInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GetAllH5ActivityInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllH5ActivityInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllH5ActivityInfoRsp(GetAllH5ActivityInfoRsp other) : this() {
      clientRedDotTimestamp_ = other.clientRedDotTimestamp_;
      h5ActivityInfoList_ = other.h5ActivityInfoList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllH5ActivityInfoRsp Clone() {
      return new GetAllH5ActivityInfoRsp(this);
    }

    /// <summary>Field number for the "client_red_dot_timestamp" field.</summary>
    public const int ClientRedDotTimestampFieldNumber = 3;
    private uint clientRedDotTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientRedDotTimestamp {
      get { return clientRedDotTimestamp_; }
      set {
        clientRedDotTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "h5_activity_info_list" field.</summary>
    public const int H5ActivityInfoListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::NewProtos.H5ActivityInfo> _repeated_h5ActivityInfoList_codec
        = pb::FieldCodec.ForMessage(42, global::NewProtos.H5ActivityInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.H5ActivityInfo> h5ActivityInfoList_ = new pbc::RepeatedField<global::NewProtos.H5ActivityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.H5ActivityInfo> H5ActivityInfoList {
      get { return h5ActivityInfoList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
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
      return Equals(other as GetAllH5ActivityInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAllH5ActivityInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientRedDotTimestamp != other.ClientRedDotTimestamp) return false;
      if(!h5ActivityInfoList_.Equals(other.h5ActivityInfoList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientRedDotTimestamp != 0) hash ^= ClientRedDotTimestamp.GetHashCode();
      hash ^= h5ActivityInfoList_.GetHashCode();
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
      if (ClientRedDotTimestamp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ClientRedDotTimestamp);
      }
      h5ActivityInfoList_.WriteTo(output, _repeated_h5ActivityInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      if (ClientRedDotTimestamp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ClientRedDotTimestamp);
      }
      h5ActivityInfoList_.WriteTo(ref output, _repeated_h5ActivityInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      if (ClientRedDotTimestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientRedDotTimestamp);
      }
      size += h5ActivityInfoList_.CalculateSize(_repeated_h5ActivityInfoList_codec);
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
    public void MergeFrom(GetAllH5ActivityInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.ClientRedDotTimestamp != 0) {
        ClientRedDotTimestamp = other.ClientRedDotTimestamp;
      }
      h5ActivityInfoList_.Add(other.h5ActivityInfoList_);
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
          case 24: {
            ClientRedDotTimestamp = input.ReadUInt32();
            break;
          }
          case 42: {
            h5ActivityInfoList_.AddEntriesFrom(input, _repeated_h5ActivityInfoList_codec);
            break;
          }
          case 112: {
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
          case 24: {
            ClientRedDotTimestamp = input.ReadUInt32();
            break;
          }
          case 42: {
            h5ActivityInfoList_.AddEntriesFrom(ref input, _repeated_h5ActivityInfoList_codec);
            break;
          }
          case 112: {
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
