using csharp_Protoshift.GameSession;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal static class TargetManager
    {
        public static uint TargetUid = 0;

        /// <summary>
        /// Get the session that can be used by actual operations.
        /// </summary>
        /// <param name="conv">The conv id user requested. Treat 0 as not given.</param>
        /// <param name="uid">The UID user requested. Treat 0 as not given.</param>
        /// <returns>The final session. Treat null as failure.</returns>
        public static HandlerSession? GetSession(LoggerChannel logger, uint conv, uint uid)
        {
            uint validconv = 0;
            uint validuid = 0;
            if (conv == 0 && uid == 0)
            {
                if (TargetUid != 0) validuid = TargetUid;
            }
            else if (conv != 0)
            {
                if (uid != 0)
                {
                    logger.LogWarn($"When conv id and uid are both given, conv id takes effect.");
                }
                validconv = conv;
            }
            else if (uid != 0) validuid = uid;

            if (validconv == 0 && validuid == 0)
            {
                logger.LogErro($"Cannot get the target for command. You can:");
                logger.LogErro($"- Give a valid UID or set default with 'target' command.");
                logger.LogErro($"- Give a direct conv id by using 'queryclient' command.");
                return null;
            }

            var collection = GameSessionDispatch.sessions;
            if (collection.IsEmpty)
            {
                logger.LogErro($"There are no sessions online.");
                return null;
            }
            if (validconv != 0)
            {
                if (collection.TryGetValue(validconv, out var res_session)) return res_session;
                logger.LogErro($"The conv id not found. Maybe the conv is currently offline.");
                return null;
            }
            else
            {
                var q_res = from session in collection.Values
                            where session.Uid == validuid
                            select session;
                var cnt = q_res.Count();
                if (cnt <= 0)
                {
                    logger.LogErro($"Not found any online sessions match the uid. Maybe the uid is currently offline.");
                    return null;
                }
                else if (cnt == 1) return q_res.First();
                else
                {
                    logger.LogErro($"Found more than 1 online sessions that match the uid, which may be a error. ");
                    logger.LogInfo($"Run 'queryclient --range-min {validuid} --range-max {validuid}' to get these sessions' conv id.");
                    return null;
                }
            }
        }

        /// <summary>
        /// Get the session that can be used by actual operations.
        /// </summary>
        /// <param name="o">The commandline options. Treat param = 0 as not given.</param>
        /// <returns>The final session. Treat null as failure.</returns>
        public static HandlerSession? GetSession(this TargetOptionAbstract o, LoggerChannel logger) =>
            GetSession(logger, o.Conv, o.Uid);

        /// <summary>
        /// Get the conv id that can be used by actual operations.
        /// </summary>
        /// <param name="conv">The conv id user requested. Treat 0 as not given.</param>
        /// <param name="uid">The UID user requested. Treat 0 as not given.</param>
        /// <returns>The final conv id. Treat 0 as failure.</returns>
        public static uint GetConv(LoggerChannel logger, uint conv, uint uid) =>
            GetSession(logger, conv, uid)?.SessionId ?? 0;

        /// <summary>
        /// Get the conv id that can be used by actual operations.
        /// </summary>
        /// <param name="o">The commandline options. Treat param = 0 as not given.</param>
        /// <returns>The final conv id. Treat 0 as failure.</returns>
        public static uint GetConv(this TargetOptionAbstract o, LoggerChannel logger) =>
            o.GetSession(logger)?.SessionId ?? 0;
    }
}