// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DeshretObeliskChestInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from DeshretObeliskChestInfo.proto</summary>
public static partial class DeshretObeliskChestInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for DeshretObeliskChestInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DeshretObeliskChestInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1EZXNocmV0T2JlbGlza0NoZXN0SW5mby5wcm90bxoMVmVjdG9yLnByb3Rv",
          "ImYKF0Rlc2hyZXRPYmVsaXNrQ2hlc3RJbmZvEhAKCHNjZW5lX2lkGAUgASgN",
          "EhQKA3BvcxgJIAEoCzIHLlZlY3RvchIQCghncm91cF9pZBgHIAEoDRIRCglj",
          "b25maWdfaWQYAyABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DeshretObeliskChestInfo), global::DeshretObeliskChestInfo.Parser, new[]{ "SceneId", "Pos", "GroupId", "ConfigId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class DeshretObeliskChestInfo : pb::IMessage<DeshretObeliskChestInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<DeshretObeliskChestInfo> _parser = new pb::MessageParser<DeshretObeliskChestInfo>(() => new DeshretObeliskChestInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<DeshretObeliskChestInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DeshretObeliskChestInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DeshretObeliskChestInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DeshretObeliskChestInfo(DeshretObeliskChestInfo other) : this() {
    sceneId_ = other.sceneId_;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    groupId_ = other.groupId_;
    configId_ = other.configId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DeshretObeliskChestInfo Clone() {
    return new DeshretObeliskChestInfo(this);
  }

  /// <summary>Field number for the "scene_id" field.</summary>
  public const int SceneIdFieldNumber = 5;
  private uint sceneId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SceneId {
    get { return sceneId_; }
    set {
      sceneId_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 9;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  /// <summary>Field number for the "group_id" field.</summary>
  public const int GroupIdFieldNumber = 7;
  private uint groupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GroupId {
    get { return groupId_; }
    set {
      groupId_ = value;
    }
  }

  /// <summary>Field number for the "config_id" field.</summary>
  public const int ConfigIdFieldNumber = 3;
  private uint configId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConfigId {
    get { return configId_; }
    set {
      configId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as DeshretObeliskChestInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(DeshretObeliskChestInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (SceneId != other.SceneId) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    if (GroupId != other.GroupId) return false;
    if (ConfigId != other.ConfigId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (SceneId != 0) hash ^= SceneId.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
    if (GroupId != 0) hash ^= GroupId.GetHashCode();
    if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
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
    if (ConfigId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ConfigId);
    }
    if (SceneId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(SceneId);
    }
    if (GroupId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(GroupId);
    }
    if (pos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(Pos);
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
    if (ConfigId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ConfigId);
    }
    if (SceneId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(SceneId);
    }
    if (GroupId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(GroupId);
    }
    if (pos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(Pos);
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
    if (SceneId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (GroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
    }
    if (ConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(DeshretObeliskChestInfo other) {
    if (other == null) {
      return;
    }
    if (other.SceneId != 0) {
      SceneId = other.SceneId;
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
    }
    if (other.GroupId != 0) {
      GroupId = other.GroupId;
    }
    if (other.ConfigId != 0) {
      ConfigId = other.ConfigId;
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
          ConfigId = input.ReadUInt32();
          break;
        }
        case 40: {
          SceneId = input.ReadUInt32();
          break;
        }
        case 56: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 74: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
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
          ConfigId = input.ReadUInt32();
          break;
        }
        case 40: {
          SceneId = input.ReadUInt32();
          break;
        }
        case 56: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 74: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
