using System.Text;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.ProtoHotPatch
{
    internal static partial class ProtoHotPatchCompiler
    {
        private static bool Check(ProtoshiftHotPatchConfig[]? configs)
        {
#if RELEASE
            Log.Erro(PSHP001, nameof(ProtoHotPatchCompiler));
            return false;
#endif
            if (configs == null)
            {
                Log.Erro(PSHP002, nameof(ProtoHotPatchCompiler));
                return false;
            }
            bool full_compile_succ = true;
            List<CompileReports> reports = new(configs.Length);
            #region Config Check
            foreach (var config in configs)
            {
                bool config_compile_succ = true;
                if (!config.Enabled) continue;

                CompileReports curproto_errs = new(config.Proto);
                reports.Add(curproto_errs);
                #region PSHP006
                if (config.Rules.Length == 0)
                {
                    curproto_errs.OuterReport = PSHP006;
                    continue;
                }
                #endregion
                #region Get Types (PSHP004, PSHP005)
                Type? type_proto;
                if (config.ApplyTo == "client")
                {
                    type_proto = Type.GetType($"OldProtos.{config.Proto}, {OldProtosAssembly}");
                }
                else if (config.ApplyTo == "server")
                {
                    type_proto = Type.GetType($"NewProtos.{config.Proto}, {NewProtosAssembly}");
                }
                else
                {
                    curproto_errs.OuterReport = PSHP005;
                    full_compile_succ = false;
                    continue;
                }
                Type? handler_proto = Type.GetType($"csharp_Protoshift.Enhanced.Handlers" +
                        $".GeneratedCode.Handler{config.Proto}, {ProtoshiftHandlersAssembly}");
                if (type_proto == null || handler_proto == null)
                {
                    curproto_errs.OuterReport = PSHP004;
                    full_compile_succ = false;
                    continue;
                }
                #endregion
                #region PSHP017
                if (type_proto.IsEnum)
                {
                    curproto_errs.OuterReport = PSHP017;
                    full_compile_succ = false;
                    continue;
                }
                #endregion
                #region Get Skill issues info (PSHP010)
                var oldSkillIssueList =
                    (List<(string type_protobuf, string name_protobuf, string name_compiled, bool supported_type)>?)
                    handler_proto.GetField("oldSkillIssueList")?.GetValue(null);
                var newSkillIssueList =
                    (List<(string type_protobuf, string name_protobuf, string name_compiled, bool supported_type)>?)
                    handler_proto.GetField("newSkillIssueList")?.GetValue(null);
                if (oldSkillIssueList == null || newSkillIssueList == null)
                {
                    curproto_errs.OuterReport = PSHP010;
                    full_compile_succ = false;
                    continue;
                }
                #endregion
                for (int i = 0; i < config.Rules.Length; i++)
                {
                    var rule = config.Rules[i];
                    var analyze_res = AnalyzeRule(rule, config.ApplyTo == "client",
                        type_proto, handler_proto, oldSkillIssueList, newSkillIssueList);
                    config_compile_succ = config_compile_succ && !analyze_res.failed;

                    if (analyze_res.failmessages.Count > 0)
                    {
                        curproto_errs.RuleReports.Add((i, analyze_res));
                        
                    }
                    config.Rules[i] = $"{analyze_res.frmField}->{analyze_res.toField}";
                }
                full_compile_succ = full_compile_succ && config_compile_succ;
            }
            #endregion
            #region Output Warning/Errors
            bool zero_warning = true;

            StringBuilder sb = new("HotPatch compile result: ");
            sb.AppendLine($"(from file: {Path.GetFullPath("skillissue_fix_config.json")})");
            sb.AppendLine();
            foreach (var configReport in reports)
            {
                if (configReport.OuterReport == null && configReport.RuleReports.Count == 0)
                    continue;
                zero_warning = false;
                sb.AppendLine($"In Proto: {configReport.Proto}");
                if (configReport.OuterReport != null)
                {
                    sb.AppendLine($"  {configReport.OuterReport}");
                }
                foreach (var ruleReport in configReport.RuleReports)
                {
                    var failmessages = configReport.RuleReports[ruleReport.number].Item2.failmessages;
                    if (failmessages.Count == 0) continue;
                    sb.AppendLine($"  In Rule {ruleReport.number}:");
                    foreach (var err in failmessages)
                    {
                        sb.AppendLine($"    {err}");
                    }
                }
            }
            if (!zero_warning)
            {
                Log.Info(sb.ToString(), nameof(ProtoHotPatchCompiler));
            }
            #endregion
            if (full_compile_succ)
            {
                HotPatchMiddleware.Apply();
                Log.Info($"Applied Proto HotPatch successfully.", nameof(ProtoHotPatchCompiler));
                if (!zero_warning)
                {
                    Log.Warn("Please checkout the warnings below.", nameof(ProtoHotPatchCompiler));
                    Log.Warn($"The compiler don't guarantee that it correctly understanded the config," +
                        $"so it's recommended to fix warnings first.", nameof(ProtoHotPatchCompiler));
                }
                return true;
            }
            else
            {
                Log.Erro($"Build failure. Please fix the errors and compile again.", nameof(ProtoHotPatchCompiler));
                return false;
            }
        }

        private class RuleAnalyzeResult
        {
            public string? frmField;
            public string? toField;
            /// <summary>
            /// Empty means no error
            /// </summary>
            public List<string> failmessages = new();
            public bool failed = false;
        }

        private static RuleAnalyzeResult AnalyzeRule(string rule, bool isNewShiftToOld,
            Type type_proto, Type handler_proto,
            List<(string type_protobuf, string name_protobuf, string name_compiled, bool supported_type)> oldSkillIssueList,
            List<(string type_protobuf, string name_protobuf, string name_compiled, bool supported_type)> newSkillIssueList)
        {
            RuleAnalyzeResult rtn = new();
            #region PSHP007
            if (!rule.Contains(identifier_connect))
            {
                rtn.failmessages.Add(PSHP007);
                rtn.failed = true;
                return rtn;
            }
            #endregion
            #region split string (PSHP008, PSHP020)
            rtn.frmField = rule.Substring(0, rule.IndexOf(identifier_connect));
            rtn.toField = rule.Substring(rule.IndexOf(identifier_connect) + identifier_connect.Length);
            if (string.IsNullOrEmpty(rtn.frmField) || string.IsNullOrEmpty(rtn.toField))
            {
                rtn.failmessages.Add(PSHP008);
                rtn.failed = true;
            }
            if (rtn.toField.Contains(identifier_connect))
            {
                rtn.failmessages.Add(PSHP020);
                rtn.failed = true;
            }
            if (rtn.failed) return rtn;
            #endregion
            #region Prepare
            var empty = default((string type_protobuf, string name_protobuf, string name_compiled, bool supported_type));
            var final_frmField = empty;
            var final_toField = empty;

            var frmField_old = (from tuple in oldSkillIssueList
                                where tuple.name_compiled == rtn.frmField
                                select tuple).FirstOrDefault();
            var frmField_new = (from tuple in newSkillIssueList
                                where tuple.name_compiled == rtn.frmField
                                select tuple).FirstOrDefault();
            var toField_old = (from tuple in oldSkillIssueList
                               where tuple.name_compiled == rtn.toField
                               select tuple).FirstOrDefault();
            var toField_new = (from tuple in newSkillIssueList
                               where tuple.name_compiled == rtn.toField
                               select tuple).FirstOrDefault();

            var frmField_old_origin = (from tuple in oldSkillIssueList
                                       where tuple.name_protobuf == rtn.frmField
                                       select tuple).FirstOrDefault();
            var frmField_new_origin = (from tuple in newSkillIssueList
                                       where tuple.name_protobuf == rtn.frmField
                                       select tuple).FirstOrDefault();
            var toField_old_origin = (from tuple in oldSkillIssueList
                                      where tuple.name_protobuf == rtn.toField
                                      select tuple).FirstOrDefault();
            var toField_new_origin = (from tuple in newSkillIssueList
                                      where tuple.name_protobuf == rtn.toField
                                      select tuple).FirstOrDefault();
            #endregion
            #region Correct Match
            if ((isNewShiftToOld && frmField_new != empty && toField_old != empty)
                || (!isNewShiftToOld && frmField_old != empty && toField_new != empty))
            {
                final_frmField = isNewShiftToOld ? frmField_new : frmField_old;
                final_toField = isNewShiftToOld ? toField_old : toField_new;
            }
            #endregion
            #region Protobuf name Match (PSHP012)
            else if ((isNewShiftToOld &&
                (frmField_new != empty || frmField_new_origin != empty)
                && (toField_old != empty || toField_old_origin != empty))

                || (!isNewShiftToOld &&
                (frmField_old != empty || frmField_old_origin != empty)
                && (toField_new != empty || toField_new_origin != empty)))
            {
                var frmSource = isNewShiftToOld ? frmField_new : frmField_old;
                var frmSource_origin = isNewShiftToOld ? frmField_new_origin : frmField_old_origin;
                final_frmField = frmSource;
                if (frmSource == empty && frmSource_origin != empty)
                {
                    final_frmField = frmSource_origin;
                }
                var toSource = isNewShiftToOld ? toField_old : toField_new;
                var toSource_origin = isNewShiftToOld ? toField_old_origin : toField_new_origin;
                final_toField = toSource;
                if (toSource == empty && toSource_origin != empty)
                {
                    final_toField = toSource_origin;
                }
                rtn.failmessages.Add(PSHP012);
            }
            #endregion
            #region Reverse Match (PSHP011)
            else if ((!isNewShiftToOld && frmField_new != empty && toField_old != empty)
                || (isNewShiftToOld && frmField_old != empty && toField_new != empty))
            {
                final_frmField = (!isNewShiftToOld) ? frmField_new : frmField_old;
                final_toField = (!isNewShiftToOld) ? toField_old : toField_new;
                rtn.failmessages.Add(PSHP011);
            }
            else if ((isNewShiftToOld &&
                (frmField_old != empty || frmField_old_origin != empty)
                && (toField_new != empty || toField_new_origin != empty))

                || (!isNewShiftToOld &&
                (frmField_new != empty || frmField_new_origin != empty)
                && (toField_old != empty || toField_old_origin != empty)))
            {
                var frmSource = isNewShiftToOld ? frmField_old : frmField_new;
                var frmSource_origin = isNewShiftToOld ? frmField_old_origin : frmField_new_origin;
                final_toField = frmSource;
                if (frmSource == empty && frmSource_origin != empty)
                {
                    final_toField = frmSource_origin;
                }
                var toSource = isNewShiftToOld ? toField_new : toField_old;
                var toSource_origin = isNewShiftToOld ? toField_new_origin : toField_old_origin;
                final_frmField = toSource;
                if (toSource == empty && toSource_origin != empty)
                {
                    final_frmField = toSource_origin;
                }
                rtn.failmessages.Add(PSHP012);

                rtn.failmessages.Add(PSHP011);
            }
            #endregion
            #region Failed to Match
            else
            {
                final_frmField = isNewShiftToOld ? frmField_new : frmField_old;
                final_toField = isNewShiftToOld ? toField_old : toField_new;

                if (final_frmField.name_compiled == type_proto.Name
                    || final_toField.name_compiled == type_proto.Name)
                {
                    rtn.failmessages.Add(PSHP018);
                    rtn.failed = true;
                }
                if (type_proto.GetProperty($"{final_frmField.name_compiled}Case") != null)
                {
                    rtn.failmessages.Add(PSHP019);
                    rtn.failed = true;
                }

                if (!rtn.failed)
                {
                    rtn.failmessages.Add(PSHP009);
                    rtn.failed = true;
                }
                return rtn;
            }
            #endregion
            #region Check shift ability
            if (final_frmField.type_protobuf != final_toField.type_protobuf)
            {
                rtn.failmessages.Add(PSHP013);
                rtn.failed = true;
            }
            if (!final_frmField.supported_type || !final_toField.supported_type)
            {
                rtn.failmessages.Add(PSHP014);
                rtn.failed = true;
            }
            if (rtn.failed) return rtn;
            #endregion
            rtn.frmField = final_frmField.name_compiled;
            rtn.toField = final_toField.name_compiled;
            return rtn;
        }

        private class CompileReports
        {
            public string Proto;

            public CompileReports(string proto)
            {
                Proto = proto;
            }

            public string? OuterReport;
            public List<(int number, RuleAnalyzeResult)> RuleReports = new();
        }
    }
}
