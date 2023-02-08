// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinElementShield.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from AbilityMixinElementShield.proto</summary>
  public static partial class AbilityMixinElementShieldReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMixinElementShield.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMixinElementShieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9BYmlsaXR5TWl4aW5FbGVtZW50U2hpZWxkLnByb3RvIpYBChlBYmlsaXR5",
            "TWl4aW5FbGVtZW50U2hpZWxkEhIKCnBsYXllcl9udW0YCSABKA0SDgoGc2hp",
            "ZWxkGAUgASgCEhgKEGlzX3NoaWVsZF9icm9rZW4YCCABKAgSEgoKc3ViX3No",
            "aWVsZBgEIAEoAhISCgptYXhfc2hpZWxkGA0gASgCEhMKC2Fic29yYl90eXBl",
            "GAogASgNQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.AbilityMixinElementShield), global::NewProtos.AbilityMixinElementShield.Parser, new[]{ "PlayerNum", "Shield", "IsShieldBroken", "SubShield", "MaxShield", "AbsorbType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMixinElementShield : pb::IMessage<AbilityMixinElementShield>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMixinElementShield> _parser = new pb::MessageParser<AbilityMixinElementShield>(() => new AbilityMixinElementShield());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMixinElementShield> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.AbilityMixinElementShieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinElementShield() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinElementShield(AbilityMixinElementShield other) : this() {
      playerNum_ = other.playerNum_;
      shield_ = other.shield_;
      isShieldBroken_ = other.isShieldBroken_;
      subShield_ = other.subShield_;
      maxShield_ = other.maxShield_;
      absorbType_ = other.absorbType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinElementShield Clone() {
      return new AbilityMixinElementShield(this);
    }

    /// <summary>Field number for the "player_num" field.</summary>
    public const int PlayerNumFieldNumber = 9;
    private uint playerNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerNum {
      get { return playerNum_; }
      set {
        playerNum_ = value;
      }
    }

    /// <summary>Field number for the "shield" field.</summary>
    public const int ShieldFieldNumber = 5;
    private float shield_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Shield {
      get { return shield_; }
      set {
        shield_ = value;
      }
    }

    /// <summary>Field number for the "is_shield_broken" field.</summary>
    public const int IsShieldBrokenFieldNumber = 8;
    private bool isShieldBroken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsShieldBroken {
      get { return isShieldBroken_; }
      set {
        isShieldBroken_ = value;
      }
    }

    /// <summary>Field number for the "sub_shield" field.</summary>
    public const int SubShieldFieldNumber = 4;
    private float subShield_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float SubShield {
      get { return subShield_; }
      set {
        subShield_ = value;
      }
    }

    /// <summary>Field number for the "max_shield" field.</summary>
    public const int MaxShieldFieldNumber = 13;
    private float maxShield_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MaxShield {
      get { return maxShield_; }
      set {
        maxShield_ = value;
      }
    }

    /// <summary>Field number for the "absorb_type" field.</summary>
    public const int AbsorbTypeFieldNumber = 10;
    private uint absorbType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AbsorbType {
      get { return absorbType_; }
      set {
        absorbType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMixinElementShield);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMixinElementShield other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerNum != other.PlayerNum) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Shield, other.Shield)) return false;
      if (IsShieldBroken != other.IsShieldBroken) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SubShield, other.SubShield)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxShield, other.MaxShield)) return false;
      if (AbsorbType != other.AbsorbType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerNum != 0) hash ^= PlayerNum.GetHashCode();
      if (Shield != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Shield);
      if (IsShieldBroken != false) hash ^= IsShieldBroken.GetHashCode();
      if (SubShield != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SubShield);
      if (MaxShield != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxShield);
      if (AbsorbType != 0) hash ^= AbsorbType.GetHashCode();
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
      if (SubShield != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(SubShield);
      }
      if (Shield != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Shield);
      }
      if (IsShieldBroken != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsShieldBroken);
      }
      if (PlayerNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PlayerNum);
      }
      if (AbsorbType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AbsorbType);
      }
      if (MaxShield != 0F) {
        output.WriteRawTag(109);
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
      if (SubShield != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(SubShield);
      }
      if (Shield != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Shield);
      }
      if (IsShieldBroken != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsShieldBroken);
      }
      if (PlayerNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PlayerNum);
      }
      if (AbsorbType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AbsorbType);
      }
      if (MaxShield != 0F) {
        output.WriteRawTag(109);
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
      if (Shield != 0F) {
        size += 1 + 4;
      }
      if (IsShieldBroken != false) {
        size += 1 + 1;
      }
      if (SubShield != 0F) {
        size += 1 + 4;
      }
      if (MaxShield != 0F) {
        size += 1 + 4;
      }
      if (AbsorbType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AbsorbType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMixinElementShield other) {
      if (other == null) {
        return;
      }
      if (other.PlayerNum != 0) {
        PlayerNum = other.PlayerNum;
      }
      if (other.Shield != 0F) {
        Shield = other.Shield;
      }
      if (other.IsShieldBroken != false) {
        IsShieldBroken = other.IsShieldBroken;
      }
      if (other.SubShield != 0F) {
        SubShield = other.SubShield;
      }
      if (other.MaxShield != 0F) {
        MaxShield = other.MaxShield;
      }
      if (other.AbsorbType != 0) {
        AbsorbType = other.AbsorbType;
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
          case 37: {
            SubShield = input.ReadFloat();
            break;
          }
          case 45: {
            Shield = input.ReadFloat();
            break;
          }
          case 64: {
            IsShieldBroken = input.ReadBool();
            break;
          }
          case 72: {
            PlayerNum = input.ReadUInt32();
            break;
          }
          case 80: {
            AbsorbType = input.ReadUInt32();
            break;
          }
          case 109: {
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
          case 37: {
            SubShield = input.ReadFloat();
            break;
          }
          case 45: {
            Shield = input.ReadFloat();
            break;
          }
          case 64: {
            IsShieldBroken = input.ReadBool();
            break;
          }
          case 72: {
            PlayerNum = input.ReadUInt32();
            break;
          }
          case 80: {
            AbsorbType = input.ReadUInt32();
            break;
          }
          case 109: {
            MaxShield = input.ReadFloat();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
