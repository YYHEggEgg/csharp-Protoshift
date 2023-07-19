using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.ProtoHotPatch
{
    internal class ProtoshiftHotPatchConfig
    {
        public string Proto { get; set; }
        public string ApplyTo { get; set; }
        public bool Enabled { get; set; }
        public string[] Rules { get; set; }
    }
}
