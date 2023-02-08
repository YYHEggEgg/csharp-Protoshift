// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuickUseWidgetRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from QuickUseWidgetRsp.proto</summary>
  public static partial class QuickUseWidgetRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QuickUseWidgetRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuickUseWidgetRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdRdWlja1VzZVdpZGdldFJzcC5wcm90bxoZQ2xpZW50Q29sbGVjdG9yRGF0",
            "YS5wcm90bxojT25lb2ZmR2F0aGVyUG9pbnREZXRlY3RvckRhdGEucHJvdG8a",
            "JlNreUNyeXN0YWxEZXRlY3RvclF1aWNrVXNlUmVzdWx0LnByb3RvIogCChFR",
            "dWlja1VzZVdpZGdldFJzcBITCgttYXRlcmlhbF9pZBgLIAEoDRIPCgdyZXRj",
            "b2RlGAwgASgFEjcKDWRldGVjdG9yX2RhdGEYDiABKAsyHi5PbmVvZmZHYXRo",
            "ZXJQb2ludERldGVjdG9yRGF0YUgAEjUKFWNsaWVudF9jb2xsZWN0b3JfZGF0",
            "YRgKIAEoCzIULkNsaWVudENvbGxlY3RvckRhdGFIABJUCiVza3lfY3J5c3Rh",
            "bF9kZXRlY3Rvcl9xdWlja191c2VfcmVzdWx0GKLCCiABKAsyIS5Ta3lDcnlz",
            "dGFsRGV0ZWN0b3JRdWlja1VzZVJlc3VsdEgAQgcKBXBhcmFtQgyqAglOZXdQ",
            "cm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ClientCollectorDataReflection.Descriptor, global::NewProtos.OneoffGatherPointDetectorDataReflection.Descriptor, global::NewProtos.SkyCrystalDetectorQuickUseResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.QuickUseWidgetRsp), global::NewProtos.QuickUseWidgetRsp.Parser, new[]{ "MaterialId", "Retcode", "DetectorData", "ClientCollectorData", "SkyCrystalDetectorQuickUseResult" }, new[]{ "Param" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4265;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class QuickUseWidgetRsp : pb::IMessage<QuickUseWidgetRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuickUseWidgetRsp> _parser = new pb::MessageParser<QuickUseWidgetRsp>(() => new QuickUseWidgetRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuickUseWidgetRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.QuickUseWidgetRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuickUseWidgetRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuickUseWidgetRsp(QuickUseWidgetRsp other) : this() {
      materialId_ = other.materialId_;
      retcode_ = other.retcode_;
      switch (other.ParamCase) {
        case ParamOneofCase.DetectorData:
          DetectorData = other.DetectorData.Clone();
          break;
        case ParamOneofCase.ClientCollectorData:
          ClientCollectorData = other.ClientCollectorData.Clone();
          break;
        case ParamOneofCase.SkyCrystalDetectorQuickUseResult:
          SkyCrystalDetectorQuickUseResult = other.SkyCrystalDetectorQuickUseResult.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuickUseWidgetRsp Clone() {
      return new QuickUseWidgetRsp(this);
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 11;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "detector_data" field.</summary>
    public const int DetectorDataFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.OneoffGatherPointDetectorData DetectorData {
      get { return paramCase_ == ParamOneofCase.DetectorData ? (global::NewProtos.OneoffGatherPointDetectorData) param_ : null; }
      set {
        param_ = value;
        paramCase_ = value == null ? ParamOneofCase.None : ParamOneofCase.DetectorData;
      }
    }

    /// <summary>Field number for the "client_collector_data" field.</summary>
    public const int ClientCollectorDataFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ClientCollectorData ClientCollectorData {
      get { return paramCase_ == ParamOneofCase.ClientCollectorData ? (global::NewProtos.ClientCollectorData) param_ : null; }
      set {
        param_ = value;
        paramCase_ = value == null ? ParamOneofCase.None : ParamOneofCase.ClientCollectorData;
      }
    }

    /// <summary>Field number for the "sky_crystal_detector_quick_use_result" field.</summary>
    public const int SkyCrystalDetectorQuickUseResultFieldNumber = 172322;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.SkyCrystalDetectorQuickUseResult SkyCrystalDetectorQuickUseResult {
      get { return paramCase_ == ParamOneofCase.SkyCrystalDetectorQuickUseResult ? (global::NewProtos.SkyCrystalDetectorQuickUseResult) param_ : null; }
      set {
        param_ = value;
        paramCase_ = value == null ? ParamOneofCase.None : ParamOneofCase.SkyCrystalDetectorQuickUseResult;
      }
    }

    private object param_;
    /// <summary>Enum of possible cases for the "param" oneof.</summary>
    public enum ParamOneofCase {
      None = 0,
      DetectorData = 14,
      ClientCollectorData = 10,
      SkyCrystalDetectorQuickUseResult = 172322,
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
      return Equals(other as QuickUseWidgetRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuickUseWidgetRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaterialId != other.MaterialId) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(DetectorData, other.DetectorData)) return false;
      if (!object.Equals(ClientCollectorData, other.ClientCollectorData)) return false;
      if (!object.Equals(SkyCrystalDetectorQuickUseResult, other.SkyCrystalDetectorQuickUseResult)) return false;
      if (ParamCase != other.ParamCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (paramCase_ == ParamOneofCase.DetectorData) hash ^= DetectorData.GetHashCode();
      if (paramCase_ == ParamOneofCase.ClientCollectorData) hash ^= ClientCollectorData.GetHashCode();
      if (paramCase_ == ParamOneofCase.SkyCrystalDetectorQuickUseResult) hash ^= SkyCrystalDetectorQuickUseResult.GetHashCode();
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
      if (paramCase_ == ParamOneofCase.ClientCollectorData) {
        output.WriteRawTag(82);
        output.WriteMessage(ClientCollectorData);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaterialId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (paramCase_ == ParamOneofCase.DetectorData) {
        output.WriteRawTag(114);
        output.WriteMessage(DetectorData);
      }
      if (paramCase_ == ParamOneofCase.SkyCrystalDetectorQuickUseResult) {
        output.WriteRawTag(146, 146, 84);
        output.WriteMessage(SkyCrystalDetectorQuickUseResult);
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
      if (paramCase_ == ParamOneofCase.ClientCollectorData) {
        output.WriteRawTag(82);
        output.WriteMessage(ClientCollectorData);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaterialId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (paramCase_ == ParamOneofCase.DetectorData) {
        output.WriteRawTag(114);
        output.WriteMessage(DetectorData);
      }
      if (paramCase_ == ParamOneofCase.SkyCrystalDetectorQuickUseResult) {
        output.WriteRawTag(146, 146, 84);
        output.WriteMessage(SkyCrystalDetectorQuickUseResult);
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
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (paramCase_ == ParamOneofCase.DetectorData) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DetectorData);
      }
      if (paramCase_ == ParamOneofCase.ClientCollectorData) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClientCollectorData);
      }
      if (paramCase_ == ParamOneofCase.SkyCrystalDetectorQuickUseResult) {
        size += 3 + pb::CodedOutputStream.ComputeMessageSize(SkyCrystalDetectorQuickUseResult);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuickUseWidgetRsp other) {
      if (other == null) {
        return;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      switch (other.ParamCase) {
        case ParamOneofCase.DetectorData:
          if (DetectorData == null) {
            DetectorData = new global::NewProtos.OneoffGatherPointDetectorData();
          }
          DetectorData.MergeFrom(other.DetectorData);
          break;
        case ParamOneofCase.ClientCollectorData:
          if (ClientCollectorData == null) {
            ClientCollectorData = new global::NewProtos.ClientCollectorData();
          }
          ClientCollectorData.MergeFrom(other.ClientCollectorData);
          break;
        case ParamOneofCase.SkyCrystalDetectorQuickUseResult:
          if (SkyCrystalDetectorQuickUseResult == null) {
            SkyCrystalDetectorQuickUseResult = new global::NewProtos.SkyCrystalDetectorQuickUseResult();
          }
          SkyCrystalDetectorQuickUseResult.MergeFrom(other.SkyCrystalDetectorQuickUseResult);
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
          case 82: {
            global::NewProtos.ClientCollectorData subBuilder = new global::NewProtos.ClientCollectorData();
            if (paramCase_ == ParamOneofCase.ClientCollectorData) {
              subBuilder.MergeFrom(ClientCollectorData);
            }
            input.ReadMessage(subBuilder);
            ClientCollectorData = subBuilder;
            break;
          }
          case 88: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            global::NewProtos.OneoffGatherPointDetectorData subBuilder = new global::NewProtos.OneoffGatherPointDetectorData();
            if (paramCase_ == ParamOneofCase.DetectorData) {
              subBuilder.MergeFrom(DetectorData);
            }
            input.ReadMessage(subBuilder);
            DetectorData = subBuilder;
            break;
          }
          case 1378578: {
            global::NewProtos.SkyCrystalDetectorQuickUseResult subBuilder = new global::NewProtos.SkyCrystalDetectorQuickUseResult();
            if (paramCase_ == ParamOneofCase.SkyCrystalDetectorQuickUseResult) {
              subBuilder.MergeFrom(SkyCrystalDetectorQuickUseResult);
            }
            input.ReadMessage(subBuilder);
            SkyCrystalDetectorQuickUseResult = subBuilder;
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
          case 82: {
            global::NewProtos.ClientCollectorData subBuilder = new global::NewProtos.ClientCollectorData();
            if (paramCase_ == ParamOneofCase.ClientCollectorData) {
              subBuilder.MergeFrom(ClientCollectorData);
            }
            input.ReadMessage(subBuilder);
            ClientCollectorData = subBuilder;
            break;
          }
          case 88: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            global::NewProtos.OneoffGatherPointDetectorData subBuilder = new global::NewProtos.OneoffGatherPointDetectorData();
            if (paramCase_ == ParamOneofCase.DetectorData) {
              subBuilder.MergeFrom(DetectorData);
            }
            input.ReadMessage(subBuilder);
            DetectorData = subBuilder;
            break;
          }
          case 1378578: {
            global::NewProtos.SkyCrystalDetectorQuickUseResult subBuilder = new global::NewProtos.SkyCrystalDetectorQuickUseResult();
            if (paramCase_ == ParamOneofCase.SkyCrystalDetectorQuickUseResult) {
              subBuilder.MergeFrom(SkyCrystalDetectorQuickUseResult);
            }
            input.ReadMessage(subBuilder);
            SkyCrystalDetectorQuickUseResult = subBuilder;
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
