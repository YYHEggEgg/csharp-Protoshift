// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonCandidateTeamPlayerLeaveReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from DungeonCandidateTeamPlayerLeaveReason.proto</summary>
  public static partial class DungeonCandidateTeamPlayerLeaveReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonCandidateTeamPlayerLeaveReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonCandidateTeamPlayerLeaveReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitEdW5nZW9uQ2FuZGlkYXRlVGVhbVBsYXllckxlYXZlUmVhc29uLnByb3Rv",
            "KpkCCiVEdW5nZW9uQ2FuZGlkYXRlVGVhbVBsYXllckxlYXZlUmVhc29uEjoK",
            "NkRVTkdFT05fQ0FORElEQVRFX1RFQU1fUExBWUVSX0xFQVZFX1JFQVNPTl9U",
            "UExSX05PUk1BTBAAEjcKM0RVTkdFT05fQ0FORElEQVRFX1RFQU1fUExBWUVS",
            "X0xFQVZFX1JFQVNPTl9UUExSX0RJRRABEjsKN0RVTkdFT05fQ0FORElEQVRF",
            "X1RFQU1fUExBWUVSX0xFQVZFX1JFQVNPTl9UUExSX0JFX0tJQ0sQAhI+CjpE",
            "VU5HRU9OX0NBTkRJREFURV9URUFNX1BMQVlFUl9MRUFWRV9SRUFTT05fVFBM",
            "Ul9ESVNDT05ORUNUEANCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NewProtos.DungeonCandidateTeamPlayerLeaveReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum DungeonCandidateTeamPlayerLeaveReason {
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_PLAYER_LEAVE_REASON_TPLR_NORMAL")] TplrNormal = 0,
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_PLAYER_LEAVE_REASON_TPLR_DIE")] TplrDie = 1,
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_PLAYER_LEAVE_REASON_TPLR_BE_KICK")] TplrBeKick = 2,
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_PLAYER_LEAVE_REASON_TPLR_DISCONNECT")] TplrDisconnect = 3,
  }

  #endregion

}

#endregion Designer generated code
