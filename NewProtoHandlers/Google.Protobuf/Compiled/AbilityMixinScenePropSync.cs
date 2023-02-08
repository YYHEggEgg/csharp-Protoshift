// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinScenePropSync.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from AbilityMixinScenePropSync.proto</summary>
  public static partial class AbilityMixinScenePropSyncReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMixinScenePropSync.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMixinScenePropSyncReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9BYmlsaXR5TWl4aW5TY2VuZVByb3BTeW5jLnByb3RvGhlNYXNzaXZlUHJv",
            "cFN5bmNJbmZvLnByb3RvInoKGUFiaWxpdHlNaXhpblNjZW5lUHJvcFN5bmMS",
            "LwoRbWFzc2l2ZV9wcm9wX2xpc3QYCyADKAsyFC5NYXNzaXZlUHJvcFN5bmNJ",
            "bmZvEhYKDmRlbGV0ZV9pZF9saXN0GAwgAygDEhQKDGlzX2NsZWFyX2FsbBgD",
            "IAEoCEIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.MassivePropSyncInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.AbilityMixinScenePropSync), global::NewProtos.AbilityMixinScenePropSync.Parser, new[]{ "MassivePropList", "DeleteIdList", "IsClearAll" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMixinScenePropSync : pb::IMessage<AbilityMixinScenePropSync>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMixinScenePropSync> _parser = new pb::MessageParser<AbilityMixinScenePropSync>(() => new AbilityMixinScenePropSync());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMixinScenePropSync> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.AbilityMixinScenePropSyncReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinScenePropSync() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinScenePropSync(AbilityMixinScenePropSync other) : this() {
      massivePropList_ = other.massivePropList_.Clone();
      deleteIdList_ = other.deleteIdList_.Clone();
      isClearAll_ = other.isClearAll_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinScenePropSync Clone() {
      return new AbilityMixinScenePropSync(this);
    }

    /// <summary>Field number for the "massive_prop_list" field.</summary>
    public const int MassivePropListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::NewProtos.MassivePropSyncInfo> _repeated_massivePropList_codec
        = pb::FieldCodec.ForMessage(90, global::NewProtos.MassivePropSyncInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.MassivePropSyncInfo> massivePropList_ = new pbc::RepeatedField<global::NewProtos.MassivePropSyncInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.MassivePropSyncInfo> MassivePropList {
      get { return massivePropList_; }
    }

    /// <summary>Field number for the "delete_id_list" field.</summary>
    public const int DeleteIdListFieldNumber = 12;
    private static readonly pb::FieldCodec<long> _repeated_deleteIdList_codec
        = pb::FieldCodec.ForInt64(98);
    private readonly pbc::RepeatedField<long> deleteIdList_ = new pbc::RepeatedField<long>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<long> DeleteIdList {
      get { return deleteIdList_; }
    }

    /// <summary>Field number for the "is_clear_all" field.</summary>
    public const int IsClearAllFieldNumber = 3;
    private bool isClearAll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsClearAll {
      get { return isClearAll_; }
      set {
        isClearAll_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMixinScenePropSync);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMixinScenePropSync other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!massivePropList_.Equals(other.massivePropList_)) return false;
      if(!deleteIdList_.Equals(other.deleteIdList_)) return false;
      if (IsClearAll != other.IsClearAll) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= massivePropList_.GetHashCode();
      hash ^= deleteIdList_.GetHashCode();
      if (IsClearAll != false) hash ^= IsClearAll.GetHashCode();
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
      if (IsClearAll != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsClearAll);
      }
      massivePropList_.WriteTo(output, _repeated_massivePropList_codec);
      deleteIdList_.WriteTo(output, _repeated_deleteIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsClearAll != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsClearAll);
      }
      massivePropList_.WriteTo(ref output, _repeated_massivePropList_codec);
      deleteIdList_.WriteTo(ref output, _repeated_deleteIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += massivePropList_.CalculateSize(_repeated_massivePropList_codec);
      size += deleteIdList_.CalculateSize(_repeated_deleteIdList_codec);
      if (IsClearAll != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMixinScenePropSync other) {
      if (other == null) {
        return;
      }
      massivePropList_.Add(other.massivePropList_);
      deleteIdList_.Add(other.deleteIdList_);
      if (other.IsClearAll != false) {
        IsClearAll = other.IsClearAll;
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
          case 24: {
            IsClearAll = input.ReadBool();
            break;
          }
          case 90: {
            massivePropList_.AddEntriesFrom(input, _repeated_massivePropList_codec);
            break;
          }
          case 98:
          case 96: {
            deleteIdList_.AddEntriesFrom(input, _repeated_deleteIdList_codec);
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
          case 24: {
            IsClearAll = input.ReadBool();
            break;
          }
          case 90: {
            massivePropList_.AddEntriesFrom(ref input, _repeated_massivePropList_codec);
            break;
          }
          case 98:
          case 96: {
            deleteIdList_.AddEntriesFrom(ref input, _repeated_deleteIdList_codec);
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
