// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityPushTipsData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ActivityPushTipsData.proto</summary>
public static partial class ActivityPushTipsDataReflection {

  #region Descriptor
  /// <summary>File descriptor for ActivityPushTipsData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ActivityPushTipsDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpBY3Rpdml0eVB1c2hUaXBzRGF0YS5wcm90bxobQWN0aXZpdHlQdXNoVGlw",
          "c1N0YXRlLnByb3RvIlwKFEFjdGl2aXR5UHVzaFRpcHNEYXRhEh0KFWFjdGl2",
          "aXR5X3B1c2hfdGlwc19pZBgOIAEoDRIlCgVzdGF0ZRgDIAEoDjIWLkFjdGl2",
          "aXR5UHVzaFRpcHNTdGF0ZUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ActivityPushTipsStateReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ActivityPushTipsData), global::ActivityPushTipsData.Parser, new[]{ "ActivityPushTipsId", "State" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ActivityPushTipsData : pb::IMessage<ActivityPushTipsData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ActivityPushTipsData> _parser = new pb::MessageParser<ActivityPushTipsData>(() => new ActivityPushTipsData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ActivityPushTipsData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ActivityPushTipsDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityPushTipsData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityPushTipsData(ActivityPushTipsData other) : this() {
    activityPushTipsId_ = other.activityPushTipsId_;
    state_ = other.state_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityPushTipsData Clone() {
    return new ActivityPushTipsData(this);
  }

  /// <summary>Field number for the "activity_push_tips_id" field.</summary>
  public const int ActivityPushTipsIdFieldNumber = 14;
  private uint activityPushTipsId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ActivityPushTipsId {
    get { return activityPushTipsId_; }
    set {
      activityPushTipsId_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 3;
  private global::ActivityPushTipsState state_ = global::ActivityPushTipsState.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ActivityPushTipsState State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ActivityPushTipsData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ActivityPushTipsData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ActivityPushTipsId != other.ActivityPushTipsId) return false;
    if (State != other.State) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ActivityPushTipsId != 0) hash ^= ActivityPushTipsId.GetHashCode();
    if (State != global::ActivityPushTipsState.None) hash ^= State.GetHashCode();
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
    if (State != global::ActivityPushTipsState.None) {
      output.WriteRawTag(24);
      output.WriteEnum((int) State);
    }
    if (ActivityPushTipsId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(ActivityPushTipsId);
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
    if (State != global::ActivityPushTipsState.None) {
      output.WriteRawTag(24);
      output.WriteEnum((int) State);
    }
    if (ActivityPushTipsId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(ActivityPushTipsId);
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
    if (ActivityPushTipsId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityPushTipsId);
    }
    if (State != global::ActivityPushTipsState.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ActivityPushTipsData other) {
    if (other == null) {
      return;
    }
    if (other.ActivityPushTipsId != 0) {
      ActivityPushTipsId = other.ActivityPushTipsId;
    }
    if (other.State != global::ActivityPushTipsState.None) {
      State = other.State;
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
        case 24: {
          State = (global::ActivityPushTipsState) input.ReadEnum();
          break;
        }
        case 112: {
          ActivityPushTipsId = input.ReadUInt32();
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
        case 24: {
          State = (global::ActivityPushTipsState) input.ReadEnum();
          break;
        }
        case 112: {
          ActivityPushTipsId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
