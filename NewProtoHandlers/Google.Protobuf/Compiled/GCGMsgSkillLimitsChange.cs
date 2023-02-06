// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgSkillLimitsChange.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGMsgSkillLimitsChange.proto</summary>
public static partial class GCGMsgSkillLimitsChangeReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGMsgSkillLimitsChange.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGMsgSkillLimitsChangeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1HQ0dNc2dTa2lsbExpbWl0c0NoYW5nZS5wcm90bxocR0NHQ2FyZFNraWxs",
          "TGltaXRzSW5mby5wcm90byLBAQoXR0NHTXNnU2tpbGxMaW1pdHNDaGFuZ2US",
          "UQoWY2FyZF9saW1pdHNfY2hhbmdlX21hcBgDIAMoCzIxLkdDR01zZ1NraWxs",
          "TGltaXRzQ2hhbmdlLkNhcmRMaW1pdHNDaGFuZ2VNYXBFbnRyeRpTChhDYXJk",
          "TGltaXRzQ2hhbmdlTWFwRW50cnkSCwoDa2V5GAEgASgNEiYKBXZhbHVlGAIg",
          "ASgLMhcuR0NHQ2FyZFNraWxsTGltaXRzSW5mbzoCOAFCFgoUb3JnLnNvcmFw",
          "b2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGCardSkillLimitsInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGMsgSkillLimitsChange), global::GCGMsgSkillLimitsChange.Parser, new[]{ "CardLimitsChangeMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGMsgSkillLimitsChange : pb::IMessage<GCGMsgSkillLimitsChange>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGMsgSkillLimitsChange> _parser = new pb::MessageParser<GCGMsgSkillLimitsChange>(() => new GCGMsgSkillLimitsChange());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGMsgSkillLimitsChange> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGMsgSkillLimitsChangeReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgSkillLimitsChange() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgSkillLimitsChange(GCGMsgSkillLimitsChange other) : this() {
    cardLimitsChangeMap_ = other.cardLimitsChangeMap_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgSkillLimitsChange Clone() {
    return new GCGMsgSkillLimitsChange(this);
  }

  /// <summary>Field number for the "card_limits_change_map" field.</summary>
  public const int CardLimitsChangeMapFieldNumber = 3;
  private static readonly pbc::MapField<uint, global::GCGCardSkillLimitsInfo>.Codec _map_cardLimitsChangeMap_codec
      = new pbc::MapField<uint, global::GCGCardSkillLimitsInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::GCGCardSkillLimitsInfo.Parser), 26);
  private readonly pbc::MapField<uint, global::GCGCardSkillLimitsInfo> cardLimitsChangeMap_ = new pbc::MapField<uint, global::GCGCardSkillLimitsInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::GCGCardSkillLimitsInfo> CardLimitsChangeMap {
    get { return cardLimitsChangeMap_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGMsgSkillLimitsChange);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGMsgSkillLimitsChange other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!CardLimitsChangeMap.Equals(other.CardLimitsChangeMap)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= CardLimitsChangeMap.GetHashCode();
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
    cardLimitsChangeMap_.WriteTo(output, _map_cardLimitsChangeMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    cardLimitsChangeMap_.WriteTo(ref output, _map_cardLimitsChangeMap_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += cardLimitsChangeMap_.CalculateSize(_map_cardLimitsChangeMap_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGMsgSkillLimitsChange other) {
    if (other == null) {
      return;
    }
    cardLimitsChangeMap_.Add(other.cardLimitsChangeMap_);
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
        case 26: {
          cardLimitsChangeMap_.AddEntriesFrom(input, _map_cardLimitsChangeMap_codec);
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
        case 26: {
          cardLimitsChangeMap_.AddEntriesFrom(ref input, _map_cardLimitsChangeMap_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
