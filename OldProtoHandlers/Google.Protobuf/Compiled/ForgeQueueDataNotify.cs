// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForgeQueueDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ForgeQueueDataNotify.proto</summary>
  public static partial class ForgeQueueDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ForgeQueueDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForgeQueueDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpGb3JnZVF1ZXVlRGF0YU5vdGlmeS5wcm90bxoURm9yZ2VRdWV1ZURhdGEu",
            "cHJvdG8iwgEKFEZvcmdlUXVldWVEYXRhTm90aWZ5EkEKD2ZvcmdlX3F1ZXVl",
            "X21hcBgHIAMoCzIoLkZvcmdlUXVldWVEYXRhTm90aWZ5LkZvcmdlUXVldWVN",
            "YXBFbnRyeRIgChhyZW1vdmVkX2ZvcmdlX3F1ZXVlX2xpc3QYBiADKA0aRQoS",
            "Rm9yZ2VRdWV1ZU1hcEVudHJ5EgsKA2tleRgBIAEoDRIeCgV2YWx1ZRgCIAEo",
            "CzIPLkZvcmdlUXVldWVEYXRhOgI4AUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ForgeQueueDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ForgeQueueDataNotify), global::OldProtos.ForgeQueueDataNotify.Parser, new[]{ "ForgeQueueMap", "RemovedForgeQueueList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 676
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class ForgeQueueDataNotify : pb::IMessage<ForgeQueueDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForgeQueueDataNotify> _parser = new pb::MessageParser<ForgeQueueDataNotify>(() => new ForgeQueueDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ForgeQueueDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ForgeQueueDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueDataNotify(ForgeQueueDataNotify other) : this() {
      forgeQueueMap_ = other.forgeQueueMap_.Clone();
      removedForgeQueueList_ = other.removedForgeQueueList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueDataNotify Clone() {
      return new ForgeQueueDataNotify(this);
    }

    /// <summary>Field number for the "forge_queue_map" field.</summary>
    public const int ForgeQueueMapFieldNumber = 7;
    private static readonly pbc::MapField<uint, global::OldProtos.ForgeQueueData>.Codec _map_forgeQueueMap_codec
        = new pbc::MapField<uint, global::OldProtos.ForgeQueueData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.ForgeQueueData.Parser), 58);
    private readonly pbc::MapField<uint, global::OldProtos.ForgeQueueData> forgeQueueMap_ = new pbc::MapField<uint, global::OldProtos.ForgeQueueData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.ForgeQueueData> ForgeQueueMap {
      get { return forgeQueueMap_; }
    }

    /// <summary>Field number for the "removed_forge_queue_list" field.</summary>
    public const int RemovedForgeQueueListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_removedForgeQueueList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> removedForgeQueueList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RemovedForgeQueueList {
      get { return removedForgeQueueList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ForgeQueueDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ForgeQueueDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ForgeQueueMap.Equals(other.ForgeQueueMap)) return false;
      if(!removedForgeQueueList_.Equals(other.removedForgeQueueList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ForgeQueueMap.GetHashCode();
      hash ^= removedForgeQueueList_.GetHashCode();
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
      removedForgeQueueList_.WriteTo(output, _repeated_removedForgeQueueList_codec);
      forgeQueueMap_.WriteTo(output, _map_forgeQueueMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      removedForgeQueueList_.WriteTo(ref output, _repeated_removedForgeQueueList_codec);
      forgeQueueMap_.WriteTo(ref output, _map_forgeQueueMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += forgeQueueMap_.CalculateSize(_map_forgeQueueMap_codec);
      size += removedForgeQueueList_.CalculateSize(_repeated_removedForgeQueueList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ForgeQueueDataNotify other) {
      if (other == null) {
        return;
      }
      forgeQueueMap_.Add(other.forgeQueueMap_);
      removedForgeQueueList_.Add(other.removedForgeQueueList_);
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
          case 50:
          case 48: {
            removedForgeQueueList_.AddEntriesFrom(input, _repeated_removedForgeQueueList_codec);
            break;
          }
          case 58: {
            forgeQueueMap_.AddEntriesFrom(input, _map_forgeQueueMap_codec);
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
          case 50:
          case 48: {
            removedForgeQueueList_.AddEntriesFrom(ref input, _repeated_removedForgeQueueList_codec);
            break;
          }
          case 58: {
            forgeQueueMap_.AddEntriesFrom(ref input, _map_forgeQueueMap_codec);
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
