using System;

namespace AtLeastOnePositive
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var x);
            ReadDouble(out var y);
            ReadDouble(out var z);
            ReadDouble(out var t);
            
            Console.WriteLine(x > 0 || y > 0 || z > 0 || t > 0);
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}