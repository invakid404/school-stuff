using System;

namespace InCircle
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var x);
            ReadDouble(out var y);
            
            Console.WriteLine($@"The point ({x}, {y}) {(x * x + y * y <= 25 ? "is" : "is not")} in the circle.");
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}