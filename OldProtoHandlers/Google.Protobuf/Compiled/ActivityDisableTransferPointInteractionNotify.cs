// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityDisableTransferPointInteractionNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ActivityDisableTransferPointInteractionNotify.proto</summary>
public static partial class ActivityDisableTransferPointInteractionNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ActivityDisableTransferPointInteractionNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ActivityDisableTransferPointInteractionNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CjNBY3Rpdml0eURpc2FibGVUcmFuc2ZlclBvaW50SW50ZXJhY3Rpb25Ob3Rp",
          "ZnkucHJvdG8aEFVpbnQzMlBhaXIucHJvdG8iagotQWN0aXZpdHlEaXNhYmxl",
          "VHJhbnNmZXJQb2ludEludGVyYWN0aW9uTm90aWZ5EhIKCmlzX2Rpc2FibGUY",
          "CiABKAgSJQoQc2NlbmVfcG9pbnRfcGFpchgFIAEoCzILLlVpbnQzMlBhaXJC",
          "HgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Uint32PairReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ActivityDisableTransferPointInteractionNotify), global::ActivityDisableTransferPointInteractionNotify.Parser, new[]{ "IsDisable", "ScenePointPair" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8982
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ActivityDisableTransferPointInteractionNotify : pb::IMessage<ActivityDisableTransferPointInteractionNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ActivityDisableTransferPointInteractionNotify> _parser = new pb::MessageParser<ActivityDisableTransferPointInteractionNotify>(() => new ActivityDisableTransferPointInteractionNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ActivityDisableTransferPointInteractionNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ActivityDisableTransferPointInteractionNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityDisableTransferPointInteractionNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityDisableTransferPointInteractionNotify(ActivityDisableTransferPointInteractionNotify other) : this() {
    isDisable_ = other.isDisable_;
    scenePointPair_ = other.scenePointPair_ != null ? other.scenePointPair_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityDisableTransferPointInteractionNotify Clone() {
    return new ActivityDisableTransferPointInteractionNotify(this);
  }

  /// <summary>Field number for the "is_disable" field.</summary>
  public const int IsDisableFieldNumber = 10;
  private bool isDisable_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsDisable {
    get { return isDisable_; }
    set {
      isDisable_ = value;
    }
  }

  /// <summary>Field number for the "scene_point_pair" field.</summary>
  public const int ScenePointPairFieldNumber = 5;
  private global::Uint32Pair scenePointPair_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Uint32Pair ScenePointPair {
    get { return scenePointPair_; }
    set {
      scenePointPair_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ActivityDisableTransferPointInteractionNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ActivityDisableTransferPointInteractionNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsDisable != other.IsDisable) return false;
    if (!object.Equals(ScenePointPair, other.ScenePointPair)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsDisable != false) hash ^= IsDisable.GetHashCode();
    if (scenePointPair_ != null) hash ^= ScenePointPair.GetHashCode();
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
    if (scenePointPair_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(ScenePointPair);
    }
    if (IsDisable != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsDisable);
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
    if (scenePointPair_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(ScenePointPair);
    }
    if (IsDisable != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsDisable);
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
    if (IsDisable != false) {
      size += 1 + 1;
    }
    if (scenePointPair_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScenePointPair);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ActivityDisableTransferPointInteractionNotify other) {
    if (other == null) {
      return;
    }
    if (other.IsDisable != false) {
      IsDisable = other.IsDisable;
    }
    if (other.scenePointPair_ != null) {
      if (scenePointPair_ == null) {
        ScenePointPair = new global::Uint32Pair();
      }
      ScenePointPair.MergeFrom(other.ScenePointPair);
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
        case 42: {
          if (scenePointPair_ == null) {
            ScenePointPair = new global::Uint32Pair();
          }
          input.ReadMessage(ScenePointPair);
          break;
        }
        case 80: {
          IsDisable = input.ReadBool();
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
        case 42: {
          if (scenePointPair_ == null) {
            ScenePointPair = new global::Uint32Pair();
          }
          input.ReadMessage(ScenePointPair);
          break;
        }
        case 80: {
          IsDisable = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code