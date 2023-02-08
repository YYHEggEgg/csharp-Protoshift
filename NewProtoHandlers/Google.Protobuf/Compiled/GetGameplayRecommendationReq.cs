// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetGameplayRecommendationReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GetGameplayRecommendationReq.proto</summary>
  public static partial class GetGameplayRecommendationReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetGameplayRecommendationReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetGameplayRecommendationReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJHZXRHYW1lcGxheVJlY29tbWVuZGF0aW9uUmVxLnByb3RvGjNHYW1lcGxh",
            "eVJlY29tbWVuZGF0aW9uRWxlbWVudFJlbGlxdWFyeVJlcXVlc3QucHJvdG8a",
            "LEdhbWVwbGF5UmVjb21tZW5kYXRpb25SZWxpcXVhcnlSZXF1ZXN0LnByb3Rv",
            "GihHYW1lcGxheVJlY29tbWVuZGF0aW9uU2tpbGxSZXF1ZXN0LnByb3RvIpYC",
            "ChxHZXRHYW1lcGxheVJlY29tbWVuZGF0aW9uUmVxEhEKCWF2YXRhcl9pZBgG",
            "IAEoDRI9Cg1za2lsbF9yZXF1ZXN0GJ4MIAEoCzIjLkdhbWVwbGF5UmVjb21t",
            "ZW5kYXRpb25Ta2lsbFJlcXVlc3RIABJEChFyZWxpcXVhcnlfcmVxdWVzdBhI",
            "IAEoCzInLkdhbWVwbGF5UmVjb21tZW5kYXRpb25SZWxpcXVhcnlSZXF1ZXN0",
            "SAASVAoZZWxlbWVudF9yZWxpcXVhcnlfcmVxdWVzdBjjBiABKAsyLi5HYW1l",
            "cGxheVJlY29tbWVuZGF0aW9uRWxlbWVudFJlbGlxdWFyeVJlcXVlc3RIAEII",
            "CgZkZXRhaWxCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GameplayRecommendationElementReliquaryRequestReflection.Descriptor, global::NewProtos.GameplayRecommendationReliquaryRequestReflection.Descriptor, global::NewProtos.GameplayRecommendationSkillRequestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GetGameplayRecommendationReq), global::NewProtos.GetGameplayRecommendationReq.Parser, new[]{ "AvatarId", "SkillRequest", "ReliquaryRequest", "ElementReliquaryRequest" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 155;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class GetGameplayRecommendationReq : pb::IMessage<GetGameplayRecommendationReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetGameplayRecommendationReq> _parser = new pb::MessageParser<GetGameplayRecommendationReq>(() => new GetGameplayRecommendationReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetGameplayRecommendationReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GetGameplayRecommendationReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGameplayRecommendationReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGameplayRecommendationReq(GetGameplayRecommendationReq other) : this() {
      avatarId_ = other.avatarId_;
      switch (other.DetailCase) {
        case DetailOneofCase.SkillRequest:
          SkillRequest = other.SkillRequest.Clone();
          break;
        case DetailOneofCase.ReliquaryRequest:
          ReliquaryRequest = other.ReliquaryRequest.Clone();
          break;
        case DetailOneofCase.ElementReliquaryRequest:
          ElementReliquaryRequest = other.ElementReliquaryRequest.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGameplayRecommendationReq Clone() {
      return new GetGameplayRecommendationReq(this);
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 6;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "skill_request" field.</summary>
    public const int SkillRequestFieldNumber = 1566;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GameplayRecommendationSkillRequest SkillRequest {
      get { return detailCase_ == DetailOneofCase.SkillRequest ? (global::NewProtos.GameplayRecommendationSkillRequest) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.SkillRequest;
      }
    }

    /// <summary>Field number for the "reliquary_request" field.</summary>
    public const int ReliquaryRequestFieldNumber = 72;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GameplayRecommendationReliquaryRequest ReliquaryRequest {
      get { return detailCase_ == DetailOneofCase.ReliquaryRequest ? (global::NewProtos.GameplayRecommendationReliquaryRequest) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.ReliquaryRequest;
      }
    }

    /// <summary>Field number for the "element_reliquary_request" field.</summary>
    public const int ElementReliquaryRequestFieldNumber = 867;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GameplayRecommendationElementReliquaryRequest ElementReliquaryRequest {
      get { return detailCase_ == DetailOneofCase.ElementReliquaryRequest ? (global::NewProtos.GameplayRecommendationElementReliquaryRequest) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.ElementReliquaryRequest;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      SkillRequest = 1566,
      ReliquaryRequest = 72,
      ElementReliquaryRequest = 867,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetGameplayRecommendationReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetGameplayRecommendationReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if (!object.Equals(SkillRequest, other.SkillRequest)) return false;
      if (!object.Equals(ReliquaryRequest, other.ReliquaryRequest)) return false;
      if (!object.Equals(ElementReliquaryRequest, other.ElementReliquaryRequest)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (detailCase_ == DetailOneofCase.SkillRequest) hash ^= SkillRequest.GetHashCode();
      if (detailCase_ == DetailOneofCase.ReliquaryRequest) hash ^= ReliquaryRequest.GetHashCode();
      if (detailCase_ == DetailOneofCase.ElementReliquaryRequest) hash ^= ElementReliquaryRequest.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (AvatarId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarId);
      }
      if (detailCase_ == DetailOneofCase.ReliquaryRequest) {
        output.WriteRawTag(194, 4);
        output.WriteMessage(ReliquaryRequest);
      }
      if (detailCase_ == DetailOneofCase.ElementReliquaryRequest) {
        output.WriteRawTag(154, 54);
        output.WriteMessage(ElementReliquaryRequest);
      }
      if (detailCase_ == DetailOneofCase.SkillRequest) {
        output.WriteRawTag(242, 97);
        output.WriteMessage(SkillRequest);
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
      if (AvatarId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AvatarId);
      }
      if (detailCase_ == DetailOneofCase.ReliquaryRequest) {
        output.WriteRawTag(194, 4);
        output.WriteMessage(ReliquaryRequest);
      }
      if (detailCase_ == DetailOneofCase.ElementReliquaryRequest) {
        output.WriteRawTag(154, 54);
        output.WriteMessage(ElementReliquaryRequest);
      }
      if (detailCase_ == DetailOneofCase.SkillRequest) {
        output.WriteRawTag(242, 97);
        output.WriteMessage(SkillRequest);
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
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (detailCase_ == DetailOneofCase.SkillRequest) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SkillRequest);
      }
      if (detailCase_ == DetailOneofCase.ReliquaryRequest) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ReliquaryRequest);
      }
      if (detailCase_ == DetailOneofCase.ElementReliquaryRequest) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ElementReliquaryRequest);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetGameplayRecommendationReq other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.SkillRequest:
          if (SkillRequest == null) {
            SkillRequest = new global::NewProtos.GameplayRecommendationSkillRequest();
          }
          SkillRequest.MergeFrom(other.SkillRequest);
          break;
        case DetailOneofCase.ReliquaryRequest:
          if (ReliquaryRequest == null) {
            ReliquaryRequest = new global::NewProtos.GameplayRecommendationReliquaryRequest();
          }
          ReliquaryRequest.MergeFrom(other.ReliquaryRequest);
          break;
        case DetailOneofCase.ElementReliquaryRequest:
          if (ElementReliquaryRequest == null) {
            ElementReliquaryRequest = new global::NewProtos.GameplayRecommendationElementReliquaryRequest();
          }
          ElementReliquaryRequest.MergeFrom(other.ElementReliquaryRequest);
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
          case 48: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 578: {
            global::NewProtos.GameplayRecommendationReliquaryRequest subBuilder = new global::NewProtos.GameplayRecommendationReliquaryRequest();
            if (detailCase_ == DetailOneofCase.ReliquaryRequest) {
              subBuilder.MergeFrom(ReliquaryRequest);
            }
            input.ReadMessage(subBuilder);
            ReliquaryRequest = subBuilder;
            break;
          }
          case 6938: {
            global::NewProtos.GameplayRecommendationElementReliquaryRequest subBuilder = new global::NewProtos.GameplayRecommendationElementReliquaryRequest();
            if (detailCase_ == DetailOneofCase.ElementReliquaryRequest) {
              subBuilder.MergeFrom(ElementReliquaryRequest);
            }
            input.ReadMessage(subBuilder);
            ElementReliquaryRequest = subBuilder;
            break;
          }
          case 12530: {
            global::NewProtos.GameplayRecommendationSkillRequest subBuilder = new global::NewProtos.GameplayRecommendationSkillRequest();
            if (detailCase_ == DetailOneofCase.SkillRequest) {
              subBuilder.MergeFrom(SkillRequest);
            }
            input.ReadMessage(subBuilder);
            SkillRequest = subBuilder;
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 578: {
            global::NewProtos.GameplayRecommendationReliquaryRequest subBuilder = new global::NewProtos.GameplayRecommendationReliquaryRequest();
            if (detailCase_ == DetailOneofCase.ReliquaryRequest) {
              subBuilder.MergeFrom(ReliquaryRequest);
            }
            input.ReadMessage(subBuilder);
            ReliquaryRequest = subBuilder;
            break;
          }
          case 6938: {
            global::NewProtos.GameplayRecommendationElementReliquaryRequest subBuilder = new global::NewProtos.GameplayRecommendationElementReliquaryRequest();
            if (detailCase_ == DetailOneofCase.ElementReliquaryRequest) {
              subBuilder.MergeFrom(ElementReliquaryRequest);
            }
            input.ReadMessage(subBuilder);
            ElementReliquaryRequest = subBuilder;
            break;
          }
          case 12530: {
            global::NewProtos.GameplayRecommendationSkillRequest subBuilder = new global::NewProtos.GameplayRecommendationSkillRequest();
            if (detailCase_ == DetailOneofCase.SkillRequest) {
              subBuilder.MergeFrom(SkillRequest);
            }
            input.ReadMessage(subBuilder);
            SkillRequest = subBuilder;
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
