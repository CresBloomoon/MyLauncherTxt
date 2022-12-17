using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public const string AppSettingFileName = "appsettings.json";

        public const string LaunchDefFileName = "WrapLauncher.path";

        /// <summary>
        /// アプリケーションパス取得
        /// </summary>
        /// <returns>アプリケーションのパス</returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static string GetAppPath()
        {
            string? appPath = AppContext.BaseDirectory;
            if (appPath is null)
            {
                throw new DirectoryNotFoundException("実行ファイルのパス取得失敗");
            }
            return appPath;
        }

        /// <summary>
        /// アプリケーション設定ファイルパス取得
        /// </summary>
        /// <returns>アプリケーション設定ファイルパス</returns>
        public static string GetAppSettingsFilePath()
        {
            return Path.Combine(GetAppPath(), AppSettingFileName);
        }

        /// <summary>
        /// ランチャー定義ファイルパス取得
        /// </summary>
        /// <returns>ランチャー定義ファイルパス</returns>
        public static string GetLaunchDefFilePath()
        {
            return Path.Combine(GetAppPath(), LaunchDefFileName);
        }
    }
}
