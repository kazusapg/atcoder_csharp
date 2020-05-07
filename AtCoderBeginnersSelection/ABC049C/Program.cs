using System;

namespace ABC049C
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            
            while (s != "")
            {
                if (s.EndsWith("dream"))
                    s = s.Remove(s.LastIndexOf("dream", StringComparison.Ordinal), 5);
                else if(s.EndsWith("dreamer"))
                    s = s.Remove(s.LastIndexOf("dreamer", StringComparison.Ordinal), 7);
                else if(s.EndsWith("erase"))
                    s = s.Remove(s.LastIndexOf("erase", StringComparison.Ordinal), 5);
                else if(s.EndsWith("eraser"))
                    s = s.Remove(s.LastIndexOf("eraser", StringComparison.Ordinal), 6);
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}