using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Collections.ObjectModel;
using YYHEggEgg.Logger;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace NewProtos
{
    public class QueryJsonSerializer
    {
        public const string ProtoNamespace = "NewProtos";

        private static ReadOnlyDictionary<string, ProtoSerializeJson> serializers_queryByName;

        static QueryJsonSerializer()
        {
            #region Serializers
            ConcurrentDictionary<string, ProtoSerializeJson> _serializers_queryByName = new();

#pragma warning disable CS8602 // 解引用可能出现空引用。
#pragma warning disable CS8604
            var messageTypes = from type in Assembly.GetAssembly(
                Type.GetType($"{ProtoNamespace}.{nameof(GetPlayerTokenReq)}")).GetTypes()
                               where type.Namespace == ProtoNamespace
                               where type.GetInterface("IMessage") != null
                               select type;
#pragma warning restore CS8602 // 解引用可能出现空引用。
#pragma warning restore CS8604
            var messagesCount = messageTypes.Count();

            int failure = 0;
            object failure_lck = new();
            Parallel.ForEach(messageTypes, type =>
            {
                try
                {
                    var name = type.FullName?.Substring(ProtoNamespace.Length + 1);
                    Log.Dbug($"Initializing Message: {name}", ProtoNamespace);
#pragma warning disable CS8604
                    ProtoSerializeJson serializer = new(name); // NewProtos.*
#pragma warning restore CS8604
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
            
            serializers_queryByName = new(_serializers_queryByName);
        }

        public static bool TryGetJsonSerializer(uint cmdid, out ProtoSerializeJson serializer)
            => TryGetJsonSerializer(NewProtos.AskCmdId.GetProtonameFromCmdId(cmdid), out serializer);

        public static bool TryGetJsonSerializer(string protoname, out ProtoSerializeJson serializer)
        {
            if (serializers_queryByName.ContainsKey(protoname))
            {
                serializer = serializers_queryByName[protoname];
                return true;
            }
            else
            {
                serializer = ProtoSerializeJson.Empty;
                return false;
            }
        }

        public static string Initialize()
        {
            return $"{ProtoNamespace} QueryCmdId initialized, {serializers_queryByName.Count} serializers.";
        }

        /// <summary>
        /// Get all loaded protobuf names.
        /// </summary>
        public static string[] GetAllLoadedProtoNames()
            => serializers_queryByName.Keys.ToArray();
    }
}