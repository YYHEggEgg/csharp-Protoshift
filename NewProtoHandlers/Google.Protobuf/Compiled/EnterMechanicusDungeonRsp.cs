// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterMechanicusDungeonRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EnterMechanicusDungeonRsp.proto</summary>
public static partial class EnterMechanicusDungeonRspReflection {

  #region Descriptor
  /// <summary>File descriptor for EnterMechanicusDungeonRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EnterMechanicusDungeonRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9FbnRlck1lY2hhbmljdXNEdW5nZW9uUnNwLnByb3RvImwKGUVudGVyTWVj",
          "aGFuaWN1c0R1bmdlb25Sc3ASEQoJd3JvbmdfdWlkGA0gASgNEhcKD2RpZmZp",
          "Y3VsdF9sZXZlbBgPIAEoDRIPCgdyZXRjb2RlGAwgASgFEhIKCmR1bmdlb25f",
          "aWQYCiABKA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EnterMechanicusDungeonRsp), global::EnterMechanicusDungeonRsp.Parser, new[]{ "WrongUid", "DifficultLevel", "Retcode", "DungeonId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 3939;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class EnterMechanicusDungeonRsp : pb::IMessage<EnterMechanicusDungeonRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EnterMechanicusDungeonRsp> _parser = new pb::MessageParser<EnterMechanicusDungeonRsp>(() => new EnterMechanicusDungeonRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EnterMechanicusDungeonRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EnterMechanicusDungeonRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EnterMechanicusDungeonRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EnterMechanicusDungeonRsp(EnterMechanicusDungeonRsp other) : this() {
    wrongUid_ = other.wrongUid_;
    difficultLevel_ = other.difficultLevel_;
    retcode_ = other.retcode_;
    dungeonId_ = other.dungeonId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EnterMechanicusDungeonRsp Clone() {
    return new EnterMechanicusDungeonRsp(this);
  }

  /// <summary>Field number for the "wrong_uid" field.</summary>
  public const int WrongUidFieldNumber = 13;
  private uint wrongUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WrongUid {
    get { return wrongUid_; }
    set {
      wrongUid_ = value;
    }
  }

  /// <summary>Field number for the "difficult_level" field.</summary>
  public const int DifficultLevelFieldNumber = 15;
  private uint difficultLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DifficultLevel {
    get { return difficultLevel_; }
    set {
      difficultLevel_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 12;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "dungeon_id" field.</summary>
  public const int DungeonIdFieldNumber = 10;
  private uint dungeonId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DungeonId {
    get { return dungeonId_; }
    set {
      dungeonId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EnterMechanicusDungeonRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EnterMechanicusDungeonRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (WrongUid != other.WrongUid) return false;
    if (DifficultLevel != other.DifficultLevel) return false;
    if (Retcode != other.Retcode) return false;
    if (DungeonId != other.DungeonId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (WrongUid != 0) hash ^= WrongUid.GetHashCode();
    if (DifficultLevel != 0) hash ^= DifficultLevel.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
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
    if (DungeonId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DungeonId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(96);
      output.WriteInt32(Retcode);
    }
    if (WrongUid != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(WrongUid);
    }
    if (DifficultLevel != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(DifficultLevel);
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
    if (DungeonId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(DungeonId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(96);
      output.WriteInt32(Retcode);
    }
    if (WrongUid != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(WrongUid);
    }
    if (DifficultLevel != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(DifficultLevel);
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
    if (WrongUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WrongUid);
    }
    if (DifficultLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultLevel);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (DungeonId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EnterMechanicusDungeonRsp other) {
    if (other == null) {
      return;
    }
    if (other.WrongUid != 0) {
      WrongUid = other.WrongUid;
    }
    if (other.DifficultLevel != 0) {
      DifficultLevel = other.DifficultLevel;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.DungeonId != 0) {
      DungeonId = other.DungeonId;
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
        case 80: {
          DungeonId = input.ReadUInt32();
          break;
        }
        case 96: {
          Retcode = input.ReadInt32();
          break;
        }
        case 104: {
          WrongUid = input.ReadUInt32();
          break;
        }
        case 120: {
          DifficultLevel = input.ReadUInt32();
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
        case 80: {
          DungeonId = input.ReadUInt32();
          break;
        }
        case 96: {
          Retcode = input.ReadInt32();
          break;
        }
        case 104: {
          WrongUid = input.ReadUInt32();
          break;
        }
        case 120: {
          DifficultLevel = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
