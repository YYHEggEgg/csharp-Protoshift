using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.ProtoHotPatch
{
    public static class HotPatchMiddleware
    {
        private static object hotpatch_lck = "March 7th with P.A.I.M.O.N";
        internal static HotPatchReadOnlyWorker Worker { get; private set; } = new();

        private static Dictionary<string, Func<(object oldprotocol, object newprotocol_return), object>> config_applyold = new();
        private static Dictionary<string, Func<(object newprotocol, object oldprotocol_return), object>> config_applynew = new();
        
        /// <summary>
        /// Prepare for a config apply to server.
        /// </summary>
        public static void AssignOldShiftToNewMiddleware(string proto,
            Func<(object oldprotocol, object newprotocol_return), object> worker)
        {
            lock (hotpatch_lck)
            {
                string handler_name = proto.Replace(".Types.", ".Handler");
                Debug.Assert(Type.GetType($"csharp_Protoshift.Enhanced.Handlers.GeneratedCode.Handler{handler_name}") != null);
                config_applyold.Add(proto, worker);
            }
        }

        /// <summary>
        /// Prepare for a config apply to client.
        /// </summary>
        public static void AssignNewShiftToOldMiddleware(string proto,
            Func<(object newprotocol, object oldprotocol_return), object> worker)
        {
            lock (hotpatch_lck)
            {
                string handler_name = proto.Replace(".Types.", ".Handler");
                Debug.Assert(Type.GetType($"csharp_Protoshift.Enhanced.Handlers.GeneratedCode.Handler{handler_name}") != null);
                config_applynew.Add(proto, worker);
            }
        }

        /// <summary>
        /// Clear the assigned proto and workers.
        /// </summary>
        public static void Clear()
        {
            lock (hotpatch_lck)
            {
                config_applyold = new();
                config_applynew = new();
                Worker = new();
            }
        }

        /// <summary>
        /// Apply the existed configs in use, and clear the assignments.
        /// </summary>
        public static void Apply()
        {
            lock (hotpatch_lck)
            {
                Worker = new(config_applyold, config_applynew);
            }
        }
    }

    internal class HotPatchReadOnlyWorker
    {
        public readonly bool Empty;

        private ReadOnlyCollection<string> enabled_config_protos_applyold;
        private ReadOnlyDictionary<string, Func<(object oldprotocol, object newprotocol_return), object>> config_applyold;
        private ReadOnlyCollection<string> enabled_config_protos_applynew;
        private ReadOnlyDictionary<string, Func<(object newprotocol, object oldprotocol_return), object>> config_applynew;

        public HotPatchReadOnlyWorker(Dictionary<string, Func<(object oldprotocol, object newprotocol_return), object>> config_applyold,
            Dictionary<string, Func<(object newprotocol, object oldprotocol_return), object>> config_applynew)
        {
            this.config_applyold = new(config_applyold);
            this.config_applynew = new(config_applynew);
            enabled_config_protos_applyold = new(config_applyold.Keys.ToList());
            enabled_config_protos_applynew = new(config_applynew.Keys.ToList());
            Empty = false;
        }

        public bool HasOldShiftToNewMiddleare(string proto)
            => Empty ? false : enabled_config_protos_applyold.Contains(proto);
        public object ExecuteOldShiftToNewMiddleware(string proto, object oldprotocol, object newprotocol_return)
            => config_applyold[proto].Invoke((oldprotocol, newprotocol_return));
        public bool HasNewShiftToOldMiddleare(string proto)
            => Empty ? false : enabled_config_protos_applynew.Contains(proto);
        public object ExecuteNewShiftToOldMiddleware(string proto, object newprotocol, object oldprotocol_return)
            => config_applynew[proto].Invoke((newprotocol, oldprotocol_return));

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public HotPatchReadOnlyWorker()
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        {
            Empty = true;
        }
    }
}
