// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReunionActivateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ReunionActivateNotify.proto</summary>
  public static partial class ReunionActivateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ReunionActivateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReunionActivateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSZXVuaW9uQWN0aXZhdGVOb3RpZnkucHJvdG8aFlJldW5pb25CcmllZklu",
            "Zm8ucHJvdG8iWwoVUmV1bmlvbkFjdGl2YXRlTm90aWZ5EhMKC2lzX2FjdGl2",
            "YXRlGAkgASgIEi0KEnJldW5pb25fYnJpZWZfaW5mbxgNIAEoCzIRLlJldW5p",
            "b25CcmllZkluZm9CDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ReunionBriefInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ReunionActivateNotify), global::OldProtos.ReunionActivateNotify.Parser, new[]{ "IsActivate", "ReunionBriefInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5085
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ReunionActivateNotify : pb::IMessage<ReunionActivateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReunionActivateNotify> _parser = new pb::MessageParser<ReunionActivateNotify>(() => new ReunionActivateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReunionActivateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ReunionActivateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionActivateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionActivateNotify(ReunionActivateNotify other) : this() {
      isActivate_ = other.isActivate_;
      reunionBriefInfo_ = other.reunionBriefInfo_ != null ? other.reunionBriefInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionActivateNotify Clone() {
      return new ReunionActivateNotify(this);
    }

    /// <summary>Field number for the "is_activate" field.</summary>
    public const int IsActivateFieldNumber = 9;
    private bool isActivate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsActivate {
      get { return isActivate_; }
      set {
        isActivate_ = value;
      }
    }

    /// <summary>Field number for the "reunion_brief_info" field.</summary>
    public const int ReunionBriefInfoFieldNumber = 13;
    private global::OldProtos.ReunionBriefInfo reunionBriefInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ReunionBriefInfo ReunionBriefInfo {
      get { return reunionBriefInfo_; }
      set {
        reunionBriefInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReunionActivateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReunionActivateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsActivate != other.IsActivate) return false;
      if (!object.Equals(ReunionBriefInfo, other.ReunionBriefInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsActivate != false) hash ^= IsActivate.GetHashCode();
      if (reunionBriefInfo_ != null) hash ^= ReunionBriefInfo.GetHashCode();
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
      if (IsActivate != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsActivate);
      }
      if (reunionBriefInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ReunionBriefInfo);
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
      if (IsActivate != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsActivate);
      }
      if (reunionBriefInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ReunionBriefInfo);
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
      if (IsActivate != false) {
        size += 1 + 1;
      }
      if (reunionBriefInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReunionBriefInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReunionActivateNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsActivate != false) {
        IsActivate = other.IsActivate;
      }
      if (other.reunionBriefInfo_ != null) {
        if (reunionBriefInfo_ == null) {
          ReunionBriefInfo = new global::OldProtos.ReunionBriefInfo();
        }
        ReunionBriefInfo.MergeFrom(other.ReunionBriefInfo);
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
          case 72: {
            IsActivate = input.ReadBool();
            break;
          }
          case 106: {
            if (reunionBriefInfo_ == null) {
              ReunionBriefInfo = new global::OldProtos.ReunionBriefInfo();
            }
            input.ReadMessage(ReunionBriefInfo);
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
          case 72: {
            IsActivate = input.ReadBool();
            break;
          }
          case 106: {
            if (reunionBriefInfo_ == null) {
              ReunionBriefInfo = new global::OldProtos.ReunionBriefInfo();
            }
            input.ReadMessage(ReunionBriefInfo);
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
