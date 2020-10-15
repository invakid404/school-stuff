using System;

namespace DivisibleBy5
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
            
            Console.WriteLine(n % 5 == 0);
        }
    }
}