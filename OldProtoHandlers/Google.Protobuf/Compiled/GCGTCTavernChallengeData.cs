// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGTCTavernChallengeData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGTCTavernChallengeData.proto</summary>
public static partial class GCGTCTavernChallengeDataReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGTCTavernChallengeData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGTCTavernChallengeDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5HQ0dUQ1RhdmVybkNoYWxsZW5nZURhdGEucHJvdG8iTgoYR0NHVENUYXZl",
          "cm5DaGFsbGVuZ2VEYXRhEhwKFHVubG9ja19sZXZlbF9pZF9saXN0GAEgAygN",
          "EhQKDGNoYXJhY3Rlcl9pZBgIIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0",
          "Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGTCTavernChallengeData), global::GCGTCTavernChallengeData.Parser, new[]{ "UnlockLevelIdList", "CharacterId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGTCTavernChallengeData : pb::IMessage<GCGTCTavernChallengeData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGTCTavernChallengeData> _parser = new pb::MessageParser<GCGTCTavernChallengeData>(() => new GCGTCTavernChallengeData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGTCTavernChallengeData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGTCTavernChallengeDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGTCTavernChallengeData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGTCTavernChallengeData(GCGTCTavernChallengeData other) : this() {
    unlockLevelIdList_ = other.unlockLevelIdList_.Clone();
    characterId_ = other.characterId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGTCTavernChallengeData Clone() {
    return new GCGTCTavernChallengeData(this);
  }

  /// <summary>Field number for the "unlock_level_id_list" field.</summary>
  public const int UnlockLevelIdListFieldNumber = 1;
  private static readonly pb::FieldCodec<uint> _repeated_unlockLevelIdList_codec
      = pb::FieldCodec.ForUInt32(10);
  private readonly pbc::RepeatedField<uint> unlockLevelIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> UnlockLevelIdList {
    get { return unlockLevelIdList_; }
  }

  /// <summary>Field number for the "character_id" field.</summary>
  public const int CharacterIdFieldNumber = 8;
  private uint characterId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CharacterId {
    get { return characterId_; }
    set {
      characterId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGTCTavernChallengeData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGTCTavernChallengeData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!unlockLevelIdList_.Equals(other.unlockLevelIdList_)) return false;
    if (CharacterId != other.CharacterId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= unlockLevelIdList_.GetHashCode();
    if (CharacterId != 0) hash ^= CharacterId.GetHashCode();
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
    unlockLevelIdList_.WriteTo(output, _repeated_unlockLevelIdList_codec);
    if (CharacterId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CharacterId);
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
    unlockLevelIdList_.WriteTo(ref output, _repeated_unlockLevelIdList_codec);
    if (CharacterId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CharacterId);
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
    size += unlockLevelIdList_.CalculateSize(_repeated_unlockLevelIdList_codec);
    if (CharacterId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CharacterId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGTCTavernChallengeData other) {
    if (other == null) {
      return;
    }
    unlockLevelIdList_.Add(other.unlockLevelIdList_);
    if (other.CharacterId != 0) {
      CharacterId = other.CharacterId;
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
        case 10:
        case 8: {
          unlockLevelIdList_.AddEntriesFrom(input, _repeated_unlockLevelIdList_codec);
          break;
        }
        case 64: {
          CharacterId = input.ReadUInt32();
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
        case 10:
        case 8: {
          unlockLevelIdList_.AddEntriesFrom(ref input, _repeated_unlockLevelIdList_codec);
          break;
        }
        case 64: {
          CharacterId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
