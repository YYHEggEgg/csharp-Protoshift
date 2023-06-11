namespace csharp_Protoshift.MhyKCP.Test.App
{
    public static class Constants
    {
        public const ushort UDP_SERVER_PORT = 30351;
        public const ushort UDP_PROXY_PORT = 30341;

        public const int each_packet_size = 3500;
        // 是否随机包大小 最小为0 最大为each_packet_size
        // 目前包大小固定
        // public const bool random_packet_size = false;
        // 发包总数量
        public const int packet_repeat_time = 5000;
        // 发包间隔 非严格间隔，即发完包后等待毫秒数
        public const int packet_interval_ms = 30;
        // 是否发包完成后 10s 自动退出 一般在Actions上跑要分配true
        public const bool auto_exit = true;
    }
}