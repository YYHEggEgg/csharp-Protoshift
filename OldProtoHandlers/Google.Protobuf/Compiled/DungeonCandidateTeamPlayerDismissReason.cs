// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonCandidateTeamPlayerDismissReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from DungeonCandidateTeamPlayerDismissReason.proto</summary>
  public static partial class DungeonCandidateTeamPlayerDismissReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonCandidateTeamPlayerDismissReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonCandidateTeamPlayerDismissReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1EdW5nZW9uQ2FuZGlkYXRlVGVhbVBsYXllckRpc21pc3NSZWFzb24ucHJv",
            "dG8q5AEKJ0R1bmdlb25DYW5kaWRhdGVUZWFtUGxheWVyRGlzbWlzc1JlYXNv",
            "bhI8CjhEVU5HRU9OX0NBTkRJREFURV9URUFNX1BMQVlFUl9ESVNNSVNTX1JF",
            "QVNPTl9UUERSX05PUk1BTBAAEjkKNURVTkdFT05fQ0FORElEQVRFX1RFQU1f",
            "UExBWUVSX0RJU01JU1NfUkVBU09OX1RQRFJfRElFEAESQAo8RFVOR0VPTl9D",
            "QU5ESURBVEVfVEVBTV9QTEFZRVJfRElTTUlTU19SRUFTT05fVFBEUl9ESVND",
            "T05ORUNUEAJCDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.DungeonCandidateTeamPlayerDismissReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum DungeonCandidateTeamPlayerDismissReason {
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_PLAYER_DISMISS_REASON_TPDR_NORMAL")] TpdrNormal = 0,
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_PLAYER_DISMISS_REASON_TPDR_DIE")] TpdrDie = 1,
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_PLAYER_DISMISS_REASON_TPDR_DISCONNECT")] TpdrDisconnect = 2,
  }

  #endregion

}

#endregion Designer generated code
