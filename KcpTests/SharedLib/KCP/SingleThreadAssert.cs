namespace csharp_Protoshift
{
    /// <summary>
    /// Assert 是否存在线程安全问题
    /// </summary>
    public class SingleThreadAssert
    {
#if STA_ASSERT
        private bool occupying = false;
#if DEBUG
        private string occupier_StackTrace = "-----STA Assert not invoked yet-----";
#endif
        public readonly string FriendlyName;
        public readonly UInt64 Unique_ID;

        private static object increasing_id_lock = "wtf am I debugging";
        private static UInt64 increasing_id = 0;
#endif

        public SingleThreadAssert(string friendlyName)
        {
#if STA_ASSERT
            FriendlyName = friendlyName;
            lock (increasing_id_lock) Unique_ID = increasing_id++;
#endif
        }

        public void Enter()
        {
#if STA_ASSERT
            if (occupying)
            {
                Log.Erro($"STA Assert failed! 2nd invoker stacktrace: \n{Environment.StackTrace}", $"{nameof(SingleThreadAssert)}({FriendlyName}, ID:{Unique_ID})");
#if DEBUG
                Log.Erro($"1st invoker stacktrace: \n{occupier_StackTrace}", $"{nameof(SingleThreadAssert)}({FriendlyName}, ID:{Unique_ID})");
                throw new InvalidOperationException($"STA Assert for ({FriendlyName}, ID:{Unique_ID}) failed!");
#endif
            }
            else
            {
                occupying = true;
#if DEBUG
                occupier_StackTrace = Environment.StackTrace;
#endif
            }
#endif
        }

        public void Exit()
        {
#if STA_ASSERT
            occupying = false;
#endif
        }
    }
}
