// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ResetAvatarRenameReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ResetAvatarRenameReason.proto</summary>
  public static partial class ResetAvatarRenameReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for ResetAvatarRenameReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResetAvatarRenameReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1SZXNldEF2YXRhclJlbmFtZVJlYXNvbi5wcm90byq/AQoXUmVzZXRBdmF0",
            "YXJSZW5hbWVSZWFzb24SIwofUkVTRVRfQVZBVEFSX1JFTkFNRV9SRUFTT05f",
            "Tk9ORRAAEiwKKFJFU0VUX0FWQVRBUl9SRU5BTUVfUkVBU09OX0lQX0JMQUNL",
            "X0xJU1QQARIqCiZSRVNFVF9BVkFUQVJfUkVOQU1FX1JFQVNPTl9RVUVTVF9B",
            "VURJVBACEiUKIVJFU0VUX0FWQVRBUl9SRU5BTUVfUkVBU09OX0FDVElWRRAD",
            "QgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NewProtos.ResetAvatarRenameReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ResetAvatarRenameReason {
    [pbr::OriginalName("RESET_AVATAR_RENAME_REASON_NONE")] None = 0,
    [pbr::OriginalName("RESET_AVATAR_RENAME_REASON_IP_BLACK_LIST")] IpBlackList = 1,
    [pbr::OriginalName("RESET_AVATAR_RENAME_REASON_QUEST_AUDIT")] QuestAudit = 2,
    [pbr::OriginalName("RESET_AVATAR_RENAME_REASON_ACTIVE")] Active = 3,
  }

  #endregion

}

#endregion Designer generated code
