using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage
{
    /// <summary>
    /// 
    /// </summary>
    internal class DMCATakenDownException : Exception
    {
        public DMCATakenDownException(string message) : base(message) { }
        public DMCATakenDownException(string message, Exception? innerException) : base(message, innerException) { }
    }
}
