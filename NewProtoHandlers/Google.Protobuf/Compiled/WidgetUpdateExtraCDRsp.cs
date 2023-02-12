// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetUpdateExtraCDRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from WidgetUpdateExtraCDRsp.proto</summary>
  public static partial class WidgetUpdateExtraCDRspReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetUpdateExtraCDRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetUpdateExtraCDRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxXaWRnZXRVcGRhdGVFeHRyYUNEUnNwLnByb3RvGhhXaWRnZXRDb29sRG93",
            "bkRhdGEucHJvdG8aF1dpZGdldEV4dHJhQ2RUeXBlLnByb3RvIqMBChZXaWRn",
            "ZXRVcGRhdGVFeHRyYUNEUnNwEiYKCWNvb2xfZGF0YRgKIAEoCzITLldpZGdl",
            "dENvb2xEb3duRGF0YRIpCg1leHRyYV9jZF90eXBlGAUgASgOMhIuV2lkZ2V0",
            "RXh0cmFDZFR5cGUSDwoHcmV0Y29kZRgNIAEoBRIQCghjZF9ncm91cBgLIAEo",
            "DRITCgttYXRlcmlhbF9pZBgHIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.WidgetCoolDownDataReflection.Descriptor, global::NewProtos.WidgetExtraCdTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.WidgetUpdateExtraCDRsp), global::NewProtos.WidgetUpdateExtraCDRsp.Parser, new[]{ "CoolData", "ExtraCdType", "Retcode", "CdGroup", "MaterialId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6076;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class WidgetUpdateExtraCDRsp : pb::IMessage<WidgetUpdateExtraCDRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetUpdateExtraCDRsp> _parser = new pb::MessageParser<WidgetUpdateExtraCDRsp>(() => new WidgetUpdateExtraCDRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetUpdateExtraCDRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.WidgetUpdateExtraCDRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetUpdateExtraCDRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetUpdateExtraCDRsp(WidgetUpdateExtraCDRsp other) : this() {
      coolData_ = other.coolData_ != null ? other.coolData_.Clone() : null;
      extraCdType_ = other.extraCdType_;
      retcode_ = other.retcode_;
      cdGroup_ = other.cdGroup_;
      materialId_ = other.materialId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetUpdateExtraCDRsp Clone() {
      return new WidgetUpdateExtraCDRsp(this);
    }

    /// <summary>Field number for the "cool_data" field.</summary>
    public const int CoolDataFieldNumber = 10;
    private global::NewProtos.WidgetCoolDownData coolData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.WidgetCoolDownData CoolData {
      get { return coolData_; }
      set {
        coolData_ = value;
      }
    }

    /// <summary>Field number for the "extra_cd_type" field.</summary>
    public const int ExtraCdTypeFieldNumber = 5;
    private global::NewProtos.WidgetExtraCdType extraCdType_ = global::NewProtos.WidgetExtraCdType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.WidgetExtraCdType ExtraCdType {
      get { return extraCdType_; }
      set {
        extraCdType_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cd_group" field.</summary>
    public const int CdGroupFieldNumber = 11;
    private uint cdGroup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CdGroup {
      get { return cdGroup_; }
      set {
        cdGroup_ = value;
      }
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 7;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetUpdateExtraCDRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetUpdateExtraCDRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CoolData, other.CoolData)) return false;
      if (ExtraCdType != other.ExtraCdType) return false;
      if (Retcode != other.Retcode) return false;
      if (CdGroup != other.CdGroup) return false;
      if (MaterialId != other.MaterialId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (coolData_ != null) hash ^= CoolData.GetHashCode();
      if (ExtraCdType != global::NewProtos.WidgetExtraCdType.None) hash ^= ExtraCdType.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (CdGroup != 0) hash ^= CdGroup.GetHashCode();
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
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
      if (ExtraCdType != global::NewProtos.WidgetExtraCdType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ExtraCdType);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaterialId);
      }
      if (coolData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CoolData);
      }
      if (CdGroup != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CdGroup);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
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
      if (ExtraCdType != global::NewProtos.WidgetExtraCdType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ExtraCdType);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaterialId);
      }
      if (coolData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CoolData);
      }
      if (CdGroup != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CdGroup);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
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
      if (coolData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CoolData);
      }
      if (ExtraCdType != global::NewProtos.WidgetExtraCdType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtraCdType);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (CdGroup != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CdGroup);
      }
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetUpdateExtraCDRsp other) {
      if (other == null) {
        return;
      }
      if (other.coolData_ != null) {
        if (coolData_ == null) {
          CoolData = new global::NewProtos.WidgetCoolDownData();
        }
        CoolData.MergeFrom(other.CoolData);
      }
      if (other.ExtraCdType != global::NewProtos.WidgetExtraCdType.None) {
        ExtraCdType = other.ExtraCdType;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.CdGroup != 0) {
        CdGroup = other.CdGroup;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
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
            ExtraCdType = (global::NewProtos.WidgetExtraCdType) input.ReadEnum();
            break;
          }
          case 56: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (coolData_ == null) {
              CoolData = new global::NewProtos.WidgetCoolDownData();
            }
            input.ReadMessage(CoolData);
            break;
          }
          case 88: {
            CdGroup = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
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
            ExtraCdType = (global::NewProtos.WidgetExtraCdType) input.ReadEnum();
            break;
          }
          case 56: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (coolData_ == null) {
              CoolData = new global::NewProtos.WidgetCoolDownData();
            }
            input.ReadMessage(CoolData);
            break;
          }
          case 88: {
            CdGroup = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
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