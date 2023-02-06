// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGActionType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGActionType.proto</summary>
public static partial class GCGActionTypeReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGActionType.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGActionTypeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNHQ0dBY3Rpb25UeXBlLnByb3RvKtkGCg1HQ0dBY3Rpb25UeXBlEhgKFEdD",
          "R19BQ1RJT05fVFlQRV9OT05FEAASIQodR0NHX0FDVElPTl9UWVBFX1NQRUNJ",
          "QUxfUEhBU0UQARIeChpHQ0dfQUNUSU9OX1RZUEVfTkVYVF9QSEFTRRACEhgK",
          "FEdDR19BQ1RJT05fVFlQRV9EUkFXEAMSGgoWR0NHX0FDVElPTl9UWVBFX1JF",
          "RFJBVxAEEiIKHkdDR19BQ1RJT05fVFlQRV9TRUxFQ1RfT05TVEFHRRAFEhgK",
          "FEdDR19BQ1RJT05fVFlQRV9ST0xMEAYSGgoWR0NHX0FDVElPTl9UWVBFX1JF",
          "Uk9MTBAHEhoKFkdDR19BQ1RJT05fVFlQRV9BVFRBQ0sQCBIdChlHQ0dfQUNU",
          "SU9OX1RZUEVfUExBWV9DQVJEEAkSGAoUR0NHX0FDVElPTl9UWVBFX1BBU1MQ",
          "ChIaChZHQ0dfQUNUSU9OX1RZUEVfUkVCT09UEAsSHQoZR0NHX0FDVElPTl9U",
          "WVBFX0dBTUVfT1ZFUhAMEhsKF0dDR19BQ1RJT05fVFlQRV9UUklHR0VSEA0S",
          "HgoaR0NHX0FDVElPTl9UWVBFX1BIQVNFX0VYSVQQDhIaChZHQ0dfQUNUSU9O",
          "X1RZUEVfQ1VTVE9NEA8SHwobR0NHX0FDVElPTl9UWVBFX05PVElGWV9DT1NU",
          "EBASIwofR0NHX0FDVElPTl9UWVBFX0FGVEVSX09QRVJBVElPThAREh0KGUdD",
          "R19BQ1RJT05fVFlQRV9VU0VfU0tJTEwQEhIoCiRHQ0dfQUNUSU9OX1RZUEVf",
          "Tk9USUZZX1NLSUxMX1BSRVZJRVcQExIiCh5HQ0dfQUNUSU9OX1RZUEVfUFJF",
          "VklFV19BVFRBQ0sQFBIoCiRHQ0dfQUNUSU9OX1RZUEVfUFJFVklFV19BRlRF",
          "Ul9BVFRBQ0sQFRIgChxHQ0dfQUNUSU9OX1RZUEVfU0VORF9NRVNTQUdFEBYS",
          "JQohR0NHX0FDVElPTl9UWVBFX1dBSVRJTkdfQ0hBUkFDVEVSEBcSIQodR0NH",
          "X0FDVElPTl9UWVBFX1RSSUdHRVJfU0tJTEwQGBIpCiVHQ0dfQUNUSU9OX1RZ",
          "UEVfQkVGT1JFX05FWFRfT1BFUkFUSU9OEBlCHgocZW11LmdyYXNzY3V0dGVy",
          "Lm5ldC5uZXdwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GCGActionType), }, null, null));
  }
  #endregion

}
#region Enums
public enum GCGActionType {
  [pbr::OriginalName("GCG_ACTION_TYPE_NONE")] None = 0,
  [pbr::OriginalName("GCG_ACTION_TYPE_SPECIAL_PHASE")] SpecialPhase = 1,
  [pbr::OriginalName("GCG_ACTION_TYPE_NEXT_PHASE")] NextPhase = 2,
  [pbr::OriginalName("GCG_ACTION_TYPE_DRAW")] Draw = 3,
  [pbr::OriginalName("GCG_ACTION_TYPE_REDRAW")] Redraw = 4,
  [pbr::OriginalName("GCG_ACTION_TYPE_SELECT_ONSTAGE")] SelectOnstage = 5,
  [pbr::OriginalName("GCG_ACTION_TYPE_ROLL")] Roll = 6,
  [pbr::OriginalName("GCG_ACTION_TYPE_REROLL")] Reroll = 7,
  [pbr::OriginalName("GCG_ACTION_TYPE_ATTACK")] Attack = 8,
  [pbr::OriginalName("GCG_ACTION_TYPE_PLAY_CARD")] PlayCard = 9,
  [pbr::OriginalName("GCG_ACTION_TYPE_PASS")] Pass = 10,
  [pbr::OriginalName("GCG_ACTION_TYPE_REBOOT")] Reboot = 11,
  [pbr::OriginalName("GCG_ACTION_TYPE_GAME_OVER")] GameOver = 12,
  [pbr::OriginalName("GCG_ACTION_TYPE_TRIGGER")] Trigger = 13,
  [pbr::OriginalName("GCG_ACTION_TYPE_PHASE_EXIT")] PhaseExit = 14,
  [pbr::OriginalName("GCG_ACTION_TYPE_CUSTOM")] Custom = 15,
  [pbr::OriginalName("GCG_ACTION_TYPE_NOTIFY_COST")] NotifyCost = 16,
  [pbr::OriginalName("GCG_ACTION_TYPE_AFTER_OPERATION")] AfterOperation = 17,
  [pbr::OriginalName("GCG_ACTION_TYPE_USE_SKILL")] UseSkill = 18,
  [pbr::OriginalName("GCG_ACTION_TYPE_NOTIFY_SKILL_PREVIEW")] NotifySkillPreview = 19,
  [pbr::OriginalName("GCG_ACTION_TYPE_PREVIEW_ATTACK")] PreviewAttack = 20,
  [pbr::OriginalName("GCG_ACTION_TYPE_PREVIEW_AFTER_ATTACK")] PreviewAfterAttack = 21,
  [pbr::OriginalName("GCG_ACTION_TYPE_SEND_MESSAGE")] SendMessage = 22,
  [pbr::OriginalName("GCG_ACTION_TYPE_WAITING_CHARACTER")] WaitingCharacter = 23,
  [pbr::OriginalName("GCG_ACTION_TYPE_TRIGGER_SKILL")] TriggerSkill = 24,
  [pbr::OriginalName("GCG_ACTION_TYPE_BEFORE_NEXT_OPERATION")] BeforeNextOperation = 25,
}

#endregion


#endregion Designer generated code
