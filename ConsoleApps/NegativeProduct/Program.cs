using System;

namespace NegativeProduct
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var x);
            ReadDouble(out var y);
            
            Console.WriteLine(x < 0 ^ y < 0);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}