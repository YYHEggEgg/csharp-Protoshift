using csharp_Protoshift.Enhanced.Handlers.CustomHandlers;
using csharp_Protoshift.ProtoHotPatch;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System.Collections.Generic;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerGCGSelectOnStageCostInfo 
        : HandlerBase<NewProtos.GCGSelectOnStageCostInfo, OldProtos.GCGSelectOnStageCostInfo>
    {
        #region Base Type
        MessageParser<NewProtos.GCGSelectOnStageCostInfo> newproto_parser_base = NewProtos.GCGSelectOnStageCostInfo.Parser;
        MessageParser<OldProtos.GCGSelectOnStageCostInfo> oldproto_parser_base = OldProtos.GCGSelectOnStageCostInfo.Parser;
        #endregion
        #region Import Types
        HandlerUint32PairAndMap handler_fuck = HandlerUint32PairAndMap.GlobalInstance;
        #endregion

        #region Protocol Shift
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override OldProtos.GCGSelectOnStageCostInfo? NewShiftToOld(NewProtos.GCGSelectOnStageCostInfo? newprotocol)
        {
            if (newprotocol == null) return null;
            OldProtos.GCGSelectOnStageCostInfo oldprotocol = new();
            oldprotocol.CardGuid = newprotocol.CardGuid;
            handler_fuck.NewShiftToOld(newprotocol.CostList, oldprotocol.CostMap);
            return oldprotocol;
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGSelectOnStageCostInfo? OldShiftToNew(OldProtos.GCGSelectOnStageCostInfo? oldprotocol)
        {
            if (oldprotocol == null) return null;
            NewProtos.GCGSelectOnStageCostInfo newprotocol = new();
            newprotocol.CardGuid = oldprotocol.CardGuid;
            handler_fuck.OldShiftToNew(oldprotocol.CostMap, newprotocol.CostList);
            return newprotocol;
        }

        #region JIT API
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGSelectOnStageCostInfo GetNewShiftToOldJitInstance()
        {
            NewProtos.GCGSelectOnStageCostInfo newprotocol = new();
            newprotocol.CardGuid = 20231024;
            newprotocol.CostList.Add(handler_fuck.GetNewShiftToOldJitInstance());
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

        private static HandlerGCGSelectOnStageCostInfo _globalOnlyInstance = new HandlerGCGSelectOnStageCostInfo();
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public static HandlerGCGSelectOnStageCostInfo GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
