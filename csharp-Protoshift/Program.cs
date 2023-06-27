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
        static async Task Main(string[] args)
        {
            StartupWorkingDirChanger.ChangeToDotNetRunPath(new LoggerConfig(
                max_Output_Char_Count: 16 * 1024,
                use_Console_Wrapper: true,
                use_Working_Directory: false,
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

            Log.Info("Start loading all protos, it will take some time...", "Entry");
            Log.Info(OldProtos.QueryJsonSerializer.Initialize(), "OldProtos");
            Log.Info(NewProtos.QueryJsonSerializer.Initialize(), "NewProtos");
            Log.Info(ProtoshiftDispatch.Initialize(), "Entry");

            Log.Info(SkillIssueDetect.Initialize(), "Entry");
            // Log.Info(KcpPacketAudit.Initialize(), "Entry");

            /*var dbgsession = new HandlerSession(1001);
            var rtn = dbgsession.GetPacketResult(
                Convert.FromHexString("4567002A000C0000009B188C60280130E1A4F5C6EF303A201A1B2A19120A0D555555406DED0958411A02500C38828080084010480720EA083A521A4D724B3A4508BF80801012370A0F0D88B48EC115E152DA3C1D2F355341120F0D76D187341541749A431D847713331A0F0D29C71BC0153CB1103C1DBF77FB3F2005320018AFA30520880E4807580220E2023A231A1E721C3A16120F0DF787313F15006FEDAD1D0E71383F28828080084803580220E20289AB"),
                42, true, 22, 155);
            Log.Info("Finish");*/

            var kcpProxy = new KcpProxyServer(new IPEndPoint(IPAddress.Parse("0.0.0.0"), 22102),
                new IPEndPoint(IPAddress.Parse("192.168.127.130"), 20041));

            ProxyHandlers handlers = new ProxyHandlers
            {
                OnServerPacketArrival = GameSessionDispatch.HandleServerPacket,
                OnClientPacketArrival = GameSessionDispatch.HandleClientPacket,
                ServerPacketOrdered = GameSessionDispatch.OrderedServerPacket,
                ClientPacketOrdered = GameSessionDispatch.OrderedClientPacket
            };
            kcpProxy.StartProxy(handlers);
            Log.Info("Protoshift server started on 127.0.0.1:22102", "Entry");
            Log.Info("Ready! Type 'help' to get command help.", "Entry");

            await CommandLine.Start();
            Close();
        }

        public static void Close()
        {
            Log.Erro("Unreachable Close method invoked.");
        }
    }
}