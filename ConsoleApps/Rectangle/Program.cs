using System;

namespace Rectangle
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var w);
            ReadDouble(out var h);

            var perimeter = 2 * (w + h);
            var area = w * h;
            Console.WriteLine($@"Perimeter: {perimeter:0.##}, Area: {area:0.##}.");
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}