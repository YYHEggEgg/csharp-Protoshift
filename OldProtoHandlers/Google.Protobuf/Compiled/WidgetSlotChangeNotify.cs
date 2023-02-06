// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetSlotChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WidgetSlotChangeNotify.proto</summary>
public static partial class WidgetSlotChangeNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for WidgetSlotChangeNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WidgetSlotChangeNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxXaWRnZXRTbG90Q2hhbmdlTm90aWZ5LnByb3RvGhRXaWRnZXRTbG90RGF0",
          "YS5wcm90bxoSV2lkZ2V0U2xvdE9wLnByb3RvIlIKFldpZGdldFNsb3RDaGFu",
          "Z2VOb3RpZnkSGQoCb3AYCyABKA4yDS5XaWRnZXRTbG90T3ASHQoEc2xvdBgI",
          "IAEoCzIPLldpZGdldFNsb3REYXRhQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQu",
          "b2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::WidgetSlotDataReflection.Descriptor, global::WidgetSlotOpReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WidgetSlotChangeNotify), global::WidgetSlotChangeNotify.Parser, new[]{ "Op", "Slot" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4267
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class WidgetSlotChangeNotify : pb::IMessage<WidgetSlotChangeNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WidgetSlotChangeNotify> _parser = new pb::MessageParser<WidgetSlotChangeNotify>(() => new WidgetSlotChangeNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WidgetSlotChangeNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WidgetSlotChangeNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WidgetSlotChangeNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WidgetSlotChangeNotify(WidgetSlotChangeNotify other) : this() {
    op_ = other.op_;
    slot_ = other.slot_ != null ? other.slot_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WidgetSlotChangeNotify Clone() {
    return new WidgetSlotChangeNotify(this);
  }

  /// <summary>Field number for the "op" field.</summary>
  public const int OpFieldNumber = 11;
  private global::WidgetSlotOp op_ = global::WidgetSlotOp.Attach;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::WidgetSlotOp Op {
    get { return op_; }
    set {
      op_ = value;
    }
  }

  /// <summary>Field number for the "slot" field.</summary>
  public const int SlotFieldNumber = 8;
  private global::WidgetSlotData slot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::WidgetSlotData Slot {
    get { return slot_; }
    set {
      slot_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WidgetSlotChangeNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WidgetSlotChangeNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Op != other.Op) return false;
    if (!object.Equals(Slot, other.Slot)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Op != global::WidgetSlotOp.Attach) hash ^= Op.GetHashCode();
    if (slot_ != null) hash ^= Slot.GetHashCode();
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
    if (slot_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(Slot);
    }
    if (Op != global::WidgetSlotOp.Attach) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Op);
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
    if (slot_ != null) {
      output.WriteRawTag(66);
      output.WriteMessage(Slot);
    }
    if (Op != global::WidgetSlotOp.Attach) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Op);
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
    if (Op != global::WidgetSlotOp.Attach) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Op);
    }
    if (slot_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Slot);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WidgetSlotChangeNotify other) {
    if (other == null) {
      return;
    }
    if (other.Op != global::WidgetSlotOp.Attach) {
      Op = other.Op;
    }
    if (other.slot_ != null) {
      if (slot_ == null) {
        Slot = new global::WidgetSlotData();
      }
      Slot.MergeFrom(other.Slot);
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
        case 66: {
          if (slot_ == null) {
            Slot = new global::WidgetSlotData();
          }
          input.ReadMessage(Slot);
          break;
        }
        case 88: {
          Op = (global::WidgetSlotOp) input.ReadEnum();
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
        case 66: {
          if (slot_ == null) {
            Slot = new global::WidgetSlotData();
          }
          input.ReadMessage(Slot);
          break;
        }
        case 88: {
          Op = (global::WidgetSlotOp) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
