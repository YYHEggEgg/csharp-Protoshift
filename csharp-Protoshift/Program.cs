using csharp_Protoshift.Commands;
using csharp_Protoshift.Enhanced.Handlers.GeneratedCode;
using csharp_Protoshift.GameSession;
using csharp_Protoshift.MhyKCP.Proxy;
using csharp_Protoshift.resLoader;
using csharp_Protoshift.SkillIssue;
using OfficeOpenXml;
using System.Net;
using YYHEggEgg.Logger;

namespace csharp_Protoshift
{
    internal class Program
    {
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public static KcpProxyServer ProxyServer { get; private set; }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。

        static async Task Main(string[] args)
        {
            StartupWorkingDirChanger.ChangeToDotNetRunPath(new LoggerConfig(
                max_Output_Char_Count: 16 * 1024,
                use_Console_Wrapper: true,
                use_Working_Directory: true,
#if DEBUG
                global_Minimum_LogLevel: LogLevel.Verbose,
                console_Minimum_LogLevel: LogLevel.Information,
#else
                global_Minimum_LogLevel: LogLevel.Information,
                console_Minimum_LogLevel: LogLevel.Warning,
#endif
                debug_LogWriter_AutoFlush: false
                ));
            Log.Info("csharp-Protoshift v1.0.0", "Entry");
            Log.Info("Written by YYHEggEgg#6167, https://github.com/YYHEggEgg.", "Entry");
            ResourcesLoader.CheckForRequiredResources();
            await ResourcesLoader.Load();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (args.Length == 1 && args[0] == "--utils-only")
            {
                Log.Info($"umm... It's OK...", "UtilsOnly");
                Log.Warn($"Please use util cmd only, or it will cause unknown problems!", "UtilsOnly");
                Log.Info($"Type 'util help' to get command help.", "UtilsOnly");
            }
            else
            {
                Log.Info("Start loading all protos, it will take some time...", "Entry");
                Log.Info(OldProtos.QueryJsonSerializer.Initialize(), "OldProtos");
                Log.Info(NewProtos.QueryJsonSerializer.Initialize(), "NewProtos");
                Log.Info(ProtoshiftDispatch.Initialize(), "Entry");

#if !PROXY_ONLY_SERVER
                Log.Info(SkillIssueDetect.Initialize(), "Entry");
#endif
                // Log.Info(KcpPacketAudit.Initialize(), "Entry");


                ProxyServer = new KcpProxyServer(new IPEndPoint(IPAddress.Parse("0.0.0.0"), 22102),
                    new IPEndPoint(IPAddress.Parse("192.168.127.130"), 20041));

                ProxyHandlers handlers = new ProxyHandlers
                {
                    SessionCreated = GameSessionDispatch.SessionCreated,
                    SessionDestroyed = GameSessionDispatch.DestroySession,
                    OnServerPacketArrival = GameSessionDispatch.HandleServerPacket,
                    OnClientPacketArrival = GameSessionDispatch.HandleClientPacket,
                    ServerPacketOrdered = GameSessionDispatch.OrderedServerPacket,
                    ClientPacketOrdered = GameSessionDispatch.OrderedClientPacket
                };
                _ = Task.Run(() => ProxyServer.StartProxy(handlers));
                Log.Info("Protoshift server started on 127.0.0.1:22102", "Entry");
                Log.Info("Ready! Type 'help' to get command help.", "Entry");
            }

            await ServerCommandLine.Start();
            Close();
        }

        public static void Close()
        {
            Log.Erro("Unreachable Close method invoked.");
        }
    }
}