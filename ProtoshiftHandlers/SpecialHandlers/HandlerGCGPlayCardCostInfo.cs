using csharp_Protoshift.Enhanced.Handlers.CustomHandlers;
using csharp_Protoshift.ProtoHotPatch;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System.Collections.Generic;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerGCGPlayCardCostInfo 
        : HandlerBase<NewProtos.GCGPlayCardCostInfo, OldProtos.GCGPlayCardCostInfo>
    {
        #region Base Type
        MessageParser<NewProtos.GCGPlayCardCostInfo> newproto_parser_base = NewProtos.GCGPlayCardCostInfo.Parser;
        MessageParser<OldProtos.GCGPlayCardCostInfo> oldproto_parser_base = OldProtos.GCGPlayCardCostInfo.Parser;
        #endregion
        #region Import Types
        HandlerUint32PairAndMap handler_fuck = HandlerUint32PairAndMap.GlobalInstance;
        #endregion

        #region Protocol Shift
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override OldProtos.GCGPlayCardCostInfo? NewShiftToOld(NewProtos.GCGPlayCardCostInfo? newprotocol)
        {
            if (newprotocol == null) return null;
            OldProtos.GCGPlayCardCostInfo oldprotocol = new();
            handler_fuck.NewShiftToOld(newprotocol.CostList, oldprotocol.CostMap);
            oldprotocol.CardId = newprotocol.CardId;
            return oldprotocol;
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGPlayCardCostInfo? OldShiftToNew(OldProtos.GCGPlayCardCostInfo? oldprotocol)
        {
            if (oldprotocol == null) return null;
            NewProtos.GCGPlayCardCostInfo newprotocol = new();
            newprotocol.CardId = oldprotocol.CardId;
            handler_fuck.OldShiftToNew(oldprotocol.CostMap, newprotocol.CostList);
            return newprotocol;
        }

        #region JIT API
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGPlayCardCostInfo GetNewShiftToOldJitInstance()
        {
            NewProtos.GCGPlayCardCostInfo newprotocol = new();
            newprotocol.CardId = 20231024;
            newprotocol.CostList.Add(handler_fuck.GetNewShiftToOldJitInstance());
            return newprotocol;
        }
            
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override void RunJit()
        {
            var instance = GetNewShiftToOldJitInstance();
            OldShiftToNew(NewShiftToOld(instance.ToByteArray()));
            OldShiftToNew(new Span<byte>(NewShiftToOld(new Span<byte>(instance.ToByteArray())).ToByteArray()));
            OldShiftToNew(NewShiftToOld(instance.ToByteString()));
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
        public override IMessage? NewShiftToOld(ReadOnlySpan<byte> span)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));
            return rtn;
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
        public override IMessage? OldShiftToNew(ReadOnlySpan<byte> span)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));
            return rtn;
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override ByteString OldShiftToNew(ByteString bytes)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }

        private static HandlerGCGPlayCardCostInfo _globalOnlyInstance = new HandlerGCGPlayCardCostInfo();
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public static HandlerGCGPlayCardCostInfo GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
