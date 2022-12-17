using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLauncher.Settings
{
    public sealed class LauncherDefinition
    {
        public const char Delimiter = '\t';

        public const string GroupTitleHeader = "//";

        public const int GroupTitleColumnIndex = 0;

        public static IReadOnlyDictionary<string, int> Columns =
            new Dictionary<string, int>
            {
                {"Color", 0 },
                {"ButtonTitle", 1 },
                {"Path", 2 },
            };

        public bool IsGroupTitle(string[] values)
        {
            return values[GroupTitleColumnIndex].StartsWith(GroupTitleHeader);
        }

        public string GetGroupTitle(string[] values)
        {
            return values[GroupTitleColumnIndex].Substring(GroupTitleHeader.Length);
        }
    }
}
