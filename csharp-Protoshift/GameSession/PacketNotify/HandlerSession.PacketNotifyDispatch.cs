using System.Collections.Concurrent;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    public partial class HandlerSession
    {
        // Signal that whether the packet need to search
        // and invoke its notify method. The indexer is CmdId.
        private bool[] _oldpacket_notifylist = new bool[ushort.MaxValue];
        private bool[] _newpacket_notifylist = new bool[ushort.MaxValue];
        /// <summary>
        /// The list of actual notify methods. Param is packet (same as
        /// the proto), offset and length.<para/>
        /// The return value specifies whether the regular packet shifting
        /// and sending should be cancelled.
        /// If <see langword="false"/> is returned, the shifted packet
        /// will not be sent to the other side.
        /// </summary>
        private ConcurrentDictionary<string, Func<byte[], int, int, bool>> notifyInvokes = new();

        private void ConfigureInitialNotifyList()
        {
            PushNotifyStatus("GetPlayerTokenReq", false, true, GetPlayerTokenReqNotify);
            PushNotifyStatus("GetPlayerTokenRsp", true, false, GetPlayerTokenRspNotify);
            PushNotifyStatus("ClientSetGameTimeReq", false, true, ClientSetGameTimeReqNotify);
            PushNotifyStatus("ChangeGameTimeRsp", true, false, ChangeGameTimeRspNotify);
        }

        /// <summary>
        /// Push a callback to receive the packet notify.
        /// </summary>
        /// <param name="protoname">The packet proto name.</param>
        /// <param name="applyToOld">Whether to apply to packets sent by server.</param>
        /// <param name="applyToNew">Whether to apply to packets sent by client.</param>
        /// <param name="callback">The actual notify callback. Param is packet (same as
        /// the proto), offset and length. The return value specifies whether the regular packet shifting
        /// and sending should be cancelled. If <see langword="false"/> is returned, the shifted packet
        /// will not be sent to the other side.</param>
        /// <exception cref="InvalidOperationException"></exception>
        public void PushNotifyStatus(string protoname, bool applyToOld, bool applyToNew,
            Func<byte[], int, int, bool> callback)
        {
            if (!applyToOld && !applyToNew)
                throw new ArgumentException("Can't add a rule but apply it to none side of the proxy!");
            if (callback == null) throw new ArgumentNullException(nameof(callback));
            if (notifyInvokes.ContainsKey(protoname))
                throw new ArgumentException("The proto is already set to receive notify.");

            if (applyToOld)
            {
                var cmdid = (ushort)OldProtos.AskCmdId.GetCmdIdFromProtoname(protoname);
                _oldpacket_notifylist[cmdid] = true;
            }
            if (applyToNew)
            {
#if PROXY_ONLY_SERVER
                var cmdid = (ushort)OldProtos.AskCmdId.GetCmdIdFromProtoname(protoname);
#else
                var cmdid = (ushort)NewProtos.AskCmdId.GetCmdIdFromProtoname(protoname);
#endif
                _newpacket_notifylist[cmdid] = true;
            }
            notifyInvokes.TryAdd(protoname, callback);
        }

        /// <summary>
        /// Invoke the actual notify when Protoshift completed
        /// (but the packet has not been sent).<para/>
        /// The return value specifies whether the regular packet shifting
        /// should be cancelled. If <see langword="false"/> is returned,
        /// the shifted packet will not be sent to the other side.
        /// </summary>
        protected bool InvokeNotifyMiddleware(byte[] packet, string protoname,
            ushort cmdid, bool isNewCmdid, int body_offset, uint body_length)
        {
            if (isNewCmdid && !_newpacket_notifylist[cmdid]) return true;
            else if (!isNewCmdid && !_oldpacket_notifylist[cmdid]) return true;

            if (!notifyInvokes.TryGetValue(protoname, out var callback))
            {
                Log.Warn("Error: A packet is intended to invoke notify but cannot find target callback.", $"PacketHandler({_sessionId}):Notify");
                return true;
            }

            return callback(packet, body_offset, (int)body_length);
        }
    }
}
