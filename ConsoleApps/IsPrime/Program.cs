using System;

namespace IsPrime
{
    internal static class Program
    {
        public static void Main()
        {
            ReadInt(out var n);

            var res = true;
            var hi = (int) Math.Sqrt(n);

            for (var i = 2; i <= hi; ++i)
            {
                if (n % i != 0) continue;

                res = false;
                break;
            }

            Console.WriteLine($@"{n} {(res ? "is" : "isn't")} prime");
        }

        private static void ReadInt(out int n)
        {
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
        }
    }
}