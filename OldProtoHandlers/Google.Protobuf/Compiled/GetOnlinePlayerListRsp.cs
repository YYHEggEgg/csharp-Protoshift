// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetOnlinePlayerListRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GetOnlinePlayerListRsp.proto</summary>
  public static partial class GetOnlinePlayerListRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetOnlinePlayerListRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetOnlinePlayerListRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRPbmxpbmVQbGF5ZXJMaXN0UnNwLnByb3RvGhZPbmxpbmVQbGF5ZXJJ",
            "bmZvLnByb3RvImUKFkdldE9ubGluZVBsYXllckxpc3RSc3ASDwoHcmV0Y29k",
            "ZRgHIAEoBRINCgVwYXJhbRgLIAEoDRIrChBwbGF5ZXJfaW5mb19saXN0GAUg",
            "AygLMhEuT25saW5lUGxheWVySW5mb0IMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GetOnlinePlayerListRsp), global::OldProtos.GetOnlinePlayerListRsp.Parser, new[]{ "Retcode", "Param", "PlayerInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 73
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GetOnlinePlayerListRsp : pb::IMessage<GetOnlinePlayerListRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetOnlinePlayerListRsp> _parser = new pb::MessageParser<GetOnlinePlayerListRsp>(() => new GetOnlinePlayerListRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetOnlinePlayerListRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GetOnlinePlayerListRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetOnlinePlayerListRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetOnlinePlayerListRsp(GetOnlinePlayerListRsp other) : this() {
      retcode_ = other.retcode_;
      param_ = other.param_;
      playerInfoList_ = other.playerInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetOnlinePlayerListRsp Clone() {
      return new GetOnlinePlayerListRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 11;
    private uint param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    /// <summary>Field number for the "player_info_list" field.</summary>
    public const int PlayerInfoListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::OldProtos.OnlinePlayerInfo> _repeated_playerInfoList_codec
        = pb::FieldCodec.ForMessage(42, global::OldProtos.OnlinePlayerInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.OnlinePlayerInfo> playerInfoList_ = new pbc::RepeatedField<global::OldProtos.OnlinePlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.OnlinePlayerInfo> PlayerInfoList {
      get { return playerInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetOnlinePlayerListRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetOnlinePlayerListRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Param != other.Param) return false;
      if(!playerInfoList_.Equals(other.playerInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Param != 0) hash ^= Param.GetHashCode();
      hash ^= playerInfoList_.GetHashCode();
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
      playerInfoList_.WriteTo(output, _repeated_playerInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (Param != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Param);
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
      playerInfoList_.WriteTo(ref output, _repeated_playerInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (Param != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Param);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param);
      }
      size += playerInfoList_.CalculateSize(_repeated_playerInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetOnlinePlayerListRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Param != 0) {
        Param = other.Param;
      }
      playerInfoList_.Add(other.playerInfoList_);
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
          case 42: {
            playerInfoList_.AddEntriesFrom(input, _repeated_playerInfoList_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 88: {
            Param = input.ReadUInt32();
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
          case 42: {
            playerInfoList_.AddEntriesFrom(ref input, _repeated_playerInfoList_codec);
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 88: {
            Param = input.ReadUInt32();
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
