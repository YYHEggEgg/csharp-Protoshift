using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Benchmark
{
    internal static class GetPingReq
    {
        public static NewProtos.PingReq GetLongBytes(int bytes_data_length)
        {
            NewProtos.PingReq rtn = new();
            rtn.Seq = 546782553;
            byte[] data = new byte[bytes_data_length];
            for (uint i = 0; i < bytes_data_length; i++) data[i] = (byte)(i ^ 208521753);
            rtn.ScData = ByteString.CopyFrom(data);
            return rtn;
        }
    }
}