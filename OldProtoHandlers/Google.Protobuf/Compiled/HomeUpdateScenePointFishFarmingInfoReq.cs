// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeUpdateScenePointFishFarmingInfoReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from HomeUpdateScenePointFishFarmingInfoReq.proto</summary>
  public static partial class HomeUpdateScenePointFishFarmingInfoReqReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeUpdateScenePointFishFarmingInfoReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeUpdateScenePointFishFarmingInfoReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixIb21lVXBkYXRlU2NlbmVQb2ludEZpc2hGYXJtaW5nSW5mb1JlcS5wcm90",
            "bxojSG9tZVNjZW5lUG9pbnRGaXNoRmFybWluZ0luZm8ucHJvdG8iYwomSG9t",
            "ZVVwZGF0ZVNjZW5lUG9pbnRGaXNoRmFybWluZ0luZm9SZXESOQoRZmlzaF9m",
            "YXJtaW5nX2luZm8YByABKAsyHi5Ib21lU2NlbmVQb2ludEZpc2hGYXJtaW5n",
            "SW5mb0IMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.HomeScenePointFishFarmingInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.HomeUpdateScenePointFishFarmingInfoReq), global::OldProtos.HomeUpdateScenePointFishFarmingInfoReq.Parser, new[]{ "FishFarmingInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4511
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class HomeUpdateScenePointFishFarmingInfoReq : pb::IMessage<HomeUpdateScenePointFishFarmingInfoReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeUpdateScenePointFishFarmingInfoReq> _parser = new pb::MessageParser<HomeUpdateScenePointFishFarmingInfoReq>(() => new HomeUpdateScenePointFishFarmingInfoReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeUpdateScenePointFishFarmingInfoReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.HomeUpdateScenePointFishFarmingInfoReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeUpdateScenePointFishFarmingInfoReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeUpdateScenePointFishFarmingInfoReq(HomeUpdateScenePointFishFarmingInfoReq other) : this() {
      fishFarmingInfo_ = other.fishFarmingInfo_ != null ? other.fishFarmingInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeUpdateScenePointFishFarmingInfoReq Clone() {
      return new HomeUpdateScenePointFishFarmingInfoReq(this);
    }

    /// <summary>Field number for the "fish_farming_info" field.</summary>
    public const int FishFarmingInfoFieldNumber = 7;
    private global::OldProtos.HomeScenePointFishFarmingInfo fishFarmingInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.HomeScenePointFishFarmingInfo FishFarmingInfo {
      get { return fishFarmingInfo_; }
      set {
        fishFarmingInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeUpdateScenePointFishFarmingInfoReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeUpdateScenePointFishFarmingInfoReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FishFarmingInfo, other.FishFarmingInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (fishFarmingInfo_ != null) hash ^= FishFarmingInfo.GetHashCode();
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
      if (fishFarmingInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FishFarmingInfo);
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
      if (fishFarmingInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FishFarmingInfo);
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
      if (fishFarmingInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FishFarmingInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeUpdateScenePointFishFarmingInfoReq other) {
      if (other == null) {
        return;
      }
      if (other.fishFarmingInfo_ != null) {
        if (fishFarmingInfo_ == null) {
          FishFarmingInfo = new global::OldProtos.HomeScenePointFishFarmingInfo();
        }
        FishFarmingInfo.MergeFrom(other.FishFarmingInfo);
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
          case 58: {
            if (fishFarmingInfo_ == null) {
              FishFarmingInfo = new global::OldProtos.HomeScenePointFishFarmingInfo();
            }
            input.ReadMessage(FishFarmingInfo);
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
          case 58: {
            if (fishFarmingInfo_ == null) {
              FishFarmingInfo = new global::OldProtos.HomeScenePointFishFarmingInfo();
            }
            input.ReadMessage(FishFarmingInfo);
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
