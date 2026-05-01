using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession;

public partial class HandlerSession
{
    protected uint _3400_clientGameTime;
    protected uint _3400_targetGameTime;

    private bool ClientSetGameTimeReqNotify(byte[] packet, int offset, int length)
    {
#if PROXY_ONLY_SERVER
        var message = OldProtos.ClientSetGameTimeReq.Parser.ParseFrom(packet, offset, length);
#else
        var message = NewProtos.ClientSetGameTimeReq.Parser.ParseFrom(packet, offset, length);
#endif
        _3400_clientGameTime = message.ClientGameTime;
        _3400_targetGameTime = message.GameTime;

        var delta = message.GameTime - message.ClientGameTime;
#if PROXY_ONLY_SERVER
        var converted = new OldProtos.ChangeGameTimeReq()
#else
        var converted = new NewProtos.ChangeGameTimeReq()
#endif
        {
            ExtraDays = delta / 1440,
            GameTime = message.GameTime % 1440,
            IsForceSet = message.IsForceSet,
        };
        GameSessionDispatch.InjectPacketToServer(_sessionId,
            "ChangeGameTimeReq", null, converted.ToByteArray());

        PushPlayerStatLog("3.4_clientSetGameTime_middleware", "client_ClientSetGameTimeReq",
            $"recv_clientGameTime={message.ClientGameTime}|recv_gameTime={message.GameTime}|isForceSet={message.IsForceSet}" +
            $"|sent_extraDays={converted.ExtraDays}|sent_gameTime={converted.GameTime}");
        return false;
    }

    private bool ChangeGameTimeRspNotify(byte[] packet, int offset, int length)
    {
        var message = OldProtos.ChangeGameTimeRsp.Parser.ParseFrom(packet, offset, length);
#if PROXY_ONLY_SERVER
        var converted = new OldProtos.ClientSetGameTimeRsp()
#else
        var converted = new NewProtos.ClientSetGameTimeRsp()
#endif
        {
            Retcode = message.Retcode,
            ClientGameTime = _3400_clientGameTime,
            GameTime = _3400_targetGameTime,
        };
        GameSessionDispatch.InjectPacketToClient(_sessionId,
            "ClientSetGameTimeRsp", null, converted.ToByteArray());

        PushPlayerStatLog("3.4_clientSetGameTime_middleware", "server_ChangeGameTimeRsp",
            $"retcode={message.Retcode}|recv_curGameTime={message.CurGameTime}|recv_extraDays={message.ExtraDays}" +
            $"|sent_clientGameTime={converted.ClientGameTime}|sent_gameTime={converted.GameTime}");
        return false;
    }
}
