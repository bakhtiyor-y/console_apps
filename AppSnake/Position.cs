using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position() { }

        public Position(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void PrintPoint(ConsoleColor color, int x, int y, string str = "")
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (str == "snake")
            {
                Console.Write("■", Console.ForegroundColor);
            }
            else
            {
                Console.Write("ѽ", Console.ForegroundColor);
            }
        }
    }
}
