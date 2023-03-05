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
    /// <para>The generic type param <typeparamref name="TNewProtocol"/>, <typeparamref name="TOldProtocol"/> is used for Protoshift, and both of these name should equal to <see cref="ISpecialBytesSkillIssueFixer.Protoname"/>.</para>
    /// <para>This is only used for protocols <b>DIRECTLY</b> have bytes fields, e.g. <see cref="NewProtos.AbilityInvokeEntry"/>, <see cref="NewProtos.CombatInvokeEntry"/>.</para>
    /// </summary>
    interface ISpecialBytesSkillIssueFixer<TNewProtocol, TOldProtocol>
        where TNewProtocol : IMessage<TNewProtocol>
        where TOldProtocol : IMessage<TOldProtocol>
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

        public TOldProtocol NewShiftToOld(TNewProtocol message);
        public TNewProtocol OldShiftToNew(TOldProtocol message);
    }

    /// <summary>
    /// Why it call this? From its name, we know that it mainly solve the 'bytes' problem.
    /// <para>In some packets, for unknown purposes, the anime game send original protobuf bin data as 'bytes', and along with any fields describe its protocol information.</para>
    /// <para>Though never could we know why they don't use oneof, we can do no more than adjust to it.</para>
    /// <para>The generic type param <typeparamref name="TNewParam"/>, <typeparamref name="TOldParam"/> is used for what information it requires for identifying proto type of 'bytes', e.g. ushort for cmdid, specified enum type, etc; thus, for successors, they shouldn't make it a generic implement.</para>
    /// <para>The generic type param <typeparamref name="TNewProtocol"/>, <typeparamref name="TOldProtocol"/> is used for Protoshift, and both of these name should equal to <see cref="ISpecialBytesSkillIssueFixer.Protoname"/>.</para>
    /// <para>This is only used for protocols <b>DIRECTLY</b> have bytes fields, e.g. <see cref="NewProtos.AbilityInvokeEntry"/>, <see cref="NewProtos.CombatInvokeEntry"/>.</para>
    /// </summary>
    interface ISpecialBytesSkillIssueFixer<TNewParam, TOldParam, TNewProtocol, TOldProtocol>
        : ISpecialBytesSkillIssueFixer<TNewProtocol, TOldProtocol>
        where TNewParam : notnull 
        where TOldParam : notnull
        where TNewProtocol : IMessage<TNewProtocol>
        where TOldProtocol : IMessage<TOldProtocol>
    {
        /// <summary>
        /// Utils for inner <c>bytes</c>
        /// </summary>
        public Dictionary<TNewParam, ProtoShiftUtils> newutils { get; }
        /// <summary>
        /// Utils for inner <c>bytes</c>
        /// </summary>
        public Dictionary<TOldParam, ProtoShiftUtils> oldutils { get; }
    }

    /// <summary>
    /// It is also used to solve the 'bytes' problem, but what's different is that it's used to handle packets that contains fields with protocols mentioned in <see cref="ISpecialBytesSkillIssueFixer"/>, e.g. <see cref="NewProtos.AbilityInvocationsNotify"/> contains <see cref="NewProtos.AbilityInvokeEntry"/>.
    /// </summary>
    interface ISpecialOuterSkillIssueFixer
    {
        public string Protoname { get; }
        public string ApplyToVersion { get; }
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

    /// <summary>
    /// It is also used to solve the 'bytes' problem, but what's different is that it's used to handle packets that contains fields with protocols mentioned in <see cref="ISpecialBytesSkillIssueFixer"/>, e.g. <see cref="NewProtos.AbilityInvocationsNotify"/> contains <see cref="NewProtos.AbilityInvokeEntry"/>.
    /// <para>The generic type param <typeparamref name="TNewProtocol"/>, <typeparamref name="TOldProtocol"/> is used for fixer, and both of these name should equal to <see cref="ISpecialBytesSkillIssueFixer.Protoname"/>.</para>
    /// </summary>
    interface ISpecialOuterSkillIssueFixer<TNewProtocol, TOldProtocol> : ISpecialOuterSkillIssueFixer
        where TNewProtocol : IMessage<TNewProtocol>
        where TOldProtocol : IMessage<TOldProtocol>
    {
        /// <summary>
        /// The inner fixer. Usually set by outer code for using the same reference object.
        /// </summary>
        public ISpecialBytesSkillIssueFixer<TNewProtocol, TOldProtocol>? fixer_bytes { get; set; }
    }
}
