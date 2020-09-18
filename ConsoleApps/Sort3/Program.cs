using System;

namespace Sort3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadInt(out var a);
            ReadInt(out var b);
            ReadInt(out var c);

            if (a > b) Swap(ref a, ref b);
            if (b > c) Swap(ref b, ref c);
            if (a > b) Swap(ref a, ref b);
            
            Console.WriteLine($@"{a} {b} {c}");
        }

        private static void ReadInt(out int x)
        {
            while (!int.TryParse(Console.ReadLine(), out x))
            {
            }
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            var tmp = x;
            x = y;
            y = tmp;
        }
    }
}