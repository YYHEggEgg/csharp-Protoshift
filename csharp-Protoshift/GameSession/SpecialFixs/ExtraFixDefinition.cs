using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs
{
    internal partial class ExtraFix
    {
        /// <summary>
        /// fixers dictionary, using oldcmdids.
        /// </summary>
        static readonly Dictionary<ushort, ISpecialBytesSkillIssueFixer> fixers_server;
        /// <summary>
        /// fixers dictionary, using newcmdids.
        /// </summary>
        static readonly Dictionary<ushort, ISpecialBytesSkillIssueFixer> fixers_client;
        static readonly Dictionary<string, ISpecialBytesSkillIssueFixer> fixers;

        static ExtraFix()
        {
            fixers = new Dictionary<string, ISpecialBytesSkillIssueFixer>
            {
                { "AbilityInvocationsNotify", new AbilityInvocationsNotifyFix() },
                { "CombatInvocationsNotify", new CombatInvocationsNotifyFix() }
            };
            fixers_client = new();
            fixers_server = new();
            foreach (var pair in fixers)
            {
                fixers_client.Add((ushort)NewProtos.QueryCmdId.GetCmdIdFromProtoname(pair.Key), pair.Value);
                fixers_server.Add((ushort)OldProtos.QueryCmdId.GetCmdIdFromProtoname(pair.Key), pair.Value);
            }
        }

        /// <summary>
        /// Invoke the static initializer for better performance afterwards.
        /// </summary>
        public static string Initialize()
        {
            return "ExtraFix Initialized.";
        }
    }
}
