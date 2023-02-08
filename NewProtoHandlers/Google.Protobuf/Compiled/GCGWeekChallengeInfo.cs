// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGWeekChallengeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GCGWeekChallengeInfo.proto</summary>
  public static partial class GCGWeekChallengeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGWeekChallengeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGWeekChallengeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHQ0dXZWVrQ2hhbGxlbmdlSW5mby5wcm90byJQChRHQ0dXZWVrQ2hhbGxl",
            "bmdlSW5mbxIOCgZucGNfaWQYCSABKA0SEwoLdW5sb2NrX3RpbWUYCCABKA0S",
            "EwoLaXNfZmluaXNoZWQYDCABKAhCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GCGWeekChallengeInfo), global::NewProtos.GCGWeekChallengeInfo.Parser, new[]{ "NpcId", "UnlockTime", "IsFinished" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGWeekChallengeInfo : pb::IMessage<GCGWeekChallengeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGWeekChallengeInfo> _parser = new pb::MessageParser<GCGWeekChallengeInfo>(() => new GCGWeekChallengeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGWeekChallengeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GCGWeekChallengeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGWeekChallengeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGWeekChallengeInfo(GCGWeekChallengeInfo other) : this() {
      npcId_ = other.npcId_;
      unlockTime_ = other.unlockTime_;
      isFinished_ = other.isFinished_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGWeekChallengeInfo Clone() {
      return new GCGWeekChallengeInfo(this);
    }

    /// <summary>Field number for the "npc_id" field.</summary>
    public const int NpcIdFieldNumber = 9;
    private uint npcId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NpcId {
      get { return npcId_; }
      set {
        npcId_ = value;
      }
    }

    /// <summary>Field number for the "unlock_time" field.</summary>
    public const int UnlockTimeFieldNumber = 8;
    private uint unlockTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UnlockTime {
      get { return unlockTime_; }
      set {
        unlockTime_ = value;
      }
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 12;
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
      return Equals(other as GCGWeekChallengeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGWeekChallengeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NpcId != other.NpcId) return false;
      if (UnlockTime != other.UnlockTime) return false;
      if (IsFinished != other.IsFinished) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NpcId != 0) hash ^= NpcId.GetHashCode();
      if (UnlockTime != 0) hash ^= UnlockTime.GetHashCode();
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
      if (UnlockTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(UnlockTime);
      }
      if (NpcId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NpcId);
      }
      if (IsFinished != false) {
        output.WriteRawTag(96);
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
      if (UnlockTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(UnlockTime);
      }
      if (NpcId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NpcId);
      }
      if (IsFinished != false) {
        output.WriteRawTag(96);
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
      if (NpcId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NpcId);
      }
      if (UnlockTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockTime);
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
    public void MergeFrom(GCGWeekChallengeInfo other) {
      if (other == null) {
        return;
      }
      if (other.NpcId != 0) {
        NpcId = other.NpcId;
      }
      if (other.UnlockTime != 0) {
        UnlockTime = other.UnlockTime;
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
          case 64: {
            UnlockTime = input.ReadUInt32();
            break;
          }
          case 72: {
            NpcId = input.ReadUInt32();
            break;
          }
          case 96: {
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
          case 64: {
            UnlockTime = input.ReadUInt32();
            break;
          }
          case 72: {
            NpcId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsFinished = input.ReadBool();
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
