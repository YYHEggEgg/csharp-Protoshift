namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    internal static class GenProtoshiftDispatch
    {
        public static void Run(CmdIdDataStructure cmdData, string genFilePath,
            List<Dictionary<string, MergeChange>> mergeChanges)
        {
            using (BasicCodeWriter fi = new(genFilePath))
            {
                #region Code file Start
                fi.WriteLine("// <auto-generated>");
                fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator. ");
                fi.WriteLine("// </auto-generated>");
                fi.WriteLine();
                fi.WriteLine("#nullable enable");
                fi.WriteLine("#region Designer Generated Code");
                fi.WriteLine("using Google.Protobuf;");
                fi.WriteLine();
                fi.WriteLine("namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode");
                fi.EnterCodeRegion();
                fi.WriteLine("public static class ProtoshiftDispatch");
                fi.EnterCodeRegion();
                #endregion
                int curMethodNum = 0;
                #region (New -> Old, reload: byte[])
                GenMethodEntry(fi, true, ShiftDataType.ByteArray);
                fi.EnterCodeRegion();
                fi.WriteLine("switch (cmdid)");
                fi.EnterCodeRegion();
                GenMergeNotice(fi);
                GenMethodBody(fi, true, ShiftDataType.ByteArray, mergeChanges[curMethodNum], cmdData.cmdlist_order_new);
                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                curMethodNum++;
                #endregion
                #region (New -> Old, reload: Span)
                GenMethodEntry(fi, true, ShiftDataType.ReadOnlySpan);
                fi.EnterCodeRegion();
                fi.WriteLine("switch (cmdid)");
                fi.EnterCodeRegion();
                GenMergeNotice(fi);
                GenMethodBody(fi, true, ShiftDataType.ReadOnlySpan, mergeChanges[curMethodNum], cmdData.cmdlist_order_new);
                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                curMethodNum++;
                #endregion
                #region (New -> Old, reload: ByteString)
                GenMethodEntry(fi, true, ShiftDataType.ByteString);
                fi.EnterCodeRegion();
                fi.WriteLine("switch (cmdid)");
                fi.EnterCodeRegion();
                GenMergeNotice(fi);
                GenMethodBody(fi, true, ShiftDataType.ByteString, mergeChanges[curMethodNum], cmdData.cmdlist_order_new);
                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                curMethodNum++;
                #endregion
                #region (Old -> New, reload: byte[])
                GenMethodEntry(fi, false, ShiftDataType.ByteArray);
                fi.EnterCodeRegion();
                fi.WriteLine("switch (cmdid)");
                fi.EnterCodeRegion();
                GenMergeNotice(fi);
                GenMethodBody(fi, false, ShiftDataType.ByteArray, mergeChanges[curMethodNum], cmdData.cmdlist_order_new);
                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                curMethodNum++;
                #endregion
                #region (Old -> New, reload: Span)
                GenMethodEntry(fi, false, ShiftDataType.ReadOnlySpan);
                fi.EnterCodeRegion();
                fi.WriteLine("switch (cmdid)");
                fi.EnterCodeRegion();
                GenMergeNotice(fi);
                GenMethodBody(fi, false, ShiftDataType.ReadOnlySpan, mergeChanges[curMethodNum], cmdData.cmdlist_order_new);
                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                curMethodNum++;
                #endregion
                #region (Old -> New, reload: ByteString)
                GenMethodEntry(fi, false, ShiftDataType.ByteString);
                fi.EnterCodeRegion();
                fi.WriteLine("switch (cmdid)");
                fi.EnterCodeRegion();
                GenMergeNotice(fi);
                GenMethodBody(fi, false, ShiftDataType.ByteString, mergeChanges[curMethodNum], cmdData.cmdlist_order_new);
                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                #endregion
                #region Code file End
                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                fi.WriteLine("#nullable disable");
                fi.WriteLine("#endregion Designer generated code");
                #endregion
            }
        }

        #region Hardcoded
        private enum ShiftDataType
        {
            ByteArray = 0,
            ReadOnlySpan = 1,
            ByteString = 2;
        }

        private static void GenMethodEntry(BasicCodeWriter fi, bool isGenNewShiftToOld, ShiftDataType paramType)
        {
            string packetFrom = isGenNewShiftToOld ? "client" : "server";
            string packetTo = isGenNewShiftToOld ? "server" : "client";
            string protocol = isGenNewShiftToOld ? "Old" : "New";
            string method_identifier = isGenNewShiftToOld ? "NewShiftToOld" : "OldShiftToNew"
            fi.WriteLine("/// <summary>");
            fi.WriteLine($"/// Protoshift a base packet from {packetFrom}.");
            fi.WriteLine("/// </summary>");
            fi.WriteLine("/// <param name=\"cmdid\">The cmd_id to dispatch the packet.</param>");
            fi.WriteLine($"/// <param name=\"head\">The head (for dispatching packet). If not providing head, it may be set {(paramType == ShiftDataType.ReadOnlySpan ? "empty" : "null")}. </param>");
            if (paramType == ShiftDataType.ByteArray)
            {
                fi.WriteLine("/// <param name=\"head_offset\">The offset of the <paramref name=\"head\"/>. If not providing head, it may be set null. </param>");
                fi.WriteLine("/// <param name=\"head_length\">The valid length of the <paramref name=\"head\"/>. If not providing head, it may be set null. </param>");
            }
            fi.WriteLine("/// <param name=\"body\">The main body (protobuf).</param>");
            if (paramType == ShiftDataType.ByteArray)
            {
                fi.WriteLine("/// <param name=\"body_offset\">The offset of the <paramref name=\"body\"/>.</param>");
                fi.WriteLine("/// <param name=\"body_length\">The valid length of the <paramref name=\"body\"/>.</param>");
            }
            fi.WriteLine($"/// <returns>The protobuf with {protocol}Protos, can be sent to {packetTo}.</returns>");
            fi.WriteLine("/// <exception cref=\"ArgumentNullException\">The <paramref name=\"head\"/> is not null, but provided null for <paramref name=\"head_length\"/> or <paramref name=\"head_offset\"/>.</exception>");
            fi.WriteLine("/// <exception cref=\"ArgumentException\">Provided offset & length exceeded the readable length.</exception>");
            fi.WriteLine("/// <exception cref=\"NotSupportedException\">The input <paramref name=\"cmdid\"/> is not supported to be Protoshifted.</exception>");
            switch (paramType)
            {
                case ShiftDataType.ByteArray: 
                    fi.WriteLine($"public static byte[] {method_identifier}(uint cmdid, ",
                        "byte[]? head, int? head_offset, int? head_length, ",
                        "byte[] body, int body_offset, int body_length)");
                break;
            case ShiftDataType.ReadOnlySpan: 
                fi.WriteLine($"public static byte[] {method_identifier}(uint cmdid, ReadOnlySpan<byte> head, ReadOnlySpan<byte> body)");
                break;
            case ShiftDataType.ByteString: 
                fi.WriteLine($"public static byte[] {method_identifier}(uint cmdid, ByteString? head, ByteString body)");
                break;
            }
        }

        private static void GenMergeNotice(BasicCodeWriter fi)
        {
            fi.WriteLine("// For convience, the following code is marked as 'merge - Generated Code'.");
            fi.WriteLine("// In the 'merge code region', if you want to modify some code:");
            fi.WriteLine("// First, find the proto name & cmdid you want to modify;");
            fi.WriteLine("// Second, write the proto name at the comment;");
            fi.WriteLine("// Third, write '- merge - ignore case';");
            fi.WriteLine("// Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.");
            fi.WriteLine("// ");
            fi.WriteLine("// NOTICE: If you modified the code here, you may also do the same change");
            fi.WriteLine("//         in the implement below in different reloads. ");
            fi.WriteLine("// ");
            fi.WriteLine("// NOTICE 2: Change code here is very unconvenient. ");
            fi.WriteLine("//           It's suggested to change in the Handler. ");
            fi.WriteLine("//");
            fi.WriteLine("// Below is mergable region");
        }
        #endregion
    
        private static void GenMethodBody(BasicCodeWriter fi, 
            bool isGenNewShiftToOld, ShiftDataType paramType, Dictionary<string, MergeChange> mergeChanges,
            IOrderedEnumerable<IGrouping<int, (string messageName, int oldcmdid, int newcmdid)>> cmdlist_order)
        {
            string identifier = isGenNewShiftToOld ? "New" : "Old";
            string method_identifier = isGenNewShiftToOld ? "NewShiftToOld" : "OldShiftToNew";
            string invokeParam = (paramType == ShiftDataType.ByteArray) ? "body, body_offset, body_length" : "body";

            fi.WriteLine("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/");
            foreach (var grp in cmdlist_order)
            {
                if (grp.Count() == 1)
                {
                    var tuple = grp.First();
                    #region 1. No conflict, auto generate
                    if (!mergeChanges.ContainsKey(tuple.messageName))
                    {
                        fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                            $"return handler_{tuple.messageName}.{method_identifier}({invokeParam}); ");
                    }
                    #endregion
                    #region 2. No conflict, but ignore the case for human written before
                    else
                    {
                        fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                            mergeChanges[tuple.messageName].CodeLines);
                        Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                    }
                    #endregion
                }
                else if (grp.Count() == 0)
                {
                    Log.Erro("3. FUCK (this line never shows)", "ProtoshiftDispatch_Generate");
                }
                else
                {
                    #region 4. Have conflict, but solved before
                    bool merged_haveConflict = false;
                    foreach (var tuple in grp)
                    {
                        if (mergeChanges.ContainsKey(tuple.messageName))
                        {
                            fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                                mergeChanges[tuple.messageName].CodeLines);
                            Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                            merged_haveConflict = true;
                            break;
                        }
                    }
                    #endregion
                    #region 5. Have conflict, never solved
                    if (!merged_haveConflict)
                    {
                        var writing_list = new List<string>
                        {
                            "// Please solve the proto conflict here. You may refer to ShiftCmdId.cs " +
                            "to get info about the exception and the beginning of this method " +
                            "to get modification grammar."
                        };
                        foreach (var tuple in grp)
                        {
                            writing_list.Add($"// return handler_{tuple.messageName}.{method_identifier}({invokeParam}); ");
                        }
                        writing_list.Add("throw new NotSupportedException(\"The cmdid conflict " +
                            "haven't been solved. Search for 'request special handle' in " +
                            "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                            "the exception, look at the beginning of this method in " +
                            "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                            "to get modification grammar, and search for 'solve the proto conflict here'.\"); ");
                        fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                            writing_list);
                        Log.Warn($"ProtoshiftDispatch.{method_identifier} has cmd_id conflict to be solved " +
                            $"(affected {identifier}Cmd: {grp.Key}). Search for 'request special handle' in " +
                            "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                            "the exception, look at the beginning of {method_identifier} method in " +
                            "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                            "to get modification grammar, and search for 'solve the proto conflict here'.",
                            "ProtoshiftDispatch_Generate");
                    }
                    #endregion
                }
            }
            fi.WriteLine("/***********End mergable region --- DO NOT EDIT THIS LINE***********/");
            fi.WriteLine("default: ",
                "throw new NotSupportedException(\"The input cmdid is not supported to be Protoshifted.\"); ");
        }
    }
}