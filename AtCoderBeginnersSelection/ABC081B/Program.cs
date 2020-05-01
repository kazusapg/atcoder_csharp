using System;
using System.Linq;

namespace ABC081B
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ')
                .Select(i => long.Parse(i))
                .ToArray();
            var count = 0;
            while (true)
            {
                if (!numbers.All(i => i % 2 == 0)) break;

                numbers = numbers.Select(i => i / 2).ToArray();
                count++;
            }

            Console.WriteLine(count);
        }
    }
}