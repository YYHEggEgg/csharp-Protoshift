using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// the proto), offset and length.
        /// </summary>
        private ConcurrentDictionary<string, Action<byte[], int, int>> notifyInvokes = new();

        private void ConfigureInitialNotifyList()
        {
            PushNotifyStatus("GetPlayerTokenReq", false, true, GetPlayerTokenReqNotify);
            PushNotifyStatus("GetPlayerTokenRsp", true, false, GetPlayerTokenRspNotify);
        }

        /// <summary>
        /// Push a callback to receive the packet notify.
        /// </summary>
        /// <param name="protoname">The packet proto name.</param>
        /// <param name="applyToOld">Whether to apply to packets sent by server.</param>
        /// <param name="applyToNew">Whether to apply to packets sent by client.</param>
        /// <param name="callback">The actual notify callback. Param is packet (same as
        /// the proto), offset and length.</param>
        /// <exception cref="InvalidOperationException"></exception>
        public void PushNotifyStatus(string protoname, bool applyToOld, bool applyToNew,
            Action<byte[], int, int> callback)
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
        /// (but the packet has not been sent).
        /// </summary>
        protected void InvokeNotifyMiddleware(byte[] packet, string protoname,
            ushort cmdid, bool isNewCmdid, int body_offset, uint body_length)
        {
            if (isNewCmdid && !_newpacket_notifylist[cmdid]) return;
            else if (!isNewCmdid && !_oldpacket_notifylist[cmdid]) return;

            if (!notifyInvokes.TryGetValue(protoname, out var callback))
            {
                Log.Warn("Error: A packet is intended to invoke notify but cannot find target callback.", $"PacketHandler({_sessionId}):Notify");
                return;
            }

            callback(packet, body_offset, (int)body_length);
        }
    }
}
