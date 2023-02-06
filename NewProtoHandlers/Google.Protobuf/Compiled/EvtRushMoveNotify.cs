// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtRushMoveNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EvtRushMoveNotify.proto</summary>
public static partial class EvtRushMoveNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for EvtRushMoveNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EvtRushMoveNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdFdnRSdXNoTW92ZU5vdGlmeS5wcm90bxoVRXZ0UnVzaE1vdmVJbmZvLnBy",
          "b3RvGhFGb3J3YXJkVHlwZS5wcm90byJlChFFdnRSdXNoTW92ZU5vdGlmeRIs",
          "ChJldnRfcnVzaF9tb3ZlX2luZm8YASABKAsyEC5FdnRSdXNoTW92ZUluZm8S",
          "IgoMZm9yd2FyZF90eXBlGAogASgOMgwuRm9yd2FyZFR5cGVCFgoUb3JnLnNv",
          "cmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::EvtRushMoveInfoReflection.Descriptor, global::ForwardTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EvtRushMoveNotify), global::EvtRushMoveNotify.Parser, new[]{ "EvtRushMoveInfo", "ForwardType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 339;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class EvtRushMoveNotify : pb::IMessage<EvtRushMoveNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EvtRushMoveNotify> _parser = new pb::MessageParser<EvtRushMoveNotify>(() => new EvtRushMoveNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EvtRushMoveNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EvtRushMoveNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtRushMoveNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtRushMoveNotify(EvtRushMoveNotify other) : this() {
    evtRushMoveInfo_ = other.evtRushMoveInfo_ != null ? other.evtRushMoveInfo_.Clone() : null;
    forwardType_ = other.forwardType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EvtRushMoveNotify Clone() {
    return new EvtRushMoveNotify(this);
  }

  /// <summary>Field number for the "evt_rush_move_info" field.</summary>
  public const int EvtRushMoveInfoFieldNumber = 1;
  private global::EvtRushMoveInfo evtRushMoveInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::EvtRushMoveInfo EvtRushMoveInfo {
    get { return evtRushMoveInfo_; }
    set {
      evtRushMoveInfo_ = value;
    }
  }

  /// <summary>Field number for the "forward_type" field.</summary>
  public const int ForwardTypeFieldNumber = 10;
  private global::ForwardType forwardType_ = global::ForwardType.Local;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ForwardType ForwardType {
    get { return forwardType_; }
    set {
      forwardType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EvtRushMoveNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EvtRushMoveNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(EvtRushMoveInfo, other.EvtRushMoveInfo)) return false;
    if (ForwardType != other.ForwardType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (evtRushMoveInfo_ != null) hash ^= EvtRushMoveInfo.GetHashCode();
    if (ForwardType != global::ForwardType.Local) hash ^= ForwardType.GetHashCode();
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
    if (evtRushMoveInfo_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(EvtRushMoveInfo);
    }
    if (ForwardType != global::ForwardType.Local) {
      output.WriteRawTag(80);
      output.WriteEnum((int) ForwardType);
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
    if (evtRushMoveInfo_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(EvtRushMoveInfo);
    }
    if (ForwardType != global::ForwardType.Local) {
      output.WriteRawTag(80);
      output.WriteEnum((int) ForwardType);
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
    if (evtRushMoveInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(EvtRushMoveInfo);
    }
    if (ForwardType != global::ForwardType.Local) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EvtRushMoveNotify other) {
    if (other == null) {
      return;
    }
    if (other.evtRushMoveInfo_ != null) {
      if (evtRushMoveInfo_ == null) {
        EvtRushMoveInfo = new global::EvtRushMoveInfo();
      }
      EvtRushMoveInfo.MergeFrom(other.EvtRushMoveInfo);
    }
    if (other.ForwardType != global::ForwardType.Local) {
      ForwardType = other.ForwardType;
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
          if (evtRushMoveInfo_ == null) {
            EvtRushMoveInfo = new global::EvtRushMoveInfo();
          }
          input.ReadMessage(EvtRushMoveInfo);
          break;
        }
        case 80: {
          ForwardType = (global::ForwardType) input.ReadEnum();
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
          if (evtRushMoveInfo_ == null) {
            EvtRushMoveInfo = new global::EvtRushMoveInfo();
          }
          input.ReadMessage(EvtRushMoveInfo);
          break;
        }
        case 80: {
          ForwardType = (global::ForwardType) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
