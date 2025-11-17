using System;
using System.Linq;

namespace NkustAqiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 全國空氣品質指數(AQI) 即時分析 ===");
            Console.WriteLine("正在讀取資料...");

            var dataService = new JsonDataService();
            var allRecords = dataService.LoadAqiData();

            if (allRecords.Any()) 
            {
                Console.WriteLine($"成功讀取 {allRecords.Count} 筆測站資料。");
                Console.WriteLine();

                var top20Sites = allRecords
                    .Where(record => record.AqiValue > 0)
                    .OrderByDescending(record => record.AqiValue)
                    .Take(20)
                    .ToList(); 

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- AQI 最高的前 20 個測站 ---");
                Console.ResetColor();

                int rank = 1;
                foreach (var site in top20Sites)
                {
                    Console.WriteLine($"第 {rank,2} 名: {site.SiteName,-10} \t AQI: {site.AqiValue}");
                    rank++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("分析失敗：無法從檔案中讀取任何有效資料。");
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine("按任意鍵結束程式...");
            Console.ReadKey(); 
        }
    }
}