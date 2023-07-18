using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
