// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerPropChangeReasonNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from PlayerPropChangeReasonNotify.proto</summary>
  public static partial class PlayerPropChangeReasonNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerPropChangeReasonNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerPropChangeReasonNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQbGF5ZXJQcm9wQ2hhbmdlUmVhc29uTm90aWZ5LnByb3RvGhZQcm9wQ2hh",
            "bmdlUmVhc29uLnByb3RvInoKHFBsYXllclByb3BDaGFuZ2VSZWFzb25Ob3Rp",
            "ZnkSEQoJcHJvcF90eXBlGAYgASgNEhEKCW9sZF92YWx1ZRgMIAEoAhIhCgZy",
            "ZWFzb24YASABKA4yES5Qcm9wQ2hhbmdlUmVhc29uEhEKCWN1cl92YWx1ZRgL",
            "IAEoAkIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.PropChangeReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.PlayerPropChangeReasonNotify), global::OldProtos.PlayerPropChangeReasonNotify.Parser, new[]{ "PropType", "OldValue", "Reason", "CurValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1299
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerPropChangeReasonNotify : pb::IMessage<PlayerPropChangeReasonNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerPropChangeReasonNotify> _parser = new pb::MessageParser<PlayerPropChangeReasonNotify>(() => new PlayerPropChangeReasonNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerPropChangeReasonNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.PlayerPropChangeReasonNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerPropChangeReasonNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerPropChangeReasonNotify(PlayerPropChangeReasonNotify other) : this() {
      propType_ = other.propType_;
      oldValue_ = other.oldValue_;
      reason_ = other.reason_;
      curValue_ = other.curValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerPropChangeReasonNotify Clone() {
      return new PlayerPropChangeReasonNotify(this);
    }

    /// <summary>Field number for the "prop_type" field.</summary>
    public const int PropTypeFieldNumber = 6;
    private uint propType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropType {
      get { return propType_; }
      set {
        propType_ = value;
      }
    }

    /// <summary>Field number for the "old_value" field.</summary>
    public const int OldValueFieldNumber = 12;
    private float oldValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float OldValue {
      get { return oldValue_; }
      set {
        oldValue_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 1;
    private global::OldProtos.PropChangeReason reason_ = global::OldProtos.PropChangeReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.PropChangeReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "cur_value" field.</summary>
    public const int CurValueFieldNumber = 11;
    private float curValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CurValue {
      get { return curValue_; }
      set {
        curValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerPropChangeReasonNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerPropChangeReasonNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PropType != other.PropType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(OldValue, other.OldValue)) return false;
      if (Reason != other.Reason) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CurValue, other.CurValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PropType != 0) hash ^= PropType.GetHashCode();
      if (OldValue != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(OldValue);
      if (Reason != global::OldProtos.PropChangeReason.None) hash ^= Reason.GetHashCode();
      if (CurValue != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CurValue);
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
      if (Reason != global::OldProtos.PropChangeReason.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      if (PropType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PropType);
      }
      if (CurValue != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(CurValue);
      }
      if (OldValue != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(OldValue);
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
      if (Reason != global::OldProtos.PropChangeReason.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      if (PropType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PropType);
      }
      if (CurValue != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(CurValue);
      }
      if (OldValue != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(OldValue);
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
      if (PropType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropType);
      }
      if (OldValue != 0F) {
        size += 1 + 4;
      }
      if (Reason != global::OldProtos.PropChangeReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (CurValue != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerPropChangeReasonNotify other) {
      if (other == null) {
        return;
      }
      if (other.PropType != 0) {
        PropType = other.PropType;
      }
      if (other.OldValue != 0F) {
        OldValue = other.OldValue;
      }
      if (other.Reason != global::OldProtos.PropChangeReason.None) {
        Reason = other.Reason;
      }
      if (other.CurValue != 0F) {
        CurValue = other.CurValue;
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
            Reason = (global::OldProtos.PropChangeReason) input.ReadEnum();
            break;
          }
          case 48: {
            PropType = input.ReadUInt32();
            break;
          }
          case 93: {
            CurValue = input.ReadFloat();
            break;
          }
          case 101: {
            OldValue = input.ReadFloat();
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
            Reason = (global::OldProtos.PropChangeReason) input.ReadEnum();
            break;
          }
          case 48: {
            PropType = input.ReadUInt32();
            break;
          }
          case 93: {
            CurValue = input.ReadFloat();
            break;
          }
          case 101: {
            OldValue = input.ReadFloat();
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
