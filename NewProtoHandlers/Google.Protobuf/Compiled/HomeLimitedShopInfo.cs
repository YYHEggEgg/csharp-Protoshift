// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeLimitedShopInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from HomeLimitedShopInfo.proto</summary>
  public static partial class HomeLimitedShopInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeLimitedShopInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeLimitedShopInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlIb21lTGltaXRlZFNob3BJbmZvLnByb3RvGgxWZWN0b3IucHJvdG8iqQEK",
            "E0hvbWVMaW1pdGVkU2hvcEluZm8SCwoDdWlkGAkgASgNEhwKFG5leHRfZ3Vl",
            "c3Rfb3Blbl90aW1lGAggASgHEhoKCWRqaW5uX3JvdBgLIAEoCzIHLlZlY3Rv",
            "chIWCg5uZXh0X29wZW5fdGltZRgFIAEoBxIaCglkamlubl9wb3MYAiABKAsy",
            "By5WZWN0b3ISFwoPbmV4dF9jbG9zZV90aW1lGA8gASgHQgyqAglOZXdQcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.HomeLimitedShopInfo), global::NewProtos.HomeLimitedShopInfo.Parser, new[]{ "Uid", "NextGuestOpenTime", "DjinnRot", "NextOpenTime", "DjinnPos", "NextCloseTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeLimitedShopInfo : pb::IMessage<HomeLimitedShopInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeLimitedShopInfo> _parser = new pb::MessageParser<HomeLimitedShopInfo>(() => new HomeLimitedShopInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeLimitedShopInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.HomeLimitedShopInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfo(HomeLimitedShopInfo other) : this() {
      uid_ = other.uid_;
      nextGuestOpenTime_ = other.nextGuestOpenTime_;
      djinnRot_ = other.djinnRot_ != null ? other.djinnRot_.Clone() : null;
      nextOpenTime_ = other.nextOpenTime_;
      djinnPos_ = other.djinnPos_ != null ? other.djinnPos_.Clone() : null;
      nextCloseTime_ = other.nextCloseTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfo Clone() {
      return new HomeLimitedShopInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 9;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "next_guest_open_time" field.</summary>
    public const int NextGuestOpenTimeFieldNumber = 8;
    private uint nextGuestOpenTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextGuestOpenTime {
      get { return nextGuestOpenTime_; }
      set {
        nextGuestOpenTime_ = value;
      }
    }

    /// <summary>Field number for the "djinn_rot" field.</summary>
    public const int DjinnRotFieldNumber = 11;
    private global::NewProtos.Vector djinnRot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector DjinnRot {
      get { return djinnRot_; }
      set {
        djinnRot_ = value;
      }
    }

    /// <summary>Field number for the "next_open_time" field.</summary>
    public const int NextOpenTimeFieldNumber = 5;
    private uint nextOpenTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextOpenTime {
      get { return nextOpenTime_; }
      set {
        nextOpenTime_ = value;
      }
    }

    /// <summary>Field number for the "djinn_pos" field.</summary>
    public const int DjinnPosFieldNumber = 2;
    private global::NewProtos.Vector djinnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector DjinnPos {
      get { return djinnPos_; }
      set {
        djinnPos_ = value;
      }
    }

    /// <summary>Field number for the "next_close_time" field.</summary>
    public const int NextCloseTimeFieldNumber = 15;
    private uint nextCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextCloseTime {
      get { return nextCloseTime_; }
      set {
        nextCloseTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeLimitedShopInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeLimitedShopInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (NextGuestOpenTime != other.NextGuestOpenTime) return false;
      if (!object.Equals(DjinnRot, other.DjinnRot)) return false;
      if (NextOpenTime != other.NextOpenTime) return false;
      if (!object.Equals(DjinnPos, other.DjinnPos)) return false;
      if (NextCloseTime != other.NextCloseTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (NextGuestOpenTime != 0) hash ^= NextGuestOpenTime.GetHashCode();
      if (djinnRot_ != null) hash ^= DjinnRot.GetHashCode();
      if (NextOpenTime != 0) hash ^= NextOpenTime.GetHashCode();
      if (djinnPos_ != null) hash ^= DjinnPos.GetHashCode();
      if (NextCloseTime != 0) hash ^= NextCloseTime.GetHashCode();
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
      if (djinnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DjinnPos);
      }
      if (NextOpenTime != 0) {
        output.WriteRawTag(45);
        output.WriteFixed32(NextOpenTime);
      }
      if (NextGuestOpenTime != 0) {
        output.WriteRawTag(69);
        output.WriteFixed32(NextGuestOpenTime);
      }
      if (Uid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Uid);
      }
      if (djinnRot_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DjinnRot);
      }
      if (NextCloseTime != 0) {
        output.WriteRawTag(125);
        output.WriteFixed32(NextCloseTime);
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
      if (djinnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DjinnPos);
      }
      if (NextOpenTime != 0) {
        output.WriteRawTag(45);
        output.WriteFixed32(NextOpenTime);
      }
      if (NextGuestOpenTime != 0) {
        output.WriteRawTag(69);
        output.WriteFixed32(NextGuestOpenTime);
      }
      if (Uid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Uid);
      }
      if (djinnRot_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DjinnRot);
      }
      if (NextCloseTime != 0) {
        output.WriteRawTag(125);
        output.WriteFixed32(NextCloseTime);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (NextGuestOpenTime != 0) {
        size += 1 + 4;
      }
      if (djinnRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DjinnRot);
      }
      if (NextOpenTime != 0) {
        size += 1 + 4;
      }
      if (djinnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DjinnPos);
      }
      if (NextCloseTime != 0) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeLimitedShopInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.NextGuestOpenTime != 0) {
        NextGuestOpenTime = other.NextGuestOpenTime;
      }
      if (other.djinnRot_ != null) {
        if (djinnRot_ == null) {
          DjinnRot = new global::NewProtos.Vector();
        }
        DjinnRot.MergeFrom(other.DjinnRot);
      }
      if (other.NextOpenTime != 0) {
        NextOpenTime = other.NextOpenTime;
      }
      if (other.djinnPos_ != null) {
        if (djinnPos_ == null) {
          DjinnPos = new global::NewProtos.Vector();
        }
        DjinnPos.MergeFrom(other.DjinnPos);
      }
      if (other.NextCloseTime != 0) {
        NextCloseTime = other.NextCloseTime;
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
            if (djinnPos_ == null) {
              DjinnPos = new global::NewProtos.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 45: {
            NextOpenTime = input.ReadFixed32();
            break;
          }
          case 69: {
            NextGuestOpenTime = input.ReadFixed32();
            break;
          }
          case 72: {
            Uid = input.ReadUInt32();
            break;
          }
          case 90: {
            if (djinnRot_ == null) {
              DjinnRot = new global::NewProtos.Vector();
            }
            input.ReadMessage(DjinnRot);
            break;
          }
          case 125: {
            NextCloseTime = input.ReadFixed32();
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
            if (djinnPos_ == null) {
              DjinnPos = new global::NewProtos.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 45: {
            NextOpenTime = input.ReadFixed32();
            break;
          }
          case 69: {
            NextGuestOpenTime = input.ReadFixed32();
            break;
          }
          case 72: {
            Uid = input.ReadUInt32();
            break;
          }
          case 90: {
            if (djinnRot_ == null) {
              DjinnRot = new global::NewProtos.Vector();
            }
            input.ReadMessage(DjinnRot);
            break;
          }
          case 125: {
            NextCloseTime = input.ReadFixed32();
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
