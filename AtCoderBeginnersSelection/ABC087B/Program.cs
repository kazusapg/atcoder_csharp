using System;

namespace ABC087B
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            var c = long.Parse(Console.ReadLine());
            var x = long.Parse(Console.ReadLine());

            var count = 0;
            for (var i = 0; i <= a; i++)
            {
                for (var j = 0; j <= b; j++)
                {
                    for (var k = 0; k <= c; k++)
                    {
                        var sum = i * 500 + j * 100 + k * 50;
                        if (sum == x)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}