// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintagePresentStageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from VintagePresentStageData.proto</summary>
  public static partial class VintagePresentStageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for VintagePresentStageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintagePresentStageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1WaW50YWdlUHJlc2VudFN0YWdlRGF0YS5wcm90bxodVmludGFnZVByZXNl",
            "bnRMZXZlbERhdGEucHJvdG8i/gEKF1ZpbnRhZ2VQcmVzZW50U3RhZ2VEYXRh",
            "EhEKCW9wZW5fdGltZRgBIAEoDRIQCghzdGFnZV9pZBgPIAEoDRIRCglpc19m",
            "aW5pc2gYDSABKAgSDwoHaXNfb3BlbhgKIAEoCBJIChFwcmVzZW50X2xldmVs",
            "X21hcBgCIAMoCzItLlZpbnRhZ2VQcmVzZW50U3RhZ2VEYXRhLlByZXNlbnRM",
            "ZXZlbE1hcEVudHJ5GlAKFFByZXNlbnRMZXZlbE1hcEVudHJ5EgsKA2tleRgB",
            "IAEoDRInCgV2YWx1ZRgCIAEoCzIYLlZpbnRhZ2VQcmVzZW50TGV2ZWxEYXRh",
            "OgI4AUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VintagePresentLevelDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.VintagePresentStageData), global::OldProtos.VintagePresentStageData.Parser, new[]{ "OpenTime", "StageId", "IsFinish", "IsOpen", "PresentLevelMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintagePresentStageData : pb::IMessage<VintagePresentStageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintagePresentStageData> _parser = new pb::MessageParser<VintagePresentStageData>(() => new VintagePresentStageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintagePresentStageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.VintagePresentStageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintagePresentStageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintagePresentStageData(VintagePresentStageData other) : this() {
      openTime_ = other.openTime_;
      stageId_ = other.stageId_;
      isFinish_ = other.isFinish_;
      isOpen_ = other.isOpen_;
      presentLevelMap_ = other.presentLevelMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintagePresentStageData Clone() {
      return new VintagePresentStageData(this);
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 1;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 15;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 13;
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
    public const int IsOpenFieldNumber = 10;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "present_level_map" field.</summary>
    public const int PresentLevelMapFieldNumber = 2;
    private static readonly pbc::MapField<uint, global::OldProtos.VintagePresentLevelData>.Codec _map_presentLevelMap_codec
        = new pbc::MapField<uint, global::OldProtos.VintagePresentLevelData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.VintagePresentLevelData.Parser), 18);
    private readonly pbc::MapField<uint, global::OldProtos.VintagePresentLevelData> presentLevelMap_ = new pbc::MapField<uint, global::OldProtos.VintagePresentLevelData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.VintagePresentLevelData> PresentLevelMap {
      get { return presentLevelMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintagePresentStageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintagePresentStageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpenTime != other.OpenTime) return false;
      if (StageId != other.StageId) return false;
      if (IsFinish != other.IsFinish) return false;
      if (IsOpen != other.IsOpen) return false;
      if (!PresentLevelMap.Equals(other.PresentLevelMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      hash ^= PresentLevelMap.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(OpenTime);
      }
      presentLevelMap_.WriteTo(output, _map_presentLevelMap_codec);
      if (IsOpen != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsOpen);
      }
      if (IsFinish != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsFinish);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
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
      if (OpenTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OpenTime);
      }
      presentLevelMap_.WriteTo(ref output, _map_presentLevelMap_codec);
      if (IsOpen != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsOpen);
      }
      if (IsFinish != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsFinish);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
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
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      size += presentLevelMap_.CalculateSize(_map_presentLevelMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintagePresentStageData other) {
      if (other == null) {
        return;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      presentLevelMap_.Add(other.presentLevelMap_);
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
            OpenTime = input.ReadUInt32();
            break;
          }
          case 18: {
            presentLevelMap_.AddEntriesFrom(input, _map_presentLevelMap_codec);
            break;
          }
          case 80: {
            IsOpen = input.ReadBool();
            break;
          }
          case 104: {
            IsFinish = input.ReadBool();
            break;
          }
          case 120: {
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
          case 8: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 18: {
            presentLevelMap_.AddEntriesFrom(ref input, _map_presentLevelMap_codec);
            break;
          }
          case 80: {
            IsOpen = input.ReadBool();
            break;
          }
          case 104: {
            IsFinish = input.ReadBool();
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
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
