// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpiceActivityGivingRecordNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from SpiceActivityGivingRecordNotify.proto</summary>
  public static partial class SpiceActivityGivingRecordNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SpiceActivityGivingRecordNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpiceActivityGivingRecordNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTcGljZUFjdGl2aXR5R2l2aW5nUmVjb3JkTm90aWZ5LnByb3RvIo4BCh9T",
            "cGljZUFjdGl2aXR5R2l2aW5nUmVjb3JkTm90aWZ5EiwKJGN1cnJlbnRfaW5j",
            "cmVhc2VfYXZhdGFyX2ZldHRlcl90aW1lcxgDIAEoDRIqCiJpbmNyZWFzZV9h",
            "dmF0YXJfZmV0dGVyX2xpbWl0X3RpbWVzGAcgASgNEhEKCWF2YXRhcl9pZBgL",
            "IAEoDUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.SpiceActivityGivingRecordNotify), global::OldProtos.SpiceActivityGivingRecordNotify.Parser, new[]{ "CurrentIncreaseAvatarFetterTimes", "IncreaseAvatarFetterLimitTimes", "AvatarId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8407
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class SpiceActivityGivingRecordNotify : pb::IMessage<SpiceActivityGivingRecordNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpiceActivityGivingRecordNotify> _parser = new pb::MessageParser<SpiceActivityGivingRecordNotify>(() => new SpiceActivityGivingRecordNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpiceActivityGivingRecordNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.SpiceActivityGivingRecordNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpiceActivityGivingRecordNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpiceActivityGivingRecordNotify(SpiceActivityGivingRecordNotify other) : this() {
      currentIncreaseAvatarFetterTimes_ = other.currentIncreaseAvatarFetterTimes_;
      increaseAvatarFetterLimitTimes_ = other.increaseAvatarFetterLimitTimes_;
      avatarId_ = other.avatarId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpiceActivityGivingRecordNotify Clone() {
      return new SpiceActivityGivingRecordNotify(this);
    }

    /// <summary>Field number for the "current_increase_avatar_fetter_times" field.</summary>
    public const int CurrentIncreaseAvatarFetterTimesFieldNumber = 3;
    private uint currentIncreaseAvatarFetterTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurrentIncreaseAvatarFetterTimes {
      get { return currentIncreaseAvatarFetterTimes_; }
      set {
        currentIncreaseAvatarFetterTimes_ = value;
      }
    }

    /// <summary>Field number for the "increase_avatar_fetter_limit_times" field.</summary>
    public const int IncreaseAvatarFetterLimitTimesFieldNumber = 7;
    private uint increaseAvatarFetterLimitTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IncreaseAvatarFetterLimitTimes {
      get { return increaseAvatarFetterLimitTimes_; }
      set {
        increaseAvatarFetterLimitTimes_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 11;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpiceActivityGivingRecordNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpiceActivityGivingRecordNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentIncreaseAvatarFetterTimes != other.CurrentIncreaseAvatarFetterTimes) return false;
      if (IncreaseAvatarFetterLimitTimes != other.IncreaseAvatarFetterLimitTimes) return false;
      if (AvatarId != other.AvatarId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentIncreaseAvatarFetterTimes != 0) hash ^= CurrentIncreaseAvatarFetterTimes.GetHashCode();
      if (IncreaseAvatarFetterLimitTimes != 0) hash ^= IncreaseAvatarFetterLimitTimes.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
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
      if (CurrentIncreaseAvatarFetterTimes != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurrentIncreaseAvatarFetterTimes);
      }
      if (IncreaseAvatarFetterLimitTimes != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IncreaseAvatarFetterLimitTimes);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AvatarId);
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
      if (CurrentIncreaseAvatarFetterTimes != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurrentIncreaseAvatarFetterTimes);
      }
      if (IncreaseAvatarFetterLimitTimes != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IncreaseAvatarFetterLimitTimes);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(AvatarId);
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
      if (CurrentIncreaseAvatarFetterTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrentIncreaseAvatarFetterTimes);
      }
      if (IncreaseAvatarFetterLimitTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IncreaseAvatarFetterLimitTimes);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpiceActivityGivingRecordNotify other) {
      if (other == null) {
        return;
      }
      if (other.CurrentIncreaseAvatarFetterTimes != 0) {
        CurrentIncreaseAvatarFetterTimes = other.CurrentIncreaseAvatarFetterTimes;
      }
      if (other.IncreaseAvatarFetterLimitTimes != 0) {
        IncreaseAvatarFetterLimitTimes = other.IncreaseAvatarFetterLimitTimes;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
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
            CurrentIncreaseAvatarFetterTimes = input.ReadUInt32();
            break;
          }
          case 56: {
            IncreaseAvatarFetterLimitTimes = input.ReadUInt32();
            break;
          }
          case 88: {
            AvatarId = input.ReadUInt32();
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
            CurrentIncreaseAvatarFetterTimes = input.ReadUInt32();
            break;
          }
          case 56: {
            IncreaseAvatarFetterLimitTimes = input.ReadUInt32();
            break;
          }
          case 88: {
            AvatarId = input.ReadUInt32();
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
