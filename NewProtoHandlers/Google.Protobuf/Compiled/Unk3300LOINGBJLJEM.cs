// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3300_LOINGBJLJEM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Unk3300_LOINGBJLJEM.proto</summary>
public static partial class Unk3300LOINGBJLJEMReflection {

  #region Descriptor
  /// <summary>File descriptor for Unk3300_LOINGBJLJEM.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static Unk3300LOINGBJLJEMReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlVbmszMzAwX0xPSU5HQkpMSkVNLnByb3RvIs0BChNVbmszMzAwX0xPSU5H",
          "QkpMSkVNEkUKE1VuazMzMDBfTk9GQkVKTE5NTEEYBCABKA4yKC5VbmszMzAw",
          "X0xPSU5HQkpMSkVNLlVuazMzMDBfS0RCSlBKQURKS0YibwoTVW5rMzMwMF9L",
          "REJKUEpBREpLRhIrCidVbmszMzAwX0tEQkpQSkFESktGX1VuazMzMDBfRUtC",
          "RkpQR0dFQ00QABIrCidVbmszMzAwX0tEQkpQSkFESktGX1VuazMzMDBfTkFM",
          "SEpCS01QQ0gQAUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Unk3300_LOINGBJLJEM), global::Unk3300_LOINGBJLJEM.Parser, new[]{ "Unk3300NOFBEJLNMLA" }, null, new[]{ typeof(global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF) }, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 7048;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class Unk3300_LOINGBJLJEM : pb::IMessage<Unk3300_LOINGBJLJEM>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Unk3300_LOINGBJLJEM> _parser = new pb::MessageParser<Unk3300_LOINGBJLJEM>(() => new Unk3300_LOINGBJLJEM());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Unk3300_LOINGBJLJEM> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::Unk3300LOINGBJLJEMReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_LOINGBJLJEM() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_LOINGBJLJEM(Unk3300_LOINGBJLJEM other) : this() {
    unk3300NOFBEJLNMLA_ = other.unk3300NOFBEJLNMLA_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_LOINGBJLJEM Clone() {
    return new Unk3300_LOINGBJLJEM(this);
  }

  /// <summary>Field number for the "Unk3300_NOFBEJLNMLA" field.</summary>
  public const int Unk3300NOFBEJLNMLAFieldNumber = 4;
  private global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF unk3300NOFBEJLNMLA_ = global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF.Unk3300Ekbfjpggecm;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF Unk3300NOFBEJLNMLA {
    get { return unk3300NOFBEJLNMLA_; }
    set {
      unk3300NOFBEJLNMLA_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Unk3300_LOINGBJLJEM);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Unk3300_LOINGBJLJEM other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Unk3300NOFBEJLNMLA != other.Unk3300NOFBEJLNMLA) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Unk3300NOFBEJLNMLA != global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF.Unk3300Ekbfjpggecm) hash ^= Unk3300NOFBEJLNMLA.GetHashCode();
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
    if (Unk3300NOFBEJLNMLA != global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF.Unk3300Ekbfjpggecm) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Unk3300NOFBEJLNMLA);
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
    if (Unk3300NOFBEJLNMLA != global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF.Unk3300Ekbfjpggecm) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Unk3300NOFBEJLNMLA);
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
    if (Unk3300NOFBEJLNMLA != global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF.Unk3300Ekbfjpggecm) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unk3300NOFBEJLNMLA);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Unk3300_LOINGBJLJEM other) {
    if (other == null) {
      return;
    }
    if (other.Unk3300NOFBEJLNMLA != global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF.Unk3300Ekbfjpggecm) {
      Unk3300NOFBEJLNMLA = other.Unk3300NOFBEJLNMLA;
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
          Unk3300NOFBEJLNMLA = (global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF) input.ReadEnum();
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
          Unk3300NOFBEJLNMLA = (global::Unk3300_LOINGBJLJEM.Types.Unk3300_KDBJPJADJKF) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the Unk3300_LOINGBJLJEM message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum Unk3300_KDBJPJADJKF {
      [pbr::OriginalName("Unk3300_KDBJPJADJKF_Unk3300_EKBFJPGGECM")] Unk3300Ekbfjpggecm = 0,
      [pbr::OriginalName("Unk3300_KDBJPJADJKF_Unk3300_NALHJBKMPCH")] Unk3300Nalhjbkmpch = 1,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code