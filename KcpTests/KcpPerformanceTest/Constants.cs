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