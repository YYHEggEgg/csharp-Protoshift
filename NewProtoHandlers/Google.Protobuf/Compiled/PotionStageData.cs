// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PotionStageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PotionStageData.proto</summary>
  public static partial class PotionStageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PotionStageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PotionStageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQb3Rpb25TdGFnZURhdGEucHJvdG8aFVBvdGlvbkxldmVsRGF0YS5wcm90",
            "byKUAQoPUG90aW9uU3RhZ2VEYXRhEhsKE1VuazMzMDBfQk1FSEpIRkNQTUEY",
            "ByADKA0SGwoTVW5rMzMwMF9OTE1FUFBQTUNLSRgJIAMoDRIQCghzdGFnZV9p",
            "ZBgNIAEoDRIPCgdpc19vcGVuGAggASgIEiQKCmxldmVsX2xpc3QYCyADKAsy",
            "EC5Qb3Rpb25MZXZlbERhdGFCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.PotionLevelDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PotionStageData), global::NewProtos.PotionStageData.Parser, new[]{ "Unk3300BMEHJHFCPMA", "Unk3300NLMEPPPMCKI", "StageId", "IsOpen", "LevelList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PotionStageData : pb::IMessage<PotionStageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PotionStageData> _parser = new pb::MessageParser<PotionStageData>(() => new PotionStageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PotionStageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PotionStageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionStageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionStageData(PotionStageData other) : this() {
      unk3300BMEHJHFCPMA_ = other.unk3300BMEHJHFCPMA_.Clone();
      unk3300NLMEPPPMCKI_ = other.unk3300NLMEPPPMCKI_.Clone();
      stageId_ = other.stageId_;
      isOpen_ = other.isOpen_;
      levelList_ = other.levelList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionStageData Clone() {
      return new PotionStageData(this);
    }

    /// <summary>Field number for the "Unk3300_BMEHJHFCPMA" field.</summary>
    public const int Unk3300BMEHJHFCPMAFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300BMEHJHFCPMA_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> unk3300BMEHJHFCPMA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300BMEHJHFCPMA {
      get { return unk3300BMEHJHFCPMA_; }
    }

    /// <summary>Field number for the "Unk3300_NLMEPPPMCKI" field.</summary>
    public const int Unk3300NLMEPPPMCKIFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300NLMEPPPMCKI_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> unk3300NLMEPPPMCKI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300NLMEPPPMCKI {
      get { return unk3300NLMEPPPMCKI_; }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 13;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 8;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "level_list" field.</summary>
    public const int LevelListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::NewProtos.PotionLevelData> _repeated_levelList_codec
        = pb::FieldCodec.ForMessage(90, global::NewProtos.PotionLevelData.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.PotionLevelData> levelList_ = new pbc::RepeatedField<global::NewProtos.PotionLevelData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.PotionLevelData> LevelList {
      get { return levelList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PotionStageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PotionStageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk3300BMEHJHFCPMA_.Equals(other.unk3300BMEHJHFCPMA_)) return false;
      if(!unk3300NLMEPPPMCKI_.Equals(other.unk3300NLMEPPPMCKI_)) return false;
      if (StageId != other.StageId) return false;
      if (IsOpen != other.IsOpen) return false;
      if(!levelList_.Equals(other.levelList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk3300BMEHJHFCPMA_.GetHashCode();
      hash ^= unk3300NLMEPPPMCKI_.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      hash ^= levelList_.GetHashCode();
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
      unk3300BMEHJHFCPMA_.WriteTo(output, _repeated_unk3300BMEHJHFCPMA_codec);
      if (IsOpen != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsOpen);
      }
      unk3300NLMEPPPMCKI_.WriteTo(output, _repeated_unk3300NLMEPPPMCKI_codec);
      levelList_.WriteTo(output, _repeated_levelList_codec);
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
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
      unk3300BMEHJHFCPMA_.WriteTo(ref output, _repeated_unk3300BMEHJHFCPMA_codec);
      if (IsOpen != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsOpen);
      }
      unk3300NLMEPPPMCKI_.WriteTo(ref output, _repeated_unk3300NLMEPPPMCKI_codec);
      levelList_.WriteTo(ref output, _repeated_levelList_codec);
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
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
      size += unk3300BMEHJHFCPMA_.CalculateSize(_repeated_unk3300BMEHJHFCPMA_codec);
      size += unk3300NLMEPPPMCKI_.CalculateSize(_repeated_unk3300NLMEPPPMCKI_codec);
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      size += levelList_.CalculateSize(_repeated_levelList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PotionStageData other) {
      if (other == null) {
        return;
      }
      unk3300BMEHJHFCPMA_.Add(other.unk3300BMEHJHFCPMA_);
      unk3300NLMEPPPMCKI_.Add(other.unk3300NLMEPPPMCKI_);
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      levelList_.Add(other.levelList_);
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
          case 58:
          case 56: {
            unk3300BMEHJHFCPMA_.AddEntriesFrom(input, _repeated_unk3300BMEHJHFCPMA_codec);
            break;
          }
          case 64: {
            IsOpen = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            unk3300NLMEPPPMCKI_.AddEntriesFrom(input, _repeated_unk3300NLMEPPPMCKI_codec);
            break;
          }
          case 90: {
            levelList_.AddEntriesFrom(input, _repeated_levelList_codec);
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
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
          case 58:
          case 56: {
            unk3300BMEHJHFCPMA_.AddEntriesFrom(ref input, _repeated_unk3300BMEHJHFCPMA_codec);
            break;
          }
          case 64: {
            IsOpen = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            unk3300NLMEPPPMCKI_.AddEntriesFrom(ref input, _repeated_unk3300NLMEPPPMCKI_codec);
            break;
          }
          case 90: {
            levelList_.AddEntriesFrom(ref input, _repeated_levelList_codec);
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
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
