using BOMMigration.Console.Services;

namespace BOMMigration.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("PLM BOM Migration Tool\n");

            var csvService = new CsvService();
            var bomService = new BomService();

            var path = @"DataFiles\bom.csv";
            var bomData = csvService.ReadBomCsv(path);

            System.Console.WriteLine("P1000");
            bomService.PrintBomTree(bomData, "P1000");

            System.Console.ReadKey();
        }
    }
}
