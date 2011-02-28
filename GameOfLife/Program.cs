using System;
using System.Threading;
using GameOfLife.Model;

namespace GameOfLife
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Game of life. Any key to exit.");
            var game = new Game(new Grid(5, 5, new[]
            {
                new Tuple<int, int>(1, 3),
                new Tuple<int, int>(2, 3),
                new Tuple<int, int>(3, 3)
            }));

            while(true)
            {
                // todo: make this work and change in place!
                Console.Write("\r{0}", game.DisplayGrid());

                game.Tick();

                Thread.Sleep(500);

                if (Console.ReadLine() != null)
                    break;
            }
        }
    }
}
