// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryFallScoreNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GalleryFallScoreNotify.proto</summary>
public static partial class GalleryFallScoreNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for GalleryFallScoreNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GalleryFallScoreNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxHYWxsZXJ5RmFsbFNjb3JlTm90aWZ5LnByb3RvGhVGYWxsUGxheWVyQnJp",
          "ZWYucHJvdG8iswEKFkdhbGxlcnlGYWxsU2NvcmVOb3RpZnkSPwoNdWlkX2Jy",
          "aWVmX21hcBgKIAMoCzIoLkdhbGxlcnlGYWxsU2NvcmVOb3RpZnkuVWlkQnJp",
          "ZWZNYXBFbnRyeRISCgpnYWxsZXJ5X2lkGA8gASgNGkQKEFVpZEJyaWVmTWFw",
          "RW50cnkSCwoDa2V5GAEgASgNEh8KBXZhbHVlGAIgASgLMhAuRmFsbFBsYXll",
          "ckJyaWVmOgI4AUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::FallPlayerBriefReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GalleryFallScoreNotify), global::GalleryFallScoreNotify.Parser, new[]{ "UidBriefMap", "GalleryId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 5543;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GalleryFallScoreNotify : pb::IMessage<GalleryFallScoreNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GalleryFallScoreNotify> _parser = new pb::MessageParser<GalleryFallScoreNotify>(() => new GalleryFallScoreNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GalleryFallScoreNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GalleryFallScoreNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GalleryFallScoreNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GalleryFallScoreNotify(GalleryFallScoreNotify other) : this() {
    uidBriefMap_ = other.uidBriefMap_.Clone();
    galleryId_ = other.galleryId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GalleryFallScoreNotify Clone() {
    return new GalleryFallScoreNotify(this);
  }

  /// <summary>Field number for the "uid_brief_map" field.</summary>
  public const int UidBriefMapFieldNumber = 10;
  private static readonly pbc::MapField<uint, global::FallPlayerBrief>.Codec _map_uidBriefMap_codec
      = new pbc::MapField<uint, global::FallPlayerBrief>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::FallPlayerBrief.Parser), 82);
  private readonly pbc::MapField<uint, global::FallPlayerBrief> uidBriefMap_ = new pbc::MapField<uint, global::FallPlayerBrief>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::FallPlayerBrief> UidBriefMap {
    get { return uidBriefMap_; }
  }

  /// <summary>Field number for the "gallery_id" field.</summary>
  public const int GalleryIdFieldNumber = 15;
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
    return Equals(other as GalleryFallScoreNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GalleryFallScoreNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!UidBriefMap.Equals(other.UidBriefMap)) return false;
    if (GalleryId != other.GalleryId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= UidBriefMap.GetHashCode();
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
    uidBriefMap_.WriteTo(output, _map_uidBriefMap_codec);
    if (GalleryId != 0) {
      output.WriteRawTag(120);
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
    uidBriefMap_.WriteTo(ref output, _map_uidBriefMap_codec);
    if (GalleryId != 0) {
      output.WriteRawTag(120);
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
    size += uidBriefMap_.CalculateSize(_map_uidBriefMap_codec);
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
  public void MergeFrom(GalleryFallScoreNotify other) {
    if (other == null) {
      return;
    }
    uidBriefMap_.Add(other.uidBriefMap_);
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
        case 82: {
          uidBriefMap_.AddEntriesFrom(input, _map_uidBriefMap_codec);
          break;
        }
        case 120: {
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
        case 82: {
          uidBriefMap_.AddEntriesFrom(ref input, _map_uidBriefMap_codec);
          break;
        }
        case 120: {
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