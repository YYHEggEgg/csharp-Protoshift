// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeUpdatePictureFrameInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HomeUpdatePictureFrameInfoRsp.proto</summary>
public static partial class HomeUpdatePictureFrameInfoRspReflection {

  #region Descriptor
  /// <summary>File descriptor for HomeUpdatePictureFrameInfoRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HomeUpdatePictureFrameInfoRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNIb21lVXBkYXRlUGljdHVyZUZyYW1lSW5mb1JzcC5wcm90bxoaSG9tZVBp",
          "Y3R1cmVGcmFtZUluZm8ucHJvdG8iYwodSG9tZVVwZGF0ZVBpY3R1cmVGcmFt",
          "ZUluZm9Sc3ASDwoHcmV0Y29kZRgNIAEoBRIxChJwaWN0dXJlX2ZyYW1lX2lu",
          "Zm8YDiABKAsyFS5Ib21lUGljdHVyZUZyYW1lSW5mb0IeChxlbXUuZ3Jhc3Nj",
          "dXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HomePictureFrameInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HomeUpdatePictureFrameInfoRsp), global::HomeUpdatePictureFrameInfoRsp.Parser, new[]{ "Retcode", "PictureFrameInfo" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4641
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class HomeUpdatePictureFrameInfoRsp : pb::IMessage<HomeUpdatePictureFrameInfoRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HomeUpdatePictureFrameInfoRsp> _parser = new pb::MessageParser<HomeUpdatePictureFrameInfoRsp>(() => new HomeUpdatePictureFrameInfoRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HomeUpdatePictureFrameInfoRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HomeUpdatePictureFrameInfoRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeUpdatePictureFrameInfoRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeUpdatePictureFrameInfoRsp(HomeUpdatePictureFrameInfoRsp other) : this() {
    retcode_ = other.retcode_;
    pictureFrameInfo_ = other.pictureFrameInfo_ != null ? other.pictureFrameInfo_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HomeUpdatePictureFrameInfoRsp Clone() {
    return new HomeUpdatePictureFrameInfoRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 13;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "picture_frame_info" field.</summary>
  public const int PictureFrameInfoFieldNumber = 14;
  private global::HomePictureFrameInfo pictureFrameInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::HomePictureFrameInfo PictureFrameInfo {
    get { return pictureFrameInfo_; }
    set {
      pictureFrameInfo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HomeUpdatePictureFrameInfoRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HomeUpdatePictureFrameInfoRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if (!object.Equals(PictureFrameInfo, other.PictureFrameInfo)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (pictureFrameInfo_ != null) hash ^= PictureFrameInfo.GetHashCode();
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
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
    }
    if (pictureFrameInfo_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(PictureFrameInfo);
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
      output.WriteRawTag(104);
      output.WriteInt32(Retcode);
    }
    if (pictureFrameInfo_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(PictureFrameInfo);
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
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (pictureFrameInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(PictureFrameInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HomeUpdatePictureFrameInfoRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.pictureFrameInfo_ != null) {
      if (pictureFrameInfo_ == null) {
        PictureFrameInfo = new global::HomePictureFrameInfo();
      }
      PictureFrameInfo.MergeFrom(other.PictureFrameInfo);
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
        case 104: {
          Retcode = input.ReadInt32();
          break;
        }
        case 114: {
          if (pictureFrameInfo_ == null) {
            PictureFrameInfo = new global::HomePictureFrameInfo();
          }
          input.ReadMessage(PictureFrameInfo);
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
        case 104: {
          Retcode = input.ReadInt32();
          break;
        }
        case 114: {
          if (pictureFrameInfo_ == null) {
            PictureFrameInfo = new global::HomePictureFrameInfo();
          }
          input.ReadMessage(PictureFrameInfo);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
