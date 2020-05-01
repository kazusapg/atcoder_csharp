using System;
using System.Linq;

namespace ABC081A
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(s.Count(c => c == '1'));
        }
    }
}