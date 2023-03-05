using csharp_Protoshift.GameSession.SpecialFixs.AbilityInvokeEntry;
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
        static readonly Dictionary<ushort, ISpecialOuterSkillIssueFixer> fixers_server;
        /// <summary>
        /// fixers dictionary, using newcmdids.
        /// </summary>
        static readonly Dictionary<ushort, ISpecialOuterSkillIssueFixer> fixers_client;

        static ExtraFix()
        {
            var fixer_ability_invoke_entry = new AbilityInvokeEntryFix();
            var fixers = new Dictionary<string, ISpecialOuterSkillIssueFixer>
            {
                { "AbilityInvocationsNotify", new AbilityInvocationsNotifyOuterFix 
                    { fixer_bytes = fixer_ability_invoke_entry } },
                { "ClientAbilityChangeNotify", new ClientAbilityChangeNotifyOuterFix
                    { fixer_bytes = fixer_ability_invoke_entry } },
                { "ClientAbilityInitFinishNotify", new ClientAbilityInitFinishNotifyOuterFix
                    { fixer_bytes = fixer_ability_invoke_entry } },
                { "AbilityInvocationFailNotify", new AbilityInvocationFailNotifyOuterFix
                    { fixer_bytes = fixer_ability_invoke_entry } },
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
