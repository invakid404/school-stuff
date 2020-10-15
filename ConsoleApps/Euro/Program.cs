using System;

namespace Euro
{
    internal static class Program
    {
        private const decimal EuroChange = 0.511292M;

        public static void Main(string[] args)
        {
            decimal priceLeva;
            while (!decimal.TryParse(Console.ReadLine(), out priceLeva))
            {
            }

            Console.WriteLine($@"Price in euro: {priceLeva * EuroChange:0.00}");
        }
    }
}