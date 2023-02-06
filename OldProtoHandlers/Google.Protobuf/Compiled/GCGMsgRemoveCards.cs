// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgRemoveCards.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGMsgRemoveCards.proto</summary>
public static partial class GCGMsgRemoveCardsReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGMsgRemoveCards.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGMsgRemoveCardsReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdHQ0dNc2dSZW1vdmVDYXJkcy5wcm90bxoPR0NHUmVhc29uLnByb3RvGhFH",
          "Q0dab25lVHlwZS5wcm90byJ6ChFHQ0dNc2dSZW1vdmVDYXJkcxIVCg1jb250",
          "cm9sbGVyX2lkGA8gASgNEhoKBHpvbmUYCiABKA4yDC5HQ0dab25lVHlwZRIa",
          "CgZyZWFzb24YBSABKA4yCi5HQ0dSZWFzb24SFgoOY2FyZF9ndWlkX2xpc3QY",
          "ASADKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGReasonReflection.Descriptor, global::GCGZoneTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGMsgRemoveCards), global::GCGMsgRemoveCards.Parser, new[]{ "ControllerId", "Zone", "Reason", "CardGuidList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGMsgRemoveCards : pb::IMessage<GCGMsgRemoveCards>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGMsgRemoveCards> _parser = new pb::MessageParser<GCGMsgRemoveCards>(() => new GCGMsgRemoveCards());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGMsgRemoveCards> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGMsgRemoveCardsReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgRemoveCards() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgRemoveCards(GCGMsgRemoveCards other) : this() {
    controllerId_ = other.controllerId_;
    zone_ = other.zone_;
    reason_ = other.reason_;
    cardGuidList_ = other.cardGuidList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGMsgRemoveCards Clone() {
    return new GCGMsgRemoveCards(this);
  }

  /// <summary>Field number for the "controller_id" field.</summary>
  public const int ControllerIdFieldNumber = 15;
  private uint controllerId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ControllerId {
    get { return controllerId_; }
    set {
      controllerId_ = value;
    }
  }

  /// <summary>Field number for the "zone" field.</summary>
  public const int ZoneFieldNumber = 10;
  private global::GCGZoneType zone_ = global::GCGZoneType.Invalid;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGZoneType Zone {
    get { return zone_; }
    set {
      zone_ = value;
    }
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 5;
  private global::GCGReason reason_ = global::GCGReason.Default;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "card_guid_list" field.</summary>
  public const int CardGuidListFieldNumber = 1;
  private static readonly pb::FieldCodec<uint> _repeated_cardGuidList_codec
      = pb::FieldCodec.ForUInt32(10);
  private readonly pbc::RepeatedField<uint> cardGuidList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> CardGuidList {
    get { return cardGuidList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGMsgRemoveCards);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGMsgRemoveCards other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ControllerId != other.ControllerId) return false;
    if (Zone != other.Zone) return false;
    if (Reason != other.Reason) return false;
    if(!cardGuidList_.Equals(other.cardGuidList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
    if (Zone != global::GCGZoneType.Invalid) hash ^= Zone.GetHashCode();
    if (Reason != global::GCGReason.Default) hash ^= Reason.GetHashCode();
    hash ^= cardGuidList_.GetHashCode();
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
    cardGuidList_.WriteTo(output, _repeated_cardGuidList_codec);
    if (Reason != global::GCGReason.Default) {
      output.WriteRawTag(40);
      output.WriteEnum((int) Reason);
    }
    if (Zone != global::GCGZoneType.Invalid) {
      output.WriteRawTag(80);
      output.WriteEnum((int) Zone);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(ControllerId);
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
    cardGuidList_.WriteTo(ref output, _repeated_cardGuidList_codec);
    if (Reason != global::GCGReason.Default) {
      output.WriteRawTag(40);
      output.WriteEnum((int) Reason);
    }
    if (Zone != global::GCGZoneType.Invalid) {
      output.WriteRawTag(80);
      output.WriteEnum((int) Zone);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(ControllerId);
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
    if (ControllerId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
    }
    if (Zone != global::GCGZoneType.Invalid) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Zone);
    }
    if (Reason != global::GCGReason.Default) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    size += cardGuidList_.CalculateSize(_repeated_cardGuidList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGMsgRemoveCards other) {
    if (other == null) {
      return;
    }
    if (other.ControllerId != 0) {
      ControllerId = other.ControllerId;
    }
    if (other.Zone != global::GCGZoneType.Invalid) {
      Zone = other.Zone;
    }
    if (other.Reason != global::GCGReason.Default) {
      Reason = other.Reason;
    }
    cardGuidList_.Add(other.cardGuidList_);
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
          cardGuidList_.AddEntriesFrom(input, _repeated_cardGuidList_codec);
          break;
        }
        case 40: {
          Reason = (global::GCGReason) input.ReadEnum();
          break;
        }
        case 80: {
          Zone = (global::GCGZoneType) input.ReadEnum();
          break;
        }
        case 120: {
          ControllerId = input.ReadUInt32();
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
          cardGuidList_.AddEntriesFrom(ref input, _repeated_cardGuidList_codec);
          break;
        }
        case 40: {
          Reason = (global::GCGReason) input.ReadEnum();
          break;
        }
        case 80: {
          Zone = (global::GCGZoneType) input.ReadEnum();
          break;
        }
        case 120: {
          ControllerId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
