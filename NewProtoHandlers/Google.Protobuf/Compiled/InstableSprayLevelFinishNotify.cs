// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InstableSprayLevelFinishNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from InstableSprayLevelFinishNotify.proto</summary>
  public static partial class InstableSprayLevelFinishNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for InstableSprayLevelFinishNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InstableSprayLevelFinishNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRJbnN0YWJsZVNwcmF5TGV2ZWxGaW5pc2hOb3RpZnkucHJvdG8ijQEKHklu",
            "c3RhYmxlU3ByYXlMZXZlbEZpbmlzaE5vdGlmeRINCgVyb3VuZBgCIAEoDRIQ",
            "CghsZXZlbF9pZBgPIAEoDRIbChNVbmszMzAwX0FNRUJBUElQTEdMGAMgASgI",
            "EhsKE1VuazMzMDBfREhLSEJLTEJJUEEYDCABKAgSEAoIc3RhZ2VfaWQYCiAB",
            "KA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.InstableSprayLevelFinishNotify), global::NewProtos.InstableSprayLevelFinishNotify.Parser, new[]{ "Round", "LevelId", "Unk3300AMEBAPIPLGL", "Unk3300DHKHBKLBIPA", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 21512;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class InstableSprayLevelFinishNotify : pb::IMessage<InstableSprayLevelFinishNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InstableSprayLevelFinishNotify> _parser = new pb::MessageParser<InstableSprayLevelFinishNotify>(() => new InstableSprayLevelFinishNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InstableSprayLevelFinishNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.InstableSprayLevelFinishNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstableSprayLevelFinishNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstableSprayLevelFinishNotify(InstableSprayLevelFinishNotify other) : this() {
      round_ = other.round_;
      levelId_ = other.levelId_;
      unk3300AMEBAPIPLGL_ = other.unk3300AMEBAPIPLGL_;
      unk3300DHKHBKLBIPA_ = other.unk3300DHKHBKLBIPA_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InstableSprayLevelFinishNotify Clone() {
      return new InstableSprayLevelFinishNotify(this);
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 2;
    private uint round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 15;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AMEBAPIPLGL" field.</summary>
    public const int Unk3300AMEBAPIPLGLFieldNumber = 3;
    private bool unk3300AMEBAPIPLGL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300AMEBAPIPLGL {
      get { return unk3300AMEBAPIPLGL_; }
      set {
        unk3300AMEBAPIPLGL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DHKHBKLBIPA" field.</summary>
    public const int Unk3300DHKHBKLBIPAFieldNumber = 12;
    private bool unk3300DHKHBKLBIPA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300DHKHBKLBIPA {
      get { return unk3300DHKHBKLBIPA_; }
      set {
        unk3300DHKHBKLBIPA_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 10;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InstableSprayLevelFinishNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InstableSprayLevelFinishNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Round != other.Round) return false;
      if (LevelId != other.LevelId) return false;
      if (Unk3300AMEBAPIPLGL != other.Unk3300AMEBAPIPLGL) return false;
      if (Unk3300DHKHBKLBIPA != other.Unk3300DHKHBKLBIPA) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Round != 0) hash ^= Round.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (Unk3300AMEBAPIPLGL != false) hash ^= Unk3300AMEBAPIPLGL.GetHashCode();
      if (Unk3300DHKHBKLBIPA != false) hash ^= Unk3300DHKHBKLBIPA.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (Round != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Round);
      }
      if (Unk3300AMEBAPIPLGL != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300AMEBAPIPLGL);
      }
      if (StageId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageId);
      }
      if (Unk3300DHKHBKLBIPA != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk3300DHKHBKLBIPA);
      }
      if (LevelId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LevelId);
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
      if (Round != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Round);
      }
      if (Unk3300AMEBAPIPLGL != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300AMEBAPIPLGL);
      }
      if (StageId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageId);
      }
      if (Unk3300DHKHBKLBIPA != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk3300DHKHBKLBIPA);
      }
      if (LevelId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LevelId);
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
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (Unk3300AMEBAPIPLGL != false) {
        size += 1 + 1;
      }
      if (Unk3300DHKHBKLBIPA != false) {
        size += 1 + 1;
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InstableSprayLevelFinishNotify other) {
      if (other == null) {
        return;
      }
      if (other.Round != 0) {
        Round = other.Round;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.Unk3300AMEBAPIPLGL != false) {
        Unk3300AMEBAPIPLGL = other.Unk3300AMEBAPIPLGL;
      }
      if (other.Unk3300DHKHBKLBIPA != false) {
        Unk3300DHKHBKLBIPA = other.Unk3300DHKHBKLBIPA;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
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
          case 16: {
            Round = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300AMEBAPIPLGL = input.ReadBool();
            break;
          }
          case 80: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300DHKHBKLBIPA = input.ReadBool();
            break;
          }
          case 120: {
            LevelId = input.ReadUInt32();
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
          case 16: {
            Round = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300AMEBAPIPLGL = input.ReadBool();
            break;
          }
          case 80: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300DHKHBKLBIPA = input.ReadBool();
            break;
          }
          case 120: {
            LevelId = input.ReadUInt32();
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