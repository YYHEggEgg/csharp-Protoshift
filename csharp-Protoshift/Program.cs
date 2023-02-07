using csharp_Protoshift.AnimeGameKCP;
using csharp_Protoshift.Commands;
using csharp_Protoshift.GameSession;
using csharp_Protoshift.KcpProxy;
using csharp_Protoshift.resLoader;
using System.Net;
using System.Numerics;
using System.Text;
using YSFreedom.Common.Net;
using YSFreedom.Common.Util;

namespace csharp_Protoshift
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ResourcesLoader.CheckForRequiredResources();
            await ResourcesLoader.Load();

            var kcpServer = new KCPServer(new IPEndPoint(IPAddress.Loopback, 20102));
            var kcpProxy = new KcpProxyServer(new IPEndPoint(IPAddress.Loopback, 22102),
                new IPEndPoint(IPAddress.Parse("192.168.127.130"), 20041));

            kcpProxy.StartProxy(GameSessionDispatch.HandleServerPacket,
                GameSessionDispatch.HandleClientPacket);

            Log.Info("Ready! Type 'help' to get command help.");

            await CommandLine.Start();
        }
    }
}