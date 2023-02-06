// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayBattleInterruptNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ScenePlayBattleInterruptNotify.proto</summary>
public static partial class ScenePlayBattleInterruptNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ScenePlayBattleInterruptNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ScenePlayBattleInterruptNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiRTY2VuZVBsYXlCYXR0bGVJbnRlcnJ1cHROb3RpZnkucHJvdG8iXQoeU2Nl",
          "bmVQbGF5QmF0dGxlSW50ZXJydXB0Tm90aWZ5EhcKD2ludGVycnVwdF9zdGF0",
          "ZRgIIAEoDRIPCgdwbGF5X2lkGAogASgNEhEKCXBsYXlfdHlwZRgBIAEoDUIW",
          "ChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ScenePlayBattleInterruptNotify), global::ScenePlayBattleInterruptNotify.Parser, new[]{ "InterruptState", "PlayId", "PlayType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4389;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class ScenePlayBattleInterruptNotify : pb::IMessage<ScenePlayBattleInterruptNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ScenePlayBattleInterruptNotify> _parser = new pb::MessageParser<ScenePlayBattleInterruptNotify>(() => new ScenePlayBattleInterruptNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ScenePlayBattleInterruptNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ScenePlayBattleInterruptNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleInterruptNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleInterruptNotify(ScenePlayBattleInterruptNotify other) : this() {
    interruptState_ = other.interruptState_;
    playId_ = other.playId_;
    playType_ = other.playType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayBattleInterruptNotify Clone() {
    return new ScenePlayBattleInterruptNotify(this);
  }

  /// <summary>Field number for the "interrupt_state" field.</summary>
  public const int InterruptStateFieldNumber = 8;
  private uint interruptState_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint InterruptState {
    get { return interruptState_; }
    set {
      interruptState_ = value;
    }
  }

  /// <summary>Field number for the "play_id" field.</summary>
  public const int PlayIdFieldNumber = 10;
  private uint playId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayId {
    get { return playId_; }
    set {
      playId_ = value;
    }
  }

  /// <summary>Field number for the "play_type" field.</summary>
  public const int PlayTypeFieldNumber = 1;
  private uint playType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayType {
    get { return playType_; }
    set {
      playType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ScenePlayBattleInterruptNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ScenePlayBattleInterruptNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (InterruptState != other.InterruptState) return false;
    if (PlayId != other.PlayId) return false;
    if (PlayType != other.PlayType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (InterruptState != 0) hash ^= InterruptState.GetHashCode();
    if (PlayId != 0) hash ^= PlayId.GetHashCode();
    if (PlayType != 0) hash ^= PlayType.GetHashCode();
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
    if (PlayType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(PlayType);
    }
    if (InterruptState != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(InterruptState);
    }
    if (PlayId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(PlayId);
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
    if (PlayType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(PlayType);
    }
    if (InterruptState != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(InterruptState);
    }
    if (PlayId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(PlayId);
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
    if (InterruptState != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InterruptState);
    }
    if (PlayId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayId);
    }
    if (PlayType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ScenePlayBattleInterruptNotify other) {
    if (other == null) {
      return;
    }
    if (other.InterruptState != 0) {
      InterruptState = other.InterruptState;
    }
    if (other.PlayId != 0) {
      PlayId = other.PlayId;
    }
    if (other.PlayType != 0) {
      PlayType = other.PlayType;
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
          PlayType = input.ReadUInt32();
          break;
        }
        case 64: {
          InterruptState = input.ReadUInt32();
          break;
        }
        case 80: {
          PlayId = input.ReadUInt32();
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
          PlayType = input.ReadUInt32();
          break;
        }
        case 64: {
          InterruptState = input.ReadUInt32();
          break;
        }
        case 80: {
          PlayId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code