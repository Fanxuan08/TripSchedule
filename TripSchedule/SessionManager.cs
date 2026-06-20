using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using Newtonsoft.Json; // 負責處理 JSON 轉換

namespace TripSchedule
{
    public static class SessionManager
    {
        // 記憶體中目前的旅程資料
        public static Trip CurrentTrip { get; set; }

        // 目前登入的操作者身分
        public static string CurrentUserRole { get; set; }

        // JSON 存檔路徑 (預設存在程式執行檔的 Debug 資料夾下)
        private static readonly string SaveFilePath = "TripData.json";

        // 儲存檔案
        public static void SaveToFile()
        {
            if (CurrentTrip == null) return;

            // 使用 Newtonsoft.Json 將物件轉為字串 (Formatting.Indented 會自動排版)
            string jsonString = JsonConvert.SerializeObject(CurrentTrip, Formatting.Indented);
            File.WriteAllText(SaveFilePath, jsonString);
        }

        // 讀取檔案
        public static bool LoadFromFile()
        {
            if (!File.Exists(SaveFilePath)) return false;

            try
            {
                string jsonString = File.ReadAllText(SaveFilePath);
                CurrentTrip = JsonConvert.DeserializeObject<Trip>(jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
