using csharp_Protoshift.AnimeGameKCP;
using csharp_Protoshift.Commands;
using csharp_Protoshift.Commands.SkillIssueFix;
using csharp_Protoshift.GameSession;
using csharp_Protoshift.GameSession.SpecialFixs;
using csharp_Protoshift.KcpProxy;
using csharp_Protoshift.resLoader;
using csharp_Protoshift.SkillIssue;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.Json;
using YSFreedom.Common.Net;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Log.Info("csharp-Protoshift v1.0.0", "Entry");
            Log.Info("Written by YYHEggEgg#6167, https://github.com/YYHEggEgg.", "Entry");
            ResourcesLoader.CheckForRequiredResources();
            await ResourcesLoader.Load();

            #region SkillIssueFixCmd
            SkillIssueFixCmd? sicmd = null;
            if (File.Exists("skillissue_fix_config.json"))
            {
                sicmd = JsonSerializer.Deserialize<SkillIssueFixCmd>(
                    File.ReadAllText("skillissue_fix_config.json"));
            }
            sicmd ??= new();
            CommandLine.handlers.Add(sicmd);
            skillcmd = sicmd;

            // Add instances need to be saved here. Repeat time is 60s.
            savetimer = new((_) =>
            {
                File.WriteAllText("skillissue_fix_config.json", JsonSerializer.Serialize(sicmd));
            }, null, 0, 60000);
            #endregion

            Log.Info("Start loading all protos, it will take some time...", "Entry");
            Log.Info(NewProtos.QueryCmdId.Initialize(), "Entry");
            Log.Info(OldProtos.QueryCmdId.Initialize(), "Entry");

            Log.Info(ExtraFix.Initialize(), "Entry");
            Log.Info(SkillIssueDetect.Initialize(), "Entry");

            Log.Info(ExtraFix.Initialize());

            var kcpProxy = new KcpProxyServer(new IPEndPoint(IPAddress.Loopback, 22102),
                new IPEndPoint(IPAddress.Parse("192.168.127.130"), 20041));

            ProxyHandlers handlers = new ProxyHandlers
            {
                OnServerPacketArrival = GameSessionDispatch.HandleServerPacket,
                OnClientPacketArrival = GameSessionDispatch.HandleClientPacket,
                IsUrgentServerPacket = GameSessionDispatch.IsUrgentServerPacket,
                IsUrgentClientPacket = GameSessionDispatch.IsUrgentClientPacket
            };
            kcpProxy.StartProxy(handlers);
            Log.Info("Protoshift server started on 127.0.0.1:22102", "Entry");
            Log.Info("Ready! Type 'help' to get command help.", "Entry");

            await CommandLine.Start();
            Close();
        }

        public static SkillIssueFixCmd skillcmd = new();
        private static Timer? savetimer;

        public static void Close()
        {
            Log.Erro("Unreachable Close method invoked.");
            savetimer?.Dispose();
        }
    }
}