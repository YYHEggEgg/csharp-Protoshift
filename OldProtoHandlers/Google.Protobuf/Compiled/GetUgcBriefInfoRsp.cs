// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetUgcBriefInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GetUgcBriefInfoRsp.proto</summary>
  public static partial class GetUgcBriefInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetUgcBriefInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetUgcBriefInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHZXRVZ2NCcmllZkluZm9Sc3AucHJvdG8aF1VnY011c2ljQnJpZWZJbmZv",
            "LnByb3RvGg1VZ2NUeXBlLnByb3RvIowBChJHZXRVZ2NCcmllZkluZm9Sc3AS",
            "EAoIdWdjX2d1aWQYAyABKAQSGgoIdWdjX3R5cGUYCyABKA4yCC5VZ2NUeXBl",
            "Eg8KB3JldGNvZGUYBCABKAUSLgoQbXVzaWNfYnJpZWZfaW5mbxgCIAEoCzIS",
            "LlVnY011c2ljQnJpZWZJbmZvSABCBwoFYnJpZWZCDKoCCU9sZFByb3Rvc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.UgcMusicBriefInfoReflection.Descriptor, global::OldProtos.UgcTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GetUgcBriefInfoRsp), global::OldProtos.GetUgcBriefInfoRsp.Parser, new[]{ "UgcGuid", "UgcType", "Retcode", "MusicBriefInfo" }, new[]{ "Brief" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6307
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GetUgcBriefInfoRsp : pb::IMessage<GetUgcBriefInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetUgcBriefInfoRsp> _parser = new pb::MessageParser<GetUgcBriefInfoRsp>(() => new GetUgcBriefInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetUgcBriefInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GetUgcBriefInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUgcBriefInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUgcBriefInfoRsp(GetUgcBriefInfoRsp other) : this() {
      ugcGuid_ = other.ugcGuid_;
      ugcType_ = other.ugcType_;
      retcode_ = other.retcode_;
      switch (other.BriefCase) {
        case BriefOneofCase.MusicBriefInfo:
          MusicBriefInfo = other.MusicBriefInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUgcBriefInfoRsp Clone() {
      return new GetUgcBriefInfoRsp(this);
    }

    /// <summary>Field number for the "ugc_guid" field.</summary>
    public const int UgcGuidFieldNumber = 3;
    private ulong ugcGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UgcGuid {
      get { return ugcGuid_; }
      set {
        ugcGuid_ = value;
      }
    }

    /// <summary>Field number for the "ugc_type" field.</summary>
    public const int UgcTypeFieldNumber = 11;
    private global::OldProtos.UgcType ugcType_ = global::OldProtos.UgcType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.UgcType UgcType {
      get { return ugcType_; }
      set {
        ugcType_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "music_brief_info" field.</summary>
    public const int MusicBriefInfoFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.UgcMusicBriefInfo MusicBriefInfo {
      get { return briefCase_ == BriefOneofCase.MusicBriefInfo ? (global::OldProtos.UgcMusicBriefInfo) brief_ : null; }
      set {
        brief_ = value;
        briefCase_ = value == null ? BriefOneofCase.None : BriefOneofCase.MusicBriefInfo;
      }
    }

    private object brief_;
    /// <summary>Enum of possible cases for the "brief" oneof.</summary>
    public enum BriefOneofCase {
      None = 0,
      MusicBriefInfo = 2,
    }
    private BriefOneofCase briefCase_ = BriefOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BriefOneofCase BriefCase {
      get { return briefCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBrief() {
      briefCase_ = BriefOneofCase.None;
      brief_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetUgcBriefInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetUgcBriefInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UgcGuid != other.UgcGuid) return false;
      if (UgcType != other.UgcType) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(MusicBriefInfo, other.MusicBriefInfo)) return false;
      if (BriefCase != other.BriefCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UgcGuid != 0UL) hash ^= UgcGuid.GetHashCode();
      if (UgcType != global::OldProtos.UgcType.None) hash ^= UgcType.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (briefCase_ == BriefOneofCase.MusicBriefInfo) hash ^= MusicBriefInfo.GetHashCode();
      hash ^= (int) briefCase_;
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
      if (briefCase_ == BriefOneofCase.MusicBriefInfo) {
        output.WriteRawTag(18);
        output.WriteMessage(MusicBriefInfo);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(UgcGuid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      if (UgcType != global::OldProtos.UgcType.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) UgcType);
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
      if (briefCase_ == BriefOneofCase.MusicBriefInfo) {
        output.WriteRawTag(18);
        output.WriteMessage(MusicBriefInfo);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(UgcGuid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      if (UgcType != global::OldProtos.UgcType.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) UgcType);
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
      if (UgcGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UgcGuid);
      }
      if (UgcType != global::OldProtos.UgcType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UgcType);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (briefCase_ == BriefOneofCase.MusicBriefInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MusicBriefInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetUgcBriefInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.UgcGuid != 0UL) {
        UgcGuid = other.UgcGuid;
      }
      if (other.UgcType != global::OldProtos.UgcType.None) {
        UgcType = other.UgcType;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      switch (other.BriefCase) {
        case BriefOneofCase.MusicBriefInfo:
          if (MusicBriefInfo == null) {
            MusicBriefInfo = new global::OldProtos.UgcMusicBriefInfo();
          }
          MusicBriefInfo.MergeFrom(other.MusicBriefInfo);
          break;
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
          case 18: {
            global::OldProtos.UgcMusicBriefInfo subBuilder = new global::OldProtos.UgcMusicBriefInfo();
            if (briefCase_ == BriefOneofCase.MusicBriefInfo) {
              subBuilder.MergeFrom(MusicBriefInfo);
            }
            input.ReadMessage(subBuilder);
            MusicBriefInfo = subBuilder;
            break;
          }
          case 24: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 88: {
            UgcType = (global::OldProtos.UgcType) input.ReadEnum();
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
          case 18: {
            global::OldProtos.UgcMusicBriefInfo subBuilder = new global::OldProtos.UgcMusicBriefInfo();
            if (briefCase_ == BriefOneofCase.MusicBriefInfo) {
              subBuilder.MergeFrom(MusicBriefInfo);
            }
            input.ReadMessage(subBuilder);
            MusicBriefInfo = subBuilder;
            break;
          }
          case 24: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 88: {
            UgcType = (global::OldProtos.UgcType) input.ReadEnum();
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
