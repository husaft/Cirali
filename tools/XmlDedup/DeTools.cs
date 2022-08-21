using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace XmlDedup
{
    internal static class DeTools
    {
        internal const string Non = ".non";

        internal static void Update(double[] values, double value)
        {
            if (value < values[0])
                values[0] = value;
            if (value > values[1])
                values[1] = value;
        }

        internal static void Update(long[] values, long value)
        {
            if (value < values[0])
                values[0] = value;
            if (value > values[1])
                values[1] = value;
        }

        internal static void WriteJson(object obj, string name)
        {
            var json = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            });
            File.WriteAllText($"{name}.json", json, Encoding.UTF8);
        }

        internal static XDocument TryLoad(string file)
        {
            try
            {
                using var input = File.OpenRead(file);
                return XDocument.Load(input);
            }
            catch (XmlException)
            {
                var nonFile = file + Non;
                File.Move(file, nonFile);
                return null;
            }
        }
    }
}