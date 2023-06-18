namespace csharp_Protoshift.MhyKCP.Proxy
{
    public class ProxyHandlers
    {
        public Func<byte[], uint, byte[]?> OnServerPacketArrival
            = (data, conv) => data;
        public Func<byte[], uint, byte[]?> OnClientPacketArrival
            = (data, conv) => data;
        public Func<byte[], uint, bool> ServerPacketOrdered
            = (_, _) => true;
        public Func<byte[], uint, bool> ClientPacketOrdered
            = (_, _) => true;
    }
}