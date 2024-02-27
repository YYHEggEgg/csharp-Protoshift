using YYHEggEgg.ProtoParser;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    internal class SkillIssueCollection
    {
        public bool HasSkillIssue = false;
        public List<CommonResult> CommonFields = new();
        public List<MapResult> MapFields = new();
        public List<OneofResult> OneofFields = new();
    }
}
