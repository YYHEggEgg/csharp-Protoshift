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
namespace NewProtos {

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
            "cHJvdG8ibwocSG9tZUZ1cm5pdHVyZUN1c3RvbVN1aXRlRGF0YRIlCh1pbmNs",
            "dWRlZF9mdXJuaXR1cmVfaW5kZXhfbGlzdBgOIAMoBRIaCglzcGF3bl9wb3MY",
            "BSABKAsyBy5WZWN0b3ISDAoEZ3VpZBgMIAEoDUIMqgIJTmV3UHJvdG9zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.HomeFurnitureCustomSuiteData), global::NewProtos.HomeFurnitureCustomSuiteData.Parser, new[]{ "IncludedFurnitureIndexList", "SpawnPos", "Guid" }, null, null, null, null)
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
      get { return global::NewProtos.HomeFurnitureCustomSuiteDataReflection.Descriptor.MessageTypes[0]; }
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
      includedFurnitureIndexList_ = other.includedFurnitureIndexList_.Clone();
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      guid_ = other.guid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureCustomSuiteData Clone() {
      return new HomeFurnitureCustomSuiteData(this);
    }

    /// <summary>Field number for the "included_furniture_index_list" field.</summary>
    public const int IncludedFurnitureIndexListFieldNumber = 14;
    private static readonly pb::FieldCodec<int> _repeated_includedFurnitureIndexList_codec
        = pb::FieldCodec.ForInt32(114);
    private readonly pbc::RepeatedField<int> includedFurnitureIndexList_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> IncludedFurnitureIndexList {
      get { return includedFurnitureIndexList_; }
    }

    /// <summary>Field number for the "spawn_pos" field.</summary>
    public const int SpawnPosFieldNumber = 5;
    private global::NewProtos.Vector spawnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector SpawnPos {
      get { return spawnPos_; }
      set {
        spawnPos_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 12;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
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
      if(!includedFurnitureIndexList_.Equals(other.includedFurnitureIndexList_)) return false;
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      if (Guid != other.Guid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= includedFurnitureIndexList_.GetHashCode();
      if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
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
      if (spawnPos_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SpawnPos);
      }
      if (Guid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Guid);
      }
      includedFurnitureIndexList_.WriteTo(output, _repeated_includedFurnitureIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (spawnPos_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SpawnPos);
      }
      if (Guid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Guid);
      }
      includedFurnitureIndexList_.WriteTo(ref output, _repeated_includedFurnitureIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += includedFurnitureIndexList_.CalculateSize(_repeated_includedFurnitureIndexList_codec);
      if (spawnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
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
      includedFurnitureIndexList_.Add(other.includedFurnitureIndexList_);
      if (other.spawnPos_ != null) {
        if (spawnPos_ == null) {
          SpawnPos = new global::NewProtos.Vector();
        }
        SpawnPos.MergeFrom(other.SpawnPos);
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
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
          case 42: {
            if (spawnPos_ == null) {
              SpawnPos = new global::NewProtos.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 96: {
            Guid = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            includedFurnitureIndexList_.AddEntriesFrom(input, _repeated_includedFurnitureIndexList_codec);
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
          case 42: {
            if (spawnPos_ == null) {
              SpawnPos = new global::NewProtos.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 96: {
            Guid = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            includedFurnitureIndexList_.AddEntriesFrom(ref input, _repeated_includedFurnitureIndexList_codec);
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
