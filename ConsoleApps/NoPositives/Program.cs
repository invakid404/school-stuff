using System;

namespace NoPositives
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadInt(out var a);
            ReadInt(out var b);
            ReadInt(out var c);
            
            Console.WriteLine(!(a > 0 || b > 0 || c > 0));
        }

        private static void ReadInt(out int v)
        {
            while (!int.TryParse(Console.ReadLine(), out v))
            {
            }
        }
    }
}