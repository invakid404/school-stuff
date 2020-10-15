using System;

namespace Fraction2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
            }

            var res = (Math.Sqrt(6 * Math.Abs(x)) + 3) / (Math.Pow(x, 4) + 2);
            Console.WriteLine(res);
        }
    }
}