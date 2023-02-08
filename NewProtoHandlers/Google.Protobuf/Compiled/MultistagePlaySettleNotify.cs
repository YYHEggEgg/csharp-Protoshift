// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MultistagePlaySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from MultistagePlaySettleNotify.proto</summary>
  public static partial class MultistagePlaySettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MultistagePlaySettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultistagePlaySettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBNdWx0aXN0YWdlUGxheVNldHRsZU5vdGlmeS5wcm90bxodSW5CYXR0bGVD",
            "aGVzc1NldHRsZUluZm8ucHJvdG8aJEluQmF0dGxlSXJvZG9yaUNoZXNzU2V0",
            "dGxlSW5mby5wcm90bxoiSW5CYXR0bGVNZWNoYW5pY3VzU2V0dGxlSW5mby5w",
            "cm90byKNAgoaTXVsdGlzdGFnZVBsYXlTZXR0bGVOb3RpZnkSEAoIZ3JvdXBf",
            "aWQYAyABKA0SEgoKcGxheV9pbmRleBgJIAEoDRJAChZtZWNoYW5pY3VzX3Nl",
            "dHRsZV9pbmZvGIkFIAEoCzIdLkluQmF0dGxlTWVjaGFuaWN1c1NldHRsZUlu",
            "Zm9IABI2ChFjaGVzc19zZXR0bGVfaW5mbxiABCABKAsyGC5JbkJhdHRsZUNo",
            "ZXNzU2V0dGxlSW5mb0gAEkUKGWlyb2RvcmlfY2hlc3Nfc2V0dGxlX2luZm8Y",
            "iAQgASgLMh8uSW5CYXR0bGVJcm9kb3JpQ2hlc3NTZXR0bGVJbmZvSABCCAoG",
            "ZGV0YWlsQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.InBattleChessSettleInfoReflection.Descriptor, global::NewProtos.InBattleIrodoriChessSettleInfoReflection.Descriptor, global::NewProtos.InBattleMechanicusSettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.MultistagePlaySettleNotify), global::NewProtos.MultistagePlaySettleNotify.Parser, new[]{ "GroupId", "PlayIndex", "MechanicusSettleInfo", "ChessSettleInfo", "IrodoriChessSettleInfo" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5360;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class MultistagePlaySettleNotify : pb::IMessage<MultistagePlaySettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultistagePlaySettleNotify> _parser = new pb::MessageParser<MultistagePlaySettleNotify>(() => new MultistagePlaySettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultistagePlaySettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.MultistagePlaySettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistagePlaySettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistagePlaySettleNotify(MultistagePlaySettleNotify other) : this() {
      groupId_ = other.groupId_;
      playIndex_ = other.playIndex_;
      switch (other.DetailCase) {
        case DetailOneofCase.MechanicusSettleInfo:
          MechanicusSettleInfo = other.MechanicusSettleInfo.Clone();
          break;
        case DetailOneofCase.ChessSettleInfo:
          ChessSettleInfo = other.ChessSettleInfo.Clone();
          break;
        case DetailOneofCase.IrodoriChessSettleInfo:
          IrodoriChessSettleInfo = other.IrodoriChessSettleInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistagePlaySettleNotify Clone() {
      return new MultistagePlaySettleNotify(this);
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 3;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "play_index" field.</summary>
    public const int PlayIndexFieldNumber = 9;
    private uint playIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayIndex {
      get { return playIndex_; }
      set {
        playIndex_ = value;
      }
    }

    /// <summary>Field number for the "mechanicus_settle_info" field.</summary>
    public const int MechanicusSettleInfoFieldNumber = 649;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.InBattleMechanicusSettleInfo MechanicusSettleInfo {
      get { return detailCase_ == DetailOneofCase.MechanicusSettleInfo ? (global::NewProtos.InBattleMechanicusSettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.MechanicusSettleInfo;
      }
    }

    /// <summary>Field number for the "chess_settle_info" field.</summary>
    public const int ChessSettleInfoFieldNumber = 512;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.InBattleChessSettleInfo ChessSettleInfo {
      get { return detailCase_ == DetailOneofCase.ChessSettleInfo ? (global::NewProtos.InBattleChessSettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.ChessSettleInfo;
      }
    }

    /// <summary>Field number for the "irodori_chess_settle_info" field.</summary>
    public const int IrodoriChessSettleInfoFieldNumber = 520;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.InBattleIrodoriChessSettleInfo IrodoriChessSettleInfo {
      get { return detailCase_ == DetailOneofCase.IrodoriChessSettleInfo ? (global::NewProtos.InBattleIrodoriChessSettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.IrodoriChessSettleInfo;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      MechanicusSettleInfo = 649,
      ChessSettleInfo = 512,
      IrodoriChessSettleInfo = 520,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultistagePlaySettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultistagePlaySettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (PlayIndex != other.PlayIndex) return false;
      if (!object.Equals(MechanicusSettleInfo, other.MechanicusSettleInfo)) return false;
      if (!object.Equals(ChessSettleInfo, other.ChessSettleInfo)) return false;
      if (!object.Equals(IrodoriChessSettleInfo, other.IrodoriChessSettleInfo)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) hash ^= MechanicusSettleInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) hash ^= ChessSettleInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) hash ^= IrodoriChessSettleInfo.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (GroupId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GroupId);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PlayIndex);
      }
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
        output.WriteRawTag(130, 32);
        output.WriteMessage(ChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
        output.WriteRawTag(194, 32);
        output.WriteMessage(IrodoriChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
        output.WriteRawTag(202, 40);
        output.WriteMessage(MechanicusSettleInfo);
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
      if (GroupId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GroupId);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PlayIndex);
      }
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
        output.WriteRawTag(130, 32);
        output.WriteMessage(ChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
        output.WriteRawTag(194, 32);
        output.WriteMessage(IrodoriChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
        output.WriteRawTag(202, 40);
        output.WriteMessage(MechanicusSettleInfo);
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
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (PlayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
      }
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MechanicusSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(IrodoriChessSettleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MultistagePlaySettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.PlayIndex != 0) {
        PlayIndex = other.PlayIndex;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.MechanicusSettleInfo:
          if (MechanicusSettleInfo == null) {
            MechanicusSettleInfo = new global::NewProtos.InBattleMechanicusSettleInfo();
          }
          MechanicusSettleInfo.MergeFrom(other.MechanicusSettleInfo);
          break;
        case DetailOneofCase.ChessSettleInfo:
          if (ChessSettleInfo == null) {
            ChessSettleInfo = new global::NewProtos.InBattleChessSettleInfo();
          }
          ChessSettleInfo.MergeFrom(other.ChessSettleInfo);
          break;
        case DetailOneofCase.IrodoriChessSettleInfo:
          if (IrodoriChessSettleInfo == null) {
            IrodoriChessSettleInfo = new global::NewProtos.InBattleIrodoriChessSettleInfo();
          }
          IrodoriChessSettleInfo.MergeFrom(other.IrodoriChessSettleInfo);
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
          case 24: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 72: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 4098: {
            global::NewProtos.InBattleChessSettleInfo subBuilder = new global::NewProtos.InBattleChessSettleInfo();
            if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
              subBuilder.MergeFrom(ChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            ChessSettleInfo = subBuilder;
            break;
          }
          case 4162: {
            global::NewProtos.InBattleIrodoriChessSettleInfo subBuilder = new global::NewProtos.InBattleIrodoriChessSettleInfo();
            if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
              subBuilder.MergeFrom(IrodoriChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            IrodoriChessSettleInfo = subBuilder;
            break;
          }
          case 5194: {
            global::NewProtos.InBattleMechanicusSettleInfo subBuilder = new global::NewProtos.InBattleMechanicusSettleInfo();
            if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
              subBuilder.MergeFrom(MechanicusSettleInfo);
            }
            input.ReadMessage(subBuilder);
            MechanicusSettleInfo = subBuilder;
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 72: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 4098: {
            global::NewProtos.InBattleChessSettleInfo subBuilder = new global::NewProtos.InBattleChessSettleInfo();
            if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
              subBuilder.MergeFrom(ChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            ChessSettleInfo = subBuilder;
            break;
          }
          case 4162: {
            global::NewProtos.InBattleIrodoriChessSettleInfo subBuilder = new global::NewProtos.InBattleIrodoriChessSettleInfo();
            if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
              subBuilder.MergeFrom(IrodoriChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            IrodoriChessSettleInfo = subBuilder;
            break;
          }
          case 5194: {
            global::NewProtos.InBattleMechanicusSettleInfo subBuilder = new global::NewProtos.InBattleMechanicusSettleInfo();
            if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
              subBuilder.MergeFrom(MechanicusSettleInfo);
            }
            input.ReadMessage(subBuilder);
            MechanicusSettleInfo = subBuilder;
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
