// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CustomDungeonState.proto</summary>
public static partial class CustomDungeonStateReflection {

  #region Descriptor
  /// <summary>File descriptor for CustomDungeonState.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CustomDungeonStateReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhDdXN0b21EdW5nZW9uU3RhdGUucHJvdG8qewoSQ3VzdG9tRHVuZ2VvblN0",
          "YXRlEh0KGUNVU1RPTV9EVU5HRU9OX1NUQVRFX0VESVQQABIiCh5DVVNUT01f",
          "RFVOR0VPTl9TVEFURV9TRUxGX1BBU1MQARIiCh5DVVNUT01fRFVOR0VPTl9T",
          "VEFURV9QVUJMSVNIRUQQAkIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::CustomDungeonState), }, null, null));
  }
  #endregion

}
#region Enums
public enum CustomDungeonState {
  [pbr::OriginalName("CUSTOM_DUNGEON_STATE_EDIT")] Edit = 0,
  [pbr::OriginalName("CUSTOM_DUNGEON_STATE_SELF_PASS")] SelfPass = 1,
  [pbr::OriginalName("CUSTOM_DUNGEON_STATE_PUBLISHED")] Published = 2,
}

#endregion


#endregion Designer generated code
