using System;

namespace Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadInt(out var a);
            ReadInt(out var b);

            for (var i = a; i <= b; ++i)
            {
                Console.Write($@"{i} ");
            }
            Console.WriteLine();
        }

        private static void ReadInt(out int n)
        {
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
        }
    }
}
