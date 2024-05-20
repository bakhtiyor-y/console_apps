using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food
    {
        public Position foodPos = new Position();

        Random rnd = new Random();
        Canvas canvas = new Canvas();

        public Food()
        {
            foodPos.X = rnd.Next(5, canvas.Width-1);
            foodPos.Y = rnd.Next(5, canvas.Height-1);
        }

        public void DrawFood()
        {
            foodPos.PrintPoint(ConsoleColor.Red, foodPos.X, foodPos.Y);        
        }

        public Position FoodLocation()
        {
            return foodPos;
        }

        public void FoodNewLocation()
        {
            foodPos.X = rnd.Next(5, canvas.Width - 1);
            foodPos.Y = rnd.Next(5, canvas.Height - 1);
        }


    }
}
