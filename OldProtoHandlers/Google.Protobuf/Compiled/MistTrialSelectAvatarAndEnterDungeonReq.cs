// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MistTrialSelectAvatarAndEnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from MistTrialSelectAvatarAndEnterDungeonReq.proto</summary>
  public static partial class MistTrialSelectAvatarAndEnterDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MistTrialSelectAvatarAndEnterDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MistTrialSelectAvatarAndEnterDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1NaXN0VHJpYWxTZWxlY3RBdmF0YXJBbmRFbnRlckR1bmdlb25SZXEucHJv",
            "dG8iswIKJ01pc3RUcmlhbFNlbGVjdEF2YXRhckFuZEVudGVyRHVuZ2VvblJl",
            "cRIWCg5lbnRlcl9wb2ludF9pZBgHIAEoDRIjChtzZWxlY3RfdHJpYWxfYXZh",
            "dGFyX2lkX2xpc3QYCiADKA0SEAoIdHJpYWxfaWQYBCABKA0SXAoYc2VsZWN0",
            "X2F2YXRhcl9pbmRleF9saXN0GAYgAygLMjouTWlzdFRyaWFsU2VsZWN0QXZh",
            "dGFyQW5kRW50ZXJEdW5nZW9uUmVxLlNlbGVjdEF2YXRhckluZGV4GlsKEVNl",
            "bGVjdEF2YXRhckluZGV4Eh4KFG1pc3RfdHJpYWxfYXZhdGFyX2lkGAggASgN",
            "SAASHAoSZm9ybWFsX2F2YXRhcl9ndWlkGAYgASgESABCCAoGZGV0YWlsQgyq",
            "AglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq), global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Parser, new[]{ "EnterPointId", "SelectTrialAvatarIdList", "TrialId", "SelectAvatarIndexList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Types.SelectAvatarIndex), global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Types.SelectAvatarIndex.Parser, new[]{ "MistTrialAvatarId", "FormalAvatarGuid" }, new[]{ "Detail" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MistTrialSelectAvatarAndEnterDungeonReq : pb::IMessage<MistTrialSelectAvatarAndEnterDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MistTrialSelectAvatarAndEnterDungeonReq> _parser = new pb::MessageParser<MistTrialSelectAvatarAndEnterDungeonReq>(() => new MistTrialSelectAvatarAndEnterDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MistTrialSelectAvatarAndEnterDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialSelectAvatarAndEnterDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialSelectAvatarAndEnterDungeonReq(MistTrialSelectAvatarAndEnterDungeonReq other) : this() {
      enterPointId_ = other.enterPointId_;
      selectTrialAvatarIdList_ = other.selectTrialAvatarIdList_.Clone();
      trialId_ = other.trialId_;
      selectAvatarIndexList_ = other.selectAvatarIndexList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialSelectAvatarAndEnterDungeonReq Clone() {
      return new MistTrialSelectAvatarAndEnterDungeonReq(this);
    }

    /// <summary>Field number for the "enter_point_id" field.</summary>
    public const int EnterPointIdFieldNumber = 7;
    private uint enterPointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterPointId {
      get { return enterPointId_; }
      set {
        enterPointId_ = value;
      }
    }

    /// <summary>Field number for the "select_trial_avatar_id_list" field.</summary>
    public const int SelectTrialAvatarIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_selectTrialAvatarIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> selectTrialAvatarIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectTrialAvatarIdList {
      get { return selectTrialAvatarIdList_; }
    }

    /// <summary>Field number for the "trial_id" field.</summary>
    public const int TrialIdFieldNumber = 4;
    private uint trialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TrialId {
      get { return trialId_; }
      set {
        trialId_ = value;
      }
    }

    /// <summary>Field number for the "select_avatar_index_list" field.</summary>
    public const int SelectAvatarIndexListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Types.SelectAvatarIndex> _repeated_selectAvatarIndexList_codec
        = pb::FieldCodec.ForMessage(50, global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Types.SelectAvatarIndex.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Types.SelectAvatarIndex> selectAvatarIndexList_ = new pbc::RepeatedField<global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Types.SelectAvatarIndex>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Types.SelectAvatarIndex> SelectAvatarIndexList {
      get { return selectAvatarIndexList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MistTrialSelectAvatarAndEnterDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MistTrialSelectAvatarAndEnterDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnterPointId != other.EnterPointId) return false;
      if(!selectTrialAvatarIdList_.Equals(other.selectTrialAvatarIdList_)) return false;
      if (TrialId != other.TrialId) return false;
      if(!selectAvatarIndexList_.Equals(other.selectAvatarIndexList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EnterPointId != 0) hash ^= EnterPointId.GetHashCode();
      hash ^= selectTrialAvatarIdList_.GetHashCode();
      if (TrialId != 0) hash ^= TrialId.GetHashCode();
      hash ^= selectAvatarIndexList_.GetHashCode();
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
      if (TrialId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TrialId);
      }
      selectAvatarIndexList_.WriteTo(output, _repeated_selectAvatarIndexList_codec);
      if (EnterPointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterPointId);
      }
      selectTrialAvatarIdList_.WriteTo(output, _repeated_selectTrialAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TrialId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TrialId);
      }
      selectAvatarIndexList_.WriteTo(ref output, _repeated_selectAvatarIndexList_codec);
      if (EnterPointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterPointId);
      }
      selectTrialAvatarIdList_.WriteTo(ref output, _repeated_selectTrialAvatarIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EnterPointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterPointId);
      }
      size += selectTrialAvatarIdList_.CalculateSize(_repeated_selectTrialAvatarIdList_codec);
      if (TrialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialId);
      }
      size += selectAvatarIndexList_.CalculateSize(_repeated_selectAvatarIndexList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MistTrialSelectAvatarAndEnterDungeonReq other) {
      if (other == null) {
        return;
      }
      if (other.EnterPointId != 0) {
        EnterPointId = other.EnterPointId;
      }
      selectTrialAvatarIdList_.Add(other.selectTrialAvatarIdList_);
      if (other.TrialId != 0) {
        TrialId = other.TrialId;
      }
      selectAvatarIndexList_.Add(other.selectAvatarIndexList_);
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
          case 32: {
            TrialId = input.ReadUInt32();
            break;
          }
          case 50: {
            selectAvatarIndexList_.AddEntriesFrom(input, _repeated_selectAvatarIndexList_codec);
            break;
          }
          case 56: {
            EnterPointId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            selectTrialAvatarIdList_.AddEntriesFrom(input, _repeated_selectTrialAvatarIdList_codec);
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
          case 32: {
            TrialId = input.ReadUInt32();
            break;
          }
          case 50: {
            selectAvatarIndexList_.AddEntriesFrom(ref input, _repeated_selectAvatarIndexList_codec);
            break;
          }
          case 56: {
            EnterPointId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            selectTrialAvatarIdList_.AddEntriesFrom(ref input, _repeated_selectTrialAvatarIdList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MistTrialSelectAvatarAndEnterDungeonReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class SelectAvatarIndex : pb::IMessage<SelectAvatarIndex>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<SelectAvatarIndex> _parser = new pb::MessageParser<SelectAvatarIndex>(() => new SelectAvatarIndex());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<SelectAvatarIndex> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::OldProtos.MistTrialSelectAvatarAndEnterDungeonReq.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SelectAvatarIndex() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SelectAvatarIndex(SelectAvatarIndex other) : this() {
          switch (other.DetailCase) {
            case DetailOneofCase.MistTrialAvatarId:
              MistTrialAvatarId = other.MistTrialAvatarId;
              break;
            case DetailOneofCase.FormalAvatarGuid:
              FormalAvatarGuid = other.FormalAvatarGuid;
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SelectAvatarIndex Clone() {
          return new SelectAvatarIndex(this);
        }

        /// <summary>Field number for the "mist_trial_avatar_id" field.</summary>
        public const int MistTrialAvatarIdFieldNumber = 8;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint MistTrialAvatarId {
          get { return HasMistTrialAvatarId ? (uint) detail_ : 0; }
          set {
            detail_ = value;
            detailCase_ = DetailOneofCase.MistTrialAvatarId;
          }
        }
        /// <summary>Gets whether the "mist_trial_avatar_id" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasMistTrialAvatarId {
          get { return detailCase_ == DetailOneofCase.MistTrialAvatarId; }
        }
        /// <summary> Clears the value of the oneof if it's currently set to "mist_trial_avatar_id" </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearMistTrialAvatarId() {
          if (HasMistTrialAvatarId) {
            ClearDetail();
          }
        }

        /// <summary>Field number for the "formal_avatar_guid" field.</summary>
        public const int FormalAvatarGuidFieldNumber = 6;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public ulong FormalAvatarGuid {
          get { return HasFormalAvatarGuid ? (ulong) detail_ : 0UL; }
          set {
            detail_ = value;
            detailCase_ = DetailOneofCase.FormalAvatarGuid;
          }
        }
        /// <summary>Gets whether the "formal_avatar_guid" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasFormalAvatarGuid {
          get { return detailCase_ == DetailOneofCase.FormalAvatarGuid; }
        }
        /// <summary> Clears the value of the oneof if it's currently set to "formal_avatar_guid" </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearFormalAvatarGuid() {
          if (HasFormalAvatarGuid) {
            ClearDetail();
          }
        }

        private object detail_;
        /// <summary>Enum of possible cases for the "detail" oneof.</summary>
        public enum DetailOneofCase {
          None = 0,
          MistTrialAvatarId = 8,
          FormalAvatarGuid = 6,
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
          return Equals(other as SelectAvatarIndex);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(SelectAvatarIndex other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (MistTrialAvatarId != other.MistTrialAvatarId) return false;
          if (FormalAvatarGuid != other.FormalAvatarGuid) return false;
          if (DetailCase != other.DetailCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (HasMistTrialAvatarId) hash ^= MistTrialAvatarId.GetHashCode();
          if (HasFormalAvatarGuid) hash ^= FormalAvatarGuid.GetHashCode();
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
          if (HasFormalAvatarGuid) {
            output.WriteRawTag(48);
            output.WriteUInt64(FormalAvatarGuid);
          }
          if (HasMistTrialAvatarId) {
            output.WriteRawTag(64);
            output.WriteUInt32(MistTrialAvatarId);
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
          if (HasFormalAvatarGuid) {
            output.WriteRawTag(48);
            output.WriteUInt64(FormalAvatarGuid);
          }
          if (HasMistTrialAvatarId) {
            output.WriteRawTag(64);
            output.WriteUInt32(MistTrialAvatarId);
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
          if (HasMistTrialAvatarId) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MistTrialAvatarId);
          }
          if (HasFormalAvatarGuid) {
            size += 1 + pb::CodedOutputStream.ComputeUInt64Size(FormalAvatarGuid);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(SelectAvatarIndex other) {
          if (other == null) {
            return;
          }
          switch (other.DetailCase) {
            case DetailOneofCase.MistTrialAvatarId:
              MistTrialAvatarId = other.MistTrialAvatarId;
              break;
            case DetailOneofCase.FormalAvatarGuid:
              FormalAvatarGuid = other.FormalAvatarGuid;
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
              case 48: {
                FormalAvatarGuid = input.ReadUInt64();
                break;
              }
              case 64: {
                MistTrialAvatarId = input.ReadUInt32();
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
                FormalAvatarGuid = input.ReadUInt64();
                break;
              }
              case 64: {
                MistTrialAvatarId = input.ReadUInt32();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
