// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeSeekFurnitureOneRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from HomeSeekFurnitureOneRecord.proto</summary>
  public static partial class HomeSeekFurnitureOneRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeSeekFurnitureOneRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeSeekFurnitureOneRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBIb21lU2Vla0Z1cm5pdHVyZU9uZVJlY29yZC5wcm90bxoiSG9tZVNlZWtG",
            "dXJuaXR1cmVQbGF5ZXJTY29yZS5wcm90byJxChpIb21lU2Vla0Z1cm5pdHVy",
            "ZU9uZVJlY29yZBJAChllbmdhZ2VkX3BsYXllcl9zY29yZV9saXN0GAggAygL",
            "Mh0uSG9tZVNlZWtGdXJuaXR1cmVQbGF5ZXJTY29yZRIRCgl0aW1lc3RhbXAY",
            "AyABKA1CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.HomeSeekFurniturePlayerScoreReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.HomeSeekFurnitureOneRecord), global::OldProtos.HomeSeekFurnitureOneRecord.Parser, new[]{ "EngagedPlayerScoreList", "Timestamp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeSeekFurnitureOneRecord : pb::IMessage<HomeSeekFurnitureOneRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeSeekFurnitureOneRecord> _parser = new pb::MessageParser<HomeSeekFurnitureOneRecord>(() => new HomeSeekFurnitureOneRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeSeekFurnitureOneRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.HomeSeekFurnitureOneRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSeekFurnitureOneRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSeekFurnitureOneRecord(HomeSeekFurnitureOneRecord other) : this() {
      engagedPlayerScoreList_ = other.engagedPlayerScoreList_.Clone();
      timestamp_ = other.timestamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSeekFurnitureOneRecord Clone() {
      return new HomeSeekFurnitureOneRecord(this);
    }

    /// <summary>Field number for the "engaged_player_score_list" field.</summary>
    public const int EngagedPlayerScoreListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::OldProtos.HomeSeekFurniturePlayerScore> _repeated_engagedPlayerScoreList_codec
        = pb::FieldCodec.ForMessage(66, global::OldProtos.HomeSeekFurniturePlayerScore.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.HomeSeekFurniturePlayerScore> engagedPlayerScoreList_ = new pbc::RepeatedField<global::OldProtos.HomeSeekFurniturePlayerScore>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.HomeSeekFurniturePlayerScore> EngagedPlayerScoreList {
      get { return engagedPlayerScoreList_; }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
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
      return Equals(other as HomeSeekFurnitureOneRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeSeekFurnitureOneRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!engagedPlayerScoreList_.Equals(other.engagedPlayerScoreList_)) return false;
      if (Timestamp != other.Timestamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= engagedPlayerScoreList_.GetHashCode();
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
        output.WriteRawTag(24);
        output.WriteUInt32(Timestamp);
      }
      engagedPlayerScoreList_.WriteTo(output, _repeated_engagedPlayerScoreList_codec);
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
        output.WriteRawTag(24);
        output.WriteUInt32(Timestamp);
      }
      engagedPlayerScoreList_.WriteTo(ref output, _repeated_engagedPlayerScoreList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += engagedPlayerScoreList_.CalculateSize(_repeated_engagedPlayerScoreList_codec);
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
    public void MergeFrom(HomeSeekFurnitureOneRecord other) {
      if (other == null) {
        return;
      }
      engagedPlayerScoreList_.Add(other.engagedPlayerScoreList_);
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
          case 24: {
            Timestamp = input.ReadUInt32();
            break;
          }
          case 66: {
            engagedPlayerScoreList_.AddEntriesFrom(input, _repeated_engagedPlayerScoreList_codec);
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
            Timestamp = input.ReadUInt32();
            break;
          }
          case 66: {
            engagedPlayerScoreList_.AddEntriesFrom(ref input, _repeated_engagedPlayerScoreList_codec);
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
