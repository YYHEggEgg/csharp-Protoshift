// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinDoActionBySelfModifierElementDurabilityRatio.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AbilityMixinDoActionBySelfModifierElementDurabilityRatio.proto</summary>
public static partial class AbilityMixinDoActionBySelfModifierElementDurabilityRatioReflection {

  #region Descriptor
  /// <summary>File descriptor for AbilityMixinDoActionBySelfModifierElementDurabilityRatio.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AbilityMixinDoActionBySelfModifierElementDurabilityRatioReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cj5BYmlsaXR5TWl4aW5Eb0FjdGlvbkJ5U2VsZk1vZGlmaWVyRWxlbWVudER1",
          "cmFiaWxpdHlSYXRpby5wcm90byJZCjhBYmlsaXR5TWl4aW5Eb0FjdGlvbkJ5",
          "U2VsZk1vZGlmaWVyRWxlbWVudER1cmFiaWxpdHlSYXRpbxIdChVsYXN0X2R1",
          "cmFiaWxpdHlfcmF0aW8YCSABKAJCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5v",
          "bGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AbilityMixinDoActionBySelfModifierElementDurabilityRatio), global::AbilityMixinDoActionBySelfModifierElementDurabilityRatio.Parser, new[]{ "LastDurabilityRatio" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AbilityMixinDoActionBySelfModifierElementDurabilityRatio : pb::IMessage<AbilityMixinDoActionBySelfModifierElementDurabilityRatio>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AbilityMixinDoActionBySelfModifierElementDurabilityRatio> _parser = new pb::MessageParser<AbilityMixinDoActionBySelfModifierElementDurabilityRatio>(() => new AbilityMixinDoActionBySelfModifierElementDurabilityRatio());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AbilityMixinDoActionBySelfModifierElementDurabilityRatio> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AbilityMixinDoActionBySelfModifierElementDurabilityRatioReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMixinDoActionBySelfModifierElementDurabilityRatio() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMixinDoActionBySelfModifierElementDurabilityRatio(AbilityMixinDoActionBySelfModifierElementDurabilityRatio other) : this() {
    lastDurabilityRatio_ = other.lastDurabilityRatio_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMixinDoActionBySelfModifierElementDurabilityRatio Clone() {
    return new AbilityMixinDoActionBySelfModifierElementDurabilityRatio(this);
  }

  /// <summary>Field number for the "last_durability_ratio" field.</summary>
  public const int LastDurabilityRatioFieldNumber = 9;
  private float lastDurabilityRatio_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float LastDurabilityRatio {
    get { return lastDurabilityRatio_; }
    set {
      lastDurabilityRatio_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AbilityMixinDoActionBySelfModifierElementDurabilityRatio);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AbilityMixinDoActionBySelfModifierElementDurabilityRatio other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LastDurabilityRatio, other.LastDurabilityRatio)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (LastDurabilityRatio != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LastDurabilityRatio);
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
    if (LastDurabilityRatio != 0F) {
      output.WriteRawTag(77);
      output.WriteFloat(LastDurabilityRatio);
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
    if (LastDurabilityRatio != 0F) {
      output.WriteRawTag(77);
      output.WriteFloat(LastDurabilityRatio);
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
    if (LastDurabilityRatio != 0F) {
      size += 1 + 4;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AbilityMixinDoActionBySelfModifierElementDurabilityRatio other) {
    if (other == null) {
      return;
    }
    if (other.LastDurabilityRatio != 0F) {
      LastDurabilityRatio = other.LastDurabilityRatio;
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
        case 77: {
          LastDurabilityRatio = input.ReadFloat();
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
        case 77: {
          LastDurabilityRatio = input.ReadFloat();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
