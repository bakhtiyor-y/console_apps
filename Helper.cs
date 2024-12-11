using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApps
{
    internal class Helper
    {
        
        public static void DisplayMessage(string msg)
        { 
            if (msg == "title")
            {
                string title = @"
     ____       ____              
    | __ )  ___|  _ \ _ __ ___    
    |  _ \ / _ \ |_) | '__/ _ \  
    | |_) |  __/  __/| | | (_) | █ █░░ █▀█ █░█ ▄▀█ █░░ ▄▀█ █▀█ █
    |____/ \___|_|   |_|  \___/  █ █▄▄ █▄█ ▀▄▀ █▀█ █▄▄ █▀█ █▀▄ █
    ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
";
                Console.WriteLine($"\n{title}");
            }
            else if (msg=="game over")
            {

                string gameOver = @"
█▀▀ ▄▀█ █▀▄▀█ █▀▀   █▀█ █░█ █▀▀ █▀█
█▄█ █▀█ █░▀░█ ██▄   █▄█ ▀▄▀ ██▄ █▀▄
";
                ShowWithPrefix(gameOver);
            } 
            else if(msg == "snake")
            {
                string snake = @"
 ____  _   _    _    _  _______ 
/ ___|| \ | |  / \  | |/ / ____|
\___ \|  \| | / _ \ | ' /|  _|  
 ___) | |\  |/ ___ \| . \| |___ 
|____/|_| \_/_/   \_\_|\_\_____|
";
                ShowWithPrefix(snake);
            }
            else if (msg == "kalkulyator")
            {
                string kalkulyator = @"
   ____    _    _     _  ___   _ _        _  _____ ___  ____  
  / ___|  / \  | |   | |/ / | | | |      / \|_   _/ _ \|  _ \ 
 | |     / _ \ | |   | ' /| | | | |     / _ \ | || | | | |_) |
 | |___ / ___ \| |___| . \| |_| | |___ / ___ \| || |_| |  _ < 
  \____/_/   \_\_____|_|\_\\___/|_____/_/   \_\_| \___/|_| \_\
";
                ShowWithPrefix(kalkulyator);
            }
            else if (msg == "figures")
            {
                string figures = @"
  _____ ___ ____ _   _ ____  _____ ____  
 |  ___|_ _/ ___| | | |  _ \| ____/ ___| 
 | |_   | | |  _| | | | |_) |  _| \___ \ 
 |  _|  | | |_| | |_| |  _ <| |___ ___) |
 |_|   |___\____|\___/|_| \_\_____|____/ 
";
                ShowWithPrefix(figures);
            }
            else if (msg == "pow")
            {
                string pow = @"
  ____   _____        __
 |  _ \ / _ \ \      / /
 | |_) | | | \ \ /\ / / 
 |  __/| |_| |\ V  V /  
 |_|    \___/  \_/\_/   
";
                ShowWithPrefix(pow);
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, (Console.WindowHeight) / 2 + 2);
                Console.WriteLine(msg);
            }
        }

        private static void ShowWithPrefix(string inComingStr)
        {
            string[] arr = inComingStr.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            int strMax = arr.Max(x => x.Length);
            int horizStart = (Console.WindowWidth - strMax) / 2;
            string prefix = new(' ', horizStart);
            Console.SetCursorPosition(horizStart, Console.WindowHeight / 2 - 7);
            var FinalStr = arr.Select(el => prefix + el + "\r\n").ToArray();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Concat(FinalStr));
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static int JMax(int i)
        {
            return 1 + 2 * (i - 1);
        }

        public static int CheckForDigit(string str)
        {
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);
                if ((str).Contains(key.KeyChar.ToString()))
                {
                    Console.WriteLine(key.KeyChar);
                    return key.KeyChar - '0';
                }
            }
        }

        public static int CheckForNumber(string str)
        {
            string _val = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    if (str.Contains(key.KeyChar.ToString()))
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return int.Parse(_val);
        }

        public static int CheckForYESorNO(string str)
        {
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);
                if ((str).Contains(key.KeyChar.ToString()))
                {
                    Console.WriteLine(key.KeyChar);
                    if (key.KeyChar == 'x')
                    {
                        return 0;
                    }
                    if (key.KeyChar == 'y')
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

