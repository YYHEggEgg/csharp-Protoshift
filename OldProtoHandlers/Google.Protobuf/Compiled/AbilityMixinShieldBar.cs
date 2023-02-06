// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinShieldBar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AbilityMixinShieldBar.proto</summary>
public static partial class AbilityMixinShieldBarReflection {

  #region Descriptor
  /// <summary>File descriptor for AbilityMixinShieldBar.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AbilityMixinShieldBarReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtBYmlsaXR5TWl4aW5TaGllbGRCYXIucHJvdG8iZQoVQWJpbGl0eU1peGlu",
          "U2hpZWxkQmFyEhIKCnBsYXllcl9udW0YDiABKA0SEgoKbWF4X3NoaWVsZBgP",
          "IAEoAhIOCgZzaGllbGQYDCABKAISFAoMZWxlbWVudF90eXBlGA0gASgNQh4K",
          "HGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AbilityMixinShieldBar), global::AbilityMixinShieldBar.Parser, new[]{ "PlayerNum", "MaxShield", "Shield", "ElementType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AbilityMixinShieldBar : pb::IMessage<AbilityMixinShieldBar>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AbilityMixinShieldBar> _parser = new pb::MessageParser<AbilityMixinShieldBar>(() => new AbilityMixinShieldBar());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AbilityMixinShieldBar> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AbilityMixinShieldBarReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMixinShieldBar() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMixinShieldBar(AbilityMixinShieldBar other) : this() {
    playerNum_ = other.playerNum_;
    maxShield_ = other.maxShield_;
    shield_ = other.shield_;
    elementType_ = other.elementType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityMixinShieldBar Clone() {
    return new AbilityMixinShieldBar(this);
  }

  /// <summary>Field number for the "player_num" field.</summary>
  public const int PlayerNumFieldNumber = 14;
  private uint playerNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayerNum {
    get { return playerNum_; }
    set {
      playerNum_ = value;
    }
  }

  /// <summary>Field number for the "max_shield" field.</summary>
  public const int MaxShieldFieldNumber = 15;
  private float maxShield_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float MaxShield {
    get { return maxShield_; }
    set {
      maxShield_ = value;
    }
  }

  /// <summary>Field number for the "shield" field.</summary>
  public const int ShieldFieldNumber = 12;
  private float shield_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Shield {
    get { return shield_; }
    set {
      shield_ = value;
    }
  }

  /// <summary>Field number for the "element_type" field.</summary>
  public const int ElementTypeFieldNumber = 13;
  private uint elementType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ElementType {
    get { return elementType_; }
    set {
      elementType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AbilityMixinShieldBar);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AbilityMixinShieldBar other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (PlayerNum != other.PlayerNum) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxShield, other.MaxShield)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Shield, other.Shield)) return false;
    if (ElementType != other.ElementType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (PlayerNum != 0) hash ^= PlayerNum.GetHashCode();
    if (MaxShield != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxShield);
    if (Shield != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Shield);
    if (ElementType != 0) hash ^= ElementType.GetHashCode();
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
    if (Shield != 0F) {
      output.WriteRawTag(101);
      output.WriteFloat(Shield);
    }
    if (ElementType != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ElementType);
    }
    if (PlayerNum != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(PlayerNum);
    }
    if (MaxShield != 0F) {
      output.WriteRawTag(125);
      output.WriteFloat(MaxShield);
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
    if (Shield != 0F) {
      output.WriteRawTag(101);
      output.WriteFloat(Shield);
    }
    if (ElementType != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ElementType);
    }
    if (PlayerNum != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(PlayerNum);
    }
    if (MaxShield != 0F) {
      output.WriteRawTag(125);
      output.WriteFloat(MaxShield);
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
    if (PlayerNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerNum);
    }
    if (MaxShield != 0F) {
      size += 1 + 4;
    }
    if (Shield != 0F) {
      size += 1 + 4;
    }
    if (ElementType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AbilityMixinShieldBar other) {
    if (other == null) {
      return;
    }
    if (other.PlayerNum != 0) {
      PlayerNum = other.PlayerNum;
    }
    if (other.MaxShield != 0F) {
      MaxShield = other.MaxShield;
    }
    if (other.Shield != 0F) {
      Shield = other.Shield;
    }
    if (other.ElementType != 0) {
      ElementType = other.ElementType;
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
        case 101: {
          Shield = input.ReadFloat();
          break;
        }
        case 104: {
          ElementType = input.ReadUInt32();
          break;
        }
        case 112: {
          PlayerNum = input.ReadUInt32();
          break;
        }
        case 125: {
          MaxShield = input.ReadFloat();
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
        case 101: {
          Shield = input.ReadFloat();
          break;
        }
        case 104: {
          ElementType = input.ReadUInt32();
          break;
        }
        case 112: {
          PlayerNum = input.ReadUInt32();
          break;
        }
        case 125: {
          MaxShield = input.ReadFloat();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
