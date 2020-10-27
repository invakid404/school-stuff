using System;

namespace DigitsN
{
    internal static class Program
    {
        public static void Main()
        {
            ReadInt(out var n);

            var res = 0;
            while (n != 0)
            {
                n /= 10;
                ++res;
            }
            
            Console.WriteLine(res);
        }

        private static void ReadInt(out int n)
        {
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
        }
    }
}