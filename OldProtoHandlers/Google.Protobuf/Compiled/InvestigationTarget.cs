// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InvestigationTarget.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from InvestigationTarget.proto</summary>
public static partial class InvestigationTargetReflection {

  #region Descriptor
  /// <summary>File descriptor for InvestigationTarget.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InvestigationTargetReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlJbnZlc3RpZ2F0aW9uVGFyZ2V0LnByb3RvIvUBChNJbnZlc3RpZ2F0aW9u",
          "VGFyZ2V0EhAKCHF1ZXN0X2lkGA8gASgNEikKBXN0YXRlGAIgASgOMhouSW52",
          "ZXN0aWdhdGlvblRhcmdldC5TdGF0ZRIQCghwcm9ncmVzcxgIIAEoDRIWCg50",
          "b3RhbF9wcm9ncmVzcxgHIAEoDRIYChBpbnZlc3RpZ2F0aW9uX2lkGAMgASgN",
          "Il0KBVN0YXRlEhEKDVNUQVRFX0lOVkFMSUQQABIVChFTVEFURV9JTl9QUk9H",
          "UkVTUxABEhIKDlNUQVRFX0NPTVBMRVRFEAISFgoSU1RBVEVfUkVXQVJEX1RB",
          "S0VOEANCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InvestigationTarget), global::InvestigationTarget.Parser, new[]{ "QuestId", "State", "Progress", "TotalProgress", "InvestigationId" }, null, new[]{ typeof(global::InvestigationTarget.Types.State) }, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class InvestigationTarget : pb::IMessage<InvestigationTarget>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InvestigationTarget> _parser = new pb::MessageParser<InvestigationTarget>(() => new InvestigationTarget());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InvestigationTarget> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InvestigationTargetReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InvestigationTarget() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InvestigationTarget(InvestigationTarget other) : this() {
    questId_ = other.questId_;
    state_ = other.state_;
    progress_ = other.progress_;
    totalProgress_ = other.totalProgress_;
    investigationId_ = other.investigationId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InvestigationTarget Clone() {
    return new InvestigationTarget(this);
  }

  /// <summary>Field number for the "quest_id" field.</summary>
  public const int QuestIdFieldNumber = 15;
  private uint questId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint QuestId {
    get { return questId_; }
    set {
      questId_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 2;
  private global::InvestigationTarget.Types.State state_ = global::InvestigationTarget.Types.State.Invalid;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::InvestigationTarget.Types.State State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 8;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  /// <summary>Field number for the "total_progress" field.</summary>
  public const int TotalProgressFieldNumber = 7;
  private uint totalProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalProgress {
    get { return totalProgress_; }
    set {
      totalProgress_ = value;
    }
  }

  /// <summary>Field number for the "investigation_id" field.</summary>
  public const int InvestigationIdFieldNumber = 3;
  private uint investigationId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint InvestigationId {
    get { return investigationId_; }
    set {
      investigationId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InvestigationTarget);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InvestigationTarget other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (QuestId != other.QuestId) return false;
    if (State != other.State) return false;
    if (Progress != other.Progress) return false;
    if (TotalProgress != other.TotalProgress) return false;
    if (InvestigationId != other.InvestigationId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (QuestId != 0) hash ^= QuestId.GetHashCode();
    if (State != global::InvestigationTarget.Types.State.Invalid) hash ^= State.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (TotalProgress != 0) hash ^= TotalProgress.GetHashCode();
    if (InvestigationId != 0) hash ^= InvestigationId.GetHashCode();
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
    if (State != global::InvestigationTarget.Types.State.Invalid) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (InvestigationId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(InvestigationId);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(TotalProgress);
    }
    if (Progress != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Progress);
    }
    if (QuestId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(QuestId);
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
    if (State != global::InvestigationTarget.Types.State.Invalid) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (InvestigationId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(InvestigationId);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(TotalProgress);
    }
    if (Progress != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Progress);
    }
    if (QuestId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(QuestId);
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
    if (QuestId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
    }
    if (State != global::InvestigationTarget.Types.State.Invalid) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (TotalProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalProgress);
    }
    if (InvestigationId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InvestigationId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InvestigationTarget other) {
    if (other == null) {
      return;
    }
    if (other.QuestId != 0) {
      QuestId = other.QuestId;
    }
    if (other.State != global::InvestigationTarget.Types.State.Invalid) {
      State = other.State;
    }
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    if (other.TotalProgress != 0) {
      TotalProgress = other.TotalProgress;
    }
    if (other.InvestigationId != 0) {
      InvestigationId = other.InvestigationId;
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
        case 16: {
          State = (global::InvestigationTarget.Types.State) input.ReadEnum();
          break;
        }
        case 24: {
          InvestigationId = input.ReadUInt32();
          break;
        }
        case 56: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 64: {
          Progress = input.ReadUInt32();
          break;
        }
        case 120: {
          QuestId = input.ReadUInt32();
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
        case 16: {
          State = (global::InvestigationTarget.Types.State) input.ReadEnum();
          break;
        }
        case 24: {
          InvestigationId = input.ReadUInt32();
          break;
        }
        case 56: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 64: {
          Progress = input.ReadUInt32();
          break;
        }
        case 120: {
          QuestId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the InvestigationTarget message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum State {
      [pbr::OriginalName("STATE_INVALID")] Invalid = 0,
      [pbr::OriginalName("STATE_IN_PROGRESS")] InProgress = 1,
      [pbr::OriginalName("STATE_COMPLETE")] Complete = 2,
      [pbr::OriginalName("STATE_REWARD_TAKEN")] RewardTaken = 3,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
