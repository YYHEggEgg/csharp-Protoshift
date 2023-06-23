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
    public static class ProtoshiftDispatch
    {
        /// <summary>
        /// Protoshift a base packet from client.
        /// </summary>
        /// <param name="cmdid">The cmd_id to dispatch the packet.</param>
        /// <param name="head">The head (for dispatching packet). If not providing head, it may be set null. </param>
        /// <param name="head_offset">The offset of the <paramref name="head"/>. If not providing head, it may be set null. </param>
        /// <param name="head_length">The valid length of the <paramref name="head"/>. If not providing head, it may be set null. </param>
        /// <param name="body">The main body (protobuf).</param>
        /// <param name="body_offset">The offset of the <paramref name="body"/>.</param>
        /// <param name="body_length">The valid length of the <paramref name="body"/>.</param>
        /// <returns>The protobuf with OldProtos, can be sent to server.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="head"/> is not null, but provided null for <paramref name="head_length"/> or <paramref name="head_offset"/>.</exception>
        /// <exception cref="ArgumentException">Provided offset & length exceeded the readable length.</exception>
        /// <exception cref="NotSupportedException">The input <paramref name="cmdid"/> is not supported to be Protoshifted.</exception>
        public static byte[] NewShiftToOld(uint cmdid, 
            byte[]? head, int? head_offset, int? head_length, 
            byte[] body, int body_offset, int body_length)
        {
            #region Checks
            if (head != null)
            {
                if (head_offset == null)
                    throw new ArgumentNullException(nameof(head_offset), "Given head but provided offset with null.");
                if (head_length == null)
                    throw new ArgumentNullException(nameof(head_length), "Given head but provided length with null.");
                if (head_offset + head_length > head.Length)
                {
                    throw new ArgumentException("The reported head offset+length exceeded the actual length.", nameof(head));
                }
            }
            if (body_offset + body_length > body.Length)
            {
                throw new ArgumentException("The reported body offset+length exceeded the actual length.", nameof(body));
            }
            #endregion
            switch (cmdid) 
            {
                // For convience, the following code is marked as 'merge - Generated Code'.
                // In the 'merge code region', if you want to modify some code:
                // First, find the proto name & cmdid you want to modify;
                // Second, write the proto name at the comment;
                // Third, write '- merge - ignore case';
                // Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.
                // 
                // NOTICE: If you modified the code here, you may also do the same change
                //         in the implement below in different reloads. 
                // 
                // NOTICE 2: Change code here is very unconvenient. 
                //           It's suggested to change in the Handler. 
                //
                // Below is mergable region
                /**********Start mergable region --- DO NOT EDIT THIS LINE**********/
                case 1127: // merge - Generated Code
                    return new HandlerAbilityChangeNotify().NewShiftToOld(body, body_offset, body_length); // merge - Generated Code
                case 1200: // merge - Generated Code
                    return new HandlerAbilityInvocationFailNotify().NewShiftToOld(body, body_offset, body_length); // merge - Generated Code
                case 42: // UnionCmdNotify - merge - ignore case
                    NewProtos.UnionCmdNotify unionCmds = 
                        NewProtos.UnionCmdNotify.Parser.ParseFrom(body, body_offset, body_length);
                    OldProtos.UnionCmdNotify res = new();
                    foreach (var cmdPair in unionCmds.CmdList)
                    {
                        uint cmd_id = ShiftCmdId.NewShiftToOld(cmdPair.MessageId);
                        ByteString cmd_body = NewShiftToOld(cmdPair.MessageId, null, cmdPair.Body);
                        res.CmdList.Add(new OldProtos.UnionCmd { MessageId = cmd_id, Body = cmd_body });
                    }
                    return res.ToByteArray();
                // ...
                /***********End mergable region --- DO NOT EDIT THIS LINE***********/
                default: 
                    throw new NotSupportedException("The input cmdid is not supported to be Protoshifted.");
            }
        }

        /// <summary>
        /// Protoshift a base packet from client.
        /// </summary>
        /// <param name="cmdid">The cmd_id to dispatch the packet.</param>
        /// <param name="head">The head (for dispatching packet). If not providing head, it may be set empty. </param>
        /// <param name="body">The main body (protobuf).</param>
        /// <returns>The protobuf with OldProtos, can be sent to server.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="head"/> is not null, but provided null for <paramref name="head_length"/> or <paramref name="head_offset"/>.</exception>
        /// <exception cref="ArgumentException">Provided offset & length exceeded the readable length.</exception>
        /// <exception cref="NotSupportedException">The input <paramref name="cmdid"/> is not supported to be Protoshifted.</exception>
        public static byte[] NewShiftToOld(uint cmdid, ReadOnlySpan<byte> head, ReadOnlySpan<byte> body)
        {
            switch (cmdid)
            {
                // For convience, the following code is marked as 'merge - Generated Code'.
                // In the 'merge code region', if you want to modify some code:
                // First, find the proto name & cmdid you want to modify;
                // Second, write the proto name at the comment;
                // Third, write '- merge - ignore case';
                // Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.
                // 
                // NOTICE: If you modified the code here, you may also do the same change
                //         in the implement below in different reloads. 
                // 
                // NOTICE 2: Change code here is very unconvenient. 
                //           It's suggested to change in the Handler. 
                //
                // Below is mergable region
                /**********Start mergable region --- DO NOT EDIT THIS LINE**********/
                case 1127: // merge - Generated Code
                    return new HandlerAbilityChangeNotify().NewShiftToOld(body); // merge - Generated Code
                case 1200: // merge - Generated Code
                    return new HandlerAbilityInvocationFailNotify().NewShiftToOld(body); // merge - Generated Code
                case 42: // UnionCmdNotify - merge - ignore case
                    NewProtos.UnionCmdNotify unionCmds =
                        NewProtos.UnionCmdNotify.Parser.ParseFrom(body);
                    OldProtos.UnionCmdNotify res = new();
                    foreach (var cmdPair in unionCmds.CmdList)
                    {
                        uint cmd_id = ShiftCmdId.NewShiftToOld(cmdPair.MessageId);
                        ByteString cmd_body = NewShiftToOld(cmdPair.MessageId, null, cmdPair.Body);
                        res.CmdList.Add(new OldProtos.UnionCmd { MessageId = cmd_id, Body = cmd_body });
                    }
                    return res.ToByteArray();
                // ...
                /***********End mergable region --- DO NOT EDIT THIS LINE***********/
                default:
                    throw new NotSupportedException("The input cmdid is not supported to be Protoshifted.");
            }
        }

        /// <summary>
        /// Protoshift a base packet from client.
        /// </summary>
        /// <param name="cmdid">The cmd_id to dispatch the packet.</param>
        /// <param name="head">The head (for dispatching packet). If not providing head, it may be set null. </param>
        /// <param name="body">The main body (protobuf).</param>
        /// <returns>The protobuf with OldProtos, can be sent to server.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="head"/> is not null, but provided null for <paramref name="head_length"/> or <paramref name="head_offset"/>.</exception>
        /// <exception cref="ArgumentException">Provided offset & length exceeded the readable length.</exception>
        /// <exception cref="NotSupportedException">The input <paramref name="cmdid"/> is not supported to be Protoshifted.</exception>
        public static ByteString NewShiftToOld(uint cmdid, ByteString? head, ByteString body)
        {
            switch (cmdid)
            {
                // For convience, the following code is marked as 'merge - Generated Code'.
                // In the 'merge code region', if you want to modify some code:
                // First, find the proto name & cmdid you want to modify;
                // Second, write the proto name at the comment;
                // Third, write '- merge - ignore case';
                // Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.
                // 
                // NOTICE: If you modified the code here, you may also do the same change
                //         in the implement below in different reloads. 
                // 
                // NOTICE 2: Change code here is very unconvenient. 
                //           It's suggested to change in the Handler. 
                //
                // Below is mergable region
                /**********Start mergable region --- DO NOT EDIT THIS LINE**********/
                case 1127: // merge - Generated Code
                    return new HandlerAbilityChangeNotify().NewShiftToOld(body); // merge - Generated Code
                case 1200: // merge - Generated Code
                    return new HandlerAbilityInvocationFailNotify().NewShiftToOld(body); // merge - Generated Code
                case 42: // UnionCmdNotify - merge - ignore case
                    NewProtos.UnionCmdNotify unionCmds =
                        NewProtos.UnionCmdNotify.Parser.ParseFrom(body);
                    OldProtos.UnionCmdNotify res = new();
                    foreach (var cmdPair in unionCmds.CmdList)
                    {
                        uint cmd_id = ShiftCmdId.NewShiftToOld(cmdPair.MessageId);
                        ByteString cmd_body = NewShiftToOld(cmdPair.MessageId, null, cmdPair.Body);
                        res.CmdList.Add(new OldProtos.UnionCmd { MessageId = cmd_id, Body = cmd_body });
                    }
                    return res.ToByteString();
                // ...
                /***********End mergable region --- DO NOT EDIT THIS LINE***********/
                default:
                    throw new NotSupportedException("The input cmdid is not supported to be Protoshifted.");
            }
        }

        /// <summary>
        /// Protoshift a base packet from server.
        /// </summary>
        /// <param name="cmdid">The cmd_id to dispatch the packet.</param>
        /// <param name="head">The head (for dispatching packet). If not providing head, it may be set null. </param>
        /// <param name="head_offset">The offset of the <paramref name="head"/>. If not providing head, it may be set null. </param>
        /// <param name="head_length">The valid length of the <paramref name="head"/>. If not providing head, it may be set null. </param>
        /// <param name="body">The main body (protobuf).</param>
        /// <param name="body_offset">The offset of the <paramref name="body"/>.</param>
        /// <param name="body_length">The valid length of the <paramref name="body"/>.</param>
        /// <returns>The protobuf with NewProtos, can be sent to client.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="head"/> is not null, but provided null for <paramref name="head_length"/> or <paramref name="head_offset"/>.</exception>
        /// <exception cref="ArgumentException">Provided offset & length exceeded the readable length.</exception>
        /// <exception cref="NotSupportedException">The input <paramref name="cmdid"/> is not supported to be Protoshifted.</exception>
        public static byte[] OldShiftToNew(uint cmdid,
            byte[]? head, int? head_offset, int? head_length,
            byte[] body, int body_offset, int body_length)
        {
            #region Checks
            if (head != null)
            {
                if (head_offset == null)
                    throw new ArgumentNullException(nameof(head_offset), "Given head but provided offset with null.");
                if (head_length == null)
                    throw new ArgumentNullException(nameof(head_length), "Given head but provided length with null.");
                if (head_offset + head_length > head.Length)
                {
                    throw new ArgumentException("The reported head offset+length exceeded the actual length.", nameof(head));
                }
            }
            if (body_offset + body_length > body.Length)
            {
                throw new ArgumentException("The reported body offset+length exceeded the actual length.", nameof(body));
            }
            #endregion
            switch (cmdid)
            {
                // For convience, the following code is marked as 'merge - Generated Code'.
                // In the 'merge code region', if you want to modify some code:
                // First, find the proto name & cmdid you want to modify;
                // Second, write the proto name at the comment;
                // Third, write '- merge - ignore case';
                // Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.
                // 
                // NOTICE: If you modified the code here, you may also do the same change
                //         in the implement below in different reloads. 
                // 
                // NOTICE 2: Change code here is very unconvenient. 
                //           It's suggested to change in the Handler. 
                //
                // Below is mergable region
                /**********Start mergable region --- DO NOT EDIT THIS LINE**********/
                case 1131: // merge - Generated Code
                    return new HandlerAbilityChangeNotify().OldShiftToNew(body, body_offset, body_length); // merge - Generated Code
                case 1107: // merge - Generated Code
                    return new HandlerAbilityInvocationFailNotify().OldShiftToNew(body, body_offset, body_length); // merge - Generated Code
                case 5: // UnionCmdNotify - merge - ignore case
                    OldProtos.UnionCmdNotify unionCmds =
                        OldProtos.UnionCmdNotify.Parser.ParseFrom(body, body_offset, body_length);
                    NewProtos.UnionCmdNotify res = new();
                    foreach (var cmdPair in unionCmds.CmdList)
                    {
                        uint cmd_id = ShiftCmdId.OldShiftToNew(cmdPair.MessageId);
                        ByteString cmd_body = OldShiftToNew(cmdPair.MessageId, null, cmdPair.Body);
                        res.CmdList.Add(new NewProtos.UnionCmd { MessageId = cmd_id, Body = cmd_body });
                    }
                    return res.ToByteArray();
                // ...
                /***********End mergable region --- DO NOT EDIT THIS LINE***********/
                default:
                    throw new NotSupportedException("The input cmdid is not supported to be Protoshifted.");
            }
        }

        /// <summary>
        /// Protoshift a base packet from server.
        /// </summary>
        /// <param name="cmdid">The cmd_id to dispatch the packet.</param>
        /// <param name="head">The head (for dispatching packet). If not providing head, it may be set empty. </param>
        /// <param name="body">The main body (protobuf).</param>
        /// <returns>The protobuf with NewProtos, can be sent to client.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="head"/> is not null, but provided null for <paramref name="head_length"/> or <paramref name="head_offset"/>.</exception>
        /// <exception cref="ArgumentException">Provided offset & length exceeded the readable length.</exception>
        /// <exception cref="NotSupportedException">The input <paramref name="cmdid"/> is not supported to be Protoshifted.</exception>
        public static byte[] OldShiftToNew(uint cmdid, ReadOnlySpan<byte> head, ReadOnlySpan<byte> body)
        {
            switch (cmdid)
            {
                // For convience, the following code is marked as 'merge - Generated Code'.
                // In the 'merge code region', if you want to modify some code:
                // First, find the proto name & cmdid you want to modify;
                // Second, write the proto name at the comment;
                // Third, write '- merge - ignore case';
                // Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.
                // 
                // NOTICE: If you modified the code here, you may also do the same change
                //         in the implement below in different reloads. 
                // 
                // NOTICE 2: Change code here is very unconvenient. 
                //           It's suggested to change in the Handler. 
                //
                // Below is mergable region
                /**********Start mergable region --- DO NOT EDIT THIS LINE**********/
                case 1131: // merge - Generated Code
                    return new HandlerAbilityChangeNotify().OldShiftToNew(body); // merge - Generated Code
                case 1107: // merge - Generated Code
                    return new HandlerAbilityInvocationFailNotify().OldShiftToNew(body); // merge - Generated Code
                case 5: // UnionCmdNotify - merge - ignore case
                    OldProtos.UnionCmdNotify unionCmds =
                        OldProtos.UnionCmdNotify.Parser.ParseFrom(body);
                    NewProtos.UnionCmdNotify res = new();
                    foreach (var cmdPair in unionCmds.CmdList)
                    {
                        uint cmd_id = ShiftCmdId.OldShiftToNew(cmdPair.MessageId);
                        ByteString cmd_body = OldShiftToNew(cmdPair.MessageId, null, cmdPair.Body);
                        res.CmdList.Add(new NewProtos.UnionCmd { MessageId = cmd_id, Body = cmd_body });
                    }
                    return res.ToByteArray();
                // ...
                /***********End mergable region --- DO NOT EDIT THIS LINE***********/
                default:
                    throw new NotSupportedException("The input cmdid is not supported to be Protoshifted.");
            }
        }

        /// <summary>
        /// Protoshift a base packet from server.
        /// </summary>
        /// <param name="cmdid">The cmd_id to dispatch the packet.</param>
        /// <param name="head">The head (for dispatching packet). If not providing head, it may be set null. </param>
        /// <param name="body">The main body (protobuf).</param>
        /// <returns>The protobuf with NewProtos, can be sent to client.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="head"/> is not null, but provided null for <paramref name="head_length"/> or <paramref name="head_offset"/>.</exception>
        /// <exception cref="ArgumentException">Provided offset & length exceeded the readable length.</exception>
        /// <exception cref="NotSupportedException">The input <paramref name="cmdid"/> is not supported to be Protoshifted.</exception>
        public static ByteString OldShiftToNew(uint cmdid, ByteString? head, ByteString body)
        {
            switch (cmdid)
            {
                // For convience, the following code is marked as 'merge - Generated Code'.
                // In the 'merge code region', if you want to modify some code:
                // First, find the proto name & cmdid you want to modify;
                // Second, write the proto name at the comment;
                // Third, write '- merge - ignore case';
                // Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.
                // 
                // NOTICE: If you modified the code here, you may also do the same change
                //         in the implement below in different reloads. 
                // 
                // NOTICE 2: Change code here is very unconvenient. 
                //           It's suggested to change in the Handler. 
                //
                // Below is mergable region
                /**********Start mergable region --- DO NOT EDIT THIS LINE**********/
                case 1127: // merge - Generated Code
                    return new HandlerAbilityChangeNotify().OldShiftToNew(body); // merge - Generated Code
                case 1200: // merge - Generated Code
                    return new HandlerAbilityInvocationFailNotify().OldShiftToNew(body); // merge - Generated Code
                case 42: // UnionCmdNotify - merge - ignore case
                    OldProtos.UnionCmdNotify unionCmds =
                        OldProtos.UnionCmdNotify.Parser.ParseFrom(body);
                    NewProtos.UnionCmdNotify res = new();
                    foreach (var cmdPair in unionCmds.CmdList)
                    {
                        uint cmd_id = ShiftCmdId.OldShiftToNew(cmdPair.MessageId);
                        ByteString cmd_body = OldShiftToNew(cmdPair.MessageId, null, cmdPair.Body);
                        res.CmdList.Add(new NewProtos.UnionCmd { MessageId = cmd_id, Body = cmd_body });
                    }
                    return res.ToByteString();
                // ...
                /***********End mergable region --- DO NOT EDIT THIS LINE***********/
                default:
                    throw new NotSupportedException("The input cmdid is not supported to be Protoshifted.");
            }
        }
    }
}
#nullable disable
#endregion Designer Generated Code