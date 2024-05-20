using ConsoleApps;
using ConsoleApps.CalculatorApplication;
using Snake;

namespace ConsoleApps.CalculatorApplication
{
    internal class CalculatorApp
    {        
        internal static void CalcMain()
        {
            Helper.DisplayMessage("kalkulyator");
            Thread.Sleep(2000);
            new Computing().StartComputing();
        }
    }
}
