// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SummerTimeFloatSignalPositionNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SummerTimeFloatSignalPositionNotify.proto</summary>
  public static partial class SummerTimeFloatSignalPositionNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SummerTimeFloatSignalPositionNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SummerTimeFloatSignalPositionNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilTdW1tZXJUaW1lRmxvYXRTaWduYWxQb3NpdGlvbk5vdGlmeS5wcm90bxoM",
            "VmVjdG9yLnByb3RvInUKI1N1bW1lclRpbWVGbG9hdFNpZ25hbFBvc2l0aW9u",
            "Tm90aWZ5EhoKEmlzX3RyYW5zZmVyX2FuY2hvchgGIAEoCBIXCg9mbG9hdF9z",
            "aWduYWxfaWQYDyABKA0SGQoIcG9zaXRpb24YDiABKAsyBy5WZWN0b3JCDKoC",
            "CU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SummerTimeFloatSignalPositionNotify), global::NewProtos.SummerTimeFloatSignalPositionNotify.Parser, new[]{ "IsTransferAnchor", "FloatSignalId", "Position" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8701;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SummerTimeFloatSignalPositionNotify : pb::IMessage<SummerTimeFloatSignalPositionNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SummerTimeFloatSignalPositionNotify> _parser = new pb::MessageParser<SummerTimeFloatSignalPositionNotify>(() => new SummerTimeFloatSignalPositionNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SummerTimeFloatSignalPositionNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SummerTimeFloatSignalPositionNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeFloatSignalPositionNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeFloatSignalPositionNotify(SummerTimeFloatSignalPositionNotify other) : this() {
      isTransferAnchor_ = other.isTransferAnchor_;
      floatSignalId_ = other.floatSignalId_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeFloatSignalPositionNotify Clone() {
      return new SummerTimeFloatSignalPositionNotify(this);
    }

    /// <summary>Field number for the "is_transfer_anchor" field.</summary>
    public const int IsTransferAnchorFieldNumber = 6;
    private bool isTransferAnchor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTransferAnchor {
      get { return isTransferAnchor_; }
      set {
        isTransferAnchor_ = value;
      }
    }

    /// <summary>Field number for the "float_signal_id" field.</summary>
    public const int FloatSignalIdFieldNumber = 15;
    private uint floatSignalId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloatSignalId {
      get { return floatSignalId_; }
      set {
        floatSignalId_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 14;
    private global::NewProtos.Vector position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SummerTimeFloatSignalPositionNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SummerTimeFloatSignalPositionNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsTransferAnchor != other.IsTransferAnchor) return false;
      if (FloatSignalId != other.FloatSignalId) return false;
      if (!object.Equals(Position, other.Position)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsTransferAnchor != false) hash ^= IsTransferAnchor.GetHashCode();
      if (FloatSignalId != 0) hash ^= FloatSignalId.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
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
      if (IsTransferAnchor != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsTransferAnchor);
      }
      if (position_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Position);
      }
      if (FloatSignalId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FloatSignalId);
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
      if (IsTransferAnchor != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsTransferAnchor);
      }
      if (position_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Position);
      }
      if (FloatSignalId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FloatSignalId);
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
      if (IsTransferAnchor != false) {
        size += 1 + 1;
      }
      if (FloatSignalId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloatSignalId);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SummerTimeFloatSignalPositionNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsTransferAnchor != false) {
        IsTransferAnchor = other.IsTransferAnchor;
      }
      if (other.FloatSignalId != 0) {
        FloatSignalId = other.FloatSignalId;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::NewProtos.Vector();
        }
        Position.MergeFrom(other.Position);
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
            IsTransferAnchor = input.ReadBool();
            break;
          }
          case 114: {
            if (position_ == null) {
              Position = new global::NewProtos.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 120: {
            FloatSignalId = input.ReadUInt32();
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
            IsTransferAnchor = input.ReadBool();
            break;
          }
          case 114: {
            if (position_ == null) {
              Position = new global::NewProtos.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 120: {
            FloatSignalId = input.ReadUInt32();
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
