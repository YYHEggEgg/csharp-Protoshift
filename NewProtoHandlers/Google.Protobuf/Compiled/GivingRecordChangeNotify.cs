// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GivingRecordChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GivingRecordChangeNotify.proto</summary>
  public static partial class GivingRecordChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GivingRecordChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GivingRecordChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HaXZpbmdSZWNvcmRDaGFuZ2VOb3RpZnkucHJvdG8aEkdpdmluZ1JlY29y",
            "ZC5wcm90byJVChhHaXZpbmdSZWNvcmRDaGFuZ2VOb3RpZnkSEwoLaXNfZGVh",
            "Y3RpdmUYDiABKAgSJAoNZ2l2aW5nX3JlY29yZBgPIAEoCzINLkdpdmluZ1Jl",
            "Y29yZEIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GivingRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GivingRecordChangeNotify), global::NewProtos.GivingRecordChangeNotify.Parser, new[]{ "IsDeactive", "GivingRecord" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 187;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GivingRecordChangeNotify : pb::IMessage<GivingRecordChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GivingRecordChangeNotify> _parser = new pb::MessageParser<GivingRecordChangeNotify>(() => new GivingRecordChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GivingRecordChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GivingRecordChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GivingRecordChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GivingRecordChangeNotify(GivingRecordChangeNotify other) : this() {
      isDeactive_ = other.isDeactive_;
      givingRecord_ = other.givingRecord_ != null ? other.givingRecord_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GivingRecordChangeNotify Clone() {
      return new GivingRecordChangeNotify(this);
    }

    /// <summary>Field number for the "is_deactive" field.</summary>
    public const int IsDeactiveFieldNumber = 14;
    private bool isDeactive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDeactive {
      get { return isDeactive_; }
      set {
        isDeactive_ = value;
      }
    }

    /// <summary>Field number for the "giving_record" field.</summary>
    public const int GivingRecordFieldNumber = 15;
    private global::NewProtos.GivingRecord givingRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GivingRecord GivingRecord {
      get { return givingRecord_; }
      set {
        givingRecord_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GivingRecordChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GivingRecordChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsDeactive != other.IsDeactive) return false;
      if (!object.Equals(GivingRecord, other.GivingRecord)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsDeactive != false) hash ^= IsDeactive.GetHashCode();
      if (givingRecord_ != null) hash ^= GivingRecord.GetHashCode();
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
      if (IsDeactive != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsDeactive);
      }
      if (givingRecord_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(GivingRecord);
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
      if (IsDeactive != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsDeactive);
      }
      if (givingRecord_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(GivingRecord);
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
      if (IsDeactive != false) {
        size += 1 + 1;
      }
      if (givingRecord_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GivingRecord);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GivingRecordChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsDeactive != false) {
        IsDeactive = other.IsDeactive;
      }
      if (other.givingRecord_ != null) {
        if (givingRecord_ == null) {
          GivingRecord = new global::NewProtos.GivingRecord();
        }
        GivingRecord.MergeFrom(other.GivingRecord);
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
          case 112: {
            IsDeactive = input.ReadBool();
            break;
          }
          case 122: {
            if (givingRecord_ == null) {
              GivingRecord = new global::NewProtos.GivingRecord();
            }
            input.ReadMessage(GivingRecord);
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
          case 112: {
            IsDeactive = input.ReadBool();
            break;
          }
          case 122: {
            if (givingRecord_ == null) {
              GivingRecord = new global::NewProtos.GivingRecord();
            }
            input.ReadMessage(GivingRecord);
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
