// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassProduct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BattlePassProduct.proto</summary>
public static partial class BattlePassProductReflection {

  #region Descriptor
  /// <summary>File descriptor for BattlePassProduct.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BattlePassProductReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdCYXR0bGVQYXNzUHJvZHVjdC5wcm90byJkChFCYXR0bGVQYXNzUHJvZHVj",
          "dBIZChFub3JtYWxfcHJvZHVjdF9pZBgNIAEoCRIYChBleHRyYV9wcm9kdWN0",
          "X2lkGAogASgJEhoKEnVwZ3JhZGVfcHJvZHVjdF9pZBgGIAEoCUIeChxlbXUu",
          "Z3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BattlePassProduct), global::BattlePassProduct.Parser, new[]{ "NormalProductId", "ExtraProductId", "UpgradeProductId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BattlePassProduct : pb::IMessage<BattlePassProduct>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BattlePassProduct> _parser = new pb::MessageParser<BattlePassProduct>(() => new BattlePassProduct());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BattlePassProduct> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BattlePassProductReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassProduct() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassProduct(BattlePassProduct other) : this() {
    normalProductId_ = other.normalProductId_;
    extraProductId_ = other.extraProductId_;
    upgradeProductId_ = other.upgradeProductId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BattlePassProduct Clone() {
    return new BattlePassProduct(this);
  }

  /// <summary>Field number for the "normal_product_id" field.</summary>
  public const int NormalProductIdFieldNumber = 13;
  private string normalProductId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string NormalProductId {
    get { return normalProductId_; }
    set {
      normalProductId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "extra_product_id" field.</summary>
  public const int ExtraProductIdFieldNumber = 10;
  private string extraProductId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ExtraProductId {
    get { return extraProductId_; }
    set {
      extraProductId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "upgrade_product_id" field.</summary>
  public const int UpgradeProductIdFieldNumber = 6;
  private string upgradeProductId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string UpgradeProductId {
    get { return upgradeProductId_; }
    set {
      upgradeProductId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BattlePassProduct);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BattlePassProduct other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (NormalProductId != other.NormalProductId) return false;
    if (ExtraProductId != other.ExtraProductId) return false;
    if (UpgradeProductId != other.UpgradeProductId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (NormalProductId.Length != 0) hash ^= NormalProductId.GetHashCode();
    if (ExtraProductId.Length != 0) hash ^= ExtraProductId.GetHashCode();
    if (UpgradeProductId.Length != 0) hash ^= UpgradeProductId.GetHashCode();
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
    if (UpgradeProductId.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(UpgradeProductId);
    }
    if (ExtraProductId.Length != 0) {
      output.WriteRawTag(82);
      output.WriteString(ExtraProductId);
    }
    if (NormalProductId.Length != 0) {
      output.WriteRawTag(106);
      output.WriteString(NormalProductId);
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
    if (UpgradeProductId.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(UpgradeProductId);
    }
    if (ExtraProductId.Length != 0) {
      output.WriteRawTag(82);
      output.WriteString(ExtraProductId);
    }
    if (NormalProductId.Length != 0) {
      output.WriteRawTag(106);
      output.WriteString(NormalProductId);
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
    if (NormalProductId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(NormalProductId);
    }
    if (ExtraProductId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ExtraProductId);
    }
    if (UpgradeProductId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(UpgradeProductId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BattlePassProduct other) {
    if (other == null) {
      return;
    }
    if (other.NormalProductId.Length != 0) {
      NormalProductId = other.NormalProductId;
    }
    if (other.ExtraProductId.Length != 0) {
      ExtraProductId = other.ExtraProductId;
    }
    if (other.UpgradeProductId.Length != 0) {
      UpgradeProductId = other.UpgradeProductId;
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
        case 50: {
          UpgradeProductId = input.ReadString();
          break;
        }
        case 82: {
          ExtraProductId = input.ReadString();
          break;
        }
        case 106: {
          NormalProductId = input.ReadString();
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
        case 50: {
          UpgradeProductId = input.ReadString();
          break;
        }
        case 82: {
          ExtraProductId = input.ReadString();
          break;
        }
        case 106: {
          NormalProductId = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
