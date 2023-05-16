using KcpCsharpTest;
using YYHEggEgg.Logger;
using System.Net.Sockets.Kcp;
using System.Buffers;
using System.Buffers.Binary;

// See https://aka.ms/new-console-template for more information
Log.Initialize(new LoggerConfig(
    max_Output_Char_Count: -1,
    use_Console_Wrapper: false,
    use_Working_Directory: true,
    global_Minimum_LogLevel: LogLevel.Verbose,
    console_Minimum_LogLevel: LogLevel.Verbose
));

Log.Info("Test Program for KumoKyaru/KCP (modified)");
Log.Info(KcpPacketAudit.Initialize());

#region Kcp Initialize
TestOutputCallback callback_client = new();
TestOutputCallback callback_server = new();
#if MIHOMO_KCP
Kcp<KcpSegment> cskcpHandle_client = new(Constants.global_kcp_conv, Constants.global_kcp_token, callback_client);
Kcp<KcpSegment> cskcpHandle_server = new(Constants.global_kcp_conv, Constants.global_kcp_token, callback_server);
#else
Kcp<KcpSegment> cskcpHandle_client = new(Constants.global_kcp_conv, callback_client);
Kcp<KcpSegment> cskcpHandle_server = new(Constants.global_kcp_conv, callback_server);
#endif
callback_client.sendToKcpInstance = cskcpHandle_server;
callback_server.sendToKcpInstance = cskcpHandle_client;

cskcpHandle_client.NoDelay(1, Constants.KCP_RefreshMilliseconds, 1, 1);
cskcpHandle_client.WndSize(Constants.global_wndsize, Constants.global_wndsize);
cskcpHandle_client.TraceListener = new LogTraceListener("KcpClient");
cskcpHandle_client.SegmentManager = new SimpleSegManager();

cskcpHandle_server.NoDelay(1, Constants.KCP_RefreshMilliseconds, 1, 1);
cskcpHandle_server.WndSize(Constants.global_wndsize, Constants.global_wndsize);
cskcpHandle_server.TraceListener = new LogTraceListener("KcpServer");
cskcpHandle_server.SegmentManager = new SimpleSegManager();

_ = Task.Run(() => BackgroundUpdate(cskcpHandle_client));
_ = Task.Run(() => BackgroundUpdate(cskcpHandle_server));
_ = Task.Run(() => BackgroundServerReceive());
_ = Task.Run(() => BackgroundClientReceive());
#region Update
async Task BackgroundUpdate(Kcp<KcpSegment> cskcpHandle)
{
    Log.Info($"{nameof(BackgroundUpdate)} thread started. ");
    while (true)
    {
        try
        {
            cskcpHandle.Update(DateTimeOffset.UtcNow);
            await Task.Delay(Constants.KCP_RefreshMilliseconds);
        }
        catch (Exception ex)
        {
            Log.Erro($"ikcp_update background meets error: {ex}", nameof(BackgroundUpdate));
        }
    }
}
void BackgroundServerReceive()
{
    Log.Info($"{nameof(BackgroundServerReceive)} thread started. ");
    Span<byte> baseBuffer = new Span<byte>(new byte[65507]);
    while (true)
    {
        try
        {
            int size = cskcpHandle_server.PeekSize();
            if (size >= 0)
            {
                int truesize = cskcpHandle_server.Recv(baseBuffer);
                if (size != truesize)
                {
                    Log.Erro($"Unexpected state, PeekSize: {size}, Recved size: {truesize}", nameof(BackgroundServerReceive));
                }
                Log.Info($"KcpServer received packet of {truesize} bytes, send back", nameof(BackgroundServerReceive));
                cskcpHandle_server.Send(baseBuffer.Slice(0, truesize));
            }
            Thread.Sleep(Constants.KCP_RefreshMilliseconds);
        }
        catch (Exception ex)
        {
            Log.Erro($"Server receiving meets error: {ex}", nameof(BackgroundServerReceive));
        }
    }
}
void BackgroundClientReceive()
{
    Log.Info($"{nameof(BackgroundClientReceive)} thread started. ");
    Span<byte> baseBuffer = new Span<byte>(new byte[65507]);
    while (true)
    {
        try
        {
            int size = cskcpHandle_client.PeekSize();
            if (size >= 0)
            {
                int truesize = cskcpHandle_client.Recv(baseBuffer);
                if (size != truesize)
                {
                    Log.Erro($"Unexpected state, PeekSize: {size}, Recved size: {truesize}", nameof(BackgroundClientReceive));
                }
                Log.Info($"KcpClient received packet of {truesize} bytes.", nameof(BackgroundClientReceive));
            }
            Thread.Sleep(Constants.KCP_RefreshMilliseconds);
        }
        catch (Exception ex)
        {
            Log.Erro($"Client receiving meets error: {ex}", nameof(BackgroundClientReceive));
        }
    }
}
#endregion
#endregion

