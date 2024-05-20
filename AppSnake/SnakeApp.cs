using ConsoleApps;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Timers;

namespace Snake
{
    internal class SnakeApp
    { 
        internal static void SnakeMain()
        {
            Helper.DisplayMessage("snake");
            Thread.Sleep(2000);
            new Game().StartGame();
        }
    }
}