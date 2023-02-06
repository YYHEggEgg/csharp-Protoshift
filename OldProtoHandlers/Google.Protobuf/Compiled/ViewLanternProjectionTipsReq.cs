// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ViewLanternProjectionTipsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ViewLanternProjectionTipsReq.proto</summary>
public static partial class ViewLanternProjectionTipsReqReflection {

  #region Descriptor
  /// <summary>File descriptor for ViewLanternProjectionTipsReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ViewLanternProjectionTipsReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiJWaWV3TGFudGVyblByb2plY3Rpb25UaXBzUmVxLnByb3RvGhVDbGllbnRJ",
          "bnB1dFR5cGUucHJvdG8iWwocVmlld0xhbnRlcm5Qcm9qZWN0aW9uVGlwc1Jl",
          "cRIVCg1pc19pbnB1dF90aXBzGAkgASgIEiQKCmlucHV0X3R5cGUYCiABKA4y",
          "EC5DbGllbnRJbnB1dFR5cGVCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRw",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ClientInputTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ViewLanternProjectionTipsReq), global::ViewLanternProjectionTipsReq.Parser, new[]{ "IsInputTips", "InputType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8218
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class ViewLanternProjectionTipsReq : pb::IMessage<ViewLanternProjectionTipsReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ViewLanternProjectionTipsReq> _parser = new pb::MessageParser<ViewLanternProjectionTipsReq>(() => new ViewLanternProjectionTipsReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ViewLanternProjectionTipsReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ViewLanternProjectionTipsReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ViewLanternProjectionTipsReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ViewLanternProjectionTipsReq(ViewLanternProjectionTipsReq other) : this() {
    isInputTips_ = other.isInputTips_;
    inputType_ = other.inputType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ViewLanternProjectionTipsReq Clone() {
    return new ViewLanternProjectionTipsReq(this);
  }

  /// <summary>Field number for the "is_input_tips" field.</summary>
  public const int IsInputTipsFieldNumber = 9;
  private bool isInputTips_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsInputTips {
    get { return isInputTips_; }
    set {
      isInputTips_ = value;
    }
  }

  /// <summary>Field number for the "input_type" field.</summary>
  public const int InputTypeFieldNumber = 10;
  private global::ClientInputType inputType_ = global::ClientInputType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ClientInputType InputType {
    get { return inputType_; }
    set {
      inputType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ViewLanternProjectionTipsReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ViewLanternProjectionTipsReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsInputTips != other.IsInputTips) return false;
    if (InputType != other.InputType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsInputTips != false) hash ^= IsInputTips.GetHashCode();
    if (InputType != global::ClientInputType.None) hash ^= InputType.GetHashCode();
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
    if (IsInputTips != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsInputTips);
    }
    if (InputType != global::ClientInputType.None) {
      output.WriteRawTag(80);
      output.WriteEnum((int) InputType);
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
    if (IsInputTips != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsInputTips);
    }
    if (InputType != global::ClientInputType.None) {
      output.WriteRawTag(80);
      output.WriteEnum((int) InputType);
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
    if (IsInputTips != false) {
      size += 1 + 1;
    }
    if (InputType != global::ClientInputType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InputType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ViewLanternProjectionTipsReq other) {
    if (other == null) {
      return;
    }
    if (other.IsInputTips != false) {
      IsInputTips = other.IsInputTips;
    }
    if (other.InputType != global::ClientInputType.None) {
      InputType = other.InputType;
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
        case 72: {
          IsInputTips = input.ReadBool();
          break;
        }
        case 80: {
          InputType = (global::ClientInputType) input.ReadEnum();
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
        case 72: {
          IsInputTips = input.ReadBool();
          break;
        }
        case 80: {
          InputType = (global::ClientInputType) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
