using System;

namespace Inequality
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var x);
            ReadDouble(out var a);
            
            Console.WriteLine(x * x + 5 * a <= 18);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}