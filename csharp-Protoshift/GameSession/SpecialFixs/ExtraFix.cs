using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs
{
    internal partial class ExtraFix
    {
        public static bool NeedSpecialHandle(ushort cmdid, bool isNewCmdid)
        {
            return (isNewCmdid ? fixers_client : fixers_server).ContainsKey(cmdid);
        }

        public static byte[] SpecialHandle(ushort cmdid, bool isNewCmdid, byte[] data)
        {
            return (isNewCmdid ? fixers_client : fixers_server)[cmdid].Handle(data, isNewCmdid);
        }
    }
}
