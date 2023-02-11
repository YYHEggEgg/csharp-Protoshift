// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGControllerShowInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GCGControllerShowInfo.proto</summary>
  public static partial class GCGControllerShowInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGControllerShowInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGControllerShowInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHQ0dDb250cm9sbGVyU2hvd0luZm8ucHJvdG8aFFByb2ZpbGVQaWN0dXJl",
            "LnByb3RvIo4BChVHQ0dDb250cm9sbGVyU2hvd0luZm8SDgoGcHNuX2lkGAwg",
            "ASgJEhEKCW5pY2tfbmFtZRgKIAEoCRIRCglvbmxpbmVfaWQYDyABKAkSKAoP",
            "cHJvZmlsZV9waWN0dXJlGAMgASgLMg8uUHJvZmlsZVBpY3R1cmUSFQoNY29u",
            "dHJvbGxlcl9pZBgLIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GCGControllerShowInfo), global::NewProtos.GCGControllerShowInfo.Parser, new[]{ "PsnId", "NickName", "OnlineId", "ProfilePicture", "ControllerId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGControllerShowInfo : pb::IMessage<GCGControllerShowInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGControllerShowInfo> _parser = new pb::MessageParser<GCGControllerShowInfo>(() => new GCGControllerShowInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGControllerShowInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GCGControllerShowInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGControllerShowInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGControllerShowInfo(GCGControllerShowInfo other) : this() {
      psnId_ = other.psnId_;
      nickName_ = other.nickName_;
      onlineId_ = other.onlineId_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      controllerId_ = other.controllerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGControllerShowInfo Clone() {
      return new GCGControllerShowInfo(this);
    }

    /// <summary>Field number for the "psn_id" field.</summary>
    public const int PsnIdFieldNumber = 12;
    private string psnId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PsnId {
      get { return psnId_; }
      set {
        psnId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nick_name" field.</summary>
    public const int NickNameFieldNumber = 10;
    private string nickName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NickName {
      get { return nickName_; }
      set {
        nickName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "online_id" field.</summary>
    public const int OnlineIdFieldNumber = 15;
    private string onlineId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OnlineId {
      get { return onlineId_; }
      set {
        onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 3;
    private global::NewProtos.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 11;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGControllerShowInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGControllerShowInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PsnId != other.PsnId) return false;
      if (NickName != other.NickName) return false;
      if (OnlineId != other.OnlineId) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (ControllerId != other.ControllerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PsnId.Length != 0) hash ^= PsnId.GetHashCode();
      if (NickName.Length != 0) hash ^= NickName.GetHashCode();
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
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
      if (profilePicture_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfilePicture);
      }
      if (NickName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(NickName);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ControllerId);
      }
      if (PsnId.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(PsnId);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(OnlineId);
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
      if (profilePicture_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProfilePicture);
      }
      if (NickName.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(NickName);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ControllerId);
      }
      if (PsnId.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(PsnId);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(OnlineId);
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
      if (PsnId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PsnId);
      }
      if (NickName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NickName);
      }
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGControllerShowInfo other) {
      if (other == null) {
        return;
      }
      if (other.PsnId.Length != 0) {
        PsnId = other.PsnId;
      }
      if (other.NickName.Length != 0) {
        NickName = other.NickName;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::NewProtos.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
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
            if (profilePicture_ == null) {
              ProfilePicture = new global::NewProtos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 82: {
            NickName = input.ReadString();
            break;
          }
          case 88: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 98: {
            PsnId = input.ReadString();
            break;
          }
          case 122: {
            OnlineId = input.ReadString();
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
            if (profilePicture_ == null) {
              ProfilePicture = new global::NewProtos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 82: {
            NickName = input.ReadString();
            break;
          }
          case 88: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 98: {
            PsnId = input.ReadString();
            break;
          }
          case 122: {
            OnlineId = input.ReadString();
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