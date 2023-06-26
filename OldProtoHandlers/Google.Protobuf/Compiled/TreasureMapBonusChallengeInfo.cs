// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureMapBonusChallengeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from TreasureMapBonusChallengeInfo.proto</summary>
  public static partial class TreasureMapBonusChallengeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureMapBonusChallengeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureMapBonusChallengeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNUcmVhc3VyZU1hcEJvbnVzQ2hhbGxlbmdlSW5mby5wcm90byLmAQodVHJl",
            "YXN1cmVNYXBCb251c0NoYWxsZW5nZUluZm8SDwoHaXNfZG9uZRgFIAEoCBIR",
            "Cgljb25maWdfaWQYCiABKA0SEQoJaXNfYWN0aXZlGAEgASgIEkUKDGZyYWdt",
            "ZW50X21hcBgMIAMoCzIvLlRyZWFzdXJlTWFwQm9udXNDaGFsbGVuZ2VJbmZv",
            "LkZyYWdtZW50TWFwRW50cnkSEwoLc29sdXRpb25faWQYCCABKA0aMgoQRnJh",
            "Z21lbnRNYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKAg6AjgB",
            "QgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.TreasureMapBonusChallengeInfo), global::OldProtos.TreasureMapBonusChallengeInfo.Parser, new[]{ "IsDone", "ConfigId", "IsActive", "FragmentMap", "SolutionId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TreasureMapBonusChallengeInfo : pb::IMessage<TreasureMapBonusChallengeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureMapBonusChallengeInfo> _parser = new pb::MessageParser<TreasureMapBonusChallengeInfo>(() => new TreasureMapBonusChallengeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureMapBonusChallengeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.TreasureMapBonusChallengeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapBonusChallengeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapBonusChallengeInfo(TreasureMapBonusChallengeInfo other) : this() {
      isDone_ = other.isDone_;
      configId_ = other.configId_;
      isActive_ = other.isActive_;
      fragmentMap_ = other.fragmentMap_.Clone();
      solutionId_ = other.solutionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapBonusChallengeInfo Clone() {
      return new TreasureMapBonusChallengeInfo(this);
    }

    /// <summary>Field number for the "is_done" field.</summary>
    public const int IsDoneFieldNumber = 5;
    private bool isDone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDone {
      get { return isDone_; }
      set {
        isDone_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 10;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "is_active" field.</summary>
    public const int IsActiveFieldNumber = 1;
    private bool isActive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsActive {
      get { return isActive_; }
      set {
        isActive_ = value;
      }
    }

    /// <summary>Field number for the "fragment_map" field.</summary>
    public const int FragmentMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, bool>.Codec _map_fragmentMap_codec
        = new pbc::MapField<uint, bool>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForBool(16, false), 98);
    private readonly pbc::MapField<uint, bool> fragmentMap_ = new pbc::MapField<uint, bool>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, bool> FragmentMap {
      get { return fragmentMap_; }
    }

    /// <summary>Field number for the "solution_id" field.</summary>
    public const int SolutionIdFieldNumber = 8;
    private uint solutionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SolutionId {
      get { return solutionId_; }
      set {
        solutionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureMapBonusChallengeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureMapBonusChallengeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsDone != other.IsDone) return false;
      if (ConfigId != other.ConfigId) return false;
      if (IsActive != other.IsActive) return false;
      if (!FragmentMap.Equals(other.FragmentMap)) return false;
      if (SolutionId != other.SolutionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsDone != false) hash ^= IsDone.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (IsActive != false) hash ^= IsActive.GetHashCode();
      hash ^= FragmentMap.GetHashCode();
      if (SolutionId != 0) hash ^= SolutionId.GetHashCode();
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
      if (IsActive != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsActive);
      }
      if (IsDone != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDone);
      }
      if (SolutionId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SolutionId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ConfigId);
      }
      fragmentMap_.WriteTo(output, _map_fragmentMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsActive != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsActive);
      }
      if (IsDone != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDone);
      }
      if (SolutionId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SolutionId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ConfigId);
      }
      fragmentMap_.WriteTo(ref output, _map_fragmentMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsDone != false) {
        size += 1 + 1;
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (IsActive != false) {
        size += 1 + 1;
      }
      size += fragmentMap_.CalculateSize(_map_fragmentMap_codec);
      if (SolutionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SolutionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureMapBonusChallengeInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsDone != false) {
        IsDone = other.IsDone;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.IsActive != false) {
        IsActive = other.IsActive;
      }
      fragmentMap_.MergeFrom(other.fragmentMap_);
      if (other.SolutionId != 0) {
        SolutionId = other.SolutionId;
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
            IsActive = input.ReadBool();
            break;
          }
          case 40: {
            IsDone = input.ReadBool();
            break;
          }
          case 64: {
            SolutionId = input.ReadUInt32();
            break;
          }
          case 80: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 98: {
            fragmentMap_.AddEntriesFrom(input, _map_fragmentMap_codec);
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
            IsActive = input.ReadBool();
            break;
          }
          case 40: {
            IsDone = input.ReadBool();
            break;
          }
          case 64: {
            SolutionId = input.ReadUInt32();
            break;
          }
          case 80: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 98: {
            fragmentMap_.AddEntriesFrom(ref input, _map_fragmentMap_codec);
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
