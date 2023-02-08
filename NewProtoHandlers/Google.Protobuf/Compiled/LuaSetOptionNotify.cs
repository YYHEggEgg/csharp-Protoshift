// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LuaSetOptionNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from LuaSetOptionNotify.proto</summary>
  public static partial class LuaSetOptionNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for LuaSetOptionNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LuaSetOptionNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhMdWFTZXRPcHRpb25Ob3RpZnkucHJvdG8isAEKEkx1YVNldE9wdGlvbk5v",
            "dGlmeRIVCg1sdWFfc2V0X3BhcmFtGAEgASgJEjYKC29wdGlvbl90eXBlGAcg",
            "ASgOMiEuTHVhU2V0T3B0aW9uTm90aWZ5Lkx1YU9wdGlvblR5cGUiSwoNTHVh",
            "T3B0aW9uVHlwZRIYChRMVUFfT1BUSU9OX1RZUEVfTk9ORRAAEiAKHExVQV9P",
            "UFRJT05fVFlQRV9QTEFZRVJfSU5QVVQQAUIMqgIJTmV3UHJvdG9zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.LuaSetOptionNotify), global::NewProtos.LuaSetOptionNotify.Parser, new[]{ "LuaSetParam", "OptionType" }, null, new[]{ typeof(global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 323;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class LuaSetOptionNotify : pb::IMessage<LuaSetOptionNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LuaSetOptionNotify> _parser = new pb::MessageParser<LuaSetOptionNotify>(() => new LuaSetOptionNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LuaSetOptionNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.LuaSetOptionNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuaSetOptionNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuaSetOptionNotify(LuaSetOptionNotify other) : this() {
      luaSetParam_ = other.luaSetParam_;
      optionType_ = other.optionType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LuaSetOptionNotify Clone() {
      return new LuaSetOptionNotify(this);
    }

    /// <summary>Field number for the "lua_set_param" field.</summary>
    public const int LuaSetParamFieldNumber = 1;
    private string luaSetParam_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LuaSetParam {
      get { return luaSetParam_; }
      set {
        luaSetParam_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "option_type" field.</summary>
    public const int OptionTypeFieldNumber = 7;
    private global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType optionType_ = global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType OptionType {
      get { return optionType_; }
      set {
        optionType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LuaSetOptionNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LuaSetOptionNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LuaSetParam != other.LuaSetParam) return false;
      if (OptionType != other.OptionType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LuaSetParam.Length != 0) hash ^= LuaSetParam.GetHashCode();
      if (OptionType != global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType.None) hash ^= OptionType.GetHashCode();
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
      if (LuaSetParam.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LuaSetParam);
      }
      if (OptionType != global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) OptionType);
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
      if (LuaSetParam.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LuaSetParam);
      }
      if (OptionType != global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) OptionType);
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
      if (LuaSetParam.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LuaSetParam);
      }
      if (OptionType != global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OptionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LuaSetOptionNotify other) {
      if (other == null) {
        return;
      }
      if (other.LuaSetParam.Length != 0) {
        LuaSetParam = other.LuaSetParam;
      }
      if (other.OptionType != global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType.None) {
        OptionType = other.OptionType;
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
          case 10: {
            LuaSetParam = input.ReadString();
            break;
          }
          case 56: {
            OptionType = (global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType) input.ReadEnum();
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
            LuaSetParam = input.ReadString();
            break;
          }
          case 56: {
            OptionType = (global::NewProtos.LuaSetOptionNotify.Types.LuaOptionType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LuaSetOptionNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum LuaOptionType {
        [pbr::OriginalName("LUA_OPTION_TYPE_NONE")] None = 0,
        [pbr::OriginalName("LUA_OPTION_TYPE_PLAYER_INPUT")] PlayerInput = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
