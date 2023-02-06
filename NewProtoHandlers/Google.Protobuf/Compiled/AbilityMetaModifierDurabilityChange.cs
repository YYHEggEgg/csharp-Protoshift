// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMetaModifierDurabilityChange.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AbilityMetaModifierDurabilityChange.proto</summary>
public static partial class AbilityMetaModifierDurabilityChangeReflection {

  #region Descriptor
  /// <summary>File descriptor for AbilityMetaModifierDurabilityChange.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AbilityMetaModifierDurabilityChangeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CilBYmlsaXR5TWV0YU1vZGlmaWVyRHVyYWJpbGl0eUNoYW5nZS5wcm90byJb",
          "CiNBYmlsaXR5TWV0YU1vZGlmaWVyRHVyYWJpbGl0eUNoYW5nZRIZChFyZW1h",
          "aW5fZHVyYWJpbGl0eRgNIAEoAhIZChFyZWR1Y2VfZHVyYWJpbGl0eRgBIAEo",
          "AkIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AbilityMetaModifierDurabilityChange), global::AbilityMetaModifierDurabilityChange.Parser, new[]{ "RemainDurability", "ReduceDurability" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AbilityMetaModifierDurabilityChange : pb::IMessage<AbilityMetaModifierDurabilityChange>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AbilityMetaModifierDurabilityChange> _parser = new pb::MessageParser<AbilityMetaModifierDurabilityChange>(() => new AbilityMetaModifierDurabilityChange());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AbilityMetaModifierDurabilityChange> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AbilityMetaModifierDurabilityChangeReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMetaModifierDurabilityChange() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMetaModifierDurabilityChange(AbilityMetaModifierDurabilityChange other) : this() {
    remainDurability_ = other.remainDurability_;
    reduceDurability_ = other.reduceDurability_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMetaModifierDurabilityChange Clone() {
    return new AbilityMetaModifierDurabilityChange(this);
  }

  /// <summary>Field number for the "remain_durability" field.</summary>
  public const int RemainDurabilityFieldNumber = 13;
  private float remainDurability_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float RemainDurability {
    get { return remainDurability_; }
    set {
      remainDurability_ = value;
    }
  }

  /// <summary>Field number for the "reduce_durability" field.</summary>
  public const int ReduceDurabilityFieldNumber = 1;
  private float reduceDurability_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float ReduceDurability {
    get { return reduceDurability_; }
    set {
      reduceDurability_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AbilityMetaModifierDurabilityChange);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AbilityMetaModifierDurabilityChange other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RemainDurability, other.RemainDurability)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ReduceDurability, other.ReduceDurability)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RemainDurability != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RemainDurability);
    if (ReduceDurability != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ReduceDurability);
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
    if (ReduceDurability != 0F) {
      output.WriteRawTag(13);
      output.WriteFloat(ReduceDurability);
    }
    if (RemainDurability != 0F) {
      output.WriteRawTag(109);
      output.WriteFloat(RemainDurability);
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
    if (ReduceDurability != 0F) {
      output.WriteRawTag(13);
      output.WriteFloat(ReduceDurability);
    }
    if (RemainDurability != 0F) {
      output.WriteRawTag(109);
      output.WriteFloat(RemainDurability);
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
    if (RemainDurability != 0F) {
      size += 1 + 4;
    }
    if (ReduceDurability != 0F) {
      size += 1 + 4;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AbilityMetaModifierDurabilityChange other) {
    if (other == null) {
      return;
    }
    if (other.RemainDurability != 0F) {
      RemainDurability = other.RemainDurability;
    }
    if (other.ReduceDurability != 0F) {
      ReduceDurability = other.ReduceDurability;
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
        case 13: {
          ReduceDurability = input.ReadFloat();
          break;
        }
        case 109: {
          RemainDurability = input.ReadFloat();
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
        case 13: {
          ReduceDurability = input.ReadFloat();
          break;
        }
        case 109: {
          RemainDurability = input.ReadFloat();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
