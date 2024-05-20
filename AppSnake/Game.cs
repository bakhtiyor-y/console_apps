using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Diagnostics;
using System.Threading;
using ConsoleApps;

namespace Snake
{
    internal class Game
    {
        public void StartGame() 
        {            
            bool again = true;
            while (again)
            {
                Console.Clear();
                bool finished = false;
                Canvas canvas = new Canvas();
                Snake snake = new Snake();
                Food food = new Food();
                canvas.DrawCanvas();

                while (!finished)
                {
                    try
                    {
                        Console.SetCursorPosition(20, 1);
                        Console.WriteLine("Score: {0}", snake.Score);
                        snake.Input();
                        food.DrawFood();
                        snake.DrawSnake();
                        snake.MoveSnake();
                        snake.Eat(food.FoodLocation(), food);
                        snake.IsDead();
                        snake.HitWall(canvas);
                    }
                    catch (SnakeException e)
                    {
                        Console.Clear();
                        Helper.DisplayMessage(e.Message);
                        Thread.Sleep(1000);
                        finished = true;
                    }
                }
                Helper.DisplayMessage("Try again? (y/n)");

                if (Console.ReadKey(true).Key.Equals(ConsoleKey.Y))
                {
                    finished = false;
                }
                else
                {
                    again = false;
                }
            }
            Console.Clear();
        }

    }

}

