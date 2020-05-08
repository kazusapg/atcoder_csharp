using System;
using System.Linq;

namespace ABC086C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var t = 0;
            var x = 0;
            var y = 0;
            for (var i = 0; i < n; i++)
            {
                var txy = Console.ReadLine().Split(" ")
                    .Select(i => int.Parse(i)).ToArray();
                var nextT = txy[0];
                var nextX = txy[1];
                var nextY = txy[2];

                var diffX = Math.Abs(nextX - x);
                var diffY = Math.Abs(nextY - y);
                var diffT = nextT - t;
                if (diffT < diffX + diffY)
                {
                    Console.WriteLine("No");
                    return;
                }

                if (diffT % 2 == 0)
                {
                    if ((diffX + diffY) % 2 == 1)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                else
                {
                    if ((diffX + diffY) % 2 == 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }

                t = nextT;
                x = nextX;
                y = nextY;
            }
            Console.WriteLine("Yes");
        }
    }
}