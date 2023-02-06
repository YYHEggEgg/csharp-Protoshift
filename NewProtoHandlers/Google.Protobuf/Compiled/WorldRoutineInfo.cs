// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldRoutineInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WorldRoutineInfo.proto</summary>
public static partial class WorldRoutineInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for WorldRoutineInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WorldRoutineInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZXb3JsZFJvdXRpbmVJbmZvLnByb3RvImYKEFdvcmxkUm91dGluZUluZm8S",
          "FwoPZmluaXNoX3Byb2dyZXNzGAEgASgNEhIKCnJvdXRpbmVfaWQYCiABKA0S",
          "EAoIcHJvZ3Jlc3MYByABKA0SEwoLaXNfZmluaXNoZWQYDyABKAhCFgoUb3Jn",
          "LnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WorldRoutineInfo), global::WorldRoutineInfo.Parser, new[]{ "FinishProgress", "RoutineId", "Progress", "IsFinished" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class WorldRoutineInfo : pb::IMessage<WorldRoutineInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WorldRoutineInfo> _parser = new pb::MessageParser<WorldRoutineInfo>(() => new WorldRoutineInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WorldRoutineInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WorldRoutineInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldRoutineInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldRoutineInfo(WorldRoutineInfo other) : this() {
    finishProgress_ = other.finishProgress_;
    routineId_ = other.routineId_;
    progress_ = other.progress_;
    isFinished_ = other.isFinished_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldRoutineInfo Clone() {
    return new WorldRoutineInfo(this);
  }

  /// <summary>Field number for the "finish_progress" field.</summary>
  public const int FinishProgressFieldNumber = 1;
  private uint finishProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FinishProgress {
    get { return finishProgress_; }
    set {
      finishProgress_ = value;
    }
  }

  /// <summary>Field number for the "routine_id" field.</summary>
  public const int RoutineIdFieldNumber = 10;
  private uint routineId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RoutineId {
    get { return routineId_; }
    set {
      routineId_ = value;
    }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 7;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  /// <summary>Field number for the "is_finished" field.</summary>
  public const int IsFinishedFieldNumber = 15;
  private bool isFinished_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFinished {
    get { return isFinished_; }
    set {
      isFinished_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WorldRoutineInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WorldRoutineInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (FinishProgress != other.FinishProgress) return false;
    if (RoutineId != other.RoutineId) return false;
    if (Progress != other.Progress) return false;
    if (IsFinished != other.IsFinished) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (FinishProgress != 0) hash ^= FinishProgress.GetHashCode();
    if (RoutineId != 0) hash ^= RoutineId.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (IsFinished != false) hash ^= IsFinished.GetHashCode();
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
    if (FinishProgress != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(FinishProgress);
    }
    if (Progress != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Progress);
    }
    if (RoutineId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(RoutineId);
    }
    if (IsFinished != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsFinished);
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
    if (FinishProgress != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(FinishProgress);
    }
    if (Progress != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Progress);
    }
    if (RoutineId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(RoutineId);
    }
    if (IsFinished != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsFinished);
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
    if (FinishProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishProgress);
    }
    if (RoutineId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoutineId);
    }
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (IsFinished != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WorldRoutineInfo other) {
    if (other == null) {
      return;
    }
    if (other.FinishProgress != 0) {
      FinishProgress = other.FinishProgress;
    }
    if (other.RoutineId != 0) {
      RoutineId = other.RoutineId;
    }
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    if (other.IsFinished != false) {
      IsFinished = other.IsFinished;
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
          FinishProgress = input.ReadUInt32();
          break;
        }
        case 56: {
          Progress = input.ReadUInt32();
          break;
        }
        case 80: {
          RoutineId = input.ReadUInt32();
          break;
        }
        case 120: {
          IsFinished = input.ReadBool();
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
          FinishProgress = input.ReadUInt32();
          break;
        }
        case 56: {
          Progress = input.ReadUInt32();
          break;
        }
        case 80: {
          RoutineId = input.ReadUInt32();
          break;
        }
        case 120: {
          IsFinished = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
