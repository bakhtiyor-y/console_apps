using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key;
        char dir;

        public List<Position> snakeBody { get; set; }

        public int X {  get; set; }
        public int Y { get; set; }

        public int Score { get; set; } 

        public Snake()
        {
            X = 2;            
            Y = 10;
            snakeBody =
            [
                new Position(X, Y),
                new Position(X, Y) 
            ];
        }

        public void DrawSnake()
        {
            if (dir != '\0')
            {
                Position snTail = snakeBody[0];
                Console.SetCursorPosition(snTail.X, snTail.Y);
                Console.Write(" ");                
            }

            snakeBody.RemoveAt(0);

            for(var i = 0; i < snakeBody.Count; i++) 
            {
                if(i == snakeBody.Count - 1)
                {
                    snakeBody[i].PrintPoint(ConsoleColor.Yellow, snakeBody[i].X, snakeBody[i].Y, "snake");
                } else
                {
                    snakeBody[i].PrintPoint(ConsoleColor.DarkGreen, snakeBody[i].X, snakeBody[i].Y, "snake");
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        private void Direction()
        {
            if (key == 'w' && dir != 'd')
            {
                dir = 'u';
            } else if (key == 's' && dir != 'u') 
            {
                dir = 'd';
            }
            else if (key == 'd' && dir != 'l')
            {
                dir = 'r';
            }
            else if (key == 'a' && dir != 'r')
            {
                dir = 'l';
            }
        }

        public void MoveSnake()
        {
            Direction();           

            if (dir == 'u')
            {
                Y--;
            } else if (dir == 'd')
            {
                Y++;
            } else if (dir == 'r')
            {
                X++;
            } else if (dir == 'l')
            {
                X--;
            }

            snakeBody.Add(new Position(X, Y));
            Thread.Sleep(400);
        }
        [SupportedOSPlatform("windows")]
        public void Eat(Position food, Food f)
        {
            Position snHead = snakeBody[snakeBody.Count - 1];
            if(snHead.X == food.X && snHead.Y == food.Y)
            {
                snakeBody.Add(new Position(X, Y));

                f.FoodNewLocation();

                Score++;

                if (OperatingSystem.IsWindows())
                {
                    Task.Run(() => Console.Beep(1200, 2000));
                }

                //Console.Beep(1200, 5000);
            }
        }

        public void IsDead()
        {
            Position head = snakeBody[snakeBody.Count - 1];
            for(int i = 0; i < snakeBody.Count - 2; i++)
            {
                Position sb = snakeBody[i];
                if(head.X == sb.X && head.Y == sb.Y)
                {
                    throw new SnakeException("GAME OVER");
                }
            }
        }

        public void HitWall(Canvas canvas)
        {
            Position head = snakeBody[snakeBody.Count - 1];
            if(head.X >= canvas.Width || head.X <= 0 || head.Y >= canvas.Height-1 || head.Y <= 0)
            {
                throw new SnakeException("GAME OVER");
            }
        }
    }
}
