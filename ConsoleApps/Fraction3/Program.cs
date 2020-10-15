using System;

namespace Fraction3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var m);
            ReadDouble(out var n);

            var res = 45 - Math.Abs(m + n) * Math.Sqrt(Math.Pow(m, 3) - 1) / (6 + 2 * n);
            Console.WriteLine(res);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}