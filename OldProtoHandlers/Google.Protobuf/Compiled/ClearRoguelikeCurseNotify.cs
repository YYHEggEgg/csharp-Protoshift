// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClearRoguelikeCurseNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ClearRoguelikeCurseNotify.proto</summary>
  public static partial class ClearRoguelikeCurseNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ClearRoguelikeCurseNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClearRoguelikeCurseNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DbGVhclJvZ3VlbGlrZUN1cnNlTm90aWZ5LnByb3RvItwBChlDbGVhclJv",
            "Z3VlbGlrZUN1cnNlTm90aWZ5EkYKD2NsZWFyX2N1cnNlX21hcBgKIAMoCzIt",
            "LkNsZWFyUm9ndWVsaWtlQ3Vyc2VOb3RpZnkuQ2xlYXJDdXJzZU1hcEVudHJ5",
            "EhQKDGlzX2NsZWFyX2FsbBgLIAEoCBIPCgdjYXJkX2lkGAggASgNEhoKEmlz",
            "X2N1cnNlX2FsbF9jbGVhchgBIAEoCBo0ChJDbGVhckN1cnNlTWFwRW50cnkS",
            "CwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIMqgIJT2xkUHJvdG9z",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ClearRoguelikeCurseNotify), global::OldProtos.ClearRoguelikeCurseNotify.Parser, new[]{ "ClearCurseMap", "IsClearAll", "CardId", "IsCurseAllClear" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8207
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ClearRoguelikeCurseNotify : pb::IMessage<ClearRoguelikeCurseNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClearRoguelikeCurseNotify> _parser = new pb::MessageParser<ClearRoguelikeCurseNotify>(() => new ClearRoguelikeCurseNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClearRoguelikeCurseNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ClearRoguelikeCurseNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearRoguelikeCurseNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearRoguelikeCurseNotify(ClearRoguelikeCurseNotify other) : this() {
      clearCurseMap_ = other.clearCurseMap_.Clone();
      isClearAll_ = other.isClearAll_;
      cardId_ = other.cardId_;
      isCurseAllClear_ = other.isCurseAllClear_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClearRoguelikeCurseNotify Clone() {
      return new ClearRoguelikeCurseNotify(this);
    }

    /// <summary>Field number for the "clear_curse_map" field.</summary>
    public const int ClearCurseMapFieldNumber = 10;
    private static readonly pbc::MapField<uint, uint>.Codec _map_clearCurseMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 82);
    private readonly pbc::MapField<uint, uint> clearCurseMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> ClearCurseMap {
      get { return clearCurseMap_; }
    }

    /// <summary>Field number for the "is_clear_all" field.</summary>
    public const int IsClearAllFieldNumber = 11;
    private bool isClearAll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsClearAll {
      get { return isClearAll_; }
      set {
        isClearAll_ = value;
      }
    }

    /// <summary>Field number for the "card_id" field.</summary>
    public const int CardIdFieldNumber = 8;
    private uint cardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardId {
      get { return cardId_; }
      set {
        cardId_ = value;
      }
    }

    /// <summary>Field number for the "is_curse_all_clear" field.</summary>
    public const int IsCurseAllClearFieldNumber = 1;
    private bool isCurseAllClear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCurseAllClear {
      get { return isCurseAllClear_; }
      set {
        isCurseAllClear_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClearRoguelikeCurseNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClearRoguelikeCurseNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ClearCurseMap.Equals(other.ClearCurseMap)) return false;
      if (IsClearAll != other.IsClearAll) return false;
      if (CardId != other.CardId) return false;
      if (IsCurseAllClear != other.IsCurseAllClear) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ClearCurseMap.GetHashCode();
      if (IsClearAll != false) hash ^= IsClearAll.GetHashCode();
      if (CardId != 0) hash ^= CardId.GetHashCode();
      if (IsCurseAllClear != false) hash ^= IsCurseAllClear.GetHashCode();
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
      if (IsCurseAllClear != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsCurseAllClear);
      }
      if (CardId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CardId);
      }
      clearCurseMap_.WriteTo(output, _map_clearCurseMap_codec);
      if (IsClearAll != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsClearAll);
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
      if (IsCurseAllClear != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsCurseAllClear);
      }
      if (CardId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CardId);
      }
      clearCurseMap_.WriteTo(ref output, _map_clearCurseMap_codec);
      if (IsClearAll != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsClearAll);
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
      size += clearCurseMap_.CalculateSize(_map_clearCurseMap_codec);
      if (IsClearAll != false) {
        size += 1 + 1;
      }
      if (CardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardId);
      }
      if (IsCurseAllClear != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClearRoguelikeCurseNotify other) {
      if (other == null) {
        return;
      }
      clearCurseMap_.MergeFrom(other.clearCurseMap_);
      if (other.IsClearAll != false) {
        IsClearAll = other.IsClearAll;
      }
      if (other.CardId != 0) {
        CardId = other.CardId;
      }
      if (other.IsCurseAllClear != false) {
        IsCurseAllClear = other.IsCurseAllClear;
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
            IsCurseAllClear = input.ReadBool();
            break;
          }
          case 64: {
            CardId = input.ReadUInt32();
            break;
          }
          case 82: {
            clearCurseMap_.AddEntriesFrom(input, _map_clearCurseMap_codec);
            break;
          }
          case 88: {
            IsClearAll = input.ReadBool();
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
            IsCurseAllClear = input.ReadBool();
            break;
          }
          case 64: {
            CardId = input.ReadUInt32();
            break;
          }
          case 82: {
            clearCurseMap_.AddEntriesFrom(ref input, _map_clearCurseMap_codec);
            break;
          }
          case 88: {
            IsClearAll = input.ReadBool();
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
