using System;
using System.Linq;

namespace ABC086A
{
    class Program
    {
        static void Main(string[] args)
        {
            var ab = Console.ReadLine().Split(' ')
                .Select(i => long.Parse(i)).ToArray();
            var a = ab[0];
            var b = ab[1];

            if (a*b % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}