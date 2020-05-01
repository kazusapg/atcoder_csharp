using System;
using System.Linq;

namespace ABC088B
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var cards = Console.ReadLine().Split(' ')
                .Select(i => long.Parse(i))
                .OrderByDescending(i => i)
                .ToArray();

            long alice = 0;
            long bob = 0;
            for (var i = 0; i < cards.Length; i++)
                if (i % 2 == 0)
                    alice += cards[i];
                else
                    bob += cards[i];
            Console.WriteLine(alice - bob);
        }
    }
}