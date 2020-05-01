using System;
using System.Linq;

namespace ABC085B
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mochis = new int[n];
            for (var i = 0; i < n; i++) mochis[i] = int.Parse(Console.ReadLine());

            var count = 0;

            var sortedMochis = mochis.OrderByDescending(m => m)
                .ToArray();
            var previousSize = 0;
            for (var i = 0; i < sortedMochis.Length; i++)
            {
                if (i == 0)
                {
                    count++;
                }
                else
                {
                    if (sortedMochis[i] != previousSize) count++;
                }

                previousSize = sortedMochis[i];
            }

            Console.WriteLine(count);
        }
    }
}