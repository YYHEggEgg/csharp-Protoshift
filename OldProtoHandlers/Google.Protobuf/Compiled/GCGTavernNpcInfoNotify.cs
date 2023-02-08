// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGTavernNpcInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GCGTavernNpcInfoNotify.proto</summary>
  public static partial class GCGTavernNpcInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGTavernNpcInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGTavernNpcInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHQ0dUYXZlcm5OcGNJbmZvTm90aWZ5LnByb3RvGhZHQ0dUYXZlcm5OcGNJ",
            "bmZvLnByb3RvIpcBChZHQ0dUYXZlcm5OcGNJbmZvTm90aWZ5EigKDXdlZWtf",
            "bnBjX2xpc3QYASADKAsyES5HQ0dUYXZlcm5OcGNJbmZvEigKDWNoYXJhY3Rl",
            "cl9ucGMYBSABKAsyES5HQ0dUYXZlcm5OcGNJbmZvEikKDmNvbnN0X25wY19s",
            "aXN0GA8gAygLMhEuR0NHVGF2ZXJuTnBjSW5mb0IMqgIJT2xkUHJvdG9zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.GCGTavernNpcInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GCGTavernNpcInfoNotify), global::OldProtos.GCGTavernNpcInfoNotify.Parser, new[]{ "WeekNpcList", "CharacterNpc", "ConstNpcList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 7290
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GCGTavernNpcInfoNotify : pb::IMessage<GCGTavernNpcInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGTavernNpcInfoNotify> _parser = new pb::MessageParser<GCGTavernNpcInfoNotify>(() => new GCGTavernNpcInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGTavernNpcInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GCGTavernNpcInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGTavernNpcInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGTavernNpcInfoNotify(GCGTavernNpcInfoNotify other) : this() {
      weekNpcList_ = other.weekNpcList_.Clone();
      characterNpc_ = other.characterNpc_ != null ? other.characterNpc_.Clone() : null;
      constNpcList_ = other.constNpcList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGTavernNpcInfoNotify Clone() {
      return new GCGTavernNpcInfoNotify(this);
    }

    /// <summary>Field number for the "week_npc_list" field.</summary>
    public const int WeekNpcListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::OldProtos.GCGTavernNpcInfo> _repeated_weekNpcList_codec
        = pb::FieldCodec.ForMessage(10, global::OldProtos.GCGTavernNpcInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.GCGTavernNpcInfo> weekNpcList_ = new pbc::RepeatedField<global::OldProtos.GCGTavernNpcInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.GCGTavernNpcInfo> WeekNpcList {
      get { return weekNpcList_; }
    }

    /// <summary>Field number for the "character_npc" field.</summary>
    public const int CharacterNpcFieldNumber = 5;
    private global::OldProtos.GCGTavernNpcInfo characterNpc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.GCGTavernNpcInfo CharacterNpc {
      get { return characterNpc_; }
      set {
        characterNpc_ = value;
      }
    }

    /// <summary>Field number for the "const_npc_list" field.</summary>
    public const int ConstNpcListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::OldProtos.GCGTavernNpcInfo> _repeated_constNpcList_codec
        = pb::FieldCodec.ForMessage(122, global::OldProtos.GCGTavernNpcInfo.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.GCGTavernNpcInfo> constNpcList_ = new pbc::RepeatedField<global::OldProtos.GCGTavernNpcInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.GCGTavernNpcInfo> ConstNpcList {
      get { return constNpcList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGTavernNpcInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGTavernNpcInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!weekNpcList_.Equals(other.weekNpcList_)) return false;
      if (!object.Equals(CharacterNpc, other.CharacterNpc)) return false;
      if(!constNpcList_.Equals(other.constNpcList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= weekNpcList_.GetHashCode();
      if (characterNpc_ != null) hash ^= CharacterNpc.GetHashCode();
      hash ^= constNpcList_.GetHashCode();
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
      weekNpcList_.WriteTo(output, _repeated_weekNpcList_codec);
      if (characterNpc_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CharacterNpc);
      }
      constNpcList_.WriteTo(output, _repeated_constNpcList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      weekNpcList_.WriteTo(ref output, _repeated_weekNpcList_codec);
      if (characterNpc_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CharacterNpc);
      }
      constNpcList_.WriteTo(ref output, _repeated_constNpcList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += weekNpcList_.CalculateSize(_repeated_weekNpcList_codec);
      if (characterNpc_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CharacterNpc);
      }
      size += constNpcList_.CalculateSize(_repeated_constNpcList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGTavernNpcInfoNotify other) {
      if (other == null) {
        return;
      }
      weekNpcList_.Add(other.weekNpcList_);
      if (other.characterNpc_ != null) {
        if (characterNpc_ == null) {
          CharacterNpc = new global::OldProtos.GCGTavernNpcInfo();
        }
        CharacterNpc.MergeFrom(other.CharacterNpc);
      }
      constNpcList_.Add(other.constNpcList_);
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
            weekNpcList_.AddEntriesFrom(input, _repeated_weekNpcList_codec);
            break;
          }
          case 42: {
            if (characterNpc_ == null) {
              CharacterNpc = new global::OldProtos.GCGTavernNpcInfo();
            }
            input.ReadMessage(CharacterNpc);
            break;
          }
          case 122: {
            constNpcList_.AddEntriesFrom(input, _repeated_constNpcList_codec);
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
            weekNpcList_.AddEntriesFrom(ref input, _repeated_weekNpcList_codec);
            break;
          }
          case 42: {
            if (characterNpc_ == null) {
              CharacterNpc = new global::OldProtos.GCGTavernNpcInfo();
            }
            input.ReadMessage(CharacterNpc);
            break;
          }
          case 122: {
            constNpcList_.AddEntriesFrom(ref input, _repeated_constNpcList_codec);
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
