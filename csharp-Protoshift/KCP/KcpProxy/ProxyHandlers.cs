namespace csharp_Protoshift.MhyKCP.Proxy
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