// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueEffectRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from RogueEffectRecord.proto</summary>
  public static partial class RogueEffectRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueEffectRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueEffectRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSb2d1ZUVmZmVjdFJlY29yZC5wcm90byJfChFSb2d1ZUVmZmVjdFJlY29y",
            "ZBIRCglzb3VyY2VfaWQYCSABKA0SDgoGaXNfbmV3GAggASgIEg0KBWNvdW50",
            "GAMgASgNEhgKEGV4dHJhX3BhcmFtX2xpc3QYDyADKA1CDKoCCU5ld1Byb3Rv",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.RogueEffectRecord), global::NewProtos.RogueEffectRecord.Parser, new[]{ "SourceId", "IsNew", "Count", "ExtraParamList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueEffectRecord : pb::IMessage<RogueEffectRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueEffectRecord> _parser = new pb::MessageParser<RogueEffectRecord>(() => new RogueEffectRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueEffectRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.RogueEffectRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueEffectRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueEffectRecord(RogueEffectRecord other) : this() {
      sourceId_ = other.sourceId_;
      isNew_ = other.isNew_;
      count_ = other.count_;
      extraParamList_ = other.extraParamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueEffectRecord Clone() {
      return new RogueEffectRecord(this);
    }

    /// <summary>Field number for the "source_id" field.</summary>
    public const int SourceIdFieldNumber = 9;
    private uint sourceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceId {
      get { return sourceId_; }
      set {
        sourceId_ = value;
      }
    }

    /// <summary>Field number for the "is_new" field.</summary>
    public const int IsNewFieldNumber = 8;
    private bool isNew_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNew {
      get { return isNew_; }
      set {
        isNew_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 3;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "extra_param_list" field.</summary>
    public const int ExtraParamListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_extraParamList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> extraParamList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExtraParamList {
      get { return extraParamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueEffectRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueEffectRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceId != other.SourceId) return false;
      if (IsNew != other.IsNew) return false;
      if (Count != other.Count) return false;
      if(!extraParamList_.Equals(other.extraParamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceId != 0) hash ^= SourceId.GetHashCode();
      if (IsNew != false) hash ^= IsNew.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      hash ^= extraParamList_.GetHashCode();
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
      if (Count != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Count);
      }
      if (IsNew != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsNew);
      }
      if (SourceId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SourceId);
      }
      extraParamList_.WriteTo(output, _repeated_extraParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Count != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Count);
      }
      if (IsNew != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsNew);
      }
      if (SourceId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SourceId);
      }
      extraParamList_.WriteTo(ref output, _repeated_extraParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (SourceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceId);
      }
      if (IsNew != false) {
        size += 1 + 1;
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      size += extraParamList_.CalculateSize(_repeated_extraParamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueEffectRecord other) {
      if (other == null) {
        return;
      }
      if (other.SourceId != 0) {
        SourceId = other.SourceId;
      }
      if (other.IsNew != false) {
        IsNew = other.IsNew;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      extraParamList_.Add(other.extraParamList_);
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
            Count = input.ReadUInt32();
            break;
          }
          case 64: {
            IsNew = input.ReadBool();
            break;
          }
          case 72: {
            SourceId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            extraParamList_.AddEntriesFrom(input, _repeated_extraParamList_codec);
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
            Count = input.ReadUInt32();
            break;
          }
          case 64: {
            IsNew = input.ReadBool();
            break;
          }
          case 72: {
            SourceId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            extraParamList_.AddEntriesFrom(ref input, _repeated_extraParamList_codec);
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
