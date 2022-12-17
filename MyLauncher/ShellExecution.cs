using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLauncher
{
    public sealed class ShellExecution
    {
        public static void Run(string cmd)
        {
            var p = new Process();
            p.StartInfo.FileName = cmd;
            p.StartInfo.UseShellExecute = true;

            p.Start();
        }
    }
}
