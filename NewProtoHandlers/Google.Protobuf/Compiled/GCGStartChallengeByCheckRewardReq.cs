// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGStartChallengeByCheckRewardReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGStartChallengeByCheckRewardReq.proto</summary>
public static partial class GCGStartChallengeByCheckRewardReqReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGStartChallengeByCheckRewardReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGStartChallengeByCheckRewardReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CidHQ0dTdGFydENoYWxsZW5nZUJ5Q2hlY2tSZXdhcmRSZXEucHJvdG8aEkdD",
          "R0xldmVsVHlwZS5wcm90byJrCiFHQ0dTdGFydENoYWxsZW5nZUJ5Q2hlY2tS",
          "ZXdhcmRSZXESEAoIbGV2ZWxfaWQYDSABKA0SIQoKbGV2ZWxfdHlwZRgDIAEo",
          "DjINLkdDR0xldmVsVHlwZRIRCgljb25maWdfaWQYBSABKA1CFgoUb3JnLnNv",
          "cmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGLevelTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGStartChallengeByCheckRewardReq), global::GCGStartChallengeByCheckRewardReq.Parser, new[]{ "LevelId", "LevelType", "ConfigId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 7982;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class GCGStartChallengeByCheckRewardReq : pb::IMessage<GCGStartChallengeByCheckRewardReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGStartChallengeByCheckRewardReq> _parser = new pb::MessageParser<GCGStartChallengeByCheckRewardReq>(() => new GCGStartChallengeByCheckRewardReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGStartChallengeByCheckRewardReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGStartChallengeByCheckRewardReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGStartChallengeByCheckRewardReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGStartChallengeByCheckRewardReq(GCGStartChallengeByCheckRewardReq other) : this() {
    levelId_ = other.levelId_;
    levelType_ = other.levelType_;
    configId_ = other.configId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGStartChallengeByCheckRewardReq Clone() {
    return new GCGStartChallengeByCheckRewardReq(this);
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 13;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "level_type" field.</summary>
  public const int LevelTypeFieldNumber = 3;
  private global::GCGLevelType levelType_ = global::GCGLevelType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGLevelType LevelType {
    get { return levelType_; }
    set {
      levelType_ = value;
    }
  }

  /// <summary>Field number for the "config_id" field.</summary>
  public const int ConfigIdFieldNumber = 5;
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
    return Equals(other as GCGStartChallengeByCheckRewardReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGStartChallengeByCheckRewardReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (LevelId != other.LevelId) return false;
    if (LevelType != other.LevelType) return false;
    if (ConfigId != other.ConfigId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (LevelType != global::GCGLevelType.None) hash ^= LevelType.GetHashCode();
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
    if (LevelType != global::GCGLevelType.None) {
      output.WriteRawTag(24);
      output.WriteEnum((int) LevelType);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ConfigId);
    }
    if (LevelId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(LevelId);
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
    if (LevelType != global::GCGLevelType.None) {
      output.WriteRawTag(24);
      output.WriteEnum((int) LevelType);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(ConfigId);
    }
    if (LevelId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(LevelId);
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
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (LevelType != global::GCGLevelType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LevelType);
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
  public void MergeFrom(GCGStartChallengeByCheckRewardReq other) {
    if (other == null) {
      return;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.LevelType != global::GCGLevelType.None) {
      LevelType = other.LevelType;
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
          LevelType = (global::GCGLevelType) input.ReadEnum();
          break;
        }
        case 40: {
          ConfigId = input.ReadUInt32();
          break;
        }
        case 104: {
          LevelId = input.ReadUInt32();
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
          LevelType = (global::GCGLevelType) input.ReadEnum();
          break;
        }
        case 40: {
          ConfigId = input.ReadUInt32();
          break;
        }
        case 104: {
          LevelId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
