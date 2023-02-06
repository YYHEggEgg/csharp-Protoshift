// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonsterSummonTagNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MonsterSummonTagNotify.proto</summary>
public static partial class MonsterSummonTagNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for MonsterSummonTagNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MonsterSummonTagNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxNb25zdGVyU3VtbW9uVGFnTm90aWZ5LnByb3RvIqsBChZNb25zdGVyU3Vt",
          "bW9uVGFnTm90aWZ5EkEKDnN1bW1vbl90YWdfbWFwGAEgAygLMikuTW9uc3Rl",
          "clN1bW1vblRhZ05vdGlmeS5TdW1tb25UYWdNYXBFbnRyeRIZChFtb25zdGVy",
          "X2VudGl0eV9pZBgIIAEoDRozChFTdW1tb25UYWdNYXBFbnRyeRILCgNrZXkY",
          "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh4KHGVtdS5ncmFzc2N1dHRlci5u",
          "ZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MonsterSummonTagNotify), global::MonsterSummonTagNotify.Parser, new[]{ "SummonTagMap", "MonsterEntityId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 1372
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class MonsterSummonTagNotify : pb::IMessage<MonsterSummonTagNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MonsterSummonTagNotify> _parser = new pb::MessageParser<MonsterSummonTagNotify>(() => new MonsterSummonTagNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MonsterSummonTagNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MonsterSummonTagNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MonsterSummonTagNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MonsterSummonTagNotify(MonsterSummonTagNotify other) : this() {
    summonTagMap_ = other.summonTagMap_.Clone();
    monsterEntityId_ = other.monsterEntityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MonsterSummonTagNotify Clone() {
    return new MonsterSummonTagNotify(this);
  }

  /// <summary>Field number for the "summon_tag_map" field.</summary>
  public const int SummonTagMapFieldNumber = 1;
  private static readonly pbc::MapField<uint, uint>.Codec _map_summonTagMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 10);
  private readonly pbc::MapField<uint, uint> summonTagMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> SummonTagMap {
    get { return summonTagMap_; }
  }

  /// <summary>Field number for the "monster_entity_id" field.</summary>
  public const int MonsterEntityIdFieldNumber = 8;
  private uint monsterEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MonsterEntityId {
    get { return monsterEntityId_; }
    set {
      monsterEntityId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MonsterSummonTagNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MonsterSummonTagNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!SummonTagMap.Equals(other.SummonTagMap)) return false;
    if (MonsterEntityId != other.MonsterEntityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= SummonTagMap.GetHashCode();
    if (MonsterEntityId != 0) hash ^= MonsterEntityId.GetHashCode();
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
    summonTagMap_.WriteTo(output, _map_summonTagMap_codec);
    if (MonsterEntityId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(MonsterEntityId);
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
    summonTagMap_.WriteTo(ref output, _map_summonTagMap_codec);
    if (MonsterEntityId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(MonsterEntityId);
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
    size += summonTagMap_.CalculateSize(_map_summonTagMap_codec);
    if (MonsterEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterEntityId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MonsterSummonTagNotify other) {
    if (other == null) {
      return;
    }
    summonTagMap_.Add(other.summonTagMap_);
    if (other.MonsterEntityId != 0) {
      MonsterEntityId = other.MonsterEntityId;
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
        case 10: {
          summonTagMap_.AddEntriesFrom(input, _map_summonTagMap_codec);
          break;
        }
        case 64: {
          MonsterEntityId = input.ReadUInt32();
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
        case 10: {
          summonTagMap_.AddEntriesFrom(ref input, _map_summonTagMap_codec);
          break;
        }
        case 64: {
          MonsterEntityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
