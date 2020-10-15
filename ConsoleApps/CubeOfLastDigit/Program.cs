using System;

namespace CubeOfLastDigit
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
            }

            var res = (int) Math.Pow(n % 10, 3);
            Console.WriteLine(res);
        }
    }
}