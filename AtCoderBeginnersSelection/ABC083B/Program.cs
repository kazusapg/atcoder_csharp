using System;
using System.Linq;

namespace ABC083B
{
    class Program
    {
        static void Main(string[] args)
        {
            var nab = Console.ReadLine().Split()
                .Select(i => long.Parse(i)).ToArray();
            var n = nab[0];
            var a = nab[1];
            var b = nab[2];

            var count = 0;
            for (var i = 1; i <= n; i++)
            {
                var sum = i.ToString().Sum(c => int.Parse(c.ToString()));
                if (a <= sum && sum <= b)
                {
                    count+=i;
                }
            }

            Console.WriteLine(count);
        }
    }
}