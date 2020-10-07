using System;
using System.CodeDom;

namespace AverageDigits
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }

            var ones = n % 10;
            var tens = n / 10 % 10;

            var avg = (ones + tens) / 2.0;
            Console.WriteLine($@"Average: {avg:0.0}");
        }
    }
}
