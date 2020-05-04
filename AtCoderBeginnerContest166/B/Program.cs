using System;
using System.Linq;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            var nk = Console.ReadLine().Split(" ")
                .Select(i => int.Parse(i)).ToArray();
            var n = nk[0];
            var k = nk[1];

            var people = new Boolean[n];

            for (var i = 0; i < k; i++)
            {
                var d = int.Parse(Console.ReadLine());
                foreach (var pi in Console.ReadLine().Split(" ").Select(i => int.Parse(i)).ToArray())
                {
                    people[pi - 1] = true;
                }
            }

            var count = people.Count(b => b == false);
            Console.WriteLine(count);
        }
    }
}