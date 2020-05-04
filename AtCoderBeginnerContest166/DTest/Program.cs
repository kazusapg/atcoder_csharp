using System;

namespace DTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthRoot(Math.Pow(10,9), 5));
            Console.WriteLine(Math.Pow(-64, 5));
        }
        
        private static double NthRoot(double x, int n)
        {
            if (x >= 0)
            {
                // 通常のn乗根
                return Math.Pow(x, 1.0 / (double)n);
            }
            else
            {
                if ((n % 2) != 0)
                {
                    // 奇数乗根の場合
                    return -Math.Pow(-x, 1.0 / (double)n);
                }
                else
                {
                    // 偶数乗根の場合
                    return double.NaN;
                }
            }
        }
    }
    
    
}