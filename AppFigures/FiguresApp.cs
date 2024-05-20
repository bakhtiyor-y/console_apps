using Shakl;

namespace ConsoleApps.AppFigures
{
    internal class FiguresApp
    {
        internal static void FiguresMain()
        {
            Helper.DisplayMessage("figures");
            Thread.Sleep(2000);
            new Figures().ShowFigures();
        }
    }
}
