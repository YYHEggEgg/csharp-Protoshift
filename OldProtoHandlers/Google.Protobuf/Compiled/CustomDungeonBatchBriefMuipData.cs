// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonBatchBriefMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from CustomDungeonBatchBriefMuipData.proto</summary>
  public static partial class CustomDungeonBatchBriefMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonBatchBriefMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonBatchBriefMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVDdXN0b21EdW5nZW9uQmF0Y2hCcmllZk11aXBEYXRhLnByb3RvGiBDdXN0",
            "b21EdW5nZW9uQnJpZWZNdWlwRGF0YS5wcm90byJSCh9DdXN0b21EdW5nZW9u",
            "QmF0Y2hCcmllZk11aXBEYXRhEi8KCmJyaWVmX2xpc3QYASADKAsyGy5DdXN0",
            "b21EdW5nZW9uQnJpZWZNdWlwRGF0YUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.CustomDungeonBriefMuipDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.CustomDungeonBatchBriefMuipData), global::OldProtos.CustomDungeonBatchBriefMuipData.Parser, new[]{ "BriefList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonBatchBriefMuipData : pb::IMessage<CustomDungeonBatchBriefMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonBatchBriefMuipData> _parser = new pb::MessageParser<CustomDungeonBatchBriefMuipData>(() => new CustomDungeonBatchBriefMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonBatchBriefMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.CustomDungeonBatchBriefMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBatchBriefMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBatchBriefMuipData(CustomDungeonBatchBriefMuipData other) : this() {
      briefList_ = other.briefList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBatchBriefMuipData Clone() {
      return new CustomDungeonBatchBriefMuipData(this);
    }

    /// <summary>Field number for the "brief_list" field.</summary>
    public const int BriefListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::OldProtos.CustomDungeonBriefMuipData> _repeated_briefList_codec
        = pb::FieldCodec.ForMessage(10, global::OldProtos.CustomDungeonBriefMuipData.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.CustomDungeonBriefMuipData> briefList_ = new pbc::RepeatedField<global::OldProtos.CustomDungeonBriefMuipData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.CustomDungeonBriefMuipData> BriefList {
      get { return briefList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonBatchBriefMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonBatchBriefMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!briefList_.Equals(other.briefList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= briefList_.GetHashCode();
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
      briefList_.WriteTo(output, _repeated_briefList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      briefList_.WriteTo(ref output, _repeated_briefList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += briefList_.CalculateSize(_repeated_briefList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonBatchBriefMuipData other) {
      if (other == null) {
        return;
      }
      briefList_.Add(other.briefList_);
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
            briefList_.AddEntriesFrom(input, _repeated_briefList_codec);
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
            briefList_.AddEntriesFrom(ref input, _repeated_briefList_codec);
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
