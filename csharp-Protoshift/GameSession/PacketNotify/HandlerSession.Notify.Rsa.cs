﻿using AssetLib.Utils;
using csharp_Protoshift.Configuration;
using csharp_Protoshift.resLoader;
using Google.Protobuf;
using System.Security.Cryptography;
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
                PushPlayerStatLog("rsa_seed_exchange", "client_seed", $"succ|{Convert.ToHexString(client_seed)}", LogLevel.Debug);
            }
            catch
            {
                PushPlayerStatLog("rsa_seed_exchange", "client_seed", $"fail", LogLevel.Warning);
#if PROXY_ONLY_SERVER
                OldProtos.GetPlayerTokenRsp rsaFatalRsp = new();
#else
                NewProtos.GetPlayerTokenRsp rsaFatalRsp = new();
#endif
                rsaFatalRsp.Retcode = (int)OldProtos.Retcode.RetStopServer;
                rsaFatalRsp.Msg = "RSA Failure";
                rsaFatalRsp.StopServer = new()
                {
                    ContentMsg = "Crypto failure. Please confirm that your program is the right version.",
                    StopBeginTime = 1698076800,
                    StopEndTime = 3402230400,
                    Url = "https://sdl.moe/post/magic-sniffer/"
                };
                GameSessionDispatch.InjectPacketToClient(_sessionId,
                    nameof(OldProtos.GetPlayerTokenRsp), null, rsaFatalRsp.ToByteArray());
                Thread.Sleep(500);
                Program.ProxyServer.KickSession(_sessionId, client_reason: 15);
                return;
            }
        }

        private void GetPlayerTokenRspNotify(byte[] packet, int offset, int length)
        {
            var message = OldProtos.GetPlayerTokenRsp.Parser.ParseFrom(packet, offset, length);
            _uid = message.Uid;
            _player_statlog.LogSender = $"{_sessionId}|{_uid}";

            uint key_id = message.KeyId;
            try
            {
                server_seed = Resources.CPri[key_id].RsaDecrypt(
                    Convert.FromBase64String(message.ServerRandKey),
                    RSAEncryptionPadding.Pkcs1)
                    .Fill0(8);
            }
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex, $"PacketHandler({_sessionId})",
                    $"Decrypt server_seed failure. Please check resources/rsakeys/ClientPri.");
                PushPlayerStatLog("rsa_seed_exchange", "server_seed", $"fail", LogLevel.Error);
            }
            PushPlayerStatLog("rsa_seed_exchange", "server_seed", $"succ|{Convert.ToHexString(server_seed)}", LogLevel.Debug);
            
            ulong encrypt_seed = server_seed.GetUInt64(0) ^ client_seed.GetUInt64(0);
            PushPlayerStatLog("rsa_seed_exchange", "final_seed", $"succ|{encrypt_seed}", LogLevel.Debug); 
            
            _xorKey = Generate4096KeyByMT19937(encrypt_seed);
            PushPlayerStatLog("rsa_seed_exchange", "new_xorkey", Convert.ToHexString(_xorKey));

            GameSessionDispatch.BackgroundInjectOnlineExecuteWindys(_sessionId,
                OnlineExecWindyMode_v1_0_0.OnGetPlayerTokenFinish, "windyOnGetPlayerTokenFinish");
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
