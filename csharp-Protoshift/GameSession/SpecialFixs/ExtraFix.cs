using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs
{
    internal partial class ExtraFix
    {
        public static byte[] SpecialHandle(ushort cmdid, bool isNewCmdid, byte[] data)
        {
            if ((isNewCmdid ? fixers_client : fixers_server).ContainsKey(cmdid))
                return (isNewCmdid ? fixers_client : fixers_server)[cmdid].Handle(data, isNewCmdid);
            else return data;
        }
    }

    /// <summary>
    /// Why it call this? From its name, we know that it mainly solve the 'bytes' problem.
    /// <para>In some packets, for unknown purposes, the anime game send original protobuf bin data as 'bytes', and along with any fields describe its protocol information.</para>
    /// <para>Though never could we know why they don't use oneof, we can do no more than adjust to it.</para>
    /// </summary>
    interface ISpecialBytesSkillIssueFixer
    {
        public string Protoname { get; }
        /// <summary>
        /// Util for main proto, or <c>Protoname</c>, used for serializing <c>data</c>.
        /// </summary>
        public NewProtos.ProtoSerialize Mainutil_new { get; }
        /// <summary>
        /// Util for main proto, or <c>Protoname</c>, used for serializing <c>data</c>.
        /// </summary>
        public OldProtos.ProtoSerialize Mainutil_old { get; }
        public string ApplyToVersion { get; }

        /// <summary>
        /// We stipulate that Handle() only shift the <c>bytes</c> field in protocol, but don't shift data from one protocol to another.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public byte[] Handle(byte[] data, bool isNewCmdid);
    }

    /// <summary>
    /// Why it call this? From its name, we know that it mainly solve the 'bytes' problem.
    /// <para>In some packets, for unknown purposes, the anime game send original protobuf bin data as 'bytes', and along with any fields describe its protocol information.</para>
    /// <para>Though never could we know why they don't use oneof, we can do no more than adjust to it.</para>
    /// <para>The generic type param T is used for what information it requires for identifying proto type of 'bytes', e.g. ushort for cmdid, specified enum type, etc; thus, for successors, they shouldn't make it a generic implement.</para>
    /// </summary>
    interface ISpecialBytesSkillIssueFixer<T> : ISpecialBytesSkillIssueFixer where T : notnull
    {
        /// <summary>
        /// Utils for inner <c>bytes</c>
        /// </summary>
        public Dictionary<T, ProtoShiftUtils> utils { get; }
    }
}
