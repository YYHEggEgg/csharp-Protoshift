// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuickUseWidgetReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from QuickUseWidgetReq.proto</summary>
public static partial class QuickUseWidgetReqReflection {

  #region Descriptor
  /// <summary>File descriptor for QuickUseWidgetReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static QuickUseWidgetReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdRdWlja1VzZVdpZGdldFJlcS5wcm90bxoWV2lkZ2V0Q2FtZXJhSW5mby5w",
          "cm90bxoeV2lkZ2V0Q3JlYXRlTG9jYXRpb25JbmZvLnByb3RvGhdXaWRnZXRD",
          "cmVhdG9ySW5mby5wcm90bxoiV2lkZ2V0VGh1bmRlckJpcmRGZWF0aGVySW5m",
          "by5wcm90byLuAQoRUXVpY2tVc2VXaWRnZXRSZXESMwoNbG9jYXRpb25faW5m",
          "bxikBSABKAsyGS5XaWRnZXRDcmVhdGVMb2NhdGlvbkluZm9IABIpCgtjYW1l",
          "cmFfaW5mbxjeAyABKAsyES5XaWRnZXRDYW1lcmFJbmZvSAASKwoMY3JlYXRv",
          "cl9pbmZvGKwGIAEoCzISLldpZGdldENyZWF0b3JJbmZvSAASQwoZdGh1bmRl",
          "cl9iaXJkX2ZlYXRoZXJfaW5mbxjDDiABKAsyHS5XaWRnZXRUaHVuZGVyQmly",
          "ZEZlYXRoZXJJbmZvSABCBwoFcGFyYW1CHgocZW11LmdyYXNzY3V0dGVyLm5l",
          "dC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::WidgetCameraInfoReflection.Descriptor, global::WidgetCreateLocationInfoReflection.Descriptor, global::WidgetCreatorInfoReflection.Descriptor, global::WidgetThunderBirdFeatherInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::QuickUseWidgetReq), global::QuickUseWidgetReq.Parser, new[]{ "LocationInfo", "CameraInfo", "CreatorInfo", "ThunderBirdFeatherInfo" }, new[]{ "Param" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4299
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class QuickUseWidgetReq : pb::IMessage<QuickUseWidgetReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<QuickUseWidgetReq> _parser = new pb::MessageParser<QuickUseWidgetReq>(() => new QuickUseWidgetReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<QuickUseWidgetReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::QuickUseWidgetReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public QuickUseWidgetReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public QuickUseWidgetReq(QuickUseWidgetReq other) : this() {
    switch (other.ParamCase) {
      case ParamOneofCase.LocationInfo:
        LocationInfo = other.LocationInfo.Clone();
        break;
      case ParamOneofCase.CameraInfo:
        CameraInfo = other.CameraInfo.Clone();
        break;
      case ParamOneofCase.CreatorInfo:
        CreatorInfo = other.CreatorInfo.Clone();
        break;
      case ParamOneofCase.ThunderBirdFeatherInfo:
        ThunderBirdFeatherInfo = other.ThunderBirdFeatherInfo.Clone();
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public QuickUseWidgetReq Clone() {
    return new QuickUseWidgetReq(this);
  }

  /// <summary>Field number for the "location_info" field.</summary>
  public const int LocationInfoFieldNumber = 676;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::WidgetCreateLocationInfo LocationInfo {
    get { return paramCase_ == ParamOneofCase.LocationInfo ? (global::WidgetCreateLocationInfo) param_ : null; }
    set {
      param_ = value;
      paramCase_ = value == null ? ParamOneofCase.None : ParamOneofCase.LocationInfo;
    }
  }

  /// <summary>Field number for the "camera_info" field.</summary>
  public const int CameraInfoFieldNumber = 478;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::WidgetCameraInfo CameraInfo {
    get { return paramCase_ == ParamOneofCase.CameraInfo ? (global::WidgetCameraInfo) param_ : null; }
    set {
      param_ = value;
      paramCase_ = value == null ? ParamOneofCase.None : ParamOneofCase.CameraInfo;
    }
  }

  /// <summary>Field number for the "creator_info" field.</summary>
  public const int CreatorInfoFieldNumber = 812;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::WidgetCreatorInfo CreatorInfo {
    get { return paramCase_ == ParamOneofCase.CreatorInfo ? (global::WidgetCreatorInfo) param_ : null; }
    set {
      param_ = value;
      paramCase_ = value == null ? ParamOneofCase.None : ParamOneofCase.CreatorInfo;
    }
  }

  /// <summary>Field number for the "thunder_bird_feather_info" field.</summary>
  public const int ThunderBirdFeatherInfoFieldNumber = 1859;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::WidgetThunderBirdFeatherInfo ThunderBirdFeatherInfo {
    get { return paramCase_ == ParamOneofCase.ThunderBirdFeatherInfo ? (global::WidgetThunderBirdFeatherInfo) param_ : null; }
    set {
      param_ = value;
      paramCase_ = value == null ? ParamOneofCase.None : ParamOneofCase.ThunderBirdFeatherInfo;
    }
  }

  private object param_;
  /// <summary>Enum of possible cases for the "param" oneof.</summary>
  public enum ParamOneofCase {
    None = 0,
    LocationInfo = 676,
    CameraInfo = 478,
    CreatorInfo = 812,
    ThunderBirdFeatherInfo = 1859,
  }
  private ParamOneofCase paramCase_ = ParamOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ParamOneofCase ParamCase {
    get { return paramCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearParam() {
    paramCase_ = ParamOneofCase.None;
    param_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as QuickUseWidgetReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(QuickUseWidgetReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(LocationInfo, other.LocationInfo)) return false;
    if (!object.Equals(CameraInfo, other.CameraInfo)) return false;
    if (!object.Equals(CreatorInfo, other.CreatorInfo)) return false;
    if (!object.Equals(ThunderBirdFeatherInfo, other.ThunderBirdFeatherInfo)) return false;
    if (ParamCase != other.ParamCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (paramCase_ == ParamOneofCase.LocationInfo) hash ^= LocationInfo.GetHashCode();
    if (paramCase_ == ParamOneofCase.CameraInfo) hash ^= CameraInfo.GetHashCode();
    if (paramCase_ == ParamOneofCase.CreatorInfo) hash ^= CreatorInfo.GetHashCode();
    if (paramCase_ == ParamOneofCase.ThunderBirdFeatherInfo) hash ^= ThunderBirdFeatherInfo.GetHashCode();
    hash ^= (int) paramCase_;
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
    if (paramCase_ == ParamOneofCase.CameraInfo) {
      output.WriteRawTag(242, 29);
      output.WriteMessage(CameraInfo);
    }
    if (paramCase_ == ParamOneofCase.LocationInfo) {
      output.WriteRawTag(162, 42);
      output.WriteMessage(LocationInfo);
    }
    if (paramCase_ == ParamOneofCase.CreatorInfo) {
      output.WriteRawTag(226, 50);
      output.WriteMessage(CreatorInfo);
    }
    if (paramCase_ == ParamOneofCase.ThunderBirdFeatherInfo) {
      output.WriteRawTag(154, 116);
      output.WriteMessage(ThunderBirdFeatherInfo);
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
    if (paramCase_ == ParamOneofCase.CameraInfo) {
      output.WriteRawTag(242, 29);
      output.WriteMessage(CameraInfo);
    }
    if (paramCase_ == ParamOneofCase.LocationInfo) {
      output.WriteRawTag(162, 42);
      output.WriteMessage(LocationInfo);
    }
    if (paramCase_ == ParamOneofCase.CreatorInfo) {
      output.WriteRawTag(226, 50);
      output.WriteMessage(CreatorInfo);
    }
    if (paramCase_ == ParamOneofCase.ThunderBirdFeatherInfo) {
      output.WriteRawTag(154, 116);
      output.WriteMessage(ThunderBirdFeatherInfo);
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
    if (paramCase_ == ParamOneofCase.LocationInfo) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(LocationInfo);
    }
    if (paramCase_ == ParamOneofCase.CameraInfo) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(CameraInfo);
    }
    if (paramCase_ == ParamOneofCase.CreatorInfo) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(CreatorInfo);
    }
    if (paramCase_ == ParamOneofCase.ThunderBirdFeatherInfo) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(ThunderBirdFeatherInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(QuickUseWidgetReq other) {
    if (other == null) {
      return;
    }
    switch (other.ParamCase) {
      case ParamOneofCase.LocationInfo:
        if (LocationInfo == null) {
          LocationInfo = new global::WidgetCreateLocationInfo();
        }
        LocationInfo.MergeFrom(other.LocationInfo);
        break;
      case ParamOneofCase.CameraInfo:
        if (CameraInfo == null) {
          CameraInfo = new global::WidgetCameraInfo();
        }
        CameraInfo.MergeFrom(other.CameraInfo);
        break;
      case ParamOneofCase.CreatorInfo:
        if (CreatorInfo == null) {
          CreatorInfo = new global::WidgetCreatorInfo();
        }
        CreatorInfo.MergeFrom(other.CreatorInfo);
        break;
      case ParamOneofCase.ThunderBirdFeatherInfo:
        if (ThunderBirdFeatherInfo == null) {
          ThunderBirdFeatherInfo = new global::WidgetThunderBirdFeatherInfo();
        }
        ThunderBirdFeatherInfo.MergeFrom(other.ThunderBirdFeatherInfo);
        break;
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
        case 3826: {
          global::WidgetCameraInfo subBuilder = new global::WidgetCameraInfo();
          if (paramCase_ == ParamOneofCase.CameraInfo) {
            subBuilder.MergeFrom(CameraInfo);
          }
          input.ReadMessage(subBuilder);
          CameraInfo = subBuilder;
          break;
        }
        case 5410: {
          global::WidgetCreateLocationInfo subBuilder = new global::WidgetCreateLocationInfo();
          if (paramCase_ == ParamOneofCase.LocationInfo) {
            subBuilder.MergeFrom(LocationInfo);
          }
          input.ReadMessage(subBuilder);
          LocationInfo = subBuilder;
          break;
        }
        case 6498: {
          global::WidgetCreatorInfo subBuilder = new global::WidgetCreatorInfo();
          if (paramCase_ == ParamOneofCase.CreatorInfo) {
            subBuilder.MergeFrom(CreatorInfo);
          }
          input.ReadMessage(subBuilder);
          CreatorInfo = subBuilder;
          break;
        }
        case 14874: {
          global::WidgetThunderBirdFeatherInfo subBuilder = new global::WidgetThunderBirdFeatherInfo();
          if (paramCase_ == ParamOneofCase.ThunderBirdFeatherInfo) {
            subBuilder.MergeFrom(ThunderBirdFeatherInfo);
          }
          input.ReadMessage(subBuilder);
          ThunderBirdFeatherInfo = subBuilder;
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
        case 3826: {
          global::WidgetCameraInfo subBuilder = new global::WidgetCameraInfo();
          if (paramCase_ == ParamOneofCase.CameraInfo) {
            subBuilder.MergeFrom(CameraInfo);
          }
          input.ReadMessage(subBuilder);
          CameraInfo = subBuilder;
          break;
        }
        case 5410: {
          global::WidgetCreateLocationInfo subBuilder = new global::WidgetCreateLocationInfo();
          if (paramCase_ == ParamOneofCase.LocationInfo) {
            subBuilder.MergeFrom(LocationInfo);
          }
          input.ReadMessage(subBuilder);
          LocationInfo = subBuilder;
          break;
        }
        case 6498: {
          global::WidgetCreatorInfo subBuilder = new global::WidgetCreatorInfo();
          if (paramCase_ == ParamOneofCase.CreatorInfo) {
            subBuilder.MergeFrom(CreatorInfo);
          }
          input.ReadMessage(subBuilder);
          CreatorInfo = subBuilder;
          break;
        }
        case 14874: {
          global::WidgetThunderBirdFeatherInfo subBuilder = new global::WidgetThunderBirdFeatherInfo();
          if (paramCase_ == ParamOneofCase.ThunderBirdFeatherInfo) {
            subBuilder.MergeFrom(ThunderBirdFeatherInfo);
          }
          input.ReadMessage(subBuilder);
          ThunderBirdFeatherInfo = subBuilder;
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
