// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgModifyAdd.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GCGMsgModifyAdd.proto</summary>
  public static partial class GCGMsgModifyAddReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgModifyAdd.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgModifyAddReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHQ0dNc2dNb2RpZnlBZGQucHJvdG8aD0dDR1JlYXNvbi5wcm90byKCAQoP",
            "R0NHTXNnTW9kaWZ5QWRkEgsKA3BvcxgJIAEoDRIXCg9vd25lcl9jYXJkX2d1",
            "aWQYCiABKA0SFgoOY2FyZF9ndWlkX2xpc3QYDyADKA0SFQoNY29udHJvbGxl",
            "cl9pZBgOIAEoDRIaCgZyZWFzb24YCyABKA4yCi5HQ0dSZWFzb25CDKoCCU9s",
            "ZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.GCGReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GCGMsgModifyAdd), global::OldProtos.GCGMsgModifyAdd.Parser, new[]{ "Pos", "OwnerCardGuid", "CardGuidList", "ControllerId", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgModifyAdd : pb::IMessage<GCGMsgModifyAdd>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgModifyAdd> _parser = new pb::MessageParser<GCGMsgModifyAdd>(() => new GCGMsgModifyAdd());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgModifyAdd> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GCGMsgModifyAddReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyAdd() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyAdd(GCGMsgModifyAdd other) : this() {
      pos_ = other.pos_;
      ownerCardGuid_ = other.ownerCardGuid_;
      cardGuidList_ = other.cardGuidList_.Clone();
      controllerId_ = other.controllerId_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyAdd Clone() {
      return new GCGMsgModifyAdd(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 9;
    private uint pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "owner_card_guid" field.</summary>
    public const int OwnerCardGuidFieldNumber = 10;
    private uint ownerCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerCardGuid {
      get { return ownerCardGuid_; }
      set {
        ownerCardGuid_ = value;
      }
    }

    /// <summary>Field number for the "card_guid_list" field.</summary>
    public const int CardGuidListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_cardGuidList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> cardGuidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardGuidList {
      get { return cardGuidList_; }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 14;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 11;
    private global::OldProtos.GCGReason reason_ = global::OldProtos.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgModifyAdd);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgModifyAdd other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Pos != other.Pos) return false;
      if (OwnerCardGuid != other.OwnerCardGuid) return false;
      if(!cardGuidList_.Equals(other.cardGuidList_)) return false;
      if (ControllerId != other.ControllerId) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Pos != 0) hash ^= Pos.GetHashCode();
      if (OwnerCardGuid != 0) hash ^= OwnerCardGuid.GetHashCode();
      hash ^= cardGuidList_.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      if (Reason != global::OldProtos.GCGReason.Default) hash ^= Reason.GetHashCode();
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
      if (Pos != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Pos);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OwnerCardGuid);
      }
      if (Reason != global::OldProtos.GCGReason.Default) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ControllerId);
      }
      cardGuidList_.WriteTo(output, _repeated_cardGuidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Pos != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Pos);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OwnerCardGuid);
      }
      if (Reason != global::OldProtos.GCGReason.Default) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ControllerId);
      }
      cardGuidList_.WriteTo(ref output, _repeated_cardGuidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Pos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      if (OwnerCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerCardGuid);
      }
      size += cardGuidList_.CalculateSize(_repeated_cardGuidList_codec);
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (Reason != global::OldProtos.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgModifyAdd other) {
      if (other == null) {
        return;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      if (other.OwnerCardGuid != 0) {
        OwnerCardGuid = other.OwnerCardGuid;
      }
      cardGuidList_.Add(other.cardGuidList_);
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      if (other.Reason != global::OldProtos.GCGReason.Default) {
        Reason = other.Reason;
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
          case 72: {
            Pos = input.ReadUInt32();
            break;
          }
          case 80: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::OldProtos.GCGReason) input.ReadEnum();
            break;
          }
          case 112: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            cardGuidList_.AddEntriesFrom(input, _repeated_cardGuidList_codec);
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
          case 72: {
            Pos = input.ReadUInt32();
            break;
          }
          case 80: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::OldProtos.GCGReason) input.ReadEnum();
            break;
          }
          case 112: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            cardGuidList_.AddEntriesFrom(ref input, _repeated_cardGuidList_codec);
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
