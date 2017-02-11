using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using NeaUtils.Misc;

namespace NeaUtils.Extensions.XmlExtensions
{
    public static class Generic
    {
        public static bool SerializeToFile<T>(this T value, string filePath)
        {
            if (value == null) return false;

            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var stringWriter = new Utf8StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true,Encoding = Encoding.UTF8}))
                {
                    xmlSerializer.Serialize(xmlWriter, value);
                    File.WriteAllText(filePath, stringWriter.ToString());
                    return true;
                }
            }
        }

        public static T DeserializeFromFile<T>(this T value, string filePath)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            T result;

            using (TextReader reader = new StringReader(File.ReadAllText(filePath)))
            {
                result = (T)xmlSerializer.Deserialize(reader);
            }
            return result;
        }

        public static T DeserializeFromStream<T>(this T value, Stream stream)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            T result;
            using (stream)
            {
                result = (T)xmlSerializer.Deserialize(stream);
            }
            return result;
        }
    }
}
