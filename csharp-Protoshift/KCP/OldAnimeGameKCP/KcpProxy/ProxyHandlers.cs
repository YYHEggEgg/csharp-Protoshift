namespace csharp_Protoshift.Obsoleted.KcpProxy
{
    public class ProxyHandlers
    {
        public Func<byte[], uint, byte[]?> OnServerPacketArrival
            = (data, conv) => data;
        public Func<byte[], uint, byte[]?> OnClientPacketArrival
            = (data, conv) => data;
        public Func<byte[], uint, bool> IsUrgentServerPacket
            = (_, _) => false;
        public Func<byte[], uint, bool> IsUrgentClientPacket
            = (_, _) => false;
    }
}