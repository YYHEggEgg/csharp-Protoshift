// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGBasicDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGBasicDataNotify.proto</summary>
public static partial class GCGBasicDataNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGBasicDataNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGBasicDataNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhHQ0dCYXNpY0RhdGFOb3RpZnkucHJvdG8iUQoSR0NHQmFzaWNEYXRhTm90",
          "aWZ5Eg0KBWxldmVsGAYgASgNEgsKA2V4cBgEIAEoDRIfChdsZXZlbF9yZXdh",
          "cmRfdGFrZW5fbGlzdBgOIAMoDUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGBasicDataNotify), global::GCGBasicDataNotify.Parser, new[]{ "Level", "Exp", "LevelRewardTakenList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 7739;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GCGBasicDataNotify : pb::IMessage<GCGBasicDataNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGBasicDataNotify> _parser = new pb::MessageParser<GCGBasicDataNotify>(() => new GCGBasicDataNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGBasicDataNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGBasicDataNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGBasicDataNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGBasicDataNotify(GCGBasicDataNotify other) : this() {
    level_ = other.level_;
    exp_ = other.exp_;
    levelRewardTakenList_ = other.levelRewardTakenList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGBasicDataNotify Clone() {
    return new GCGBasicDataNotify(this);
  }

  /// <summary>Field number for the "level" field.</summary>
  public const int LevelFieldNumber = 6;
  private uint level_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Level {
    get { return level_; }
    set {
      level_ = value;
    }
  }

  /// <summary>Field number for the "exp" field.</summary>
  public const int ExpFieldNumber = 4;
  private uint exp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Exp {
    get { return exp_; }
    set {
      exp_ = value;
    }
  }

  /// <summary>Field number for the "level_reward_taken_list" field.</summary>
  public const int LevelRewardTakenListFieldNumber = 14;
  private static readonly pb::FieldCodec<uint> _repeated_levelRewardTakenList_codec
      = pb::FieldCodec.ForUInt32(114);
  private readonly pbc::RepeatedField<uint> levelRewardTakenList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> LevelRewardTakenList {
    get { return levelRewardTakenList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGBasicDataNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGBasicDataNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Level != other.Level) return false;
    if (Exp != other.Exp) return false;
    if(!levelRewardTakenList_.Equals(other.levelRewardTakenList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Level != 0) hash ^= Level.GetHashCode();
    if (Exp != 0) hash ^= Exp.GetHashCode();
    hash ^= levelRewardTakenList_.GetHashCode();
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
    if (Exp != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Exp);
    }
    if (Level != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Level);
    }
    levelRewardTakenList_.WriteTo(output, _repeated_levelRewardTakenList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Exp != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Exp);
    }
    if (Level != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Level);
    }
    levelRewardTakenList_.WriteTo(ref output, _repeated_levelRewardTakenList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Level != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
    }
    if (Exp != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
    }
    size += levelRewardTakenList_.CalculateSize(_repeated_levelRewardTakenList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGBasicDataNotify other) {
    if (other == null) {
      return;
    }
    if (other.Level != 0) {
      Level = other.Level;
    }
    if (other.Exp != 0) {
      Exp = other.Exp;
    }
    levelRewardTakenList_.Add(other.levelRewardTakenList_);
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
        case 32: {
          Exp = input.ReadUInt32();
          break;
        }
        case 48: {
          Level = input.ReadUInt32();
          break;
        }
        case 114:
        case 112: {
          levelRewardTakenList_.AddEntriesFrom(input, _repeated_levelRewardTakenList_codec);
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
        case 32: {
          Exp = input.ReadUInt32();
          break;
        }
        case 48: {
          Level = input.ReadUInt32();
          break;
        }
        case 114:
        case 112: {
          levelRewardTakenList_.AddEntriesFrom(ref input, _repeated_levelRewardTakenList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
