// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AsterLittleStageState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AsterLittleStageState.proto</summary>
  public static partial class AsterLittleStageStateReflection {

    #region Descriptor
    /// <summary>File descriptor for AsterLittleStageState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AsterLittleStageStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBc3RlckxpdHRsZVN0YWdlU3RhdGUucHJvdG8qrwEKFUFzdGVyTGl0dGxl",
            "U3RhZ2VTdGF0ZRIhCh1BU1RFUl9MSVRUTEVfU1RBR0VfU1RBVEVfTk9ORRAA",
            "EiYKIkFTVEVSX0xJVFRMRV9TVEFHRV9TVEFURV9VTlNUQVJURUQQARIkCiBB",
            "U1RFUl9MSVRUTEVfU1RBR0VfU1RBVEVfU1RBUlRFRBACEiUKIUFTVEVSX0xJ",
            "VFRMRV9TVEFHRV9TVEFURV9GSU5JU0hFRBADQgyqAglPbGRQcm90b3NiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.AsterLittleStageState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum AsterLittleStageState {
    [pbr::OriginalName("ASTER_LITTLE_STAGE_STATE_NONE")] None = 0,
    [pbr::OriginalName("ASTER_LITTLE_STAGE_STATE_UNSTARTED")] Unstarted = 1,
    [pbr::OriginalName("ASTER_LITTLE_STAGE_STATE_STARTED")] Started = 2,
    [pbr::OriginalName("ASTER_LITTLE_STAGE_STATE_FINISHED")] Finished = 3,
  }

  #endregion

}

#endregion Designer generated code
