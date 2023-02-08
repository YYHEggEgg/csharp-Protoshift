// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketNpcEventFinishNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from VintageMarketNpcEventFinishNotify.proto</summary>
  public static partial class VintageMarketNpcEventFinishNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageMarketNpcEventFinishNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageMarketNpcEventFinishNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidWaW50YWdlTWFya2V0TnBjRXZlbnRGaW5pc2hOb3RpZnkucHJvdG8iYQoh",
            "VmludGFnZU1hcmtldE5wY0V2ZW50RmluaXNoTm90aWZ5Eg4KBmNvaW5fYRgD",
            "IAEoDRIOCgZjb2luX2MYCSABKA0SHAoUdW5sb2NrX3N0cmF0ZWd5X2xpc3QY",
            "DCADKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.VintageMarketNpcEventFinishNotify), global::NewProtos.VintageMarketNpcEventFinishNotify.Parser, new[]{ "CoinA", "CoinC", "UnlockStrategyList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 24781;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class VintageMarketNpcEventFinishNotify : pb::IMessage<VintageMarketNpcEventFinishNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageMarketNpcEventFinishNotify> _parser = new pb::MessageParser<VintageMarketNpcEventFinishNotify>(() => new VintageMarketNpcEventFinishNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageMarketNpcEventFinishNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.VintageMarketNpcEventFinishNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketNpcEventFinishNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketNpcEventFinishNotify(VintageMarketNpcEventFinishNotify other) : this() {
      coinA_ = other.coinA_;
      coinC_ = other.coinC_;
      unlockStrategyList_ = other.unlockStrategyList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketNpcEventFinishNotify Clone() {
      return new VintageMarketNpcEventFinishNotify(this);
    }

    /// <summary>Field number for the "coin_a" field.</summary>
    public const int CoinAFieldNumber = 3;
    private uint coinA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinA {
      get { return coinA_; }
      set {
        coinA_ = value;
      }
    }

    /// <summary>Field number for the "coin_c" field.</summary>
    public const int CoinCFieldNumber = 9;
    private uint coinC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinC {
      get { return coinC_; }
      set {
        coinC_ = value;
      }
    }

    /// <summary>Field number for the "unlock_strategy_list" field.</summary>
    public const int UnlockStrategyListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_unlockStrategyList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> unlockStrategyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockStrategyList {
      get { return unlockStrategyList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageMarketNpcEventFinishNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageMarketNpcEventFinishNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CoinA != other.CoinA) return false;
      if (CoinC != other.CoinC) return false;
      if(!unlockStrategyList_.Equals(other.unlockStrategyList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CoinA != 0) hash ^= CoinA.GetHashCode();
      if (CoinC != 0) hash ^= CoinC.GetHashCode();
      hash ^= unlockStrategyList_.GetHashCode();
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
      if (CoinA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CoinA);
      }
      if (CoinC != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CoinC);
      }
      unlockStrategyList_.WriteTo(output, _repeated_unlockStrategyList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CoinA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CoinA);
      }
      if (CoinC != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CoinC);
      }
      unlockStrategyList_.WriteTo(ref output, _repeated_unlockStrategyList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CoinA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinA);
      }
      if (CoinC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinC);
      }
      size += unlockStrategyList_.CalculateSize(_repeated_unlockStrategyList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageMarketNpcEventFinishNotify other) {
      if (other == null) {
        return;
      }
      if (other.CoinA != 0) {
        CoinA = other.CoinA;
      }
      if (other.CoinC != 0) {
        CoinC = other.CoinC;
      }
      unlockStrategyList_.Add(other.unlockStrategyList_);
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
            CoinA = input.ReadUInt32();
            break;
          }
          case 72: {
            CoinC = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            unlockStrategyList_.AddEntriesFrom(input, _repeated_unlockStrategyList_codec);
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
            CoinA = input.ReadUInt32();
            break;
          }
          case 72: {
            CoinC = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            unlockStrategyList_.AddEntriesFrom(ref input, _repeated_unlockStrategyList_codec);
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
