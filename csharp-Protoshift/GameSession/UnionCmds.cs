using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession
{
    /// <summary>
    /// Used for special UnionCmdNotify shifting, to have a better efficiency.
    /// <para>What UnionCmdNotify does is to bind multiple packages into one UnionCmdNotify and send in one packet.</para>
    /// <para>It's obvious that each of them also needs to be Protoshifted.</para>
    /// <para>Notice that UnionCmdNotify should only be sent by client.</para>
    /// </summary>
    public static class UnionCmds
    {
        /// <summary>
        /// Serializer cache for fast CmdId queries. Notice that the ushort key refers to newcmdid.
        /// </summary>
        private static Dictionary<ushort, UnionCmdShiftUtils> serializers = new();
        private static MessageParser<NewProtos.UnionCmdNotify> newunionParser = 
            NewProtos.UnionCmdNotify.Parser;

        public static byte[] Shift(string newjson)
        {
            NewProtos.UnionCmdNotify newunionCmds = newunionParser.ParseJson(newjson);
            OldProtos.UnionCmdNotify oldunionCmds = new();

            foreach (var newmsg in newunionCmds.CmdList)
            {
                ushort newmsg_cmdid = (ushort)newmsg.MessageId;
                byte[] newmsg_body = newmsg.Body.ToByteArray();

                UnionCmdShiftUtils utils;
                #region Utils Chekc
                if (!serializers.ContainsKey(newmsg_cmdid))
                {
                    utils = new(newmsg_cmdid);
                    serializers.Add(newmsg_cmdid, utils);
                }
                else utils = serializers[newmsg_cmdid];
                #endregion

                ushort oldmsg_cmdid = utils.oldcmdid;
                byte[] oldmsg_body = utils.Protoshift(newmsg_body);
                oldunionCmds.CmdList.Add(new OldProtos.UnionCmd
                {
                    MessageId = oldmsg_cmdid,
                    Body = ByteString.FromBase64(Convert.ToBase64String(oldmsg_body))
                });
            }

            return MessageExtensions.ToByteArray(oldunionCmds);
        }
    }

    internal struct UnionCmdShiftUtils
    {
        public ushort newcmdid;
        public ushort oldcmdid;
        public OldProtos.ProtoSerialize oldserializer;
        public NewProtos.ProtoSerialize newserializer;
        public string protoname;
        /// <summary>
        /// If one of the two required protos are lost, then it will be marked true.
        /// </summary>
        public bool skip;

        public UnionCmdShiftUtils(ushort newcmdid)
        {
            this.newcmdid = newcmdid;
            try
            {
                NewProtos.QueryCmdId.TryGetSerializer(newcmdid, out newserializer);
                protoname = newserializer.Protoname;
                oldcmdid = (ushort)OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname);
                OldProtos.QueryCmdId.TryGetSerializer(oldcmdid, out oldserializer);
                skip = false;
            }
            catch (Exception ex)
            {
                Log.Erro($"Exception happened when initializing Proto newCmdId:{newcmdid}, " +
                    $"so it will be ignored in UnionCmdNotify!", "UnionCmdShiftUtils");
                Log.Erro($"{ex};\nInnerException:{ex.InnerException}", "UnionCmdShiftUtils");
                skip = true;
                oldserializer = new("GetPlayerTokenReq");
                newserializer = new("PlayerLoginRsp");
                protoname = "WR1tten by YYHEYggegg";
                oldcmdid = 6167;
            }
        }

        public byte[] Protoshift(byte[] newbody)
        {
            string newjson = newserializer.DeserializeToJson(newbody);
            byte[] oldbody = oldserializer.SerializeFromJson(newjson);
#if DEBUG
            string oldjson = oldserializer.DeserializeToJson(oldbody);
            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

            if (newlines.Length != oldlines.Length)
            {
                Log.Warn($"Packet {protoname}(Unioned) has an information lost in Protoshift:\n" +
                    $"new: {newjson}\nold: {oldjson}", $"UnionCmdHandler");
            }
#endif
            return oldbody;
        }
    }
}
