using System;
using System.Numerics;

namespace ConsoleApps.AppPow
{
    internal class Pow
    {
        internal void CalculatePow()
        {
            do
            {
                Console.Clear();

                Console.Write("Darajani kiriting: ");

                var daraja = Helper.CheckForNumber("01");

                Console.WriteLine("\n" + TwoPowX(daraja) + "\n");

                Console.WriteLine("Davom etish uchun 'x' ni, chiqish uchun 'y' bosing: ");

            }while (!Console.ReadKey(false).Key.Equals(ConsoleKey.Y));
            
        }
        public BigInteger TwoPowX(int power)
        {
            return ((BigInteger)1 << power);
        }
    }
}
