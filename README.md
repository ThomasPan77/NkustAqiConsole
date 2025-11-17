# NkustAqiConsole - 全國空氣品質即時分析

這是一個使用 **.NET 9.0** 開發的主控台應用程式，用於讀取、解析並分析「環境部空氣品質指數 (AQI)」的即時資料。

程式會載入 JSON 資料，並在終端機中印出「全國 AQI 最高的前 20 個測站」列表。

---

## 📁 專案結構

```
NkustAqiConsole/
├─ App_Data/
│  └─ AQI_Data.json   # AQI 即時資料（需手動下載）
├─ NkustAqiConsole.csproj   # 專案檔
├─ AqiDataModel.cs          # C# 資料模型
├─ JsonDataService.cs       # JSON 讀取服務
├─ Program.cs               # 主程式邏輯
└─ README.md                # 專案說明
```
README.md # 專案說明檔


---

## 📊 資料來源

- **資料集**：環境部空氣品質指數 (AQI)（即時資料）
- **來源網站**：[政府資料開放平台](https://data.gov.tw/dataset/40507)

---

## 🚀 專案啟動方式

### 🧰 開發環境需求

- 安裝 `.NET 9.0 SDK`（或更高版本）  
  → 可從官方網站下載：https://dotnet.microsoft.com/download

---

### 📝 執行步驟

1. **克隆或下載專案**
   將此專案資料夾下載至你的本機電腦。

2. **準備資料檔案（重要）**
   - 至[政府資料開放平台](https://data.gov.tw/dataset/40507)下載 **JSON 格式**資料。
   - 在專案根目錄 (`NkustAqiConsole/`) 下建立 `App_Data/` 資料夾。
   - 將下載的 JSON 檔案放入 `App_Data/` 目錄，並將其**重新命名**為：
     ```
     AQI_Data.json
     ```

3. **還原套件 (Restore)**
   若為首次執行，請在終端機輸入以下指令：
   ```bash
   dotnet restore
   或執行 dotnet build，也會自動進行還原動作。
