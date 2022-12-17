using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyLauncher.Settings
{
    /// <summary>
    /// アプリケーション読み込み
    /// </summary>
    public sealed class AppSettingsReader
    {
        /// <summary>
        /// ファイル存在確認
        /// </summary>
        /// <returns>ファイルが存在していればtrue</returns>
        public bool ExistsFile()
        {
            return File.Exists(App.GetAppSettingsFilePath());
        }

        /// <summary>
        /// ファイル読み込み
        /// </summary>
        /// <returns>設定情報</returns>
        public AppSettings ReadFromFile()
        {
            if (!ExistsFile())
            {
                return new AppSettings();
            }

            //読み込み
            string jsonStr = File.ReadAllText(App.GetAppSettingsFilePath());
            var stg = JsonSerializer.Deserialize<AppSettings>(jsonStr);

            return stg ?? new AppSettings();
        }
    }
}
