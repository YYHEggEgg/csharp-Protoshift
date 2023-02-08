// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinShootFromCamera.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AbilityMixinShootFromCamera.proto</summary>
  public static partial class AbilityMixinShootFromCameraReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMixinShootFromCamera.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMixinShootFromCameraReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFBYmlsaXR5TWl4aW5TaG9vdEZyb21DYW1lcmEucHJvdG8aDFZlY3Rvci5w",
            "cm90byJSChtBYmlsaXR5TWl4aW5TaG9vdEZyb21DYW1lcmESGQoIaW5pdF9w",
            "b3MYDSABKAsyBy5WZWN0b3ISGAoHZm9yd2FyZBgCIAEoCzIHLlZlY3RvckIM",
            "qgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AbilityMixinShootFromCamera), global::OldProtos.AbilityMixinShootFromCamera.Parser, new[]{ "InitPos", "Forward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMixinShootFromCamera : pb::IMessage<AbilityMixinShootFromCamera>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMixinShootFromCamera> _parser = new pb::MessageParser<AbilityMixinShootFromCamera>(() => new AbilityMixinShootFromCamera());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMixinShootFromCamera> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.AbilityMixinShootFromCameraReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinShootFromCamera() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinShootFromCamera(AbilityMixinShootFromCamera other) : this() {
      initPos_ = other.initPos_ != null ? other.initPos_.Clone() : null;
      forward_ = other.forward_ != null ? other.forward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinShootFromCamera Clone() {
      return new AbilityMixinShootFromCamera(this);
    }

    /// <summary>Field number for the "init_pos" field.</summary>
    public const int InitPosFieldNumber = 13;
    private global::OldProtos.Vector initPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector InitPos {
      get { return initPos_; }
      set {
        initPos_ = value;
      }
    }

    /// <summary>Field number for the "forward" field.</summary>
    public const int ForwardFieldNumber = 2;
    private global::OldProtos.Vector forward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector Forward {
      get { return forward_; }
      set {
        forward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMixinShootFromCamera);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMixinShootFromCamera other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(InitPos, other.InitPos)) return false;
      if (!object.Equals(Forward, other.Forward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (initPos_ != null) hash ^= InitPos.GetHashCode();
      if (forward_ != null) hash ^= Forward.GetHashCode();
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
      if (forward_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Forward);
      }
      if (initPos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(InitPos);
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
      if (forward_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Forward);
      }
      if (initPos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(InitPos);
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
      if (initPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitPos);
      }
      if (forward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Forward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMixinShootFromCamera other) {
      if (other == null) {
        return;
      }
      if (other.initPos_ != null) {
        if (initPos_ == null) {
          InitPos = new global::OldProtos.Vector();
        }
        InitPos.MergeFrom(other.InitPos);
      }
      if (other.forward_ != null) {
        if (forward_ == null) {
          Forward = new global::OldProtos.Vector();
        }
        Forward.MergeFrom(other.Forward);
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
          case 18: {
            if (forward_ == null) {
              Forward = new global::OldProtos.Vector();
            }
            input.ReadMessage(Forward);
            break;
          }
          case 106: {
            if (initPos_ == null) {
              InitPos = new global::OldProtos.Vector();
            }
            input.ReadMessage(InitPos);
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
          case 18: {
            if (forward_ == null) {
              Forward = new global::OldProtos.Vector();
            }
            input.ReadMessage(Forward);
            break;
          }
          case 106: {
            if (initPos_ == null) {
              InitPos = new global::OldProtos.Vector();
            }
            input.ReadMessage(InitPos);
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
