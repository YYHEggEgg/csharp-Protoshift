// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MichiaeMatsuriGainCrystalExpUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MichiaeMatsuriGainCrystalExpUpdateNotify.proto</summary>
public static partial class MichiaeMatsuriGainCrystalExpUpdateNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for MichiaeMatsuriGainCrystalExpUpdateNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MichiaeMatsuriGainCrystalExpUpdateNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ci5NaWNoaWFlTWF0c3VyaUdhaW5DcnlzdGFsRXhwVXBkYXRlTm90aWZ5LnBy",
          "b3RvIlkKKE1pY2hpYWVNYXRzdXJpR2FpbkNyeXN0YWxFeHBVcGRhdGVOb3Rp",
          "ZnkSGAoQZ2Fpbl9jcnlzdGFsX2V4cBgCIAEoDRITCgthY3Rpdml0eV9pZBgD",
          "IAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MichiaeMatsuriGainCrystalExpUpdateNotify), global::MichiaeMatsuriGainCrystalExpUpdateNotify.Parser, new[]{ "GainCrystalExp", "ActivityId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8523
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class MichiaeMatsuriGainCrystalExpUpdateNotify : pb::IMessage<MichiaeMatsuriGainCrystalExpUpdateNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MichiaeMatsuriGainCrystalExpUpdateNotify> _parser = new pb::MessageParser<MichiaeMatsuriGainCrystalExpUpdateNotify>(() => new MichiaeMatsuriGainCrystalExpUpdateNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MichiaeMatsuriGainCrystalExpUpdateNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MichiaeMatsuriGainCrystalExpUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MichiaeMatsuriGainCrystalExpUpdateNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MichiaeMatsuriGainCrystalExpUpdateNotify(MichiaeMatsuriGainCrystalExpUpdateNotify other) : this() {
    gainCrystalExp_ = other.gainCrystalExp_;
    activityId_ = other.activityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MichiaeMatsuriGainCrystalExpUpdateNotify Clone() {
    return new MichiaeMatsuriGainCrystalExpUpdateNotify(this);
  }

  /// <summary>Field number for the "gain_crystal_exp" field.</summary>
  public const int GainCrystalExpFieldNumber = 2;
  private uint gainCrystalExp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GainCrystalExp {
    get { return gainCrystalExp_; }
    set {
      gainCrystalExp_ = value;
    }
  }

  /// <summary>Field number for the "activity_id" field.</summary>
  public const int ActivityIdFieldNumber = 3;
  private uint activityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ActivityId {
    get { return activityId_; }
    set {
      activityId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MichiaeMatsuriGainCrystalExpUpdateNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MichiaeMatsuriGainCrystalExpUpdateNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GainCrystalExp != other.GainCrystalExp) return false;
    if (ActivityId != other.ActivityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (GainCrystalExp != 0) hash ^= GainCrystalExp.GetHashCode();
    if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
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
    if (GainCrystalExp != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(GainCrystalExp);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ActivityId);
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
    if (GainCrystalExp != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(GainCrystalExp);
    }
    if (ActivityId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ActivityId);
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
    if (GainCrystalExp != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GainCrystalExp);
    }
    if (ActivityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MichiaeMatsuriGainCrystalExpUpdateNotify other) {
    if (other == null) {
      return;
    }
    if (other.GainCrystalExp != 0) {
      GainCrystalExp = other.GainCrystalExp;
    }
    if (other.ActivityId != 0) {
      ActivityId = other.ActivityId;
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
        case 16: {
          GainCrystalExp = input.ReadUInt32();
          break;
        }
        case 24: {
          ActivityId = input.ReadUInt32();
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
        case 16: {
          GainCrystalExp = input.ReadUInt32();
          break;
        }
        case 24: {
          ActivityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
