// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MotionState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from MotionState.proto</summary>
  public static partial class MotionStateReflection {

    #region Descriptor
    /// <summary>File descriptor for MotionState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MotionStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNb3Rpb25TdGF0ZS5wcm90byqUDQoLTW90aW9uU3RhdGUSFQoRTU9USU9O",
            "X1NUQVRFX05PTkUQABIWChJNT1RJT05fU1RBVEVfUkVTRVQQARIYChRNT1RJ",
            "T05fU1RBVEVfU1RBTkRCWRACEh0KGU1PVElPTl9TVEFURV9TVEFOREJZX01P",
            "VkUQAxIVChFNT1RJT05fU1RBVEVfV0FMSxAEEhQKEE1PVElPTl9TVEFURV9S",
            "VU4QBRIVChFNT1RJT05fU1RBVEVfREFTSBAGEhYKEk1PVElPTl9TVEFURV9D",
            "TElNQhAHEhsKF01PVElPTl9TVEFURV9DTElNQl9KVU1QEAgSIQodTU9USU9O",
            "X1NUQVRFX1NUQU5EQllfVE9fQ0xJTUIQCRIWChJNT1RJT05fU1RBVEVfRklH",
            "SFQQChIVChFNT1RJT05fU1RBVEVfSlVNUBALEhUKEU1PVElPTl9TVEFURV9E",
            "Uk9QEAwSFAoQTU9USU9OX1NUQVRFX0ZMWRANEhoKFk1PVElPTl9TVEFURV9T",
            "V0lNX01PVkUQDhIaChZNT1RJT05fU1RBVEVfU1dJTV9JRExFEA8SGgoWTU9U",
            "SU9OX1NUQVRFX1NXSU1fREFTSBAQEhoKFk1PVElPTl9TVEFURV9TV0lNX0pV",
            "TVAQERIVChFNT1RJT05fU1RBVEVfU0xJUBASEhwKGE1PVElPTl9TVEFURV9H",
            "T19VUFNUQUlSUxATEh8KG01PVElPTl9TVEFURV9GQUxMX09OX0dST1VORBAU",
            "EikKJU1PVElPTl9TVEFURV9KVU1QX1VQX1dBTExfRk9SX1NUQU5EQlkQFRIe",
            "ChpNT1RJT05fU1RBVEVfSlVNUF9PRkZfV0FMTBAWEhwKGE1PVElPTl9TVEFU",
            "RV9QT1dFUkVEX0ZMWRAXEhwKGE1PVElPTl9TVEFURV9MQURERVJfSURMRRAY",
            "EhwKGE1PVElPTl9TVEFURV9MQURERVJfTU9WRRAZEhwKGE1PVElPTl9TVEFU",
            "RV9MQURERVJfU0xJUBAaEiIKHk1PVElPTl9TVEFURV9TVEFOREJZX1RPX0xB",
            "RERFUhAbEiIKHk1PVElPTl9TVEFURV9MQURERVJfVE9fU1RBTkRCWRAcEh8K",
            "G01PVElPTl9TVEFURV9EQU5HRVJfU1RBTkRCWRAdEiQKIE1PVElPTl9TVEFU",
            "RV9EQU5HRVJfU1RBTkRCWV9NT1ZFEB4SHAoYTU9USU9OX1NUQVRFX0RBTkdF",
            "Ul9XQUxLEB8SGwoXTU9USU9OX1NUQVRFX0RBTkdFUl9SVU4QIBIcChhNT1RJ",
            "T05fU1RBVEVfREFOR0VSX0RBU0gQIRIcChhNT1RJT05fU1RBVEVfQ1JPVUNI",
            "X0lETEUQIhIcChhNT1RJT05fU1RBVEVfQ1JPVUNIX01PVkUQIxIcChhNT1RJ",
            "T05fU1RBVEVfQ1JPVUNIX1JPTEwQJBIXChNNT1RJT05fU1RBVEVfTk9USUZZ",
            "ECUSGwoXTU9USU9OX1NUQVRFX0xBTkRfU1BFRUQQJhIeChpNT1RJT05fU1RB",
            "VEVfTU9WRV9GQUlMX0FDSxAnEhoKFk1PVElPTl9TVEFURV9XQVRFUkZBTEwQ",
            "KBIiCh5NT1RJT05fU1RBVEVfREFTSF9CRUZPUkVfU0hBS0UQKRIZChVNT1RJ",
            "T05fU1RBVEVfU0lUX0lETEUQKhIeChpNT1RJT05fU1RBVEVfRk9SQ0VfU0VU",
            "X1BPUxArEiEKHU1PVElPTl9TVEFURV9RVUVTVF9GT1JDRV9EUkFHECwSHQoZ",
            "TU9USU9OX1NUQVRFX0ZPTExPV19ST1VURRAtEh8KG01PVElPTl9TVEFURV9T",
            "S0lGRl9CT0FSRElORxAuEh0KGU1PVElPTl9TVEFURV9TS0lGRl9OT1JNQUwQ",
            "LxIbChdNT1RJT05fU1RBVEVfU0tJRkZfREFTSBAwEiMKH01PVElPTl9TVEFU",
            "RV9TS0lGRl9QT1dFUkVEX0RBU0gQMRIgChxNT1RJT05fU1RBVEVfREVTVFJP",
            "WV9WRUhJQ0xFEDISGQoVTU9USU9OX1NUQVRFX0ZMWV9JRExFEDMSGQoVTU9U",
            "SU9OX1NUQVRFX0ZMWV9TTE9XEDQSGQoVTU9USU9OX1NUQVRFX0ZMWV9GQVNU",
            "EDUSGQoVTU9USU9OX1NUQVRFX0FJTV9NT1ZFEDYSIQodTU9USU9OX1NUQVRF",
            "X0FJUl9DT01QRU5TQVRJT04QNxIUChBNT1RJT05fU1RBVEVfTlVNEDhCDKoC",
            "CU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.MotionState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MotionState {
    [pbr::OriginalName("MOTION_STATE_NONE")] None = 0,
    [pbr::OriginalName("MOTION_STATE_RESET")] Reset = 1,
    [pbr::OriginalName("MOTION_STATE_STANDBY")] Standby = 2,
    [pbr::OriginalName("MOTION_STATE_STANDBY_MOVE")] StandbyMove = 3,
    [pbr::OriginalName("MOTION_STATE_WALK")] Walk = 4,
    [pbr::OriginalName("MOTION_STATE_RUN")] Run = 5,
    [pbr::OriginalName("MOTION_STATE_DASH")] Dash = 6,
    [pbr::OriginalName("MOTION_STATE_CLIMB")] Climb = 7,
    [pbr::OriginalName("MOTION_STATE_CLIMB_JUMP")] ClimbJump = 8,
    [pbr::OriginalName("MOTION_STATE_STANDBY_TO_CLIMB")] StandbyToClimb = 9,
    [pbr::OriginalName("MOTION_STATE_FIGHT")] Fight = 10,
    [pbr::OriginalName("MOTION_STATE_JUMP")] Jump = 11,
    [pbr::OriginalName("MOTION_STATE_DROP")] Drop = 12,
    [pbr::OriginalName("MOTION_STATE_FLY")] Fly = 13,
    [pbr::OriginalName("MOTION_STATE_SWIM_MOVE")] SwimMove = 14,
    [pbr::OriginalName("MOTION_STATE_SWIM_IDLE")] SwimIdle = 15,
    [pbr::OriginalName("MOTION_STATE_SWIM_DASH")] SwimDash = 16,
    [pbr::OriginalName("MOTION_STATE_SWIM_JUMP")] SwimJump = 17,
    [pbr::OriginalName("MOTION_STATE_SLIP")] Slip = 18,
    [pbr::OriginalName("MOTION_STATE_GO_UPSTAIRS")] GoUpstairs = 19,
    [pbr::OriginalName("MOTION_STATE_FALL_ON_GROUND")] FallOnGround = 20,
    [pbr::OriginalName("MOTION_STATE_JUMP_UP_WALL_FOR_STANDBY")] JumpUpWallForStandby = 21,
    [pbr::OriginalName("MOTION_STATE_JUMP_OFF_WALL")] JumpOffWall = 22,
    [pbr::OriginalName("MOTION_STATE_POWERED_FLY")] PoweredFly = 23,
    [pbr::OriginalName("MOTION_STATE_LADDER_IDLE")] LadderIdle = 24,
    [pbr::OriginalName("MOTION_STATE_LADDER_MOVE")] LadderMove = 25,
    [pbr::OriginalName("MOTION_STATE_LADDER_SLIP")] LadderSlip = 26,
    [pbr::OriginalName("MOTION_STATE_STANDBY_TO_LADDER")] StandbyToLadder = 27,
    [pbr::OriginalName("MOTION_STATE_LADDER_TO_STANDBY")] LadderToStandby = 28,
    [pbr::OriginalName("MOTION_STATE_DANGER_STANDBY")] DangerStandby = 29,
    [pbr::OriginalName("MOTION_STATE_DANGER_STANDBY_MOVE")] DangerStandbyMove = 30,
    [pbr::OriginalName("MOTION_STATE_DANGER_WALK")] DangerWalk = 31,
    [pbr::OriginalName("MOTION_STATE_DANGER_RUN")] DangerRun = 32,
    [pbr::OriginalName("MOTION_STATE_DANGER_DASH")] DangerDash = 33,
    [pbr::OriginalName("MOTION_STATE_CROUCH_IDLE")] CrouchIdle = 34,
    [pbr::OriginalName("MOTION_STATE_CROUCH_MOVE")] CrouchMove = 35,
    [pbr::OriginalName("MOTION_STATE_CROUCH_ROLL")] CrouchRoll = 36,
    [pbr::OriginalName("MOTION_STATE_NOTIFY")] Notify = 37,
    [pbr::OriginalName("MOTION_STATE_LAND_SPEED")] LandSpeed = 38,
    [pbr::OriginalName("MOTION_STATE_MOVE_FAIL_ACK")] MoveFailAck = 39,
    [pbr::OriginalName("MOTION_STATE_WATERFALL")] Waterfall = 40,
    [pbr::OriginalName("MOTION_STATE_DASH_BEFORE_SHAKE")] DashBeforeShake = 41,
    [pbr::OriginalName("MOTION_STATE_SIT_IDLE")] SitIdle = 42,
    [pbr::OriginalName("MOTION_STATE_FORCE_SET_POS")] ForceSetPos = 43,
    [pbr::OriginalName("MOTION_STATE_QUEST_FORCE_DRAG")] QuestForceDrag = 44,
    [pbr::OriginalName("MOTION_STATE_FOLLOW_ROUTE")] FollowRoute = 45,
    [pbr::OriginalName("MOTION_STATE_SKIFF_BOARDING")] SkiffBoarding = 46,
    [pbr::OriginalName("MOTION_STATE_SKIFF_NORMAL")] SkiffNormal = 47,
    [pbr::OriginalName("MOTION_STATE_SKIFF_DASH")] SkiffDash = 48,
    [pbr::OriginalName("MOTION_STATE_SKIFF_POWERED_DASH")] SkiffPoweredDash = 49,
    [pbr::OriginalName("MOTION_STATE_DESTROY_VEHICLE")] DestroyVehicle = 50,
    [pbr::OriginalName("MOTION_STATE_FLY_IDLE")] FlyIdle = 51,
    [pbr::OriginalName("MOTION_STATE_FLY_SLOW")] FlySlow = 52,
    [pbr::OriginalName("MOTION_STATE_FLY_FAST")] FlyFast = 53,
    [pbr::OriginalName("MOTION_STATE_AIM_MOVE")] AimMove = 54,
    [pbr::OriginalName("MOTION_STATE_AIR_COMPENSATION")] AirCompensation = 55,
    [pbr::OriginalName("MOTION_STATE_NUM")] Num = 56,
  }

  #endregion

}

#endregion Designer generated code
