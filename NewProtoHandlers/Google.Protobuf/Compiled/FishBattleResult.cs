// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishBattleResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from FishBattleResult.proto</summary>
  public static partial class FishBattleResultReflection {

    #region Descriptor
    /// <summary>File descriptor for FishBattleResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishBattleResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGaXNoQmF0dGxlUmVzdWx0LnByb3RvKsUBChBGaXNoQmF0dGxlUmVzdWx0",
            "EhsKF0ZJU0hfQkFUVExFX1JFU1VMVF9OT05FEAASGwoXRklTSF9CQVRUTEVf",
            "UkVTVUxUX1NVQ0MQARIbChdGSVNIX0JBVFRMRV9SRVNVTFRfRkFJTBACEh4K",
            "GkZJU0hfQkFUVExFX1JFU1VMVF9USU1FT1VUEAMSHQoZRklTSF9CQVRUTEVf",
            "UkVTVUxUX0NBTkNFTBAEEhsKF0ZJU0hfQkFUVExFX1JFU1VMVF9FWElUEAVC",
            "DKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NewProtos.FishBattleResult), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FishBattleResult {
    [pbr::OriginalName("FISH_BATTLE_RESULT_NONE")] None = 0,
    [pbr::OriginalName("FISH_BATTLE_RESULT_SUCC")] Succ = 1,
    [pbr::OriginalName("FISH_BATTLE_RESULT_FAIL")] Fail = 2,
    [pbr::OriginalName("FISH_BATTLE_RESULT_TIMEOUT")] Timeout = 3,
    [pbr::OriginalName("FISH_BATTLE_RESULT_CANCEL")] Cancel = 4,
    [pbr::OriginalName("FISH_BATTLE_RESULT_EXIT")] Exit = 5,
  }

  #endregion

}

#endregion Designer generated code
