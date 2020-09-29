using System;

namespace Rectangle
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadInt(out var w);
            ReadInt(out var h);

            var perimeter = 2 * (w + h);
            var area = w * h;
            Console.WriteLine($@"Perimeter: {perimeter}, Area: {area}.");
        }

        private static void ReadInt(out int v)
        {
            while (!int.TryParse(Console.ReadLine(), out v))
            {
            }
        }
    }
}