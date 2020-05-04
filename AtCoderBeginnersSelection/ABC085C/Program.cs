using System;
using System.Linq;

namespace ABC085C
{
    class Program
    {
        static void Main(string[] args)
        {
            var ny = Console.ReadLine().Split(' ')
                .Select(i => long.Parse(i)).ToArray();
            var n = ny[0];
            var y = ny[1];
            for (var i = 0; i <= n; i++)
            {
                for (var j = 0; j <= n - i; j++)
                {
                    if (i * 10000 + j * 5000 + (n - i- j) * 1000 == y)
                    {
                        Console.WriteLine($"{i} {j} {n - i- j}");
                        return;
                    }
                }
            }
            Console.WriteLine("-1 -1 -1");
        }
    }
}