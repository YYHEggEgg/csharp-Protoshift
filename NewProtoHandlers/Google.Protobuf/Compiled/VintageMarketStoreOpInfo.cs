// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketStoreOpInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from VintageMarketStoreOpInfo.proto</summary>
  public static partial class VintageMarketStoreOpInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageMarketStoreOpInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageMarketStoreOpInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5WaW50YWdlTWFya2V0U3RvcmVPcEluZm8ucHJvdG8igwEKGFZpbnRhZ2VN",
            "YXJrZXRTdG9yZU9wSW5mbxIQCghoZWxwX3VpZBgLIAEoDRIVCg1oZWxwX3Nr",
            "aWxsX2lkGAogASgNEhAKCHN0b3JlX2lkGAggASgNEhUKDWFkZF9hdHRyX2xp",
            "c3QYDCADKA0SFQoNc3RyYXRlZ3lfbGlzdBgJIAMoDUIMqgIJTmV3UHJvdG9z",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.VintageMarketStoreOpInfo), global::NewProtos.VintageMarketStoreOpInfo.Parser, new[]{ "HelpUid", "HelpSkillId", "StoreId", "AddAttrList", "StrategyList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageMarketStoreOpInfo : pb::IMessage<VintageMarketStoreOpInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageMarketStoreOpInfo> _parser = new pb::MessageParser<VintageMarketStoreOpInfo>(() => new VintageMarketStoreOpInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageMarketStoreOpInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.VintageMarketStoreOpInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStoreOpInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStoreOpInfo(VintageMarketStoreOpInfo other) : this() {
      helpUid_ = other.helpUid_;
      helpSkillId_ = other.helpSkillId_;
      storeId_ = other.storeId_;
      addAttrList_ = other.addAttrList_.Clone();
      strategyList_ = other.strategyList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStoreOpInfo Clone() {
      return new VintageMarketStoreOpInfo(this);
    }

    /// <summary>Field number for the "help_uid" field.</summary>
    public const int HelpUidFieldNumber = 11;
    private uint helpUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HelpUid {
      get { return helpUid_; }
      set {
        helpUid_ = value;
      }
    }

    /// <summary>Field number for the "help_skill_id" field.</summary>
    public const int HelpSkillIdFieldNumber = 10;
    private uint helpSkillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HelpSkillId {
      get { return helpSkillId_; }
      set {
        helpSkillId_ = value;
      }
    }

    /// <summary>Field number for the "store_id" field.</summary>
    public const int StoreIdFieldNumber = 8;
    private uint storeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreId {
      get { return storeId_; }
      set {
        storeId_ = value;
      }
    }

    /// <summary>Field number for the "add_attr_list" field.</summary>
    public const int AddAttrListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_addAttrList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> addAttrList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AddAttrList {
      get { return addAttrList_; }
    }

    /// <summary>Field number for the "strategy_list" field.</summary>
    public const int StrategyListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_strategyList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> strategyList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> StrategyList {
      get { return strategyList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageMarketStoreOpInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageMarketStoreOpInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HelpUid != other.HelpUid) return false;
      if (HelpSkillId != other.HelpSkillId) return false;
      if (StoreId != other.StoreId) return false;
      if(!addAttrList_.Equals(other.addAttrList_)) return false;
      if(!strategyList_.Equals(other.strategyList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HelpUid != 0) hash ^= HelpUid.GetHashCode();
      if (HelpSkillId != 0) hash ^= HelpSkillId.GetHashCode();
      if (StoreId != 0) hash ^= StoreId.GetHashCode();
      hash ^= addAttrList_.GetHashCode();
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
        output.WriteRawTag(64);
        output.WriteUInt32(StoreId);
      }
      strategyList_.WriteTo(output, _repeated_strategyList_codec);
      if (HelpSkillId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HelpSkillId);
      }
      if (HelpUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HelpUid);
      }
      addAttrList_.WriteTo(output, _repeated_addAttrList_codec);
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
        output.WriteRawTag(64);
        output.WriteUInt32(StoreId);
      }
      strategyList_.WriteTo(ref output, _repeated_strategyList_codec);
      if (HelpSkillId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HelpSkillId);
      }
      if (HelpUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HelpUid);
      }
      addAttrList_.WriteTo(ref output, _repeated_addAttrList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HelpUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HelpUid);
      }
      if (HelpSkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HelpSkillId);
      }
      if (StoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreId);
      }
      size += addAttrList_.CalculateSize(_repeated_addAttrList_codec);
      size += strategyList_.CalculateSize(_repeated_strategyList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageMarketStoreOpInfo other) {
      if (other == null) {
        return;
      }
      if (other.HelpUid != 0) {
        HelpUid = other.HelpUid;
      }
      if (other.HelpSkillId != 0) {
        HelpSkillId = other.HelpSkillId;
      }
      if (other.StoreId != 0) {
        StoreId = other.StoreId;
      }
      addAttrList_.Add(other.addAttrList_);
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
          case 64: {
            StoreId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            strategyList_.AddEntriesFrom(input, _repeated_strategyList_codec);
            break;
          }
          case 80: {
            HelpSkillId = input.ReadUInt32();
            break;
          }
          case 88: {
            HelpUid = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            addAttrList_.AddEntriesFrom(input, _repeated_addAttrList_codec);
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
          case 64: {
            StoreId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            strategyList_.AddEntriesFrom(ref input, _repeated_strategyList_codec);
            break;
          }
          case 80: {
            HelpSkillId = input.ReadUInt32();
            break;
          }
          case 88: {
            HelpUid = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            addAttrList_.AddEntriesFrom(ref input, _repeated_addAttrList_codec);
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