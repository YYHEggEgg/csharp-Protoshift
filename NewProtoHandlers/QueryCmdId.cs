using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProtos
{
    public static class QueryCmdId
    {
        public static string ThisPath => AppDomain.CurrentDomain.BaseDirectory;
        private static Dictionary<int, ProtoSerialize> serializers = new();

        static QueryCmdId()
        {
            var cmdids = File.ReadAllLines("/resources/protobuf/newcmdid.csv");
            foreach (var line in cmdids)
            {
                var csvline = line.Split(',');
                Debug.Assert(csvline.Length == 2);
                string name = csvline[0];
                int cmdid = int.Parse(csvline[1]);
                serializers.Add(cmdid, new ProtoSerialize(name));
            }
        }

        public static bool TryGetSerializer(int cmdid, out ProtoSerialize serializer)
        {
            if (serializers.ContainsKey(cmdid))
            {
                serializer = serializers[cmdid];
                return true;
            }
            else
            {
                serializer = ProtoSerialize.Empty;
                return false;
            }
        }
    }
}
