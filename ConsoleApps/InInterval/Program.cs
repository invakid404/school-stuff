using System;

namespace InInterval
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            double d;
            while (!double.TryParse(Console.ReadLine(), out d))
            {
            }
            
            Console.WriteLine(2 <= d && d <= 6);
        }
    }
}