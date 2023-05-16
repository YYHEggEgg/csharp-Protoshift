namespace KcpCsharpTest
{
    public static class Constants
    {
        public const int each_packet_size = 1372;
        public const int KCP_RefreshMilliseconds = 10;
        public const int packet_repeat_time = 5000;
        public const int packet_interval_ms = 50;
        public const int packet_loss_percent = 0; // 5% / 100%
        public const uint global_kcp_conv = 1001;
#if MIHOMO_KCP        
        public const uint global_kcp_token = 1234567890;
#endif
        public const ushort global_wndsize = 1024;
    }
}