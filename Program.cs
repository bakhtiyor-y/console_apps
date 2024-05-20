using ConsoleApps.AppFigures;
using ConsoleApps.AppPow;
using ConsoleApps.CalculatorApplication;
using Snake;

namespace ConsoleApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;
            while (choice)
            {
                int menuOpt = Menu.ChooseMenu();

                switch (menuOpt)
                {
                    case 1:
                        SnakeApp.SnakeMain();
                        break;

                    case 2:
                        CalculatorApp.CalcMain();
                        break;

                    case 3:
                        FiguresApp.FiguresMain();
                        break;

                    case 4:
                        PowApp.PowMain();
                        break;

                    case 5:
                        choice = false;
                        break;

                    default:
                        Console.WriteLine("Something went wrong.");
                        break;
                }
            }
        }
    }
}
