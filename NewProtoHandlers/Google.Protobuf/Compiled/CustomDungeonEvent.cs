// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CustomDungeonEvent.proto</summary>
public static partial class CustomDungeonEventReflection {

  #region Descriptor
  /// <summary>File descriptor for CustomDungeonEvent.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CustomDungeonEventReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhDdXN0b21EdW5nZW9uRXZlbnQucHJvdG8qggEKEkN1c3RvbUR1bmdlb25F",
          "dmVudBIdChlDVVNUT01fRFVOR0VPTl9FVkVOVF9OT05FEAASKQolQ1VTVE9N",
          "X0RVTkdFT05fRVZFTlRfT0ZGSUNJQUxfUkVTVEFSVBABEiIKHkNVU1RPTV9E",
          "VU5HRU9OX0VWRU5UX09VVF9TVFVDSxACQhYKFG9yZy5zb3JhcG9pbnRhLnBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::CustomDungeonEvent), }, null, null));
  }
  #endregion

}
#region Enums
public enum CustomDungeonEvent {
  [pbr::OriginalName("CUSTOM_DUNGEON_EVENT_NONE")] None = 0,
  [pbr::OriginalName("CUSTOM_DUNGEON_EVENT_OFFICIAL_RESTART")] OfficialRestart = 1,
  [pbr::OriginalName("CUSTOM_DUNGEON_EVENT_OUT_STUCK")] OutStuck = 2,
}

#endregion


#endregion Designer generated code