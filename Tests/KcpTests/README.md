# KcpPerformanceTest

本项目用于常规的网络协议（基于 KCP 的 mihoyonet）测试。

开启符号 `CONNECT_SERVERONLY` 以跳过中间代理，否则将会通过代理进行。

各项设置（包括 UDP 端口号）在 `Constants.cs` 中设置。

## 测试方法概述

测试由客户端生成一个奇数 ack，即 1,3,5,...；  
服务端收到对应 ack 后，将 ack +1 并将 body 原封不动重传；  
在此期间，三方将数据提交至统一的 Analysis 处理，分析速度、延迟、丢包等数据。

由于这套协议主要用于 Protobuf 传输，包数据只要有部分错误即视为全部丢包。

为了设计方便，此套测试程序仍使用 XOR 加密，但舍去了非对称密钥交换而只使用 dispatchKey.

## 命令行操作

程序支持使用命令行操作。

English Usage:

```txt
   Usage: KcpPerformanceTest [options]

   Options:
     -s, --packet-size <size>         The size of each packet.
     -t, --packet-repeat-time <time>  The total number of packets to send.
     -i, --packet-interval <interval> The interval between packets in milliseconds.
     -g, --github-actions             Whether the program is running on GitHub Actions.
     -c, --clients-count <count>      The number of concurrent clients.
     -d, --packet-delay-log           Whether to generate a packet delay log.
```

中文使用说明:

```txt
   用法: KcpPerformanceTest [选项]

   选项:
     -s, --packet-size <size>         每个数据包的大小。
     -t, --packet-repeat-time <time>  发送的总数据包数量。
     -i, --packet-interval <interval> 数据包之间的间隔时间（毫秒）。
     -g, --github-actions             程序是否在 GitHub Actions 上运行。
     -c, --clients-count <count>      并发客户端的数量。
     -d, --packet-delay-log           是否生成数据包延迟日志。
```

更具体的，可参考 `Constants.cs`：

```cs
namespace csharp_Protoshift.MhyKCP.Test.App
{
    public static class Constants
    {
        public const ushort UDP_SERVER_PORT = 30351;
        public const ushort UDP_PROXY_PORT = 30341;

        public static int each_packet_size = 3500;
        // 是否随机包大小 最小为0 最大为each_packet_size
        // 目前包大小固定 不作更改
        // public const bool random_packet_size = false;

        // 发包总数量
        public static int packet_repeat_time = 5000;
        // 发包间隔 非严格间隔，即发完包后等待毫秒数
        public static int packet_interval_ms = 40;
        // 在Actions上跑要分配true 决定是否发包结束后10s退出 是否输出packet.log到控制台
        public static bool running_on_github_actions = true;

        // 同时向服务器并发请求的客户端数量
        public static int running_clients_count = 5;
        // 是否生成包延迟统计表 一般客户端数量>5时分配false 控制输出量
        public static bool output_packet_delaylog = true;
    }
}
```
