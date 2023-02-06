// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BartenderGetFormulaRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BartenderGetFormulaRsp.proto</summary>
public static partial class BartenderGetFormulaRspReflection {

  #region Descriptor
  /// <summary>File descriptor for BartenderGetFormulaRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BartenderGetFormulaRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxCYXJ0ZW5kZXJHZXRGb3JtdWxhUnNwLnByb3RvImEKFkJhcnRlbmRlckdl",
          "dEZvcm11bGFSc3ASDgoGaXNfbmV3GAwgASgIEg8KB3JldGNvZGUYBiABKAUS",
          "EgoKYWZmaXhfbGlzdBgIIAMoDRISCgpmb3JtdWxhX2lkGAsgASgNQh4KHGVt",
          "dS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BartenderGetFormulaRsp), global::BartenderGetFormulaRsp.Parser, new[]{ "IsNew", "Retcode", "AffixList", "FormulaId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8842
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class BartenderGetFormulaRsp : pb::IMessage<BartenderGetFormulaRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BartenderGetFormulaRsp> _parser = new pb::MessageParser<BartenderGetFormulaRsp>(() => new BartenderGetFormulaRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BartenderGetFormulaRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BartenderGetFormulaRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BartenderGetFormulaRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BartenderGetFormulaRsp(BartenderGetFormulaRsp other) : this() {
    isNew_ = other.isNew_;
    retcode_ = other.retcode_;
    affixList_ = other.affixList_.Clone();
    formulaId_ = other.formulaId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BartenderGetFormulaRsp Clone() {
    return new BartenderGetFormulaRsp(this);
  }

  /// <summary>Field number for the "is_new" field.</summary>
  public const int IsNewFieldNumber = 12;
  private bool isNew_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNew {
    get { return isNew_; }
    set {
      isNew_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 6;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "affix_list" field.</summary>
  public const int AffixListFieldNumber = 8;
  private static readonly pb::FieldCodec<uint> _repeated_affixList_codec
      = pb::FieldCodec.ForUInt32(66);
  private readonly pbc::RepeatedField<uint> affixList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> AffixList {
    get { return affixList_; }
  }

  /// <summary>Field number for the "formula_id" field.</summary>
  public const int FormulaIdFieldNumber = 11;
  private uint formulaId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FormulaId {
    get { return formulaId_; }
    set {
      formulaId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BartenderGetFormulaRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BartenderGetFormulaRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsNew != other.IsNew) return false;
    if (Retcode != other.Retcode) return false;
    if(!affixList_.Equals(other.affixList_)) return false;
    if (FormulaId != other.FormulaId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsNew != false) hash ^= IsNew.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    hash ^= affixList_.GetHashCode();
    if (FormulaId != 0) hash ^= FormulaId.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(Retcode);
    }
    affixList_.WriteTo(output, _repeated_affixList_codec);
    if (FormulaId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(FormulaId);
    }
    if (IsNew != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsNew);
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
    if (Retcode != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(Retcode);
    }
    affixList_.WriteTo(ref output, _repeated_affixList_codec);
    if (FormulaId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(FormulaId);
    }
    if (IsNew != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsNew);
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
    if (IsNew != false) {
      size += 1 + 1;
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    size += affixList_.CalculateSize(_repeated_affixList_codec);
    if (FormulaId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FormulaId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BartenderGetFormulaRsp other) {
    if (other == null) {
      return;
    }
    if (other.IsNew != false) {
      IsNew = other.IsNew;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    affixList_.Add(other.affixList_);
    if (other.FormulaId != 0) {
      FormulaId = other.FormulaId;
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
          Retcode = input.ReadInt32();
          break;
        }
        case 66:
        case 64: {
          affixList_.AddEntriesFrom(input, _repeated_affixList_codec);
          break;
        }
        case 88: {
          FormulaId = input.ReadUInt32();
          break;
        }
        case 96: {
          IsNew = input.ReadBool();
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
          Retcode = input.ReadInt32();
          break;
        }
        case 66:
        case 64: {
          affixList_.AddEntriesFrom(ref input, _repeated_affixList_codec);
          break;
        }
        case 88: {
          FormulaId = input.ReadUInt32();
          break;
        }
        case 96: {
          IsNew = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code