// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OtherPlayerEnterHomeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from OtherPlayerEnterHomeNotify.proto</summary>
public static partial class OtherPlayerEnterHomeNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for OtherPlayerEnterHomeNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static OtherPlayerEnterHomeNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBPdGhlclBsYXllckVudGVySG9tZU5vdGlmeS5wcm90byKkAQoaT3RoZXJQ",
          "bGF5ZXJFbnRlckhvbWVOb3RpZnkSEAoIbmlja25hbWUYBSABKAkSMgoGcmVh",
          "c29uGAogASgOMiIuT3RoZXJQbGF5ZXJFbnRlckhvbWVOb3RpZnkuUmVhc29u",
          "IkAKBlJlYXNvbhISCg5SRUFTT05fSU5WQUxJRBAAEhAKDFJFQVNPTl9FTlRF",
          "UhABEhAKDFJFQVNPTl9MRUFWRRACQhYKFG9yZy5zb3JhcG9pbnRhLnByb3Rv",
          "YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::OtherPlayerEnterHomeNotify), global::OtherPlayerEnterHomeNotify.Parser, new[]{ "Nickname", "Reason" }, null, new[]{ typeof(global::OtherPlayerEnterHomeNotify.Types.Reason) }, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4749;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class OtherPlayerEnterHomeNotify : pb::IMessage<OtherPlayerEnterHomeNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<OtherPlayerEnterHomeNotify> _parser = new pb::MessageParser<OtherPlayerEnterHomeNotify>(() => new OtherPlayerEnterHomeNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<OtherPlayerEnterHomeNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::OtherPlayerEnterHomeNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public OtherPlayerEnterHomeNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public OtherPlayerEnterHomeNotify(OtherPlayerEnterHomeNotify other) : this() {
    nickname_ = other.nickname_;
    reason_ = other.reason_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public OtherPlayerEnterHomeNotify Clone() {
    return new OtherPlayerEnterHomeNotify(this);
  }

  /// <summary>Field number for the "nickname" field.</summary>
  public const int NicknameFieldNumber = 5;
  private string nickname_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Nickname {
    get { return nickname_; }
    set {
      nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 10;
  private global::OtherPlayerEnterHomeNotify.Types.Reason reason_ = global::OtherPlayerEnterHomeNotify.Types.Reason.Invalid;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::OtherPlayerEnterHomeNotify.Types.Reason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as OtherPlayerEnterHomeNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(OtherPlayerEnterHomeNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Nickname != other.Nickname) return false;
    if (Reason != other.Reason) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
    if (Reason != global::OtherPlayerEnterHomeNotify.Types.Reason.Invalid) hash ^= Reason.GetHashCode();
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
    if (Nickname.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Nickname);
    }
    if (Reason != global::OtherPlayerEnterHomeNotify.Types.Reason.Invalid) {
      output.WriteRawTag(80);
      output.WriteEnum((int) Reason);
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
    if (Nickname.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Nickname);
    }
    if (Reason != global::OtherPlayerEnterHomeNotify.Types.Reason.Invalid) {
      output.WriteRawTag(80);
      output.WriteEnum((int) Reason);
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
    if (Nickname.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
    }
    if (Reason != global::OtherPlayerEnterHomeNotify.Types.Reason.Invalid) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(OtherPlayerEnterHomeNotify other) {
    if (other == null) {
      return;
    }
    if (other.Nickname.Length != 0) {
      Nickname = other.Nickname;
    }
    if (other.Reason != global::OtherPlayerEnterHomeNotify.Types.Reason.Invalid) {
      Reason = other.Reason;
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
          Nickname = input.ReadString();
          break;
        }
        case 80: {
          Reason = (global::OtherPlayerEnterHomeNotify.Types.Reason) input.ReadEnum();
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
          Nickname = input.ReadString();
          break;
        }
        case 80: {
          Reason = (global::OtherPlayerEnterHomeNotify.Types.Reason) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the OtherPlayerEnterHomeNotify message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum Reason {
      [pbr::OriginalName("REASON_INVALID")] Invalid = 0,
      [pbr::OriginalName("REASON_ENTER")] Enter = 1,
      [pbr::OriginalName("REASON_LEAVE")] Leave = 2,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
