// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Investigation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Investigation.proto</summary>
public static partial class InvestigationReflection {

  #region Descriptor
  /// <summary>File descriptor for Investigation.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InvestigationReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNJbnZlc3RpZ2F0aW9uLnByb3RvIskBCg1JbnZlc3RpZ2F0aW9uEhYKDnRv",
          "dGFsX3Byb2dyZXNzGAUgASgNEiMKBXN0YXRlGAIgASgOMhQuSW52ZXN0aWdh",
          "dGlvbi5TdGF0ZRIQCghwcm9ncmVzcxgNIAEoDRIKCgJpZBgJIAEoDSJdCgVT",
          "dGF0ZRIRCg1TVEFURV9JTlZBTElEEAASFQoRU1RBVEVfSU5fUFJPR1JFU1MQ",
          "ARISCg5TVEFURV9DT01QTEVURRACEhYKElNUQVRFX1JFV0FSRF9UQUtFThAD",
          "Qh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Investigation), global::Investigation.Parser, new[]{ "TotalProgress", "State", "Progress", "Id" }, null, new[]{ typeof(global::Investigation.Types.State) }, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Investigation : pb::IMessage<Investigation>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Investigation> _parser = new pb::MessageParser<Investigation>(() => new Investigation());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Investigation> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InvestigationReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Investigation() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Investigation(Investigation other) : this() {
    totalProgress_ = other.totalProgress_;
    state_ = other.state_;
    progress_ = other.progress_;
    id_ = other.id_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Investigation Clone() {
    return new Investigation(this);
  }

  /// <summary>Field number for the "total_progress" field.</summary>
  public const int TotalProgressFieldNumber = 5;
  private uint totalProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalProgress {
    get { return totalProgress_; }
    set {
      totalProgress_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 2;
  private global::Investigation.Types.State state_ = global::Investigation.Types.State.Invalid;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Investigation.Types.State State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 13;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 9;
  private uint id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Investigation);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Investigation other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (TotalProgress != other.TotalProgress) return false;
    if (State != other.State) return false;
    if (Progress != other.Progress) return false;
    if (Id != other.Id) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (TotalProgress != 0) hash ^= TotalProgress.GetHashCode();
    if (State != global::Investigation.Types.State.Invalid) hash ^= State.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (Id != 0) hash ^= Id.GetHashCode();
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
    if (State != global::Investigation.Types.State.Invalid) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(TotalProgress);
    }
    if (Id != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Id);
    }
    if (Progress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(Progress);
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
    if (State != global::Investigation.Types.State.Invalid) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(TotalProgress);
    }
    if (Id != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Id);
    }
    if (Progress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(Progress);
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
    if (TotalProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalProgress);
    }
    if (State != global::Investigation.Types.State.Invalid) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Investigation other) {
    if (other == null) {
      return;
    }
    if (other.TotalProgress != 0) {
      TotalProgress = other.TotalProgress;
    }
    if (other.State != global::Investigation.Types.State.Invalid) {
      State = other.State;
    }
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    if (other.Id != 0) {
      Id = other.Id;
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
          State = (global::Investigation.Types.State) input.ReadEnum();
          break;
        }
        case 40: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 72: {
          Id = input.ReadUInt32();
          break;
        }
        case 104: {
          Progress = input.ReadUInt32();
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
          State = (global::Investigation.Types.State) input.ReadEnum();
          break;
        }
        case 40: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 72: {
          Id = input.ReadUInt32();
          break;
        }
        case 104: {
          Progress = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the Investigation message type.</summary>
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
