// <auto-generated>
//     Generated by csharp-Protoshift.HandlerGenerator. 
// </auto-generated>

#region Designer Generated Code
using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerUnionCmd 
        : HandlerBase<NewProtos.UnionCmd, OldProtos.UnionCmd>
    {
        #region Base Type
        MessageParser<NewProtos.UnionCmd> newproto_parser_base = NewProtos.UnionCmd.Parser;
        MessageParser<OldProtos.UnionCmd> oldproto_parser_base = OldProtos.UnionCmd.Parser;
        #endregion
        #region Import Types
        #endregion

        #region Protocol Shift
        public override OldProtos.UnionCmd NewShiftToOld(NewProtos.UnionCmd? newprotocol)
        {
            OldProtos.UnionCmd oldprotocol = new();
            if (newprotocol == null) return oldprotocol;
            if (oldprotocol.MessageId != 0 && !oldprotocol.Body.IsEmpty)
            {
                oldprotocol.MessageId = ShiftCmdId.NewShiftToOld(newprotocol.MessageId);
                oldprotocol.Body = ProtoshiftDispatch.NewShiftToOld(
                    newprotocol.MessageId, null, newprotocol.Body);
            }
            return oldprotocol;
        }

        public override NewProtos.UnionCmd OldShiftToNew(OldProtos.UnionCmd? oldprotocol)
        {
            NewProtos.UnionCmd newprotocol = new();
            if (oldprotocol == null) return newprotocol;
            if (oldprotocol.MessageId != 0 && !oldprotocol.Body.IsEmpty)
            {
                newprotocol.MessageId = ShiftCmdId.OldShiftToNew(oldprotocol.MessageId);
                newprotocol.Body = ProtoshiftDispatch.OldShiftToNew(
                    oldprotocol.MessageId, null, oldprotocol.Body);
            }
            return newprotocol;
        }
        #endregion

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

        private static HandlerUnionCmd _globalOnlyInstance = new HandlerUnionCmd();
        public static HandlerUnionCmd GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
#endregion Designer generated code
