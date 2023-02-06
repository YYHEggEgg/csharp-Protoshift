// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageCampChallengeLevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from VintageCampChallengeLevelData.proto</summary>
public static partial class VintageCampChallengeLevelDataReflection {

  #region Descriptor
  /// <summary>File descriptor for VintageCampChallengeLevelData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static VintageCampChallengeLevelDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNWaW50YWdlQ2FtcENoYWxsZW5nZUxldmVsRGF0YS5wcm90byJnCh1WaW50",
          "YWdlQ2FtcENoYWxsZW5nZUxldmVsRGF0YRIQCghzdGFnZV9pZBgOIAEoDRIQ",
          "CghsZXZlbF9pZBgLIAEoDRIRCglpc19maW5pc2gYCCABKAgSDwoHaXNfb3Bl",
          "bhgGIAEoCEIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::VintageCampChallengeLevelData), global::VintageCampChallengeLevelData.Parser, new[]{ "StageId", "LevelId", "IsFinish", "IsOpen" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class VintageCampChallengeLevelData : pb::IMessage<VintageCampChallengeLevelData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<VintageCampChallengeLevelData> _parser = new pb::MessageParser<VintageCampChallengeLevelData>(() => new VintageCampChallengeLevelData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<VintageCampChallengeLevelData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::VintageCampChallengeLevelDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageCampChallengeLevelData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageCampChallengeLevelData(VintageCampChallengeLevelData other) : this() {
    stageId_ = other.stageId_;
    levelId_ = other.levelId_;
    isFinish_ = other.isFinish_;
    isOpen_ = other.isOpen_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageCampChallengeLevelData Clone() {
    return new VintageCampChallengeLevelData(this);
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 14;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 11;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "is_finish" field.</summary>
  public const int IsFinishFieldNumber = 8;
  private bool isFinish_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFinish {
    get { return isFinish_; }
    set {
      isFinish_ = value;
    }
  }

  /// <summary>Field number for the "is_open" field.</summary>
  public const int IsOpenFieldNumber = 6;
  private bool isOpen_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsOpen {
    get { return isOpen_; }
    set {
      isOpen_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as VintageCampChallengeLevelData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(VintageCampChallengeLevelData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (StageId != other.StageId) return false;
    if (LevelId != other.LevelId) return false;
    if (IsFinish != other.IsFinish) return false;
    if (IsOpen != other.IsOpen) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (StageId != 0) hash ^= StageId.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (IsFinish != false) hash ^= IsFinish.GetHashCode();
    if (IsOpen != false) hash ^= IsOpen.GetHashCode();
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
    if (IsOpen != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsOpen);
    }
    if (IsFinish != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsFinish);
    }
    if (LevelId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(LevelId);
    }
    if (StageId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(StageId);
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
    if (IsOpen != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsOpen);
    }
    if (IsFinish != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsFinish);
    }
    if (LevelId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(LevelId);
    }
    if (StageId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(StageId);
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
    if (StageId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (IsFinish != false) {
      size += 1 + 1;
    }
    if (IsOpen != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(VintageCampChallengeLevelData other) {
    if (other == null) {
      return;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.IsFinish != false) {
      IsFinish = other.IsFinish;
    }
    if (other.IsOpen != false) {
      IsOpen = other.IsOpen;
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
        case 48: {
          IsOpen = input.ReadBool();
          break;
        }
        case 64: {
          IsFinish = input.ReadBool();
          break;
        }
        case 88: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 112: {
          StageId = input.ReadUInt32();
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
        case 48: {
          IsOpen = input.ReadBool();
          break;
        }
        case 64: {
          IsFinish = input.ReadBool();
          break;
        }
        case 88: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 112: {
          StageId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code