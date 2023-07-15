// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SummerTimeDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from SummerTimeDetailInfo.proto</summary>
  public static partial class SummerTimeDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SummerTimeDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SummerTimeDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTdW1tZXJUaW1lRGV0YWlsSW5mby5wcm90bxoeU3VtbWVyVGltZVNwcmlu",
            "dEJvYXRJbmZvLnByb3RvGhlTdW1tZXJUaW1lU3RhZ2VJbmZvLnByb3RvIoEC",
            "ChRTdW1tZXJUaW1lRGV0YWlsSW5mbxI2CglzdGFnZV9tYXAYAyADKAsyIy5T",
            "dW1tZXJUaW1lRGV0YWlsSW5mby5TdGFnZU1hcEVudHJ5EhoKEmNvbnRlbnRf",
            "Y2xvc2VfdGltZRgLIAEoDRIZChFpc19jb250ZW50X2Nsb3NlZBgNIAEoCBIz",
            "ChBzcHJpbnRfYm9hdF9pbmZvGAQgASgLMhkuU3VtbWVyVGltZVNwcmludEJv",
            "YXRJbmZvGkUKDVN0YWdlTWFwRW50cnkSCwoDa2V5GAEgASgNEiMKBXZhbHVl",
            "GAIgASgLMhQuU3VtbWVyVGltZVN0YWdlSW5mbzoCOAFCDKoCCU9sZFByb3Rv",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.SummerTimeSprintBoatInfoReflection.Descriptor, global::OldProtos.SummerTimeStageInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.SummerTimeDetailInfo), global::OldProtos.SummerTimeDetailInfo.Parser, new[]{ "StageMap", "ContentCloseTime", "IsContentClosed", "SprintBoatInfo" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SummerTimeDetailInfo : pb::IMessage<SummerTimeDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SummerTimeDetailInfo> _parser = new pb::MessageParser<SummerTimeDetailInfo>(() => new SummerTimeDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SummerTimeDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.SummerTimeDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeDetailInfo(SummerTimeDetailInfo other) : this() {
      stageMap_ = other.stageMap_.Clone();
      contentCloseTime_ = other.contentCloseTime_;
      isContentClosed_ = other.isContentClosed_;
      sprintBoatInfo_ = other.sprintBoatInfo_ != null ? other.sprintBoatInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeDetailInfo Clone() {
      return new SummerTimeDetailInfo(this);
    }

    /// <summary>Field number for the "stage_map" field.</summary>
    public const int StageMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, global::OldProtos.SummerTimeStageInfo>.Codec _map_stageMap_codec
        = new pbc::MapField<uint, global::OldProtos.SummerTimeStageInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.SummerTimeStageInfo.Parser), 26);
    private readonly pbc::MapField<uint, global::OldProtos.SummerTimeStageInfo> stageMap_ = new pbc::MapField<uint, global::OldProtos.SummerTimeStageInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.SummerTimeStageInfo> StageMap {
      get { return stageMap_; }
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 11;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 13;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "sprint_boat_info" field.</summary>
    public const int SprintBoatInfoFieldNumber = 4;
    private global::OldProtos.SummerTimeSprintBoatInfo sprintBoatInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.SummerTimeSprintBoatInfo SprintBoatInfo {
      get { return sprintBoatInfo_; }
      set {
        sprintBoatInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SummerTimeDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SummerTimeDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!StageMap.Equals(other.StageMap)) return false;
      if (ContentCloseTime != other.ContentCloseTime) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (!object.Equals(SprintBoatInfo, other.SprintBoatInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= StageMap.GetHashCode();
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (sprintBoatInfo_ != null) hash ^= SprintBoatInfo.GetHashCode();
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
      stageMap_.WriteTo(output, _map_stageMap_codec);
      if (sprintBoatInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SprintBoatInfo);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ContentCloseTime);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsContentClosed);
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
      stageMap_.WriteTo(ref output, _map_stageMap_codec);
      if (sprintBoatInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SprintBoatInfo);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ContentCloseTime);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsContentClosed);
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
      size += stageMap_.CalculateSize(_map_stageMap_codec);
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (sprintBoatInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SprintBoatInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SummerTimeDetailInfo other) {
      if (other == null) {
        return;
      }
      stageMap_.MergeFrom(other.stageMap_);
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.sprintBoatInfo_ != null) {
        if (sprintBoatInfo_ == null) {
          SprintBoatInfo = new global::OldProtos.SummerTimeSprintBoatInfo();
        }
        SprintBoatInfo.MergeFrom(other.SprintBoatInfo);
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
          case 26: {
            stageMap_.AddEntriesFrom(input, _map_stageMap_codec);
            break;
          }
          case 34: {
            if (sprintBoatInfo_ == null) {
              SprintBoatInfo = new global::OldProtos.SummerTimeSprintBoatInfo();
            }
            input.ReadMessage(SprintBoatInfo);
            break;
          }
          case 88: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 104: {
            IsContentClosed = input.ReadBool();
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
          case 26: {
            stageMap_.AddEntriesFrom(ref input, _map_stageMap_codec);
            break;
          }
          case 34: {
            if (sprintBoatInfo_ == null) {
              SprintBoatInfo = new global::OldProtos.SummerTimeSprintBoatInfo();
            }
            input.ReadMessage(SprintBoatInfo);
            break;
          }
          case 88: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 104: {
            IsContentClosed = input.ReadBool();
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
