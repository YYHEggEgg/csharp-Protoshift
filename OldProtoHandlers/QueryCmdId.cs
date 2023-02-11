using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldProtos
{
    public static class QueryCmdId
    {
        public static string ThisPath => AppDomain.CurrentDomain.BaseDirectory;
        private static Dictionary<int, ProtoSerialize> serializers = new();
        private static Dictionary<string, int> protonameToCmdids = new();

        static QueryCmdId()
        {
            var cmdids = File.ReadAllLines("resources/protobuf/oldcmdid.csv");
            foreach (var line in cmdids)
            {
                var csvline = line.Split(',');
                Debug.Assert(csvline.Length == 2);
                string name = csvline[0].Trim();
                int cmdid = int.Parse(csvline[1].Trim());
                if (serializers.ContainsKey(cmdid))
                {
                    Console.WriteLine($"Oldprotos: {cmdid} multiples, dropped proto {name}");
                    continue;
                }
                serializers.Add(cmdid, new ProtoSerialize(name));
                protonameToCmdids.Add(name, cmdid);
            }
        }

        public static int GetCmdIdFromProtoname(string protoname)
            => protonameToCmdids[protoname];

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

        public static bool TryGetSerializer(string protoname, out ProtoSerialize serializer)
        {
            if (protonameToCmdids.ContainsKey(protoname))
            {
                serializer = serializers[protonameToCmdids[protoname]];
                return true;
            }
            else
            {
                serializer = ProtoSerialize.Empty;
                return false;
            }
        }

        public static bool ProtoExists(string protoname)
            => protonameToCmdids.ContainsKey(protoname);

        public static string Initialize()
        {
            return $"OldProtos initialized, {serializers.Count} serializers.";
        }
    }
}
