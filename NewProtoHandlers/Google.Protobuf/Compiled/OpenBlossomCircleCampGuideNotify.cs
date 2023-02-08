// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OpenBlossomCircleCampGuideNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from OpenBlossomCircleCampGuideNotify.proto</summary>
  public static partial class OpenBlossomCircleCampGuideNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for OpenBlossomCircleCampGuideNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpenBlossomCircleCampGuideNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZPcGVuQmxvc3NvbUNpcmNsZUNhbXBHdWlkZU5vdGlmeS5wcm90byJTCiBP",
            "cGVuQmxvc3NvbUNpcmNsZUNhbXBHdWlkZU5vdGlmeRISCgpyZWZyZXNoX2lk",
            "GAggASgNEhsKE2NpcmNsZV9jYW1wX2lkX2xpc3QYBiADKA1CDKoCCU5ld1By",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.OpenBlossomCircleCampGuideNotify), global::NewProtos.OpenBlossomCircleCampGuideNotify.Parser, new[]{ "RefreshId", "CircleCampIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2761;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class OpenBlossomCircleCampGuideNotify : pb::IMessage<OpenBlossomCircleCampGuideNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OpenBlossomCircleCampGuideNotify> _parser = new pb::MessageParser<OpenBlossomCircleCampGuideNotify>(() => new OpenBlossomCircleCampGuideNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OpenBlossomCircleCampGuideNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.OpenBlossomCircleCampGuideNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenBlossomCircleCampGuideNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenBlossomCircleCampGuideNotify(OpenBlossomCircleCampGuideNotify other) : this() {
      refreshId_ = other.refreshId_;
      circleCampIdList_ = other.circleCampIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenBlossomCircleCampGuideNotify Clone() {
      return new OpenBlossomCircleCampGuideNotify(this);
    }

    /// <summary>Field number for the "refresh_id" field.</summary>
    public const int RefreshIdFieldNumber = 8;
    private uint refreshId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RefreshId {
      get { return refreshId_; }
      set {
        refreshId_ = value;
      }
    }

    /// <summary>Field number for the "circle_camp_id_list" field.</summary>
    public const int CircleCampIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_circleCampIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> circleCampIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CircleCampIdList {
      get { return circleCampIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OpenBlossomCircleCampGuideNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OpenBlossomCircleCampGuideNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RefreshId != other.RefreshId) return false;
      if(!circleCampIdList_.Equals(other.circleCampIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RefreshId != 0) hash ^= RefreshId.GetHashCode();
      hash ^= circleCampIdList_.GetHashCode();
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
      circleCampIdList_.WriteTo(output, _repeated_circleCampIdList_codec);
      if (RefreshId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RefreshId);
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
      circleCampIdList_.WriteTo(ref output, _repeated_circleCampIdList_codec);
      if (RefreshId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RefreshId);
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
      if (RefreshId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RefreshId);
      }
      size += circleCampIdList_.CalculateSize(_repeated_circleCampIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OpenBlossomCircleCampGuideNotify other) {
      if (other == null) {
        return;
      }
      if (other.RefreshId != 0) {
        RefreshId = other.RefreshId;
      }
      circleCampIdList_.Add(other.circleCampIdList_);
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
            circleCampIdList_.AddEntriesFrom(input, _repeated_circleCampIdList_codec);
            break;
          }
          case 64: {
            RefreshId = input.ReadUInt32();
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
            circleCampIdList_.AddEntriesFrom(ref input, _repeated_circleCampIdList_codec);
            break;
          }
          case 64: {
            RefreshId = input.ReadUInt32();
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
