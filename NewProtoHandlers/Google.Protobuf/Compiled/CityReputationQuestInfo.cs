// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CityReputationQuestInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CityReputationQuestInfo.proto</summary>
public static partial class CityReputationQuestInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for CityReputationQuestInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CityReputationQuestInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1DaXR5UmVwdXRhdGlvblF1ZXN0SW5mby5wcm90byJkChdDaXR5UmVwdXRh",
          "dGlvblF1ZXN0SW5mbxIbChNVbmszMzAwX0lNTERQRE1ISkJKGAwgAygNEhsK",
          "E1VuazMzMDBfT01HTUdESUhET0gYCiADKA0SDwoHaXNfb3BlbhgEIAEoCEIW",
          "ChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CityReputationQuestInfo), global::CityReputationQuestInfo.Parser, new[]{ "Unk3300IMLDPDMHJBJ", "Unk3300OMGMGDIHDOH", "IsOpen" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CityReputationQuestInfo : pb::IMessage<CityReputationQuestInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CityReputationQuestInfo> _parser = new pb::MessageParser<CityReputationQuestInfo>(() => new CityReputationQuestInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CityReputationQuestInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CityReputationQuestInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CityReputationQuestInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CityReputationQuestInfo(CityReputationQuestInfo other) : this() {
    unk3300IMLDPDMHJBJ_ = other.unk3300IMLDPDMHJBJ_.Clone();
    unk3300OMGMGDIHDOH_ = other.unk3300OMGMGDIHDOH_.Clone();
    isOpen_ = other.isOpen_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CityReputationQuestInfo Clone() {
    return new CityReputationQuestInfo(this);
  }

  /// <summary>Field number for the "Unk3300_IMLDPDMHJBJ" field.</summary>
  public const int Unk3300IMLDPDMHJBJFieldNumber = 12;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300IMLDPDMHJBJ_codec
      = pb::FieldCodec.ForUInt32(98);
  private readonly pbc::RepeatedField<uint> unk3300IMLDPDMHJBJ_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300IMLDPDMHJBJ {
    get { return unk3300IMLDPDMHJBJ_; }
  }

  /// <summary>Field number for the "Unk3300_OMGMGDIHDOH" field.</summary>
  public const int Unk3300OMGMGDIHDOHFieldNumber = 10;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300OMGMGDIHDOH_codec
      = pb::FieldCodec.ForUInt32(82);
  private readonly pbc::RepeatedField<uint> unk3300OMGMGDIHDOH_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300OMGMGDIHDOH {
    get { return unk3300OMGMGDIHDOH_; }
  }

  /// <summary>Field number for the "is_open" field.</summary>
  public const int IsOpenFieldNumber = 4;
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
    return Equals(other as CityReputationQuestInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CityReputationQuestInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!unk3300IMLDPDMHJBJ_.Equals(other.unk3300IMLDPDMHJBJ_)) return false;
    if(!unk3300OMGMGDIHDOH_.Equals(other.unk3300OMGMGDIHDOH_)) return false;
    if (IsOpen != other.IsOpen) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= unk3300IMLDPDMHJBJ_.GetHashCode();
    hash ^= unk3300OMGMGDIHDOH_.GetHashCode();
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
      output.WriteRawTag(32);
      output.WriteBool(IsOpen);
    }
    unk3300OMGMGDIHDOH_.WriteTo(output, _repeated_unk3300OMGMGDIHDOH_codec);
    unk3300IMLDPDMHJBJ_.WriteTo(output, _repeated_unk3300IMLDPDMHJBJ_codec);
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
      output.WriteRawTag(32);
      output.WriteBool(IsOpen);
    }
    unk3300OMGMGDIHDOH_.WriteTo(ref output, _repeated_unk3300OMGMGDIHDOH_codec);
    unk3300IMLDPDMHJBJ_.WriteTo(ref output, _repeated_unk3300IMLDPDMHJBJ_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += unk3300IMLDPDMHJBJ_.CalculateSize(_repeated_unk3300IMLDPDMHJBJ_codec);
    size += unk3300OMGMGDIHDOH_.CalculateSize(_repeated_unk3300OMGMGDIHDOH_codec);
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
  public void MergeFrom(CityReputationQuestInfo other) {
    if (other == null) {
      return;
    }
    unk3300IMLDPDMHJBJ_.Add(other.unk3300IMLDPDMHJBJ_);
    unk3300OMGMGDIHDOH_.Add(other.unk3300OMGMGDIHDOH_);
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
        case 32: {
          IsOpen = input.ReadBool();
          break;
        }
        case 82:
        case 80: {
          unk3300OMGMGDIHDOH_.AddEntriesFrom(input, _repeated_unk3300OMGMGDIHDOH_codec);
          break;
        }
        case 98:
        case 96: {
          unk3300IMLDPDMHJBJ_.AddEntriesFrom(input, _repeated_unk3300IMLDPDMHJBJ_codec);
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
        case 32: {
          IsOpen = input.ReadBool();
          break;
        }
        case 82:
        case 80: {
          unk3300OMGMGDIHDOH_.AddEntriesFrom(ref input, _repeated_unk3300OMGMGDIHDOH_codec);
          break;
        }
        case 98:
        case 96: {
          unk3300IMLDPDMHJBJ_.AddEntriesFrom(ref input, _repeated_unk3300IMLDPDMHJBJ_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
