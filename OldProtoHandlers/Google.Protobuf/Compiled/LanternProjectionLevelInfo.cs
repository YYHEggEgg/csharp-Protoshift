// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanternProjectionLevelInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from LanternProjectionLevelInfo.proto</summary>
  public static partial class LanternProjectionLevelInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LanternProjectionLevelInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanternProjectionLevelInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBMYW50ZXJuUHJvamVjdGlvbkxldmVsSW5mby5wcm90byKCAQoaTGFudGVy",
            "blByb2plY3Rpb25MZXZlbEluZm8SFwoPbWluX2ZpbmlzaF90aW1lGAEgASgN",
            "EgoKAmlkGAIgASgNEhMKC2lzX2ZpbmlzaGVkGAcgASgIEhQKDGlzX2Nhbl9z",
            "dGFydBgJIAEoCBIUCgxpc19zaG93X3RpcHMYCiABKAhCDKoCCU9sZFByb3Rv",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.LanternProjectionLevelInfo), global::OldProtos.LanternProjectionLevelInfo.Parser, new[]{ "MinFinishTime", "Id", "IsFinished", "IsCanStart", "IsShowTips" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LanternProjectionLevelInfo : pb::IMessage<LanternProjectionLevelInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanternProjectionLevelInfo> _parser = new pb::MessageParser<LanternProjectionLevelInfo>(() => new LanternProjectionLevelInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanternProjectionLevelInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.LanternProjectionLevelInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternProjectionLevelInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternProjectionLevelInfo(LanternProjectionLevelInfo other) : this() {
      minFinishTime_ = other.minFinishTime_;
      id_ = other.id_;
      isFinished_ = other.isFinished_;
      isCanStart_ = other.isCanStart_;
      isShowTips_ = other.isShowTips_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternProjectionLevelInfo Clone() {
      return new LanternProjectionLevelInfo(this);
    }

    /// <summary>Field number for the "min_finish_time" field.</summary>
    public const int MinFinishTimeFieldNumber = 1;
    private uint minFinishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinFinishTime {
      get { return minFinishTime_; }
      set {
        minFinishTime_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 7;
    private bool isFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinished {
      get { return isFinished_; }
      set {
        isFinished_ = value;
      }
    }

    /// <summary>Field number for the "is_can_start" field.</summary>
    public const int IsCanStartFieldNumber = 9;
    private bool isCanStart_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCanStart {
      get { return isCanStart_; }
      set {
        isCanStart_ = value;
      }
    }

    /// <summary>Field number for the "is_show_tips" field.</summary>
    public const int IsShowTipsFieldNumber = 10;
    private bool isShowTips_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsShowTips {
      get { return isShowTips_; }
      set {
        isShowTips_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanternProjectionLevelInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanternProjectionLevelInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinFinishTime != other.MinFinishTime) return false;
      if (Id != other.Id) return false;
      if (IsFinished != other.IsFinished) return false;
      if (IsCanStart != other.IsCanStart) return false;
      if (IsShowTips != other.IsShowTips) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MinFinishTime != 0) hash ^= MinFinishTime.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (IsFinished != false) hash ^= IsFinished.GetHashCode();
      if (IsCanStart != false) hash ^= IsCanStart.GetHashCode();
      if (IsShowTips != false) hash ^= IsShowTips.GetHashCode();
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
      if (MinFinishTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MinFinishTime);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (IsFinished != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinished);
      }
      if (IsCanStart != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsCanStart);
      }
      if (IsShowTips != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsShowTips);
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
      if (MinFinishTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MinFinishTime);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (IsFinished != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinished);
      }
      if (IsCanStart != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsCanStart);
      }
      if (IsShowTips != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsShowTips);
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
      if (MinFinishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinFinishTime);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (IsFinished != false) {
        size += 1 + 1;
      }
      if (IsCanStart != false) {
        size += 1 + 1;
      }
      if (IsShowTips != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanternProjectionLevelInfo other) {
      if (other == null) {
        return;
      }
      if (other.MinFinishTime != 0) {
        MinFinishTime = other.MinFinishTime;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.IsFinished != false) {
        IsFinished = other.IsFinished;
      }
      if (other.IsCanStart != false) {
        IsCanStart = other.IsCanStart;
      }
      if (other.IsShowTips != false) {
        IsShowTips = other.IsShowTips;
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
            MinFinishTime = input.ReadUInt32();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFinished = input.ReadBool();
            break;
          }
          case 72: {
            IsCanStart = input.ReadBool();
            break;
          }
          case 80: {
            IsShowTips = input.ReadBool();
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
            MinFinishTime = input.ReadUInt32();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFinished = input.ReadBool();
            break;
          }
          case 72: {
            IsCanStart = input.ReadBool();
            break;
          }
          case 80: {
            IsShowTips = input.ReadBool();
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
