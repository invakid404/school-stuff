using System;

namespace Square3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var area);

            var side = Math.Sqrt(area);
            var perimeter = 4 * side;

            Console.WriteLine($@"Perimeter = {perimeter}");
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}