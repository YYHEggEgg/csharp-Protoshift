// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChatInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ChatInfo.proto</summary>
public static partial class ChatInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for ChatInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ChatInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg5DaGF0SW5mby5wcm90byLPAgoIQ2hhdEluZm8SDwoHaXNfcmVhZBgDIAEo",
          "CBIMCgR0aW1lGAEgASgNEg4KBnRvX3VpZBgKIAEoDRILCgN1aWQYCyABKA0S",
          "EAoIc2VxdWVuY2UYBSABKA0SDwoEdGV4dBiNByABKAlIABIPCgRpY29uGN4H",
          "IAEoDUgAEiwKC3N5c3RlbV9oaW50GJ8GIAEoCzIULkNoYXRJbmZvLlN5c3Rl",
          "bUhpbnRIABoaCgpTeXN0ZW1IaW50EgwKBHR5cGUYDyABKA0ifgoOU3lzdGVt",
          "SGludFR5cGUSHgoaU1lTVEVNX0hJTlRfVFlQRV9DSEFUX05PTkUQABIlCiFT",
          "WVNURU1fSElOVF9UWVBFX0NIQVRfRU5URVJfV09STEQQARIlCiFTWVNURU1f",
          "SElOVF9UWVBFX0NIQVRfTEVBVkVfV09STEQQAkIJCgdjb250ZW50QhYKFG9y",
          "Zy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ChatInfo), global::ChatInfo.Parser, new[]{ "IsRead", "Time", "ToUid", "Uid", "Sequence", "Text", "Icon", "SystemHint" }, new[]{ "Content" }, new[]{ typeof(global::ChatInfo.Types.SystemHintType) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::ChatInfo.Types.SystemHint), global::ChatInfo.Types.SystemHint.Parser, new[]{ "Type" }, null, null, null, null)})
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ChatInfo : pb::IMessage<ChatInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ChatInfo> _parser = new pb::MessageParser<ChatInfo>(() => new ChatInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ChatInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ChatInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChatInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChatInfo(ChatInfo other) : this() {
    isRead_ = other.isRead_;
    time_ = other.time_;
    toUid_ = other.toUid_;
    uid_ = other.uid_;
    sequence_ = other.sequence_;
    switch (other.ContentCase) {
      case ContentOneofCase.Text:
        Text = other.Text;
        break;
      case ContentOneofCase.Icon:
        Icon = other.Icon;
        break;
      case ContentOneofCase.SystemHint:
        SystemHint = other.SystemHint.Clone();
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChatInfo Clone() {
    return new ChatInfo(this);
  }

  /// <summary>Field number for the "is_read" field.</summary>
  public const int IsReadFieldNumber = 3;
  private bool isRead_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsRead {
    get { return isRead_; }
    set {
      isRead_ = value;
    }
  }

  /// <summary>Field number for the "time" field.</summary>
  public const int TimeFieldNumber = 1;
  private uint time_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Time {
    get { return time_; }
    set {
      time_ = value;
    }
  }

  /// <summary>Field number for the "to_uid" field.</summary>
  public const int ToUidFieldNumber = 10;
  private uint toUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ToUid {
    get { return toUid_; }
    set {
      toUid_ = value;
    }
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 11;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  /// <summary>Field number for the "sequence" field.</summary>
  public const int SequenceFieldNumber = 5;
  private uint sequence_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Sequence {
    get { return sequence_; }
    set {
      sequence_ = value;
    }
  }

  /// <summary>Field number for the "text" field.</summary>
  public const int TextFieldNumber = 909;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Text {
    get { return contentCase_ == ContentOneofCase.Text ? (string) content_ : ""; }
    set {
      content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      contentCase_ = ContentOneofCase.Text;
    }
  }

  /// <summary>Field number for the "icon" field.</summary>
  public const int IconFieldNumber = 990;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Icon {
    get { return contentCase_ == ContentOneofCase.Icon ? (uint) content_ : 0; }
    set {
      content_ = value;
      contentCase_ = ContentOneofCase.Icon;
    }
  }

  /// <summary>Field number for the "system_hint" field.</summary>
  public const int SystemHintFieldNumber = 799;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ChatInfo.Types.SystemHint SystemHint {
    get { return contentCase_ == ContentOneofCase.SystemHint ? (global::ChatInfo.Types.SystemHint) content_ : null; }
    set {
      content_ = value;
      contentCase_ = value == null ? ContentOneofCase.None : ContentOneofCase.SystemHint;
    }
  }

  private object content_;
  /// <summary>Enum of possible cases for the "content" oneof.</summary>
  public enum ContentOneofCase {
    None = 0,
    Text = 909,
    Icon = 990,
    SystemHint = 799,
  }
  private ContentOneofCase contentCase_ = ContentOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ContentOneofCase ContentCase {
    get { return contentCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearContent() {
    contentCase_ = ContentOneofCase.None;
    content_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ChatInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ChatInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsRead != other.IsRead) return false;
    if (Time != other.Time) return false;
    if (ToUid != other.ToUid) return false;
    if (Uid != other.Uid) return false;
    if (Sequence != other.Sequence) return false;
    if (Text != other.Text) return false;
    if (Icon != other.Icon) return false;
    if (!object.Equals(SystemHint, other.SystemHint)) return false;
    if (ContentCase != other.ContentCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsRead != false) hash ^= IsRead.GetHashCode();
    if (Time != 0) hash ^= Time.GetHashCode();
    if (ToUid != 0) hash ^= ToUid.GetHashCode();
    if (Uid != 0) hash ^= Uid.GetHashCode();
    if (Sequence != 0) hash ^= Sequence.GetHashCode();
    if (contentCase_ == ContentOneofCase.Text) hash ^= Text.GetHashCode();
    if (contentCase_ == ContentOneofCase.Icon) hash ^= Icon.GetHashCode();
    if (contentCase_ == ContentOneofCase.SystemHint) hash ^= SystemHint.GetHashCode();
    hash ^= (int) contentCase_;
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
    if (Time != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Time);
    }
    if (IsRead != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsRead);
    }
    if (Sequence != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Sequence);
    }
    if (ToUid != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(ToUid);
    }
    if (Uid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Uid);
    }
    if (contentCase_ == ContentOneofCase.SystemHint) {
      output.WriteRawTag(250, 49);
      output.WriteMessage(SystemHint);
    }
    if (contentCase_ == ContentOneofCase.Text) {
      output.WriteRawTag(234, 56);
      output.WriteString(Text);
    }
    if (contentCase_ == ContentOneofCase.Icon) {
      output.WriteRawTag(240, 61);
      output.WriteUInt32(Icon);
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
    if (Time != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Time);
    }
    if (IsRead != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsRead);
    }
    if (Sequence != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Sequence);
    }
    if (ToUid != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(ToUid);
    }
    if (Uid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Uid);
    }
    if (contentCase_ == ContentOneofCase.SystemHint) {
      output.WriteRawTag(250, 49);
      output.WriteMessage(SystemHint);
    }
    if (contentCase_ == ContentOneofCase.Text) {
      output.WriteRawTag(234, 56);
      output.WriteString(Text);
    }
    if (contentCase_ == ContentOneofCase.Icon) {
      output.WriteRawTag(240, 61);
      output.WriteUInt32(Icon);
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
    if (IsRead != false) {
      size += 1 + 1;
    }
    if (Time != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Time);
    }
    if (ToUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ToUid);
    }
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    if (Sequence != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Sequence);
    }
    if (contentCase_ == ContentOneofCase.Text) {
      size += 2 + pb::CodedOutputStream.ComputeStringSize(Text);
    }
    if (contentCase_ == ContentOneofCase.Icon) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Icon);
    }
    if (contentCase_ == ContentOneofCase.SystemHint) {
      size += 2 + pb::CodedOutputStream.ComputeMessageSize(SystemHint);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ChatInfo other) {
    if (other == null) {
      return;
    }
    if (other.IsRead != false) {
      IsRead = other.IsRead;
    }
    if (other.Time != 0) {
      Time = other.Time;
    }
    if (other.ToUid != 0) {
      ToUid = other.ToUid;
    }
    if (other.Uid != 0) {
      Uid = other.Uid;
    }
    if (other.Sequence != 0) {
      Sequence = other.Sequence;
    }
    switch (other.ContentCase) {
      case ContentOneofCase.Text:
        Text = other.Text;
        break;
      case ContentOneofCase.Icon:
        Icon = other.Icon;
        break;
      case ContentOneofCase.SystemHint:
        if (SystemHint == null) {
          SystemHint = new global::ChatInfo.Types.SystemHint();
        }
        SystemHint.MergeFrom(other.SystemHint);
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
        case 8: {
          Time = input.ReadUInt32();
          break;
        }
        case 24: {
          IsRead = input.ReadBool();
          break;
        }
        case 40: {
          Sequence = input.ReadUInt32();
          break;
        }
        case 80: {
          ToUid = input.ReadUInt32();
          break;
        }
        case 88: {
          Uid = input.ReadUInt32();
          break;
        }
        case 6394: {
          global::ChatInfo.Types.SystemHint subBuilder = new global::ChatInfo.Types.SystemHint();
          if (contentCase_ == ContentOneofCase.SystemHint) {
            subBuilder.MergeFrom(SystemHint);
          }
          input.ReadMessage(subBuilder);
          SystemHint = subBuilder;
          break;
        }
        case 7274: {
          Text = input.ReadString();
          break;
        }
        case 7920: {
          Icon = input.ReadUInt32();
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
          Time = input.ReadUInt32();
          break;
        }
        case 24: {
          IsRead = input.ReadBool();
          break;
        }
        case 40: {
          Sequence = input.ReadUInt32();
          break;
        }
        case 80: {
          ToUid = input.ReadUInt32();
          break;
        }
        case 88: {
          Uid = input.ReadUInt32();
          break;
        }
        case 6394: {
          global::ChatInfo.Types.SystemHint subBuilder = new global::ChatInfo.Types.SystemHint();
          if (contentCase_ == ContentOneofCase.SystemHint) {
            subBuilder.MergeFrom(SystemHint);
          }
          input.ReadMessage(subBuilder);
          SystemHint = subBuilder;
          break;
        }
        case 7274: {
          Text = input.ReadString();
          break;
        }
        case 7920: {
          Icon = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the ChatInfo message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum SystemHintType {
      [pbr::OriginalName("SYSTEM_HINT_TYPE_CHAT_NONE")] ChatNone = 0,
      [pbr::OriginalName("SYSTEM_HINT_TYPE_CHAT_ENTER_WORLD")] ChatEnterWorld = 1,
      [pbr::OriginalName("SYSTEM_HINT_TYPE_CHAT_LEAVE_WORLD")] ChatLeaveWorld = 2,
    }

    public sealed partial class SystemHint : pb::IMessage<SystemHint>
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , pb::IBufferMessage
    #endif
    {
      private static readonly pb::MessageParser<SystemHint> _parser = new pb::MessageParser<SystemHint>(() => new SystemHint());
      private pb::UnknownFieldSet _unknownFields;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pb::MessageParser<SystemHint> Parser { get { return _parser; } }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public static pbr::MessageDescriptor Descriptor {
        get { return global::ChatInfo.Descriptor.NestedTypes[0]; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public SystemHint() {
        OnConstruction();
      }

      partial void OnConstruction();

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public SystemHint(SystemHint other) : this() {
        type_ = other.type_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public SystemHint Clone() {
        return new SystemHint(this);
      }

      /// <summary>Field number for the "type" field.</summary>
      public const int TypeFieldNumber = 15;
      private uint type_;
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public uint Type {
        get { return type_; }
        set {
          type_ = value;
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override bool Equals(object other) {
        return Equals(other as SystemHint);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public bool Equals(SystemHint other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if (Type != other.Type) return false;
        return Equals(_unknownFields, other._unknownFields);
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public override int GetHashCode() {
        int hash = 1;
        if (Type != 0) hash ^= Type.GetHashCode();
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
        if (Type != 0) {
          output.WriteRawTag(120);
          output.WriteUInt32(Type);
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
        if (Type != 0) {
          output.WriteRawTag(120);
          output.WriteUInt32(Type);
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
        if (Type != 0) {
          size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
        }
        if (_unknownFields != null) {
          size += _unknownFields.CalculateSize();
        }
        return size;
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
      [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
      public void MergeFrom(SystemHint other) {
        if (other == null) {
          return;
        }
        if (other.Type != 0) {
          Type = other.Type;
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
            case 120: {
              Type = input.ReadUInt32();
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
            case 120: {
              Type = input.ReadUInt32();
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


#endregion Designer generated code
