// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGGameBriefDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GCGGameBriefDataNotify.proto</summary>
  public static partial class GCGGameBriefDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGGameBriefDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGGameBriefDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHQ0dHYW1lQnJpZWZEYXRhTm90aWZ5LnByb3RvGhZHQ0dHYW1lQnJpZWZE",
            "YXRhLnByb3RvIlgKFkdDR0dhbWVCcmllZkRhdGFOb3RpZnkSKQoOZ2NnX2Jy",
            "aWVmX2RhdGEYAyABKAsyES5HQ0dHYW1lQnJpZWZEYXRhEhMKC2lzX25ld19n",
            "YW1lGAQgASgIQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GCGGameBriefDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GCGGameBriefDataNotify), global::NewProtos.GCGGameBriefDataNotify.Parser, new[]{ "GcgBriefData", "IsNewGame" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 7824;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GCGGameBriefDataNotify : pb::IMessage<GCGGameBriefDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGGameBriefDataNotify> _parser = new pb::MessageParser<GCGGameBriefDataNotify>(() => new GCGGameBriefDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGGameBriefDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GCGGameBriefDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGGameBriefDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGGameBriefDataNotify(GCGGameBriefDataNotify other) : this() {
      gcgBriefData_ = other.gcgBriefData_ != null ? other.gcgBriefData_.Clone() : null;
      isNewGame_ = other.isNewGame_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGGameBriefDataNotify Clone() {
      return new GCGGameBriefDataNotify(this);
    }

    /// <summary>Field number for the "gcg_brief_data" field.</summary>
    public const int GcgBriefDataFieldNumber = 3;
    private global::NewProtos.GCGGameBriefData gcgBriefData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GCGGameBriefData GcgBriefData {
      get { return gcgBriefData_; }
      set {
        gcgBriefData_ = value;
      }
    }

    /// <summary>Field number for the "is_new_game" field.</summary>
    public const int IsNewGameFieldNumber = 4;
    private bool isNewGame_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewGame {
      get { return isNewGame_; }
      set {
        isNewGame_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGGameBriefDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGGameBriefDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GcgBriefData, other.GcgBriefData)) return false;
      if (IsNewGame != other.IsNewGame) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gcgBriefData_ != null) hash ^= GcgBriefData.GetHashCode();
      if (IsNewGame != false) hash ^= IsNewGame.GetHashCode();
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
      if (gcgBriefData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GcgBriefData);
      }
      if (IsNewGame != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewGame);
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
      if (gcgBriefData_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GcgBriefData);
      }
      if (IsNewGame != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewGame);
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
      if (gcgBriefData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GcgBriefData);
      }
      if (IsNewGame != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGGameBriefDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.gcgBriefData_ != null) {
        if (gcgBriefData_ == null) {
          GcgBriefData = new global::NewProtos.GCGGameBriefData();
        }
        GcgBriefData.MergeFrom(other.GcgBriefData);
      }
      if (other.IsNewGame != false) {
        IsNewGame = other.IsNewGame;
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
          case 26: {
            if (gcgBriefData_ == null) {
              GcgBriefData = new global::NewProtos.GCGGameBriefData();
            }
            input.ReadMessage(GcgBriefData);
            break;
          }
          case 32: {
            IsNewGame = input.ReadBool();
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
          case 26: {
            if (gcgBriefData_ == null) {
              GcgBriefData = new global::NewProtos.GCGGameBriefData();
            }
            input.ReadMessage(GcgBriefData);
            break;
          }
          case 32: {
            IsNewGame = input.ReadBool();
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
