// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarExpeditionState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AvatarExpeditionState.proto</summary>
  public static partial class AvatarExpeditionStateReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarExpeditionState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarExpeditionStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBdmF0YXJFeHBlZGl0aW9uU3RhdGUucHJvdG8q4gEKFUF2YXRhckV4cGVk",
            "aXRpb25TdGF0ZRIgChxBVkFUQVJfRVhQRURJVElPTl9TVEFURV9OT05FEAAS",
            "IQodQVZBVEFSX0VYUEVESVRJT05fU1RBVEVfRE9JTkcQARIuCipBVkFUQVJf",
            "RVhQRURJVElPTl9TVEFURV9GSU5JU0hfV0FJVF9SRVdBUkQQAhIwCixBVkFU",
            "QVJfRVhQRURJVElPTl9TVEFURV9DQUxMQkFDS19XQUlUX1JFV0FSRBADEiIK",
            "HkFWQVRBUl9FWFBFRElUSU9OX1NUQVRFX0xPQ0tFRBAEQgyqAglPbGRQcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.AvatarExpeditionState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum AvatarExpeditionState {
    [pbr::OriginalName("AVATAR_EXPEDITION_STATE_NONE")] None = 0,
    [pbr::OriginalName("AVATAR_EXPEDITION_STATE_DOING")] Doing = 1,
    [pbr::OriginalName("AVATAR_EXPEDITION_STATE_FINISH_WAIT_REWARD")] FinishWaitReward = 2,
    [pbr::OriginalName("AVATAR_EXPEDITION_STATE_CALLBACK_WAIT_REWARD")] CallbackWaitReward = 3,
    [pbr::OriginalName("AVATAR_EXPEDITION_STATE_LOCKED")] Locked = 4,
  }

  #endregion

}

#endregion Designer generated code
