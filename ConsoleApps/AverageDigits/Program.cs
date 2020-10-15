using System;

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

            var res = (n % 10 + n / 10 % 10) / 2.0;
            Console.WriteLine(res);
        }
    }
}