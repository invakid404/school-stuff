using System;

namespace Divisors
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadInt(out var n);

            var hi = (int) Math.Sqrt(n);

            for (var i = 1; i < hi; ++i)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

            for (var i = hi; i >= 1; i--)
            {
                if (n % i == 0)
                {
                    Console.Write(n / i + " ");
                }
            }

            Console.WriteLine();
        }

        private static void ReadInt(out int n)
        {
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
        }
    }
}