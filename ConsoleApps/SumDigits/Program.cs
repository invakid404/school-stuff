using System;

namespace SumDigits
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadInt(out var n);
            n = Math.Abs(n);
            
            var res = 0;
            while (n != 0)
            {
                res += n % 10;
                n /= 10;
            }
            
            Console.WriteLine(res);
        }

        private static void ReadInt(out int n)
        {
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
        }
    }
}