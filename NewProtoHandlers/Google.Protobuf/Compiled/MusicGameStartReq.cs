// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameStartReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from MusicGameStartReq.proto</summary>
  public static partial class MusicGameStartReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameStartReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameStartReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdNdXNpY0dhbWVTdGFydFJlcS5wcm90byJUChFNdXNpY0dhbWVTdGFydFJl",
            "cRIWCg5tdXNpY19iYXNpY19pZBgLIAEoDRIVCg1pc19zYXZlX3Njb3JlGAwg",
            "ASgIEhAKCHVnY19ndWlkGAkgASgEQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.MusicGameStartReq), global::NewProtos.MusicGameStartReq.Parser, new[]{ "MusicBasicId", "IsSaveScore", "UgcGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8820;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class MusicGameStartReq : pb::IMessage<MusicGameStartReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameStartReq> _parser = new pb::MessageParser<MusicGameStartReq>(() => new MusicGameStartReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameStartReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.MusicGameStartReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameStartReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameStartReq(MusicGameStartReq other) : this() {
      musicBasicId_ = other.musicBasicId_;
      isSaveScore_ = other.isSaveScore_;
      ugcGuid_ = other.ugcGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameStartReq Clone() {
      return new MusicGameStartReq(this);
    }

    /// <summary>Field number for the "music_basic_id" field.</summary>
    public const int MusicBasicIdFieldNumber = 11;
    private uint musicBasicId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MusicBasicId {
      get { return musicBasicId_; }
      set {
        musicBasicId_ = value;
      }
    }

    /// <summary>Field number for the "is_save_score" field.</summary>
    public const int IsSaveScoreFieldNumber = 12;
    private bool isSaveScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSaveScore {
      get { return isSaveScore_; }
      set {
        isSaveScore_ = value;
      }
    }

    /// <summary>Field number for the "ugc_guid" field.</summary>
    public const int UgcGuidFieldNumber = 9;
    private ulong ugcGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UgcGuid {
      get { return ugcGuid_; }
      set {
        ugcGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameStartReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameStartReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MusicBasicId != other.MusicBasicId) return false;
      if (IsSaveScore != other.IsSaveScore) return false;
      if (UgcGuid != other.UgcGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MusicBasicId != 0) hash ^= MusicBasicId.GetHashCode();
      if (IsSaveScore != false) hash ^= IsSaveScore.GetHashCode();
      if (UgcGuid != 0UL) hash ^= UgcGuid.GetHashCode();
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
      if (UgcGuid != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(UgcGuid);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MusicBasicId);
      }
      if (IsSaveScore != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsSaveScore);
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
      if (UgcGuid != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(UgcGuid);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MusicBasicId);
      }
      if (IsSaveScore != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsSaveScore);
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
      if (MusicBasicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MusicBasicId);
      }
      if (IsSaveScore != false) {
        size += 1 + 1;
      }
      if (UgcGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UgcGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameStartReq other) {
      if (other == null) {
        return;
      }
      if (other.MusicBasicId != 0) {
        MusicBasicId = other.MusicBasicId;
      }
      if (other.IsSaveScore != false) {
        IsSaveScore = other.IsSaveScore;
      }
      if (other.UgcGuid != 0UL) {
        UgcGuid = other.UgcGuid;
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
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 88: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsSaveScore = input.ReadBool();
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
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 88: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsSaveScore = input.ReadBool();
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
