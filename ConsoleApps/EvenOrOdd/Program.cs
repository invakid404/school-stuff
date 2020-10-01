using System;

namespace EvenOrOdd
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }

            Console.Write($@"{n} is {(n % 2 == 0 ? "even" : "odd")}");
        }
    }
}