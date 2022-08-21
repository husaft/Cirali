using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static XmlDedup.DeTools;

namespace XmlDedup
{
    public static class Program
    {
        public static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var root = AppContext.BaseDirectory;
            root = Path.Combine(root, "Inputs");
            root = Path.GetFullPath(root);
            Directory.CreateDirectory(root);
            Console.WriteLine(root);

            var o = SearchOption.AllDirectories;
            var files = Directory.GetFiles(root, "*.*", o);

            var bounds = new
            {
                FORMID = new[] { long.MaxValue, long.MinValue },
                CIRALI = new[] { double.MaxValue, double.MinValue },
                FORMVERSION = new[] { long.MaxValue, long.MinValue },
                MANDANTID = new[] { long.MaxValue, long.MinValue }
            };
            var map = new SortedDictionary<string, (string id, string uid, string ver,
                string fv, string phy, string man)>();

            foreach (var file in files)
            {
                if (file.EndsWith(Non))
                    continue;

                var shortName = file.Replace(root, string.Empty)[1..];
                Console.WriteLine($" * {shortName}");

                var doc = TryLoad(file);
                if (doc == null)
                    continue;
                var id = doc.Descendants("FORMID").FirstOrDefault()?.Value;
                if (string.IsNullOrWhiteSpace(id))
                    continue;
                id = id.PadLeft(5, '0');
                var uid = doc.Descendants("FORMUID").FirstOrDefault()?.Value;
                var ver = doc.Descendants("CIRALI").FirstOrDefault()?.Attribute("version")?.Value;
                var fv = doc.Descendants("FORMVERSION").FirstOrDefault()?.Value;
                fv = fv!.PadLeft(2, '0');
                var man = doc.Descendants("MANDANTID").FirstOrDefault()?.Value;
                man = man!.PadLeft(4, '0');
                var phy = doc.Descendants("PHYSNAME").FirstOrDefault()?.Value;
                map.Add(file, (id, uid, ver, fv, phy, man));

                Update(bounds.FORMID, long.Parse(id));
                Update(bounds.CIRALI, double.Parse(ver ?? "0"));
                Update(bounds.FORMVERSION, long.Parse(fv));
                Update(bounds.MANDANTID, long.Parse(man));

                var grouped = map.GroupBy(m => m.Value).ToArray();

                var steps = grouped
                    .Select(g => g.Key.ToString())
                    .OrderBy(static e => e);
                WriteJson(steps, nameof(grouped));
                WriteJson(bounds, nameof(bounds));

                var keys = grouped.Select(g => $"{g.Key.id}{g.Key.man}{g.Key.fv}")
                    .Distinct().ToArray();
                if (keys.Length != grouped.Length)
                    throw new InvalidOperationException($"Not unique! {string.Join(", ", keys)}");

                Console.WriteLine();

                foreach (var tuple in grouped)
                {
                    var bestFile = tuple.Select(t => new FileInfo(t.Key))
                        .OrderByDescending(t => t.Length).First().FullName;
                    Console.WriteLine(" + Winner is '{0}'!", bestFile);
                    foreach (var other in tuple)
                    {
                        if (other.Key.Equals(bestFile))
                            continue;
                        Console.WriteLine(" - Deleting '{0}'...", other.Key);
                        File.Delete(other.Key);
                    }
                    var g = new { tuple.Key };
                    var destFile = Path.Combine(Path.GetDirectoryName(bestFile)!,
                        $"{g.Key.id}{g.Key.man}{g.Key.fv}.xml");
                    if (bestFile.Equals(destFile))
                        continue;
                    File.Move(bestFile, destFile);
                }

                Console.WriteLine("Done.");
            }
        }
    }
}