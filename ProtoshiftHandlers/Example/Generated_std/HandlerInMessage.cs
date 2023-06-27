// Below is human-written, acting as an generated code example.
// 
// ------------------------------------------------------------
//
// <auto-generated>
//     Generated by csharp-Protoshift.HandlerGenerator. 
// </auto-generated>

#nullable enable
#region Designer Generated Code
using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerInMessage 
        : HandlerBase<NewProtos.InMessage, OldProtos.InMessage>
    {
        #region Base Type
        MessageParser<NewProtos.InMessage> newproto_parser_base = NewProtos.InMessage.Parser;
        MessageParser<OldProtos.InMessage> oldproto_parser_base = OldProtos.InMessage.Parser;
        #endregion
        #region Import Types
        #endregion

        #region Protocol shift
        public override OldProtos.InMessage NewShiftToOld(NewProtos.InMessage? newprotocol)
        {
            OldProtos.InMessage oldprotocol = new();
            if (newprotocol == null) return oldprotocol;
            oldprotocol.InStr = newprotocol.InStr;
            oldprotocol.Code = newprotocol.Code;
            return oldprotocol;
        }

        public override NewProtos.InMessage OldShiftToNew(OldProtos.InMessage? oldprotocol)
        {
            NewProtos.InMessage newprotocol = new();
            if (oldprotocol == null) return newprotocol;
            newprotocol.InStr = oldprotocol.InStr;
            newprotocol.Code = oldprotocol.Code;
            return newprotocol;
        }
        #endregion

        #region Outer bytes invoke
        public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
            => NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
        public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)
            => NewShiftToOld(newproto_parser_base.ParseFrom(span)).ToByteArray();
        public override ByteString NewShiftToOld(ByteString bytes)
            => NewShiftToOld(newproto_parser_base.ParseFrom(bytes).ToByteString());
        public override byte[] OldShiftToNew(byte[] arr, int offset, int length)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
        public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(span)).ToByteArray();
        public override ByteString OldShiftToNew(ByteString bytes)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(bytes).ToByteString());
        #endregion

        private static HandlerInMessage _globalOnlyInstance = new HandlerInMessage();
        public static HandlerInMessage GlobalInstance => _globalOnlyInstance;
    }
}
#endregion Designer generated code