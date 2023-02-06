// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlossomScheduleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BlossomScheduleInfo.proto</summary>
public static partial class BlossomScheduleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for BlossomScheduleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BlossomScheduleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlCbG9zc29tU2NoZWR1bGVJbmZvLnByb3RvIooBChNCbG9zc29tU2NoZWR1",
          "bGVJbmZvEhAKCHByb2dyZXNzGA0gASgNEg0KBXN0YXRlGAogASgNEg0KBXJv",
          "dW5kGAQgASgNEhYKDmNpcmNsZV9jYW1wX2lkGA8gASgNEhIKCnJlZnJlc2hf",
          "aWQYBiABKA0SFwoPZmluaXNoX3Byb2dyZXNzGA4gASgNQh4KHGVtdS5ncmFz",
          "c2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BlossomScheduleInfo), global::BlossomScheduleInfo.Parser, new[]{ "Progress", "State", "Round", "CircleCampId", "RefreshId", "FinishProgress" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BlossomScheduleInfo : pb::IMessage<BlossomScheduleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BlossomScheduleInfo> _parser = new pb::MessageParser<BlossomScheduleInfo>(() => new BlossomScheduleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BlossomScheduleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlossomScheduleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlossomScheduleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlossomScheduleInfo(BlossomScheduleInfo other) : this() {
    progress_ = other.progress_;
    state_ = other.state_;
    round_ = other.round_;
    circleCampId_ = other.circleCampId_;
    refreshId_ = other.refreshId_;
    finishProgress_ = other.finishProgress_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlossomScheduleInfo Clone() {
    return new BlossomScheduleInfo(this);
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

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 10;
  private uint state_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  /// <summary>Field number for the "round" field.</summary>
  public const int RoundFieldNumber = 4;
  private uint round_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Round {
    get { return round_; }
    set {
      round_ = value;
    }
  }

  /// <summary>Field number for the "circle_camp_id" field.</summary>
  public const int CircleCampIdFieldNumber = 15;
  private uint circleCampId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CircleCampId {
    get { return circleCampId_; }
    set {
      circleCampId_ = value;
    }
  }

  /// <summary>Field number for the "refresh_id" field.</summary>
  public const int RefreshIdFieldNumber = 6;
  private uint refreshId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RefreshId {
    get { return refreshId_; }
    set {
      refreshId_ = value;
    }
  }

  /// <summary>Field number for the "finish_progress" field.</summary>
  public const int FinishProgressFieldNumber = 14;
  private uint finishProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FinishProgress {
    get { return finishProgress_; }
    set {
      finishProgress_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BlossomScheduleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BlossomScheduleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Progress != other.Progress) return false;
    if (State != other.State) return false;
    if (Round != other.Round) return false;
    if (CircleCampId != other.CircleCampId) return false;
    if (RefreshId != other.RefreshId) return false;
    if (FinishProgress != other.FinishProgress) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (State != 0) hash ^= State.GetHashCode();
    if (Round != 0) hash ^= Round.GetHashCode();
    if (CircleCampId != 0) hash ^= CircleCampId.GetHashCode();
    if (RefreshId != 0) hash ^= RefreshId.GetHashCode();
    if (FinishProgress != 0) hash ^= FinishProgress.GetHashCode();
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
    if (Round != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Round);
    }
    if (RefreshId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(RefreshId);
    }
    if (State != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(State);
    }
    if (Progress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(Progress);
    }
    if (FinishProgress != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(FinishProgress);
    }
    if (CircleCampId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(CircleCampId);
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
    if (Round != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Round);
    }
    if (RefreshId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(RefreshId);
    }
    if (State != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(State);
    }
    if (Progress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(Progress);
    }
    if (FinishProgress != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(FinishProgress);
    }
    if (CircleCampId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(CircleCampId);
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
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (State != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(State);
    }
    if (Round != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
    }
    if (CircleCampId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CircleCampId);
    }
    if (RefreshId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RefreshId);
    }
    if (FinishProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishProgress);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BlossomScheduleInfo other) {
    if (other == null) {
      return;
    }
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    if (other.State != 0) {
      State = other.State;
    }
    if (other.Round != 0) {
      Round = other.Round;
    }
    if (other.CircleCampId != 0) {
      CircleCampId = other.CircleCampId;
    }
    if (other.RefreshId != 0) {
      RefreshId = other.RefreshId;
    }
    if (other.FinishProgress != 0) {
      FinishProgress = other.FinishProgress;
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
        case 32: {
          Round = input.ReadUInt32();
          break;
        }
        case 48: {
          RefreshId = input.ReadUInt32();
          break;
        }
        case 80: {
          State = input.ReadUInt32();
          break;
        }
        case 104: {
          Progress = input.ReadUInt32();
          break;
        }
        case 112: {
          FinishProgress = input.ReadUInt32();
          break;
        }
        case 120: {
          CircleCampId = input.ReadUInt32();
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
        case 32: {
          Round = input.ReadUInt32();
          break;
        }
        case 48: {
          RefreshId = input.ReadUInt32();
          break;
        }
        case 80: {
          State = input.ReadUInt32();
          break;
        }
        case 104: {
          Progress = input.ReadUInt32();
          break;
        }
        case 112: {
          FinishProgress = input.ReadUInt32();
          break;
        }
        case 120: {
          CircleCampId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
