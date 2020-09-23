using System;

namespace Circle
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var r);

            var s = Math.PI * r * r;
            var d = 2 * Math.PI * r;
            Console.WriteLine($@"Area: ${s}; Circumference: ${d}");
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}
