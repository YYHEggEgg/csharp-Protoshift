// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LockedPersonallineData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from LockedPersonallineData.proto</summary>
  public static partial class LockedPersonallineDataReflection {

    #region Descriptor
    /// <summary>File descriptor for LockedPersonallineData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LockedPersonallineDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxMb2NrZWRQZXJzb25hbGxpbmVEYXRhLnByb3RvItcBChZMb2NrZWRQZXJz",
            "b25hbGxpbmVEYXRhEjcKC2xvY2tfcmVhc29uGAIgASgOMiIuTG9ja2VkUGVy",
            "c29uYWxsaW5lRGF0YS5Mb2NrUmVhc29uEhgKEHBlcnNvbmFsX2xpbmVfaWQY",
            "DSABKA0SFAoKY2hhcHRlcl9pZBgDIAEoDUgAEg8KBWxldmVsGAEgASgNSAAi",
            "OgoKTG9ja1JlYXNvbhIVChFMT0NLX1JFQVNPTl9MRVZFTBAAEhUKEUxPQ0tf",
            "UkVBU09OX1FVRVNUEAFCBwoFcGFyYW1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.LockedPersonallineData), global::OldProtos.LockedPersonallineData.Parser, new[]{ "LockReason", "PersonalLineId", "ChapterId", "Level" }, new[]{ "Param" }, new[]{ typeof(global::OldProtos.LockedPersonallineData.Types.LockReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LockedPersonallineData : pb::IMessage<LockedPersonallineData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LockedPersonallineData> _parser = new pb::MessageParser<LockedPersonallineData>(() => new LockedPersonallineData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LockedPersonallineData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.LockedPersonallineDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LockedPersonallineData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LockedPersonallineData(LockedPersonallineData other) : this() {
      lockReason_ = other.lockReason_;
      personalLineId_ = other.personalLineId_;
      switch (other.ParamCase) {
        case ParamOneofCase.ChapterId:
          ChapterId = other.ChapterId;
          break;
        case ParamOneofCase.Level:
          Level = other.Level;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LockedPersonallineData Clone() {
      return new LockedPersonallineData(this);
    }

    /// <summary>Field number for the "lock_reason" field.</summary>
    public const int LockReasonFieldNumber = 2;
    private global::OldProtos.LockedPersonallineData.Types.LockReason lockReason_ = global::OldProtos.LockedPersonallineData.Types.LockReason.Level;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.LockedPersonallineData.Types.LockReason LockReason {
      get { return lockReason_; }
      set {
        lockReason_ = value;
      }
    }

    /// <summary>Field number for the "personal_line_id" field.</summary>
    public const int PersonalLineIdFieldNumber = 13;
    private uint personalLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PersonalLineId {
      get { return personalLineId_; }
      set {
        personalLineId_ = value;
      }
    }

    /// <summary>Field number for the "chapter_id" field.</summary>
    public const int ChapterIdFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChapterId {
      get { return HasChapterId ? (uint) param_ : 0; }
      set {
        param_ = value;
        paramCase_ = ParamOneofCase.ChapterId;
      }
    }
    /// <summary>Gets whether the "chapter_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasChapterId {
      get { return paramCase_ == ParamOneofCase.ChapterId; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "chapter_id" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearChapterId() {
      if (HasChapterId) {
        ClearParam();
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return HasLevel ? (uint) param_ : 0; }
      set {
        param_ = value;
        paramCase_ = ParamOneofCase.Level;
      }
    }
    /// <summary>Gets whether the "level" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLevel {
      get { return paramCase_ == ParamOneofCase.Level; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "level" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLevel() {
      if (HasLevel) {
        ClearParam();
      }
    }

    private object param_;
    /// <summary>Enum of possible cases for the "param" oneof.</summary>
    public enum ParamOneofCase {
      None = 0,
      ChapterId = 3,
      Level = 1,
    }
    private ParamOneofCase paramCase_ = ParamOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParamOneofCase ParamCase {
      get { return paramCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearParam() {
      paramCase_ = ParamOneofCase.None;
      param_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LockedPersonallineData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LockedPersonallineData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LockReason != other.LockReason) return false;
      if (PersonalLineId != other.PersonalLineId) return false;
      if (ChapterId != other.ChapterId) return false;
      if (Level != other.Level) return false;
      if (ParamCase != other.ParamCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LockReason != global::OldProtos.LockedPersonallineData.Types.LockReason.Level) hash ^= LockReason.GetHashCode();
      if (PersonalLineId != 0) hash ^= PersonalLineId.GetHashCode();
      if (HasChapterId) hash ^= ChapterId.GetHashCode();
      if (HasLevel) hash ^= Level.GetHashCode();
      hash ^= (int) paramCase_;
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
      if (HasLevel) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (LockReason != global::OldProtos.LockedPersonallineData.Types.LockReason.Level) {
        output.WriteRawTag(16);
        output.WriteEnum((int) LockReason);
      }
      if (HasChapterId) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChapterId);
      }
      if (PersonalLineId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PersonalLineId);
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
      if (HasLevel) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (LockReason != global::OldProtos.LockedPersonallineData.Types.LockReason.Level) {
        output.WriteRawTag(16);
        output.WriteEnum((int) LockReason);
      }
      if (HasChapterId) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChapterId);
      }
      if (PersonalLineId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PersonalLineId);
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
      if (LockReason != global::OldProtos.LockedPersonallineData.Types.LockReason.Level) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LockReason);
      }
      if (PersonalLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PersonalLineId);
      }
      if (HasChapterId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChapterId);
      }
      if (HasLevel) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LockedPersonallineData other) {
      if (other == null) {
        return;
      }
      if (other.LockReason != global::OldProtos.LockedPersonallineData.Types.LockReason.Level) {
        LockReason = other.LockReason;
      }
      if (other.PersonalLineId != 0) {
        PersonalLineId = other.PersonalLineId;
      }
      switch (other.ParamCase) {
        case ParamOneofCase.ChapterId:
          ChapterId = other.ChapterId;
          break;
        case ParamOneofCase.Level:
          Level = other.Level;
          break;
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
            Level = input.ReadUInt32();
            break;
          }
          case 16: {
            LockReason = (global::OldProtos.LockedPersonallineData.Types.LockReason) input.ReadEnum();
            break;
          }
          case 24: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 104: {
            PersonalLineId = input.ReadUInt32();
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
            Level = input.ReadUInt32();
            break;
          }
          case 16: {
            LockReason = (global::OldProtos.LockedPersonallineData.Types.LockReason) input.ReadEnum();
            break;
          }
          case 24: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 104: {
            PersonalLineId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LockedPersonallineData message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum LockReason {
        [pbr::OriginalName("LOCK_REASON_LEVEL")] Level = 0,
        [pbr::OriginalName("LOCK_REASON_QUEST")] Quest = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
