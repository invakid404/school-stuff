using System;

namespace Both
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ReadBoolean(out var a);
            ReadBoolean(out var b);
            
            Console.WriteLine(a && b);
        }

        private static void ReadBoolean(out bool v)
        {
            while (!bool.TryParse(Console.ReadLine(), out v))
            {
            }
        }
    }
}