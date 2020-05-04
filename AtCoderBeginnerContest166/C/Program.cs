using System;
using System.Linq;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(" ")
                .Select(i => long.Parse(i)).ToArray();
            var n = nm[0];
            var tenbous = new long[n];
            var m = nm[1];
            var heights = Console.ReadLine().Split(" ")
                .Select(i => long.Parse(i)).ToArray();
            for (var i = 0; i < m; i++)
            {
                var connects = Console.ReadLine().Split(" ")
                    .Select(m => int.Parse(m)).ToArray();
                var connect0 = connects[0] - 1;
                var connect1 = connects[1]- 1;
                tenbous[connect0] = Math.Max(tenbous[connect0], heights[connect1]) ;
                tenbous[connect1] = Math.Max(tenbous[connect1], heights[connect0]);
            }

            var count = 0;
            for (var i = 0; i < tenbous.Length; i++)
            {
                
                if (tenbous[i] == 0)
                {
                    count++;
                    continue;
                }

                if (tenbous[i] < heights[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}