// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetReportReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from WidgetReportReq.proto</summary>
  public static partial class WidgetReportReqReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetReportReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetReportReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXaWRnZXRSZXBvcnRSZXEucHJvdG8iqAEKD1dpZGdldFJlcG9ydFJlcRIj",
            "Cht3ZWF0aGVyX3dpemFyZF9zaGllbGRfdmFsdWUYCCABKA0SGwoTVW5rMzMw",
            "MF9BUERGS0tOS0lKShgHIAEoCBIbChNVbmszMzAwX0JDQUlCS0RJSEhGGAYg",
            "ASgIEhMKC21hdGVyaWFsX2lkGAIgASgNEiEKGWlzX2NsZWFyX3NreV9jcnlz",
            "dGFsX2hpbnQYDiABKAhCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.WidgetReportReq), global::NewProtos.WidgetReportReq.Parser, new[]{ "WeatherWizardShieldValue", "Unk3300APDFKKNKIJJ", "Unk3300BCAIBKDIHHF", "MaterialId", "IsClearSkyCrystalHint" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4258;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class WidgetReportReq : pb::IMessage<WidgetReportReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetReportReq> _parser = new pb::MessageParser<WidgetReportReq>(() => new WidgetReportReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetReportReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.WidgetReportReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetReportReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetReportReq(WidgetReportReq other) : this() {
      weatherWizardShieldValue_ = other.weatherWizardShieldValue_;
      unk3300APDFKKNKIJJ_ = other.unk3300APDFKKNKIJJ_;
      unk3300BCAIBKDIHHF_ = other.unk3300BCAIBKDIHHF_;
      materialId_ = other.materialId_;
      isClearSkyCrystalHint_ = other.isClearSkyCrystalHint_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetReportReq Clone() {
      return new WidgetReportReq(this);
    }

    /// <summary>Field number for the "weather_wizard_shield_value" field.</summary>
    public const int WeatherWizardShieldValueFieldNumber = 8;
    private uint weatherWizardShieldValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeatherWizardShieldValue {
      get { return weatherWizardShieldValue_; }
      set {
        weatherWizardShieldValue_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_APDFKKNKIJJ" field.</summary>
    public const int Unk3300APDFKKNKIJJFieldNumber = 7;
    private bool unk3300APDFKKNKIJJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300APDFKKNKIJJ {
      get { return unk3300APDFKKNKIJJ_; }
      set {
        unk3300APDFKKNKIJJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BCAIBKDIHHF" field.</summary>
    public const int Unk3300BCAIBKDIHHFFieldNumber = 6;
    private bool unk3300BCAIBKDIHHF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300BCAIBKDIHHF {
      get { return unk3300BCAIBKDIHHF_; }
      set {
        unk3300BCAIBKDIHHF_ = value;
      }
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 2;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    /// <summary>Field number for the "is_clear_sky_crystal_hint" field.</summary>
    public const int IsClearSkyCrystalHintFieldNumber = 14;
    private bool isClearSkyCrystalHint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsClearSkyCrystalHint {
      get { return isClearSkyCrystalHint_; }
      set {
        isClearSkyCrystalHint_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetReportReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetReportReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WeatherWizardShieldValue != other.WeatherWizardShieldValue) return false;
      if (Unk3300APDFKKNKIJJ != other.Unk3300APDFKKNKIJJ) return false;
      if (Unk3300BCAIBKDIHHF != other.Unk3300BCAIBKDIHHF) return false;
      if (MaterialId != other.MaterialId) return false;
      if (IsClearSkyCrystalHint != other.IsClearSkyCrystalHint) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WeatherWizardShieldValue != 0) hash ^= WeatherWizardShieldValue.GetHashCode();
      if (Unk3300APDFKKNKIJJ != false) hash ^= Unk3300APDFKKNKIJJ.GetHashCode();
      if (Unk3300BCAIBKDIHHF != false) hash ^= Unk3300BCAIBKDIHHF.GetHashCode();
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
      if (IsClearSkyCrystalHint != false) hash ^= IsClearSkyCrystalHint.GetHashCode();
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
      if (MaterialId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MaterialId);
      }
      if (Unk3300BCAIBKDIHHF != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300BCAIBKDIHHF);
      }
      if (Unk3300APDFKKNKIJJ != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk3300APDFKKNKIJJ);
      }
      if (WeatherWizardShieldValue != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WeatherWizardShieldValue);
      }
      if (IsClearSkyCrystalHint != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsClearSkyCrystalHint);
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
      if (MaterialId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MaterialId);
      }
      if (Unk3300BCAIBKDIHHF != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300BCAIBKDIHHF);
      }
      if (Unk3300APDFKKNKIJJ != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk3300APDFKKNKIJJ);
      }
      if (WeatherWizardShieldValue != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WeatherWizardShieldValue);
      }
      if (IsClearSkyCrystalHint != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsClearSkyCrystalHint);
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
      if (WeatherWizardShieldValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeatherWizardShieldValue);
      }
      if (Unk3300APDFKKNKIJJ != false) {
        size += 1 + 1;
      }
      if (Unk3300BCAIBKDIHHF != false) {
        size += 1 + 1;
      }
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (IsClearSkyCrystalHint != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetReportReq other) {
      if (other == null) {
        return;
      }
      if (other.WeatherWizardShieldValue != 0) {
        WeatherWizardShieldValue = other.WeatherWizardShieldValue;
      }
      if (other.Unk3300APDFKKNKIJJ != false) {
        Unk3300APDFKKNKIJJ = other.Unk3300APDFKKNKIJJ;
      }
      if (other.Unk3300BCAIBKDIHHF != false) {
        Unk3300BCAIBKDIHHF = other.Unk3300BCAIBKDIHHF;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
      }
      if (other.IsClearSkyCrystalHint != false) {
        IsClearSkyCrystalHint = other.IsClearSkyCrystalHint;
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
          case 16: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300BCAIBKDIHHF = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300APDFKKNKIJJ = input.ReadBool();
            break;
          }
          case 64: {
            WeatherWizardShieldValue = input.ReadUInt32();
            break;
          }
          case 112: {
            IsClearSkyCrystalHint = input.ReadBool();
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
          case 16: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300BCAIBKDIHHF = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300APDFKKNKIJJ = input.ReadBool();
            break;
          }
          case 64: {
            WeatherWizardShieldValue = input.ReadUInt32();
            break;
          }
          case 112: {
            IsClearSkyCrystalHint = input.ReadBool();
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
