// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageHuntingSecondStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from VintageHuntingSecondStageInfo.proto</summary>
  public static partial class VintageHuntingSecondStageInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageHuntingSecondStageInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageHuntingSecondStageInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNWaW50YWdlSHVudGluZ1NlY29uZFN0YWdlSW5mby5wcm90byJgCh1WaW50",
            "YWdlSHVudGluZ1NlY29uZFN0YWdlSW5mbxIQCghsZWZ0X251bRgPIAEoDRIR",
            "Cgl0b3RhbF9udW0YDSABKA0SGgoSY2FwdHVyZV9hbmltYWxfbnVtGAogASgN",
            "QgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.VintageHuntingSecondStageInfo), global::NewProtos.VintageHuntingSecondStageInfo.Parser, new[]{ "LeftNum", "TotalNum", "CaptureAnimalNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageHuntingSecondStageInfo : pb::IMessage<VintageHuntingSecondStageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageHuntingSecondStageInfo> _parser = new pb::MessageParser<VintageHuntingSecondStageInfo>(() => new VintageHuntingSecondStageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageHuntingSecondStageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.VintageHuntingSecondStageInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingSecondStageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingSecondStageInfo(VintageHuntingSecondStageInfo other) : this() {
      leftNum_ = other.leftNum_;
      totalNum_ = other.totalNum_;
      captureAnimalNum_ = other.captureAnimalNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingSecondStageInfo Clone() {
      return new VintageHuntingSecondStageInfo(this);
    }

    /// <summary>Field number for the "left_num" field.</summary>
    public const int LeftNumFieldNumber = 15;
    private uint leftNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftNum {
      get { return leftNum_; }
      set {
        leftNum_ = value;
      }
    }

    /// <summary>Field number for the "total_num" field.</summary>
    public const int TotalNumFieldNumber = 13;
    private uint totalNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalNum {
      get { return totalNum_; }
      set {
        totalNum_ = value;
      }
    }

    /// <summary>Field number for the "capture_animal_num" field.</summary>
    public const int CaptureAnimalNumFieldNumber = 10;
    private uint captureAnimalNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CaptureAnimalNum {
      get { return captureAnimalNum_; }
      set {
        captureAnimalNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageHuntingSecondStageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageHuntingSecondStageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LeftNum != other.LeftNum) return false;
      if (TotalNum != other.TotalNum) return false;
      if (CaptureAnimalNum != other.CaptureAnimalNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LeftNum != 0) hash ^= LeftNum.GetHashCode();
      if (TotalNum != 0) hash ^= TotalNum.GetHashCode();
      if (CaptureAnimalNum != 0) hash ^= CaptureAnimalNum.GetHashCode();
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
      if (CaptureAnimalNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CaptureAnimalNum);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalNum);
      }
      if (LeftNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LeftNum);
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
      if (CaptureAnimalNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CaptureAnimalNum);
      }
      if (TotalNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalNum);
      }
      if (LeftNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LeftNum);
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
      if (LeftNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftNum);
      }
      if (TotalNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalNum);
      }
      if (CaptureAnimalNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CaptureAnimalNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageHuntingSecondStageInfo other) {
      if (other == null) {
        return;
      }
      if (other.LeftNum != 0) {
        LeftNum = other.LeftNum;
      }
      if (other.TotalNum != 0) {
        TotalNum = other.TotalNum;
      }
      if (other.CaptureAnimalNum != 0) {
        CaptureAnimalNum = other.CaptureAnimalNum;
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
          case 80: {
            CaptureAnimalNum = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalNum = input.ReadUInt32();
            break;
          }
          case 120: {
            LeftNum = input.ReadUInt32();
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
          case 80: {
            CaptureAnimalNum = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalNum = input.ReadUInt32();
            break;
          }
          case 120: {
            LeftNum = input.ReadUInt32();
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
