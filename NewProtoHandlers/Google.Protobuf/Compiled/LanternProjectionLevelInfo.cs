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
          "blByb2plY3Rpb25MZXZlbEluZm8SEwoLaXNfZmluaXNoZWQYByABKAgSFAoM",
          "aXNfY2FuX3N0YXJ0GA4gASgIEgoKAmlkGAogASgNEhQKDGlzX3Nob3dfdGlw",
          "cxgPIAEoCBIXCg9taW5fZmluaXNoX3RpbWUYBSABKA1CFgoUb3JnLnNvcmFw",
          "b2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::LanternProjectionLevelInfo), global::LanternProjectionLevelInfo.Parser, new[]{ "IsFinished", "IsCanStart", "Id", "IsShowTips", "MinFinishTime" }, null, null, null, null)
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
    get { return global::LanternProjectionLevelInfoReflection.Descriptor.MessageTypes[0]; }
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
    isFinished_ = other.isFinished_;
    isCanStart_ = other.isCanStart_;
    id_ = other.id_;
    isShowTips_ = other.isShowTips_;
    minFinishTime_ = other.minFinishTime_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public LanternProjectionLevelInfo Clone() {
    return new LanternProjectionLevelInfo(this);
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
  public const int IsCanStartFieldNumber = 14;
  private bool isCanStart_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsCanStart {
    get { return isCanStart_; }
    set {
      isCanStart_ = value;
    }
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 10;
  private uint id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "is_show_tips" field.</summary>
  public const int IsShowTipsFieldNumber = 15;
  private bool isShowTips_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsShowTips {
    get { return isShowTips_; }
    set {
      isShowTips_ = value;
    }
  }

  /// <summary>Field number for the "min_finish_time" field.</summary>
  public const int MinFinishTimeFieldNumber = 5;
  private uint minFinishTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MinFinishTime {
    get { return minFinishTime_; }
    set {
      minFinishTime_ = value;
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
    if (IsFinished != other.IsFinished) return false;
    if (IsCanStart != other.IsCanStart) return false;
    if (Id != other.Id) return false;
    if (IsShowTips != other.IsShowTips) return false;
    if (MinFinishTime != other.MinFinishTime) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsFinished != false) hash ^= IsFinished.GetHashCode();
    if (IsCanStart != false) hash ^= IsCanStart.GetHashCode();
    if (Id != 0) hash ^= Id.GetHashCode();
    if (IsShowTips != false) hash ^= IsShowTips.GetHashCode();
    if (MinFinishTime != 0) hash ^= MinFinishTime.GetHashCode();
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
      output.WriteRawTag(40);
      output.WriteUInt32(MinFinishTime);
    }
    if (IsFinished != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsFinished);
    }
    if (Id != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Id);
    }
    if (IsCanStart != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsCanStart);
    }
    if (IsShowTips != false) {
      output.WriteRawTag(120);
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
      output.WriteRawTag(40);
      output.WriteUInt32(MinFinishTime);
    }
    if (IsFinished != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsFinished);
    }
    if (Id != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Id);
    }
    if (IsCanStart != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsCanStart);
    }
    if (IsShowTips != false) {
      output.WriteRawTag(120);
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
    if (IsFinished != false) {
      size += 1 + 1;
    }
    if (IsCanStart != false) {
      size += 1 + 1;
    }
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (IsShowTips != false) {
      size += 1 + 1;
    }
    if (MinFinishTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinFinishTime);
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
    if (other.IsFinished != false) {
      IsFinished = other.IsFinished;
    }
    if (other.IsCanStart != false) {
      IsCanStart = other.IsCanStart;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.IsShowTips != false) {
      IsShowTips = other.IsShowTips;
    }
    if (other.MinFinishTime != 0) {
      MinFinishTime = other.MinFinishTime;
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
        case 40: {
          MinFinishTime = input.ReadUInt32();
          break;
        }
        case 56: {
          IsFinished = input.ReadBool();
          break;
        }
        case 80: {
          Id = input.ReadUInt32();
          break;
        }
        case 112: {
          IsCanStart = input.ReadBool();
          break;
        }
        case 120: {
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
        case 40: {
          MinFinishTime = input.ReadUInt32();
          break;
        }
        case 56: {
          IsFinished = input.ReadBool();
          break;
        }
        case 80: {
          Id = input.ReadUInt32();
          break;
        }
        case 112: {
          IsCanStart = input.ReadBool();
          break;
        }
        case 120: {
          IsShowTips = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
