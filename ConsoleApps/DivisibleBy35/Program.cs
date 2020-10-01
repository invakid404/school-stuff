using System;

namespace DivisibleBy35
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }
            
            Console.WriteLine($@"{n} {(n % 35 == 0 ? "is" : "is not")} divisible by 5 and 7.");
        }
    }
}