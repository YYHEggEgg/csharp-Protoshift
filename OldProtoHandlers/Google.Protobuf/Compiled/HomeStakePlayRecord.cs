// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeStakePlayRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from HomeStakePlayRecord.proto</summary>
  public static partial class HomeStakePlayRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeStakePlayRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeStakePlayRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlIb21lU3Rha2VQbGF5UmVjb3JkLnByb3RvGhlIb21lR3JvdXBQbGF5ZXJJ",
            "bmZvLnByb3RvImAKE0hvbWVTdGFrZVBsYXlSZWNvcmQSNgoYZW5nYWdlZF9w",
            "bGF5ZXJfaW5mb19saXN0GA4gAygLMhQuSG9tZUdyb3VwUGxheWVySW5mbxIR",
            "Cgl0aW1lc3RhbXAYCSABKA1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.HomeGroupPlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.HomeStakePlayRecord), global::OldProtos.HomeStakePlayRecord.Parser, new[]{ "EngagedPlayerInfoList", "Timestamp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeStakePlayRecord : pb::IMessage<HomeStakePlayRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeStakePlayRecord> _parser = new pb::MessageParser<HomeStakePlayRecord>(() => new HomeStakePlayRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeStakePlayRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.HomeStakePlayRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeStakePlayRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeStakePlayRecord(HomeStakePlayRecord other) : this() {
      engagedPlayerInfoList_ = other.engagedPlayerInfoList_.Clone();
      timestamp_ = other.timestamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeStakePlayRecord Clone() {
      return new HomeStakePlayRecord(this);
    }

    /// <summary>Field number for the "engaged_player_info_list" field.</summary>
    public const int EngagedPlayerInfoListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::OldProtos.HomeGroupPlayerInfo> _repeated_engagedPlayerInfoList_codec
        = pb::FieldCodec.ForMessage(114, global::OldProtos.HomeGroupPlayerInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.HomeGroupPlayerInfo> engagedPlayerInfoList_ = new pbc::RepeatedField<global::OldProtos.HomeGroupPlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.HomeGroupPlayerInfo> EngagedPlayerInfoList {
      get { return engagedPlayerInfoList_; }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 9;
    private uint timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeStakePlayRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeStakePlayRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!engagedPlayerInfoList_.Equals(other.engagedPlayerInfoList_)) return false;
      if (Timestamp != other.Timestamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= engagedPlayerInfoList_.GetHashCode();
      if (Timestamp != 0) hash ^= Timestamp.GetHashCode();
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
      if (Timestamp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Timestamp);
      }
      engagedPlayerInfoList_.WriteTo(output, _repeated_engagedPlayerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Timestamp != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Timestamp);
      }
      engagedPlayerInfoList_.WriteTo(ref output, _repeated_engagedPlayerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += engagedPlayerInfoList_.CalculateSize(_repeated_engagedPlayerInfoList_codec);
      if (Timestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeStakePlayRecord other) {
      if (other == null) {
        return;
      }
      engagedPlayerInfoList_.Add(other.engagedPlayerInfoList_);
      if (other.Timestamp != 0) {
        Timestamp = other.Timestamp;
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
            Timestamp = input.ReadUInt32();
            break;
          }
          case 114: {
            engagedPlayerInfoList_.AddEntriesFrom(input, _repeated_engagedPlayerInfoList_codec);
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
            Timestamp = input.ReadUInt32();
            break;
          }
          case 114: {
            engagedPlayerInfoList_.AddEntriesFrom(ref input, _repeated_engagedPlayerInfoList_codec);
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
