using System;

namespace Equal3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var a);
            ReadDouble(out var b);
            ReadDouble(out var c);

            Console.WriteLine(AreEqual(a, b) && AreEqual(b, c));
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }

        private static bool AreEqual(double x, double y)
        {
            return Math.Abs(x - y) < double.Epsilon;
        }
    }
}