// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SingleStartBrickBreakerReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from SingleStartBrickBreakerReq.proto</summary>
  public static partial class SingleStartBrickBreakerReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SingleStartBrickBreakerReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SingleStartBrickBreakerReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTaW5nbGVTdGFydEJyaWNrQnJlYWtlclJlcS5wcm90byJ5ChpTaW5nbGVT",
            "dGFydEJyaWNrQnJlYWtlclJlcRISCgppc19kdW5nZW9uGAsgASgIEhoKEmNo",
            "b3Nlbl9hdmF0YXJfbGlzdBgNIAMoDRIZChFjaG9zZW5fc2tpbGxfbGlzdBgH",
            "IAMoDRIQCghsZXZlbF9pZBgGIAEoDUIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.SingleStartBrickBreakerReq), global::OldProtos.SingleStartBrickBreakerReq.Parser, new[]{ "IsDungeon", "ChosenAvatarList", "ChosenSkillList", "LevelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SingleStartBrickBreakerReq : pb::IMessage<SingleStartBrickBreakerReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SingleStartBrickBreakerReq> _parser = new pb::MessageParser<SingleStartBrickBreakerReq>(() => new SingleStartBrickBreakerReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SingleStartBrickBreakerReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.SingleStartBrickBreakerReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleStartBrickBreakerReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleStartBrickBreakerReq(SingleStartBrickBreakerReq other) : this() {
      isDungeon_ = other.isDungeon_;
      chosenAvatarList_ = other.chosenAvatarList_.Clone();
      chosenSkillList_ = other.chosenSkillList_.Clone();
      levelId_ = other.levelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleStartBrickBreakerReq Clone() {
      return new SingleStartBrickBreakerReq(this);
    }

    /// <summary>Field number for the "is_dungeon" field.</summary>
    public const int IsDungeonFieldNumber = 11;
    private bool isDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDungeon {
      get { return isDungeon_; }
      set {
        isDungeon_ = value;
      }
    }

    /// <summary>Field number for the "chosen_avatar_list" field.</summary>
    public const int ChosenAvatarListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_chosenAvatarList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> chosenAvatarList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenAvatarList {
      get { return chosenAvatarList_; }
    }

    /// <summary>Field number for the "chosen_skill_list" field.</summary>
    public const int ChosenSkillListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_chosenSkillList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> chosenSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenSkillList {
      get { return chosenSkillList_; }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 6;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SingleStartBrickBreakerReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SingleStartBrickBreakerReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsDungeon != other.IsDungeon) return false;
      if(!chosenAvatarList_.Equals(other.chosenAvatarList_)) return false;
      if(!chosenSkillList_.Equals(other.chosenSkillList_)) return false;
      if (LevelId != other.LevelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsDungeon != false) hash ^= IsDungeon.GetHashCode();
      hash ^= chosenAvatarList_.GetHashCode();
      hash ^= chosenSkillList_.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LevelId);
      }
      chosenSkillList_.WriteTo(output, _repeated_chosenSkillList_codec);
      if (IsDungeon != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsDungeon);
      }
      chosenAvatarList_.WriteTo(output, _repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LevelId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LevelId);
      }
      chosenSkillList_.WriteTo(ref output, _repeated_chosenSkillList_codec);
      if (IsDungeon != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsDungeon);
      }
      chosenAvatarList_.WriteTo(ref output, _repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsDungeon != false) {
        size += 1 + 1;
      }
      size += chosenAvatarList_.CalculateSize(_repeated_chosenAvatarList_codec);
      size += chosenSkillList_.CalculateSize(_repeated_chosenSkillList_codec);
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SingleStartBrickBreakerReq other) {
      if (other == null) {
        return;
      }
      if (other.IsDungeon != false) {
        IsDungeon = other.IsDungeon;
      }
      chosenAvatarList_.Add(other.chosenAvatarList_);
      chosenSkillList_.Add(other.chosenSkillList_);
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
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
          case 48: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            chosenSkillList_.AddEntriesFrom(input, _repeated_chosenSkillList_codec);
            break;
          }
          case 88: {
            IsDungeon = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            chosenAvatarList_.AddEntriesFrom(input, _repeated_chosenAvatarList_codec);
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
          case 48: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            chosenSkillList_.AddEntriesFrom(ref input, _repeated_chosenSkillList_codec);
            break;
          }
          case 88: {
            IsDungeon = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            chosenAvatarList_.AddEntriesFrom(ref input, _repeated_chosenAvatarList_codec);
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