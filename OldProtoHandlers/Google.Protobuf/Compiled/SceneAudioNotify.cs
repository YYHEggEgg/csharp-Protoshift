// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneAudioNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneAudioNotify.proto</summary>
public static partial class SceneAudioNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneAudioNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneAudioNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZTY2VuZUF1ZGlvTm90aWZ5LnByb3RvImQKEFNjZW5lQXVkaW9Ob3RpZnkS",
          "DgoGcGFyYW0yGA4gAygCEgwKBHR5cGUYAyABKAUSDgoGcGFyYW0zGAsgAygJ",
          "EhIKCnNvdXJjZV91aWQYBiABKA0SDgoGcGFyYW0xGAQgAygNQh4KHGVtdS5n",
          "cmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneAudioNotify), global::SceneAudioNotify.Parser, new[]{ "Param2", "Type", "Param3", "SourceUid", "Param1" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 3166
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class SceneAudioNotify : pb::IMessage<SceneAudioNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneAudioNotify> _parser = new pb::MessageParser<SceneAudioNotify>(() => new SceneAudioNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneAudioNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneAudioNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneAudioNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneAudioNotify(SceneAudioNotify other) : this() {
    param2_ = other.param2_.Clone();
    type_ = other.type_;
    param3_ = other.param3_.Clone();
    sourceUid_ = other.sourceUid_;
    param1_ = other.param1_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneAudioNotify Clone() {
    return new SceneAudioNotify(this);
  }

  /// <summary>Field number for the "param2" field.</summary>
  public const int Param2FieldNumber = 14;
  private static readonly pb::FieldCodec<float> _repeated_param2_codec
      = pb::FieldCodec.ForFloat(114);
  private readonly pbc::RepeatedField<float> param2_ = new pbc::RepeatedField<float>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<float> Param2 {
    get { return param2_; }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 3;
  private int type_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  /// <summary>Field number for the "param3" field.</summary>
  public const int Param3FieldNumber = 11;
  private static readonly pb::FieldCodec<string> _repeated_param3_codec
      = pb::FieldCodec.ForString(90);
  private readonly pbc::RepeatedField<string> param3_ = new pbc::RepeatedField<string>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<string> Param3 {
    get { return param3_; }
  }

  /// <summary>Field number for the "source_uid" field.</summary>
  public const int SourceUidFieldNumber = 6;
  private uint sourceUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SourceUid {
    get { return sourceUid_; }
    set {
      sourceUid_ = value;
    }
  }

  /// <summary>Field number for the "param1" field.</summary>
  public const int Param1FieldNumber = 4;
  private static readonly pb::FieldCodec<uint> _repeated_param1_codec
      = pb::FieldCodec.ForUInt32(34);
  private readonly pbc::RepeatedField<uint> param1_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Param1 {
    get { return param1_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneAudioNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneAudioNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!param2_.Equals(other.param2_)) return false;
    if (Type != other.Type) return false;
    if(!param3_.Equals(other.param3_)) return false;
    if (SourceUid != other.SourceUid) return false;
    if(!param1_.Equals(other.param1_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= param2_.GetHashCode();
    if (Type != 0) hash ^= Type.GetHashCode();
    hash ^= param3_.GetHashCode();
    if (SourceUid != 0) hash ^= SourceUid.GetHashCode();
    hash ^= param1_.GetHashCode();
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
    if (Type != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Type);
    }
    param1_.WriteTo(output, _repeated_param1_codec);
    if (SourceUid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(SourceUid);
    }
    param3_.WriteTo(output, _repeated_param3_codec);
    param2_.WriteTo(output, _repeated_param2_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Type != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Type);
    }
    param1_.WriteTo(ref output, _repeated_param1_codec);
    if (SourceUid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(SourceUid);
    }
    param3_.WriteTo(ref output, _repeated_param3_codec);
    param2_.WriteTo(ref output, _repeated_param2_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += param2_.CalculateSize(_repeated_param2_codec);
    if (Type != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
    }
    size += param3_.CalculateSize(_repeated_param3_codec);
    if (SourceUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceUid);
    }
    size += param1_.CalculateSize(_repeated_param1_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneAudioNotify other) {
    if (other == null) {
      return;
    }
    param2_.Add(other.param2_);
    if (other.Type != 0) {
      Type = other.Type;
    }
    param3_.Add(other.param3_);
    if (other.SourceUid != 0) {
      SourceUid = other.SourceUid;
    }
    param1_.Add(other.param1_);
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
          Type = input.ReadInt32();
          break;
        }
        case 34:
        case 32: {
          param1_.AddEntriesFrom(input, _repeated_param1_codec);
          break;
        }
        case 48: {
          SourceUid = input.ReadUInt32();
          break;
        }
        case 90: {
          param3_.AddEntriesFrom(input, _repeated_param3_codec);
          break;
        }
        case 114:
        case 117: {
          param2_.AddEntriesFrom(input, _repeated_param2_codec);
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
          Type = input.ReadInt32();
          break;
        }
        case 34:
        case 32: {
          param1_.AddEntriesFrom(ref input, _repeated_param1_codec);
          break;
        }
        case 48: {
          SourceUid = input.ReadUInt32();
          break;
        }
        case 90: {
          param3_.AddEntriesFrom(ref input, _repeated_param3_codec);
          break;
        }
        case 114:
        case 117: {
          param2_.AddEntriesFrom(ref input, _repeated_param2_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code