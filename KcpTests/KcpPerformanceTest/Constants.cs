namespace csharp_Protoshift.MhyKCP.Test.App
{
    public static class Constants
    {
        public const ushort UDP_SERVER_PORT = 30351;
        public const ushort UDP_PROXY_PORT = 30341;

        public const int each_packet_size = 2500;
        // �Ƿ��������С ��СΪ0 ���Ϊeach_packet_size
        public const bool random_packet_size = false;
        // ����������
        public const int packet_repeat_time = 5000;
        // ������� ���ϸ��������������ȴ�������
        public const int packet_interval_ms = 50;
    }
}