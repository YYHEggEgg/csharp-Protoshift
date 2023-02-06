// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StoreCustomDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from StoreCustomDungeonReq.proto</summary>
public static partial class StoreCustomDungeonReqReflection {

  #region Descriptor
  /// <summary>File descriptor for StoreCustomDungeonReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static StoreCustomDungeonReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtTdG9yZUN1c3RvbUR1bmdlb25SZXEucHJvdG8iRgoVU3RvcmVDdXN0b21E",
          "dW5nZW9uUmVxEhcKD2lzX2NhbmNlbF9zdG9yZRgJIAEoCBIUCgxkdW5nZW9u",
          "X2d1aWQYCyABKARCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::StoreCustomDungeonReq), global::StoreCustomDungeonReq.Parser, new[]{ "IsCancelStore", "DungeonGuid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 6213
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class StoreCustomDungeonReq : pb::IMessage<StoreCustomDungeonReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<StoreCustomDungeonReq> _parser = new pb::MessageParser<StoreCustomDungeonReq>(() => new StoreCustomDungeonReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<StoreCustomDungeonReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::StoreCustomDungeonReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public StoreCustomDungeonReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public StoreCustomDungeonReq(StoreCustomDungeonReq other) : this() {
    isCancelStore_ = other.isCancelStore_;
    dungeonGuid_ = other.dungeonGuid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public StoreCustomDungeonReq Clone() {
    return new StoreCustomDungeonReq(this);
  }

  /// <summary>Field number for the "is_cancel_store" field.</summary>
  public const int IsCancelStoreFieldNumber = 9;
  private bool isCancelStore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsCancelStore {
    get { return isCancelStore_; }
    set {
      isCancelStore_ = value;
    }
  }

  /// <summary>Field number for the "dungeon_guid" field.</summary>
  public const int DungeonGuidFieldNumber = 11;
  private ulong dungeonGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong DungeonGuid {
    get { return dungeonGuid_; }
    set {
      dungeonGuid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as StoreCustomDungeonReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(StoreCustomDungeonReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsCancelStore != other.IsCancelStore) return false;
    if (DungeonGuid != other.DungeonGuid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsCancelStore != false) hash ^= IsCancelStore.GetHashCode();
    if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
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
    if (IsCancelStore != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsCancelStore);
    }
    if (DungeonGuid != 0UL) {
      output.WriteRawTag(88);
      output.WriteUInt64(DungeonGuid);
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
    if (IsCancelStore != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsCancelStore);
    }
    if (DungeonGuid != 0UL) {
      output.WriteRawTag(88);
      output.WriteUInt64(DungeonGuid);
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
    if (IsCancelStore != false) {
      size += 1 + 1;
    }
    if (DungeonGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(StoreCustomDungeonReq other) {
    if (other == null) {
      return;
    }
    if (other.IsCancelStore != false) {
      IsCancelStore = other.IsCancelStore;
    }
    if (other.DungeonGuid != 0UL) {
      DungeonGuid = other.DungeonGuid;
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
        case 72: {
          IsCancelStore = input.ReadBool();
          break;
        }
        case 88: {
          DungeonGuid = input.ReadUInt64();
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
        case 72: {
          IsCancelStore = input.ReadBool();
          break;
        }
        case 88: {
          DungeonGuid = input.ReadUInt64();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
