using CommandLine;
using csharp_Protoshift.GameSession;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class QueryClientOption
    {
        [Option('l', "limit", Required = false, Default = 50, HelpText = "The output limit of query result.")]
        public int Limit { get; set; }
        [Option("range-from", Required = false, Default = uint.MinValue, HelpText = "The minimum value of query range.")]
        public uint MinUid { get; set; }
        [Option("range-to", Required = false, Default = uint.MaxValue, HelpText = "The maximum value of query range.")]
        public uint MaxUid { get; set; }
    }
        
    internal class QueryClientCmd : StandardCommandHandler<QueryClientOption>
    {
        public override string CommandName => "queryclient";

        public override string Description => "Query the online convs of the instance. ";

        public override string Usage => $"queryclient [--limit=50] {Environment.NewLine}" +
            $"  [--range-from <uid_min> --range-to <uid_max>]{Environment.NewLine}" +
            $"  Query the online conv ids. Default output limit is 50, so use --range when query exceeded limit. ";

        public override Task HandleAsync(QueryClientOption opt)
        {
            int limit = opt.Limit;
            uint uid_min = Math.Max(1, opt.MinUid);
            uint uid_max = opt.MaxUid;
            List<KeyValuePair<uint, HandlerSession>> search_res = new((
                from pair in GameSessionDispatch.sessions
                let uid = pair.Value.Uid
                where uid >= uid_min && uid <= uid_max
                select pair).Concat(
                    from pair in GameSessionDispatch.sessions
                    let uid = pair.Value.Uid
                    where uid == 0 && opt.MinUid == 0
                    select pair));
            if (search_res.Count == 0)
            {
                Log.Info($"No match sessions found.", nameof(QueryClientCmd));
            }
            else for (int i = 0; i < search_res.Count; i++)
                {
                    if (i >= limit)
                    {
                        Log.Warn($"Session counts exceeded limit {limit} (total: {search_res.Count}).", nameof(QueryClientCmd));
                        Log.Warn("You may use --range <uid_min> <uid_max> or change the limit, and run the command again.", nameof(QueryClientCmd));
                        break;
                    }
                    Log.Info($"Found uid: {search_res[i].Value.Uid}, conv: {search_res[i].Key}, IP address: {search_res[i].Value.remoteIp}", nameof(QueryClientCmd));
                }
            return Task.CompletedTask;
        }
    }
}