using System;

namespace Equality
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var k);
            ReadDouble(out var p);
            
            Console.WriteLine(Math.Abs(k % 7 - (p / 5 - 2)) < double.Epsilon);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}