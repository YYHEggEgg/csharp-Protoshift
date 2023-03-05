// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CombatInvokeEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from CombatInvokeEntry.proto</summary>
  public static partial class CombatInvokeEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for CombatInvokeEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CombatInvokeEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDb21iYXRJbnZva2VFbnRyeS5wcm90bxoYQ29tYmF0VHlwZUFyZ3VtZW50",
            "LnByb3RvGhFGb3J3YXJkVHlwZS5wcm90byJ4ChFDb21iYXRJbnZva2VFbnRy",
            "eRITCgtjb21iYXRfZGF0YRgMIAEoDBIiCgxmb3J3YXJkX3R5cGUYCiABKA4y",
            "DC5Gb3J3YXJkVHlwZRIqCg1hcmd1bWVudF90eXBlGAsgASgOMhMuQ29tYmF0",
            "VHlwZUFyZ3VtZW50QgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.CombatTypeArgumentReflection.Descriptor, global::OldProtos.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.CombatInvokeEntry), global::OldProtos.CombatInvokeEntry.Parser, new[]{ "CombatData", "ForwardType", "ArgumentType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CombatInvokeEntry : pb::IMessage<CombatInvokeEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CombatInvokeEntry> _parser = new pb::MessageParser<CombatInvokeEntry>(() => new CombatInvokeEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CombatInvokeEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.CombatInvokeEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombatInvokeEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombatInvokeEntry(CombatInvokeEntry other) : this() {
      combatData_ = other.combatData_;
      forwardType_ = other.forwardType_;
      argumentType_ = other.argumentType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombatInvokeEntry Clone() {
      return new CombatInvokeEntry(this);
    }

    /// <summary>Field number for the "combat_data" field.</summary>
    public const int CombatDataFieldNumber = 12;
    private pb::ByteString combatData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString CombatData {
      get { return combatData_; }
      set {
        combatData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 10;
    private global::OldProtos.ForwardType forwardType_ = global::OldProtos.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "argument_type" field.</summary>
    public const int ArgumentTypeFieldNumber = 11;
    private global::OldProtos.CombatTypeArgument argumentType_ = global::OldProtos.CombatTypeArgument.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.CombatTypeArgument ArgumentType {
      get { return argumentType_; }
      set {
        argumentType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CombatInvokeEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CombatInvokeEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CombatData != other.CombatData) return false;
      if (ForwardType != other.ForwardType) return false;
      if (ArgumentType != other.ArgumentType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CombatData.Length != 0) hash ^= CombatData.GetHashCode();
      if (ForwardType != global::OldProtos.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      if (ArgumentType != global::OldProtos.CombatTypeArgument.None) hash ^= ArgumentType.GetHashCode();
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
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        output.WriteRawTag(80);
        output.WriteEnum((int) ForwardType);
      }
      if (ArgumentType != global::OldProtos.CombatTypeArgument.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ArgumentType);
      }
      if (CombatData.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(CombatData);
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
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        output.WriteRawTag(80);
        output.WriteEnum((int) ForwardType);
      }
      if (ArgumentType != global::OldProtos.CombatTypeArgument.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ArgumentType);
      }
      if (CombatData.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(CombatData);
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
      if (CombatData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(CombatData);
      }
      if (ForwardType != global::OldProtos.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (ArgumentType != global::OldProtos.CombatTypeArgument.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArgumentType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CombatInvokeEntry other) {
      if (other == null) {
        return;
      }
      if (other.CombatData.Length != 0) {
        CombatData = other.CombatData;
      }
      if (other.ForwardType != global::OldProtos.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      if (other.ArgumentType != global::OldProtos.CombatTypeArgument.None) {
        ArgumentType = other.ArgumentType;
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
          case 80: {
            ForwardType = (global::OldProtos.ForwardType) input.ReadEnum();
            break;
          }
          case 88: {
            ArgumentType = (global::OldProtos.CombatTypeArgument) input.ReadEnum();
            break;
          }
          case 98: {
            CombatData = input.ReadBytes();
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
          case 80: {
            ForwardType = (global::OldProtos.ForwardType) input.ReadEnum();
            break;
          }
          case 88: {
            ArgumentType = (global::OldProtos.CombatTypeArgument) input.ReadEnum();
            break;
          }
          case 98: {
            CombatData = input.ReadBytes();
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