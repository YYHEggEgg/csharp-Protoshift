using csharp_Protoshift.GameSession.SpecialFixs;
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
        private static Dictionary<ushort, ProtoShiftUtils> serializers = new();
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

                ProtoShiftUtils utils;
                #region Utils Chekc
                if (!serializers.ContainsKey(newmsg_cmdid))
                {
                    utils = new(newmsg_cmdid, true);
                    serializers.Add(newmsg_cmdid, utils);
                }
                else utils = serializers[newmsg_cmdid];
                #endregion

                newmsg_body = 

                ushort oldmsg_cmdid = utils.oldcmdid;
                byte[] oldmsg_body; 

                if (ExtraFix.NeedSpecialHandle(newmsg_cmdid, true))
                    oldmsg_body = ExtraFix.SpecialHandle(newmsg_cmdid, true, newmsg_body);
                else oldmsg_body = utils.NewShiftToOld(newmsg_body);
                
                oldunionCmds.CmdList.Add(new OldProtos.UnionCmd
                {
                    MessageId = oldmsg_cmdid,
                    Body = ByteString.FromBase64(Convert.ToBase64String(oldmsg_body))
                });
            }

            return MessageExtensions.ToByteArray(oldunionCmds);
        }
    }

    internal class ProtoShiftUtils
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

        public ProtoShiftUtils(ushort cmdid, bool isNewProtocol)
        {
            if (isNewProtocol)
            {
                newcmdid = cmdid;
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
                        $"so it will be ignored!", "ProtoShiftUtils");
                    Log.Erro($"{ex};\nInnerException:{ex.InnerException}", "ProtoShiftUtils");
                    skip = true;
                    oldserializer = new("GetPlayerTokenReq");
                    newserializer = new("PlayerLoginRsp");
                    protoname = "WR1tten by YYHEYggegg";
                    oldcmdid = 6167;
                }
            }
            else
            {
                oldcmdid = cmdid;
                try
                {
                    OldProtos.QueryCmdId.TryGetSerializer(oldcmdid, out oldserializer);
                    protoname = oldserializer.Protoname;
                    newcmdid = (ushort)NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname);
                    NewProtos.QueryCmdId.TryGetSerializer(newcmdid, out newserializer);
                    skip = false;
                }
                catch (Exception ex)
                {
                    Log.Erro($"Exception happened when initializing Proto oldCmdId:{oldcmdid}, " +
                        $"so it will be ignored!", "ProtoShiftUtils");
                    Log.Erro($"{ex};\nInnerException:{ex.InnerException}", "ProtoShiftUtils");
                    skip = true;
                    oldserializer = new("GetPlayerTokenReq");
                    newserializer = new("PlayerLoginRsp");
                    protoname = "WR1tten by YYHEYggegg";
                    newcmdid = 6167;
                }
            }
        }

        /// <summary>
        /// Warning: using this initializer means that you accept CmdId to be invalid when not exist.
        /// </summary>
        /// <param name="protoname"></param>
        public ProtoShiftUtils(string? protoname)
        {
            try
            {
                if (protoname == null)
                {
                    throw new ArgumentNullException(nameof(protoname));
                }
                this.protoname = protoname;
                OldProtos.QueryCmdId.TryGetSerializer(protoname, out oldserializer);
                NewProtos.QueryCmdId.TryGetSerializer(protoname, out newserializer);
                try
                {
                    oldcmdid = (ushort)OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname);
                    newcmdid = (ushort)NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname);
                }
                catch 
                {
                    newcmdid = oldcmdid = 11451;
                }
                skip = false;
            }
            catch (Exception ex)
            {
                Log.Erro($"Exception happened when initializing Proto Name:{protoname}, " +
                    $"so it will be ignored!", "ProtoShiftUtils");
                Log.Erro($"{ex};\nInnerException:{ex.InnerException}", "ProtoShiftUtils");
                this.protoname = "WR1tten by YYHEYggegg";
                skip = true;
                oldserializer = new("GetPlayerTokenReq");
                newserializer = new("PlayerLoginRsp");
                newcmdid = 6167;
                oldcmdid = 8431;
            }
        }

        public byte[] NewShiftToOld(byte[] newbody)
        {
            if (skip) return newbody;

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

        public byte[] OldShiftToNew(byte[] oldbody)
        {
            if (skip) return oldbody;

            string oldjson = oldserializer.DeserializeToJson(oldbody);
            byte[] newbody = newserializer.SerializeFromJson(oldjson);
#if DEBUG
            string newjson = newserializer.DeserializeToJson(newbody);
            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

            if (newlines.Length != oldlines.Length)
            {
                Log.Warn($"Packet {protoname}(Unioned) has an information lost in Protoshift:\n" +
                    $"new: {newjson}\nold: {oldjson}", $"UnionCmdHandler");
            }
#endif
            return newbody;
        }

        public string GetJson(byte[] data, bool isNewProto)
        {
            if (skip) return "{  }";
            return isNewProto ? newserializer.DeserializeToJson(data) : oldserializer.DeserializeToJson(data);
        }
    }
}
