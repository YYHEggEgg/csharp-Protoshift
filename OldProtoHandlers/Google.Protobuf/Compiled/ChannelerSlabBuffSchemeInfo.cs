// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabBuffSchemeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ChannelerSlabBuffSchemeInfo.proto</summary>
  public static partial class ChannelerSlabBuffSchemeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChannelerSlabBuffSchemeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelerSlabBuffSchemeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDaGFubmVsZXJTbGFiQnVmZlNjaGVtZUluZm8ucHJvdG8itQEKG0NoYW5u",
            "ZWxlclNsYWJCdWZmU2NoZW1lSW5mbxI7CghzbG90X21hcBgJIAMoCzIpLkNo",
            "YW5uZWxlclNsYWJCdWZmU2NoZW1lSW5mby5TbG90TWFwRW50cnkSFAoMdG90",
            "YWxfZW5lcmd5GA0gASgNEhMKC3NlbGZfZW5lcmd5GA8gASgNGi4KDFNsb3RN",
            "YXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQgyqAglP",
            "bGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ChannelerSlabBuffSchemeInfo), global::OldProtos.ChannelerSlabBuffSchemeInfo.Parser, new[]{ "SlotMap", "TotalEnergy", "SelfEnergy" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChannelerSlabBuffSchemeInfo : pb::IMessage<ChannelerSlabBuffSchemeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelerSlabBuffSchemeInfo> _parser = new pb::MessageParser<ChannelerSlabBuffSchemeInfo>(() => new ChannelerSlabBuffSchemeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelerSlabBuffSchemeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ChannelerSlabBuffSchemeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabBuffSchemeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabBuffSchemeInfo(ChannelerSlabBuffSchemeInfo other) : this() {
      slotMap_ = other.slotMap_.Clone();
      totalEnergy_ = other.totalEnergy_;
      selfEnergy_ = other.selfEnergy_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabBuffSchemeInfo Clone() {
      return new ChannelerSlabBuffSchemeInfo(this);
    }

    /// <summary>Field number for the "slot_map" field.</summary>
    public const int SlotMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, uint>.Codec _map_slotMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 74);
    private readonly pbc::MapField<uint, uint> slotMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SlotMap {
      get { return slotMap_; }
    }

    /// <summary>Field number for the "total_energy" field.</summary>
    public const int TotalEnergyFieldNumber = 13;
    private uint totalEnergy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalEnergy {
      get { return totalEnergy_; }
      set {
        totalEnergy_ = value;
      }
    }

    /// <summary>Field number for the "self_energy" field.</summary>
    public const int SelfEnergyFieldNumber = 15;
    private uint selfEnergy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelfEnergy {
      get { return selfEnergy_; }
      set {
        selfEnergy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelerSlabBuffSchemeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelerSlabBuffSchemeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!SlotMap.Equals(other.SlotMap)) return false;
      if (TotalEnergy != other.TotalEnergy) return false;
      if (SelfEnergy != other.SelfEnergy) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= SlotMap.GetHashCode();
      if (TotalEnergy != 0) hash ^= TotalEnergy.GetHashCode();
      if (SelfEnergy != 0) hash ^= SelfEnergy.GetHashCode();
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
      slotMap_.WriteTo(output, _map_slotMap_codec);
      if (TotalEnergy != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalEnergy);
      }
      if (SelfEnergy != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelfEnergy);
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
      slotMap_.WriteTo(ref output, _map_slotMap_codec);
      if (TotalEnergy != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalEnergy);
      }
      if (SelfEnergy != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelfEnergy);
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
      size += slotMap_.CalculateSize(_map_slotMap_codec);
      if (TotalEnergy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalEnergy);
      }
      if (SelfEnergy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelfEnergy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelerSlabBuffSchemeInfo other) {
      if (other == null) {
        return;
      }
      slotMap_.MergeFrom(other.slotMap_);
      if (other.TotalEnergy != 0) {
        TotalEnergy = other.TotalEnergy;
      }
      if (other.SelfEnergy != 0) {
        SelfEnergy = other.SelfEnergy;
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
          case 74: {
            slotMap_.AddEntriesFrom(input, _map_slotMap_codec);
            break;
          }
          case 104: {
            TotalEnergy = input.ReadUInt32();
            break;
          }
          case 120: {
            SelfEnergy = input.ReadUInt32();
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
          case 74: {
            slotMap_.AddEntriesFrom(ref input, _map_slotMap_codec);
            break;
          }
          case 104: {
            TotalEnergy = input.ReadUInt32();
            break;
          }
          case 120: {
            SelfEnergy = input.ReadUInt32();
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
