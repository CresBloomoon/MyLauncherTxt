using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLauncher.Settings
{
    /// <summary>
    /// アプリケーション設定
    /// </summary>
    public sealed class AppSettings
    {
        /// <summary>
        /// アプリ起動後にランチャー最小化
        /// </summary>
        public bool MinimizedAfterLaunch { get; set; } = false;

        /// <summary>
        /// 表示倍率
        /// </summary>
        public double Scale { get; set; } = 1.0;
    }
}
