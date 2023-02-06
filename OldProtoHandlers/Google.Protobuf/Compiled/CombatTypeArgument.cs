// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CombatTypeArgument.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CombatTypeArgument.proto</summary>
public static partial class CombatTypeArgumentReflection {

  #region Descriptor
  /// <summary>File descriptor for CombatTypeArgument.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CombatTypeArgumentReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhDb21iYXRUeXBlQXJndW1lbnQucHJvdG8qyAYKEkNvbWJhdFR5cGVBcmd1",
          "bWVudBIdChlDT01CQVRfVFlQRV9BUkdVTUVOVF9OT05FEAASJgoiQ09NQkFU",
          "X1RZUEVfQVJHVU1FTlRfRVZUX0JFSU5HX0hJVBABEi8KK0NPTUJBVF9UWVBF",
          "X0FSR1VNRU5UX0FOSU1BVE9SX1NUQVRFX0NIQU5HRUQQAhIkCiBDT01CQVRf",
          "VFlQRV9BUkdVTUVOVF9GQUNFX1RPX0RJUhADEioKJkNPTUJBVF9UWVBFX0FS",
          "R1VNRU5UX1NFVF9BVFRBQ0tfVEFSR0VUEAQSIgoeQ09NQkFUX1RZUEVfQVJH",
          "VU1FTlRfUlVTSF9NT1ZFEAUSMwovQ09NQkFUX1RZUEVfQVJHVU1FTlRfQU5J",
          "TUFUT1JfUEFSQU1FVEVSX0NIQU5HRUQQBhIkCiBDT01CQVRfVFlQRV9BUkdV",
          "TUVOVF9FTlRJVFlfTU9WRRAHEi0KKUNPTUJBVF9UWVBFX0FSR1VNRU5UX1NZ",
          "TkNfRU5USVRZX1BPU0lUSU9OEAgSKgomQ09NQkFUX1RZUEVfQVJHVU1FTlRf",
          "U1RFRVJfTU9USU9OX0lORk8QCRIrCidDT01CQVRfVFlQRV9BUkdVTUVOVF9G",
          "T1JDRV9TRVRfUE9TX0lORk8QChIsCihDT01CQVRfVFlQRV9BUkdVTUVOVF9D",
          "T01QRU5TQVRFX1BPU19ESUZGEAsSKQolQ09NQkFUX1RZUEVfQVJHVU1FTlRf",
          "TU9OU1RFUl9ET19CTElOSxAMEigKJENPTUJBVF9UWVBFX0FSR1VNRU5UX0ZJ",
          "WEVEX1JVU0hfTU9WRRANEicKI0NPTUJBVF9UWVBFX0FSR1VNRU5UX1NZTkNf",
          "VFJBTlNGT1JNEA4SKAokQ09NQkFUX1RZUEVfQVJHVU1FTlRfTElHSFRfQ09S",
          "RV9NT1ZFEA8SKQolQ09NQkFUX1RZUEVfQVJHVU1FTlRfQkVJTkdfSEVBTEVE",
          "X05URhAQEjIKLkNPTUJBVF9UWVBFX0FSR1VNRU5UX1NLSUxMX0FOQ0hPUl9Q",
          "T1NJVElPTl9OVEYQERIsCihDT01CQVRfVFlQRV9BUkdVTUVOVF9HUkFQUExJ",
          "TkdfSE9PS19NT1ZFEBJCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::CombatTypeArgument), }, null, null));
  }
  #endregion

}
#region Enums
public enum CombatTypeArgument {
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_NONE")] None = 0,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_EVT_BEING_HIT")] EvtBeingHit = 1,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_ANIMATOR_STATE_CHANGED")] AnimatorStateChanged = 2,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_FACE_TO_DIR")] FaceToDir = 3,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_SET_ATTACK_TARGET")] SetAttackTarget = 4,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_RUSH_MOVE")] RushMove = 5,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_ANIMATOR_PARAMETER_CHANGED")] AnimatorParameterChanged = 6,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_ENTITY_MOVE")] EntityMove = 7,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_SYNC_ENTITY_POSITION")] SyncEntityPosition = 8,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_STEER_MOTION_INFO")] SteerMotionInfo = 9,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_FORCE_SET_POS_INFO")] ForceSetPosInfo = 10,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_COMPENSATE_POS_DIFF")] CompensatePosDiff = 11,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_MONSTER_DO_BLINK")] MonsterDoBlink = 12,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_FIXED_RUSH_MOVE")] FixedRushMove = 13,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_SYNC_TRANSFORM")] SyncTransform = 14,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_LIGHT_CORE_MOVE")] LightCoreMove = 15,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_BEING_HEALED_NTF")] BeingHealedNtf = 16,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_SKILL_ANCHOR_POSITION_NTF")] SkillAnchorPositionNtf = 17,
  [pbr::OriginalName("COMBAT_TYPE_ARGUMENT_GRAPPLING_HOOK_MOVE")] GrapplingHookMove = 18,
}

#endregion


#endregion Designer generated code
