// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DraftInviteFailReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from DraftInviteFailReason.proto</summary>
  public static partial class DraftInviteFailReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for DraftInviteFailReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DraftInviteFailReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtEcmFmdEludml0ZUZhaWxSZWFzb24ucHJvdG8qrgIKFURyYWZ0SW52aXRl",
            "RmFpbFJlYXNvbhIkCiBEUkFGVF9JTlZJVEVfRkFJTF9SRUFTT05fVU5LTk9X",
            "ThAAEi4KKkRSQUZUX0lOVklURV9GQUlMX1JFQVNPTl9BQ1RJVklUWV9OT1Rf",
            "T1BFThABEjMKL0RSQUZUX0lOVklURV9GQUlMX1JFQVNPTl9BQ1RJVklUWV9Q",
            "TEFZX05PVF9PUEVOEAISKwonRFJBRlRfSU5WSVRFX0ZBSUxfUkVBU09OX1ND",
            "RU5FX05PVF9NRUVUEAMSKwonRFJBRlRfSU5WSVRFX0ZBSUxfUkVBU09OX1dP",
            "UkxEX05PVF9NRUVUEAQSMAosRFJBRlRfSU5WSVRFX0ZBSUxfUkVBU09OX1BM",
            "QVlfTElNSVRfTk9UX01FRVQQBUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NewProtos.DraftInviteFailReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum DraftInviteFailReason {
    [pbr::OriginalName("DRAFT_INVITE_FAIL_REASON_UNKNOWN")] Unknown = 0,
    [pbr::OriginalName("DRAFT_INVITE_FAIL_REASON_ACTIVITY_NOT_OPEN")] ActivityNotOpen = 1,
    [pbr::OriginalName("DRAFT_INVITE_FAIL_REASON_ACTIVITY_PLAY_NOT_OPEN")] ActivityPlayNotOpen = 2,
    [pbr::OriginalName("DRAFT_INVITE_FAIL_REASON_SCENE_NOT_MEET")] SceneNotMeet = 3,
    [pbr::OriginalName("DRAFT_INVITE_FAIL_REASON_WORLD_NOT_MEET")] WorldNotMeet = 4,
    [pbr::OriginalName("DRAFT_INVITE_FAIL_REASON_PLAY_LIMIT_NOT_MEET")] PlayLimitNotMeet = 5,
  }

  #endregion

}

#endregion Designer generated code
