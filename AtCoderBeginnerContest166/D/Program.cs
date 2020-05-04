using System;

namespace D
{
    class Program
    {
        
        /// <summary>
        /// 参考
        /// https://webbibouroku.com/Blog/Article/atcoder-abc166
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var x = long.Parse(Console.ReadLine());
            for (long a = -200; a <= 200; a++)
            {
                for (long b = -200; b < 200; b++)
                {
                    if (a*a*a*a*a - b*b*b*b*b == x)
                    {
                        Console.WriteLine($"{a} {b}");
                        return;
                    }
                }
            }
        }
    }
}