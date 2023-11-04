using csharp_Protoshift.Enhanced.Handlers.CustomHandlers;
using csharp_Protoshift.ProtoHotPatch;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System.Collections.Generic;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerGCGAttackCostInfo 
        : HandlerBase<NewProtos.GCGAttackCostInfo, OldProtos.GCGAttackCostInfo>
    {
        #region Base Type
        MessageParser<NewProtos.GCGAttackCostInfo> newproto_parser_base = NewProtos.GCGAttackCostInfo.Parser;
        MessageParser<OldProtos.GCGAttackCostInfo> oldproto_parser_base = OldProtos.GCGAttackCostInfo.Parser;
        #endregion
        #region Import Types
        HandlerUint32PairAndMap handler_fuck = HandlerUint32PairAndMap.GlobalInstance;
        #endregion

        #region Protocol Shift
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override OldProtos.GCGAttackCostInfo? NewShiftToOld(NewProtos.GCGAttackCostInfo? newprotocol)
        {
            if (newprotocol == null) return null;
            OldProtos.GCGAttackCostInfo oldprotocol = new();
            handler_fuck.NewShiftToOld(newprotocol.CostList, oldprotocol.CostMap);
            oldprotocol.SkillId = newprotocol.SkillId;
            return oldprotocol;
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGAttackCostInfo? OldShiftToNew(OldProtos.GCGAttackCostInfo? oldprotocol)
        {
            if (oldprotocol == null) return null;
            NewProtos.GCGAttackCostInfo newprotocol = new();
            newprotocol.SkillId = oldprotocol.SkillId;
            handler_fuck.OldShiftToNew(oldprotocol.CostMap, newprotocol.CostList);
            return newprotocol;
        }

        #region JIT API
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGAttackCostInfo GetNewShiftToOldJitInstance()
        {
            NewProtos.GCGAttackCostInfo newprotocol = new();
            newprotocol.CostList.Add(handler_fuck.GetNewShiftToOldJitInstance());
            newprotocol.SkillId = 20231024;
            return newprotocol;
        }
        #endregion
        #endregion

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override ByteString NewShiftToOld(ByteString bytes)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override byte[] OldShiftToNew(byte[] arr, int offset, int length)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override ByteString OldShiftToNew(ByteString bytes)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }

        private static HandlerGCGAttackCostInfo _globalOnlyInstance = new HandlerGCGAttackCostInfo();
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public static HandlerGCGAttackCostInfo GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
