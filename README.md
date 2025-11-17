NkustAqiConsole - 全國空氣品質即時分析
這是一個 .NET 9.0 主控台應用程式，用於讀取、解析並分析「環境部空氣品質指數(AQI)」的即時資料。

程式會載入 JSON 資料，並在終端機中印出「全國 AQI 最高的前 20 個測站」列表。

專案結構
NkustAqiConsole/
├── App_Data/
│   └── AQI_Data.json       # AQI 即時資料 (需手動下載)
├── NkustAqiConsole.csproj  # 專案檔
├── AqiDataModel.cs         # C# 資料模型 (對應 JSON 結構)
├── JsonDataService.cs      # 讀取 JSON 檔案的服務
├── Program.cs              # 程式主邏輯 (分析與印出)
└── README.md               # 專案說明檔
資料來源
資料集: 環境部空氣品質指數(AQI) (即時資料)

資料來源: 政府資料開放平臺

專案啟動方式
開發環境需求
.NET 9.0 SDK (或更高版本)

執行步驟
克隆或下載專案 (確保你已將此專案資料夾下載到你的電腦)

準備資料檔案 (重要)

從 政府資料開放平台 下載 JSON 格式的資料。

在專案根目錄 (NkustAqiConsole/) 建立 App_Data/ 資料夾。

將下載的 JSON 檔案放入 App_Data/ 目錄，並重新命名為 AQI_Data.json。

還原套件 (Restore) (如果是第一次執行，建議先執行此指令，或 dotnet build 也會自動還原)

Bash

dotnet restore
執行應用程式 在專案根目錄 (NkustAqiConsole/) 開啟終端機，輸入以下指令：

Bash

dotnet run
查看結果 程式將在終端機視窗中印出「AQI 最高的前 20 個測站」列表。