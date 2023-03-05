using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs
{
    /// <summary>
    /// Why it call this? From its name, we know that it mainly solve the 'bytes' problem.
    /// <para>In some packets, for unknown purposes, the anime game send original protobuf bin data as 'bytes', and along with any fields describe its protocol information.</para>
    /// <para>Though never could we know why they don't use oneof, we can do no more than adjust to it.</para>
    /// <para>This is only used for protocols <b>DIRECTLY</b> have bytes fields, e.g. <see cref="NewProtos.AbilityInvokeEntry"/>, <see cref="NewProtos.CombatInvokeEntry"/>.</para>
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
        /// <param name="json">The original data. Whether it's new or old protocol is defined by <paramref name="isNewCmdid"/>.</param>
        /// <returns>The data with shifted bytes-field(s), also in json. Whether it's new or old protocol is on the contrary of <paramref name="isNewCmdid"/>.</returns>
        public string Handle(string json, bool isNewCmdid);
    }

    /// <summary>
    /// Why it call this? From its name, we know that it mainly solve the 'bytes' problem.
    /// <para>In some packets, for unknown purposes, the anime game send original protobuf bin data as 'bytes', and along with any fields describe its protocol information.</para>
    /// <para>Though never could we know why they don't use oneof, we can do no more than adjust to it.</para>
    /// <para>The generic type param TNew, TOld is used for what information it requires for identifying proto type of 'bytes', e.g. ushort for cmdid, specified enum type, etc; thus, for successors, they shouldn't make it a generic implement.</para>
    /// <para>This is only used for protocols <b>DIRECTLY</b> have bytes fields, e.g. <see cref="NewProtos.AbilityInvokeEntry"/>, <see cref="NewProtos.CombatInvokeEntry"/>.</para>
    /// </summary>
    interface ISpecialBytesSkillIssueFixer<TNew, TOld> : ISpecialBytesSkillIssueFixer
        where TNew : notnull 
        where TOld : notnull
    {
        /// <summary>
        /// Utils for inner <c>bytes</c>
        /// </summary>
        public Dictionary<TNew, ProtoShiftUtils> newutils { get; }
        /// <summary>
        /// Utils for inner <c>bytes</c>
        /// </summary>
        public Dictionary<TOld, ProtoShiftUtils> oldutils { get; }
    }

    /// <summary>
    /// It is also used to solve the 'bytes' problem, but what's different is that it's used to handle packets that contains fields with protocols mentioned in <see cref="ISpecialBytesSkillIssueFixer"/>, e.g. <see cref="NewProtos.AbilityInvocationsNotify"/> contains <see cref="NewProtos.AbilityInvokeEntry"/>.
    /// </summary>
    interface ISpecialOuterSkillIssueFixer
    {
        public string Protoname { get; }
        public string ApplyToVersion { get; }
        public ISpecialBytesSkillIssueFixer fixer_bytes { get; set; }
        /// <summary>
        /// Util for main proto, or <c>Protoname</c>, used for serializing <c>data</c>.
        /// </summary>
        public NewProtos.ProtoSerialize Mainutil_new { get; }
        /// <summary>
        /// Util for main proto, or <c>Protoname</c>, used for serializing <c>data</c>.
        /// </summary>
        public OldProtos.ProtoSerialize Mainutil_old { get; }

        /// <summary>
        /// We stimulate that the Handle() method do both Protoshifts in bytes field and outer fields, so don't mix it with other converts.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="isNewCmdid"></param>
        /// <returns>The final shifted data.</returns>
        public byte[] Handle(byte[] data, bool isNewCmdid);
    }
}
