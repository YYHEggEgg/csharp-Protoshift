// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGPlayerField.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGPlayerField.proto</summary>
public static partial class GCGPlayerFieldReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGPlayerField.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGPlayerFieldReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChRHQ0dQbGF5ZXJGaWVsZC5wcm90bxoVR0NHRGljZVNpZGVUeXBlLnByb3Rv",
          "GhVHQ0dQVkVJbnRlbnRpb24ucHJvdG8aGUdDR1dhaXRpbmdDaGFyYWN0ZXIu",
          "cHJvdG8aDUdDR1pvbmUucHJvdG8i8AQKDkdDR1BsYXllckZpZWxkEjsKD21v",
          "ZGlmeV96b25lX21hcBgCIAMoCzIiLkdDR1BsYXllckZpZWxkLk1vZGlmeVpv",
          "bmVNYXBFbnRyeRIaChFjdXJfd2FpdGluZ19pbmRleBj/AiABKA0SHQoLc3Vt",
          "bW9uX3pvbmUYASABKAsyCC5HQ0dab25lEhUKDWZpZWxkX3Nob3dfaWQYCCAB",
          "KA0SGQoRY2FyZF9iYWNrX3Nob3dfaWQYDCABKA0SEgoKZGljZV9jb3VudBgD",
          "IAEoDRIVCg1jb250cm9sbGVyX2lkGAogASgNEh8KDW9uX3N0YWdlX3pvbmUY",
          "DiABKAsyCC5HQ0dab25lEhEKCWlzX3Bhc3NlZBgHIAEoCBIgCg5jaGFyYWN0",
          "ZXJfem9uZRgFIAEoCzIILkdDR1pvbmUSHwoXb25fc3RhZ2VfY2hhcmFjdGVy",
          "X2d1aWQYBiABKA0SHQoLYXNzaXN0X3pvbmUYDyABKAsyCC5HQ0dab25lEhUK",
          "DWRlY2tfY2FyZF9udW0YDSABKA0SKAoOZGljZV9zaWRlX2xpc3QYCyADKA4y",
          "EC5HQ0dEaWNlU2lkZVR5cGUSGwoJaGFuZF96b25lGAkgASgLMgguR0NHWm9u",
          "ZRIpCg5pbnRlbnRpb25fbGlzdBioCSADKAsyEC5HQ0dQVkVJbnRlbnRpb24S",
          "KgoMd2FpdGluZ19saXN0GAQgAygLMhQuR0NHV2FpdGluZ0NoYXJhY3Rlcho+",
          "ChJNb2RpZnlab25lTWFwRW50cnkSCwoDa2V5GAEgASgNEhcKBXZhbHVlGAIg",
          "ASgLMgguR0NHWm9uZToCOAFCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRw",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGDiceSideTypeReflection.Descriptor, global::GCGPVEIntentionReflection.Descriptor, global::GCGWaitingCharacterReflection.Descriptor, global::GCGZoneReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGPlayerField), global::GCGPlayerField.Parser, new[]{ "ModifyZoneMap", "CurWaitingIndex", "SummonZone", "FieldShowId", "CardBackShowId", "DiceCount", "ControllerId", "OnStageZone", "IsPassed", "CharacterZone", "OnStageCharacterGuid", "AssistZone", "DeckCardNum", "DiceSideList", "HandZone", "IntentionList", "WaitingList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGPlayerField : pb::IMessage<GCGPlayerField>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGPlayerField> _parser = new pb::MessageParser<GCGPlayerField>(() => new GCGPlayerField());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGPlayerField> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGPlayerFieldReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGPlayerField() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGPlayerField(GCGPlayerField other) : this() {
    modifyZoneMap_ = other.modifyZoneMap_.Clone();
    curWaitingIndex_ = other.curWaitingIndex_;
    summonZone_ = other.summonZone_ != null ? other.summonZone_.Clone() : null;
    fieldShowId_ = other.fieldShowId_;
    cardBackShowId_ = other.cardBackShowId_;
    diceCount_ = other.diceCount_;
    controllerId_ = other.controllerId_;
    onStageZone_ = other.onStageZone_ != null ? other.onStageZone_.Clone() : null;
    isPassed_ = other.isPassed_;
    characterZone_ = other.characterZone_ != null ? other.characterZone_.Clone() : null;
    onStageCharacterGuid_ = other.onStageCharacterGuid_;
    assistZone_ = other.assistZone_ != null ? other.assistZone_.Clone() : null;
    deckCardNum_ = other.deckCardNum_;
    diceSideList_ = other.diceSideList_.Clone();
    handZone_ = other.handZone_ != null ? other.handZone_.Clone() : null;
    intentionList_ = other.intentionList_.Clone();
    waitingList_ = other.waitingList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGPlayerField Clone() {
    return new GCGPlayerField(this);
  }

  /// <summary>Field number for the "modify_zone_map" field.</summary>
  public const int ModifyZoneMapFieldNumber = 2;
  private static readonly pbc::MapField<uint, global::GCGZone>.Codec _map_modifyZoneMap_codec
      = new pbc::MapField<uint, global::GCGZone>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::GCGZone.Parser), 18);
  private readonly pbc::MapField<uint, global::GCGZone> modifyZoneMap_ = new pbc::MapField<uint, global::GCGZone>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::GCGZone> ModifyZoneMap {
    get { return modifyZoneMap_; }
  }

  /// <summary>Field number for the "cur_waiting_index" field.</summary>
  public const int CurWaitingIndexFieldNumber = 383;
  private uint curWaitingIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurWaitingIndex {
    get { return curWaitingIndex_; }
    set {
      curWaitingIndex_ = value;
    }
  }

  /// <summary>Field number for the "summon_zone" field.</summary>
  public const int SummonZoneFieldNumber = 1;
  private global::GCGZone summonZone_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGZone SummonZone {
    get { return summonZone_; }
    set {
      summonZone_ = value;
    }
  }

  /// <summary>Field number for the "field_show_id" field.</summary>
  public const int FieldShowIdFieldNumber = 8;
  private uint fieldShowId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FieldShowId {
    get { return fieldShowId_; }
    set {
      fieldShowId_ = value;
    }
  }

  /// <summary>Field number for the "card_back_show_id" field.</summary>
  public const int CardBackShowIdFieldNumber = 12;
  private uint cardBackShowId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CardBackShowId {
    get { return cardBackShowId_; }
    set {
      cardBackShowId_ = value;
    }
  }

  /// <summary>Field number for the "dice_count" field.</summary>
  public const int DiceCountFieldNumber = 3;
  private uint diceCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DiceCount {
    get { return diceCount_; }
    set {
      diceCount_ = value;
    }
  }

  /// <summary>Field number for the "controller_id" field.</summary>
  public const int ControllerIdFieldNumber = 10;
  private uint controllerId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ControllerId {
    get { return controllerId_; }
    set {
      controllerId_ = value;
    }
  }

  /// <summary>Field number for the "on_stage_zone" field.</summary>
  public const int OnStageZoneFieldNumber = 14;
  private global::GCGZone onStageZone_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGZone OnStageZone {
    get { return onStageZone_; }
    set {
      onStageZone_ = value;
    }
  }

  /// <summary>Field number for the "is_passed" field.</summary>
  public const int IsPassedFieldNumber = 7;
  private bool isPassed_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsPassed {
    get { return isPassed_; }
    set {
      isPassed_ = value;
    }
  }

  /// <summary>Field number for the "character_zone" field.</summary>
  public const int CharacterZoneFieldNumber = 5;
  private global::GCGZone characterZone_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGZone CharacterZone {
    get { return characterZone_; }
    set {
      characterZone_ = value;
    }
  }

  /// <summary>Field number for the "on_stage_character_guid" field.</summary>
  public const int OnStageCharacterGuidFieldNumber = 6;
  private uint onStageCharacterGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OnStageCharacterGuid {
    get { return onStageCharacterGuid_; }
    set {
      onStageCharacterGuid_ = value;
    }
  }

  /// <summary>Field number for the "assist_zone" field.</summary>
  public const int AssistZoneFieldNumber = 15;
  private global::GCGZone assistZone_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGZone AssistZone {
    get { return assistZone_; }
    set {
      assistZone_ = value;
    }
  }

  /// <summary>Field number for the "deck_card_num" field.</summary>
  public const int DeckCardNumFieldNumber = 13;
  private uint deckCardNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DeckCardNum {
    get { return deckCardNum_; }
    set {
      deckCardNum_ = value;
    }
  }

  /// <summary>Field number for the "dice_side_list" field.</summary>
  public const int DiceSideListFieldNumber = 11;
  private static readonly pb::FieldCodec<global::GCGDiceSideType> _repeated_diceSideList_codec
      = pb::FieldCodec.ForEnum(90, x => (int) x, x => (global::GCGDiceSideType) x);
  private readonly pbc::RepeatedField<global::GCGDiceSideType> diceSideList_ = new pbc::RepeatedField<global::GCGDiceSideType>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGDiceSideType> DiceSideList {
    get { return diceSideList_; }
  }

  /// <summary>Field number for the "hand_zone" field.</summary>
  public const int HandZoneFieldNumber = 9;
  private global::GCGZone handZone_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGZone HandZone {
    get { return handZone_; }
    set {
      handZone_ = value;
    }
  }

  /// <summary>Field number for the "intention_list" field.</summary>
  public const int IntentionListFieldNumber = 1192;
  private static readonly pb::FieldCodec<global::GCGPVEIntention> _repeated_intentionList_codec
      = pb::FieldCodec.ForMessage(9538, global::GCGPVEIntention.Parser);
  private readonly pbc::RepeatedField<global::GCGPVEIntention> intentionList_ = new pbc::RepeatedField<global::GCGPVEIntention>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGPVEIntention> IntentionList {
    get { return intentionList_; }
  }

  /// <summary>Field number for the "waiting_list" field.</summary>
  public const int WaitingListFieldNumber = 4;
  private static readonly pb::FieldCodec<global::GCGWaitingCharacter> _repeated_waitingList_codec
      = pb::FieldCodec.ForMessage(34, global::GCGWaitingCharacter.Parser);
  private readonly pbc::RepeatedField<global::GCGWaitingCharacter> waitingList_ = new pbc::RepeatedField<global::GCGWaitingCharacter>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGWaitingCharacter> WaitingList {
    get { return waitingList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGPlayerField);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGPlayerField other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!ModifyZoneMap.Equals(other.ModifyZoneMap)) return false;
    if (CurWaitingIndex != other.CurWaitingIndex) return false;
    if (!object.Equals(SummonZone, other.SummonZone)) return false;
    if (FieldShowId != other.FieldShowId) return false;
    if (CardBackShowId != other.CardBackShowId) return false;
    if (DiceCount != other.DiceCount) return false;
    if (ControllerId != other.ControllerId) return false;
    if (!object.Equals(OnStageZone, other.OnStageZone)) return false;
    if (IsPassed != other.IsPassed) return false;
    if (!object.Equals(CharacterZone, other.CharacterZone)) return false;
    if (OnStageCharacterGuid != other.OnStageCharacterGuid) return false;
    if (!object.Equals(AssistZone, other.AssistZone)) return false;
    if (DeckCardNum != other.DeckCardNum) return false;
    if(!diceSideList_.Equals(other.diceSideList_)) return false;
    if (!object.Equals(HandZone, other.HandZone)) return false;
    if(!intentionList_.Equals(other.intentionList_)) return false;
    if(!waitingList_.Equals(other.waitingList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= ModifyZoneMap.GetHashCode();
    if (CurWaitingIndex != 0) hash ^= CurWaitingIndex.GetHashCode();
    if (summonZone_ != null) hash ^= SummonZone.GetHashCode();
    if (FieldShowId != 0) hash ^= FieldShowId.GetHashCode();
    if (CardBackShowId != 0) hash ^= CardBackShowId.GetHashCode();
    if (DiceCount != 0) hash ^= DiceCount.GetHashCode();
    if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
    if (onStageZone_ != null) hash ^= OnStageZone.GetHashCode();
    if (IsPassed != false) hash ^= IsPassed.GetHashCode();
    if (characterZone_ != null) hash ^= CharacterZone.GetHashCode();
    if (OnStageCharacterGuid != 0) hash ^= OnStageCharacterGuid.GetHashCode();
    if (assistZone_ != null) hash ^= AssistZone.GetHashCode();
    if (DeckCardNum != 0) hash ^= DeckCardNum.GetHashCode();
    hash ^= diceSideList_.GetHashCode();
    if (handZone_ != null) hash ^= HandZone.GetHashCode();
    hash ^= intentionList_.GetHashCode();
    hash ^= waitingList_.GetHashCode();
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
    if (summonZone_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(SummonZone);
    }
    modifyZoneMap_.WriteTo(output, _map_modifyZoneMap_codec);
    if (DiceCount != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(DiceCount);
    }
    waitingList_.WriteTo(output, _repeated_waitingList_codec);
    if (characterZone_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(CharacterZone);
    }
    if (OnStageCharacterGuid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(OnStageCharacterGuid);
    }
    if (IsPassed != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsPassed);
    }
    if (FieldShowId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(FieldShowId);
    }
    if (handZone_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(HandZone);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(ControllerId);
    }
    diceSideList_.WriteTo(output, _repeated_diceSideList_codec);
    if (CardBackShowId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CardBackShowId);
    }
    if (DeckCardNum != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(DeckCardNum);
    }
    if (onStageZone_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(OnStageZone);
    }
    if (assistZone_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(AssistZone);
    }
    if (CurWaitingIndex != 0) {
      output.WriteRawTag(248, 23);
      output.WriteUInt32(CurWaitingIndex);
    }
    intentionList_.WriteTo(output, _repeated_intentionList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (summonZone_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(SummonZone);
    }
    modifyZoneMap_.WriteTo(ref output, _map_modifyZoneMap_codec);
    if (DiceCount != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(DiceCount);
    }
    waitingList_.WriteTo(ref output, _repeated_waitingList_codec);
    if (characterZone_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(CharacterZone);
    }
    if (OnStageCharacterGuid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(OnStageCharacterGuid);
    }
    if (IsPassed != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsPassed);
    }
    if (FieldShowId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(FieldShowId);
    }
    if (handZone_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(HandZone);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(ControllerId);
    }
    diceSideList_.WriteTo(ref output, _repeated_diceSideList_codec);
    if (CardBackShowId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CardBackShowId);
    }
    if (DeckCardNum != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(DeckCardNum);
    }
    if (onStageZone_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(OnStageZone);
    }
    if (assistZone_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(AssistZone);
    }
    if (CurWaitingIndex != 0) {
      output.WriteRawTag(248, 23);
      output.WriteUInt32(CurWaitingIndex);
    }
    intentionList_.WriteTo(ref output, _repeated_intentionList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += modifyZoneMap_.CalculateSize(_map_modifyZoneMap_codec);
    if (CurWaitingIndex != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(CurWaitingIndex);
    }
    if (summonZone_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SummonZone);
    }
    if (FieldShowId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FieldShowId);
    }
    if (CardBackShowId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardBackShowId);
    }
    if (DiceCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiceCount);
    }
    if (ControllerId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
    }
    if (onStageZone_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(OnStageZone);
    }
    if (IsPassed != false) {
      size += 1 + 1;
    }
    if (characterZone_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(CharacterZone);
    }
    if (OnStageCharacterGuid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OnStageCharacterGuid);
    }
    if (assistZone_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(AssistZone);
    }
    if (DeckCardNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DeckCardNum);
    }
    size += diceSideList_.CalculateSize(_repeated_diceSideList_codec);
    if (handZone_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HandZone);
    }
    size += intentionList_.CalculateSize(_repeated_intentionList_codec);
    size += waitingList_.CalculateSize(_repeated_waitingList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGPlayerField other) {
    if (other == null) {
      return;
    }
    modifyZoneMap_.Add(other.modifyZoneMap_);
    if (other.CurWaitingIndex != 0) {
      CurWaitingIndex = other.CurWaitingIndex;
    }
    if (other.summonZone_ != null) {
      if (summonZone_ == null) {
        SummonZone = new global::GCGZone();
      }
      SummonZone.MergeFrom(other.SummonZone);
    }
    if (other.FieldShowId != 0) {
      FieldShowId = other.FieldShowId;
    }
    if (other.CardBackShowId != 0) {
      CardBackShowId = other.CardBackShowId;
    }
    if (other.DiceCount != 0) {
      DiceCount = other.DiceCount;
    }
    if (other.ControllerId != 0) {
      ControllerId = other.ControllerId;
    }
    if (other.onStageZone_ != null) {
      if (onStageZone_ == null) {
        OnStageZone = new global::GCGZone();
      }
      OnStageZone.MergeFrom(other.OnStageZone);
    }
    if (other.IsPassed != false) {
      IsPassed = other.IsPassed;
    }
    if (other.characterZone_ != null) {
      if (characterZone_ == null) {
        CharacterZone = new global::GCGZone();
      }
      CharacterZone.MergeFrom(other.CharacterZone);
    }
    if (other.OnStageCharacterGuid != 0) {
      OnStageCharacterGuid = other.OnStageCharacterGuid;
    }
    if (other.assistZone_ != null) {
      if (assistZone_ == null) {
        AssistZone = new global::GCGZone();
      }
      AssistZone.MergeFrom(other.AssistZone);
    }
    if (other.DeckCardNum != 0) {
      DeckCardNum = other.DeckCardNum;
    }
    diceSideList_.Add(other.diceSideList_);
    if (other.handZone_ != null) {
      if (handZone_ == null) {
        HandZone = new global::GCGZone();
      }
      HandZone.MergeFrom(other.HandZone);
    }
    intentionList_.Add(other.intentionList_);
    waitingList_.Add(other.waitingList_);
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
          if (summonZone_ == null) {
            SummonZone = new global::GCGZone();
          }
          input.ReadMessage(SummonZone);
          break;
        }
        case 18: {
          modifyZoneMap_.AddEntriesFrom(input, _map_modifyZoneMap_codec);
          break;
        }
        case 24: {
          DiceCount = input.ReadUInt32();
          break;
        }
        case 34: {
          waitingList_.AddEntriesFrom(input, _repeated_waitingList_codec);
          break;
        }
        case 42: {
          if (characterZone_ == null) {
            CharacterZone = new global::GCGZone();
          }
          input.ReadMessage(CharacterZone);
          break;
        }
        case 48: {
          OnStageCharacterGuid = input.ReadUInt32();
          break;
        }
        case 56: {
          IsPassed = input.ReadBool();
          break;
        }
        case 64: {
          FieldShowId = input.ReadUInt32();
          break;
        }
        case 74: {
          if (handZone_ == null) {
            HandZone = new global::GCGZone();
          }
          input.ReadMessage(HandZone);
          break;
        }
        case 80: {
          ControllerId = input.ReadUInt32();
          break;
        }
        case 90:
        case 88: {
          diceSideList_.AddEntriesFrom(input, _repeated_diceSideList_codec);
          break;
        }
        case 96: {
          CardBackShowId = input.ReadUInt32();
          break;
        }
        case 104: {
          DeckCardNum = input.ReadUInt32();
          break;
        }
        case 114: {
          if (onStageZone_ == null) {
            OnStageZone = new global::GCGZone();
          }
          input.ReadMessage(OnStageZone);
          break;
        }
        case 122: {
          if (assistZone_ == null) {
            AssistZone = new global::GCGZone();
          }
          input.ReadMessage(AssistZone);
          break;
        }
        case 3064: {
          CurWaitingIndex = input.ReadUInt32();
          break;
        }
        case 9538: {
          intentionList_.AddEntriesFrom(input, _repeated_intentionList_codec);
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
          if (summonZone_ == null) {
            SummonZone = new global::GCGZone();
          }
          input.ReadMessage(SummonZone);
          break;
        }
        case 18: {
          modifyZoneMap_.AddEntriesFrom(ref input, _map_modifyZoneMap_codec);
          break;
        }
        case 24: {
          DiceCount = input.ReadUInt32();
          break;
        }
        case 34: {
          waitingList_.AddEntriesFrom(ref input, _repeated_waitingList_codec);
          break;
        }
        case 42: {
          if (characterZone_ == null) {
            CharacterZone = new global::GCGZone();
          }
          input.ReadMessage(CharacterZone);
          break;
        }
        case 48: {
          OnStageCharacterGuid = input.ReadUInt32();
          break;
        }
        case 56: {
          IsPassed = input.ReadBool();
          break;
        }
        case 64: {
          FieldShowId = input.ReadUInt32();
          break;
        }
        case 74: {
          if (handZone_ == null) {
            HandZone = new global::GCGZone();
          }
          input.ReadMessage(HandZone);
          break;
        }
        case 80: {
          ControllerId = input.ReadUInt32();
          break;
        }
        case 90:
        case 88: {
          diceSideList_.AddEntriesFrom(ref input, _repeated_diceSideList_codec);
          break;
        }
        case 96: {
          CardBackShowId = input.ReadUInt32();
          break;
        }
        case 104: {
          DeckCardNum = input.ReadUInt32();
          break;
        }
        case 114: {
          if (onStageZone_ == null) {
            OnStageZone = new global::GCGZone();
          }
          input.ReadMessage(OnStageZone);
          break;
        }
        case 122: {
          if (assistZone_ == null) {
            AssistZone = new global::GCGZone();
          }
          input.ReadMessage(AssistZone);
          break;
        }
        case 3064: {
          CurWaitingIndex = input.ReadUInt32();
          break;
        }
        case 9538: {
          intentionList_.AddEntriesFrom(ref input, _repeated_intentionList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
