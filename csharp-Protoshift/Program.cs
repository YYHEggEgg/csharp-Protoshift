using csharp_Protoshift.AnimeGameKCP;
using csharp_Protoshift.Commands;
using csharp_Protoshift.Commands.SkillIssueFix;
using csharp_Protoshift.GameSession;
using csharp_Protoshift.GameSession.SpecialFixs;
using csharp_Protoshift.KcpProxy;
using csharp_Protoshift.resLoader;
using csharp_Protoshift.SkillIssue;
using OfficeOpenXml;
using System;
using System.Diagnostics;
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

            /*************Test area*************
            SimpleKcpClient kcpClient = new(new(IPAddress.Parse("192.168.127.130"), 20041));
            kcpClient.kcp.TraceListener = new ConsoleTraceListener();
            kcpClient.kcp.NoDelay(1, 10, 2, 1);
            Task.Run(async () =>
            {
                while (true)
                {
                    kcpClient.kcp.Update(DateTimeOffset.UtcNow);
                    await Task.Delay(10);
                }
            });
            var buffer = Convert.FromHexString("000000FF0000000000000000499602D2FFFFFFFF");
            // var buffer = Convert.FromHexString("456700C6000D000001B718B6E70128013081D8F4BAF13008014001524070396971647476716261776E3737323364746B6D6A6E65793339607775386F783839346A65726D37767860676535666776693774677160637839326F757232615A0931313435313430313160037801C22FD8024D4C3876776E45386B682B45582F306D69644869337855766E34427749482B4A3979556938662B6C4841644E6D476F4863786F49304668595563466451353766543970375A3341425A50514D794272682B626256356E7844685753554577353577517A394B7A596478507437663164706B5A7863522F4676544151494E3034364A73594B44774F456979544A637A635732586A4470363171654672666E6570462F494A486B4163702F4A4E4F515A70346C47564778444D6D76665A4E6E54356B6557674D73312B364B62713866796155777255454C4169436F725374594D734F5635756862397973503352617975743234554C4F6F686C2B33524A366D6C5A496D55396D2B4B465A65756F46552B744F79342B556E6D57486E797357774A5A4D565A712B447549654A5747503079756E6766416953465A6259356161747247323666473279306554553937534371756C446F713842673D3DE03702D86F0589AB");
            kcpClient.SendAsync(buffer, buffer.Length);
            await Task.Delay(1000);
            var resp = await kcpClient.ReceiveAsync();
            Log.Info($"Server Rsp: {Convert.ToHexString(resp)}", "TESTCODE");

            Console.ReadLine();
            *************Test area*************/

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

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