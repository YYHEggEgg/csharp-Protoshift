// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameSettleRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from MusicGameSettleRsp.proto</summary>
  public static partial class MusicGameSettleRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameSettleRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameSettleRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhNdXNpY0dhbWVTZXR0bGVSc3AucHJvdG8ihAEKEk11c2ljR2FtZVNldHRs",
            "ZVJzcBIPCgdyZXRjb2RlGAwgASgFEhAKCHVnY19ndWlkGAcgASgEEhUKDWlz",
            "X25ld19yZWNvcmQYCCABKAgSHAoUaXNfdW5sb2NrX25leHRfbGV2ZWwYCiAB",
            "KAgSFgoObXVzaWNfYmFzaWNfaWQYASABKA1CDKoCCU5ld1Byb3Rvc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.MusicGameSettleRsp), global::NewProtos.MusicGameSettleRsp.Parser, new[]{ "Retcode", "UgcGuid", "IsNewRecord", "IsUnlockNextLevel", "MusicBasicId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8360;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class MusicGameSettleRsp : pb::IMessage<MusicGameSettleRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameSettleRsp> _parser = new pb::MessageParser<MusicGameSettleRsp>(() => new MusicGameSettleRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameSettleRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.MusicGameSettleRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleRsp(MusicGameSettleRsp other) : this() {
      retcode_ = other.retcode_;
      ugcGuid_ = other.ugcGuid_;
      isNewRecord_ = other.isNewRecord_;
      isUnlockNextLevel_ = other.isUnlockNextLevel_;
      musicBasicId_ = other.musicBasicId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleRsp Clone() {
      return new MusicGameSettleRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "ugc_guid" field.</summary>
    public const int UgcGuidFieldNumber = 7;
    private ulong ugcGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UgcGuid {
      get { return ugcGuid_; }
      set {
        ugcGuid_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 8;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "is_unlock_next_level" field.</summary>
    public const int IsUnlockNextLevelFieldNumber = 10;
    private bool isUnlockNextLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnlockNextLevel {
      get { return isUnlockNextLevel_; }
      set {
        isUnlockNextLevel_ = value;
      }
    }

    /// <summary>Field number for the "music_basic_id" field.</summary>
    public const int MusicBasicIdFieldNumber = 1;
    private uint musicBasicId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MusicBasicId {
      get { return musicBasicId_; }
      set {
        musicBasicId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameSettleRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameSettleRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (UgcGuid != other.UgcGuid) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (IsUnlockNextLevel != other.IsUnlockNextLevel) return false;
      if (MusicBasicId != other.MusicBasicId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (UgcGuid != 0UL) hash ^= UgcGuid.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (IsUnlockNextLevel != false) hash ^= IsUnlockNextLevel.GetHashCode();
      if (MusicBasicId != 0) hash ^= MusicBasicId.GetHashCode();
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
      if (MusicBasicId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MusicBasicId);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(UgcGuid);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsNewRecord);
      }
      if (IsUnlockNextLevel != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsUnlockNextLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
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
      if (MusicBasicId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MusicBasicId);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(UgcGuid);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsNewRecord);
      }
      if (IsUnlockNextLevel != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsUnlockNextLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (UgcGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UgcGuid);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (IsUnlockNextLevel != false) {
        size += 1 + 1;
      }
      if (MusicBasicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MusicBasicId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameSettleRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.UgcGuid != 0UL) {
        UgcGuid = other.UgcGuid;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.IsUnlockNextLevel != false) {
        IsUnlockNextLevel = other.IsUnlockNextLevel;
      }
      if (other.MusicBasicId != 0) {
        MusicBasicId = other.MusicBasicId;
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
          case 8: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 56: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 64: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 80: {
            IsUnlockNextLevel = input.ReadBool();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
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
          case 8: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 56: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 64: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 80: {
            IsUnlockNextLevel = input.ReadBool();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
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