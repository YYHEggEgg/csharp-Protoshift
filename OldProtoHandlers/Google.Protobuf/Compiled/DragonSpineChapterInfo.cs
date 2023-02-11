// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DragonSpineChapterInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from DragonSpineChapterInfo.proto</summary>
  public static partial class DragonSpineChapterInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DragonSpineChapterInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DragonSpineChapterInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxEcmFnb25TcGluZUNoYXB0ZXJJbmZvLnByb3RvIoABChZEcmFnb25TcGlu",
            "ZUNoYXB0ZXJJbmZvEhAKCHByb2dyZXNzGA4gASgNEhEKCW9wZW5fdGltZRgG",
            "IAEoDRIPCgdpc19vcGVuGAsgASgIEhIKCmNoYXB0ZXJfaWQYCSABKA0SHAoU",
            "ZmluaXNoZWRfbWlzc2lvbl9udW0YCiABKA1CDKoCCU9sZFByb3Rvc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.DragonSpineChapterInfo), global::OldProtos.DragonSpineChapterInfo.Parser, new[]{ "Progress", "OpenTime", "IsOpen", "ChapterId", "FinishedMissionNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DragonSpineChapterInfo : pb::IMessage<DragonSpineChapterInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DragonSpineChapterInfo> _parser = new pb::MessageParser<DragonSpineChapterInfo>(() => new DragonSpineChapterInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DragonSpineChapterInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.DragonSpineChapterInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineChapterInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineChapterInfo(DragonSpineChapterInfo other) : this() {
      progress_ = other.progress_;
      openTime_ = other.openTime_;
      isOpen_ = other.isOpen_;
      chapterId_ = other.chapterId_;
      finishedMissionNum_ = other.finishedMissionNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineChapterInfo Clone() {
      return new DragonSpineChapterInfo(this);
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 14;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 6;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 11;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "chapter_id" field.</summary>
    public const int ChapterIdFieldNumber = 9;
    private uint chapterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChapterId {
      get { return chapterId_; }
      set {
        chapterId_ = value;
      }
    }

    /// <summary>Field number for the "finished_mission_num" field.</summary>
    public const int FinishedMissionNumFieldNumber = 10;
    private uint finishedMissionNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishedMissionNum {
      get { return finishedMissionNum_; }
      set {
        finishedMissionNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DragonSpineChapterInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DragonSpineChapterInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Progress != other.Progress) return false;
      if (OpenTime != other.OpenTime) return false;
      if (IsOpen != other.IsOpen) return false;
      if (ChapterId != other.ChapterId) return false;
      if (FinishedMissionNum != other.FinishedMissionNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (ChapterId != 0) hash ^= ChapterId.GetHashCode();
      if (FinishedMissionNum != 0) hash ^= FinishedMissionNum.GetHashCode();
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
      if (OpenTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OpenTime);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChapterId);
      }
      if (FinishedMissionNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FinishedMissionNum);
      }
      if (IsOpen != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsOpen);
      }
      if (Progress != 0) {
        output.WriteRawTag(112);
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
      if (OpenTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OpenTime);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChapterId);
      }
      if (FinishedMissionNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FinishedMissionNum);
      }
      if (IsOpen != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsOpen);
      }
      if (Progress != 0) {
        output.WriteRawTag(112);
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
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (ChapterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChapterId);
      }
      if (FinishedMissionNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishedMissionNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DragonSpineChapterInfo other) {
      if (other == null) {
        return;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.ChapterId != 0) {
        ChapterId = other.ChapterId;
      }
      if (other.FinishedMissionNum != 0) {
        FinishedMissionNum = other.FinishedMissionNum;
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
            OpenTime = input.ReadUInt32();
            break;
          }
          case 72: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 80: {
            FinishedMissionNum = input.ReadUInt32();
            break;
          }
          case 88: {
            IsOpen = input.ReadBool();
            break;
          }
          case 112: {
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
          case 48: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 72: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 80: {
            FinishedMissionNum = input.ReadUInt32();
            break;
          }
          case 88: {
            IsOpen = input.ReadBool();
            break;
          }
          case 112: {
            Progress = input.ReadUInt32();
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