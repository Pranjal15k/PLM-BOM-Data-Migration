using System.Collections.Generic;
using System.IO;
using BOMMigration.Console.Models;

namespace BOMMigration.Console.Services
{
    public class CsvService
    {
        public List<BomRelation> ReadBomCsv(string path)
        {
            var list = new List<BomRelation>();

            if (!File.Exists(path))
            {
                System.Console.WriteLine($"CSV file not found: {path}");
                return list; // RETURN EMPTY LIST (IMPORTANT)
            }

            var lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                // Skip empty lines
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var cols = lines[i].Split(',');

                // Skip invalid rows
                if (cols.Length < 3)
                {
                    System.Console.WriteLine($"Skipping invalid row: {lines[i]}");
                    continue;
                }

                list.Add(new BomRelation
                {
                    ParentPart = cols[0].Trim(),
                    ChildPart = cols[1].Trim(),
                    Quantity = int.Parse(cols[2].Trim())
                });
            }

            return list; // ✅ ALWAYS RETURN
        }
    }
}
