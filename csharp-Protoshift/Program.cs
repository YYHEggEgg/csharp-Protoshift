using csharp_Protoshift.Commands;
using csharp_Protoshift.Configuration;
using csharp_Protoshift.Enhanced.Handlers.GeneratedCode;
using csharp_Protoshift.GameSession;
using csharp_Protoshift.MhyKCP.Proxy;
using csharp_Protoshift.resLoader;
using csharp_Protoshift.SkillIssue;
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
                console_Minimum_LogLevel: LogLevel.Information,
#endif
                debug_LogWriter_AutoFlush: false,
                is_PipeSeparated_Format: false,
                enable_Detailed_Time: true
                ));
            Log.Info("csharp-Protoshift v1.0.0", "Entry");
            Log.Info("Written by YYHEggEgg#6167, https://github.com/YYHEggEgg.", "Entry");
            ResourcesLoader.CheckForRequiredResources();
            await ResourcesLoader.Load();

            #region Config
            bool configLoadSucc = true;
            var _conflog = Log.GetChannel("Configuration");
            try
            {
                _conflog.LogInfo($"Loading config...");
                await Config.InitializeAsync("config.json");
            }
            catch (Exception ex)
            {
                _conflog.LogWarnTrace(ex, $"config.json initialize failed.");
                configLoadSucc = false;
            }

            var conf_validate_errs = await Config.ValidateAsync();
            if (conf_validate_errs != null && conf_validate_errs.Count > 0) 
            {
                configLoadSucc = false;
                _conflog.LogWarn($"ValidateAsync config.json by schema failed. Detected errors below:");
                foreach (var err in conf_validate_errs)
                {
                    _conflog.LogWarn(err.ToString());
                }
            }

            if (!configLoadSucc)
            {
                _conflog.LogErro("Config load failed. Please check the errors and fix them.");
                Environment.Exit(50);
            }
            #endregion

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

                #region Parse config remote addr
                IPAddress remoteaddr;
                if (Config.Global.NetConfig.RemoteAddress.IpAddress != null)
                {
                    remoteaddr = IPAddress.Parse(Config.Global.NetConfig.RemoteAddress.IpAddress);
                }
                else if (Config.Global.NetConfig.RemoteAddress.DomainAddress != null)
                {
                    var addrs = Dns.GetHostAddresses(Config.Global.NetConfig.RemoteAddress.DomainAddress);
                    Log.Info($"Dns resolving remote address (domain) " +
                        $"got {addrs.Length} addresses in all. Using {addrs[0]} now.");
                    remoteaddr = addrs[0];
                }
                else throw new NotSupportedException("JSON Schema invalid. Please report the bug.");
                #endregion

                var bindIp = new IPEndPoint(IPAddress.Parse(Config.Global.NetConfig.BindAddress),
                    Config.Global.NetConfig.BindPort);
                var remoteIp = new IPEndPoint(remoteaddr, Config.Global.NetConfig.RemoteAddress.AddressPort);

                ProxyServer = new KcpProxyServer(bindIp, remoteIp);

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
                Log.Info($"Protoshift server started on {bindIp}, real server at {remoteIp}.", "Entry");
                await GameSessionDispatch.ValidateWindyAutoExecute();
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