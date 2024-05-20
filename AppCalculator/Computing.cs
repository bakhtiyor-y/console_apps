using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.CalculatorApplication
{
    internal class Computing
    {
        public void StartComputing()
        {
           
            bool again = true;
            while (again)
            {
                Console.Clear();
                var expressionStr = CheckInput.Checker();
                var res = new Calculator().Calculate(expressionStr);
                Console.WriteLine("\nresult: {0};", res);

                Helper.DisplayMessage("Try again? (y/n)");

                if (!Console.ReadKey(false).Key.Equals(ConsoleKey.Y))
                {
                    again = false;
                }
            }
        }
    }
}
