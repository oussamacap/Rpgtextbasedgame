using System;
using Maandag2.Commands;


namespace Maandag2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Start();
            Game.CreatePlayerStart();
            Game.CreateGame();
        }
    }
}
