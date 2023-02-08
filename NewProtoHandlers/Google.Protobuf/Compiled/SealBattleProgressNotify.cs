// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SealBattleProgressNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SealBattleProgressNotify.proto</summary>
  public static partial class SealBattleProgressNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SealBattleProgressNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SealBattleProgressNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5TZWFsQmF0dGxlUHJvZ3Jlc3NOb3RpZnkucHJvdG8igQEKGFNlYWxCYXR0",
            "bGVQcm9ncmVzc05vdGlmeRIQCghlbmRfdGltZRgFIAEoDRITCgtzZWFsX3Jh",
            "ZGl1cxgBIAEoDRIUCgxtYXhfcHJvZ3Jlc3MYCSABKA0SFgoOc2VhbF9lbnRp",
            "dHlfaWQYBiABKA0SEAoIcHJvZ3Jlc3MYBCABKA1CDKoCCU5ld1Byb3Rvc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SealBattleProgressNotify), global::NewProtos.SealBattleProgressNotify.Parser, new[]{ "EndTime", "SealRadius", "MaxProgress", "SealEntityId", "Progress" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 265;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SealBattleProgressNotify : pb::IMessage<SealBattleProgressNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SealBattleProgressNotify> _parser = new pb::MessageParser<SealBattleProgressNotify>(() => new SealBattleProgressNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SealBattleProgressNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SealBattleProgressNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SealBattleProgressNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SealBattleProgressNotify(SealBattleProgressNotify other) : this() {
      endTime_ = other.endTime_;
      sealRadius_ = other.sealRadius_;
      maxProgress_ = other.maxProgress_;
      sealEntityId_ = other.sealEntityId_;
      progress_ = other.progress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SealBattleProgressNotify Clone() {
      return new SealBattleProgressNotify(this);
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 5;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "seal_radius" field.</summary>
    public const int SealRadiusFieldNumber = 1;
    private uint sealRadius_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SealRadius {
      get { return sealRadius_; }
      set {
        sealRadius_ = value;
      }
    }

    /// <summary>Field number for the "max_progress" field.</summary>
    public const int MaxProgressFieldNumber = 9;
    private uint maxProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxProgress {
      get { return maxProgress_; }
      set {
        maxProgress_ = value;
      }
    }

    /// <summary>Field number for the "seal_entity_id" field.</summary>
    public const int SealEntityIdFieldNumber = 6;
    private uint sealEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SealEntityId {
      get { return sealEntityId_; }
      set {
        sealEntityId_ = value;
      }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 4;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SealBattleProgressNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SealBattleProgressNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EndTime != other.EndTime) return false;
      if (SealRadius != other.SealRadius) return false;
      if (MaxProgress != other.MaxProgress) return false;
      if (SealEntityId != other.SealEntityId) return false;
      if (Progress != other.Progress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (SealRadius != 0) hash ^= SealRadius.GetHashCode();
      if (MaxProgress != 0) hash ^= MaxProgress.GetHashCode();
      if (SealEntityId != 0) hash ^= SealEntityId.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
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
      if (SealRadius != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SealRadius);
      }
      if (Progress != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Progress);
      }
      if (EndTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EndTime);
      }
      if (SealEntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SealEntityId);
      }
      if (MaxProgress != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaxProgress);
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
      if (SealRadius != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SealRadius);
      }
      if (Progress != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Progress);
      }
      if (EndTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EndTime);
      }
      if (SealEntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SealEntityId);
      }
      if (MaxProgress != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaxProgress);
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
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (SealRadius != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealRadius);
      }
      if (MaxProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxProgress);
      }
      if (SealEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealEntityId);
      }
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SealBattleProgressNotify other) {
      if (other == null) {
        return;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      if (other.SealRadius != 0) {
        SealRadius = other.SealRadius;
      }
      if (other.MaxProgress != 0) {
        MaxProgress = other.MaxProgress;
      }
      if (other.SealEntityId != 0) {
        SealEntityId = other.SealEntityId;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
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
            SealRadius = input.ReadUInt32();
            break;
          }
          case 32: {
            Progress = input.ReadUInt32();
            break;
          }
          case 40: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 48: {
            SealEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            MaxProgress = input.ReadUInt32();
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
            SealRadius = input.ReadUInt32();
            break;
          }
          case 32: {
            Progress = input.ReadUInt32();
            break;
          }
          case 40: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 48: {
            SealEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            MaxProgress = input.ReadUInt32();
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
