using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs.AbilityInvokeEntry
{
    internal class ClientAbilityChangeNotifyOuterFix
        : ISpecialOuterSkillIssueFixer<NewProtos.ClientAbilityChangeNotify, OldProtos.ClientAbilityChangeNotify>
    {
        public ISpecialBytesSkillIssueFixer<NewProtos.ClientAbilityChangeNotify, OldProtos.ClientAbilityChangeNotify>? fixer_bytes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
