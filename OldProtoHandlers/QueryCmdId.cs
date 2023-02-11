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
        private static Dictionary<string, ProtoSerialize> serializers_queryByName = new();
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
                ProtoSerialize serializer = new(name);
                serializers.Add(cmdid, serializer);
                serializers_queryByName.Add(name, serializer);
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
            if (serializers_queryByName.ContainsKey(protoname))
            {
                serializer = serializers_queryByName[protoname];
                return true;
            }
            else
            {
                Type? prototype = Type.GetType($"OldProtos.{protoname}");
                if (prototype == null)
                {
                    serializer = ProtoSerialize.Empty;
                    return false;
                }
                else
                {
                    serializer = new ProtoSerialize(prototype);
                    serializers_queryByName.Add(protoname, serializer);
                    return true;
                }
            }
        }

        public static bool ProtoExists(string protoname)
        {
            if (protonameToCmdids.ContainsKey(protoname)) return true;
            else
            {
                Type? prototype = Type.GetType($"OldProtos.{protoname}");
                if (prototype != null)
                    serializers_queryByName.Add(protoname, new(prototype));
                return prototype != null;
            }
        }

        public static string Initialize()
        {
            return $"OldProtos initialized, {serializers.Count} serializers.";
        }
    }
}
