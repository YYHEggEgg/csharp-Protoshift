// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetHomeExchangeWoodInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GetHomeExchangeWoodInfoRsp.proto</summary>
public static partial class GetHomeExchangeWoodInfoRspReflection {

  #region Descriptor
  /// <summary>File descriptor for GetHomeExchangeWoodInfoRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GetHomeExchangeWoodInfoRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBHZXRIb21lRXhjaGFuZ2VXb29kSW5mb1JzcC5wcm90byLsAQoaR2V0SG9t",
          "ZUV4Y2hhbmdlV29vZEluZm9Sc3ASSAoOd29vZF9pbmZvX2xpc3QYByADKAsy",
          "MC5HZXRIb21lRXhjaGFuZ2VXb29kSW5mb1JzcC5Ib21lRXhjaGFuZ2VXb29k",
          "SW5mbxIPCgdyZXRjb2RlGAwgASgFGnMKFEhvbWVFeGNoYW5nZVdvb2RJbmZv",
          "Eg8KB3dvb2RfaWQYASABKA0SFwoPZXhjaGFuZ2VkX2NvdW50GAcgASgNEhkK",
          "EW5leHRfcmVmcmVzaF90aW1lGA4gASgNEhYKDmV4Y2hhbmdlX2xpbWl0GAQg",
          "ASgNQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GetHomeExchangeWoodInfoRsp), global::GetHomeExchangeWoodInfoRsp.Parser, new[]{ "WoodInfoList", "Retcode" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::GetHomeExchangeWoodInfoRsp.Types.HomeExchangeWoodInfo), global::GetHomeExchangeWoodInfoRsp.Types.HomeExchangeWoodInfo.Parser, new[]{ "WoodId", "ExchangedCount", "NextRefreshTime", "ExchangeLimit" }, null, null, null, null)})
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4580;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GetHomeExchangeWoodInfoRsp : pb::IMessage<GetHomeExchangeWoodInfoRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GetHomeExchangeWoodInfoRsp> _parser = new pb::MessageParser<GetHomeExchangeWoodInfoRsp>(() => new GetHomeExchangeWoodInfoRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GetHomeExchangeWoodInfoRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GetHomeExchangeWoodInfoRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetHomeExchangeWoodInfoRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetHomeExchangeWoodInfoRsp(GetHomeExchangeWoodInfoRsp other) : this() {
    woodInfoList_ = other.woodInfoList_.Clone();
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GetHomeExchangeWoodInfoRsp Clone() {
    return new GetHomeExchangeWoodInfoRsp(this);
  }

  /// <summary>Field number for the "wood_info_list" field.</summary>
  public const int WoodInfoListFieldNumber = 7;
  private static readonly pb::FieldCodec<global::GetHomeExchangeWoodInfoRsp.Types.HomeExchangeWoodInfo> _repeated_woodInfoList_codec
      = pb::FieldCodec.ForMessage(58, global::GetHomeExchangeWoodInfoRsp.Types.HomeExchangeWoodInfo.Parser);
  private readonly pbc::RepeatedField<global::GetHomeExchangeWoodInfoRsp.Types.HomeExchangeWoodInfo> woodInfoList_ = new pbc::RepeatedField<global::GetHomeExchangeWoodInfoRsp.Types.HomeExchangeWoodInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GetHomeExchangeWoodInfoRsp.Types.HomeExchangeWoodInfo> WoodInfoList {
    get { return woodInfoList_; }
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
    return Equals(other as GetHomeExchangeWoodInfoRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GetHomeExchangeWoodInfoRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!woodInfoList_.Equals(other.woodInfoList_)) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= woodInfoList_.GetHashCode();
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
    woodInfoList_.WriteTo(output, _repeated_woodInfoList_codec);
    if (Retcode != 0) {
      output.WriteRawTag(96);
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
    woodInfoList_.WriteTo(ref output, _repeated_woodInfoList_codec);
    if (Retcode != 0) {
      output.WriteRawTag(96);
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
    size += woodInfoList_.CalculateSize(_repeated_woodInfoList_codec);
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
  public void MergeFrom(GetHomeExchangeWoodInfoRsp other) {
    if (other == null) {
      return;
    }
    woodInfoList_.Add(other.woodInfoList_);
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
        case 58: {
          woodInfoList_.AddEntriesFrom(input, _repeated_woodInfoList_codec);
          break;
        }
        case 96: {
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
        case 58: {
          woodInfoList_.AddEntriesFrom(ref input, _repeated_woodInfoList_codec);
          break;
        }
        case 96: {
          Retcode = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the GetHomeExchangeWoodInfoRsp message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public sealed partial class HomeExchangeWoodInfo : pb::IMessage<HomeExchangeWoodInfo>
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , pb::IBufferMessage
    #endif
    {
      private static readonly pb::MessageParser<HomeExchangeWoodInfo> _parser = new pb::MessageParser<HomeExchangeWoodInfo>(() => new HomeExchangeWoodInfo());
      private pb::UnknownFieldSet _unknownFields;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pb::MessageParser<HomeExchangeWoodInfo> Parser { get { return _parser; } }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pbr::MessageDescriptor Descriptor {
        get { return global::GetHomeExchangeWoodInfoRsp.Descriptor.NestedTypes[0]; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public HomeExchangeWoodInfo() {
        OnConstruction();
      }

      partial void OnConstruction();

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public HomeExchangeWoodInfo(HomeExchangeWoodInfo other) : this() {
        woodId_ = other.woodId_;
        exchangedCount_ = other.exchangedCount_;
        nextRefreshTime_ = other.nextRefreshTime_;
        exchangeLimit_ = other.exchangeLimit_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public HomeExchangeWoodInfo Clone() {
        return new HomeExchangeWoodInfo(this);
      }

      /// <summary>Field number for the "wood_id" field.</summary>
      public const int WoodIdFieldNumber = 1;
      private uint woodId_;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public uint WoodId {
        get { return woodId_; }
        set {
          woodId_ = value;
        }
      }

      /// <summary>Field number for the "exchanged_count" field.</summary>
      public const int ExchangedCountFieldNumber = 7;
      private uint exchangedCount_;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public uint ExchangedCount {
        get { return exchangedCount_; }
        set {
          exchangedCount_ = value;
        }
      }

      /// <summary>Field number for the "next_refresh_time" field.</summary>
      public const int NextRefreshTimeFieldNumber = 14;
      private uint nextRefreshTime_;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public uint NextRefreshTime {
        get { return nextRefreshTime_; }
        set {
          nextRefreshTime_ = value;
        }
      }

      /// <summary>Field number for the "exchange_limit" field.</summary>
      public const int ExchangeLimitFieldNumber = 4;
      private uint exchangeLimit_;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public uint ExchangeLimit {
        get { return exchangeLimit_; }
        set {
          exchangeLimit_ = value;
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override bool Equals(object other) {
        return Equals(other as HomeExchangeWoodInfo);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public bool Equals(HomeExchangeWoodInfo other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if (WoodId != other.WoodId) return false;
        if (ExchangedCount != other.ExchangedCount) return false;
        if (NextRefreshTime != other.NextRefreshTime) return false;
        if (ExchangeLimit != other.ExchangeLimit) return false;
        return Equals(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override int GetHashCode() {
        int hash = 1;
        if (WoodId != 0) hash ^= WoodId.GetHashCode();
        if (ExchangedCount != 0) hash ^= ExchangedCount.GetHashCode();
        if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
        if (ExchangeLimit != 0) hash ^= ExchangeLimit.GetHashCode();
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
        if (WoodId != 0) {
          output.WriteRawTag(8);
          output.WriteUInt32(WoodId);
        }
        if (ExchangeLimit != 0) {
          output.WriteRawTag(32);
          output.WriteUInt32(ExchangeLimit);
        }
        if (ExchangedCount != 0) {
          output.WriteRawTag(56);
          output.WriteUInt32(ExchangedCount);
        }
        if (NextRefreshTime != 0) {
          output.WriteRawTag(112);
          output.WriteUInt32(NextRefreshTime);
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
        if (WoodId != 0) {
          output.WriteRawTag(8);
          output.WriteUInt32(WoodId);
        }
        if (ExchangeLimit != 0) {
          output.WriteRawTag(32);
          output.WriteUInt32(ExchangeLimit);
        }
        if (ExchangedCount != 0) {
          output.WriteRawTag(56);
          output.WriteUInt32(ExchangedCount);
        }
        if (NextRefreshTime != 0) {
          output.WriteRawTag(112);
          output.WriteUInt32(NextRefreshTime);
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
        if (WoodId != 0) {
          size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WoodId);
        }
        if (ExchangedCount != 0) {
          size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExchangedCount);
        }
        if (NextRefreshTime != 0) {
          size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
        }
        if (ExchangeLimit != 0) {
          size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExchangeLimit);
        }
        if (_unknownFields != null) {
          size += _unknownFields.CalculateSize();
        }
        return size;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public void MergeFrom(HomeExchangeWoodInfo other) {
        if (other == null) {
          return;
        }
        if (other.WoodId != 0) {
          WoodId = other.WoodId;
        }
        if (other.ExchangedCount != 0) {
          ExchangedCount = other.ExchangedCount;
        }
        if (other.NextRefreshTime != 0) {
          NextRefreshTime = other.NextRefreshTime;
        }
        if (other.ExchangeLimit != 0) {
          ExchangeLimit = other.ExchangeLimit;
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
              WoodId = input.ReadUInt32();
              break;
            }
            case 32: {
              ExchangeLimit = input.ReadUInt32();
              break;
            }
            case 56: {
              ExchangedCount = input.ReadUInt32();
              break;
            }
            case 112: {
              NextRefreshTime = input.ReadUInt32();
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
              WoodId = input.ReadUInt32();
              break;
            }
            case 32: {
              ExchangeLimit = input.ReadUInt32();
              break;
            }
            case 56: {
              ExchangedCount = input.ReadUInt32();
              break;
            }
            case 112: {
              NextRefreshTime = input.ReadUInt32();
              break;
            }
          }
        }
      }
      #endif

    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
