using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OldProtos
{
    public class ProtoSerialize
    {
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
#pragma warning disable CS8602 // 解引用可能出现空引用。
#pragma warning disable CS8604 // 引用类型参数可能为 null。W
        public ProtoSerialize(string protoname) : this(Type.GetType($"OldProtos.{protoname}")) { }

        public ProtoSerialize(Type prototype)
        {
            var parser_pro = prototype.GetProperty("Parser", BindingFlags.Static | BindingFlags.Public);
            var parse_get = parser_pro.GetGetMethod();
            Prototype = prototype;
            Parser = (MessageParser)parse_get.Invoke(null, null);
            Parser = Parser.WithDiscardUnknownFields(true);
            Protoname = prototype.Name;
            isNull = false;
            DeserializeToJson(SerializeFromJson("{}")); // Initialize protobuf class
        }
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
#pragma warning restore CS8602 // 解引用可能出现空引用。
#pragma warning restore CS8604 // 引用类型参数可能为 null。

        static ProtoSerialize()
        {
            var settings = JsonParser.Settings.Default.WithIgnoreUnknownFields(true);
            Discard_Unknown_fields_Parser = new JsonParser(settings);
        }
        public readonly static JsonParser Discard_Unknown_fields_Parser;

        public MessageParser Parser;
        public readonly string Protoname;
        public readonly Type Prototype;

        private ProtoSerialize()
        {
            Parser = WindSeedClientNotify.Parser; // Fuck
            Protoname = "YYHEggEggg#6167";
            isNull = true;
            Prototype = typeof(StackOverflowException);
        }
        public readonly bool isNull;
        public static ProtoSerialize Empty { get => new(); }

        public string DeserializeToJson(byte[] protobin)
        {
            if (isNull) throw new InvalidOperationException("Trying to use an invalid instance.");
            return JsonFormatter.Default.Format(Parser.ParseFrom(protobin));
        }

        public string DeserializeToJson(byte[] protobin, int offset, int length)
        {
            if (isNull) throw new InvalidOperationException("Trying to use an invalid instance.");
            return JsonFormatter.Default.Format(Parser.ParseFrom(protobin, offset, length));
        }

        public string DeserializeFromProto<T>(T protocol) where T : IMessage<T>
        {
            return JsonFormatter.Default.Format(protocol);
        }

        private IMessage SerializeToIMessage(string protojson)
        {
            return Parser.ParseJson(protojson);
        }

        /// <summary>
        /// No any checks. Use it at your own risk.
        /// </summary>
        public T SerializeToProto<T>(string protojson) where T : IMessage<T>
        {
            return (T)SerializeToIMessage(protojson);
        }

        public byte[] SerializeFromJson(string protojson)
        {
            if (isNull) throw new InvalidOperationException("Trying to use an invalid instance.");
            try
            {
                return MessageExtensions.ToByteArray(SerializeToIMessage(protojson));
            }
            catch (InvalidProtocolBufferException)
            {
                // json has unknown fields, fallback to Reflection
                // The following reflecting invoke equals to:
                // JsonParser.Default.Parse<GetPlayerTokenReq>(protojson);
                var parse_type = typeof(JsonParser);
                var parse_method = parse_type.GetMethod("Parse", BindingFlags.Instance | BindingFlags.Public,
                    new Type[] { typeof(string) });
                var parse_method_T = parse_method.MakeGenericMethod(Prototype);
                return MessageExtensions.ToByteArray(parse_method_T.Invoke(
                    Discard_Unknown_fields_Parser, new object[] { protojson }) as IMessage);
            }
        }
    }
}
