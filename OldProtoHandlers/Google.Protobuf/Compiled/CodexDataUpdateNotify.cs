// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CodexDataUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CodexDataUpdateNotify.proto</summary>
public static partial class CodexDataUpdateNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for CodexDataUpdateNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CodexDataUpdateNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtDb2RleERhdGFVcGRhdGVOb3RpZnkucHJvdG8aD0NvZGV4VHlwZS5wcm90",
          "byJfChVDb2RleERhdGFVcGRhdGVOb3RpZnkSCgoCaWQYCCABKA0SIAoYd2Vh",
          "cG9uX21heF9wcm9tb3RlX2xldmVsGA8gASgNEhgKBHR5cGUYCyABKA4yCi5D",
          "b2RleFR5cGVCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CodexTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CodexDataUpdateNotify), global::CodexDataUpdateNotify.Parser, new[]{ "Id", "WeaponMaxPromoteLevel", "Type" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4207
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class CodexDataUpdateNotify : pb::IMessage<CodexDataUpdateNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CodexDataUpdateNotify> _parser = new pb::MessageParser<CodexDataUpdateNotify>(() => new CodexDataUpdateNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CodexDataUpdateNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CodexDataUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CodexDataUpdateNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CodexDataUpdateNotify(CodexDataUpdateNotify other) : this() {
    id_ = other.id_;
    weaponMaxPromoteLevel_ = other.weaponMaxPromoteLevel_;
    type_ = other.type_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CodexDataUpdateNotify Clone() {
    return new CodexDataUpdateNotify(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 8;
  private uint id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "weapon_max_promote_level" field.</summary>
  public const int WeaponMaxPromoteLevelFieldNumber = 15;
  private uint weaponMaxPromoteLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WeaponMaxPromoteLevel {
    get { return weaponMaxPromoteLevel_; }
    set {
      weaponMaxPromoteLevel_ = value;
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 11;
  private global::CodexType type_ = global::CodexType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CodexType Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CodexDataUpdateNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CodexDataUpdateNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (WeaponMaxPromoteLevel != other.WeaponMaxPromoteLevel) return false;
    if (Type != other.Type) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (WeaponMaxPromoteLevel != 0) hash ^= WeaponMaxPromoteLevel.GetHashCode();
    if (Type != global::CodexType.None) hash ^= Type.GetHashCode();
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
    if (Id != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Id);
    }
    if (Type != global::CodexType.None) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Type);
    }
    if (WeaponMaxPromoteLevel != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(WeaponMaxPromoteLevel);
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
    if (Id != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Id);
    }
    if (Type != global::CodexType.None) {
      output.WriteRawTag(88);
      output.WriteEnum((int) Type);
    }
    if (WeaponMaxPromoteLevel != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(WeaponMaxPromoteLevel);
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
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (WeaponMaxPromoteLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeaponMaxPromoteLevel);
    }
    if (Type != global::CodexType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CodexDataUpdateNotify other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.WeaponMaxPromoteLevel != 0) {
      WeaponMaxPromoteLevel = other.WeaponMaxPromoteLevel;
    }
    if (other.Type != global::CodexType.None) {
      Type = other.Type;
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
        case 64: {
          Id = input.ReadUInt32();
          break;
        }
        case 88: {
          Type = (global::CodexType) input.ReadEnum();
          break;
        }
        case 120: {
          WeaponMaxPromoteLevel = input.ReadUInt32();
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
        case 64: {
          Id = input.ReadUInt32();
          break;
        }
        case 88: {
          Type = (global::CodexType) input.ReadEnum();
          break;
        }
        case 120: {
          WeaponMaxPromoteLevel = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
