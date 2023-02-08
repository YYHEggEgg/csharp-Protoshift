// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StoreWeightLimitNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from StoreWeightLimitNotify.proto</summary>
  public static partial class StoreWeightLimitNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for StoreWeightLimitNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoreWeightLimitNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTdG9yZVdlaWdodExpbWl0Tm90aWZ5LnByb3RvGg9TdG9yZVR5cGUucHJv",
            "dG8ixgEKFlN0b3JlV2VpZ2h0TGltaXROb3RpZnkSGgoSd2VhcG9uX2NvdW50",
            "X2xpbWl0GAIgASgNEh4KCnN0b3JlX3R5cGUYByABKA4yCi5TdG9yZVR5cGUS",
            "HAoUbWF0ZXJpYWxfY291bnRfbGltaXQYBCABKA0SHQoVcmVsaXF1YXJ5X2Nv",
            "dW50X2xpbWl0GAYgASgNEh0KFWZ1cm5pdHVyZV9jb3VudF9saW1pdBgJIAEo",
            "DRIUCgx3ZWlnaHRfbGltaXQYDyABKA1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.StoreTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.StoreWeightLimitNotify), global::OldProtos.StoreWeightLimitNotify.Parser, new[]{ "WeaponCountLimit", "StoreType", "MaterialCountLimit", "ReliquaryCountLimit", "FurnitureCountLimit", "WeightLimit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 698
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class StoreWeightLimitNotify : pb::IMessage<StoreWeightLimitNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StoreWeightLimitNotify> _parser = new pb::MessageParser<StoreWeightLimitNotify>(() => new StoreWeightLimitNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StoreWeightLimitNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.StoreWeightLimitNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreWeightLimitNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreWeightLimitNotify(StoreWeightLimitNotify other) : this() {
      weaponCountLimit_ = other.weaponCountLimit_;
      storeType_ = other.storeType_;
      materialCountLimit_ = other.materialCountLimit_;
      reliquaryCountLimit_ = other.reliquaryCountLimit_;
      furnitureCountLimit_ = other.furnitureCountLimit_;
      weightLimit_ = other.weightLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreWeightLimitNotify Clone() {
      return new StoreWeightLimitNotify(this);
    }

    /// <summary>Field number for the "weapon_count_limit" field.</summary>
    public const int WeaponCountLimitFieldNumber = 2;
    private uint weaponCountLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeaponCountLimit {
      get { return weaponCountLimit_; }
      set {
        weaponCountLimit_ = value;
      }
    }

    /// <summary>Field number for the "store_type" field.</summary>
    public const int StoreTypeFieldNumber = 7;
    private global::OldProtos.StoreType storeType_ = global::OldProtos.StoreType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.StoreType StoreType {
      get { return storeType_; }
      set {
        storeType_ = value;
      }
    }

    /// <summary>Field number for the "material_count_limit" field.</summary>
    public const int MaterialCountLimitFieldNumber = 4;
    private uint materialCountLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialCountLimit {
      get { return materialCountLimit_; }
      set {
        materialCountLimit_ = value;
      }
    }

    /// <summary>Field number for the "reliquary_count_limit" field.</summary>
    public const int ReliquaryCountLimitFieldNumber = 6;
    private uint reliquaryCountLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReliquaryCountLimit {
      get { return reliquaryCountLimit_; }
      set {
        reliquaryCountLimit_ = value;
      }
    }

    /// <summary>Field number for the "furniture_count_limit" field.</summary>
    public const int FurnitureCountLimitFieldNumber = 9;
    private uint furnitureCountLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureCountLimit {
      get { return furnitureCountLimit_; }
      set {
        furnitureCountLimit_ = value;
      }
    }

    /// <summary>Field number for the "weight_limit" field.</summary>
    public const int WeightLimitFieldNumber = 15;
    private uint weightLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeightLimit {
      get { return weightLimit_; }
      set {
        weightLimit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StoreWeightLimitNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StoreWeightLimitNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WeaponCountLimit != other.WeaponCountLimit) return false;
      if (StoreType != other.StoreType) return false;
      if (MaterialCountLimit != other.MaterialCountLimit) return false;
      if (ReliquaryCountLimit != other.ReliquaryCountLimit) return false;
      if (FurnitureCountLimit != other.FurnitureCountLimit) return false;
      if (WeightLimit != other.WeightLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WeaponCountLimit != 0) hash ^= WeaponCountLimit.GetHashCode();
      if (StoreType != global::OldProtos.StoreType.None) hash ^= StoreType.GetHashCode();
      if (MaterialCountLimit != 0) hash ^= MaterialCountLimit.GetHashCode();
      if (ReliquaryCountLimit != 0) hash ^= ReliquaryCountLimit.GetHashCode();
      if (FurnitureCountLimit != 0) hash ^= FurnitureCountLimit.GetHashCode();
      if (WeightLimit != 0) hash ^= WeightLimit.GetHashCode();
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
      if (WeaponCountLimit != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WeaponCountLimit);
      }
      if (MaterialCountLimit != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaterialCountLimit);
      }
      if (ReliquaryCountLimit != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ReliquaryCountLimit);
      }
      if (StoreType != global::OldProtos.StoreType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) StoreType);
      }
      if (FurnitureCountLimit != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FurnitureCountLimit);
      }
      if (WeightLimit != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(WeightLimit);
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
      if (WeaponCountLimit != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(WeaponCountLimit);
      }
      if (MaterialCountLimit != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaterialCountLimit);
      }
      if (ReliquaryCountLimit != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ReliquaryCountLimit);
      }
      if (StoreType != global::OldProtos.StoreType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) StoreType);
      }
      if (FurnitureCountLimit != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FurnitureCountLimit);
      }
      if (WeightLimit != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(WeightLimit);
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
      if (WeaponCountLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeaponCountLimit);
      }
      if (StoreType != global::OldProtos.StoreType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StoreType);
      }
      if (MaterialCountLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialCountLimit);
      }
      if (ReliquaryCountLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReliquaryCountLimit);
      }
      if (FurnitureCountLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureCountLimit);
      }
      if (WeightLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeightLimit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StoreWeightLimitNotify other) {
      if (other == null) {
        return;
      }
      if (other.WeaponCountLimit != 0) {
        WeaponCountLimit = other.WeaponCountLimit;
      }
      if (other.StoreType != global::OldProtos.StoreType.None) {
        StoreType = other.StoreType;
      }
      if (other.MaterialCountLimit != 0) {
        MaterialCountLimit = other.MaterialCountLimit;
      }
      if (other.ReliquaryCountLimit != 0) {
        ReliquaryCountLimit = other.ReliquaryCountLimit;
      }
      if (other.FurnitureCountLimit != 0) {
        FurnitureCountLimit = other.FurnitureCountLimit;
      }
      if (other.WeightLimit != 0) {
        WeightLimit = other.WeightLimit;
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
            WeaponCountLimit = input.ReadUInt32();
            break;
          }
          case 32: {
            MaterialCountLimit = input.ReadUInt32();
            break;
          }
          case 48: {
            ReliquaryCountLimit = input.ReadUInt32();
            break;
          }
          case 56: {
            StoreType = (global::OldProtos.StoreType) input.ReadEnum();
            break;
          }
          case 72: {
            FurnitureCountLimit = input.ReadUInt32();
            break;
          }
          case 120: {
            WeightLimit = input.ReadUInt32();
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
            WeaponCountLimit = input.ReadUInt32();
            break;
          }
          case 32: {
            MaterialCountLimit = input.ReadUInt32();
            break;
          }
          case 48: {
            ReliquaryCountLimit = input.ReadUInt32();
            break;
          }
          case 56: {
            StoreType = (global::OldProtos.StoreType) input.ReadEnum();
            break;
          }
          case 72: {
            FurnitureCountLimit = input.ReadUInt32();
            break;
          }
          case 120: {
            WeightLimit = input.ReadUInt32();
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
