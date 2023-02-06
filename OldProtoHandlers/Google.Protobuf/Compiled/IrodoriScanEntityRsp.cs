// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriScanEntityRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IrodoriScanEntityRsp.proto</summary>
public static partial class IrodoriScanEntityRspReflection {

  #region Descriptor
  /// <summary>File descriptor for IrodoriScanEntityRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IrodoriScanEntityRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpJcm9kb3JpU2NhbkVudGl0eVJzcC5wcm90bxocSXJvZG9yaVBvZXRyeVRo",
          "ZW1lRGF0YS5wcm90byJwChRJcm9kb3JpU2NhbkVudGl0eVJzcBIrCgp0aGVt",
          "ZV9kYXRhGAogASgLMhcuSXJvZG9yaVBvZXRyeVRoZW1lRGF0YRIPCgdyZXRj",
          "b2RlGAUgASgFEhoKEmlzX2dldF9pbnNwaXJhdGlvbhgBIAEoCEIeChxlbXUu",
          "Z3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::IrodoriPoetryThemeDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IrodoriScanEntityRsp), global::IrodoriScanEntityRsp.Parser, new[]{ "ThemeData", "Retcode", "IsGetInspiration" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8026
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class IrodoriScanEntityRsp : pb::IMessage<IrodoriScanEntityRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IrodoriScanEntityRsp> _parser = new pb::MessageParser<IrodoriScanEntityRsp>(() => new IrodoriScanEntityRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IrodoriScanEntityRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IrodoriScanEntityRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriScanEntityRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriScanEntityRsp(IrodoriScanEntityRsp other) : this() {
    themeData_ = other.themeData_ != null ? other.themeData_.Clone() : null;
    retcode_ = other.retcode_;
    isGetInspiration_ = other.isGetInspiration_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriScanEntityRsp Clone() {
    return new IrodoriScanEntityRsp(this);
  }

  /// <summary>Field number for the "theme_data" field.</summary>
  public const int ThemeDataFieldNumber = 10;
  private global::IrodoriPoetryThemeData themeData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::IrodoriPoetryThemeData ThemeData {
    get { return themeData_; }
    set {
      themeData_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 5;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "is_get_inspiration" field.</summary>
  public const int IsGetInspirationFieldNumber = 1;
  private bool isGetInspiration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsGetInspiration {
    get { return isGetInspiration_; }
    set {
      isGetInspiration_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as IrodoriScanEntityRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IrodoriScanEntityRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(ThemeData, other.ThemeData)) return false;
    if (Retcode != other.Retcode) return false;
    if (IsGetInspiration != other.IsGetInspiration) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (themeData_ != null) hash ^= ThemeData.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (IsGetInspiration != false) hash ^= IsGetInspiration.GetHashCode();
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
    if (IsGetInspiration != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsGetInspiration);
    }
    if (Retcode != 0) {
      output.WriteRawTag(40);
      output.WriteInt32(Retcode);
    }
    if (themeData_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(ThemeData);
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
    if (IsGetInspiration != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsGetInspiration);
    }
    if (Retcode != 0) {
      output.WriteRawTag(40);
      output.WriteInt32(Retcode);
    }
    if (themeData_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(ThemeData);
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
    if (themeData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ThemeData);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (IsGetInspiration != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(IrodoriScanEntityRsp other) {
    if (other == null) {
      return;
    }
    if (other.themeData_ != null) {
      if (themeData_ == null) {
        ThemeData = new global::IrodoriPoetryThemeData();
      }
      ThemeData.MergeFrom(other.ThemeData);
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.IsGetInspiration != false) {
      IsGetInspiration = other.IsGetInspiration;
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
        case 8: {
          IsGetInspiration = input.ReadBool();
          break;
        }
        case 40: {
          Retcode = input.ReadInt32();
          break;
        }
        case 82: {
          if (themeData_ == null) {
            ThemeData = new global::IrodoriPoetryThemeData();
          }
          input.ReadMessage(ThemeData);
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
        case 8: {
          IsGetInspiration = input.ReadBool();
          break;
        }
        case 40: {
          Retcode = input.ReadInt32();
          break;
        }
        case 82: {
          if (themeData_ == null) {
            ThemeData = new global::IrodoriPoetryThemeData();
          }
          input.ReadMessage(ThemeData);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
