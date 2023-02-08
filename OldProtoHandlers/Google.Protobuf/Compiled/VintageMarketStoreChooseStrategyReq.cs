// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketStoreChooseStrategyReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from VintageMarketStoreChooseStrategyReq.proto</summary>
  public static partial class VintageMarketStoreChooseStrategyReqReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageMarketStoreChooseStrategyReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageMarketStoreChooseStrategyReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilWaW50YWdlTWFya2V0U3RvcmVDaG9vc2VTdHJhdGVneVJlcS5wcm90bxoe",
            "VmludGFnZU1hcmtldFN0b3JlT3BJbmZvLnByb3RvIoABCiNWaW50YWdlTWFy",
            "a2V0U3RvcmVDaG9vc2VTdHJhdGVneVJlcRIQCghzdG9yZV9pZBgGIAEoDRIw",
            "Cg1zdG9yZV9vcF9saXN0GAkgAygLMhkuVmludGFnZU1hcmtldFN0b3JlT3BJ",
            "bmZvEhUKDXN0cmF0ZWd5X2xpc3QYCCADKA1CDKoCCU9sZFByb3Rvc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VintageMarketStoreOpInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.VintageMarketStoreChooseStrategyReq), global::OldProtos.VintageMarketStoreChooseStrategyReq.Parser, new[]{ "StoreId", "StoreOpList", "StrategyList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 21248
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class VintageMarketStoreChooseStrategyReq : pb::IMessage<VintageMarketStoreChooseStrategyReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageMarketStoreChooseStrategyReq> _parser = new pb::MessageParser<VintageMarketStoreChooseStrategyReq>(() => new VintageMarketStoreChooseStrategyReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageMarketStoreChooseStrategyReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.VintageMarketStoreChooseStrategyReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStoreChooseStrategyReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStoreChooseStrategyReq(VintageMarketStoreChooseStrategyReq other) : this() {
      storeId_ = other.storeId_;
      storeOpList_ = other.storeOpList_.Clone();
      strategyList_ = other.strategyList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStoreChooseStrategyReq Clone() {
      return new VintageMarketStoreChooseStrategyReq(this);
    }

    /// <summary>Field number for the "store_id" field.</summary>
    public const int StoreIdFieldNumber = 6;
    private uint storeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreId {
      get { return storeId_; }
      set {
        storeId_ = value;
      }
    }

    /// <summary>Field number for the "store_op_list" field.</summary>
    public const int StoreOpListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::OldProtos.VintageMarketStoreOpInfo> _repeated_storeOpList_codec
        = pb::FieldCodec.ForMessage(74, global::OldProtos.VintageMarketStoreOpInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.VintageMarketStoreOpInfo> storeOpList_ = new pbc::RepeatedField<global::OldProtos.VintageMarketStoreOpInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.VintageMarketStoreOpInfo> StoreOpList {
      get { return storeOpList_; }
    }

    /// <summary>Field number for the "strategy_list" field.</summary>
    public const int StrategyListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_strategyList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> strategyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> StrategyList {
      get { return strategyList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageMarketStoreChooseStrategyReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageMarketStoreChooseStrategyReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StoreId != other.StoreId) return false;
      if(!storeOpList_.Equals(other.storeOpList_)) return false;
      if(!strategyList_.Equals(other.strategyList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StoreId != 0) hash ^= StoreId.GetHashCode();
      hash ^= storeOpList_.GetHashCode();
      hash ^= strategyList_.GetHashCode();
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
      if (StoreId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StoreId);
      }
      strategyList_.WriteTo(output, _repeated_strategyList_codec);
      storeOpList_.WriteTo(output, _repeated_storeOpList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StoreId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StoreId);
      }
      strategyList_.WriteTo(ref output, _repeated_strategyList_codec);
      storeOpList_.WriteTo(ref output, _repeated_storeOpList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreId);
      }
      size += storeOpList_.CalculateSize(_repeated_storeOpList_codec);
      size += strategyList_.CalculateSize(_repeated_strategyList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageMarketStoreChooseStrategyReq other) {
      if (other == null) {
        return;
      }
      if (other.StoreId != 0) {
        StoreId = other.StoreId;
      }
      storeOpList_.Add(other.storeOpList_);
      strategyList_.Add(other.strategyList_);
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
            StoreId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            strategyList_.AddEntriesFrom(input, _repeated_strategyList_codec);
            break;
          }
          case 74: {
            storeOpList_.AddEntriesFrom(input, _repeated_storeOpList_codec);
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
            StoreId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            strategyList_.AddEntriesFrom(ref input, _repeated_strategyList_codec);
            break;
          }
          case 74: {
            storeOpList_.AddEntriesFrom(ref input, _repeated_storeOpList_codec);
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