byte[] rawPacket = Util.GeneratePacket(Constants.each_packet_size);

// 1. Normal packets
int sum_wait_ms = 0;
for (int i = 0; i < Constants.packet_repeat_time; i++)
{
    cskcpHandle_client.Send(rawPacket);
    sum_wait_ms += Constants.packet_interval_ms;
    if (sum_wait_ms >= 15) 
    {
        Thread.Sleep(sum_wait_ms);
        sum_wait_ms = 0;
    }
}

// 2. Random size packets
Memory<byte> rawMemoryPacket = new(rawPacket);
Random ran = new();
// sum_wait_ms = 0;
// for (int i = 0; i < Constants.packet_repeat_time; i++)
// {
//     _ = Task.Run(() => cskcpHandle_client.Send(rawMemoryPacket.Slice(
//         0, ran.Next(1, Constants.each_packet_size)).Span));
//     sum_wait_ms += Constants.packet_interval_ms;
//     if (sum_wait_ms >= 15) 
//     {
//         Thread.Sleep(sum_wait_ms);
//         sum_wait_ms = 0;
//     }
// }

// 3. Parallel input packets
sum_wait_ms = 0;
// Parallel.For(0, Constants.packet_repeat_time, async (i) =>
// {
//     _ = Task.Run(() => cskcpHandle_client.Send(rawMemoryPacket.Slice(
//         0, ran.Next(1, Constants.each_packet_size)).Span));
//     sum_wait_ms += Constants.packet_interval_ms;
//     if (sum_wait_ms >= 15)
//     {
//         await Task.Delay(sum_wait_ms);
//         sum_wait_ms = 0;
//     }
// });

// 4. Auditer check
#region False test data
#region Conv & Token
#if MIHOMO_KCP
Span<byte> kcpSegStart = new Span<byte>(new byte[sizeof(uint) * 2]);
#else
Span<byte> kcpSegStart = new Span<byte>(new byte[sizeof(uint)]);
#endif
BinaryPrimitives.WriteUInt32LittleEndian(kcpSegStart, Constants.global_kcp_conv);
#if MIHOMO_KCP
BinaryPrimitives.WriteUInt32LittleEndian(kcpSegStart.Slice(sizeof(uint)), Constants.global_kcp_token);
#endif
string kcpSegStartHex = Convert.ToHexString(kcpSegStart);
#endregion
#region Header (without uint len)
Span<byte> kcpHeaders = new Span<byte>(new byte[KcpConst.IKCP_OVERHEAD - sizeof(uint)]);
kcpSegStart.CopyTo(kcpHeaders);
int offset = kcpSegStart.Length;
// cmd
kcpHeaders[offset] = KcpConst.IKCP_CMD_PUSH;
offset += sizeof(byte);
// frg
kcpHeaders[offset] = 0;
offset += sizeof(byte);
// wnd
BinaryPrimitives.WriteUInt16LittleEndian(kcpHeaders.Slice(offset), Constants.global_wndsize);
offset += sizeof(ushort);
// ts
BinaryPrimitives.WriteUInt32LittleEndian(kcpHeaders.Slice(offset), 0);
offset += sizeof(uint);
// sn
BinaryPrimitives.WriteUInt32LittleEndian(kcpHeaders.Slice(offset), 0);
offset += sizeof(uint);
// una
BinaryPrimitives.WriteUInt32LittleEndian(kcpHeaders.Slice(offset), 0);
offset += sizeof(uint);
// len: customize

string kcpHeaderHex = Convert.ToHexString(kcpHeaders);
#endregion
string[] hexFalseKcpPackets = new string[]
{
    "FF000000EF000000", // invalid conv/token
    kcpHeaderHex, // invalid header
    string.Concat(kcpHeaderHex, "00000000"), // ok
    string.Concat(kcpHeaderHex, "14451100"), // len > actual (empty)
    string.Concat(kcpHeaderHex, "02000000", "456789AB"), // len < actual (4)
    string.Concat(kcpHeaderHex, "04000000", "456789AB"), // ok
    string.Concat(kcpHeaderHex, "08000000", "17082619"), // len > actual (4)
    string.Concat(kcpHeaderHex, "00000000", "01234567") // len < actual (4)
};
#endregion
#region Sender
void SendPacket(TestOutputCallback callback, byte[] buf)
{
    var bufferOwner = MemoryPool<byte>.Shared.Rent(buf.Length);
    buf.CopyTo(bufferOwner.Memory);
    callback.Output(bufferOwner, buf.Length, true);
}
foreach (var pkt in hexFalseKcpPackets)
    SendPacket(callback_client, Convert.FromHexString(pkt));
#endregion

Console.ReadLine();