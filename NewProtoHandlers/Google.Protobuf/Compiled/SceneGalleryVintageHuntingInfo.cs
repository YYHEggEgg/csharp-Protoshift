// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryVintageHuntingInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SceneGalleryVintageHuntingInfo.proto</summary>
  public static partial class SceneGalleryVintageHuntingInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryVintageHuntingInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryVintageHuntingInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRTY2VuZUdhbGxlcnlWaW50YWdlSHVudGluZ0luZm8ucHJvdG8aIlZpbnRh",
            "Z2VIdW50aW5nRmlyc3RTdGFnZUluZm8ucHJvdG8aI1ZpbnRhZ2VIdW50aW5n",
            "U2Vjb25kU3RhZ2VJbmZvLnByb3RvGiJWaW50YWdlSHVudGluZ1RoaXJkU3Rh",
            "Z2VJbmZvLnByb3RvIu0BCh5TY2VuZUdhbGxlcnlWaW50YWdlSHVudGluZ0lu",
            "Zm8SEAoIc3RhZ2VfaWQYCSABKA0SOQoQZmlyc3Rfc3RhZ2VfaW5mbxgFIAEo",
            "CzIdLlZpbnRhZ2VIdW50aW5nRmlyc3RTdGFnZUluZm9IABI7ChFzZWNvbmRf",
            "c3RhZ2VfaW5mbxgOIAEoCzIeLlZpbnRhZ2VIdW50aW5nU2Vjb25kU3RhZ2VJ",
            "bmZvSAASOQoQdGhpcmRfc3RhZ2VfaW5mbxgIIAEoCzIdLlZpbnRhZ2VIdW50",
            "aW5nVGhpcmRTdGFnZUluZm9IAEIGCgRpbmZvQgyqAglOZXdQcm90b3NiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VintageHuntingFirstStageInfoReflection.Descriptor, global::NewProtos.VintageHuntingSecondStageInfoReflection.Descriptor, global::NewProtos.VintageHuntingThirdStageInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SceneGalleryVintageHuntingInfo), global::NewProtos.SceneGalleryVintageHuntingInfo.Parser, new[]{ "StageId", "FirstStageInfo", "SecondStageInfo", "ThirdStageInfo" }, new[]{ "Info" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryVintageHuntingInfo : pb::IMessage<SceneGalleryVintageHuntingInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryVintageHuntingInfo> _parser = new pb::MessageParser<SceneGalleryVintageHuntingInfo>(() => new SceneGalleryVintageHuntingInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryVintageHuntingInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SceneGalleryVintageHuntingInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryVintageHuntingInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryVintageHuntingInfo(SceneGalleryVintageHuntingInfo other) : this() {
      stageId_ = other.stageId_;
      switch (other.InfoCase) {
        case InfoOneofCase.FirstStageInfo:
          FirstStageInfo = other.FirstStageInfo.Clone();
          break;
        case InfoOneofCase.SecondStageInfo:
          SecondStageInfo = other.SecondStageInfo.Clone();
          break;
        case InfoOneofCase.ThirdStageInfo:
          ThirdStageInfo = other.ThirdStageInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryVintageHuntingInfo Clone() {
      return new SceneGalleryVintageHuntingInfo(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 9;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "first_stage_info" field.</summary>
    public const int FirstStageInfoFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.VintageHuntingFirstStageInfo FirstStageInfo {
      get { return infoCase_ == InfoOneofCase.FirstStageInfo ? (global::NewProtos.VintageHuntingFirstStageInfo) info_ : null; }
      set {
        info_ = value;
        infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.FirstStageInfo;
      }
    }

    /// <summary>Field number for the "second_stage_info" field.</summary>
    public const int SecondStageInfoFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.VintageHuntingSecondStageInfo SecondStageInfo {
      get { return infoCase_ == InfoOneofCase.SecondStageInfo ? (global::NewProtos.VintageHuntingSecondStageInfo) info_ : null; }
      set {
        info_ = value;
        infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.SecondStageInfo;
      }
    }

    /// <summary>Field number for the "third_stage_info" field.</summary>
    public const int ThirdStageInfoFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.VintageHuntingThirdStageInfo ThirdStageInfo {
      get { return infoCase_ == InfoOneofCase.ThirdStageInfo ? (global::NewProtos.VintageHuntingThirdStageInfo) info_ : null; }
      set {
        info_ = value;
        infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.ThirdStageInfo;
      }
    }

    private object info_;
    /// <summary>Enum of possible cases for the "info" oneof.</summary>
    public enum InfoOneofCase {
      None = 0,
      FirstStageInfo = 5,
      SecondStageInfo = 14,
      ThirdStageInfo = 8,
    }
    private InfoOneofCase infoCase_ = InfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InfoOneofCase InfoCase {
      get { return infoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInfo() {
      infoCase_ = InfoOneofCase.None;
      info_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryVintageHuntingInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryVintageHuntingInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if (!object.Equals(FirstStageInfo, other.FirstStageInfo)) return false;
      if (!object.Equals(SecondStageInfo, other.SecondStageInfo)) return false;
      if (!object.Equals(ThirdStageInfo, other.ThirdStageInfo)) return false;
      if (InfoCase != other.InfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (infoCase_ == InfoOneofCase.FirstStageInfo) hash ^= FirstStageInfo.GetHashCode();
      if (infoCase_ == InfoOneofCase.SecondStageInfo) hash ^= SecondStageInfo.GetHashCode();
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) hash ^= ThirdStageInfo.GetHashCode();
      hash ^= (int) infoCase_;
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
      if (infoCase_ == InfoOneofCase.FirstStageInfo) {
        output.WriteRawTag(42);
        output.WriteMessage(FirstStageInfo);
      }
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
        output.WriteRawTag(66);
        output.WriteMessage(ThirdStageInfo);
      }
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (infoCase_ == InfoOneofCase.SecondStageInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(SecondStageInfo);
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
      if (infoCase_ == InfoOneofCase.FirstStageInfo) {
        output.WriteRawTag(42);
        output.WriteMessage(FirstStageInfo);
      }
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
        output.WriteRawTag(66);
        output.WriteMessage(ThirdStageInfo);
      }
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (infoCase_ == InfoOneofCase.SecondStageInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(SecondStageInfo);
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
      if (infoCase_ == InfoOneofCase.FirstStageInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FirstStageInfo);
      }
      if (infoCase_ == InfoOneofCase.SecondStageInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecondStageInfo);
      }
      if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ThirdStageInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryVintageHuntingInfo other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      switch (other.InfoCase) {
        case InfoOneofCase.FirstStageInfo:
          if (FirstStageInfo == null) {
            FirstStageInfo = new global::NewProtos.VintageHuntingFirstStageInfo();
          }
          FirstStageInfo.MergeFrom(other.FirstStageInfo);
          break;
        case InfoOneofCase.SecondStageInfo:
          if (SecondStageInfo == null) {
            SecondStageInfo = new global::NewProtos.VintageHuntingSecondStageInfo();
          }
          SecondStageInfo.MergeFrom(other.SecondStageInfo);
          break;
        case InfoOneofCase.ThirdStageInfo:
          if (ThirdStageInfo == null) {
            ThirdStageInfo = new global::NewProtos.VintageHuntingThirdStageInfo();
          }
          ThirdStageInfo.MergeFrom(other.ThirdStageInfo);
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
          case 42: {
            global::NewProtos.VintageHuntingFirstStageInfo subBuilder = new global::NewProtos.VintageHuntingFirstStageInfo();
            if (infoCase_ == InfoOneofCase.FirstStageInfo) {
              subBuilder.MergeFrom(FirstStageInfo);
            }
            input.ReadMessage(subBuilder);
            FirstStageInfo = subBuilder;
            break;
          }
          case 66: {
            global::NewProtos.VintageHuntingThirdStageInfo subBuilder = new global::NewProtos.VintageHuntingThirdStageInfo();
            if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
              subBuilder.MergeFrom(ThirdStageInfo);
            }
            input.ReadMessage(subBuilder);
            ThirdStageInfo = subBuilder;
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 114: {
            global::NewProtos.VintageHuntingSecondStageInfo subBuilder = new global::NewProtos.VintageHuntingSecondStageInfo();
            if (infoCase_ == InfoOneofCase.SecondStageInfo) {
              subBuilder.MergeFrom(SecondStageInfo);
            }
            input.ReadMessage(subBuilder);
            SecondStageInfo = subBuilder;
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
          case 42: {
            global::NewProtos.VintageHuntingFirstStageInfo subBuilder = new global::NewProtos.VintageHuntingFirstStageInfo();
            if (infoCase_ == InfoOneofCase.FirstStageInfo) {
              subBuilder.MergeFrom(FirstStageInfo);
            }
            input.ReadMessage(subBuilder);
            FirstStageInfo = subBuilder;
            break;
          }
          case 66: {
            global::NewProtos.VintageHuntingThirdStageInfo subBuilder = new global::NewProtos.VintageHuntingThirdStageInfo();
            if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
              subBuilder.MergeFrom(ThirdStageInfo);
            }
            input.ReadMessage(subBuilder);
            ThirdStageInfo = subBuilder;
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 114: {
            global::NewProtos.VintageHuntingSecondStageInfo subBuilder = new global::NewProtos.VintageHuntingSecondStageInfo();
            if (infoCase_ == InfoOneofCase.SecondStageInfo) {
              subBuilder.MergeFrom(SecondStageInfo);
            }
            input.ReadMessage(subBuilder);
            SecondStageInfo = subBuilder;
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