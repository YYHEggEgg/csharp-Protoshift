// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonDieOptionRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from DungeonDieOptionRsp.proto</summary>
public static partial class DungeonDieOptionRspReflection {

  #region Descriptor
  /// <summary>File descriptor for DungeonDieOptionRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DungeonDieOptionRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlEdW5nZW9uRGllT3B0aW9uUnNwLnByb3RvGhVQbGF5ZXJEaWVPcHRpb24u",
          "cHJvdG8iYgoTRHVuZ2VvbkRpZU9wdGlvblJzcBIPCgdyZXRjb2RlGAUgASgF",
          "EhQKDHJldml2ZV9jb3VudBgKIAEoDRIkCgpkaWVfb3B0aW9uGAYgASgOMhAu",
          "UGxheWVyRGllT3B0aW9uQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJv",
          "dG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::PlayerDieOptionReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DungeonDieOptionRsp), global::DungeonDieOptionRsp.Parser, new[]{ "Retcode", "ReviveCount", "DieOption" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 948
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class DungeonDieOptionRsp : pb::IMessage<DungeonDieOptionRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<DungeonDieOptionRsp> _parser = new pb::MessageParser<DungeonDieOptionRsp>(() => new DungeonDieOptionRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<DungeonDieOptionRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DungeonDieOptionRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DungeonDieOptionRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DungeonDieOptionRsp(DungeonDieOptionRsp other) : this() {
    retcode_ = other.retcode_;
    reviveCount_ = other.reviveCount_;
    dieOption_ = other.dieOption_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DungeonDieOptionRsp Clone() {
    return new DungeonDieOptionRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 5;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "revive_count" field.</summary>
  public const int ReviveCountFieldNumber = 10;
  private uint reviveCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ReviveCount {
    get { return reviveCount_; }
    set {
      reviveCount_ = value;
    }
  }

  /// <summary>Field number for the "die_option" field.</summary>
  public const int DieOptionFieldNumber = 6;
  private global::PlayerDieOption dieOption_ = global::PlayerDieOption.OptNone;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::PlayerDieOption DieOption {
    get { return dieOption_; }
    set {
      dieOption_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as DungeonDieOptionRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(DungeonDieOptionRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if (ReviveCount != other.ReviveCount) return false;
    if (DieOption != other.DieOption) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (ReviveCount != 0) hash ^= ReviveCount.GetHashCode();
    if (DieOption != global::PlayerDieOption.OptNone) hash ^= DieOption.GetHashCode();
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
      output.WriteRawTag(40);
      output.WriteInt32(Retcode);
    }
    if (DieOption != global::PlayerDieOption.OptNone) {
      output.WriteRawTag(48);
      output.WriteEnum((int) DieOption);
    }
    if (ReviveCount != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(ReviveCount);
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
      output.WriteRawTag(40);
      output.WriteInt32(Retcode);
    }
    if (DieOption != global::PlayerDieOption.OptNone) {
      output.WriteRawTag(48);
      output.WriteEnum((int) DieOption);
    }
    if (ReviveCount != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(ReviveCount);
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
    if (ReviveCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReviveCount);
    }
    if (DieOption != global::PlayerDieOption.OptNone) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DieOption);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(DungeonDieOptionRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.ReviveCount != 0) {
      ReviveCount = other.ReviveCount;
    }
    if (other.DieOption != global::PlayerDieOption.OptNone) {
      DieOption = other.DieOption;
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
        case 40: {
          Retcode = input.ReadInt32();
          break;
        }
        case 48: {
          DieOption = (global::PlayerDieOption) input.ReadEnum();
          break;
        }
        case 80: {
          ReviveCount = input.ReadUInt32();
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
        case 40: {
          Retcode = input.ReadInt32();
          break;
        }
        case 48: {
          DieOption = (global::PlayerDieOption) input.ReadEnum();
          break;
        }
        case 80: {
          ReviveCount = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
