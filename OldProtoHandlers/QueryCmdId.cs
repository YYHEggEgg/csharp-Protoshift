using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Collections.ObjectModel;
using YYHEggEgg.Logger;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace OldProtos
{
    public class QueryCmdId
    {
        public const string ProtoNamespace = "OldProtos";

        public static string ThisPath => AppDomain.CurrentDomain.BaseDirectory;
        private static ReadOnlyDictionary<int, string> cmdidToName;
        private static ReadOnlyDictionary<string, int> nameToCmdid;
        private static ReadOnlyDictionary<int, ProtoSerialize> serializers;
        private static ReadOnlyDictionary<string, ProtoSerialize> serializers_queryByName;

        static QueryCmdId()
        {
            #region CmdId
            var _cmdidToName = new Dictionary<int, string>();
            var _nameToCmdid = new Dictionary<string, int>();

            var cmdids = File.ReadAllLines("resources/protobuf/oldcmdid.csv");
            foreach (var line in cmdids)
            {
                var csvline = line.Split(',');
                Debug.Assert(csvline.Length == 2);
                string name = csvline[0].Trim();
                int cmdid = int.Parse(csvline[1].Trim());
                if (_cmdidToName.ContainsKey(cmdid))
                {
                    Log.Warn($"{cmdid} multiples, dropped proto {name}", ProtoNamespace);
                    continue;
                }
                _cmdidToName.Add(cmdid, name);
                _nameToCmdid.Add(name, cmdid);
            }
            #endregion

            #region Serializers
            ConcurrentDictionary<int, ProtoSerialize> _serializers = new();
            ConcurrentDictionary<string, ProtoSerialize> _serializers_queryByName = new();

#pragma warning disable CS8602 // 解引用可能出现空引用。
            var messageTypes = from type in Assembly.GetAssembly(
                Type.GetType($"{ProtoNamespace}.{nameof(GetPlayerTokenReq)}")).GetTypes()
                where type.Namespace == ProtoNamespace 
                where type.GetInterface("IMessage") != null
                select type;
#pragma warning restore CS8602 // 解引用可能出现空引用。
            var messagesCount = messageTypes.Count();

            int failure = 0;
            object failure_lck = new();
            Parallel.ForEach(messageTypes, type =>
            {
                try
                {
                    var name = type.FullName?.Substring(ProtoNamespace.Length + 1);
                    Log.Dbug($"Initializing Message: {name}", ProtoNamespace);
                    ProtoSerialize serializer = new(name); // OldProtos.*
                    if (_nameToCmdid.ContainsKey(name))
                        _serializers.TryAdd(_nameToCmdid[name], serializer);
                    _serializers_queryByName.TryAdd(name, serializer);
                }
                catch (Exception ex)
                {
                    Log.Warn($"Initialize ProtoSerialize: {type.Name} failed. Possibly that proto does not exist.", ProtoNamespace);
                    Log.Dbug(ex.ToString(), ProtoNamespace);
                    lock (failure_lck) failure++;
                }
            });
            #endregion

            if (_serializers_queryByName.Count - failure != messagesCount)
            {
                Log.Warn($"Design issue: Parallel.ForEach probably hasn't ended. Waiting...", ProtoNamespace);
                while (_serializers_queryByName.Count - failure != messagesCount) Thread.Sleep(50);
                Log.Info($"Parallel.ForEach waiting finished. ");
            }

            cmdidToName = new(_cmdidToName);
            nameToCmdid = new(_nameToCmdid);
            serializers = new(_serializers);
            serializers_queryByName = new(_serializers_queryByName);
        }

        public static bool TryGetProtonameFromCmdId(int cmdid, out string? protoname)
        {
            return cmdidToName.TryGetValue(cmdid, out protoname);
        }

        public static bool TryGetCmdIdFromProtoname(string protoname, out int cmdid)
        {
            return nameToCmdid.TryGetValue(protoname, out cmdid);
        }

        public static string GetProtonameFromCmdId(int cmdid)
        {
            return cmdidToName[cmdid];
        }

        public static int GetCmdIdFromProtoname(string protoname)
        {
            return nameToCmdid[protoname];
        }

        public static bool ProtoExists(string protoname) =>
            serializers_queryByName.ContainsKey(protoname);

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
                serializer = ProtoSerialize.Empty;
                return false;
            }
        }

        public static string Initialize()
        {
            return $"{ProtoNamespace} QueryCmdId initialized, CmdId x{nameToCmdid.Count}, {serializers_queryByName.Count} serializers.";
        }

        /// <summary>
        /// Get all loaded protobuf names.
        /// </summary>
        public static string[] GetAllLoadedProtoNames()
            => serializers_queryByName.Keys.ToArray();

        /// <summary>
        /// Get all loaded protobuf names. Only returns protobufs which have CmdId. 
        /// </summary>
        public static string[] GetAllLoadedCmdNames()
            => nameToCmdid.Keys.ToArray();
    }
}