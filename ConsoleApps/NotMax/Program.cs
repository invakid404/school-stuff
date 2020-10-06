using System;

namespace NotMax
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadInt(out var a);
            ReadInt(out var b);
            ReadInt(out var c);
            ReadInt(out var x);

            // Method 1: Sorting the three numbers and checking X against the smallest two
            /*
             * if (a > b) Swap(ref a, ref b);
             * if (b > c) Swap(ref b, ref c);
             * if (a > b) Swap(ref a, ref b);
             */

            // Method 2: Finding the minimal and median and checking X against them
            var min = Math.Min(a, Math.Min(b, c));
            var median = Math.Max(Math.Min(a, b), Math.Min(Math.Max(a, b), c));

            // Console.WriteLine(x == a || x == b);
            Console.WriteLine(x == min || x == median);
        }

        private static void ReadInt(out int v)
        {
            while (!int.TryParse(Console.ReadLine(), out v))
            {
            }
        }
        
        /*
        * private static void Swap<T>(ref T x, ref T y)
        * {
        *     var tmp = x;
        *     x = y;
        *     y = tmp;
        * }
        */
    }
}