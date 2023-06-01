namespace csharp_Protoshift.MhyKCP.Test.App
{
    public static class Constants
    {
        public const ushort UDP_SERVER_PORT = 30351;
        public const ushort UDP_PROXY_PORT = 30341;

        public const int each_packet_size = 500;
        // 是否随机包大小 最小为0 最大为each_packet_size
        public const bool random_packet_size = false;
        // 发包总数量
        public const int packet_repeat_time = 10;
        // 发包间隔 非严格间隔，即发完包后等待毫秒数
        public const int packet_interval_ms = 500;
    }
}