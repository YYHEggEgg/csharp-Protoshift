using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csharp_Protoshift.Commands.SkillIssueFix
{
    internal class SkillIssueFixCmd : ICommandHandler, IJsonOnDeserialized, IJsonOnSerializing
    {
        public string CommandName => "kskillissue";

        public string Description => "(Advanced Feature) Anti SKILL ISSUEs.";

        public string Usage => $"kskillissue <protoname> <client/server> <enable/disable/delete> [rule1...n]{Environment.NewLine}" +
            $"rule should have a syntax like: [field1]->[field2]{Environment.NewLine}" +
            $"This command is used to fix data lost when Protoshifting, but it's not substitute for fixing protos.{Environment.NewLine}" +
            $"e.g. \"kskillissue PlayerLoginRsp server enable isEnableClientHashDebug->Unk3300AJBBIPFMBEL\"{Environment.NewLine}" +
            "Notice that don't contain spaces or quotes, CommandLine cannot identify your input.";

        // ushort is CmdId
        [JsonIgnore] public Dictionary<ushort, ProtoReflectRules> clientRules = new();
        [JsonIgnore] public Dictionary<ushort, ProtoReflectRules> serverRules = new();

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        public async Task HandleAsync(string[] args)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            string protoname = args[0];
            bool forserver = args[1] == "server";
            #region Assert
            if (args.Length <= 2)
            {
                Log.Erro("Too few arguments!", "SkillIssueFixCmd");
                return;
            }
            if (args[2] != "enable" || args[2] != "disable" || args[2] != "delete")
            {
                Log.Erro("isEnabled should be one of enable/disable/delete!", "SkillIssueFixCmd");
                return;
            }
            if (args[1].ToLower() != "client" && args[1].ToLower() != "server")
            {
                Log.Erro("Should specify used on either client or server!", "SkillIssueFixCmd");
                return;
            }
            if (!(forserver && NewProtos.QueryCmdId.ProtoExists(protoname)) &&
                !(!forserver && OldProtos.QueryCmdId.ProtoExists(protoname)))
            {
                Log.Erro("Requested proto for client/server does not exist!", "SkillIssueFixCmd");
                return;
            }
            #endregion
            bool enabled = args[2] != "disable";
            bool deletemode = args[2] == "delete";

            #region Rule Initialize
            ProtoReflectRules? rule = null;
            ushort cmdid = (ushort)(forserver 
                ? OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)
                : NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname));
            if (forserver && serverRules.ContainsKey(cmdid))
            {
                rule = serverRules[cmdid];
            }
            else if (!forserver && clientRules.ContainsKey(cmdid))
            {
                rule = clientRules[cmdid];
            }
            if (rule == null)
            {
                rule = new(forserver, protoname);
                if (forserver) serverRules.Add(cmdid, rule);
                else clientRules.Add(cmdid, rule);
            }
            #endregion

            if (!enabled) rule.enabled = false;
            else
            {
                rule.enabled = true;
                if (args.Length <= 3) return;
                for (int i = 3; i < args.Length; i++)
                {
                    #region Read info
                    string input = args[i];
                    int separate = input.IndexOf("->");
                    if (separate == -1)
                    {
                        Log.Erro($"Invalid rule \"{input}\"! Not applied.", "SkillIssueFixCmd");
                        continue;
                    }
                    string sourcefield = input.Substring(0, separate);
                    string destfield = input.Substring(separate + 2);
                    if (sourcefield == string.Empty || destfield == string.Empty)
                    {
                        Log.Erro($"Invalid rule \"{input}\"! Not applied.", "SkillIssueFixCmd");
                        continue;
                    }
                    #endregion
                    #region Operation
                    if (!deletemode)
                    {
                        rule.Rules.Add((sourcefield, destfield));
                        Log.Info($"Successfully added rule {input} to {protoname}.", "SkillIssueFixCmd");
                    }
                    else
                    {
                        if (rule.Rules.Contains((sourcefield, destfield)))
                        {
                            rule.Rules.Remove((sourcefield, destfield));
                            Log.Info($"Successfully removed rule {input} from {protoname}.", "SkillIssueFixCmd");
                        }
                        else
                        {
                            Log.Erro($"Rule {input} in {protoname} not found!", "SkillIssueFixCmd");
                            if (rule.Rules.Count > 0)
                            {
                                Log.Info($"{protoname} have these rules defined:", "SkillIssueFixCmd");
                                foreach (var pair in rule.Rules)
                                {
                                    Log.Info($"{pair.Item1} -> {pair.Item2}", "SkillIssueFixCmd");
                                }
                            }
                        }
                    }
                    #endregion
                }
            }
        }
        
        public string ProcessWithRule(ushort cmdid, bool fromServer, string inputjson)
        {
            if (fromServer)
            {
                if (serverRules.ContainsKey(cmdid))
                    return serverRules[cmdid].ProcessFromJson(inputjson);
                else return inputjson;
            }
            else
            {
                if (clientRules.ContainsKey(cmdid))
                    return clientRules[cmdid].ProcessFromJson(inputjson);
                else return inputjson;
            }
        }

        #region Serialize
        /// <summary>
        /// Only used for serializer.
        /// </summary>
        public List<KeyValuePair<ushort, ProtoReflectRules>>? list_clientRules { get; set; }
        /// <summary>
        /// Only used for serializer.
        /// </summary>
        public List<KeyValuePair<ushort, ProtoReflectRules>>? list_serverRules { get; set; }

        public void OnSerializing()
        {
            list_clientRules = clientRules.ToList();
            list_serverRules = serverRules.ToList();
        }

        public void OnDeserialized()
        {
            clientRules = new(list_clientRules ?? new());
            serverRules = new(list_serverRules ?? new());

            list_clientRules?.Clear();
            list_serverRules?.Clear();
        }
        #endregion
    }
}
