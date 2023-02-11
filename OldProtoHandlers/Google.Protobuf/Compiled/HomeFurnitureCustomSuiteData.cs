// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeFurnitureCustomSuiteData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from HomeFurnitureCustomSuiteData.proto</summary>
  public static partial class HomeFurnitureCustomSuiteDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeFurnitureCustomSuiteData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeFurnitureCustomSuiteDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJIb21lRnVybml0dXJlQ3VzdG9tU3VpdGVEYXRhLnByb3RvGgxWZWN0b3Iu",
            "cHJvdG8ibwocSG9tZUZ1cm5pdHVyZUN1c3RvbVN1aXRlRGF0YRIMCgRndWlk",
            "GAsgASgNEhoKCXNwYXduX3BvcxgOIAEoCzIHLlZlY3RvchIlCh1pbmNsdWRl",
            "ZF9mdXJuaXR1cmVfaW5kZXhfbGlzdBgMIAMoBUIMqgIJT2xkUHJvdG9zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.HomeFurnitureCustomSuiteData), global::OldProtos.HomeFurnitureCustomSuiteData.Parser, new[]{ "Guid", "SpawnPos", "IncludedFurnitureIndexList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeFurnitureCustomSuiteData : pb::IMessage<HomeFurnitureCustomSuiteData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeFurnitureCustomSuiteData> _parser = new pb::MessageParser<HomeFurnitureCustomSuiteData>(() => new HomeFurnitureCustomSuiteData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeFurnitureCustomSuiteData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.HomeFurnitureCustomSuiteDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureCustomSuiteData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureCustomSuiteData(HomeFurnitureCustomSuiteData other) : this() {
      guid_ = other.guid_;
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      includedFurnitureIndexList_ = other.includedFurnitureIndexList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureCustomSuiteData Clone() {
      return new HomeFurnitureCustomSuiteData(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 11;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "spawn_pos" field.</summary>
    public const int SpawnPosFieldNumber = 14;
    private global::OldProtos.Vector spawnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector SpawnPos {
      get { return spawnPos_; }
      set {
        spawnPos_ = value;
      }
    }

    /// <summary>Field number for the "included_furniture_index_list" field.</summary>
    public const int IncludedFurnitureIndexListFieldNumber = 12;
    private static readonly pb::FieldCodec<int> _repeated_includedFurnitureIndexList_codec
        = pb::FieldCodec.ForInt32(98);
    private readonly pbc::RepeatedField<int> includedFurnitureIndexList_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> IncludedFurnitureIndexList {
      get { return includedFurnitureIndexList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeFurnitureCustomSuiteData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeFurnitureCustomSuiteData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      if(!includedFurnitureIndexList_.Equals(other.includedFurnitureIndexList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
      hash ^= includedFurnitureIndexList_.GetHashCode();
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
      if (Guid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Guid);
      }
      includedFurnitureIndexList_.WriteTo(output, _repeated_includedFurnitureIndexList_codec);
      if (spawnPos_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(SpawnPos);
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
      if (Guid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Guid);
      }
      includedFurnitureIndexList_.WriteTo(ref output, _repeated_includedFurnitureIndexList_codec);
      if (spawnPos_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(SpawnPos);
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
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (spawnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
      }
      size += includedFurnitureIndexList_.CalculateSize(_repeated_includedFurnitureIndexList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeFurnitureCustomSuiteData other) {
      if (other == null) {
        return;
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
      }
      if (other.spawnPos_ != null) {
        if (spawnPos_ == null) {
          SpawnPos = new global::OldProtos.Vector();
        }
        SpawnPos.MergeFrom(other.SpawnPos);
      }
      includedFurnitureIndexList_.Add(other.includedFurnitureIndexList_);
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
          case 88: {
            Guid = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            includedFurnitureIndexList_.AddEntriesFrom(input, _repeated_includedFurnitureIndexList_codec);
            break;
          }
          case 114: {
            if (spawnPos_ == null) {
              SpawnPos = new global::OldProtos.Vector();
            }
            input.ReadMessage(SpawnPos);
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
          case 88: {
            Guid = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
            includedFurnitureIndexList_.AddEntriesFrom(ref input, _repeated_includedFurnitureIndexList_codec);
            break;
          }
          case 114: {
            if (spawnPos_ == null) {
              SpawnPos = new global::OldProtos.Vector();
            }
            input.ReadMessage(SpawnPos);
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