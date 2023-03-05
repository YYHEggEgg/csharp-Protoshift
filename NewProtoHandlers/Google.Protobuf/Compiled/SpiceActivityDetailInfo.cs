// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpiceActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SpiceActivityDetailInfo.proto</summary>
  public static partial class SpiceActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SpiceActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpiceActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TcGljZUFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxoUU3BpY2VTdGFnZURh",
            "dGEucHJvdG8igwEKF1NwaWNlQWN0aXZpdHlEZXRhaWxJbmZvEhsKE1VuazMz",
            "MDBfQ0lISUFKRUdDQk8YDiABKA0SGwoTVW5rMzMwMF9MQUtQTU1JUEJNSRgI",
            "IAEoDRIuChVzcGljZV9zdGFnZV9kYXRhX2xpc3QYBiADKAsyDy5TcGljZVN0",
            "YWdlRGF0YUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.SpiceStageDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SpiceActivityDetailInfo), global::NewProtos.SpiceActivityDetailInfo.Parser, new[]{ "Unk3300CIHIAJEGCBO", "Unk3300LAKPMMIPBMI", "SpiceStageDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpiceActivityDetailInfo : pb::IMessage<SpiceActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpiceActivityDetailInfo> _parser = new pb::MessageParser<SpiceActivityDetailInfo>(() => new SpiceActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpiceActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SpiceActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpiceActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpiceActivityDetailInfo(SpiceActivityDetailInfo other) : this() {
      unk3300CIHIAJEGCBO_ = other.unk3300CIHIAJEGCBO_;
      unk3300LAKPMMIPBMI_ = other.unk3300LAKPMMIPBMI_;
      spiceStageDataList_ = other.spiceStageDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpiceActivityDetailInfo Clone() {
      return new SpiceActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk3300_CIHIAJEGCBO" field.</summary>
    public const int Unk3300CIHIAJEGCBOFieldNumber = 14;
    private uint unk3300CIHIAJEGCBO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300CIHIAJEGCBO {
      get { return unk3300CIHIAJEGCBO_; }
      set {
        unk3300CIHIAJEGCBO_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LAKPMMIPBMI" field.</summary>
    public const int Unk3300LAKPMMIPBMIFieldNumber = 8;
    private uint unk3300LAKPMMIPBMI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LAKPMMIPBMI {
      get { return unk3300LAKPMMIPBMI_; }
      set {
        unk3300LAKPMMIPBMI_ = value;
      }
    }

    /// <summary>Field number for the "spice_stage_data_list" field.</summary>
    public const int SpiceStageDataListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::NewProtos.SpiceStageData> _repeated_spiceStageDataList_codec
        = pb::FieldCodec.ForMessage(50, global::NewProtos.SpiceStageData.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.SpiceStageData> spiceStageDataList_ = new pbc::RepeatedField<global::NewProtos.SpiceStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.SpiceStageData> SpiceStageDataList {
      get { return spiceStageDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpiceActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpiceActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300CIHIAJEGCBO != other.Unk3300CIHIAJEGCBO) return false;
      if (Unk3300LAKPMMIPBMI != other.Unk3300LAKPMMIPBMI) return false;
      if(!spiceStageDataList_.Equals(other.spiceStageDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300CIHIAJEGCBO != 0) hash ^= Unk3300CIHIAJEGCBO.GetHashCode();
      if (Unk3300LAKPMMIPBMI != 0) hash ^= Unk3300LAKPMMIPBMI.GetHashCode();
      hash ^= spiceStageDataList_.GetHashCode();
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
      spiceStageDataList_.WriteTo(output, _repeated_spiceStageDataList_codec);
      if (Unk3300LAKPMMIPBMI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300LAKPMMIPBMI);
      }
      if (Unk3300CIHIAJEGCBO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300CIHIAJEGCBO);
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
      spiceStageDataList_.WriteTo(ref output, _repeated_spiceStageDataList_codec);
      if (Unk3300LAKPMMIPBMI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300LAKPMMIPBMI);
      }
      if (Unk3300CIHIAJEGCBO != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300CIHIAJEGCBO);
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
      if (Unk3300CIHIAJEGCBO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300CIHIAJEGCBO);
      }
      if (Unk3300LAKPMMIPBMI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LAKPMMIPBMI);
      }
      size += spiceStageDataList_.CalculateSize(_repeated_spiceStageDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpiceActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300CIHIAJEGCBO != 0) {
        Unk3300CIHIAJEGCBO = other.Unk3300CIHIAJEGCBO;
      }
      if (other.Unk3300LAKPMMIPBMI != 0) {
        Unk3300LAKPMMIPBMI = other.Unk3300LAKPMMIPBMI;
      }
      spiceStageDataList_.Add(other.spiceStageDataList_);
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
          case 50: {
            spiceStageDataList_.AddEntriesFrom(input, _repeated_spiceStageDataList_codec);
            break;
          }
          case 64: {
            Unk3300LAKPMMIPBMI = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300CIHIAJEGCBO = input.ReadUInt32();
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
          case 50: {
            spiceStageDataList_.AddEntriesFrom(ref input, _repeated_spiceStageDataList_codec);
            break;
          }
          case 64: {
            Unk3300LAKPMMIPBMI = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300CIHIAJEGCBO = input.ReadUInt32();
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