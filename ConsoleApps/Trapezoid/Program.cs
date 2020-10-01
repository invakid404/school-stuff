using System;

namespace Trapezoid
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble("a", out var a);
            ReadDouble("b", out var b);
            ReadDouble("h", out var h);

            Console.WriteLine($@"Area: {(a + b) / 2 * h:0.##}");
        }

        private static void ReadDouble(string msg, out double d)
        {
            do
            {
                Console.Write($@"{msg} = ");
            } while (!double.TryParse(Console.ReadLine(), out d));
        }
    }
}