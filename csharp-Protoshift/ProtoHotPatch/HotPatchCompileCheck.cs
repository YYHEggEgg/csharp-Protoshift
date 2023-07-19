using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.ProtoHotPatch
{
    internal static partial class ProtoHotPatchCompiler
    {
        private static bool Check(ProtoshiftHotPatchConfig[]? configs)
        {
            if (configs == null)
            {
                Log.Erro("PSHP002: json format parsing failed, and the current HotPatch configuration has been unloaded.", nameof(ProtoHotPatchCompiler));
                return false;
            }
            return true;
        }
    }
}
