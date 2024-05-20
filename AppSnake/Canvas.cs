using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Canvas
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Canvas()
        {
            Width = 30;
            Height = 20;
            Console.CursorVisible = false;
        }

        public void DrawCanvas()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (j == 0 && i == 0) { Console.Write("╔"); continue; }
                    if (j == Width - 1 && i == 0) { Console.Write("╗"); continue; }
                    if (j == 0 && i == Height - 1) { Console.Write("╚"); continue; }
                    if (j == Width - 1 && i == Height - 1) { Console.Write("╝"); continue; }

                    if (i == 0 || i == Height - 1) { Console.Write("═"); continue; }
                    if (j == 0 || j == Width - 1)
                    {
                        Console.Write("║");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
