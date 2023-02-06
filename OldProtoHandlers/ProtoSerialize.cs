using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OldProtos
{
    public class ProtoSerialize
    {
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS8602 // 解引用可能出现空引用。
#pragma warning disable CS8604 // 引用类型参数可能为 null。W
        public ProtoSerialize(string protoname) : this(Type.GetType(protoname)) { }

        public ProtoSerialize(Type prototype)
        {
            var parser_pro = prototype.GetProperty("Parser", BindingFlags.Static | BindingFlags.Public);
            var parse_get = parser_pro.GetGetMethod();
            Parser = (MessageParser)parse_get.Invoke(null, null);
            Parser = Parser.WithDiscardUnknownFields(true);
            Protoname = prototype.Name;
            isNull = false;
        }
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
#pragma warning restore CS8602 // 解引用可能出现空引用。
#pragma warning restore CS8604 // 引用类型参数可能为 null。

        public MessageParser Parser;
        public readonly string Protoname;

        private ProtoSerialize() 
        {
            Parser = WindSeedClientNotify.Parser; // Fuck
            Protoname = "YYHEggEggg#6167";
            isNull = true;
        }
        public readonly bool isNull;
        public static ProtoSerialize Empty { get => new(); }

        public string DeserializeToJson(byte[] protobin)
        {
            if (isNull) throw new InvalidOperationException("Trying to use an invalid instance.");
            return JsonFormatter.Default.Format(Parser.ParseFrom(protobin));
        }

        public byte[] SerializeFromJson(string protojson)
        {
            if (isNull) throw new InvalidOperationException("Trying to use an invalid instance.");
            return MessageExtensions.ToByteArray(Parser.ParseJson(protojson));
        }
    }
}
