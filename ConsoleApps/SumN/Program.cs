using System;

namespace SumN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadInt(out var n);

            var res = 0;
            while (n-- > 0)
            {
                ReadInt(out var curr);
                res += curr;
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
