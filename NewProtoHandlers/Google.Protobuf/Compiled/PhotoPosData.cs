// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PhotoPosData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PhotoPosData.proto</summary>
public static partial class PhotoPosDataReflection {

  #region Descriptor
  /// <summary>File descriptor for PhotoPosData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PhotoPosDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChJQaG90b1Bvc0RhdGEucHJvdG8aDFZlY3Rvci5wcm90byJsCgxQaG90b1Bv",
          "c0RhdGESEQoJb3Blbl90aW1lGAogASgNEg4KBnBvc19pZBgJIAEoDRIXCgZj",
          "ZW50ZXIYByABKAsyBy5WZWN0b3ISDwoHaXNfdmlldxgNIAEoCBIPCgdpc19v",
          "cGVuGAMgASgIQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PhotoPosData), global::PhotoPosData.Parser, new[]{ "OpenTime", "PosId", "Center", "IsView", "IsOpen" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class PhotoPosData : pb::IMessage<PhotoPosData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PhotoPosData> _parser = new pb::MessageParser<PhotoPosData>(() => new PhotoPosData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PhotoPosData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PhotoPosDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PhotoPosData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PhotoPosData(PhotoPosData other) : this() {
    openTime_ = other.openTime_;
    posId_ = other.posId_;
    center_ = other.center_ != null ? other.center_.Clone() : null;
    isView_ = other.isView_;
    isOpen_ = other.isOpen_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PhotoPosData Clone() {
    return new PhotoPosData(this);
  }

  /// <summary>Field number for the "open_time" field.</summary>
  public const int OpenTimeFieldNumber = 10;
  private uint openTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OpenTime {
    get { return openTime_; }
    set {
      openTime_ = value;
    }
  }

  /// <summary>Field number for the "pos_id" field.</summary>
  public const int PosIdFieldNumber = 9;
  private uint posId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PosId {
    get { return posId_; }
    set {
      posId_ = value;
    }
  }

  /// <summary>Field number for the "center" field.</summary>
  public const int CenterFieldNumber = 7;
  private global::Vector center_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Center {
    get { return center_; }
    set {
      center_ = value;
    }
  }

  /// <summary>Field number for the "is_view" field.</summary>
  public const int IsViewFieldNumber = 13;
  private bool isView_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsView {
    get { return isView_; }
    set {
      isView_ = value;
    }
  }

  /// <summary>Field number for the "is_open" field.</summary>
  public const int IsOpenFieldNumber = 3;
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
    return Equals(other as PhotoPosData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PhotoPosData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (OpenTime != other.OpenTime) return false;
    if (PosId != other.PosId) return false;
    if (!object.Equals(Center, other.Center)) return false;
    if (IsView != other.IsView) return false;
    if (IsOpen != other.IsOpen) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
    if (PosId != 0) hash ^= PosId.GetHashCode();
    if (center_ != null) hash ^= Center.GetHashCode();
    if (IsView != false) hash ^= IsView.GetHashCode();
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
      output.WriteRawTag(24);
      output.WriteBool(IsOpen);
    }
    if (center_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Center);
    }
    if (PosId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(PosId);
    }
    if (OpenTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(OpenTime);
    }
    if (IsView != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsView);
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
    if (IsOpen != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsOpen);
    }
    if (center_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Center);
    }
    if (PosId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(PosId);
    }
    if (OpenTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(OpenTime);
    }
    if (IsView != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsView);
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
    if (OpenTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
    }
    if (PosId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PosId);
    }
    if (center_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Center);
    }
    if (IsView != false) {
      size += 1 + 1;
    }
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
  public void MergeFrom(PhotoPosData other) {
    if (other == null) {
      return;
    }
    if (other.OpenTime != 0) {
      OpenTime = other.OpenTime;
    }
    if (other.PosId != 0) {
      PosId = other.PosId;
    }
    if (other.center_ != null) {
      if (center_ == null) {
        Center = new global::Vector();
      }
      Center.MergeFrom(other.Center);
    }
    if (other.IsView != false) {
      IsView = other.IsView;
    }
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
        case 24: {
          IsOpen = input.ReadBool();
          break;
        }
        case 58: {
          if (center_ == null) {
            Center = new global::Vector();
          }
          input.ReadMessage(Center);
          break;
        }
        case 72: {
          PosId = input.ReadUInt32();
          break;
        }
        case 80: {
          OpenTime = input.ReadUInt32();
          break;
        }
        case 104: {
          IsView = input.ReadBool();
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
        case 24: {
          IsOpen = input.ReadBool();
          break;
        }
        case 58: {
          if (center_ == null) {
            Center = new global::Vector();
          }
          input.ReadMessage(Center);
          break;
        }
        case 72: {
          PosId = input.ReadUInt32();
          break;
        }
        case 80: {
          OpenTime = input.ReadUInt32();
          break;
        }
        case 104: {
          IsView = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
