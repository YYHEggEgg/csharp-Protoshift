// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3300_DMOBAABGOBF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Unk3300_DMOBAABGOBF.proto</summary>
public static partial class Unk3300DMOBAABGOBFReflection {

  #region Descriptor
  /// <summary>File descriptor for Unk3300_DMOBAABGOBF.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static Unk3300DMOBAABGOBFReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlVbmszMzAwX0RNT0JBQUJHT0JGLnByb3RvImMKE1VuazMzMDBfRE1PQkFB",
          "QkdPQkYSEgoKaXNfc3VjY2VzcxgGIAEoCBIbChNVbmszMzAwX05LSE1NUE1F",
          "SUxKGAcgASgJEhsKE1VuazMzMDBfSk9DS0lHQ0VOR0kYDSABKAlCFgoUb3Jn",
          "LnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Unk3300_DMOBAABGOBF), global::Unk3300_DMOBAABGOBF.Parser, new[]{ "IsSuccess", "Unk3300NKHMMPMEILJ", "Unk3300JOCKIGCENGI" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 7193;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class Unk3300_DMOBAABGOBF : pb::IMessage<Unk3300_DMOBAABGOBF>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Unk3300_DMOBAABGOBF> _parser = new pb::MessageParser<Unk3300_DMOBAABGOBF>(() => new Unk3300_DMOBAABGOBF());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Unk3300_DMOBAABGOBF> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::Unk3300DMOBAABGOBFReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_DMOBAABGOBF() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_DMOBAABGOBF(Unk3300_DMOBAABGOBF other) : this() {
    isSuccess_ = other.isSuccess_;
    unk3300NKHMMPMEILJ_ = other.unk3300NKHMMPMEILJ_;
    unk3300JOCKIGCENGI_ = other.unk3300JOCKIGCENGI_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_DMOBAABGOBF Clone() {
    return new Unk3300_DMOBAABGOBF(this);
  }

  /// <summary>Field number for the "is_success" field.</summary>
  public const int IsSuccessFieldNumber = 6;
  private bool isSuccess_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSuccess {
    get { return isSuccess_; }
    set {
      isSuccess_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_NKHMMPMEILJ" field.</summary>
  public const int Unk3300NKHMMPMEILJFieldNumber = 7;
  private string unk3300NKHMMPMEILJ_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Unk3300NKHMMPMEILJ {
    get { return unk3300NKHMMPMEILJ_; }
    set {
      unk3300NKHMMPMEILJ_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Unk3300_JOCKIGCENGI" field.</summary>
  public const int Unk3300JOCKIGCENGIFieldNumber = 13;
  private string unk3300JOCKIGCENGI_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Unk3300JOCKIGCENGI {
    get { return unk3300JOCKIGCENGI_; }
    set {
      unk3300JOCKIGCENGI_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Unk3300_DMOBAABGOBF);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Unk3300_DMOBAABGOBF other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsSuccess != other.IsSuccess) return false;
    if (Unk3300NKHMMPMEILJ != other.Unk3300NKHMMPMEILJ) return false;
    if (Unk3300JOCKIGCENGI != other.Unk3300JOCKIGCENGI) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
    if (Unk3300NKHMMPMEILJ.Length != 0) hash ^= Unk3300NKHMMPMEILJ.GetHashCode();
    if (Unk3300JOCKIGCENGI.Length != 0) hash ^= Unk3300JOCKIGCENGI.GetHashCode();
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
    if (IsSuccess != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsSuccess);
    }
    if (Unk3300NKHMMPMEILJ.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(Unk3300NKHMMPMEILJ);
    }
    if (Unk3300JOCKIGCENGI.Length != 0) {
      output.WriteRawTag(106);
      output.WriteString(Unk3300JOCKIGCENGI);
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
    if (IsSuccess != false) {
      output.WriteRawTag(48);
      output.WriteBool(IsSuccess);
    }
    if (Unk3300NKHMMPMEILJ.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(Unk3300NKHMMPMEILJ);
    }
    if (Unk3300JOCKIGCENGI.Length != 0) {
      output.WriteRawTag(106);
      output.WriteString(Unk3300JOCKIGCENGI);
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
    if (IsSuccess != false) {
      size += 1 + 1;
    }
    if (Unk3300NKHMMPMEILJ.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300NKHMMPMEILJ);
    }
    if (Unk3300JOCKIGCENGI.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300JOCKIGCENGI);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Unk3300_DMOBAABGOBF other) {
    if (other == null) {
      return;
    }
    if (other.IsSuccess != false) {
      IsSuccess = other.IsSuccess;
    }
    if (other.Unk3300NKHMMPMEILJ.Length != 0) {
      Unk3300NKHMMPMEILJ = other.Unk3300NKHMMPMEILJ;
    }
    if (other.Unk3300JOCKIGCENGI.Length != 0) {
      Unk3300JOCKIGCENGI = other.Unk3300JOCKIGCENGI;
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
          IsSuccess = input.ReadBool();
          break;
        }
        case 58: {
          Unk3300NKHMMPMEILJ = input.ReadString();
          break;
        }
        case 106: {
          Unk3300JOCKIGCENGI = input.ReadString();
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
          IsSuccess = input.ReadBool();
          break;
        }
        case 58: {
          Unk3300NKHMMPMEILJ = input.ReadString();
          break;
        }
        case 106: {
          Unk3300JOCKIGCENGI = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code