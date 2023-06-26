// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgAddDice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GCGMsgAddDice.proto</summary>
  public static partial class GCGMsgAddDiceReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgAddDice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgAddDiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNHQ0dNc2dBZGREaWNlLnByb3RvGhVHQ0dEaWNlU2lkZVR5cGUucHJvdG8a",
            "D0dDR1JlYXNvbi5wcm90byLNAgoNR0NHTXNnQWRkRGljZRI6Cg9iZWZvcmVf",
            "ZGljZV9tYXAYDCADKAsyIS5HQ0dNc2dBZGREaWNlLkJlZm9yZURpY2VNYXBF",
            "bnRyeRIUCgxjaGFuZ2VfY291bnQYASABKAUSLQoIZGljZV9tYXAYCCADKAsy",
            "Gy5HQ0dNc2dBZGREaWNlLkRpY2VNYXBFbnRyeRIaCgZyZWFzb24YBCABKA4y",
            "Ci5HQ0dSZWFzb24SFQoNY29udHJvbGxlcl9pZBgKIAEoDRpGChJCZWZvcmVE",
            "aWNlTWFwRW50cnkSCwoDa2V5GAEgASgNEh8KBXZhbHVlGAIgASgOMhAuR0NH",
            "RGljZVNpZGVUeXBlOgI4ARpACgxEaWNlTWFwRW50cnkSCwoDa2V5GAEgASgN",
            "Eh8KBXZhbHVlGAIgASgOMhAuR0NHRGljZVNpZGVUeXBlOgI4AUIMqgIJT2xk",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.GCGDiceSideTypeReflection.Descriptor, global::OldProtos.GCGReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GCGMsgAddDice), global::OldProtos.GCGMsgAddDice.Parser, new[]{ "BeforeDiceMap", "ChangeCount", "DiceMap", "Reason", "ControllerId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgAddDice : pb::IMessage<GCGMsgAddDice>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgAddDice> _parser = new pb::MessageParser<GCGMsgAddDice>(() => new GCGMsgAddDice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgAddDice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GCGMsgAddDiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddDice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddDice(GCGMsgAddDice other) : this() {
      beforeDiceMap_ = other.beforeDiceMap_.Clone();
      changeCount_ = other.changeCount_;
      diceMap_ = other.diceMap_.Clone();
      reason_ = other.reason_;
      controllerId_ = other.controllerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddDice Clone() {
      return new GCGMsgAddDice(this);
    }

    /// <summary>Field number for the "before_dice_map" field.</summary>
    public const int BeforeDiceMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, global::OldProtos.GCGDiceSideType>.Codec _map_beforeDiceMap_codec
        = new pbc::MapField<uint, global::OldProtos.GCGDiceSideType>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForEnum(16, x => (int) x, x => (global::OldProtos.GCGDiceSideType) x, global::OldProtos.GCGDiceSideType.Invalid), 98);
    private readonly pbc::MapField<uint, global::OldProtos.GCGDiceSideType> beforeDiceMap_ = new pbc::MapField<uint, global::OldProtos.GCGDiceSideType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.GCGDiceSideType> BeforeDiceMap {
      get { return beforeDiceMap_; }
    }

    /// <summary>Field number for the "change_count" field.</summary>
    public const int ChangeCountFieldNumber = 1;
    private int changeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ChangeCount {
      get { return changeCount_; }
      set {
        changeCount_ = value;
      }
    }

    /// <summary>Field number for the "dice_map" field.</summary>
    public const int DiceMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, global::OldProtos.GCGDiceSideType>.Codec _map_diceMap_codec
        = new pbc::MapField<uint, global::OldProtos.GCGDiceSideType>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForEnum(16, x => (int) x, x => (global::OldProtos.GCGDiceSideType) x, global::OldProtos.GCGDiceSideType.Invalid), 66);
    private readonly pbc::MapField<uint, global::OldProtos.GCGDiceSideType> diceMap_ = new pbc::MapField<uint, global::OldProtos.GCGDiceSideType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.GCGDiceSideType> DiceMap {
      get { return diceMap_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 4;
    private global::OldProtos.GCGReason reason_ = global::OldProtos.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgAddDice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgAddDice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!BeforeDiceMap.Equals(other.BeforeDiceMap)) return false;
      if (ChangeCount != other.ChangeCount) return false;
      if (!DiceMap.Equals(other.DiceMap)) return false;
      if (Reason != other.Reason) return false;
      if (ControllerId != other.ControllerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= BeforeDiceMap.GetHashCode();
      if (ChangeCount != 0) hash ^= ChangeCount.GetHashCode();
      hash ^= DiceMap.GetHashCode();
      if (Reason != global::OldProtos.GCGReason.Default) hash ^= Reason.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
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
      if (ChangeCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ChangeCount);
      }
      if (Reason != global::OldProtos.GCGReason.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Reason);
      }
      diceMap_.WriteTo(output, _map_diceMap_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ControllerId);
      }
      beforeDiceMap_.WriteTo(output, _map_beforeDiceMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChangeCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ChangeCount);
      }
      if (Reason != global::OldProtos.GCGReason.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Reason);
      }
      diceMap_.WriteTo(ref output, _map_diceMap_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ControllerId);
      }
      beforeDiceMap_.WriteTo(ref output, _map_beforeDiceMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += beforeDiceMap_.CalculateSize(_map_beforeDiceMap_codec);
      if (ChangeCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ChangeCount);
      }
      size += diceMap_.CalculateSize(_map_diceMap_codec);
      if (Reason != global::OldProtos.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgAddDice other) {
      if (other == null) {
        return;
      }
      beforeDiceMap_.MergeFrom(other.beforeDiceMap_);
      if (other.ChangeCount != 0) {
        ChangeCount = other.ChangeCount;
      }
      diceMap_.MergeFrom(other.diceMap_);
      if (other.Reason != global::OldProtos.GCGReason.Default) {
        Reason = other.Reason;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
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
            ChangeCount = input.ReadInt32();
            break;
          }
          case 32: {
            Reason = (global::OldProtos.GCGReason) input.ReadEnum();
            break;
          }
          case 66: {
            diceMap_.AddEntriesFrom(input, _map_diceMap_codec);
            break;
          }
          case 80: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 98: {
            beforeDiceMap_.AddEntriesFrom(input, _map_beforeDiceMap_codec);
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
            ChangeCount = input.ReadInt32();
            break;
          }
          case 32: {
            Reason = (global::OldProtos.GCGReason) input.ReadEnum();
            break;
          }
          case 66: {
            diceMap_.AddEntriesFrom(ref input, _map_diceMap_codec);
            break;
          }
          case 80: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 98: {
            beforeDiceMap_.AddEntriesFrom(ref input, _map_beforeDiceMap_codec);
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
