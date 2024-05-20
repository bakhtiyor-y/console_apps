using Shakl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.AppPow
{
    internal class PowApp
    {
        internal static void PowMain()
        {
            Helper.DisplayMessage("pow");
            Thread.Sleep(2000);
            new Pow().CalculatePow();
        }
    }
}
