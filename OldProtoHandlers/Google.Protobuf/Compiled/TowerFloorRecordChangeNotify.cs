// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerFloorRecordChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from TowerFloorRecordChangeNotify.proto</summary>
  public static partial class TowerFloorRecordChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerFloorRecordChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerFloorRecordChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJUb3dlckZsb29yUmVjb3JkQ2hhbmdlTm90aWZ5LnByb3RvGhZUb3dlckZs",
            "b29yUmVjb3JkLnByb3RvInYKHFRvd2VyRmxvb3JSZWNvcmRDaGFuZ2VOb3Rp",
            "ZnkSIgoaaXNfZmluaXNoZWRfZW50cmFuY2VfZmxvb3IYCyABKAgSMgoXdG93",
            "ZXJfZmxvb3JfcmVjb3JkX2xpc3QYCCADKAsyES5Ub3dlckZsb29yUmVjb3Jk",
            "QgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.TowerFloorRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.TowerFloorRecordChangeNotify), global::OldProtos.TowerFloorRecordChangeNotify.Parser, new[]{ "IsFinishedEntranceFloor", "TowerFloorRecordList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2498
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class TowerFloorRecordChangeNotify : pb::IMessage<TowerFloorRecordChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerFloorRecordChangeNotify> _parser = new pb::MessageParser<TowerFloorRecordChangeNotify>(() => new TowerFloorRecordChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerFloorRecordChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.TowerFloorRecordChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecordChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecordChangeNotify(TowerFloorRecordChangeNotify other) : this() {
      isFinishedEntranceFloor_ = other.isFinishedEntranceFloor_;
      towerFloorRecordList_ = other.towerFloorRecordList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecordChangeNotify Clone() {
      return new TowerFloorRecordChangeNotify(this);
    }

    /// <summary>Field number for the "is_finished_entrance_floor" field.</summary>
    public const int IsFinishedEntranceFloorFieldNumber = 11;
    private bool isFinishedEntranceFloor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishedEntranceFloor {
      get { return isFinishedEntranceFloor_; }
      set {
        isFinishedEntranceFloor_ = value;
      }
    }

    /// <summary>Field number for the "tower_floor_record_list" field.</summary>
    public const int TowerFloorRecordListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::OldProtos.TowerFloorRecord> _repeated_towerFloorRecordList_codec
        = pb::FieldCodec.ForMessage(66, global::OldProtos.TowerFloorRecord.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.TowerFloorRecord> towerFloorRecordList_ = new pbc::RepeatedField<global::OldProtos.TowerFloorRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.TowerFloorRecord> TowerFloorRecordList {
      get { return towerFloorRecordList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerFloorRecordChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerFloorRecordChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinishedEntranceFloor != other.IsFinishedEntranceFloor) return false;
      if(!towerFloorRecordList_.Equals(other.towerFloorRecordList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinishedEntranceFloor != false) hash ^= IsFinishedEntranceFloor.GetHashCode();
      hash ^= towerFloorRecordList_.GetHashCode();
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
      towerFloorRecordList_.WriteTo(output, _repeated_towerFloorRecordList_codec);
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsFinishedEntranceFloor);
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
      towerFloorRecordList_.WriteTo(ref output, _repeated_towerFloorRecordList_codec);
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsFinishedEntranceFloor);
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
      if (IsFinishedEntranceFloor != false) {
        size += 1 + 1;
      }
      size += towerFloorRecordList_.CalculateSize(_repeated_towerFloorRecordList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerFloorRecordChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsFinishedEntranceFloor != false) {
        IsFinishedEntranceFloor = other.IsFinishedEntranceFloor;
      }
      towerFloorRecordList_.Add(other.towerFloorRecordList_);
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
          case 66: {
            towerFloorRecordList_.AddEntriesFrom(input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 88: {
            IsFinishedEntranceFloor = input.ReadBool();
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
          case 66: {
            towerFloorRecordList_.AddEntriesFrom(ref input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 88: {
            IsFinishedEntranceFloor = input.ReadBool();
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
