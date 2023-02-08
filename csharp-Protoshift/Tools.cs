using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace csharp_Protoshift
{
    internal static class Tools
    {
        public static string ProgramPath => AppDomain.CurrentDomain.BaseDirectory;

        static Random ran = new Random();

        /// <summary>
        /// Generate a random string with length of [len]. 
        /// </summary>
        public static string RandomStr(int len)
        {
            string charset = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            string res = "";
            while (len-- > 0)
            {
                res += charset[ran.Next(0, 61)];
            }
            return res;
        }

        public async static Task ExecuteProcess(string path, string args)
        {
            var p = Process.Start(path, args);
            await p.WaitForExitAsync();
        }

        public static JsonElement GetFieldFromJson(string json, string fieldName)
        {
            var doc = JsonDocument.Parse(json);
#pragma warning disable CS8603 // 可能返回 null 引用。
            return doc.RootElement.GetProperty(fieldName);
#pragma warning restore CS8603 // 可能返回 null 引用。
        }
    }
}
