using System;

namespace Round
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var y);

            var x = Math.Round(y);
            // x = Math.Floor(y + 0.5);
            Console.WriteLine(x);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}