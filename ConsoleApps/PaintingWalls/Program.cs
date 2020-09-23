using System;

namespace PaintingWalls
{
    static internal class Program
    {
        public static void Main(string[] args)
        {
            ReadDouble(out var height);
            ReadDouble(out var width);
            ReadDouble(out var paintArea);

            var paintBoxAmt = Math.Ceiling((height * width) / paintArea);
            Console.WriteLine($@"Amount of paint boxes: {paintBoxAmt}");
        }

        private static void ReadDouble(out double d)
        {
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
        }
    }
}
