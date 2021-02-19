using System;

namespace Mirror
{
    internal static class Program
    {
        public static void Main()
        {
            ReadInt(out var n);
            
            var mirrored = 0;
            while (n != 0)
            {
                mirrored = mirrored * 10 + n % 10;
                n /= 10;
            }
            
            Console.WriteLine(mirrored);
        }

        private static void ReadInt(out int n)
        {
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
        }
    }
}