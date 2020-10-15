using System;

namespace Fraction
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            double m;
            while (!double.TryParse(Console.ReadLine(), out m))
            {
            }

            var res = (m * m + 2 * m - 1) / (5 + Math.Sqrt(Math.Abs(m - 3)));
            Console.WriteLine($@"{res:0.###}");
        }
    }
}