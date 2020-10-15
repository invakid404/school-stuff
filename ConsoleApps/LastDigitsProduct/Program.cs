using System;

namespace LastDigitsProduct
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }

            var res = n % 10 * (n / 10 % 10);
            Console.WriteLine(res);
        }
    }
}