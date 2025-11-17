using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace NkustAqiConsole
{
    public class JsonDataService
    {
        private const string _dataPath = @"App_Data/AQI_Data.json";

        public List<AqiRecord> LoadAqiData()
        {
            if (!File.Exists(_dataPath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"錯誤: 找不到資料檔案。");
                Console.WriteLine($"請確認 App_Data 資料夾中有名為 AQI_Data.json 的檔案。");
                Console.ResetColor();
                return new List<AqiRecord>(); 
            }

            string jsonString = File.ReadAllText(_dataPath);
            var dataRoot = JsonConvert.DeserializeObject<AqiDataRoot>(jsonString);

            // 檢查 dataRoot 和 Records 是否為 null
            return dataRoot?.Records ?? new List<AqiRecord>();
        }
    }
}