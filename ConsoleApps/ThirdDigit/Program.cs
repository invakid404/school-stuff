using System;

namespace ThirdDigit
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }

            Console.WriteLine($@"Third digit {(n / 100 % 10 == 7 ? "is" : "is not")} equal to 7");
        }
    }
}