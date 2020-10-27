using System;

namespace ABDivisible
{
    internal static class Program
    {
        public static void Main()
        {
            ReadInt(out var n);
            ReadInt(out var a);
            ReadInt(out var b);

            var res = 0;
            while (n-- > 0)
            {
                ReadInt(out var curr);
                if (curr % a == 0 && curr % b != 0)
                {
                    ++res;
                }
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