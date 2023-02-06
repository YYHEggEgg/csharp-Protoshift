// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerCurLevelRecordChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TowerCurLevelRecordChangeNotify.proto</summary>
public static partial class TowerCurLevelRecordChangeNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for TowerCurLevelRecordChangeNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TowerCurLevelRecordChangeNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVUb3dlckN1ckxldmVsUmVjb3JkQ2hhbmdlTm90aWZ5LnByb3RvGhlUb3dl",
          "ckN1ckxldmVsUmVjb3JkLnByb3RvIlEKH1Rvd2VyQ3VyTGV2ZWxSZWNvcmRD",
          "aGFuZ2VOb3RpZnkSLgoQY3VyX2xldmVsX3JlY29yZBgBIAEoCzIULlRvd2Vy",
          "Q3VyTGV2ZWxSZWNvcmRCFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3Rv",
          "Mw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::TowerCurLevelRecordReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TowerCurLevelRecordChangeNotify), global::TowerCurLevelRecordChangeNotify.Parser, new[]{ "CurLevelRecord" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 2456;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class TowerCurLevelRecordChangeNotify : pb::IMessage<TowerCurLevelRecordChangeNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TowerCurLevelRecordChangeNotify> _parser = new pb::MessageParser<TowerCurLevelRecordChangeNotify>(() => new TowerCurLevelRecordChangeNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TowerCurLevelRecordChangeNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TowerCurLevelRecordChangeNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TowerCurLevelRecordChangeNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TowerCurLevelRecordChangeNotify(TowerCurLevelRecordChangeNotify other) : this() {
    curLevelRecord_ = other.curLevelRecord_ != null ? other.curLevelRecord_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TowerCurLevelRecordChangeNotify Clone() {
    return new TowerCurLevelRecordChangeNotify(this);
  }

  /// <summary>Field number for the "cur_level_record" field.</summary>
  public const int CurLevelRecordFieldNumber = 1;
  private global::TowerCurLevelRecord curLevelRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::TowerCurLevelRecord CurLevelRecord {
    get { return curLevelRecord_; }
    set {
      curLevelRecord_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TowerCurLevelRecordChangeNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TowerCurLevelRecordChangeNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(CurLevelRecord, other.CurLevelRecord)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (curLevelRecord_ != null) hash ^= CurLevelRecord.GetHashCode();
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
    if (curLevelRecord_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(CurLevelRecord);
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
    if (curLevelRecord_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(CurLevelRecord);
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
    if (curLevelRecord_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurLevelRecord);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TowerCurLevelRecordChangeNotify other) {
    if (other == null) {
      return;
    }
    if (other.curLevelRecord_ != null) {
      if (curLevelRecord_ == null) {
        CurLevelRecord = new global::TowerCurLevelRecord();
      }
      CurLevelRecord.MergeFrom(other.CurLevelRecord);
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
        case 10: {
          if (curLevelRecord_ == null) {
            CurLevelRecord = new global::TowerCurLevelRecord();
          }
          input.ReadMessage(CurLevelRecord);
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
        case 10: {
          if (curLevelRecord_ == null) {
            CurLevelRecord = new global::TowerCurLevelRecord();
          }
          input.ReadMessage(CurLevelRecord);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
