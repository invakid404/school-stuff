using System;

namespace MetalRod
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var rodLen);
            ReadDouble(out var partLen);

            var partAmt = Math.Floor(rodLen / partLen);
            Console.WriteLine($@"You can cut into {partAmt} parts.");
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}