// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerDieOption.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PlayerDieOption.proto</summary>
public static partial class PlayerDieOptionReflection {

  #region Descriptor
  /// <summary>File descriptor for PlayerDieOption.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlayerDieOptionReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVQbGF5ZXJEaWVPcHRpb24ucHJvdG8qlwEKD1BsYXllckRpZU9wdGlvbhIe",
          "ChpQTEFZRVJfRElFX09QVElPTl9PUFRfTk9ORRAAEiAKHFBMQVlFUl9ESUVf",
          "T1BUSU9OX09QVF9SRVBMQVkQARIgChxQTEFZRVJfRElFX09QVElPTl9PUFRf",
          "Q0FOQ0VMEAISIAocUExBWUVSX0RJRV9PUFRJT05fT1BUX1JFVklWRRADQhYK",
          "FG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::PlayerDieOption), }, null, null));
  }
  #endregion

}
#region Enums
public enum PlayerDieOption {
  [pbr::OriginalName("PLAYER_DIE_OPTION_OPT_NONE")] OptNone = 0,
  [pbr::OriginalName("PLAYER_DIE_OPTION_OPT_REPLAY")] OptReplay = 1,
  [pbr::OriginalName("PLAYER_DIE_OPTION_OPT_CANCEL")] OptCancel = 2,
  [pbr::OriginalName("PLAYER_DIE_OPTION_OPT_REVIVE")] OptRevive = 3,
}

#endregion


#endregion Designer generated code
