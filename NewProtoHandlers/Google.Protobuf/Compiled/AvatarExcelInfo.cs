// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarExcelInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from AvatarExcelInfo.proto</summary>
  public static partial class AvatarExcelInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarExcelInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarExcelInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVBdmF0YXJFeGNlbEluZm8ucHJvdG8iqwEKD0F2YXRhckV4Y2VsSW5mbxIY",
            "ChBwcmVmYWJfcGF0aF9oYXNoGAEgASgEEh8KF3ByZWZhYl9wYXRoX3JlbW90",
            "ZV9oYXNoGAIgASgEEhwKFGNvbnRyb2xsZXJfcGF0aF9oYXNoGAMgASgEEiMK",
            "G2NvbnRyb2xsZXJfcGF0aF9yZW1vdGVfaGFzaBgEIAEoBBIaChJjb21iYXRf",
            "Y29uZmlnX2hhc2gYBSABKARCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.AvatarExcelInfo), global::NewProtos.AvatarExcelInfo.Parser, new[]{ "PrefabPathHash", "PrefabPathRemoteHash", "ControllerPathHash", "ControllerPathRemoteHash", "CombatConfigHash" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AvatarExcelInfo : pb::IMessage<AvatarExcelInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarExcelInfo> _parser = new pb::MessageParser<AvatarExcelInfo>(() => new AvatarExcelInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarExcelInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.AvatarExcelInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExcelInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExcelInfo(AvatarExcelInfo other) : this() {
      prefabPathHash_ = other.prefabPathHash_;
      prefabPathRemoteHash_ = other.prefabPathRemoteHash_;
      controllerPathHash_ = other.controllerPathHash_;
      controllerPathRemoteHash_ = other.controllerPathRemoteHash_;
      combatConfigHash_ = other.combatConfigHash_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExcelInfo Clone() {
      return new AvatarExcelInfo(this);
    }

    /// <summary>Field number for the "prefab_path_hash" field.</summary>
    public const int PrefabPathHashFieldNumber = 1;
    private ulong prefabPathHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong PrefabPathHash {
      get { return prefabPathHash_; }
      set {
        prefabPathHash_ = value;
      }
    }

    /// <summary>Field number for the "prefab_path_remote_hash" field.</summary>
    public const int PrefabPathRemoteHashFieldNumber = 2;
    private ulong prefabPathRemoteHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong PrefabPathRemoteHash {
      get { return prefabPathRemoteHash_; }
      set {
        prefabPathRemoteHash_ = value;
      }
    }

    /// <summary>Field number for the "controller_path_hash" field.</summary>
    public const int ControllerPathHashFieldNumber = 3;
    private ulong controllerPathHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ControllerPathHash {
      get { return controllerPathHash_; }
      set {
        controllerPathHash_ = value;
      }
    }

    /// <summary>Field number for the "controller_path_remote_hash" field.</summary>
    public const int ControllerPathRemoteHashFieldNumber = 4;
    private ulong controllerPathRemoteHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ControllerPathRemoteHash {
      get { return controllerPathRemoteHash_; }
      set {
        controllerPathRemoteHash_ = value;
      }
    }

    /// <summary>Field number for the "combat_config_hash" field.</summary>
    public const int CombatConfigHashFieldNumber = 5;
    private ulong combatConfigHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CombatConfigHash {
      get { return combatConfigHash_; }
      set {
        combatConfigHash_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarExcelInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarExcelInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PrefabPathHash != other.PrefabPathHash) return false;
      if (PrefabPathRemoteHash != other.PrefabPathRemoteHash) return false;
      if (ControllerPathHash != other.ControllerPathHash) return false;
      if (ControllerPathRemoteHash != other.ControllerPathRemoteHash) return false;
      if (CombatConfigHash != other.CombatConfigHash) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PrefabPathHash != 0UL) hash ^= PrefabPathHash.GetHashCode();
      if (PrefabPathRemoteHash != 0UL) hash ^= PrefabPathRemoteHash.GetHashCode();
      if (ControllerPathHash != 0UL) hash ^= ControllerPathHash.GetHashCode();
      if (ControllerPathRemoteHash != 0UL) hash ^= ControllerPathRemoteHash.GetHashCode();
      if (CombatConfigHash != 0UL) hash ^= CombatConfigHash.GetHashCode();
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
      if (PrefabPathHash != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(PrefabPathHash);
      }
      if (PrefabPathRemoteHash != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(PrefabPathRemoteHash);
      }
      if (ControllerPathHash != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ControllerPathHash);
      }
      if (ControllerPathRemoteHash != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(ControllerPathRemoteHash);
      }
      if (CombatConfigHash != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(CombatConfigHash);
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
      if (PrefabPathHash != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(PrefabPathHash);
      }
      if (PrefabPathRemoteHash != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(PrefabPathRemoteHash);
      }
      if (ControllerPathHash != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ControllerPathHash);
      }
      if (ControllerPathRemoteHash != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(ControllerPathRemoteHash);
      }
      if (CombatConfigHash != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(CombatConfigHash);
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
      if (PrefabPathHash != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PrefabPathHash);
      }
      if (PrefabPathRemoteHash != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PrefabPathRemoteHash);
      }
      if (ControllerPathHash != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ControllerPathHash);
      }
      if (ControllerPathRemoteHash != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ControllerPathRemoteHash);
      }
      if (CombatConfigHash != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CombatConfigHash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarExcelInfo other) {
      if (other == null) {
        return;
      }
      if (other.PrefabPathHash != 0UL) {
        PrefabPathHash = other.PrefabPathHash;
      }
      if (other.PrefabPathRemoteHash != 0UL) {
        PrefabPathRemoteHash = other.PrefabPathRemoteHash;
      }
      if (other.ControllerPathHash != 0UL) {
        ControllerPathHash = other.ControllerPathHash;
      }
      if (other.ControllerPathRemoteHash != 0UL) {
        ControllerPathRemoteHash = other.ControllerPathRemoteHash;
      }
      if (other.CombatConfigHash != 0UL) {
        CombatConfigHash = other.CombatConfigHash;
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
          case 8: {
            PrefabPathHash = input.ReadUInt64();
            break;
          }
          case 16: {
            PrefabPathRemoteHash = input.ReadUInt64();
            break;
          }
          case 24: {
            ControllerPathHash = input.ReadUInt64();
            break;
          }
          case 32: {
            ControllerPathRemoteHash = input.ReadUInt64();
            break;
          }
          case 40: {
            CombatConfigHash = input.ReadUInt64();
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
          case 8: {
            PrefabPathHash = input.ReadUInt64();
            break;
          }
          case 16: {
            PrefabPathRemoteHash = input.ReadUInt64();
            break;
          }
          case 24: {
            ControllerPathHash = input.ReadUInt64();
            break;
          }
          case 32: {
            ControllerPathRemoteHash = input.ReadUInt64();
            break;
          }
          case 40: {
            CombatConfigHash = input.ReadUInt64();
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