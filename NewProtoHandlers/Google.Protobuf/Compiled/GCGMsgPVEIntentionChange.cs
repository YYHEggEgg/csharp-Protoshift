// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgPVEIntentionChange.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GCGMsgPVEIntentionChange.proto</summary>
  public static partial class GCGMsgPVEIntentionChangeReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgPVEIntentionChange.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgPVEIntentionChangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HQ0dNc2dQVkVJbnRlbnRpb25DaGFuZ2UucHJvdG8aHEdDR0ludGVudGlv",
            "bkNoYW5nZVR5cGUucHJvdG8aGEdDR01zZ1BWRUludGVudGlvbi5wcm90byJ8",
            "ChhHQ0dNc2dQVkVJbnRlbnRpb25DaGFuZ2USLAoLY2hhbmdlX3R5cGUYCSAB",
            "KA4yFy5HQ0dJbnRlbnRpb25DaGFuZ2VUeXBlEjIKFWNoYW5nZV9pbnRlbnRp",
            "b25fbGlzdBgGIAMoCzITLkdDR01zZ1BWRUludGVudGlvbkIMqgIJTmV3UHJv",
            "dG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GCGIntentionChangeTypeReflection.Descriptor, global::NewProtos.GCGMsgPVEIntentionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GCGMsgPVEIntentionChange), global::NewProtos.GCGMsgPVEIntentionChange.Parser, new[]{ "ChangeType", "ChangeIntentionList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgPVEIntentionChange : pb::IMessage<GCGMsgPVEIntentionChange>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgPVEIntentionChange> _parser = new pb::MessageParser<GCGMsgPVEIntentionChange>(() => new GCGMsgPVEIntentionChange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgPVEIntentionChange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GCGMsgPVEIntentionChangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgPVEIntentionChange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgPVEIntentionChange(GCGMsgPVEIntentionChange other) : this() {
      changeType_ = other.changeType_;
      changeIntentionList_ = other.changeIntentionList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgPVEIntentionChange Clone() {
      return new GCGMsgPVEIntentionChange(this);
    }

    /// <summary>Field number for the "change_type" field.</summary>
    public const int ChangeTypeFieldNumber = 9;
    private global::NewProtos.GCGIntentionChangeType changeType_ = global::NewProtos.GCGIntentionChangeType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GCGIntentionChangeType ChangeType {
      get { return changeType_; }
      set {
        changeType_ = value;
      }
    }

    /// <summary>Field number for the "change_intention_list" field.</summary>
    public const int ChangeIntentionListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::NewProtos.GCGMsgPVEIntention> _repeated_changeIntentionList_codec
        = pb::FieldCodec.ForMessage(50, global::NewProtos.GCGMsgPVEIntention.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.GCGMsgPVEIntention> changeIntentionList_ = new pbc::RepeatedField<global::NewProtos.GCGMsgPVEIntention>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.GCGMsgPVEIntention> ChangeIntentionList {
      get { return changeIntentionList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgPVEIntentionChange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgPVEIntentionChange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChangeType != other.ChangeType) return false;
      if(!changeIntentionList_.Equals(other.changeIntentionList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChangeType != global::NewProtos.GCGIntentionChangeType.None) hash ^= ChangeType.GetHashCode();
      hash ^= changeIntentionList_.GetHashCode();
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
      changeIntentionList_.WriteTo(output, _repeated_changeIntentionList_codec);
      if (ChangeType != global::NewProtos.GCGIntentionChangeType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ChangeType);
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
      changeIntentionList_.WriteTo(ref output, _repeated_changeIntentionList_codec);
      if (ChangeType != global::NewProtos.GCGIntentionChangeType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ChangeType);
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
      if (ChangeType != global::NewProtos.GCGIntentionChangeType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChangeType);
      }
      size += changeIntentionList_.CalculateSize(_repeated_changeIntentionList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgPVEIntentionChange other) {
      if (other == null) {
        return;
      }
      if (other.ChangeType != global::NewProtos.GCGIntentionChangeType.None) {
        ChangeType = other.ChangeType;
      }
      changeIntentionList_.Add(other.changeIntentionList_);
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
          case 50: {
            changeIntentionList_.AddEntriesFrom(input, _repeated_changeIntentionList_codec);
            break;
          }
          case 72: {
            ChangeType = (global::NewProtos.GCGIntentionChangeType) input.ReadEnum();
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
          case 50: {
            changeIntentionList_.AddEntriesFrom(ref input, _repeated_changeIntentionList_codec);
            break;
          }
          case 72: {
            ChangeType = (global::NewProtos.GCGIntentionChangeType) input.ReadEnum();
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
