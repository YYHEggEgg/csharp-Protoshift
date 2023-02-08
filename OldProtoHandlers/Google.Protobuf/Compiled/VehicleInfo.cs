// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VehicleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from VehicleInfo.proto</summary>
  public static partial class VehicleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VehicleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VehicleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFWZWhpY2xlSW5mby5wcm90bxoTVmVoaWNsZU1lbWJlci5wcm90byJaCgtW",
            "ZWhpY2xlSW5mbxIjCgttZW1iZXJfbGlzdBgBIAMoCzIOLlZlaGljbGVNZW1i",
            "ZXISEQoJb3duZXJfdWlkGAIgASgNEhMKC2N1cl9zdGFtaW5hGAMgASgCQgyq",
            "AglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VehicleMemberReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.VehicleInfo), global::OldProtos.VehicleInfo.Parser, new[]{ "MemberList", "OwnerUid", "CurStamina" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VehicleInfo : pb::IMessage<VehicleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VehicleInfo> _parser = new pb::MessageParser<VehicleInfo>(() => new VehicleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VehicleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.VehicleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleInfo(VehicleInfo other) : this() {
      memberList_ = other.memberList_.Clone();
      ownerUid_ = other.ownerUid_;
      curStamina_ = other.curStamina_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleInfo Clone() {
      return new VehicleInfo(this);
    }

    /// <summary>Field number for the "member_list" field.</summary>
    public const int MemberListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::OldProtos.VehicleMember> _repeated_memberList_codec
        = pb::FieldCodec.ForMessage(10, global::OldProtos.VehicleMember.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.VehicleMember> memberList_ = new pbc::RepeatedField<global::OldProtos.VehicleMember>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.VehicleMember> MemberList {
      get { return memberList_; }
    }

    /// <summary>Field number for the "owner_uid" field.</summary>
    public const int OwnerUidFieldNumber = 2;
    private uint ownerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerUid {
      get { return ownerUid_; }
      set {
        ownerUid_ = value;
      }
    }

    /// <summary>Field number for the "cur_stamina" field.</summary>
    public const int CurStaminaFieldNumber = 3;
    private float curStamina_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CurStamina {
      get { return curStamina_; }
      set {
        curStamina_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VehicleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VehicleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!memberList_.Equals(other.memberList_)) return false;
      if (OwnerUid != other.OwnerUid) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CurStamina, other.CurStamina)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= memberList_.GetHashCode();
      if (OwnerUid != 0) hash ^= OwnerUid.GetHashCode();
      if (CurStamina != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CurStamina);
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
      memberList_.WriteTo(output, _repeated_memberList_codec);
      if (OwnerUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerUid);
      }
      if (CurStamina != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(CurStamina);
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
      memberList_.WriteTo(ref output, _repeated_memberList_codec);
      if (OwnerUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerUid);
      }
      if (CurStamina != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(CurStamina);
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
      size += memberList_.CalculateSize(_repeated_memberList_codec);
      if (OwnerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerUid);
      }
      if (CurStamina != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VehicleInfo other) {
      if (other == null) {
        return;
      }
      memberList_.Add(other.memberList_);
      if (other.OwnerUid != 0) {
        OwnerUid = other.OwnerUid;
      }
      if (other.CurStamina != 0F) {
        CurStamina = other.CurStamina;
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
            memberList_.AddEntriesFrom(input, _repeated_memberList_codec);
            break;
          }
          case 16: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 29: {
            CurStamina = input.ReadFloat();
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
            memberList_.AddEntriesFrom(ref input, _repeated_memberList_codec);
            break;
          }
          case 16: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 29: {
            CurStamina = input.ReadFloat();
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
