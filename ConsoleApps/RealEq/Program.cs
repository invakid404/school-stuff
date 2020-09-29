using System;

namespace RealEq
{
    internal static class Program
    {
        public static void Main(string[] args)
        { 
            ReadDouble(out var x);
            
            var y = x <= 5 ? 2 * x - 3 : (x * x + 1) / x;
            Console.WriteLine(y);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}