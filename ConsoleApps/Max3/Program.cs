using System;

namespace Max3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadInt(out var a);
            ReadInt(out var b);
            ReadInt(out var c);

            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
        }

        private static void ReadInt(out int x)
        {
            while (!int.TryParse(Console.ReadLine(), out x))
            {
            }
        }
    }
}