﻿using csharp_Protoshift.Commands;
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

            Log.Info("Start loading all protos, it will take some time...", "Entry");
            Log.Info(OldProtos.QueryJsonSerializer.Initialize(), "OldProtos");
            Log.Info(NewProtos.QueryJsonSerializer.Initialize(), "NewProtos");
            Log.Info(ProtoshiftDispatch.Initialize(), "Entry");

            Log.Info(SkillIssueDetect.Initialize(), "Entry");
            // Log.Info(KcpPacketAudit.Initialize(), "Entry");

            //Log.Info(NewProtos.Unk3300_ADHENCIFKNI.Descriptor.ToProto().ToString());

            ProxyServer = new KcpProxyServer(new IPEndPoint(IPAddress.Parse("0.0.0.0"), 22102),
                new IPEndPoint(IPAddress.Parse("192.168.127.130"), 20041));

            ProxyHandlers handlers = new ProxyHandlers
            {
                SessionCreated = GameSessionDispatch.SessionCreated,
                OnServerPacketArrival = GameSessionDispatch.HandleServerPacket,
                OnClientPacketArrival = GameSessionDispatch.HandleClientPacket,
                ServerPacketOrdered = GameSessionDispatch.OrderedServerPacket,
                ClientPacketOrdered = GameSessionDispatch.OrderedClientPacket
            };
            _ = Task.Run(() => ProxyServer.StartProxy(handlers));
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