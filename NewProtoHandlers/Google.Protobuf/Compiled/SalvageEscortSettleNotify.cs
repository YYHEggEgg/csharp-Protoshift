// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SalvageEscortSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SalvageEscortSettleNotify.proto</summary>
public static partial class SalvageEscortSettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for SalvageEscortSettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SalvageEscortSettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9TYWx2YWdlRXNjb3J0U2V0dGxlTm90aWZ5LnByb3RvGh1TYWx2YWdlRXNj",
          "b3J0U2V0dGxlSW5mby5wcm90byJeChlTYWx2YWdlRXNjb3J0U2V0dGxlTm90",
          "aWZ5Ei0KC3NldHRsZV9pbmZvGAEgASgLMhguU2FsdmFnZUVzY29ydFNldHRs",
          "ZUluZm8SEgoKZ2FsbGVyeV9pZBgGIAEoDUIWChRvcmcuc29yYXBvaW50YS5w",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SalvageEscortSettleInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SalvageEscortSettleNotify), global::SalvageEscortSettleNotify.Parser, new[]{ "SettleInfo", "GalleryId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 8798;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class SalvageEscortSettleNotify : pb::IMessage<SalvageEscortSettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SalvageEscortSettleNotify> _parser = new pb::MessageParser<SalvageEscortSettleNotify>(() => new SalvageEscortSettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SalvageEscortSettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SalvageEscortSettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvageEscortSettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvageEscortSettleNotify(SalvageEscortSettleNotify other) : this() {
    settleInfo_ = other.settleInfo_ != null ? other.settleInfo_.Clone() : null;
    galleryId_ = other.galleryId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SalvageEscortSettleNotify Clone() {
    return new SalvageEscortSettleNotify(this);
  }

  /// <summary>Field number for the "settle_info" field.</summary>
  public const int SettleInfoFieldNumber = 1;
  private global::SalvageEscortSettleInfo settleInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::SalvageEscortSettleInfo SettleInfo {
    get { return settleInfo_; }
    set {
      settleInfo_ = value;
    }
  }

  /// <summary>Field number for the "gallery_id" field.</summary>
  public const int GalleryIdFieldNumber = 6;
  private uint galleryId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GalleryId {
    get { return galleryId_; }
    set {
      galleryId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SalvageEscortSettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SalvageEscortSettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
    if (GalleryId != other.GalleryId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (settleInfo_ != null) hash ^= SettleInfo.GetHashCode();
    if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
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
    if (settleInfo_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(SettleInfo);
    }
    if (GalleryId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GalleryId);
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
    if (settleInfo_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(SettleInfo);
    }
    if (GalleryId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GalleryId);
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
    if (settleInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
    }
    if (GalleryId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SalvageEscortSettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.settleInfo_ != null) {
      if (settleInfo_ == null) {
        SettleInfo = new global::SalvageEscortSettleInfo();
      }
      SettleInfo.MergeFrom(other.SettleInfo);
    }
    if (other.GalleryId != 0) {
      GalleryId = other.GalleryId;
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
        case 10: {
          if (settleInfo_ == null) {
            SettleInfo = new global::SalvageEscortSettleInfo();
          }
          input.ReadMessage(SettleInfo);
          break;
        }
        case 48: {
          GalleryId = input.ReadUInt32();
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
        case 10: {
          if (settleInfo_ == null) {
            SettleInfo = new global::SalvageEscortSettleInfo();
          }
          input.ReadMessage(SettleInfo);
          break;
        }
        case 48: {
          GalleryId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
