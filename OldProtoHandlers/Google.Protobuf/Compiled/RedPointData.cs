// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RedPointData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RedPointData.proto</summary>
public static partial class RedPointDataReflection {

  #region Descriptor
  /// <summary>File descriptor for RedPointData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RedPointDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChJSZWRQb2ludERhdGEucHJvdG8iSwoMUmVkUG9pbnREYXRhEhYKDnJlZF9w",
          "b2ludF90eXBlGAEgASgNEg8KB2lzX3Nob3cYAiABKAgSEgoKY29udGVudF9p",
          "ZBgDIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RedPointData), global::RedPointData.Parser, new[]{ "RedPointType", "IsShow", "ContentId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RedPointData : pb::IMessage<RedPointData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RedPointData> _parser = new pb::MessageParser<RedPointData>(() => new RedPointData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RedPointData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RedPointDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RedPointData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RedPointData(RedPointData other) : this() {
    redPointType_ = other.redPointType_;
    isShow_ = other.isShow_;
    contentId_ = other.contentId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RedPointData Clone() {
    return new RedPointData(this);
  }

  /// <summary>Field number for the "red_point_type" field.</summary>
  public const int RedPointTypeFieldNumber = 1;
  private uint redPointType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RedPointType {
    get { return redPointType_; }
    set {
      redPointType_ = value;
    }
  }

  /// <summary>Field number for the "is_show" field.</summary>
  public const int IsShowFieldNumber = 2;
  private bool isShow_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsShow {
    get { return isShow_; }
    set {
      isShow_ = value;
    }
  }

  /// <summary>Field number for the "content_id" field.</summary>
  public const int ContentIdFieldNumber = 3;
  private uint contentId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ContentId {
    get { return contentId_; }
    set {
      contentId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RedPointData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RedPointData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RedPointType != other.RedPointType) return false;
    if (IsShow != other.IsShow) return false;
    if (ContentId != other.ContentId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RedPointType != 0) hash ^= RedPointType.GetHashCode();
    if (IsShow != false) hash ^= IsShow.GetHashCode();
    if (ContentId != 0) hash ^= ContentId.GetHashCode();
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
    if (RedPointType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(RedPointType);
    }
    if (IsShow != false) {
      output.WriteRawTag(16);
      output.WriteBool(IsShow);
    }
    if (ContentId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ContentId);
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
    if (RedPointType != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(RedPointType);
    }
    if (IsShow != false) {
      output.WriteRawTag(16);
      output.WriteBool(IsShow);
    }
    if (ContentId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ContentId);
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
    if (RedPointType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RedPointType);
    }
    if (IsShow != false) {
      size += 1 + 1;
    }
    if (ContentId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RedPointData other) {
    if (other == null) {
      return;
    }
    if (other.RedPointType != 0) {
      RedPointType = other.RedPointType;
    }
    if (other.IsShow != false) {
      IsShow = other.IsShow;
    }
    if (other.ContentId != 0) {
      ContentId = other.ContentId;
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
          RedPointType = input.ReadUInt32();
          break;
        }
        case 16: {
          IsShow = input.ReadBool();
          break;
        }
        case 24: {
          ContentId = input.ReadUInt32();
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
          RedPointType = input.ReadUInt32();
          break;
        }
        case 16: {
          IsShow = input.ReadBool();
          break;
        }
        case 24: {
          ContentId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
