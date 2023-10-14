using AssetLib.Utils;
using csharp_Protoshift.Configuration;
using csharp_Protoshift.resLoader;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    public partial class HandlerSession
    {
        protected byte[] client_seed;
        protected byte[] server_seed;

        private void GetPlayerTokenReqNotify(byte[] packet, int offset, int length)
        {
#if PROXY_ONLY_SERVER
            var message = OldProtos.GetPlayerTokenReq.Parser.ParseFrom(packet, offset, length);
#else
            var message = NewProtos.GetPlayerTokenReq.Parser.ParseFrom(packet, offset, length);
#endif
            uint key_id = message.KeyId;
            try
            {
                client_seed = Resources.SPri[key_id].RsaDecrypt(
                    Convert.FromBase64String(message.ClientRandKey),
                    RSAEncryptionPadding.Pkcs1)
                    .Fill0(8);
            }
            catch
            {
#if PROXY_ONLY_SERVER
                OldProtos.GetPlayerTokenRsp rsaFatalRsp = new();
#else
                NewProtos.GetPlayerTokenRsp rsaFatalRsp = new();
#endif
                rsaFatalRsp.Retcode = (int)OldProtos.Retcode.RetSecurityLibraryError;
                rsaFatalRsp.Msg = "Crypto failure. Please confirm that your program is the right version.";
                GameSessionDispatch.InjectPacketToClient(_sessionId,
                    nameof(OldProtos.GetPlayerTokenRsp), null, rsaFatalRsp.ToByteArray());
                Program.ProxyServer.KickSession(_sessionId, client_reason: 5);
                return;
            }
        }

        private void GetPlayerTokenRspNotify(byte[] packet, int offset, int length)
        {
            var message = OldProtos.GetPlayerTokenRsp.Parser.ParseFrom(packet, offset, length);
            uint key_id = message.KeyId;
            server_seed = Resources.CPri[key_id].RsaDecrypt(
                Convert.FromBase64String(message.ServerRandKey),
                RSAEncryptionPadding.Pkcs1)
                .Fill0(8);
            ulong encrypt_seed = server_seed.GetUInt64(0) ^ client_seed.GetUInt64(0);
            _xorKey = Generate4096KeyByMT19937(encrypt_seed);
            _uid = message.Uid;
            Log.Info($"IMPORTANT: New XOR Key built{Environment.NewLine}" +
                $"-----BEGIN HEX New 4096 XOR Key-----{Environment.NewLine}" +
                Convert.ToHexString(_xorKey) +
                $"{Environment.NewLine}-----END HEX New 4096 XOR Key-----", $"HandlerSession({_sessionId})");
            if (GameSessionDispatch.OnlineExecWindyMode == OnlineExecWindyMode_v1_0_0.OnGetPlayerTokenFinish)
            {
                _ = Task.Run(async () =>
                {
                    // GetPlayerTokenRsp MUST BE earlier than WindSeedClientNotify
                    await Task.Delay(1500);
                    try
                    {
                        await GameSessionDispatch.InjectOnlineExecuteWindy(_sessionId);
                        Log.Info($"Successfully sent windy lua: " +
                            Path.GetFileNameWithoutExtension(Config.Global.WindyConfig.OnlineExecWindyLua) +
                            $" to session id: {_sessionId}, IP: {remoteIp}.", "windyOnGetPlayerTokenFinish_AsyncTask");
                    }
                    catch (Exception ex)
                    {
                        LogTrace.WarnTrace(ex, "windyOnGetPlayerTokenFinish_AsyncTask", $"Windy auto-execute failed. ");
                    }
                });
            }
        }

        public static byte[] Generate4096KeyByMT19937(ulong seed)
        {
            MT19937_64 mt1 = new(seed);
            ulong mt2seed = mt1.Int64();
            MT19937_64 mt2 = new(mt2seed);
            mt2.Int64();
            byte[] key = new byte[4096];
            for (int i = 0; i < key.Length; i += 8)
            {
                ulong newui64 = mt2.Int64();
                key.SetUInt64(i, newui64);
            }
            return key;
        }
    }
}
