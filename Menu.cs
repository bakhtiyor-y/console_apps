using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    internal class Menu
    {
        public static int ChooseMenu()
        {
            
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Helper.DisplayMessage("title");
            Console.ResetColor();
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = "✅ \u001b[32m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                Console.WriteLine($"    {(option == 1 ? decorator : "   ")}Ilon o'yini\u001b[0m");
                Console.WriteLine($"    {(option == 2 ? decorator : "   ")}Kalkulyator\u001b[0m");
                Console.WriteLine($"    {(option == 3 ? decorator : "   ")}Shakllar\u001b[0m");
                Console.WriteLine($"    {(option == 4 ? decorator : "   ")}Darajaga ko'tarish\u001b[0m");
                Console.WriteLine($"    {(option == 5 ? decorator : "   ")}Chiqish\u001b[0m");

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        option = option == 1 ? 5 : option - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        option = option == 5 ? 1 : option + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
            }
        
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            return option;
        }
    }
}
