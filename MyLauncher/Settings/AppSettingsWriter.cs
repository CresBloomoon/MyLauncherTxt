using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace MyLauncher.Settings
{
    public sealed class AppSettingsWriter
    {
        public void WriteToFile(AppSettings stg)
        {
            var opt = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
            };

            string jsonStr = JsonSerializer.Serialize(stg, opt);
            File.WriteAllText(App.GetAppSettingsFilePath(), jsonStr);
        }
    }
}
